# TDD-Övning: Bygg en Testbar Miniräknare ??

## ?? Introduktion

Välkommen till din första Test-Driven Development (TDD) övning! I denna övning kommer du att bygga en miniräknare **steg för steg** genom att först skriva tester, sedan implementera funktionalitet.

### Vad är TDD?

**Test-Driven Development** är en utvecklingsmetod där du:
1. ?? **RED** - Skriver ett test som misslyckas
2. ?? **GREEN** - Skriver minsta möjliga kod för att testet ska passera
3. ?? **REFACTOR** - Förbättrar koden utan att ändra funktionalitet

### Varför TDD?

- ? Säkerställer att koden fungerar som förväntat
- ? Ger dokumentation genom tester
- ? Gör det lättare att refaktorera
- ? Förbättrar koddesign och testbarhet
- ? Minskar buggar i produktion

---

## ?? Mål med Övningen

Efter denna övning kommer du att kunna:
- Förstå TDD-cykeln (Red ? Green ? Refactor)
- Skriva enhetstester med xUnit i C#
- Skapa testbar kod med små, fokuserade metoder
- Använda Git för versionshantering av varje steg

---

## ??? Förberedelser

### Förkunskaper
- Grundläggande C# kunskaper
- Git grunderna (commit, push)
- Visual Studio eller VS Code installerat

### Verktyg som behövs
- .NET 9 SDK
- xUnit (installeras i övningen)
- Git

---

## ?? Steg-för-Steg Instruktioner

### **STEG 0: Förberedelser och Setup**

#### 0.1 Klona eller skapa projektet
Om du inte redan har projektet:
```bash
# Skapa ny mapp och navigera dit
mkdir CalculatorTdd
cd CalculatorTdd

# Initiera Git
git init

# Skapa ett nytt console-projekt
dotnet new console -n CalculatorTdd
cd CalculatorTdd
```

#### 0.2 Skapa en .gitignore
```bash
dotnet new gitignore
```

#### 0.3 Första commit
```bash
git add .
git commit -m "STEG 0: Initial projekt setup"
```

---

### **STEG 1: Lägg till xUnit Testprojekt**

#### 1.1 Skapa testprojekt
Gå tillbaka till root-mappen (där solution-filen skulle ligga) och kör:
```bash
# Om du är i CalculatorTdd-mappen, gå upp en nivå
cd ..

# Skapa testprojekt
dotnet new xunit -n CalculatorTdd.Tests

# Skapa en solution
dotnet new sln -n CalculatorTdd

# Lägg till båda projekten i solution
dotnet sln add CalculatorTdd/CalculatorTdd.csproj
dotnet sln add CalculatorTdd.Tests/CalculatorTdd.Tests.csproj

# Lägg till referens från testprojektet till huvudprojektet
cd CalculatorTdd.Tests
dotnet add reference ../CalculatorTdd/CalculatorTdd.csproj
cd ..
```

#### 1.2 Verifiera att testen fungerar
```bash
dotnet test
```

Du bör se att de default-tester som skapades körs.

#### 1.3 Commit
```bash
git add .
git commit -m "STEG 1: Lagt till xUnit testprojekt och solution"
```

---

### **STEG 2: Första Testet - Addition (RED)**

#### 2.1 Skapa Calculator-klassen (tom)
Skapa filen `CalculatorTdd/Calculator.cs`:

```csharp
namespace CalculatorTdd
{
public class Calculator
    {
        // Tom klass - vi bygger den steg för steg!
    }
}
```

#### 2.2 Skriv ditt första test
Öppna `CalculatorTdd.Tests/UnitTest1.cs` och ersätt innehållet med:

```csharp
namespace CalculatorTdd.Tests
{
    public class CalculatorTests
    {
  [Fact]
     public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange (Förbered)
var calculator = new Calculator();
      
      // Act (Utför)
        var result = calculator.Add(3, 5);
            
     // Assert (Kontrollera)
    Assert.Equal(8, result);
        }
    }
}
```

#### 2.3 Kör testet (det SKA misslyckas!)
```bash
dotnet test
```

**Förväntat resultat:** ? Testet misslyckas eftersom `Add`-metoden inte existerar.

#### 2.4 Commit
```bash
git add .
git commit -m "STEG 2 (RED): Skapat första testet för Addition - testet misslyckas"
```

---

### **STEG 3: Implementera Addition (GREEN)**

#### 3.1 Lägg till Add-metoden
Uppdatera `CalculatorTdd/Calculator.cs`:

```csharp
namespace CalculatorTdd
{
    public class Calculator
    {
     public int Add(int a, int b)
        {
        return a + b;
        }
  }
}
```

#### 3.2 Kör testet igen
```bash
dotnet test
```

**Förväntat resultat:** ? Testet ska nu passera!

#### 3.3 Commit
```bash
git add .
git commit -m "STEG 3 (GREEN): Implementerat Add-metoden - testet passerar"
```

---

### **STEG 4: Fler Addition-tester (RED)**

#### 4.1 Lägg till fler testfall
Lägg till dessa tester i `CalculatorTests`:

```csharp
[Fact]
public void Add_WithNegativeNumbers_ReturnsCorrectSum()
{
    // Arrange
    var calculator = new Calculator();
    
    // Act
 var result = calculator.Add(-5, -3);
    
    // Assert
    Assert.Equal(-8, result);
}

[Fact]
public void Add_WithZero_ReturnsCorrectSum()
{
    // Arrange
    var calculator = new Calculator();
    
    // Act
    var result = calculator.Add(5, 0);
    
    // Assert
    Assert.Equal(5, result);
}
```

#### 4.2 Kör testen
```bash
dotnet test
```

**Förväntat resultat:** ? Alla tester ska passera (vår implementation täcker redan dessa fall!)

#### 4.3 Commit
```bash
git add .
git commit -m "STEG 4: Lagt till fler testfall för Addition"
```

---

### **STEG 5: Subtraktion (RED ? GREEN)**

#### 5.1 Skriv test för subtraktion
Lägg till i `CalculatorTests`:

```csharp
[Fact]
public void Subtract_TwoNumbers_ReturnsCorrectDifference()
{
 // Arrange
    var calculator = new Calculator();
    
    // Act
 var result = calculator.Subtract(10, 3);
    
    // Assert
    Assert.Equal(7, result);
}
```

#### 5.2 Kör test (ska misslyckas)
```bash
dotnet test
```

#### 5.3 Commit (RED)
```bash
git add .
git commit -m "STEG 5 (RED): Test för Subtract - misslyckas"
```

#### 5.4 Implementera Subtract
Lägg till i `Calculator.cs`:

```csharp
public int Subtract(int a, int b)
{
    return a - b;
}
```

#### 5.5 Kör test (ska passera)
```bash
dotnet test
```

#### 5.6 Commit (GREEN)
```bash
git add .
git commit -m "STEG 5 (GREEN): Implementerat Subtract - testet passerar"
```

---

### **STEG 6: Multiplikation (RED ? GREEN)**

#### 6.1 Skriv test
```csharp
[Fact]
public void Multiply_TwoNumbers_ReturnsCorrectProduct()
{
    // Arrange
    var calculator = new Calculator();
    
    // Act
    var result = calculator.Multiply(4, 5);
    
    // Assert
    Assert.Equal(20, result);
}

[Fact]
public void Multiply_WithZero_ReturnsZero()
{
    // Arrange
    var calculator = new Calculator();
    
    // Act
    var result = calculator.Multiply(5, 0);
    
    // Assert
    Assert.Equal(0, result);
}
```

#### 6.2 Commit (RED)
```bash
git add .
git commit -m "STEG 6 (RED): Test för Multiply - misslyckas"
```

#### 6.3 Implementera Multiply
```csharp
public int Multiply(int a, int b)
{
    return a * b;
}
```

#### 6.4 Commit (GREEN)
```bash
git add .
git commit -m "STEG 6 (GREEN): Implementerat Multiply - testen passerar"
```

---

### **STEG 7: Division med Edge Cases (RED ? GREEN)**

#### 7.1 Skriv tester (inklusive undantagshantering)
```csharp
[Fact]
public void Divide_TwoNumbers_ReturnsCorrectQuotient()
{
    // Arrange
    var calculator = new Calculator();
    
    // Act
    var result = calculator.Divide(20, 4);
    
  // Assert
    Assert.Equal(5, result);
}

[Fact]
public void Divide_ByZero_ThrowsException()
{
    // Arrange
 var calculator = new Calculator();
    
    // Act & Assert
    Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
}
```

#### 7.2 Commit (RED)
```bash
git add .
git commit -m "STEG 7 (RED): Test för Divide inkl. DivideByZero - misslyckas"
```

#### 7.3 Implementera Divide
```csharp
public double Divide(int a, int b)
{
    if (b == 0)
 {
        throw new DivideByZeroException("Cannot divide by zero");
    }
    return (double)a / b;
}
```

#### 7.4 Commit (GREEN)
```bash
git add .
git commit -m "STEG 7 (GREEN): Implementerat Divide med exception-hantering - testen passerar"
```

---

### **STEG 8: Refaktorering (REFACTOR)**

Nu har vi en fungerande kalkylator, men vi kan förbättra koden!

#### 8.1 Refaktorera tester - Använd teorier
Ersätt flera likadana tester med `Theory` och `InlineData`:

```csharp
[Theory]
[InlineData(3, 5, 8)]
[InlineData(-5, -3, -8)]
[InlineData(5, 0, 5)]
[InlineData(0, 0, 0)]
[InlineData(100, 50, 150)]
public void Add_VariousNumbers_ReturnsCorrectSum(int a, int b, int expected)
{
    // Arrange
    var calculator = new Calculator();
    
    // Act
    var result = calculator.Add(a, b);
    
    // Assert
    Assert.Equal(expected, result);
}
```

#### 8.2 Kör testen (ska fortfarande passera)
```bash
dotnet test
```

#### 8.3 Commit
```bash
git add .
git commit -m "STEG 8 (REFACTOR): Refaktorerat tester med Theory och InlineData"
```

---

### **STEG 9: Avancerat - Beräkna Procent (RED ? GREEN ? REFACTOR)**

#### 9.1 Skriv test
```csharp
[Theory]
[InlineData(200, 10, 20)]      // 10% av 200 = 20
[InlineData(50, 50, 25)]       // 50% av 50 = 25
[InlineData(100, 0, 0)]     // 0% av 100 = 0
public void CalculatePercentage_ReturnsCorrectValue(double value, double percentage, double expected)
{
    // Arrange
    var calculator = new Calculator();
    
 // Act
    var result = calculator.CalculatePercentage(value, percentage);
    
    // Assert
    Assert.Equal(expected, result);
}
```

#### 9.2 Commit (RED)
```bash
git add .
git commit -m "STEG 9 (RED): Test för CalculatePercentage - misslyckas"
```

#### 9.3 Implementera
```csharp
public double CalculatePercentage(double value, double percentage)
{
    return value * (percentage / 100);
}
```

#### 9.4 Commit (GREEN)
```bash
git add .
git commit -m "STEG 9 (GREEN): Implementerat CalculatePercentage - testen passerar"
```

---

### **STEG 10: Slutgiltig Refaktorering och Documentation**

#### 10.1 Lägg till XML-dokumentation
Lägg till dokumentation i `Calculator.cs`:

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
        
        // ... fortsätt för övriga metoder
    }
}
```

#### 10.2 Uppdatera Program.cs
Skapa en interaktiv konsoll-applikation:

```csharp
namespace CalculatorTdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
 
            Console.WriteLine("?? Välkommen till TDD-Kalkylatorn!");
            Console.WriteLine("==================================");
            
Console.WriteLine($"Addition: 10 + 5 = {calculator.Add(10, 5)}");
         Console.WriteLine($"Subtraktion: 10 - 5 = {calculator.Subtract(10, 5)}");
    Console.WriteLine($"Multiplikation: 10 * 5 = {calculator.Multiply(10, 5)}");
 Console.WriteLine($"Division: 10 / 5 = {calculator.Divide(10, 5)}");
          Console.WriteLine($"Procent: 10% av 200 = {calculator.CalculatePercentage(200, 10)}");
            
    Console.WriteLine("\n? Alla operationer fungerar - tack vare TDD!");
     }
    }
}
```

#### 10.3 Kör applikationen
```bash
cd CalculatorTdd
dotnet run
```

#### 10.4 Final commit
```bash
git add .
git commit -m "STEG 10 (REFACTOR): Lagt till dokumentation och interaktiv demo"
```

---

## ?? Reflektionsfrågor

Efter att du genomfört övningen, fundera över:

1. **Hur kände det sig att skriva testet INNAN koden?**
   - Var det svårt eller lätt?
   - Hjälpte det dig tänka på funktionaliteten?

2. **Vilka fördelar såg du med TDD?**
   - Kände du dig säkrare på att koden fungerade?
   - Upptäckte du edge cases du annars missat?

3. **Hur påverkade TDD din koddesign?**
   - Blev metoderna mindre och mer fokuserade?
   - Var koden lättare att testa?

4. **Vad var mest utmanande?**
   - Red-Green-Refactor-cykeln?
   - Att tänka på testfall?
   - Git-commits för varje steg?

---

## ?? Utmaningar för Fortsatt Lärande

Om du vill fortsätta öva, prova att lägga till:

### Nivå 1: Grundläggande
- [ ] `Power(base, exponent)` - Beräkna upphöjt till
- [ ] `SquareRoot(number)` - Beräkna kvadratrot
- [ ] `IsEven(number)` - Kontrollera om ett tal är jämnt

### Nivå 2: Mellansvår
- [ ] `Average(numbers[])` - Beräkna medelvärde från en array
- [ ] `Factorial(n)` - Beräkna fakultet
- [ ] `IsPrime(number)` - Kontrollera om ett tal är primtal

### Nivå 3: Avancerad
- [ ] Calculator history - Spara alla operationer
- [ ] Undo/Redo funktionalitet
- [ ] Chain operations: `calculator.Add(5).Multiply(2).Subtract(3)`

**Kom ihåg:** För varje ny funktion:
1. ?? Skriv testet först (RED)
2. ?? Implementera minsta möjliga kod (GREEN)
3. ?? Förbättra och rensa (REFACTOR)
4. ?? Commita till Git

---

## ?? Lärresurser

### Böcker
- "Test Driven Development: By Example" - Kent Beck
- "The Art of Unit Testing" - Roy Osherove

### Online
- [xUnit Documentation](https://xunit.net/)
- [Microsoft - Unit testing best practices](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)
- [Martin Fowler - Test Driven Development](https://martinfowler.com/bliki/TestDrivenDevelopment.html)

---

## ? Checklista - Har du gjort allt?

- [ ] Skapat testprojekt med xUnit
- [ ] Implementerat alla grundläggande operationer (Add, Subtract, Multiply, Divide)
- [ ] Skrivit tester FÖRE implementation
- [ ] Använt Theory och InlineData
- [ ] Hanterat exceptions (DivideByZero)
- [ ] Gjort minst 10 commits med beskrivande meddelanden
- [ ] Alla tester är gröna (`dotnet test`)
- [ ] Kört applikationen och sett att den fungerar
- [ ] Reflekterat över TDD-processen

---

## ?? Grattis!

Du har nu gått igenom en komplett TDD-övning och byggt en testbar miniräknare! 

**Key Takeaways:**
- ? TDD hjälper dig skriva bättre, mer testbar kod
- ? Tester ger dokumentation och säkerhet
- ? Red-Green-Refactor är en kraftfull utvecklingscykel
- ? Små commits gör det lätt att spåra progression

**Nästa steg:** Tillämpa TDD i dina egna projekt! ??

---

## ?? Support

Om du kör fast:
1. Läs felmeddelandet noggrant
2. Kontrollera att du följt stegen exakt
3. Kör `dotnet test --logger "console;verbosity=detailed"` för mer info
4. Fråga din lärare eller klasskamrater

**Lycka till!** ??
