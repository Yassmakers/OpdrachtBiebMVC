# C# Opdracht Bibliotheeksysteem

#### Handleiding voor de ASP.NET Core Web App Bibliotheekbeheersysteem
#### Deze handleiding beschrijft de installatie en het gebruik van de Bibliotheekbeheersysteem-applicatie. Volg de onderstaande instructies om de applicatie op te zetten en te gebruiken.

## (Bekijk ook graag de aanvullende opmerkingen voor de beoordelaars.)
Inhoudsopgave
- <a href="#installatie" target="_new">Installatie</a>

- <a href="#inloggegevens" target="_new">Inloggegevens</a>
- <a href="#systeemvereisten" target="_new">Systeemvereisten</a>
- <a href="#database-migratie" target="_new">Database migratie</a>
- <a href="#gebruikershandleiding" target="_new">Gebruikershandleiding</a>
  - <a href="#inloggen" target="_new">Inloggen</a>
  - <a href="#navigatie" target="_new">Navigatie</a>
    - <a href="#items-zoeken" target="_new">Items zoeken</a>
    - <a href="#items-beheren" target="_new">Items beheren</a>
    - <a href="#leningen-beheren" target="_new">Leningen beheren</a>
    - <a href="#Reserveringen-beheren" target="_new">Reserveringen beheren</a>
    - <a href="#gebruikeraccounts-beheren" target="_new">Gebruikeraccounts beheren</a>
- <a href="#screenshots" target="_new">screenshots</a>    
- <a href="#aanvullende-opmerkingen" target="_new">Aanvullende opmerkingen</a>


# Installatie

- Kloon de Git-repository of download en pak het zip-bestand uit.
- Open het project in Visual Studio.
- Controleer of de juiste NuGet-pakketten zijn geïnstalleerd.
- Update de database commando: "dotnet ef database update"
- Compileer en voer het project uit --> (bekijk eerst ##Inloggegevens).


## Inloggegevens

### Gebruik de volgende inloggegevens om toegang te krijgen tot het systeem

#### (hoofdlettergevoelig) :

#### Beheerder - Administrator:

    Email = admin@example.com
    Wachtwoord: AdminPassword1!
Medewerker - Librarian:

    Email = librarian@example.com
    Wachtwoord: LibrarianPassword1!

Gast:

    Email = member@example.com
    Wachtwoord: MemberPassword1!

Systeemvereisten

- .NET 6
- MVC
- Entity Framework Core 7


# Database migratie ( Dit alleen doen als de migrations map ontbreekt en het migrations niet inlaad, als je het gewoon clean pulled werkt het wel)

Voordat u de applicatie uitvoert, mocht de applicatie niet werken omdat u nog geen migrations map ziet kunt u de database migreren. Dit zijn de stappen om dat te doen:

- Open het project in Visual Studio.
- Open de NuGet Package Manager Console via Tools > NuGet Package Manager > Package Manager Console.
- Voer het volgende commando uit:

       dotnet ef migrations add <migration-name>

  Voer daarna dit commando uit:

      dotnet ef database update


Na het uitvoeren van de database migratie, kunt u het project opnieuw compileren en uitvoeren.

## Gebruikershandleiding

### Inloggen

- #### Open de applicatie en u ziet het beginscherm met eronder staan login.

- #### Voer uw e-mailadres in het veld "Email" in.

- #### Voer uw wachtwoord in het veld "Password" in.

- #### Klik op de knop "Login" om in te loggen met uw gebruikersgegevens.

- #### Als u niet wilt inloggen kunt u de applicatie blijven bekijken als gast, hiervoor hoeft u niks te doen. Hierdoor kunt u de applicatie gebruiken zonder in te loggen met een gebruikersaccount. Houd er echter rekening mee dat sommige functies mogelijk niet beschikbaar zijn voor gastgebruikers.

### Navigatie

- #### Zoek / Filter Optie: Alle items opzoeken op titel of auteur in de zoekbalk, daarnaast de mogelijkheid om te kunnen filteren op itemtype, locatie, uitgavejaar etc.
- #### Items: Beheer alle items in de bibliotheek, zoals boeken, cd's, dvd's, Blu-rays en games.

- #### Reserveringen: Beheer de reserveringen van items in de bibliotheek.

- #### Leningen: Beheer de Leningen van items in de bibliotheek.

- #### Gebruikers: Beheer de accounts van bibliotheekbeheerders, gebruikers en medewerkers.

### Items Zoeken

- Tik de zoekbalk aan en toets je gewenste titel of auteurnaam in.

### Items beheren

- Klik op het tabblad 'Items' om de lijst met items te bekijken.
- Klik op 'Nieuw item' om een nieuw item aan de lijst toe te voegen.
  Vul de gegevens van het nieuwe item in, selecteer een auteur uit de vervolgkeuzelijst en klik op 'Opslaan'.
- Klik op 'Locatie toevoegen' om de locatie voor een item toe te voegen en klik op 'Opslaan'.
- Klik op 'Locatie Verwijderen' om de locatie van een bestaande locatie te verwijderen klik op 'Bevestig'.
- Klik op 'Bewerken' om de gegevens van een item bij te werken en klik op 'Opslaan'.
- Klik op 'Verwijderen' om een item uit de lijst te verwijderen.


### Leningen beheren

- Klik op het tabblad 'Leningen' om de lijst met leningen te bekijken.
- Klik op 'Nieuwe Lening' om een nieuwe lening aan de lijst toe te voegen.
  Vul de gegevens van de nieuwe auteur in en klik op 'Opslaan'.

- Klik op 'Verwijderen' om een lening uit de lijst te verwijderen.


### Reserveringen beheren

- Klik op het tabblad 'Reserveringen' om de lijst met leningen te bekijken.
- Klik op 'Nieuwe Reservering' om een nieuwe Reservering aan de lijst toe te voegen.
  Vul de gegevens van de nieuwe auteur in en klik op 'Opslaan'.

- Klik op 'Verwijderen' om een Reservering uit de lijst te verwijderen.

### Gebruikeraccounts beheren 

- Klik op 'Nieuwe gebruiker' om een nieuw gebruikersaccount aan te maken.
  Vul de gegevens van de nieuwe gebruiker in en klik op 'Opslaan'.
- Klik op 'Blokkeren' om het account van een gebruiker te blokkeren.

- Klik op 'Bewerken' om de gegevens van een gebruiker bij te werken zoals de betalingsstand en klik op 'Opslaan'.
- Klik op 'Verwijderen' om een gebruiker uit de lijst te verwijderen.


# Screenshots
https://gyazo.com/ea033d2435365793bf2794625b93965f

https://gyazo.com/921f51f066f88ac326e27c5ab8af13b1

# Aanvullende opmerkingen

#### - Ik wil graag vermelden dat ik dit project alleen heb gemaakt, omdat ik geen teamlid heb kunnen vinden en het gevoel had dat mijn vorige teamlid niet actief heeft bijgedragen. Het was jammer dat ik geen samenwerking kon ervaren en ik heb dit project daarom zonder hulp moeten bouwen. Ik hoop dat er begrip is voor deze situatie en dat er coulanter naar mijn individuele prestaties gekeken kan worden bij de beoordeling.

> 👨‍🎓 **Yassine Messaoudi**
>
> - S-number: s1188088
> - Email: s1188088@student.windesheim.nl
> - Github: [@Yassineprojects](https://github.com/Yassmakers)
