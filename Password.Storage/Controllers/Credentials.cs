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

namespace Password.Storage.Controllers {
    public class Credentials {
        private SQLiteHelper sqlite;
        private SQLiteTable table;
        private string defaultTable = "passwords";

        public string CurrentTable {
            get { return defaultTable; }
            set { defaultTable = value; }
        }

        public Credentials(string filename) {
            sqlite = new SQLiteHelper(filename);
            CreateTable(defaultTable);
        }
      
        public void CreateTable(string tableName) {
            defaultTable = tableName.RemoveNonAlphaNumeric().ToLower();
            table = new SQLiteTable(tableName);
            table.AddColumn(new SQLiteColumn("ID", true));
            table.AddColumn(new SQLiteColumn("PassKey", ColType.Text));
            table.AddColumn(new SQLiteColumn("Description", ColType.Text));
            table.AddColumn(new SQLiteColumn("Code", ColType.Text));
            sqlite.CreateTable(table);
        }

        public bool ClearCommands() {
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

        public List<Credential> GetPasswords() {
            DataTable dt = sqlite.Select(string.Format(Queries.SELECT_TABLE_DESC, defaultTable, "ID"));
          
            List<Credential> pwds = new List<Credential>();
            if(dt.Rows.Count > 0) {
                foreach(DataRow dr in dt.Rows) {
                    Credential cmd = new Credential() {
                        ID = dr["ID"].ToSafeInteger(),
                        Description = dr["Description"].ToSafeString(),
                        PassKey = dr["PassKey"].ToSafeString(),
                        Code = dr["Code"].ToSafeString()
                    };
                    pwds.Add(cmd);
                }
            }
            return pwds;
        }
        public void Add(Credential pwd) {
            Dictionary<string, object> data = new Dictionary<string, object>();
            string code = pwd.Description.RemoveNonAlphaNumeric().ToLower();
            data.Add("Description", pwd.Description);
            data.Add("PassKey",  pwd.PassKey);
            data.Add("Code", code);
            if(sqlite.IsExist(defaultTable, "Code", code.ToStringType())) {
                sqlite.Update(defaultTable, data, "Code", code);
            } else {
                sqlite.Insert(defaultTable, data);
            }
        }

        public void Delete(string code) {
            sqlite.Delete(defaultTable, string.Format("Code ='{0}'", code));
        }
        public void Initialize(ListView list) {
           
            List<Credential> pwds = GetPasswords();
            if(pwds.Count > 0) {
                foreach(Credential pwd in pwds) {
                    int img = 1;
                    ListViewItem item = new ListViewItem(pwd.ID.ToSafeString(), img);
                    item.UseItemStyleForSubItems = false;
                    item.SubItems.Add(pwd.Description);
                    item.SubItems.Add(pwd.PassKey);
                    item.SubItems[1].ForeColor = Color.DarkGreen;
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
