using System.Diagnostics.Contracts;

namespace Clase22R;

class Program
{
    struct fechaNac {
        public int dia;
        public int mes;
        public int age;
    }
    struct Persona
    {
        public string nombre;
        public char inicial;
        public int edad;
        public double nota;
        public fechaNac fN;
    }
    static void Main(string[] args)
    {
        Persona per;
        per.nombre ="Ariel";
        per.inicial = 'A';
        per.edad = 23;
        per.fN.age = 2000;
        per.fN.mes = 5;
        Console.WriteLine($"{per.nombre} nació en el año {per.fN.age}.");
        // Persona[] per = new Persona[3];
        // for (int i = 0; i < per.Length; i++)
        // {
        //     Console.Write("Ingrese el nombre: ");
        //     per[i].nombre = Console.ReadLine();
        //     Console.Write("Ingrese su inicial: ");
        //     per[i].inicial = Convert.ToChar(Console.ReadLine());
        //     Console.Write("Ingrese su edad: ");
        //     per[i].edad = Convert.ToInt16(Console.ReadLine());
        //     Console.Write("Ingrese la nota: ");
        //     per[i].nota = Convert.ToDouble(Console.ReadLine());
        // }
        // for (int i = 0; i < per.Length; i++)
        // {
        //     Console.WriteLine($"{per[i].nombre} | {per[i].inicial} | {per[i].edad} | {per[i].nota} |");
        //     Console.WriteLine();
        // }
        // Console.WriteLine($"La edad de {per[0].nombre} es de {per[0].edad} años.");
        // Console.WriteLine($"La inicial de {per[2].nombre} es {per[2].inicial}.");

    }
}

