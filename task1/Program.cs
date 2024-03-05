// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

char[,] arrayChar = { 
  { 'a', 'b', 'c', 'd', 'e', 'f', 'g' },
  { 'h', 'i', 'j', 'k', 'm', 'l', 'n' }
};

string strChar = "";

for (int i = 0; i < arrayChar.GetLength(0); i++)
{
  for (int j = 0; j < arrayChar.GetLength(1); j++)
  {
    strChar += arrayChar[i, j];
  }
}

Console.WriteLine(strChar);

