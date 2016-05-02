using RAE.Analysis_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAE {
	public partial class runWnd : Form {
		public runWnd() {
			InitializeComponent();
		}

		private void stateStatusAnalysisBtn_Click( object sender, EventArgs e ) {
			stateStatusWnd stateStatusWindow = new stateStatusWnd();
			stateStatusWindow.Show();
		}

		private void divisionStatusAnalysisBtn_Click( object sender, EventArgs e ) {
			divisionStatusWnd divisionStatusWindow = new divisionStatusWnd();
			divisionStatusWindow.Show();
		}

		private void runAprioriBtn_Click( object sender, EventArgs e ) {
			aprioriWnd aprioriWindow = new aprioriWnd();
			aprioriWindow.Show();
		}
	}
}
