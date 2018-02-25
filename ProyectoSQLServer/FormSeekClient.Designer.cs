namespace Pantallas_VentaAutos
{
    partial class FormSeekClient
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.bSeek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(65, 15);
            this.tbName.MinimumSize = new System.Drawing.Size(274, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(274, 20);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(12, 18);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(47, 13);
            this.lName.TabIndex = 1;
            this.lName.Text = "Nombre:";
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(15, 53);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.Size = new System.Drawing.Size(405, 215);
            this.dgvClients.TabIndex = 2;
            // 
            // bSeek
            // 
            this.bSeek.Enabled = false;
            this.bSeek.Location = new System.Drawing.Point(345, 13);
            this.bSeek.Name = "bSeek";
            this.bSeek.Size = new System.Drawing.Size(75, 23);
            this.bSeek.TabIndex = 3;
            this.bSeek.Text = "Buscar";
            this.bSeek.UseVisualStyleBackColor = true;
            this.bSeek.Click += new System.EventHandler(this.bSeek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 280);
            this.Controls.Add(this.bSeek);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tbName);
            this.Name = "Form1";
            this.Text = "Búsqueda de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button bSeek;
    }
}

