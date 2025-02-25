
// CI/CD-pipeline - Slutuppgift //

------------------------------------------------------------

// PersonnummerValidator:

Detta projekt är en C#-konsolapplikation som validerar svenska personnummer enligt den svenska standarden. 
Programmet kontrollerar om ett personnummer är korrekt genom att verifiera formatet och genomföra en Luhn-algoritmberäkning (Luhn-algoritmen används för att beräkna och validera kontrollsiffran).

------------------------------------------------------------------------

// Köra lokalt:

// Klona detta repository:

git clone https://github.com/ditt-anvandarnamn/PersonnummerValidator.git

cd PersonnummerValidator

// Bygg och kör programmet:

dotnet build

dotnet run

// Ange ett personnummer.

// Programmet validerar och visar om personnumret är giltigt eller inte.



----------------------------------------------------------
// Köra med Docker:


docker build -t personnummervalidator 

docker run -it personnummervalidator

// Hämta och kör containern från DockerHub:

docker pull ditt-anvandarnamn/personnummer-validator

docker run -it ditt-anvandarnamn/personnummer-validator

--------------------------------------------------------



// Svenska personnummer följer ett specifikt format och en kontrollsumma:

Format: ÅÅMMDD-XXXX (exempel: 800101-1234)

De första 6 siffrorna representerar födelsedatum (ÅÅMMDD)

De sista 4 siffrorna (XXXX) innehåller en individnummer och en kontrollsiffra



------------------------------------------------------------

// Köra enhetstester med NUnit:

Terminal:

cd PersonnummerValidator.Tests

dotnet test



















