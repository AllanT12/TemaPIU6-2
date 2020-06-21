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
using System.Xml;
using Microsoft.Office.Interop.Excel;

namespace FORMULAR
{
    public partial class admin : Form
    {
        List<string> optiuniSelectate = new List<string>();
        IStocareData adminUtilizatori;
        public admin()
        {
            InitializeComponent();
            adminUtilizatori = StocareFactory.GetAdministratorStocare();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            ArrayList utilizatori = adminUtilizatori.GetUtilizatori();
            List<Utilizator> utilizators = adminUtilizatori.GetUtilizators();
            AdaugaUtilizatoriInDataGridView(utilizators);
        }
        private void AdaugaUtilizatoriInDataGridView(List<Utilizator> utilizators)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = utilizators.Select(u => new { u.Nume, u.Prenume, u.Buget, Prefenta = string.Join(",", u.Optiune), u.Preferinta, u.Tara_Pref,u.dataRezervarii }).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            List<Utilizator> utilizators = adminUtilizatori.Data(dateTimePicker1.Value);
            dataGridView1.DataSource=utilizators.Select(u => new { u.Nume, u.Prenume, u.Buget, Prefenta = string.Join(",", u.Optiune), u.Preferinta, u.Tara_Pref, u.dataRezervarii }).ToList();
        }

        private void Salvare_ca_excel_Click(object sender, EventArgs e)
        {
            List<Utilizator> utilizators = adminUtilizatori.GetUtilizators();
            List<Sejur> sejurs = adminUtilizatori.GetSejururi();
            dataGridView1.DataSource = utilizators.Select(u => new { u.Nume, u.Prenume, u.Buget, Prefenta = string.Join(",", u.Optiune), u.Preferinta, u.Tara_Pref, u.dataRezervarii }).ToList();
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls" })
            {
                if(sfd.ShowDialog()==DialogResult.OK)
                {
                    string numefisier = sfd.FileName;
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)excel.ActiveSheet;
                    excel.Visible = false;
                    int index = 1;
                    int i = 0;
                    int process = utilizators.Count;
                    ws.Cells[1, 1] = "Nume_Utilizator";
                    ws.Cells[1, 2] = "Prenume_Utilizator";
                    ws.Cells[1, 3] = "Buget_Utilizator";
                    ws.Cells[1, 4] = "Tara";
                    ws.Cells[1, 5] = "Oras";
                    foreach (Utilizator u in utilizators)
                    {
                        index++;
                        ws.Cells[index, 1] = u.Nume;
                        ws.Cells[index, 2] = u.Prenume;
                        ws.Cells[index, 3] = Convert.ToString(u.Buget); 
                        ws.Cells[index, 4] = u.Tara_Pref;
                        ws.Cells[index, 5] = sejurs[i].Oras;
                        i++;
                    }
                    ws.SaveAs(numefisier,XlFileFormat.xlWorkbookDefault,Type.Missing,Type.Missing,true,false,XlSaveAsAccessMode.xlNoChange,XlSaveConflictResolution.xlLocalSessionChanges,Type.Missing,Type.Missing);
                    excel.Quit();
                    label1.Text = "Salvat";
                }
                
            }
           
        }

        private void saraciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Utilizator> utilizators = adminUtilizatori.GetUtilisaraci();
            dataGridView1.DataSource = utilizators.Select(u => new { u.Nume, u.Prenume, u.Buget, Prefenta = string.Join(",", u.Optiune), u.Preferinta, u.Tara_Pref, u.dataRezervarii }).ToList();
        }

        private void bogatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Utilizator> utilizators = adminUtilizatori.GetUtilizatorsbogati();
            dataGridView1.DataSource = utilizators.Select(u => new { u.Nume, u.Prenume, u.Buget, Prefenta = string.Join(",", u.Optiune), u.Preferinta, u.Tara_Pref, u.dataRezervarii }).ToList();
        }

        private void saortareDupaBugetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Utilizator> utilizators = adminUtilizatori.GetUtilizators();
            dataGridView1.DataSource = utilizators.Select(u => new { u.Nume, u.Prenume, u.Buget, Prefenta = string.Join(",", u.Optiune), u.Preferinta, u.Tara_Pref, u.dataRezervarii }).ToList();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int sum = 0;
            sum = adminUtilizatori.GetSumaUtilizatori();
            label2.Text = Convert.ToString(sum);
        }
    }
}
