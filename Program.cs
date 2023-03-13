namespace LitleConsolGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sen = " ☻ ", zemin = " * ", senCevre = " ♦ ";
            int senSutun = 1, toplamSutun = 10;
            int senSatir = 1, toplamSatir = 10;
           

            while (true)
            {
                Console.Clear();
                for (int satir = 1; satir <= toplamSatir; satir++)
                {
                    for (int sutun = 1; sutun <= toplamSutun; sutun++)
                    {
                         bool senMi = satir == senSatir && sutun == senSutun;
                        #region Köşeler
                        #region Sol Üst Köşe
                        bool senSolUstKonum = senSatir == 1 && senSutun == 1;
                        bool senSolUstCevre = (satir == 1 && sutun == 2) || 
                                              (satir == 2 && sutun == 1) ||
                                              (satir == 2 && sutun == 2);
                        #endregion
                        #region Sol Alt Köşe
                        bool senSolAltKonum = senSatir == toplamSatir && senSutun == 1;
                        bool senSolAltCevre = (satir == toplamSatir -1 && sutun == 1) ||
                                              (satir == toplamSatir -1 && sutun == 2) ||
                                              (satir == toplamSatir && sutun == 2);
                        #endregion
                        #region Sag Üst Köşe
                        bool senSagUstKonum = senSatir == 1 && senSutun == toplamSutun;
                        bool senSagUstCevre = (satir == 1 && sutun == toplamSutun) ||
                                              (satir == 2 && sutun == toplamSutun - 1) ||
                                              (satir == 2 && sutun == toplamSutun - 1);
                        #endregion
                        #region Sag Alt Köşe
                        bool senSagAltKonum = senSatir == toplamSatir && senSutun == toplamSutun;
                        bool senSagAltCevre = (satir == toplamSatir - 1 && sutun == toplamSutun) ||
                                              (satir == toplamSatir - 1 && sutun == toplamSutun - 1) ||
                                              (satir == toplamSatir && sutun == toplamSutun - 1);
                        #endregion
                        #endregion
                        #region Kenarlar
                        #region ÜstAltKenar
                        bool senUstKenarKonum = senSatir == 1 && senSutun > 1 && senSutun < toplamSutun;
                        bool senAltKenarKonum = senSatir == toplamSatir && senSutun > 1 && senSutun < toplamSutun;

                        bool senUstAltKenarCevre =
                                          satir == senSatir && (sutun == senSutun - 1 || sutun == senSutun + 1) ||
                                         (satir == senSatir + 1 || satir == senSatir - 1) && sutun == senSutun ||
                                         (satir == senSatir + 1 || satir == senSatir - 1) && sutun == senSutun + 1;
                        #endregion
                        #region SolKenar
                        bool senSolKenarKonum = (senSatir > 1 && senSatir < toplamSatir) && senSutun == 1;

                        bool senSolKenarCevre = (sutun == senSutun || sutun == senSutun + 1 ) &&
                                                ((satir == senSatir - 1 && sutun == senSutun) ||
                                                (satir == senSatir - 1 && sutun == senSutun + 1) ||
                                                (satir == senSatir && sutun == senSutun + 1) ||
                                                (satir == senSatir + 1 && sutun == senSutun) ||
                                                (satir == senSatir + 1 && sutun == senSutun + 1));

                        #endregion
                        #region SagKenar
                        bool senSagKenarKonum = (senSatir > 1 && senSatir < toplamSatir) && senSutun == toplamSutun;

                        bool senSagKenarCevre = (sutun == toplamSutun || sutun == toplamSutun - 1) &&
                                        ((satir == senSatir - 1 && sutun == senSutun) ||
                                        (satir == senSatir - 1 && sutun == senSutun - 1) ||
                                        (satir == senSatir && sutun == senSutun - 1) ||
                                        (satir == senSatir + 1 && sutun == senSutun - 1) ||
                                        (satir == senSatir + 1 && sutun == senSutun ));
                        #endregion
                        #endregion
                        #region Orta
                        bool senOrtaKonum = senSatir > 1 && senSatir < toplamSatir && senSutun > 1 && senSutun < toplamSutun;

                        bool senOrtaCevre = (satir == senSatir - 1 && sutun == senSutun - 1) ||
                                            (satir == senSatir - 1 && sutun == senSutun) ||
                                            (satir == senSatir - 1 && sutun == senSutun + 1) ||
                                            (satir == senSatir && sutun == senSutun - 1) ||
                                            (satir == senSatir && sutun == senSutun + 1) ||
                                            (satir == senSatir + 1 && sutun == senSutun - 1) ||
                                            (satir == senSatir + 1 && sutun == senSutun) ||
                                            (satir == senSatir + 1 && sutun == senSutun + 1);

                        #endregion
                        #region Çevremi
                        bool cevreMi = (senSolUstKonum && senSolUstCevre) ||
                                       (senSolAltKonum && senSolAltCevre) ||
                                       (senSagUstKonum && senSagUstCevre) ||
                                       (senSagAltKonum && senSagAltCevre) ||
                                       ((senSolUstKonum || senSagAltKonum) && senUstAltKenarCevre) ||
                                       (senSolKenarKonum && senSolKenarCevre) ||
                                       (senSagKenarKonum && senSagKenarCevre) ||
                                       (senOrtaCevre);
                        #endregion


                        if (senMi) Console.Write(sen);
                        else if (cevreMi)Console.Write(senCevre);
                        else Console.Write(zemin);
                    }
                    Console.WriteLine();
                }
                ConsoleKey basilanTus = Console.ReadKey().Key;

                if (basilanTus == ConsoleKey.NumPad1 && senSatir != toplamSatir && senSutun != 1) { senSatir++; senSutun--; }
                if (basilanTus == ConsoleKey.NumPad2 || basilanTus == ConsoleKey.DownArrow && senSatir != toplamSatir) senSatir++;
                if (basilanTus == ConsoleKey.NumPad3 && senSatir != toplamSatir && senSutun != toplamSutun) { senSatir++; senSutun++; }
                if (basilanTus == ConsoleKey.NumPad4 || basilanTus == ConsoleKey.LeftArrow && senSutun != 1) senSutun--;
                //if (basilanTus == ConsoleKey.NumPad5) 
                if (basilanTus == ConsoleKey.NumPad6 || basilanTus == ConsoleKey.RightArrow && senSutun != toplamSutun) senSutun++;
                if (basilanTus == ConsoleKey.NumPad7 && senSatir != 1 && senSutun != 1) { senSatir--; senSutun--; }
                if (basilanTus == ConsoleKey.NumPad8 || basilanTus == ConsoleKey.UpArrow && senSatir != 1) senSatir--;
                if (basilanTus == ConsoleKey.NumPad9 && senSatir != 1 && senSutun != toplamSutun) { senSatir--; senSutun++; }

               
            }
        }
    }
} 