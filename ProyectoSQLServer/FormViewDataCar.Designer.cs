namespace ProyectoSQLServer
{
    partial class FormViewDataCar
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
            this.dataGridViewDataCar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataCar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDataCar
            // 
            this.dataGridViewDataCar.AllowUserToAddRows = false;
            this.dataGridViewDataCar.AllowUserToDeleteRows = false;
            this.dataGridViewDataCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDataCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataCar.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDataCar.MultiSelect = false;
            this.dataGridViewDataCar.Name = "dataGridViewDataCar";
            this.dataGridViewDataCar.ReadOnly = true;
            this.dataGridViewDataCar.RowHeadersVisible = false;
            this.dataGridViewDataCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDataCar.Size = new System.Drawing.Size(449, 311);
            this.dataGridViewDataCar.TabIndex = 12;
            this.dataGridViewDataCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDataCar_CellClick);
            // 
            // FormViewDataCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 329);
            this.Controls.Add(this.dataGridViewDataCar);
            this.Name = "FormViewDataCar";
            this.Text = "Carros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDataCar;
    }
}