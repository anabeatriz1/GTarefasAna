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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gtarefasDataSet.SelectQueryDados'. Você pode movê-la ou removê-la conforme necessário.
            this.selectQueryDadosTableAdapter.Fill(this.gtarefasDataSet.SelectQueryDados);
            // TODO: esta linha de código carrega dados na tabela 'gtarefasDataSet.Status'. Você pode movê-la ou removê-la conforme necessário.
            this.statusTableAdapter.Fill(this.gtarefasDataSet.Status);
            // TODO: esta linha de código carrega dados na tabela 'gtarefasDataSet.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
          

        }

        private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCadStatus fCadStatus = new FCadStatus();
            fCadStatus.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FCadTarefas fCadTarefas = new FCadTarefas();
            fCadTarefas.ShowDialog();
            
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FCadResponsavel fCadResponsavel = new FCadResponsavel();
            fCadResponsavel.ShowDialog();
        }

      
        private void tarefaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
