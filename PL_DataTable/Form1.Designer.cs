namespace PL_DataTable
{
    partial class Form1
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
            this.dtg_lista = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_TipoCambio = new System.Windows.Forms.Label();
            this.lbl_PI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_lista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_lista
            // 
            this.dtg_lista.AllowUserToAddRows = false;
            this.dtg_lista.AllowUserToDeleteRows = false;
            this.dtg_lista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtg_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_lista.Location = new System.Drawing.Point(1, 10);
            this.dtg_lista.Margin = new System.Windows.Forms.Padding(2);
            this.dtg_lista.Name = "dtg_lista";
            this.dtg_lista.RowTemplate.Height = 24;
            this.dtg_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_lista.Size = new System.Drawing.Size(511, 212);
            this.dtg_lista.TabIndex = 1;
            this.dtg_lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_lista_CellContentClick);
            this.dtg_lista.DoubleClick += new System.EventHandler(this.dtg_lista_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_PI);
            this.groupBox1.Controls.Add(this.lbl_TipoCambio);
            this.groupBox1.Location = new System.Drawing.Point(518, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 209);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "App Config";
            // 
            // lbl_TipoCambio
            // 
            this.lbl_TipoCambio.AutoSize = true;
            this.lbl_TipoCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_TipoCambio.Location = new System.Drawing.Point(61, 46);
            this.lbl_TipoCambio.Name = "lbl_TipoCambio";
            this.lbl_TipoCambio.Size = new System.Drawing.Size(92, 31);
            this.lbl_TipoCambio.TabIndex = 0;
            this.lbl_TipoCambio.Text = "label1";
            // 
            // lbl_PI
            // 
            this.lbl_PI.AutoSize = true;
            this.lbl_PI.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_PI.Location = new System.Drawing.Point(61, 104);
            this.lbl_PI.Name = "lbl_PI";
            this.lbl_PI.Size = new System.Drawing.Size(92, 31);
            this.lbl_PI.TabIndex = 1;
            this.lbl_PI.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtg_lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_lista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg_lista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_PI;
        private System.Windows.Forms.Label lbl_TipoCambio;
    }
}

