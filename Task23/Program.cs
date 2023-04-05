/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int Read()
{
  int number;
  System.Console.WriteLine("Введите число: ");
  while(!int.TryParse(System.Console.ReadLine(), out number))
  {
    System.Console.WriteLine("Это не число");
  }
  return number;
}

int cube(int number)
{
  for(int i = 1; i <= number; i++)
  {
    System.Console.Write(Math.Pow(i, 3) + " ");
  }
  return number;
}

void Output()
{
  int number = Read();
  int a = cube(number);
}

Output();
