namespace OOPCircle
{           //Timofey Suvorov, NET2024
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculate a circle with radius 5
            Console.WriteLine("Manipulating things with a circle with a radius of 5 cm:");
            Circle circle1 = new Circle(5);
            Console.WriteLine($"The area is: {circle1.GetArea().ToString("F2")} cm2");
            Console.WriteLine($"The perimeter is: {circle1.GetPerimeter().ToString("F2")} cm");
            Console.WriteLine($"The volume is: {circle1.GetVolume().ToString("F2")} cm3");

            Console.WriteLine("\nManipulating things with a circle with a radius of 6 cm:");
            Circle circle2 = new Circle(6);
            Console.WriteLine($"The area is: {circle2.GetArea().ToString("F2")} cm2");
            Console.WriteLine($"The perimeter is: {circle2.GetPerimeter().ToString("F2")} cm");
            Console.WriteLine($"The volume is: {circle2.GetVolume().ToString("F2")} cm3");


            Triangle triangle1 = new Triangle(2,5,19);
            Console.WriteLine("\n\nManipulating things with a triangle of size 2 cm, 5 cm, 19 cm:");
            Console.WriteLine($"The perimeter is: {triangle1.GetPerimeter().ToString("F0")} cm");
            Triangle triangle2 = new Triangle(2, 5);
            Console.WriteLine($"The area is: {triangle2.GetArea().ToString("F2")} cm");


        }
    }
}
