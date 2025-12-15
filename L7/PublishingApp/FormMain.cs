using PublishingApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishingApp
{
    public partial class FormMain : Form
    {
        DatabaseHelper databaseHelper = new DatabaseHelper();
        Dictionary<string, Book> books = new Dictionary<string, Book>();
        string selectedBook = "";

        public FormMain()
        {
            InitializeComponent();
            refreshBooks();
        }

        private void refreshBooks()
        {
            dgvBooks.Rows.Clear();
            books.Clear();
            foreach (Book book in databaseHelper.GetBooks())
            {
                dgvBooks.Rows.Add(book.Id, book.Title, book.AuthorName, book.ReleaseYear, book.Pages, book.Circulation);
                books.Add(book.Id.ToString(), book);
            }
        }

        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            try // срабатывает ошибка при нажатии "обновить". выделение меняется после очистки, а строчек ещё нет
            {
                int rowN = ((DataGridView)sender).SelectedRows[0].Index;
                Book book = books[dgvBooks.Rows[rowN].Cells[0].Value.ToString()];
                txtAuthor.Text = book.AuthorName;
                txtTitle.Text = book.Title;
                txtYear.Text = book.ReleaseYear.ToString();
                selectedBook = book.Id.ToString();
            }
            catch { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение выхода", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).Equals(DialogResult.OK))
            {
                Close();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtAuthor.Text = txtTitle.Text = txtYear.Text = "";
            refreshBooks();
            dgvBooks_SelectionChanged(dgvBooks, null); // выбираем книгу вручную. автоматический переход срабатывает после очистки, но не после заполнения
        }

        private void btnPreorder_Click(object sender, EventArgs e)
        {
            Form form = new FormOrder(books[selectedBook]);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
