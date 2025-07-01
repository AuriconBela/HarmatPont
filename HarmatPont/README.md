# Harmatpont Számológép

Ez egy .NET 8 C# konzol alkalmazás, amely kiszámolja a levegő harmatpontját a hőmérséklet és relatív páratartalom alapján.

## Funkciók

- Bekéri a felhasználótól a levegő hőmérsékletét Celsius fokban
- Bekéri a relatív páratartalmat százalékban (0-100% között)
- Kiszámolja a harmatpontot
- Megjeleníti az eredményt

## Használat

```bash
dotnet run
```

## Validáció

- Hőmérséklet: nincs korlátozás (pozitív vagy negatív értékek is elfogadottak)
- Páratartalom: 0-100% között kell lennie

## Harmatpont számítás

Jelenleg a Magnus formula közelítését használja:
- a = 17.62
- b = 243.12 °C

A pontos képlet később kerül implementálásra a specifikáció szerint.

## Példa futtatás

```
Harmatpont Számológép
=====================

Adja meg a levegő hőmérsékletét (°C): 20
Adja meg a relatív páratartalmat (%): 60

A harmatpont: 11,99 °C
```
