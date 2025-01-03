namespace CandyClient.Views.CandyView;

partial class CandyRowControl
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
        labelNameText = new Label();
        groupBox1 = new GroupBox();
        labelPriceText = new Label();
        label2 = new Label();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // labelDate
        // 
        labelDate.AutoSize = true;
        labelDate.Font = new Font("Segoe UI", 12F);
        labelDate.Location = new Point(7, 25);
        labelDate.Name = "labelDate";
        labelDate.Size = new Size(68, 28);
        labelDate.TabIndex = 2;
        labelDate.Text = "Name:";
        // 
        // labelNameText
        // 
        labelNameText.AutoSize = true;
        labelNameText.Font = new Font("Segoe UI", 12F);
        labelNameText.Location = new Point(81, 25);
        labelNameText.Name = "labelNameText";
        labelNameText.Size = new Size(54, 28);
        labelNameText.TabIndex = 4;
        labelNameText.Text = "TEXT";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(labelPriceText);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(labelNameText);
        groupBox1.Controls.Add(labelDate);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Margin = new Padding(3, 4, 3, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 4, 3, 4);
        groupBox1.Size = new Size(606, 114);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        // 
        // labelPriceText
        // 
        labelPriceText.AutoSize = true;
        labelPriceText.Font = new Font("Segoe UI", 12F);
        labelPriceText.Location = new Point(81, 65);
        labelPriceText.Name = "labelPriceText";
        labelPriceText.Size = new Size(54, 28);
        labelPriceText.TabIndex = 6;
        labelPriceText.Text = "TEXT";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F);
        label2.Location = new Point(7, 65);
        label2.Name = "label2";
        label2.Size = new Size(58, 28);
        label2.TabIndex = 5;
        label2.Text = "Price:";
        // 
        // CandyRowControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBox1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "CandyRowControl";
        Size = new Size(606, 115);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private Label labelDate;
    private Label labelNameText;
    private GroupBox groupBox1;
    private Label labelPriceText;
    private Label label2;
}
