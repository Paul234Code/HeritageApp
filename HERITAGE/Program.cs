using System;
using System.Collections.Generic;

namespace HERITAGE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //creation d'une liste pour stocker mes animaux
            List<Animal> listeAnimaux = new List<Animal>();
            /*creation de 3 chien et 2 chats
             * que je vais traiter comme des Animaux
             * en appelant la methode @Respirer
             */
            Animal boby = new Chien("Boby", 4,"black",true) ;
            Animal roby = new Chien("Roby",4,"dark",false);
            Animal coby = new Chien("Coby",4,"green",true);
            // les deux chats
            Animal toby = new Chat("Toby",4,"white",40);
            Animal loby = new Chat("Loby", 4, "black", 40);
            //on ajoute les chiens et chats dans la liste 
            listeAnimaux.Add(boby);
            listeAnimaux.Add(roby);
            listeAnimaux.Add(coby);
            listeAnimaux.Add(toby);
            listeAnimaux.Add(loby);
            //affichage de la liste des animaux
            foreach(Animal animal  in listeAnimaux)
            {
                animal.Respirer();
            }




        }
    }
}
