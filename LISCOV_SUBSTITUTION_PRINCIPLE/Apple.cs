﻿using LISCOV_SUBSTITUTION_PRINCIPLE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISCOV_SUBSTITUTION_PRINCIPLE
{
    public class Apple: IFruit
    {
        public  string GetColor()
        {
            return "Red";
        }
    }
}
