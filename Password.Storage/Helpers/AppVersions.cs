using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Password.Storage.Helpers {
   public class AppVersions {
        private string _filename = string.Empty;
        public string Filename {
            get {
                return _filename;
            }
            set { _filename = value; }
        }
        public AppVersions() {

        }
        public void WriteVersion(string filename, string version) {
            _filename = filename;
            if(string.IsNullOrEmpty(_filename)) {
                throw new ArgumentNullException("filename");
            }

            if(File.Exists(_filename)) {
                new FileInfo(_filename).Delete();
            }
            File.WriteAllText(_filename, version);
        }
    }
}
