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

namespace RAE.Analysis_Forms {
	public partial class divisionStatusWnd : Form {
		private string selectedDatasetKey = "";
		private string selectedStatusField = "";
		private string selectedDivisionField = "";
		private string selectedDivisionTarget = "";
		private Bitmap currentImage;

		public divisionStatusWnd() {
			InitializeComponent();
		}

		private void divisionStatusWnd_Load( object sender, EventArgs e ) {
			// Populate dataset list
			foreach( string datasetFile in Program.importedFiles.Values ) {
				datasetSlct.Items.Add( datasetFile );
			}
		}

		private void runBtn_Click( object sender, EventArgs e ) {
			if( selectedDatasetKey == "" || selectedStatusField == "" || selectedDivisionTarget == "" )
				return;

			// Get R field names
			string rStatusField = "";
			foreach( KeyValuePair<string, string> field in Program.fieldsR[selectedDatasetKey] ) {
				// key = original, value = r field name
				if( field.Key == selectedStatusField ) {
					rStatusField = field.Value;
					break;
				}
			}
			string rDivisionField = "";
			foreach( KeyValuePair<string, string> field in Program.fieldsR[selectedDatasetKey] ) {
				// key = original, value = r field name
				if( field.Key == selectedDivisionField ) {
					rDivisionField = field.Value;
					break;
				}
			}

			if( rStatusField == "" || rDivisionField == "" )
				return;

			Program.loadPackage( "ggplot2" );
			REvaluation createDivisionMapFunction = new REvaluation( @"map_division_status <- function( dataset, statusField, divisionField, divisionTarget, title ){ divisionRowIndexes <- which( dataset[,divisionField] == divisionTarget ); divisionRows <- dataset[divisionRowIndexes,]; divisionData <- data.frame( table( divisionRows[,statusField] ) );	names( divisionData ) <- c( 'Status', 'Count' ); plot <- ggplot( dat = divisionData[2:5,], aes( x=Status, y=Count, fill='red' ) ) + geom_bar( stat='identity', colour='#D5718E', fill='#D5718E' ) + labs( title=title ) + theme_minimal() + geom_text( aes(label=Count), position=position_dodge(width=0.9), vjust = 1.5 ) }" );

			REvaluation map = new REvaluation( @"map <- map_division_status( " + selectedDatasetKey + ", '" + rStatusField + "', '" + rDivisionField + "', '" + selectedDivisionTarget + "', 'Division Status Map for " + selectedDivisionTarget + "' )" );
			REvaluation saveMap = new REvaluation( @"ggsave( plot=map, filename='test.png' )" );
			if( saveMap.success ) {
				string imageBase64 = Program.imageToBase64( "test.png" );
				currentImage = Program.base64StringToBitmap( imageBase64 );
				previewPic.Image = currentImage;
				File.Delete( "test.png" );
				saveBtn.Enabled = true;
			} else {
				MessageBox.Show( "Couldn't save plot image" );
				saveBtn.Enabled = false;
			}
		}

		private void saveBtn_Click( object sender, EventArgs e ) {
			if( currentImage != null ) {
				SaveFileDialog imageDialog = new SaveFileDialog();
				imageDialog.Filter = "Portable Network Graphics file (*.png)|*.png";
				imageDialog.FilterIndex = 1;
				imageDialog.RestoreDirectory = true;

				if( imageDialog.ShowDialog() == DialogResult.OK ) {
					currentImage.Save( imageDialog.FileName, System.Drawing.Imaging.ImageFormat.Png );
				}
			}
		}

		private void datasetSlct_SelectedIndexChanged( object sender, EventArgs e ) {
			// Get dataset key
			string datasetKey = "";
			string selectedFile = datasetSlct.SelectedItem.ToString();
			if( selectedFile == "" )
				return;

			foreach( KeyValuePair<string, string> dataset in Program.importedFiles ) {
				// key = R dataset variable name, value = filename
				if( dataset.Value == selectedFile ) {
					datasetKey = dataset.Key;
					break;
				}
			}

			if( datasetKey != "" ) {
				selectedDatasetKey = datasetKey;

				// Load fields
				statusFieldSlct.Items.Clear();
				divisionFieldSlct.Items.Clear();

				foreach( KeyValuePair<string, string> fields in Program.fieldsShort[datasetKey] ) {
					// key = original, value = short
					statusFieldSlct.Items.Add( fields.Value );
					divisionFieldSlct.Items.Add( fields.Value );
				}

				statusFieldSlct.Enabled = true;
				divisionFieldSlct.Enabled = true;
			}
		}

		private void divisionFieldSlct_SelectedIndexChanged( object sender, EventArgs e ) {
			string selectedField = divisionFieldSlct.SelectedItem.ToString();
			string rStateField = "";
			if( selectedField == "" )
				return;

			if( selectedDatasetKey != "" ) {
				// selectedField is short field name, so find original
				string originalField = "";
				foreach( KeyValuePair<string, string> fields in Program.fieldsShort[selectedDatasetKey] ) {
					// key = original, value = short
					if( fields.Value == selectedField ) {
						originalField = fields.Key;
						break;
					}
				}
				selectedDivisionField = originalField;

				// Get R field name
				foreach( KeyValuePair<string, string> field in Program.fieldsR[selectedDatasetKey] ) {
					// key = original, value = r field name
					if( field.Key == selectedDivisionField ) {
						rStateField = field.Value;
						break;
					}
				}

				if( rStateField == "" )
					return;

				// Load states
				divisionTargetSlct.Items.Clear();

				REvaluation statesList = new REvaluation( "as.character( unique( " + selectedDatasetKey + "$" + rStateField + " ) )" );

				List<string> states = statesList.asStringList();
				states.Sort();
				foreach( string state in states ) {
					string trimmedState = state.Trim();
					switch( trimmedState ) {
					case "?":
					case "#N/A":
					case "0":
					case "":
						break;
					default:
						divisionTargetSlct.Items.Add( trimmedState );
						break;
					}
				}

				divisionTargetSlct.Enabled = true;
			}

			if( selectedDatasetKey == "" || selectedStatusField == "" || selectedDivisionTarget == "" || rStateField == "" ) {
				runBtn.Enabled = false;
			} else {
				runBtn.Enabled = true;
			}
		}

		private void statusFieldSlct_SelectedIndexChanged( object sender, EventArgs e ) {
			string selectedField = statusFieldSlct.SelectedItem.ToString();
			if( selectedField == "" )
				return;

			// selectedField is short field name, so find original
			string originalField = "";
			foreach( KeyValuePair<string, string> fields in Program.fieldsShort[selectedDatasetKey] ) {
				// key = original, value = short
				if( fields.Value == selectedField ) {
					originalField = fields.Key;
					break;
				}
			}
			selectedStatusField = originalField;

			if( selectedDatasetKey == "" || selectedStatusField == "" || selectedDivisionTarget == "" ) {
				runBtn.Enabled = false;
			} else {
				runBtn.Enabled = true;
			}
		}

		private void divisionTargetSlct_SelectedIndexChanged( object sender, EventArgs e ) {
			selectedDivisionTarget = divisionTargetSlct.SelectedItem.ToString();
			if( selectedDivisionTarget == "" ) return;

			if( selectedDatasetKey == "" || selectedStatusField == "" || selectedDivisionTarget == "" ) {
				runBtn.Enabled = false;
			} else {
				runBtn.Enabled = true;
			}
		}

		private void divisionStatusWnd_FormClosed( object sender, FormClosedEventArgs e ) {
			if( currentImage != null ) currentImage.Dispose();
		}
	}
}
