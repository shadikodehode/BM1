bool isRunning = true;



while (isRunning)

{

    Console.WriteLine("Velkommen til programmet!");

    Console.WriteLine("Velg et alternativ:");

    Console.WriteLine("1. Si hei");

    Console.WriteLine("2. Avslutt");



    string input = Console.ReadLine();



    switch (input)

    {

        case "1":

            Console.WriteLine("Hei der!");

            break;

        case "2":

            Console.WriteLine("Avslutter programmet...");

            isRunning = false;

            break;

        default:

            Console.WriteLine("Ugyldig valg, prøv igjen.");

            break;

    }

}