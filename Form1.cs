using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Press_OK
{
    public partial class Form1 : Form
    {
        private int ticks=1;
        private bool show = false;
        private bool isClickable = false;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Button2_MouseMove(object sender, MouseEventArgs e)
        {
            Point cur = this.PointToClient(Cursor.Position);
            Point loc = button2.Location;
            int x_new = loc.X;
            int y_new = loc.Y;

            if (this.isClickable)
                return;

            if (cur.X < loc.X + 10) //движение вправо
            {
                x_new += 30;
                button2.Width = button2.Width - 2;
                button2.Height = button2.Height - 1;
            }

            if(cur.X +10>loc.X + button2.Width) //движение влево
            {
                x_new += -30;
                button2.Width = button2.Width - 2;
                button2.Height = button2.Height - 1;
            }

            if (x_new < 30) //отступ слева
            {
                x_new = 30;
                button2.Width = button2.Width - 2;
                button2.Height = button2.Height - 1;
            }

            if(x_new>this.Width - button2.Width - 30) //отступ справа
            {
                x_new = this.Width - button2.Width - 30;
                button2.Width = button2.Width - 2;
                button2.Height = button2.Height - 1;
            }

            if (cur.Y < loc.Y + 10) //движение вниз
            {
                y_new += 30;
                button2.Width = button2.Width - 2;
                button2.Height = button2.Height - 1;
            }

            if(cur.Y + 10 > loc.Y + button2.Height) //движение вверх
            {
                y_new += -30;
                button2.Width = button2.Width - 2;
                button2.Height = button2.Height - 1;
            }

            if (y_new < 30) //отступ сверху
            {
                y_new = 10;
                button2.Width = button2.Width - 2;
                button2.Height = button2.Height - 1;
            }

            if(y_new>this.Height - button2.Height - 30) //отступ снизу
            {
                y_new = this.Height - button2.Height - 45;
                button2.Width = button2.Width - 2;
                button2.Height = button2.Height - 1;
            }

            if (y_new > this.Height - button2.Height - 15) //курсор внизу формы
            {
                y_new = this.Height - button2.Height - 80;
                button2.Width = button2.Width - 2;
                button2.Height = button2.Height - 1;
            }

            if(x_new>this.Width - button2.Width - 15) //курсор справа формы
            {
                x_new += -100;
                button2.Width = button2.Width - 2;
                button2.Height = button2.Height - 1;
            }

            if (y_new < 15) //курсор вверху формы
            {
                y_new += 50;
                button2.Width = button2.Width - 2;
                button2.Height = button2.Height - 1;
            }

            if (x_new < 15) //курсор слева формы
            {
                x_new += 100;
                button2.Width = button2.Width - 2;
                button2.Height = button2.Height - 1;
            }

            button2.Location=new Point(x_new, y_new);
        }
        private void Form(object sender, EventArgs e)
        {
            
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
            button1.TabStop = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button2.TabStop = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            if (this.show)
            {
                this.Text = "Press 'OK' button";
                this.show = false;
            }
            else
            {
                this.Text = "";
                this.show = true;
            }
            ++ticks;

            if (this.ticks <= 16)
                return;

            this.timer1.Enabled = false;
            this.show = false;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            
                if (this.show)
                {
                    this.Text = "'OK' will never been pressed!!!";
                    this.show = false;
                }
                else
                {
                    this.Text = "";
                    this.show = true;
                }
                ++this.ticks;
            
        }
    }
}
