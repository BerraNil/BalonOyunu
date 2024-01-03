namespace BalonOyunu
{
    public partial class Form1 : Form
    {

        int hiz;
        int skor;
        Random rnd = new Random();
        bool gameOver;

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //5
            txtSkor.Text = "Skor= " + skor.ToString();

            if (gameOver == true)
            {
                timer1.Stop();
                txtSkor.Text = "Skor= " + skor.ToString() + "Oyun bitti yeniden baþlatmak için enter tuþuna basýnýz. ";
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Top -= hiz;




                    if (x.Top < -100)
                    {
                        x.Top = rnd.Next(700, 1000);
                        x.Left = rnd.Next(5, 500);
                    }


                    if ((string)x.Tag == "ballon")
                    {

                        if (x.Top < -50)
                        {
                            gameOver = true;
                        }


                        if (bomb.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Top = rnd.Next(700, 1000);
                            x.Left = rnd.Next(5, 500);

                        }

                    }



                }

            }



            if (skor > 5)
            {
                hiz = 8;
            }

            if (skor > 15 && skor < 25)
            {
                hiz = 12;
            }

        }

        private void BalonTiklandi(object sender, EventArgs e)
        {
            
            if (gameOver == false)
            {
                var tiklananbalon = (PictureBox)sender;
                tiklananbalon.Top = rnd.Next(750, 1000);
                tiklananbalon.Left = rnd.Next(5, 500);
                skor += 1;
            }
        }

        private void BombaTiklandi(object sender, EventArgs e)
        {
            
            if (gameOver == false)
            {
                bomb.Image = Properties.Resources.boom;
                gameOver = true;

            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

           
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }

        }

        private void RestartGame()
        {
            //1
            hiz = 5;
            skor = 0;
            gameOver = false;

            bomb.Image = Properties.Resources.bomb;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Top = rnd.Next(750, 1000);
                    x.Left = rnd.Next(5, 500);

                }

            }

            timer1.Start();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}