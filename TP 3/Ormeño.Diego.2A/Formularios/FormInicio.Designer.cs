
namespace Formularios
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.btnVisualizaciones = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarProductos.BackgroundImage")));
            this.btnAgregarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProductos.FlatAppearance.BorderSize = 0;
            this.btnAgregarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProductos.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarProductos.Location = new System.Drawing.Point(80, 83);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(223, 51);
            this.btnAgregarProductos.TabIndex = 0;
            this.btnAgregarProductos.Text = "Agregar Productos";
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // btnVisualizaciones
            // 
            this.btnVisualizaciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVisualizaciones.BackgroundImage")));
            this.btnVisualizaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVisualizaciones.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizaciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVisualizaciones.Location = new System.Drawing.Point(80, 154);
            this.btnVisualizaciones.Name = "btnVisualizaciones";
            this.btnVisualizaciones.Size = new System.Drawing.Size(223, 51);
            this.btnVisualizaciones.TabIndex = 1;
            this.btnVisualizaciones.Text = "Visualizar Stock";
            this.btnVisualizaciones.UseVisualStyleBackColor = true;
            this.btnVisualizaciones.Click += new System.EventHandler(this.btnVisualizaciones_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVentas.BackgroundImage")));
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVentas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVentas.Location = new System.Drawing.Point(80, 223);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(223, 51);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Vender Producto";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(80, 297);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(223, 51);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(382, 388);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnVisualizaciones);
            this.Controls.Add(this.btnAgregarProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInicio_FormClosed);
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Button btnVisualizaciones;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnExit;
    }
}

