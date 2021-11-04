using System;
using System.Collections.Generic;
using System.Text;

namespace HERITAGE
{
   public class Animal
    {
        protected string prenom;
        protected int NombrePattes;
        // le constructeur
        public Animal(string prenom,int NombrePattes)
        {
            this.prenom = prenom;
            this.NombrePattes = NombrePattes;
        }
        // metrhode respirer
        public void Respirer()
        {
            Console.WriteLine("Je suis " + prenom + " et je respire");
        }
        
    }
}
