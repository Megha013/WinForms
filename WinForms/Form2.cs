﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string city = enterCity.Text;
            if(!string.IsNullOrEmpty(city))
            {
                listBox.Items.Add(city);
                enterCity.Clear();
            }
            else
            {
                MessageBox.Show("Enter city name");
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems != null)
            {
                listBox.Items.Remove(listBox.SelectedItems);
            }
            else
            {
                MessageBox.Show("Select city to remove");
            }
        }
    }
}
