namespace CandyClient.ViewClient.CatalogView;

partial class CatalogControl
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogControl));
        labelMenuName = new Label();
        buttonMenu = new Button();
        pictureBox1 = new PictureBox();
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        flowLayoutPanelProduct = new FlowLayoutPanel();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        SuspendLayout();
        // 
        // labelMenuName
        // 
        labelMenuName.AutoSize = true;
        labelMenuName.Font = new Font("Segoe UI", 30F);
        labelMenuName.Location = new Point(102, 5);
        labelMenuName.Name = "labelMenuName";
        labelMenuName.Size = new Size(182, 62);
        labelMenuName.TabIndex = 18;
        labelMenuName.Text = "Catalog";
        // 
        // buttonMenu
        // 
        buttonMenu.BackColor = SystemColors.ControlLightLight;
        buttonMenu.FlatStyle = FlatStyle.Flat;
        buttonMenu.Font = new Font("Segoe UI", 12F);
        buttonMenu.Location = new Point(3, 4);
        buttonMenu.Margin = new Padding(3, 4, 3, 4);
        buttonMenu.Name = "buttonMenu";
        buttonMenu.Size = new Size(91, 69);
        buttonMenu.TabIndex = 17;
        buttonMenu.Text = "Menu";
        buttonMenu.UseVisualStyleBackColor = false;
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
        pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        pictureBox1.Location = new Point(72, 109);
        pictureBox1.Margin = new Padding(3, 4, 3, 4);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(286, 316);
        pictureBox1.TabIndex = 20;
        pictureBox1.TabStop = false;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Font = new Font("Segoe UI", 12F);
        tabControl1.Location = new Point(402, 66);
        tabControl1.Margin = new Padding(3, 4, 3, 4);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(1034, 791);
        tabControl1.TabIndex = 22;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(flowLayoutPanelProduct);
        tabPage1.Font = new Font("Segoe UI", 12F);
        tabPage1.Location = new Point(4, 34);
        tabPage1.Margin = new Padding(3, 4, 3, 4);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3, 4, 3, 4);
        tabPage1.Size = new Size(1026, 753);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Candyes";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanelProduct
        // 
        flowLayoutPanelProduct.AutoScroll = true;
        flowLayoutPanelProduct.Location = new Point(0, 0);
        flowLayoutPanelProduct.Margin = new Padding(3, 4, 3, 4);
        flowLayoutPanelProduct.Name = "flowLayoutPanelProduct";
        flowLayoutPanelProduct.Size = new Size(1017, 748);
        flowLayoutPanelProduct.TabIndex = 0;
        // 
        // CatalogControl
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(tabControl1);
        Controls.Add(pictureBox1);
        Controls.Add(labelMenuName);
        Controls.Add(buttonMenu);
        Margin = new Padding(3, 4, 3, 4);
        Name = "CatalogControl";
        Size = new Size(1440, 862);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelMenuName;
    private Button buttonMenu;
    private PictureBox pictureBox1;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private FlowLayoutPanel flowLayoutPanelProduct;
}
