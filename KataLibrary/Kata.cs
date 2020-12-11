// Your task is to make a function that can take any non-negative integer as an argument and 
// return it with its digits in descending order. Essentially, rearrange the digits to create 
// the highest possible number.

// Examples:
// Input: 42145 Output: 54421
// Input: 145263 Output: 654321
// Input: 123456789 Output: 987654321

using System;

public static class Kata
{
    private const int MinimalAllowedNumber = 0;

    public static int DescendingOrder(int inputNumber)
    {
        int output;

        // it was not explained in the task how to handle negative values so only choice I had was to throw an exception
        if (inputNumber < MinimalAllowedNumber)
            throw new Exception($"Input number must be higher than or equal to { MinimalAllowedNumber }.");

        var inputNumberAsCharArray = ConvertionHelper.IntToCharArray(inputNumber);
        SortingHelper.SortCharArrayDescending(inputNumberAsCharArray);
        output = ConvertionHelper.CharArrayToInt(inputNumberAsCharArray);

        return output;
    }
}