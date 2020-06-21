//Tanasa Alin Petru 3121A
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemaPIU1;
using System.Collections;
namespace FORMULAR
{
   
    public partial class Form1 : Form
    {
        List<string> orase= new List<string>();
        int id = 0;
        List<string> optiuniSelectate = new List<string>();
        IStocareData adminUtilizatori;
        List<Sejur> Sejururi = new List<Sejur>();
        public Form1()
        {
            InitializeComponent();
            adminUtilizatori = StocareFactory.GetAdministratorStocare();
        }
        public bool Validare()
        {
            bool vali = true;
            if(tNume.Text==string.Empty)
            {
                vali = false;
                LNume.ForeColor = Color.Red;
            }else
            { LNume.ForeColor = Color.Black; }
            if (tPrenume.Text == string.Empty)
            {
                vali = false;
                LPrenume.ForeColor = Color.Red;
            }else
            { LPrenume.ForeColor = Color.Black; }
            if (tBuget.Text == string.Empty)
            {
                vali = false;
                LBuget.ForeColor = Color.Red;
            }
            else
            { LBuget.ForeColor = Color.Black; }
            if(dtpUtilizator.Value<=DateTime.Now)
            {
                vali = false;
                lAfisare.Text = "Nu se poate rezerva in trecut";
            }else
            { lAfisare.Text=string.Empty ; }
            if (cmbTara.Text=="Tara_De_Preferinta")
            {
                vali = false;
                cmbTara.Text = "Nu se poate fara";
            }
            else
            { lAfisare.Text = string.Empty; }
            return vali;
        }
        public void BAdauga_Click(object sender,EventArgs e)
        {
            if (Validare())
            {
                LNume.ForeColor = Color.Black;
                LPrenume.ForeColor = Color.Black;
                LBuget.ForeColor = Color.Black;
                Utilizator u = new Utilizator(tNume.Text, tPrenume.Text, Convert.ToInt32(tBuget.Text));
                u.Optiune = new List<string>();
                u.Preferinta = pref();
                u.Optiune.AddRange(optiuniSelectate);
                lAfisare.Text = u.ConversieLaSir();
                if (cmbTara.Text != null)
                {
                    u.Tara_Pref = cmbTara.Text;
                }
                u.dataActualizare = DateTime.Now;
                u.dataRezervarii = dtpUtilizator.Value;
                Random rnd = new Random();
                int i = rnd.Next(1, 3);
                if (u.Tara_Pref == "Romania")
                {
                    orase.Clear();
                    orase.Add("Bucuresti");
                    orase.Add("Cluj");
                    orase.Add("Suceava");
                }
                else if (u.Tara_Pref == "Grecia")
                {
                    orase.Clear();
                    orase.Add("Atena");
                    orase.Add("Salonic");
                    orase.Add("Volos");
                }
                else
                {
                    orase.Clear();
                    orase.Add("Madrid");
                    orase.Add("Barcelona");
                    orase.Add("Sevilia");
                }
                int pret = rnd.Next(0, u.Buget);
                Sejur S = new Sejur(u.Tara_Pref, orase[i], pret);
                adminUtilizatori.AddUtilizator(u, S);
                lAfisare.Text = S.Afisare();
                ResetareControale();
            }
        }
        admin Admin;
        public void afis_Click(object sender,EventArgs e)
        {
            afis.Text = "Afisare";
            ArrayList utilizatori = adminUtilizatori.GetUtilizatori();
            foreach(Utilizator u in utilizatori)
            {
            }
            List<Utilizator> utilizators = adminUtilizatori.GetUtilizators();
            Sejururi = adminUtilizatori.GetSejururi();
            AdaugaUtilizatorInControlListbox(utilizators,Sejururi);
            Admin = new admin();
            Admin.Show();
            this.Width =877;
        }

        private void box_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox;
            string optiuneSelectata = checkBoxControl.Text;
            if (checkBoxControl.Checked == true)
                optiuniSelectate.Add(optiuneSelectata);
            else
                optiuniSelectate.Remove(optiuneSelectata);
        }
        private Preferinte pref()
        {
            if (radIeftin.Checked)
                return Preferinte.ieftin;
            if (radScump.Checked)
                return Preferinte.scump;
            return Preferinte.nimic;
        }
        private void ResetareControale()
        {
            tNume.Text = tPrenume.Text = tBuget.Text = string.Empty;
            radIeftin.Checked = false;
            radScump.Checked = false;
            boxParcare.Checked = false;
            boxRestaurant.Checked = false;
            boxWIFI.Checked = false;
            cmbTara.Text = string.Empty;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = lstAfisare.SelectedIndex;
            Utilizator U = null;
            try
            {
                U = adminUtilizatori.getUtilizator(id);
            }
            catch(Exception ex)
            {
               lAfisare.Text = "Eroare: " + ex.Message;
            }
            if(U!=null)
            {
                tNume.Text=U.Nume;
                tPrenume.Text = U.Prenume;
                tBuget.Text =Convert.ToString(U.Buget);
                foreach(var pr in groupBox2.Controls)
                {
                    if(pr is RadioButton)
                    {
                        var prbox = pr as RadioButton;
                        if(prbox.Text!=U.Preferinta.ToString())
                        {
                            prbox.Checked = true;
                        }
                    }
                }
                foreach(var pr in groupBox1.Controls)
                {
                    if(pr is CheckBox)
                    {
                        var prBox = pr as CheckBox;
                        foreach (String dis in U.Optiune)
                            if (prBox.Text.Equals(dis))
                                prBox.Checked = true;
                    }
                }
                cmbTara.Text = U.Tara_Pref.ToString();
                dtpUtilizator.Value = U.dataRezervarii;
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Utilizator U = new Utilizator(tNume.Text, tPrenume.Text, Convert.ToInt32(tBuget.Text));
            U.Preferinta = pref();
            U.Optiune = new List<string>();
            U.Optiune.AddRange(optiuniSelectate);
            if (cmbTara.Text != null)
            {
                U.Tara_Pref = cmbTara.Text;
            }
            U.dataRezervarii = dtpUtilizator.Value;
            adminUtilizatori.updateUtilizator(U,id,Sejururi[id]);
            U.dataActualizare = DateTime.Now;
            ResetareControale();
        }

        private void AdaugaUtilizatorInControlListbox(List<Utilizator> utilizators, List<Sejur> Sejururi)
        {
            int i = 0;
            lstAfisare.Items.Clear();
            foreach (Utilizator s in utilizators)
            {
                var linieTabel = String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}\n", s.Nume, s.Prenume,s.Buget ,string.Join(",", s.Optiune), s.Preferinta,s.Tara_Pref,s.dataRezervarii,Sejururi[i].Oras,Sejururi[i].pret);
                lstAfisare.Items.Add(linieTabel);
                i++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            afis.Text = "Admin";
        }
    }
}
