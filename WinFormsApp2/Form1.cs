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

            Check_Buttun(e.Button, e.Location);

        }    
        //при натиску малює 1 символ
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {           
            Check_Buttun(e.Button, e.Location);
        }
        private void Check_Buttun(MouseButtons button, Point location)
        {            
            switch (button)
            {
                case MouseButtons.Left:
                    DrawFigures(location, Figur.Line);
                    break;
                case MouseButtons.Right:
                    DrawFigures(location, Figur.Square);
                    break;
                case MouseButtons.Middle:
                    DrawFigures(location, Figur.Triangle);
                    break;
            }
        }
        private void DrawFigures(Point location, string figure)
        {
            Label label = new Label();
            label.Text = figure;
            label.AutoSize = true;
            label.Location = location;
            this.Controls.Add(label);
        }       
    }
}