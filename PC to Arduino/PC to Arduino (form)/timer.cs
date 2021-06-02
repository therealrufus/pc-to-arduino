using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_to_Arduino__form_
{
    class timer
    {
        static DateTime stopky = new DateTime();

        public static void reset(System.Windows.Forms.Timer t)
        {
            stopky = DateTime.MinValue;
            t.Enabled = false;
            timerLabel.Text = $"00:00:00";
        }
        public static void enable(System.Windows.Forms.Timer t)
        {
            t.Enabled = true;
        }
        public static void disable(System.Windows.Forms.Timer t)
        {
            t.Enabled = false;
        }
        public static void timer_Tick(object sender, EventArgs e)
        {
            stopky = stopky.AddMilliseconds(10);
            timerLabel.Text = stopky.ToString("mm:ss.FF");
        }
    }
}
