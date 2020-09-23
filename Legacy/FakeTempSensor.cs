using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legacy
{
    public class FakeTempSensor : ITempSensor
    {
        public int Temp { get; set; }
        public bool SelfTestResult { get; set; }

        public int GetTemp()
        {
            return Temp;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
