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
    public partial class prewiwe : Form
    {
        OperationtblPart ClassTemp = new OperationtblPart();
        string searchstring = "";
        int xx=0;
        public prewiwe()
        {
            InitializeComponent();
        }
        public prewiwe(string s,int x)
        {
            InitializeComponent();
            searchstring = s;
            xx = x;
        }

        private void prewiwe_Load(object sender, EventArgs e)
        {

            if (xx == 1)
            {
                DataTable dtt = new DataTable();
                string str = "";
                str = "select Customer.name,Customer.sex,Customer.lname,Customer.mobile,Register_service.date_first,Register_service.date_end,Register_service.price,( basis_DayMonthly.title) AS title_mon";
                str += ",(basis_Session.title) AS title_sess,( basis_Service.name_option) as name_option";
                str += ",(pardakht.price) AS price2,pardakht.title_pardakht from pardakht,Customer,Register_service,basis_Service,basis_DayMonthly,basis_Session ";
                str += "where Register_service.code_customer=Customer.id and Register_service.code_serivce= basis_Service.id and basis_Service.code_daymon=basis_DayMonthly.id and basis_Service.code_session=basis_Session.id  ";
                str += "and pardakht.code_factor=Register_service.id";
                str += searchstring + " and type_service=1";
                dtt = ClassTemp.redt(str);
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rpts = new ReportDataSource("DataSet1", dtt);
                reportViewer1.LocalReport.DataSources.Add(rpts);
                reportViewer1.RefreshReport();
            }
            if (xx == 2)
            {
                DataTable dtt = new DataTable();
                string str = "";
                str = "select Customer.name,Customer.lname,Customer.mobile,Customer.sex,Register_service.*,( basis_Class.title) AS title_mon";
                str += ",( basis_Employee.name+'' +basis_Employee.lname) AS title_sess,( basis_Class.decs) as name_option";
                str += " from Customer,Register_service,basis_Class,basis_Employee ";
                str += "where Register_service.code_customer=Customer.id and Register_service.code_serivce= basis_Class.id and basis_Class.code_coch=basis_Employee.id ";
                str += searchstring + " and type_service=2";
                dtt = ClassTemp.redt(str);
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rpts = new ReportDataSource("DataSet1", dtt);
               reportViewer1.LocalReport.DataSources.Add(rpts);
                reportViewer1.RefreshReport();
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
