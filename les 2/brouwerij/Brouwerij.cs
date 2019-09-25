using System;
using System.Collections.Generic;

namespace brouwerij
{
    public class Brouwerij
    {
        public Brouwerij(string eigenaar, List<Bier> bieren){
            Eigenaar = eigenaar;
            Bieren = bieren; 
        }

        public string Eigenaar {get; set;}
        public List<Bier> Bieren {get; set;}





    }
}