﻿namespace SegundoParcialEnel.UI.Consulta
{
    partial class ConsultaArticulos
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
            this.ConsulArticulosdataGridView = new System.Windows.Forms.DataGridView();
            this.Buscar1button = new System.Windows.Forms.Button();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConsulArticulosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsulArticulosdataGridView
            // 
            this.ConsulArticulosdataGridView.AllowUserToDeleteRows = false;
            this.ConsulArticulosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsulArticulosdataGridView.Location = new System.Drawing.Point(45, 66);
            this.ConsulArticulosdataGridView.Name = "ConsulArticulosdataGridView";
            this.ConsulArticulosdataGridView.ReadOnly = true;
            this.ConsulArticulosdataGridView.Size = new System.Drawing.Size(616, 308);
            this.ConsulArticulosdataGridView.TabIndex = 35;
            // 
            // Buscar1button
            // 
            this.Buscar1button.Image = global::SegundoParcialEnel.Properties.Resources.buscar2;
            this.Buscar1button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscar1button.Location = new System.Drawing.Point(684, 11);
            this.Buscar1button.Name = "Buscar1button";
            this.Buscar1button.Size = new System.Drawing.Size(75, 67);
            this.Buscar1button.TabIndex = 34;
            this.Buscar1button.Text = "Buscar";
            this.Buscar1button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Buscar1button.UseVisualStyleBackColor = true;
            this.Buscar1button.Click += new System.EventHandler(this.Buscar1button_Click);
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(374, 22);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(269, 20);
            this.CriteriotextBox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Criterio";
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "ID",
            "Descripcion",
            "Todo"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(77, 23);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrocomboBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Filtro";
            // 
            // ConsultaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConsulArticulosdataGridView);
            this.Controls.Add(this.Buscar1button);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaArticulos";
            this.Text = "ConsultaArticulos";
            ((System.ComponentModel.ISupportInitialize)(this.ConsulArticulosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ConsulArticulosdataGridView;
        private System.Windows.Forms.Button Buscar1button;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Label label1;
    }
}