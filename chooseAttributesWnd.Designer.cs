namespace RAE {
	partial class chooseAttributesWnd {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chooseAttributesWnd));
			this.datasetSlct = new System.Windows.Forms.ComboBox();
			this.datasetLbl = new System.Windows.Forms.Label();
			this.fieldsLst = new System.Windows.Forms.CheckedListBox();
			this.finishBtn = new System.Windows.Forms.Button();
			this.saveBtn = new System.Windows.Forms.Button();
			this.explanationLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// datasetSlct
			// 
			this.datasetSlct.FormattingEnabled = true;
			this.datasetSlct.Location = new System.Drawing.Point(66, 9);
			this.datasetSlct.Name = "datasetSlct";
			this.datasetSlct.Size = new System.Drawing.Size(459, 21);
			this.datasetSlct.TabIndex = 0;
			this.datasetSlct.SelectedIndexChanged += new System.EventHandler(this.datasetSlct_SelectedIndexChanged);
			// 
			// datasetLbl
			// 
			this.datasetLbl.AutoSize = true;
			this.datasetLbl.Location = new System.Drawing.Point(13, 12);
			this.datasetLbl.Name = "datasetLbl";
			this.datasetLbl.Size = new System.Drawing.Size(47, 13);
			this.datasetLbl.TabIndex = 1;
			this.datasetLbl.Text = "Dataset:";
			// 
			// fieldsLst
			// 
			this.fieldsLst.Enabled = false;
			this.fieldsLst.FormattingEnabled = true;
			this.fieldsLst.Location = new System.Drawing.Point(16, 36);
			this.fieldsLst.Name = "fieldsLst";
			this.fieldsLst.Size = new System.Drawing.Size(509, 484);
			this.fieldsLst.TabIndex = 2;
			this.fieldsLst.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.fieldsLst_ItemCheck);
			// 
			// finishBtn
			// 
			this.finishBtn.Enabled = false;
			this.finishBtn.Location = new System.Drawing.Point(450, 609);
			this.finishBtn.Name = "finishBtn";
			this.finishBtn.Size = new System.Drawing.Size(75, 23);
			this.finishBtn.TabIndex = 3;
			this.finishBtn.Text = "Finish";
			this.finishBtn.UseVisualStyleBackColor = true;
			this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
			// 
			// saveBtn
			// 
			this.saveBtn.Enabled = false;
			this.saveBtn.Image = global::RAE.Properties.Resources.save;
			this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.saveBtn.Location = new System.Drawing.Point(16, 609);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.saveBtn.Size = new System.Drawing.Size(144, 23);
			this.saveBtn.TabIndex = 20;
			this.saveBtn.Text = "Export Dataset";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// explanationLbl
			// 
			this.explanationLbl.Location = new System.Drawing.Point(16, 523);
			this.explanationLbl.Name = "explanationLbl";
			this.explanationLbl.Size = new System.Drawing.Size(509, 83);
			this.explanationLbl.TabIndex = 21;
			this.explanationLbl.Text = resources.GetString("explanationLbl.Text");
			this.explanationLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// chooseAttributesWnd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 644);
			this.Controls.Add(this.explanationLbl);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.finishBtn);
			this.Controls.Add(this.fieldsLst);
			this.Controls.Add(this.datasetLbl);
			this.Controls.Add(this.datasetSlct);
			this.Name = "chooseAttributesWnd";
			this.Text = "Choose Attributes";
			this.Load += new System.EventHandler(this.chooseAttributesWnd_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox datasetSlct;
		private System.Windows.Forms.Label datasetLbl;
		private System.Windows.Forms.CheckedListBox fieldsLst;
		private System.Windows.Forms.Button finishBtn;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Label explanationLbl;
	}
}