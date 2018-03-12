using System;
using System.Threading;
using System.Windows.Forms;
using ClockFunctional;
using ClockForm;

namespace ClockForm
{
    public partial class Form1 : Form
    {
        Thread clockThread;
            
        public Form1()
        {
            InitializeComponent();
            clockThread = new Thread(StartClock);
            clockThread.Start();
        }


        private void StartClock()
        {
            var clock = new Clock();
            clock.Ticked += SetClockLabel;
            clock.Tick();
        }

        private void SetClockLabel(object sender, TimeEventArgs e)
        {
            var clock = sender as Clock; 
            lblClock.Text = String.Format("{0}{1}{2}", e.Hour, e.Minute, e.Second);
        }
        
        private void RunClock()
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            clockThread.Abort();
        }
    }
}
