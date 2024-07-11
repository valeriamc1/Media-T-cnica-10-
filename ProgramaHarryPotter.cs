/*
Autor: Valeria Mosquera
Fecha: 11/07/2024
Descripcion: Harry Potter necesita un programa 
en C# para listar sus hechizos. 
Completa el espacio en blanco 
para mostrar los nombres de los 
hechizos en la consola:
*/
 
using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        
Console.WriteLine("MMMMMMMMMMMMMMWMMMMMMMMWMMMMMMMMMMMMMMMM");
Console.WriteLine("MMMMMMMMWWXOkkkkxkkxxkkdOWWMMMMMMMMMMMMM");
Console.WriteLine("MMMMMMMMMWOldOOOOOOOkOklkWMMMMMMMMMMMMMM");
Console.WriteLine("MMMMMMMMMM0lkXXXK000OOodNMMMMMMMMMMMMMMM");
Console.WriteLine("MMMMMMMMMM0lxXXK00000xoKMMMWWWWMMMMMMMMM");
Console.WriteLine("MMMMMMMMMMKoxKK0000kolkNWWWWWMMMMMMMMMMM");
Console.WriteLine("MMMMMMMMMMXodK00000xlodxxkkdxXMMMMMMMMMM");
Console.WriteLine("MMMMMMMMMMXodK0O0000K00000klkWMMMMMMMMMM");
Console.WriteLine("MMMMMMMMMMNolkkkkkk000000klkNMMMMMMMMMMM");
Console.WriteLine("MMMMMMMMMMW0xkkkkllO0000xlkNMMMMMMMMMMMM");
Console.WriteLine("MMMMMMMMMMMMWWMMXoo0O00xlOWWMWWMMMMMMMMM");
Console.WriteLine("MMMMMMMMMMMWMMMMOlk0O0xlOWMWWMWWMMMMMMMM");
Console.WriteLine("MMMMMMMMMMMMMMMWxo00Odo0WMMMMMMMMMMMMMMM");
Console.WriteLine("MMMMMMMMMMMMMWMKlx0d:oKWMMMMMMMMMMMMMMMM");
Console.WriteLine("MMMMMMMMMMMMMMWklOdokKMMMMMMMMMMMMMMMMMM");
Console.WriteLine("MMMMMMMMMMMMMMXdoooXMMWMMMMMMMMMMMMMMMMM");
Console.WriteLine("MMMMMMMMMMMMMMOccdXWWWMMMMMMMMMMMMMMMMMM");
Console.WriteLine("MMMMMMMMMMMMMWx:xNMMMMMMMMMMMMMMMMMMMMMM");
Console.WriteLine("MMMMMMMMMMMMWWXKWMMWWMMMMMMMMMMMMMMMMMMM");
Console.WriteLine("MMMMMMMMMMMMWWMMMMWMMMMMMMMMMMMMMMMMMMMM");
     Thread.Sleep(3000);
        Console.Clear();
        string[] hechizos = { "Expecto Patronum", "Wingardium Leviosa", "Expelliarmus" };
        
        for (int i = 0; i <= 2; i++) 
    Console.WriteLine(hechizos[i]);
       
    
        
    }
}