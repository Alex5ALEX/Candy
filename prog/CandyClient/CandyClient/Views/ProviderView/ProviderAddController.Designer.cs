namespace CandyClient.Views.ProviderView;

partial class ProviderAddController
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
        labelCompany = new Label();
        labelContactPersom = new Label();
        labelPhone = new Label();
        labelEmail = new Label();
        labelAddres = new Label();
        textBoxContactPerson = new TextBox();
        textBoxCompany = new TextBox();
        textBoxPhone = new TextBox();
        textBoxEmail = new TextBox();
        textBoxAddres = new TextBox();
        groupBox1 = new GroupBox();
        buttonBack = new Button();
        buttonAdd = new Button();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(6, 19);
        label.Name = "label";
        label.Size = new Size(172, 37);
        label.TabIndex = 0;
        label.Text = "Add Provider";
        // 
        // labelCompany
        // 
        labelCompany.AutoSize = true;
        labelCompany.Font = new Font("Segoe UI", 12F);
        labelCompany.Location = new Point(27, 71);
        labelCompany.Name = "labelCompany";
        labelCompany.Size = new Size(80, 21);
        labelCompany.TabIndex = 1;
        labelCompany.Text = "Company:";
        // 
        // labelContactPersom
        // 
        labelContactPersom.AutoSize = true;
        labelContactPersom.Font = new Font("Segoe UI", 12F);
        labelContactPersom.Location = new Point(27, 127);
        labelContactPersom.Name = "labelContactPersom";
        labelContactPersom.Size = new Size(117, 21);
        labelContactPersom.TabIndex = 2;
        labelContactPersom.Text = "Contact Person:";
        // 
        // labelPhone
        // 
        labelPhone.AutoSize = true;
        labelPhone.Font = new Font("Segoe UI", 12F);
        labelPhone.Location = new Point(26, 183);
        labelPhone.Name = "labelPhone";
        labelPhone.Size = new Size(57, 21);
        labelPhone.TabIndex = 3;
        labelPhone.Text = "Phone:";
        // 
        // labelEmail
        // 
        labelEmail.AutoSize = true;
        labelEmail.Font = new Font("Segoe UI", 12F);
        labelEmail.Location = new Point(26, 239);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new Size(51, 21);
        labelEmail.TabIndex = 4;
        labelEmail.Text = "Email:";
        // 
        // labelAddres
        // 
        labelAddres.AutoSize = true;
        labelAddres.Font = new Font("Segoe UI", 12F);
        labelAddres.Location = new Point(26, 295);
        labelAddres.Name = "labelAddres";
        labelAddres.Size = new Size(62, 21);
        labelAddres.TabIndex = 5;
        labelAddres.Text = "Addres:";
        // 
        // textBoxContactPerson
        // 
        textBoxContactPerson.Font = new Font("Segoe UI", 12F);
        textBoxContactPerson.Location = new Point(27, 151);
        textBoxContactPerson.Name = "textBoxContactPerson";
        textBoxContactPerson.Size = new Size(291, 29);
        textBoxContactPerson.TabIndex = 6;
        // 
        // textBoxCompany
        // 
        textBoxCompany.Font = new Font("Segoe UI", 12F);
        textBoxCompany.Location = new Point(27, 95);
        textBoxCompany.Name = "textBoxCompany";
        textBoxCompany.Size = new Size(291, 29);
        textBoxCompany.TabIndex = 7;
        // 
        // textBoxPhone
        // 
        textBoxPhone.Font = new Font("Segoe UI", 12F);
        textBoxPhone.Location = new Point(26, 207);
        textBoxPhone.Name = "textBoxPhone";
        textBoxPhone.Size = new Size(291, 29);
        textBoxPhone.TabIndex = 8;
        // 
        // textBoxEmail
        // 
        textBoxEmail.Font = new Font("Segoe UI", 12F);
        textBoxEmail.Location = new Point(26, 263);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(291, 29);
        textBoxEmail.TabIndex = 9;
        // 
        // textBoxAddres
        // 
        textBoxAddres.Font = new Font("Segoe UI", 12F);
        textBoxAddres.Location = new Point(26, 319);
        textBoxAddres.Name = "textBoxAddres";
        textBoxAddres.Size = new Size(291, 29);
        textBoxAddres.TabIndex = 10;
        // 
        // groupBox1
        // 
        groupBox1.BackColor = SystemColors.ControlLightLight;
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(buttonAdd);
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(labelCompany);
        groupBox1.Controls.Add(labelContactPersom);
        groupBox1.Controls.Add(textBoxAddres);
        groupBox1.Controls.Add(labelPhone);
        groupBox1.Controls.Add(textBoxEmail);
        groupBox1.Controls.Add(labelEmail);
        groupBox1.Controls.Add(textBoxPhone);
        groupBox1.Controls.Add(labelAddres);
        groupBox1.Controls.Add(textBoxCompany);
        groupBox1.Controls.Add(textBoxContactPerson);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(340, 615);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        // 
        // buttonBack
        // 
        buttonBack.BackColor = SystemColors.ControlLightLight;
        buttonBack.FlatStyle = FlatStyle.Flat;
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.Location = new Point(9, 559);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(100, 50);
        buttonBack.TabIndex = 14;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = false;
        // 
        // buttonAdd
        // 
        buttonAdd.BackColor = Color.SpringGreen;
        buttonAdd.FlatStyle = FlatStyle.Flat;
        buttonAdd.Font = new Font("Segoe UI", 12F);
        buttonAdd.Location = new Point(237, 559);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(100, 50);
        buttonAdd.TabIndex = 13;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = false;
        // 
        // ProviderAddController
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBox1);
        Name = "ProviderAddController";
        Size = new Size(340, 615);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label label;
    private Label labelCompany;
    private Label labelContactPersom;
    private Label labelPhone;
    private Label labelEmail;
    private Label labelAddres;
    private TextBox textBoxContactPerson;
    private TextBox textBoxCompany;
    private TextBox textBoxPhone;
    private TextBox textBoxEmail;
    private TextBox textBoxAddres;
    private GroupBox groupBox1;
    private Button buttonBack;
    private Button buttonAdd;
}
