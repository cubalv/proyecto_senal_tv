namespace PresentacionAdmin.UI.Servicios
{
    partial class formAdministrarPlanes
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdministrarPlanes));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rjToggleButton1 = new RJCodeAdvance.RJControls.RJToggleButton();
            this.tbDuracionContrato = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbCostoInstalacion = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbDescripcionPlan = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.tbNombrePlan = new MaterialSkin.Controls.MaterialTextBox();
            this.tbCostoMensual = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rjToggleButton1);
            this.panel1.Controls.Add(this.tbDuracionContrato);
            this.panel1.Controls.Add(this.tbCostoInstalacion);
            this.panel1.Controls.Add(this.tbDescripcionPlan);
            this.panel1.Controls.Add(this.lblcodigo);
            this.panel1.Controls.Add(this.tbNombrePlan);
            this.panel1.Controls.Add(this.tbCostoMensual);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 692);
            this.panel1.TabIndex = 0;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.Location = new System.Drawing.Point(925, 646);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(150, 60);
            this.btnImprimir.TabIndex = 32;
            this.btnImprimir.Text = "Imprimir Reporte";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 706);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1183, 22);
            this.panel2.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Planes activos";
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.Checked = true;
            this.rjToggleButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rjToggleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjToggleButton1.Location = new System.Drawing.Point(144, 23);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(36)))), ((int)(((byte)(75)))));
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.TabIndex = 29;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            this.rjToggleButton1.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged);
            // 
            // tbDuracionContrato
            // 
            this.tbDuracionContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDuracionContrato.AnimateReadOnly = false;
            this.tbDuracionContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbDuracionContrato.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbDuracionContrato.Depth = 0;
            this.tbDuracionContrato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDuracionContrato.HideSelection = true;
            this.tbDuracionContrato.Hint = "Duracion del Contrato";
            this.tbDuracionContrato.LeadingIcon = null;
            this.tbDuracionContrato.Location = new System.Drawing.Point(841, 426);
            this.tbDuracionContrato.MaxLength = 32767;
            this.tbDuracionContrato.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDuracionContrato.Name = "tbDuracionContrato";
            this.tbDuracionContrato.PasswordChar = '\0';
            this.tbDuracionContrato.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Suffix;
            this.tbDuracionContrato.PrefixSuffixText = "Meses";
            this.tbDuracionContrato.ReadOnly = false;
            this.tbDuracionContrato.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbDuracionContrato.SelectedText = "";
            this.tbDuracionContrato.SelectionLength = 0;
            this.tbDuracionContrato.SelectionStart = 0;
            this.tbDuracionContrato.ShortcutsEnabled = true;
            this.tbDuracionContrato.Size = new System.Drawing.Size(317, 48);
            this.tbDuracionContrato.TabIndex = 5;
            this.tbDuracionContrato.TabStop = false;
            this.tbDuracionContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDuracionContrato.TrailingIcon = null;
            this.tbDuracionContrato.UseSystemPasswordChar = false;
            this.tbDuracionContrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDuracionContrato_KeyPress);
            // 
            // tbCostoInstalacion
            // 
            this.tbCostoInstalacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCostoInstalacion.AnimateReadOnly = false;
            this.tbCostoInstalacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCostoInstalacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCostoInstalacion.Depth = 0;
            this.tbCostoInstalacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostoInstalacion.HideSelection = true;
            this.tbCostoInstalacion.Hint = "Costo Instalacion";
            this.tbCostoInstalacion.LeadingIcon = null;
            this.tbCostoInstalacion.Location = new System.Drawing.Point(841, 360);
            this.tbCostoInstalacion.MaxLength = 32767;
            this.tbCostoInstalacion.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCostoInstalacion.Name = "tbCostoInstalacion";
            this.tbCostoInstalacion.PasswordChar = '\0';
            this.tbCostoInstalacion.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Suffix;
            this.tbCostoInstalacion.PrefixSuffixText = "GTQ";
            this.tbCostoInstalacion.ReadOnly = false;
            this.tbCostoInstalacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbCostoInstalacion.SelectedText = "";
            this.tbCostoInstalacion.SelectionLength = 0;
            this.tbCostoInstalacion.SelectionStart = 0;
            this.tbCostoInstalacion.ShortcutsEnabled = true;
            this.tbCostoInstalacion.Size = new System.Drawing.Size(317, 48);
            this.tbCostoInstalacion.TabIndex = 4;
            this.tbCostoInstalacion.TabStop = false;
            this.tbCostoInstalacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCostoInstalacion.TrailingIcon = null;
            this.tbCostoInstalacion.UseSystemPasswordChar = false;
            this.tbCostoInstalacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnEliminar_KeyPress);
            // 
            // tbDescripcionPlan
            // 
            this.tbDescripcionPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescripcionPlan.AnimateReadOnly = false;
            this.tbDescripcionPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbDescripcionPlan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbDescripcionPlan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDescripcionPlan.Depth = 0;
            this.tbDescripcionPlan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcionPlan.HideSelection = true;
            this.tbDescripcionPlan.Hint = "Descripcion del Plan";
            this.tbDescripcionPlan.Location = new System.Drawing.Point(841, 136);
            this.tbDescripcionPlan.MaxLength = 32767;
            this.tbDescripcionPlan.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDescripcionPlan.Name = "tbDescripcionPlan";
            this.tbDescripcionPlan.PasswordChar = '\0';
            this.tbDescripcionPlan.ReadOnly = false;
            this.tbDescripcionPlan.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbDescripcionPlan.SelectedText = "";
            this.tbDescripcionPlan.SelectionLength = 0;
            this.tbDescripcionPlan.SelectionStart = 0;
            this.tbDescripcionPlan.ShortcutsEnabled = true;
            this.tbDescripcionPlan.Size = new System.Drawing.Size(317, 145);
            this.tbDescripcionPlan.TabIndex = 2;
            this.tbDescripcionPlan.TabStop = false;
            this.tbDescripcionPlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDescripcionPlan.UseSystemPasswordChar = false;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(784, 14);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(53, 20);
            this.lblcodigo.TabIndex = 28;
            this.lblcodigo.Text = "label1";
            this.lblcodigo.Visible = false;
            // 
            // tbNombrePlan
            // 
            this.tbNombrePlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombrePlan.AnimateReadOnly = false;
            this.tbNombrePlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNombrePlan.Depth = 0;
            this.tbNombrePlan.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNombrePlan.Hint = "Nombre del Plan";
            this.tbNombrePlan.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbNombrePlan.LeadingIcon = null;
            this.tbNombrePlan.Location = new System.Drawing.Point(841, 71);
            this.tbNombrePlan.MaxLength = 3000;
            this.tbNombrePlan.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNombrePlan.Multiline = false;
            this.tbNombrePlan.Name = "tbNombrePlan";
            this.tbNombrePlan.Size = new System.Drawing.Size(317, 50);
            this.tbNombrePlan.TabIndex = 1;
            this.tbNombrePlan.Text = "";
            this.tbNombrePlan.TrailingIcon = null;
            // 
            // tbCostoMensual
            // 
            this.tbCostoMensual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCostoMensual.AnimateReadOnly = false;
            this.tbCostoMensual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCostoMensual.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCostoMensual.Depth = 0;
            this.tbCostoMensual.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostoMensual.HideSelection = true;
            this.tbCostoMensual.Hint = "Costo Mensual";
            this.tbCostoMensual.LeadingIcon = null;
            this.tbCostoMensual.Location = new System.Drawing.Point(841, 297);
            this.tbCostoMensual.MaxLength = 32767;
            this.tbCostoMensual.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCostoMensual.Name = "tbCostoMensual";
            this.tbCostoMensual.PasswordChar = '\0';
            this.tbCostoMensual.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Suffix;
            this.tbCostoMensual.PrefixSuffixText = "GTQ";
            this.tbCostoMensual.ReadOnly = false;
            this.tbCostoMensual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbCostoMensual.SelectedText = "";
            this.tbCostoMensual.SelectionLength = 0;
            this.tbCostoMensual.SelectionStart = 0;
            this.tbCostoMensual.ShortcutsEnabled = true;
            this.tbCostoMensual.Size = new System.Drawing.Size(317, 48);
            this.tbCostoMensual.TabIndex = 3;
            this.tbCostoMensual.TabStop = false;
            this.tbCostoMensual.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCostoMensual.TrailingIcon = null;
            this.tbCostoMensual.UseSystemPasswordChar = false;
            this.tbCostoMensual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCostoMensual_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.FileCircleMinus;
            this.btnEliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.Location = new System.Drawing.Point(841, 570);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 60);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Deshabilitar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(1008, 570);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 60);
            this.btnCancelar.TabIndex = 7;
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
            this.btnEditar.Location = new System.Drawing.Point(841, 493);
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
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnAgregar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.Location = new System.Drawing.Point(1008, 493);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 60);
            this.btnAgregar.TabIndex = 6;
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
            this.gridControl1.Location = new System.Drawing.Point(28, 57);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(792, 643);
            this.gridControl1.TabIndex = 0;
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
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Descripcion";
            this.gridColumn3.FieldName = "descripcion";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Instalacion";
            this.gridColumn4.FieldName = "precioIns";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Mensualidad";
            this.gridColumn5.FieldName = "precioMens";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Duracion";
            this.gridColumn6.FieldName = "duracion";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "gridColumn7";
            this.gridColumn7.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            editorButtonImageOptions3.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Seleccionar", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // formAdministrarPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formAdministrarPlanes";
            this.Text = "Agregar Planes";
            this.Load += new System.EventHandler(this.formAdministrarPlanes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private MaterialSkin.Controls.MaterialTextBox2 tbCostoMensual;
        private MaterialSkin.Controls.MaterialTextBox tbNombrePlan;
        private System.Windows.Forms.Label lblcodigo;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 tbDescripcionPlan;
        private MaterialSkin.Controls.MaterialTextBox2 tbCostoInstalacion;
        private MaterialSkin.Controls.MaterialTextBox2 tbDuracionContrato;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJToggleButton rjToggleButton1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnImprimir;
    }
}