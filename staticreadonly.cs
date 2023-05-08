using System;
class maths{
    public static readonly double pi;
    public static readonly double E;

    static maths(){
        pi=3.141592653589793;
        E=2.7182881828459045;
    }

    public static double CalculateCircleArea(double radius){
        return pi * radius * radius;
    }
    public static double CalculateExponential(double power){
        return Math.Pow(E,power);
    }


}

class exampl{
    static void Main(){
        double circleArea= maths.CalculateCircleArea(5.0);
        double exponential = maths.CalculateExponential(2.0);
        Console.WriteLine("circle area: {0:F2}", circleArea);
        Console.WriteLine("exponential {0:F2}",exponential);
    }
}