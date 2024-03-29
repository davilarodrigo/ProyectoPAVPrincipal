﻿namespace ProyectoPAV.Formularios.Auxiliares
{
    partial class FrmCargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargos));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.textBoxNuevoCargo = new System.Windows.Forms.TextBox();
            this.lblNuevoCargo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridCargos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Delete_256x256;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Location = new System.Drawing.Point(489, 318);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 50);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackgroundImage = global::ProyectoPAV.Properties.Resources.Log_Out_256x256;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(544, 318);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // textBoxNuevoCargo
            // 
            this.textBoxNuevoCargo.Location = new System.Drawing.Point(114, 25);
            this.textBoxNuevoCargo.Name = "textBoxNuevoCargo";
            this.textBoxNuevoCargo.Size = new System.Drawing.Size(164, 20);
            this.textBoxNuevoCargo.TabIndex = 0;
            // 
            // lblNuevoCargo
            // 
            this.lblNuevoCargo.AutoSize = true;
            this.lblNuevoCargo.Location = new System.Drawing.Point(38, 28);
            this.lblNuevoCargo.Name = "lblNuevoCargo";
            this.lblNuevoCargo.Size = new System.Drawing.Size(70, 13);
            this.lblNuevoCargo.TabIndex = 41;
            this.lblNuevoCargo.Text = "Nueva Cargo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::ProyectoPAV.Properties.Resources.Add_256x256;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Location = new System.Drawing.Point(284, 9);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 50);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // dataGridCargos
            // 
            this.dataGridCargos.AllowUserToAddRows = false;
            this.dataGridCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCargos.Location = new System.Drawing.Point(12, 65);
            this.dataGridCargos.Name = "dataGridCargos";
            this.dataGridCargos.Size = new System.Drawing.Size(582, 222);
            this.dataGridCargos.TabIndex = 39;
            // 
            // FrmCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 380);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.textBoxNuevoCargo);
            this.Controls.Add(this.lblNuevoCargo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridCargos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCargos";
            this.Text = "Cargos";
            this.Load += new System.EventHandler(this.FrmCargos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCargos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox textBoxNuevoCargo;
        private System.Windows.Forms.Label lblNuevoCargo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridCargos;
    }
}