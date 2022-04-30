namespace TestLibrary;
public class Vehiculo: IVehiculo
    {
        public string Marca { get; set; }
        public float combustible { get; set; }
        public int aforo { get; set; }
        public void Arrancar()
        {
            Console.WriteLine("El vehiculo esta arrancando por la interfaz");
        }
        
    }
