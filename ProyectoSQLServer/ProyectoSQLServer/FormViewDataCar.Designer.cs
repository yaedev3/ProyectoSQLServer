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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewDataCar = new System.Windows.Forms.DataGridView();
            this.numericBuyPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBuyPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Compra";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(85, 12);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.ReadOnly = true;
            this.textBoxSerialNumber.Size = new System.Drawing.Size(194, 20);
            this.textBoxSerialNumber.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(85, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(194, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(85, 64);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(194, 20);
            this.textBoxBrand.TabIndex = 7;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(85, 90);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(194, 20);
            this.textBoxModel.TabIndex = 8;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(341, 67);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "Modificar";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(341, 109);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewDataCar
            // 
            this.dataGridViewDataCar.AllowUserToAddRows = false;
            this.dataGridViewDataCar.AllowUserToDeleteRows = false;
            this.dataGridViewDataCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataCar.Location = new System.Drawing.Point(12, 154);
            this.dataGridViewDataCar.Name = "dataGridViewDataCar";
            this.dataGridViewDataCar.ReadOnly = true;
            this.dataGridViewDataCar.Size = new System.Drawing.Size(449, 169);
            this.dataGridViewDataCar.TabIndex = 12;
            this.dataGridViewDataCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDataCar_CellClick);
            // 
            // numericBuyPrice
            // 
            this.numericBuyPrice.Location = new System.Drawing.Point(85, 117);
            this.numericBuyPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericBuyPrice.Name = "numericBuyPrice";
            this.numericBuyPrice.Size = new System.Drawing.Size(193, 20);
            this.numericBuyPrice.TabIndex = 13;
            // 
            // FormViewDataCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 329);
            this.Controls.Add(this.numericBuyPrice);
            this.Controls.Add(this.dataGridViewDataCar);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSerialNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormViewDataCar";
            this.Text = "FormViewDataCar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBuyPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewDataCar;
        private System.Windows.Forms.NumericUpDown numericBuyPrice;
    }
}