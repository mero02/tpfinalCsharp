﻿namespace TurApp.Views
{
    partial class FrmTipoActividadBusq
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
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.TipoActividadCbo = new System.Windows.Forms.ComboBox();
            this.TipoActividadChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(175, 95);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 4;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(74, 95);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 3;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // TipoActividadCbo
            // 
            this.TipoActividadCbo.DisplayMember = "Nombre";
            this.TipoActividadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoActividadCbo.Enabled = false;
            this.TipoActividadCbo.FormattingEnabled = true;
            this.TipoActividadCbo.Location = new System.Drawing.Point(117, 37);
            this.TipoActividadCbo.Margin = new System.Windows.Forms.Padding(2);
            this.TipoActividadCbo.Name = "TipoActividadCbo";
            this.TipoActividadCbo.Size = new System.Drawing.Size(150, 21);
            this.TipoActividadCbo.TabIndex = 2;
            this.TipoActividadCbo.ValueMember = "Codigo";
            // 
            // TipoActividadChk
            // 
            this.TipoActividadChk.AutoSize = true;
            this.TipoActividadChk.Location = new System.Drawing.Point(23, 39);
            this.TipoActividadChk.Margin = new System.Windows.Forms.Padding(2);
            this.TipoActividadChk.Name = "TipoActividadChk";
            this.TipoActividadChk.Size = new System.Drawing.Size(70, 17);
            this.TipoActividadChk.TabIndex = 1;
            this.TipoActividadChk.Text = "Actividad";
            this.TipoActividadChk.UseVisualStyleBackColor = true;
            this.TipoActividadChk.CheckedChanged += new System.EventHandler(this.TipoActividadChk_CheckedChanged);
            // 
            // FrmTipoActividadBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(289, 159);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.TipoActividadCbo);
            this.Controls.Add(this.TipoActividadChk);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTipoActividadBusq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Tipo Actividad...";
            this.Load += new System.EventHandler(this.FrmTipoActividadBusq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.ComboBox TipoActividadCbo;
        private System.Windows.Forms.CheckBox TipoActividadChk;
    }
}