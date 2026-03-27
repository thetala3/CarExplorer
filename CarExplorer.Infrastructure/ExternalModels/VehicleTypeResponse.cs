using System;
using System.Collections.Generic;
using System.Text;

namespace CarExplorer.Infrastructure.ExternalModels
{
    public class VehicleTypeResponse
    {
        public int count { get; set; }
        public string Message { get; set; }
        public List<VehicleTypeItem> Results { get; set; }
    }

    public class VehicleTypeItem
    {
        public int VehicleTypeID { get; set; }
        public string VehicleTypeName { get; set; }
    }
}
