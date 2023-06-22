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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            PointX = new Label();
            PointY = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            test1ToolStripMenuItem = new ToolStripMenuItem();
            test11ToolStripMenuItem = new ToolStripMenuItem();
            test110ToolStripMenuItem = new ToolStripMenuItem();
            menu1ToolStripMenuItem = new ToolStripMenuItem();
            menu11ToolStripMenuItem = new ToolStripMenuItem();
            menu110ToolStripMenuItem = new ToolStripMenuItem();
            menu2ToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 19);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Mouse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 84);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 1;
            label2.Text = "X:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 116);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 2;
            label3.Text = "Y:";
            // 
            // PointX
            // 
            PointX.AutoSize = true;
            PointX.Location = new Point(170, 86);
            PointX.Name = "PointX";
            PointX.Size = new Size(0, 15);
            PointX.TabIndex = 3;
            // 
            // PointY
            // 
            PointY.AutoSize = true;
            PointY.Location = new Point(163, 115);
            PointY.Name = "PointY";
            PointY.Size = new Size(0, 15);
            PointY.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { test1ToolStripMenuItem, test11ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(113, 48);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu1ToolStripMenuItem, menu2ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // test1ToolStripMenuItem
            // 
            test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            test1ToolStripMenuItem.Size = new Size(112, 22);
            test1ToolStripMenuItem.Text = "Test 1";
            // 
            // test11ToolStripMenuItem
            // 
            test11ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { test110ToolStripMenuItem });
            test11ToolStripMenuItem.Name = "test11ToolStripMenuItem";
            test11ToolStripMenuItem.Size = new Size(112, 22);
            test11ToolStripMenuItem.Text = "Test 1.1";
            // 
            // test110ToolStripMenuItem
            // 
            test110ToolStripMenuItem.Name = "test110ToolStripMenuItem";
            test110ToolStripMenuItem.Size = new Size(180, 22);
            test110ToolStripMenuItem.Text = "Test 1.1.0";
            // 
            // menu1ToolStripMenuItem
            // 
            menu1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menu11ToolStripMenuItem });
            menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            menu1ToolStripMenuItem.Size = new Size(59, 20);
            menu1ToolStripMenuItem.Text = "Menu 1";
            // 
            // menu11ToolStripMenuItem
            // 
            menu11ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menu110ToolStripMenuItem });
            menu11ToolStripMenuItem.Name = "menu11ToolStripMenuItem";
            menu11ToolStripMenuItem.Size = new Size(180, 22);
            menu11ToolStripMenuItem.Text = "Menu 1.1";
            // 
            // menu110ToolStripMenuItem
            // 
            menu110ToolStripMenuItem.Name = "menu110ToolStripMenuItem";
            menu110ToolStripMenuItem.Size = new Size(180, 22);
            menu110ToolStripMenuItem.Text = "Menu 1.1.0";
            // 
            // menu2ToolStripMenuItem
            // 
            menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            menu2ToolStripMenuItem.Size = new Size(59, 20);
            menu2ToolStripMenuItem.Text = "Menu 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(PointY);
            Controls.Add(PointX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            MouseClick += Form1_MouseClick;
            MouseMove += Form1_MouseMove;
            MouseDown += Form1_MouseDown;
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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