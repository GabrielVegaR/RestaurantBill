namespace RestaurantBill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            lstQuantity.Items.Add(txtQuantity.Text);
            lstMenuItems.Items.Add(txtMenuItems.Text);
            lstPrice.Items.Add(txtPrice.Text);

            txtMenuItems.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }

        private void BtnTotalBill_Click(object sender, EventArgs e)
        {
            //int quantity = Convert.ToInt32(txtQuantity);
            //int price = Convert.ToInt32(txtPrice);
            int contador = 0;

            int resultado = 0;


            do
            {
                int total1 = Convert.ToInt32(lstQuantity.Items[contador]);
                int total2 = Convert.ToInt32(lstPrice.Items[contador]);

                resultado += total1 * total2; 

                contador++;

            } while (contador < lstQuantity.Items.Count);


            lblTotalCost.Text = resultado.ToString();


        }
    }
}