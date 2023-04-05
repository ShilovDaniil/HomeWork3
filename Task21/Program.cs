﻿/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние

между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

int Read(string argument)
{
  int number;
  System.Console.WriteLine($"Input {argument}: ");
  while (!int.TryParse(System.Console.ReadLine(), out number))
  {
    System.Console.WriteLine("Is not a number!");
  }
  return number;
}

double Length()
{
  int x1 = Read("x1");
  int y1 = Read("y1");
  int z1 = Read("z1");
  int x2 = Read("x2");
  int y2 = Read("y2");
  int z2 = Read("z2");
  double length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
  return length;
}

void Answer()
{
  double L = Length();
  System.Console.WriteLine($"Segment length = {L}");
}

Answer();