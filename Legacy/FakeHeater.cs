using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legacy
{
    public class FakeHeater : IHeater
    {
        public int TurnOnCalledTimes { get; set; }
        public int TurnOffCalledTimes { get; set; }

        public void TurnOn()
        {
            TurnOnCalledTimes++;
        }

        public void TurnOff()
        {
            TurnOffCalledTimes++;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
