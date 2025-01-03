namespace CandyClient.Views.CustomerView;

partial class CustomerControl
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerControl));
        labelMenuName = new Label();
        buttonAddNew = new Button();
        flowLayoutPanel = new FlowLayoutPanel();
        buttonEdit = new Button();
        groupBoxAction = new GroupBox();
        pictureBox1 = new PictureBox();
        buttonMenu = new Button();
        groupBox1 = new GroupBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // labelMenuName
        // 
        labelMenuName.AutoSize = true;
        labelMenuName.Font = new Font("Segoe UI", 30F);
        labelMenuName.Location = new Point(100, 3);
        labelMenuName.Name = "labelMenuName";
        labelMenuName.Size = new Size(211, 54);
        labelMenuName.TabIndex = 8;
        labelMenuName.Text = "Customers";
        // 
        // buttonAddNew
        // 
        buttonAddNew.FlatStyle = FlatStyle.Flat;
        buttonAddNew.Font = new Font("Segoe UI", 12F);
        buttonAddNew.Location = new Point(1154, 9);
        buttonAddNew.Name = "buttonAddNew";
        buttonAddNew.Size = new Size(90, 50);
        buttonAddNew.TabIndex = 7;
        buttonAddNew.Text = "Add New";
        buttonAddNew.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanel
        // 
        flowLayoutPanel.AutoScroll = true;
        flowLayoutPanel.Dock = DockStyle.Right;
        flowLayoutPanel.ImeMode = ImeMode.NoControl;
        flowLayoutPanel.Location = new Point(9, 19);
        flowLayoutPanel.Name = "flowLayoutPanel";
        flowLayoutPanel.Size = new Size(896, 593);
        flowLayoutPanel.TabIndex = 6;
        // 
        // buttonEdit
        // 
        buttonEdit.FlatStyle = FlatStyle.Flat;
        buttonEdit.Font = new Font("Segoe UI", 12F);
        buttonEdit.Location = new Point(1041, 9);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(90, 50);
        buttonEdit.TabIndex = 9;
        buttonEdit.Text = "Edit";
        buttonEdit.UseVisualStyleBackColor = true;
        // 
        // groupBoxAction
        // 
        groupBoxAction.Location = new Point(3, 62);
        groupBoxAction.Name = "groupBoxAction";
        groupBoxAction.Size = new Size(340, 615);
        groupBoxAction.TabIndex = 10;
        groupBoxAction.TabStop = false;
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
        pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        pictureBox1.InitialImage = null;
        pictureBox1.Location = new Point(20, 90);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(300, 300);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // buttonMenu
        // 
        buttonMenu.BackColor = SystemColors.ControlLightLight;
        buttonMenu.FlatStyle = FlatStyle.Flat;
        buttonMenu.Font = new Font("Segoe UI", 12F);
        buttonMenu.Location = new Point(3, 3);
        buttonMenu.Name = "buttonMenu";
        buttonMenu.Size = new Size(90, 55);
        buttonMenu.TabIndex = 0;
        buttonMenu.Text = "Menu";
        buttonMenu.UseVisualStyleBackColor = false;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(flowLayoutPanel);
        groupBox1.Location = new Point(349, 62);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(908, 615);
        groupBox1.TabIndex = 11;
        groupBox1.TabStop = false;
        // 
        // CustomerControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBox1);
        Controls.Add(buttonAddNew);
        Controls.Add(buttonEdit);
        Controls.Add(labelMenuName);
        Controls.Add(buttonMenu);
        Controls.Add(pictureBox1);
        Controls.Add(groupBoxAction);
        Name = "CustomerControl";
        Size = new Size(1260, 680);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelMenuName;
    private Button buttonAddNew;
    private FlowLayoutPanel flowLayoutPanel;
    private Button buttonEdit;
    private Button buttonMenu;
    private GroupBox groupBoxAction;
    private GroupBox groupBox1;
    private PictureBox pictureBox1;
}
