//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 > 0){
    Console.WriteLine("Число - нечётное");
} else {
    Console.WriteLine("Число - чётное");
}
