using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();

        }


        private void InitializeComboBox()
        {
            foreach(string s in Properties.Settings.Default.Websites)
            {
                websiteComboBox.Items.Add(s);
            }

            websiteComboBox.SelectedIndex = 0;
            websiteComboBox.SelectedIndexChanged += ComboBoxIndexChangedEventHandler;

        }



        private void ComboBoxIndexChangedEventHandler(object sender, EventArgs e)
        {
            webBrowser1.Navigate(websiteComboBox.SelectedItem.ToString());
        }









        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
