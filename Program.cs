using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDotNet;
using Microsoft.Win32;
using System.IO;
using System.Drawing;

namespace RAE {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>

		public static REngine r;
		public static bool rInitialized = false;
		public static string history = "";
		public static Dictionary<string, string> importedFiles = new Dictionary<string, string>();
		public static Dictionary<string, Dictionary<string, string>> fieldsShort = new Dictionary<string, Dictionary<string, string>>();
		public static Dictionary<string, Dictionary<string, string>> fieldsR = new Dictionary<string, Dictionary<string, string>>();
		public static string[] fieldsChosen;
		public static string datasetChosen = "";

		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new menuWnd() );
		}

		public static void initializeR() {
			var envPath = Environment.GetEnvironmentVariable( "PATH" );
			bool found = false;
			string rPathHome, rPathBin, rVersion;
			string rPathBinSuffix = ( Environment.Is64BitProcess ) ? @"\bin\x64" : @"\bin\i386";

			// Registry search from http://stackoverflow.com/questions/20142528/r-engine-is-not-initializing
			using( RegistryKey registryKey = Registry.LocalMachine.OpenSubKey( @"SOFTWARE\R-core\R" ) ) {
				rPathHome = (string)registryKey.GetValue( "InstallPath" );
				rVersion = (string)registryKey.GetValue( "Current Version" );
				found = ( !( String.IsNullOrEmpty( rPathHome ) || String.IsNullOrEmpty( rVersion ) ) );
			}

			if( !found ) {
				// Not found in registry, so find by crawling
				string[] possiblePaths = {
						@"C:\Program Files\R",
						@"C:\Program Files (x86)\R",
						@"C:\R"
					};
				for( int i = 0; i < possiblePaths.Length; i++ ) {
					if( Directory.Exists( possiblePaths[i] ) ) {
						string[] versionPaths = Directory.GetDirectories( possiblePaths[i] );
						foreach( string versionPath in versionPaths ) {
							if( File.Exists( versionPath + rPathBinSuffix + @"\R.dll" ) ) {
								rPathHome = versionPath;
								found = true;
								break;
							}
						}
						if( found )
							break;
					}
				}
			}
			rPathBin = rPathHome + rPathBinSuffix;
			Environment.SetEnvironmentVariable( "PATH", envPath + Path.PathSeparator + rPathHome + rPathBinSuffix );

			try {
				REngine.CreateInstance( "R_Main" );
				r = REngine.GetInstanceFromID( "R_Main" );
				r.Initialize();
				rInitialized = true;
			} catch( Exception ex ) {
				MessageBox.Show( ex.ToString() );
			}
		}

		// Loada a package, installing it if it is not already
		public static bool loadPackage( string package ) {
			bool result = false;

			REvaluation tryLoad = new REvaluation( "library( '" + package + "' )" );
			if( tryLoad.success ) {
				result = true;
			}else{
				REvaluation tryInstall = new REvaluation( "install.packages( '" + package + "', repos = 'http://cran.us.r-project.org', quiet = TRUE )" );
				if( tryInstall.success ) {
					REvaluation retryLoad = new REvaluation( "library( '" + package + "' )" );
					result = retryLoad.success;
				}
			}

			return result;
		}

		// From: https://code.msdn.microsoft.com/windowsdesktop/Converting-Base64-strings-8808c305
		public static Bitmap base64StringToBitmap( this string base64String ) {
			Bitmap bmpReturn = null;

			byte[] byteBuffer = Convert.FromBase64String( base64String );
			MemoryStream memoryStream = new MemoryStream( byteBuffer );

			memoryStream.Position = 0;

			bmpReturn = (Bitmap)Bitmap.FromStream( memoryStream );

			memoryStream.Close();
			memoryStream = null;
			byteBuffer = null;

			return bmpReturn;
		}

		// From: http://stackoverflow.com/questions/21325661/convert-image-path-to-base64-string
		public static string imageToBase64( string file )
		{
			string result = "";
			using( Image image = Image.FromFile( file ) ) {
				using( MemoryStream m = new MemoryStream() ) {
					image.Save( m, image.RawFormat );
					byte[] imageBytes = m.ToArray();

					// Convert byte[] to Base64 String
					result = Convert.ToBase64String( imageBytes );
				}
				image.Dispose();
			}
			return result;
		}
	}
}
