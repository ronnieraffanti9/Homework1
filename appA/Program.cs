//Homework1a
using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int n = 200000000;
        double[,] doubles;
        Stopwatch timer = new Stopwatch();
        doubles = GenRandomNumbers(n);
        //cast double array onto floats array
        float[,] floats = new float[doubles.GetLength(0), doubles.GetLength(1)];
        for (int i = 0; i < doubles.GetLength(0); i++){
            for (int j = 0; j < doubles.GetLength(1); j++){
                floats[i, j] = (float)doubles[i, j];
            }
        }
        timer.Start();
        AddDouble(doubles,n);
        timer.Stop();
        Console.WriteLine("Doubles");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
        timer.Restart();
        AddFloat(floats,n);
        timer.Stop();
        Console.WriteLine("Floats");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
    }

    private static void AddFloat(float[,] nums, int count)
    {
        int i;
        for(i=0; i<count; ++i){
            nums[i,2] = nums[i,0] + nums[i,1];
        }
    }

    private static void AddDouble(double[,] nums, int count)
    {
        int i;
        for(i=0; i<count; ++i){
            nums[i,2] = nums[i,0] + nums[i,1];
        }
    }
    static double[,] GenRandomNumbers(int count)
    {
        Random rand = new Random(); // instantiate random number generator
        double[,] num = new double[count,3]; // make array
        for(int i=0; i<count; ++i){
            num[i,0] = 10000.0*rand.NextDouble(); // fill in elements of array
            num[i,1] = 10000.0*rand.NextDouble();
        }
        return num; // returns reference to array
    }
}