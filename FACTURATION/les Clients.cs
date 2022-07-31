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
    public partial class les_Clients : Form
    {
        SqlConnection MyCon = new SqlConnection(@"Data Source=.;Initial Catalog=FACTURATION;Integrated Security=True");
        DataSet1 ds = new DataSet1();
        SqlDataAdapter da;
        public les_Clients()
        {
            InitializeComponent();
        }

        private void les_Clients_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from CLIENTS ", MyCon);
            da.Fill(ds, "CLIENTS");

            CrystalReport2 dr = new CrystalReport2();

            dr.SetDataSource(ds.Tables["CLIENTS"]);
            crystalReportViewer1.ReportSource = dr;
            crystalReportViewer1.Refresh();

        }
    }
}
