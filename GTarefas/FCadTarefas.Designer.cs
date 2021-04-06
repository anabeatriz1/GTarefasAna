
namespace GTarefas
{
    partial class FCadTarefas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idTarefaLabel;
            System.Windows.Forms.Label tDescricaoLabel;
            System.Windows.Forms.Label fKStatusLabel;
            System.Windows.Forms.Label fKResponsavelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCadTarefas));
            this.gtarefasDataSet = new GTarefas.GtarefasDataSet();
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarefaTableAdapter = new GTarefas.GtarefasDataSetTableAdapters.TarefaTableAdapter();
            this.tableAdapterManager = new GTarefas.GtarefasDataSetTableAdapters.TableAdapterManager();
            this.idTarefaLabel1 = new System.Windows.Forms.Label();
            this.tDescricaoTextBox = new System.Windows.Forms.TextBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new GTarefas.GtarefasDataSetTableAdapters.StatusTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.responsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.responsavelTableAdapter = new GTarefas.GtarefasDataSetTableAdapters.ResponsavelTableAdapter();
            this.BTSalvar = new System.Windows.Forms.Button();
            idTarefaLabel = new System.Windows.Forms.Label();
            tDescricaoLabel = new System.Windows.Forms.Label();
            fKStatusLabel = new System.Windows.Forms.Label();
            fKResponsavelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gtarefasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idTarefaLabel
            // 
            idTarefaLabel.AutoSize = true;
            idTarefaLabel.Location = new System.Drawing.Point(43, 45);
            idTarefaLabel.Name = "idTarefaLabel";
            idTarefaLabel.Size = new System.Drawing.Size(58, 12);
            idTarefaLabel.TabIndex = 1;
            idTarefaLabel.Text = "Id Tarefa:";
            // 
            // tDescricaoLabel
            // 
            tDescricaoLabel.AutoSize = true;
            tDescricaoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tDescricaoLabel.Location = new System.Drawing.Point(247, 45);
            tDescricaoLabel.Name = "tDescricaoLabel";
            tDescricaoLabel.Size = new System.Drawing.Size(72, 12);
            tDescricaoLabel.TabIndex = 3;
            tDescricaoLabel.Text = "TDescricao:";
            tDescricaoLabel.Click += new System.EventHandler(this.tDescricaoLabel_Click);
            // 
            // fKStatusLabel
            // 
            fKStatusLabel.AutoSize = true;
            fKStatusLabel.Location = new System.Drawing.Point(43, 112);
            fKStatusLabel.Name = "fKStatusLabel";
            fKStatusLabel.Size = new System.Drawing.Size(58, 12);
            fKStatusLabel.TabIndex = 5;
            fKStatusLabel.Text = "FKStatus:";
            fKStatusLabel.Click += new System.EventHandler(this.fKStatusLabel_Click);
            // 
            // fKResponsavelLabel
            // 
            fKResponsavelLabel.AutoSize = true;
            fKResponsavelLabel.Location = new System.Drawing.Point(247, 112);
            fKResponsavelLabel.Name = "fKResponsavelLabel";
            fKResponsavelLabel.Size = new System.Drawing.Size(94, 12);
            fKResponsavelLabel.TabIndex = 7;
            fKResponsavelLabel.Text = "FKResponsavel:";
            // 
            // gtarefasDataSet
            // 
            this.gtarefasDataSet.DataSetName = "GtarefasDataSet";
            this.gtarefasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tarefaBindingSource
            // 
            this.tarefaBindingSource.DataMember = "Tarefa";
            this.tarefaBindingSource.DataSource = this.gtarefasDataSet;
            // 
            // tarefaTableAdapter
            // 
            this.tarefaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ResponsavelTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TarefaTableAdapter = this.tarefaTableAdapter;
            this.tableAdapterManager.UpdateOrder = GTarefas.GtarefasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idTarefaLabel1
            // 
            this.idTarefaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "IdTarefa", true));
            this.idTarefaLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTarefaLabel1.Location = new System.Drawing.Point(125, 45);
            this.idTarefaLabel1.Name = "idTarefaLabel1";
            this.idTarefaLabel1.Size = new System.Drawing.Size(77, 21);
            this.idTarefaLabel1.TabIndex = 2;
            this.idTarefaLabel1.Text = "label1";
            this.idTarefaLabel1.Click += new System.EventHandler(this.idTarefaLabel1_Click);
            // 
            // tDescricaoTextBox
            // 
            this.tDescricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "TDescricao", true));
            this.tDescricaoTextBox.Location = new System.Drawing.Point(335, 42);
            this.tDescricaoTextBox.Name = "tDescricaoTextBox";
            this.tDescricaoTextBox.Size = new System.Drawing.Size(219, 20);
            this.tDescricaoTextBox.TabIndex = 4;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.gtarefasDataSet;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tarefaBindingSource, "FKStatus", true));
            this.listBox1.DataSource = this.statusBindingSource1;
            this.listBox1.DisplayMember = "Descricao";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(47, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 112);
            this.listBox1.TabIndex = 9;
            this.listBox1.ValueMember = "IdStatus";
            // 
            // statusBindingSource1
            // 
            this.statusBindingSource1.DataMember = "Status";
            this.statusBindingSource1.DataSource = this.gtarefasDataSet;
            // 
            // listBox2
            // 
            this.listBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tarefaBindingSource, "FKResponsavel", true));
            this.listBox2.DataSource = this.responsavelBindingSource;
            this.listBox2.DisplayMember = "Nome";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(251, 138);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(139, 112);
            this.listBox2.TabIndex = 10;
            this.listBox2.ValueMember = "IdResponsavel";
            // 
            // responsavelBindingSource
            // 
            this.responsavelBindingSource.DataMember = "Responsavel";
            this.responsavelBindingSource.DataSource = this.gtarefasDataSet;
            // 
            // responsavelTableAdapter
            // 
            this.responsavelTableAdapter.ClearBeforeFill = true;
            // 
            // BTSalvar
            // 
            this.BTSalvar.Location = new System.Drawing.Point(444, 229);
            this.BTSalvar.Name = "BTSalvar";
            this.BTSalvar.Size = new System.Drawing.Size(87, 21);
            this.BTSalvar.TabIndex = 11;
            this.BTSalvar.Text = "Salvar";
            this.BTSalvar.UseVisualStyleBackColor = true;
            this.BTSalvar.Click += new System.EventHandler(this.BTSalvar_Click);
            // 
            // FCadTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(673, 399);
            this.Controls.Add(this.BTSalvar);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(idTarefaLabel);
            this.Controls.Add(this.idTarefaLabel1);
            this.Controls.Add(tDescricaoLabel);
            this.Controls.Add(this.tDescricaoTextBox);
            this.Controls.Add(fKStatusLabel);
            this.Controls.Add(fKResponsavelLabel);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FCadTarefas";
            this.Text = "FCadTarefas";
            this.Load += new System.EventHandler(this.FCadTarefas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gtarefasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GtarefasDataSet gtarefasDataSet;
        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private GtarefasDataSetTableAdapters.TarefaTableAdapter tarefaTableAdapter;
        private GtarefasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idTarefaLabel1;
        private System.Windows.Forms.TextBox tDescricaoTextBox;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private GtarefasDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource statusBindingSource1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.BindingSource responsavelBindingSource;
        private GtarefasDataSetTableAdapters.ResponsavelTableAdapter responsavelTableAdapter;
        private System.Windows.Forms.Button BTSalvar;
    }
}