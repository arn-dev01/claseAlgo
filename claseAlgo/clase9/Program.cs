int i;

string currentChar;
int digitChar = 0;







do
{
    Console.WriteLine("Ingrese una frase que desee encriptar");
    string frase = Console.ReadLine()!.ToLower();
    string[] encrypt = new string[frase.Length];
    for (i = 0; i < frase.Length; i++)
    {
        currentChar = frase.Substring(i, 1);


        switch (currentChar)
        {
            case "a":
            case "b":
            case "c":
                digitChar = 2;
                break;

            case "d":
            case "e":
            case "f":
                digitChar = 3;
                break;

            case "g":
            case "h":
            case "i":
                digitChar = 4;
                break;

            case "j":
            case "k":
            case "l":
                digitChar = 5;
                break;
            case "m":
            case "n":
            case "o":
                digitChar = 6;
                break;

            case "p":
            case "q":
            case "r":
            case "s":
                digitChar = 7;
                break;

            case "t":
            case "u":
            case "v":
                digitChar = 8;
                break;

            case "x":
            case "y":
            case "z":
                digitChar = 9;
                break;

            case " ":
                digitChar = 0;
                break;

            default:
                digitChar = 1;
                break;

        }

        encrypt[i] = digitChar.ToString();



    }

    for (i = 0; i < encrypt.Length; i++)
    {
        Console.Write(encrypt[i]);
    }


    Console.WriteLine("\nPresione cualquier tecla para continuar");
    Console.WriteLine("Pulse ESC si desea salir\n");

} while (Console.ReadKey().Key != ConsoleKey.Escape);



