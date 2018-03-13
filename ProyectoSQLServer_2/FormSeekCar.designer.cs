namespace ProyectoSQLServer
{
    partial class FormSeekCar
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
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.buttonDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.AllowUserToAddRows = false;
            this.dataGridViewCars.AllowUserToDeleteRows = false;
            this.dataGridViewCars.AllowUserToResizeColumns = false;
            this.dataGridViewCars.AllowUserToResizeRows = false;
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(15, 62);
            this.dataGridViewCars.MultiSelect = false;
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.ReadOnly = true;
            this.dataGridViewCars.RowHeadersVisible = false;
            this.dataGridViewCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCars.Size = new System.Drawing.Size(426, 207);
            this.dataGridViewCars.TabIndex = 0;
            this.dataGridViewCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCars_CellClick);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Nombre";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(155, 9);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(37, 13);
            this.labelBrand.TabIndex = 3;
            this.labelBrand.Text = "Marca";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(298, 9);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(42, 13);
            this.labelModel.TabIndex = 4;
            this.labelModel.Text = "Modelo";
            // 
            // comboBoxName
            // 
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.Location = new System.Drawing.Point(62, 6);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(87, 21);
            this.comboBoxName.TabIndex = 5;
            this.comboBoxName.SelectedValueChanged += new System.EventHandler(this.comboBoxName_SelectedValueChanged);
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrand.Location = new System.Drawing.Point(198, 6);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(94, 21);
            this.comboBoxBrand.TabIndex = 6;
            this.comboBoxBrand.SelectedValueChanged += new System.EventHandler(this.comboBoxBrand_SelectedValueChanged);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(346, 6);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(95, 21);
            this.comboBoxModel.TabIndex = 7;
            this.comboBoxModel.SelectedValueChanged += new System.EventHandler(this.comboBoxModel_SelectedValueChanged);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(181, 33);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 8;
            this.buttonDone.Text = "Aceptar";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormSeekCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(453, 281);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dataGridViewCars);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSeekCar";
            this.Text = "Carros";
            this.Load += new System.EventHandler(this.FormSeekCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCars;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.ComboBox comboBoxBrand;
    }
}