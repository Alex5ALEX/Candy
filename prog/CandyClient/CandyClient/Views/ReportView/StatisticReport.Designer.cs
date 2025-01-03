namespace CandyClient.Views.ReportView;

partial class StatisticReport
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
        groupBox2 = new GroupBox();
        label9 = new Label();
        label10 = new Label();
        label7 = new Label();
        label8 = new Label();
        label5 = new Label();
        label6 = new Label();
        label3 = new Label();
        label4 = new Label();
        label2 = new Label();
        label1 = new Label();
        groupBox1 = new GroupBox();
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        flowLayoutPanelCandy = new FlowLayoutPanel();
        tabPage2 = new TabPage();
        flowLayoutPanelComponent = new FlowLayoutPanel();
        backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        groupBox2.SuspendLayout();
        groupBox1.SuspendLayout();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        tabPage2.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label9);
        groupBox2.Controls.Add(label10);
        groupBox2.Controls.Add(label7);
        groupBox2.Controls.Add(label8);
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(label1);
        groupBox2.Font = new Font("Segoe UI", 12F);
        groupBox2.Location = new Point(17, 22);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(277, 587);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Statistic";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(190, 215);
        label9.Name = "label9";
        label9.Size = new Size(52, 21);
        label9.TabIndex = 9;
        label9.Text = "label9";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(16, 131);
        label10.Name = "label10";
        label10.Size = new Size(143, 21);
        label10.TabIndex = 8;
        label10.Text = "Count of Providers:";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(174, 171);
        label7.Name = "label7";
        label7.Size = new Size(52, 21);
        label7.TabIndex = 7;
        label7.Text = "label7";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(16, 90);
        label8.Name = "label8";
        label8.Size = new Size(130, 21);
        label8.TabIndex = 6;
        label8.Text = "Count of Admins:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(174, 131);
        label5.Name = "label5";
        label5.Size = new Size(52, 21);
        label5.TabIndex = 5;
        label5.Text = "label5";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(21, 171);
        label6.Name = "label6";
        label6.Size = new Size(121, 21);
        label6.TabIndex = 4;
        label6.Text = "Count of Candy:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(174, 90);
        label3.Name = "label3";
        label3.Size = new Size(19, 21);
        label3.TabIndex = 3;
        label3.Text = "1";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(18, 215);
        label4.Name = "label4";
        label4.Size = new Size(166, 21);
        label4.TabIndex = 2;
        label4.Text = "Count of Components:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(174, 52);
        label2.Name = "label2";
        label2.Size = new Size(52, 21);
        label2.TabIndex = 1;
        label2.Text = "label2";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(16, 52);
        label1.Name = "label1";
        label1.Size = new Size(152, 21);
        label1.TabIndex = 0;
        label1.Text = "Count of Customers:";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(tabControl1);
        groupBox1.Controls.Add(groupBox2);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(1254, 615);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "groupBox1";
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Font = new Font("Segoe UI", 12F);
        tabControl1.Location = new Point(300, 22);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(954, 587);
        tabControl1.TabIndex = 2;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(flowLayoutPanelCandy);
        tabPage1.Location = new Point(4, 30);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(946, 553);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Candyes";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanelCandy
        // 
        flowLayoutPanelCandy.AutoScroll = true;
        flowLayoutPanelCandy.Location = new Point(0, 0);
        flowLayoutPanelCandy.Name = "flowLayoutPanelCandy";
        flowLayoutPanelCandy.Size = new Size(947, 557);
        flowLayoutPanelCandy.TabIndex = 0;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(flowLayoutPanelComponent);
        tabPage2.Location = new Point(4, 30);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(946, 553);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Components";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanelComponent
        // 
        flowLayoutPanelComponent.AutoScroll = true;
        flowLayoutPanelComponent.Location = new Point(0, 0);
        flowLayoutPanelComponent.Name = "flowLayoutPanelComponent";
        flowLayoutPanelComponent.Size = new Size(946, 553);
        flowLayoutPanelComponent.TabIndex = 0;
        // 
        // StatisticReport
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Name = "StatisticReport";
        Size = new Size(1254, 615);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox1.ResumeLayout(false);
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox2;
    private GroupBox groupBox1;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private Label label9;
    private Label label10;
    private Label label7;
    private Label label8;
    private Label label5;
    private Label label6;
    private Label label3;
    private Label label4;
    private Label label2;
    private Label label1;
    private FlowLayoutPanel flowLayoutPanelCandy;
    private FlowLayoutPanel flowLayoutPanelComponent;
}
