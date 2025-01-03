using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;

namespace CandyClient;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        labelHello = new Label();
        buttonMenu = new Button();
        groupBoxMenu = new GroupBox();
        ReportOption = new Button();
        labelMenu = new Label();
        providerOption = new Button();
        supplyOption = new Button();
        compOption = new Button();
        orderOption = new Button();
        candyOption = new Button();
        customerOption = new Button();
        backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        groupBoxMenu.SuspendLayout();
        SuspendLayout();
        // 
        // labelHello
        // 
        labelHello.AutoSize = true;
        labelHello.Font = new Font("Microsoft Sans Serif", 28F);
        labelHello.Location = new Point(592, 333);
        labelHello.Name = "labelHello";
        labelHello.Size = new Size(106, 44);
        labelHello.TabIndex = 2;
        labelHello.Text = "Hello";
        // 
        // buttonMenu
        // 
        buttonMenu.BackColor = SystemColors.ControlLightLight;
        buttonMenu.FlatStyle = FlatStyle.Flat;
        buttonMenu.Font = new Font("Segoe UI", 12F);
        buttonMenu.Location = new Point(3, 3);
        buttonMenu.Name = "buttonMenu";
        buttonMenu.Size = new Size(80, 60);
        buttonMenu.TabIndex = 0;
        buttonMenu.Text = "Menu";
        buttonMenu.UseVisualStyleBackColor = false;
        // 
        // groupBoxMenu
        // 
        groupBoxMenu.BackColor = SystemColors.ControlLightLight;
        groupBoxMenu.Controls.Add(ReportOption);
        groupBoxMenu.Controls.Add(labelMenu);
        groupBoxMenu.Controls.Add(providerOption);
        groupBoxMenu.Controls.Add(supplyOption);
        groupBoxMenu.Controls.Add(compOption);
        groupBoxMenu.Controls.Add(orderOption);
        groupBoxMenu.Controls.Add(candyOption);
        groupBoxMenu.Controls.Add(customerOption);
        groupBoxMenu.FlatStyle = FlatStyle.Flat;
        groupBoxMenu.ForeColor = SystemColors.ControlText;
        groupBoxMenu.Location = new Point(0, 0);
        groupBoxMenu.Name = "groupBoxMenu";
        groupBoxMenu.Size = new Size(202, 681);
        groupBoxMenu.TabIndex = 1;
        groupBoxMenu.TabStop = false;
        // 
        // ReportOption
        // 
        ReportOption.BackColor = SystemColors.ControlLightLight;
        ReportOption.FlatStyle = FlatStyle.Flat;
        ReportOption.Font = new Font("Segoe UI", 12F);
        ReportOption.ForeColor = SystemColors.ControlText;
        ReportOption.Location = new Point(6, 624);
        ReportOption.Name = "ReportOption";
        ReportOption.Size = new Size(188, 45);
        ReportOption.TabIndex = 30;
        ReportOption.Text = "Report";
        ReportOption.UseVisualStyleBackColor = false;
        // 
        // labelMenu
        // 
        labelMenu.AutoSize = true;
        labelMenu.BackColor = SystemColors.ControlLightLight;
        labelMenu.FlatStyle = FlatStyle.Flat;
        labelMenu.Font = new Font("Segoe UI", 24F);
        labelMenu.ForeColor = SystemColors.ControlText;
        labelMenu.Location = new Point(6, 19);
        labelMenu.Name = "labelMenu";
        labelMenu.Size = new Size(102, 45);
        labelMenu.TabIndex = 29;
        labelMenu.Text = "Menu";
        // 
        // providerOption
        // 
        providerOption.BackColor = SystemColors.ControlLightLight;
        providerOption.FlatStyle = FlatStyle.Flat;
        providerOption.Font = new Font("Segoe UI", 12F);
        providerOption.ForeColor = SystemColors.ControlText;
        providerOption.Location = new Point(6, 336);
        providerOption.Name = "providerOption";
        providerOption.Size = new Size(188, 45);
        providerOption.TabIndex = 28;
        providerOption.Text = "Providers";
        providerOption.UseVisualStyleBackColor = false;
        // 
        // supplyOption
        // 
        supplyOption.BackColor = SystemColors.ControlLightLight;
        supplyOption.FlatStyle = FlatStyle.Flat;
        supplyOption.Font = new Font("Segoe UI", 12F);
        supplyOption.ForeColor = SystemColors.ControlText;
        supplyOption.Location = new Point(6, 285);
        supplyOption.Name = "supplyOption";
        supplyOption.Size = new Size(188, 45);
        supplyOption.TabIndex = 27;
        supplyOption.Text = "Supplies";
        supplyOption.UseVisualStyleBackColor = false;
        // 
        // compOption
        // 
        compOption.BackColor = SystemColors.ControlLightLight;
        compOption.FlatStyle = FlatStyle.Flat;
        compOption.Font = new Font("Segoe UI", 12F);
        compOption.ForeColor = SystemColors.ControlText;
        compOption.Location = new Point(6, 234);
        compOption.Name = "compOption";
        compOption.Size = new Size(189, 45);
        compOption.TabIndex = 26;
        compOption.Text = "Components";
        compOption.UseVisualStyleBackColor = false;
        // 
        // orderOption
        // 
        orderOption.BackColor = SystemColors.ControlLightLight;
        orderOption.FlatStyle = FlatStyle.Flat;
        orderOption.Font = new Font("Segoe UI", 12F);
        orderOption.ForeColor = SystemColors.ControlText;
        orderOption.Location = new Point(6, 183);
        orderOption.Name = "orderOption";
        orderOption.Size = new Size(189, 45);
        orderOption.TabIndex = 25;
        orderOption.Text = "Orders";
        orderOption.UseVisualStyleBackColor = false;
        // 
        // candyOption
        // 
        candyOption.BackColor = SystemColors.ControlLightLight;
        candyOption.FlatStyle = FlatStyle.Flat;
        candyOption.Font = new Font("Segoe UI", 12F);
        candyOption.ForeColor = SystemColors.ControlText;
        candyOption.Location = new Point(6, 132);
        candyOption.Name = "candyOption";
        candyOption.Size = new Size(188, 45);
        candyOption.TabIndex = 24;
        candyOption.Text = "Candy";
        candyOption.UseVisualStyleBackColor = false;
        // 
        // customerOption
        // 
        customerOption.BackColor = SystemColors.ControlLightLight;
        customerOption.FlatStyle = FlatStyle.Flat;
        customerOption.Font = new Font("Segoe UI", 12F);
        customerOption.Location = new Point(6, 81);
        customerOption.Name = "customerOption";
        customerOption.Size = new Size(188, 45);
        customerOption.TabIndex = 23;
        customerOption.Text = "Customers";
        customerOption.UseVisualStyleBackColor = false;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        ClientSize = new Size(1264, 681);
        Controls.Add(labelHello);
        Controls.Add(groupBoxMenu);
        Controls.Add(buttonMenu);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "MainForm";
        Text = "Candy";
        groupBoxMenu.ResumeLayout(false);
        groupBoxMenu.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button buttonMenu;
    private GroupBox groupBoxMenu;
    private Label labelHello;
    private Button providerOption;
    private Button supplyOption;
    private Button compOption;
    private Button orderOption;
    private Button candyOption;
    private Button customerOption;
    private Button buttonHideMenu;
    private Label labelMenu;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private Button ReportOption;
}