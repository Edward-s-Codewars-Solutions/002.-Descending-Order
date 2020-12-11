using System;

public static class SortingHelper
{
    public static void SortCharArrayAscending(char[] inputCharArray)
    {
        Array.Sort(inputCharArray);
    }

    public static void SortCharArrayDescending(char[] inputCharArray)
    {
        SortCharArrayAscending(inputCharArray);
        Array.Reverse(inputCharArray);
    }
}