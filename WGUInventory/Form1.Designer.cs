namespace WGUInventory
{
    partial class HomeForm
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
            ProdsSearchBar = new TextBox();
            ProdsSearchButton = new Button();
            PartsSearchBar = new TextBox();
            PartsSearchButton = new Button();
            Header = new Label();
            PartsLabel = new Label();
            ProductsLabel = new Label();
            PartsGrid = new DataGridView();
            ProductsGrid = new DataGridView();
            PartsAdd = new Button();
            ProdsAdd = new Button();
            PartsMod = new Button();
            ProdsMod = new Button();
            PartsDelete = new Button();
            ProdsDelete = new Button();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PartsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGrid).BeginInit();
            SuspendLayout();
            // 
            // ProdsSearchBar
            // 
            ProdsSearchBar.Location = new Point(718, 43);
            ProdsSearchBar.Name = "ProdsSearchBar";
            ProdsSearchBar.Size = new Size(279, 31);
            ProdsSearchBar.TabIndex = 0;
            ProdsSearchBar.KeyPress += ProdsSearchBar_KeyPress;
            // 
            // ProdsSearchButton
            // 
            ProdsSearchButton.Location = new Point(1003, 39);
            ProdsSearchButton.Name = "ProdsSearchButton";
            ProdsSearchButton.Size = new Size(101, 39);
            ProdsSearchButton.TabIndex = 1;
            ProdsSearchButton.Text = "Search";
            ProdsSearchButton.UseVisualStyleBackColor = true;
            ProdsSearchButton.Click += ProdsSearchButton_Click;
            // 
            // PartsSearchBar
            // 
            PartsSearchBar.Location = new Point(174, 47);
            PartsSearchBar.Name = "PartsSearchBar";
            PartsSearchBar.Size = new Size(279, 31);
            PartsSearchBar.TabIndex = 2;
            PartsSearchBar.KeyPress += PartsSearchBar_KeyPress;
            // 
            // PartsSearchButton
            // 
            PartsSearchButton.Location = new Point(459, 43);
            PartsSearchButton.Name = "PartsSearchButton";
            PartsSearchButton.Size = new Size(101, 39);
            PartsSearchButton.TabIndex = 3;
            PartsSearchButton.Text = "Search";
            PartsSearchButton.UseVisualStyleBackColor = true;
            PartsSearchButton.Click += PartsSearchButton_Click;
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Location = new Point(12, 9);
            Header.Name = "Header";
            Header.Size = new Size(259, 25);
            Header.TabIndex = 4;
            Header.Text = "Inventory Management System";
            // 
            // PartsLabel
            // 
            PartsLabel.AutoSize = true;
            PartsLabel.Location = new Point(118, 53);
            PartsLabel.Name = "PartsLabel";
            PartsLabel.Size = new Size(50, 25);
            PartsLabel.TabIndex = 5;
            PartsLabel.Text = "Parts";
            // 
            // ProductsLabel
            // 
            ProductsLabel.AutoSize = true;
            ProductsLabel.Location = new Point(630, 49);
            ProductsLabel.Name = "ProductsLabel";
            ProductsLabel.Size = new Size(82, 25);
            ProductsLabel.TabIndex = 6;
            ProductsLabel.Text = "Products";
            // 
            // PartsGrid
            // 
            PartsGrid.AllowUserToAddRows = false;
            PartsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            PartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsGrid.Location = new Point(30, 112);
            PartsGrid.Name = "PartsGrid";
            PartsGrid.ReadOnly = true;
            PartsGrid.RowHeadersWidth = 62;
            PartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PartsGrid.Size = new Size(530, 225);
            PartsGrid.TabIndex = 7;
            // 
            // ProductsGrid
            // 
            ProductsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            ProductsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsGrid.Location = new Point(637, 112);
            ProductsGrid.Name = "ProductsGrid";
            ProductsGrid.ReadOnly = true;
            ProductsGrid.RowHeadersWidth = 62;
            ProductsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsGrid.Size = new Size(527, 225);
            ProductsGrid.TabIndex = 8;
            // 
            // PartsAdd
            // 
            PartsAdd.Location = new Point(286, 355);
            PartsAdd.Name = "PartsAdd";
            PartsAdd.Size = new Size(71, 34);
            PartsAdd.TabIndex = 9;
            PartsAdd.Text = "Add";
            PartsAdd.UseVisualStyleBackColor = true;
            PartsAdd.Click += PartsAdd_Click;
            // 
            // ProdsAdd
            // 
            ProdsAdd.Location = new Point(830, 355);
            ProdsAdd.Name = "ProdsAdd";
            ProdsAdd.Size = new Size(71, 34);
            ProdsAdd.TabIndex = 10;
            ProdsAdd.Text = "Add";
            ProdsAdd.UseVisualStyleBackColor = true;
            ProdsAdd.Click += ProdsAdd_Click;
            // 
            // PartsMod
            // 
            PartsMod.Location = new Point(363, 355);
            PartsMod.Name = "PartsMod";
            PartsMod.Size = new Size(90, 34);
            PartsMod.TabIndex = 11;
            PartsMod.Text = "Modify";
            PartsMod.UseVisualStyleBackColor = true;
            PartsMod.Click += PartsMod_Click;
            // 
            // ProdsMod
            // 
            ProdsMod.Location = new Point(907, 355);
            ProdsMod.Name = "ProdsMod";
            ProdsMod.Size = new Size(90, 34);
            ProdsMod.TabIndex = 12;
            ProdsMod.Text = "Modify";
            ProdsMod.UseVisualStyleBackColor = true;
            ProdsMod.Click += ProdsMod_Click;
            // 
            // PartsDelete
            // 
            PartsDelete.Location = new Point(459, 355);
            PartsDelete.Name = "PartsDelete";
            PartsDelete.Size = new Size(112, 34);
            PartsDelete.TabIndex = 13;
            PartsDelete.Text = "Delete";
            PartsDelete.UseVisualStyleBackColor = true;
            PartsDelete.Click += PartsDelete_Click;
            // 
            // ProdsDelete
            // 
            ProdsDelete.Location = new Point(1003, 355);
            ProdsDelete.Name = "ProdsDelete";
            ProdsDelete.Size = new Size(112, 34);
            ProdsDelete.TabIndex = 14;
            ProdsDelete.Text = "Delete";
            ProdsDelete.UseVisualStyleBackColor = true;
            ProdsDelete.Click += ProdsDelete_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(1052, 402);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 34);
            ExitButton.TabIndex = 15;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 448);
            Controls.Add(ExitButton);
            Controls.Add(ProdsDelete);
            Controls.Add(PartsDelete);
            Controls.Add(ProdsMod);
            Controls.Add(PartsMod);
            Controls.Add(ProdsAdd);
            Controls.Add(PartsAdd);
            Controls.Add(ProductsGrid);
            Controls.Add(PartsGrid);
            Controls.Add(ProductsLabel);
            Controls.Add(PartsLabel);
            Controls.Add(Header);
            Controls.Add(PartsSearchButton);
            Controls.Add(PartsSearchBar);
            Controls.Add(ProdsSearchButton);
            Controls.Add(ProdsSearchBar);
            Name = "HomeForm";
            Text = "Home";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PartsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ProdsSearchBar;
        private Button ProdsSearchButton;
        private TextBox PartsSearchBar;
        private Button PartsSearchButton;
        private Label Header;
        private Label PartsLabel;
        private Label ProductsLabel;
        private DataGridView PartsGrid;
        private DataGridView ProductsGrid;
        private Button PartsAdd;
        private Button ProdsAdd;
        private Button PartsMod;
        private Button ProdsMod;
        private Button PartsDelete;
        private Button ProdsDelete;
        private Button ExitButton;
    }
}
