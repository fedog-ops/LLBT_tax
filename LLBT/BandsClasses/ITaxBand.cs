﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBTT.BandsClasses
{
    public interface ITaxBand
    {
        decimal Start { get; }
        decimal End { get; }
        decimal Rate { get; }
    }

}
