//
//  Copyright Info
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shell.Infrastructure.IdStore
{
    public interface IIdStore
    {
        void SetClientAccess(string token);
        void RemoveClientAccess();
        string GetUserId();
    }
}
