using CarsProgram.Logica;
try
{
    var automovil1 = new Automovil()
    {
        Marca = "Ford",
        Modelo = "Mustang",
        Año = 2022,
        Puertas = 2
    };

    var camioneta1 = new Camioneta()
    {
        Marca = "Chevrolet",
        Modelo = "Silverado",
        Año = 2020,
        CapacidadCarga = 1500
    };
    Console.WriteLine(automovil1);
    Console.WriteLine(camioneta1);
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: [{ex.Message}]");
}
