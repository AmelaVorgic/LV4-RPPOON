using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4-RPPOON
{
     interface IRentable
        {
         String Description { get; }
         double CalculatePrice();
        }
}