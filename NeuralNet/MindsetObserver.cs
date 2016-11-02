using System;
using ThinkGearNET;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrainMonitor;

namespace BrainMonitor
{
    public interface MindsetObserver
    {
        void thinkgearChanged(ThinkGearChangedEventArgs e);
    }
}
