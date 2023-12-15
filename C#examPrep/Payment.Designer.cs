namespace C_examPrep
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.lbNum = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbFio = new System.Windows.Forms.TextBox();
            this.lbFio = new System.Windows.Forms.Label();
            this.tbINN = new System.Windows.Forms.TextBox();
            this.lbINN = new System.Windows.Forms.Label();
            this.tbBIK = new System.Windows.Forms.TextBox();
            this.lbBIK = new System.Windows.Forms.Label();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.lbSum = new System.Windows.Forms.Label();
            this.tbReceiver = new System.Windows.Forms.TextBox();
            this.lbReceiver = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.lbRub = new System.Windows.Forms.Label();
            this.gbReceiveBank = new System.Windows.Forms.GroupBox();
            this.rbRB_2 = new System.Windows.Forms.RadioButton();
            this.rbRB_1 = new System.Windows.Forms.RadioButton();
            this.rbRB_0 = new System.Windows.Forms.RadioButton();
            this.gbPayBank = new System.Windows.Forms.GroupBox();
            this.rbPB_2 = new System.Windows.Forms.RadioButton();
            this.rbPB_1 = new System.Windows.Forms.RadioButton();
            this.rbPB_0 = new System.Windows.Forms.RadioButton();
            this.gbMain.SuspendLayout();
            this.gbReceiveBank.SuspendLayout();
            this.gbPayBank.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(16, 29);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(157, 27);
            this.lbNum.TabIndex = 0;
            this.lbNum.Text = "Номер перевода:";
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(195, 29);
            this.tbNum.Name = "tbNum";
            this.tbNum.ReadOnly = true;
            this.tbNum.Size = new System.Drawing.Size(249, 33);
            this.tbNum.TabIndex = 1;
            // 
            // tbFio
            // 
            this.tbFio.Location = new System.Drawing.Point(195, 77);
            this.tbFio.Name = "tbFio";
            this.tbFio.Size = new System.Drawing.Size(249, 33);
            this.tbFio.TabIndex = 6;
            // 
            // lbFio
            // 
            this.lbFio.AutoSize = true;
            this.lbFio.Location = new System.Drawing.Point(16, 77);
            this.lbFio.Name = "lbFio";
            this.lbFio.Size = new System.Drawing.Size(177, 27);
            this.lbFio.TabIndex = 5;
            this.lbFio.Text = "ФИО Плательщика:";
            // 
            // tbINN
            // 
            this.tbINN.Location = new System.Drawing.Point(195, 394);
            this.tbINN.Name = "tbINN";
            this.tbINN.Size = new System.Drawing.Size(249, 33);
            this.tbINN.TabIndex = 12;
            // 
            // lbINN
            // 
            this.lbINN.AutoSize = true;
            this.lbINN.Location = new System.Drawing.Point(16, 394);
            this.lbINN.Name = "lbINN";
            this.lbINN.Size = new System.Drawing.Size(53, 27);
            this.lbINN.TabIndex = 11;
            this.lbINN.Text = "ИНН:";
            // 
            // tbBIK
            // 
            this.tbBIK.Location = new System.Drawing.Point(195, 345);
            this.tbBIK.Name = "tbBIK";
            this.tbBIK.Size = new System.Drawing.Size(249, 33);
            this.tbBIK.TabIndex = 10;
            // 
            // lbBIK
            // 
            this.lbBIK.AutoSize = true;
            this.lbBIK.Location = new System.Drawing.Point(16, 345);
            this.lbBIK.Name = "lbBIK";
            this.lbBIK.Size = new System.Drawing.Size(54, 27);
            this.lbBIK.TabIndex = 9;
            this.lbBIK.Text = "БИК:";
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(195, 125);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(208, 33);
            this.tbSum.TabIndex = 8;
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Location = new System.Drawing.Point(16, 125);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(157, 27);
            this.lbSum.TabIndex = 7;
            this.lbSum.Text = "Сумма перевода:";
            // 
            // tbReceiver
            // 
            this.tbReceiver.Location = new System.Drawing.Point(193, 625);
            this.tbReceiver.Name = "tbReceiver";
            this.tbReceiver.Size = new System.Drawing.Size(249, 33);
            this.tbReceiver.TabIndex = 14;
            // 
            // lbReceiver
            // 
            this.lbReceiver.AutoSize = true;
            this.lbReceiver.Location = new System.Drawing.Point(14, 625);
            this.lbReceiver.Name = "lbReceiver";
            this.lbReceiver.Size = new System.Drawing.Size(159, 27);
            this.lbReceiver.TabIndex = 13;
            this.lbReceiver.Text = "Счёт получателя:";
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(545, 74);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(148, 86);
            this.btSend.TabIndex = 15;
            this.btSend.Text = "Отправить";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(545, 179);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(148, 83);
            this.btReset.TabIndex = 16;
            this.btReset.Text = "Отменить";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(12, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(297, 33);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Перевести деньги на счёт";
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.lbRub);
            this.gbMain.Controls.Add(this.gbReceiveBank);
            this.gbMain.Controls.Add(this.gbPayBank);
            this.gbMain.Controls.Add(this.lbNum);
            this.gbMain.Controls.Add(this.tbNum);
            this.gbMain.Controls.Add(this.tbReceiver);
            this.gbMain.Controls.Add(this.lbReceiver);
            this.gbMain.Controls.Add(this.lbFio);
            this.gbMain.Controls.Add(this.tbINN);
            this.gbMain.Controls.Add(this.tbFio);
            this.gbMain.Controls.Add(this.lbINN);
            this.gbMain.Controls.Add(this.lbSum);
            this.gbMain.Controls.Add(this.tbBIK);
            this.gbMain.Controls.Add(this.tbSum);
            this.gbMain.Controls.Add(this.lbBIK);
            this.gbMain.Location = new System.Drawing.Point(18, 45);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(486, 676);
            this.gbMain.TabIndex = 17;
            this.gbMain.TabStop = false;
            // 
            // lbRub
            // 
            this.lbRub.AutoSize = true;
            this.lbRub.Location = new System.Drawing.Point(409, 128);
            this.lbRub.Name = "lbRub";
            this.lbRub.Size = new System.Drawing.Size(45, 27);
            this.lbRub.TabIndex = 17;
            this.lbRub.Text = "руб.";
            // 
            // gbReceiveBank
            // 
            this.gbReceiveBank.Controls.Add(this.rbRB_2);
            this.gbReceiveBank.Controls.Add(this.rbRB_1);
            this.gbReceiveBank.Controls.Add(this.rbRB_0);
            this.gbReceiveBank.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16F);
            this.gbReceiveBank.Location = new System.Drawing.Point(8, 445);
            this.gbReceiveBank.Name = "gbReceiveBank";
            this.gbReceiveBank.Size = new System.Drawing.Size(455, 160);
            this.gbReceiveBank.TabIndex = 16;
            this.gbReceiveBank.TabStop = false;
            this.gbReceiveBank.Text = "Банк получателя";
            // 
            // rbRB_2
            // 
            this.rbRB_2.AutoSize = true;
            this.rbRB_2.Location = new System.Drawing.Point(185, 115);
            this.rbRB_2.Name = "rbRB_2";
            this.rbRB_2.Size = new System.Drawing.Size(270, 31);
            this.rbRB_2.TabIndex = 2;
            this.rbRB_2.TabStop = true;
            this.rbRB_2.Text = "ПАО \"Замечательный Банк\"";
            this.rbRB_2.UseVisualStyleBackColor = true;
            // 
            // rbRB_1
            // 
            this.rbRB_1.AutoSize = true;
            this.rbRB_1.Location = new System.Drawing.Point(185, 78);
            this.rbRB_1.Name = "rbRB_1";
            this.rbRB_1.Size = new System.Drawing.Size(208, 31);
            this.rbRB_1.TabIndex = 1;
            this.rbRB_1.TabStop = true;
            this.rbRB_1.Text = "ПАО \"Главный Банк\"";
            this.rbRB_1.UseVisualStyleBackColor = true;
            // 
            // rbRB_0
            // 
            this.rbRB_0.AutoSize = true;
            this.rbRB_0.Location = new System.Drawing.Point(185, 41);
            this.rbRB_0.Name = "rbRB_0";
            this.rbRB_0.Size = new System.Drawing.Size(201, 31);
            this.rbRB_0.TabIndex = 0;
            this.rbRB_0.TabStop = true;
            this.rbRB_0.Text = "ПАО \"Лучший Банк\"";
            this.rbRB_0.UseVisualStyleBackColor = true;
            // 
            // gbPayBank
            // 
            this.gbPayBank.Controls.Add(this.rbPB_2);
            this.gbPayBank.Controls.Add(this.rbPB_1);
            this.gbPayBank.Controls.Add(this.rbPB_0);
            this.gbPayBank.Location = new System.Drawing.Point(10, 175);
            this.gbPayBank.Name = "gbPayBank";
            this.gbPayBank.Size = new System.Drawing.Size(455, 160);
            this.gbPayBank.TabIndex = 15;
            this.gbPayBank.TabStop = false;
            this.gbPayBank.Text = "Банк плательщика";
            // 
            // rbPB_2
            // 
            this.rbPB_2.AutoSize = true;
            this.rbPB_2.Location = new System.Drawing.Point(185, 115);
            this.rbPB_2.Name = "rbPB_2";
            this.rbPB_2.Size = new System.Drawing.Size(270, 31);
            this.rbPB_2.TabIndex = 2;
            this.rbPB_2.TabStop = true;
            this.rbPB_2.Text = "ПАО \"Замечательный Банк\"";
            this.rbPB_2.UseVisualStyleBackColor = true;
            // 
            // rbPB_1
            // 
            this.rbPB_1.AutoSize = true;
            this.rbPB_1.Location = new System.Drawing.Point(185, 78);
            this.rbPB_1.Name = "rbPB_1";
            this.rbPB_1.Size = new System.Drawing.Size(208, 31);
            this.rbPB_1.TabIndex = 1;
            this.rbPB_1.TabStop = true;
            this.rbPB_1.Text = "ПАО \"Главный Банк\"";
            this.rbPB_1.UseVisualStyleBackColor = true;
            // 
            // rbPB_0
            // 
            this.rbPB_0.AutoSize = true;
            this.rbPB_0.Location = new System.Drawing.Point(185, 41);
            this.rbPB_0.Name = "rbPB_0";
            this.rbPB_0.Size = new System.Drawing.Size(201, 31);
            this.rbPB_0.TabIndex = 0;
            this.rbPB_0.TabStop = true;
            this.rbPB_0.Text = "ПАО \"Лучший Банк\"";
            this.rbPB_0.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(750, 738);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.lbName);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Payment";
            this.Text = "Банковский Перевод";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.gbReceiveBank.ResumeLayout(false);
            this.gbReceiveBank.PerformLayout();
            this.gbPayBank.ResumeLayout(false);
            this.gbPayBank.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbFio;
        private System.Windows.Forms.Label lbFio;
        private System.Windows.Forms.TextBox tbINN;
        private System.Windows.Forms.Label lbINN;
        private System.Windows.Forms.TextBox tbBIK;
        private System.Windows.Forms.Label lbBIK;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.TextBox tbReceiver;
        private System.Windows.Forms.Label lbReceiver;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.GroupBox gbPayBank;
        private System.Windows.Forms.RadioButton rbPB_2;
        private System.Windows.Forms.RadioButton rbPB_1;
        private System.Windows.Forms.RadioButton rbPB_0;
        private System.Windows.Forms.GroupBox gbReceiveBank;
        private System.Windows.Forms.RadioButton rbRB_2;
        private System.Windows.Forms.RadioButton rbRB_1;
        private System.Windows.Forms.RadioButton rbRB_0;
        private System.Windows.Forms.Label lbRub;
    }
}

