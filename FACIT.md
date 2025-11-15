# FACIT - Lösningsförslag för Läraren

Detta dokument innehåller den kompletta lösningen för referens.

## Calculator.cs (Färdig implementation)

```csharp
namespace CalculatorTdd
{
    /// <summary>
    /// En enkel miniräknare med grundläggande matematiska operationer
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
```

## CalculatorTests.cs (Alla tester)

```csharp
namespace CalculatorTdd.Tests
{
    public class CalculatorTests
    {
  #region Addition Tests

      [Theory]
    [InlineData(3, 5, 8)]
        [InlineData(-5, -3, -8)]
        [InlineData(5, 0, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(100, 50, 150)]
  [InlineData(-10, 5, -5)]
        public void Add_VariousNumbers_ReturnsCorrectSum(int a, int b, int expected)
   {
  // Arrange
            var calculator = new Calculator();

            // Act
          var result = calculator.Add(a, b);

          // Assert
            Assert.Equal(expected, result);
        }

    #endregion

        #region Subtraction Tests

     [Theory]
   [InlineData(10, 3, 7)]
        [InlineData(5, 5, 0)]
        [InlineData(0, 5, -5)]
        [InlineData(-5, -3, -2)]
 [InlineData(100, 50, 50)]
        public void Subtract_VariousNumbers_ReturnsCorrectDifference(int a, int b, int expected)
        {
     // Arrange
 var calculator = new Calculator();

            // Act
    var result = calculator.Subtract(a, b);

   // Assert
   Assert.Equal(expected, result);
        }

        #endregion

      #region Multiplication Tests

      [Theory]
      [InlineData(4, 5, 20)]
        [InlineData(5, 0, 0)]
        [InlineData(0, 5, 0)]
        [InlineData(-3, 4, -12)]
        [InlineData(-3, -3, 9)]
        public void Multiply_VariousNumbers_ReturnsCorrectProduct(int a, int b, int expected)
      {
          // Arrange
            var calculator = new Calculator();

            // Act
        var result = calculator.Multiply(a, b);

    // Assert
      Assert.Equal(expected, result);
        }

        #endregion

    #region Division Tests

        [Theory]
      [InlineData(20, 4, 5)]
        [InlineData(10, 2, 5)]
 [InlineData(9, 3, 3)]
    [InlineData(-10, 2, -5)]
      [InlineData(10, -2, -5)]
        public void Divide_VariousNumbers_ReturnsCorrectQuotient(int a, int b, double expected)
        {
 // Arrange
         var calculator = new Calculator();

// Act
            var result = calculator.Divide(a, b);

            // Assert
   Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            // Arrange
     var calculator = new Calculator();

          // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
    }

        [Theory]
        [InlineData(7, 2, 3.5)]
    [InlineData(5, 4, 1.25)]
        public void Divide_ReturnsDecimalWhenNeeded(int a, int b, double expected)
        {
       // Arrange
            var calculator = new Calculator();

     // Act
var result = calculator.Divide(a, b);

            // Assert
 Assert.Equal(expected, result);
  }

        #endregion

        #region Percentage Tests

 [Theory]
     [InlineData(200, 10, 20)]
        [InlineData(50, 50, 25)]
        [InlineData(100, 0, 0)]
     [InlineData(1000, 15, 150)]
   [InlineData(75, 20, 15)]
        public void CalculatePercentage_ReturnsCorrectValue(double value, double percentage, double expected)
        {
            // Arrange
     var calculator = new Calculator();

            // Act
            var result = calculator.CalculatePercentage(value, percentage);

            // Assert
    Assert.Equal(expected, result);
}

        #endregion
    }
}
```

## Program.cs (Demo-applikation)

```csharp
namespace CalculatorTdd
{
    internal class Program
    {
static void Main(string[] args)
        {
            var calculator = new Calculator();

 Console.WriteLine("?? Välkommen till TDD-Kalkylatorn!");
            Console.WriteLine("==================================\n");

  // Demonstration av alla operationer
         Console.WriteLine("?? ADDITIONS-EXEMPEL:");
     Console.WriteLine($"   10 + 5 = {calculator.Add(10, 5)}");
  Console.WriteLine($"   -3 + -7 = {calculator.Add(-3, -7)}");

            Console.WriteLine("\n?? SUBTRAKTIONS-EXEMPEL:");
     Console.WriteLine($"   10 - 5 = {calculator.Subtract(10, 5)}");
            Console.WriteLine($"   5 - 10 = {calculator.Subtract(5, 10)}");

    Console.WriteLine("\n?? MULTIPLIKATIONS-EXEMPEL:");
    Console.WriteLine($"   10 * 5 = {calculator.Multiply(10, 5)}");
          Console.WriteLine($"   -4 * 3 = {calculator.Multiply(-4, 3)}");

         Console.WriteLine("\n?? DIVISIONS-EXEMPEL:");
            Console.WriteLine($"   10 / 5 = {calculator.Divide(10, 5)}");
      Console.WriteLine($"   7 / 2 = {calculator.Divide(7, 2):F2}");

          Console.WriteLine("\n?? PROCENT-EXEMPEL:");
  Console.WriteLine($"   10% av 200 = {calculator.CalculatePercentage(200, 10)}");
        Console.WriteLine($"   25% av 80 = {calculator.CalculatePercentage(80, 25)}");

  Console.WriteLine("\n? Alla operationer fungerar perfekt - tack vare TDD!");
            Console.WriteLine("?? Kolla testerna för att se hur varje funktion verifieras!\n");

 // Interaktiv del (valfritt)
        Console.WriteLine("Vill du testa själv? (j/n)");
        var answer = Console.ReadLine();

   if (answer?.ToLower() == "j")
      {
     InteractiveMode(calculator);
   }
        }

        static void InteractiveMode(Calculator calculator)
        {
      while (true)
      {
      Console.WriteLine("\n--- Välj operation ---");
   Console.WriteLine("1. Addition");
         Console.WriteLine("2. Subtraktion");
             Console.WriteLine("3. Multiplikation");
         Console.WriteLine("4. Division");
             Console.WriteLine("5. Procent");
 Console.WriteLine("0. Avsluta");

    var choice = Console.ReadLine();

       if (choice == "0") break;

        Console.Write("Ange första talet: ");
      if (!double.TryParse(Console.ReadLine(), out double num1))
           {
     Console.WriteLine("? Ogiltigt tal!");
continue;
       }

     Console.Write("Ange andra talet: ");
      if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("? Ogiltigt tal!");
        continue;
   }

        try
   {
     double result = choice switch
              {
        "1" => calculator.Add((int)num1, (int)num2),
 "2" => calculator.Subtract((int)num1, (int)num2),
             "3" => calculator.Multiply((int)num1, (int)num2),
   "4" => calculator.Divide((int)num1, (int)num2),
       "5" => calculator.CalculatePercentage(num1, num2),
             _ => throw new InvalidOperationException("Ogiltigt val")
 };

Console.WriteLine($"? Resultat: {result}");
 }
 catch (Exception ex)
      {
  Console.WriteLine($"? Fel: {ex.Message}");
 }
     }
     }
    }
}
```

## Bedömningskriterier

### Godkänd (G)
- [ ] Har skapat testprojekt med xUnit
- [ ] Har implementerat minst 3 av 5 operationer med tester
- [ ] Har följt Red-Green-Refactor för varje funktion
- [ ] Har gjort commits för varje steg
- [ ] Alla tester är gröna

### Väl Godkänd (VG)
- [ ] Alla punkter för G
- [ ] Har implementerat alla 5 operationer
- [ ] Har använt Theory och InlineData
- [ ] Har hanterat edge cases och exceptions
- [ ] Har refaktorerat tester och kod
- [ ] Har god commit-historik med beskrivande meddelanden
- [ ] Har lagt till extra funktionalitet (bonus-uppgifter)
- [ ] Kan förklara varför TDD är värdefullt

## Tips för genomgång i klassrummet

### Innan övningen (30 min)
1. Förklara TDD-konceptet med exempel
2. Visa Red-Green-Refactor på whiteboard
3. Demonstrera första steget live

### Under övningen (2-3 timmar)
- Låt studenterna jobba i sitt eget tempo
- Gå runt och hjälp till
- Uppmuntra pair programming
- Påminn om att commita ofta

### Efter övningen (30 min)
- Diskutera reflektionsfrågorna
- Låt några studenter presentera sin lösning
- Diskutera vad som var svårt/lätt
- Koppla till verkliga projekt

### Vanliga problem och lösningar

**Problem:** "Testet kompilerar inte"
**Lösning:** Kontrollera att referensen mellan projekt finns

**Problem:** "Jag glömde skriva testet först"
**Lösning:** Radera koden och börja om - det är en del av lärprocessen!

**Problem:** "Alla mina tester är gröna direkt"
**Lösning:** Bra! Det betyder att din implementation redan täckte fallet. Försök hitta ett edge case.

**Problem:** "Git är svårt"
**Lösning:** Använd GitHub Desktop eller VS Code's Git-integration

## Fortsättning och utbyggnad

### Nästa övningar
1. **TDD med dependencies** - Mocka externa tjänster
2. **TDD med databas** - Använd in-memory database
3. **TDD med API** - Bygg ett RESTful API test-drivet

### Verkliga projekt
- Låt studenterna bygga ett eget projekt med TDD
- Code review av varandras tester
- Mät code coverage med `dotnet-coverage`

