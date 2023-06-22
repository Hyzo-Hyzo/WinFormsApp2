namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PointX = new System.Windows.Forms.Label();
            this.PointY = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test110ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu110ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            this.MouseMove += Form1_MouseMove;
            this.MouseClick += Form1_MouseClick;
            this.MouseDown += Form1_MouseDown;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mouse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y:";
            // 
            // PointX
            // 
            this.PointX.AutoSize = true;
            this.PointX.Location = new System.Drawing.Point(170, 86);
            this.PointX.Name = "PointX";
            this.PointX.Size = new System.Drawing.Size(0, 15);
            this.PointX.TabIndex = 3;
            // 
            // PointY
            // 
            this.PointY.AutoSize = true;
            this.PointY.Location = new System.Drawing.Point(163, 115);
            this.PointY.Name = "PointY";
            this.PointY.Size = new System.Drawing.Size(0, 15);
            this.PointY.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.test11ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.test1ToolStripMenuItem.Text = "Test 1";
            // 
            // test11ToolStripMenuItem
            // 
            this.test11ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test110ToolStripMenuItem});
            this.test11ToolStripMenuItem.Name = "test11ToolStripMenuItem";
            this.test11ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.test11ToolStripMenuItem.Text = "Test 1.1";
            // 
            // test110ToolStripMenuItem
            // 
            this.test110ToolStripMenuItem.Name = "test110ToolStripMenuItem";
            this.test110ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.test110ToolStripMenuItem.Text = "Test 1.1.0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem,
            this.menu2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu11ToolStripMenuItem});
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.menu1ToolStripMenuItem.Text = "Menu 1";
            // 
            // menu11ToolStripMenuItem
            // 
            this.menu11ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu110ToolStripMenuItem});
            this.menu11ToolStripMenuItem.Name = "menu11ToolStripMenuItem";
            this.menu11ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.menu11ToolStripMenuItem.Text = "Menu 1.1";
            // 
            // menu110ToolStripMenuItem
            // 
            this.menu110ToolStripMenuItem.Name = "menu110ToolStripMenuItem";
            this.menu110ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.menu110ToolStripMenuItem.Text = "Menu 1.1.0";
            // 
            // menu2ToolStripMenuItem
            // 
            this.menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            this.menu2ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.menu2ToolStripMenuItem.Text = "Menu 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PointY);
            this.Controls.Add(this.PointX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label PointX;
        private Label PointY;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem test1ToolStripMenuItem;
        private ToolStripMenuItem test11ToolStripMenuItem;
        private ToolStripMenuItem test110ToolStripMenuItem;
        private ToolStripMenuItem menu1ToolStripMenuItem;
        private ToolStripMenuItem menu11ToolStripMenuItem;
        private ToolStripMenuItem menu110ToolStripMenuItem;
        private ToolStripMenuItem menu2ToolStripMenuItem;
    }
}