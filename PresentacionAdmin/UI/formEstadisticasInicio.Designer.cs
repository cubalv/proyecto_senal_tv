namespace PresentacionAdmin.UI
{
    partial class formEstadisticasInicio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescripion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlMuni = new MaterialSkin.Controls.MaterialComboBox();
            this.ddlDepto = new MaterialSkin.Controls.MaterialComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDescripion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ddlMuni);
            this.panel1.Controls.Add(this.ddlDepto);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 692);
            this.panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(522, 406);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(150, 60);
            this.iconButton1.TabIndex = 34;
            this.iconButton1.Text = "Imprimir Listado";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.btnImprimir.Location = new System.Drawing.Point(1038, 406);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(150, 60);
            this.btnImprimir.TabIndex = 33;
            this.btnImprimir.Text = "Imprimir Listado";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1194, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 100);
            this.panel2.TabIndex = 12;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(721, 105);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(467, 258);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Popularidad de los planes";
            // 
            // lblDescripion
            // 
            this.lblDescripion.AutoSize = true;
            this.lblDescripion.Location = new System.Drawing.Point(45, 384);
            this.lblDescripion.Name = "lblDescripion";
            this.lblDescripion.Size = new System.Drawing.Size(236, 20);
            this.lblDescripion.TabIndex = 8;
            this.lblDescripion.Text = "Total de servicios instalados en ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zonas";
            // 
            // ddlMuni
            // 
            this.ddlMuni.AutoResize = false;
            this.ddlMuni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ddlMuni.Depth = 0;
            this.ddlMuni.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ddlMuni.DropDownHeight = 174;
            this.ddlMuni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMuni.DropDownWidth = 121;
            this.ddlMuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ddlMuni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ddlMuni.FormattingEnabled = true;
            this.ddlMuni.Hint = "Municipio";
            this.ddlMuni.IntegralHeight = false;
            this.ddlMuni.ItemHeight = 43;
            this.ddlMuni.Location = new System.Drawing.Point(372, 38);
            this.ddlMuni.MaxDropDownItems = 4;
            this.ddlMuni.MouseState = MaterialSkin.MouseState.OUT;
            this.ddlMuni.Name = "ddlMuni";
            this.ddlMuni.Size = new System.Drawing.Size(300, 49);
            this.ddlMuni.StartIndex = 0;
            this.ddlMuni.TabIndex = 6;
            this.ddlMuni.SelectedValueChanged += new System.EventHandler(this.ddlMuni_SelectedValueChanged);
            // 
            // ddlDepto
            // 
            this.ddlDepto.AutoResize = false;
            this.ddlDepto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ddlDepto.Depth = 0;
            this.ddlDepto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ddlDepto.DropDownHeight = 174;
            this.ddlDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDepto.DropDownWidth = 121;
            this.ddlDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ddlDepto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ddlDepto.FormattingEnabled = true;
            this.ddlDepto.Hint = "Departamento";
            this.ddlDepto.IntegralHeight = false;
            this.ddlDepto.ItemHeight = 43;
            this.ddlDepto.Location = new System.Drawing.Point(49, 39);
            this.ddlDepto.MaxDropDownItems = 4;
            this.ddlDepto.MouseState = MaterialSkin.MouseState.OUT;
            this.ddlDepto.Name = "ddlDepto";
            this.ddlDepto.Size = new System.Drawing.Size(300, 49);
            this.ddlDepto.StartIndex = 0;
            this.ddlDepto.TabIndex = 5;
            this.ddlDepto.SelectedValueChanged += new System.EventHandler(this.ddlDepto_SelectedValueChanged);
            // 
            // chart1
            // 
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(49, 114);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Zonas";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(623, 249);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // formEstadisticasInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 692);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formEstadisticasInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.formEstadisticasInicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialComboBox ddlMuni;
        private MaterialSkin.Controls.MaterialComboBox ddlDepto;
        private System.Windows.Forms.Label lblDescripion;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnImprimir;
    }
}