Vehiculo vehiculo = new();
vehiculo.Arrancar();
vehiculo.Marca = "Ford";

Coche1 coche = new();
coche.Arrancar();
coche.Detenerse();
coche.Arrancar("Guille");

Console.WriteLine();

Console.WriteLine((int)Estaciones.Primavera);
Console.WriteLine((int)Estaciones.Verano);
Console.WriteLine((int)Estaciones.Otoño);
Console.WriteLine((int)Estaciones.Invierno);


//*Tuplas
//*Tuplas son una forma de almacenar una colección de datos.
Console.WriteLine(tuplas.GuillermoMazzari.Item1);
Console.WriteLine(tuplas.GuillermoMazzari.Item2);
Console.WriteLine(tuplas.GuillermoMazzari.Item3);
Console.WriteLine(tuplas.GuillermoMazzari);
