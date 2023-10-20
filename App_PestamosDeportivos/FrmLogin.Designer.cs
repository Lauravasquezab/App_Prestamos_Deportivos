namespace App_PestamosDeportivos
{
    partial class FrmLogin
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
            this.frmUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.frmContraseña = new MaterialSkin.Controls.MaterialTextBox();
            this.btningresar = new MaterialSkin.Controls.MaterialButton();
            this.frmCancelar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // frmUsuario
            // 
            this.frmUsuario.AnimateReadOnly = false;
            this.frmUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.frmUsuario.Depth = 0;
            this.frmUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.frmUsuario.LeadingIcon = null;
            this.frmUsuario.Location = new System.Drawing.Point(132, 72);
            this.frmUsuario.MaxLength = 50;
            this.frmUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.frmUsuario.Multiline = false;
            this.frmUsuario.Name = "frmUsuario";
            this.frmUsuario.Size = new System.Drawing.Size(480, 50);
            this.frmUsuario.TabIndex = 0;
            this.frmUsuario.Text = "Usuario";
            this.frmUsuario.TrailingIcon = null;
            // 
            // frmContraseña
            // 
            this.frmContraseña.AnimateReadOnly = false;
            this.frmContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.frmContraseña.Depth = 0;
            this.frmContraseña.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.frmContraseña.LeadingIcon = null;
            this.frmContraseña.Location = new System.Drawing.Point(132, 139);
            this.frmContraseña.MaxLength = 50;
            this.frmContraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.frmContraseña.Multiline = false;
            this.frmContraseña.Name = "frmContraseña";
            this.frmContraseña.Size = new System.Drawing.Size(480, 50);
            this.frmContraseña.TabIndex = 1;
            this.frmContraseña.Text = "Contraseña";
            this.frmContraseña.TrailingIcon = null;
            // 
            // btningresar
            // 
            this.btningresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btningresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btningresar.Depth = 0;
            this.btningresar.HighEmphasis = true;
            this.btningresar.Icon = null;
            this.btningresar.Location = new System.Drawing.Point(361, 207);
            this.btningresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btningresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btningresar.Name = "btningresar";
            this.btningresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btningresar.Size = new System.Drawing.Size(91, 36);
            this.btningresar.TabIndex = 2;
            this.btningresar.Text = "ingresar";
            this.btningresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btningresar.UseAccentColor = false;
            this.btningresar.UseVisualStyleBackColor = true;
            // 
            // frmCancelar
            // 
            this.frmCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frmCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.frmCancelar.Depth = 0;
            this.frmCancelar.HighEmphasis = true;
            this.frmCancelar.Icon = null;
            this.frmCancelar.Location = new System.Drawing.Point(460, 207);
            this.frmCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.frmCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.frmCancelar.Name = "frmCancelar";
            this.frmCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.frmCancelar.Size = new System.Drawing.Size(96, 36);
            this.frmCancelar.TabIndex = 3;
            this.frmCancelar.Text = "Cancelar";
            this.frmCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.frmCancelar.UseAccentColor = false;
            this.frmCancelar.UseVisualStyleBackColor = true;
            this.frmCancelar.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frmCancelar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.frmContraseña);
            this.Controls.Add(this.frmUsuario);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox frmUsuario;
        private MaterialSkin.Controls.MaterialTextBox frmContraseña;
        private MaterialSkin.Controls.MaterialButton btningresar;
        private MaterialSkin.Controls.MaterialButton frmCancelar;
    }
}