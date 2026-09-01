using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principios
{
    public abstract class MedioDeTransporte
    {
        public abstract string Nombre { get; }
        public abstract int CapacidadPersonas { get; }
    }
    public class BicicletaL : MedioDeTransporte
    {
        public override string Nombre => "Bicicleta";
        public override int CapacidadPersonas => 1;
    }
    public class BusL : MedioDeTransporte
    {
        public override string Nombre => "Bus Urbano";
        public override int CapacidadPersonas => 40;
    }
    public class MotoL : MedioDeTransporte
    {
        public override string Nombre => "Motocicleta";
        public override int CapacidadPersonas => 2;
    }
    public class CarroL : MedioDeTransporte
    {
        public override string Nombre => "Carro familiar";
        public override int CapacidadPersonas => 7;
    }
}
