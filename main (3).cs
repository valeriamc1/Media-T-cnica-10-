/******************************************************************************
Autor:          Valeria Mosquera 
Fecha:          10-07-2024
Descripcion:    Mi primer vector

*******************************************************************************/
using System;
class MiSegundoVector {
  static void Main() {
      
    // declaracion
    string[] nombres = new string[3];
    
     // asignacion de un vector dinamico
    for (int i = 0; i <= 2; i++){
    nombres[i] = Console.ReadLine();
    }
    
    /* imprimir un dato del vector de manera dinamica
     recorrer imprimiendo vector*/
     for (int i = 0; i <= 2; i++){
     Console.WriteLine(nombres[i]);
    }
  }
}