using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rommel01.VISTA
{
    public partial class FrmVisualUsuario : Form
    {
        public FrmVisualUsuario()
        {
            InitializeComponent();
        }

        private void FrmVisualUsuario_Load(object sender, EventArgs e)
        {
            DAO.ClsListaUsuario cls = new DAO.ClsListaUsuario();

            foreach (var iteracion in cls.user ) {

                dataGridView1.Rows.Add(iteracion.ToString();
            }

        }
    }
}
