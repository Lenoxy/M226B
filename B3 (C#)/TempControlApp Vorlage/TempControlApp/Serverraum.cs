using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;  // für einen threadbasierten Timer

namespace TempControlApp {
    public class Serverraum
    {
        private static Serverraum sigleInstance = null;
        //Singleton
        private Serverraum()
        {
            SollTemperatur = 19;
            IstTemperatur = 15;
            TimerStarten();
        }

        public static Serverraum getInstance()
        {
            if (sigleInstance == null)
                sigleInstance = new Serverraum();
            

            return sigleInstance;
        }



        public double IstTemperatur { get; set; }
        public double SollTemperatur { get; set; }




        private Timer emuliertimer = null;

        private void TimerStarten() {
            emuliertimer = new Timer(TimerCallBackFunction, null, 0, 3000);
        }

        private void TimerCallBackFunction(object State) {
            double delta = SollTemperatur - IstTemperatur;
            if (Math.Abs(delta) < 0.5)
                return;
            else if (delta > 0)
                //Heizen
                IstTemperatur += 0.5;
            else
                //Kühlen
                IstTemperatur -= 0.5;
        }

        public void TimerStoppen() {
            WaitHandle objWait = new AutoResetEvent(false);
            emuliertimer.Dispose(objWait);
            objWait.WaitOne();
            emuliertimer = null;
        }

    }
}
