using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InlandMarinaGUI.Controls
{
    public class SlipEventArgs: EventArgs
    {
        // properties from Slip, but all string type for convenience
        public string ID { get; set; }
        public string DockID { get; set; }
        public string Width { get; set; }
        public string Length { get; set; }
    }
}