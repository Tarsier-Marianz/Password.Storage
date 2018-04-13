using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tarsier.Config;
using Tarsier.Extensions;
using Password.Storage.Models;
using System.Windows.Forms;
using System.Drawing;
using Tarsier.Security;

namespace Password.Storage.Controllers {
    public class Credentials {
        private SQLiteHelper sqlite;
        private SQLiteTable table;
        private string defaultTable = "passwords";

        public string CurrentTable {
            get { return defaultTable; }
            set { defaultTable = value; }
        }

        public Credentials(string filename, bool encrypted = true) {
            sqlite = new SQLiteHelper(filename);
            CreateTable(defaultTable);
        }
      
        public void CreateTable(string tableName) {
            defaultTable = tableName.RemoveNonAlphaNumeric().ToLower();
            table = new SQLiteTable(tableName);
            table.AddColumn(new SQLiteColumn("ID", true));
            table.AddColumn(new SQLiteColumn("Username", ColType.Text));
            table.AddColumn(new SQLiteColumn("PassKey", ColType.Text));
            table.AddColumn(new SQLiteColumn("Description", ColType.Text));
            table.AddColumn(new SQLiteColumn("Code", ColType.Text));
            sqlite.CreateTable(table);
        }

        public bool ClearAll() {
            try {
                if(sqlite.IsTableExist(defaultTable)) {
                    sqlite.DropTable(defaultTable);
                    return true;
                }
            } catch {
            }
            return false;

        }
        public DataTable GetDataTable(bool orderDesc) {
            if(string.IsNullOrEmpty(defaultTable)) {
                return null;
            }
            if(orderDesc) {
                return sqlite.Select(string.Format(Queries.SELECT_TABLE_DESC, defaultTable, "ID"));
            }
            return sqlite.GetDataTable(defaultTable);
        }

        public Credential GetCredential(string id) {
            if(string.IsNullOrEmpty(id)) {
                return null;
            }
            DataTable dt = sqlite.Select(string.Format(Queries.SELECT_TABLE_WHERE, defaultTable, "ID=" + id));
            Credential c = new Credential();
            if(dt != null) {
                foreach(DataRow dr in dt.Rows) {
                    try {
                        c = new Credential() {
                            ID = dr["ID"].ToSafeInteger(),
                            Username = SimpleEncryption.Decrypt(dr["Username"].ToSafeString()),
                            Description = SimpleEncryption.Decrypt(dr["Description"].ToSafeString()),
                            PassKey = SimpleEncryption.Decrypt(dr["PassKey"].ToSafeString()),
                            Code = dr["Code"].ToSafeString()
                        };
                    } catch { /*@Ignore exception*/}
                }
            }
            return c;
        }

        public List<Credential> GetCredentials() {
            DataTable dt = sqlite.Select(string.Format(Queries.SELECT_TABLE_DESC, defaultTable, "ID"));
          
            List<Credential> pwds = new List<Credential>();
            if(dt.Rows.Count > 0) {
                foreach(DataRow dr in dt.Rows) {
                    Credential cmd = new Credential() {
                        ID = dr["ID"].ToSafeInteger(),
                        Username = SimpleEncryption.Decrypt(dr["Username"].ToSafeString()),
                        Description = SimpleEncryption.Decrypt(dr["Description"].ToSafeString()),
                        PassKey = SimpleEncryption.Decrypt(dr["PassKey"].ToSafeString()),
                        Code = dr["Code"].ToSafeString()
                    };
                    pwds.Add(cmd);
                }
            }
            return pwds;
        }
        public void Add(Credential c) {
            Dictionary<string, object> data = new Dictionary<string, object>();
            string code = (c.Username + c.Description).RemoveNonAlphaNumeric().ToLower();
            data.Add("Description", SimpleEncryption.Encrypt( c.Description));
            data.Add("Username", SimpleEncryption.Encrypt(c.Username));
            data.Add("PassKey", SimpleEncryption.Encrypt(c.PassKey));
            data.Add("Code", code);
            if(sqlite.IsExist(defaultTable, "Code", code.ToStringType())) {
                sqlite.Update(defaultTable, data, "Code", code);
            } else {
                sqlite.Insert(defaultTable, data);
            }
        }
        public void Update(Credential c, string id) {
            if(!string.IsNullOrEmpty(id)) {
                Dictionary<string, object> data = new Dictionary<string, object>();
                string code = (c.Username + c.Description).RemoveNonAlphaNumeric().ToLower();
                data.Add("Description", SimpleEncryption.Encrypt(c.Description));
                data.Add("Username", SimpleEncryption.Encrypt(c.Username));
                data.Add("PassKey", SimpleEncryption.Encrypt(c.PassKey));
                data.Add("Code", code);
                sqlite.Update(defaultTable, data, "ID", id);
            }
        }

        public void DeleteCode(string code) {
            sqlite.Delete(defaultTable, string.Format("Code ='{0}'", code));
        }
        public void Delete(string id) {
            sqlite.Delete(defaultTable, string.Format("ID ={0}", id));
        }

        public void Initialize(ListView list, bool hidePassword) {
            List<Credential> pwds = GetCredentials();
            if(pwds.Count > 0) {
                foreach(Credential c in pwds) {
                    string imgKey = string.Format("notification-counter-{0}.png", c.ID.ToString("D2"));
                    ListViewItem item = new ListViewItem(c.ID.ToSafeString(), imgKey);
                    item.UseItemStyleForSubItems = false;
                    item.SubItems.Add(c.Description);
                    item.SubItems.Add(c.Username);
                    if(hidePassword) {
                        item.SubItems.Add("*********");
                        item.SubItems[3].ForeColor = Color.Red;
                    } else {
                        item.SubItems.Add(c.PassKey);
                        item.SubItems[3].ForeColor = Color.DarkBlue;
                    }
                    item.SubItems[0].ForeColor = Color.White;
                    item.SubItems[1].ForeColor = Color.DarkGreen;
                    item.SubItems[2].Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
                    if(list.InvokeRequired) {
                        list.Invoke((MethodInvoker)delegate () {
                            list.Items.Add(item);
                        });
                    } else {
                        list.Items.Add(item);
                    }
                }
            }
        }
    }
}
