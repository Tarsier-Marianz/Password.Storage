using Microsoft.Win32;

namespace Tarsier.Regedit {
    public class RegistryControl {

        private string appKey = "SOFTWARE\\Marianz\\Password Storage";
        public string AppKey {
            get { return appKey; }
            set { appKey = value; }
        }

        private RegistryKey subRegKey = null;
        private RegistryKey rootRegKey = Registry.LocalMachine;

        public RegistryKey RootRegistryKey {
            get { return rootRegKey; }
            set { rootRegKey = value; }
        }

        public string Read(string KeyName) {
            if(!string.IsNullOrEmpty(KeyName)) {
                subRegKey = rootRegKey.OpenSubKey(appKey);
                if(subRegKey != null) {
                    try {
                        return (string)subRegKey.GetValue(KeyName);
                    } catch { }
                }
            }
            return string.Empty;
        }

        public bool Write(string KeyName, object Value) {
            if(!string.IsNullOrEmpty(KeyName)) {
                try {
                    subRegKey = rootRegKey.CreateSubKey(appKey);
                    subRegKey.SetValue(KeyName, Value);
                    return true;
                } catch { }
            }
            return false;
        }

        public bool Delete(string KeyName) {
            try {
                subRegKey = rootRegKey.CreateSubKey(appKey);
                if(subRegKey != null)
                    subRegKey.DeleteValue(KeyName);
                return true;
            } catch {
                return false;
            }
        }

        public bool Reset() {
            try {
                if(rootRegKey.OpenSubKey(appKey) != null)
                    rootRegKey.DeleteSubKeyTree(appKey);
                return true;
            } catch {
                return false;
            }
        }
    }
}