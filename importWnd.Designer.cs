namespace RAE {
	partial class importWnd {
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
			this.importBtn = new System.Windows.Forms.Button();
			this.importedLst = new System.Windows.Forms.ListBox();
			this.nextBtn = new System.Windows.Forms.Button();
			this.explanationLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// importBtn
			// 
			this.importBtn.Location = new System.Drawing.Point(11, 295);
			this.importBtn.Name = "importBtn";
			this.importBtn.Size = new System.Drawing.Size(75, 23);
			this.importBtn.TabIndex = 0;
			this.importBtn.Text = "Import datasets";
			this.importBtn.UseVisualStyleBackColor = true;
			this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
			// 
			// importedLst
			// 
			this.importedLst.FormattingEnabled = true;
			this.importedLst.Location = new System.Drawing.Point(11, 11);
			this.importedLst.Name = "importedLst";
			this.importedLst.Size = new System.Drawing.Size(653, 277);
			this.importedLst.TabIndex = 1;
			// 
			// nextBtn
			// 
			this.nextBtn.Enabled = false;
			this.nextBtn.Location = new System.Drawing.Point(589, 295);
			this.nextBtn.Name = "nextBtn";
			this.nextBtn.Size = new System.Drawing.Size(75, 23);
			this.nextBtn.TabIndex = 2;
			this.nextBtn.Text = "Next";
			this.nextBtn.UseVisualStyleBackColor = true;
			this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
			// 
			// explanationLbl
			// 
			this.explanationLbl.Location = new System.Drawing.Point(122, 295);
			this.explanationLbl.Name = "explanationLbl";
			this.explanationLbl.Size = new System.Drawing.Size(444, 28);
			this.explanationLbl.TabIndex = 3;
			this.explanationLbl.Text = "All imported datasets will be listed here. Click \"Import\" on the left to choose d" +
    "ataset files, and then \"Next\" on the right side to advance to the description st" +
    "age.";
			this.explanationLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// importWnd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 332);
			this.Controls.Add(this.explanationLbl);
			this.Controls.Add(this.nextBtn);
			this.Controls.Add(this.importedLst);
			this.Controls.Add(this.importBtn);
			this.Name = "importWnd";
			this.Text = "Import Datasets";
			this.Load += new System.EventHandler(this.importWnd_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button importBtn;
		private System.Windows.Forms.ListBox importedLst;
		private System.Windows.Forms.Button nextBtn;
		private System.Windows.Forms.Label explanationLbl;
	}
}