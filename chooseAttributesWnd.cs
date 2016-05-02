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
	public partial class chooseAttributesWnd : Form {
		private string selectedDatasetKey;

		public chooseAttributesWnd() {
			InitializeComponent();
		}

		private void saveCheckedFields() {
			// Set chosen dataset
			Program.datasetChosen = selectedDatasetKey;

			// Save chosen fields and build chosen dataset
			int columns = fieldsLst.CheckedItems.Count;
			REvaluation createChosenDataset = new REvaluation( @"chosen <- data.frame( matrix( ncol = " + columns + ", nrow = nrow( " + selectedDatasetKey + " ) ) )" );

			// Name the columns
			List<string> chosen_column_r_names_list = new List<string>();
			for( int i = 0; i < columns; i++ ) {
				// Get short name
				string fieldShort = fieldsLst.CheckedItems[i].ToString();

				// Find R name
				string fieldOriginal = "", fieldR = "";
				foreach( KeyValuePair<string, string> fields in Program.fieldsShort[selectedDatasetKey] ) {
					// key = original, value = short
					if( fields.Value == fieldShort ) {
						fieldOriginal = fields.Key;
						break;
					}
				}
				foreach( KeyValuePair<string, string> fields in Program.fieldsR[selectedDatasetKey] ) {
					// key = original, value = R
					if( fields.Key == fieldOriginal ) {
						fieldR = fields.Value;
						break;
					}
				}

				// Add to chosen column names
				chosen_column_r_names_list.Add( fieldR );
			}
			string[] chosen_column_r_names_array = chosen_column_r_names_list.ToArray();
			string name_columns_string = "";
			for( int i = 0; i < columns; i++ ) {
				name_columns_string += '"' + chosen_column_r_names_array[i] + '"';
				if( i < ( columns - 1 ) )
					name_columns_string += ", ";
			}
			REvaluation nameChosenDatasetColumns = new REvaluation( @"names( chosen ) <- c( " + name_columns_string + " )" );

			// Copy each column's data to chosen dataset
			for( int i = 0; i < columns; i++ ) {
				REvaluation copyColumn = new REvaluation( @"chosen$" + chosen_column_r_names_array[i] + " = " + selectedDatasetKey + "$" + chosen_column_r_names_array[i] );
			}
			Program.fieldsChosen = chosen_column_r_names_array;
		}

		private void finishBtn_Click( object sender, EventArgs e ) {
			saveCheckedFields();

			// Close form
			this.Close();
		}

		private void chooseAttributesWnd_Load( object sender, EventArgs e ) {
			// Populate dataset list
			foreach( string datasetFile in Program.importedFiles.Values ) {
				datasetSlct.Items.Add( datasetFile );
			}

			if( Program.datasetChosen != "" ) {
				string datasetFile = Program.importedFiles[Program.datasetChosen];
				for( int datasetToCheck = 0; datasetToCheck < datasetSlct.Items.Count; datasetToCheck++ ) {
					// If item is chosen dataset, select it
					if( datasetSlct.Items[datasetToCheck] == datasetFile ) {
						datasetSlct.SelectedIndex = datasetToCheck;
						break;
					}
				}

				// Choose all fields that were chosen
				for( int chosenItem = 0; chosenItem < Program.fieldsChosen.Length; chosenItem++ ) {
					for( int itemToCompare = 0; itemToCompare < fieldsLst.Items.Count; itemToCompare++ ) {
						// If current list box field is chosenField, check it
						if( fieldsLst.Items[itemToCompare].ToString() == Program.fieldsChosen[chosenItem].ToString() ) {
							fieldsLst.SetItemChecked( itemToCompare, true );
						}
					}
				}
			}
		}

		private void datasetSlct_SelectedIndexChanged( object sender, EventArgs e ) {
			// Enable list
			fieldsLst.Enabled = true;

			// Load attributes
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
				fieldsLst.Items.Clear();

				foreach( KeyValuePair<string, string> fields in Program.fieldsShort[datasetKey] ) {
					// key = original, value = short
					fieldsLst.Items.Add( fields.Value );
				}
			}
		}

		private void saveBtn_Click( object sender, EventArgs e ) {
			saveCheckedFields();

			SaveFileDialog datasetDialog = new SaveFileDialog();
			datasetDialog.Filter = "Comma-Separated Values file (*.csv)|*.csv";
			datasetDialog.FilterIndex = 1;
			datasetDialog.RestoreDirectory = true;

			if( datasetDialog.ShowDialog() == DialogResult.OK ) {
				REvaluation saveDataset = new REvaluation( @"write.csv( chosen, file = " + '"' + "chosen.csv" + '"' + ", row.names = FALSE )" );

				bool success = true;
				try {
					File.Copy( "chosen.csv", datasetDialog.FileName, false );
					File.Delete( "chosen.csv" );
				} catch( Exception ex ) {
					success = false;
				}

				if( success ) {
					MessageBox.Show( "Saved dataset of chosen fields to " + datasetDialog.FileName );
				}
			}
		}

		private void fieldsLst_ItemCheck( object sender, ItemCheckEventArgs e ) {
			if( fieldsLst.CheckedItems.Count > 0 ) {
				finishBtn.Enabled = true;
				saveBtn.Enabled = true;
			}
		}
	}
}
