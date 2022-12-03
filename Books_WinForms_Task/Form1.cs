using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books_WinForms_Task
{
    public partial class Form1 : Form
    {
        BooksDBEntities db= new BooksDBEntities();

        Books books= new Books();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Eror!" +" " + ex.ToString());
            }
            
        }

        private void LoadData()
        {
            dataGridView1.DataSource = db.Books.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                books.BookName = textBookName.Text;
                books.BokkDescription = textBookDescription.Text;

                db.Books.Add(books);  
                
                if(db.SaveChanges()>0)
                {
                    MessageBox.Show("Added successfully!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Eror!" + " " + ex.ToString());

            }
        }



        private void textBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentCell.RowIndex != -1)
            {
                int booksId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["CatalogNumber"].Value);
                books = db.Books.Where(x => x.CatalogNumber == booksId).FirstOrDefault();
                if (books != null)
                {
                    textBookName.Text = books.BookName;
                    textBookDescription.Text = books.BokkDescription;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (books != null)
                {
                    db.Books.Remove(books);
                    db.SaveChanges();
                    MessageBox.Show("Successfully deleted");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eror!" + " " + ex.ToString());
            }
        }

        private void bntEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if(books != null)
                {
                    books.BookName = textBookName.Text;  
                    books.BokkDescription = textBookDescription.Text;   
                    db.Entry(books).State= EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Updated successfully"); 
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eror!" + " " + ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
