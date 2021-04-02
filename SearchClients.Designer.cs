
namespace AutoShop
{
    partial class SearchClients
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
            this.clientsList = new System.Windows.Forms.ListBox();
            this.info = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clientsList
            // 
            this.clientsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.clientsList.FormattingEnabled = true;
            this.clientsList.Location = new System.Drawing.Point(0, 0);
            this.clientsList.Name = "clientsList";
            this.clientsList.Size = new System.Drawing.Size(300, 450);
            this.clientsList.TabIndex = 0;
            this.clientsList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // autosList
            // 
            this.info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info.FormattingEnabled = true;
            this.info.Location = new System.Drawing.Point(300, 0);
            this.info.Name = "autosList";
            this.info.Size = new System.Drawing.Size(500, 450);
            this.info.TabIndex = 1;
            // 
            // SearchClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.info);
            this.Controls.Add(this.clientsList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchClients";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск клиентов";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox clientsList;
        private System.Windows.Forms.ListBox info;
    }
}