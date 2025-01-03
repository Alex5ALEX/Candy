namespace CandyClient.Views.CustomerView;

partial class CustomerEditController
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
        buttonBack = new Button();
        buttonEdit = new Button();
        label = new Label();
        buttonDelete = new Button();
        groupBox1 = new GroupBox();
        labelName = new Label();
        labelSurname = new Label();
        textBoxAddres = new TextBox();
        labelPhone = new Label();
        textBoxEmail = new TextBox();
        labelEmail = new Label();
        textBoxPhone = new TextBox();
        labelAddres = new Label();
        textBoxName = new TextBox();
        textBoxSurname = new TextBox();
        textBoxPassword = new TextBox();
        label2 = new Label();
        textBoxLogin = new TextBox();
        label1 = new Label();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // buttonBack
        // 
        buttonBack.FlatStyle = FlatStyle.Flat;
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.ForeColor = SystemColors.ControlText;
        buttonBack.Location = new Point(3, 745);
        buttonBack.Margin = new Padding(3, 4, 3, 4);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(114, 67);
        buttonBack.TabIndex = 25;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = true;
        // 
        // buttonEdit
        // 
        buttonEdit.BackColor = Color.Aqua;
        buttonEdit.FlatStyle = FlatStyle.Flat;
        buttonEdit.Font = new Font("Segoe UI", 12F);
        buttonEdit.ForeColor = SystemColors.ControlText;
        buttonEdit.Location = new Point(271, 745);
        buttonEdit.Margin = new Padding(3, 4, 3, 4);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(114, 67);
        buttonEdit.TabIndex = 24;
        buttonEdit.Text = "Edit";
        buttonEdit.UseVisualStyleBackColor = false;
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(7, 25);
        label.Name = "label";
        label.Size = new Size(231, 46);
        label.TabIndex = 13;
        label.Text = "Edit Customer";
        // 
        // buttonDelete
        // 
        buttonDelete.BackColor = Color.Red;
        buttonDelete.FlatStyle = FlatStyle.Flat;
        buttonDelete.Font = new Font("Segoe UI", 12F);
        buttonDelete.ForeColor = SystemColors.ControlText;
        buttonDelete.Location = new Point(137, 745);
        buttonDelete.Margin = new Padding(3, 4, 3, 4);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(114, 67);
        buttonDelete.TabIndex = 28;
        buttonDelete.Text = "Delete";
        buttonDelete.UseVisualStyleBackColor = false;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(textBoxPassword);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(textBoxLogin);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(labelName);
        groupBox1.Controls.Add(labelSurname);
        groupBox1.Controls.Add(textBoxAddres);
        groupBox1.Controls.Add(labelPhone);
        groupBox1.Controls.Add(textBoxEmail);
        groupBox1.Controls.Add(labelEmail);
        groupBox1.Controls.Add(textBoxPhone);
        groupBox1.Controls.Add(labelAddres);
        groupBox1.Controls.Add(textBoxName);
        groupBox1.Controls.Add(textBoxSurname);
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(buttonDelete);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(buttonEdit);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Margin = new Padding(3, 4, 3, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 4, 3, 4);
        groupBox1.Size = new Size(389, 820);
        groupBox1.TabIndex = 29;
        groupBox1.TabStop = false;
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Font = new Font("Segoe UI", 12F);
        labelName.Location = new Point(25, 100);
        labelName.Name = "labelName";
        labelName.Size = new Size(68, 28);
        labelName.TabIndex = 29;
        labelName.Text = "Name:";
        // 
        // labelSurname
        // 
        labelSurname.AutoSize = true;
        labelSurname.Font = new Font("Segoe UI", 12F);
        labelSurname.Location = new Point(25, 175);
        labelSurname.Name = "labelSurname";
        labelSurname.Size = new Size(93, 28);
        labelSurname.TabIndex = 30;
        labelSurname.Text = "Surname:";
        // 
        // textBoxAddres
        // 
        textBoxAddres.Font = new Font("Segoe UI", 12F);
        textBoxAddres.Location = new Point(25, 431);
        textBoxAddres.Margin = new Padding(3, 4, 3, 4);
        textBoxAddres.Name = "textBoxAddres";
        textBoxAddres.Size = new Size(332, 34);
        textBoxAddres.TabIndex = 38;
        // 
        // labelPhone
        // 
        labelPhone.AutoSize = true;
        labelPhone.Font = new Font("Segoe UI", 12F);
        labelPhone.Location = new Point(25, 249);
        labelPhone.Name = "labelPhone";
        labelPhone.Size = new Size(71, 28);
        labelPhone.TabIndex = 31;
        labelPhone.Text = "Phone:";
        // 
        // textBoxEmail
        // 
        textBoxEmail.Font = new Font("Segoe UI", 12F);
        textBoxEmail.Location = new Point(25, 356);
        textBoxEmail.Margin = new Padding(3, 4, 3, 4);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(332, 34);
        textBoxEmail.TabIndex = 37;
        // 
        // labelEmail
        // 
        labelEmail.AutoSize = true;
        labelEmail.Font = new Font("Segoe UI", 12F);
        labelEmail.Location = new Point(25, 324);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new Size(63, 28);
        labelEmail.TabIndex = 32;
        labelEmail.Text = "Email:";
        // 
        // textBoxPhone
        // 
        textBoxPhone.Font = new Font("Segoe UI", 12F);
        textBoxPhone.Location = new Point(25, 281);
        textBoxPhone.Margin = new Padding(3, 4, 3, 4);
        textBoxPhone.Name = "textBoxPhone";
        textBoxPhone.Size = new Size(332, 34);
        textBoxPhone.TabIndex = 36;
        // 
        // labelAddres
        // 
        labelAddres.AutoSize = true;
        labelAddres.Font = new Font("Segoe UI", 12F);
        labelAddres.Location = new Point(25, 399);
        labelAddres.Name = "labelAddres";
        labelAddres.Size = new Size(78, 28);
        labelAddres.TabIndex = 33;
        labelAddres.Text = "Addres:";
        // 
        // textBoxName
        // 
        textBoxName.Font = new Font("Segoe UI", 12F);
        textBoxName.Location = new Point(25, 132);
        textBoxName.Margin = new Padding(3, 4, 3, 4);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(332, 34);
        textBoxName.TabIndex = 35;
        // 
        // textBoxSurname
        // 
        textBoxSurname.Font = new Font("Segoe UI", 12F);
        textBoxSurname.Location = new Point(25, 207);
        textBoxSurname.Margin = new Padding(3, 4, 3, 4);
        textBoxSurname.Name = "textBoxSurname";
        textBoxSurname.Size = new Size(332, 34);
        textBoxSurname.TabIndex = 34;
        // 
        // textBoxPassword
        // 
        textBoxPassword.Font = new Font("Segoe UI", 12F);
        textBoxPassword.Location = new Point(25, 581);
        textBoxPassword.Margin = new Padding(3, 4, 3, 4);
        textBoxPassword.Name = "textBoxPassword";
        textBoxPassword.Size = new Size(332, 34);
        textBoxPassword.TabIndex = 42;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F);
        label2.Location = new Point(25, 549);
        label2.Name = "label2";
        label2.Size = new Size(97, 28);
        label2.TabIndex = 41;
        label2.Text = "Password:";
        // 
        // textBoxLogin
        // 
        textBoxLogin.Font = new Font("Segoe UI", 12F);
        textBoxLogin.Location = new Point(25, 506);
        textBoxLogin.Margin = new Padding(3, 4, 3, 4);
        textBoxLogin.Name = "textBoxLogin";
        textBoxLogin.Size = new Size(332, 34);
        textBoxLogin.TabIndex = 40;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F);
        label1.Location = new Point(25, 474);
        label1.Name = "label1";
        label1.Size = new Size(65, 28);
        label1.TabIndex = 39;
        label1.Text = "Login:";
        // 
        // CustomerEditController
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "CustomerEditController";
        Size = new Size(389, 820);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button buttonBack;
    private Button buttonEdit;
    private Label label;
    private Button buttonDelete;
    private GroupBox groupBox1;
    private Label labelName;
    private Label labelSurname;
    private TextBox textBoxAddres;
    private Label labelPhone;
    private TextBox textBoxEmail;
    private Label labelEmail;
    private TextBox textBoxPhone;
    private Label labelAddres;
    private TextBox textBoxName;
    private TextBox textBoxSurname;
    private TextBox textBoxPassword;
    private Label label2;
    private TextBox textBoxLogin;
    private Label label1;
}
