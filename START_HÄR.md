# ?? TDD-Övning - Sammanfattning för läraren

## ? Vad har skapats?

Denna övning innehåller alla filer och guider dina elever behöver för att lära sig TDD i C# steg-för-steg.

---

## ?? Filer i projektet

| Fil | Syfte | För vem? |
|-----|-------|----------|
| **README.md** | Huvudinstruktioner - steg-för-steg guide | **Studenter** (GE UT) |
| **LÄRARGUIDE.md** | Lektionsplanering och tips | **Dig som lärare** |
| **FACIT.md** | Komplett lösning med alla tester | **Lärare + studenter som kör fast** |
| **GIT_COMMIT_GUIDE.md** | Exakta commit-meddelanden för varje steg | **Studenter** (GE UT) |
| **Calculator.cs** | Färdig Calculator-klass | **Referens** (ge vid behov) |
| **Program.cs** | Demo-applikation | **Klar att köra** |
| **CalculatorTdd.csproj** | Projektfil | **Redan konfigurerad** |

---

## ?? Hur använder du detta i undervisningen?

### **FÖRE lektionen**
1. ? Läs igenom **LÄRARGUIDE.md**
2. ? Genomför själv övningen (tar ~2 tim)
3. ? Dela ut **README.md** till studenterna (digitalt eller utskrivet)
4. ? Dela ut **GIT_COMMIT_GUIDE.md** till studenterna

### **UNDER lektionen**
1. ?? Håll intro-presentation (45 min) - se LÄRARGUIDE.md
2. ????? Guidad genomgång STEG 0-3 tillsammans (45 min)
3. ????? Eleverna jobbar själva STEG 4-10 (90-120 min)
4. ?? Reflektion och diskussion (30 min)

### **EFTER lektionen**
- Bedöm enligt kriterier i LÄRARGUIDE.md
- Ge **FACIT.md** till elever som vill se lösningen
- Samla feedback för nästa gång

---

## ?? Övningens struktur

Eleverna bygger en **miniräknare** genom TDD i **10 steg**:

| Steg | Vad görs | TDD-fas | Tidsåtgång |
|------|----------|---------|------------|
| 0-1 | Setup projekt + xUnit | - | 20 min |
| 2-3 | Addition (första RED-GREEN) | ????? | 30 min |
| 4 | Fler addition-tester | ?? | 15 min |
| 5 | Subtraktion | ????? | 20 min |
| 6 | Multiplikation | ????? | 20 min |
| 7 | Division + Exceptions | ????? | 30 min |
| 8 | Refaktorera med Theory | ?? | 30 min |
| 9 | Procent-beräkning | ????? | 20 min |
| 10 | Dokumentation + demo | ?? | 20 min |

**Total tid:** ~3-4 timmar

---

## ?? Lärandemål (sammanfattning)

Efter övningen kan studenten:
- ? Förklara TDD-cykeln (Red-Green-Refactor)
- ? Skriva enhetstester med xUnit
- ? Använda [Fact], [Theory] och [InlineData]
- ? Testa edge cases och exceptions
- ? Skriva testbar kod
- ? Versionshantera med Git steg-för-steg

---

## ?? Snabbstart för dig

### Vill du testa övningen själv direkt?

```bash
# 1. Öppna projektet i VS Code eller Visual Studio
cd C:\Users\rober\source\repos\test verifiering certifiering\CalculatorTdd\

# 2. Kör den färdiga applikationen
dotnet run

# 3. Skapa testprojekt (om du vill följa övningen)
cd ..
dotnet new xunit -n CalculatorTdd.Tests
dotnet new sln -n CalculatorTdd
dotnet sln add CalculatorTdd/CalculatorTdd.csproj
dotnet sln add CalculatorTdd.Tests/CalculatorTdd.Tests.csproj
cd CalculatorTdd.Tests
dotnet add reference ../CalculatorTdd/CalculatorTdd.csproj
cd ..

# 4. Kör tester
dotnet test
```

---

## ?? Snabbtips

### För eleverna som är snabba
- Ge dem utmaningarna i README.md (Power, SquareRoot, etc.)
- Låt dem para ihop med någon som ligger efter
- Be dem göra code review på varandras kod

### För eleverna som har svårt
- Para ihop med en snabbare elev (pair programming)
- Ge dem FACIT.md så de kan komma ikapp
- Fokusera på att de förstår KONCEPTET, inte att de blir klara

### Vanliga problem
| Problem | Lösning |
|---------|---------|
| "Testet kompilerar inte" | Kontrollera projekt-referens (STEG 1) |
| "dotnet test hittar inga tester" | Klassen/metoden måste vara `public` |
| "Jag kan inte commita" | Konfigurera Git: `git config --global user.name "Namn"` |

---

## ?? Bedömning - Snabbversion

### **Godkänd (G)**
- Skapat testprojekt ?
- Minst 3 av 5 operationer med tester ?
- Följt TDD ?
- Commits för huvudstegen ?

### **Väl Godkänd (VG)**
- Alla G-kriterier ?
- Alla 5 operationer ?
- Theory + InlineData ?
- Edge cases + exceptions ?
- Refaktorering ?
- Minst 1 bonus-uppgift ?

---

## ?? Uppföljning

### Nästa lektion - förslag
1. **Mockning och Dependencies** - Testa kod med externa beroenden
2. **Integration Testing** - Skillnad mot unit tests
3. **TDD i praktiken** - Eget projekt med TDD

### Långsiktigt
- Låt TDD vara en del av alla projekt framöver
- Code review-sessioner där studenter granskar varandras tester
- Diskutera code coverage och testpyramiden

---

## ?? Support

Om du har frågor:
1. Kolla **LÄRARGUIDE.md** för detaljerad info
2. Se **FACIT.md** för komplett lösning
3. Kontakta andra lärare som undervisat TDD

---

## ? Key Takeaways för dig

Detta är en **heltäckande övning** som:
- ? Täcker TDD från grunden
- ? Har steg-för-steg instruktioner
- ? Inkluderar Git-versionshantering
- ? Ger både teori och praktik
- ? Passar för yrkeshögskola nivå (systemutvecklare år 2)
- ? Tar ~3-4 timmar att genomföra
- ? Har tydliga bedömningskriterier

**Du är redo att hålla lektionen!** ??

---

## ?? Nästa steg för dig

1. [ ] Läs igenom LÄRARGUIDE.md
2. [ ] Genomför övningen själv (valfritt men rekommenderat)
3. [ ] Förbered intro-presentation (slides)
4. [ ] Dela ut README.md och GIT_COMMIT_GUIDE.md till eleverna
5. [ ] Boka datorsal med .NET 9 SDK installerat
6. [ ] Håll lektionen! ??

**Lycka till - dina elever kommer älska TDD efter detta!** ??
