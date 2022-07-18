Console.Write("Введите первое число ");
int numOne = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int numTwo = int.Parse(Console.ReadLine());
Console.Write("Введите третье число ");
int numThree = int.Parse(Console.ReadLine());
int max = 0;
if (numOne > max) {
    max = numOne;
} if (numTwo > max) {
    max = numTwo;
} if (numThree > max) {
    max = numThree;
}
Console.Write("Максимальное число = " + max);