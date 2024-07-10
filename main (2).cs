/******************************************************************************

Autor:          Valeria Mosquera 
Fecha:          10-07-2024
DescripciC3n:    Mi primer vector


*******************************************************************************/
using System;
class MiPrimerVector {
  static void Main() {
      
    // declaracion y asignacion de un vector
    string[] nombres = {"julian", "efrain", "la maria"};
    
    //imprimir un dato del vector de manera directa 
    Console.WriteLine(nombres[0]);
    
     /*imprimir un dato del vector de manera dinamica 
       recorrer imprimiendo el vector */
    for (int i = 0; i <= 2; i++) 
    Console.WriteLine(nombres[i]);
  }
}
