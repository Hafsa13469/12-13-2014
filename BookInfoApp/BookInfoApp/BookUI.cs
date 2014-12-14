using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInfoApp
{
    public partial class BookUI : Form
    {   Hashtable bookInfo = new Hashtable();
        public BookUI()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (bookInfo.ContainsKey(isbnAddTextBox.Text))
            {
                MessageBox.Show("Data is already Saved before");
            }
            else
            {

                bookInfo.Add(isbnAddTextBox.Text, detailAddTextBox.Text);
                MessageBox.Show("Data is Saved");
                
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (bookInfo.ContainsKey(isbnSearchTextBox.Text))
            {
                string details = Convert.ToString(bookInfo[isbnSearchTextBox.Text]);
                isbnDetailTextBox.Text = details;
            }
            else
            {
                MessageBox.Show("There no book with this id");
            }
        }
    }
}
