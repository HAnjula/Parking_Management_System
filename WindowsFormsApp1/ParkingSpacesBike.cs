﻿using ReaLTaiizor.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagementSystem
{
    public partial class ParkingSpacesBike : Form
    {
        public ParkingSpacesBike()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ParkingSpaces parkingSpaces = new ParkingSpaces();
            parkingSpaces.Show();
            this.Close();
        }

        private void btnAddBike_Click(object sender, EventArgs e)
        {
            BookParking bookParking = new BookParking();
            bookParking.Show();
            
        }
    }
}
