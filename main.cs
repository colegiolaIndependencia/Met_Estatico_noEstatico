using System;

 class Program
    { 
        static void Main(string[] args)
        {
            var objeto1 = new Program(); // Instanciación de objeto1 
            objeto1.MetodoPrivado();      //Llamado al metodo no estatico
            Console.WriteLine("Inicio del Metodo principal");
        }
        private static void MetodoEstaticoPrivado()// Deben ser Estaticos como el Main
        {
            Console.WriteLine("Metodo estatico invocado.");
        }
            // Metodo que no necesita del static ya que crea instancias 
            // para poder acceder al Main
        private void MetodoPrivado()
        {
            Console.WriteLine("Hola desde el metodo no estatico");
            Console.ReadLine();
        }
        
        
    }