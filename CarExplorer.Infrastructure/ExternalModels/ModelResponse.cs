using System;
using System.Collections.Generic;
using System.Text;

namespace CarExplorer.Infrastructure.ExternalModels
{
    public class ModelResponse
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public List<ModelItem> Results { get; set; }
    }

    public class ModelItem
    {
        public int Make_ID { get; set; }
        public string Make_Name { get; set; }
        public int Model_ID { get; set; }
        public string Model_Name { get; set; }
    }
}
