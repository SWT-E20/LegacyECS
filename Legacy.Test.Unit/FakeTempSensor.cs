using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legacy
{
    public class FakeTempSensor : ITempSensor
    {
        private int _temperature;
        public void SetTemp(int val)
        {
            if (val > -5 && val < 45)
            {
                _temperature = val;
            }
        }

        public int GetTemp()
        {
            return _temperature;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
