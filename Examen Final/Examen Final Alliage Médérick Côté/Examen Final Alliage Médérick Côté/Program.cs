using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final_Alliage_Médérick_Côté
{
    class Program
    {
        public struct Metaux
        {
            public string nom;
            public int resistance;
            public int pointDeFusion;
            public int poid;
            public int conductivite;
            
            public Metaux (string _nom,int _resistance,int _pointdefusion,int _poid,int _conductivité) : this()
            {
                nom = _nom;
                resistance = _resistance;
                pointDeFusion = _pointdefusion;
                poid = _poid;
                conductivite = _conductivité;
            } 

        }
        static void Main(string[] args)
        {
            Metaux[] tabmetaux = new Metaux[4];
            tabmetaux[0] = new Metaux("Fer",7,9,4,3);
            tabmetaux[1] = new Metaux("Cuivre",4,8,8,2);
            tabmetaux[2] = new Metaux("Plomb",1,3,7,2);
            tabmetaux[3] = new Metaux("Zinc",2,5,3,6);
            AfficherListeMetaux(ref tabmetaux);
            AfficherMenu();
            int choixMenu = Convert.ToInt32(Console.ReadLine());
            switch (choixMenu)
            {
                case 1: AfficherMResistance(ref tabmetaux); break;
                case 2: AfficherMScore(ref tabmetaux); break;
                case 3: AfficherSiConductivite6(ref tabmetaux); break;
                case 4: CreerMetaux(ref tabmetaux); break;
                case 5:; break;
                default: Console.WriteLine("Cette option n'est pas valide, veuillez réessayer"); break;
            }
            Console.ReadKey(); 
        }
        static void AfficherMResistance (ref Metaux[] tabmetaux)
        {
            int meillResistance = 0;
            int pos = 0;
            for (int i = 0; i < tabmetaux.Length; i++)
            {
                if (tabmetaux[i].resistance > meillResistance )
                {
                    meillResistance = tabmetaux[i].resistance -=5;
                    pos = i; 
                }
            }
            Console.WriteLine("Le Métal ayant le plus d'attaque est le no "
                + (pos + 1) + " ayant " + meillResistance + " la meilleur");
        }
        static void AfficherMScore(ref Metaux[] tabmetaux)
        {
            int cote = 0;
            int pos = 0;
            for (int i = 0; i < tabmetaux.Length; i++)
            {

               cote = (tabmetaux[i].conductivite - 5) + (tabmetaux[i].resistance - 5) + (tabmetaux[i].pointDeFusion - 5) + (tabmetaux[i].poid - 5);
               pos = i;
                
            }
            Console.WriteLine("Le métal avec la cote la plus haute de"+ cote +"est le numéro" +pos);  
        }
        static void AfficherSiConductivite6(ref Metaux[] tabmetaux)
        {
            bool trouve = false;
            int conductiviteRechercher = 6, cpt = 0;
            while (trouve == false && cpt < tabmetaux.Length)
            {
                if (tabmetaux[cpt].conductivite > conductiviteRechercher)
                {
                    trouve = true;
                }
                else
                {
                    cpt++;
                }
            }

            if (trouve)
            {
                Console.WriteLine("il existe un métal avec plus de 6 en conductivité" );
            }
            else
            {
                Console.WriteLine("il n existe pas de Métal avec plus de 6 de conductivié");
            }
        }

        static void CreerMetaux(ref Metaux[] tabmetaux)
        {
            int Resis = 0;
            int PDF = 0;
            int Poid = 0;
            int Conduc = 0;
            int cote = 0;

            Console.WriteLine("Veuiller choisir votre premier metal");
            AfficherListeMetaux(ref tabmetaux);
            int choixMetal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Veuiller choisir votre deuxieme metaux");
            int choixMetal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choisir votre pourcentage pour le premier Métal");
            int choixPC1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choisir votre pourcentage pour le deuxieme Métal");
            int choixPC2 = Convert.ToInt32(Console.ReadLine());

           
                Resis = tabmetaux[choixMetal1].resistance * (choixPC1 / 100) + tabmetaux[choixMetal2].resistance * (choixPC2 / 100);
                PDF = tabmetaux[choixMetal1].pointDeFusion * (choixPC1 / 100) + tabmetaux[choixMetal2].pointDeFusion * (choixPC2 / 100);
                Poid = tabmetaux[choixMetal1].poid * (choixPC1 / 100) + tabmetaux[choixMetal2].poid * (choixPC2 / 100);
                Conduc = tabmetaux[choixMetal1].conductivite * (choixPC1 / 100) + tabmetaux[choixMetal2].conductivite * (choixPC2 / 100);

                cote = (Conduc - 5) + (Poid - 5) + (PDF - 5) + (Resis - 5);
                if (cote > 7)
                {
                    
                }
                if (cote > 3.5)
                {
                }
                if (cote > 1)
                {
                }
                if (cote < 1)
                {
                }
            
            Console.WriteLine("Votre novelle alliage a une resisitance de "+Resis +",un point de fusion de"+PDF+",un poid de"+Poid +"et une condutivité de"+Conduc+"et il est de qualité"+cote);
        }
        static void AfficherListeMetaux(ref Metaux[] tabmetaux)
        {
            for (int i = 0; i < tabmetaux.Length; i++)
            {
                Console.WriteLine("Metaux n " + (i + 1) + " Nom : " + tabmetaux[i].nom);

            }
        }
        static void AfficherMenu()
        {
            Console.WriteLine("Choisisez ce que vous voulez faire :");
            Console.WriteLine("1-Connaître le métal avec la meilleur résistance");
            Console.WriteLine("2-Connaître le métal avce le meilleur score");
            Console.WriteLine("3-Savoir si un métal avec une conductivité de plus de 6 existe");
            Console.WriteLine("4-Créer un nouvel alliage");
            Console.WriteLine("5-Quitter ");
        }
    }
}
