namespace Presentacion
{
    partial class frm_ModuloUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ModuloUsuarios));
            this.txt_id = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_pnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_snombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_papellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_sapellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_contacto = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_correo = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_direccion = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_cancelar = new MaterialSkin.Controls.MaterialButton();
            this.btn_guardar = new MaterialSkin.Controls.MaterialButton();
            this.btn_actualizar = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dbs_prestamos_deportivosDataSet = new Presentacion.dbs_prestamos_deportivosDataSet();
            this.tblsexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sexoTableAdapter = new Presentacion.dbs_prestamos_deportivosDataSetTableAdapters.tbl_sexoTableAdapter();
            this.cbx_sexo = new MaterialSkin.Controls.MaterialComboBox();
            this.dbs_prestamos_deportivosDataSet1 = new Presentacion.dbs_prestamos_deportivosDataSet1();
            this.tblsexoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sexoTableAdapter1 = new Presentacion.dbs_prestamos_deportivosDataSet1TableAdapters.tbl_sexoTableAdapter();
            this.dbsprestamosdeportivosDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsexoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsprestamosdeportivosDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.AnimateReadOnly = false;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Depth = 0;
            this.txt_id.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_id.Hint = "Identificación";
            this.txt_id.LeadingIcon = null;
            this.txt_id.Location = new System.Drawing.Point(14, 29);
            this.txt_id.MaxLength = 50;
            this.txt_id.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(233, 50);
            this.txt_id.TabIndex = 0;
            this.txt_id.Text = "";
            this.txt_id.TrailingIcon = null;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // txt_pnombre
            // 
            this.txt_pnombre.AnimateReadOnly = false;
            this.txt_pnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pnombre.Depth = 0;
            this.txt_pnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_pnombre.Hint = "Primer Nombre";
            this.txt_pnombre.LeadingIcon = null;
            this.txt_pnombre.Location = new System.Drawing.Point(253, 29);
            this.txt_pnombre.MaxLength = 50;
            this.txt_pnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_pnombre.Multiline = false;
            this.txt_pnombre.Name = "txt_pnombre";
            this.txt_pnombre.Size = new System.Drawing.Size(270, 50);
            this.txt_pnombre.TabIndex = 1;
            this.txt_pnombre.Text = "";
            this.txt_pnombre.TrailingIcon = null;
            this.txt_pnombre.TextChanged += new System.EventHandler(this.txt_pnombre_TextChanged);
            // 
            // txt_snombre
            // 
            this.txt_snombre.AnimateReadOnly = false;
            this.txt_snombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_snombre.Depth = 0;
            this.txt_snombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_snombre.Hint = "Segundo Nombre";
            this.txt_snombre.LeadingIcon = null;
            this.txt_snombre.Location = new System.Drawing.Point(529, 29);
            this.txt_snombre.MaxLength = 50;
            this.txt_snombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_snombre.Multiline = false;
            this.txt_snombre.Name = "txt_snombre";
            this.txt_snombre.Size = new System.Drawing.Size(229, 50);
            this.txt_snombre.TabIndex = 2;
            this.txt_snombre.Text = "";
            this.txt_snombre.TrailingIcon = null;
            this.txt_snombre.TextChanged += new System.EventHandler(this.txt_snombre_TextChanged);
            // 
            // txt_papellido
            // 
            this.txt_papellido.AnimateReadOnly = false;
            this.txt_papellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_papellido.Depth = 0;
            this.txt_papellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_papellido.Hint = "Primer Apellido";
            this.txt_papellido.LeadingIcon = null;
            this.txt_papellido.Location = new System.Drawing.Point(14, 85);
            this.txt_papellido.MaxLength = 50;
            this.txt_papellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_papellido.Multiline = false;
            this.txt_papellido.Name = "txt_papellido";
            this.txt_papellido.Size = new System.Drawing.Size(233, 50);
            this.txt_papellido.TabIndex = 3;
            this.txt_papellido.Text = "";
            this.txt_papellido.TrailingIcon = null;
            this.txt_papellido.TextChanged += new System.EventHandler(this.txt_papellido_TextChanged);
            // 
            // txt_sapellido
            // 
            this.txt_sapellido.AnimateReadOnly = false;
            this.txt_sapellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sapellido.Depth = 0;
            this.txt_sapellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_sapellido.Hint = "Segundo Apellido";
            this.txt_sapellido.LeadingIcon = null;
            this.txt_sapellido.Location = new System.Drawing.Point(253, 85);
            this.txt_sapellido.MaxLength = 50;
            this.txt_sapellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_sapellido.Multiline = false;
            this.txt_sapellido.Name = "txt_sapellido";
            this.txt_sapellido.Size = new System.Drawing.Size(270, 50);
            this.txt_sapellido.TabIndex = 4;
            this.txt_sapellido.Text = "";
            this.txt_sapellido.TrailingIcon = null;
            this.txt_sapellido.TextChanged += new System.EventHandler(this.txt_sapellido_TextChanged);
            // 
            // txt_contacto
            // 
            this.txt_contacto.AnimateReadOnly = false;
            this.txt_contacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contacto.Depth = 0;
            this.txt_contacto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_contacto.Hint = "Contacto";
            this.txt_contacto.LeadingIcon = null;
            this.txt_contacto.Location = new System.Drawing.Point(529, 85);
            this.txt_contacto.MaxLength = 50;
            this.txt_contacto.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_contacto.Multiline = false;
            this.txt_contacto.Name = "txt_contacto";
            this.txt_contacto.Size = new System.Drawing.Size(229, 50);
            this.txt_contacto.TabIndex = 5;
            this.txt_contacto.Text = "";
            this.txt_contacto.TrailingIcon = null;
            this.txt_contacto.TextChanged += new System.EventHandler(this.txt_contacto_TextChanged);
            // 
            // txt_correo
            // 
            this.txt_correo.AnimateReadOnly = false;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Depth = 0;
            this.txt_correo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_correo.Hint = "Correo";
            this.txt_correo.LeadingIcon = null;
            this.txt_correo.Location = new System.Drawing.Point(11, 141);
            this.txt_correo.MaxLength = 50;
            this.txt_correo.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_correo.Multiline = false;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(512, 50);
            this.txt_correo.TabIndex = 6;
            this.txt_correo.Text = "";
            this.txt_correo.TrailingIcon = null;
            this.txt_correo.TextChanged += new System.EventHandler(this.txt_correo_TextChanged);
            // 
            // txt_direccion
            // 
            this.txt_direccion.AnimateReadOnly = false;
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_direccion.Depth = 0;
            this.txt_direccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_direccion.Hint = "Dirección";
            this.txt_direccion.LeadingIcon = null;
            this.txt_direccion.Location = new System.Drawing.Point(11, 197);
            this.txt_direccion.MaxLength = 50;
            this.txt_direccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_direccion.Multiline = false;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(752, 50);
            this.txt_direccion.TabIndex = 7;
            this.txt_direccion.Text = "";
            this.txt_direccion.TrailingIcon = null;
            this.txt_direccion.TextChanged += new System.EventHandler(this.txt_direccion_TextChanged);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancelar.Depth = 0;
            this.btn_cancelar.HighEmphasis = true;
            this.btn_cancelar.Icon = null;
            this.btn_cancelar.Location = new System.Drawing.Point(667, 256);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancelar.Size = new System.Drawing.Size(96, 36);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancelar.UseAccentColor = false;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_guardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_guardar.Depth = 0;
            this.btn_guardar.HighEmphasis = true;
            this.btn_guardar.Icon = null;
            this.btn_guardar.Location = new System.Drawing.Point(560, 256);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_guardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_guardar.Size = new System.Drawing.Size(88, 36);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_guardar.UseAccentColor = false;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_actualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_actualizar.Depth = 0;
            this.btn_actualizar.HighEmphasis = true;
            this.btn_actualizar.Icon = null;
            this.btn_actualizar.Location = new System.Drawing.Point(443, 256);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_actualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_actualizar.Size = new System.Drawing.Size(109, 36);
            this.btn_actualizar.TabIndex = 11;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_actualizar.UseAccentColor = false;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(785, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dbs_prestamos_deportivosDataSet
            // 
            this.dbs_prestamos_deportivosDataSet.DataSetName = "dbs_prestamos_deportivosDataSet";
            this.dbs_prestamos_deportivosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblsexoBindingSource
            // 
            this.tblsexoBindingSource.DataMember = "tbl_sexo";
            this.tblsexoBindingSource.DataSource = this.dbs_prestamos_deportivosDataSet;
            // 
            // tbl_sexoTableAdapter
            // 
            this.tbl_sexoTableAdapter.ClearBeforeFill = true;
            // 
            // cbx_sexo
            // 
            this.cbx_sexo.AutoResize = false;
            this.cbx_sexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbx_sexo.DataSource = this.tblsexoBindingSource1;
            this.cbx_sexo.Depth = 0;
            this.cbx_sexo.DisplayMember = "Nombre";
            this.cbx_sexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbx_sexo.DropDownHeight = 174;
            this.cbx_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_sexo.DropDownWidth = 121;
            this.cbx_sexo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbx_sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbx_sexo.FormattingEnabled = true;
            this.cbx_sexo.Hint = "Sexo";
            this.cbx_sexo.IntegralHeight = false;
            this.cbx_sexo.ItemHeight = 43;
            this.cbx_sexo.Location = new System.Drawing.Point(527, 140);
            this.cbx_sexo.MaxDropDownItems = 4;
            this.cbx_sexo.MouseState = MaterialSkin.MouseState.OUT;
            this.cbx_sexo.Name = "cbx_sexo";
            this.cbx_sexo.Size = new System.Drawing.Size(231, 49);
            this.cbx_sexo.StartIndex = 0;
            this.cbx_sexo.TabIndex = 13;
            this.cbx_sexo.ValueMember = "PKId";
            // 
            // dbs_prestamos_deportivosDataSet1
            // 
            this.dbs_prestamos_deportivosDataSet1.DataSetName = "dbs_prestamos_deportivosDataSet1";
            this.dbs_prestamos_deportivosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblsexoBindingSource1
            // 
            this.tblsexoBindingSource1.DataMember = "tbl_sexo";
            this.tblsexoBindingSource1.DataSource = this.dbs_prestamos_deportivosDataSet1;
            // 
            // tbl_sexoTableAdapter1
            // 
            this.tbl_sexoTableAdapter1.ClearBeforeFill = true;
            // 
            // dbsprestamosdeportivosDataSet1BindingSource
            // 
            this.dbsprestamosdeportivosDataSet1BindingSource.DataSource = this.dbs_prestamos_deportivosDataSet1;
            this.dbsprestamosdeportivosDataSet1BindingSource.Position = 0;
            // 
            // frm_ModuloUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 302);
            this.Controls.Add(this.cbx_sexo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_contacto);
            this.Controls.Add(this.txt_sapellido);
            this.Controls.Add(this.txt_papellido);
            this.Controls.Add(this.txt_snombre);
            this.Controls.Add(this.txt_pnombre);
            this.Controls.Add(this.txt_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_ModuloUsuarios";
            this.Text = "MÓDULO - REGISTRO USUARIOS";
            this.Load += new System.EventHandler(this.frm_ModuloUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsexoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsprestamosdeportivosDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_id;
        private MaterialSkin.Controls.MaterialTextBox txt_pnombre;
        private MaterialSkin.Controls.MaterialTextBox txt_snombre;
        private MaterialSkin.Controls.MaterialTextBox txt_papellido;
        private MaterialSkin.Controls.MaterialTextBox txt_sapellido;
        private MaterialSkin.Controls.MaterialTextBox txt_contacto;
        private MaterialSkin.Controls.MaterialTextBox txt_correo;
        private MaterialSkin.Controls.MaterialTextBox txt_direccion;
        private MaterialSkin.Controls.MaterialButton btn_cancelar;
        private MaterialSkin.Controls.MaterialButton btn_guardar;
        private MaterialSkin.Controls.MaterialButton btn_actualizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private dbs_prestamos_deportivosDataSet dbs_prestamos_deportivosDataSet;
        private System.Windows.Forms.BindingSource tblsexoBindingSource;
        private dbs_prestamos_deportivosDataSetTableAdapters.tbl_sexoTableAdapter tbl_sexoTableAdapter;
        private MaterialSkin.Controls.MaterialComboBox cbx_sexo;
        private dbs_prestamos_deportivosDataSet1 dbs_prestamos_deportivosDataSet1;
        private System.Windows.Forms.BindingSource tblsexoBindingSource1;
        private dbs_prestamos_deportivosDataSet1TableAdapters.tbl_sexoTableAdapter tbl_sexoTableAdapter1;
        private System.Windows.Forms.BindingSource dbsprestamosdeportivosDataSet1BindingSource;
    }
}

