# Git Commit Guide för TDD-Övningen

Detta dokument innehåller alla commits du ska göra under övningen.

## ?? Commit-mall för varje steg

### Standard commit-format
```
STEG X (FASE): Kort beskrivning

- Detalj 1
- Detalj 2
```

Där **FASE** är:
- **RED** = Testet misslyckas
- **GREEN** = Testet passerar
- **REFACTOR** = Förbättrad kod

---

## ?? Kompletta commits för övningen

### STEG 0
```bash
git add .
git commit -m "STEG 0: Initial projekt setup"
```

### STEG 1
```bash
git add .
git commit -m "STEG 1: Lagt till xUnit testprojekt och solution

- Skapat CalculatorTdd.Tests projekt
- Lagt till projektreferens
- Verifierat att dotnet test fungerar"
```

### STEG 2 (RED)
```bash
git add .
git commit -m "STEG 2 (RED): Skapat första testet för Addition - testet misslyckas

- Skapat Calculator.cs (tom klass)
- Skapat CalculatorTests.cs med Add-test
- Testet kompilerar inte än eftersom Add() inte finns"
```

### STEG 3 (GREEN)
```bash
git add .
git commit -m "STEG 3 (GREEN): Implementerat Add-metoden - testet passerar

- Lagt till Add(int a, int b) metod
- Returnerar a + b
- Test: Add_TwoPositiveNumbers_ReturnsCorrectSum ?"
```

### STEG 4
```bash
git add .
git commit -m "STEG 4: Lagt till fler testfall för Addition

- Test för negativa tal
- Test för addition med noll
- Alla befintliga tester passerar redan"
```

### STEG 5 (RED)
```bash
git add .
git commit -m "STEG 5 (RED): Test för Subtract - misslyckas

- Lagt till test: Subtract_TwoNumbers_ReturnsCorrectDifference
- Metoden Subtract() finns inte än"
```

### STEG 5 (GREEN)
```bash
git add .
git commit -m "STEG 5 (GREEN): Implementerat Subtract - testet passerar

- Lagt till Subtract(int a, int b) metod
- Returnerar a - b"
```

### STEG 6 (RED)
```bash
git add .
git commit -m "STEG 6 (RED): Tester för Multiply - misslyckas

- Test för multiplikation av två tal
- Test för multiplikation med noll
- Multiply() metoden finns inte än"
```

### STEG 6 (GREEN)
```bash
git add .
git commit -m "STEG 6 (GREEN): Implementerat Multiply - testen passerar

- Lagt till Multiply(int a, int b) metod
- Returnerar a * b
- Båda testerna är gröna ?"
```

### STEG 7 (RED)
```bash
git add .
git commit -m "STEG 7 (RED): Tester för Divide inkl. DivideByZero - misslyckas

- Test för normal division
- Test för division med noll (ska kasta exception)
- Divide() metoden finns inte än"
```

### STEG 7 (GREEN)
```bash
git add .
git commit -m "STEG 7 (GREEN): Implementerat Divide med exception-hantering - testen passerar

- Lagt till Divide(int a, int b) metod
- Returnerar double för decimalresultat
- Kastar DivideByZeroException när b = 0
- Alla tester gröna ?"
```

### STEG 8 (REFACTOR)
```bash
git add .
git commit -m "STEG 8 (REFACTOR): Refaktorerat tester med Theory och InlineData

- Konverterat flera [Fact] till [Theory]
- Använder [InlineData] för multipla testfall
- Samma funktionalitet, mindre kod
- Alla tester fortfarande gröna ?"
```

### STEG 9 (RED)
```bash
git add .
git commit -m "STEG 9 (RED): Test för CalculatePercentage - misslyckas

- Lagt till Theory med flera InlineData för procentberäkning
- Metoden finns inte än"
```

### STEG 9 (GREEN)
```bash
git add .
git commit -m "STEG 9 (GREEN): Implementerat CalculatePercentage - testen passerar

- Lagt till CalculatePercentage(double value, double percentage)
- Beräknar value * (percentage / 100)
- Alla tester gröna ?"
```

### STEG 10 (REFACTOR)
```bash
git add .
git commit -m "STEG 10 (REFACTOR): Lagt till dokumentation och demo

- XML-dokumentation för alla metoder
- Uppdaterat Program.cs med interaktiv demo
- Code cleanup och organisering
- Final touch! ??"
```

---

## ?? Bonus commits (om du gör utmaningarna)

### Power-metod
```bash
git add .
git commit -m "BONUS: Implementerat Power-metod med TDD

- Test för upphöjt till
- Implementation med Math.Pow
- Edge cases: negativa exponenter, noll"
```

### Square Root
```bash
git add .
git commit -m "BONUS: Implementerat SquareRoot-metod med TDD

- Test för kvadratrot
- Exception för negativa tal
- Använder Math.Sqrt"
```

### History-funktion
```bash
git add .
git commit -m "BONUS: Lagt till Calculator History

- List<string> för att lagra operationer
- GetHistory() metod
- ClearHistory() metod
- Tester för history-funktionalitet"
```

---

## ?? Verifiera din Git-historik

Efter övningen, kör:
```bash
git log --oneline
```

Du bör se något liknande:
```
a1b2c3d STEG 10 (REFACTOR): Lagt till dokumentation och demo
b2c3d4e STEG 9 (GREEN): Implementerat CalculatePercentage - testen passerar
c3d4e5f STEG 9 (RED): Test för CalculatePercentage - misslyckas
d4e5f6g STEG 8 (REFACTOR): Refaktorerat tester med Theory och InlineData
...
```

### Kolla detaljerad historik
```bash
git log --graph --decorate --all
```

### Se vad som ändrats i varje commit
```bash
git log -p
```

---

## ?? Bra commit-meddelanden

### ? BRA exempel
```bash
"STEG 3 (GREEN): Implementerat Add-metoden - testet passerar"
"STEG 7 (RED): Tester för Divide inkl. DivideByZero - misslyckas"
"STEG 8 (REFACTOR): Refaktorerat tester med Theory och InlineData"
```

**Varför bra?**
- Tydlig fas (RED/GREEN/REFACTOR)
- Beskriver VAD som gjorts
- Kort men informativt

### ? DÅLIGA exempel
```bash
"uppdatering"
"fixade grejer"
"asdf"
"test"
```

**Varför dåligt?**
- Ingen kontext
- Omöjligt att förstå vad som ändrats
- Hjälper inte framtida dig eller andra

---

## ?? Tips för Git under övningen

### Innan du commitar
```bash
# Se vad som ändrats
git status

# Se specifika ändringar
git diff

# Lägg till specifika filer
git add Calculator.cs
git add CalculatorTests.cs

# Eller lägg till allt
git add .
```

### Om du gjorde fel commit
```bash
# Ändra senaste commit-meddelandet
git commit --amend -m "Nytt meddelande"

# Lägg till glömda filer i senaste commit
git add glömd-fil.cs
git commit --amend --no-edit
```

### Se vad som finns i en commit
```bash
git show HEAD      # Senaste commit
git show HEAD~1    # Näst senaste commit
```

---

## ?? Varför är bra commits viktiga?

1. **Dokumentation:** Din commit-historik berättar en story
2. **Felsökning:** Lätt att hitta när något gick fel
3. **Samarbete:** Andra kan förstå dina tankar
4. **Lärande:** Du kan se din egen utveckling
5. **Portfolio:** Visar professionalism till framtida arbetsgivare

---

## ? Checklista för varje commit

Innan du commitar, fråga dig själv:

- [ ] Har jag testat att koden kompilerar?
- [ ] Har jag kört `dotnet test`?
- [ ] Är mitt commit-meddelande beskrivande?
- [ ] Har jag inkluderat rätt fas (RED/GREEN/REFACTOR)?
- [ ] Kan någon annan förstå vad jag gjort?

---

## ?? Efter övningen

När du är klar, pusha till GitHub:

```bash
# Skapa repo på GitHub först, sedan:
git remote add origin https://github.com/ditt-användarnamn/calculator-tdd.git
git branch -M main
git push -u origin main
```

Nu kan du dela din TDD-resa med andra! ??

---

**Lycka till med dina commits!** ??
