using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenClosePrinciple
{
    public class Pentagono : Shape
    {
        public double Apotema { get; set; }
        public double Perimetro { get; set; }
        public override double Area() => (this.Perimetro * this.Apotema) / 2;
    }
}
