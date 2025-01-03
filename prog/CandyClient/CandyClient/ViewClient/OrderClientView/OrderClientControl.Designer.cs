namespace CandyClient.ViewClient.OrderClientView;

partial class OrderClientControl
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderClientControl));
        groupBoxList = new GroupBox();
        flowLayoutPanel = new FlowLayoutPanel();
        pictureBox1 = new PictureBox();
        labelMenuName = new Label();
        buttonAddNew = new Button();
        buttonMenu = new Button();
        groupBoxAction = new GroupBox();
        groupBoxList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // groupBoxList
        // 
        groupBoxList.Controls.Add(flowLayoutPanel);
        groupBoxList.Location = new Point(787, 79);
        groupBoxList.Margin = new Padding(3, 4, 3, 4);
        groupBoxList.Name = "groupBoxList";
        groupBoxList.Padding = new Padding(3, 4, 3, 4);
        groupBoxList.Size = new Size(649, 779);
        groupBoxList.TabIndex = 24;
        groupBoxList.TabStop = false;
        // 
        // flowLayoutPanel
        // 
        flowLayoutPanel.AutoScroll = true;
        flowLayoutPanel.Location = new Point(10, 24);
        flowLayoutPanel.Margin = new Padding(3, 4, 3, 4);
        flowLayoutPanel.Name = "flowLayoutPanel";
        flowLayoutPanel.Size = new Size(635, 751);
        flowLayoutPanel.TabIndex = 6;
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
        pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        pictureBox1.Location = new Point(171, 114);
        pictureBox1.Margin = new Padding(3, 4, 3, 4);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(457, 507);
        pictureBox1.TabIndex = 25;
        pictureBox1.TabStop = false;
        // 
        // labelMenuName
        // 
        labelMenuName.AutoSize = true;
        labelMenuName.Font = new Font("Segoe UI", 30F);
        labelMenuName.Location = new Point(102, 4);
        labelMenuName.Name = "labelMenuName";
        labelMenuName.Size = new Size(165, 62);
        labelMenuName.TabIndex = 21;
        labelMenuName.Text = "Orders";
        // 
        // buttonAddNew
        // 
        buttonAddNew.FlatStyle = FlatStyle.Flat;
        buttonAddNew.Location = new Point(1330, 11);
        buttonAddNew.Margin = new Padding(3, 4, 3, 4);
        buttonAddNew.Name = "buttonAddNew";
        buttonAddNew.Size = new Size(91, 63);
        buttonAddNew.TabIndex = 20;
        buttonAddNew.Text = "Add New";
        buttonAddNew.UseVisualStyleBackColor = true;
        // 
        // buttonMenu
        // 
        buttonMenu.BackColor = SystemColors.ControlLightLight;
        buttonMenu.FlatStyle = FlatStyle.Flat;
        buttonMenu.Font = new Font("Segoe UI", 12F);
        buttonMenu.Location = new Point(3, 4);
        buttonMenu.Margin = new Padding(3, 4, 3, 4);
        buttonMenu.Name = "buttonMenu";
        buttonMenu.Size = new Size(91, 70);
        buttonMenu.TabIndex = 19;
        buttonMenu.Text = "Menu";
        buttonMenu.UseVisualStyleBackColor = false;
        // 
        // groupBoxAction
        // 
        groupBoxAction.Location = new Point(3, 79);
        groupBoxAction.Margin = new Padding(3, 4, 3, 4);
        groupBoxAction.Name = "groupBoxAction";
        groupBoxAction.Padding = new Padding(3, 4, 3, 4);
        groupBoxAction.Size = new Size(777, 779);
        groupBoxAction.TabIndex = 23;
        groupBoxAction.TabStop = false;
        // 
        // OrderClientControl
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBoxList);
        Controls.Add(pictureBox1);
        Controls.Add(labelMenuName);
        Controls.Add(buttonAddNew);
        Controls.Add(buttonMenu);
        Controls.Add(groupBoxAction);
        Margin = new Padding(3, 4, 3, 4);
        Name = "OrderClientControl";
        Size = new Size(1440, 861);
        groupBoxList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private GroupBox groupBoxList;
    private FlowLayoutPanel flowLayoutPanel;
    private PictureBox pictureBox1;
    private Label labelMenuName;
    private Button buttonAddNew;
    private Button buttonMenu;
    private GroupBox groupBoxAction;
}
