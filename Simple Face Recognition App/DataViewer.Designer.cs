using System.Drawing;
using System.Windows.Forms;

namespace Simple_Face_Recognition_App
{
    partial class DataViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewer));
            this.facesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faceDataSet = new Simple_Face_Recognition_App.FaceDataSet();
            this.facesTableAdapter = new Simple_Face_Recognition_App.FaceDataSetTableAdapters.facesTableAdapter();
            this.faceDataSet1 = new Simple_Face_Recognition_App.FaceDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.facesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // facesBindingSource
            // 
            this.facesBindingSource.DataMember = "faces";
            this.facesBindingSource.DataSource = this.faceDataSet;
            // 
            // faceDataSet
            // 
            this.faceDataSet.DataSetName = "FaceDataSet";
            this.faceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facesTableAdapter
            // 
            this.facesTableAdapter.ClearBeforeFill = true;
            // 
            // faceDataSet1
            // 
            this.faceDataSet1.DataSetName = "FaceDataSet";
            this.faceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(13)))), ((int)(((byte)(55)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 373);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // DataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(13)))), ((int)(((byte)(55)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 581);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(805, 620);
            this.MinimumSize = new System.Drawing.Size(805, 620);
            this.Name = "DataViewer";
            this.ShowInTaskbar = false;
            this.Text = "DataViewer";
            this.Load += new System.EventHandler(this.DataViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FaceDataSet faceDataSet;
        private System.Windows.Forms.BindingSource facesBindingSource;
        private FaceDataSetTableAdapters.facesTableAdapter facesTableAdapter;
        private FaceDataSet faceDataSet1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewImageColumn pictureDataGridViewImageColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}