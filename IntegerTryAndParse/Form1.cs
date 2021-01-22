using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegerTryAndParse
{
    public partial class MainWindow : Form
    {
        public static string sInteger1;
        public static int iIntger1;
        public static string sInteger2;
        public static int iIntger2;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tryParseButton_Click(object sender, EventArgs e)
        {
            // method one.
            if (Int32.TryParse(integer1TB.Text, out iIntger1) == true)
            {

            }
            else
            {
                integer1TB.Text = "";
                MessageBox.Show("Integer 1 is not a valid integer");
            }
            try
            {
                iIntger2 = Convert.ToInt32(integer2TB.Text);
            } catch (FormatException)
            { 
                integer2TB.Text = "";
                MessageBox.Show("Integer 2 is not a valid integer.");

            }            
        }
    }
}
