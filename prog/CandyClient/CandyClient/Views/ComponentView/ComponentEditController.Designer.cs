namespace CandyClient.Views.ComponentView;

partial class ComponentEditController
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
        textBoxName = new TextBox();
        labelPrice = new Label();
        labelName = new Label();
        label = new Label();
        groupBox1 = new GroupBox();
        numericUpDown1 = new NumericUpDown();
        buttonDelete = new Button();
        buttonBack = new Button();
        buttonEdit = new Button();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        SuspendLayout();
        // 
        // textBoxName
        // 
        textBoxName.Font = new Font("Segoe UI", 12F);
        textBoxName.Location = new Point(28, 92);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(291, 29);
        textBoxName.TabIndex = 20;
        // 
        // labelPrice
        // 
        labelPrice.AutoSize = true;
        labelPrice.Font = new Font("Segoe UI", 12F);
        labelPrice.Location = new Point(28, 124);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(47, 21);
        labelPrice.TabIndex = 15;
        labelPrice.Text = "Price:";
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Font = new Font("Segoe UI", 12F);
        labelName.Location = new Point(28, 68);
        labelName.Name = "labelName";
        labelName.Size = new Size(55, 21);
        labelName.TabIndex = 14;
        labelName.Text = "Name:";
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(6, 19);
        label.Name = "label";
        label.Size = new Size(211, 37);
        label.TabIndex = 13;
        label.Text = "Edit Component";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(numericUpDown1);
        groupBox1.Controls.Add(buttonDelete);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(buttonEdit);
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(labelName);
        groupBox1.Controls.Add(labelPrice);
        groupBox1.Controls.Add(textBoxName);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(340, 615);
        groupBox1.TabIndex = 29;
        groupBox1.TabStop = false;
        // 
        // numericUpDown1
        // 
        numericUpDown1.DecimalPlaces = 2;
        numericUpDown1.Font = new Font("Segoe UI", 12F);
        numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
        numericUpDown1.Location = new Point(28, 148);
        numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(291, 29);
        numericUpDown1.TabIndex = 34;
        // 
        // buttonDelete
        // 
        buttonDelete.BackColor = Color.Red;
        buttonDelete.FlatStyle = FlatStyle.Flat;
        buttonDelete.Font = new Font("Segoe UI", 12F);
        buttonDelete.ForeColor = SystemColors.ControlText;
        buttonDelete.Location = new Point(120, 559);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(100, 50);
        buttonDelete.TabIndex = 33;
        buttonDelete.Text = "Delete";
        buttonDelete.UseVisualStyleBackColor = false;
        // 
        // buttonBack
        // 
        buttonBack.FlatStyle = FlatStyle.Flat;
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.ForeColor = SystemColors.ControlText;
        buttonBack.Location = new Point(3, 559);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(100, 50);
        buttonBack.TabIndex = 32;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = true;
        // 
        // buttonEdit
        // 
        buttonEdit.BackColor = Color.Aqua;
        buttonEdit.FlatStyle = FlatStyle.Flat;
        buttonEdit.Font = new Font("Segoe UI", 12F);
        buttonEdit.ForeColor = SystemColors.ControlText;
        buttonEdit.Location = new Point(237, 559);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(100, 50);
        buttonEdit.TabIndex = 31;
        buttonEdit.Text = "Edit";
        buttonEdit.UseVisualStyleBackColor = false;
        // 
        // ComponentEditController
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBox1);
        Name = "ComponentEditController";
        Size = new Size(340, 615);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private TextBox textBoxAddres;
    private TextBox textBoxEmail;
    private TextBox textBoxPhone;
    private TextBox textBoxName;
    private TextBox textBoxSurname;
    private Label labelAddres;
    private Label labelEmail;
    private Label labelPhone;
    private Label labelPrice;
    private Label labelName;
    private Label label;
    private GroupBox groupBox1;
    private Label labelJobtitle;
    private TextBox textBoxJobtitle;
    private Button buttonDelete;
    private Button buttonBack;
    private Button buttonEdit;
    private NumericUpDown numericUpDown1;
}
