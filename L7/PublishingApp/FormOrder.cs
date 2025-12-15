using PublishingApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PublishingApp
{
    public partial class FormOrder : Form
    {
        Book _book;
        List<Office> offices;
        DatabaseHelper dbHelper = new DatabaseHelper();

        public FormOrder(Book book)
        {
            InitializeComponent();
            txtAuthor.Text = book.AuthorName;
            txtTitle.Text = book.Title;
            _book = book;
            nudCantidad_ValueChanged(this, EventArgs.Empty);
            refreshOffices();
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            lblResultPrice.Text = $"Итого: {_book.Price * nudCantidad.Value}₽";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите отменить заказ?", "Подтверждение отмены", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).Equals(DialogResult.OK))
            {
                Close();
            }
        }

        private void refreshOffices()
        {
            offices = dbHelper.GetOffices();
            foreach (Office office in offices)
            {
                cbxOffices.Items.Add(office.Name);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbxOffices.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите офис получения!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtClientName.Text.Length == 0 || txtPhoneNumber.Text.Length == 0 || txtAddress.Text.Length == 0)
            {
                MessageBox.Show("Заполните данные клиента!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = dbHelper.CreateCustomer(new Customer { Name = txtClientName.Text, Address = txtAddress.Text, Phone = txtPhoneNumber.Text });
            Office office = offices[cbxOffices.SelectedIndex];
            Order order = new Order
            {
                CustomerId = id,
                CustomerName = txtClientName.Text,
                BookId = _book.Id,
                BookTitle = _book.Title,
                OfficeId = office.Id,
                OfficeName = office.Name,
                OrderDate = DateTime.Now,
                Price = _book.Price * nudCantidad.Value,
                CompletionDate = null
            };
            order.Id = dbHelper.CreateOrder(order);
            MessageBox.Show("Заказ успешно создан!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form form = new FormReceipt(order.Id);
            this.Hide();
            form.ShowDialog();
            Close();
        }
    }
}