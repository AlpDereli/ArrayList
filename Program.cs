// See https://aka.ms/new-console-template for more information
using System.Collections;
ArrayList Liste = new ArrayList();
//Liste.Add("Ayse");
//Liste.Add(2); 
//Liste.Add(true);
//Console.WriteLine(Liste[1]);
//foreach(var obj in Liste)
//{
//    Console.WriteLine(obj);
//}
//string[] renk = {"kirmizi", "mavi", "sari"};
List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};
//Liste.AddRange(renk);
Liste.AddRange(sayilar);
foreach(var i in Liste)
{
    Console.WriteLine(i);
}
Liste.Sort();
foreach(var i in Liste)
{
    Console.WriteLine(i);
}
Console.WriteLine(Liste.BinarySearch(9));
Liste.Reverse();
foreach(var i in Liste)
{
    Console.WriteLine(i);
}
Liste.Clear();
foreach(var i in Liste)
{
    Console.WriteLine(i);
}
Console.WriteLine("Liste bos");