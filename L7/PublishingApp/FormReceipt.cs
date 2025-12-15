using PublishingApp.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace PublishingApp
{
    public partial class FormReceipt : Form
    {
        private Order _order;
        DatabaseHelper databaseHelper = new DatabaseHelper();

        public FormReceipt(int orderId)
        {
            _order = databaseHelper.GetOrderDetails(orderId);
            InitializeComponent();
            BuildReceipt();
        }

        private void BuildReceipt()
        {
            var receipt = $@"
            ================================
                      ИЗДАТЕЛЬСТВО
            ================================
            Заказ №: {_order.Id}
            Дата: {_order.OrderDate:dd.MM.yyyy HH:mm}
            --------------------------------
            Книга: {_order.BookTitle}
            Цена: {_order.Price:C2}
            --------------------------------
            Клиент: {_order.CustomerName}
            --------------------------------
            Филиал: {_order.OfficeName}
            --------------------------------
            Статус: {(_order.CompletionDate.HasValue ? "Выполнен" : "В обработке")}
            " + (_order.CompletionDate.HasValue ? $"Дата выполнения: {_order.CompletionDate:dd.MM.yyyy}\n" : "") + @"
            ================================
                     СПАСИБО ЗА ЗАКАЗ!
            ================================
            ";
            rtbReceiptText.Text = receipt;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";
                saveFileDialog.FileName = $"Чек_заказа_{_order.Id}_{_order.OrderDate:yyyyMMdd}.txt";
                saveFileDialog.Title = "Сохранить чек как...";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, rtbReceiptText.Text);
                    MessageBox.Show($"Чек успешно сохранен!", "Сохранение завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение выхода", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).Equals(DialogResult.OK))
            {
                Close();
            }
        }
    }
}
