﻿using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
        ChangeColor();
        Console.WriteLine("ΠΑΙΧΝΙΔΙ ΜΑΝΤΕΨΕ ΤΟΝ ΑΡΙΘΜΟ");
        Console.WriteLine("Ο υπολογιστης επιλέγει τυχαία έναν Αριθμό απο το 1 εως το 100 και ο χρήστης πρέπει να τον μαντέψει");
        PlayGame();
    }

    public static void ChangeColor()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
    }

    public static void PlayGame()
    {
        int ComputerNumber = RandomNumber();
        int Counter = 1;
        do
        {
            int PlayerNumber = CheckInput();
            bool results = CheckIfWin(ComputerNumber, PlayerNumber);
            if (!results)
            {
                Counter++;
                continue;
            }
            else
            {
                Console.WriteLine("Συγχαρητήρια!!! Τον βρήκες με " + Counter + " Προσπάθειες");
                break;
            }
        } while (true);
        Console.WriteLine("Τέλος Παιχνιδιου!!");
        GameInfo();
        Console.Read();
    }

    public static int RandomNumber()
    {
        Random random = new();
        return random.Next(1,100);
    }

    public static int CheckInput()
    {
        bool isNumber = false;
        int PlayerNumber;
        do
        {
            Console.WriteLine("Διάλεξε έναν Αριθμό απο το 1 εως το 100");
            string? PlayerN = Console.ReadLine();
            isNumber = int.TryParse(PlayerN, out PlayerNumber);
        } while (!isNumber  || PlayerNumber<=0 || PlayerNumber>100);
        return PlayerNumber;
    }

    public static bool CheckIfWin(int ComputerNumber, int  PlayerNumber)
    {
        if (ComputerNumber == PlayerNumber)
        {
            return true;
            
        }
        Console.WriteLine("Δεν τον Βρήκεες Ξαναδοκιμασε");
        if (ComputerNumber < PlayerNumber)
        {
            Console.WriteLine("Ο Αριθμός του Υπολογιστή είναι μικρότερος απο αυτόν που έδωσες");
        }else
        {
            Console.WriteLine("Ο Αριθμός του Υπολογιστή είναι μεγαλύτερος απο αυτόν που έδωσες");
        }
        return false;
    }

    public static void GameInfo()
    {
        Console.WriteLine("Το παίχνιδι αυτό φιάχτηκε για εκπαιδευτικούς σκοπούς");
        Console.WriteLine("Όνομα Προγραμματιστή : ΨΑλτάκης Νικόλαος");
        Console.WriteLine("(C) 06/2023 using .NET");
    }
}