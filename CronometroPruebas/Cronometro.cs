using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace CronometroPruebas
{
    public class Cronometro
    {
        public int Hor { get; set; }
        public int Min { get; set; }
        public int Seg { get; set; }
        public TextBox TxtSegundos { get; set; }

        public DispatcherTimer dt = new DispatcherTimer();
        public Cronometro(int hor, int min, int seg )

        {
            Hor = hor;
            Min = min;
            Seg = seg;
            this.dt.Interval = TimeSpan.FromSeconds(1);
            //            dt.Tick += tickevent;
            dt.Tick += (a, b) =>
            Seg = Seg + 1;
            TxtSegundos.Text = dt.ToString();
        }
//        private void tickevent(object sender, EventArgs e)
//        {
//            Seg = Seg + 1;
//            //txtSegundos.Text = Seg.ToString();
//        }
        public void Arrancar()
        {

            dt.Start();
        }
    }
}
