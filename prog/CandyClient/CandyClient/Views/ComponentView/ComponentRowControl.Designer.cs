namespace CandyClient.Views.ComponentView;

partial class ComponentRowControl
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
        labelName = new Label();
        labelNameText = new Label();
        labelPrice = new Label();
        labelPriceText = new Label();
        groupBox1 = new GroupBox();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Font = new Font("Segoe UI", 12F);
        labelName.Location = new Point(18, 28);
        labelName.Name = "labelName";
        labelName.Size = new Size(55, 21);
        labelName.TabIndex = 2;
        labelName.Text = "Name:";
        // 
        // labelNameText
        // 
        labelNameText.AutoSize = true;
        labelNameText.Font = new Font("Segoe UI", 12F);
        labelNameText.Location = new Point(79, 28);
        labelNameText.Name = "labelNameText";
        labelNameText.Size = new Size(94, 21);
        labelNameText.TabIndex = 4;
        labelNameText.Text = "TEXT_NAME";
        // 
        // labelPrice
        // 
        labelPrice.AutoSize = true;
        labelPrice.Font = new Font("Segoe UI", 12F);
        labelPrice.Location = new Point(387, 28);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(47, 21);
        labelPrice.TabIndex = 13;
        labelPrice.Text = "Price:";
        // 
        // labelPriceText
        // 
        labelPriceText.AutoSize = true;
        labelPriceText.Font = new Font("Segoe UI", 12F);
        labelPriceText.Location = new Point(440, 28);
        labelPriceText.Name = "labelPriceText";
        labelPriceText.Size = new Size(94, 21);
        labelPriceText.TabIndex = 14;
        labelPriceText.Text = "TEXT_EMAIL";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(labelNameText);
        groupBox1.Controls.Add(labelPriceText);
        groupBox1.Controls.Add(labelName);
        groupBox1.Controls.Add(labelPrice);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(873, 65);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        // 
        // ComponentRowControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBox1);
        Name = "ComponentRowControl";
        Size = new Size(873, 65);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private Label labelName;
    private Label labelNameText;
    private Label labelPrice;
    private Label labelPriceText;
    private GroupBox groupBox1;
}
