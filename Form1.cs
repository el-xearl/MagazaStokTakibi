namespace MagazaStokTakibi
{
    public partial class Form1 : Form
    {
        private Inventory inventory = new Inventory(); // <<< BU EKLENECEK

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void UpdateProductList()
        {
            lstProducts.Items.Clear(); // Önce listeyi temizle
            foreach (var product in inventory.Products)
            {
                lstProducts.Items.Add(product); // Her ürünü ekle
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //textbox dan ürün adýný alýoruz
            string name = txtName.Text;

            // TextBox'tan stok miktarýný alýyoruz ve int'e çevirmeye çalýþýyoruz
            // Eðer çevirme baþarýsýz olursa kullanýcýya uyarý veriyoruz ve metodu durduruyoruz
            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Stok Geçerli Deðil! Lütfen Sayýsal Bir Deðer Girin.");
                return;//Hatalý Giriþte Buradan Çýkýyoruz
            }

            // TextBox'tan fiyat bilgisini alýyoruz ve decimal'e çevirmeye çalýþýyoruz
            // Eðer çevirme baþarýsýz olursa kullanýcýya uyarý veriyoruz ve metodu durduruyoruz
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Fiyat Geçerli Deðil! Lütfen Sayýsal Bir Deðer Girin.");
                return;// Hatalý giriþte buradan çýkýyoruz
            }

            //Product sýnýfýndan yeni bir ürün nesnesi oluþturuyoruz
            // Constructor: Product(string name, int stock, decimal price)
            Product p = new Product(name, stock, price);

            // Oluþturduðumuz ürünü Inventory sýnýfýndaki Products listesine ekliyoruz
            inventory.AddProduct(p);

            // ListBox'ý güncellemek için UpdateProductList metodunu çaðýrýyoruz
            UpdateProductList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem is Product selected)
            {
                inventory.RemoveProduct(selected);
                UpdateProductList();
            }

            else
            {
                //eðer ürün seçilmemiþse kullanýcýya uyarý gösteriyoruz
                MessageBox.Show("Önce Bir Ürün Seçin!");

            }
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            {
                // ListBox'ta seçili bir ürün var mý kontrol ediyoruz
                if (lstProducts.SelectedItem is Product selected)
                {
                    // Seçili ürünün stok miktarýný 1 artýrýyoruz
                    inventory.IncreaseStock(selected, 1);

                    // ListBox'ý güncellemek için UpdateProductList metodunu çaðýrýyoruz
                    UpdateProductList();
                }
            }
        }


        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem is Product selected)
            {
            inventory.DecreaseStock(selected, 1);
            UpdateProductList();
            }
            

        }
    }
}
