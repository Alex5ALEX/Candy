namespace CandyClient.Views.CandyView;

partial class ComponentShortRow
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
        label5 = new Label();
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
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(numericUpDown1);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Margin = new Padding(3, 4, 3, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 4, 3, 4);
        groupBox1.Size = new Size(382, 120);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 12F);
        label5.Location = new Point(238, 37);
        label5.Name = "label5";
        label5.Size = new Size(79, 28);
        label5.TabIndex = 6;
        label5.Text = "Weight:";
        // 
        // numericUpDown1
        // 
        numericUpDown1.DecimalPlaces = 3;
        numericUpDown1.Font = new Font("Segoe UI", 12F);
        numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
        numericUpDown1.Location = new Point(238, 69);
        numericUpDown1.Margin = new Padding(3, 4, 3, 4);
        numericUpDown1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(137, 34);
        numericUpDown1.TabIndex = 5;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 12F);
        label4.Location = new Point(70, 72);
        label4.Name = "label4";
        label4.Size = new Size(65, 28);
        label4.TabIndex = 4;
        label4.Text = "label4";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F);
        label3.Location = new Point(70, 25);
        label3.Name = "label3";
        label3.Size = new Size(65, 28);
        label3.TabIndex = 3;
        label3.Text = "label3";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F);
        label2.Location = new Point(3, 72);
        label2.Name = "label2";
        label2.Size = new Size(58, 28);
        label2.TabIndex = 2;
        label2.Text = "Price:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F);
        label1.Location = new Point(3, 25);
        label1.Name = "label1";
        label1.Size = new Size(68, 28);
        label1.TabIndex = 1;
        label1.Text = "Name:";
        // 
        // ComponentShortRow
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBox1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "ComponentShortRow";
        Size = new Size(382, 120);
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
    private Label label5;
}
