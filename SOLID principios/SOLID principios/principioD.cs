using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace SOLID_principios
{
    public interface ITransporte
    {
        string Nombre { get; }
        int CapacidadPersonas { get; }
    }

    public class BicicletaD: ITransporte
    {
        public string Nombre => "Bicicleta";
        public int CapacidadPersonas => 1;
    }
    public class BusD: ITransporte
    {
        public string Nombre => "Bus Urbano";
        public int CapacidadPersonas => 40;
    }
    public class MotoD: ITransporte
    {
        public string Nombre => "Motocicleta";
        public int CapacidadPersonas => 2;
    }
    public class CarroD : ITransporte
    {
        public string Nombre => "Carro familiar";
        public int CapacidadPersonas => 7;
    }
    public class GestorDeViaje
    {
        public int CalcularCapacidadTotal(List<ITransporte> transportes)
        {
            return transportes.Sum(t => t.CapacidadPersonas);
        }
    }
}
