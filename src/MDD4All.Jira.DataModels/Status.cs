/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDD4All.Jira.DataModels
{
    public class Status
    {
        public string self { get; set; }
        public string description { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }

        [JsonProperty("untranslatedName")]
        public string UntranslatedName { get; set; }

        public string id { get; set; }
        public StatusCategory statusCategory { get; set; }
    }
}
