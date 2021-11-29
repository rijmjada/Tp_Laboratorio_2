
namespace Calculadora_de_Ormeño.Diego
{
    partial class DiegoOrmenio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiegoOrmenio));
            this.btnOperar = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.cmbBoxOperator = new System.Windows.Forms.ComboBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblOperar = new System.Windows.Forms.Label();
            this.btnConvertirABinario = new System.Windows.Forms.Button();
            this.btnConvertirADecimal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.listBoxHistorial = new System.Windows.Forms.ListBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOperar
            // 
            this.btnOperar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnOperar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOperar.BackgroundImage")));
            this.btnOperar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperar.FlatAppearance.BorderSize = 0;
            this.btnOperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOperar.ForeColor = System.Drawing.Color.Black;
            this.btnOperar.Location = new System.Drawing.Point(14, 304);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(63, 58);
            this.btnOperar.TabIndex = 6;
            this.btnOperar.UseVisualStyleBackColor = false;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Font = new System.Drawing.Font("Super Mario Bros. 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBox1.Location = new System.Drawing.Point(5, 182);
            this.txtBox1.MaxLength = 17;
            this.txtBox1.Multiline = true;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(288, 29);
            this.txtBox1.TabIndex = 3;
            this.txtBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox1_KeyPress);
            // 
            // cmbBoxOperator
            // 
            this.cmbBoxOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxOperator.Font = new System.Drawing.Font("Super Mario Bros. 2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBoxOperator.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbBoxOperator.FormattingEnabled = true;
            this.cmbBoxOperator.Items.AddRange(new object[] {
            "/",
            "+",
            "-",
            "*"});
            this.cmbBoxOperator.Location = new System.Drawing.Point(5, 217);
            this.cmbBoxOperator.Name = "cmbBoxOperator";
            this.cmbBoxOperator.Size = new System.Drawing.Size(288, 29);
            this.cmbBoxOperator.TabIndex = 4;
            // 
            // txtBox2
            // 
            this.txtBox2.Font = new System.Drawing.Font("Super Mario Bros. 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBox2.Location = new System.Drawing.Point(5, 251);
            this.txtBox2.MaxLength = 17;
            this.txtBox2.Multiline = true;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(288, 29);
            this.txtBox2.TabIndex = 5;
            this.txtBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox2_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(96, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 73);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(209, 303);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(67, 58);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblOperar
            // 
            this.lblOperar.AutoSize = true;
            this.lblOperar.BackColor = System.Drawing.Color.White;
            this.lblOperar.Font = new System.Drawing.Font("Super Mario Bros. 2", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOperar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblOperar.Location = new System.Drawing.Point(7, 382);
            this.lblOperar.Name = "lblOperar";
            this.lblOperar.Size = new System.Drawing.Size(79, 14);
            this.lblOperar.TabIndex = 12;
            this.lblOperar.Text = "Operar";
            // 
            // btnConvertirABinario
            // 
            this.btnConvertirABinario.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnConvertirABinario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConvertirABinario.BackgroundImage")));
            this.btnConvertirABinario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConvertirABinario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvertirABinario.FlatAppearance.BorderSize = 0;
            this.btnConvertirABinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertirABinario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvertirABinario.ForeColor = System.Drawing.Color.Black;
            this.btnConvertirABinario.Location = new System.Drawing.Point(396, 426);
            this.btnConvertirABinario.Name = "btnConvertirABinario";
            this.btnConvertirABinario.Size = new System.Drawing.Size(377, 32);
            this.btnConvertirABinario.TabIndex = 10;
            this.btnConvertirABinario.UseVisualStyleBackColor = false;
            this.btnConvertirABinario.Click += new System.EventHandler(this.btnConvertirABinario_Click);
            // 
            // btnConvertirADecimal
            // 
            this.btnConvertirADecimal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnConvertirADecimal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConvertirADecimal.BackgroundImage")));
            this.btnConvertirADecimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConvertirADecimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvertirADecimal.FlatAppearance.BorderSize = 0;
            this.btnConvertirADecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertirADecimal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvertirADecimal.ForeColor = System.Drawing.Color.Black;
            this.btnConvertirADecimal.Location = new System.Drawing.Point(8, 426);
            this.btnConvertirADecimal.Name = "btnConvertirADecimal";
            this.btnConvertirADecimal.Size = new System.Drawing.Size(377, 32);
            this.btnConvertirADecimal.TabIndex = 9;
            this.btnConvertirADecimal.UseVisualStyleBackColor = false;
            this.btnConvertirADecimal.Click += new System.EventHandler(this.btnConvertirADecimal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Super Mario Bros. 2", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(103, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "limpiar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Super Mario Bros. 2", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(205, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cerrar";
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Super Mario Bros. 2", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.Color.Red;
            this.lblResultado.Location = new System.Drawing.Point(293, 19);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(480, 33);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxHistorial
            // 
            this.listBoxHistorial.BackColor = System.Drawing.Color.Lavender;
            this.listBoxHistorial.FormattingEnabled = true;
            this.listBoxHistorial.ItemHeight = 15;
            this.listBoxHistorial.Location = new System.Drawing.Point(619, 81);
            this.listBoxHistorial.Name = "listBoxHistorial";
            this.listBoxHistorial.Size = new System.Drawing.Size(154, 139);
            this.listBoxHistorial.TabIndex = 2;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Super Mario Bros. 2", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHistorial.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblHistorial.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblHistorial.Location = new System.Drawing.Point(658, 64);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(115, 14);
            this.lblHistorial.TabIndex = 20;
            this.lblHistorial.Text = "Historial";
            // 
            // DiegoOrmenio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 483);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.listBoxHistorial);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertirADecimal);
            this.Controls.Add(this.btnConvertirABinario);
            this.Controls.Add(this.lblOperar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.cmbBoxOperator);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.btnOperar);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiegoOrmenio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diego.Ormeño";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DiegoOrmenio_FormClosing);
            this.Load += new System.EventHandler(this.DiegoOrmenio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.ComboBox cmbBoxOperator;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblOperar;
        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.Button btnConvertirADecimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ListBox listBoxHistorial;
        private System.Windows.Forms.Label lblHistorial;
    }
}

