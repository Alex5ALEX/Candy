namespace CandyClient.Views.SupplyView.Rows;

partial class ProductShortRow
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
        groupBox1 = new GroupBox();
        numericUpDown1 = new NumericUpDown();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(numericUpDown1);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(334, 90);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        // 
        // numericUpDown1
        // 
        numericUpDown1.Font = new Font("Segoe UI", 12F);
        numericUpDown1.Location = new Point(208, 52);
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(120, 29);
        numericUpDown1.TabIndex = 5;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 12F);
        label4.Location = new Point(61, 54);
        label4.Name = "label4";
        label4.Size = new Size(52, 21);
        label4.TabIndex = 4;
        label4.Text = "label4";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F);
        label3.Location = new Point(61, 19);
        label3.Name = "label3";
        label3.Size = new Size(52, 21);
        label3.TabIndex = 3;
        label3.Text = "label3";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F);
        label2.Location = new Point(3, 54);
        label2.Name = "label2";
        label2.Size = new Size(47, 21);
        label2.TabIndex = 2;
        label2.Text = "Price:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F);
        label1.Location = new Point(3, 19);
        label1.Name = "label1";
        label1.Size = new Size(55, 21);
        label1.TabIndex = 1;
        label1.Text = "Name:";
        // 
        // ProductAddRowControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBox1);
        Name = "ProductAddRowControl";
        Size = new Size(334, 90);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private NumericUpDown numericUpDown1;
}
