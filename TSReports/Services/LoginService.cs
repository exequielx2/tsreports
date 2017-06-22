using Newtonsoft.Json.Linq;
using System;  
namespace TSReports.Services
{
    class LoginService : RestConnection
    {
        private string basepath = "login";
        private static LoginService instance;
        private LoginService() { }
        public static LoginService Instance {
            get {
                if (instance == null) {
                    instance = new LoginService();
                }
                return instance;
            }
        }
        public JObject Login(String user,String pass)
        {
            var par = new { username = user, password = pass };
            dynamic response = this.DoPost(basepath+"/login", par);
            return JObject.Parse(response.Content);
        }
    }
}
