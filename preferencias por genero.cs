/******************************************************************************  
     Autor: Valeria Mosquera Cordoba
     Fecha: 29-05-24
     Descripcion: Ejercicio estructura de decisión múltiple
     Se desea un programa que ayude diciendo 
     las preferencias según el género:
     - Si es un hombre menor de edad sus preferencias son:
     Figuras de acción, Caricaturas, Series TV
     - Si es un hombre mayor de edad sus preferencias son:
     cine, picnic y filantropía
     - Si es una mujer menor de edad sus preferencias son:
     Muñecas, Maquillaje, Series TV
     - Si es una mujer mayor de edad sus preferencias son:
     Maquillaje, Series TV, Cine, filantropía

*******************************************************************************/
     using System;
     class HelloWorld {
     static void Main(string[]args) {
      // 1 Variables 
      Console.WriteLine("Escribir 'hombre' o 'mujer' ");
      string genero = Console.ReadLine()
      Console.WriteLine("Escribir tu edad ");
      int edad=  Int32.Parse(Console.ReadLine())
     
     // 2 mostrar menu de opciones 
     Console.WriteLine("seleccione su genero: ");
     Console.WriteLine("1.hombre");
     Console.WriteLine("2. mujer");
     
     //validacion
     if ( genero == "hombre"){
         if(edad<17)
         Console.WriteLine("sus preferencias son:Figuras de acción, Caricaturas, Series TV");
         
     }
     
     }
     }