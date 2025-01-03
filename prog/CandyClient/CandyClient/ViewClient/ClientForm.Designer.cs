namespace CandyClient.ViewClient
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            groupBoxMenu = new GroupBox();
            labelMenu = new Label();
            orderOption = new Button();
            catalogOption = new Button();
            personOption = new Button();
            buttonMenu = new Button();
            pictureBox1 = new PictureBox();
            groupBoxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxMenu
            // 
            groupBoxMenu.BackColor = SystemColors.ControlLightLight;
            groupBoxMenu.Controls.Add(labelMenu);
            groupBoxMenu.Controls.Add(orderOption);
            groupBoxMenu.Controls.Add(catalogOption);
            groupBoxMenu.Controls.Add(personOption);
            groupBoxMenu.FlatStyle = FlatStyle.Flat;
            groupBoxMenu.ForeColor = SystemColors.ControlText;
            groupBoxMenu.Location = new Point(0, 0);
            groupBoxMenu.Margin = new Padding(3, 4, 3, 4);
            groupBoxMenu.Name = "groupBoxMenu";
            groupBoxMenu.Padding = new Padding(3, 4, 3, 4);
            groupBoxMenu.Size = new Size(231, 863);
            groupBoxMenu.TabIndex = 3;
            groupBoxMenu.TabStop = false;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.BackColor = SystemColors.ControlLightLight;
            labelMenu.FlatStyle = FlatStyle.Flat;
            labelMenu.Font = new Font("Segoe UI", 24F);
            labelMenu.ForeColor = SystemColors.ControlText;
            labelMenu.Location = new Point(7, 24);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(116, 50);
            labelMenu.TabIndex = 29;
            labelMenu.Text = "Menu";
            // 
            // orderOption
            // 
            orderOption.BackColor = SystemColors.ControlLightLight;
            orderOption.FlatStyle = FlatStyle.Flat;
            orderOption.Font = new Font("Segoe UI", 12F);
            orderOption.ForeColor = SystemColors.ControlText;
            orderOption.Location = new Point(6, 167);
            orderOption.Margin = new Padding(3, 4, 3, 4);
            orderOption.Name = "orderOption";
            orderOption.Size = new Size(216, 57);
            orderOption.TabIndex = 25;
            orderOption.Text = "Orders";
            orderOption.UseVisualStyleBackColor = false;
            // 
            // catalogOption
            // 
            catalogOption.BackColor = SystemColors.ControlLightLight;
            catalogOption.FlatStyle = FlatStyle.Flat;
            catalogOption.Font = new Font("Segoe UI", 12F);
            catalogOption.ForeColor = SystemColors.ControlText;
            catalogOption.Location = new Point(7, 232);
            catalogOption.Margin = new Padding(3, 4, 3, 4);
            catalogOption.Name = "catalogOption";
            catalogOption.Size = new Size(215, 57);
            catalogOption.TabIndex = 24;
            catalogOption.Text = "Catalog";
            catalogOption.UseVisualStyleBackColor = false;
            // 
            // personOption
            // 
            personOption.BackColor = SystemColors.ControlLightLight;
            personOption.FlatStyle = FlatStyle.Flat;
            personOption.Font = new Font("Segoe UI", 12F);
            personOption.Location = new Point(7, 103);
            personOption.Margin = new Padding(3, 4, 3, 4);
            personOption.Name = "personOption";
            personOption.Size = new Size(215, 57);
            personOption.TabIndex = 23;
            personOption.Text = "Personal Account";
            personOption.UseVisualStyleBackColor = false;
            // 
            // buttonMenu
            // 
            buttonMenu.FlatStyle = FlatStyle.Flat;
            buttonMenu.Font = new Font("Segoe UI", 12F);
            buttonMenu.Location = new Point(3, 4);
            buttonMenu.Margin = new Padding(3, 4, 3, 4);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(91, 70);
            buttonMenu.TabIndex = 4;
            buttonMenu.Text = "Menu";
            buttonMenu.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(532, 147);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1445, 863);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxMenu);
            Controls.Add(buttonMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClientForm";
            Text = "Candy";
            groupBoxMenu.ResumeLayout(false);
            groupBoxMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMenu;
        private Label labelMenu;
        private Button orderOption;
        private Button catalogOption;
        private Button personOption;
        private Button buttonMenu;
        private PictureBox pictureBox1;
    }
}