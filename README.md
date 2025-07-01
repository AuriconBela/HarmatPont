# Harmatpont Számológép

.NET 8 C# konzol alkalmazás és Python vizualizáció a levegő harmatpontjának kiszámítására.

## 🎯 Funkciók

### C# Konzol Alkalmazás (`/HarmatPont`)
- Interaktív harmatpont számológép
- Hőmérséklet és páratartalom bemenet validációval
- Magnus formula implementálás
- Többszöri számítás lehetősége
- Színes konzol kimenet

### Python Vizualizáció (`/Visualization`)
- 3D felületgrafikon a harmatpont függvényről
- Interaktív Jupyter Notebook
- 2D kontúr grafikonok
- Különböző nézőpontok
- Statikus matplotlib grafikonok

## 🚀 Gyors kezdés

### C# alkalmazás futtatása
```bash
cd HarmatPont
dotnet run
```

### Python vizualizáció
```bash
cd Visualization
# Nyisd meg a harmatpont_3d_vizualizacio.ipynb fájlt VS Code-ban vagy Jupyter-ben
```

## 📊 Magnus Formula

A harmatpont számításához a meteorológiában használt Magnus formulát alkalmazzuk:

- **a = 17.62**
- **b = 243.12 °C**

```
α = (a × T) / (b + T) + ln(RH/100)
Harmatpont = (b × α) / (a - α)
```

Ahol:
- T = hőmérséklet (°C)
- RH = relatív páratartalom (%)

## 🛠️ Technológiák

- **.NET 8** - C# konzol alkalmazás
- **Python 3.11+** - Vizualizáció
- **Matplotlib** - 3D és 2D grafikonok
- **NumPy** - Numerikus számítások
- **Jupyter** - Interaktív notebook

## 📁 Projekt struktúra

```
HarmatPont/
├── HarmatPont/           # C# konzol alkalmazás
│   ├── Program.cs        # Fő alkalmazás
│   ├── HarmatPont.csproj # Projekt fájl
│   └── README.md         # C# dokumentáció
├── Visualization/        # Python vizualizáció
│   ├── harmatpont_3d_vizualizacio.ipynb  # Jupyter notebook
│   └── README.md         # Python dokumentáció
├── .gitignore           # Git kizárások
└── README.md            # Fő dokumentáció
```

## 🎮 Használat

### C# Alkalmazás
1. Indítsd el a `dotnet run` paranccsal
2. Add meg a hőmérsékletet (°C)
3. Add meg a relatív páratartalmat (0-100%)
4. Látod a harmatpont eredményt
5. Választhatsz újabb számítást vagy kilépést

### Python Vizualizáció
1. Nyisd meg a notebook-ot
2. Futtasd le a cellákat sorrendben
3. Láthatod a 3D felületet és 2D kontúrokat
4. Vizsgáld a harmatpont függvényt különböző nézőpontokból

## 📈 Példa eredmények

- **20°C, 60% RH** → Harmatpont: **12.00°C**
- **25°C, 70% RH** → Harmatpont: **19.15°C**
- **10°C, 80% RH** → Harmatpont: **6.71°C**

## 🤝 Hozzájárulás

1. Fork-old a repót
2. Hozz létre egy feature branch-et
3. Commitold a változásokat
4. Push-old a branch-et
5. Hozz létre Pull Request-et

## 📄 Licenc

Ez a projekt MIT licenc alatt áll.
