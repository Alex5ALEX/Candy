namespace CandyClient.ViewClient.CatalogView;

partial class ProductCatalogControl
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCatalogControl));
        groupBox1 = new GroupBox();
        pictureBox1 = new PictureBox();
        labelNameText = new Label();
        labelPriceText = new Label();
        labelName = new Label();
        labelPrice = new Label();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.BackColor = SystemColors.ControlLightLight;
        groupBox1.Controls.Add(pictureBox1);
        groupBox1.Controls.Add(labelNameText);
        groupBox1.Controls.Add(labelPriceText);
        groupBox1.Controls.Add(labelName);
        groupBox1.Controls.Add(labelPrice);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Margin = new Padding(3, 4, 3, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 4, 3, 4);
        groupBox1.Size = new Size(497, 144);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
        pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        pictureBox1.Location = new Point(346, 24);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(115, 113);
        pictureBox1.TabIndex = 23;
        pictureBox1.TabStop = false;
        // 
        // labelNameText
        // 
        labelNameText.AutoSize = true;
        labelNameText.Font = new Font("Segoe UI", 12F);
        labelNameText.Location = new Point(79, 24);
        labelNameText.Name = "labelNameText";
        labelNameText.Size = new Size(114, 25);
        labelNameText.TabIndex = 20;
        labelNameText.Text = "TEXT_NAME";
        // 
        // labelPriceText
        // 
        labelPriceText.AutoSize = true;
        labelPriceText.Font = new Font("Segoe UI", 12F);
        labelPriceText.Location = new Point(71, 79);
        labelPriceText.Name = "labelPriceText";
        labelPriceText.Size = new Size(114, 25);
        labelPriceText.TabIndex = 22;
        labelPriceText.Text = "TEXT_EMAIL";
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Font = new Font("Segoe UI", 12F);
        labelName.Location = new Point(9, 24);
        labelName.Name = "labelName";
        labelName.Size = new Size(66, 25);
        labelName.TabIndex = 19;
        labelName.Text = "Name:";
        // 
        // labelPrice
        // 
        labelPrice.AutoSize = true;
        labelPrice.Font = new Font("Segoe UI", 12F);
        labelPrice.Location = new Point(7, 79);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(58, 25);
        labelPrice.TabIndex = 21;
        labelPrice.Text = "Price:";
        // 
        // ProductCatalogControl
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "ProductCatalogControl";
        Size = new Size(497, 146);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Label labelNameText;
    private Label labelPriceText;
    private Label labelName;
    private Label labelPrice;
    private PictureBox pictureBox1;
}
