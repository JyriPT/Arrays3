using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kaikki tehtävät tehty yhteen, tehtävien tarkistus tehdään valikon kautta
            string input;
            Console.WriteLine("Select the assignment you wish to check (number 1-3):");
            Console.WriteLine("");
            //Laitetaan käyttäjän valinta string arvoon
            input = Console.ReadLine();
            Console.WriteLine("");
            //Käsitellään edellä annettu arvo.
            //Jos mahdollista muuttaa int arvoksi, tarkistetaan mikä numero.
            //Jos annettu arvo ei ole numero väliltä 1-3, mitään ei tapahdu.
            if (int.TryParse(input, out int select) == true)
            {
                //Tehtävä 1 valinta
                if (select == 1)
                {
                    //Alustetaan taulukko
                    Random rnd = new Random();
                    int[] taulukko = new int[10];

                    //Syötetään taulukkoon 10 lukua
                    for (int i = 0; i < 10; i++)
                    {
                        int add = rnd.Next(0, 21);
                        taulukko[i] = add;
                    }

                    //Tulostetaan taulukko, luodaan muuttujaa järjestysluvun seuraamista varten
                    Console.WriteLine("[X] = Arvo");
                    int track = 0;

                    //Loopissa tarkistetaan onko luku pienempi kuin 10, jos on niin lisätään 0 sen eteen
                    foreach (int i in taulukko)
                    {
                        if (i < 10)
                        {
                            Console.WriteLine($"[{track}] = 0{i}");
                        } else
                        {
                            Console.WriteLine($"[{track}] = {i}");
                        }

                        track++;
                    }

                }
                //Tehtävä 2 valinta
                else if (select == 2)
                {
                    //Alustetaan taulukko
                    Random rnd = new Random();
                    int[,] taulukko = new int[10,20];

                    //Lisätään taulukkoon arvot, käydään läpi 2 for-looppia
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            taulukko[i, j] = rnd.Next(0, 101);
                        }
                    }

                    //Tulostetaan taulukko, alustetaan int-arvot järjestysnumeroiden seurantaa varten
                    Console.WriteLine("[X, Y] = Arvo");
                    int trackX = 0;
                    int trackY = 0;

                    //Käydään taulukko läpi, tarkistetaan onko numero piennempi kuin 10, lisätään nolla eteen tarpeen mukaan
                    foreach (int i in taulukko)
                    {
                        if (i < 10)
                        {
                            Console.WriteLine($"[{trackX}, {trackY}] = 0{i}");
                        } else
                        {
                            Console.WriteLine($"[{trackX}, {trackY}] = {i}");
                        }

                        trackY++;

                        //Seurantanumeroiden päivitystä, jos Y menee "yli", nollataan ja nostetaan X arvo
                        if (trackY == 20)
                        {
                            trackY = 0;
                            trackX++;
                        }
                    }
                }
                //Tehtävä 3 valinta
                else if (select == 3)
                {

                }
            }
            else
            {
                Console.WriteLine("Invalid selection, please reboot.");
            }
        }
    }
}
