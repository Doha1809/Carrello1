using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrello2
{
    internal class Prodotto
    {
            private string id;
            public string Id
            {
                get { return id; }
            }
            private string marca;
            public string Marca
            {
                get { return marca; }
            }
            /* private string modello;
             public string Modello
             {
                 get { return modello; }
             }*/
            private double prezzo;
            public double Prezzo
            {
                get { return prezzo; }
                set { prezzo = value; }
            }
            public Prodotto(string id, string marca, string modello, double prezzo)
            {
                this.id = id;
                this.marca = marca;

                this.prezzo = prezzo;
            }
        
    }
}
