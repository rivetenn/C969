﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;

namespace C969
{
    public class AppTools
    {
        public int? appID { get; set; }
        public int custid { get; set; }
        public int userid { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string cont { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }

        public AppTools(int custid, int userid, string name, string title, string description, string location, string cont, string type,  DateTime start, DateTime end,string url, int appID = 0)
        {
            this.appID = appID;
            this.custid = custid;
            this.userid = userid;
            this.name = name;
            this.title = Isempty(title);
            this.description = Isempty(description);
            this.location = Isempty(location);
            this.cont = Isempty(cont);
            this.type = Isempty(type);
            this.url = Isempty(url);
            this.start = start;
            this.end = end;
        }

        public string Isempty(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? "N/A" : value.Trim();
        }

    }
}
