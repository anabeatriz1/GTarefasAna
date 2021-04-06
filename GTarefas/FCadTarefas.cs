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
    public partial class FCadTarefas : Form
    {
        public FCadTarefas()
        {
            InitializeComponent();
        }

        private void tarefaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tarefaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gtarefasDataSet);

        }

        private void FCadTarefas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gtarefasDataSet.Responsavel'. Você pode movê-la ou removê-la conforme necessário.
            this.responsavelTableAdapter.Fill(this.gtarefasDataSet.Responsavel);
            // TODO: esta linha de código carrega dados na tabela 'gtarefasDataSet.Status'. Você pode movê-la ou removê-la conforme necessário.
            this.statusTableAdapter.Fill(this.gtarefasDataSet.Status);
            // TODO: esta linha de código carrega dados na tabela 'gtarefasDataSet.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefaTableAdapter.Fill(this.gtarefasDataSet.Tarefa);
            this.tarefaBindingSource.AddNew();
        }

        private void tarefaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idTarefaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tDescricaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void fKStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void BTSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.tarefaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gtarefasDataSet);
                this.Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
