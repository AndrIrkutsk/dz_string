// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// string strPalindrom = "шалаш";
// string strPalindrom = "55655";
string strPalindrom = "PaLiNDRomOrdNIlAP";

bool CheckPalindrom(string palindrom)
{
  string copyPalindrom = palindrom.ToLower();
  bool check = true;

  for (int i = 0; i < copyPalindrom.Length / 2; i++)
  {
    if(copyPalindrom[i] != copyPalindrom[copyPalindrom.Length - 1 - i])
    {
      check = false;
    }
  }

  return check;
}

void PrintPalindrom(bool check, string strPalindrom)
{
  if(check)
    Console.WriteLine($"строка {strPalindrom} является палиндромом.");
  else 
    Console.WriteLine($"строка {strPalindrom} не является палиндромом."); 
}

bool checkPalindrom = CheckPalindrom(strPalindrom);
PrintPalindrom(checkPalindrom, strPalindrom);
