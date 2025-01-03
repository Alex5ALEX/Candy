namespace CandyClient.Views.CandyView;

partial class CandyAddController
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
        groupBox1 = new GroupBox();
        buttonBack = new Button();
        buttonAdd = new Button();
        tabControl = new TabControl();
        tabPageProducts = new TabPage();
        flowLayoutPanelProducts = new FlowLayoutPanel();
        labelName = new Label();
        textBoxName = new TextBox();
        labelSurname = new Label();
        numericUpDown1 = new NumericUpDown();
        groupBox1.SuspendLayout();
        tabControl.SuspendLayout();
        tabPageProducts.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        SuspendLayout();
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(7, 25);
        label.Name = "label";
        label.Size = new Size(184, 46);
        label.TabIndex = 0;
        label.Text = "Add Candy";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(numericUpDown1);
        groupBox1.Controls.Add(labelName);
        groupBox1.Controls.Add(labelSurname);
        groupBox1.Controls.Add(textBoxName);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(buttonAdd);
        groupBox1.Controls.Add(tabControl);
        groupBox1.Controls.Add(label);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Margin = new Padding(3, 4, 3, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 4, 3, 4);
        groupBox1.Size = new Size(777, 780);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
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
        tabPageProducts.Text = "Components";
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
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Font = new Font("Segoe UI", 12F);
        labelName.Location = new Point(19, 80);
        labelName.Name = "labelName";
        labelName.Size = new Size(68, 28);
        labelName.TabIndex = 18;
        labelName.Text = "Name:";
        // 
        // textBoxName
        // 
        textBoxName.Font = new Font("Segoe UI", 12F);
        textBoxName.Location = new Point(19, 112);
        textBoxName.Margin = new Padding(3, 4, 3, 4);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(332, 34);
        textBoxName.TabIndex = 21;
        // 
        // labelSurname
        // 
        labelSurname.AutoSize = true;
        labelSurname.Font = new Font("Segoe UI", 12F);
        labelSurname.Location = new Point(19, 155);
        labelSurname.Name = "labelSurname";
        labelSurname.Size = new Size(58, 28);
        labelSurname.TabIndex = 19;
        labelSurname.Text = "Price:";
        // 
        // numericUpDown1
        // 
        numericUpDown1.DecimalPlaces = 2;
        numericUpDown1.Font = new Font("Segoe UI", 12F);
        numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
        numericUpDown1.Location = new Point(19, 186);
        numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(332, 34);
        numericUpDown1.TabIndex = 22;
        // 
        // CandyAddController
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBox1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "CandyAddController";
        Size = new Size(777, 780);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        tabControl.ResumeLayout(false);
        tabPageProducts.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label label;
    private GroupBox groupBox1;
    private Button buttonBack;
    private Button buttonAdd;
    private TabControl tabControl;
    private TabPage tabPageProducts;
    private FlowLayoutPanel flowLayoutPanelProducts;
    private NumericUpDown numericUpDown1;
    private Label labelName;
    private Label labelSurname;
    private TextBox textBoxName;
}
