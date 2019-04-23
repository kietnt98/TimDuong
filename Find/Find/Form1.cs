using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
namespace Find
{
    
    public partial class Form1 : Form
    {
        TimDuongEntities db = new TimDuongEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtFind_Click(object sender, EventArgs e)
        {
            txtFind.Text = "";
        }

        private void picFind_Click(object sender, EventArgs e)
        {
            if(txtFind.Text=="" || txtFind.Text== "tên phòng học cần tìm")
            {
                txtResult.Text = "Vui lòng nhập tên phòng học cần tìm";
            }
            else
            {

               // string re = db.Tim(txtFind.Text).SingleOrDefault();


                if (db.Tim(txtFind.Text).SingleOrDefault() != null)
                {
                    txtResult.Text = db.Tim(txtFind.Text).SingleOrDefault();
                }
                else
                {
                    txtResult.Text = "Tên phòng không đúng";
                }
            }
        }
    }
}
