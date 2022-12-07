namespace ExerciceTest
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonNotifications = new System.Windows.Forms.Button();
            this.buttonReporting = new System.Windows.Forms.Button();
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonNotifications);
            this.panelMenu.Controls.Add(this.buttonReporting);
            this.panelMenu.Controls.Add(this.buttonCustomers);
            this.panelMenu.Controls.Add(this.buttonOrders);
            this.panelMenu.Controls.Add(this.buttonProducts);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 399);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonSettings.Image = global::ExerciceTest.Properties.Resources.Settings_icon;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSettings.Location = new System.Drawing.Point(0, 255);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(150, 40);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.Text = "  Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonNotifications
            // 
            this.buttonNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNotifications.FlatAppearance.BorderSize = 0;
            this.buttonNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotifications.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonNotifications.Image = global::ExerciceTest.Properties.Resources.preferences_desktop_notification_bell_icon;
            this.buttonNotifications.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonNotifications.Location = new System.Drawing.Point(0, 215);
            this.buttonNotifications.Name = "buttonNotifications";
            this.buttonNotifications.Size = new System.Drawing.Size(150, 40);
            this.buttonNotifications.TabIndex = 5;
            this.buttonNotifications.Text = "  Notifications";
            this.buttonNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNotifications.UseVisualStyleBackColor = true;
            this.buttonNotifications.Click += new System.EventHandler(this.buttonNotifications_Click);
            // 
            // buttonReporting
            // 
            this.buttonReporting.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReporting.FlatAppearance.BorderSize = 0;
            this.buttonReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReporting.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonReporting.Image = global::ExerciceTest.Properties.Resources.SEO_icon;
            this.buttonReporting.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonReporting.Location = new System.Drawing.Point(0, 175);
            this.buttonReporting.Name = "buttonReporting";
            this.buttonReporting.Size = new System.Drawing.Size(150, 40);
            this.buttonReporting.TabIndex = 4;
            this.buttonReporting.Text = "  Reporting";
            this.buttonReporting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReporting.UseVisualStyleBackColor = true;
            this.buttonReporting.Click += new System.EventHandler(this.buttonReporting_Click);
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCustomers.FlatAppearance.BorderSize = 0;
            this.buttonCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomers.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonCustomers.Image = global::ExerciceTest.Properties.Resources.user_group_icon;
            this.buttonCustomers.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCustomers.Location = new System.Drawing.Point(0, 135);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(150, 40);
            this.buttonCustomers.TabIndex = 3;
            this.buttonCustomers.Text = "  Customers";
            this.buttonCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCustomers.UseVisualStyleBackColor = true;
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrders.FlatAppearance.BorderSize = 0;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonOrders.Image = global::ExerciceTest.Properties.Resources.Order_history_icon;
            this.buttonOrders.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonOrders.Location = new System.Drawing.Point(0, 95);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(150, 40);
            this.buttonOrders.TabIndex = 2;
            this.buttonOrders.Text = "  Orders";
            this.buttonOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProducts.FlatAppearance.BorderSize = 0;
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProducts.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonProducts.Image = global::ExerciceTest.Properties.Resources.Cart_icon;
            this.buttonProducts.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonProducts.Location = new System.Drawing.Point(0, 55);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(150, 40);
            this.buttonProducts.TabIndex = 1;
            this.buttonProducts.Text = "  Products";
            this.buttonProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(150, 55);
            this.panelLogo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(795, 399);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonNotifications;
        private System.Windows.Forms.Button buttonReporting;
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.Button buttonOrders;
    }
}
    
