using System;
class pie{
    const double pi = 3.14159265;
    static void notMain(){
        double radius = 5.0;
        double area = pi * radius* radius;
        Console.WriteLine("area of circle with radius: {1:F2}",radius,area);
    }
}