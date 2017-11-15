using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace FIGURY
{
    public partial class Form1 : Form
    {

        private int iNumerFigury  = 0;
        private int iIloscKol     = 0;
        private int iIloscKul     = 0;
        private int iIloscWalcow  = 0;
        private int iIloscStozkow = 0;

       // public ArrayList lstListaFigur = new ArrayList();
        public List<Figura> lstListaFigur= new List<Figura>();
        public Form1()
        {
            InitializeComponent();
        }

        //private void getNumerFigury()
        //{

        //}

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            switch (iNumerFigury)
            {
                case 0:
                    break;
                case 1:
                    Kolo noweKolo = new Kolo(1, "koło");
                    lstListaFigur.Add(noweKolo); 
                    lbxListaFigur.Items.Add("Koło " + iIloscKol);
                    iIloscKol++;
                    break;
                case 2:
                    Kula nowaKula = new Kula(2, "kula");
                    lstListaFigur.Add(nowaKula); 
                    lbxListaFigur.Items.Add("Kula " + iIloscKul);
                    iIloscKul++;
                    break;
            }
        }

        private void cbxKolo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxKolo.Checked)
                iNumerFigury = 1;
            //else
            //    iNumerFigury = 0;
        }

        private void cbxKula_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxKula.Checked)
                iNumerFigury = 2;
        }

        private void cbxWalec_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxWalec.Checked)
                iNumerFigury = 3;
        }

        private void cbxStozek_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxStozek.Checked)
                iNumerFigury = 4;
        }



        private void lbxListaFigur_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblParametry.Text = "";
            int index = lbxListaFigur.SelectedIndex;
            if (lstListaFigur[lbxListaFigur.SelectedIndex] is Kolo)
            {
                lblParametry.Text =
                 "Figura geometryczna:  " + ((Kolo)(lstListaFigur[lbxListaFigur.SelectedIndex])).sNazwa  + "\n" +
                 "Pole figury:  "         + ((Kolo)(lstListaFigur[lbxListaFigur.SelectedIndex])).dPole() + "\n" +
                 "Objętość: nie dotyczy";
            }
            //else
            if (lstListaFigur[lbxListaFigur.SelectedIndex] is Kula)
            {
                lblParametry.Text =
                 "Figura geometryczna:  " + ((Kula)(lstListaFigur[lbxListaFigur.SelectedIndex])).sNazwa  + "\n" +
                 "Pole figury:  "         + ((Kula)(lstListaFigur[lbxListaFigur.SelectedIndex]))._dPoleKuli + "\n" +
                 "Objętość: "             + ((Kula)(lstListaFigur[lbxListaFigur.SelectedIndex]))._dObjetoscKuli;
            }
        }
    }
}
