namespace ProyectoSQLServer
{
    partial class FormViewAddSupplier
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxResidency = new System.Windows.Forms.TextBox();
            this.textBoxBusinessName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBusinessName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(80, 12);
            this.textBoxName.MaxLength = 25;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(197, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(80, 38);
            this.textBoxPhone.MaxLength = 15;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(197, 20);
            this.textBoxPhone.TabIndex = 1;
            // 
            // textBoxResidency
            // 
            this.textBoxResidency.Location = new System.Drawing.Point(80, 64);
            this.textBoxResidency.MaxLength = 25;
            this.textBoxResidency.Name = "textBoxResidency";
            this.textBoxResidency.Size = new System.Drawing.Size(197, 20);
            this.textBoxResidency.TabIndex = 2;
            // 
            // textBoxBusinessName
            // 
            this.textBoxBusinessName.Location = new System.Drawing.Point(80, 90);
            this.textBoxBusinessName.MaxLength = 25;
            this.textBoxBusinessName.Name = "textBoxBusinessName";
            this.textBoxBusinessName.Size = new System.Drawing.Size(197, 20);
            this.textBoxBusinessName.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(80, 116);
            this.textBoxEmail.MaxLength = 25;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(197, 20);
            this.textBoxEmail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Domicilio";
            // 
            // labelBusinessName
            // 
            this.labelBusinessName.AutoSize = true;
            this.labelBusinessName.Location = new System.Drawing.Point(4, 93);
            this.labelBusinessName.Name = "labelBusinessName";
            this.labelBusinessName.Size = new System.Drawing.Size(70, 13);
            this.labelBusinessName.TabIndex = 8;
            this.labelBusinessName.Text = "Razon Social";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(42, 119);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email";
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.AllowUserToAddRows = false;
            this.dataGridViewSuppliers.AllowUserToDeleteRows = false;
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(12, 146);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.ReadOnly = true;
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(445, 145);
            this.dataGridViewSuppliers.TabIndex = 10;
            this.dataGridViewSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuppliers_CellClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(337, 15);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Insertar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(337, 57);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 12;
            this.buttonModify.Text = "Modificar";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(337, 98);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormViewAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 303);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewSuppliers);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelBusinessName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxBusinessName);
            this.Controls.Add(this.textBoxResidency);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormViewAddSupplier";
            this.Text = "Provedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxResidency;
        private System.Windows.Forms.TextBox textBoxBusinessName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBusinessName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDelete;
    }
}