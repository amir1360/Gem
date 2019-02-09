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
    public partial class previwe2 : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        string searchstring = "";
        int xx = 0;
        public previwe2()
        {
            InitializeComponent();
        }
        public previwe2(string s, int x)
        {
            InitializeComponent();
            searchstring = s;
            xx = x;
        }
        private void previwe2_Load(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();
            string str = "";
            str = "select Customer.name,Customer.lname,Customer.mobile,Customer.sex,(Register_service.date_first) AS date_fist,( basis_Class.title) AS title_mon";
            str += ",( basis_Employee.name+'' +basis_Employee.lname) AS title_sess,( basis_Class.decs) as name_option,(pardakht.price) AS price2";
            str += " from Customer,Register_service,basis_Class,basis_Employee,pardakht ";
            str += "where Register_service.code_customer=Customer.id and Register_service.code_serivce= basis_Class.id and basis_Class.code_coch=basis_Employee.id ";
            str += "and pardakht.code_factor=Register_service.id";
            str += searchstring + " and type_service=2";
            dtt = ClassTemp.redt(str);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rpts = new ReportDataSource("DataSet1", dtt);
            reportViewer1.LocalReport.DataSources.Add(rpts);
            reportViewer1.RefreshReport();
        }
    }
}
