﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    [Serializable]
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
