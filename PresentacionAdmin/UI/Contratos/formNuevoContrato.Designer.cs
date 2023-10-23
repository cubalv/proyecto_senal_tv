namespace PresentacionAdmin.UI.Contratos
{
    partial class formNuevoContrato
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNuevoContrato));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ddlRangos = new MaterialSkin.Controls.MaterialComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rjToggleButton1 = new RJCodeAdvance.RJControls.RJToggleButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.lblcodigo = new System.Windows.Forms.Label();
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
            this.tbDuracion = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbSueldo = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.tbNombreContrato = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ddlRangos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rjToggleButton1);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.lblcodigo);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.tbDuracion);
            this.panel1.Controls.Add(this.tbSueldo);
            this.panel1.Controls.Add(this.tbDescripcion);
            this.panel1.Controls.Add(this.tbNombreContrato);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 742);
            this.panel1.TabIndex = 0;
            // 
            // ddlRangos
            // 
            this.ddlRangos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlRangos.AutoResize = false;
            this.ddlRangos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ddlRangos.Depth = 0;
            this.ddlRangos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ddlRangos.DropDownHeight = 174;
            this.ddlRangos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlRangos.DropDownWidth = 121;
            this.ddlRangos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ddlRangos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ddlRangos.FormattingEnabled = true;
            this.ddlRangos.Hint = "Rango de permisos";
            this.ddlRangos.IntegralHeight = false;
            this.ddlRangos.ItemHeight = 43;
            this.ddlRangos.Location = new System.Drawing.Point(702, 390);
            this.ddlRangos.MaxDropDownItems = 4;
            this.ddlRangos.MouseState = MaterialSkin.MouseState.OUT;
            this.ddlRangos.Name = "ddlRangos";
            this.ddlRangos.Size = new System.Drawing.Size(317, 49);
            this.ddlRangos.StartIndex = 0;
            this.ddlRangos.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Contratos activos";
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.Checked = true;
            this.rjToggleButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rjToggleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjToggleButton1.Location = new System.Drawing.Point(157, 26);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(36)))), ((int)(((byte)(75)))));
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.TabIndex = 22;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            this.rjToggleButton1.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.FileCircleMinus;
            this.btnEliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.Location = new System.Drawing.Point(702, 545);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 60);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Deshabilitar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(685, 9);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(53, 20);
            this.lblcodigo.TabIndex = 20;
            this.lblcodigo.Text = "label1";
            this.lblcodigo.Visible = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(869, 545);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 60);
            this.btnCancelar.TabIndex = 19;
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
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.btnEditar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.Location = new System.Drawing.Point(702, 468);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 60);
            this.btnEditar.TabIndex = 18;
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
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnAgregar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.Location = new System.Drawing.Point(869, 468);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 60);
            this.btnAgregar.TabIndex = 17;
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
            this.gridControl1.Location = new System.Drawing.Point(12, 64);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(667, 638);
            this.gridControl1.TabIndex = 16;
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
            this.gridColumn1.Caption = "Codigo";
            this.gridColumn1.FieldName = "codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre";
            this.gridColumn2.FieldName = "nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 115;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Descripcion";
            this.gridColumn4.FieldName = "descripcion";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 172;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Sueldo";
            this.gridColumn5.FieldName = "sueldo";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 79;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Duracion";
            this.gridColumn3.FieldName = "duracion";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 103;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Seleccionar";
            this.gridColumn7.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 173;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            editorButtonImageOptions2.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            serializableAppearanceObject5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            serializableAppearanceObject5.Options.UseBackColor = true;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Seleccionar", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // tbDuracion
            // 
            this.tbDuracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDuracion.AnimateReadOnly = false;
            this.tbDuracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbDuracion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbDuracion.Depth = 0;
            this.tbDuracion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDuracion.HideSelection = true;
            this.tbDuracion.Hint = "Duracion del contrato";
            this.tbDuracion.LeadingIcon = null;
            this.tbDuracion.Location = new System.Drawing.Point(702, 327);
            this.tbDuracion.MaxLength = 32767;
            this.tbDuracion.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDuracion.Name = "tbDuracion";
            this.tbDuracion.PasswordChar = '\0';
            this.tbDuracion.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Suffix;
            this.tbDuracion.PrefixSuffixText = "Meses";
            this.tbDuracion.ReadOnly = false;
            this.tbDuracion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbDuracion.SelectedText = "";
            this.tbDuracion.SelectionLength = 0;
            this.tbDuracion.SelectionStart = 0;
            this.tbDuracion.ShortcutsEnabled = true;
            this.tbDuracion.Size = new System.Drawing.Size(317, 48);
            this.tbDuracion.TabIndex = 15;
            this.tbDuracion.TabStop = false;
            this.tbDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDuracion.TrailingIcon = null;
            this.tbDuracion.UseSystemPasswordChar = false;
            this.tbDuracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox22_KeyPress);
            // 
            // tbSueldo
            // 
            this.tbSueldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSueldo.AnimateReadOnly = false;
            this.tbSueldo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbSueldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbSueldo.Depth = 0;
            this.tbSueldo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSueldo.HideSelection = true;
            this.tbSueldo.Hint = "Sueldo del contrato";
            this.tbSueldo.LeadingIcon = null;
            this.tbSueldo.Location = new System.Drawing.Point(702, 264);
            this.tbSueldo.MaxLength = 32767;
            this.tbSueldo.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSueldo.Name = "tbSueldo";
            this.tbSueldo.PasswordChar = '\0';
            this.tbSueldo.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Suffix;
            this.tbSueldo.PrefixSuffixText = "GTQ";
            this.tbSueldo.ReadOnly = false;
            this.tbSueldo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSueldo.SelectedText = "";
            this.tbSueldo.SelectionLength = 0;
            this.tbSueldo.SelectionStart = 0;
            this.tbSueldo.ShortcutsEnabled = true;
            this.tbSueldo.Size = new System.Drawing.Size(317, 48);
            this.tbSueldo.TabIndex = 14;
            this.tbSueldo.TabStop = false;
            this.tbSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSueldo.TrailingIcon = null;
            this.tbSueldo.UseSystemPasswordChar = false;
            this.tbSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox21_KeyPress);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescripcion.AnimateReadOnly = false;
            this.tbDescripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDescripcion.Depth = 0;
            this.tbDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.HideSelection = true;
            this.tbDescripcion.Hint = "Descripcion del contrato";
            this.tbDescripcion.Location = new System.Drawing.Point(702, 104);
            this.tbDescripcion.MaxLength = 32767;
            this.tbDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.PasswordChar = '\0';
            this.tbDescripcion.ReadOnly = false;
            this.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbDescripcion.SelectedText = "";
            this.tbDescripcion.SelectionLength = 0;
            this.tbDescripcion.SelectionStart = 0;
            this.tbDescripcion.ShortcutsEnabled = true;
            this.tbDescripcion.Size = new System.Drawing.Size(317, 145);
            this.tbDescripcion.TabIndex = 12;
            this.tbDescripcion.TabStop = false;
            this.tbDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDescripcion.UseSystemPasswordChar = false;
            // 
            // tbNombreContrato
            // 
            this.tbNombreContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombreContrato.AnimateReadOnly = false;
            this.tbNombreContrato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNombreContrato.Depth = 0;
            this.tbNombreContrato.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNombreContrato.Hint = "Nombre del contrato";
            this.tbNombreContrato.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbNombreContrato.LeadingIcon = null;
            this.tbNombreContrato.Location = new System.Drawing.Point(702, 37);
            this.tbNombreContrato.MaxLength = 3000;
            this.tbNombreContrato.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNombreContrato.Multiline = false;
            this.tbNombreContrato.Name = "tbNombreContrato";
            this.tbNombreContrato.Size = new System.Drawing.Size(317, 50);
            this.tbNombreContrato.TabIndex = 7;
            this.tbNombreContrato.Text = "";
            this.tbNombreContrato.TrailingIcon = null;
            // 
            // formNuevoContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 742);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formNuevoContrato";
            this.Text = "Agregar un nuevo contrato";
            this.Load += new System.EventHandler(this.formNuevoContrato_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox tbNombreContrato;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 tbDescripcion;
        private MaterialSkin.Controls.MaterialTextBox2 tbSueldo;
        private MaterialSkin.Controls.MaterialTextBox2 tbDuracion;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Label lblcodigo;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJToggleButton rjToggleButton1;
        private MaterialSkin.Controls.MaterialComboBox ddlRangos;
    }
}