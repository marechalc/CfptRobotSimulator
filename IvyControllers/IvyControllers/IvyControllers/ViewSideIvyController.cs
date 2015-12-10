using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvyControllers
{
    public class ViewSideIvyController : IvyController
    {
        #region Methods
        internal override void MessageReceivedCallback(object sender, IvyBus.IvyMessageEventArgs e)
        {
            base.MessageReceivedCallback(sender, e);
        }
        #endregion
    }
}
