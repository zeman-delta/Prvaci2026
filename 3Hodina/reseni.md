# Řešení – 3. hodina

Algoritmy jsou zapsané jako vývojové diagramy, tak jak bychom je sestavili v RAPTORu.

## Použité značky

| Tvar | RAPTOR | Význam |
|---|---|---|
| ovál | Start / End | začátek a konec programu |
| kosodélník nakloněný **doprava**, modrý | Input (GET) | načtení hodnoty od uživatele |
| kosodélník nakloněný **doleva**, červený | Output (PUT) | výpis na obrazovku |
| obdélník | Assignment | přiřazení do proměnné |
| kosočtverec | Selection | rozhodnutí, větve **Ano** / **Ne** |

Vstup a výstup se tedy rozlišují sklonem i barvou stejně jako v RAPTORu.
Malé šipky, které RAPTOR kreslí do boku těchto značek, se v Markdownu nakreslit nedají –
směr toku dat ale určuje hlavní šipka mezi značkami.

Šipka `←` znamená přiřazení (v C# `=`).
`mod` je zbytek po dělení (v C# `%`), `floor` je zaokrouhlení dolů (celočíselné dělení).

---

# Úloha 1

Uživatel zadá délku dvou stran obdélníku. Program vypočítá jeho obvod.

```mermaid
flowchart TD
    S([Start]) --> V1[/"Zadej stranu a"/]
    V1 --> V2[/"Zadej stranu b"/]
    V2 --> P["obvod ← 2 * (a + b)"]
    P --> O[\"Vypiš obvod"\]
    O --> K([Konec])

    classDef vstup stroke:#1e88e5,stroke-width:2px
    classDef vystup stroke:#e53935,stroke-width:2px
    class V1,V2 vstup
    class O vystup
```

---

# Úloha 2

Uživatel zadá cenu nákupu. Pokud cena dosáhne alespoň 2 000 Kč, získá zákazník slevu 10 %.
Program zobrazí výslednou cenu.

```mermaid
flowchart TD
    S([Start]) --> V[/"Zadej cenu nákupu"/]
    V --> D{"cena ≥ 2000 ?"}
    D -->|Ano| A["vysledna ← cena * 0,9"]
    D -->|Ne| B["vysledna ← cena"]
    A --> O[\"Vypiš vysledna"\]
    B --> O
    O --> K([Konec])

    classDef vstup stroke:#1e88e5,stroke-width:2px
    classDef vystup stroke:#e53935,stroke-width:2px
    class V vstup
    class O vystup
```

---

# Úloha 3

Uživatel zadá dvě čísla. Program zobrazí větší z nich.
Nezapomeň se zamyslet také nad případem, kdy jsou obě čísla stejná.

```mermaid
flowchart TD
    S([Start]) --> V1[/"Zadej číslo a"/]
    V1 --> V2[/"Zadej číslo b"/]
    V2 --> D1{"a > b ?"}
    D1 -->|Ano| O1[\"Vypiš: větší je a"\]
    D1 -->|Ne| D2{"a < b ?"}
    D2 -->|Ano| O2[\"Vypiš: větší je b"\]
    D2 -->|Ne| O3[\"Vypiš: čísla jsou stejná"\]
    O1 --> K([Konec])
    O2 --> K
    O3 --> K

    classDef vstup stroke:#1e88e5,stroke-width:2px
    classDef vystup stroke:#e53935,stroke-width:2px
    class V1,V2 vstup
    class O1,O2,O3 vystup
```

*Pozor: dvě podmínky za sebou, ne jedna. Kdyby byla jen `a > b`, případ rovnosti by spadl do větve „větší je b“.*

---

# Úloha 4

Uživatel zadá počet získaných bodů. Maximální počet je 100.
Pokud student získal alespoň 50 bodů, program zobrazí „Splnil“. V opačném případě „Nesplnil“.

```mermaid
flowchart TD
    S([Start]) --> V[/"Zadej počet bodů"/]
    V --> D{"body ≥ 50 ?"}
    D -->|Ano| O1[\"Vypiš: Splnil"\]
    D -->|Ne| O2[\"Vypiš: Nesplnil"\]
    O1 --> K([Konec])
    O2 --> K

    classDef vstup stroke:#1e88e5,stroke-width:2px
    classDef vystup stroke:#e53935,stroke-width:2px
    class V vstup
    class O1,O2 vystup
```

---

# Úloha 5

Uživatel má zadat číslo od 1 do 10. Pokud zadá hodnotu mimo tento interval,
program ho musí požádat o nové zadání. Opakování pokračuje tak dlouho,
dokud uživatel nezadá platnou hodnotu.

```mermaid
flowchart TD
    S([Start]) --> V[/"Zadej číslo od 1 do 10"/]
    V --> D{"cislo ≥ 1 a zároveň cislo ≤ 10 ?"}
    D -->|Ne| V
    D -->|Ano| O[\"Vypiš: zadáno platné číslo"\]
    O --> K([Konec])

    classDef vstup stroke:#1e88e5,stroke-width:2px
    classDef vystup stroke:#e53935,stroke-width:2px
    class V vstup
    class O vystup
```

*Šipka zpět do načítání je celá smyčka. Všimni si, že se vrací na vstup, ne na začátek programu.*

---

# Úloha 6

Uživatel zadá teplotu ve stupních Celsia. Program ji převede na stupně Fahrenheita
a výsledek vypíše. Platí vztah F = C * 1,8 + 32.

```mermaid
flowchart TD
    S([Start]) --> V[/"Zadej teplotu ve stupních Celsia"/]
    V --> P["F ← C * 1,8 + 32"]
    P --> O[\"Vypiš F"\]
    O --> K([Konec])

    classDef vstup stroke:#1e88e5,stroke-width:2px
    classDef vystup stroke:#e53935,stroke-width:2px
    class V vstup
    class O vystup
```

---

# Úloha 7

Uživatel zadá poloměr kruhu. Program vypočítá a vypíše jeho obvod a obsah.
Pro číslo pí použij Math.PI.

```mermaid
flowchart TD
    S([Start]) --> V[/"Zadej poloměr r"/]
    V --> P1["obvod ← 2 * π * r"]
    P1 --> P2["obsah ← π * r * r"]
    P2 --> O[\"Vypiš obvod a obsah"\]
    O --> K([Konec])

    classDef vstup stroke:#1e88e5,stroke-width:2px
    classDef vystup stroke:#e53935,stroke-width:2px
    class V vstup
    class O vystup
```

---

# Úloha 8

Uživatel zadá celé číslo. Program vypíše, zda je sudé, nebo liché.

```mermaid
flowchart TD
    S([Start]) --> V[/"Zadej celé číslo n"/]
    V --> P["zbytek ← n mod 2"]
    P --> D{"zbytek = 0 ?"}
    D -->|Ano| O1[\"Vypiš: číslo je sudé"\]
    D -->|Ne| O2[\"Vypiš: číslo je liché"\]
    O1 --> K([Konec])
    O2 --> K

    classDef vstup stroke:#1e88e5,stroke-width:2px
    classDef vystup stroke:#e53935,stroke-width:2px
    class V vstup
    class O1,O2 vystup
```

---

# Úloha 9

Uživatel zadá číslo. Program vypíše, jestli je kladné, záporné, nebo nula.

```mermaid
flowchart TD
    S([Start]) --> V[/"Zadej číslo n"/]
    V --> D1{"n > 0 ?"}
    D1 -->|Ano| O1[\"Vypiš: kladné"\]
    D1 -->|Ne| D2{"n < 0 ?"}
    D2 -->|Ano| O2[\"Vypiš: záporné"\]
    D2 -->|Ne| O3[\"Vypiš: nula"\]
    O1 --> K([Konec])
    O2 --> K
    O3 --> K

    classDef vstup stroke:#1e88e5,stroke-width:2px
    classDef vystup stroke:#e53935,stroke-width:2px
    class V vstup
    class O1,O2,O3 vystup
```

---

# Úloha 10

Uživatel zadá svůj věk a program vypíše cenu vstupenky do kina.
Základní vstupné je 180 Kč, ale děti do 15 let a lidé od 65 let platí polovinu.

```mermaid
flowchart TD
    S([Start]) --> V[/"Zadej věk"/]
    V --> D{"vek < 15 nebo vek ≥ 65 ?"}
    D -->|Ano| A["cena ← 90"]
    D -->|Ne| B["cena ← 180"]
    A --> O[\"Vypiš cenu vstupenky"\]
    B --> O
    O --> K([Konec])

    classDef vstup stroke:#1e88e5,stroke-width:2px
    classDef vystup stroke:#e53935,stroke-width:2px
    class V vstup
    class O vystup
```

---

# Úloha 11

Uživatel zadá počet minut. Program ho převede na hodiny a minuty
a vypíše například ve tvaru „135 minut = 2 h 15 min“.

```mermaid
flowchart TD
    S([Start]) --> V[/"Zadej počet minut"/]
    V --> P1["hodiny ← floor(minuty / 60)"]
    P1 --> P2["zbyleMinuty ← minuty mod 60"]
    P2 --> O[\"Vypiš hodiny a zbyleMinuty"\]
    O --> K([Konec])

    classDef vstup stroke:#1e88e5,stroke-width:2px
    classDef vystup stroke:#e53935,stroke-width:2px
    class V vstup
    class O vystup
```

*Celočíselné dělení dá hodiny, zbytek po dělení minuty. V C# to `/` mezi dvěma `int` udělá samo.*

---

# Úloha 12

Uživatel zadá počet bodů z testu (maximum je 100). Program vypíše známku:
100–90 bodů je 1, 89–75 je 2, 74–60 je 3, 59–50 je 4 a méně než 50 je 5.

```mermaid
flowchart TD
    S([Start]) --> V[/"Zadej počet bodů"/]
    V --> D1{"body ≥ 90 ?"}
    D1 -->|Ano| Z1["znamka ← 1"]
    D1 -->|Ne| D2{"body ≥ 75 ?"}
    D2 -->|Ano| Z2["znamka ← 2"]
    D2 -->|Ne| D3{"body ≥ 60 ?"}
    D3 -->|Ano| Z3["znamka ← 3"]
    D3 -->|Ne| D4{"body ≥ 50 ?"}
    D4 -->|Ano| Z4["znamka ← 4"]
    D4 -->|Ne| Z5["znamka ← 5"]
    Z1 --> O[\"Vypiš známku"\]
    Z2 --> O
    Z3 --> O
    Z4 --> O
    Z5 --> O
    O --> K([Konec])

    classDef vstup stroke:#1e88e5,stroke-width:2px
    classDef vystup stroke:#e53935,stroke-width:2px
    class V vstup
    class O vystup
```

*Podmínky testujeme odshora dolů, proto stačí vždy jen dolní mez. Horní mez hlídá předchozí větev.*

---

# Úloha 13

Uživatel zadá tři čísla. Program vypíše největší z nich.
Opět si rozmysli, co se má stát, když jsou některá čísla stejná.

```mermaid
flowchart TD
    S([Start]) --> V[/"Zadej čísla a, b, c"/]
    V --> P["max ← a"]
    P --> D1{"b > max ?"}
    D1 -->|Ano| A1["max ← b"]
    D1 -->|Ne| D2{"c > max ?"}
    A1 --> D2
    D2 -->|Ano| A2["max ← c"]
    D2 -->|Ne| O[\"Vypiš max"\]
    A2 --> O
    O --> K([Konec])

    classDef vstup stroke:#1e88e5,stroke-width:2px
    classDef vystup stroke:#e53935,stroke-width:2px
    class V vstup
    class O vystup
```

*Postup „zatím největší je a, zkus ho přebít“ je lepší než porovnávat všechny dvojice. Při rovnosti se max nepřepíše a vyjde správný výsledek.*

---

# Úloha 14

Uživatel má zadat svůj věk, tedy číslo od 0 do 120.
Pokud zadá hodnotu mimo tento rozsah, program ho požádá o nové zadání
a opakuje to tak dlouho, dokud nedostane platnou hodnotu.

```mermaid
flowchart TD
    S([Start]) --> V[/"Zadej věk od 0 do 120"/]
    V --> D{"vek ≥ 0 a zároveň vek ≤ 120 ?"}
    D -->|Ne| V
    D -->|Ano| O[\"Vypiš: věk přijat"\]
    O --> K([Konec])

    classDef vstup stroke:#1e88e5,stroke-width:2px
    classDef vystup stroke:#e53935,stroke-width:2px
    class V vstup
    class O vystup
```

---

# Úloha 15

Uživatel postupně zadává čísla. Jakmile zadá 0, zadávání skončí
a program vypíše součet všech zadaných čísel.

```mermaid
flowchart TD
    S([Start]) --> P0["soucet ← 0"]
    P0 --> V[/"Zadej číslo"/]
    V --> D{"cislo = 0 ?"}
    D -->|Ne| P1["soucet ← soucet + cislo"]
    P1 --> V
    D -->|Ano| O[\"Vypiš soucet"\]
    O --> K([Konec])

    classDef vstup stroke:#1e88e5,stroke-width:2px
    classDef vystup stroke:#e53935,stroke-width:2px
    class V vstup
    class O vystup
```

*Proměnná `soucet` se musí vynulovat **před** smyčkou. Kdyby byla uvnitř, vynulovala by se při každém průchodu.*
