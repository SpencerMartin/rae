using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDotNet;
using Microsoft.VisualBasic.FileIO;
using System.IO;

namespace RAE {
	public partial class importWnd : Form {
		public importWnd() {
			InitializeComponent();
		}

		private void importBtn_Click( object sender, EventArgs e ) {
			OpenFileDialog datasetDialog = new OpenFileDialog();
			datasetDialog.Filter = "Comma-Separated Values Document (*.csv)|*.csv";
			datasetDialog.FilterIndex = 1;
			datasetDialog.Multiselect = true;

			DialogResult datasetDialogResult = datasetDialog.ShowDialog();
			if( datasetDialogResult == System.Windows.Forms.DialogResult.OK ) {
				foreach( String file in datasetDialog.FileNames ) {
					string indicator = "Failed";
					string key = "d" + ( Program.importedFiles.Count + 1 );
					REvaluation importStatement = new REvaluation( key + " <- read.csv( '" + file.Replace( @"\", @"\\" ) + "' )" );
					indicator = "Imported";
					
					Program.importedFiles.Add( key, file );
					indicator = "Imported but could not add to list";

					List<string> fieldsOriginal = getOriginalFields( file );
					List<string> fieldsR = getRFields( key );
					
					// Get short names if they were entered in a previous session, otherwise set them to the current field names
					string descriptorFile = Path.GetFileNameWithoutExtension( file ) + "descriptors.raed";
					Dictionary<string, string> currentShort = new Dictionary<string, string>();
					if( File.Exists( descriptorFile ) ) {
						string[] lines = File.ReadAllLines( descriptorFile );
						foreach( string line in lines ) {
							string[] pair = line.Split(new string[] { "<KEY|VALUE>" }, StringSplitOptions.None);
							string pairKey = pair[0];
							string pairValue = pair[1];
							currentShort.Add( pairKey, pairValue );
						}
					}else if( fieldsOriginal != null ) {
						foreach( string field in fieldsOriginal ) {
							currentShort.Add( field, field );
						}
					}
					Program.fieldsShort.Add( key, currentShort );
					indicator = "Imported but could not get R fields";

					if( fieldsR != null ) {
						string[] fieldsOriginalArray = fieldsOriginal.ToArray();
						string[] fieldsRArray = fieldsR.ToArray();

						if( fieldsOriginalArray.Length == fieldsRArray.Length ) {
							Dictionary<string, string> currentR = new Dictionary<string, string>();
							for( int i = 0; i < fieldsOriginalArray.Length; i++ ) {
								currentR.Add( fieldsOriginalArray[i], fieldsRArray[i] );
							}
							Program.fieldsR.Add( key, currentR );
							if( currentR != null ) {
								indicator = "Success";
								nextBtn.Enabled = true;
							} else {
								indicator = "Imported but could not get R fields";
							}
						}
					}

					importedLst.Items.Add( indicator + " - " + file );
				}
			}
		}

		private void nextBtn_Click( object sender, EventArgs e ) {
			describeWnd nextWindow = new describeWnd();
			nextWindow.Show();
			this.Close();
		}

		private List<string> getOriginalFields( string file ) {
			List<string> result = null;

			try {
				using( TextFieldParser parser = new TextFieldParser( file ) ) {
					parser.TextFieldType = FieldType.Delimited;
					parser.SetDelimiters( "," );
					string[] fields = parser.ReadFields();

					if( fields.Length > 0 ){
						result = new List<string>();
						foreach( string field in fields ) {
							result.Add( field );
						}
					}
				}
			} catch( Exception ex ) {
				MessageBox.Show( "Could not read column headers from this dataset file: " + file );
			}

			return result;
		}

		private List<string> getRFields( string dataset ) {
			List<string> result = null;

			try {
				REvaluation getFields = new REvaluation( "names( " + dataset + " )" );
				result = getFields.asStringList();
			} catch( Exception ex ) {
				MessageBox.Show( "Could not read column headers from this R dataset: " + dataset );
			}

			return result;
		}

		private void cancelBtb_Click( object sender, EventArgs e ) {
			this.Close();
		}

		private void importWnd_Load( object sender, EventArgs e ) {
			foreach( KeyValuePair<string, string> dataset in Program.importedFiles ) {
				importedLst.Items.Add( "Success - " + dataset.Value );
			}

			if( importedLst.Items.Count > 0 ) {
				nextBtn.Enabled = true;
			}
		}
	}
}
