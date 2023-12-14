using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace car_management_sys
{
    
    public partial class Form1 : Form
    {
        //sqlConn will be used to establish a connection to the SQLite database.
        private SQLiteConnection sqlConn;
        // sqlCmd will be used to execute SQL commands on the SQLite database.
        private SQLiteCommand sqlCmd;
        //This DataTable will be used to hold data retrieved from the database and bind it to a DataGridView.
        private DataTable sqlDT = new DataTable();
        public Form1()
        {
            // Automatically generated method call that initializes the visual components of the form. 
            InitializeComponent();
            // Calls the SetConnectDB method, which is responsible for setting up the SQLite database connection.
            SetConnectDB();
            // load data from the database into a DataTable and binds it to a DataGridView for display.
            upLoadData();
            // generating a randon number
            Random rnd = new Random();
            //Generates a random integer between 1000 and 55555 (exclusive) and assigns it to the variable iRef.
            int iRef = rnd.Next(1000, 55555);
            //Sets the text property of a TextBox named textBoxCar to the string representation of the randomly generated number. This is used to initialize a unique identifier for a new entry
            textBoxCar.Text = iRef.ToString();
            InitializeDatabase();  // Ensure the database is initialized
        }

        /* the SetConnectDB method is responsible for ensuring that the SQLite database file exists at the specified location. If the file doesn't exist,
        it creates an empty database file and initializes it using the InitializeDatabase method. Finally, it sets up the SQLiteConnection object with
        the appropriate connection string for further database operations in the application.*/
        private void SetConnectDB()
        {
            // 1. Specify the database file name
            string dbFileName = "details.db";
            // 2. Get the directory where the executable is located
            string executableDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            // 3. Combine the directory and database file name to get the full path
            string dbPath = Path.Combine(executableDirectory, dbFileName);

            // Check if the database file exists
            if (!File.Exists(dbPath))
            {
                // If the file doesn't exist, create it and initialize the database
                SQLiteConnection.CreateFile(dbPath);
                InitializeDatabase();
            }
            // 6. Set up the SQLite connection using the full path to the database file
            sqlConn = new SQLiteConnection($"Data Source={dbPath}");
        }

        /*the ExecuteQery method encapsulates the process of setting up the SQLite database
        connection, ensuring database initialization, executing a provided non-query SQL statement,
        and properly closing the database connection*/
        private void ExecuteQery(string QueryData)
        {
            //Set up the SQLite database connection
            SetConnectDB();
            InitializeDatabase();
            //Open the database connection
            sqlConn.Open();
            //Create a SQLiteCommand for executing the query
            sqlCmd = sqlConn.CreateCommand();
            //Set the command text to the provided query
            sqlCmd.CommandText = QueryData;
            //Execute the query and perform any non-query SQL statement
            sqlCmd.ExecuteNonQuery();
            //Dispose of the SQLiteCommand to release resources
            sqlCmd.Dispose();
            //Close the database connection
            sqlConn.Close();
        }
        /*  the upLoadData method fetches data from the "details" table in the SQLite database, loads it
         into a DataTable, and sets the DataTable as the DataSource for a DataGridView to display the data in the user interface.*/
        private void upLoadData()
        {
            InitializeDatabase();
            SetConnectDB();
            sqlConn.Open();
            //Define the SQL command text for selecting all records from the "details" table
            string commandText = "Select * from details";
            // Execute the query using Dapper and load the result into a DataTable
            using (var reader = sqlConn.ExecuteReader(commandText))
            {
                //Create a new DataTable to hold the query result
                DataTable dataTable = new DataTable();
                //Load the data from the reader into the DataTable
                dataTable.Load(reader);
                //Set the DataGridView's DataSource to the DataTable
                dataGridView1.DataSource = dataTable;
                sqlDT = dataTable; // Update the reference to sqlDT
            }
            sqlConn.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        /*the button1_Click event handler captures user input from various UI controls,
         creates a Car object with the entered details, executes a query to insert the 
        car details into the database, and then refreshes the UI by reloading the data from the database. */
        private void button1_Click(object sender, EventArgs e)
        {
            // Create a Car instance and populate its properties
            Car car = new Car
            {
                Color = comboBoxColor.Text,
                Description = textBoxDescription.Text,
                Transmission = comboBoxTransmission.Text,
                FuelType = comboBoxFuel.Text,
                Company = comboBoxCompany.Text,
                Price = textBoxPrice.Text,
                Model = textBoxModel.Text,
                Mileage = textBoxMileage.Text,
                EngineCC = textBoxEngine.Text
            };

            // Call a method to execute the query using the Car properties
            ExecuteQueryForCar(car);

            // Reload data after the operation
            upLoadData();
        }
        /*the ExecuteQueryForCar method is responsible for executing an SQL INSERT
         query to add a new car's details to the "details" table in the SQLite database.
        It uses parameterized values to prevent SQL injection and catches any exceptions 
        that might occur during the execution of the query, displaying an error message if necessary.*/
        private void ExecuteQueryForCar(Car car)
        {
            // Define the SQL query string with parameterized values
            string queryData = "INSERT INTO details(Car_Id, Color, Description, Transmission, Fuel_Type, Company, Price, Model, Mielage, Engine_Cc) " +
                               "VALUES (@CarId, @Color, @Description, @Transmission, @FuelType, @Company, @Price, @Model, @Mileage, @EngineCC)";

            try
            {
                //Execute the query using Dapper and provide parameter values
                sqlConn.Execute(queryData, new
                {
                    CarId = textBoxCar.Text,  
                    Color = comboBoxColor.Text,
                    Description = textBoxDescription.Text,
                    Transmission = comboBoxTransmission.Text,
                    FuelType = comboBoxFuel.Text,
                    Company = comboBoxCompany.Text,
                    Price = textBoxPrice.Text,
                    Model = textBoxModel.Text,
                    Mileage = textBoxMileage.Text,
                    EngineCC = textBoxEngine.Text
                });
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                MessageBox.Show($"Error executing query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*Exit button presents a confirmation prompt to the user, asking if they want to exit the application.
         If the user chooses 'Yes,' the application is exited using Application.Exit(). Any exceptions that occur during this
        process are caught and displayed in a MessageBox to ensure a smooth user experience and provide feedback in case of errors.*/
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //Display a MessageBox with a confirmation prompt
                if (MessageBox.Show("Do you want to exit", "Car Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                //Handle exceptions appropriately
                MessageBox.Show(ex.Message, "Car Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }
        /*reset button performs the tasks of clearing the text in TextBox controls, setting the text to an empty string in ComboBox controls, 
         handling any exceptions that might occur, and generating and setting a random number in a specific TextBox.*/
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                //Clear the text in all TextBox controls
                foreach (Control txt in panel1.Controls)
                {
                    if (txt is TextBox)
                        ((TextBox)txt).Clear();
                }
                //Set the text to an empty string in all ComboBox controls
                foreach (Control cbo in panel1.Controls)
                {
                    if (cbo is ComboBox)
                        ((ComboBox)cbo).Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Car Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Random rnd = new Random();
            int iRef = rnd.Next(1000, 55555);
            textBoxCar.Text = iRef.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void company_Click(object sender, EventArgs e)
        {

        }

        private void engine_Cc_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEngine_TextChanged(object sender, EventArgs e)
        {

        }

        private void transmission_Click(object sender, EventArgs e)
        {

        }
        //bitmap used to capture the content of a DataGridView in the button2_Click event handler.
        Bitmap bit_map; //. This variable is used to store an image (bitmap) in memory.

        /*button print allows the user to preview the content of the DataGridView in a print preview dialog. It first adjusts the height of the DataGridView 
         to fit all rows, captures the content in a Bitmap, shows the print preview dialog, and finally restores the original height of the DataGridView.*/
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Save the current height of the DataGridView
                int height = dataGridView1.Height;
                //Increase the height of the DataGridView to fit all rows for printing
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                //Create a Bitmap with the size of the DataGridView
                bit_map = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                //Draw the DataGridView onto the Bitmap
                dataGridView1.DrawToBitmap(bit_map, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                //Configure print preview settings 
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                //Show the print preview dialog
                printPreviewDialog1.ShowDialog();
                //Restore the original height of the DataGridView
                dataGridView1.Height = height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Car Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /*This event handler is associated with the PrintDocument (printDocument1) and is triggered when a page is being printed.
         It draws the previously created bit_map (Bitmap) onto the print page using the DrawImage method of the Graphics object (e.Graphics).
        */
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bit_map, 0, 0);
        }
        // button to delete a record from the database and update the UI.
        private void button4_Click(object sender, EventArgs e)
        {
            string QueryData = "delete from details where Car_Id= '" + textBoxCar.Text + "'";
            ExecuteQery(QueryData);
            upLoadData();
        }
        /*Form1_Load event handler is responsible for loading data from the "details" table in the SQLite database and populating a DataTable. 
         The data is then bound to a DataGridView (dataGridView1)*/
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Check if the database connection is closed and open it if necessary
                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();
                //Use a SQLiteDataAdapter to fetch data from the "details" table
                using (SQLiteDataAdapter DB = new SQLiteDataAdapter("select *from details", sqlConn))
                {
                    //reate a new DataTable named "sqlDT"
                    DataTable sqlDT = new DataTable("Color");
                    //Fill the DataTable with data from the database using the DataAdapter
                    DB.Fill(sqlDT);
                    //Set the DataGridView's DataSource to the filled DataTabl
                    dataGridView1.DataSource = sqlDT;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Car Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /* Search button filters the data displayed in a DataGridView based on the text entered in a search TextBox (textBoxSearch) when
         the Enter key is pressed. It uses a DataView to filter the DataTable (sqlDT) and updates the DataGridView with the filtered results.*/

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //check if enter is pressed
            if (e.KeyChar == (Char)13)
            {
                // A DataView provides a way to filter and sort data in a DataTable.
                DataView dv = sqlDT.DefaultView;
                // display rows where the "Description" column contains the text entered in textBoxSearch.
                dv.RowFilter = string.Format("Description like'%{0}%'", textBoxSearch.Text);
                //convert the filtered view back to a DataTable.
                dataGridView1.DataSource = dv.ToTable();
            }
        }
        /* InitializeDatabase method is responsible for ensuring that the database connection is open and that the 
         "details" table with the specified schema exists. If the table does not exist, it creates the table.*/
        private bool isTableInitialized = false; // Flag to track whether the table is already initialized

        private void InitializeDatabase()
        {
            // Ensure sqlConn is not null before attempting to use it
            if (sqlConn != null)
            {
                // Check if the table has already been initialized
                if (!isTableInitialized)
                {
                    // Open a connection to the database
                    using (SQLiteConnection connection = new SQLiteConnection(sqlConn.ConnectionString))
                    {
                        connection.Open();

                        // Check if the "details" table already exists
                        if (!TableExists(connection, "details"))
                        {
                            // Create the "details" table with the required schema
                            string createTableQuery = @"
                        CREATE TABLE details (
                            Ser_No INTEGER NOT NULL UNIQUE,
                            Car_Id TEXT NOT NULL,
                            Color TEXT,
                            Description TEXT,
                            Transmission TEXT NOT NULL,
                            Fuel_Type TEXT NOT NULL,
                            Company TEXT NOT NULL,
                            Price TEXT NOT NULL,
                            Model TEXT NOT NULL,
                            Mielage TEXT,
                            Engine_Cc TEXT NOT NULL,
                            PRIMARY KEY(Ser_No AUTOINCREMENT)
                        );";

                            // Execute the create table query
                            using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, connection))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Set the flag to indicate that table initialization has been performed
                        isTableInitialized = true;
                    }
                }
            }
            else
            {
                // Handle the case where sqlConn is null, log, or throw an exception
                Console.WriteLine("sqlConn is null. Ensure SetConnectDB is called before InitializeDatabase.");
            }
        }
     
        private bool TableExists(SQLiteConnection connection, string tableName)
        {
            // Check if the table exists
            using (SQLiteCommand cmd = new SQLiteCommand($"SELECT name FROM sqlite_master WHERE type='table' AND name='{tableName}'", connection))
            {
                return cmd.ExecuteScalar() != null;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxCar.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBoxColor.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBoxDescription.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                comboBoxTransmission.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                comboBoxFuel.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                comboBoxCompany.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBoxPrice.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                textBoxModel.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                textBoxMileage.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                textBoxEngine.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Car Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {


            DataView dv = sqlDT.DefaultView;
            dv.RowFilter = string.Format("Description like'%{0}%'", textBoxSearch.Text);
            dataGridView1.DataSource = dv.ToTable();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    public class Vehicle
    {
        public string Color { get; set; }
        public string Description { get; set; }
        public string Transmission { get; set; }
        public string FuelType { get; set; }
    }
    // Derived class representing a car, inheriting from the Vehicle base class
    [Table("details")]
    public class Car : Vehicle
    {
        public string Company { get; set; }
        public string Price { get; set; } //changed it to price
        public string Model { get; set; }
        public string Mileage { get; set; }
        public string EngineCC { get; set; }
    }
}