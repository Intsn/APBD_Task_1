﻿static double CalculateAverage(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("Input array must not be null or empty.");
    }

    double sum = 0;
    foreach (int num in numbers)
    {
        sum += num;
    }

    return sum / numbers.Length;
}
static int FindMax(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("Input array must not be null or empty.");
    }

    int max = numbers[0]; // Initialize max with the first element

    foreach (int num in numbers)
    {
        if (num > max)
        {
            max = num;
        }
    }

    return max;
}