namespace RAE {
	partial class runWnd {
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
			this.stateStatusAnalysisBtn = new System.Windows.Forms.Button();
			this.divisionStatusAnalysisBtn = new System.Windows.Forms.Button();
			this.runAprioriBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// stateStatusAnalysisBtn
			// 
			this.stateStatusAnalysisBtn.Location = new System.Drawing.Point(27, 12);
			this.stateStatusAnalysisBtn.Name = "stateStatusAnalysisBtn";
			this.stateStatusAnalysisBtn.Size = new System.Drawing.Size(228, 23);
			this.stateStatusAnalysisBtn.TabIndex = 0;
			this.stateStatusAnalysisBtn.Text = "Status by state (graph)";
			this.stateStatusAnalysisBtn.UseVisualStyleBackColor = true;
			this.stateStatusAnalysisBtn.Click += new System.EventHandler(this.stateStatusAnalysisBtn_Click);
			// 
			// divisionStatusAnalysisBtn
			// 
			this.divisionStatusAnalysisBtn.Location = new System.Drawing.Point(27, 43);
			this.divisionStatusAnalysisBtn.Name = "divisionStatusAnalysisBtn";
			this.divisionStatusAnalysisBtn.Size = new System.Drawing.Size(228, 23);
			this.divisionStatusAnalysisBtn.TabIndex = 1;
			this.divisionStatusAnalysisBtn.Text = "Status by division (graph)";
			this.divisionStatusAnalysisBtn.UseVisualStyleBackColor = true;
			this.divisionStatusAnalysisBtn.Click += new System.EventHandler(this.divisionStatusAnalysisBtn_Click);
			// 
			// runAprioriBtn
			// 
			this.runAprioriBtn.Location = new System.Drawing.Point(27, 72);
			this.runAprioriBtn.Name = "runAprioriBtn";
			this.runAprioriBtn.Size = new System.Drawing.Size(228, 23);
			this.runAprioriBtn.TabIndex = 2;
			this.runAprioriBtn.Text = "Find association rules using Apriori";
			this.runAprioriBtn.UseVisualStyleBackColor = true;
			this.runAprioriBtn.Click += new System.EventHandler(this.runAprioriBtn_Click);
			// 
			// runWnd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 101);
			this.Controls.Add(this.runAprioriBtn);
			this.Controls.Add(this.divisionStatusAnalysisBtn);
			this.Controls.Add(this.stateStatusAnalysisBtn);
			this.Name = "runWnd";
			this.Text = "Run Analysis";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button stateStatusAnalysisBtn;
		private System.Windows.Forms.Button divisionStatusAnalysisBtn;
		private System.Windows.Forms.Button runAprioriBtn;
	}
}