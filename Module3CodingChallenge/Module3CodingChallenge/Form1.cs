namespace Module3CodingChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Flavor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Data Source
            string[] descriptions = { "Vanilla ice cream is a classic flavor made with fresh vanilla.",
            "Rocky Road is a chocolate-flavored ice cream with nuts and marshallows.",
            "Strawberry ice cream is made by blending in fresh starwberries.",
            "Mint ice cream is made to taste like mint."
            };

            //Data source for prices
            Dictionary<string, decimal> iceCreamPrices = new Dictionary<string, decimal>()
            {
                { "Vanilla", 2.99m },
                { "Rocky Road", 3.59m },
                { "Strawberry", 3.49m },
                { "Mint", 4.49m }
            };

            //LINQ Query to retrieve the description that starts with the 
            //ice dream flavor that the user chose.
            var myLinqQuery = from description in descriptions
                              where description.StartsWith(Flavor.Text)
                              select description;


            //Query execution 
            foreach (var description in myLinqQuery)
            {
                //Setting the property of the label to the 
                //description from the data collection (array)
                lblDescription.Text = description;
            }//end for loop

            // LINQ Query for price 
            var priceQuery = from price in iceCreamPrices
                             where price.Key == (Flavor.Text)
                             select price;

            //Query execution 
            foreach (var price in priceQuery)
            {
                //Set the value of the prices label to the price from the dictionary
                lblPrice.Text = "$" + price.Value.ToString();
            }//end for the loop
        }

        private void Cookies_SelectedIndexChanged(object sender, EventArgs e)
        {
            // An array holding details for each type of cookie.
            string[] Details = {"Mint Cookies is made to feel refreshing like the ice cream.",
            "Ice Cream Cookies is customer favorite.",
            "Soft Cookies is filled with chocolate."
            };

            // A dictionary mapping types of cookies to their prices.
            Dictionary<string, decimal> cookiesPrices = new Dictionary<string, decimal>()
            {
                {"Mint", 1.50m },
                {"Ice Cream", 2.50m },
                {"Soft", 2.00m}
            };

            // Using LINQ to find the detail that matches the selected type of cookie.
            var myLinqQuery = from detail in Details
                              where detail.StartsWith(Cookies.Text)
                              select detail;

            // Displaying the found detail in a label.
            foreach (var detail in myLinqQuery)
            {
                lblDetails.Text = detail;
            }

            // Using LINQ to find the price that matches the selected type of cookie.
            var priceQuery = from price in cookiesPrices
                             where price.Key == Cookies.Text.Trim()
                             select price;


            // Displaying the found price in a label.
            foreach (var prices in priceQuery)
            {
                lblPrices.Text = "$" + prices.Value.ToString();
            }
                             

        }
    }
}
