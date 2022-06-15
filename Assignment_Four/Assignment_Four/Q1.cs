using System;

// ---------------------------------------
// COMP 348
// Assignment 4
// Written By: Gabriel Dubois (40209252), Ali Fetanat (40158208), Gabriel D’Alesio(40208868), Liam Daigle(40207583)
// Due June 15, 2022
// ---------------------------------------
public interface Shape
{
    string Name
    {
        get;

    }
    double GetPerimeter();
    double GetArea();
}
public class Rectangle : Shape
{
    double width;
    double height;
    public Rectangle()
    {
        height = 0;
        width = 0;
    }
    public Rectangle(double w, double h)
    {
        width = w;
        height = h;
    }
    public double GetPerimeter()
    {
        return (2 * (width + height));
    }
    public double GetArea()
    {
        return width * height;
    }
    public string Name
    {
        set { }
        get { return this.GetType().Name; }
    }

    public override string ToString()
    {
        return Name + " Width:" + width + ", height: " + height;
    }
}
//Class declaration
public class Circle : Shape
{
    double radius;
    public Circle()
    {
        radius = 0;
    }
    public Circle(double r)
    {
        radius = r;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }
    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
    public String Name
    {
        set { }
        get { return this.GetType().Name; }
    }
    public override string ToString()
    {
        return this.Name + " Radius: " + radius;
    }
}
