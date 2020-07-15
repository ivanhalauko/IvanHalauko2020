using System;

namespace Task1_1ClassLibrary
{
	class DataForTheGraph
	{
		public string QuantityOfParam { get; set; }
		public double ElapsedTimeSteinsAlgorithm { get; set; }
		public double ElapsedTimeEuclideanAlgorithm { get; set; }

		public DataForTheGraph()
		{
		}
		public DataForTheGraph(string quantityOfParam, double elapsedTimeSteinsAlgorithm, double elapsedTimeEuclideanAlgorithm)
		{
			QuantityOfParam = quantityOfParam;
			ElapsedTimeSteinsAlgorithm = elapsedTimeSteinsAlgorithm;
			ElapsedTimeEuclideanAlgorithm = elapsedTimeEuclideanAlgorithm;
		}
	}
}
