using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cotraser.Isoa.Domain;

namespace Cotraser.Isoa.Common.Security
{
    public class SecurityContext
    {
        #region [Properties]

            User _user;
            public User User
            {
                get { return _user; }
            }

            Dictionary<string, string> _userRoles;
            public Dictionary<string, string> UserRoles
            {
                get { return _userRoles; }
            }

            Dictionary<string, string> _userAreas;
            public Dictionary<string, string> userAreas
            {
                get { return _userAreas; }
            }

        #endregion

        #region [.ctors]

            public SecurityContext(User user
                , Dictionary<string, string> userRoles
                , Dictionary<string, string> userAreas)
            {
                _user = user;
                _userRoles = userRoles;
                _userAreas = userAreas;
            }

        #endregion
    }
}
