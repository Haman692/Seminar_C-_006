// //Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Random rand = new Random();

int numberA = rand.Next(1, 10);
int numberB = rand.Next(1, 10);
int numberC = rand.Next(1, 10);
System.Console.WriteLine($"{numberA},{numberB}, {numberC}");

bool Tringl =  false;

if(numberA > numberB && numberA > numberC && numberA < numberB + numberC)
    Tringl = true;
if(numberB > numberA && numberB > numberC && numberB < numberA + numberC)
    Tringl = true;
if(numberC > numberB && numberC > numberA && numberC < numberB + numberA)
    Tringl = true;

if(Tringl)
    System.Console.WriteLine($"Треугольник со сторонами {numberA}, {numberB}, {numberC} может быть");
else
    System.Console.WriteLine($"Треугольник со сторонами {numberA}, {numberB}, {numberC} не может быть");
