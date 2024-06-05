/******************************************************************************

Autor:  Valeria Mosquera 
Fecha: 05-06-24
Descripcion:  El Rey León: 
    Las manadas de la Roca del Rey están compitiendo 
    por el control de las Tierras del Reino. 
    Pide al usuario la fuerza de al menos 5 
    clanes diferentes y usa estructuras "si" 
    para determinar clasificación de fuerza.
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      // variable
      int fuerza=0;
      // estructura loop
         for (int i = 0; i <= 4; i++) {
         Console.WriteLine("ingrese su fuerza "  + i + " luego presionar enter");
         fuerza = fuerza + Int32.Parse(Console.ReadLine());
         
         if (fuerza >= 22) {
             if (fuerza<=30){
         Console.WriteLine("Felicidades, eres un leon");
         }
         }
         if (fuerza >=32){
             if(fuerza<=40){
               Console.WriteLine("Felicidades eres una zebra");
         }
         }
         if (fuerza>=41){
            if (fuerza<=50){
             Console.WriteLine("Felicidades eres un jirafa");
            }   
         }
         if (fuerza<= 51){
            if (fuerza>=60){
             Console.WriteLine("Felicidades eres un rinoceronte");
         }
         }
         if (fuerza<=61){
             if(fuerza>=99){
             Console.WriteLine("Felicidades eres un elefante ");
         }
         }   
         
         }
           
 }
}