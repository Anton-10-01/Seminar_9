/* Задача 67: Напишите программу, которая принимает два числа
А и В, и возводит число А в целую степень В с помощью рекурсии.
А = 3; В = 5 -> 243 (3^5)
А = 2; В = 3 -> 8
*/

Console.Write("Введите натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A = {number1}; B = {number2} -> {PowDigits(number1, number2)}");

int PowDigits(int num1, int num2) {
    if (num2 == 0) return 1;
    return num1* PowDigits(num1, num2 - 1);
}