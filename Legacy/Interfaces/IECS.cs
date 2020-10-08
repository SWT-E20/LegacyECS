﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Legacy
{
    public interface IECS
    {
        public void Regulate();
        public void SetThreshold(int thr);
        public int GetThreshold();
        public int GetCurTemp();
        public bool RunSelfTest();
    }
}
