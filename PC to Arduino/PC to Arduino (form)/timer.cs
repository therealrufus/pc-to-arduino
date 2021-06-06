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

        public static void reset(System.Windows.Forms.Timer t, System.Windows.Forms.Label l, System.Windows.Forms.Label s)
        {
            stopky = DateTime.MinValue;
            t.Enabled = false;
            l.Text = $"00:00:00";
            s.Text = $"00.00";
        }
        public static void enable(System.Windows.Forms.Timer t)
        {
            t.Enabled = true;
        }
        public static void disable(System.Windows.Forms.Timer t)
        {
            t.Enabled = false;
        }
        public static void tick(System.Windows.Forms.Label l, System.Windows.Forms.Label s, double len)
        {
            stopky = stopky.AddMilliseconds(10);
            l.Text = stopky.ToString("mm:ss.FF");
            s.Text = Convert.ToString(Math.Round(len / (stopky.Subtract(DateTime.MinValue).TotalSeconds), 2));
        }
    }
}
