
string [] arrayCharsAndDigits = new string [new Random().Next(5,20)]; 

string [] FillArray (string [] array) 
{
    for (int i = 0; i < array.Length; i ++)
    {
        char [] CharsArray = new char [new Random().Next(5,15)];
        for (int k = 0; k < CharsArray.Length; k++)
        {
            CharsArray[k] = Convert.ToChar(new Random().Next(33, 123));
        }
        string someString = new string (CharsArray);
        array[i] = someString;
    }
    return array;
}
FillArray(arrayCharsAndDigits);

string [] DeleteDig (string[] array)
{
    string [] onlyChars = new string [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        string onlyChar = string.Empty;
        for (int k = 0; k < array[i].Length; k++)
        {
            if ((Convert.ToInt32(array[i][k]) < 48) || (Convert.ToInt32(array[i][k]) > 57))
            {
                onlyChar += array[i][k];
            }
        }
        onlyChars[i] = onlyChar;
    }
    return onlyChars;
}

void PrintArray(string[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
PrintArray(arrayCharsAndDigits);

string [] arrayOnlyChars = DeleteDig(arrayCharsAndDigits);
Console.WriteLine();
PrintArray (arrayOnlyChars);