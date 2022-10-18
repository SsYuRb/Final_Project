

string [] arrayCharsAndDigits = new string [new Random().Next(5,20)]; 

void FillArray (string[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        char[] CharsArray = new char[new Random().Next(5,15)];
        for (int k = 0; k < CharsArray.Length; k++)
        {
            CharsArray[i] = Convert.ToChar(new Random().Next(33, 123));
        }
        string someString = new string (CharsArray);
        array[i] = someString;
    }
}
Console.WriteLine(FillArray(arrayCharsAndDigits[5]));