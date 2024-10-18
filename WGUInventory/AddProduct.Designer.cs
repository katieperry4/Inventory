namespace WGUInventory
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddProductLabel = new Label();
            SearchBar = new TextBox();
            SearchButton = new Button();
            AllPartsLabel = new Label();
            PartsGrid = new DataGridView();
            AddPartButton = new Button();
            DeletePartButton = new Button();
            AssPartsGrid = new DataGridView();
            PartsAssLabel = new Label();
            SaveButton = new Button();
            CancelButton = new Button();
            IDLabel = new Label();
            IDText = new TextBox();
            NameLabel = new Label();
            NameText = new TextBox();
            InventoryLabel = new Label();
            InventoryText = new TextBox();
            PriceLabel = new Label();
            PriceText = new TextBox();
            MaxText = new TextBox();
            MaxLabel = new Label();
            MinText = new TextBox();
            MinLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)PartsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AssPartsGrid).BeginInit();
            SuspendLayout();
            // 
            // AddProductLabel
            // 
            AddProductLabel.AutoSize = true;
            AddProductLabel.Location = new Point(104, 30);
            AddProductLabel.Name = "AddProductLabel";
            AddProductLabel.Size = new Size(113, 25);
            AddProductLabel.TabIndex = 0;
            AddProductLabel.Text = "Add Product";
            // 
            // SearchBar
            // 
            SearchBar.Location = new Point(766, 30);
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(284, 31);
            SearchBar.TabIndex = 2;
            SearchBar.KeyPress += SearchBar_KeyPress;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(648, 30);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(112, 34);
            SearchButton.TabIndex = 3;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // AllPartsLabel
            // 
            AllPartsLabel.AutoSize = true;
            AllPartsLabel.Location = new Point(462, 66);
            AllPartsLabel.Name = "AllPartsLabel";
            AllPartsLabel.Size = new Size(159, 25);
            AllPartsLabel.TabIndex = 4;
            AllPartsLabel.Text = "All candidate parts";
            // 
            // PartsGrid
            // 
            PartsGrid.AllowUserToAddRows = false;
            PartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsGrid.Location = new Point(462, 94);
            PartsGrid.Name = "PartsGrid";
            PartsGrid.RowHeadersWidth = 62;
            PartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PartsGrid.Size = new Size(643, 182);
            PartsGrid.TabIndex = 5;
            // 
            // AddPartButton
            // 
            AddPartButton.Location = new Point(982, 285);
            AddPartButton.Name = "AddPartButton";
            AddPartButton.Size = new Size(112, 34);
            AddPartButton.TabIndex = 6;
            AddPartButton.Text = "Add";
            AddPartButton.UseVisualStyleBackColor = true;
            AddPartButton.Click += AddPartButton_Click;
            // 
            // DeletePartButton
            // 
            DeletePartButton.Location = new Point(982, 541);
            DeletePartButton.Name = "DeletePartButton";
            DeletePartButton.Size = new Size(112, 34);
            DeletePartButton.TabIndex = 9;
            DeletePartButton.Text = "Delete";
            DeletePartButton.UseVisualStyleBackColor = true;
            DeletePartButton.Click += DeletePartButton_Click;
            // 
            // AssPartsGrid
            // 
            AssPartsGrid.AllowUserToAddRows = false;
            AssPartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AssPartsGrid.Location = new Point(462, 350);
            AssPartsGrid.Name = "AssPartsGrid";
            AssPartsGrid.RowHeadersWidth = 62;
            AssPartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AssPartsGrid.Size = new Size(643, 182);
            AssPartsGrid.TabIndex = 8;
            // 
            // PartsAssLabel
            // 
            PartsAssLabel.AutoSize = true;
            PartsAssLabel.Location = new Point(462, 322);
            PartsAssLabel.Name = "PartsAssLabel";
            PartsAssLabel.Size = new Size(277, 25);
            PartsAssLabel.TabIndex = 7;
            PartsAssLabel.Text = "Parts associated with this product";
            // 
            // SaveButton
            // 
            SaveButton.Enabled = false;
            SaveButton.Location = new Point(754, 604);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(112, 34);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(884, 605);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(112, 34);
            CancelButton.TabIndex = 11;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(40, 94);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(30, 25);
            IDLabel.TabIndex = 12;
            IDLabel.Text = "ID";
            // 
            // IDText
            // 
            IDText.Enabled = false;
            IDText.Location = new Point(141, 94);
            IDText.Name = "IDText";
            IDText.Size = new Size(150, 31);
            IDText.TabIndex = 13;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(40, 158);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(59, 25);
            NameLabel.TabIndex = 14;
            NameLabel.Text = "Name";
            // 
            // NameText
            // 
            NameText.Location = new Point(141, 158);
            NameText.Name = "NameText";
            NameText.Size = new Size(241, 31);
            NameText.TabIndex = 15;
            NameText.TextChanged += NameText_TextChanged;
            // 
            // InventoryLabel
            // 
            InventoryLabel.AutoSize = true;
            InventoryLabel.Location = new Point(40, 226);
            InventoryLabel.Name = "InventoryLabel";
            InventoryLabel.Size = new Size(87, 25);
            InventoryLabel.TabIndex = 16;
            InventoryLabel.Text = "Inventory";
            // 
            // InventoryText
            // 
            InventoryText.Location = new Point(141, 226);
            InventoryText.Name = "InventoryText";
            InventoryText.Size = new Size(241, 31);
            InventoryText.TabIndex = 17;
            InventoryText.TextChanged += InventoryText_TextChanged;
            InventoryText.KeyPress += InventoryText_KeyPress;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(40, 290);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(49, 25);
            PriceLabel.TabIndex = 18;
            PriceLabel.Text = "Price";
            // 
            // PriceText
            // 
            PriceText.Location = new Point(141, 290);
            PriceText.Name = "PriceText";
            PriceText.Size = new Size(241, 31);
            PriceText.TabIndex = 19;
            PriceText.TextChanged += PriceText_TextChanged;
            PriceText.KeyPress += PriceText_KeyPress;
            // 
            // MaxText
            // 
            MaxText.Location = new Point(104, 371);
            MaxText.Name = "MaxText";
            MaxText.Size = new Size(94, 31);
            MaxText.TabIndex = 21;
            MaxText.TextChanged += MaxText_TextChanged;
            MaxText.KeyPress += MaxText_KeyPress;
            // 
            // MaxLabel
            // 
            MaxLabel.AutoSize = true;
            MaxLabel.Location = new Point(50, 371);
            MaxLabel.Name = "MaxLabel";
            MaxLabel.Size = new Size(45, 25);
            MaxLabel.TabIndex = 20;
            MaxLabel.Text = "Max";
            // 
            // MinText
            // 
            MinText.Location = new Point(288, 371);
            MinText.Name = "MinText";
            MinText.Size = new Size(94, 31);
            MinText.TabIndex = 23;
            MinText.TextChanged += MinText_TextChanged;
            MinText.KeyPress += MinText_KeyPress;
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Location = new Point(234, 371);
            MinLabel.Name = "MinLabel";
            MinLabel.Size = new Size(42, 25);
            MinLabel.TabIndex = 22;
            MinLabel.Text = "Min";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 651);
            Controls.Add(MinText);
            Controls.Add(MinLabel);
            Controls.Add(MaxText);
            Controls.Add(MaxLabel);
            Controls.Add(PriceText);
            Controls.Add(PriceLabel);
            Controls.Add(InventoryText);
            Controls.Add(InventoryLabel);
            Controls.Add(NameText);
            Controls.Add(NameLabel);
            Controls.Add(IDText);
            Controls.Add(IDLabel);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(DeletePartButton);
            Controls.Add(AssPartsGrid);
            Controls.Add(PartsAssLabel);
            Controls.Add(AddPartButton);
            Controls.Add(PartsGrid);
            Controls.Add(AllPartsLabel);
            Controls.Add(SearchButton);
            Controls.Add(SearchBar);
            Controls.Add(AddProductLabel);
            Name = "AddProduct";
            Text = "AddProduct";
            Load += AddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)PartsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AssPartsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddProductLabel;
        private TextBox SearchBar;
        private Button SearchButton;
        private Label AllPartsLabel;
        private DataGridView PartsGrid;
        private Button AddPartButton;
        private Button DeletePartButton;
        private DataGridView AssPartsGrid;
        private Label PartsAssLabel;
        private Button SaveButton;
        private Button CancelButton;
        private Label IDLabel;
        private TextBox IDText;
        private Label NameLabel;
        private TextBox NameText;
        private Label InventoryLabel;
        private TextBox InventoryText;
        private Label PriceLabel;
        private TextBox PriceText;
        private TextBox MaxText;
        private Label MaxLabel;
        private TextBox MinText;
        private Label MinLabel;
    }
}