using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Credit;

namespace TravailCreditCsp
{
    public partial class frmCredit : Form
    {
        public frmCredit()
        {
            InitializeComponent();
        }

        private void cmdCalcul_Click(object sender, EventArgs e)
        {


            //  Credit.Credit  unCredit = new Credit.Credit (TxtMontantFinancé.Text, cbxDurée.Text, txtTaux.Text);
            // fonctionne en vb --> fait la transformation implicite 
            // string -->> passage de paramètres --> convertit en double
            // pas en C#

            Credit.Credit unCredit = new Credit.Credit(Convert.ToDouble(TxtMontantFinancé.Text), Convert.ToDouble(cbxDurée.Text), Convert.ToDouble(txtTaux.Text));
            // en c#, il faut tout convertir

            // autre solution ??
            // Il faudrait créer un constructeur en VB qui prend des valeurs en string
            // pour l'instant, j'ai un constructeur en double
            // rajouter un autre (question étude de cas)



            txtMensualité.Text = Convert.ToString(unCredit.getMensualités());  // c'est un double

            // c'est une variable globale

            Globales.lesCredits.Add(unCredit); //   ' rajoute le crédit dans la collection des crédits 

            // pensez à modifier la classe credit, rajouter un constructeur (string)

        }

        private void frmCredit_Load(object sender, EventArgs e)
        {

            int i;

            for (i = 1; i < 180; i++)
                cbxDurée.Items.Add(i);

       // rajouter dans la collection (LesCredits) les enregsitrements qui sont déjà dans la base de données (CreditCeleste ; Table credit)

        //  BDD --> Objets --> écran



        }

        private void cmdListeCredit_Click(object sender, EventArgs e)
        {

            //    '
            //'   pour aller sur la prochaine fenetre
            //'
            //' frmListCredit.Show()   '' vous appliquez une méthode à frmListCredit 
            //' c'est une classe

            //'' utiliser un objet
            //'
            //'   fenListCredit = New frmListCredit  ' pb, va créer un objet à chaque fois

            //' pensez à créer un singleton  

            if (Globales.fenListCredit == null)
                Globales.fenListCredit = new frmListCredit();
            else if (Globales.fenListCredit.IsDisposed) //   ' chercher la raison ' mettre un point d'arret
                Globales.fenListCredit = new frmListCredit();
            // normalement pas besoin d'accolades, car une instruction par ligne

            

            Globales.fenListCredit.Show();
            Globales.fenListCredit.BringToFront();

            //'   Me.Close()    à tester, ferme la fenêtre 

         //   this.Hide();   // si vous fermez la première fénêtre, toute l'application se ferme

            Hide();   // en corrigeant

            }
    }
}
