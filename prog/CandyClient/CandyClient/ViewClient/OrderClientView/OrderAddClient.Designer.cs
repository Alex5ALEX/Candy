namespace CandyClient.ViewClient.OrderClientView;

partial class OrderAddClient
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
        groupBox1 = new GroupBox();
        dateTimePicker1 = new DateTimePicker();
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
        tabControl = new TabControl();
        PageProduct = new TabPage();
        flowLayoutPanelProduct = new FlowLayoutPanel();
        buttonBack = new Button();
        buttonAdd = new Button();
        label = new Label();
        labelDate = new Label();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        tabControl.SuspendLayout();
        PageProduct.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.BackColor = SystemColors.ControlLightLight;
        groupBox1.Controls.Add(dateTimePicker1);
        groupBox1.Controls.Add(groupBox2);
        groupBox1.Controls.Add(tabControl);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(buttonAdd);
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(labelDate);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Margin = new Padding(3, 4, 3, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 4, 3, 4);
        groupBox1.Size = new Size(777, 779);
        groupBox1.TabIndex = 15;
        groupBox1.TabStop = false;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Font = new Font("Segoe UI", 12F);
        dateTimePicker1.Location = new Point(18, 115);
        dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(331, 32);
        dateTimePicker1.TabIndex = 63;
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
        groupBox2.Location = new Point(18, 160);
        groupBox2.Margin = new Padding(3, 4, 3, 4);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(3, 4, 3, 4);
        groupBox2.Size = new Size(331, 294);
        groupBox2.TabIndex = 61;
        groupBox2.TabStop = false;
        groupBox2.Text = "Customer";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(17, 246);
        label9.Name = "label9";
        label9.Size = new Size(83, 25);
        label9.TabIndex = 9;
        label9.Text = "Address:";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(103, 246);
        label10.Name = "label10";
        label10.Size = new Size(0, 25);
        label10.TabIndex = 8;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(17, 194);
        label7.Name = "label7";
        label7.Size = new Size(62, 25);
        label7.TabIndex = 7;
        label7.Text = "Email:";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(110, 194);
        label8.Name = "label8";
        label8.Size = new Size(0, 25);
        label8.TabIndex = 6;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(17, 141);
        label5.Name = "label5";
        label5.Size = new Size(70, 25);
        label5.TabIndex = 5;
        label5.Text = "Phone:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(110, 141);
        label6.Name = "label6";
        label6.Size = new Size(0, 25);
        label6.TabIndex = 4;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(17, 92);
        label3.Name = "label3";
        label3.Size = new Size(91, 25);
        label3.TabIndex = 3;
        label3.Text = "Surmane:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(110, 92);
        label4.Name = "label4";
        label4.Size = new Size(0, 25);
        label4.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(110, 49);
        label2.Name = "label2";
        label2.Size = new Size(0, 25);
        label2.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(17, 49);
        label1.Name = "label1";
        label1.Size = new Size(66, 25);
        label1.TabIndex = 0;
        label1.Text = "Name:";
        // 
        // tabControl
        // 
        tabControl.Controls.Add(PageProduct);
        tabControl.Font = new Font("Segoe UI", 12F);
        tabControl.Location = new Point(357, 24);
        tabControl.Margin = new Padding(3, 4, 3, 4);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(414, 751);
        tabControl.TabIndex = 24;
        // 
        // PageProduct
        // 
        PageProduct.Controls.Add(flowLayoutPanelProduct);
        PageProduct.Location = new Point(4, 34);
        PageProduct.Margin = new Padding(3, 4, 3, 4);
        PageProduct.Name = "PageProduct";
        PageProduct.Padding = new Padding(3, 4, 3, 4);
        PageProduct.Size = new Size(406, 713);
        PageProduct.TabIndex = 0;
        PageProduct.Text = "Candyes";
        PageProduct.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanelProduct
        // 
        flowLayoutPanelProduct.AutoScroll = true;
        flowLayoutPanelProduct.Location = new Point(0, 0);
        flowLayoutPanelProduct.Margin = new Padding(3, 4, 3, 4);
        flowLayoutPanelProduct.Name = "flowLayoutPanelProduct";
        flowLayoutPanelProduct.Size = new Size(405, 709);
        flowLayoutPanelProduct.TabIndex = 0;
        // 
        // buttonBack
        // 
        buttonBack.BackColor = SystemColors.ControlLightLight;
        buttonBack.FlatStyle = FlatStyle.Flat;
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.Location = new Point(7, 712);
        buttonBack.Margin = new Padding(3, 4, 3, 4);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(114, 63);
        buttonBack.TabIndex = 14;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = false;
        // 
        // buttonAdd
        // 
        buttonAdd.BackColor = Color.SpringGreen;
        buttonAdd.FlatStyle = FlatStyle.Flat;
        buttonAdd.Font = new Font("Segoe UI", 12F);
        buttonAdd.Location = new Point(237, 712);
        buttonAdd.Margin = new Padding(3, 4, 3, 4);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(114, 63);
        buttonAdd.TabIndex = 13;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = false;
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(7, 24);
        label.Name = "label";
        label.Size = new Size(161, 42);
        label.TabIndex = 0;
        label.Text = "Add Order";
        // 
        // labelDate
        // 
        labelDate.AutoSize = true;
        labelDate.Font = new Font("Segoe UI", 12F);
        labelDate.Location = new Point(21, 85);
        labelDate.Name = "labelDate";
        labelDate.Size = new Size(55, 25);
        labelDate.TabIndex = 1;
        labelDate.Text = "Date:";
        // 
        // OrderAddClient
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBox1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "OrderAddClient";
        Size = new Size(777, 779);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        tabControl.ResumeLayout(false);
        PageProduct.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private DateTimePicker dateTimePicker1;
    private GroupBox groupBox2;
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
    private TabControl tabControl;
    private TabPage PageProduct;
    private FlowLayoutPanel flowLayoutPanelProduct;
    private Button buttonBack;
    private Button buttonAdd;
    private Label label;
    private Label labelDate;
}
