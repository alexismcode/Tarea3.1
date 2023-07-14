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
    Console.WriteLine(automovil1);
}
catch (Exception ex)
{
    Console.WriteLine($"Existio un Eror {ex.Message}");
}
Console.WriteLine("Sigo en pie...!");
