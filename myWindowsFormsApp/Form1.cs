using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myWindowsFormsApp
{
    public partial class Form1 : Form
    {
        List<string> names = new List<string> {};
        List<int> ages = new List<int> { };
        public Form1()
        {
            InitializeComponent();
        }



        private void addButton_Click_1(object sender, EventArgs e)
        {

            // List<string> name = new List<string> { };
            names.Add(nameTextBox.Text);
            ages.Add(Convert.ToInt32(ageTextBox.Text));
            
            ShowCustomer();
            //   string message = "";
            // for ( int i= 0;i < names.count(); i++){
            //      message += names[i]+ "\n";
            //   }
            // foreach(string name in names)
            // {
            //      message += "Name: " + name + "\n";
            //  }
            //
            // showRichTextBox.Text = message;
            // 
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowCustomer();
        }
        private void ShowCustomer()
        {
            // List<string> name = new List<string> { };
            // names.Add(nameTextBox.Text);
            string message = "";
            for (int i = 0; i < names.Count(); i++)
            {
                message += names[i]+" " + ages[i] + "\n";
            }

            ////foreach (string name in names)

            //   {
            //       message += "Name: " + name + "\n";
            //   }

            showRichTextBox.Text = message;
        }



    }
}

