namespace CandyClient.Views.ComponentView;

partial class ComponentAddController
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
        labelName = new Label();
        labelPrice = new Label();
        textBoxName = new TextBox();
        groupBox1 = new GroupBox();
        numericUpDownComponent = new NumericUpDown();
        buttonBack = new Button();
        buttonAdd = new Button();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDownComponent).BeginInit();
        SuspendLayout();
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(6, 19);
        label.Name = "label";
        label.Size = new Size(214, 37);
        label.TabIndex = 0;
        label.Text = "Add Component";
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Font = new Font("Segoe UI", 12F);
        labelName.Location = new Point(27, 77);
        labelName.Name = "labelName";
        labelName.Size = new Size(55, 21);
        labelName.TabIndex = 1;
        labelName.Text = "Name:";
        // 
        // labelPrice
        // 
        labelPrice.AutoSize = true;
        labelPrice.Font = new Font("Segoe UI", 12F);
        labelPrice.Location = new Point(27, 133);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(47, 21);
        labelPrice.TabIndex = 2;
        labelPrice.Text = "Price:";
        // 
        // textBoxName
        // 
        textBoxName.Font = new Font("Segoe UI", 12F);
        textBoxName.Location = new Point(27, 101);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(291, 29);
        textBoxName.TabIndex = 7;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(numericUpDownComponent);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(buttonAdd);
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(labelName);
        groupBox1.Controls.Add(labelPrice);
        groupBox1.Controls.Add(textBoxName);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(340, 615);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        // 
        // numericUpDownComponent
        // 
        numericUpDownComponent.DecimalPlaces = 2;
        numericUpDownComponent.Font = new Font("Segoe UI", 12F);
        numericUpDownComponent.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
        numericUpDownComponent.Location = new Point(27, 157);
        numericUpDownComponent.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        numericUpDownComponent.Name = "numericUpDownComponent";
        numericUpDownComponent.Size = new Size(291, 29);
        numericUpDownComponent.TabIndex = 15;
        // 
        // buttonBack
        // 
        buttonBack.BackColor = SystemColors.ControlLightLight;
        buttonBack.FlatStyle = FlatStyle.Flat;
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.Location = new Point(6, 562);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(100, 50);
        buttonBack.TabIndex = 14;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = false;
        // 
        // buttonAdd
        // 
        buttonAdd.BackColor = Color.SpringGreen;
        buttonAdd.FlatStyle = FlatStyle.Flat;
        buttonAdd.Font = new Font("Segoe UI", 12F);
        buttonAdd.Location = new Point(234, 562);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(100, 50);
        buttonAdd.TabIndex = 13;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = false;
        // 
        // ComponentAddController
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBox1);
        Name = "ComponentAddController";
        Size = new Size(340, 615);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDownComponent).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label label;
    private Label labelName;
    private Label labelPrice;
    private TextBox textBoxName;
    private GroupBox groupBox1;
    private Button buttonBack;
    private Button buttonAdd;
    private NumericUpDown numericUpDownComponent;
}
