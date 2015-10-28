using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using ServiceStack.Auth;

namespace SelfHost
{

    public class CustomAuthentication : CredentialsAuthProvider
    {


        public override bool TryAuthenticate(IServiceBase authService, string userName, string password)
        {
            //Add here your custom auth logic (database calls etc)
            //Return true if credentials are valid, otherwise false

            bool validated = false;

            if ((userName == "Admin") & (password == "Admin"))
            {
                validated = true;
            }

            return validated;
        }

        public override ServiceStack.Web.IHttpResult OnAuthenticated(IServiceBase authService, IAuthSession session,
            IAuthTokens tokens, Dictionary<string, string> authInfo)
        {
            //Fill IAuthSession with data you want to retrieve in the app eg:

            session.FirstName = "FirstName";
            session.LastName = "LastName";
            session.DisplayName = "Display Name";
            session.Email = "noway@jose.nl";
            session.IsAuthenticated = true;
            session.UserName = "Username";
            session.UserAuthId = "001";
            //...

            //Important: You need to save the session!
            authService.SaveSession(session, SessionExpiry);
            return default(ServiceStack.Web.IHttpResult);
        }

    }

}
