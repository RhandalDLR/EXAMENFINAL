namespace GUI
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
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelsSubMenuFormularios = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.FormIngredientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNomina = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelFormularioHijo = new System.Windows.Forms.Panel();
            this.panelMenuLateral.SuspendLayout();
            this.panelsSubMenuFormularios.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenuLateral.Controls.Add(this.panelsSubMenuFormularios);
            this.panelMenuLateral.Controls.Add(this.btnNomina);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.ForeColor = System.Drawing.Color.DarkBlue;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(200, 668);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // panelsSubMenuFormularios
            // 
            this.panelsSubMenuFormularios.Controls.Add(this.button3);
            this.panelsSubMenuFormularios.Controls.Add(this.FormIngredientes);
            this.panelsSubMenuFormularios.Controls.Add(this.button1);
            this.panelsSubMenuFormularios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsSubMenuFormularios.Location = new System.Drawing.Point(0, 110);
            this.panelsSubMenuFormularios.Name = "panelsSubMenuFormularios";
            this.panelsSubMenuFormularios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelsSubMenuFormularios.Size = new System.Drawing.Size(200, 138);
            this.panelsSubMenuFormularios.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.GhostWhite;
            this.button3.Location = new System.Drawing.Point(10, 46);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(190, 21);
            this.button3.TabIndex = 3;
            this.button3.Text = "Facturacion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormIngredientes
            // 
            this.FormIngredientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormIngredientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormIngredientes.ForeColor = System.Drawing.Color.GhostWhite;
            this.FormIngredientes.Location = new System.Drawing.Point(10, 23);
            this.FormIngredientes.Name = "FormIngredientes";
            this.FormIngredientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.FormIngredientes.Size = new System.Drawing.Size(190, 23);
            this.FormIngredientes.TabIndex = 2;
            this.FormIngredientes.Text = "Ingredientes";
            this.FormIngredientes.UseVisualStyleBackColor = true;
            this.FormIngredientes.Click += new System.EventHandler(this.FormIngredientes_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.GhostWhite;
            this.button1.Location = new System.Drawing.Point(10, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(190, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nomina Profesores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNomina
            // 
            this.btnNomina.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNomina.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnNomina.Location = new System.Drawing.Point(0, 65);
            this.btnNomina.Name = "btnNomina";
            this.btnNomina.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNomina.Size = new System.Drawing.Size(200, 45);
            this.btnNomina.TabIndex = 1;
            this.btnNomina.Text = "FORMULARIOS";
            this.btnNomina.UseVisualStyleBackColor = true;
            this.btnNomina.Click += new System.EventHandler(this.btnNomina_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 65);
            this.panelLogo.TabIndex = 1;
            // 
            // panelFormularioHijo
            // 
            this.panelFormularioHijo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelFormularioHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularioHijo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelFormularioHijo.Location = new System.Drawing.Point(200, 0);
            this.panelFormularioHijo.Name = "panelFormularioHijo";
            this.panelFormularioHijo.Size = new System.Drawing.Size(756, 668);
            this.panelFormularioHijo.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 668);
            this.Controls.Add(this.panelFormularioHijo);
            this.Controls.Add(this.panelMenuLateral);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenuLateral.ResumeLayout(false);
            this.panelsSubMenuFormularios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Button btnNomina;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelsSubMenuFormularios;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button FormIngredientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelFormularioHijo;
    }
}

