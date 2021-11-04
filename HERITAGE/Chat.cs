using System;
using System.Collections.Generic;
using System.Text;

namespace HERITAGE
{
    public class Chat:Animal
    {
        public string Couleur { get; set; }
        public double Poids { get; set; }
        // le constructeur  de la classe Chat
        public Chat(string prenom, int nombrePattes,string couleur,double poids):
            base(prenom, nombrePattes)
        {
            Couleur = couleur;
            Poids = poids;


        }
        // la methode miauler
        public void Miauler()
        {
            Console.WriteLine("Miauo miauo miaou miauo miaou miauo miaou");
        }

    }
}
