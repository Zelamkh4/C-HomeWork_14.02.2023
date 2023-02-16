//Напишите программу, 
//которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет


// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Enter number: ");

int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberTest = Convert.ToString(anyNumber);

if (anyNumberTest.Length > 2){
  Console.WriteLine("third num -> " + anyNumberTest[2]);
}

else {

  Console.WriteLine("-> no third num");
}
