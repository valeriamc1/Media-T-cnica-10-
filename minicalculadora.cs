/******************************************************************************  
     Autor: Valeria Mosquera Cordoba
     Fecha: 29-05-24
     Descripcion:
     
      *****
     App con menu
     *****
     se solicita crear una minicalculadora que realice:
     -Suma
     -Resta
     -Multiplicacion
     -Division
     Debe terminar la ejecucion al usuario elegir la opcion "salir"
*******************************************************************************/
     using System;
     using System.Threading;
     class HelloWorld {
     static void Main(string[]args) {
     Console.WriteLine("Hello World");
     //1 Pantalla Bienvenida (imagen ASCII)
     Console.WriteLine(".----------------.  ");    
     Console.WriteLine("| .--------------. |");
     Console.WriteLine("| |      _       | |");
     Console.WriteLine("| |     | |      |  ");  
     Console.WriteLine("| |  ___| |___   | |");
     Console.WriteLine("| | |___   ___|  | |");
     Console.WriteLine("| |     | |      | |");
     Console.WriteLine("| |     |_|      | |");
     Console.WriteLine("| |              | |");
     Console.WriteLine("| '--------------' |");
     Console.WriteLine("'----------------'  ");
     Console.WriteLine("Bienvenido a la minicalculadora");
     Thread.Sleep(1000); // 3 segundos= 3000 milisegundos 
     Console.Clear();
      // 2 Mostrar menú de opciones
    Console.WriteLine("Menú de opciones");
    Console.WriteLine("Seleccionar la opción deseada:");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicación");
    Console.WriteLine("4. Divisón");
    Console.WriteLine("5. Salir");
    
    // 3 capturar opción elegida por usuario
    Console.Write("Digitar opción deseada: ");
    int opcion = Int32.Parse(Console.ReadLine());
    
    if(opcion ==5){
    goto Salir;
    }

    // 3.5 capturar los números elegidos por el usuario
    Console.Write("\nDigitar numero 1: ");
    int numero1 = Int32.Parse(Console.ReadLine());
    Console.Write("\nDigitar numero 2: ");
    int numero2 = Int32.Parse(Console.ReadLine());
    
    // 4 Validar opción elegida
    if( opcion == 1){
        Console.WriteLine("la suma es:"+ (numero1+numero2));
            
     }
     
     if( opcion == 2){
        Console.WriteLine("la resta es:"+ (numero1-numero2));
     }
     
     if( opcion == 3){
        Console.WriteLine("la Multiplicación es:"+ (numero1*numero2));
     }
       
      if( opcion == 4){
        if ( numero1 != 0 && numero2 !=0){
            Console.WriteLine("La división es: " + (numero1/numero2));    
        }
        else{
            Console.WriteLine("No se puede dividir por cero.");    
        }
    }

       // 5 Mostrar resultado o finalizar ejecución
    Salir:
        Console.WriteLine("Saliendo del programa...");
    
    
    }
}