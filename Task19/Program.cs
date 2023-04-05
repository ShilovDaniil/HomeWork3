
void Main()
{
  System.Console.WriteLine("Введите пятизначное число: ");
  string input = System.Console.ReadLine();
  if(input.Length != 5)
  {
    System.Console.WriteLine("Это не пятизначное число!");
    return;
  }

  bool isPalindrome = true;
  for(int i = 0; i < input.Length/2; i++)
  {
    if(input[i] != input[input.Length - i - 1])
    {
      isPalindrome = false;
      break;
    }
  }
  if(isPalindrome)
  {
    System.Console.WriteLine("Это палиндром");
  
  }
  else
  {
    System.Console.WriteLine("Это не палиндром");
  }
}

Main();