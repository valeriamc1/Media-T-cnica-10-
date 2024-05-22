     /******************************************************************************
      Autor:  VALERIA MOSQUERA
     lenguaje usado: C#
     Fecha de creación: 2024-05-22
     Descripción: programa con desiciones para determinar el sexo de un
     usuario
     
     *******************************************************************************/
     using System;
     class HelloWorld {
     static void Main() {
     // variable
     bool sexoMasculino;
     //capturar informacion del usuario 
     Console.Write("Digite true si es hombre");
     sexoMasculino = Convert.ToBoolean (Console.ReadLine());
     // validación
     if (sexoMasculino == true){ 
     Console.WriteLine("felicidades, es hombre"); 
     } 
     else{
     Console.WriteLine("felicidades, es mujer");
     }
     
     Console.WriteLine("Finalizada la ejecucion");
     
      }
     }
