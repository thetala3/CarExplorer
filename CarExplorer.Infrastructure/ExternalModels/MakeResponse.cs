using System;
using System.Collections.Generic;
using System.Text;

namespace CarExplorer.Infrastructure.ExternalModels
{
    public class MakeResponse
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public List<MakeItem> Results { get; set; }
    }

    public class MakeItem { 
        public int Make_ID { get; set; }
        public string Make_Name { get; set; }
    }
}
