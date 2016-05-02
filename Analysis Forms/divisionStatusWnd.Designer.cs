namespace RAE.Analysis_Forms {
	partial class divisionStatusWnd {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(divisionStatusWnd));
			this.divisionTargetSlct = new System.Windows.Forms.ComboBox();
			this.divisionTargetLbl = new System.Windows.Forms.Label();
			this.saveBtn = new System.Windows.Forms.Button();
			this.divisionFieldLbl = new System.Windows.Forms.Label();
			this.statusLbl = new System.Windows.Forms.Label();
			this.divisionFieldSlct = new System.Windows.Forms.ComboBox();
			this.statusFieldSlct = new System.Windows.Forms.ComboBox();
			this.datasetLbl = new System.Windows.Forms.Label();
			this.datasetSlct = new System.Windows.Forms.ComboBox();
			this.runBtn = new System.Windows.Forms.Button();
			this.previewPic = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.previewPic)).BeginInit();
			this.SuspendLayout();
			// 
			// divisionTargetSlct
			// 
			this.divisionTargetSlct.Enabled = false;
			this.divisionTargetSlct.FormattingEnabled = true;
			this.divisionTargetSlct.Location = new System.Drawing.Point(420, 43);
			this.divisionTargetSlct.Name = "divisionTargetSlct";
			this.divisionTargetSlct.Size = new System.Drawing.Size(117, 21);
			this.divisionTargetSlct.TabIndex = 21;
			this.divisionTargetSlct.SelectedIndexChanged += new System.EventHandler(this.divisionTargetSlct_SelectedIndexChanged);
			// 
			// divisionTargetLbl
			// 
			this.divisionTargetLbl.AutoSize = true;
			this.divisionTargetLbl.Location = new System.Drawing.Point(335, 46);
			this.divisionTargetLbl.Name = "divisionTargetLbl";
			this.divisionTargetLbl.Size = new System.Drawing.Size(79, 13);
			this.divisionTargetLbl.TabIndex = 20;
			this.divisionTargetLbl.Text = "Target division:";
			// 
			// saveBtn
			// 
			this.saveBtn.Enabled = false;
			this.saveBtn.Image = global::RAE.Properties.Resources.save;
			this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.saveBtn.Location = new System.Drawing.Point(607, 46);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.saveBtn.Size = new System.Drawing.Size(118, 23);
			this.saveBtn.TabIndex = 19;
			this.saveBtn.Text = "Save Image";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// divisionFieldLbl
			// 
			this.divisionFieldLbl.AutoSize = true;
			this.divisionFieldLbl.Location = new System.Drawing.Point(335, 15);
			this.divisionFieldLbl.Name = "divisionFieldLbl";
			this.divisionFieldLbl.Size = new System.Drawing.Size(69, 13);
			this.divisionFieldLbl.TabIndex = 18;
			this.divisionFieldLbl.Text = "Division field:";
			// 
			// statusLbl
			// 
			this.statusLbl.AutoSize = true;
			this.statusLbl.Location = new System.Drawing.Point(18, 46);
			this.statusLbl.Name = "statusLbl";
			this.statusLbl.Size = new System.Drawing.Size(62, 13);
			this.statusLbl.TabIndex = 17;
			this.statusLbl.Text = "Status field:";
			// 
			// divisionFieldSlct
			// 
			this.divisionFieldSlct.Enabled = false;
			this.divisionFieldSlct.FormattingEnabled = true;
			this.divisionFieldSlct.Location = new System.Drawing.Point(420, 12);
			this.divisionFieldSlct.Name = "divisionFieldSlct";
			this.divisionFieldSlct.Size = new System.Drawing.Size(217, 21);
			this.divisionFieldSlct.TabIndex = 16;
			this.divisionFieldSlct.SelectedIndexChanged += new System.EventHandler( this.divisionFieldSlct_SelectedIndexChanged );
			// 
			// statusFieldSlct
			// 
			this.statusFieldSlct.Enabled = false;
			this.statusFieldSlct.FormattingEnabled = true;
			this.statusFieldSlct.Location = new System.Drawing.Point(86, 43);
			this.statusFieldSlct.Name = "statusFieldSlct";
			this.statusFieldSlct.Size = new System.Drawing.Size(229, 21);
			this.statusFieldSlct.TabIndex = 15;
			this.statusFieldSlct.SelectedIndexChanged += new System.EventHandler(this.statusFieldSlct_SelectedIndexChanged);
			// 
			// datasetLbl
			// 
			this.datasetLbl.AutoSize = true;
			this.datasetLbl.Location = new System.Drawing.Point(18, 15);
			this.datasetLbl.Name = "datasetLbl";
			this.datasetLbl.Size = new System.Drawing.Size(47, 13);
			this.datasetLbl.TabIndex = 14;
			this.datasetLbl.Text = "Dataset:";
			// 
			// datasetSlct
			// 
			this.datasetSlct.FormattingEnabled = true;
			this.datasetSlct.Location = new System.Drawing.Point(86, 12);
			this.datasetSlct.Name = "datasetSlct";
			this.datasetSlct.Size = new System.Drawing.Size(229, 21);
			this.datasetSlct.TabIndex = 13;
			this.datasetSlct.SelectedIndexChanged += new System.EventHandler(this.datasetSlct_SelectedIndexChanged);
			// 
			// runBtn
			// 
			this.runBtn.Enabled = false;
			this.runBtn.Image = ((System.Drawing.Image)(resources.GetObject("runBtn.Image")));
			this.runBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.runBtn.Location = new System.Drawing.Point(650, 12);
			this.runBtn.Name = "runBtn";
			this.runBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.runBtn.Size = new System.Drawing.Size(75, 23);
			this.runBtn.TabIndex = 12;
			this.runBtn.Text = "Run";
			this.runBtn.UseVisualStyleBackColor = true;
			this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
			// 
			// previewPic
			// 
			this.previewPic.Location = new System.Drawing.Point(21, 79);
			this.previewPic.Name = "previewPic";
			this.previewPic.Size = new System.Drawing.Size(704, 382);
			this.previewPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.previewPic.TabIndex = 11;
			this.previewPic.TabStop = false;
			// 
			// divisionStatusWnd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(744, 469);
			this.Controls.Add(this.divisionTargetSlct);
			this.Controls.Add(this.divisionTargetLbl);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.divisionFieldLbl);
			this.Controls.Add(this.statusLbl);
			this.Controls.Add(this.divisionFieldSlct);
			this.Controls.Add(this.statusFieldSlct);
			this.Controls.Add(this.datasetLbl);
			this.Controls.Add(this.datasetSlct);
			this.Controls.Add(this.runBtn);
			this.Controls.Add(this.previewPic);
			this.Name = "divisionStatusWnd";
			this.Text = "Status by Division";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.divisionStatusWnd_FormClosed);
			this.Load += new System.EventHandler(this.divisionStatusWnd_Load);
			((System.ComponentModel.ISupportInitialize)(this.previewPic)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox divisionTargetSlct;
		private System.Windows.Forms.Label divisionTargetLbl;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Label divisionFieldLbl;
		private System.Windows.Forms.Label statusLbl;
		private System.Windows.Forms.ComboBox divisionFieldSlct;
		private System.Windows.Forms.ComboBox statusFieldSlct;
		private System.Windows.Forms.Label datasetLbl;
		private System.Windows.Forms.ComboBox datasetSlct;
		private System.Windows.Forms.Button runBtn;
		private System.Windows.Forms.PictureBox previewPic;
	}
}