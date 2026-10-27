namespace Battle
{
    public partial class FormMain : Form
    {
        int dx = -5;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        void InitGame()
        {
//Задание 1: fullscreen режим, пушка, ядро переместить в низ в центр
            pictureBoxCanonBall.Visible = false;
            pictureBoxBoom.Visible = false;
            pictureBoxShip.Location = new Point(732, 2);
            pictureBoxShip.Visible = true;
            timerCanonBall.Enabled = false;
            timerShip.Enabled = true;
        }

        private void timerShip_Tick(object sender, EventArgs e)
        {
            pictureBoxShip.Location = new Point(pictureBoxShip.Location.X + dx, pictureBoxShip.Location.Y);
            if (pictureBoxShip.Location.X < 0 ||
                    pictureBoxShip.Location.X > Width - pictureBoxShip.Width - 10) dx = -dx;
        }

        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == ' ') 
            {
//Задание 2: если летит ядро, новое не разрешать выпускать
                pictureBoxCanonBall.Location = new Point(425, 522);
                pictureBoxCanonBall.Visible = true;
                timerCanonBall.Enabled = true;
            }
        }

        double Distance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        private void timerCanonBall_Tick(object sender, EventArgs e)
        {
            pictureBoxCanonBall.Location = new Point(pictureBoxCanonBall.Location.X, 
                                                        pictureBoxCanonBall.Location.Y - 5);
//Задание 3: исправить точность попадания ядра в корабль
            if (Distance(pictureBoxCanonBall.Location, pictureBoxShip.Location) < pictureBoxShip.Width / 2)
            {
                pictureBoxBoom.Location = pictureBoxShip.Location;
                pictureBoxShip.Visible = false;
                pictureBoxCanonBall.Visible = false;
                pictureBoxBoom.Visible = true; 
                timerCanonBall.Enabled = false;
                timerShip.Enabled = false;

                if (MessageBox.Show("Хотите еще сыграть?", "Цель поражена", MessageBoxButtons.YesNo) ==
                      DialogResult.Yes) InitGame();
                else Close();
            }
            if (pictureBoxCanonBall.Location.Y < - pictureBoxCanonBall.Height) 
            {
                pictureBoxCanonBall.Visible = false;
                timerCanonBall.Enabled = false;
            }
        }
    }
}
