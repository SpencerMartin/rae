using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace RAE.Analysis_Forms {
	public partial class aprioriWnd : Form {
		private float support = 0.5f;
		private float confidence = 0.5f;

		public aprioriWnd() {
			InitializeComponent();
		}

		private void aprioriWnd_Load( object sender, EventArgs e ) {
			
		}

		private void runBtn_Click( object sender, EventArgs e ) {
			Program.loadPackage( "arules" );

			REvaluation factorizeChosen = new REvaluation( @"chosen_factors <- data.frame( sapply( chosen, as.factor ) )" );
			REvaluation generateRules = new REvaluation( @"rules <- apriori( chosen_factors,  control = list( verbose = FALSE ), parameter = list( minlen = 2, supp = " + support + ", conf = " + confidence + " ) )" );
			REvaluation rulesSummary = new REvaluation( @"rules@lhs@data@Dim[2]" );
			string rulesSummaryText = rulesSummary.asString().Trim();
			bool rulesFound = false;
			if( rulesSummaryText != "" && int.Parse( rulesSummaryText ) > 0 ){
				rulesFound = true;
			}

			if( !rulesFound ) {
				MessageBox.Show( "No rules were found! Trying all rules." );
				REvaluation generateRulesAll = new REvaluation( @"rules <- apriori( chosen_factors )" );
			}

			REvaluation roundQuality = new REvaluation( @"quality( rules ) <- round( quality( rules ), digits = 3 )" );
			REvaluation sortRules = new REvaluation( "rules.sorted <- sort( rules, by = " + '"' + "lift" + '"' + " )" );
			REvaluation createSubset = new REvaluation( "subset.matrix <- is.subset( rules.sorted, rules.sorted )" );
			REvaluation subset2 = new REvaluation( "subset.matrix[lower.tri( subset.matrix, diag = TRUE )] <- NA" );
			REvaluation createRedundantIndexes = new REvaluation( "redundant <- colSums( subset.matrix, na.rm = TRUE ) >= 1" );
			REvaluation uniqueRules = new REvaluation( "rules.pruned <- rules.sorted[!redundant]" );
			REvaluation outputFileOn = new REvaluation( "sink( " + '"' + "apriori.txt" + '"' + ", append = FALSE, split = FALSE )" );
			REvaluation getRuleText = new REvaluation( "inspect( rules.pruned )" );
			REvaluation outputFileOff = new REvaluation( "sink()" );

			output.Text = File.ReadAllText( "apriori.txt" );
			File.Delete( "apriori.txt" );
		}

		private void supportFld_SelectedIndexChanged( object sender, EventArgs e ) {
			if( supportFld.Text != "" ) {
				support = float.Parse( supportFld.Text );
			}
		}

		private void confidenceFld_SelectedIndexChanged( object sender, EventArgs e ) {
			if( confidenceFld.Text != "" ) {
				confidence = float.Parse( confidenceFld.Text );
			}
		}

		private void saveBtn_Click( object sender, EventArgs e ) {
			SaveFileDialog aprioriDialog = new SaveFileDialog();
			aprioriDialog.Filter = "Text document (*.txt)|*.txt";
			aprioriDialog.FilterIndex = 1;
			aprioriDialog.RestoreDirectory = true;

			if( aprioriDialog.ShowDialog() == DialogResult.OK ) {
				File.WriteAllText( aprioriDialog.FileName, output.Text );
			}
		}
	}
}
