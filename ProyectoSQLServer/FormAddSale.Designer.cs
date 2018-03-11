namespace ProyectoSQLServer
{
    partial class FormAddSale
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
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.textBoxAuto = new System.Windows.Forms.TextBox();
            this.comboBoxPaymentType = new System.Windows.Forms.ComboBox();
            this.numericFinalPrice = new System.Windows.Forms.NumericUpDown();
            this.groupBoxCredit = new System.Windows.Forms.GroupBox();
            this.numericStartingAmount = new System.Windows.Forms.NumericUpDown();
            this.numericExhibitions = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSClient = new System.Windows.Forms.Button();
            this.buttonSAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericFinalPrice)).BeginInit();
            this.groupBoxCredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartingAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericExhibitions)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(91, 15);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(170, 20);
            this.textBoxClient.TabIndex = 0;
            // 
            // textBoxAuto
            // 
            this.textBoxAuto.Location = new System.Drawing.Point(91, 41);
            this.textBoxAuto.Name = "textBoxAuto";
            this.textBoxAuto.Size = new System.Drawing.Size(170, 20);
            this.textBoxAuto.TabIndex = 1;
            // 
            // comboBoxPaymentType
            // 
            this.comboBoxPaymentType.Items.AddRange(new object[] {
            "Contado",
            "Credito"});
            this.comboBoxPaymentType.Location = new System.Drawing.Point(91, 67);
            this.comboBoxPaymentType.Name = "comboBoxPaymentType";
            this.comboBoxPaymentType.Size = new System.Drawing.Size(170, 21);
            this.comboBoxPaymentType.TabIndex = 2;
            this.comboBoxPaymentType.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymentType_SelectedIndexChanged);
            // 
            // numericFinalPrice
            // 
            this.numericFinalPrice.Location = new System.Drawing.Point(91, 96);
            this.numericFinalPrice.Name = "numericFinalPrice";
            this.numericFinalPrice.Size = new System.Drawing.Size(170, 20);
            this.numericFinalPrice.TabIndex = 3;
            // 
            // groupBoxCredit
            // 
            this.groupBoxCredit.Controls.Add(this.label6);
            this.groupBoxCredit.Controls.Add(this.label5);
            this.groupBoxCredit.Controls.Add(this.numericExhibitions);
            this.groupBoxCredit.Controls.Add(this.numericStartingAmount);
            this.groupBoxCredit.Enabled = false;
            this.groupBoxCredit.Location = new System.Drawing.Point(49, 122);
            this.groupBoxCredit.Name = "groupBoxCredit";
            this.groupBoxCredit.Size = new System.Drawing.Size(323, 116);
            this.groupBoxCredit.TabIndex = 4;
            this.groupBoxCredit.TabStop = false;
            this.groupBoxCredit.Text = "Credito";
            // 
            // numericStartingAmount
            // 
            this.numericStartingAmount.Location = new System.Drawing.Point(132, 27);
            this.numericStartingAmount.Name = "numericStartingAmount";
            this.numericStartingAmount.Size = new System.Drawing.Size(166, 20);
            this.numericStartingAmount.TabIndex = 0;
            // 
            // numericExhibitions
            // 
            this.numericExhibitions.Location = new System.Drawing.Point(132, 69);
            this.numericExhibitions.Name = "numericExhibitions";
            this.numericExhibitions.Size = new System.Drawing.Size(166, 20);
            this.numericExhibitions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Auto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Monto Inicial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Numero exhibiciones";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(111, 254);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(206, 254);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSClient
            // 
            this.buttonSClient.Location = new System.Drawing.Point(272, 13);
            this.buttonSClient.Name = "buttonSClient";
            this.buttonSClient.Size = new System.Drawing.Size(75, 23);
            this.buttonSClient.TabIndex = 11;
            this.buttonSClient.Text = "Seleccionar";
            this.buttonSClient.UseVisualStyleBackColor = true;
            this.buttonSClient.Click += new System.EventHandler(this.buttonSClient_Click);
            // 
            // buttonSAuto
            // 
            this.buttonSAuto.Location = new System.Drawing.Point(272, 39);
            this.buttonSAuto.Name = "buttonSAuto";
            this.buttonSAuto.Size = new System.Drawing.Size(75, 23);
            this.buttonSAuto.TabIndex = 12;
            this.buttonSAuto.Text = "Seleccionar";
            this.buttonSAuto.UseVisualStyleBackColor = true;
            this.buttonSAuto.Click += new System.EventHandler(this.buttonSAuto_Click);
            // 
            // FormAddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 290);
            this.Controls.Add(this.buttonSAuto);
            this.Controls.Add(this.buttonSClient);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxCredit);
            this.Controls.Add(this.numericFinalPrice);
            this.Controls.Add(this.comboBoxPaymentType);
            this.Controls.Add(this.textBoxAuto);
            this.Controls.Add(this.textBoxClient);
            this.Name = "FormAddSale";
            this.Text = "FormAddSale";
            ((System.ComponentModel.ISupportInitialize)(this.numericFinalPrice)).EndInit();
            this.groupBoxCredit.ResumeLayout(false);
            this.groupBoxCredit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartingAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericExhibitions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.TextBox textBoxAuto;
        private System.Windows.Forms.ComboBox comboBoxPaymentType;
        private System.Windows.Forms.NumericUpDown numericFinalPrice;
        private System.Windows.Forms.GroupBox groupBoxCredit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericExhibitions;
        private System.Windows.Forms.NumericUpDown numericStartingAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSClient;
        private System.Windows.Forms.Button buttonSAuto;
    }
}