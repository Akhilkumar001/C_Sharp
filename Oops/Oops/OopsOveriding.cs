using System;
class Shape

{
    public  string ShapeName { get; set; }

public void GetShape()
    {
        Console.WriteLine("Enter Your Shape Name : ");
      
        this.ShapeName =Console.ReadLine();
    }

    public virtual double ComputeArea( )
    {
        Console.WriteLine($"Compute Area of Your {this.ShapeName} \n");
        return 1;
    }
}

class Rectangle : Shape
{
    public double Length { get; set; }
    public double Breadth { get; set; }
    public override double  ComputeArea()
    {
    
        Console.WriteLine("Enter Radius of Circle : ");
        this.Length = Convert.ToDouble(Console.ReadLine());
        this.Breadth = Convert.ToDouble(Console.ReadLine());

        return Length*Breadth;
    }


}
class Circle:Shape
{
    public double Radius { get; set; }
    public double Breadth { get; set; }
    public override double ComputeArea()
    {
       
        base.ComputeArea();
        Console.WriteLine("Enter Radius of Circle : ");
        this.Radius=Convert.ToDouble(Console.ReadLine());
   
        return Math.PI*(Radius*Radius);
    }

    public static void Main(string[] args)
    {
        Shape c = new Circle();
        c.GetShape();
        Console.WriteLine($"Area of Circle  :{Math.Round(c.ComputeArea(),2)}");
        Shape r = new Rectangle();
        r.GetShape();
        Console.WriteLine($"\nArea of Rectangle  :{r.ComputeArea()}");
    }


}


