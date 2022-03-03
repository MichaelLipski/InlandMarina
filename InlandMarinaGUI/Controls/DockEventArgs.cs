using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InlandMarinaGUI.Controls
{
    public class DockEventArgs: EventArgs
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string WaterService { get; set; }
        public string ElectricalService { get; set; }
    }
}