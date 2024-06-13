using System.Windows.Forms.VisualStyles;

namespace _28._05._2024
{
    public partial class Form1 : Form
    {
        private Car_Toyota ct;
        private int meter;
        private int tmr_hit;
        private bool ingame;
        private int tmr_meter;
        private int speed;
        private int accel_g;
        private int accel_h;

        public Form1()
        {
            speed = 0;
            accel_g = 2;
            accel_h = 8;
            InitializeComponent();
            ct = new Car_Toyota("corolla");
            ct.hit_from_pit += ct.hit_handler;
            meter = 0;
            ingame = false;
            tmr_meter = 0;
            ct.Y = player.Bottom;
            System.Console.WriteLine(ct.Y);
        }

        private void Decr_Button_Click(object sender, EventArgs e)
        {
            counter -= 1;
            ct.Speed -= 1;
            show_text.Text = ct.Speed.ToString();

            accel_h = accel_g * 4;
        }
        private void Incr_button_Click(object sender, EventArgs e)
        {
            counter += 1;
            ct.Speed += 1;
            show_text.Text = ct.Speed.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //player.Left = ct.update_Y();
            //meter = Math.Round(meter + ct.Speed * 0.1 , 1);
            meter += ct.Speed;
            tmr_meter++;
            if (tmr_meter >= 15)
            {
                show_meter.Text = meter.ToString();
                tmr_meter = 0;
            }
            show_life.Text = ct.Life.ToString();
            Random rand = new Random();
            if (rand.Next(1, 30) == 2)
            {
                show_hit.Visible = true;
                tmr_hit = 8;
                if (ct.hit_handler(1))
                {
                    /*                    timer1.Stop();*/
                    show_hit.Text = "meter = " + meter.ToString();

                }
            }
            tmr_hit = tmr_hit > 0 ? tmr_hit - 1 : 0;
            if (tmr_hit == 0) show_hit.Visible = false;

            BG1.Left -= ct.Speed * 10;
            BG2.Left -= ct.Speed * 10;
            if (BG1.Left < -800)
            {
                BG1.Left = 0;
                BG2.Left = BG1.Right;
            }
            if (ct.Life < 0) { timer1.Stop(); }


            /*accel_h=accel_h>0 ? accel_h-1:0 ;

            speed += accel_g - accel_h;*/

            

            speed += accel_g;
            if (player.Top >= BG1.Top - player.Height)
            {
                player.Top = BG1.Top - player.Height;
                speed = 0;
            }
            player.Top += speed - accel_h*2;

            if (accel_h > 0) accel_h -= 1;
            else accel_h = 0;

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            ct.Life = 30;
            meter = 0;
            show_life.Text = ct.Life.ToString();
            show_meter.Text = meter.ToString();

            button_stop.Visible = true;
            button_stop.Enabled = true;

            button_restart.Visible = true;
            button_restart.Enabled = true;

            ingame = true;

            button_start.Enabled = false;
            button_start.Visible = false;

        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            if (ingame)
            {
                timer1.Stop();
                button_stop.Text = "resume";
                ingame = false;
            }
            else
            {
                timer1.Start();
                button_stop.Text = "stop";
                ingame = true;
            }
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            ct.Life = 30;
            meter = 0;

        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            accel_h = accel_g * 4;
        }
    }
}
