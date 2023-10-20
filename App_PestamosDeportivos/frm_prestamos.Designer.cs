namespace App_PestamosDeportivos
{
    partial class frm_prestamos
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
            this.txtId = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtImplemento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtExistencias = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombreImpedimento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCantidadaPrestar = new MaterialSkin.Controls.MaterialTextBox();
            this.btnrealizarprestamo = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.txtobservaciones = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnagregar = new MaterialSkin.Controls.MaterialButton();
            this.dtg_prestamos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_prestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.AnimateReadOnly = false;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Depth = 0;
            this.txtId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.LeadingIcon = null;
            this.txtId.Location = new System.Drawing.Point(42, 38);
            this.txtId.MaxLength = 50;
            this.txtId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(327, 50);
            this.txtId.TabIndex = 0;
            this.txtId.Text = "Identificacion de la persona";
            this.txtId.TrailingIcon = null;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(376, 38);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(376, 50);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombres Persona";
            this.txtNombre.TrailingIcon = null;
            // 
            // txtImplemento
            // 
            this.txtImplemento.AnimateReadOnly = false;
            this.txtImplemento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImplemento.Depth = 0;
            this.txtImplemento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtImplemento.LeadingIcon = null;
            this.txtImplemento.Location = new System.Drawing.Point(42, 106);
            this.txtImplemento.MaxLength = 50;
            this.txtImplemento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImplemento.Multiline = false;
            this.txtImplemento.Name = "txtImplemento";
            this.txtImplemento.Size = new System.Drawing.Size(327, 50);
            this.txtImplemento.TabIndex = 2;
            this.txtImplemento.Text = "Codigo Implemento";
            this.txtImplemento.TrailingIcon = null;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AnimateReadOnly = false;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescripcion.LeadingIcon = null;
            this.txtDescripcion.Location = new System.Drawing.Point(376, 106);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcion.Multiline = false;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(376, 50);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Text = "Descripción";
            this.txtDescripcion.TrailingIcon = null;
            // 
            // txtExistencias
            // 
            this.txtExistencias.AnimateReadOnly = false;
            this.txtExistencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExistencias.Depth = 0;
            this.txtExistencias.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtExistencias.LeadingIcon = null;
            this.txtExistencias.Location = new System.Drawing.Point(42, 163);
            this.txtExistencias.MaxLength = 50;
            this.txtExistencias.MouseState = MaterialSkin.MouseState.OUT;
            this.txtExistencias.Multiline = false;
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(327, 50);
            this.txtExistencias.TabIndex = 4;
            this.txtExistencias.Text = "Existencias";
            this.txtExistencias.TrailingIcon = null;
            // 
            // txtNombreImpedimento
            // 
            this.txtNombreImpedimento.AnimateReadOnly = false;
            this.txtNombreImpedimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreImpedimento.Depth = 0;
            this.txtNombreImpedimento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreImpedimento.LeadingIcon = null;
            this.txtNombreImpedimento.Location = new System.Drawing.Point(376, 163);
            this.txtNombreImpedimento.MaxLength = 50;
            this.txtNombreImpedimento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreImpedimento.Multiline = false;
            this.txtNombreImpedimento.Name = "txtNombreImpedimento";
            this.txtNombreImpedimento.Size = new System.Drawing.Size(384, 50);
            this.txtNombreImpedimento.TabIndex = 5;
            this.txtNombreImpedimento.Text = "Nombre impedimento";
            this.txtNombreImpedimento.TrailingIcon = null;
            // 
            // txtCantidadaPrestar
            // 
            this.txtCantidadaPrestar.AnimateReadOnly = false;
            this.txtCantidadaPrestar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadaPrestar.Depth = 0;
            this.txtCantidadaPrestar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidadaPrestar.LeadingIcon = null;
            this.txtCantidadaPrestar.Location = new System.Drawing.Point(42, 220);
            this.txtCantidadaPrestar.MaxLength = 50;
            this.txtCantidadaPrestar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidadaPrestar.Multiline = false;
            this.txtCantidadaPrestar.Name = "txtCantidadaPrestar";
            this.txtCantidadaPrestar.Size = new System.Drawing.Size(327, 50);
            this.txtCantidadaPrestar.TabIndex = 6;
            this.txtCantidadaPrestar.Text = "Cantidad a prestar";
            this.txtCantidadaPrestar.TrailingIcon = null;
            // 
            // btnrealizarprestamo
            // 
            this.btnrealizarprestamo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnrealizarprestamo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnrealizarprestamo.Depth = 0;
            this.btnrealizarprestamo.HighEmphasis = true;
            this.btnrealizarprestamo.Icon = null;
            this.btnrealizarprestamo.Location = new System.Drawing.Point(54, 292);
            this.btnrealizarprestamo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnrealizarprestamo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnrealizarprestamo.Name = "btnrealizarprestamo";
            this.btnrealizarprestamo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnrealizarprestamo.Size = new System.Drawing.Size(85, 36);
            this.btnrealizarprestamo.TabIndex = 7;
            this.btnrealizarprestamo.Text = "Prestar";
            this.btnrealizarprestamo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnrealizarprestamo.UseAccentColor = false;
            this.btnrealizarprestamo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(160, 292);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.AnimateReadOnly = false;
            this.txtobservaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtobservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtobservaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtobservaciones.Depth = 0;
            this.txtobservaciones.HideSelection = true;
            this.txtobservaciones.Location = new System.Drawing.Point(376, 220);
            this.txtobservaciones.MaxLength = 32767;
            this.txtobservaciones.MouseState = MaterialSkin.MouseState.OUT;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.PasswordChar = '\0';
            this.txtobservaciones.ReadOnly = false;
            this.txtobservaciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtobservaciones.SelectedText = "";
            this.txtobservaciones.SelectionLength = 0;
            this.txtobservaciones.SelectionStart = 0;
            this.txtobservaciones.ShortcutsEnabled = true;
            this.txtobservaciones.Size = new System.Drawing.Size(384, 108);
            this.txtobservaciones.TabIndex = 9;
            this.txtobservaciones.TabStop = false;
            this.txtobservaciones.Text = "Observaciones";
            this.txtobservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtobservaciones.UseSystemPasswordChar = false;
            // 
            // btnagregar
            // 
            this.btnagregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnagregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnagregar.Depth = 0;
            this.btnagregar.HighEmphasis = true;
            this.btnagregar.Icon = null;
            this.btnagregar.Location = new System.Drawing.Point(277, 292);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnagregar.Size = new System.Drawing.Size(64, 36);
            this.btnagregar.TabIndex = 10;
            this.btnagregar.Text = "+";
            this.btnagregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnagregar.UseAccentColor = false;
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // dtg_prestamos
            // 
            this.dtg_prestamos.AllowUserToAddRows = false;
            this.dtg_prestamos.AllowUserToDeleteRows = false;
            this.dtg_prestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_prestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_prestamos.Location = new System.Drawing.Point(54, 357);
            this.dtg_prestamos.Name = "dtg_prestamos";
            this.dtg_prestamos.ReadOnly = true;
            this.dtg_prestamos.Size = new System.Drawing.Size(706, 162);
            this.dtg_prestamos.TabIndex = 11;
            // 
            // frm_prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.dtg_prestamos);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtobservaciones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnrealizarprestamo);
            this.Controls.Add(this.txtCantidadaPrestar);
            this.Controls.Add(this.txtNombreImpedimento);
            this.Controls.Add(this.txtExistencias);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtImplemento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Name = "frm_prestamos";
            this.Text = "frm_prestamos";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_prestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtId;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtImplemento;
        private MaterialSkin.Controls.MaterialTextBox txtDescripcion;
        private MaterialSkin.Controls.MaterialTextBox txtExistencias;
        private MaterialSkin.Controls.MaterialTextBox txtNombreImpedimento;
        private MaterialSkin.Controls.MaterialTextBox txtCantidadaPrestar;
        private MaterialSkin.Controls.MaterialButton btnrealizarprestamo;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtobservaciones;
        private MaterialSkin.Controls.MaterialButton btnagregar;
        private System.Windows.Forms.DataGridView dtg_prestamos;
    }
}