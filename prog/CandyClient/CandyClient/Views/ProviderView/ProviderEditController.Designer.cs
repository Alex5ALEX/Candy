namespace CandyClient.Views.ProviderView;

partial class ProviderEditController
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
        textBoxAddres = new TextBox();
        textBoxEmail = new TextBox();
        textBoxPhone = new TextBox();
        textBoxCompany = new TextBox();
        textBoxContactPerson = new TextBox();
        labelAddres = new Label();
        labelEmail = new Label();
        labelPhone = new Label();
        labelContactPerson = new Label();
        labelCompany = new Label();
        label = new Label();
        groupBox1 = new GroupBox();
        buttonDelete = new Button();
        buttonBack = new Button();
        buttonEdit = new Button();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // textBoxAddres
        // 
        textBoxAddres.Font = new Font("Segoe UI", 12F);
        textBoxAddres.Location = new Point(36, 314);
        textBoxAddres.Name = "textBoxAddres";
        textBoxAddres.Size = new Size(291, 29);
        textBoxAddres.TabIndex = 23;
        // 
        // textBoxEmail
        // 
        textBoxEmail.Font = new Font("Segoe UI", 12F);
        textBoxEmail.Location = new Point(36, 258);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(291, 29);
        textBoxEmail.TabIndex = 22;
        // 
        // textBoxPhone
        // 
        textBoxPhone.Font = new Font("Segoe UI", 12F);
        textBoxPhone.Location = new Point(36, 202);
        textBoxPhone.Name = "textBoxPhone";
        textBoxPhone.Size = new Size(291, 29);
        textBoxPhone.TabIndex = 21;
        // 
        // textBoxCompany
        // 
        textBoxCompany.Font = new Font("Segoe UI", 12F);
        textBoxCompany.Location = new Point(37, 90);
        textBoxCompany.Name = "textBoxCompany";
        textBoxCompany.Size = new Size(291, 29);
        textBoxCompany.TabIndex = 20;
        // 
        // textBoxContactPerson
        // 
        textBoxContactPerson.Font = new Font("Segoe UI", 12F);
        textBoxContactPerson.Location = new Point(36, 146);
        textBoxContactPerson.Name = "textBoxContactPerson";
        textBoxContactPerson.Size = new Size(291, 29);
        textBoxContactPerson.TabIndex = 19;
        // 
        // labelAddres
        // 
        labelAddres.AutoSize = true;
        labelAddres.Font = new Font("Segoe UI", 12F);
        labelAddres.Location = new Point(36, 290);
        labelAddres.Name = "labelAddres";
        labelAddres.Size = new Size(62, 21);
        labelAddres.TabIndex = 18;
        labelAddres.Text = "Addres:";
        // 
        // labelEmail
        // 
        labelEmail.AutoSize = true;
        labelEmail.Font = new Font("Segoe UI", 12F);
        labelEmail.Location = new Point(36, 234);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new Size(51, 21);
        labelEmail.TabIndex = 17;
        labelEmail.Text = "Email:";
        // 
        // labelPhone
        // 
        labelPhone.AutoSize = true;
        labelPhone.Font = new Font("Segoe UI", 12F);
        labelPhone.Location = new Point(37, 178);
        labelPhone.Name = "labelPhone";
        labelPhone.Size = new Size(57, 21);
        labelPhone.TabIndex = 16;
        labelPhone.Text = "Phone:";
        // 
        // labelContactPerson
        // 
        labelContactPerson.AutoSize = true;
        labelContactPerson.Font = new Font("Segoe UI", 12F);
        labelContactPerson.Location = new Point(36, 122);
        labelContactPerson.Name = "labelContactPerson";
        labelContactPerson.Size = new Size(117, 21);
        labelContactPerson.TabIndex = 15;
        labelContactPerson.Text = "Contact Person:";
        // 
        // labelCompany
        // 
        labelCompany.AutoSize = true;
        labelCompany.Font = new Font("Segoe UI", 12F);
        labelCompany.Location = new Point(37, 66);
        labelCompany.Name = "labelCompany";
        labelCompany.Size = new Size(80, 21);
        labelCompany.TabIndex = 14;
        labelCompany.Text = "Company:";
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(6, 19);
        label.Name = "label";
        label.Size = new Size(169, 37);
        label.TabIndex = 13;
        label.Text = "Edit Provider";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(buttonDelete);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(buttonEdit);
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(labelCompany);
        groupBox1.Controls.Add(labelContactPerson);
        groupBox1.Controls.Add(labelPhone);
        groupBox1.Controls.Add(labelEmail);
        groupBox1.Controls.Add(labelAddres);
        groupBox1.Controls.Add(textBoxAddres);
        groupBox1.Controls.Add(textBoxContactPerson);
        groupBox1.Controls.Add(textBoxEmail);
        groupBox1.Controls.Add(textBoxCompany);
        groupBox1.Controls.Add(textBoxPhone);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(340, 615);
        groupBox1.TabIndex = 29;
        groupBox1.TabStop = false;
        // 
        // buttonDelete
        // 
        buttonDelete.BackColor = Color.Red;
        buttonDelete.FlatStyle = FlatStyle.Flat;
        buttonDelete.Font = new Font("Segoe UI", 12F);
        buttonDelete.ForeColor = SystemColors.ControlText;
        buttonDelete.Location = new Point(121, 559);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(100, 50);
        buttonDelete.TabIndex = 31;
        buttonDelete.Text = "Delete";
        buttonDelete.UseVisualStyleBackColor = false;
        // 
        // buttonBack
        // 
        buttonBack.FlatStyle = FlatStyle.Flat;
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.ForeColor = SystemColors.ControlText;
        buttonBack.Location = new Point(4, 559);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(100, 50);
        buttonBack.TabIndex = 30;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = true;
        // 
        // buttonEdit
        // 
        buttonEdit.BackColor = Color.Aqua;
        buttonEdit.FlatStyle = FlatStyle.Flat;
        buttonEdit.Font = new Font("Segoe UI", 12F);
        buttonEdit.ForeColor = SystemColors.ControlText;
        buttonEdit.Location = new Point(238, 559);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(100, 50);
        buttonEdit.TabIndex = 29;
        buttonEdit.Text = "Edit";
        buttonEdit.UseVisualStyleBackColor = false;
        // 
        // ProviderEditController
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBox1);
        Name = "ProviderEditController";
        Size = new Size(340, 615);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private TextBox textBoxAddres;
    private TextBox textBoxEmail;
    private TextBox textBoxPhone;
    private TextBox textBoxCompany;
    private TextBox textBoxContactPerson;
    private Label labelAddres;
    private Label labelEmail;
    private Label labelPhone;
    private Label labelContactPerson;
    private Label labelCompany;
    private Label label;
    private GroupBox groupBox1;
    private Button buttonDelete;
    private Button buttonBack;
    private Button buttonEdit;
}
