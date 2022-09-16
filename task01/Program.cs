// Задача: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
//a = 5; b = 7 -> max = 7
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if(num1 > num2){
    Console.WriteLine($"число {num1} больше чем число {num2}");
} else if (num2 > num1){
    Console.WriteLine($"число {num2} больше чем число {num1}");
}else if (num1 == num2){
    Console.WriteLine("числа равны");
}else {
    Console.WriteLine("Неправильный ввод");
}