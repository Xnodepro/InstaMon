using InstaSharper.API;
using InstaSharper.API.Builder;
using InstaSharper.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insta
{
    class Work
    {
        private static IInstaApi _instaApi;
        public int Id = 0;
        public Work(int id)
        {
            Id = id;

        }
        public void Init()
        {
            var userSession = new UserSessionData
            {
                UserName = Struc.allUsers[Id].login,
                Password = Struc.allUsers[Id].pass
            };
            _instaApi = new InstaApiBuilder()
                .SetUser(userSession)
                .SetRequestDelay(TimeSpan.FromSeconds(1)) // set delay between requests
                .Build();
            var result = Task.Run(MainAsync).GetAwaiter().GetResult();
        }

        public async Task<bool> MainAsync()
        {
            try
            {
                Console.WriteLine("Starting demo of InstaSharper project");
                var logInResult = await _instaApi.LoginAsync();
                if (!logInResult.Succeeded)
                {
                    var us = Struc.allUsers[Id];
                    us.stateUser = "Приостановлен";
                    us.statusWork = logInResult.Info.Message;
                    Struc.allUsers[Id] = us;
                    Program.Mess.Enqueue("{FOLLOWING} Аккаунт:[" + Struc.allUsers[Id].login + "] Логирование не удачно:" + logInResult.Info.Message);
                }
                else
                {
                    Console.WriteLine("Press 1 to start basic demo samples");
                    var us = Struc.allUsers[Id];
                    us.stateUser = "Активный";
                    us.statusWork = "Работаю";
                    Struc.allUsers[Id] = us;
                    Program.Mess.Enqueue("{FOLLOWING} Аккаунт:[" + Struc.allUsers[Id].login + "] Логирование удачно");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                //var logoutResult = Task.Run(() => _instaApi.LogoutAsync()).GetAwaiter().GetResult();
                //if (logoutResult.Succeeded) Console.WriteLine("Logout succeed");
            }
            return false;
        }
    }
}
