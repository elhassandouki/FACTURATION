using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FACTURATION
{
    public partial class Form1 : Form
    {
        SqlConnection mycon = new SqlConnection(@"Data Source=.;Initial Catalog=FACTURATION;Integrated Security=True");
        printFacture myds = new printFacture();
        SqlDataAdapter myclient;
        SqlDataAdapter mydetails;
        SqlDataAdapter myfact;
        SqlDataAdapter myproduit;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myclient = new SqlDataAdapter("select * from CLIENTS", mycon);
            mydetails = new SqlDataAdapter("select * from DETAILS", mycon);
            myfact = new SqlDataAdapter("select * from FACTURES", mycon);
            myproduit = new SqlDataAdapter("select * from PRODUITS", mycon);

            myclient.Fill(myds, "CLIENTS");
            mydetails.Fill(myds, "DETAILS");
            myfact.Fill(myds, "FACTURES");
            myproduit.Fill(myds, "PRODUITS");

            CrystalReport1 monetat = new CrystalReport1();
            monetat.SetDataSource(myds);
            crystalReportViewer1.ReportSource = monetat;
            crystalReportViewer1.Refresh();





            combrechclient.DataSource = myds.Tables["CLIENTS"];
            combrechclient.DisplayMember = "RaisonSociale";
            combrechclient.ValueMember="CodeClient";



            CrystalReport1 C = new CrystalReport1();
            C.SetDataSource(myds);
            crystalReportViewer1.ReportSource = C;
            crystalReportViewer1.Refresh();


        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnRecherech_Click(object sender, EventArgs e)
        {
            CrystalReport1 C = new CrystalReport1();
            C.SetDataSource(myds);
           // crystalReportViewer1.SelectionFormula = "{FACTURES.NumFacture} = " + txtrech.Text;
           // crystalReportViewer1.SelectionFormula = "{FACTURES.Codeclient} = " + combrech.Text;
            crystalReportViewer1.ReportSource = C;

            crystalReportViewer1.Refresh();
         

        }

        private void combrech_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRecherchclient_Click(object sender, EventArgs e)
        {
            CrystalReport1 c1 = new CrystalReport1();
            c1.SetDataSource(myds);
            crystalReportViewer1.SelectionFormula = "{CLIENTS.CodeClient} = " + combrechclient.SelectedValue;
            crystalReportViewer1.ReportSource = c1;
            crystalReportViewer1.Refresh();
        }

        private void FilitreParDate_Enter(object sender, EventArgs e)
        {

        }

        private void btnfilterpardate_Click(object sender, EventArgs e)
        {
            CrystalReport1 c2 = new CrystalReport1();
            c2.SetDataSource(myds);
            crystalReportViewer1.SelectionFormula = "{FACTURES.DateFacture} >= #" + datede.Value + "# and {FACTURES.DateFacture} <= #" + datea.Value + "#";
            crystalReportViewer1.ReportSource=c2;
            crystalReportViewer1.Refresh();
        }
    }
}
