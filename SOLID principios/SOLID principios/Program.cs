// See https://aka.ms/new-console-template for more information
using SOLID_principios;
BicicletaL bici1 = new BicicletaL();

CarroL carro1 = new CarroL();

BusL bus1 = new BusL();

MotoL moto1 = new MotoL();

List<MedioDeTransporte> listaTransportes = new List<MedioDeTransporte>();
listaTransportes.Add(bici1);
listaTransportes.Add(bus1);
listaTransportes.Add(moto1);
listaTransportes.Add(carro1);


Console.WriteLine("-LSP-");
foreach (var transporte in listaTransportes)
{
    Console.WriteLine($"{transporte.Nombre} tiene capacidad para {transporte.CapacidadPersonas} persona(s).");
}
Console.WriteLine("\n-ISP-");
BicicletaI biciI = new BicicletaI();
BusI busI= new BusI();
MotoI motoI = new MotoI();
CarroI carroI =new CarroI();

Console.WriteLine($"Bicicleta ruedas: {biciI.CantidadRuedas}");
Console.WriteLine($"Bus ruedas: {busI.CantidadRuedas}");
Console.WriteLine($"Moto ruedas: {motoI.CantidadRuedas}");
Console.WriteLine($"Carro ruedas: {carroI.CantidadRuedas}");

busI.GirarVolante();
carroI.GirarVolante();
Console.WriteLine("\n-DIP-");
GestorDeViaje gestor = new GestorDeViaje();
BicicletaD biciD1 = new BicicletaD();
BusD busD1 = new BusD();
MotoD motoD1 = new MotoD();
CarroD carroD1 = new CarroD();

List<ITransporte> flota = new List<ITransporte> { biciD1, busD1, motoD1};


int capacidadTotal = gestor.CalcularCapacidadTotal(flota);
Console.WriteLine($"La capacidad total de la flota procesada por el gestor es: {capacidadTotal} personas.");