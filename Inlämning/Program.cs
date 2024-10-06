//using System;

string input = "29535123p48723487597645723645";
long sum = 0; // hjälper till att hålla summan av alla tal vi hittar
int length = input.Length;

for (int i = 0; i < length; i++)
{
    if (char.IsDigit(input[i]))
    {
        for (int j = i + 2; j < length; j++)
        {
            if (char.IsDigit(input[j]) && input[i] == input[j])
            {
                bool isValid = true;

                // Kontrollera om de inre siffrorna är unika
                for (int k = i + 1; k < j; k++)
                {
                    if (!char.IsDigit(input[k]) || input[k] == input[i])
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    string number = input.Substring(i, j - i + 1);

                    // Skriv ut strängen innan numret
                    Console.Write(input.Substring(0, i));

                    // Byt färg för numret som matchar kriterierna
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(number);
                    Console.ResetColor();

                    // Skriv ut resten av strängen
                    Console.WriteLine(input.Substring(j + 1));

                    // Lägg till talet till summan
                    sum += long.Parse(number);
                    break;
                }
            }
        }
    }
}

// Sist men inte minst skriver vi ut summan
Console.WriteLine("Summa = {0} ", sum);
Console.WriteLine("Tryck på en tangent för att avsluta!");
Console.ReadKey();
