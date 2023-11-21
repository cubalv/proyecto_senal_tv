namespace PresentacionAdmin.UI
{
    partial class Logins
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUser = new MaterialSkin.Controls.MaterialTextBox();
            this.tbPswrd = new MaterialSkin.Controls.MaterialTextBox();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnVerPswrd = new FontAwesome.Sharp.IconButton();
            this.btnEntrar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(331, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inicio de sesion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(341, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Brown;
            this.lblError.Location = new System.Drawing.Point(342, 228);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(47, 17);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "label4";
            this.lblError.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 348);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentacionAdmin.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(12, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 72);
            this.label3.TabIndex = 6;
            this.label3.Text = "Señal Tv";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUser
            // 
            this.tbUser.AnimateReadOnly = false;
            this.tbUser.BackColor = System.Drawing.Color.Red;
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Depth = 0;
            this.tbUser.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbUser.Hint = "Usuario";
            this.tbUser.LeadingIcon = null;
            this.tbUser.Location = new System.Drawing.Point(344, 112);
            this.tbUser.MaxLength = 50;
            this.tbUser.MouseState = MaterialSkin.MouseState.OUT;
            this.tbUser.Multiline = false;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(363, 50);
            this.tbUser.TabIndex = 10;
            this.tbUser.Text = "";
            this.tbUser.TrailingIcon = null;
            this.tbUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbUser_KeyUp);
            // 
            // tbPswrd
            // 
            this.tbPswrd.AnimateReadOnly = false;
            this.tbPswrd.BackColor = System.Drawing.Color.Red;
            this.tbPswrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPswrd.Depth = 0;
            this.tbPswrd.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPswrd.Hint = "Contraseña";
            this.tbPswrd.LeadingIcon = null;
            this.tbPswrd.Location = new System.Drawing.Point(345, 175);
            this.tbPswrd.MaxLength = 50;
            this.tbPswrd.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPswrd.Multiline = false;
            this.tbPswrd.Name = "tbPswrd";
            this.tbPswrd.Password = true;
            this.tbPswrd.Size = new System.Drawing.Size(363, 50);
            this.tbPswrd.TabIndex = 11;
            this.tbPswrd.Text = "";
            this.tbPswrd.TrailingIcon = null;
            this.tbPswrd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPswrd_KeyUp);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 17;
            this.btnClose.Location = new System.Drawing.Point(720, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnVerPswrd
            // 
            this.btnVerPswrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnVerPswrd.FlatAppearance.BorderSize = 0;
            this.btnVerPswrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPswrd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerPswrd.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnVerPswrd.IconColor = System.Drawing.Color.Black;
            this.btnVerPswrd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerPswrd.IconSize = 30;
            this.btnVerPswrd.Location = new System.Drawing.Point(655, 180);
            this.btnVerPswrd.Margin = new System.Windows.Forms.Padding(5);
            this.btnVerPswrd.Name = "btnVerPswrd";
            this.btnVerPswrd.Size = new System.Drawing.Size(53, 39);
            this.btnVerPswrd.TabIndex = 3;
            this.btnVerPswrd.UseVisualStyleBackColor = false;
            this.btnVerPswrd.Click += new System.EventHandler(this.btnVerPswrd_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEntrar.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnEntrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEntrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEntrar.Location = new System.Drawing.Point(438, 272);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(180, 62);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Ingresar";
            this.btnEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // Logins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(780, 348);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnVerPswrd);
            this.Controls.Add(this.tbPswrd);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEntrar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Logins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnEntrar;
        private FontAwesome.Sharp.IconButton btnVerPswrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox tbUser;
        private MaterialSkin.Controls.MaterialTextBox tbPswrd;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label label3;
    }
}