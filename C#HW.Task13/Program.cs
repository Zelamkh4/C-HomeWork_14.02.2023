//Напишите программу, 
//которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет


// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Enter number: ");

int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);

if (anyNumberText.Length > 2){
  Console.WriteLine("third num -> " + anyNumberText[2]);
}

else {

  Console.WriteLine("-> no third num");
}
