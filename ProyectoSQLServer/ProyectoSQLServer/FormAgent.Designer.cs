namespace ProyectoSQLServer
{
    partial class FormAgent
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
            this.numericUpSalary = new System.Windows.Forms.NumericUpDown();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxRFCAgent = new System.Windows.Forms.TextBox();
            this.textBoxNameAgent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAgent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgent)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpSalary
            // 
            this.numericUpSalary.DecimalPlaces = 4;
            this.numericUpSalary.Location = new System.Drawing.Point(86, 101);
            this.numericUpSalary.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numericUpSalary.Name = "numericUpSalary";
            this.numericUpSalary.Size = new System.Drawing.Size(120, 20);
            this.numericUpSalary.TabIndex = 45;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(290, 178);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(158, 23);
            this.buttonDelete.TabIndex = 44;
            this.buttonDelete.Text = "ELIMINAR";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(290, 121);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(158, 23);
            this.buttonModify.TabIndex = 43;
            this.buttonModify.Text = "MODIFICAR";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(290, 60);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(158, 23);
            this.buttonInsert.TabIndex = 42;
            this.buttonInsert.Text = "INSERTAR";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(86, 221);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(151, 20);
            this.textBoxEmail.TabIndex = 41;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(86, 180);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(151, 20);
            this.textBoxPhone.TabIndex = 40;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(86, 139);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(181, 20);
            this.textBoxAddress.TabIndex = 39;
            // 
            // textBoxRFCAgent
            // 
            this.textBoxRFCAgent.Location = new System.Drawing.Point(86, 57);
            this.textBoxRFCAgent.Name = "textBoxRFCAgent";
            this.textBoxRFCAgent.Size = new System.Drawing.Size(181, 20);
            this.textBoxRFCAgent.TabIndex = 38;
            // 
            // textBoxNameAgent
            // 
            this.textBoxNameAgent.Location = new System.Drawing.Point(86, 19);
            this.textBoxNameAgent.Name = "textBoxNameAgent";
            this.textBoxNameAgent.Size = new System.Drawing.Size(181, 20);
            this.textBoxNameAgent.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "EMAIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "CELULAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "DOMICILIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "SALARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "RFC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "NOMBRE";
            // 
            // dataGridViewAgent
            // 
            this.dataGridViewAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgent.Location = new System.Drawing.Point(15, 280);
            this.dataGridViewAgent.Name = "dataGridViewAgent";
            this.dataGridViewAgent.Size = new System.Drawing.Size(436, 166);
            this.dataGridViewAgent.TabIndex = 30;
            this.dataGridViewAgent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAgent_CellClick);
            // 
            // FormAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 465);
            this.Controls.Add(this.numericUpSalary);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxRFCAgent);
            this.Controls.Add(this.textBoxNameAgent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAgent);
            this.Name = "FormAgent";
            this.Text = "FormAgent";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpSalary;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxRFCAgent;
        private System.Windows.Forms.TextBox textBoxNameAgent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAgent;
    }
}