namespace PublishingApp
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxSelectedBook = new System.Windows.Forms.GroupBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxClientInfo = new System.Windows.Forms.GroupBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.gbxOffice = new System.Windows.Forms.GroupBox();
            this.cbxOffices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.lblResultPrice = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxSelectedBook.SuspendLayout();
            this.gbxClientInfo.SuspendLayout();
            this.gbxOffice.SuspendLayout();
            this.gbxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSelectedBook
            // 
            this.gbxSelectedBook.Controls.Add(this.txtAuthor);
            this.gbxSelectedBook.Controls.Add(this.txtTitle);
            this.gbxSelectedBook.Controls.Add(this.lblAuthor);
            this.gbxSelectedBook.Controls.Add(this.lblTitle);
            this.gbxSelectedBook.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxSelectedBook.Location = new System.Drawing.Point(13, 13);
            this.gbxSelectedBook.Name = "gbxSelectedBook";
            this.gbxSelectedBook.Size = new System.Drawing.Size(459, 107);
            this.gbxSelectedBook.TabIndex = 0;
            this.gbxSelectedBook.TabStop = false;
            this.gbxSelectedBook.Text = "Выбранная книга";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAuthor.Location = new System.Drawing.Point(101, 68);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(342, 29);
            this.txtAuthor.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTitle.Location = new System.Drawing.Point(101, 34);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(342, 29);
            this.txtTitle.TabIndex = 1;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuthor.Location = new System.Drawing.Point(6, 71);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(64, 21);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Автор:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(7, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Название:";
            // 
            // gbxClientInfo
            // 
            this.gbxClientInfo.Controls.Add(this.lblPhoneNumber);
            this.gbxClientInfo.Controls.Add(this.txtPhoneNumber);
            this.gbxClientInfo.Controls.Add(this.txtAddress);
            this.gbxClientInfo.Controls.Add(this.txtClientName);
            this.gbxClientInfo.Controls.Add(this.lblAddress);
            this.gbxClientInfo.Controls.Add(this.lblClientName);
            this.gbxClientInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxClientInfo.Location = new System.Drawing.Point(13, 127);
            this.gbxClientInfo.Name = "gbxClientInfo";
            this.gbxClientInfo.Size = new System.Drawing.Size(459, 132);
            this.gbxClientInfo.TabIndex = 1;
            this.gbxClientInfo.TabStop = false;
            this.gbxClientInfo.Text = "Данные клиента";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(9, 90);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(82, 21);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Телефон:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(101, 87);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(342, 29);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddress.Location = new System.Drawing.Point(101, 59);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(342, 29);
            this.txtAddress.TabIndex = 1;
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtClientName.Location = new System.Drawing.Point(101, 31);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(342, 29);
            this.txtClientName.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddress.Location = new System.Drawing.Point(9, 62);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 21);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Адрес:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClientName.Location = new System.Drawing.Point(7, 34);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(55, 21);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "ФИО:";
            // 
            // gbxOffice
            // 
            this.gbxOffice.Controls.Add(this.cbxOffices);
            this.gbxOffice.Controls.Add(this.label1);
            this.gbxOffice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxOffice.Location = new System.Drawing.Point(13, 266);
            this.gbxOffice.Name = "gbxOffice";
            this.gbxOffice.Size = new System.Drawing.Size(459, 74);
            this.gbxOffice.TabIndex = 2;
            this.gbxOffice.TabStop = false;
            this.gbxOffice.Text = "Выбор офиса получения";
            // 
            // cbxOffices
            // 
            this.cbxOffices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOffices.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxOffices.FormattingEnabled = true;
            this.cbxOffices.Location = new System.Drawing.Point(101, 29);
            this.cbxOffices.Name = "cbxOffices";
            this.cbxOffices.Size = new System.Drawing.Size(342, 29);
            this.cbxOffices.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Офис:";
            // 
            // gbxDetails
            // 
            this.gbxDetails.Controls.Add(this.lblResultPrice);
            this.gbxDetails.Controls.Add(this.nudCantidad);
            this.gbxDetails.Controls.Add(this.lblCantidad);
            this.gbxDetails.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxDetails.Location = new System.Drawing.Point(13, 359);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(459, 81);
            this.gbxDetails.TabIndex = 3;
            this.gbxDetails.TabStop = false;
            this.gbxDetails.Text = "Детали заказа";
            // 
            // lblResultPrice
            // 
            this.lblResultPrice.AutoSize = true;
            this.lblResultPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResultPrice.Location = new System.Drawing.Point(276, 36);
            this.lblResultPrice.Name = "lblResultPrice";
            this.lblResultPrice.Size = new System.Drawing.Size(87, 21);
            this.lblResultPrice.TabIndex = 2;
            this.lblResultPrice.Text = "Итого: 0₽";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudCantidad.Location = new System.Drawing.Point(127, 34);
            this.nudCantidad.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 29);
            this.nudCantidad.TabIndex = 1;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCantidad.Location = new System.Drawing.Point(12, 36);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(109, 21);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Количество:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirm.Location = new System.Drawing.Point(50, 458);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(148, 56);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Подтвердить заказ";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(293, 458);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 56);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 580);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbxDetails);
            this.Controls.Add(this.gbxOffice);
            this.Controls.Add(this.gbxClientInfo);
            this.Controls.Add(this.gbxSelectedBook);
            this.Name = "FormOrder";
            this.Text = "Оформление предзаказа";
            this.gbxSelectedBook.ResumeLayout(false);
            this.gbxSelectedBook.PerformLayout();
            this.gbxClientInfo.ResumeLayout(false);
            this.gbxClientInfo.PerformLayout();
            this.gbxOffice.ResumeLayout(false);
            this.gbxOffice.PerformLayout();
            this.gbxDetails.ResumeLayout(false);
            this.gbxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSelectedBook;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.GroupBox gbxClientInfo;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.GroupBox gbxOffice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.ComboBox cbxOffices;
        private System.Windows.Forms.GroupBox gbxDetails;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblResultPrice;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}