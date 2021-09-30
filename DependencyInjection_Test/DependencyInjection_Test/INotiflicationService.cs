using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection_Test
{
    interface INotiflicationService
    {
        void NotifyUsernameChanged(User user);
    }
}
