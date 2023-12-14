namespace car_management_sys
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxTransmission = new System.Windows.Forms.ComboBox();
            this.comboBoxFuel = new System.Windows.Forms.ComboBox();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.transmission = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.fuel_Type = new System.Windows.Forms.Label();
            this.textBoxMileage = new System.Windows.Forms.TextBox();
            this.purchaed_Date = new System.Windows.Forms.Label();
            this.engine_Cc = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxEngine = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.company = new System.Windows.Forms.Label();
            this.mileage = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxCar = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.car_Id = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addNew = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBoxTransmission);
            this.panel1.Controls.Add(this.comboBoxFuel);
            this.panel1.Controls.Add(this.comboBoxCompany);
            this.panel1.Controls.Add(this.comboBoxColor);
            this.panel1.Controls.Add(this.textBoxDescription);
            this.panel1.Controls.Add(this.transmission);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.fuel_Type);
            this.panel1.Controls.Add(this.textBoxMileage);
            this.panel1.Controls.Add(this.purchaed_Date);
            this.panel1.Controls.Add(this.engine_Cc);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.textBoxEngine);
            this.panel1.Controls.Add(this.textBoxModel);
            this.panel1.Controls.Add(this.company);
            this.panel1.Controls.Add(this.mileage);
            this.panel1.Controls.Add(this.model);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.textBoxCar);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.Color);
            this.panel1.Controls.Add(this.car_Id);
            this.panel1.Location = new System.Drawing.Point(142, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 240);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBoxTransmission
            // 
            this.comboBoxTransmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTransmission.FormattingEnabled = true;
            this.comboBoxTransmission.Items.AddRange(new object[] {
            "Manaul",
            "Automatic"});
            this.comboBoxTransmission.Location = new System.Drawing.Point(1244, 194);
            this.comboBoxTransmission.Name = "comboBoxTransmission";
            this.comboBoxTransmission.Size = new System.Drawing.Size(198, 37);
            this.comboBoxTransmission.TabIndex = 2;
            // 
            // comboBoxFuel
            // 
            this.comboBoxFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.Items.AddRange(new object[] {
            "Gasoline (Petrol)",
            "Diesel",
            "Hybrid",
            "Electric",
            "CNG",
            "LPG"});
            this.comboBoxFuel.Location = new System.Drawing.Point(1244, 138);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(198, 37);
            this.comboBoxFuel.TabIndex = 2;
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Fiat",
            "Ford",
            "Honda",
            "Hyundai",
            "Jaguar",
            "Kia",
            "Lexus",
            "Mazda",
            "Mercedes-Benz",
            "Mitsubishi",
            "Nissan",
            "Porsche",
            "Subaru",
            "Suzuki",
            "Tesla",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.comboBoxCompany.Location = new System.Drawing.Point(1244, 19);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(198, 37);
            this.comboBoxCompany.TabIndex = 2;
            this.comboBoxCompany.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompany_SelectedIndexChanged);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "White",
            "Black",
            "Silver",
            "Gray",
            "Blue",
            "Red",
            "Green",
            "Yellow",
            "Orange",
            "Brown",
            "Beige",
            "Gold",
            "Purple",
            "Pink",
            "Bronze",
            "Burgundy",
            "Turquoise",
            "Charcoal",
            "Maroon",
            "Navy",
            "Teal",
            "Ivory",
            "Cream",
            "Tan",
            "Platinum"});
            this.comboBoxColor.Location = new System.Drawing.Point(1244, 77);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(198, 37);
            this.comboBoxColor.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(173, 199);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(818, 34);
            this.textBoxDescription.TabIndex = 1;
            this.textBoxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // transmission
            // 
            this.transmission.AutoSize = true;
            this.transmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transmission.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.transmission.Location = new System.Drawing.Point(1072, 202);
            this.transmission.Name = "transmission";
            this.transmission.Size = new System.Drawing.Size(170, 29);
            this.transmission.TabIndex = 0;
            this.transmission.Text = "Transmission";
            this.transmission.Click += new System.EventHandler(this.transmission_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.description.Location = new System.Drawing.Point(20, 202);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(146, 29);
            this.description.TabIndex = 0;
            this.description.Text = "Description";
            // 
            // fuel_Type
            // 
            this.fuel_Type.AutoSize = true;
            this.fuel_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuel_Type.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fuel_Type.Location = new System.Drawing.Point(1107, 146);
            this.fuel_Type.Name = "fuel_Type";
            this.fuel_Type.Size = new System.Drawing.Size(131, 29);
            this.fuel_Type.TabIndex = 0;
            this.fuel_Type.Text = "Fuel Type";
            // 
            // textBoxMileage
            // 
            this.textBoxMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMileage.Location = new System.Drawing.Point(173, 80);
            this.textBoxMileage.Name = "textBoxMileage";
            this.textBoxMileage.Size = new System.Drawing.Size(198, 34);
            this.textBoxMileage.TabIndex = 1;
            this.textBoxMileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // purchaed_Date
            // 
            this.purchaed_Date.AutoSize = true;
            this.purchaed_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaed_Date.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.purchaed_Date.Location = new System.Drawing.Point(446, 143);
            this.purchaed_Date.Name = "purchaed_Date";
            this.purchaed_Date.Size = new System.Drawing.Size(74, 29);
            this.purchaed_Date.TabIndex = 0;
            this.purchaed_Date.Text = "Price";
            // 
            // engine_Cc
            // 
            this.engine_Cc.AutoSize = true;
            this.engine_Cc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engine_Cc.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.engine_Cc.Location = new System.Drawing.Point(410, 80);
            this.engine_Cc.Name = "engine_Cc";
            this.engine_Cc.Size = new System.Drawing.Size(138, 29);
            this.engine_Cc.TabIndex = 0;
            this.engine_Cc.Text = "Engine CC";
            this.engine_Cc.Click += new System.EventHandler(this.engine_Cc_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(574, 138);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(417, 34);
            this.textBoxPrice.TabIndex = 1;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxEngine_TextChanged);
            // 
            // textBoxEngine
            // 
            this.textBoxEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEngine.Location = new System.Drawing.Point(574, 77);
            this.textBoxEngine.Name = "textBoxEngine";
            this.textBoxEngine.Size = new System.Drawing.Size(417, 34);
            this.textBoxEngine.TabIndex = 1;
            this.textBoxEngine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEngine.TextChanged += new System.EventHandler(this.textBoxEngine_TextChanged);
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModel.Location = new System.Drawing.Point(173, 138);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(198, 34);
            this.textBoxModel.TabIndex = 1;
            this.textBoxModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.company.Location = new System.Drawing.Point(1103, 22);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(122, 29);
            this.company.TabIndex = 0;
            this.company.Text = "Company";
            this.company.Click += new System.EventHandler(this.company_Click);
            // 
            // mileage
            // 
            this.mileage.AutoSize = true;
            this.mileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mileage.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mileage.Location = new System.Drawing.Point(48, 83);
            this.mileage.Name = "mileage";
            this.mileage.Size = new System.Drawing.Size(107, 29);
            this.mileage.TabIndex = 0;
            this.mileage.Text = "Mileage";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.model.Location = new System.Drawing.Point(56, 143);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(86, 29);
            this.model.TabIndex = 0;
            this.model.Text = "Model";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(574, 19);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(417, 34);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.Text = "Search Data (Description)";
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBoxSearch, "textBoxSearch");
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // textBoxCar
            // 
            this.textBoxCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCar.Location = new System.Drawing.Point(173, 19);
            this.textBoxCar.Name = "textBoxCar";
            this.textBoxCar.Size = new System.Drawing.Size(198, 34);
            this.textBoxCar.TabIndex = 1;
            this.textBoxCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.search.Location = new System.Drawing.Point(435, 22);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(95, 29);
            this.search.TabIndex = 0;
            this.search.Text = "Search";
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Color.Location = new System.Drawing.Point(1125, 83);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(77, 29);
            this.Color.TabIndex = 0;
            this.Color.Text = "Color";
            this.Color.Click += new System.EventHandler(this.label6_Click);
            // 
            // car_Id
            // 
            this.car_Id.AutoSize = true;
            this.car_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_Id.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.car_Id.Location = new System.Drawing.Point(63, 22);
            this.car_Id.Name = "car_Id";
            this.car_Id.Size = new System.Drawing.Size(86, 29);
            this.car_Id.TabIndex = 0;
            this.car_Id.Text = "Car ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(142, 470);
            this.panel2.MaximumSize = new System.Drawing.Size(1500, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 500);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1400, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.addNew);
            this.panel3.Location = new System.Drawing.Point(142, 341);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1500, 123);
            this.panel3.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Crimson;
            this.button6.Location = new System.Drawing.Point(1228, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 61);
            this.button6.TabIndex = 0;
            this.button6.Text = "Exit";
            this.toolTip1.SetToolTip(this.button6, "Exit");
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Crimson;
            this.button5.Location = new System.Drawing.Point(1006, 33);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 61);
            this.button5.TabIndex = 0;
            this.button5.Text = "Search";
            this.toolTip1.SetToolTip(this.button5, "Search");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Crimson;
            this.button4.Location = new System.Drawing.Point(327, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 61);
            this.button4.TabIndex = 0;
            this.button4.Text = "Delete";
            this.toolTip1.SetToolTip(this.button4, "Delete");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(553, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 61);
            this.button3.TabIndex = 0;
            this.button3.Text = "Reset";
            this.toolTip1.SetToolTip(this.button3, "Reset");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(779, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 61);
            this.button2.TabIndex = 0;
            this.button2.Text = "Print";
            this.toolTip1.SetToolTip(this.button2, "Print");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addNew
            // 
            this.addNew.BackColor = System.Drawing.Color.Black;
            this.addNew.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNew.ForeColor = System.Drawing.Color.Crimson;
            this.addNew.Location = new System.Drawing.Point(105, 33);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(172, 61);
            this.addNew.TabIndex = 0;
            this.addNew.Text = "Add New";
            this.toolTip1.SetToolTip(this.addNew, "Add New Car");
            this.addNew.UseVisualStyleBackColor = false;
            this.addNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(142, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1500, 77);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1244, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(431, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAR MANAGEMENT SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1782, 1003);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1800, 1100);
            this.MinimumSize = new System.Drawing.Size(1700, 850);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label car_Id;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox textBoxMileage;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label mileage;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.TextBox textBoxCar;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label company;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.Label engine_Cc;
        private System.Windows.Forms.ComboBox comboBoxFuel;
        private System.Windows.Forms.Label fuel_Type;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.ComboBox comboBoxTransmission;
        private System.Windows.Forms.Label transmission;
        private System.Windows.Forms.Label purchaed_Date;
        private System.Windows.Forms.TextBox textBoxEngine;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

