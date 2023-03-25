//void Adivina ()
//{
//    const int Oportunidades = 4;
//    int numeroCPU, numeroUser;
//    byte intentos, BanderaControl;
//    string linea;


//    Random rand = new Random();

//    numeroCPU = Convert.ToInt32(rand.Next(1,20));
//    Console.WriteLine(numeroCPU);
//    //El ! hace que se niegue, para que mientras que no este dentro de ese rango pase ello.

//    //Proceso
//    intentos = 1;
//    BanderaControl = 0;
//    do
//    {
//        Console.WriteLine("Hola, estoy pensando en un número, cual crees que es el correcto?");
//        numeroUser= Convert.ToInt32(Console.ReadLine());
//        if ((numeroUser==numeroCPU))
//        {
//            Console.WriteLine("Genial!, has adivinado el numero!");
//            BanderaControl = 1;
//        } else
//        {
//            if (numeroUser>numeroCPU)
//            {
//                Console.WriteLine("Lo siento, has insertado un numero mayor al que he pensado, intentalo de nuevo:");
//            } else
//            {
//                Console.WriteLine("Lo siento, has insertado un numero menor al que he pensado, intentalo de nuevo:");
//            }
//        }
//        intentos++;

//    } while (((intentos <= Oportunidades) & (BanderaControl == 0)));

//    if (BanderaControl == 0 ) 
//    {
//            Console.WriteLine("El numero que pensé era:" +numeroCPU);
//    }   

//}


//void buscaMayor()
//{
//    int mayor = 0;
//    int numero = 0;
//    Random numr= new Random();

//    for (int i = 0; i < 5; i++)
//    {
//        numero = numr.Next(100);
//        Console.WriteLine(numero);
//        if (numero > mayor)
//        {
//            mayor = numero;
//        }
//    }
//    Console.WriteLine("El numero mayor es: "+mayor);
//}


//void buscaMenor()
//{
//    int menor = 100;
//    int numero = 0;
//    Random numr = new Random();

//    for (int i = 0; i < 5; i++)
//    {
//        numero = numr.Next(100);
//        Console.WriteLine(numero);
//        if (numero < menor)
//        {
//            menor = numero;
//        }
//    }
//    Console.WriteLine("El numero menor es: " + menor);
//}
////buscaMenor();
////buscaMayor();



//void arreglos()
//{
//    int[] notas = new int[15];
//    Random rnd = new Random();

//    for (int i = 0;i < notas.Length;i++)
//    {
//        notas[i] = rnd.Next(100);
//    }
//    Console.WriteLine("Desplegando información");




//    for (int i = 0; i < notas.Length; i++)
//    {
//        Console.WriteLine(notas[i]);
//    }

//        int mayor = 0;
//        for (int i = 0; i < 100;)
//        {
//            Console.WriteLine(i);
//            if (i > mayor)
//            {
//                mayor = i;
//            }
//        }
//        Console.WriteLine("El numero mayor es: " +mayor);


//        int menor = 100;
//        for (int i = 0; i < 100;)
//        {
//            Console.WriteLine(i);
//            if (i < menor)
//            {
//                menor = i;
//            }
//        }
//        Console.WriteLine("El numero menor es: " + menor);
//}



 void nombres()
{
    string[] nombre = new string[5];
    nombre[0] = "Jairo";
    nombre[1] = "Brandom";
    nombre[2] = "Hector";
    nombre[3] = "Yeimi";
    nombre[4] = "Fatima";

    for (int i = 0; i < nombre.Length; i++)
    {
        Console.WriteLine(i + "; " + nombre[i]);
    }
    Random g1 = new Random(10);
    int numeroCPU1 = 0;
    numeroCPU1 = Convert.ToInt32(g1.Next(0, nombre.Length));
    Console.WriteLine("\nEl primer ganador es:"+nombre[numeroCPU1]);

    int numeroCPU2 =0;
    Random g2 = new Random(10);
    
    while(numeroCPU1 == numeroCPU2)
    {
        numeroCPU2 = Convert.ToInt32(g2.Next(0, nombre.Length));
    }
    Console.WriteLine("\nEl segundo ganador es:" + nombre[numeroCPU2]);
}

nombres();