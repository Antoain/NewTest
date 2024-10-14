using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDadtos;

namespace EFInsert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private CategoryRepo cr = new CategoryRepo();
        private void btnCargarAll_Click(object sender, EventArgs e)
        {
            var categs = cr.ObtnTodos();
            dgvCategory.DataSource = categs;
        }
    }
}
