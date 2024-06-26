﻿namespace TurApp.Views
{
    partial class FrmFacturaAM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LetraCbo = new System.Windows.Forms.ComboBox();
            this.FormaPagoCbo = new System.Windows.Forms.ComboBox();
            this.FechaFacturaTime = new System.Windows.Forms.DateTimePicker();
            this.FormaPagolbl = new System.Windows.Forms.Label();
            this.NumeroTxt = new System.Windows.Forms.TextBox();
            this.NumeroLbl = new System.Windows.Forms.Label();
            this.DniTuristaCbo = new System.Windows.Forms.ComboBox();
            this.DniTuristaLbl = new System.Windows.Forms.Label();
            this.FechaLbl = new System.Windows.Forms.Label();
            this.LetraLbl = new System.Windows.Forms.Label();
            this.SerieTxt = new System.Windows.Forms.TextBox();
            this.SerieLbl = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.PaquetesGrupBox = new System.Windows.Forms.GroupBox();
            this.DetallesGrd = new System.Windows.Forms.DataGridView();
            this.NroCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuitarBtn = new System.Windows.Forms.Button();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.PaquetesGrd = new System.Windows.Forms.DataGridView();
            this.CodPaqCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAgenciaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetallePagoTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.PaquetesGrupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesGrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaquetesGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DetallePagoTxt);
            this.groupBox1.Controls.Add(this.LetraCbo);
            this.groupBox1.Controls.Add(this.FormaPagoCbo);
            this.groupBox1.Controls.Add(this.FechaFacturaTime);
            this.groupBox1.Controls.Add(this.FormaPagolbl);
            this.groupBox1.Controls.Add(this.NumeroTxt);
            this.groupBox1.Controls.Add(this.NumeroLbl);
            this.groupBox1.Controls.Add(this.DniTuristaCbo);
            this.groupBox1.Controls.Add(this.DniTuristaLbl);
            this.groupBox1.Controls.Add(this.FechaLbl);
            this.groupBox1.Controls.Add(this.LetraLbl);
            this.groupBox1.Controls.Add(this.SerieTxt);
            this.groupBox1.Controls.Add(this.SerieLbl);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(292, 319);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // LetraCbo
            // 
            this.LetraCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LetraCbo.FormattingEnabled = true;
            this.LetraCbo.Location = new System.Drawing.Point(74, 86);
            this.LetraCbo.Margin = new System.Windows.Forms.Padding(2);
            this.LetraCbo.Name = "LetraCbo";
            this.LetraCbo.Size = new System.Drawing.Size(80, 21);
            this.LetraCbo.TabIndex = 30;
            this.LetraCbo.Tag = "Letra";
            // 
            // FormaPagoCbo
            // 
            this.FormaPagoCbo.DisplayMember = "Forma";
            this.FormaPagoCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormaPagoCbo.FormattingEnabled = true;
            this.FormaPagoCbo.Location = new System.Drawing.Point(93, 187);
            this.FormaPagoCbo.Margin = new System.Windows.Forms.Padding(2);
            this.FormaPagoCbo.Name = "FormaPagoCbo";
            this.FormaPagoCbo.Size = new System.Drawing.Size(157, 21);
            this.FormaPagoCbo.TabIndex = 12;
            this.FormaPagoCbo.Tag = "CodFormaPago";
            this.FormaPagoCbo.ValueMember = "Codigo";
            this.FormaPagoCbo.SelectedIndexChanged += new System.EventHandler(this.FormaPagoCbo_SelectedIndexChanged);
            // 
            // FechaFacturaTime
            // 
            this.FechaFacturaTime.CustomFormat = "yyyy-mm-dd";
            this.FechaFacturaTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaFacturaTime.Location = new System.Drawing.Point(74, 120);
            this.FechaFacturaTime.Name = "FechaFacturaTime";
            this.FechaFacturaTime.Size = new System.Drawing.Size(120, 20);
            this.FechaFacturaTime.TabIndex = 8;
            this.FechaFacturaTime.Tag = "Fecha";
            // 
            // FormaPagolbl
            // 
            this.FormaPagolbl.AutoSize = true;
            this.FormaPagolbl.Location = new System.Drawing.Point(10, 190);
            this.FormaPagolbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FormaPagolbl.Name = "FormaPagolbl";
            this.FormaPagolbl.Size = new System.Drawing.Size(79, 13);
            this.FormaPagolbl.TabIndex = 11;
            this.FormaPagolbl.Text = "&Forma de Pago";
            // 
            // NumeroTxt
            // 
            this.NumeroTxt.Location = new System.Drawing.Point(74, 22);
            this.NumeroTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NumeroTxt.MaxLength = 15;
            this.NumeroTxt.Name = "NumeroTxt";
            this.NumeroTxt.Size = new System.Drawing.Size(80, 20);
            this.NumeroTxt.TabIndex = 2;
            this.NumeroTxt.Tag = "Nro";
            this.NumeroTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NroTxt_KeyPress);
            // 
            // NumeroLbl
            // 
            this.NumeroLbl.AutoSize = true;
            this.NumeroLbl.Location = new System.Drawing.Point(10, 22);
            this.NumeroLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumeroLbl.Name = "NumeroLbl";
            this.NumeroLbl.Size = new System.Drawing.Size(44, 13);
            this.NumeroLbl.TabIndex = 1;
            this.NumeroLbl.Text = "&Numero";
            // 
            // DniTuristaCbo
            // 
            this.DniTuristaCbo.DisplayMember = "Nombre";
            this.DniTuristaCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DniTuristaCbo.FormattingEnabled = true;
            this.DniTuristaCbo.Location = new System.Drawing.Point(74, 150);
            this.DniTuristaCbo.Margin = new System.Windows.Forms.Padding(2);
            this.DniTuristaCbo.Name = "DniTuristaCbo";
            this.DniTuristaCbo.Size = new System.Drawing.Size(157, 21);
            this.DniTuristaCbo.TabIndex = 10;
            this.DniTuristaCbo.Tag = "DniTurista";
            this.DniTuristaCbo.ValueMember = "Id";
            this.DniTuristaCbo.SelectedIndexChanged += new System.EventHandler(this.DniTuristaCbo_SelectedIndexChanged);
            // 
            // DniTuristaLbl
            // 
            this.DniTuristaLbl.AutoSize = true;
            this.DniTuristaLbl.Location = new System.Drawing.Point(10, 154);
            this.DniTuristaLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DniTuristaLbl.Name = "DniTuristaLbl";
            this.DniTuristaLbl.Size = new System.Drawing.Size(55, 13);
            this.DniTuristaLbl.TabIndex = 9;
            this.DniTuristaLbl.Text = "&DniTurista";
            // 
            // FechaLbl
            // 
            this.FechaLbl.AutoSize = true;
            this.FechaLbl.Location = new System.Drawing.Point(10, 120);
            this.FechaLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FechaLbl.Name = "FechaLbl";
            this.FechaLbl.Size = new System.Drawing.Size(37, 13);
            this.FechaLbl.TabIndex = 7;
            this.FechaLbl.Text = "&Fecha";
            // 
            // LetraLbl
            // 
            this.LetraLbl.AutoSize = true;
            this.LetraLbl.Location = new System.Drawing.Point(10, 86);
            this.LetraLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LetraLbl.Name = "LetraLbl";
            this.LetraLbl.Size = new System.Drawing.Size(31, 13);
            this.LetraLbl.TabIndex = 5;
            this.LetraLbl.Text = "&Letra";
            // 
            // SerieTxt
            // 
            this.SerieTxt.Location = new System.Drawing.Point(74, 51);
            this.SerieTxt.Margin = new System.Windows.Forms.Padding(2);
            this.SerieTxt.MaxLength = 90;
            this.SerieTxt.Name = "SerieTxt";
            this.SerieTxt.Size = new System.Drawing.Size(166, 20);
            this.SerieTxt.TabIndex = 4;
            this.SerieTxt.Tag = "Serie";
            this.SerieTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SerieTxt_KeyPress);
            // 
            // SerieLbl
            // 
            this.SerieLbl.AutoSize = true;
            this.SerieLbl.Location = new System.Drawing.Point(10, 51);
            this.SerieLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SerieLbl.Name = "SerieLbl";
            this.SerieLbl.Size = new System.Drawing.Size(31, 13);
            this.SerieLbl.TabIndex = 3;
            this.SerieLbl.Text = "&Serie";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(233, 342);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 19;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(146, 342);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 18;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // PaquetesGrupBox
            // 
            this.PaquetesGrupBox.Controls.Add(this.DetallesGrd);
            this.PaquetesGrupBox.Controls.Add(this.QuitarBtn);
            this.PaquetesGrupBox.Controls.Add(this.AgregarBtn);
            this.PaquetesGrupBox.Controls.Add(this.PaquetesGrd);
            this.PaquetesGrupBox.Location = new System.Drawing.Point(327, 12);
            this.PaquetesGrupBox.Name = "PaquetesGrupBox";
            this.PaquetesGrupBox.Size = new System.Drawing.Size(476, 380);
            this.PaquetesGrupBox.TabIndex = 28;
            this.PaquetesGrupBox.TabStop = false;
            this.PaquetesGrupBox.Text = "Paquetes";
            // 
            // DetallesGrd
            // 
            this.DetallesGrd.AllowUserToAddRows = false;
            this.DetallesGrd.AllowUserToDeleteRows = false;
            this.DetallesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetallesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroCol,
            this.CodCol,
            this.ImpCol});
            this.DetallesGrd.Location = new System.Drawing.Point(17, 221);
            this.DetallesGrd.MultiSelect = false;
            this.DetallesGrd.Name = "DetallesGrd";
            this.DetallesGrd.ReadOnly = true;
            this.DetallesGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetallesGrd.Size = new System.Drawing.Size(439, 144);
            this.DetallesGrd.TabIndex = 15;
            this.DetallesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DetallesGrd_DataBindingComplete);
            // 
            // NroCol
            // 
            this.NroCol.HeaderText = "Nro Renglon";
            this.NroCol.Name = "NroCol";
            this.NroCol.ReadOnly = true;
            this.NroCol.Width = 90;
            // 
            // CodCol
            // 
            this.CodCol.DataPropertyName = "Codigo";
            this.CodCol.HeaderText = "Codigo";
            this.CodCol.Name = "CodCol";
            this.CodCol.ReadOnly = true;
            // 
            // ImpCol
            // 
            this.ImpCol.HeaderText = "Importe";
            this.ImpCol.Name = "ImpCol";
            this.ImpCol.ReadOnly = true;
            // 
            // QuitarBtn
            // 
            this.QuitarBtn.Location = new System.Drawing.Point(271, 182);
            this.QuitarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.QuitarBtn.Name = "QuitarBtn";
            this.QuitarBtn.Size = new System.Drawing.Size(59, 27);
            this.QuitarBtn.TabIndex = 17;
            this.QuitarBtn.Text = "&Quitar";
            this.QuitarBtn.UseVisualStyleBackColor = true;
            this.QuitarBtn.Click += new System.EventHandler(this.QuitarBtn_Click);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(161, 182);
            this.AgregarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(59, 27);
            this.AgregarBtn.TabIndex = 16;
            this.AgregarBtn.Text = "&Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // PaquetesGrd
            // 
            this.PaquetesGrd.AllowUserToAddRows = false;
            this.PaquetesGrd.AllowUserToDeleteRows = false;
            this.PaquetesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaquetesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodPaqCol,
            this.NombreAgenciaCol,
            this.ImporteCol});
            this.PaquetesGrd.Location = new System.Drawing.Point(17, 26);
            this.PaquetesGrd.MultiSelect = false;
            this.PaquetesGrd.Name = "PaquetesGrd";
            this.PaquetesGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PaquetesGrd.Size = new System.Drawing.Size(439, 144);
            this.PaquetesGrd.TabIndex = 14;
            this.PaquetesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.PaquetesGrd_DataBindingComplete);
            // 
            // CodPaqCol
            // 
            this.CodPaqCol.DataPropertyName = "Codigo";
            this.CodPaqCol.HeaderText = "Codigo";
            this.CodPaqCol.Name = "CodPaqCol";
            // 
            // NombreAgenciaCol
            // 
            this.NombreAgenciaCol.HeaderText = "Nombre Agencia";
            this.NombreAgenciaCol.Name = "NombreAgenciaCol";
            this.NombreAgenciaCol.Width = 150;
            // 
            // ImporteCol
            // 
            this.ImporteCol.HeaderText = "Importe";
            this.ImporteCol.Name = "ImporteCol";
            // 
            // DetallePagoTxt
            // 
            this.DetallePagoTxt.Location = new System.Drawing.Point(13, 231);
            this.DetallePagoTxt.MaxLength = 90;
            this.DetallePagoTxt.Multiline = true;
            this.DetallePagoTxt.Name = "DetallePagoTxt";
            this.DetallePagoTxt.Size = new System.Drawing.Size(268, 83);
            this.DetallePagoTxt.TabIndex = 31;
            this.DetallePagoTxt.Tag = "DetallePago";
            // 
            // FrmFacturaAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 404);
            this.Controls.Add(this.PaquetesGrupBox);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFacturaAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso nueva factura";
            this.Deactivate += new System.EventHandler(this.FrmFacturaAM_Deactivate);
            this.Load += new System.EventHandler(this.FrmFacturaAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PaquetesGrupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetallesGrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaquetesGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NumeroTxt;
        private System.Windows.Forms.Label NumeroLbl;
        private System.Windows.Forms.ComboBox DniTuristaCbo;
        private System.Windows.Forms.Label DniTuristaLbl;
        private System.Windows.Forms.Label FechaLbl;
        private System.Windows.Forms.Label LetraLbl;
        private System.Windows.Forms.TextBox SerieTxt;
        private System.Windows.Forms.Label SerieLbl;
        private System.Windows.Forms.DateTimePicker FechaFacturaTime;
        private System.Windows.Forms.Label FormaPagolbl;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.ComboBox FormaPagoCbo;
        private System.Windows.Forms.GroupBox PaquetesGrupBox;
        private System.Windows.Forms.Button QuitarBtn;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.DataGridView PaquetesGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPaqCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAgenciaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteCol;
        private System.Windows.Forms.DataGridView DetallesGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpCol;
        private System.Windows.Forms.ComboBox LetraCbo;
        private System.Windows.Forms.TextBox DetallePagoTxt;
    }
}