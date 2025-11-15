namespace CalculatorTdd
{
    internal class Program
    {
      static void Main(string[] args)
      {
            var calculator = new Calculator();

            Console.WriteLine("🧮 Välkommen till TDD-Kalkylatorn!");
    Console.WriteLine("==================================\n");

       // Demonstration av alla operationer
     Console.WriteLine("📊 ADDITIONS-EXEMPEL:");
    Console.WriteLine($"   10 + 5 = {calculator.Add(10, 5)}");
      Console.WriteLine($"   -3 + -7 = {calculator.Add(-3, -7)}");

     Console.WriteLine("\n📊 SUBTRAKTIONS-EXEMPEL:");
            Console.WriteLine($"   10 - 5 = {calculator.Subtract(10, 5)}");
 Console.WriteLine($"   5 - 10 = {calculator.Subtract(5, 10)}");

   Console.WriteLine("\n📊 MULTIPLIKATIONS-EXEMPEL:");
       Console.WriteLine($"   10 * 5 = {calculator.Multiply(10, 5)}");
            Console.WriteLine($"   -4 * 3 = {calculator.Multiply(-4, 3)}");

            Console.WriteLine("\n📊 DIVISIONS-EXEMPEL:");
    Console.WriteLine($"   10 / 5 = {calculator.Divide(10, 5)}");
      Console.WriteLine($" 7 / 2 = {calculator.Divide(7, 2):F2}");

        Console.WriteLine("\n📊 PROCENT-EXEMPEL:");
            Console.WriteLine($"   10% av 200 = {calculator.CalculatePercentage(200, 10)}");
  Console.WriteLine($"   25% av 80 = {calculator.CalculatePercentage(80, 25)}");

            Console.WriteLine("\n✅ Alla operationer fungerar perfekt - tack vare TDD!");
  Console.WriteLine("💡 Kolla testerna för att se hur varje funktion verifieras!\n");
    }
    }
}
