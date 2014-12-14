using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerInfoInFolderApp
{
    public partial class CustomerInfoUI : Form
    {
        private string filename = @"E:\Info.txt";
        public CustomerInfoUI()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            FileStream aFileStream = new FileStream(filename,FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFileStream);
            aStreamWriter.Write(CustomerInfoSaveTextBox.Text);
            aStreamWriter.WriteLine();
            aStreamWriter.Close();
            aStreamWriter.Close();

        }

        private void showButton_Click(object sender, EventArgs e)
        {
             FileStream aFileStream = new FileStream(filename,FileMode.Open);
             StreamReader aStreamReader = new StreamReader(aFileStream);
            while (!aStreamReader.EndOfStream)
            {
                string show = aStreamReader.ReadLine();
                nameListBox.Items.Add(show);
            }
            aStreamReader.Close();


        }
    }
}
