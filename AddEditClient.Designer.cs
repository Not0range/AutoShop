
namespace AutoShop
{
    partial class AddEditClient
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
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.middleName = new System.Windows.Forms.TextBox();
            this.transmission = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.newOrOld = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.power = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.brends = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.contacts = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.power)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(12, 66);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(259, 20);
            this.firstName.TabIndex = 9;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(12, 26);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(259, 20);
            this.lastName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // middleName
            // 
            this.middleName.Location = new System.Drawing.Point(12, 106);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(259, 20);
            this.middleName.TabIndex = 9;
            // 
            // transmission
            // 
            this.transmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transmission.FormattingEnabled = true;
            this.transmission.Items.AddRange(new object[] {
            "Автоматическая",
            "Ручная",
            "Любая"});
            this.transmission.Location = new System.Drawing.Point(10, 146);
            this.transmission.Name = "transmission";
            this.transmission.Size = new System.Drawing.Size(258, 21);
            this.transmission.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Предпочтительная коробка передач";
            // 
            // newOrOld
            // 
            this.newOrOld.AutoSize = true;
            this.newOrOld.Checked = true;
            this.newOrOld.CheckState = System.Windows.Forms.CheckState.Checked;
            this.newOrOld.Location = new System.Drawing.Point(10, 174);
            this.newOrOld.Name = "newOrOld";
            this.newOrOld.Size = new System.Drawing.Size(192, 17);
            this.newOrOld.TabIndex = 12;
            this.newOrOld.Text = "Обязательно новый автомобиль";
            this.newOrOld.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "л.с.";
            // 
            // price
            // 
            this.price.DecimalPlaces = 2;
            this.price.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.price.Location = new System.Drawing.Point(12, 251);
            this.price.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(259, 20);
            this.price.TabIndex = 15;
            this.price.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // power
            // 
            this.power.DecimalPlaces = 2;
            this.power.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.power.Location = new System.Drawing.Point(12, 211);
            this.power.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(230, 20);
            this.power.TabIndex = 16;
            this.power.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Максимальная стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Минимальная мощность";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // brends
            // 
            this.brends.FormattingEnabled = true;
            this.brends.Location = new System.Drawing.Point(277, 26);
            this.brends.Name = "brends";
            this.brends.Size = new System.Drawing.Size(177, 121);
            this.brends.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Предпочитаемые марки";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Контакты";
            // 
            // contacts
            // 
            this.contacts.FormattingEnabled = true;
            this.contacts.Location = new System.Drawing.Point(277, 171);
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(177, 121);
            this.contacts.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(460, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(460, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(457, 306);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 23;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // accept
            // 
            this.accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.accept.Location = new System.Drawing.Point(12, 306);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(75, 23);
            this.accept.TabIndex = 22;
            this.accept.Text = "Добавить";
            this.accept.UseVisualStyleBackColor = true;
            // 
            // AddEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 341);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contacts);
            this.Controls.Add(this.brends);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.price);
            this.Controls.Add(this.power);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newOrOld);
            this.Controls.Add(this.transmission);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditClient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.power)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox firstName;
        public System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox middleName;
        public System.Windows.Forms.ComboBox transmission;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.CheckBox newOrOld;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown price;
        public System.Windows.Forms.NumericUpDown power;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox brends;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ListBox contacts;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button cancel;
        public System.Windows.Forms.Button accept;
    }
}