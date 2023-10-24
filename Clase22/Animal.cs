// Definimos la clase Animal como clase base
public class Animal  
{

    // Definimos un método virtual que imprimirá el sonido del animal
    public virtual void HacerSonido()  
    {
        Console.WriteLine("Este animal no hace ningún sonido.");
    }
}

// Definimos la clase Perro, que hereda de Animal
public class Perro : Animal  
{
    // Sobreescribimos el método HacerSonido para que imprima el ladrido del perro
    public override void HacerSonido()  
    {
        Console.WriteLine("El perro ladra: ¡Guau guau!");
    }
}

// Definimos la clase Gato, que hereda de Animal
public class Gato : Animal  
{
    // Sobreescribimos el método HacerSonido para que imprima el maullido del gato
    public override void HacerSonido()  
    {
        Console.WriteLine("El gato maúlla: ¡Miau miau!");
    }
}

// Definimos la clase Pájaro, que hereda de Animal
public class Pajaro : Animal  
{
    // Sobreescribimos el método HacerSonido para que imprima el canto del pájaro
    public override void HacerSonido()  
    {
        Console.WriteLine("El pájaro canta: ¡Pio pio!");
    }
}