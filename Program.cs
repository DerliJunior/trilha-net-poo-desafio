using DesafioPOO.Models;

Nokia nokia = new("111234567","Pixel 8 Pro", "11223344", 8);
System.Console.WriteLine(nokia.Numero);

nokia.InstalarAplicativo("Facebook");

Iphone iphone = new("1234", "11999716735", "15 Pro", "22334444",6);

Console.WriteLine(iphone.Numero);

iphone.InstalarAplicativo("Facebook");
