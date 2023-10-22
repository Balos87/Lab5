namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var circle1 = new Circle(5);
            var circle2 = new Circle(6);

            double area1 = circle1.GetArea();
            double area2 = circle2.GetArea();

            Console.WriteLine($"Arean på cirkel 1 med radie 5 är = {area1}");
            Console.WriteLine($"Arean på cirkel 2 med radie 6 = {area2}");
        }
    }
}