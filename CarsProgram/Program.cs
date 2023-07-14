using CarsProgram.Logica;
try
{
    var automovil1 = new Automovil()
    {
        Marca = "Ford",
        Modelo = "Mustang",
        Año = 2022,
        RunAction = true,
        Puertas = 2
    };
    var camioneta1 = new Camioneta()
    {
        Marca = "Ford",
        Modelo = "Mustang",
        Año = 2022,
        RunAction = true,
        CapacidadCarga = 1500
    };
    Console.WriteLine(automovil1);
    Console.WriteLine(camioneta1);
}
catch (Exception ex)
{
    Console.WriteLine($"Existio un Eror {ex.Message}");
}
