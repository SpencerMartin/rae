namespace RAE {
	partial class stateStatusWnd {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stateStatusWnd));
			this.datasetSlct = new System.Windows.Forms.ComboBox();
			this.datasetLbl = new System.Windows.Forms.Label();
			this.statusFieldSlct = new System.Windows.Forms.ComboBox();
			this.stateFieldSlct = new System.Windows.Forms.ComboBox();
			this.statusLbl = new System.Windows.Forms.Label();
			this.stateFieldLbl = new System.Windows.Forms.Label();
			this.saveBtn = new System.Windows.Forms.Button();
			this.stateTargetLbl = new System.Windows.Forms.Label();
			this.stateTargetSlct = new System.Windows.Forms.ComboBox();
			this.runBtn = new System.Windows.Forms.Button();
			this.previewPic = new System.Windows.Forms.PictureBox();
			this.noEnrolleesLbl = new System.Windows.Forms.Label();
			this.noEnrolleeFld = new System.Windows.Forms.Label();
			this.bestFld = new System.Windows.Forms.Label();
			this.bestLbl = new System.Windows.Forms.Label();
			this.worstFld = new System.Windows.Forms.Label();
			this.worstLbl = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.previewPic)).BeginInit();
			this.SuspendLayout();
			// 
			// datasetSlct
			// 
			this.datasetSlct.FormattingEnabled = true;
			this.datasetSlct.Location = new System.Drawing.Point(80, 18);
			this.datasetSlct.Name = "datasetSlct";
			this.datasetSlct.Size = new System.Drawing.Size(439, 21);
			this.datasetSlct.TabIndex = 2;
			this.datasetSlct.SelectedIndexChanged += new System.EventHandler(this.datasetSlct_SelectedIndexChanged);
			// 
			// datasetLbl
			// 
			this.datasetLbl.AutoSize = true;
			this.datasetLbl.Location = new System.Drawing.Point(12, 21);
			this.datasetLbl.Name = "datasetLbl";
			this.datasetLbl.Size = new System.Drawing.Size(47, 13);
			this.datasetLbl.TabIndex = 3;
			this.datasetLbl.Text = "Dataset:";
			// 
			// statusFieldSlct
			// 
			this.statusFieldSlct.Enabled = false;
			this.statusFieldSlct.FormattingEnabled = true;
			this.statusFieldSlct.Location = new System.Drawing.Point(80, 49);
			this.statusFieldSlct.Name = "statusFieldSlct";
			this.statusFieldSlct.Size = new System.Drawing.Size(229, 21);
			this.statusFieldSlct.TabIndex = 4;
			this.statusFieldSlct.SelectedIndexChanged += new System.EventHandler(this.statusFieldSlct_SelectedIndexChanged);
			// 
			// stateFieldSlct
			// 
			this.stateFieldSlct.Enabled = false;
			this.stateFieldSlct.FormattingEnabled = true;
			this.stateFieldSlct.Location = new System.Drawing.Point(606, 18);
			this.stateFieldSlct.Name = "stateFieldSlct";
			this.stateFieldSlct.Size = new System.Drawing.Size(229, 21);
			this.stateFieldSlct.TabIndex = 5;
			this.stateFieldSlct.SelectedIndexChanged += new System.EventHandler(this.stateFieldSlct_SelectedIndexChanged);
			// 
			// statusLbl
			// 
			this.statusLbl.AutoSize = true;
			this.statusLbl.Location = new System.Drawing.Point(12, 52);
			this.statusLbl.Name = "statusLbl";
			this.statusLbl.Size = new System.Drawing.Size(62, 13);
			this.statusLbl.TabIndex = 6;
			this.statusLbl.Text = "Status field:";
			// 
			// stateFieldLbl
			// 
			this.stateFieldLbl.AutoSize = true;
			this.stateFieldLbl.Location = new System.Drawing.Point(543, 21);
			this.stateFieldLbl.Name = "stateFieldLbl";
			this.stateFieldLbl.Size = new System.Drawing.Size(57, 13);
			this.stateFieldLbl.TabIndex = 7;
			this.stateFieldLbl.Text = "State field:";
			// 
			// saveBtn
			// 
			this.saveBtn.Enabled = false;
			this.saveBtn.Image = global::RAE.Properties.Resources.save;
			this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.saveBtn.Location = new System.Drawing.Point(717, 45);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.saveBtn.Size = new System.Drawing.Size(118, 23);
			this.saveBtn.TabIndex = 8;
			this.saveBtn.Text = "Save Image";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// stateTargetLbl
			// 
			this.stateTargetLbl.AutoSize = true;
			this.stateTargetLbl.Location = new System.Drawing.Point(329, 52);
			this.stateTargetLbl.Name = "stateTargetLbl";
			this.stateTargetLbl.Size = new System.Drawing.Size(67, 13);
			this.stateTargetLbl.TabIndex = 9;
			this.stateTargetLbl.Text = "Target state:";
			// 
			// stateTargetSlct
			// 
			this.stateTargetSlct.Enabled = false;
			this.stateTargetSlct.FormattingEnabled = true;
			this.stateTargetSlct.Location = new System.Drawing.Point(402, 45);
			this.stateTargetSlct.Name = "stateTargetSlct";
			this.stateTargetSlct.Size = new System.Drawing.Size(117, 21);
			this.stateTargetSlct.TabIndex = 10;
			this.stateTargetSlct.SelectedIndexChanged += new System.EventHandler(this.stateTargetSlct_SelectedIndexChanged);
			// 
			// runBtn
			// 
			this.runBtn.Enabled = false;
			this.runBtn.Image = ((System.Drawing.Image)(resources.GetObject("runBtn.Image")));
			this.runBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.runBtn.Location = new System.Drawing.Point(540, 45);
			this.runBtn.Name = "runBtn";
			this.runBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.runBtn.Size = new System.Drawing.Size(75, 23);
			this.runBtn.TabIndex = 1;
			this.runBtn.Text = "Run";
			this.runBtn.UseVisualStyleBackColor = true;
			this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
			// 
			// previewPic
			// 
			this.previewPic.Location = new System.Drawing.Point(15, 85);
			this.previewPic.Name = "previewPic";
			this.previewPic.Size = new System.Drawing.Size(600, 600);
			this.previewPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.previewPic.TabIndex = 0;
			this.previewPic.TabStop = false;
			// 
			// noEnrolleesLbl
			// 
			this.noEnrolleesLbl.AutoSize = true;
			this.noEnrolleesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.noEnrolleesLbl.Location = new System.Drawing.Point(624, 85);
			this.noEnrolleesLbl.Name = "noEnrolleesLbl";
			this.noEnrolleesLbl.Size = new System.Drawing.Size(181, 16);
			this.noEnrolleesLbl.TabIndex = 11;
			this.noEnrolleesLbl.Text = "States with no representation:";
			// 
			// noEnrolleeFld
			// 
			this.noEnrolleeFld.Location = new System.Drawing.Point(624, 101);
			this.noEnrolleeFld.Name = "noEnrolleeFld";
			this.noEnrolleeFld.Size = new System.Drawing.Size(211, 168);
			this.noEnrolleeFld.TabIndex = 12;
			this.noEnrolleeFld.Text = "<Select state field>";
			// 
			// bestFld
			// 
			this.bestFld.Location = new System.Drawing.Point(624, 312);
			this.bestFld.Name = "bestFld";
			this.bestFld.Size = new System.Drawing.Size(211, 112);
			this.bestFld.TabIndex = 14;
			this.bestFld.Text = "<Select state field>";
			// 
			// bestLbl
			// 
			this.bestLbl.AutoSize = true;
			this.bestLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bestLbl.Location = new System.Drawing.Point(621, 292);
			this.bestLbl.Name = "bestLbl";
			this.bestLbl.Size = new System.Drawing.Size(165, 16);
			this.bestLbl.TabIndex = 13;
			this.bestLbl.Text = "States with best outcomes:";
			// 
			// worstFld
			// 
			this.worstFld.Location = new System.Drawing.Point(624, 466);
			this.worstFld.Name = "worstFld";
			this.worstFld.Size = new System.Drawing.Size(211, 112);
			this.worstFld.TabIndex = 16;
			this.worstFld.Text = "<Select state field>";
			// 
			// worstLbl
			// 
			this.worstLbl.AutoSize = true;
			this.worstLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.worstLbl.Location = new System.Drawing.Point(621, 446);
			this.worstLbl.Name = "worstLbl";
			this.worstLbl.Size = new System.Drawing.Size(170, 16);
			this.worstLbl.TabIndex = 15;
			this.worstLbl.Text = "States with worst outcomes:";
			// 
			// stateStatusWnd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(856, 702);
			this.Controls.Add(this.worstFld);
			this.Controls.Add(this.worstLbl);
			this.Controls.Add(this.bestFld);
			this.Controls.Add(this.bestLbl);
			this.Controls.Add(this.noEnrolleeFld);
			this.Controls.Add(this.noEnrolleesLbl);
			this.Controls.Add(this.stateTargetSlct);
			this.Controls.Add(this.stateTargetLbl);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.stateFieldLbl);
			this.Controls.Add(this.statusLbl);
			this.Controls.Add(this.stateFieldSlct);
			this.Controls.Add(this.statusFieldSlct);
			this.Controls.Add(this.datasetLbl);
			this.Controls.Add(this.datasetSlct);
			this.Controls.Add(this.runBtn);
			this.Controls.Add(this.previewPic);
			this.Name = "stateStatusWnd";
			this.Text = "Status by State";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.stateStatusWnd_FormClosed);
			this.Load += new System.EventHandler(this.stateStatusWnd_Load);
			((System.ComponentModel.ISupportInitialize)(this.previewPic)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox previewPic;
		private System.Windows.Forms.Button runBtn;
		private System.Windows.Forms.ComboBox datasetSlct;
		private System.Windows.Forms.Label datasetLbl;
		private System.Windows.Forms.ComboBox statusFieldSlct;
		private System.Windows.Forms.ComboBox stateFieldSlct;
		private System.Windows.Forms.Label statusLbl;
		private System.Windows.Forms.Label stateFieldLbl;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Label stateTargetLbl;
		private System.Windows.Forms.ComboBox stateTargetSlct;
		private System.Windows.Forms.Label noEnrolleesLbl;
		private System.Windows.Forms.Label noEnrolleeFld;
		private System.Windows.Forms.Label bestFld;
		private System.Windows.Forms.Label bestLbl;
		private System.Windows.Forms.Label worstFld;
		private System.Windows.Forms.Label worstLbl;

	}
}