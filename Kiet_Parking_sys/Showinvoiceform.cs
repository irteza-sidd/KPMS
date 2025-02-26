using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiet_Parking_sys
{
    public partial class Showinvoiceform : Form
    {
        string plateno;
        public Showinvoiceform(string pl)
        {
            plateno = pl;
            InitializeComponent();
        }
        public Showinvoiceform()
        {
            InitializeComponent();
        }

        private void Showinvoiceform_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-KOIN233;Initial Catalog=KPMS;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from voiceshow where Plate_No='" + plateno + "'", sqlcon);
            Mydataset ds = new Mydataset();
            da.Fill(ds, "Invoice");
            ReportDataSource datasource = new ReportDataSource("Report_Data", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-KOIN233;Initial Catalog=KPMS;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from voiceshow where Plate_No='" + textBox1.Text + "'", sqlcon);
            Mydataset ds = new Mydataset();
            da.Fill(ds, "Invoice");
            ReportDataSource datasource = new ReportDataSource("Report_Data", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
    }
}
