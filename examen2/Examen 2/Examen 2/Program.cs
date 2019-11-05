using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2
{
    class Program
    {
        static Random generateur = new Random();
        public struct rarete
        {
            public vaisseaux[] tabvais;
            public int nom;
            public int commun;
            public int rare;
            public int epique;
            public int legendaire;
            
            public rarete (int _nom,int _commun,int _rare,int _epique,int _legendaire) : this()
            {
                tabvais = new vaisseaux[20];
                nom = _nom;
                commun = _commun = 1;
                rare = _rare = 2;
                epique = _epique = 3;
                legendaire = _legendaire = 4;
                for (int i = 0; i < tabvais.Length; i++)
                {
                    tabvais[i] = new vaisseaux (generateur.Next(1, 4));
                }
                if(vaisseaux = 1)
                {
                    _attaque
                }

            }
        }
        static void AfficherMenu()
        {
            Console.WriteLine("Veuillez choisir les options suivantes pour pouvoir les tester : ");
            Console.WriteLine("1- Afficher les vaisseaux avec toute les caractéristique ");
            Console.WriteLine("2- Vérifier si un vaisseaux légendaire existe ");
            Console.WriteLine("3- Trouver le vaiseau avec le plus d'attaque ");
            Console.WriteLine("4-Afficher la moyenne des prix des vaiseaux ");
            Console.WriteLine("5-Quitter le programme");
        }
        static void AfficherMoyenneAtt(ref Soldat[] tabSoldat)
        {
            for (int i = 0; i < tabvais.Length; i++)
            {
                tot += tabvais[i].attaque;
            }
        }
        public struct vaisseaux
        {
            public int attaque;
            public int vie;
            public int prix;

            public vaisseaux (int _attaque,int _vie, int _prix) : this()
            {
                attaque = _attaque;
                vie = _vie;
                prix = _prix; 
            }
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu dans mon echoppe que voulez-vous aujourd'hui ?");
            string rarete;
            string AfficherMenu;
            int choix = Convert.ToInt32(Console.ReadLine()); 
            switch (choix)
            {
                case 1: string carateristique; break;
                case 2:string legendaire ;break;
                case 3:string pAttaque ; break;
                case 4:string MPrix; break;
                case 5: Fermer programme ; break;
                default: Console.WriteLine("Entrer un choix valide"); break;
            }
        }
    }
}
