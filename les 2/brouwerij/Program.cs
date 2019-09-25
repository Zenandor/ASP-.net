using System;
using System.Collections.Generic;

namespace brouwerij
{
    class Program
    {
        private static List<Bier> bieren = new List<Bier>();

        static void Main(string[] args)
        {
            var brouwerij = new Brouwerij("Bram", bieren);
            for(int i = 0; i < 5; i++){
                var name = $"bier{i}";
                var type = "blond";
                var bier = new Bier(name, type);
                brouwerij.Bieren.Add(bier);
            }

            foreach(var bier in brouwerij.Bieren){
                Console.WriteLine($"bier: {bier.Naam}, type: {bier.Type}");
            }



            Console.WriteLine("Enter the name of the beer you want to edit");
            string oldName = Console.ReadLine();
             
            foreach(var bier in brouwerij.Bieren){
                if(bier.Naam == oldName){
                    Console.WriteLine("Enter a new name for the beer");
                    string newName = Console.ReadLine();

                    bier.Naam = newName;
                }
            }

            foreach(var bier in brouwerij.Bieren){
                Console.WriteLine($"bier: {bier.Naam}, type: {bier.Type}");
            }
        }
    }
}
