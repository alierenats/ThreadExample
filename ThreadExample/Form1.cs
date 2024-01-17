using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
        }
        Random rnd;
        Thread th1;        
        Thread th2;
        Thread th3;


        private void Form1_Load(object? sender, EventArgs e)
        {
            rnd = new Random();

        }



        public void method1()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4),
                                                    new Rectangle(rnd.Next(0, this.Width),
                                                                  rnd.Next(0, this.Height), 30, 30));
                Thread.Sleep(100);

            }

        }

        public void method2()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4),
                    new Rectangle(rnd.Next(0, this.Width),
                                  rnd.Next(0, this.Height), 30, 30));
                Thread.Sleep(100);
            }

        }

        public void method3()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Yellow, 4),
                    new Rectangle(rnd.Next(0, this.Width),
                                  rnd.Next(0, this.Height), 30, 30));
                Thread.Sleep(100);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            th1 = new Thread(method1);
            th1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            th2 = new Thread(method2);
            th2.Start();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            th3 = new Thread(method3);
            th3.Start();
        }

    }
}

