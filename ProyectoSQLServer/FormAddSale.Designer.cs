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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSClient = new System.Windows.Forms.Button();
            this.buttonSAuto = new System.Windows.Forms.Button();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelCarName = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPaymentType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericStartingAmount = new System.Windows.Forms.NumericUpDown();
            this.numericExhibitions = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxCredit = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxFinalPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartingAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericExhibitions)).BeginInit();
            this.groupBoxCredit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Auto";
            // 
            // buttonSClient
            // 
            this.buttonSClient.Location = new System.Drawing.Point(271, 25);
            this.buttonSClient.Name = "buttonSClient";
            this.buttonSClient.Size = new System.Drawing.Size(75, 23);
            this.buttonSClient.TabIndex = 11;
            this.buttonSClient.Text = "Seleccionar";
            this.buttonSClient.UseVisualStyleBackColor = true;
            this.buttonSClient.Click += new System.EventHandler(this.buttonSClient_Click);
            // 
            // buttonSAuto
            // 
            this.buttonSAuto.Location = new System.Drawing.Point(272, 82);
            this.buttonSAuto.Name = "buttonSAuto";
            this.buttonSAuto.Size = new System.Drawing.Size(75, 23);
            this.buttonSAuto.TabIndex = 12;
            this.buttonSAuto.Text = "Seleccionar";
            this.buttonSAuto.UseVisualStyleBackColor = true;
            this.buttonSAuto.Click += new System.EventHandler(this.buttonSAuto_Click);
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Location = new System.Drawing.Point(87, 56);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(87, 13);
            this.labelSerialNumber.TabIndex = 13;
            this.labelSerialNumber.Text = "Numero de serie:";
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(87, 9);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(47, 13);
            this.labelClientName.TabIndex = 14;
            this.labelClientName.Text = "Nombre:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(87, 22);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(52, 13);
            this.labelAddress.TabIndex = 15;
            this.labelAddress.Text = "Domicilio:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(87, 35);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(52, 13);
            this.labelPhone.TabIndex = 16;
            this.labelPhone.Text = "Telefono:";
            // 
            // labelCarName
            // 
            this.labelCarName.AutoSize = true;
            this.labelCarName.Location = new System.Drawing.Point(89, 69);
            this.labelCarName.Name = "labelCarName";
            this.labelCarName.Size = new System.Drawing.Size(47, 13);
            this.labelCarName.TabIndex = 17;
            this.labelCarName.Text = "Nombre:";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(89, 82);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(40, 13);
            this.labelBrand.TabIndex = 18;
            this.labelBrand.Text = "Marca:";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(89, 95);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(45, 13);
            this.labelModel.TabIndex = 19;
            this.labelModel.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de pago";
            // 
            // comboBoxPaymentType
            // 
            this.comboBoxPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentType.Items.AddRange(new object[] {
            "Contado",
            "Credito"});
            this.comboBoxPaymentType.Location = new System.Drawing.Point(92, 116);
            this.comboBoxPaymentType.Name = "comboBoxPaymentType";
            this.comboBoxPaymentType.Size = new System.Drawing.Size(170, 21);
            this.comboBoxPaymentType.TabIndex = 2;
            this.comboBoxPaymentType.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymentType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio Final";
            // 
            // numericStartingAmount
            // 
            this.numericStartingAmount.DecimalPlaces = 2;
            this.numericStartingAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericStartingAmount.Location = new System.Drawing.Point(132, 29);
            this.numericStartingAmount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericStartingAmount.Name = "numericStartingAmount";
            this.numericStartingAmount.Size = new System.Drawing.Size(166, 20);
            this.numericStartingAmount.TabIndex = 0;
            this.numericStartingAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericExhibitions
            // 
            this.numericExhibitions.Location = new System.Drawing.Point(132, 69);
            this.numericExhibitions.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericExhibitions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericExhibitions.Name = "numericExhibitions";
            this.numericExhibitions.Size = new System.Drawing.Size(166, 20);
            this.numericExhibitions.TabIndex = 1;
            this.numericExhibitions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericExhibitions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // groupBoxCredit
            // 
            this.groupBoxCredit.Controls.Add(this.label6);
            this.groupBoxCredit.Controls.Add(this.label5);
            this.groupBoxCredit.Controls.Add(this.numericExhibitions);
            this.groupBoxCredit.Controls.Add(this.numericStartingAmount);
            this.groupBoxCredit.Enabled = false;
            this.groupBoxCredit.Location = new System.Drawing.Point(49, 171);
            this.groupBoxCredit.Name = "groupBoxCredit";
            this.groupBoxCredit.Size = new System.Drawing.Size(323, 116);
            this.groupBoxCredit.TabIndex = 4;
            this.groupBoxCredit.TabStop = false;
            this.groupBoxCredit.Text = "Credito";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(111, 303);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(206, 303);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxFinalPrice
            // 
            this.textBoxFinalPrice.Location = new System.Drawing.Point(90, 147);
            this.textBoxFinalPrice.Name = "textBoxFinalPrice";
            this.textBoxFinalPrice.ReadOnly = true;
            this.textBoxFinalPrice.Size = new System.Drawing.Size(171, 20);
            this.textBoxFinalPrice.TabIndex = 21;
            this.textBoxFinalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormAddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 339);
            this.Controls.Add(this.textBoxFinalPrice);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelCarName);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.labelSerialNumber);
            this.Controls.Add(this.buttonSAuto);
            this.Controls.Add(this.buttonSClient);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxCredit);
            this.Controls.Add(this.comboBoxPaymentType);
            this.Name = "FormAddSale";
            this.Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)(this.numericStartingAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericExhibitions)).EndInit();
            this.groupBoxCredit.ResumeLayout(false);
            this.groupBoxCredit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSClient;
        private System.Windows.Forms.Button buttonSAuto;
        private System.Windows.Forms.Label labelSerialNumber;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelCarName;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPaymentType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericStartingAmount;
        private System.Windows.Forms.NumericUpDown numericExhibitions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxCredit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxFinalPrice;
    }
}