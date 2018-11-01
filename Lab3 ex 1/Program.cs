using System;

namespace Lab3_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabNrb = new int[300];
            bool fermer = false;
            int resultatAdd = 0;

            int TrouverPlusGrandNrb()
            {
                int bonNrbPlus = 1;
                int nrbtestPlus = tabNrb[0];

                for (int i = 0; i < tabNrb.Length; i++)
                {
                    nrbtestPlus = tabNrb[i];

                    if (nrbtestPlus > bonNrbPlus)
                    {
                        bonNrbPlus = nrbtestPlus;
                    }
                }
                return bonNrbPlus;
            }

            int TrouverPlusPetitNrb()
            {
                int bonNrbMoin = 10001;
                int nrbtestMoin = tabNrb[0];

                for (int i = 0; i < tabNrb.Length; i++)
                {
                    nrbtestMoin = tabNrb[i];

                    if (nrbtestMoin < bonNrbMoin)
                    {
                        bonNrbMoin = nrbtestMoin;
                    }
                }
                return bonNrbMoin;
            }

            string TrouverNrbTab(int _nrbCase3)
            {

                string repCase3 = "";

                for (int i = 0; i < tabNrb.Length; i++)
                {

                    if (_nrbCase3 == tabNrb[i])
                    {
                        repCase3 = "est";
                    }
                }
                return repCase3;
            }

            float CalculerMoyenneTab()
            {

                for (int i = 0; i < tabNrb.Length; i++)
                {
                    resultatAdd += tabNrb[i];
                }
                float resultatMoy = (float)resultatAdd / (float)tabNrb.Length;

                return resultatMoy;
            }

            for (int i = 0; i < tabNrb.Length; i++)
            {
                Random gen = new Random();
                int ranNrb = gen.Next(1, 10001);

                tabNrb[i] = ranNrb;
            }

            while (fermer == false)
            {
                int nrbCase3 = 0;
                string repCase3HorsF = "";
                int plusPNrbAfficher = 0;
                int plusGNrbAfficher = 0;




                Console.WriteLine("Votre tableau a été créé. ");
                Console.WriteLine("");
                Console.WriteLine("Que voulez vous faire? ");
                Console.WriteLine("");
                Console.WriteLine("1-Trouver le plus grand nombre");
                Console.WriteLine("2-Trouver le plus petit nombre");
                Console.WriteLine("3-Vérifier qu'un nombre est dans votre tableau");
                Console.WriteLine("4-Faire la moyenne du tableau");
                Console.WriteLine("5-Fermer le programme");


                int choix = 0;

                choix = Convert.ToInt32(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        plusGNrbAfficher = TrouverPlusGrandNrb();
                        Console.WriteLine("Le plus grand nombre de votre tableau est " + plusGNrbAfficher);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        plusPNrbAfficher = TrouverPlusPetitNrb();
                        Console.WriteLine("Le plus petit nombre de votre tableau est " + plusPNrbAfficher);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Quel nombre voulez vous vérifier?");
                        nrbCase3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        repCase3HorsF = TrouverNrbTab(nrbCase3);
                        if (repCase3HorsF == "est")
                        {
                            Console.WriteLine("Ce nombre " + repCase3HorsF + " dans le tableau");
                        }
                        else if (repCase3HorsF != "est")
                        {
                            Console.WriteLine("Ce nombre n'est pas dans le tableau");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine("la moyenne de votre tableau est " + CalculerMoyenneTab());
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        fermer = true;
                        break;

                }
            }

            Console.Clear();
            Console.WriteLine("Appuyer sur une touche pour fermer le programme");


            Console.ReadKey();





        }
    }
}
