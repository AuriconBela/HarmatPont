# Harmatpont 3D Vizualizáció

Ez a mappa tartalmazza a harmatpont függvény 3D és 2D vizualizációját Jupyter Notebook formájában.

## Fájlok

- `harmatpont_3d_vizualizacio.ipynb` - Jupyter Notebook a 3D vizualizációval

## Futtatás

1. Nyisd meg a notebook-ot VS Code-ban
2. Válaszd ki a Python kernelt
3. Futtasd le a cellákat sorrendben

## Vizualizációk

A notebook a következő grafikonokat tartalmazza:

1. **3D felületgrafikon** - Hőmérséklet (X), Páratartalom (Y), Harmatpont (Z)
2. **2D kontúr grafikonok** - Kitöltött kontúrvonalak és izovonalak

## Szükséges csomagok

- `numpy` - Numerikus számítások
- `matplotlib` - Grafikonok készítése

## Magnus Formula

A harmatpont számításához a Magnus formulát használjuk:
- a = 17.62
- b = 243.12 °C

## Paraméter tartományok

- **Hőmérséklet**: -10°C - +40°C
- **Relatív páratartalom**: 10% - 100%
