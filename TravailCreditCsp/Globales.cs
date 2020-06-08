using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailCreditCsp
{
    static class Globales   // plus tard  
    { 
        // classe particulières qui sert à stocker les variables globales

    //  pas d'objets instanciables  --> static

    public static List<Credit.Credit> lesCredits = new List<Credit.Credit>();
    //' permet de déclarer et de créer une liste de crédit

    // faudrait quand meme se débarrasser de Credit.credit --> uniquement credit
    //'
    //' gestion de la fenêtre credit
    //'
    public static frmCredit fenCredit; // As frmCredit   '' fenetre crédit(avec new  ??)
    public static frmListCredit fenListCredit; //   '' fenêtre list Credit



    
    }
}
