using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTarefas
{
    public partial class FCadStatus : Form
    {
        public FCadStatus()
        {
            InitializeComponent();
        }

        private void statusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gtarefasDataSet);

        }

        private void FCadStatus_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gtarefasDataSet.Status'. Você pode movê-la ou removê-la conforme necessário.
            this.statusTableAdapter.Fill(this.gtarefasDataSet.Status);

        }

        private void descricaoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
