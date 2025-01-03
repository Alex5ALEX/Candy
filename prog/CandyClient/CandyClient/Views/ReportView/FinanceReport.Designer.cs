namespace CandyClient.Views.ReportView;

partial class FinanceReport
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
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
        groupBox1 = new GroupBox();
        groupBox3 = new GroupBox();
        chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
        groupBox2 = new GroupBox();
        label6 = new Label();
        label7 = new Label();
        label1 = new Label();
        label8 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        groupBox1.SuspendLayout();
        groupBox3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.BackColor = SystemColors.ControlLightLight;
        groupBox1.Controls.Add(groupBox3);
        groupBox1.Controls.Add(groupBox2);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(1254, 615);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(chart1);
        groupBox3.Font = new Font("Segoe UI", 12F);
        groupBox3.Location = new Point(298, 22);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(950, 587);
        groupBox3.TabIndex = 1;
        groupBox3.TabStop = false;
        // 
        // chart1
        // 
        chartArea1.Name = "ChartArea1";
        chart1.ChartAreas.Add(chartArea1);
        legend1.Name = "Legend1";
        chart1.Legends.Add(legend1);
        chart1.Location = new Point(6, 20);
        chart1.Name = "chart1";
        series1.ChartArea = "ChartArea1";
        series1.Legend = "Legend1";
        series1.Name = "Series1";
        chart1.Series.Add(series1);
        chart1.Size = new Size(938, 561);
        chart1.TabIndex = 0;
        chart1.Text = "chart1";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(label7);
        groupBox2.Controls.Add(label1);
        groupBox2.Controls.Add(label8);
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(label2);
        groupBox2.Font = new Font("Segoe UI", 12F);
        groupBox2.Location = new Point(15, 22);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(277, 587);
        groupBox2.TabIndex = 0;
        groupBox2.TabStop = false;
        groupBox2.Text = "Statistic";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 12F);
        label6.Location = new Point(155, 203);
        label6.Name = "label6";
        label6.Size = new Size(52, 21);
        label6.TabIndex = 21;
        label6.Text = "label6";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 12F);
        label7.Location = new Point(6, 203);
        label7.Name = "label7";
        label7.Size = new Size(143, 21);
        label7.TabIndex = 20;
        label7.Text = "Quantity of Supply:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F);
        label1.Location = new Point(124, 49);
        label1.Name = "label1";
        label1.Size = new Size(52, 21);
        label1.TabIndex = 19;
        label1.Text = "label1";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 12F);
        label8.Location = new Point(6, 79);
        label8.Name = "label8";
        label8.Size = new Size(112, 21);
        label8.TabIndex = 18;
        label8.Text = "Total expenses:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 12F);
        label5.Location = new Point(155, 169);
        label5.Name = "label5";
        label5.Size = new Size(52, 21);
        label5.TabIndex = 15;
        label5.Text = "label5";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 12F);
        label4.Location = new Point(6, 169);
        label4.Name = "label4";
        label4.Size = new Size(143, 21);
        label4.TabIndex = 14;
        label4.Text = "Quantity of Orders:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F);
        label3.Location = new Point(124, 79);
        label3.Name = "label3";
        label3.Size = new Size(52, 21);
        label3.TabIndex = 13;
        label3.Text = "label3";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F);
        label2.Location = new Point(6, 49);
        label2.Name = "label2";
        label2.Size = new Size(87, 21);
        label2.TabIndex = 12;
        label2.Text = "Total profit:";
        // 
        // FinanceReport
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Name = "FinanceReport";
        Size = new Size(1254, 615);
        groupBox1.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private Label label1;
    private Label label8;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private GroupBox groupBox3;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private Label label6;
    private Label label7;
}
