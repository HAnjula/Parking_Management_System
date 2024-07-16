using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ParkingManagementSystem
{
    public partial class BookParking : Form
    {
        Functions Con;
         Database db;
        public BookParking()
        {
            InitializeComponent();
            Con = new Functions();
            db= new Database();
            SetCurrentDate();
        }

        private void SetCurrentDate()
        {
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void BookParking_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtVehicleNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void Booking_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtParkingLotNumber.Text) ||
                string.IsNullOrWhiteSpace(txtVehicleNumber.Text) ||
                string.IsNullOrWhiteSpace(txtVehicleType.Text) ||
                string.IsNullOrWhiteSpace(txtOwnerId.Text))
            {
                MessageBox.Show("Missing Data!!!");
                return;
            }

            try
            {
                int slotNo = int.Parse(txtParkingLotNumber.Text);
                string vehicleNo = txtVehicleNumber.Text;
                string vehicleType = txtVehicleType.Text;
                string ownerName = txtOwnerId.Text;

                // Insert query without booking_id
                string query = "INSERT INTO Booking (slot_no, vehicle_no, vehicle_type, owner_name) VALUES (@SlotNo, @VehicleNo, @VehicleType, @OwnerName)";

                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@SlotNo", slotNo);
                    cmd.Parameters.AddWithValue("@VehicleNo", vehicleNo);
                    cmd.Parameters.AddWithValue("@VehicleType", vehicleType);
                    cmd.Parameters.AddWithValue("@OwnerName", ownerName);

                    db.ExecuteNonQuery(cmd);
                }

                // Retrieve the last inserted booking_id
                int bookingId = db.GetLastInsertedId();
                MessageBox.Show($"Car Added! Booking ID: {bookingId}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            SetCurrentDate();
        }

        private void txtParkingLotNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOwnerId_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Database
    {
        private string connectionString;

        public Database()
        {
            // Read the connection string from App.config
            connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public int ExecuteNonQuery(MySqlCommand cmd)
        {
            int affectedRows = 0;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    affectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                throw;
            }
            return affectedRows;
        }

     

        public int GetLastInsertedId()
        {
            int lastId = 0;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", connection))
                    {
                        lastId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return lastId;
        }

    }
}
