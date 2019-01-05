﻿namespace GraphicalProgram
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.canvasBox = new System.Windows.Forms.PictureBox();
            this.canvasLabel = new System.Windows.Forms.Label();
            this.cmdLabel = new System.Windows.Forms.Label();
            this.commandText = new System.Windows.Forms.TextBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.drawButton = new System.Windows.Forms.Button();
            this.textButton = new System.Windows.Forms.Button();
            this.canvasButton = new System.Windows.Forms.Button();
            this.toolsLabel = new System.Windows.Forms.Label();
            this.penLabel = new System.Windows.Forms.Label();
            this.cdLabel = new System.Windows.Forms.Label();
            this.xlabel = new System.Windows.Forms.Label();
            this.ylabel = new System.Windows.Forms.Label();
            this.xTxtbox = new System.Windows.Forms.TextBox();
            this.yTxtbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.canvasBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvasBox
            // 
            this.canvasBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasBox.Location = new System.Drawing.Point(362, 88);
            this.canvasBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.canvasBox.Name = "canvasBox";
            this.canvasBox.Size = new System.Drawing.Size(1068, 799);
            this.canvasBox.TabIndex = 1;
            this.canvasBox.TabStop = false;
            this.canvasBox.Click += new System.EventHandler(this.canvasBox_Click);
            // 
            // canvasLabel
            // 
            this.canvasLabel.AutoSize = true;
            this.canvasLabel.Location = new System.Drawing.Point(357, 63);
            this.canvasLabel.Name = "canvasLabel";
            this.canvasLabel.Size = new System.Drawing.Size(66, 20);
            this.canvasLabel.TabIndex = 2;
            this.canvasLabel.Text = "Canvas:";
            this.canvasLabel.Click += new System.EventHandler(this.DrawingBoard_Click);
            // 
            // cmdLabel
            // 
            this.cmdLabel.AutoSize = true;
            this.cmdLabel.Location = new System.Drawing.Point(33, 63);
            this.cmdLabel.Name = "cmdLabel";
            this.cmdLabel.Size = new System.Drawing.Size(137, 20);
            this.cmdLabel.TabIndex = 3;
            this.cmdLabel.Text = "Enter Commnads:";
            // 
            // commandText
            // 
            this.commandText.Location = new System.Drawing.Point(38, 88);
            this.commandText.Multiline = true;
            this.commandText.Name = "commandText";
            this.commandText.Size = new System.Drawing.Size(286, 382);
            this.commandText.TabIndex = 4;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipsToolStripMenuItem,
            this.coloursToolStripMenuItem,
            this.shapesToolStripMenuItem,
            this.commandsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.helpToolStripMenuItem.Text = "Commands";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // tipsToolStripMenuItem
            // 
            this.tipsToolStripMenuItem.Name = "tipsToolStripMenuItem";
            this.tipsToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.tipsToolStripMenuItem.Text = "Tips";
            // 
            // coloursToolStripMenuItem
            // 
            this.coloursToolStripMenuItem.Name = "coloursToolStripMenuItem";
            this.coloursToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.coloursToolStripMenuItem.Text = "Colours";
            // 
            // shapesToolStripMenuItem
            // 
            this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            this.shapesToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.shapesToolStripMenuItem.Text = "Shapes";
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.commandsToolStripMenuItem.Text = "Commands";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1468, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(38, 515);
            this.drawButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(218, 35);
            this.drawButton.TabIndex = 5;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textButton
            // 
            this.textButton.Location = new System.Drawing.Point(38, 605);
            this.textButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(218, 35);
            this.textButton.TabIndex = 6;
            this.textButton.Text = "Clear Text";
            this.textButton.UseVisualStyleBackColor = true;
            this.textButton.Click += new System.EventHandler(this.textButton_Click);
            // 
            // canvasButton
            // 
            this.canvasButton.Location = new System.Drawing.Point(38, 560);
            this.canvasButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.canvasButton.Name = "canvasButton";
            this.canvasButton.Size = new System.Drawing.Size(218, 35);
            this.canvasButton.TabIndex = 7;
            this.canvasButton.Text = "Clear Canvas";
            this.canvasButton.UseVisualStyleBackColor = true;
            this.canvasButton.Click += new System.EventHandler(this.canvasButton_Click);
            // 
            // toolsLabel
            // 
            this.toolsLabel.AutoSize = true;
            this.toolsLabel.Location = new System.Drawing.Point(33, 491);
            this.toolsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toolsLabel.Name = "toolsLabel";
            this.toolsLabel.Size = new System.Drawing.Size(90, 20);
            this.toolsLabel.TabIndex = 8;
            this.toolsLabel.Text = "Commands";
            this.toolsLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // penLabel
            // 
            this.penLabel.AutoSize = true;
            this.penLabel.Location = new System.Drawing.Point(33, 672);
            this.penLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.penLabel.Name = "penLabel";
            this.penLabel.Size = new System.Drawing.Size(88, 20);
            this.penLabel.TabIndex = 9;
            this.penLabel.Text = "Pen Status";
            // 
            // cdLabel
            // 
            this.cdLabel.AutoSize = true;
            this.cdLabel.Location = new System.Drawing.Point(38, 774);
            this.cdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cdLabel.Name = "cdLabel";
            this.cdLabel.Size = new System.Drawing.Size(95, 20);
            this.cdLabel.TabIndex = 10;
            this.cdLabel.Text = "Coordinates";
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.Location = new System.Drawing.Point(38, 817);
            this.xlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(28, 20);
            this.xlabel.TabIndex = 11;
            this.xlabel.Text = "X :";
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Location = new System.Drawing.Point(38, 862);
            this.ylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(28, 20);
            this.ylabel.TabIndex = 12;
            this.ylabel.Text = "Y :";
            // 
            // xTxtbox
            // 
            this.xTxtbox.Location = new System.Drawing.Point(76, 812);
            this.xTxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xTxtbox.Name = "xTxtbox";
            this.xTxtbox.Size = new System.Drawing.Size(148, 26);
            this.xTxtbox.TabIndex = 13;
            // 
            // yTxtbox
            // 
            this.yTxtbox.Location = new System.Drawing.Point(76, 857);
            this.yTxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yTxtbox.Name = "yTxtbox";
            this.yTxtbox.Size = new System.Drawing.Size(148, 26);
            this.yTxtbox.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 704);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 26);
            this.textBox1.TabIndex = 15;
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(252, 30);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AccessibleDescription = "A Graphical Program to create shapes.";
            this.AccessibleName = "Graphical Program";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 928);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.yTxtbox);
            this.Controls.Add(this.xTxtbox);
            this.Controls.Add(this.ylabel);
            this.Controls.Add(this.xlabel);
            this.Controls.Add(this.cdLabel);
            this.Controls.Add(this.penLabel);
            this.Controls.Add(this.toolsLabel);
            this.Controls.Add(this.canvasButton);
            this.Controls.Add(this.textButton);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.commandText);
            this.Controls.Add(this.cmdLabel);
            this.Controls.Add(this.canvasLabel);
            this.Controls.Add(this.canvasBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphical Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvasBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox canvasBox;
        private System.Windows.Forms.Label canvasLabel;
        private System.Windows.Forms.Label cmdLabel;
        private System.Windows.Forms.TextBox commandText;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button textButton;
        private System.Windows.Forms.Button canvasButton;
        private System.Windows.Forms.Label toolsLabel;
        private System.Windows.Forms.Label penLabel;
        private System.Windows.Forms.Label cdLabel;
        private System.Windows.Forms.Label xlabel;
        private System.Windows.Forms.Label ylabel;
        private System.Windows.Forms.TextBox xTxtbox;
        private System.Windows.Forms.TextBox yTxtbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}
