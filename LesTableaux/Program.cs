﻿using System;

namespace LesTableaux
{
    class Program
    {

        static void getEtudiantsClasse(int numero, Etudiant[][] tab)
        {
            Console.WriteLine("Eleves de la classe : {0}", numero);
            foreach (Etudiant e in tab[numero])
            {
                Console.WriteLine(e.ToString());
            }
        }
        
        static void Main(string[] args)
        {
            /*
            Etudiant e1 = new Etudiant(1,"Alain",15.5);
            Etudiant e2 = new Etudiant(2, "Olivier", 17.5);
            Etudiant e3 = new Etudiant(3, "Mathieu", 12.5);
            Etudiant e4 = new Etudiant(4, "Claude", 11.5);

            Etudiant[] tab = new Etudiant[4];
            tab[0] = e1;
            tab[1] = e2;
            tab[2] = e3;
            tab[3] = e4;
            foreach (Etudiant e in tab)
            {
                Console.WriteLine(e.ToString());
            }

            // Affichage la meilleure moyenne
            double MeilleureMoyenne = tab[0].get_moyenne();
            int MeilleurePos = 0;

            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i].get_moyenne() > MeilleureMoyenne)
                {
                    MeilleureMoyenne = tab[i].get_moyenne();
                    MeilleurePos = i;
                }
            }

            Console.WriteLine("\nL'étudiant avec la meilleure moyenne est {0}", tab[MeilleurePos].ToString());


            */
            Etudiant[][] tabClasses = new Etudiant[3][];
            tabClasses[0] = new Etudiant[2];
            tabClasses[1] = new Etudiant[3];
            tabClasses[2] = new Etudiant[6];

            // remplissage de tabClasses[0]
            for (int i = 0; i < tabClasses[0].Length; i++)
            {
                tabClasses[0][i] = new Etudiant(i, "a-" + i, 12);
            }

            // remplissage de tabClasses[1]
            for (int i = 0; i < tabClasses[1].Length; i++)
            {
                tabClasses[1][i] = new Etudiant(i, "b-" + i, 14);
            }

            // remplissage de tabClasses[2]
            for (int i = 0; i < tabClasses[2].Length; i++)
            {
                tabClasses[2][i] = new Etudiant(i, "c-" + i, 13);
            }

            int k = 1;
            foreach (Etudiant[] tab in tabClasses)
            {

                Console.WriteLine("Eleve de la classe : {0} ", k);
                foreach (Etudiant e in tab)
                {
                    Console.WriteLine(e.ToString());
                }
                k++;
                    
            }

            int index = 0;

            getEtudiantsClasse(index, tabClasses);
            // Partie 2



            //Console.WriteLine("Vous êtes : {0}", e1.ToString());
            /*
            int compteur = 0;
            int x = 100;
            compteur++;

            compteur = compteur + 2;
            Console.WriteLine("La valeur de compteur = {0}", compteur);
            Console.WriteLine("La valeur de x = {0}", x);
            Console.WriteLine("Fin du programme.");*/
        }
    }
}
