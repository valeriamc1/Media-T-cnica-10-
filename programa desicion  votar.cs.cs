     /******************************************************************************
      Autor:  VALERIA MOSQUERA
     lenguaje usado: C#
     Fecha de creación: 2024-05-22
     Descripción: programa con desiciones para 
     habilitar votacion de personas y descuento
     matricula estudio
     *******************************************************************************/
     using System;
     class HelloWorld {
     static void Main() {
         
          //variables
         int edad;
         int valorMatricula;
         
           //peticion de datos
           Console.WriteLine("digite su edad");
           edad= Int32.Parse(Console.ReadLine());
           
           Console.WriteLine("digite su valor de matricula");
           valorMatricula= Int32.Parse(Console.ReadLine());
           
           //validacion 
           if ( edad >= 18){
               Console.WriteLine("felicidades, usted puede votar");
               Console.WriteLine(("usted pagara de matricula" + valorMatricula * 0.85));
               
           }
          }
         }
