namespace Clase22;

class Program
{
    static void Main(string[] args)
    {    
// Creamos una lista de animales y llamamos al método HacerSonido de cada uno de ellos
        // Creamos una lista de animales
        Animal[] animales = new Animal[3];
        animales[0] = new Perro();
        animales[1] = new Gato();
        animales[2] = new Pajaro();

        // Llamamos al método HacerSonido de cada animal
        foreach (Animal animal in animales)  
        {
            animal.HacerSonido();
        }
    }
}


