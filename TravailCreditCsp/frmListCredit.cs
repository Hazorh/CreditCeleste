using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravailCreditCsp
{
    public partial class frmListCredit : Form
    {
        public frmListCredit()
        {
            InitializeComponent();
        }

        private void frmListCredit_Load(object sender, EventArgs e)
        {


            //    '
            //'  mettre les éléments de la collection des crédits dans le listbox
            //'
            //' lsbCredit = lesCredits  ne fonctionne pas
            //'
            //'lsbCredit.Items = lesCredits  ' fonctionne pas
            //'
            //'lesCredits.AddAll(collectionB)   ' n'existe pas ici, à voir
            //'

            foreach (Credit.Credit xCredit in Globales.lesCredits)
            {
                //   '    lsbCredit.Items.Add(xCredit)   '' à  tester

                lsbCredit.Items.Add(xCredit.getInfo());

            }




        }

        private void cmdInit_Click(object sender, EventArgs e)
        {
            //    '
            //'  initialiser la liste box
            //'
            lsbCredit.Items.Clear();
            //'

            //' initialiser la collection
            //'
           Globales.lesCredits.Clear();




        }

        private void CmdCredit_Click(object sender, EventArgs e)
        {


            //    '
            //'  retourne à la fenetre précedente
            //'
            //' frmCredit.Show()

            if (Globales.fenCredit == null)
                Globales.fenCredit = new frmCredit();
            else if (Globales.fenCredit.IsDisposed)  //   ' chercher la raison ' mettre un point d'arret
                Globales.fenCredit = new frmCredit();


            Globales.fenCredit.Show();
            Globales.fenCredit.BringToFront();

            this.Close();  //   ' détruire la fenêtre en partant 
                       //      ( sécurité --> récupération dans la RAM,
        //' ne pas garder les anciennes valeurs quand on revient sur la fêntre
        //'  libére la mémoire 
        //'
        //'    me.hide ???


        }

        private void cmdEnregistre_Click(object sender, EventArgs e)
        {
            //
            //  Collection --> Stockage vers la base de données  --> sqlserveur  (CréditCeleste , table crédit)

            

            // Ecran --> Objets --> BDD

        }
    }
}
