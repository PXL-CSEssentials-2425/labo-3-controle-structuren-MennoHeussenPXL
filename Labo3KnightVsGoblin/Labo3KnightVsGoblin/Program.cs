Console.WriteLine("Welcome to Knight VS Goblin!");
Console.WriteLine("----------------------------");

Random randomNumberGenerator = new Random();

Console.WriteLine("Enter Knight Healt: ");
string input = Console.ReadLine();

int attempts = 0;

int knightHealt;
if (int.TryParse(input, out knightHealt))
{
    if (0 > knightHealt || knightHealt > 100)
    {
        Console.WriteLine("Invalid input, delfault healt 100 is used");
        knightHealt = 100;
    }
}
else
{
    Console.WriteLine("Invalid input, delfault healt 100 is used");
    knightHealt = 100;
}


int goblinHealt = randomNumberGenerator.Next(30, 101);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Knight healt: {knightHealt}");
Console.WriteLine($"Goblin healt: {goblinHealt}");
Console.ResetColor();

//for(int attempts = 1; attempts <= 4 ; attempts++)
do 
{
    attempts += attempts; 
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Ronde: {attempts}");
    Console.ResetColor();
    int attackKnight = 10;
    int attackGoblin = randomNumberGenerator.Next(5, 16); ;

    Console.WriteLine("Enter: 1 to attack, 2 to heal");
    string number = Console.ReadLine();

    Console.WriteLine("You're Turn");

    switch (number)
    {
        case "1":
            goblinHealt -= attackKnight;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"You attacked Goblin by {attackKnight}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Knight healt: {knightHealt}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Goblin healt: {goblinHealt}(-{attackKnight})");
            Console.ResetColor();
            break;
        case "2":
            knightHealt += 10;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"You Healed by {10}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Knight healt: {knightHealt}(+10)");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Goblin healt: {goblinHealt}");
            Console.ResetColor();
            break;
        default:
            Console.WriteLine($"{number} is Invalid!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Knight healt: {knightHealt}");
            Console.WriteLine($"Goblin healt: {goblinHealt}");
            Console.ResetColor();
            break;
    }


    Console.WriteLine("Goblin's Turn");
    System.Threading.Thread.Sleep(1000);

    if (goblinHealt > 0)
    {
        knightHealt -= attackGoblin;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Goblin attacked you by {attackGoblin}");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Knight healt: {knightHealt}(-{attackGoblin})");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Goblin healt: {goblinHealt}");
        Console.ResetColor();
    }


    if (goblinHealt <= 0)
    {
        Console.WriteLine("Goblin Died! \nYou Won!!");
    }


    if (knightHealt <= 0)
    {
        Console.WriteLine("You Died!");
    }
} while (knightHealt > 0 && goblinHealt > 0);




/* 
 * Deel 1
 * 
 * We gaan een applicatie maken waarin de speler als ridder tegen een goblin moet vechten.
 * We starten met een controle te implementeren die kijkt of de speler nog leeft.
 *  - Declareer en initialiseer een waarde knightHealth (0) en goblinHealth (20).
 *  - Indien de levenspunten van de speler (knightHealth) kleiner of gelijk zijn aan nul,
 *    dan toon je aan de speler dat hij/zij is gestorven. 
 *  - Doe hetzelfde voor de goblin.
 *  - Extra: gebruik de Random klasse om de levenspuntenvan de ridder en goblin in te stellen.
 */

/* 
 * Deel 2
 * 
 * - Indien de speler niet gestorven is, dan druk je af hoeveel levenspunten (knightHealth) 
 *   speler nog heeft. Gebruik hier else voor.
 * - Laat de speler zelf levenspunten ingeven voor de ridder (knightHealth). Zo kiest elke speler 
 *   zelf hoe moeilijk het gevecht is. 
 * - De waarde knightHealth moeten tussen 0 en 100. Indien de speler een ongeldige waarde ingeeft, 
 *   dan wordt de standaard waarde 100 gebruikt.
 *    - Extra: gebruik TryParse om de input van de speler te verwerken, 
 *      zodat het programma niet zal crashen.
 */

/*
 * Deel 3
 * 
 * Declareer en initialiseer een aanvalswaarde voor de ridder, attackKnight (10), 
 * en de goblin, attackGoblin (5).
 * Laat de speler een actie selecteren door een getal in te geven. Gebruik een switch:
 *  - Als ik als speler actie 1 kies, dan val ik aan en wordt attackKnight afgetrokken van 
 *    goblinHealth. Beschrijf in de output wat er gebeurt.
 *  - Als ik als speler actie 2 kies, dan genees ik mezelf 10 levenspunten. Beschrijf in de 
 *    output wat er gebeurt.
 *  - Als de speler een ongeldige actie ingeeft, dan weergeef je dit in de output.
 *  - Extra: voeg extra acties toe die de speler kan kiezen.
 *  - Extra: zorg er voor dat de goblin ook een actie neemt.
 */

/*
 * Deel 4
 * 
 * Gebruik een for lus, zodat de speler exact 4 keer een actie kan selecteren.
 */

/*
 * Deel 5
 * 
 * Vervang de for lus door een while lus die vraagt aan de speler om een actie 
 * uit te voeren zolang als de ridder of goblin nog leeft.
 * 
 * Extra: zorg er voor dat de goblin ook een actie neemt.
 */
