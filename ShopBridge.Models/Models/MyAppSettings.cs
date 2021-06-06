using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBridge.Models.Models
{
    public class MyAppSettings
    {
        public const string SectionName = "ConnectionString";
        public string ShopBridgeDb { get; set; }
    }
}
