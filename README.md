# DesignPattern

 Designmönster: Factory Pattern

Beskrivning:
Jag valde Factory Pattern för att skapa olika produkttyper (t.ex. "Bok", "Elektronik") i en e-handelsapp. Mönstret gör det enkelt att lägga till nya produktkategorier utan att ändra befintlig kod, vilket förbättrar systemets flexibilitet och underhållbarhet.

Use Case:
När en användare väljer en produktkategori (t.ex. "Böcker"), anropas en fabrik som genererar rätt produkttyp med relevanta egenskaper (t.ex. författare, ISBN).

User Story:
"Som kund vill jag kunna se olika produkttyper med unika detaljer (t.ex. författare för böcker, märke för elektronik), så att jag får rätt information för mitt köpbeslut."

Algoritm 1: Binär sökning

Anledning:
Jag valde binär sökning för att snabbt hitta produkter efter ID i en sorterad lista. Algoritmen har en tidskomplexitet på O(log n), vilket är mycket effektivt jämfört med linjär sökning (O(n)).

Algoritm 2: Quicksort

Anledning:
Jag implementerade Quicksort för att sortera produkter efter pris. Den har en genomsnittlig tidskomplexitet på O(n log n), vilket är optimalt för större dataset.

Struktur & Kvalitet

Factory Pattern separerar produktskapande från huvudlogiken, vilket minskar kodduplicering.
Binär sökning säkerställer snabb produktsökning i stora dataset.
Quicksort optimerar sortering av produkter efter pris.
