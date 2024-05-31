namespace Carrental
{
    partial class ReturnDetail
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxcarid = new System.Windows.Forms.ComboBox();
            this.carBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carRentalDBDataSet4 = new Carrental.CarRentalDBDataSet4();
            this.textboxcustomername = new System.Windows.Forms.ComboBox();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carRentalDBDataSet3 = new Carrental.CarRentalDBDataSet3();
            this.textBoxfine = new System.Windows.Forms.TextBox();
            this.textBoxelapsed = new System.Windows.Forms.TextBox();
            this.textBoxdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carRentalDBDataSet2 = new Carrental.CarRentalDBDataSet2();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carRentalDBDataSet1 = new Carrental.CarRentalDBDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.carRentalDBDataSet = new Carrental.CarRentalDBDataSet();
            this.returnDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.return_DetailTableAdapter = new Carrental.CarRentalDBDataSetTableAdapters.Return_DetailTableAdapter();
            this.customerTableAdapter = new Carrental.CarRentalDBDataSet1TableAdapters.CustomerTableAdapter();
            this.carTableAdapter = new Carrental.CarRentalDBDataSet2TableAdapters.CarTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.customerTableAdapter1 = new Carrental.CarRentalDBDataSet3TableAdapters.CustomerTableAdapter();
            this.carTableAdapter1 = new Carrental.CarRentalDBDataSet4TableAdapters.CarTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnDetailBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.textBoxcarid);
            this.groupBox1.Controls.Add(this.textboxcustomername);
            this.groupBox1.Controls.Add(this.textBoxfine);
            this.groupBox1.Controls.Add(this.textBoxelapsed);
            this.groupBox1.Controls.Add(this.textBoxdate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(26, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return Car";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxcarid
            // 
            this.textBoxcarid.DataSource = this.carBindingSource1;
            this.textBoxcarid.DisplayMember = "Model";
            this.textBoxcarid.FormattingEnabled = true;
            this.textBoxcarid.Location = new System.Drawing.Point(107, 48);
            this.textBoxcarid.Name = "textBoxcarid";
            this.textBoxcarid.Size = new System.Drawing.Size(163, 23);
            this.textBoxcarid.TabIndex = 13;
            this.textBoxcarid.ValueMember = "CarId";
            this.textBoxcarid.SelectedIndexChanged += new System.EventHandler(this.textBoxcarid_SelectedIndexChanged);
            // 
            // carBindingSource1
            // 
            this.carBindingSource1.DataMember = "Car";
            this.carBindingSource1.DataSource = this.carRentalDBDataSet4;
            // 
            // carRentalDBDataSet4
            // 
            this.carRentalDBDataSet4.DataSetName = "CarRentalDBDataSet4";
            this.carRentalDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textboxcustomername
            // 
            this.textboxcustomername.DataSource = this.customerBindingSource1;
            this.textboxcustomername.DisplayMember = "CustomerName";
            this.textboxcustomername.FormattingEnabled = true;
            this.textboxcustomername.Location = new System.Drawing.Point(107, 79);
            this.textboxcustomername.Name = "textboxcustomername";
            this.textboxcustomername.Size = new System.Drawing.Size(163, 23);
            this.textboxcustomername.TabIndex = 12;
            this.textboxcustomername.ValueMember = "CustomerId";
            this.textboxcustomername.SelectedIndexChanged += new System.EventHandler(this.textboxcustomername_SelectedIndexChanged);
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.carRentalDBDataSet3;
            // 
            // carRentalDBDataSet3
            // 
            this.carRentalDBDataSet3.DataSetName = "CarRentalDBDataSet3";
            this.carRentalDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxfine
            // 
            this.textBoxfine.Location = new System.Drawing.Point(107, 173);
            this.textBoxfine.Name = "textBoxfine";
            this.textBoxfine.Size = new System.Drawing.Size(163, 22);
            this.textBoxfine.TabIndex = 11;
            // 
            // textBoxelapsed
            // 
            this.textBoxelapsed.Location = new System.Drawing.Point(107, 143);
            this.textBoxelapsed.Name = "textBoxelapsed";
            this.textBoxelapsed.Size = new System.Drawing.Size(163, 22);
            this.textBoxelapsed.TabIndex = 10;
            // 
            // textBoxdate
            // 
            this.textBoxdate.Location = new System.Drawing.Point(107, 112);
            this.textBoxdate.Name = "textBoxdate";
            this.textBoxdate.Size = new System.Drawing.Size(163, 22);
            this.textBoxdate.TabIndex = 9;
            this.textBoxdate.TextChanged += new System.EventHandler(this.textBoxdate_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Car Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Days Elapsed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fine";
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.carRentalDBDataSet2;
            // 
            // carRentalDBDataSet2
            // 
            this.carRentalDBDataSet2.DataSetName = "CarRentalDBDataSet2";
            this.carRentalDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.carRentalDBDataSet1;
            // 
            // carRentalDBDataSet1
            // 
            this.carRentalDBDataSet1.DataSetName = "CarRentalDBDataSet1";
            this.carRentalDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Return Detail";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(329, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 268);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ID";
            this.Column6.Name = "Column6";
            // 
            // column1
            // 
            this.column1.HeaderText = "Car Id";
            this.column1.Name = "column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Customer ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Days Elapsed";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fine";
            this.Column5.Name = "Column5";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Font = new System.Drawing.Font("Georgia", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAdd.Location = new System.Drawing.Point(110, 371);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Font = new System.Drawing.Font("Georgia", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCancel.Location = new System.Drawing.Point(212, 371);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // carRentalDBDataSet
            // 
            this.carRentalDBDataSet.DataSetName = "CarRentalDBDataSet";
            this.carRentalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // returnDetailBindingSource
            // 
            this.returnDetailBindingSource.DataMember = "Return_Detail";
            this.returnDetailBindingSource.DataSource = this.carRentalDBDataSet;
            // 
            // return_DetailTableAdapter
            // 
            this.return_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(371, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "Car Return Detail";
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // carTableAdapter1
            // 
            this.carTableAdapter1.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(998, 25);
            this.fillByToolStrip.TabIndex = 8;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click_1);
            // 
            // ReturnDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Carrental.Properties.Resources.image_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnDetail";
            this.Text = "ReturnDetail";
            this.Load += new System.EventHandler(this.ReturnDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnDetailBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxfine;
        private System.Windows.Forms.TextBox textBoxelapsed;
        private System.Windows.Forms.TextBox textBoxdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox textboxcustomername;
        private CarRentalDBDataSet carRentalDBDataSet;
        private System.Windows.Forms.BindingSource returnDetailBindingSource;
        private CarRentalDBDataSetTableAdapters.Return_DetailTableAdapter return_DetailTableAdapter;
        private CarRentalDBDataSet1 carRentalDBDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CarRentalDBDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.ComboBox textBoxcarid;
        private CarRentalDBDataSet2 carRentalDBDataSet2;
        private System.Windows.Forms.BindingSource carBindingSource;
        private CarRentalDBDataSet2TableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.Label label7;
        private CarRentalDBDataSet3 carRentalDBDataSet3;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private CarRentalDBDataSet3TableAdapters.CustomerTableAdapter customerTableAdapter1;
        private CarRentalDBDataSet4 carRentalDBDataSet4;
        private System.Windows.Forms.BindingSource carBindingSource1;
        private CarRentalDBDataSet4TableAdapters.CarTableAdapter carTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}