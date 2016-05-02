namespace RAE {
	partial class describeWnd {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(describeWnd));
			this.finishBtn = new System.Windows.Forms.Button();
			this.fieldShortFld = new System.Windows.Forms.TextBox();
			this.fieldOriginalLbl = new System.Windows.Forms.Label();
			this.fieldLst = new System.Windows.Forms.ListView();
			this.originalCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.shortCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.datasetLst = new System.Windows.Forms.ListView();
			this.indexCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.fileCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.explanationLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// finishBtn
			// 
			this.finishBtn.Location = new System.Drawing.Point(776, 434);
			this.finishBtn.Name = "finishBtn";
			this.finishBtn.Size = new System.Drawing.Size(75, 23);
			this.finishBtn.TabIndex = 2;
			this.finishBtn.Text = "Finish";
			this.finishBtn.UseVisualStyleBackColor = true;
			this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
			// 
			// fieldShortFld
			// 
			this.fieldShortFld.Location = new System.Drawing.Point(399, 121);
			this.fieldShortFld.Name = "fieldShortFld";
			this.fieldShortFld.Size = new System.Drawing.Size(452, 20);
			this.fieldShortFld.TabIndex = 4;
			this.fieldShortFld.TextChanged += new System.EventHandler(this.fieldShortFld_TextChanged);
			// 
			// fieldOriginalLbl
			// 
			this.fieldOriginalLbl.Location = new System.Drawing.Point(11, 118);
			this.fieldOriginalLbl.Name = "fieldOriginalLbl";
			this.fieldOriginalLbl.Size = new System.Drawing.Size(396, 23);
			this.fieldOriginalLbl.TabIndex = 5;
			// 
			// fieldLst
			// 
			this.fieldLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.originalCol,
            this.shortCol});
			this.fieldLst.FullRowSelect = true;
			this.fieldLst.Location = new System.Drawing.Point(10, 144);
			this.fieldLst.Name = "fieldLst";
			this.fieldLst.Size = new System.Drawing.Size(841, 275);
			this.fieldLst.TabIndex = 6;
			this.fieldLst.UseCompatibleStateImageBehavior = false;
			this.fieldLst.View = System.Windows.Forms.View.Details;
			this.fieldLst.SelectedIndexChanged += new System.EventHandler(this.fieldLst_SelectedIndexChanged);
			// 
			// originalCol
			// 
			this.originalCol.Text = "Original";
			this.originalCol.Width = 387;
			// 
			// shortCol
			// 
			this.shortCol.Text = "Description";
			this.shortCol.Width = 447;
			// 
			// datasetLst
			// 
			this.datasetLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.indexCol,
            this.fileCol});
			this.datasetLst.FullRowSelect = true;
			this.datasetLst.Location = new System.Drawing.Point(9, 12);
			this.datasetLst.Name = "datasetLst";
			this.datasetLst.Size = new System.Drawing.Size(842, 97);
			this.datasetLst.TabIndex = 7;
			this.datasetLst.UseCompatibleStateImageBehavior = false;
			this.datasetLst.View = System.Windows.Forms.View.Details;
			this.datasetLst.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.datasetLst_ItemSelectionChanged);
			// 
			// indexCol
			// 
			this.indexCol.Text = "Index";
			this.indexCol.Width = 108;
			// 
			// fileCol
			// 
			this.fileCol.Text = "File";
			this.fileCol.Width = 719;
			// 
			// explanationLbl
			// 
			this.explanationLbl.Location = new System.Drawing.Point(11, 425);
			this.explanationLbl.Name = "explanationLbl";
			this.explanationLbl.Size = new System.Drawing.Size(749, 44);
			this.explanationLbl.TabIndex = 8;
			this.explanationLbl.Text = resources.GetString("explanationLbl.Text");
			this.explanationLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// describeWnd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(863, 478);
			this.Controls.Add(this.explanationLbl);
			this.Controls.Add(this.datasetLst);
			this.Controls.Add(this.fieldLst);
			this.Controls.Add(this.fieldOriginalLbl);
			this.Controls.Add(this.fieldShortFld);
			this.Controls.Add(this.finishBtn);
			this.Name = "describeWnd";
			this.Text = "Describe datasets";
			this.Load += new System.EventHandler(this.describeWnd_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button finishBtn;
		private System.Windows.Forms.TextBox fieldShortFld;
		private System.Windows.Forms.Label fieldOriginalLbl;
		private System.Windows.Forms.ListView fieldLst;
		private System.Windows.Forms.ListView datasetLst;
		private System.Windows.Forms.ColumnHeader indexCol;
		private System.Windows.Forms.ColumnHeader fileCol;
		private System.Windows.Forms.ColumnHeader originalCol;
		private System.Windows.Forms.ColumnHeader shortCol;
		private System.Windows.Forms.Label explanationLbl;
	}
}