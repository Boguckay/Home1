﻿// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
//Console.Write("Введи трёхзначное число: ");
//int Number = Convert.ToInt32(Console.ReadLine());
//int num = (Number / 10);
//Console.WriteLine($"остаток {num % 10}");



//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
//Console.Write("Введи число: ");
//int anyNumber = Convert.ToInt32(Console.ReadLine());
//string anyNumberText = Convert.ToString(anyNumber);
//if (anyNumberText.Length > 2){
 // Console.WriteLine("третья цифра -> " + anyNumberText[2]);
//}
//else {
 // Console.WriteLine("-> третьей цифры нет");
//}


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это не день недели");
  }
  else Console.WriteLine("(не выходной) -> нет");
}
CheckingTheDayOfTheWeek(dayNumber);



