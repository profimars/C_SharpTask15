//Задача 15
//Напишите програамму, которая принимает на вход цифру, обозначающую день недели,  
//и проверяет является ли этот день выходным
//6 -> да
//7 -> да
//1 -> нет
//https://github.com/profimars/C_SharpTask15
Console.WriteLine("Ведите целое положительное число от 1 до 7");
int q = Convert.ToInt32(Console.ReadLine());
if (q >= 1 && q <= 7)
{
    if (q == 6 || q == 7)
        Console.WriteLine("да");
    else
        Console.WriteLine("нет");
}
else
{
    Console.WriteLine("Вы ввели неправильное число");
}
