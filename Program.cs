namespace LitleConsolGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string sen = " ☻ " , zemin = " * ", senCevre = " ♦ ";
            int senSutun = 6, toplamSutun = 10;
            int senSatır = 5, toplamSatir = 10;
            //int senKonum
            
            bool solUst = (senSutun == 1 && senSatır == 1);
            bool solUstCevre = ((senSutun == 1 && senSatır == 2) || (senSutun == 2 && senSatır == 1) || (senSutun == 2 && senSatır == 2));

            bool solAlt = (senSutun == 1 && senSatır == toplamSatir);
            bool solAltCevre = ((senSutun == 1 && senSatır == toplamSatir-1) || (senSutun == 2 && senSatır == toplamSatir - 2) || (senSutun == 2 && senSatır == toplamSatir));

            bool sagUst = (senSutun == toplamSutun && senSatır == 1);
            bool sagUstCevre = ((senSutun == toplamSutun && senSatır == 2) || (senSutun == toplamSutun-1 && senSatır == 1) || (senSutun == toplamSutun && senSatır == toplamSatir-1));

            bool sagAlt = (senSutun == toplamSutun && senSatır == toplamSatir);
            bool sagAltCevre = ((senSutun == toplamSutun-1 && senSatır == toplamSatir) || (senSutun == toplamSutun - 1 && senSatır == toplamSatir-1) || (senSutun == toplamSutun - 1 && senSatır == toplamSatir));
            while (true)
            {

            for (senSutun = 1; senSutun < toplamSutun; senSutun++)
            {

                for (senSatır = 1; senSatır < toplamSatir; senSatır++)
                {
                    if (senSatır == 1 && senSutun == 1)
                    {
                        Console.Write( sen );
                        //if (senKonum == sagAltCevre) Console.WriteLine(senCevre);
                      

                    }
                    
                    else Console.Write(zemin);
                }
                    Console.WriteLine(zemin);
            }
            ConsoleKey kullaniciYon = Console.ReadKey().Key;

            } 




            //Console.Clear();
        } 
    }

}