﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullPdbSourceLink
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
