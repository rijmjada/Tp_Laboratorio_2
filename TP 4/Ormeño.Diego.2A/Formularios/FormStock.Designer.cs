
namespace Formularios
{
    partial class FormStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStock));
            this.listStock = new System.Windows.Forms.ListBox();
            this.btnEstadisticasSemana = new System.Windows.Forms.Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listStock
            // 
            this.listStock.FormattingEnabled = true;
            this.listStock.ItemHeight = 15;
            this.listStock.Location = new System.Drawing.Point(207, 26);
            this.listStock.Name = "listStock";
            this.listStock.Size = new System.Drawing.Size(436, 169);
            this.listStock.TabIndex = 0;
            // 
            // btnEstadisticasSemana
            // 
            this.btnEstadisticasSemana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEstadisticasSemana.BackgroundImage")));
            this.btnEstadisticasSemana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadisticasSemana.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstadisticasSemana.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstadisticasSemana.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEstadisticasSemana.Location = new System.Drawing.Point(26, 65);
            this.btnEstadisticasSemana.Name = "btnEstadisticasSemana";
            this.btnEstadisticasSemana.Size = new System.Drawing.Size(150, 119);
            this.btnEstadisticasSemana.TabIndex = 1;
            this.btnEstadisticasSemana.Text = "Ventas Semana";
            this.btnEstadisticasSemana.UseVisualStyleBackColor = true;
            this.btnEstadisticasSemana.Click += new System.EventHandler(this.btnEstadisticasSemana_Click);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.BackColor = System.Drawing.Color.Transparent;
            this.lblSort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSort.Location = new System.Drawing.Point(26, 37);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(70, 15);
            this.lblSort.TabIndex = 6;
            this.lblSort.Text = "Estadisticas:";
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(657, 211);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.btnEstadisticasSemana);
            this.Controls.Add(this.listStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.FormStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listStock;
        private System.Windows.Forms.Button btnEstadisticasSemana;
        private System.Windows.Forms.Label lblSort;
    }
}