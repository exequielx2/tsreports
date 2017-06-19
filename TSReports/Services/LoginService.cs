using System;  
namespace TSReports.Services
{
    class LoginService
    {
        public RestSharp.IRestResponse Login(String user,String pass)
        {
            var par = new { username = user, password = pass};
            return RestConnection.Instance.Post("login/login", par);
        }
    }
}
