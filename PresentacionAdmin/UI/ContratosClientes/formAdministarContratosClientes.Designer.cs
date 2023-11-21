namespace PresentacionAdmin.UI.ContratosClientes
{
    partial class formAdministarContratosClientes
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdministarContratosClientes));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDpi = new MaterialSkin.Controls.MaterialTextBox();
            this.tbNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.tbPlan = new MaterialSkin.Controls.MaterialTextBox();
            this.tbFecha = new MaterialSkin.Controls.MaterialTextBox();
            this.tbDireccion = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnCambiarDireccion = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDarBaja = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 664);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 28);
            this.panel2.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(24, 44);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(811, 600);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn7});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Codigo";
            this.gridColumn1.FieldName = "codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 66;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cliente";
            this.gridColumn2.FieldName = "cliente";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 181;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Plan";
            this.gridColumn3.FieldName = "plan";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 153;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Fecha contratacion";
            this.gridColumn4.FieldName = "fechaCont";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 115;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Direccion";
            this.gridColumn5.FieldName = "direccion";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 182;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Seleccionar";
            this.gridColumn7.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 150;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            editorButtonImageOptions1.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            serializableAppearanceObject1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            serializableAppearanceObject1.Options.UseBackColor = true;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Seleccionar", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Seleccione el contrato";
            // 
            // tbDpi
            // 
            this.tbDpi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDpi.AnimateReadOnly = false;
            this.tbDpi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDpi.Depth = 0;
            this.tbDpi.Enabled = false;
            this.tbDpi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbDpi.Hint = "DPI del Cliente";
            this.tbDpi.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbDpi.LeadingIcon = null;
            this.tbDpi.Location = new System.Drawing.Point(855, 55);
            this.tbDpi.MaxLength = 13;
            this.tbDpi.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDpi.Multiline = false;
            this.tbDpi.Name = "tbDpi";
            this.tbDpi.Size = new System.Drawing.Size(316, 50);
            this.tbDpi.TabIndex = 20;
            this.tbDpi.Text = "";
            this.tbDpi.TrailingIcon = null;
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.AnimateReadOnly = false;
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNombre.Depth = 0;
            this.tbNombre.Enabled = false;
            this.tbNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNombre.Hint = "Nombre Cliente";
            this.tbNombre.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbNombre.LeadingIcon = null;
            this.tbNombre.Location = new System.Drawing.Point(855, 120);
            this.tbNombre.MaxLength = 200;
            this.tbNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNombre.Multiline = false;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(316, 50);
            this.tbNombre.TabIndex = 19;
            this.tbNombre.Text = "";
            this.tbNombre.TrailingIcon = null;
            // 
            // tbPlan
            // 
            this.tbPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlan.AnimateReadOnly = false;
            this.tbPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPlan.Depth = 0;
            this.tbPlan.Enabled = false;
            this.tbPlan.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPlan.Hint = "Nombre del Plan";
            this.tbPlan.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbPlan.LeadingIcon = null;
            this.tbPlan.Location = new System.Drawing.Point(855, 186);
            this.tbPlan.MaxLength = 200;
            this.tbPlan.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPlan.Multiline = false;
            this.tbPlan.Name = "tbPlan";
            this.tbPlan.Size = new System.Drawing.Size(316, 50);
            this.tbPlan.TabIndex = 21;
            this.tbPlan.Text = "";
            this.tbPlan.TrailingIcon = null;
            // 
            // tbFecha
            // 
            this.tbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFecha.AnimateReadOnly = false;
            this.tbFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFecha.Depth = 0;
            this.tbFecha.Enabled = false;
            this.tbFecha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbFecha.Hint = "Fecha de la contratacion";
            this.tbFecha.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbFecha.LeadingIcon = null;
            this.tbFecha.Location = new System.Drawing.Point(855, 251);
            this.tbFecha.MaxLength = 200;
            this.tbFecha.MouseState = MaterialSkin.MouseState.OUT;
            this.tbFecha.Multiline = false;
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(316, 50);
            this.tbFecha.TabIndex = 22;
            this.tbFecha.Text = "";
            this.tbFecha.TrailingIcon = null;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDireccion.AnimateReadOnly = false;
            this.tbDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDireccion.Depth = 0;
            this.tbDireccion.Enabled = false;
            this.tbDireccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbDireccion.Hint = "Direccion del plan";
            this.tbDireccion.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbDireccion.LeadingIcon = null;
            this.tbDireccion.Location = new System.Drawing.Point(855, 316);
            this.tbDireccion.MaxLength = 200;
            this.tbDireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDireccion.Multiline = false;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(316, 50);
            this.tbDireccion.TabIndex = 23;
            this.tbDireccion.Text = "";
            this.tbDireccion.TrailingIcon = null;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(867, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 20);
            this.lblCodigo.TabIndex = 24;
            this.lblCodigo.Text = "label2";
            this.lblCodigo.Visible = false;
            // 
            // btnCambiarDireccion
            // 
            this.btnCambiarDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCambiarDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnCambiarDireccion.Enabled = false;
            this.btnCambiarDireccion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCambiarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCambiarDireccion.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.btnCambiarDireccion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCambiarDireccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCambiarDireccion.Location = new System.Drawing.Point(855, 385);
            this.btnCambiarDireccion.Name = "btnCambiarDireccion";
            this.btnCambiarDireccion.Size = new System.Drawing.Size(150, 60);
            this.btnCambiarDireccion.TabIndex = 29;
            this.btnCambiarDireccion.Text = "Cambiar la direccion";
            this.btnCambiarDireccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiarDireccion.UseVisualStyleBackColor = false;
            this.btnCambiarDireccion.Click += new System.EventHandler(this.btnCambiarDireccion_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnDarBaja);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnCambiarDireccion);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.tbDireccion);
            this.panel1.Controls.Add(this.tbFecha);
            this.panel1.Controls.Add(this.tbPlan);
            this.panel1.Controls.Add(this.tbNombre);
            this.panel1.Controls.Add(this.tbDpi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 692);
            this.panel1.TabIndex = 0;
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDarBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnDarBaja.Enabled = false;
            this.btnDarBaja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnDarBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarBaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnDarBaja.IconChar = FontAwesome.Sharp.IconChar.FileCircleMinus;
            this.btnDarBaja.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnDarBaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDarBaja.Location = new System.Drawing.Point(855, 464);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(316, 60);
            this.btnDarBaja.TabIndex = 32;
            this.btnDarBaja.Text = "Dar de baja el servicio";
            this.btnDarBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDarBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDarBaja.UseVisualStyleBackColor = false;
            this.btnDarBaja.Click += new System.EventHandler(this.btnDarBaja_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.Location = new System.Drawing.Point(1021, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 60);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // formAdministarContratosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formAdministarContratosClientes";
            this.Text = "Administrar contratos";
            this.Load += new System.EventHandler(this.formAdministarContratosClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox tbDpi;
        private MaterialSkin.Controls.MaterialTextBox tbNombre;
        private MaterialSkin.Controls.MaterialTextBox tbPlan;
        private MaterialSkin.Controls.MaterialTextBox tbFecha;
        private MaterialSkin.Controls.MaterialTextBox tbDireccion;
        private System.Windows.Forms.Label lblCodigo;
        private FontAwesome.Sharp.IconButton btnCambiarDireccion;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnDarBaja;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}