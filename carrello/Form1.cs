using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
    namespace Carrello2
{
    public partial class Form1 : Form
    {

        Carrello carrello1 = new Carrello("ciao");
        Prodotto p = new Prodotto("123", "321", "12", 1.20);
        Prodotto c = new Prodotto("12355", "321", "12", 1.20);
       List <TextBox> textbox= new List<TextBox> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void elimina_Click(object sender, EventArgs e)
        {
            for(int i=0;i<carrello1.prodotti.Count;i++)
             {
                 if (carrello1.prodotti[i].Id==c.Id)
                 {
                     int indice = i;
                     Controls.Remove(textbox[indice]);
                    
                 }
             }
        }
        int i = 0;
        int locazione = 0;
        private void aggiungi_Click(object sender, EventArgs e)
        {
          
            carrello1.Aggiungi_prodotto(p, c);
            for (; i < carrello1.prodotti.Count; i++)
            { 
                TextBox textBox =new TextBox();
                textBox.Text= $"E' stato aggiunto il prodotto di identificativo {carrello1.prodotti[i].Id}\n";
                textBox.Size = new Size(270, 22); 
                locazione =locazione+ 20;
                textBox.Location = new System.Drawing.Point(259, 181+locazione);
                textbox.Add(textBox);
                Controls.Add(textBox);
            }
        }

        private void Svuota_Click(object sender, EventArgs e)
        {
            carrello1.Svuota_carrello();
            for (int i = 0; i < textbox.Count; i++)
            {
                Controls.Remove(textbox[i]);
            }
            i = 0;
            locazione = 0;
        }
    }
}
