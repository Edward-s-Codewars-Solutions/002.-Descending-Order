using System;

public static class ConvertionHelper
{
    public static char[] IntToCharArray(int inputInt)
    {
        char[] output;

        var inputConvertedToString = inputInt.ToString();
        output = inputConvertedToString.ToCharArray();

        return output;
    }

    public static int CharArrayToInt(char[] inputCharArray)
    {
        int output;

        var inputConvertedToString = string.Concat(inputCharArray);
        var parsingResult = int.TryParse(inputConvertedToString, out output);

        if (parsingResult == false)
            throw new Exception("Convertion from char[] to int failed.");

        return output;
    }
}