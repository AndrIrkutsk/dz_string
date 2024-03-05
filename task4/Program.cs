// Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, 
// в которой слова расположены в обратном порядке. В полученной строке слова 
// должны быть также разделены пробелами.

string strLong = "How much is the fish?";
string strReverse = "";
string[] strSplit = strLong.Split(' ');

for (int i = 0; i < strSplit.Length; i++)
{
  strReverse += strSplit[strSplit.Length - 1 - i] + " ";
}

Console.WriteLine(strReverse);


