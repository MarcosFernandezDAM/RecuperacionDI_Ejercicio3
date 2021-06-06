namespace Ejercicio3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxColor1 = new System.Windows.Forms.TextBox();
            this.textBoxColor2 = new System.Windows.Forms.TextBox();
            this.textBoxColor3 = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.r = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxColor1
            // 
            this.textBoxColor1.Location = new System.Drawing.Point(91, 110);
            this.textBoxColor1.Name = "textBoxColor1";
            this.textBoxColor1.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor1.TabIndex = 0;
            this.textBoxColor1.Click += new System.EventHandler(this.EnterBoxes);
            this.textBoxColor1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // textBoxColor2
            // 
            this.textBoxColor2.Location = new System.Drawing.Point(251, 109);
            this.textBoxColor2.Name = "textBoxColor2";
            this.textBoxColor2.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor2.TabIndex = 1;
            this.textBoxColor2.Click += new System.EventHandler(this.EnterBoxes);
            this.textBoxColor2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // textBoxColor3
            // 
            this.textBoxColor3.Location = new System.Drawing.Point(417, 110);
            this.textBoxColor3.Name = "textBoxColor3";
            this.textBoxColor3.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor3.TabIndex = 2;
            this.textBoxColor3.Click += new System.EventHandler(this.EnterBoxes);
            this.textBoxColor3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(267, 176);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            this.btnColor.MouseEnter += new System.EventHandler(this.EntraRatonButton);
            this.btnColor.MouseLeave += new System.EventHandler(this.SaleRatonButton);
            this.btnColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(91, 262);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(100, 20);
            this.textBoxPath.TabIndex = 4;
            this.textBoxPath.Click += new System.EventHandler(this.EnterBoxes);
            this.textBoxPath.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // btnPath
            // 
            this.btnPath.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPath.Location = new System.Drawing.Point(267, 258);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 5;
            this.btnPath.Text = "Path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.BtnPath_Click);
            this.btnPath.MouseEnter += new System.EventHandler(this.EntraRatonButton);
            this.btnPath.MouseLeave += new System.EventHandler(this.SaleRatonButton);
            this.btnPath.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(53, 382);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.EntraRatonButton);
            this.btnSalir.MouseLeave += new System.EventHandler(this.SaleRatonButton);
            this.btnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Location = new System.Drawing.Point(131, 91);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(10, 13);
            this.r.TabIndex = 7;
            this.r.Text = "r";
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Location = new System.Drawing.Point(295, 90);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(13, 13);
            this.g.TabIndex = 8;
            this.g.Text = "g";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(466, 91);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(13, 13);
            this.b.TabIndex = 9;
            this.b.Text = "b";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnColor;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b);
            this.Controls.Add(this.g);
            this.Controls.Add(this.r);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.textBoxColor3);
            this.Controls.Add(this.textBoxColor2);
            this.Controls.Add(this.textBoxColor1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colores e Imágenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxColor1;
        private System.Windows.Forms.TextBox textBoxColor2;
        private System.Windows.Forms.TextBox textBoxColor3;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Label g;
        private System.Windows.Forms.Label b;
    }
}

