using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ΠΑΙΧΝΙΔΙ ΜΑΝΤΕΨΕ ΤΟΝ ΑΡΙΘΜΟ");
        Console.WriteLine("Ο υπολογιστης επιλέγει τυχαία έναν Αριθμό απο το 1 ερως το 100 και ο χρήστης πρέπει να τον μαντέψει");
        PlayGame();
    }

    public static void PlayGame()
    {
        bool Win = false;
        int ComputerNumber = 0;
        int Counter = 1;
        ComputerNumber = RandomNumber();
        do
        {
            int PlayerNumber = CheckInput();
            Win = CheckIfWin(ComputerNumber, PlayerNumber);
            if (!Win)
            {
                Counter++;
            }
            else
            {
                Console.WriteLine("Συγχαρητήρια!!! Τον βρήκες με " + Counter + " Πεοσπάθειες");
                break;
            }
        } while (!Win);
        Console.WriteLine("Τέλος Παιχνιδιου!!");
        Console.ReadKey();
    }

    public static int RandomNumber()
    {
        Random random = new Random();
        return random.Next(1,100);
    }

    public static int CheckInput()
    {
        bool isNumber = false;
        int PlayerNumber = 0;
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
            Console.WriteLine("Ο Αριθμπος του Υπολογιστή είναι μικρότερος απο αυτός που έδωσες");
        }else
        {
            Console.WriteLine("Ο Αριθμπος του Υπολογιστή είναι μεγαλύτερος απο αυτός που έδωσες");
        }
        return false;
    }
}