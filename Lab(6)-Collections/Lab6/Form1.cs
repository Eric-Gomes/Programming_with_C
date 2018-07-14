using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Book> books = new List<Book>();
    



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Settng Values
        public void button1_Click(object sender, EventArgs e)
        {

            Book b = new Book();
            b.Title = textBox1.Text;
            b.ISBN = textBox2.Text;
            b.Onloan = trueCheckBox.Checked;
            listView1.Items.Add(b.Title + ", " + b.ISBN + ", " + b.Onloan);
            books.Add(b);

            textBox1.Text = null;
            textBox2.Text = null;

        }

        //Method to check if item is aviable or note - boolean type
        void avaiable()
        {
            if (trueCheckBox.Checked = true)
            {



                bool onloan = true;
            }

            else
            {
                bool onloan = false;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Remove();
        }

        //Remove item from both the List & Listview
        void Remove()
        {

            try
            {

                listView1.Items.Remove(listView1.SelectedItems[0]);
                books.RemoveAt(listView1.SelectedItems[0].Index);
            

            }
            catch
            {

            }
        }


        //Display  information within their field when selected an item is selected
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {


                textBox1.Text = books[listView1.SelectedItems[0].Index].Title;
                textBox2.Text = books[listView1.SelectedItems[0].Index].ISBN;
                trueCheckBox.Checked = books[listView1.SelectedItems[0].Index].Onloan;
            }
        }


        //Update the values without having to re-add
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                books[listView1.SelectedItems[0].Index].Title = textBox1.Text;
                books[listView1.SelectedItems[0].Index].ISBN = textBox2.Text;
                books[listView1.SelectedItems[0].Index].Onloan = trueCheckBox.Checked;
                listView1.SelectedItems[0].Text = textBox1.Text + ", " + textBox2.Text + ", " + trueCheckBox.Checked;
            }
        }

   
 

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems.Clear();

            for (int  i = listView1.Items.Count-1; i >= 0; i--)
            {
                if (listView1.Items[i].ToString().ToLower().Contains(searchBox.Text.ToLower())) {

                    listView1.Items[i].Selected = true;

                }
            }
      
        }

        //Class - set & get methods
        class Book
        {

            public string isbn;
            public string title;
            private Boolean onloan;


            public Book()
            {
                this.isbn = isbn;
                this.title = title;
            }

            public string ISBN
            {
                get { return isbn; }
                set { isbn = value; }
            }
            public string Title
            {

                get { return title; }
                set { title = value; }
            }
            public Boolean Onloan
            {
                get { return onloan; }
                set { onloan = value; }
            }

        }

   
    }

}