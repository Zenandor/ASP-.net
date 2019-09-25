using System;

namespace brouwerij
{
    public class Bier
    {
        public Bier(int id, string naam, string type){
            Id = id
            Naam = naam;
            Type = type;
        }

        public int Id {get; set;}
        public string Naam {get; set;}
        public string Type {get; set;}
    }
}