using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Password.Storage.Models {
    public class Credential {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Username { get; set; }
        public string PassKey { get; set; }
        public string Code { get; set; }
    }
}
