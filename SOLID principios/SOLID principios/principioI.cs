using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principios
{
    public interface IVehiculoConVolante
    {
        void GirarVolante();
    }
    public interface IVehiculoConRuedas
    {
        int CantidadRuedas { get; }
    }

    public class BusI: IVehiculoConVolante, IVehiculoConRuedas
    {
        public int CantidadRuedas => 6;
        public void GirarVolante() => Console.WriteLine("Girando el volante del bus...");
    }
    public class MotoI : IVehiculoConRuedas
    {
        public int CantidadRuedas => 2;
        
    }
    public class CarroI : IVehiculoConVolante, IVehiculoConRuedas
    {
        public int CantidadRuedas => 4;
        public void GirarVolante() => System.Console.WriteLine("Girando el volante del carro...");
    }
    public class BicicletaI: IVehiculoConRuedas
    {
        public int CantidadRuedas => 2;
    }

}
