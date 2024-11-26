//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.IO;
//using System.Linq;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Text;
//using System.Text.Json;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Xml.Linq;
//using System.Xml.Serialization;
//using System.Runtime.Serialization.Formatters.Soap;


//namespace WinForms
//{
//    public partial class Serialization : Form
//    {
//        public Serialization()
//        {
//            InitializeComponent();
//        }
//        private void btnBinaryWrite_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                FileStream fs = new FileStream(@"C:\Users\ranua\Documents\DotNet\FileIO\Demo.dat", FileMode.Create, FileAccess.Write);
//                BinaryFormatter binaryFormatter = new BinaryFormatter();
//                Product prod = new Product();
//                prod.Id = Convert.ToInt32(textId.Text);
//                prod.Name = textName.Text;
//                prod.Price = Convert.ToInt32(textPrice.Text);
//                binaryFormatter.Serialize(fs, prod);
//                fs.Close();
//                MessageBox.Show("Done");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }
//        private void btnBinaryRead_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                FileStream fs = new FileStream(@"C:\Users\ranua\Documents\DotNet\FileIO\Demo.dat", FileMode.Open, FileAccess.Read);
//                BinaryFormatter binaryFormatter = new BinaryFormatter();
//                Product prod = new Product();
//                prod = (Product)binaryFormatter.Deserialize(fs);
//                textId.Text = prod.Id.ToString();
//                textName.Text = prod.Name;
//                textPrice.Text = prod.Price.ToString();
//                fs.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }
//        private void btnXmlWrite_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                FileStream fs = new FileStream(@"C:\Users\ranua\Documents\DotNet\FileIO\xmlDemo.xml", FileMode.Create, FileAccess.Write);
//                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
//                Product prod = new Product();
//                prod.Id = Convert.ToInt32(textId.Text);
//                prod.Name = textName.Text;
//                prod.Price = Convert.ToInt32(textPrice.Text);
//                xmlSerializer.Serialize(fs, prod);
//                fs.Close();
//                MessageBox.Show("Done");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }
//        private void btnXmlRead_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                FileStream fs = new FileStream(@"C:\Users\ranua\Documents\DotNet\FileIO\xmlDemo.xml", FileMode.Open, FileAccess.Read);
//                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
//                Product prod = new Product();
//                prod = (Product)xmlSerializer.Deserialize(fs);
//                textId.Text = prod.Id.ToString();
//                textName.Text = prod.Name;
//                textPrice.Text = prod.Price.ToString();
//                fs.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }
//        private void btnSoapWrite_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                FileStream fs = new FileStream(@"C:\Users\ranua\Documents\DotNet\FileIO\soapDemo.soap", FileMode.Create, FileAccess.Write);
//                SoapFormatter soapFormatter = new SoapFormatter();
//                Product prod = new Product();
//                prod.Id = Convert.ToInt32(textId.Text);
//                prod.Name = textName.Text;
//                prod.Price = Convert.ToInt32(textPrice.Text);
//                soapFormatter.Serialize(fs, prod);
//                fs.Close();
//                MessageBox.Show("Done");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }
//        private void btnSoapRead_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                FileStream fs = new FileStream(@"C:\Users\ranua\Documents\DotNet\FileIO\soapDemo.soap", FileMode.Open, FileAccess.Read);
//                SoapFormatter soapFormatter = new SoapFormatter();
//                Product prod = new Product();
//                prod = (Product)soapFormatter.Deserialize(fs);
//                textId.Text = prod.Id.ToString();
//                textName.Text = prod.Name;
//                textPrice.Text = prod.Price.ToString();
//                fs.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }
//        private void btnJsonWrite_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                FileStream fs = new FileStream(@"C:\Users\ranua\Documents\DotNet\FileIO\jsonDemo.json", FileMode.Create, FileAccess.Write);
//                Product prod = new Product();
//                prod.Id = Convert.ToInt32(textId.Text);
//                prod.Name = textName.Text;
//                prod.Price = Convert.ToInt32(textPrice.Text);
//                JsonSerializer.Serialize<Product>(fs, prod);
//                fs.Close();
//                MessageBox.Show("Done");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }
//        private void btnJsonRead_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                FileStream fs = new FileStream(@"C:\Users\ranua\Documents\DotNet\FileIO\soapDemo.soap", FileMode.Open, FileAccess.Read);
//                Product prod = new Product();
//                prod = JsonSerializer.Deserialize<Product>(fs);
//                textId.Text = prod.Id.ToString();
//                textName.Text = prod.Name;
//                textPrice.Text = prod.Price.ToString();
//                fs.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }
//        private void btnClear_Click(object sender, EventArgs e)
//        {
//            textId.Clear();
//            textName.Clear();
//            textPrice.Clear();
//        }
//    }
//}
