using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryApp
{
    public partial class StudentInfoUI : Form
    {
        public StudentInfoUI()
        {
            InitializeComponent();
        }
        Dictionary<String, String> studentinfo = new Dictionary<string, string>();
        private String idInput, details;
        private void SaveButton_Click(object sender, EventArgs e)
        {
             idInput = idInputText.Text;
             details=detailsText.Text;
            if (!studentinfo.ContainsKey(idInput))
            {
                studentinfo.Add(idInput, details);
                MessageBox.Show("Data is saved!");
                idInputText.Text = String.Empty;
                detailsText.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("already exists!");
            }
           
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            String idSearch = idSearchText.Text;
            if (studentinfo.ContainsKey(idSearch))
            {
                detailsText.Text = studentinfo[idSearch];
               
            }
            else
            {
                 MessageBox.Show("doesn't exists!");
            }
           
        }
        String info;
        private void ShowAllButton_Click(object sender, EventArgs e)
        {

           
            foreach (KeyValuePair<String,String> value in studentinfo)
            {
                info += value.Key + " " + value.Value+ "\n";

            }
            MessageBox.Show(info);
        }
    }
}
