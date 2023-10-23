namespace PresentacionAdmin.UI.Empleados
{
    partial class formNuevoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNuevoEmpleado));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPswrd = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tbDpi = new MaterialSkin.Controls.MaterialTextBox();
            this.tbCorreo = new MaterialSkin.Controls.MaterialTextBox();
            this.tbUser = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTel1 = new MaterialSkin.Controls.MaterialTextBox();
            this.tbDireccion = new MaterialSkin.Controls.MaterialTextBox();
            this.tbApellido = new MaterialSkin.Controls.MaterialTextBox();
            this.tbNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbPswrd);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Controls.Add(this.tbDpi);
            this.groupBox1.Controls.Add(this.tbCorreo);
            this.groupBox1.Controls.Add(this.tbUser);
            this.groupBox1.Controls.Add(this.tbTel1);
            this.groupBox1.Controls.Add(this.tbDireccion);
            this.groupBox1.Controls.Add(this.tbApellido);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.MinimumSize = new System.Drawing.Size(400, 707);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1272, 707);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Empleado";
            // 
            // tbPswrd
            // 
            this.tbPswrd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPswrd.AnimateReadOnly = false;
            this.tbPswrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPswrd.Depth = 0;
            this.tbPswrd.Enabled = false;
            this.tbPswrd.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPswrd.Hint = "Contraseña";
            this.tbPswrd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbPswrd.LeadingIcon = null;
            this.tbPswrd.Location = new System.Drawing.Point(935, 484);
            this.tbPswrd.MaxLength = 100;
            this.tbPswrd.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPswrd.Multiline = false;
            this.tbPswrd.Name = "tbPswrd";
            this.tbPswrd.Size = new System.Drawing.Size(316, 50);
            this.tbPswrd.TabIndex = 11;
            this.tbPswrd.Text = "";
            this.tbPswrd.TrailingIcon = null;
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
            this.btnCancelar.Location = new System.Drawing.Point(1101, 623);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 60);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEditar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.Location = new System.Drawing.Point(935, 549);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 60);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.Location = new System.Drawing.Point(1101, 549);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 60);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(6, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(909, 676);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn3,
            this.gridColumn7});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "DPI";
            this.gridColumn1.FieldName = "dpi";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 160;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre";
            this.gridColumn2.FieldName = "nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 259;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Telefono";
            this.gridColumn4.FieldName = "telefono";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 87;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Direccion";
            this.gridColumn5.FieldName = "direccion";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 84;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Correo";
            this.gridColumn3.FieldName = "correo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 110;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Seleccionar";
            this.gridColumn7.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 179;
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
            // tbDpi
            // 
            this.tbDpi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDpi.AnimateReadOnly = false;
            this.tbDpi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDpi.Depth = 0;
            this.tbDpi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbDpi.Hint = "DPI";
            this.tbDpi.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbDpi.LeadingIcon = null;
            this.tbDpi.Location = new System.Drawing.Point(935, 25);
            this.tbDpi.MaxLength = 13;
            this.tbDpi.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDpi.Multiline = false;
            this.tbDpi.Name = "tbDpi";
            this.tbDpi.Size = new System.Drawing.Size(316, 50);
            this.tbDpi.TabIndex = 6;
            this.tbDpi.Text = "";
            this.tbDpi.TrailingIcon = null;
            this.tbDpi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDpi_KeyPress);
            this.tbDpi.Leave += new System.EventHandler(this.tbDpi_Leave);
            // 
            // tbCorreo
            // 
            this.tbCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCorreo.AnimateReadOnly = false;
            this.tbCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCorreo.Depth = 0;
            this.tbCorreo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCorreo.Hint = "Correo Electrónico";
            this.tbCorreo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbCorreo.LeadingIcon = null;
            this.tbCorreo.Location = new System.Drawing.Point(935, 354);
            this.tbCorreo.MaxLength = 100;
            this.tbCorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCorreo.Multiline = false;
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(316, 50);
            this.tbCorreo.TabIndex = 5;
            this.tbCorreo.Text = "";
            this.tbCorreo.TrailingIcon = null;
            // 
            // tbUser
            // 
            this.tbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUser.AnimateReadOnly = false;
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Depth = 0;
            this.tbUser.Enabled = false;
            this.tbUser.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbUser.Hint = "Usuario";
            this.tbUser.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbUser.LeadingIcon = null;
            this.tbUser.Location = new System.Drawing.Point(935, 419);
            this.tbUser.MaxLength = 100;
            this.tbUser.MouseState = MaterialSkin.MouseState.OUT;
            this.tbUser.Multiline = false;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(316, 50);
            this.tbUser.TabIndex = 4;
            this.tbUser.Text = "";
            this.tbUser.TrailingIcon = null;
            // 
            // tbTel1
            // 
            this.tbTel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTel1.AnimateReadOnly = false;
            this.tbTel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTel1.Depth = 0;
            this.tbTel1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTel1.Hint = "Telefono Celular";
            this.tbTel1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbTel1.LeadingIcon = null;
            this.tbTel1.Location = new System.Drawing.Point(935, 288);
            this.tbTel1.MaxLength = 8;
            this.tbTel1.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTel1.Multiline = false;
            this.tbTel1.Name = "tbTel1";
            this.tbTel1.Size = new System.Drawing.Size(316, 50);
            this.tbTel1.TabIndex = 3;
            this.tbTel1.Text = "";
            this.tbTel1.TrailingIcon = null;
            this.tbTel1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDpi_KeyPress);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDireccion.AnimateReadOnly = false;
            this.tbDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDireccion.Depth = 0;
            this.tbDireccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbDireccion.Hint = "Direccion";
            this.tbDireccion.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbDireccion.LeadingIcon = null;
            this.tbDireccion.Location = new System.Drawing.Point(935, 223);
            this.tbDireccion.MaxLength = 300;
            this.tbDireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDireccion.Multiline = false;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(316, 50);
            this.tbDireccion.TabIndex = 2;
            this.tbDireccion.Text = "";
            this.tbDireccion.TrailingIcon = null;
            // 
            // tbApellido
            // 
            this.tbApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApellido.AnimateReadOnly = false;
            this.tbApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbApellido.Depth = 0;
            this.tbApellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbApellido.Hint = "Apellidos";
            this.tbApellido.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbApellido.LeadingIcon = null;
            this.tbApellido.Location = new System.Drawing.Point(935, 157);
            this.tbApellido.MaxLength = 100;
            this.tbApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.tbApellido.Multiline = false;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(316, 50);
            this.tbApellido.TabIndex = 1;
            this.tbApellido.Text = "";
            this.tbApellido.TrailingIcon = null;
            this.tbApellido.Leave += new System.EventHandler(this.tbNombre_Leave);
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.AnimateReadOnly = false;
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNombre.Depth = 0;
            this.tbNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNombre.Hint = "Nombres";
            this.tbNombre.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbNombre.LeadingIcon = null;
            this.tbNombre.Location = new System.Drawing.Point(935, 91);
            this.tbNombre.MaxLength = 100;
            this.tbNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNombre.Multiline = false;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(316, 50);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.Text = "";
            this.tbNombre.TrailingIcon = null;
            this.tbNombre.Leave += new System.EventHandler(this.tbNombre_Leave);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 742);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 713);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 29);
            this.panel2.TabIndex = 2;
            // 
            // formNuevoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 742);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formNuevoEmpleado";
            this.Text = "Administrar Empleados";
            this.Load += new System.EventHandler(this.formNuevoEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private MaterialSkin.Controls.MaterialTextBox tbDpi;
        private MaterialSkin.Controls.MaterialTextBox tbCorreo;
        private MaterialSkin.Controls.MaterialTextBox tbTel1;
        private MaterialSkin.Controls.MaterialTextBox tbDireccion;
        private MaterialSkin.Controls.MaterialTextBox tbApellido;
        private MaterialSkin.Controls.MaterialTextBox tbNombre;
        private MaterialSkin.Controls.MaterialTextBox tbPswrd;
        private MaterialSkin.Controls.MaterialTextBox tbUser;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}