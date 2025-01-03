namespace CandyClient.Views.ComponentView;

partial class ComponentControl
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentControl));
        labelMenuName = new Label();
        buttonAddNew = new Button();
        flowLayoutPanel = new FlowLayoutPanel();
        buttonEdit = new Button();
        groupBoxList = new GroupBox();
        groupBoxAction = new GroupBox();
        buttonMenu = new Button();
        pictureBox1 = new PictureBox();
        groupBoxList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // labelMenuName
        // 
        labelMenuName.AutoSize = true;
        labelMenuName.Font = new Font("Segoe UI", 30F);
        labelMenuName.Location = new Point(100, 3);
        labelMenuName.Name = "labelMenuName";
        labelMenuName.Size = new Size(250, 54);
        labelMenuName.TabIndex = 8;
        labelMenuName.Text = "Components";
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
        // groupBoxList
        // 
        groupBoxList.Controls.Add(flowLayoutPanel);
        groupBoxList.Location = new Point(349, 62);
        groupBoxList.Name = "groupBoxList";
        groupBoxList.Size = new Size(908, 615);
        groupBoxList.TabIndex = 11;
        groupBoxList.TabStop = false;
        // 
        // groupBoxAction
        // 
        groupBoxAction.Location = new Point(3, 62);
        groupBoxAction.Name = "groupBoxAction";
        groupBoxAction.Size = new Size(340, 615);
        groupBoxAction.TabIndex = 10;
        groupBoxAction.TabStop = false;
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
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
        pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        pictureBox1.Location = new Point(20, 90);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(300, 300);
        pictureBox1.TabIndex = 12;
        pictureBox1.TabStop = false;
        // 
        // ComponentControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(pictureBox1);
        Controls.Add(buttonEdit);
        Controls.Add(groupBoxList);
        Controls.Add(labelMenuName);
        Controls.Add(buttonAddNew);
        Controls.Add(buttonMenu);
        Controls.Add(groupBoxAction);
        Name = "ComponentControl";
        Size = new Size(1260, 680);
        groupBoxList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelMenuName;
    private Button buttonAddNew;
    private FlowLayoutPanel flowLayoutPanel;
    private Button buttonEdit;
    private Button buttonMenu;
    private GroupBox groupBoxList;
    private GroupBox groupBoxAction;
    private PictureBox pictureBox1;
}
