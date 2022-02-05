using System;
using System.Collections.Generic;

namespace v2rayN.Mode
{
    [Serializable]
    public class RulesItem
    {
        public string type { get; set; }
      
        public List<string> inboundTag { get; set; }
 
        public string outboundTag { get; set; }
         
       public bool enabled { get; set; } = true;

    }

}
