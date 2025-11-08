namespace MagazaStokTakibi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblStock = new Label();
            lblPrice = new Label();
            txtName = new TextBox();
            txtStock = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnIncrease = new Button();
            btnDecrease = new Button();
            lstProducts = new ListBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 15);
            lblName.TabIndex = 0;
            lblName.Text = "ÜrünAdı:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(20, 60);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(33, 15);
            lblStock.TabIndex = 1;
            lblStock.Text = "Stok:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(20, 100);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(35, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Fiyat:";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(120, 60);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(120, 100);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(120, 140);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Ürün Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(220, 140);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Ürün Sil";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnIncrease
            // 
            btnIncrease.Location = new Point(320, 140);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(75, 23);
            btnIncrease.TabIndex = 8;
            btnIncrease.Text = "Stok Arttır";
            btnIncrease.UseVisualStyleBackColor = true;
            btnIncrease.Click += btnIncrease_Click;
            // 
            // btnDecrease
            // 
            btnDecrease.Location = new Point(420, 140);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(75, 23);
            btnDecrease.TabIndex = 9;
            btnDecrease.Text = "Stok Azalt";
            btnDecrease.UseVisualStyleBackColor = true;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 15;
            lstProducts.Location = new Point(20, 200);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(550, 139);
            lstProducts.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(584, 361);
            Controls.Add(lstProducts);
            Controls.Add(btnDecrease);
            Controls.Add(btnIncrease);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtStock);
            Controls.Add(txtName);
            Controls.Add(lblPrice);
            Controls.Add(lblStock);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblStock;
        private Label lblPrice;
        private TextBox txtName;
        private TextBox txtStock;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnIncrease;
        private Button btnDecrease;
        private ListBox lstProducts;
    }
}
