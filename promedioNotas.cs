 /******************************************************************************
      Autor:  VALERIA MOSQUERA
     lenguaje usado: C#
     Fecha de creación: 2024-05-23
     Descripción:Un docente requiere de un sistema de notas
                 donde recibe 4 calificaciones generando un 
                 promedio y luego determinando si gana o 
                 pierde.
                 Si su promedio es menor a 3 pierde 
                 Si es mayor gana
                 Si tiene un promedio mayor a 4.5 emitir mensaje:
                 "Felicidades, te has ganado una beca"
     *******************************************************************************/
     using System;
     class HelloWorld {
     static void Main() {
         
          //variables
         double calificacion1;
         double calificacion2;
         double calificacion3;
         double calificacion4;
         double promedio;
         
         
           //peticion de datos
           Console.WriteLine("ingrese su nota");
           calificacion1= Convert.ToDouble(Console.ReadLine());
          
               
            Console.WriteLine("ingrese su nota");
           calificacion2= Convert.ToDouble(Console.ReadLine());
               
               
            Console.WriteLine("ingrese su nota");
           calificacion3= Convert.ToDouble(Console.ReadLine());
            
           
           Console.WriteLine("ingrese su nota");
           calificacion4= Convert.ToDouble(Console.ReadLine());
          promedio=(calificacion1+ calificacion2+ calificacion3+ calificacion4)/ 4;
          
          if(promedio<=2.9){
         Console.WriteLine("Perdio");
          }
          
          if (promedio>=3.0){
          Console.WriteLine("Gano");
          }
          
          if (promedio>=4.5){
              Console.WriteLine("Felicidades, ganaste una beca");
              
          }
          }
           
     }  
     
         
           
    