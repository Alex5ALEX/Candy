namespace CandyClient.Views.CustomerView;

partial class CustomerAddController
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
        label = new Label();
        labelName = new Label();
        labelSurname = new Label();
        labelPhone = new Label();
        labelEmail = new Label();
        labelAddres = new Label();
        textBoxSurname = new TextBox();
        textBoxName = new TextBox();
        textBoxPhone = new TextBox();
        textBoxEmail = new TextBox();
        textBoxAddres = new TextBox();
        buttonAdd = new Button();
        buttonBack = new Button();
        groupBox1 = new GroupBox();
        textBoxPassword = new TextBox();
        label2 = new Label();
        textBoxLogin = new TextBox();
        label1 = new Label();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(6, 19);
        label.Name = "label";
        label.Size = new Size(187, 37);
        label.TabIndex = 0;
        label.Text = "Add Customer";
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Font = new Font("Segoe UI", 12F);
        labelName.Location = new Point(23, 81);
        labelName.Name = "labelName";
        labelName.Size = new Size(55, 21);
        labelName.TabIndex = 1;
        labelName.Text = "Name:";
        // 
        // labelSurname
        // 
        labelSurname.AutoSize = true;
        labelSurname.Font = new Font("Segoe UI", 12F);
        labelSurname.Location = new Point(23, 137);
        labelSurname.Name = "labelSurname";
        labelSurname.Size = new Size(76, 21);
        labelSurname.TabIndex = 2;
        labelSurname.Text = "Surname:";
        // 
        // labelPhone
        // 
        labelPhone.AutoSize = true;
        labelPhone.Font = new Font("Segoe UI", 12F);
        labelPhone.Location = new Point(23, 193);
        labelPhone.Name = "labelPhone";
        labelPhone.Size = new Size(57, 21);
        labelPhone.TabIndex = 3;
        labelPhone.Text = "Phone:";
        // 
        // labelEmail
        // 
        labelEmail.AutoSize = true;
        labelEmail.Font = new Font("Segoe UI", 12F);
        labelEmail.Location = new Point(23, 249);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new Size(51, 21);
        labelEmail.TabIndex = 4;
        labelEmail.Text = "Email:";
        // 
        // labelAddres
        // 
        labelAddres.AutoSize = true;
        labelAddres.Font = new Font("Segoe UI", 12F);
        labelAddres.Location = new Point(23, 305);
        labelAddres.Name = "labelAddres";
        labelAddres.Size = new Size(69, 21);
        labelAddres.TabIndex = 5;
        labelAddres.Text = "Address:";
        // 
        // textBoxSurname
        // 
        textBoxSurname.Font = new Font("Segoe UI", 12F);
        textBoxSurname.Location = new Point(23, 161);
        textBoxSurname.Name = "textBoxSurname";
        textBoxSurname.Size = new Size(291, 29);
        textBoxSurname.TabIndex = 6;
        // 
        // textBoxName
        // 
        textBoxName.Font = new Font("Segoe UI", 12F);
        textBoxName.Location = new Point(23, 105);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(291, 29);
        textBoxName.TabIndex = 7;
        // 
        // textBoxPhone
        // 
        textBoxPhone.Font = new Font("Segoe UI", 12F);
        textBoxPhone.Location = new Point(23, 217);
        textBoxPhone.Name = "textBoxPhone";
        textBoxPhone.Size = new Size(291, 29);
        textBoxPhone.TabIndex = 8;
        // 
        // textBoxEmail
        // 
        textBoxEmail.Font = new Font("Segoe UI", 12F);
        textBoxEmail.Location = new Point(23, 273);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(291, 29);
        textBoxEmail.TabIndex = 9;
        // 
        // textBoxAddres
        // 
        textBoxAddres.Font = new Font("Segoe UI", 12F);
        textBoxAddres.Location = new Point(23, 329);
        textBoxAddres.Name = "textBoxAddres";
        textBoxAddres.Size = new Size(291, 29);
        textBoxAddres.TabIndex = 10;
        // 
        // buttonAdd
        // 
        buttonAdd.BackColor = Color.SpringGreen;
        buttonAdd.FlatStyle = FlatStyle.Flat;
        buttonAdd.Font = new Font("Segoe UI", 12F);
        buttonAdd.Location = new Point(234, 559);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(100, 50);
        buttonAdd.TabIndex = 11;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = false;
        // 
        // buttonBack
        // 
        buttonBack.BackColor = SystemColors.ControlLightLight;
        buttonBack.FlatStyle = FlatStyle.Flat;
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.Location = new Point(6, 559);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(100, 50);
        buttonBack.TabIndex = 12;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = false;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(textBoxPassword);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(textBoxLogin);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(labelName);
        groupBox1.Controls.Add(buttonAdd);
        groupBox1.Controls.Add(labelSurname);
        groupBox1.Controls.Add(textBoxAddres);
        groupBox1.Controls.Add(labelPhone);
        groupBox1.Controls.Add(textBoxEmail);
        groupBox1.Controls.Add(labelEmail);
        groupBox1.Controls.Add(textBoxPhone);
        groupBox1.Controls.Add(labelAddres);
        groupBox1.Controls.Add(textBoxName);
        groupBox1.Controls.Add(textBoxSurname);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(340, 615);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        // 
        // textBoxPassword
        // 
        textBoxPassword.Font = new Font("Segoe UI", 12F);
        textBoxPassword.Location = new Point(23, 446);
        textBoxPassword.Name = "textBoxPassword";
        textBoxPassword.Size = new Size(291, 29);
        textBoxPassword.TabIndex = 33;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F);
        label2.Location = new Point(23, 422);
        label2.Name = "label2";
        label2.Size = new Size(79, 21);
        label2.TabIndex = 32;
        label2.Text = "Password:";
        // 
        // textBoxLogin
        // 
        textBoxLogin.Font = new Font("Segoe UI", 12F);
        textBoxLogin.Location = new Point(23, 389);
        textBoxLogin.Name = "textBoxLogin";
        textBoxLogin.Size = new Size(291, 29);
        textBoxLogin.TabIndex = 31;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F);
        label1.Location = new Point(23, 365);
        label1.Name = "label1";
        label1.Size = new Size(52, 21);
        label1.TabIndex = 30;
        label1.Text = "Login:";
        // 
        // CustomerAddController
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBox1);
        Name = "CustomerAddController";
        Size = new Size(340, 615);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label label;
    private Label labelName;
    private Label labelSurname;
    private Label labelPhone;
    private Label labelEmail;
    private Label labelAddres;
    private TextBox textBoxSurname;
    private TextBox textBoxName;
    private TextBox textBoxPhone;
    private TextBox textBoxEmail;
    private TextBox textBoxAddres;
    private Button buttonAdd;
    private Button buttonBack;
    private GroupBox groupBox1;
    private TextBox textBoxPassword;
    private Label label2;
    private TextBox textBoxLogin;
    private Label label1;
}
