using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAE {
	public partial class menuWnd : Form {
		public menuWnd() {
			InitializeComponent();
		}

		private void menuWnd_Load( object sender, EventArgs e ) {
			
		}

		private void debugBtn_Click( object sender, EventArgs e ) {
			stateStatusWnd test = new stateStatusWnd();
			test.Show();
		}

		private void prepareDataBtn_Click( object sender, EventArgs e ) {
			importWnd importer = new importWnd();
			importer.Show();
		}

		private void runAnalysisBtn_Click( object sender, EventArgs e ) {
			runWnd runWindow = new runWnd();
			runWindow.Show();
		}

		private void chooseAttributesBtn_Click( object sender, EventArgs e ) {
			chooseAttributesWnd chooseAttributesWindow = new chooseAttributesWnd();
			chooseAttributesWindow.Show();
		}

		private void saveHistoryBtn_Click( object sender, EventArgs e ) {
			SaveFileDialog historyDialog = new SaveFileDialog();
			historyDialog.Filter = "Text document (*.txt)|*.txt";
			historyDialog.FilterIndex = 1;
			historyDialog.RestoreDirectory = true;

			if( historyDialog.ShowDialog() == DialogResult.OK ) {
				File.WriteAllText( historyDialog.FileName, Program.history );
			}
		}
	}
}
