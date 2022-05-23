using System;

namespace ConsoleApp
{
	class Program
	{
		 static void Main(string[] args)
		{
			Rectangle rect1 = new Rectangle { Width = 7, Height = 3 };
			Rectangle rect2 = new Rectangle { Width = 7, Height = 3 };
			Rectangle rect3 = new Rectangle { Width = 7, Height = 3 };
			var rectArr = new Rectangle[] { rect1, rect2, rect3};
			var areaCalculator = new AreaCalculator();
			var result = areaCalculator.TotalArea(rectArr);
			Console.WriteLine($"Rectangle's area: {result}");

			Circle c1 = new Circle { Radius = 4 };
			Circle c2 = new Circle { Radius = 5 };
			Circle c3 = new Circle { Radius = 7 };

			var cArr = new Circle[] { c1, c2, c3 };
			var res = areaCalculator.TotalArea(cArr);
			Console.WriteLine($"Circle's area: {res}");
			Console.ReadKey();
		}

	}

	public class Rectangle: Shape
	{
		public double Height { get; set; } 
		public double Width { get; set; }
		public double Area()
		{
			double area = Height * Width;
			return area;
		}
	}

	public class Circle: Shape
	{
		public double Radius { get; set; }
		public double Area()
		{
			return Radius * Radius * Math.PI;
		}
	}

	// this interface explain: open for the extension
	public interface Shape
	{
		public double Area();
	} 

	public class AreaCalculator
	{
		// this method: closed for modification and open for extension (create interface Shape)
		public double TotalArea(Shape[] shapes) 
		{
			double area = 0;
			foreach (var s in shapes)
			{
				area += s.Area();
			}
			return area;
		}
	}
}
