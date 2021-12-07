using System;
using System.Threading.Tasks;
using System.Linq;

class Program 
{
	public static async Task Main (string[] args) 
  	{
		//как ускорить получение результата?
    	var objects = Enumerable.Range(0, 100);
		var sum = 0;
		foreach (var obj in objects)
		{
			sum += await ProcessAsync(obj);
		}
		Console.WriteLine($"Sum is {sum}");
  	}

	private static async Task<int> ProcessAsync(int i)
	{		
		Console.WriteLine($"Processing {i}");
		await Task.Delay(TimeSpan.FromSeconds(5));
		return i * 5;
	}
}