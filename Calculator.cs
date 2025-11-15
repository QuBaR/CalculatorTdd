namespace CalculatorTdd
{
    /// <summary>
    /// En enkel miniräknare med grundläggande matematiska operationer
    /// Byggd med Test-Driven Development (TDD)
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Adderar två heltal
        /// </summary>
        /// <param name="a">Första talet</param>
    /// <param name="b">Andra talet</param>
        /// <returns>Summan av a och b</returns>
        public int Add(int a, int b)
      {
          return a + b;
        }

        /// <summary>
        /// Subtraherar två heltal
 /// </summary>
        /// <param name="a">Första talet</param>
        /// <param name="b">Andra talet (subtraheras från a)</param>
    /// <returns>Differensen mellan a och b</returns>
   public int Subtract(int a, int b)
     {
         return a - b;
     }

        /// <summary>
        /// Multiplicerar två heltal
        /// </summary>
   /// <param name="a">Första talet</param>
        /// <param name="b">Andra talet</param>
     /// <returns>Produkten av a och b</returns>
        public int Multiply(int a, int b)
        {
            return a * b;
  }

    /// <summary>
   /// Dividerar två heltal
/// </summary>
        /// <param name="a">Täljaren</param>
        /// <param name="b">Nämnaren</param>
        /// <returns>Kvoten av a och b som double</returns>
     /// <exception cref="DivideByZeroException">Kastas när b är 0</exception>
        public double Divide(int a, int b)
        {
       if (b == 0)
            {
  throw new DivideByZeroException("Cannot divide by zero");
            }
  return (double)a / b;
        }

        /// <summary>
      /// Beräknar procent av ett värde
        /// </summary>
        /// <param name="value">Värdet att beräkna procent av</param>
        /// <param name="percentage">Procentandelen</param>
        /// <returns>Procentvärdet</returns>
   public double CalculatePercentage(double value, double percentage)
      {
   return value * (percentage / 100);
        }
    }
}
