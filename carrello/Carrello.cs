using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrello2
{
    internal class Carrello
    {
            private string id;
            public string Id
            {
                get { return id; }
                set { id = value; }
            }

            public object Properties { get; internal set; }

            public Carrello(string id)
            {
                this.id = id;
            }
            public List<Prodotto> prodotti = new List<Prodotto>();
            public int conta;
            public void Aggiungi_prodotto(Prodotto p, Prodotto c)
            {
               
                prodotti.Add(p);
                prodotti.Add(c);
            MessageBox.Show("Prodotto aggiunto");
            }
            public int trovato = -1;
            public void Elimina_prodotto(Prodotto P)
            {
                for (int i = 0; i < prodotti.Count; i++)
                {
                    if (prodotti[i].Id == P.Id)
                    {
                        trovato = i;
                        i = i - 1; //così viene controllato anche l'elemento che sostituisce l'elemento elemenato'
                        prodotti.RemoveAt(trovato);
                    }
               

            }
            MessageBox.Show("prodotto eleminato");

        }
            public void Svuota_carrello()
            {
                if (prodotti.Count > 0)
                {
                    prodotti.Clear();
                    MessageBox.Show("carrello svuotato");
                }
            }
    }
}



