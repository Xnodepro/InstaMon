using InstaSharper.API;
using InstaSharper.API.Builder;
using InstaSharper.Classes;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Insta
{
    class ChekAcc
    {
        private static IInstaApi _instaApi;
        public int Id = 0;
        public ChekAcc(int id)
        {
            Id = id; 
        }
        public void Init()
        {
            var userSession = new UserSessionData
            {
                UserName = "ivansemenov103",
                Password = "12369854789Qq"
            };
            _instaApi = new InstaApiBuilder()
                .SetUser(userSession)
                .SetRequestDelay(TimeSpan.FromSeconds(1)) // set delay between requests
                .Build();
            var result = Task.Run(MainAsync).GetAwaiter().GetResult();
        }
        
        public  async Task<bool> MainAsync()
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
                    Program.Mess.Enqueue("Аккаунт:["+ Struc.allUsers[Id].login+"] Логирование не удачно:" + logInResult.Info.Message);
                }
                else
                {
                    Console.WriteLine("Press 1 to start basic demo samples");
                    var currentUser = await _instaApi.GetCurrentUserAsync();
                    var followers = await _instaApi.GetUserFollowersAsync(currentUser.Value.UserName, 5);
                    var following = await _instaApi.GetUserFollowingAsync(currentUser.Value.UserName, 5);
                    var media = await _instaApi.GetUserMediaAsync(currentUser.Value.UserName, 5);
                    var us = Struc.allUsers[Id];
                    us.countFolowing = followers.Value.Count;
                    us.countSubscribers = following.Value.Count;
                    us.countPublication = media.Value.Count;
                    us.stateUser = "Активный";
                    us.statusWork = "Логирование успешно!";
                    Struc.allUsers[Id] = us;
                    Program.Mess.Enqueue("Аккаунт:[" + Struc.allUsers[Id].login + "] Логирование удачно" );
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
