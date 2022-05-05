namespace Prototipo1_GT.Forms
{
    partial class MinhasT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tarefasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarefaTabela = new Prototipo1_GT.TarefaTabela();
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarefa = new Prototipo1_GT.Tarefa();
            this.tarefasTableAdapter = new Prototipo1_GT.TarefaTabelaTableAdapters.TarefasTableAdapter();
            this.tableAdapterManager = new Prototipo1_GT.TarefaTableAdapters.TableAdapterManager();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTarefaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefa)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeTarefaDataGridViewTextBoxColumn,
            this.descriçãoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tarefasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(136, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(569, 295);
            this.dataGridView1.TabIndex = 1;
            // 
            // tarefasBindingSource
            // 
            this.tarefasBindingSource.DataMember = "Tarefas";
            this.tarefasBindingSource.DataSource = this.tarefaTabela;
            // 
            // tarefaTabela
            // 
            this.tarefaTabela.DataSetName = "TarefaTabela";
            this.tarefaTabela.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tarefaBindingSource
            // 
            this.tarefaBindingSource.DataSource = this.tarefa;
            this.tarefaBindingSource.Position = 0;
            // 
            // tarefa
            // 
            this.tarefa.DataSetName = "Tarefa";
            this.tarefa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tarefasTableAdapter
            // 
            this.tarefasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.TarefasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Prototipo1_GT.TarefaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 43;
            // 
            // nomeTarefaDataGridViewTextBoxColumn
            // 
            this.nomeTarefaDataGridViewTextBoxColumn.DataPropertyName = "NomeTarefa";
            this.nomeTarefaDataGridViewTextBoxColumn.HeaderText = "NomeTarefa";
            this.nomeTarefaDataGridViewTextBoxColumn.Name = "nomeTarefaDataGridViewTextBoxColumn";
            // 
            // descriçãoDataGridViewTextBoxColumn
            // 
            this.descriçãoDataGridViewTextBoxColumn.DataPropertyName = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.Name = "descriçãoDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // MinhasT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 343);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "MinhasT";
            this.Text = "Minhas Tarefas";
            this.Load += new System.EventHandler(this.MinhasT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private Tarefa tarefa;
        private TarefaTabela tarefaTabela;
        private System.Windows.Forms.BindingSource tarefasBindingSource;
        private TarefaTabelaTableAdapters.TarefasTableAdapter tarefasTableAdapter;
        private TarefaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeTarefaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
    }
}