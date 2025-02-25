
                                                     // CI/CD-pipeline - Slutuppgift //




------------------------------------------------------------

// PersonnummerValidator:

Detta projekt �r en C#-konsolapplikation som validerar svenska personnummer enligt den svenska standarden. 
Programmet kontrollerar om ett personnummer �r korrekt genom att verifiera formatet och genomf�ra en Luhn-algoritmber�kning (Luhn-algoritmen anv�nds f�r att ber�kna och validera kontrollsiffran).

------------------------------------------------------------------------

// K�ra lokalt:

// Klona detta repository:

git clone https://github.com/ditt-anvandarnamn/PersonnummerValidator.git

cd PersonnummerValidator

// Bygg och k�r programmet:

dotnet build

dotnet run

// Ange ett personnummer.

// Programmet validerar och visar om personnumret �r giltigt eller inte.



----------------------------------------------------------
// K�ra med Docker:


docker build -t personnummervalidator 

docker run -it personnummervalidator

// H�mta och k�r containern fr�n DockerHub:

docker pull ditt-anvandarnamn/personnummer-validator

docker run -it ditt-anvandarnamn/personnummer-validator

--------------------------------------------------------



// Svenska personnummer f�ljer ett specifikt format och en kontrollsumma:

Format: ��MMDD-XXXX (exempel: 800101-1234)

De f�rsta 6 siffrorna representerar f�delsedatum (��MMDD)

De sista 4 siffrorna (XXXX) inneh�ller en individnummer och en kontrollsiffra



------------------------------------------------------------

// K�ra enhetstester med NUnit:

// Terminal:

cd PersonnummerValidator.Tests

dotnet test



















