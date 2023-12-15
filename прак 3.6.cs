using System;
using System.Collections.Generic;
using System.Linq;

class RandomNumberGenerator
{
private List randomNumbers;
private double? cachedMean;
private double? cachedVariance;
private double? cachedStandardDeviation;
private double? cachedMedian;

public RandomNumberGenerator(int length)
{
randomNumbers = new List();
Random random = new Random();
for (int i = 0; i < length; i++)
{
randomNumbers.Add(random.NextDouble());
}
}

public double Mean()
{
if (cachedMean == null)
{
cachedMean = randomNumbers.Average();
}
return cachedMean.Value;
}

public double Variance()
{
if (cachedVariance == null)
{
double mean = Mean();
cachedVariance = randomNumbers.Select(x => Math.Pow(x - mean, 2)).Average();
}
return cachedVariance.Value;
}

public double StandardDeviation()
{
if (cachedStandardDeviation == null)
{
cachedStandardDeviation = Math.Sqrt(Variance());
}
return cachedStandardDeviation.Value;
}

public double Median()
{
if (cachedMedian == null)
{
var sortedNumbers = randomNumbers.OrderBy(x => x).ToList();
int count = sortedNumbers.Count;
if (count % 2 == 0)
{
cachedMedian = (sortedNumbers[count / 2 - 1] + sortedNumbers[count / 2]) / 2.0;
}
else
{
cachedMedian = sortedNumbers[count / 2];
}
}
return cachedMedian.Value;
}
}

class Program
{
static void Main()
{
RandomNumberGenerator generator = new RandomNumberGenerator(1000);
Console.WriteLine("Mean: " + generator.Mean());
Console.WriteLine("Variance: " + generator.Variance());
Console.WriteLine("Standard Deviation: " + generator.StandardDeviation());
Console.WriteLine("Median: " + generator.Median());
}
}