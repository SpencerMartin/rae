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
	public partial class describeWnd : Form {
		public describeWnd() {
			InitializeComponent();
		}

		private void describeWnd_Load( object sender, EventArgs e ) {
			foreach( KeyValuePair<string, string> entry in Program.importedFiles ) {
				// index, file, described
				ListViewItem item = new ListViewItem( new[] { entry.Key, entry.Value } );
				datasetLst.Items.Add( item );
			}
		}

		private void datasetLst_ItemSelectionChanged( object sender, ListViewItemSelectionChangedEventArgs e ) {
			string datasetIndex = "";
			fieldLst.Items.Clear();
			fieldOriginalLbl.Text = "";
			fieldShortFld.Text = "";

			try {
				datasetIndex = datasetLst.SelectedItems[0].Text.Trim();
			} catch( Exception ex ) {

			}
			if( datasetIndex == "" ) return;

			Dictionary<string, string> datasetFields = Program.fieldsShort[datasetIndex];
			foreach( KeyValuePair<string, string> entry in datasetFields ) {
				// original, readable
				ListViewItem item = new ListViewItem( new[] { entry.Key, entry.Value } );
				fieldLst.Items.Add( item );
			}
		}

		private void fieldLst_SelectedIndexChanged( object sender, EventArgs e ) {
			fieldOriginalLbl.Text = "";
			fieldShortFld.Text = "";

			try {
				string originalText = fieldLst.SelectedItems[0].Text.Trim();
				string shortText = fieldLst.SelectedItems[0].SubItems[1].Text.Trim();

				fieldOriginalLbl.Text = originalText;
				fieldShortFld.Text = shortText;
			} catch( Exception ex ) {

			}
		}

		private void fieldShortFld_TextChanged( object sender, EventArgs e ) {
			string datasetIndex = "";
			string fieldIndex = "";
			try {
				datasetIndex = datasetLst.SelectedItems[0].Text.Trim();
				fieldIndex = fieldLst.SelectedItems[0].Text.Trim();
			} catch( Exception ex ) {

			}
			if( datasetIndex == "" || fieldIndex == ""  || fieldShortFld.Text.Length == 0 ) return;

			Program.fieldsShort[datasetIndex][fieldIndex] = fieldShortFld.Text;
			fieldLst.SelectedItems[0].SubItems[1].Text = fieldShortFld.Text;
		}

		private void finishBtn_Click( object sender, EventArgs e ) {
			// Export each dataset description
			foreach( string datasetKey in Program.fieldsShort.Keys ) {
				string datasetFile = Program.importedFiles[datasetKey];
				string descriptorFile = Path.GetFileNameWithoutExtension( datasetFile ) + "descriptors.raed";
				String descriptorCSV = String.Join(
					Environment.NewLine,
					Program.fieldsShort[datasetKey].Select( d => d.Key + "<KEY|VALUE>" + d.Value )
				);
				File.WriteAllText( descriptorFile, descriptorCSV );
			}
			this.Close();
		}
	}
}
