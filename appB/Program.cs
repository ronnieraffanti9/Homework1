//Homework1b
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int n = 800000; //using 800,000 for 4,5 aginst instructions because a single calculation was too short to show a difference
        Stopwatch timer = new Stopwatch();
        double[,] array1 = GenRandomNumbers(n,10000);//(length of aray, max number)
        double[,] array2 = GenRandomNumbers(n,1.57);//(length of aray, max number)
        double[,] array3 = GenRandomNumbers(n,5000);//(length of aray, max number)
        timer.Start();
        ManSquare(array1);
        timer.Stop();
        Console.WriteLine("Manual square");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
        timer.Restart();
        FuncSquare(array1);
        timer.Stop();
        Console.WriteLine("Function square");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
        timer.Restart();
        FuncSqrt(array1);
        timer.Stop();
        Console.WriteLine("Function square root");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
        timer.Restart();
        ManSin(array2);
        timer.Stop();
        Console.WriteLine("Manual Sin");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
        timer.Restart();
        FuncSin(array2);
        timer.Stop();
        Console.WriteLine("Function Sin");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
        timer.Restart();
        FuncCos(array2);
        timer.Stop();
        Console.WriteLine("Function Cos");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
        timer.Restart();
        ManExp(array3);
        timer.Stop();
        Console.WriteLine("Manual Exponent");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
        timer.Restart();
        FuncExp(array3);
        timer.Stop();
        Console.WriteLine("Function Exponent");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
        timer.Restart();
        FuncLog(array3);
        timer.Stop();
        Console.WriteLine("Function Log");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
    }
    private static void ManSquare(double[,] nums)
    {
        int count = nums.GetLength(0); //allows nums to scale automaticly with the passed in array
        int i;
        for(i=0; i<count; ++i){
            nums[i,1] = nums[i,0] * nums[i,0];
        }
    }
    private static void ManSin(double[,] nums)
    {
        int count = nums.GetLength(0); //allows nums to scale automaticly with the passed in array
        int i;
        for(i=0; i<count; ++i){
            nums[i,1] = nums[i,0] - (Math.Pow(nums[i,0], 3) / 6) + (Math.Pow(nums[i,0], 6) / 120);//calculation
        }
    }
    private static void ManExp(double[,] nums)
    {
        int count = nums.GetLength(0); //allows nums to scale automaticly with the passed in array
        int i;
        for(i=0; i<count; ++i){
            nums[i,1] = 1 + nums[i,0] + (Math.Pow(nums[i,0], 2) / 2) + (Math.Pow(nums[i,0], 3) / 6);//calculation
        }
    }
    private static void FuncSquare(double[,] nums)
    {
        int count = nums.GetLength(0); //allows nums to scale automaticly with the passed in array
        int i;
        for(i=0; i<count; ++i){
            nums[i,1] = Math.Pow(nums[i,0],2);//calculation
        }
    }
    private static void FuncSqrt(double[,] nums)
    {
        int count = nums.GetLength(0); //allows nums to scale automaticly with the passed in array
        int i;
        for(i=0; i<count; ++i){
            nums[i,1] = Math.Sqrt(nums[i,0]);//calculation
        }
    }
    private static void FuncSin(double[,] nums)
    {
        int count = nums.GetLength(0); //allows nums to scale automaticly with the passed in array
        int i;
        for(i=0; i<count; ++i){
            nums[i,1] = Math.Sin(nums[i,0]);//calculation
        }
    }
    private static void FuncCos(double[,] nums)
    {
        int count = nums.GetLength(0); //allows nums to scale automaticly with the passed in array
        int i;
        for(i=0; i<count; ++i){
            nums[i,1] = Math.Cos(nums[i,0]);//calculation
        }
    }
    private static void FuncExp(double[,] nums)
    {
        int count = nums.GetLength(0); //allows nums to scale automaticly with the passed in array
        int i;
        for(i=0; i<count; ++i){
            nums[i,1] = Math.Exp(nums[i,0]);//calculation
        }
    }
    private static void FuncLog(double[,] nums)
    {
        int count = nums.GetLength(0); //allows nums to scale automaticly with the passed in array
        int i;
        for(i=0; i<count; ++i){
            nums[i,1] = Math.Log(nums[i,0]);//calculation
        }
    }
    static double[,] GenRandomNumbers(int count, double max) //int max allows max to be changed for each of the tests
    {
        Random rand = new Random(); // instantiate random number generator
        double[,] num = new double[count,2]; // make array
        for(int i=0; i<count; ++i){
            num[i,0] = max*rand.NextDouble(); // fill in elements of array
        }
        return num; // returns reference to array
    }
}