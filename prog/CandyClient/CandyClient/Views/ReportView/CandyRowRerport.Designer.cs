namespace CandyClient.Views.ReportView;

partial class CandyRowRerport
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandyRowRerport));
        groupBox1 = new GroupBox();
        pictureBox1 = new PictureBox();
        label3 = new Label();
        label4 = new Label();
        label2 = new Label();
        label1 = new Label();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(pictureBox1);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(570, 150);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
        pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        pictureBox1.Location = new Point(429, 19);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(119, 113);
        pictureBox1.TabIndex = 4;
        pictureBox1.TabStop = false;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F);
        label3.Location = new Point(95, 55);
        label3.Name = "label3";
        label3.Size = new Size(55, 21);
        label3.TabIndex = 3;
        label3.Text = "Name:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 12F);
        label4.Location = new Point(24, 55);
        label4.Name = "label4";
        label4.Size = new Size(47, 21);
        label4.TabIndex = 2;
        label4.Text = "Price:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F);
        label2.Location = new Point(95, 19);
        label2.Name = "label2";
        label2.Size = new Size(55, 21);
        label2.TabIndex = 1;
        label2.Text = "Name:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F);
        label1.Location = new Point(24, 19);
        label1.Name = "label1";
        label1.Size = new Size(55, 21);
        label1.TabIndex = 0;
        label1.Text = "Name:";
        // 
        // CandyRowRerport
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Name = "CandyRowRerport";
        Size = new Size(570, 150);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private PictureBox pictureBox1;
    private Label label3;
    private Label label4;
    private Label label2;
    private Label label1;
}
