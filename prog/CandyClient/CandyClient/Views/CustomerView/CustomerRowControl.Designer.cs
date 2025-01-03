namespace CandyClient.Views.CustomerView;

partial class CustomerRowControl
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

    #region Код, автоматически созданный конструктором компонентов

    /// <summary> 
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
        labelName = new Label();
        labelSurname = new Label();
        labelSurnameText = new Label();
        labelNameText = new Label();
        labelPhone = new Label();
        labelPhoneText = new Label();
        labelEmail = new Label();
        labelEmailText = new Label();
        labelAddres = new Label();
        labelAddresText = new Label();
        groupBox1 = new GroupBox();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Font = new Font("Segoe UI", 12F);
        labelName.Location = new Point(6, 19);
        labelName.Name = "labelName";
        labelName.Size = new Size(55, 21);
        labelName.TabIndex = 2;
        labelName.Text = "Name:";
        // 
        // labelSurname
        // 
        labelSurname.AutoSize = true;
        labelSurname.Font = new Font("Segoe UI", 12F);
        labelSurname.Location = new Point(6, 49);
        labelSurname.Name = "labelSurname";
        labelSurname.Size = new Size(76, 21);
        labelSurname.TabIndex = 3;
        labelSurname.Text = "Surname:";
        // 
        // labelSurnameText
        // 
        labelSurnameText.AutoSize = true;
        labelSurnameText.Font = new Font("Segoe UI", 12F);
        labelSurnameText.Location = new Point(88, 49);
        labelSurnameText.Name = "labelSurnameText";
        labelSurnameText.Size = new Size(124, 21);
        labelSurnameText.TabIndex = 5;
        labelSurnameText.Text = "TEXT_SURNAME";
        // 
        // labelNameText
        // 
        labelNameText.AutoSize = true;
        labelNameText.Font = new Font("Segoe UI", 12F);
        labelNameText.Location = new Point(88, 19);
        labelNameText.Name = "labelNameText";
        labelNameText.Size = new Size(94, 21);
        labelNameText.TabIndex = 4;
        labelNameText.Text = "TEXT_NAME";
        // 
        // labelPhone
        // 
        labelPhone.AutoSize = true;
        labelPhone.Font = new Font("Segoe UI", 12F);
        labelPhone.Location = new Point(302, 19);
        labelPhone.Name = "labelPhone";
        labelPhone.Size = new Size(57, 21);
        labelPhone.TabIndex = 6;
        labelPhone.Text = "Phone:";
        // 
        // labelPhoneText
        // 
        labelPhoneText.AutoSize = true;
        labelPhoneText.Font = new Font("Segoe UI", 12F);
        labelPhoneText.Location = new Point(357, 19);
        labelPhoneText.Name = "labelPhoneText";
        labelPhoneText.Size = new Size(102, 21);
        labelPhoneText.TabIndex = 7;
        labelPhoneText.Text = "TEXT_PHONE";
        // 
        // labelEmail
        // 
        labelEmail.AutoSize = true;
        labelEmail.Font = new Font("Segoe UI", 12F);
        labelEmail.Location = new Point(302, 49);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new Size(51, 21);
        labelEmail.TabIndex = 8;
        labelEmail.Text = "Email:";
        // 
        // labelEmailText
        // 
        labelEmailText.AutoSize = true;
        labelEmailText.Font = new Font("Segoe UI", 12F);
        labelEmailText.Location = new Point(357, 49);
        labelEmailText.Name = "labelEmailText";
        labelEmailText.Size = new Size(94, 21);
        labelEmailText.TabIndex = 9;
        labelEmailText.Text = "TEXT_EMAIL";
        // 
        // labelAddres
        // 
        labelAddres.AutoSize = true;
        labelAddres.Font = new Font("Segoe UI", 12F);
        labelAddres.Location = new Point(581, 19);
        labelAddres.Name = "labelAddres";
        labelAddres.Size = new Size(62, 21);
        labelAddres.TabIndex = 10;
        labelAddres.Text = "Addres:";
        // 
        // labelAddresText
        // 
        labelAddresText.AutoSize = true;
        labelAddresText.Font = new Font("Segoe UI", 12F);
        labelAddresText.Location = new Point(649, 19);
        labelAddresText.Name = "labelAddresText";
        labelAddresText.Size = new Size(109, 21);
        labelAddresText.TabIndex = 11;
        labelAddresText.Text = "TEXT_ADDRES";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(labelPhoneText);
        groupBox1.Controls.Add(labelAddresText);
        groupBox1.Controls.Add(labelPhone);
        groupBox1.Controls.Add(labelAddres);
        groupBox1.Controls.Add(labelSurnameText);
        groupBox1.Controls.Add(labelEmailText);
        groupBox1.Controls.Add(labelSurname);
        groupBox1.Controls.Add(labelNameText);
        groupBox1.Controls.Add(labelEmail);
        groupBox1.Controls.Add(labelName);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(873, 85);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        // 
        // CustomerRowControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Name = "CustomerRowControl";
        Size = new Size(873, 85);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private Label labelName;
    private Label labelSurname;
    private Label labelSurnameText;
    private Label labelNameText;
    private Label labelPhone;
    private Label labelPhoneText;
    private Label labelEmail;
    private Label labelEmailText;
    private Label labelAddres;
    private Label labelAddresText;
    private GroupBox groupBox1;
}
