using System.Diagnostics;

namespace RandomDataGeneratorLibrary;

public class RandomDataGenerator
{
    private static readonly Random random = new Random();


    public static int GenerateRandomNumber(int min = 0, int max = 100)
    {
        return random.Next(min, max);
    }

    public static double GenerateRandomDouble(double min = 0, double max = 100)
    {
        return min + random.NextDouble() * (max - min);
    }

    public static bool GenerateRandomBoolean()
    {
        return random.Next(2) == 0;
    }

    public static string GenerateRandomString(int length)
    {
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        string randomString = string.Empty;

        for (int i = 0; i < length; i++)
        {
            randomString += chars[random.Next(chars.Length)];
        }

        return randomString;
    }
    public static string GenerateRandomString()
    {
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        string randomString = string.Empty;

        for (int i = 0; i < GenerateRandomNumber(); i++)
        {
            randomString += chars[random.Next(chars.Length)];
        }

        return randomString;
    }

    public static void FillingListRandomly(List<int> list, int numberRepetitions, int min = 0, int max = 100)
    {

        for (int i = 0; i < numberRepetitions; i++)
        {
            list.Add(GenerateRandomNumber(min, max));
        }
        return;
    }
    public static void FillingListRandomly(List<double> list, int numberRepetitions, double min = 0, double max = 100)
    {

        for (int i = 0; i < numberRepetitions; i++)
        {
            list.Add(GenerateRandomDouble(min, max));
        }
        return;
    }

    public static void FillingListRandomly(List<bool> list, int numberRepetitions)
    {

        for (int i = 0; i < numberRepetitions; i++)
        {
            list.Add(GenerateRandomBoolean());
        }
        return;
    }
    public static void FillingListRandomly(List<string> list, int numberRepetitions, int length)
    {

        for (int i = 0; i < numberRepetitions; i++)
        {
            list.Add(GenerateRandomString(length));
        }
        return;
    }
    public static void FillingListRandomly(List<string> list, int numberRepetitions)
    {

        for (int i = 0; i < numberRepetitions; i++)
        {
            list.Add(GenerateRandomString());
        }
        return;
    }


}