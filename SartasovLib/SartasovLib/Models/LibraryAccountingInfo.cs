﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SartasovLib.Models
{
    public class LibraryAccountingInfo
    {
        public int LibraryAccountingID { get; set; }
        public string Type { get; set; }
        public string BookInfo { get; set; }
        public string AccountInfo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime CompletionDate { get; set; }
    }
}
