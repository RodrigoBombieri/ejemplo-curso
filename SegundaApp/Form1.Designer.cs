namespace SegundaApp
{
    partial class Form2
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lswResultado = new System.Windows.Forms.ListView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btrCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(37, 45);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 16);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "APELLIDO";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 99);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblEdad
            // 
            this.lblEdad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(37, 157);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(40, 16);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "EDAD";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(37, 219);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(71, 16);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "DIRECCIÓN";
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(37, 314);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(76, 16);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "RESULTADO";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(156, 42);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(557, 26);
            this.txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(156, 96);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(557, 26);
            this.txtNombre.TabIndex = 7;
            // 
            // txtEdad
            // 
            this.txtEdad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEdad.Location = new System.Drawing.Point(156, 154);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(89, 26);
            this.txtEdad.TabIndex = 8;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(156, 216);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(557, 26);
            this.txtDireccion.TabIndex = 9;
            // 
            // lswResultado
            // 
            this.lswResultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lswResultado.HideSelection = false;
            this.lswResultado.Location = new System.Drawing.Point(40, 333);
            this.lswResultado.Name = "lswResultado";
            this.lswResultado.Size = new System.Drawing.Size(673, 138);
            this.lswResultado.TabIndex = 10;
            this.lswResultado.UseCompatibleStateImageBehavior = false;
            this.lswResultado.View = System.Windows.Forms.View.List;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(84, 491);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(124, 42);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btrCancelar
            // 
            this.btrCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btrCancelar.Location = new System.Drawing.Point(528, 491);
            this.btrCancelar.Name = "btrCancelar";
            this.btrCancelar.Size = new System.Drawing.Size(124, 42);
            this.btrCancelar.TabIndex = 12;
            this.btrCancelar.Text = "Cancelar";
            this.btrCancelar.UseVisualStyleBackColor = true;
            this.btrCancelar.Click += new System.EventHandler(this.btrCancelar_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btrCancelar;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.btrCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lswResultado);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(949, 593);
            this.Name = "Form2";
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ListView lswResultado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btrCancelar;
    }
}

