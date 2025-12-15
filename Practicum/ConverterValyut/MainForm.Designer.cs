namespace ConverterValyut
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblSumm = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKrwToRub = new System.Windows.Forms.Label();
            this.lblCnyToRub = new System.Windows.Forms.Label();
            this.lblEurToRub = new System.Windows.Forms.Label();
            this.lblUsdToRub = new System.Windows.Forms.Label();
            this.cbxFrom = new System.Windows.Forms.ComboBox();
            this.cbxTo = new System.Windows.Forms.ComboBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.txtSumm = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblPreviewFrom = new System.Windows.Forms.Label();
            this.lblPreviewTo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Конвертер валют";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrom.Location = new System.Drawing.Point(16, 55);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(35, 21);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "Из:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTo.Location = new System.Drawing.Point(16, 94);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 21);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "В:";
            // 
            // lblSumm
            // 
            this.lblSumm.AutoSize = true;
            this.lblSumm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSumm.Location = new System.Drawing.Point(16, 133);
            this.lblSumm.Name = "lblSumm";
            this.lblSumm.Size = new System.Drawing.Size(68, 21);
            this.lblSumm.TabIndex = 1;
            this.lblSumm.Text = "Сумма:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(16, 172);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(90, 21);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Результат:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKrwToRub);
            this.groupBox1.Controls.Add(this.lblCnyToRub);
            this.groupBox1.Controls.Add(this.lblEurToRub);
            this.groupBox1.Controls.Add(this.lblUsdToRub);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(19, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 157);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Курс валют к RUB";
            // 
            // lblKrwToRub
            // 
            this.lblKrwToRub.AutoSize = true;
            this.lblKrwToRub.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKrwToRub.Location = new System.Drawing.Point(7, 114);
            this.lblKrwToRub.Name = "lblKrwToRub";
            this.lblKrwToRub.Size = new System.Drawing.Size(53, 21);
            this.lblKrwToRub.TabIndex = 0;
            this.lblKrwToRub.Text = "label1";
            // 
            // lblCnyToRub
            // 
            this.lblCnyToRub.AutoSize = true;
            this.lblCnyToRub.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCnyToRub.Location = new System.Drawing.Point(7, 87);
            this.lblCnyToRub.Name = "lblCnyToRub";
            this.lblCnyToRub.Size = new System.Drawing.Size(53, 21);
            this.lblCnyToRub.TabIndex = 0;
            this.lblCnyToRub.Text = "label1";
            // 
            // lblEurToRub
            // 
            this.lblEurToRub.AutoSize = true;
            this.lblEurToRub.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEurToRub.Location = new System.Drawing.Point(7, 60);
            this.lblEurToRub.Name = "lblEurToRub";
            this.lblEurToRub.Size = new System.Drawing.Size(53, 21);
            this.lblEurToRub.TabIndex = 0;
            this.lblEurToRub.Text = "label1";
            // 
            // lblUsdToRub
            // 
            this.lblUsdToRub.AutoSize = true;
            this.lblUsdToRub.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsdToRub.Location = new System.Drawing.Point(7, 33);
            this.lblUsdToRub.Name = "lblUsdToRub";
            this.lblUsdToRub.Size = new System.Drawing.Size(53, 21);
            this.lblUsdToRub.TabIndex = 0;
            this.lblUsdToRub.Text = "label1";
            // 
            // cbxFrom
            // 
            this.cbxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFrom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxFrom.FormattingEnabled = true;
            this.cbxFrom.Items.AddRange(new object[] {
            "Российский рубль",
            "Доллар США",
            "Евро",
            "Китайский юань",
            "Южнокорейская вона"});
            this.cbxFrom.Location = new System.Drawing.Point(82, 52);
            this.cbxFrom.Name = "cbxFrom";
            this.cbxFrom.Size = new System.Drawing.Size(210, 29);
            this.cbxFrom.TabIndex = 3;
            this.cbxFrom.SelectedIndexChanged += new System.EventHandler(this.cbxFrom_SelectedIndexChanged);
            // 
            // cbxTo
            // 
            this.cbxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxTo.FormattingEnabled = true;
            this.cbxTo.Items.AddRange(new object[] {
            "Российский рубль",
            "Доллар США",
            "Евро",
            "Китайский юань",
            "Южнокорейская вона"});
            this.cbxTo.Location = new System.Drawing.Point(82, 91);
            this.cbxTo.Name = "cbxTo";
            this.cbxTo.Size = new System.Drawing.Size(210, 29);
            this.cbxTo.TabIndex = 3;
            this.cbxTo.SelectedIndexChanged += new System.EventHandler(this.cbxTo_SelectedIndexChanged);
            // 
            // btnSwap
            // 
            this.btnSwap.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSwap.Location = new System.Drawing.Point(330, 64);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(61, 44);
            this.btnSwap.TabIndex = 4;
            this.btnSwap.Text = " ⇄";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // txtSumm
            // 
            this.txtSumm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSumm.Location = new System.Drawing.Point(117, 130);
            this.txtSumm.Name = "txtSumm";
            this.txtSumm.Size = new System.Drawing.Size(175, 29);
            this.txtSumm.TabIndex = 5;
            this.txtSumm.TextChanged += new System.EventHandler(this.txtSumm_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResult.Location = new System.Drawing.Point(117, 169);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(175, 29);
            this.txtResult.TabIndex = 5;
            // 
            // lblPreviewFrom
            // 
            this.lblPreviewFrom.AutoSize = true;
            this.lblPreviewFrom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPreviewFrom.Location = new System.Drawing.Point(298, 55);
            this.lblPreviewFrom.Name = "lblPreviewFrom";
            this.lblPreviewFrom.Size = new System.Drawing.Size(20, 21);
            this.lblPreviewFrom.TabIndex = 6;
            this.lblPreviewFrom.Text = "₽";
            // 
            // lblPreviewTo
            // 
            this.lblPreviewTo.AutoSize = true;
            this.lblPreviewTo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPreviewTo.Location = new System.Drawing.Point(298, 94);
            this.lblPreviewTo.Name = "lblPreviewTo";
            this.lblPreviewTo.Size = new System.Drawing.Size(20, 21);
            this.lblPreviewTo.TabIndex = 6;
            this.lblPreviewTo.Text = "₽";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 429);
            this.Controls.Add(this.lblPreviewTo);
            this.Controls.Add(this.lblPreviewFrom);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSumm);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.cbxTo);
            this.Controls.Add(this.cbxFrom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSumm);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.Text = "Конвертер валют";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblSumm;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUsdToRub;
        private System.Windows.Forms.Label lblEurToRub;
        private System.Windows.Forms.Label lblCnyToRub;
        private System.Windows.Forms.Label lblKrwToRub;
        private System.Windows.Forms.ComboBox cbxFrom;
        private System.Windows.Forms.ComboBox cbxTo;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.TextBox txtSumm;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblPreviewFrom;
        private System.Windows.Forms.Label lblPreviewTo;
    }
}

