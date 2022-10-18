namespace Ejercicio_tema_Ocho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Edade = "50";
            persona.Nombre = "Rui Lagos";
            persona.Telefono = "121365888";


            Console.WriteLine("La edad es: " + persona.Edade);
            Console.WriteLine("Nombre: " + persona.Nombre);
            Console.WriteLine("Telefono: " + persona.Telefono);

        }
    }
}

   