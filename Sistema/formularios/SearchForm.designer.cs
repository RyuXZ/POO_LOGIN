namespace Sistema.formularios
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.cmbMatch = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.cmbLookIn = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtFindWhat = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(920, 572);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 63);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(521, 572);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(127, 63);
            this.btnOK.TabIndex = 30;
            this.btnOK.Text = "Aceptar";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClearSearch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearch.ForeColor = System.Drawing.Color.Black;
            this.btnClearSearch.Location = new System.Drawing.Point(731, 572);
            this.btnClearSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(127, 63);
            this.btnClearSearch.TabIndex = 32;
            this.btnClearSearch.Text = "Limpiar";
            this.btnClearSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClearSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClearSearch.UseVisualStyleBackColor = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // cmbMatch
            // 
            this.cmbMatch.BackColor = System.Drawing.Color.White;
            this.cmbMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMatch.Items.AddRange(new object[] {
            "Cualquier parte del Campo",
            "Total del Campo",
            "Inicio del campo"});
            this.cmbMatch.Location = new System.Drawing.Point(740, 92);
            this.cmbMatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMatch.Name = "cmbMatch";
            this.cmbMatch.Size = new System.Drawing.Size(305, 32);
            this.cmbMatch.TabIndex = 27;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.MediumOrchid;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(652, 95);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(75, 26);
            this.Label3.TabIndex = 26;
            this.Label3.Text = "Filtro :";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbLookIn
            // 
            this.cmbLookIn.BackColor = System.Drawing.Color.White;
            this.cmbLookIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLookIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLookIn.Location = new System.Drawing.Point(240, 92);
            this.cmbLookIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbLookIn.Name = "cmbLookIn";
            this.cmbLookIn.Size = new System.Drawing.Size(393, 32);
            this.cmbLookIn.TabIndex = 25;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.MediumOrchid;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(115, 95);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(117, 26);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "Buscar en:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFindWhat
            // 
            this.txtFindWhat.BackColor = System.Drawing.Color.White;
            this.txtFindWhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindWhat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFindWhat.Location = new System.Drawing.Point(240, 34);
            this.txtFindWhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFindWhat.Name = "txtFindWhat";
            this.txtFindWhat.Size = new System.Drawing.Size(805, 29);
            this.txtFindWhat.TabIndex = 23;
            this.txtFindWhat.TextChanged += new System.EventHandler(this.txtFindWhat_TextChanged);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.MediumOrchid;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(61, 36);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(171, 26);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "Dato a Buscar :";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dg
            // 
            this.dg.BackgroundColor = System.Drawing.Color.MediumOrchid;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(33, 150);
            this.dg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersWidth = 51;
            this.dg.Size = new System.Drawing.Size(1380, 396);
            this.dg.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1078, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1445, 666);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.cmbMatch);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.cmbLookIn);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtFindWhat);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSQUEDA EXPERTA";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Button btnClearSearch;
        internal System.Windows.Forms.ComboBox cmbMatch;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cmbLookIn;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtFindWhat;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}