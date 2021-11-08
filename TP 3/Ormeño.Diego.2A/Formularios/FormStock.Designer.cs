
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
            this.btnOrdenarPorPrecio = new System.Windows.Forms.Button();
            this.btnOrdenarPorTipo = new System.Windows.Forms.Button();
            this.btnOrdenarPorOrigen = new System.Windows.Forms.Button();
            this.btnOrdenarPorGanancia = new System.Windows.Forms.Button();
            this.lblListaProductos = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listStock
            // 
            this.listStock.FormattingEnabled = true;
            this.listStock.ItemHeight = 15;
            this.listStock.Location = new System.Drawing.Point(157, 37);
            this.listStock.Name = "listStock";
            this.listStock.Size = new System.Drawing.Size(545, 244);
            this.listStock.TabIndex = 0;
            // 
            // btnOrdenarPorPrecio
            // 
            this.btnOrdenarPorPrecio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrdenarPorPrecio.BackgroundImage")));
            this.btnOrdenarPorPrecio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenarPorPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrdenarPorPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrdenarPorPrecio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrdenarPorPrecio.Location = new System.Drawing.Point(26, 59);
            this.btnOrdenarPorPrecio.Name = "btnOrdenarPorPrecio";
            this.btnOrdenarPorPrecio.Size = new System.Drawing.Size(106, 35);
            this.btnOrdenarPorPrecio.TabIndex = 1;
            this.btnOrdenarPorPrecio.Text = "Precio";
            this.btnOrdenarPorPrecio.UseVisualStyleBackColor = true;
            this.btnOrdenarPorPrecio.Click += new System.EventHandler(this.btnOrdenarPorPrecio_Click);
            // 
            // btnOrdenarPorTipo
            // 
            this.btnOrdenarPorTipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrdenarPorTipo.BackgroundImage")));
            this.btnOrdenarPorTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenarPorTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrdenarPorTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrdenarPorTipo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrdenarPorTipo.Location = new System.Drawing.Point(26, 111);
            this.btnOrdenarPorTipo.Name = "btnOrdenarPorTipo";
            this.btnOrdenarPorTipo.Size = new System.Drawing.Size(106, 35);
            this.btnOrdenarPorTipo.TabIndex = 2;
            this.btnOrdenarPorTipo.Text = " Tipo";
            this.btnOrdenarPorTipo.UseVisualStyleBackColor = true;
            this.btnOrdenarPorTipo.Click += new System.EventHandler(this.btnOrdenarPorTipo_Click);
            // 
            // btnOrdenarPorOrigen
            // 
            this.btnOrdenarPorOrigen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrdenarPorOrigen.BackgroundImage")));
            this.btnOrdenarPorOrigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenarPorOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrdenarPorOrigen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrdenarPorOrigen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrdenarPorOrigen.Location = new System.Drawing.Point(26, 165);
            this.btnOrdenarPorOrigen.Name = "btnOrdenarPorOrigen";
            this.btnOrdenarPorOrigen.Size = new System.Drawing.Size(106, 35);
            this.btnOrdenarPorOrigen.TabIndex = 3;
            this.btnOrdenarPorOrigen.Text = "Origen";
            this.btnOrdenarPorOrigen.UseVisualStyleBackColor = true;
            this.btnOrdenarPorOrigen.Click += new System.EventHandler(this.btnOrdenarPorOrigen_Click);
            // 
            // btnOrdenarPorGanancia
            // 
            this.btnOrdenarPorGanancia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrdenarPorGanancia.BackgroundImage")));
            this.btnOrdenarPorGanancia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenarPorGanancia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrdenarPorGanancia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrdenarPorGanancia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrdenarPorGanancia.Location = new System.Drawing.Point(26, 220);
            this.btnOrdenarPorGanancia.Name = "btnOrdenarPorGanancia";
            this.btnOrdenarPorGanancia.Size = new System.Drawing.Size(106, 35);
            this.btnOrdenarPorGanancia.TabIndex = 4;
            this.btnOrdenarPorGanancia.Text = " Ganancia";
            this.btnOrdenarPorGanancia.UseVisualStyleBackColor = true;
            this.btnOrdenarPorGanancia.Click += new System.EventHandler(this.btnOrdenarPorGanancia_Click);
            // 
            // lblListaProductos
            // 
            this.lblListaProductos.AutoSize = true;
            this.lblListaProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblListaProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblListaProductos.Location = new System.Drawing.Point(157, 19);
            this.lblListaProductos.Name = "lblListaProductos";
            this.lblListaProductos.Size = new System.Drawing.Size(107, 15);
            this.lblListaProductos.TabIndex = 5;
            this.lblListaProductos.Text = "Lista de Productos:";
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.BackColor = System.Drawing.Color.Transparent;
            this.lblSort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSort.Location = new System.Drawing.Point(26, 37);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(74, 15);
            this.lblSort.TabIndex = 6;
            this.lblSort.Text = "Ordenar por:";
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(714, 293);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.lblListaProductos);
            this.Controls.Add(this.btnOrdenarPorGanancia);
            this.Controls.Add(this.btnOrdenarPorOrigen);
            this.Controls.Add(this.btnOrdenarPorTipo);
            this.Controls.Add(this.btnOrdenarPorPrecio);
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
        private System.Windows.Forms.Button btnOrdenarPorPrecio;
        private System.Windows.Forms.Button btnOrdenarPorTipo;
        private System.Windows.Forms.Button btnOrdenarPorOrigen;
        private System.Windows.Forms.Button btnOrdenarPorGanancia;
        private System.Windows.Forms.Label lblListaProductos;
        private System.Windows.Forms.Label lblSort;
    }
}