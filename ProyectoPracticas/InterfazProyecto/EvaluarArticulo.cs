using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazProyecto
{
    public partial class EvaluarArticulo : Form
    {
        private IMagazineService service;
        public EvaluarArticulo(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void EvaluarArticulo_Load(object sender, EventArgs e)
        {

        }
    }
}
