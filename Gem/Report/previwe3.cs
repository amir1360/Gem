using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Gem.Report
{
    public partial class previwe3 : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        string searchstring = "";
       // string s1 = "";
        string b1,b2,b3,b4,b5;
        public previwe3(string s11,string sum1,string sum2,string sum3,string sum4,string sum5)
        {
            
            InitializeComponent();
            searchstring = s11;
            b1=sum1;
            b2=sum2;
            b3=sum3;
            b4=sum4;
            b5=sum5;
           
        }

        private void previwe3_Load(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();
            string str = searchstring;
           
            dtt = ClassTemp.redt(str);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rpts = new ReportDataSource("DataSet1", dtt);
            reportViewer1.LocalReport.DataSources.Add(rpts);
            reportViewer1.RefreshReport();
        }
    }
}
