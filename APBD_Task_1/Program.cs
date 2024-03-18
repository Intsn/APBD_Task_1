static double CalculateAverage(int[] numbers)
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