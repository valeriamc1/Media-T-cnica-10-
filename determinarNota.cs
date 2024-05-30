/******************************************************************************

Autor: Valeria Mosquera Cordoba
     Fecha: 29-05-24
     Descripcion: dada la nota determinar:
     1- pierde
     2-pierde
     3-gana
     4-alto
     5-superior
*******************************************************************************/
using System;
class Programa {
  static void Main() {
       Console.WriteLine("digite una opcion ");
       Console.WriteLine("opcion:");
       int nota= Int32.Parse(Console.ReadLine());
       switch(nota) 
            {  
          case 1:
              Console.WriteLine("pierde");
             break;
          case 2:
             Console.WriteLine("pierde");
             break;
          case 3:
              Console.WriteLine("gana");
             break;
          case 4:
             Console.WriteLine("alto");
             break;
          case 5:
             Console.WriteLine("superior");
             break;
         default:
              Console.WriteLine("opcion no valida");
              Console.WriteLine("Saliendo del programa");
              break;
            }
        }
   }