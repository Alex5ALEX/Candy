namespace CandyClient.Views.OrderView;

partial class OrderRowControl
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
        labelDate = new Label();
        labelDateText = new Label();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // labelDate
        // 
        labelDate.AutoSize = true;
        labelDate.Font = new Font("Segoe UI", 12F);
        labelDate.Location = new Point(6, 19);
        labelDate.Name = "labelDate";
        labelDate.Size = new Size(45, 21);
        labelDate.TabIndex = 2;
        labelDate.Text = "Date:";
        // 
        // labelDateText
        // 
        labelDateText.AutoSize = true;
        labelDateText.Font = new Font("Segoe UI", 12F);
        labelDateText.Location = new Point(57, 19);
        labelDateText.Name = "labelDateText";
        labelDateText.Size = new Size(43, 21);
        labelDateText.TabIndex = 4;
        labelDateText.Text = "TEXT";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(groupBox2);
        groupBox1.Controls.Add(labelDateText);
        groupBox1.Controls.Add(labelDate);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(530, 170);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(label1);
        groupBox2.Font = new Font("Segoe UI", 12F);
        groupBox2.Location = new Point(6, 43);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(519, 122);
        groupBox2.TabIndex = 8;
        groupBox2.TabStop = false;
        groupBox2.Text = "Customer";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(88, 95);
        label3.Name = "label3";
        label3.Size = new Size(52, 21);
        label3.TabIndex = 2;
        label3.Text = "label3";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(88, 60);
        label2.Name = "label2";
        label2.Size = new Size(52, 21);
        label2.TabIndex = 1;
        label2.Text = "label2";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(88, 25);
        label1.Name = "label1";
        label1.Size = new Size(52, 21);
        label1.TabIndex = 0;
        label1.Text = "label1";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(6, 95);
        label4.Name = "label4";
        label4.Size = new Size(57, 21);
        label4.TabIndex = 5;
        label4.Text = "Phone:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(6, 60);
        label5.Name = "label5";
        label5.Size = new Size(76, 21);
        label5.TabIndex = 4;
        label5.Text = "Surname:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(6, 25);
        label6.Name = "label6";
        label6.Size = new Size(55, 21);
        label6.TabIndex = 3;
        label6.Text = "Name:";
        // 
        // OrderRowControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBox1);
        Name = "OrderRowControl";
        Size = new Size(530, 170);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private Label labelDate;
    private Label labelDateText;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private Label label3;
    private Label label2;
    private Label label1;
    private Label label4;
    private Label label5;
    private Label label6;
}
