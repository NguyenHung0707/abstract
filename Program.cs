﻿public class Program { 
    static void Main(string[] args)
    {
        Circle c1 = new Circle(2.45, "Blue", 23);
        Console.WriteLine("Circle before change : " + c1.ToString());
        c1.PColor = "red";
        c1.PWeight = 2.56;

        Console.WriteLine("Circle after change : " + c1.ToString());
        Console.WriteLine(" Area of circle is :" + c1.findArea());
        Console.WriteLine("Perimeter of circle is :" + c1.findPerimeter());

        
    }
}