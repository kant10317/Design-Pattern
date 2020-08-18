using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class SystemMessage : AbstractMessage
    {
        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body);
        }
    }
}
