// Task: Create a function(let's say SortCoordinates) to sort the coordinates according to top left and bottom right.
// Sort the coordinates in the Y axis, highest Y value should come first and rest should follow it, basically sort in desceding order.            

// problem Link: https://dotnetfiddle.net/CNZzCS

using System;
using System.Text.Json;
using System.IO;

public class Program
{
	public static void Main()
	{
		// Generate Points
		// https://www.i-pathways.org/public/sampleLesson/math/images/graph2.png
		var points = GeneratePoints();
		
		Point[] f = new[]
                    {
                      new Point() { X = -4, Y = 0},
                      new Point() { X = -3, Y = 4},
                      new Point() { X = 0, Y = -5},
                      new Point() { X = 4, Y = 2},
                    };
                    
    // Sort the coordinates in the Y axis, highest Y value should come first and rest should follow it, basically sort in desceding order.               
		points = SortCoordinates(points);
		
		// Print Points
		PrintPoints(points);
	}
	
	public static Point[] SortCoordinates(Point[] points)
  	{
		 // We can use: IComparer<Point> as well in place of this.
		 Array.Sort(points, (a, b) =>
		 {
		     if (a.Y == b.Y)
		     {
			return Convert.ToInt32(a.X) - Convert.ToInt32(b.X);
		     }

		     return Convert.ToInt32(b.Y) - Convert.ToInt32(a.Y);
		 });

	   	return points;
  	}
	
	public static Point[] GeneratePoints()
	{
		var points = new Bogus.Faker<Point>()
			.RuleFor(pt => pt.X, pt => Math.Round(pt.Random.Double(-20, 20), 2))
			.RuleFor(pt => pt.Y, pt => Math.Round(pt.Random.Double(-20, 20), 2))
			.Generate(100)
			.ToArray();
		
		return points;
	}
	
	public static void PrintPoints(Point[] points)
	{
		foreach (var point in points)
		{
			Console.WriteLine(point);
		}
	}
}

public class Point
{
	public double X { get; set; }
	public double Y { get; set; }
	
	public override string ToString()
	{
		return $"X: {X}, Y: {Y}";
	}
}
