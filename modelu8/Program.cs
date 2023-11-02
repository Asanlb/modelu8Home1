using System;

public class SquaredArray
{
    private double[] array;

    public SquaredArray(int size)
    {
        array = new double[size];
    }

    public double this[int index]
    {
        get
        {
            if (IsIndexValid(index))
            {
                return array[index];
            }
            throw new IndexOutOfRangeException("Индекс вне диапазона.");
        }
        set
        {
            if (IsIndexValid(index))
            {
                array[index] = value * value; 
            }
            else
            {
                throw new IndexOutOfRangeException("Индекс вне диапазона.");
            }
        }
    }

    private bool IsIndexValid(int index)
    {
        return index >= 0 && index < array.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        SquaredArray array = new SquaredArray(5);
        array[0] = 2; 
        array[1] = 3; 
        array[2] = 4; 

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"array[{i}] = {array[i]}");
        }
    }
}
