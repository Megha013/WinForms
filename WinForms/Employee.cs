using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
//using System.Runtime.Serialization.Formatters.Soap;

namespace WinForms
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\ranua\Documents\DotNet\binaryDemo.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Emp em = new Emp();
                em.Id = Convert.ToInt32(label1.Text);
                em.Name = label2.Text;
                em.Salary = Convert.ToInt32(label3.Text);
                binaryFormatter.Serialize(fs, e);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\ranua\Documents\DotNet\binaryDemo.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Product prod = new Product();
                prod = (Product)binaryFormatter.Deserialize(fs);
                label1.Text = prod.Id.ToString();
                label2.Text = prod.Name;
                label3.Text = prod.Price.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\ranua\Documents\DotNet\xmlDemo.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Emp));
                Emp em = new Emp();
                em.Id = Convert.ToInt32(label1.Text);
                em.Name = label2.Text;
                em.Salary = Convert.ToInt32(label3.Text);
                xmlSerializer.Serialize(fs, em);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\ranua\Documents\DotNet\xmlDemo.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Emp));
                Emp em = new Emp();
                em = (Emp)xmlSerializer.Deserialize(fs);
                label1.Text = em.Id.ToString();
                label2.Text = em.Name;
                label3.Text = em.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\ranua\Documents\DotNet\soapDemo.soap", FileMode.Create, FileAccess.Write);
                //SoapFormatter soapFormatter = new SoapFormatter();
                Emp em = new Emp();
                em.Id = Convert.ToInt32(label1.Text);
                em.Name = label2.Text;
                em.Salary = Convert.ToInt32(label3.Text);
                //soapFormatter.Serialize(fs, em);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\ranua\Documents\DotNet\soapDemo.soap", FileMode.Create, FileAccess.Write);
                //SoapFormatter soapFormatter = new SoapFormatter();
                Emp em = new Emp();
                //em = (Emp)soapFormatter.Deserialize(fs);
                label1.Text = em.Id.ToString();
                label2.Text = em.Name;
                label3.Text = em.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\ranua\Documents\DotNet\jsonDemo.json", FileMode.Create, FileAccess.Write);
                Emp em = new Emp();
                em.Id = Convert.ToInt32(label1.Text);
                em.Name = label2.Text;
                em.Salary = Convert.ToInt32(label3.Text);
                JsonSerializer.Serialize<Emp>(fs, em);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\ranua\Documents\DotNet\soapDemo.soap", FileMode.Create, FileAccess.Write);
                Emp em = new Emp();
                em = JsonSerializer.Deserialize<Emp>(fs);
                label1.Text = em.Id.ToString();
                label2.Text = em.Name;
                label3.Text = em.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
