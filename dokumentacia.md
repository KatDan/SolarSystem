# SolarSystem - simulátor pohybu planét Slnečnej sústavy
zápočtový program, letný semester 2018/2019
<br>

Program má za úlohu simulovať pohyb planét Slnečnej sústavy a vykresľovať trajektóriu ich pohybu v čase. Vzdialenosti medzi objektami, excentricity ich dráh a ich hmotnosti sú skutočné hodnoty*, pre lepšiu vizualizáciu sú však jemne upravené pomery veľkostí týchto objektov, aby bol zážitok z pozorovania simulácie čo najlepší.

Čas je meraný v pozemských dňoch a rokoch, zobrazuje sa v ľavom hornom rohu nami viditeľného vesmíru. Počas používania programu je odporúčané nepodliehať panike.



## Používateľské rozhranie
Používateľ má možnosť meniť chod simulácie pomocou:

 - tlačidlo **"Start the simulation"** - na začiatku vykreslí počiatočnú pozíciu sústavy. 
 Predvolene sú viditeľné všetky objekty SLnečnej sústavy, preto sú aj veľmi malé.
 
 - tlačidlo **"Start"/"Stop"** - rozhýbe/zastaví pohyb planét.
 - tlačidlo **"Reset"** - vráti sústavu do pôvodného stavu, t.j. objekty sa znovu nachádzajú na štartovacích pozíciách. Na štartovacie pozície sa sústava dostane automaticky aj po zmenení "Rendering options", módu alebo viditeľnosti objektov a ich trajektorií.
 - tlačidlo **"Mode"** - mení vzťažnú sústavu. Na začiatku je pohyb objektov vykresľovaný vzhľadom k Slnku, po prepnutí režimu sa objekty pohybujú vzhľadom k Zemi.
 - box **Visible objects** - po odškrtnutí daný objekt zmizne spolu aj s jeho stopou. Po opätovnom zaškrtnutí sa objekt znovu objaví (bez stopy, tú si treba potom zaškrtnúť dodatočne). Predvolene sú viditeľné všetky objekty. **Po zmiznutí najvzdialenejšieho objektu sa veľkosť zvyšných objektov automaticky preškáluje, aby boli čo najlepšie viditeľné **(ale zároveň si stále zachovali vzájomné pomery veľkostí).
 - box **Visible trace** - zapína/vypína viditeľnú stopu daného objektu. Predvolene sú zapnuté stopy všetkých objektov.
 - box **Rendering options**:
   - **Speed** - mení rýchlosť vykreslenia novej pozície. Je možné prepínať medzi rýchlosťami 10 ms, 100 ms a 1000 ms.
   - **Accuracy** - upravuje presnosť výpočtov novej pozície. Predvolene je dt = 20000 s,  je však možné nastaviť hodnotu na 5000-5000000 s. Pri práci so vzdialenejšími planétami je dostačujúca menšia presnosť výpočtu. Pri práci s viditeľnými len blízkymi planétami je ale potrebné presnosť zvýšiť. Ak je pri blízkych planétach zvolená prislabá presnosť, môžu byť planéty nemilosrdne katapultované do zabudnutia. So zmenou presnosti sa mení aj samotná rýchlosť planét - čím vyššia presnosť, tým pomalšie sa objekty pohybujú.

Prajeme príjemnú zábavu!



*Dáta použité na chod Slnečnej sústavy sú čerpané z textového súboru "planety.txt", používateľ si v prípade záujmu môže vstupné údaje upraviť na fiktívne.
