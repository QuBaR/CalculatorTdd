# Lärarguide - TDD Övning

## ?? Snabböversikt

**Övningens syfte:** Introducera TDD (Test-Driven Development) genom att bygga en miniräknare steg-för-steg.

**Tidsåtgång:** 3-4 timmar (inklusive genomgång och reflektion)

**Förkunskaper:** 
- Grundläggande C# (variabler, metoder, klasser)
- Git basics (commit)
- Hur man kör dotnet-kommandon

---

## ?? Lärandemål

Efter övningen ska studenten kunna:
1. ? Förklara TDD-cykeln (Red-Green-Refactor)
2. ? Skriva enhetstester med xUnit i C#
3. ? Skriva testbar kod genom att tänka på tester först
4. ? Använda [Fact] och [Theory] attribut
5. ? Hantera edge cases och exceptions i tester
6. ? Förstå värdet av TDD i verkliga projekt

---

## ?? Lektionsplanering

### Del 1: Introduktion (45 min)

#### Teori (30 min)
1. **Vad är TDD?** (10 min)
   - Red-Green-Refactor-cykeln
   - Visa på whiteboard/slides
   - Exempel från verkliga projekt

2. **Varför TDD?** (10 min)
   - Fördelar: Färre buggar, bättre design, dokumentation
   - Nackdelar: Tar längre tid initialt, kräver övning
   - Diskutera när TDD är lämpligt

3. **xUnit basics** (10 min)
   - Arrange-Act-Assert mönstret
   - [Fact] vs [Theory]
   - Assert-metoder

#### Live-demo (15 min)
- Öppna Visual Studio/VS Code
- Skapa ett enkelt test (t.ex. för en IsEven-metod)
- Visa Red ? Green ? Refactor live
- Förklara varje steg högt

**?? Tips:** Gör misstag medvetet för att visa hur man felsöker!

---

### Del 2: Guidad övning (45 min)

Gå igenom **STEG 0-3** tillsammans med hela klassen:

1. **STEG 0-1:** Setup (15 min)
   - Alla skapar projekt och testprojekt
 - Verifiera att `dotnet test` fungerar
   - Första Git commit

2. **STEG 2-3:** Första RED-GREEN cykeln (30 min)
   - Skriv Add-testet tillsammans
   - Kör test och se det misslyckas (RED)
   - Implementera Add-metoden
   - Se testet bli grönt (GREEN)
   - Diskutera: "Varför känns detta bra?"

**?? Checkpoint:** Alla har ett grönt test för Addition!

---

### Del 3: Självständigt arbete (90-120 min)

Nu jobbar studenterna själva eller i par genom:
- STEG 4-10

**Din roll som lärare:**
- Gå runt och hjälp till
- Ställ ledande frågor istället för att ge svar
- Uppmuntra pair programming
- Påminn om att commita ofta

**Vanliga hjälpsituationer:**

| Problem | Ledande frågor |
|---------|----------------|
| "Testet kompilerar inte" | "Har du lagt till projekt-referensen? Kolla STEG 1 igen." |
| "Jag vet inte vilket test jag ska skriva" | "Vad ska metoden göra? Skriv det som ett test!" |
| "Mitt test är grönt direkt" | "Perfekt! Din kod täckte redan det fallet. Kan du hitta ett edge case?" |
| "Jag glömde skriva testet först" | "Det är okej! Radera implementation och gör om - det är en del av lärprocessen." |

---

### Del 4: Reflektion och diskussion (30 min)

#### Gruppaktivitet (15 min)
Dela in i små grupper (3-4 personer) och diskutera:
1. Vad var svårast med TDD?
2. Såg ni några fördelar redan?
3. När skulle TDD vara användbart i era egna projekt?

#### Klassgenomgång (15 min)
- Låt 2-3 grupper dela sina reflektioner
- Du som lärare:
  - Sammanfatta key takeaways
  - Visa verkliga exempel där TDD använts
  - Diskutera nästa steg

**Diskussionsfrågor att ställa:**
- "Hur påverkade TDD hur ni tänkte kring kodens struktur?"
- "Märkte ni att metoderna blev mindre och mer fokuserade?"
- "Kändes det säkrare att refaktorera när ni hade tester?"

---

## ??? Förberedelser för lektionen

### Innan lektionen
- [ ] Testa själv hela övningen (tar ~2 tim första gången)
- [ ] Verifiera att .NET 9 SDK är installerat på alla datorer
- [ ] Skapa ett demo-repo som du kan visa
- [ ] Ladda ner/skriv ut README.md åt studenterna
- [ ] Förbered slides för intro-delen

### Material att dela ut
1. **README.md** - Huvudinstruktionerna (obligatorisk)
2. **FACIT.md** - Ge endast till studenter som kör fast (valfritt)
3. **BONUS_FACIT_Calculator.cs** - För referens (valfritt)

### Tekniska förberedelser
Kontrollera att alla har:
```bash
# .NET 9 SDK
dotnet --version

# Git
git --version

# Editor (VS Code eller Visual Studio)
code --version
```

---

## ?? Bedömning

### Godkänd (G)

**Kunskapskrav:**
- Kan förklara TDD-cykeln
- Kan skriva enkla enhetstester
- Kan följa Red-Green-Refactor

**Praktiskt:**
- [X] Har skapat testprojekt med xUnit
- [X] Minst 3 av 5 operationer implementerade med tester
- [X] Har följt TDD för varje funktion
- [X] Commits för huvudstegen
- [X] Alla tester är gröna

### Väl Godkänd (VG)

**Kunskapskrav:**
- Kan motivera varför TDD är värdefullt
- Kan använda avancerade test-patterns (Theory, InlineData)
- Kan identifiera och testa edge cases

**Praktiskt:**
- [X] Alla G-kriterier uppfyllda
- [X] Alla 5 operationer implementerade
- [X] Theory och InlineData används
- [X] Edge cases och exceptions hanterade
- [X] Kod refaktorerad för bättre design
- [X] Tydlig och strukturerad Git-historik
- [X] Minst 1 bonus-uppgift genomförd
- [X] Kan förklara designbeslut

---

## ?? Tips för framgång

### Klassrumstips
1. **Visa misstag:** Gör medvetna fel för att visa felsökningsprocess
2. **Pair programming:** Uppmuntra samarbete (driver/navigator)
3. **Positiv förstärkning:** Fira när tester blir gröna! ??
4. **Iterativ:** Betona att det är okej att göra om steg

### Om någon ligger efter
- Para ihop med någon som ligger före
- Dela ut FACIT.md så de kan komma ikapp
- Påminn: Processen är viktigare än att bli klar

### Om någon blir klar tidigt
Bonus-uppgifter:
1. Implementera utmaningarna i README.md
2. Lägg till Calculator history
3. Skapa en webbaserad UI för kalkylatorn
4. Utforska code coverage med `dotnet-coverage`

---

## ?? Vanliga problem och lösningar

### "Jag får 'Project reference does not exist'"
```bash
# Lösning: Lägg till referens från testprojektet
cd CalculatorTdd.Tests
dotnet add reference ../CalculatorTdd/CalculatorTdd.csproj
```

### "dotnet test hittar inga tester"
- Kontrollera att klassen är `public`
- Kontrollera att metoderna har `[Fact]` eller `[Theory]`
- Kör `dotnet build` först

### "Jag kan inte commita"
```bash
# Konfigurera Git första gången
git config --global user.name "Ditt Namn"
git config --global user.email "din@email.com"
```

### "Alla mina tester är gröna direkt"
Detta är faktiskt bra! Det betyder:
1. Implementation är korrekt för det testfallet
2. Försök hitta ett edge case som inte täcks
3. Exempel: negativa tal, noll, stora tal

---

## ?? Resurser för djupare förståelse

### För dig som lärare
- **Bok:** "Test Driven Development: By Example" - Kent Beck
- **Video:** "TDD: The Bad Parts" - Matt Parker (YouTube)
- **Artikel:** [Microsoft - Unit testing best practices](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)

### För studenter att utforska
- [xUnit Documentation](https://xunit.net/)
- [Martin Fowler's blog om TDD](https://martinfowler.com/bliki/TestDrivenDevelopment.html)
- [.NET Testing Tutorials](https://docs.microsoft.com/en-us/dotnet/core/testing/)

---

## ?? Uppföljning och fortsättning

### Nästa lektion
**Alternativ 1: Mockning och Dependencies**
- Introducera Moq
- Testa kod som använder databas/externa API:er
- Dependency Injection

**Alternativ 2: Integration Testing**
- Skillnad mellan unit tests och integration tests
- Testa webb-API:er med WebApplicationFactory
- In-memory databaser för testning

**Alternativ 3: TDD i praktiken**
- Låt studenterna börja eget projekt med TDD
- Code review av varandras tester
- Diskutera code coverage

### Projekt-idéer med TDD
1. **Todo-lista** - CRUD med tester
2. **Bankomat** - Business logic med många edge cases
3. **Spellogik** - Tic-Tac-Toe, Kortspel
4. **Valideringsbibliotek** - Email, phone, personnummer

---

## ? Checklista - Efter lektionen

- [ ] Samla in feedback från studenterna
- [ ] Notera vad som gick bra/mindre bra
- [ ] Planera uppföljning för nästa lektion
- [ ] Bedöm inlämnade övningar
- [ ] Ge individuell feedback

---

## ?? Key Takeaways för studenter

Efter övningen ska de komma ihåg:

1. **?? RED:** Skriv test som misslyckas först
2. **?? GREEN:** Skriv minsta kod för att testet ska passera
3. **?? REFACTOR:** Förbättra koden utan att ändra funktionalitet
4. **?? REPEAT:** Upprepa för varje ny feature
5. **?? COMMIT:** Versionshantera varje steg

**Och viktigast av allt:** *"If it's not tested, it doesn't work!"*

---

## ?? Support

Om du har frågor om övningen eller hur den fungerar i klassrummet, kontakta:
- TUC's pedagogiska utvecklingsgrupp
- Kollegor som undervisat TDD tidigare
- Community: Swedish Developers Discord/Slack

**Lycka till med lektionen! Du gör skillnad! ??**
