namespace ProyectoSQLServer
{
    partial class FormBuy
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
            this.tabControlPages = new System.Windows.Forms.TabControl();
            this.tabPageNew = new System.Windows.Forms.TabPage();
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.numericUpDownCarPrice = new System.Windows.Forms.NumericUpDown();
            this.buttonSupplierSeek = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.textBoxCarModel = new System.Windows.Forms.TextBox();
            this.textBoxCarBrand = new System.Windows.Forms.TextBox();
            this.textBoxCarName = new System.Windows.Forms.TextBox();
            this.textBoxCarSerialNumber = new System.Windows.Forms.TextBox();
            this.labelCarPrice = new System.Windows.Forms.Label();
            this.labelCarModel = new System.Windows.Forms.Label();
            this.labelCarBrand = new System.Windows.Forms.Label();
            this.labelCarName = new System.Windows.Forms.Label();
            this.labelCarSerialNumber = new System.Windows.Forms.Label();
            this.labelCar = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelSupplierBusinessName = new System.Windows.Forms.Label();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlPages.SuspendLayout();
            this.tabPageNew.SuspendLayout();
            this.tabPageView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPages
            // 
            this.tabControlPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlPages.Controls.Add(this.tabPageNew);
            this.tabControlPages.Controls.Add(this.tabPageView);
            this.tabControlPages.Location = new System.Drawing.Point(0, 0);
            this.tabControlPages.Name = "tabControlPages";
            this.tabControlPages.SelectedIndex = 0;
            this.tabControlPages.Size = new System.Drawing.Size(220, 304);
            this.tabControlPages.TabIndex = 0;
            this.tabControlPages.SelectedIndexChanged += new System.EventHandler(this.tabControlPages_SelectedIndexChanged);
            // 
            // tabPageNew
            // 
            this.tabPageNew.Controls.Add(this.numericUpDownCarPrice);
            this.tabPageNew.Controls.Add(this.buttonSupplierSeek);
            this.tabPageNew.Controls.Add(this.buttonCancel);
            this.tabPageNew.Controls.Add(this.buttonAccept);
            this.tabPageNew.Controls.Add(this.textBoxCarModel);
            this.tabPageNew.Controls.Add(this.textBoxCarBrand);
            this.tabPageNew.Controls.Add(this.textBoxCarName);
            this.tabPageNew.Controls.Add(this.textBoxCarSerialNumber);
            this.tabPageNew.Controls.Add(this.labelCarPrice);
            this.tabPageNew.Controls.Add(this.labelCarModel);
            this.tabPageNew.Controls.Add(this.labelCarBrand);
            this.tabPageNew.Controls.Add(this.labelCarName);
            this.tabPageNew.Controls.Add(this.labelCarSerialNumber);
            this.tabPageNew.Controls.Add(this.labelCar);
            this.tabPageNew.Controls.Add(this.labelPhone);
            this.tabPageNew.Controls.Add(this.labelSupplierBusinessName);
            this.tabPageNew.Controls.Add(this.labelSupplierName);
            this.tabPageNew.Controls.Add(this.labelSupplier);
            this.tabPageNew.Location = new System.Drawing.Point(4, 22);
            this.tabPageNew.Name = "tabPageNew";
            this.tabPageNew.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNew.Size = new System.Drawing.Size(212, 278);
            this.tabPageNew.TabIndex = 0;
            this.tabPageNew.Text = "Nueva";
            this.tabPageNew.UseVisualStyleBackColor = true;
            // 
            // tabPageView
            // 
            this.tabPageView.Controls.Add(this.label1);
            this.tabPageView.Controls.Add(this.dataGridViewData);
            this.tabPageView.Location = new System.Drawing.Point(4, 22);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageView.Size = new System.Drawing.Size(212, 278);
            this.tabPageView.TabIndex = 1;
            this.tabPageView.Text = "Ver";
            this.tabPageView.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCarPrice
            // 
            this.numericUpDownCarPrice.DecimalPlaces = 2;
            this.numericUpDownCarPrice.Location = new System.Drawing.Point(74, 213);
            this.numericUpDownCarPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDownCarPrice.Name = "numericUpDownCarPrice";
            this.numericUpDownCarPrice.Size = new System.Drawing.Size(130, 20);
            this.numericUpDownCarPrice.TabIndex = 35;
            this.numericUpDownCarPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownCarPrice.ThousandsSeparator = true;
            // 
            // buttonSupplierSeek
            // 
            this.buttonSupplierSeek.Location = new System.Drawing.Point(70, 9);
            this.buttonSupplierSeek.Name = "buttonSupplierSeek";
            this.buttonSupplierSeek.Size = new System.Drawing.Size(79, 24);
            this.buttonSupplierSeek.TabIndex = 19;
            this.buttonSupplierSeek.Text = "Seleccionar";
            this.buttonSupplierSeek.UseVisualStyleBackColor = true;
            this.buttonSupplierSeek.Click += new System.EventHandler(this.buttonSupplierSeek_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(129, 247);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 34;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(6, 247);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 33;
            this.buttonAccept.Text = "Aceptar";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // textBoxCarModel
            // 
            this.textBoxCarModel.Location = new System.Drawing.Point(74, 187);
            this.textBoxCarModel.Name = "textBoxCarModel";
            this.textBoxCarModel.Size = new System.Drawing.Size(130, 20);
            this.textBoxCarModel.TabIndex = 32;
            this.textBoxCarModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCarBrand
            // 
            this.textBoxCarBrand.Location = new System.Drawing.Point(74, 163);
            this.textBoxCarBrand.Name = "textBoxCarBrand";
            this.textBoxCarBrand.Size = new System.Drawing.Size(130, 20);
            this.textBoxCarBrand.TabIndex = 31;
            this.textBoxCarBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCarName
            // 
            this.textBoxCarName.Location = new System.Drawing.Point(74, 137);
            this.textBoxCarName.Name = "textBoxCarName";
            this.textBoxCarName.Size = new System.Drawing.Size(130, 20);
            this.textBoxCarName.TabIndex = 30;
            this.textBoxCarName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCarSerialNumber
            // 
            this.textBoxCarSerialNumber.Location = new System.Drawing.Point(74, 111);
            this.textBoxCarSerialNumber.Name = "textBoxCarSerialNumber";
            this.textBoxCarSerialNumber.Size = new System.Drawing.Size(130, 20);
            this.textBoxCarSerialNumber.TabIndex = 29;
            this.textBoxCarSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCarPrice
            // 
            this.labelCarPrice.AutoSize = true;
            this.labelCarPrice.Location = new System.Drawing.Point(10, 215);
            this.labelCarPrice.Name = "labelCarPrice";
            this.labelCarPrice.Size = new System.Drawing.Size(37, 13);
            this.labelCarPrice.TabIndex = 28;
            this.labelCarPrice.Text = "Precio";
            // 
            // labelCarModel
            // 
            this.labelCarModel.AutoSize = true;
            this.labelCarModel.Location = new System.Drawing.Point(10, 190);
            this.labelCarModel.Name = "labelCarModel";
            this.labelCarModel.Size = new System.Drawing.Size(42, 13);
            this.labelCarModel.TabIndex = 27;
            this.labelCarModel.Text = "Modelo";
            // 
            // labelCarBrand
            // 
            this.labelCarBrand.AutoSize = true;
            this.labelCarBrand.Location = new System.Drawing.Point(8, 166);
            this.labelCarBrand.Name = "labelCarBrand";
            this.labelCarBrand.Size = new System.Drawing.Size(37, 13);
            this.labelCarBrand.TabIndex = 26;
            this.labelCarBrand.Text = "Marca";
            // 
            // labelCarName
            // 
            this.labelCarName.AutoSize = true;
            this.labelCarName.Location = new System.Drawing.Point(8, 140);
            this.labelCarName.Name = "labelCarName";
            this.labelCarName.Size = new System.Drawing.Size(44, 13);
            this.labelCarName.TabIndex = 25;
            this.labelCarName.Text = "Nombre";
            // 
            // labelCarSerialNumber
            // 
            this.labelCarSerialNumber.AutoSize = true;
            this.labelCarSerialNumber.Location = new System.Drawing.Point(8, 114);
            this.labelCarSerialNumber.Name = "labelCarSerialNumber";
            this.labelCarSerialNumber.Size = new System.Drawing.Size(51, 13);
            this.labelCarSerialNumber.TabIndex = 24;
            this.labelCarSerialNumber.Text = "No. Serie";
            // 
            // labelCar
            // 
            this.labelCar.AutoSize = true;
            this.labelCar.Location = new System.Drawing.Point(10, 90);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(29, 13);
            this.labelCar.TabIndex = 23;
            this.labelCar.Text = "Auto";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(8, 68);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(52, 13);
            this.labelPhone.TabIndex = 22;
            this.labelPhone.Text = "Telefono:";
            // 
            // labelSupplierBusinessName
            // 
            this.labelSupplierBusinessName.AutoSize = true;
            this.labelSupplierBusinessName.Location = new System.Drawing.Point(8, 55);
            this.labelSupplierBusinessName.Name = "labelSupplierBusinessName";
            this.labelSupplierBusinessName.Size = new System.Drawing.Size(73, 13);
            this.labelSupplierBusinessName.TabIndex = 21;
            this.labelSupplierBusinessName.Text = "Razon Social:";
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Location = new System.Drawing.Point(8, 42);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(47, 13);
            this.labelSupplierName.TabIndex = 20;
            this.labelSupplierName.Text = "Nombre:";
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Location = new System.Drawing.Point(8, 15);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(56, 13);
            this.labelSupplier.TabIndex = 18;
            this.labelSupplier.Text = "Proveedor";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.AllowUserToResizeColumns = false;
            this.dataGridViewData.AllowUserToResizeRows = false;
            this.dataGridViewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(8, 28);
            this.dataGridViewData.MultiSelect = false;
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.RowHeadersVisible = false;
            this.dataGridViewData.Size = new System.Drawing.Size(198, 244);
            this.dataGridViewData.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Compras:";
            // 
            // FormBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 316);
            this.Controls.Add(this.tabControlPages);
            this.Name = "FormBuy";
            this.Text = "Compra";
            this.tabControlPages.ResumeLayout(false);
            this.tabPageNew.ResumeLayout(false);
            this.tabPageNew.PerformLayout();
            this.tabPageView.ResumeLayout(false);
            this.tabPageView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPages;
        private System.Windows.Forms.TabPage tabPageNew;
        private System.Windows.Forms.NumericUpDown numericUpDownCarPrice;
        private System.Windows.Forms.Button buttonSupplierSeek;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.TextBox textBoxCarModel;
        private System.Windows.Forms.TextBox textBoxCarBrand;
        private System.Windows.Forms.TextBox textBoxCarName;
        private System.Windows.Forms.TextBox textBoxCarSerialNumber;
        private System.Windows.Forms.Label labelCarPrice;
        private System.Windows.Forms.Label labelCarModel;
        private System.Windows.Forms.Label labelCarBrand;
        private System.Windows.Forms.Label labelCarName;
        private System.Windows.Forms.Label labelCarSerialNumber;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelSupplierBusinessName;
        private System.Windows.Forms.Label labelSupplierName;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.TabPage tabPageView;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Label label1;
    }
}