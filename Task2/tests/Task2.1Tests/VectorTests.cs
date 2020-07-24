using NUnit.Framework;

namespace Task201.Tests
{
	/// <summary>
	/// Public class for testing Vector class.
	/// </summary>
	[TestFixture()]
	public class VectorTests
	{
		/// <summary>
		/// Test cases for testing operator vector "+" whith positive numbers.  
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>
		/// <param name="vectorExpectedX">Test parameter "X" expected vector</param>
		/// <param name="vectorExpectedY">Test parameter "Y" expected vector</param>
		/// <param name="vectorExpectedZ">Test parameter "Z" expected vector</param>
		[TestCase(10, 10, 10, 1, 1, 1, 11, 11, 11)]
		[TestCase(5, 5, 5, 1, 1, 1, 6, 6, 6)]
		[TestCase(2, 2, 2, 1, 1, 1, 3, 3, 3)]
		public void GivenOverrideOperatorPlus_WhenTwoVectorsIsPositive_ThenOutIsPositive(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			int vectorExpectedX, int vectorExpectedY, int vectorExpectedZ)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			Vector expectedVector = new Vector(vectorExpectedX, vectorExpectedY, vectorExpectedZ);

			//Act
			Vector actual = vectorFirst + vectorSecond;

			//Assert
			Assert.AreEqual(expectedVector, actual);
		}

		/// <summary>
		/// Test cases for testing operator vector "+" whith negative numbers.  
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>
		/// <param name="vectorExpectedX">Test parameter "X" expected vector</param>
		/// <param name="vectorExpectedY">Test parameter "Y" expected vector</param>
		/// <param name="vectorExpectedZ">Test parameter "Z" expected vector</param>
		[TestCase(-10, -10, -10, -1, -1, -1, -11, -11, -11)]
		[TestCase(-5, -5, -5, -1, -1, -1, -6, -6, -6)]
		[TestCase(-15, -15, -15, -2, -2, -2, -17, -17, -17)]
		public void GivenOverrideOperatorPlus_WhenTwoVectorsIsNegative_ThenOutIsNegative(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			int vectorExpectedX, int vectorExpectedY, int vectorExpectedZ)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			Vector expectedVector = new Vector(vectorExpectedX, vectorExpectedY, vectorExpectedZ);

			//Act
			Vector actual = vectorFirst + vectorSecond;

			//Assert
			Assert.AreEqual(expectedVector, actual);
		}
		/// <summary>
		/// Test cases for testing operator vector "+" whith negative and positive numbers.  
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>
		/// <param name="vectorExpectedX">Test parameter "X" expected vector</param>
		/// <param name="vectorExpectedY">Test parameter "Y" expected vector</param>
		/// <param name="vectorExpectedZ">Test parameter "Z" expected vector</param>
		[TestCase(-10, -10, -10, 1, 1, 1, -9, -9, -9)]
		[TestCase(-5, -5, -5, 1, 1, 1, -4, -4, -4)]
		[TestCase(-15, -15, -15, 2, 2, 2, -13, -13, -13)]
		public void GivenOverrideOperatorPlus_WhenSecondVectorsIsNegativeAndFirstVectorIsPositive_ThenOutIsNegative(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			int vectorExpectedX, int vectorExpectedY, int vectorExpectedZ)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			Vector expectedVector = new Vector(vectorExpectedX, vectorExpectedY, vectorExpectedZ);

			//Act
			Vector actual = vectorFirst + vectorSecond;

			//Assert
			Assert.AreEqual(expectedVector, actual);
		}

		/// <summary>
		/// Test cases for testing operator vector "+" whith negative and "0" numbers.  
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>
		/// <param name="vectorExpectedX">Test parameter "X" expected vector</param>
		/// <param name="vectorExpectedY">Test parameter "Y" expected vector</param>
		/// <param name="vectorExpectedZ">Test parameter "Z" expected vector</param>
		[TestCase(-10, -10, -10, 0, 0, 0, -10, -10, -10)]
		[TestCase(-5, -5, -5, 0, 0, 0, -5, -5, -5)]
		[TestCase(-15, -15, -15, 0, 0, 0, -15, -15, -15)]
		public void GivenOverrideOperatorPlus_WhenFirstVectorIsNegativeAndSecondVectorIsNull_ThenOutIsNegative(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			int vectorExpectedX, int vectorExpectedY, int vectorExpectedZ)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			Vector expectedVector = new Vector(vectorExpectedX, vectorExpectedY, vectorExpectedZ);

			//Act
			Vector actual = vectorFirst + vectorSecond;

			//Assert
			Assert.AreEqual(expectedVector, actual);
		}

		/// <summary>
		/// Test cases for testing operator vector "-" whith positive numbers.  
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>
		/// <param name="vectorExpectedX">Test parameter "X" expected vector</param>
		/// <param name="vectorExpectedY">Test parameter "Y" expected vector</param>
		/// <param name="vectorExpectedZ">Test parameter "Z" expected vector</param>
		[TestCase(10, 10, 10, 1, 1, 1, 9, 9, 9)]
		[TestCase(5, 5, 5, 1, 1, 1, 4, 4, 4)]
		[TestCase(2, 2, 2, 1, 1, 1, 1, 1, 1)]
		public void GivenOverrideOperatorSubtract_WhenTwoVectorsIsPositive_ThenOutIsPositive(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			int vectorExpectedX, int vectorExpectedY, int vectorExpectedZ)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			Vector expectedVector = new Vector(vectorExpectedX, vectorExpectedY, vectorExpectedZ);

			//Act
			Vector actual = vectorFirst - vectorSecond;

			//Assert
			Assert.AreEqual(expectedVector, actual);
		}

		/// <summary>
		/// Test cases for testing operator vector "-" whith negative numbers.  
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>
		/// <param name="vectorExpectedX">Test parameter "X" expected vector</param>
		/// <param name="vectorExpectedY">Test parameter "Y" expected vector</param>
		/// <param name="vectorExpectedZ">Test parameter "Z" expected vector</param>
		[TestCase(-10, -10, -10, -1, -1, -1, -9, -9, -9)]
		[TestCase(-5, -5, -5, -1, -1, -1, -4, -4, -4)]
		[TestCase(-15, -15, -15, -2, -2, -2, -13, -13, -13)]
		public void GivenOverrideOperatorSubtract_WhenTwoVectorsIsNegative_ThenOutIsNegative(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			int vectorExpectedX, int vectorExpectedY, int vectorExpectedZ)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			Vector expectedVector = new Vector(vectorExpectedX, vectorExpectedY, vectorExpectedZ);

			//Act
			Vector actual = vectorFirst - vectorSecond;

			//Assert
			Assert.AreEqual(expectedVector, actual);
		}

		/// <summary>
		/// Test cases for testing operator vector "-" whith negative and positive numbers.  
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>
		/// <param name="vectorExpectedX">Test parameter "X" expected vector</param>
		/// <param name="vectorExpectedY">Test parameter "Y" expected vector</param>
		/// <param name="vectorExpectedZ">Test parameter "Z" expected vector</param>
		[TestCase(-10, -10, -10, 1, 1, 1, -11, -11, -11)]
		[TestCase(-5, -5, -5, 1, 1, 1, -6, -6, -6)]
		[TestCase(-15, -15, -15, 2, 2, 2, -17, -17, -17)]
		public void GivenOverrideOperatorSubtract_WhenSecondVectorsIsNegativeAndFirstVectorIsPositive_ThenOutIsNegative(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			int vectorExpectedX, int vectorExpectedY, int vectorExpectedZ)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			Vector expectedVector = new Vector(vectorExpectedX, vectorExpectedY, vectorExpectedZ);

			//Act
			Vector actual = vectorFirst - vectorSecond;

			//Assert
			Assert.AreEqual(expectedVector, actual);
		}

		/// <summary>
		/// Test cases for testing operator vector "-" whith negative and "0" numbers.  
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>
		/// <param name="vectorExpectedX">Test parameter "X" expected vector</param>
		/// <param name="vectorExpectedY">Test parameter "Y" expected vector</param>
		/// <param name="vectorExpectedZ">Test parameter "Z" expected vector</param>
		[TestCase(-10, -10, -10, 0, 0, 0, -10, -10, -10)]
		[TestCase(-5, -5, -5, 0, 0, 0, -5, -5, -5)]
		[TestCase(-15, -15, -15, 0, 0, 0, -15, -15, -15)]
		public void GivenOverrideOperatorSubtract_WhenFirstVectorIsNegativeAndSecondVectorIsNull_ThenOutIsNegative(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			int vectorExpectedX, int vectorExpectedY, int vectorExpectedZ)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			Vector expectedVector = new Vector(vectorExpectedX, vectorExpectedY, vectorExpectedZ);

			//Act
			Vector actual = vectorFirst - vectorSecond;

			//Assert
			Assert.AreEqual(expectedVector, actual);
		}

		/// <summary>
		/// Test cases for testing operator vector "multiply" whith positive numbers.  
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>
		/// <param name="vectorExpectedX">Test parameter "X" expected vector</param>
		/// <param name="vectorExpectedY">Test parameter "Y" expected vector</param>
		/// <param name="vectorExpectedZ">Test parameter "Z" expected vector</param>
		[TestCase(10, 10, 10, 1, 1, 1, 10, 10, 10)]
		[TestCase(5, 5, 5, 1, 1, 1, 5, 5, 5)]
		[TestCase(2, 2, 2, 1, 1, 1, 2, 2, 2)]
		public void GivenOverrideOperatorMultiply_WhenTwoVectorsIsPositive_ThenOutIsPositive(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			int vectorExpectedX, int vectorExpectedY, int vectorExpectedZ)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			Vector expectedVector = new Vector(vectorExpectedX, vectorExpectedY, vectorExpectedZ);

			//Act
			Vector actual = vectorFirst * vectorSecond;

			//Assert
			Assert.AreEqual(expectedVector, actual);
		}

		/// <summary>
		/// Test cases for testing operator vector "multiply" whith negative numbers.  
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>
		/// <param name="vectorExpectedX">Test parameter "X" expected vector</param>
		/// <param name="vectorExpectedY">Test parameter "Y" expected vector</param>
		/// <param name="vectorExpectedZ">Test parameter "Z" expected vector</param>
		[TestCase(-10, -10, -10, -1, -1, -1, 10, 10, 10)]
		[TestCase(-5, -5, -5, -1, -1, -1, 5, 5, 5)]
		[TestCase(-15, -15, -15, -2, -2, -2, 30, 30, 30)]
		public void GivenOverrideOperatorMultiply_WhenTwoVectorsIsNegative_ThenOutIsPozitive(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			int vectorExpectedX, int vectorExpectedY, int vectorExpectedZ)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			Vector expectedVector = new Vector(vectorExpectedX, vectorExpectedY, vectorExpectedZ);

			//Act
			Vector actual = vectorFirst * vectorSecond;

			//Assert
			Assert.AreEqual(expectedVector, actual);
		}

		/// <summary>
		/// Test cases for testing operator vector "multiply" whith negative and positive numbers.  
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>
		/// <param name="vectorExpectedX">Test parameter "X" expected vector</param>
		/// <param name="vectorExpectedY">Test parameter "Y" expected vector</param>
		/// <param name="vectorExpectedZ">Test parameter "Z" expected vector</param>
		[TestCase(-10, -10, -10, 1, 1, 1, -10, -10, -10)]
		[TestCase(-5, -5, -5, 1, 1, 1, -5, -5, -5)]
		[TestCase(-15, -15, -15, 2, 2, 2, -30, -30, -30)]
		public void GivenOverrideOperatorMultiply_WhenSecondVectorsIsNegativeAndFirstVectorIsPositive_ThenOutIsNegative(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			int vectorExpectedX, int vectorExpectedY, int vectorExpectedZ)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			Vector expectedVector = new Vector(vectorExpectedX, vectorExpectedY, vectorExpectedZ);

			//Act
			Vector actual = vectorFirst * vectorSecond;

			//Assert
			Assert.AreEqual(expectedVector, actual);
		}

		/// <summary>
		/// Test cases for testing operator vector "multiply" whith negative and "0" numbers.  
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>
		/// <param name="vectorExpectedX">Test parameter "X" expected vector</param>
		/// <param name="vectorExpectedY">Test parameter "Y" expected vector</param>
		/// <param name="vectorExpectedZ">Test parameter "Z" expected vector</param>
		[TestCase(-10, -10, -10, 0, 0, 0, 0, 0, 0)]
		[TestCase(-5, -5, -5, 0, 0, 0, 0, 0, 0)]
		[TestCase(-15, -15, -15, 0, 0, 0, 0, 0, 0)]
		public void GivenOverrideOperatorMultiply_WhenFirstVectorIsNegativeAndSecondVectorIsNull_ThenOutIsNegative(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			int vectorExpectedX, int vectorExpectedY, int vectorExpectedZ)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			Vector expectedVector = new Vector(vectorExpectedX, vectorExpectedY, vectorExpectedZ);

			//Act
			Vector actual = vectorFirst * vectorSecond;

			//Assert
			Assert.AreEqual(expectedVector, actual);
		}

		/// <summary>
		/// Test cases for testing operator vector "multiply" whith negative and numbers and scalar.  
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="scalar"></param>
		/// <param name="vectorExpectedX">Test parameter "X" expected vector</param>
		/// <param name="vectorExpectedY">Test parameter "Y" expected vector</param>
		/// <param name="vectorExpectedZ">Test parameter "Z" expected vector</param>
		[TestCase(-10, -10, -10, 5,  -50, -50, -50)]
		[TestCase(-5, -5, -5, -6, 30, 30, 30)]
		[TestCase(-15, -15, -15, 0, 0, 0, 0)]
		public void GivenOverrideOperatorMultiply_WhenFirstVectorIsNegativeAndSecondIsScalar_ThenOutIsPositive_NegativeVector(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			double scalar,
			int vectorExpectedX, int vectorExpectedY, int vectorExpectedZ)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			
			Vector expectedVector = new Vector(vectorExpectedX, vectorExpectedY, vectorExpectedZ);

			//Act
			Vector actual = vectorFirst * scalar;

			//Assert
			Assert.AreEqual(expectedVector, actual);
		}

		/// <summary>
		/// Test case for testing operator vector "==" whith negative and "0". 
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>>
		/// <param name="expected">expected "false"</param>
		[TestCase(-10, -10, -10, 0, 0, 0, false)]
		[TestCase(-5, -5, -5, 0, 0, 0, false)]
		[TestCase(-15, -15, -15, 0, 0, 0, false)]
		public void GivenOverrideMethodEquals_WhenFirstVectorIsNegativeAndSecondVectorIsNull_ThenOutIsFalse(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			bool expected)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			bool actual;

			//Act
			actual = (vectorFirst == vectorSecond);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Test case for testing operator vector "==" whith positive numbers. 
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>>
		/// <param name="expected">expected "false"</param>
		[TestCase(10, 10, 10, 9, 10, 10, false)]
		[TestCase(5, 5, 5, 5, 3, 5, false)]
		[TestCase(15, 15, 15, 15, 5, 15, false)]
		public void GivenOverrideMethodEquals_WhenFirstVectorIsPositiveAndSecondVectorIsPositive_ThenOutIsFalse(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			bool expected)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			bool actual;

			//Act
			actual = (vectorFirst == vectorSecond);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Test case for testing operator vector "==" whith "0" numbers. 
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>>
		/// <param name="expected">expected "true"</param>
		[TestCase(0, 0, 0, 0, 0, 0, true)]
		public void GivenOverrideMethodEquals_WhenFirstVectorIsNullAndSecondVectorIsNull_ThenOutIsTrue(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			bool expected)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			bool actual;

			//Act
			actual = (vectorFirst == vectorSecond);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Test case for testing operator vector "==" whith negative numbers. 
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>>
		/// <param name="expected">expected "true"</param>
		[TestCase(-10, -10, -10, -10, -10, -10, true)]
		[TestCase(-5, -5, -5, -5, -5, -5, true)]
		[TestCase(-15, -15, -15, -15, -15, -15, true)]
		public void GivenOverrideMethodEquals_WhenFirstVectorIsNegativeAndSecondVectorIsNegative_ThenOutIsTrue(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			bool expected)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			bool actual;

			//Act
			actual = (vectorFirst == vectorSecond);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Test case for testing operator vector "=!" whith negative and "0".
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>>
		/// <param name="expected">expected "true"</param>
		[TestCase(-10, -10, -10, 0, 0, 0, true)]
		[TestCase(-5, -5, -5, 0, 0, 0, true)]
		[TestCase(-15, -15, -15, 0, 0, 0, true)]
		public void GivenOverrideMethodNotEquals_WhenFirstVectorIsNegativeAndSecondVectorIsNull_ThenOutIsTrue(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			bool expected)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			bool actual;

			//Act
			actual = (vectorFirst != vectorSecond);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Test case for testing operator vector "=!" whith positive numbers.
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>>
		/// <param name="expected">expected "true"</param>
		[TestCase(10, 10, 10, 10, 5, 10, true)]
		[TestCase(5, 5, 5, 5, 15, 5, true)]
		[TestCase(15, 15, 15, 15, 5, 15, true)]
		public void GivenOverrideMethodNotEquals_WhenFirstVectorIsPositiveAndSecondVectorIsPositive_ThenOutIsTrue(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			bool expected)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			bool actual;

			//Act
			actual = (vectorFirst != vectorSecond);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Test case for testing operator vector "=!" whith "0" numbers.
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>>
		/// <param name="expected">expected "false"</param>
		[TestCase(0, 0, 0, 0, 0, 0, false)]
		public void GivenOverrideMethodNotEquals_WhenFirstVectorIsNullAndSecondVectorIsNull_ThenOutIsFalse(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			bool expected)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			bool actual;

			//Act
			actual = (vectorFirst != vectorSecond);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Test case for testing operator vector "!=" whith negative numbers.
		/// </summary>
		/// <param name="vectorFirstX">Test parameter "X" first vector</param>
		/// <param name="vectorFirstY">Test parameter "Y" first vector</param>
		/// <param name="vectorFirstZ">Test parameter "Z" first vector</param>
		/// <param name="vectorSecondX">Test parameter "X" second vector</param>
		/// <param name="vectorSecondY">Test parameter "Y" second vector</param>
		/// <param name="vectorSecondZ">Test parameter "Z" second vector</param>>
		/// <param name="expected">expected "false"</param>
		[TestCase(-10, -10, -10, -10, -10, -10, false)]
		[TestCase(-5, -5, -5, -5, -5, -5, false)]
		[TestCase(-15, -15, -15, -15, -15, -15, false)]
		public void GivenOverrideMethodNotEquals_WhenFirstVectorIsNegativeAndSecondVectorIsNegative_ThenOutIsFalse(
			int vectorFirstX, int vectorFirstY, int vectorFirstZ,
			int vectorSecondX, int vectorSecondY, int vectorSecondZ,
			bool expected)
		{
			//Arrange
			Vector vectorFirst = new Vector(vectorFirstX, vectorFirstY, vectorFirstZ);
			Vector vectorSecond = new Vector(vectorSecondX, vectorSecondY, vectorSecondZ);
			bool actual;

			//Act
			actual = (vectorFirst != vectorSecond);

			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}