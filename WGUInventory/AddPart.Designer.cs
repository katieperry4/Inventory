
namespace WGUInventory
{
    partial class AddPart
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
            AddPartLabel = new Label();
            InHouseRadio = new RadioButton();
            OutsourcedRadio = new RadioButton();
            IDLabel = new Label();
            IDText = new TextBox();
            NameLabel = new Label();
            NameText = new TextBox();
            InventoryText = new TextBox();
            InventoryLabel = new Label();
            PriceLabel = new Label();
            PriceText = new TextBox();
            MaxLabel = new Label();
            MaxText = new TextBox();
            MinText = new TextBox();
            MinLabel = new Label();
            MachineIDLabel = new Label();
            MachineIDText = new TextBox();
            CompanyNameText = new TextBox();
            CompanyLabel = new Label();
            SaveButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // AddPartLabel
            // 
            AddPartLabel.AutoSize = true;
            AddPartLabel.Location = new Point(207, 30);
            AddPartLabel.Name = "AddPartLabel";
            AddPartLabel.Size = new Size(81, 25);
            AddPartLabel.TabIndex = 0;
            AddPartLabel.Text = "Add Part";
            // 
            // InHouseRadio
            // 
            InHouseRadio.AutoSize = true;
            InHouseRadio.Location = new Point(366, 30);
            InHouseRadio.Name = "InHouseRadio";
            InHouseRadio.Size = new Size(110, 29);
            InHouseRadio.TabIndex = 1;
            InHouseRadio.TabStop = true;
            InHouseRadio.Text = "In-House";
            InHouseRadio.UseVisualStyleBackColor = true;
            InHouseRadio.CheckedChanged += InHouseRadio_CheckedChanged;
            // 
            // OutsourcedRadio
            // 
            OutsourcedRadio.AutoSize = true;
            OutsourcedRadio.Location = new Point(547, 30);
            OutsourcedRadio.Name = "OutsourcedRadio";
            OutsourcedRadio.Size = new Size(130, 29);
            OutsourcedRadio.TabIndex = 2;
            OutsourcedRadio.TabStop = true;
            OutsourcedRadio.Text = "Outsourced";
            OutsourcedRadio.UseVisualStyleBackColor = true;
            OutsourcedRadio.CheckedChanged += OutsourcedRadio_CheckedChanged;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(378, 97);
            IDLabel.Name = "IDLabel";
            IDLabel.RightToLeft = RightToLeft.No;
            IDLabel.Size = new Size(30, 25);
            IDLabel.TabIndex = 3;
            IDLabel.Text = "ID";
            // 
            // IDText
            // 
            IDText.Enabled = false;
            IDText.Location = new Point(427, 94);
            IDText.Name = "IDText";
            IDText.Size = new Size(150, 31);
            IDText.TabIndex = 4;
            IDText.TextChanged += IDText_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(349, 143);
            NameLabel.Name = "NameLabel";
            NameLabel.RightToLeft = RightToLeft.No;
            NameLabel.Size = new Size(59, 25);
            NameLabel.TabIndex = 5;
            NameLabel.Text = "Name";
            // 
            // NameText
            // 
            NameText.Location = new Point(427, 143);
            NameText.Name = "NameText";
            NameText.Size = new Size(235, 31);
            NameText.TabIndex = 6;
            NameText.TextChanged += NameText_TextChanged;
            // 
            // InventoryText
            // 
            InventoryText.Location = new Point(427, 193);
            InventoryText.Name = "InventoryText";
            InventoryText.Size = new Size(235, 31);
            InventoryText.TabIndex = 7;
            InventoryText.TextChanged += InventoryText_TextChanged;
            InventoryText.KeyPress += InventoryText_KeyPress;
            // 
            // InventoryLabel
            // 
            InventoryLabel.AutoSize = true;
            InventoryLabel.Location = new Point(330, 196);
            InventoryLabel.Name = "InventoryLabel";
            InventoryLabel.RightToLeft = RightToLeft.No;
            InventoryLabel.Size = new Size(87, 25);
            InventoryLabel.TabIndex = 8;
            InventoryLabel.Text = "Inventory";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(330, 251);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.RightToLeft = RightToLeft.No;
            PriceLabel.Size = new Size(92, 25);
            PriceLabel.TabIndex = 9;
            PriceLabel.Text = "Price/Cost";
    
            // 
            // PriceText
            // 
            PriceText.Location = new Point(427, 245);
            PriceText.Name = "PriceText";
            PriceText.Size = new Size(235, 31);
            PriceText.TabIndex = 10;
            PriceText.TextChanged += PriceText_TextChanged;
            PriceText.KeyPress += PriceText_KeyPress;
            // 
            // MaxLabel
            // 
            MaxLabel.AutoSize = true;
            MaxLabel.Location = new Point(363, 302);
            MaxLabel.Name = "MaxLabel";
            MaxLabel.RightToLeft = RightToLeft.No;
            MaxLabel.Size = new Size(45, 25);
            MaxLabel.TabIndex = 11;
            MaxLabel.Text = "Max";
            // 
            // MaxText
            // 
            MaxText.Location = new Point(427, 296);
            MaxText.Name = "MaxText";
            MaxText.Size = new Size(110, 31);
            MaxText.TabIndex = 12;
            MaxText.TextChanged += MaxText_TextChanged;
            MaxText.KeyPress += MaxText_KeyPress;
            // 
            // MinText
            // 
            MinText.Location = new Point(652, 296);
            MinText.Name = "MinText";
            MinText.Size = new Size(110, 31);
            MinText.TabIndex = 14;
            MinText.TextChanged += MinText_TextChanged;
            MinText.KeyPress += MinText_KeyPress;
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Location = new Point(588, 302);
            MinLabel.Name = "MinLabel";
            MinLabel.RightToLeft = RightToLeft.No;
            MinLabel.Size = new Size(42, 25);
            MinLabel.TabIndex = 13;
            MinLabel.Text = "Min";
            // 
            // MachineIDLabel
            // 
            MachineIDLabel.AutoSize = true;
            MachineIDLabel.Location = new Point(312, 355);
            MachineIDLabel.Name = "MachineIDLabel";
            MachineIDLabel.RightToLeft = RightToLeft.No;
            MachineIDLabel.Size = new Size(96, 25);
            MachineIDLabel.TabIndex = 15;
            MachineIDLabel.Text = "MachineID";
            // 
            // MachineIDText
            // 
            MachineIDText.Location = new Point(427, 352);
            MachineIDText.Name = "MachineIDText";
            MachineIDText.Size = new Size(203, 31);
            MachineIDText.TabIndex = 16;
            MachineIDText.TextChanged += MachineIDText_TextChanged;
            MachineIDText.KeyPress += MachineIDText_KeyPress;
            // 
            // CompanyNameText
            // 
            CompanyNameText.Location = new Point(427, 352);
            CompanyNameText.Name = "CompanyNameText";
            CompanyNameText.Size = new Size(203, 31);
            CompanyNameText.TabIndex = 17;
            CompanyNameText.TextChanged += CompanyNameText_TextChanged;
            // 
            // CompanyLabel
            // 
            CompanyLabel.AutoSize = true;
            CompanyLabel.Location = new Point(267, 358);
            CompanyLabel.Name = "CompanyLabel";
            CompanyLabel.RightToLeft = RightToLeft.No;
            CompanyLabel.Size = new Size(141, 25);
            CompanyLabel.TabIndex = 18;
            CompanyLabel.Text = "Company Name";
            // 
            // SaveButton
            // 
            SaveButton.Enabled = false;
            SaveButton.Location = new Point(565, 413);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(112, 34);
            SaveButton.TabIndex = 19;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(687, 413);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(112, 34);
            CancelButton.TabIndex = 20;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 483);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(CompanyLabel);
            Controls.Add(CompanyNameText);
            Controls.Add(MachineIDText);
            Controls.Add(MachineIDLabel);
            Controls.Add(MinText);
            Controls.Add(MinLabel);
            Controls.Add(MaxText);
            Controls.Add(MaxLabel);
            Controls.Add(PriceText);
            Controls.Add(PriceLabel);
            Controls.Add(InventoryLabel);
            Controls.Add(InventoryText);
            Controls.Add(NameText);
            Controls.Add(NameLabel);
            Controls.Add(IDText);
            Controls.Add(IDLabel);
            Controls.Add(OutsourcedRadio);
            Controls.Add(InHouseRadio);
            Controls.Add(AddPartLabel);
            Name = "AddPart";
            Text = "AddPart";
            Load += AddPart_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label AddPartLabel;
        private RadioButton InHouseRadio;
        private RadioButton OutsourcedRadio;
        private Label IDLabel;
        private TextBox IDText;
        private Label NameLabel;
        private TextBox NameText;
        private TextBox InventoryText;
        private Label InventoryLabel;
        private Label PriceLabel;
        private TextBox PriceText;
        private Label MaxLabel;
        private TextBox MaxText;
        private TextBox MinText;
        private Label MinLabel;
        private Label MachineIDLabel;
        private TextBox MachineIDText;
        private TextBox CompanyNameText;
        private Label CompanyLabel;
        private Button SaveButton;
        private Button CancelButton;
    }
}