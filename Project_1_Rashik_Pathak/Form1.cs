namespace Project_1_Rashik_Pathak
{
   
    public enum Category { Coffee, Tea, Pastry, Sandwich }
    //Enum allows fixed quantity of options in the menu

    // Enum allows 3 fixed sizes of drinks. 
    public enum CupSize { Small, Medium, Large } // in array
    //cup size holds 3 values


    public struct MenuProduct //struct is baseline as class
    {
        public string Name;
        public Category Category;
        public decimal BasePrice;

        public MenuProduct(string name, Category category, decimal basePrice) // parameterized 
            //constructor
        {
            Name = name;
            Category = category;
            BasePrice = basePrice;
        }

        //to make sure only coffe and drinks come in sizes. 
        public bool IsDrink() //if its a drink
        {
            return Category == Category.Coffee || Category == Category.Tea; // Tea or coffee
        }
    }

    public struct OrderLine
    {
        public MenuProduct Item;
        public CupSize Size;
        public int Quantity;
        public decimal UnitPrice;

        public OrderLine(MenuProduct item, CupSize size, int quantity, decimal unitPrice)
        {
            Item = item; //constructor
            Size = size;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public decimal LineTotal
        {
            get { return UnitPrice * Quantity; } //total is quantity *n individual price
        }

        // Text shown in the order ListBox
        public override string ToString()
        {
            string sizeText = Item.IsDrink() ? " (" + Size + ")" : "";
            return $"{Quantity} x {Item.Name}{sizeText} - ${LineTotal:F2}";
        }
    }

    public partial class Form1 : Form
    {
        private readonly string menuPath = Path.Combine(AppContext.BaseDirectory, "Menu.txt"); // read menu from Menu.txt
        private readonly string historyPath = Path.Combine(AppContext.BaseDirectory, "OrderHistory.txt");

        // Dictionary: fast lookup of a menu item by its name
        private Dictionary<string, MenuProduct> menu = new Dictionary<string, MenuProduct>();

        // List: the customer's current order
        private List<OrderLine> currentOrder = new List<OrderLine>();

        // List: summary lines of completed orders (saved to file on close)
        private List<string> orderHistory = new List<string>();

        // Dictionary: total sales per category this session
        private Dictionary<Category, decimal> salesByCategory = new Dictionary<Category, decimal>();

        // Array: size surcharge, indexed by (int)CupSize -> Small, Medium, Large
        private readonly decimal[] sizeSurcharge = { 0.00m, 0.50m, 1.00m };

        // Array is used here to handle some cases when Menu.Txt is not found to acvoid
        //program crash or failure. 
        private readonly MenuProduct[] defaultMenu =
        {
            new MenuProduct("Espresso", Category.Coffee, 3.00m),
            new MenuProduct("Latte", Category.Coffee, 4.25m),
            new MenuProduct("Green Tea", Category.Tea, 2.75m),
            new MenuProduct("Croissant", Category.Pastry, 3.25m),
            new MenuProduct("Turkey Sandwich", Category.Sandwich, 6.50m)
        };

        private const decimal ExtraShotPrice = 0.75m;
        private const decimal WhippedCreamPrice = 0.50m;
        private const decimal OatMilkPrice = 0.60m;

        public Form1()
        {
            InitializeComponent();
        }

        //FILE HANDLING 

        private void Form1_Load(object sender, EventArgs e)
        {
            //Every catagory starts ai $0.00
            foreach (Category category in Enum.GetValues(typeof(Category))) //loop
            {
                salesByCategory[category] = 0m;
            }

            LoadMenu();
            LoadHistory();
            UpdateRunningTotal();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                File.WriteAllLines(historyPath, orderHistory); //try this but if it fails
            }
            catch (IOException) //caatch the reason and display it for clarity. 
            //try catch. error handling 
            {
                MessageBox.Show("Could not save the order history.", "Save Error");
            }
        }

        //In order to read whats in our menu.txt
        private void LoadMenu()
        {
            menu.Clear();
            cboMenu.Items.Clear();

            if (!File.Exists(menuPath)) // when does not exist
            {
                MessageBox.Show(
                    "Menu.txt was not found. Using the default menu.",
                    "File Not Found"); //displau the reason

                foreach (MenuProduct product in defaultMenu)
                {
                    AddMenuProduct(product); //function call
                }
                return;
            }

            foreach (string line in File.ReadAllLines(menuPath))
            {
                string[] parts = line.Split(',');

                if (parts.Length != 3)
                    continue;   //to skip empty spaces

                if (Enum.TryParse(parts[1].Trim(), out Category category) &&
                    decimal.TryParse(parts[2].Trim(), out decimal price))
                {
                    AddMenuProduct(new MenuProduct(parts[0].Trim(), category, price));
                }
            }
        }

        private void AddMenuProduct(MenuProduct product)
        {
            if (menu.ContainsKey(product.Name))
                return;   // to avoid  duplicate names

            menu[product.Name] = product;
            cboMenu.Items.Add(product.Name);
        }

        private void LoadHistory()//to display the recent order in the box
        {
            if (!File.Exists(historyPath))
                return;

            foreach (string line in File.ReadAllLines(historyPath))
            {
                if (line.Trim() != "")
                {
                    orderHistory.Add(line);
                    lstHistory.Items.Add(line);
                }
            }
        }
        //Name of the customer

        private void btnDisplayName_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            if (firstName == "" || lastName == "") // when names are empty 
            {
                MessageBox.Show("Please enter a first and last name.", "Missing Name");
                return;
            }

            string fullName = firstName + " " + lastName;
            lblCustomerName.Text = "Customer: " + fullName;
        }


        //Presssing enter also add the items from combpo box to order
        private void cboMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.SuppressKeyPress = true;
            btnAddItem.PerformClick();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cboMenu.SelectedItem == null)
            {
                MessageBox.Show("Please select a menu item first.", "No Item Selected");
                return;
            }

            string itemName = cboMenu.SelectedItem.ToString() ?? "";
            MenuProduct product = menu[itemName];
            CupSize size = GetSelectedSize();
            int quantity = (int)nudQuantity.Value;

            //SInce extra charges technically only appplies to drink 
            decimal unitPrice = product.BasePrice;
            if (product.IsDrink())
            {
                unitPrice += sizeSurcharge[(int)size];
            }

            currentOrder.Add(new OrderLine(product, size, quantity, unitPrice));

            RefreshOrderList();
            nudQuantity.Value = 1;
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to remove.", "No Item Selected");
                return; //when remove button is pressed without anything to remove
            }

            currentOrder.RemoveAt(lstOrder.SelectedIndex);
            RefreshOrderList();
        }

        private CupSize GetSelectedSize()
        {
            if (rdoSmall.Checked) return CupSize.Small;
            if (rdoLarge.Checked) return CupSize.Large;
            return CupSize.Medium;
        }

        private void RefreshOrderList()
        {
            lstOrder.Items.Clear();

            foreach (OrderLine line in currentOrder)
            {
                lstOrder.Items.Add(line.ToString());
            }

            UpdateRunningTotal();
        }

        private decimal GetItemsTotal()
        {
            decimal total = 0m;

            foreach (OrderLine line in currentOrder)
            {
                total += line.LineTotal;
            }

            return total;
        }

        private void UpdateRunningTotal()
        {
            lblRunningTotal.Text = $"Items Total: ${GetItemsTotal():F2}";
        }

        //CHeckout

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!lblCustomerName.Text.StartsWith("Customer:"))//When name is missing
            {
                MessageBox.Show("Please enter and display the customer name first.", "Missing Name");
                return;
            }

            if (currentOrder.Count == 0) //Nothing is ordered
            {
                MessageBox.Show("Your order is empty.", "Empty Order");
                return;
            }

            decimal itemsTotal = GetItemsTotal();

            //Extra addons
            decimal extrasTotal = 0m;
            string extras = "";

            if (chkExtraShot.Checked)
            {
                extrasTotal += ExtraShotPrice;
                extras += "Extra Shot - $0.75\n";
            }
            if (chkWhippedCream.Checked)
            {
                extrasTotal += WhippedCreamPrice;
                extras += "Whipped Cream - $0.50\n";
            }
            if (chkOatMilk.Checked)
            {
                extrasTotal += OatMilkPrice;
                extras += "Oat Milk - $0.60\n";
            }

            //to handle service time if it is dine in or service charge 
            decimal beforeFee = itemsTotal + extrasTotal;
            decimal deliveryFee = 0m;
            string serviceType = "Dine In";

            if (rdoDelivery.Checked)
            {
                serviceType = "Delivery";
                deliveryFee = 3.00m; //$3.00 delievery fee
            }
            else if (rdoFreeDelivery.Checked)
            {
                if (beforeFee > 20.00m)
                {
                    serviceType = "Free Delivery"; //When order is Greater then $20.00
                }
                else
                {
                    MessageBox.Show(
                        "Free delivery is only available for orders over $20.",
                        "Delivery");
                    return;
                }
            }

            // Promo code / Voucher
            decimal subtotal = beforeFee + deliveryFee;
            decimal discount = 0m;

            if (txtPromo.Text.Trim().ToUpper() == "UCOCAFE10")
            {
                discount = subtotal * 0.10m; //10% discount
            }

            decimal total = subtotal - discount;
            //substraction of discount from the total price. 

            //Build the summary orentation// The summary look is based on this 
            string summary = "ORDER SUMMARY\n========================\n\n";
            summary += lblCustomerName.Text + "\n\nItems:\n";

            foreach (OrderLine line in currentOrder)
            {
                summary += line + "\n";
            }

            summary += "\nExtras:\n" + (extras == "" ? "None\n" : extras);
            summary += "\nService: " + serviceType + "\n";
            summary += "\n------------------------\n";
            summary += $"Items Total: ${itemsTotal:F2}\n";
            summary += $"Extras Total: ${extrasTotal:F2}\n";
            summary += $"Delivery: ${deliveryFee:F2}\n";
            summary += $"Promo Discount: -${discount:F2}\n";
            summary += $"Total Cost: ${total:F2}\n\n";
            summary += "Is this your final order?";

            DialogResult result = MessageBox.Show(
                summary,
                "Order Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Dictionary: add each line's total to its category
                foreach (OrderLine line in currentOrder)
                {
                    salesByCategory[line.Item.Category] += line.LineTotal;
                }

                string historyLine =
                    $"{DateTime.Now:g} | {lblCustomerName.Text.Replace("Customer: ", "")} | ${total:F2}";
                orderHistory.Add(historyLine);
                lstHistory.Items.Add(historyLine);

                ResetForm();
                MessageBox.Show("Thank you for your order!", "Order Complete");
            }
        }



        //report and abount page

        private void btnShowSales_Click(object sender, EventArgs e)
        {
            string report = "SALES BY CATEGORY (this session)\n\n";

            foreach (KeyValuePair<Category, decimal> pair in salesByCategory)
            {
                report += $"{pair.Key}: ${pair.Value:F2}\n";
            }

            MessageBox.Show(report, "Sales Report");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "UCOCampus Cafe\u00e9 serves fresh coffee, tea, pastries, and sandwiches. " +
                "Use promo code UCOCAFE10 for 10% off your order.",
                "About Us");
        }



        private void ResetForm() //Reset everything
        {
            currentOrder.Clear();
            RefreshOrderList();

            txtFirstName.Clear();
            txtLastName.Clear();
            lblCustomerName.Text = "Customer: (not set)";

            cboMenu.SelectedIndex = -1;
            nudQuantity.Value = 1;
            rdoMedium.Checked = true;

            chkExtraShot.Checked = false;
            chkWhippedCream.Checked = false;
            chkOatMilk.Checked = false;

            rdoDineIn.Checked = true;
            txtPromo.Clear();
        }

        private void cafe_Logo_(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "")
            {
                cafe_Logo.Visible = false;
            }
        }
    }
}