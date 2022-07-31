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
    public partial class Commande___ : Form
    {
        SqlConnection mycon = new SqlConnection(@"Data Source=.;Initial Catalog=FACTURATION;Integrated Security=True");
        DataSet myds = new DataSet();
        SqlDataAdapter myclinet;
        SqlDataAdapter myref;
        public Commande___()
        {
            InitializeComponent();
        }

        private void btntroncaction_Click(object sender, EventArgs e)
        {
             string str;
             string str2;
            
            
            if (mycon.State==ConnectionState.Closed)
            {
                mycon.Open();
            }
            SqlTransaction mytrans = mycon.BeginTransaction();
            try
            { 
               
                SqlCommand mycmd = mycon.CreateCommand();
                mycmd.Transaction = mytrans;
                str = "insert into FACTURES VALUES (" + txtnumfacteur.Text + ",'" + datetimefacteur.Value.ToShortDateString().ToString() + "'," + combclient.SelectedValue + ")";
                mycmd.CommandText = str;
                mycmd.ExecuteNonQuery();

                for (int i = 0; i <datagriddetail.RowCount-1; i++)
                {
                    str2 = "insert into DETAILS VALUES (" + txtnumfacteur.Text + ",'" + datagriddetail.Rows[i].Cells["comref"].Value.ToString() + "'," + datagriddetail.Rows[i].Cells["Qté"].Value.ToString() + ")";
                    SqlCommand cm1 = mycon.CreateCommand();
                    cm1.CommandText = str2;
                    cm1.Transaction = mytrans;
                    cm1.ExecuteNonQuery();
                }
                  
                //mycmd.ExecuteNonQuery();
                mytrans.Commit();
                MessageBox.Show(" Bien Ajouter !");
                
            }
            catch (Exception ex)
            {
                mytrans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                mycon.Close();
            }
        }

        private void Commande____Load(object sender, EventArgs e)
        {
            myclinet = new SqlDataAdapter("select * from CLIENTS", mycon);
            myclinet.Fill(myds, "CLIENTS");

            combclient.DataSource = myds.Tables["CLIENTS"];
            combclient.DisplayMember = "RaisonSociale";
            combclient.ValueMember = "CodeClient";

            myref = new SqlDataAdapter("select * from PRODUITS ", mycon);
            myref.Fill(myds, "PRODUITS");

            comref.DataSource = myds.Tables["PRODUITS"];
            comref.DisplayMember = "Ref";
            comref.ValueMember = "Ref";
            
        }

        private void btnclients_Click(object sender, EventArgs e)
        {
            les_Clients l = new les_Clients();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
