namespace Prototipo1_GT.Forms
{
    partial class CDTarefa
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
            this.TxBTarefa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Dt_Data = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxBDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_voltar = new System.Windows.Forms.Button();
            this.Dt_Hora = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxBTarefa
            // 
            this.TxBTarefa.Location = new System.Drawing.Point(124, 28);
            this.TxBTarefa.Name = "TxBTarefa";
            this.TxBTarefa.Size = new System.Drawing.Size(278, 20);
            this.TxBTarefa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da Tarefa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dt_Data
            // 
            this.Dt_Data.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Dt_Data.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dt_Data.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dt_Data.Location = new System.Drawing.Point(124, 148);
            this.Dt_Data.Name = "Dt_Data";
            this.Dt_Data.Size = new System.Drawing.Size(104, 22);
            this.Dt_Data.TabIndex = 3;
            this.Dt_Data.Value = new System.DateTime(2022, 4, 29, 0, 0, 0, 0);
            this.Dt_Data.ValueChanged += new System.EventHandler(this.Dt_Data_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição";
            // 
            // TxBDescricao
            // 
            this.TxBDescricao.Location = new System.Drawing.Point(124, 65);
            this.TxBDescricao.Multiline = true;
            this.TxBDescricao.Name = "TxBDescricao";
            this.TxBDescricao.Size = new System.Drawing.Size(278, 68);
            this.TxBDescricao.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data";
            // 
            // BT_voltar
            // 
            this.BT_voltar.Location = new System.Drawing.Point(15, 235);
            this.BT_voltar.Name = "BT_voltar";
            this.BT_voltar.Size = new System.Drawing.Size(57, 23);
            this.BT_voltar.TabIndex = 8;
            this.BT_voltar.Text = "Voltar";
            this.BT_voltar.UseVisualStyleBackColor = true;
            this.BT_voltar.Click += new System.EventHandler(this.BT_voltar_Click);
            // 
            // Dt_Hora
            // 
            this.Dt_Hora.CustomFormat = " hh:mm:ss.";
            this.Dt_Hora.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Dt_Hora.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dt_Hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dt_Hora.Location = new System.Drawing.Point(300, 148);
            this.Dt_Hora.Name = "Dt_Hora";
            this.Dt_Hora.ShowUpDown = true;
            this.Dt_Hora.Size = new System.Drawing.Size(75, 22);
            this.Dt_Hora.TabIndex = 9;
            this.Dt_Hora.Value = new System.DateTime(2022, 4, 29, 0, 0, 0, 0);
            this.Dt_Hora.ValueChanged += new System.EventHandler(this.Dt_Hora_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Horario";
            // 
            // CDTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 270);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Dt_Hora);
            this.Controls.Add(this.BT_voltar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxBDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dt_Data);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxBTarefa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CDTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CDTarefa";
            this.Load += new System.EventHandler(this.CDTarefa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxBTarefa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker Dt_Data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxBDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_voltar;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.DateTimePicker Dt_Hora;
    }
}