using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejercicio60
{
    public partial class Form1 : Form
    {
        private SqlConnection conexion;

        public Form1()
        {
            InitializeComponent();
            string conexionStr = "Data Source=[LAB3PC27\\SQLEXPRESS];Initial Catalog=[AdventureWorks2012];Integrated Security=True";
            conexion = new SqlConnection(conexionStr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
