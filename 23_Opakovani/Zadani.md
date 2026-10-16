# Opakování – podmínky, switch, Random

# A) Složené podmínky a negace

## Úloha 1 – Vstupenka do kina
Uživatel zadá svůj věk a jestli je student (`a` / `n`).
Děti do 6 let a lidé od 65 let mají vstup zdarma.
Studenti do 26 let platí 90 Kč, ostatní 180 Kč. Program vypíše cenu vstupenky.

## Úloha 2 – Přestupný rok
Uživatel zadá rok. Program vypíše, zda je přestupný.
Rok je přestupný, pokud je dělitelný 4 a zároveň není dělitelný 100,
nebo pokud je dělitelný 400.
Pro kontrolu: 2024 je přestupný, 1900 není, 2000 je.

## Úloha 3 – Trojúhelník
Uživatel zadá délky tří stran. Program zjistí, zda z nich lze sestrojit trojúhelník
(součet každých dvou stran musí být větší než třetí strana).
Pokud ano, vypíše, zda je trojúhelník rovnostranný, rovnoramenný, nebo obecný.

## Úloha 4 – Není víkend
Uživatel zadá číslo dne v týdnu (1–7). Pokud **není** víkend (6 nebo 7),
program vypíše „Do školy!“, jinak „Hurá, víkend!“. Použij negaci `!`.
Bonus: napiš podmínku jednou s `!( ... || ... )` a jednou bez negace.
Proč fungují obě?

## Úloha 5 – Přihlášení
V programu je uložené uživatelské jméno a heslo. Uživatel obojí zadá. Program vypíše:
- „Přihlášeno“, pokud sedí jméno i heslo,
- „Špatné heslo“, pokud sedí jen jméno,
- „Uživatel neexistuje“ ve všech ostatních případech.

## Úloha 6 – Interval
Uživatel zadá číslo. Program vypíše, zda leží v intervalu ⟨10; 20⟩.
Dále vypíše, zda leží **mimo** interval ⟨-5; 5⟩.
Druhou podmínku napiš jednou s negací `!` a jednou bez ní.

# B) Switch

## Úloha 7 – Známka slovy
Uživatel zadá známku 1–5. Program ji vypíše slovy (výborně, chvalitebně, dobře,
dostatečně, nedostatečně). Pro jiné číslo vypíše „Neplatná známka“.

## Úloha 8 – Kalkulačka
Uživatel zadá dvě čísla a operátor (`+`, `-`, `*`, `/`, `%`).
Program provede výpočet pomocí `switch` a vypíše výsledek.
Ošetři dělení nulou a neznámý operátor.

## Úloha 9 – Počet dní v měsíci
Uživatel zadá číslo měsíce (1–12). Program vypíše, kolik dní měsíc má.
Využij toho, že více `case` může vést na stejný kód.
Bonus: pro únor se zeptej na rok a použij podmínku z úlohy 2.

## Úloha 10 – Roční období
Uživatel zadá název měsíce slovem (např. „leden“). Program vypíše roční období.
Použij `switch` nad textem (`string`).

# C) Random

Připomínka: `Random rnd = new Random();` a `rnd.Next(1, 7)` vrací čísla 1 až 6
(horní mez se do rozsahu nezapočítává).

## Úloha 11 – Hod kostkou
Program hodí dvěma kostkami a vypíše obě čísla i jejich součet.
Pokud padla dvě stejná čísla, vypíše „Dublet!“. Pokud padly dvě šestky, vypíše „Jackpot!“.
Pozor na pořadí podmínek.

## Úloha 12 – Hádej číslo
Počítač si vylosuje číslo 1–10. Uživatel má jeden pokus na uhodnutí.
Program vypíše „Trefa!“, „Těsně vedle“ (pokud se liší o 1),
nebo „Vedle, bylo to X“.
Tip: rozdíl spočítáš pomocí `Math.Abs`.

## Úloha 13 – Kámen, nůžky, papír
Počítač náhodně zvolí 0, 1 nebo 2 (kámen, nůžky, papír) a pomocí `switch`
převede volbu na text. Uživatel zadá svou volbu.
Program vypíše obě volby a vyhodnotí výhru, prohru, nebo remízu.

## Úloha 14 – Předpověď počasí
Program vylosuje teplotu od -10 do 35 °C a počasí (0 = slunečno, 1 = déšť, 2 = sníh).
Podle kombinace vypíše doporučení, co si obléct.
Ošetři i nesmyslné kombinace (např. sníh při 30 °C) – vypiš „Divné počasí!“.

# D) Pro rychlejší

## Úloha 15 – Kouzelná osmička
Uživatel napíše otázku. Počítač vylosuje číslo 1–8 a pomocí `switch` vybere odpověď
(např. „Určitě ano“, „Spíš ne“, „Zeptej se později“…).
Pokud uživatel nezadá žádnou otázku, program vypíše „Nezeptal ses!“
(použij `string.IsNullOrEmpty`).

## Úloha 16 – Bankomat
Na účtu je náhodný zůstatek 0–5000 Kč. Uživatel zadá částku k výběru.
Výběr se zamítne, pokud částka není kladná, není dělitelná 100,
nebo je větší než zůstatek. Program vypíše konkrétní důvod zamítnutí,
nebo nový zůstatek po výběru.

## Úloha 17 – Souboj
Hráč i nepřítel dostanou náhodný útok (1–20) a náhodnou obranu (1–10).
Poškození = útok soupeře − vlastní obrana (záporné poškození se počítá jako 0).
Pokud někdo hodí útok 20, jde o kritický zásah a jeho poškození se zdvojnásobí.
Program vypíše všechny hodnoty a kdo kolo vyhrál (případně remízu).
