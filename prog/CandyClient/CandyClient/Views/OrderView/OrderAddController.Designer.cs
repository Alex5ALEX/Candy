namespace CandyClient.Views.OrderView;

partial class OrderAddController
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
        label = new Label();
        labelDate = new Label();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        buttonBack = new Button();
        buttonAdd = new Button();
        tabControl = new TabControl();
        tabPageProducts = new TabPage();
        flowLayoutPanelProducts = new FlowLayoutPanel();
        tabPageCustomer = new TabPage();
        flowLayoutPanelCustomers = new FlowLayoutPanel();
        dateTimePicker = new DateTimePicker();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        tabControl.SuspendLayout();
        tabPageProducts.SuspendLayout();
        tabPageCustomer.SuspendLayout();
        SuspendLayout();
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(7, 25);
        label.Name = "label";
        label.Size = new Size(179, 46);
        label.TabIndex = 0;
        label.Text = "Add Order";
        // 
        // labelDate
        // 
        labelDate.AutoSize = true;
        labelDate.Font = new Font("Segoe UI", 12F);
        labelDate.Location = new Point(17, 92);
        labelDate.Name = "labelDate";
        labelDate.Size = new Size(57, 28);
        labelDate.TabIndex = 1;
        labelDate.Text = "Date:";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(groupBox2);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(buttonAdd);
        groupBox1.Controls.Add(tabControl);
        groupBox1.Controls.Add(dateTimePicker);
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(labelDate);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Margin = new Padding(3, 4, 3, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 4, 3, 4);
        groupBox1.Size = new Size(777, 780);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(label1);
        groupBox2.Font = new Font("Segoe UI", 12F);
        groupBox2.Location = new Point(17, 200);
        groupBox2.Margin = new Padding(3, 4, 3, 4);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(3, 4, 3, 4);
        groupBox2.Size = new Size(322, 173);
        groupBox2.TabIndex = 18;
        groupBox2.TabStop = false;
        groupBox2.Text = "Customer";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(21, 121);
        label4.Name = "label4";
        label4.Size = new Size(0, 28);
        label4.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(21, 76);
        label3.Name = "label3";
        label3.Size = new Size(0, 28);
        label3.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(169, 33);
        label2.Name = "label2";
        label2.Size = new Size(0, 28);
        label2.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(21, 33);
        label1.Name = "label1";
        label1.Size = new Size(0, 28);
        label1.TabIndex = 0;
        // 
        // buttonBack
        // 
        buttonBack.BackColor = SystemColors.ControlLightLight;
        buttonBack.FlatStyle = FlatStyle.Flat;
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.Location = new Point(7, 704);
        buttonBack.Margin = new Padding(3, 4, 3, 4);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(114, 67);
        buttonBack.TabIndex = 17;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = false;
        // 
        // buttonAdd
        // 
        buttonAdd.BackColor = Color.SpringGreen;
        buttonAdd.FlatStyle = FlatStyle.Flat;
        buttonAdd.Font = new Font("Segoe UI", 12F);
        buttonAdd.Location = new Point(225, 704);
        buttonAdd.Margin = new Padding(3, 4, 3, 4);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(114, 67);
        buttonAdd.TabIndex = 16;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = false;
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabPageProducts);
        tabControl.Controls.Add(tabPageCustomer);
        tabControl.Font = new Font("Segoe UI", 12F);
        tabControl.Location = new Point(357, 25);
        tabControl.Margin = new Padding(3, 4, 3, 4);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(414, 751);
        tabControl.TabIndex = 15;
        // 
        // tabPageProducts
        // 
        tabPageProducts.Controls.Add(flowLayoutPanelProducts);
        tabPageProducts.Location = new Point(4, 37);
        tabPageProducts.Margin = new Padding(3, 4, 3, 4);
        tabPageProducts.Name = "tabPageProducts";
        tabPageProducts.Padding = new Padding(3, 4, 3, 4);
        tabPageProducts.Size = new Size(406, 710);
        tabPageProducts.TabIndex = 0;
        tabPageProducts.Text = "Products";
        tabPageProducts.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanelProducts
        // 
        flowLayoutPanelProducts.AutoScroll = true;
        flowLayoutPanelProducts.Location = new Point(0, 0);
        flowLayoutPanelProducts.Margin = new Padding(3, 4, 3, 4);
        flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
        flowLayoutPanelProducts.Size = new Size(405, 705);
        flowLayoutPanelProducts.TabIndex = 0;
        // 
        // tabPageCustomer
        // 
        tabPageCustomer.Controls.Add(flowLayoutPanelCustomers);
        tabPageCustomer.Location = new Point(4, 37);
        tabPageCustomer.Margin = new Padding(3, 4, 3, 4);
        tabPageCustomer.Name = "tabPageCustomer";
        tabPageCustomer.Padding = new Padding(3, 4, 3, 4);
        tabPageCustomer.Size = new Size(406, 710);
        tabPageCustomer.TabIndex = 1;
        tabPageCustomer.Text = "Customer";
        tabPageCustomer.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanelCustomers
        // 
        flowLayoutPanelCustomers.AutoScroll = true;
        flowLayoutPanelCustomers.Location = new Point(0, 0);
        flowLayoutPanelCustomers.Margin = new Padding(3, 4, 3, 4);
        flowLayoutPanelCustomers.Name = "flowLayoutPanelCustomers";
        flowLayoutPanelCustomers.Size = new Size(405, 705);
        flowLayoutPanelCustomers.TabIndex = 0;
        // 
        // dateTimePicker
        // 
        dateTimePicker.CalendarFont = new Font("Segoe UI", 12F);
        dateTimePicker.Font = new Font("Segoe UI", 12F);
        dateTimePicker.Location = new Point(17, 124);
        dateTimePicker.Margin = new Padding(3, 4, 3, 4);
        dateTimePicker.Name = "dateTimePicker";
        dateTimePicker.Size = new Size(322, 34);
        dateTimePicker.TabIndex = 14;
        // 
        // OrderAddController
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBox1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "OrderAddController";
        Size = new Size(777, 780);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        tabControl.ResumeLayout(false);
        tabPageProducts.ResumeLayout(false);
        tabPageCustomer.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Label label;
    private Label labelDate;
    private GroupBox groupBox1;
    private DateTimePicker dateTimePicker;
    private Button buttonBack;
    private Button buttonAdd;
    private GroupBox groupBox2;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private TabControl tabControl;
    private TabPage tabPageProducts;
    private FlowLayoutPanel flowLayoutPanelProducts;
    private TabPage tabPageCustomer;
    private FlowLayoutPanel flowLayoutPanelCustomers;
}
