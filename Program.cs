namespace LitleConsolGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sen = " ☻ ", zemin = " * ", senCevre = " ♦ ";
            int senSutun = 1, toplamSutun = 10;
            int senSatir = 1, toplamSatir = 10;

            bool sol = (senSutun == 1);
            //bool solCevre = (senKonum != satir );
            bool solUst = (senSutun == 1 && senSatir == 1);
            bool solUstCevre = ((senSutun == 1 && senSatir == 2) || (senSutun == 2 && senSatir == 1) || (senSutun == 2 && senSatir == 2));

            bool alt = (senSatir == toplamSatir);

            bool solAlt = (senSutun == 1 && senSatir == toplamSatir);
            bool solAltCevre = ((senSutun == 1 && senSatir == toplamSatir-1) || (senSutun == 2 && senSatir == toplamSatir - 2) || (senSutun == 2 && senSatir == toplamSatir));

            bool sag = (senSutun == toplamSutun);

            bool sagUst = (senSutun == toplamSutun && senSatir == 1);
            bool sagUstCevre = ((senSutun == toplamSutun && senSatir == 2) || (senSutun == toplamSutun-1 && senSatir == 1) || (senSutun == toplamSutun && senSatir == toplamSatir-1));

            bool ust = (senSatir == 1);

            bool sagAlt = (senSutun == toplamSutun && senSatir == toplamSatir);
            bool sagAltCevre = ((senSutun == toplamSutun-1 && senSatir == toplamSatir) || (senSutun == toplamSutun - 1 && senSatir == toplamSatir-1) || (senSutun == toplamSutun - 1 && senSatir == toplamSatir));
            


            while (true)
            {
                Console.Clear();
                for (int satir = 1; satir <= toplamSatir; satir++)
                {
                    for (int sutun = 1; sutun <= toplamSutun; sutun++)
                    {
                        bool senKonum = satir == senSatir && sutun == senSutun;

                        //if (senKonum == altCevre) Console.Write(senCevre);
                        //if (senKonum == ustCevre) Console.Write(senCevre);
                        //if (senKonum == sagCevre) Console.Write(senCevre);
                        //if (senKonum == solCevre) Console.Write(senCevre);
                        //if (senKonum == sagAltCevre) Console.Write(senCevre);
                        //if (senKonum == sagUstCevre) Console.Write(senCevre);
                        //if (senKonum == solAltCevre) Console.Write(senCevre);
                        //if (senKonum == solUstCevre) Console.Write(senCevre);
                        

                        if (senKonum) Console.Write(sen);
                        else Console.Write(zemin);
                    }
                    Console.WriteLine();
                }
                ConsoleKey basilanTus = Console.ReadKey().Key;

                if (basilanTus == ConsoleKey.UpArrow    && senSatir != 1) senSatir--;
                if (basilanTus == ConsoleKey.DownArrow  && senSatir != toplamSatir) senSatir++;
                if (basilanTus == ConsoleKey.LeftArrow  && senSutun != 1) senSutun--;
                if (basilanTus == ConsoleKey.RightArrow && senSutun != toplamSutun) senSutun++;
                //if (basilanTus == ConsoleKey.NumPad1    && senSatir != toplamSatir && senSutun != 1) senSatir--; senSutun--;
                if (basilanTus == ConsoleKey.NumPad2    && senSatir != toplamSatir) senSatir++;
                //if (basilanTus == ConsoleKey.NumPad3    && senSatir != toplamSatir && senSutun != toplamSutun) senSatir++; senSutun++;
                if (basilanTus == ConsoleKey.NumPad4    && senSutun != 1) senSutun--;
                //if (basilanTus == ConsoleKey.NumPad5) 
                if (basilanTus == ConsoleKey.NumPad6    && senSutun != toplamSutun) senSutun++;
                //if (basilanTus == ConsoleKey.NumPad7    && senSatir != 1 && senSutun != 1) senSatir--; senSutun--;
                if (basilanTus == ConsoleKey.NumPad8    && senSatir != 1) senSatir--;
                //if (basilanTus == ConsoleKey.NumPad9    && senSatir != 1 && senSutun !=toplamSutun ) senSatir--; senSutun++;

            }
        }
    }
}   