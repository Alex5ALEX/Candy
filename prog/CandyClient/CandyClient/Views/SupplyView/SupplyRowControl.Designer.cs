namespace CandyClient.Views.SupplyView;

partial class SupplyRowControl
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
        labelPrice = new Label();
        labelPriceText = new Label();
        labelDateText = new Label();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // labelDate
        // 
        labelDate.AutoSize = true;
        labelDate.Font = new Font("Segoe UI", 12F);
        labelDate.Location = new Point(4, 19);
        labelDate.Name = "labelDate";
        labelDate.Size = new Size(45, 21);
        labelDate.TabIndex = 2;
        labelDate.Text = "Date:";
        // 
        // labelPrice
        // 
        labelPrice.AutoSize = true;
        labelPrice.Font = new Font("Segoe UI", 12F);
        labelPrice.Location = new Point(6, 49);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(47, 21);
        labelPrice.TabIndex = 3;
        labelPrice.Text = "Price:";
        // 
        // labelPriceText
        // 
        labelPriceText.AutoSize = true;
        labelPriceText.Font = new Font("Segoe UI", 12F);
        labelPriceText.Location = new Point(56, 49);
        labelPriceText.Name = "labelPriceText";
        labelPriceText.Size = new Size(43, 21);
        labelPriceText.TabIndex = 5;
        labelPriceText.Text = "TEXT";
        // 
        // labelDateText
        // 
        labelDateText.AutoSize = true;
        labelDateText.Font = new Font("Segoe UI", 12F);
        labelDateText.Location = new Point(55, 19);
        labelDateText.Name = "labelDateText";
        labelDateText.Size = new Size(43, 21);
        labelDateText.TabIndex = 4;
        labelDateText.Text = "TEXT";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(groupBox2);
        groupBox1.Controls.Add(labelPrice);
        groupBox1.Controls.Add(labelDateText);
        groupBox1.Controls.Add(labelPriceText);
        groupBox1.Controls.Add(labelDate);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(535, 161);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(label1);
        groupBox2.Font = new Font("Segoe UI", 12F);
        groupBox2.Location = new Point(195, 19);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(334, 133);
        groupBox2.TabIndex = 15;
        groupBox2.TabStop = false;
        groupBox2.Text = "Provider";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(19, 30);
        label1.Name = "label1";
        label1.Size = new Size(52, 21);
        label1.TabIndex = 0;
        label1.Text = "label1";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(19, 63);
        label2.Name = "label2";
        label2.Size = new Size(52, 21);
        label2.TabIndex = 1;
        label2.Text = "label2";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(19, 95);
        label3.Name = "label3";
        label3.Size = new Size(52, 21);
        label3.TabIndex = 2;
        label3.Text = "label3";
        // 
        // SupplyRowControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Name = "SupplyRowControl";
        Size = new Size(535, 161);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private Label labelDate;
    private Label labelPrice;
    private Label labelPriceText;
    private Label labelDateText;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private Label label1;
    private Label label2;
    private Label label3;
}
