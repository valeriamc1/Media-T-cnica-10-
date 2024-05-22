     /******************************************************************************
      Autor:  VALERIA MOSQUERA
     lenguaje usado: C#
     Fecha de creación: 2024-05-22
     Descripción:Tony stark, Iron man. quiere saber cuanto dinero debe tener 
     para comprar X tornillos c/u a 300$, pero en la tienda le dan descuentos 
     segun la cantidad comprada.
     crear un algoritmo que ayude a calcular si compra:
     1 sin descuento 
     5 descuento dl 30%
     10 descuento del 50%
     *******************************************************************************/
     using System;
     class HelloWorld {
     static void Main() {
         
          //variables
         int cantidadTornillos;
         int valorTornillos;
         
           //peticion de datos
           Console.WriteLine("ingrese la cantidad de tornillos");
           cantidadTornillos= Int32.Parse(Console.ReadLine());
           valorTornillos= 300;
           //validacion
           
         if (cantidadTornillos >= 5){
               Console.WriteLine("el valor del tornillo es "+ (valorTornillos * 0.70));
             }
            
            //peticion de datos
           Console.WriteLine("ingrese la cantidad de tornillos");
           cantidadTornillos= Int32.Parse(Console.ReadLine());
           valorTornillos= 300;
           //validacion
           
         if (cantidadTornillos >= 10){
               Console.WriteLine("el valor del tornillo es "+ (valorTornillos * 0.50)); 
               Console.WriteLine("el valor del tornillo es "+ (valorTornillos * 0.50*cantidadTornillos));
         }
               
           
          }
     }
    
