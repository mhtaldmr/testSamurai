using TestSamurai.Fundementals;

Console.WriteLine("Hello, World!");

while (true)
{

var result = new DemeritPointsCalculator();

var input = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(result.CalculateDemeritPoints(input));
}