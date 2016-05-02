using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RDotNet;
using System.IO;

namespace RAE {
	class REvaluation {
		/* Joseph Morrill
		 * Developed to make interfacing with RDotNet a little easier
		 */
		public bool success = false;
		private SymbolicExpression expression_result;
		private Exception error;
		public string type;
		public string query;

		public REvaluation( String input ) {
			query = input;
			Program.history += query + Environment.NewLine;
			if( !Program.rInitialized ) Program.initializeR();
			try {
				expression_result = Program.r.Evaluate( input );
				success = true;
				switch( expression_result.Type ) {
				case RDotNet.Internals.SymbolicExpressionType.CharacterVector:
					type = "string";
					break;
				case RDotNet.Internals.SymbolicExpressionType.NumericVector:
					if( asString().Contains( '.' ) ) {
						type = "decimal";
					} else {
						type = "integer";
					}
					break;
				default:
					type = expression_result.Type.ToString();
					break;
				}
			} catch( Exception ex ) {
				error = ex;
				success = false;
				Program.history += "ERROR: " + error.ToString() + Environment.NewLine;
			}
		}

		public SymbolicExpression asSymbolic() {
			return expression_result;
		}

		public CharacterVector asCharacterVector() {
			return expression_result.AsCharacter();
		}

		public string asString() {
			string result = "";
			try {
				CharacterVector lines = expression_result.AsCharacter();
				for( var i = 0; i < lines.Length; i++ ) {
					result += lines[i];
					if( i < ( lines.Length - 1 ) )
						result += Environment.NewLine;
				}
			} catch( Exception ex ) {

			}
			return result;
		}

		public int asInteger() {
			string result_string = asString();
			return int.Parse( result_string );
		}

		public float asFloat() {
			string result_string = asString();
			return float.Parse( result_string );
		}

		public double asDouble() {
			string result_string = asString();
			return double.Parse( result_string );
		}

		public List<string> asStringList() {
			List<string> result = new List<string>();

			CharacterVector expression_result_list = expression_result.AsCharacter();
			for( int i = 0; i < expression_result_list.Length; i++ ) {
				result.Add( expression_result_list[i].ToString() );
			}

			return result;
		}
	}
}
