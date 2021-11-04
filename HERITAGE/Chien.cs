using System;
using System.Collections.Generic;
using System.Text;

namespace HERITAGE
{
    public class Chien:Animal

    {
        //public int NombrePattes { get; set; }
        public string Couleur { get; set; }
        public bool PossedePoils { get; set; }
        //le constructeur de la classe Chien 
        public Chien(string prenom, int nombrePattes, string couleur,bool poils) :
            base(prenom,nombrePattes)
        {
            Couleur = couleur;
            PossedePoils = poils;

        }
        // la methode aboyer()
        public void Aboyer()
        {
            Console.WriteLine("wow wow wow wow wow wowoooooooooooooooooooooooooo");
        }
    }
}
