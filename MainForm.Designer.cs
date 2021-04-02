
namespace AutoShop
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
            this.shopList = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addShop = new System.Windows.Forms.Button();
            this.editShop = new System.Windows.Forms.Button();
            this.deleteShop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteClient = new System.Windows.Forms.Button();
            this.editClient = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            this.clientsList = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deleteAuto = new System.Windows.Forms.Button();
            this.editAuto = new System.Windows.Forms.Button();
            this.addAuto = new System.Windows.Forms.Button();
            this.autosList = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.searchAuto = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // shopList
            // 
            this.shopList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopList.FormattingEnabled = true;
            this.shopList.Location = new System.Drawing.Point(3, 3);
            this.shopList.Name = "shopList";
            this.shopList.Size = new System.Drawing.Size(286, 379);
            this.shopList.TabIndex = 0;
            this.shopList.SelectedIndexChanged += new System.EventHandler(this.shopList_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(300, 411);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.shopList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(292, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Магазины";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.clientsList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(292, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Клиенты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.deleteShop);
            this.panel1.Controls.Add(this.editShop);
            this.panel1.Controls.Add(this.addShop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 36);
            this.panel1.TabIndex = 1;
            // 
            // addShop
            // 
            this.addShop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addShop.Location = new System.Drawing.Point(6, 6);
            this.addShop.Name = "addShop";
            this.addShop.Size = new System.Drawing.Size(75, 23);
            this.addShop.TabIndex = 0;
            this.addShop.Text = "Добавить";
            this.addShop.UseVisualStyleBackColor = true;
            this.addShop.Click += new System.EventHandler(this.addShop_Click);
            // 
            // editShop
            // 
            this.editShop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editShop.Location = new System.Drawing.Point(105, 6);
            this.editShop.Name = "editShop";
            this.editShop.Size = new System.Drawing.Size(75, 23);
            this.editShop.TabIndex = 0;
            this.editShop.Text = "Изменить";
            this.editShop.UseVisualStyleBackColor = true;
            this.editShop.Click += new System.EventHandler(this.editShop_Click);
            // 
            // deleteShop
            // 
            this.deleteShop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteShop.Location = new System.Drawing.Point(206, 6);
            this.deleteShop.Name = "deleteShop";
            this.deleteShop.Size = new System.Drawing.Size(75, 23);
            this.deleteShop.TabIndex = 0;
            this.deleteShop.Text = "Удалить";
            this.deleteShop.UseVisualStyleBackColor = true;
            this.deleteShop.Click += new System.EventHandler(this.deleteShop_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.deleteClient);
            this.panel2.Controls.Add(this.editClient);
            this.panel2.Controls.Add(this.addClient);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 36);
            this.panel2.TabIndex = 3;
            // 
            // deleteClient
            // 
            this.deleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteClient.Location = new System.Drawing.Point(208, 5);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(73, 23);
            this.deleteClient.TabIndex = 0;
            this.deleteClient.Text = "Удалить";
            this.deleteClient.UseVisualStyleBackColor = true;
            this.deleteClient.Click += new System.EventHandler(this.deleteClient_Click);
            // 
            // editClient
            // 
            this.editClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editClient.Location = new System.Drawing.Point(106, 6);
            this.editClient.Name = "editClient";
            this.editClient.Size = new System.Drawing.Size(73, 23);
            this.editClient.TabIndex = 0;
            this.editClient.Text = "Изменить";
            this.editClient.UseVisualStyleBackColor = true;
            this.editClient.Click += new System.EventHandler(this.editClient_Click);
            // 
            // addClient
            // 
            this.addClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addClient.Location = new System.Drawing.Point(3, 6);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(73, 23);
            this.addClient.TabIndex = 0;
            this.addClient.Text = "Добавить";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // clientsList
            // 
            this.clientsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsList.FormattingEnabled = true;
            this.clientsList.Location = new System.Drawing.Point(3, 3);
            this.clientsList.Name = "clientsList";
            this.clientsList.Size = new System.Drawing.Size(286, 379);
            this.clientsList.TabIndex = 2;
            this.clientsList.SelectedIndexChanged += new System.EventHandler(this.clientsList_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.searchAuto);
            this.panel3.Controls.Add(this.deleteAuto);
            this.panel3.Controls.Add(this.editAuto);
            this.panel3.Controls.Add(this.addAuto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(300, 368);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 43);
            this.panel3.TabIndex = 2;
            // 
            // deleteAuto
            // 
            this.deleteAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteAuto.Location = new System.Drawing.Point(168, 6);
            this.deleteAuto.Name = "deleteAuto";
            this.deleteAuto.Size = new System.Drawing.Size(75, 23);
            this.deleteAuto.TabIndex = 1;
            this.deleteAuto.Text = "Удалить";
            this.deleteAuto.UseVisualStyleBackColor = true;
            this.deleteAuto.Click += new System.EventHandler(this.deleteAuto_Click);
            // 
            // editAuto
            // 
            this.editAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editAuto.Location = new System.Drawing.Point(87, 6);
            this.editAuto.Name = "editAuto";
            this.editAuto.Size = new System.Drawing.Size(75, 23);
            this.editAuto.TabIndex = 2;
            this.editAuto.Text = "Изменить";
            this.editAuto.UseVisualStyleBackColor = true;
            this.editAuto.Click += new System.EventHandler(this.editAuto_Click);
            // 
            // addAuto
            // 
            this.addAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addAuto.Location = new System.Drawing.Point(6, 6);
            this.addAuto.Name = "addAuto";
            this.addAuto.Size = new System.Drawing.Size(75, 23);
            this.addAuto.TabIndex = 3;
            this.addAuto.Text = "Добавить";
            this.addAuto.UseVisualStyleBackColor = true;
            this.addAuto.Click += new System.EventHandler(this.addAuto_Click);
            // 
            // autosList
            // 
            this.autosList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autosList.FormattingEnabled = true;
            this.autosList.Location = new System.Drawing.Point(300, 23);
            this.autosList.Name = "autosList";
            this.autosList.Size = new System.Drawing.Size(334, 345);
            this.autosList.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(300, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 23);
            this.panel4.TabIndex = 4;
            // 
            // searchAuto
            // 
            this.searchAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchAuto.Location = new System.Drawing.Point(249, 6);
            this.searchAuto.Name = "searchAuto";
            this.searchAuto.Size = new System.Drawing.Size(75, 23);
            this.searchAuto.TabIndex = 1;
            this.searchAuto.Text = "Найти...";
            this.searchAuto.UseVisualStyleBackColor = true;
            this.searchAuto.Click += new System.EventHandler(this.searchAuto_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.autosList);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(610, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информационная система \"Продажа автомобилей\"";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox shopList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteShop;
        private System.Windows.Forms.Button editShop;
        private System.Windows.Forms.Button addShop;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteClient;
        private System.Windows.Forms.Button editClient;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.ListBox clientsList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button searchAuto;
        private System.Windows.Forms.Button deleteAuto;
        private System.Windows.Forms.Button editAuto;
        private System.Windows.Forms.Button addAuto;
        private System.Windows.Forms.ListBox autosList;
        private System.Windows.Forms.Panel panel4;
    }
}

