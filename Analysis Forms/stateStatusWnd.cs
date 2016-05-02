using RDotNet;
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
	public partial class stateStatusWnd : Form {
		private string selectedDatasetKey = "";
		private string selectedStatusField = "";
		private string selectedStateField = "";
		private string selectedStateTarget = "";
		private Bitmap currentImage;

		public stateStatusWnd() {
			InitializeComponent();
		}

		private void stateStatusWnd_Load( object sender, EventArgs e ) {
			// Populate dataset list
			foreach( string datasetFile in Program.importedFiles.Values ) {
				datasetSlct.Items.Add( datasetFile );
			}
		}

		private void runBtn_Click( object sender, EventArgs e ) {
			if( selectedDatasetKey == "" || selectedStatusField == "" || selectedStateTarget == "" ) return;

			// Get R field names
			string rStatusField = "";
			foreach( KeyValuePair<string, string> field in Program.fieldsR[selectedDatasetKey] ) {
				// key = original, value = r field name
				if( field.Key == selectedStatusField ) {
					rStatusField = field.Value;
					break;
				}
			}
			string rStateField = "";
			foreach( KeyValuePair<string, string> field in Program.fieldsR[selectedDatasetKey] ) {
				// key = original, value = r field name
				if( field.Key == selectedStateField ) {
					rStateField = field.Value;
					break;
				}
			}

			if( rStatusField == "" || rStateField == "" ) return;

			Program.loadPackage( "ggplot2" );
			REvaluation createStateMapFunction = new REvaluation( @"map_state_status <- function( dataset, statusField, stateField, stateTarget, title ){ stateRowIndexes <- which( dataset[,stateField] == stateTarget ); stateRows <- dataset[stateRowIndexes,]; stateData <- data.frame( table( stateRows[,statusField] ) );	names( stateData ) <- c( 'Status', 'Count' ); plot <- ggplot( dat = stateData[2:5,], aes( x=Status, y=Count, fill='green' ) ) + geom_bar( stat='identity', colour='#C0D571', fill='#C0D571' ) + labs( title=title ) + theme_minimal() + geom_text( aes(label=Count), position=position_dodge(width=0.9), vjust = 1.5 ) }" );

			REvaluation map = new REvaluation( @"map <- map_state_status( " + selectedDatasetKey + ", '" + rStatusField + "', '" + rStateField + "', '" + selectedStateTarget + "', 'State Status Map for " + selectedStateTarget + "' )" );
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

		private void datasetSlct_SelectedIndexChanged( object sender, EventArgs e ) {
			// Get dataset key
			string datasetKey = "";
			string selectedFile = datasetSlct.SelectedItem.ToString();
			if( selectedFile == "" ) return;

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
				stateFieldSlct.Items.Clear();
				
				foreach( KeyValuePair<string, string> fields in Program.fieldsShort[datasetKey] ){
					// key = original, value = short
					statusFieldSlct.Items.Add( fields.Value );
					stateFieldSlct.Items.Add( fields.Value );
				}

				statusFieldSlct.Enabled = true;
				stateFieldSlct.Enabled = true;
			}
		}

		private void statusFieldSlct_SelectedIndexChanged( object sender, EventArgs e ) {
			string selectedField = statusFieldSlct.SelectedItem.ToString();
			if( selectedField == "" ) return;

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

			if( selectedDatasetKey == "" || selectedStatusField == "" || selectedStateTarget == "" ) {
				runBtn.Enabled = false;
			} else {
				runBtn.Enabled = true;
			}
		}

		private void stateTargetSlct_SelectedIndexChanged( object sender, EventArgs e ) {
			selectedStateTarget = stateTargetSlct.SelectedItem.ToString();
			if( selectedStateTarget == "" )	return;

			if( selectedDatasetKey == "" || selectedStatusField == "" || selectedStateTarget == "" ) {
				runBtn.Enabled = false;
			} else {
				runBtn.Enabled = true;
			}
		}

		private void stateFieldSlct_SelectedIndexChanged( object sender, EventArgs e ) {
			string selectedField = stateFieldSlct.SelectedItem.ToString();
			string rStateField = "";
			if( selectedField == "" ) return;

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
				selectedStateField = originalField;

				// Get R field name
				foreach( KeyValuePair<string, string> field in Program.fieldsR[selectedDatasetKey] ) {
					// key = original, value = r field name
					if( field.Key == selectedStateField ) {
						rStateField = field.Value;
						break;
					}
				}

				if( rStateField == "" )	return;

				// Load states
				stateTargetSlct.Items.Clear();

				REvaluation getUniqueStates = new REvaluation( "unique_states <- as.character( unique( " + selectedDatasetKey + "$" + rStateField + " ) )" );
				REvaluation removeStateIndices = new REvaluation( "remove_indices <- which( unique_states == " + '"' + "?" + '"' + " | unique_states == " + '"' + "#N/A" + '"' + " | unique_states == " + '"' + '"' + " | unique_states == " + '"' + "0" + '"' + " )" );
				REvaluation removeJunkStates = new REvaluation( "unique_states <- unique_states[-remove_indices]" );
				REvaluation statesList = new REvaluation( "unique_states" );
				
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
						stateTargetSlct.Items.Add( trimmedState );
						break;
					}
				}

				stateTargetSlct.Enabled = true;

				// Run state statistics
				runStateStatistics( rStateField );
			}

			if( selectedDatasetKey == "" || selectedStatusField == "" || selectedStateTarget == "" || rStateField == "" ) {
				runBtn.Enabled = false;
			} else {
				runBtn.Enabled = true;
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

		private void stateStatusWnd_FormClosed( object sender, FormClosedEventArgs e ) {
			if( currentImage != null ) currentImage.Dispose();
		}

		private void runStateStatistics( string rStateField ) {
			int grab = 15;
			string rStatusField = "";

			// Find R name for status field
			foreach( KeyValuePair<string, string> field in Program.fieldsR[selectedDatasetKey] ) {
				// key = original, value = r field name
				if( field.Key == selectedStatusField ) {
					rStatusField = field.Value;
					break;
				}
			}

			if( rStatusField == "" ) return;

			// Get unique statuses
			REvaluation getUniqueStatuses = new REvaluation( "unique_statuses <- as.character( unique( " + selectedDatasetKey + "$" + rStatusField + " ) )" );
			REvaluation removeStatusesIndices = new REvaluation( "remove_indices <- which( unique_statuses == " + '"' + "?" + '"' + " | unique_statuses == " + '"' + "#N/A" + '"' + " | unique_statuses == " + '"' + '"' + " | unique_statuses == " + '"' + "0" + '"' + " )" );
			REvaluation removeJunkStatuses = new REvaluation( "unique_statuses <- unique_statuses[-remove_indices]" );

			// Make stats frame
			REvaluation makeStats = new REvaluation( "stats <- data.frame( matrix( ncol = ( 4 + length( unique_statuses ) ), nrow = ( length( unique_states ) ) ) )" );
			REvaluation nameStats = new REvaluation( "names( stats ) <- c( " + '"' + "state" + '"' + ", " + '"' + "outcome_ratio" + '"' + ", " + '"' + "positive_outcomes" + '"' + ", " + '"' + "total_outcomes" + '"' + ", unique_statuses )" );
			REvaluation insertStates = new REvaluation( "stats$state <- unique_states" );

			REvaluation fillStats = new REvaluation( @"for( i in 1:nrow(stats) ){ state <- stats[i,1]; grad <- length( which( " + selectedDatasetKey + "$" + rStateField + " == state & " + selectedDatasetKey + "$" + rStatusField + " == 'Grad' ) ); stats[i,'Grad'] <- grad; withdrawn <- length( which( " + selectedDatasetKey + "$" + rStateField + " == state & " + selectedDatasetKey + "$" + rStatusField + " == 'Withdrawn' ) ); stats[i, 'Withdrawn'] <- withdrawn; acad_dism <- length( which( " + selectedDatasetKey + "$" + rStateField + " == state & " + selectedDatasetKey + "$" + rStatusField + " == 'Acad Dism' ) ); stats[i, 'Acad Dism'] <- acad_dism; enrolled <- length( which( " + selectedDatasetKey + "$" + rStateField + " == state & " + selectedDatasetKey + "$" + rStatusField + " == 'Enrolled' ) ); stats[i, 'Enrolled'] <- enrolled; positive <- enrolled + grad; stats[i, 'positive_outcomes'] <- positive; total <- positive + withdrawn + acad_dism; stats[i, 'total_outcomes'] <- total; if( total > 0 ){ ratio <- positive / total	}else{ ratio <- 0 }; stats[i, 'outcome_ratio'] <- ratio }" );

			REvaluation sortStats = new REvaluation( "stats <- stats[order(stats$outcome_ratio, stats$total_outcomes, stats$state),]" );
			
			REvaluation findNoEnrollees = new REvaluation( "no_enrollees_indices <- which( stats$total_outcomes == 0 ); no_enrollees <- stats[no_enrollees_indices, 'state']" );
			REvaluation noEnrollees = new REvaluation( "no_enrollees" );
			if( noEnrollees.success ) {
				noEnrolleeFld.Text = "";
				string[] no_enrollees_array = noEnrollees.asStringList().ToArray();
				for( int i = 0; i < no_enrollees_array.Length; i++ ) {
					noEnrolleeFld.Text += no_enrollees_array[i];
					if( i < ( no_enrollees_array.Length - 1 ) ) noEnrolleeFld.Text += ", ";
				}
			} else {
				noEnrolleeFld.Text = "Could not load list.";
			}

			REvaluation findBest = new REvaluation( "best_start <- dim( stats )[1] - " + grab + "; best <- stats[best_start:nrow(stats),]" );
			REvaluation best = new REvaluation( "best$state" );
			if( best.success ) {
				bestFld.Text = "";
				string[] best_array = best.asStringList().ToArray();
				for( int i = 0; i < best_array.Length; i++ ) {
					bestFld.Text += best_array[i];
					if( i < ( best_array.Length - 1 ) ) bestFld.Text += ", ";
				}
			} else {
				bestFld.Text = "Could not load list.";
			}

			REvaluation findWorst = new REvaluation( "worst_start <- which( stats$total_outcomes > 0 )[1]; worst <- stats[worst_start:( worst_start + " + grab + " ),]" );
			REvaluation worst = new REvaluation( "worst$state" );
			if( worst.success ) {
				worstFld.Text = "";
				string[] worst_array = worst.asStringList().ToArray();
				for( int i = 0; i < worst_array.Length; i++ ) {
					worstFld.Text += worst_array[i];
					if( i < ( worst_array.Length - 1 ) ) worstFld.Text += ", ";
				}
			} else {
				worstFld.Text = "Could not load list.";
			}
		}
	}
}
