Console.OutputEncoding = System.Text.Encoding.UTF8;

string [] arrayCharsAndDigits = new string [new Random().Next(5,20)]; 

string [] FillArray (string[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        char[] CharsArray = new char[new Random().Next(5,15)];
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
        string size = array[i];
        string onlyChar = string.Empty;
        for (int k = 0; k < size.Length; k++)
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

DeleteDig(arrayCharsAndDigits);

void PrintArray(string[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
PrintArray(arrayCharsAndDigits);
