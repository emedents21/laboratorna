﻿namespace Laba2
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Inheritance = new System.Windows.Forms.ToolStripMenuItem();
            this.inheritanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абстракiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abstractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Inheritance,
            this.абстракiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Inheritance
            // 
            this.Inheritance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inheritanceToolStripMenuItem});
            this.Inheritance.Name = "Inheritance";
            this.Inheritance.Size = new System.Drawing.Size(90, 20);
            this.Inheritance.Text = "Спадкування";
            this.Inheritance.Click += new System.EventHandler(this.Inheritance_Click);
            // 
            // inheritanceToolStripMenuItem
            // 
            this.inheritanceToolStripMenuItem.Name = "inheritanceToolStripMenuItem";
            this.inheritanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inheritanceToolStripMenuItem.Text = "Inheritance";
            this.inheritanceToolStripMenuItem.Click += new System.EventHandler(this.inheritanceToolStripMenuItem_Click);
            // 
            // абстракiToolStripMenuItem
            // 
            this.абстракiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abstractToolStripMenuItem});
            this.абстракiToolStripMenuItem.Name = "абстракiToolStripMenuItem";
            this.абстракiToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.абстракiToolStripMenuItem.Text = "Абстракцiя";
            this.абстракiToolStripMenuItem.Click += new System.EventHandler(this.абстракiToolStripMenuItem_Click);
            // 
            // abstractToolStripMenuItem
            // 
            this.abstractToolStripMenuItem.Name = "abstractToolStripMenuItem";
            this.abstractToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abstractToolStripMenuItem.Text = "Abstract";
            this.abstractToolStripMenuItem.Click += new System.EventHandler(this.abstractToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Inheritance;
        private System.Windows.Forms.ToolStripMenuItem inheritanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абстракiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abstractToolStripMenuItem;
    }
}

