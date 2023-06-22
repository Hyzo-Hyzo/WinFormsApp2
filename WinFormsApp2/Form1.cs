namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }     
        //малює слід та координати, при натиску не малює
       private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            PointX.Text = e.X.ToString();
            PointY.Text = e.Y.ToString();

            
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        DrawRectangle(e.Location);
                        break;
                    case MouseButtons.Right:
                        DrawSquare(e.Location);
                        break;
                    case MouseButtons.Middle:
                        DrawLine(e.Location);
                        break;
                }
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Info:\nX = " + e.X + "; Y = " + e.Y + "\nButton: " + e.Button, "Mouse Click Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //при натиску малює 1 символ
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
            switch (e.Button)
            {
                case MouseButtons.Left:
                    DrawRectangle(e.Location);
                    break;
                case MouseButtons.Right:
                    DrawSquare(e.Location);
                    break;
                case MouseButtons.Middle:
                    DrawLine(e.Location);
                    break;
            }
        }

        private void DrawRectangle(Point location)
        {
            Label label = new Label();
            label.Text = "*\n**";
            label.AutoSize = true;
            label.Location = location;
            this.Controls.Add(label);
        }

        private void DrawSquare(Point location)
        {
            Label label = new Label();
            label.Text = "**\n**";
            label.AutoSize = true;
            label.Location = location;
            this.Controls.Add(label);
        }
        private void DrawLine(Point location)
        {
            Label label = new Label();
            label.Text = "⎯-";
            label.AutoSize = true;
            label.Location = location;
            this.Controls.Add(label);
        }

       
    }
}