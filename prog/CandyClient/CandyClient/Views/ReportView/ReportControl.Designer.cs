namespace CandyClient.Views.ReportView;

partial class ReportControl
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportControl));
        labelMenuName = new Label();
        buttonStatistic = new Button();
        pictureBox1 = new PictureBox();
        buttonFinance = new Button();
        buttonMenu = new Button();
        groupBoxAction = new GroupBox();
        buttonClear = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // labelMenuName
        // 
        labelMenuName.AutoSize = true;
        labelMenuName.Font = new Font("Segoe UI", 30F);
        labelMenuName.Location = new Point(100, 3);
        labelMenuName.Name = "labelMenuName";
        labelMenuName.Size = new Size(159, 54);
        labelMenuName.TabIndex = 15;
        labelMenuName.Text = "Reports";
        // 
        // buttonStatistic
        // 
        buttonStatistic.FlatStyle = FlatStyle.Flat;
        buttonStatistic.Font = new Font("Segoe UI", 12F);
        buttonStatistic.Location = new Point(655, 8);
        buttonStatistic.Name = "buttonStatistic";
        buttonStatistic.Size = new Size(90, 50);
        buttonStatistic.TabIndex = 14;
        buttonStatistic.Text = "Statistic";
        buttonStatistic.UseVisualStyleBackColor = true;
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
        pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        pictureBox1.Location = new Point(440, 90);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(400, 400);
        pictureBox1.TabIndex = 19;
        pictureBox1.TabStop = false;
        // 
        // buttonFinance
        // 
        buttonFinance.FlatStyle = FlatStyle.Flat;
        buttonFinance.Font = new Font("Segoe UI", 12F);
        buttonFinance.Location = new Point(542, 8);
        buttonFinance.Name = "buttonFinance";
        buttonFinance.Size = new Size(90, 50);
        buttonFinance.TabIndex = 16;
        buttonFinance.Text = "Finance";
        buttonFinance.UseVisualStyleBackColor = true;
        // 
        // buttonMenu
        // 
        buttonMenu.BackColor = SystemColors.ControlLightLight;
        buttonMenu.FlatStyle = FlatStyle.Flat;
        buttonMenu.Font = new Font("Segoe UI", 12F);
        buttonMenu.Location = new Point(3, 3);
        buttonMenu.Name = "buttonMenu";
        buttonMenu.Size = new Size(90, 55);
        buttonMenu.TabIndex = 13;
        buttonMenu.Text = "Menu";
        buttonMenu.UseVisualStyleBackColor = false;
        // 
        // groupBoxAction
        // 
        groupBoxAction.Location = new Point(3, 62);
        groupBoxAction.Name = "groupBoxAction";
        groupBoxAction.Size = new Size(1254, 615);
        groupBoxAction.TabIndex = 17;
        groupBoxAction.TabStop = false;
        // 
        // buttonClear
        // 
        buttonClear.FlatStyle = FlatStyle.Flat;
        buttonClear.Font = new Font("Segoe UI", 12F);
        buttonClear.Location = new Point(1155, 8);
        buttonClear.Name = "buttonClear";
        buttonClear.Size = new Size(90, 50);
        buttonClear.TabIndex = 20;
        buttonClear.Text = "Clear";
        buttonClear.UseVisualStyleBackColor = true;
        // 
        // ReportControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(buttonClear);
        Controls.Add(labelMenuName);
        Controls.Add(buttonStatistic);
        Controls.Add(buttonFinance);
        Controls.Add(buttonMenu);
        Controls.Add(pictureBox1);
        Controls.Add(groupBoxAction);
        Name = "ReportControl";
        Size = new Size(1260, 680);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelMenuName;
    private Button buttonStatistic;
    private PictureBox pictureBox1;
    private Button buttonFinance;
    private Button buttonMenu;
    private GroupBox groupBoxAction;
    private Button buttonClear;
}
