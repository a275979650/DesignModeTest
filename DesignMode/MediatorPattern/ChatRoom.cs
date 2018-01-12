using System;

namespace DesignMode.MediatorPattern
{
    public class ChatRoom
    {
        public static string showMessage(User user, string message)
        {
            return  System.DateTime.Now.ToString()
                               + " [" + user.Name + "] : " + message;
        }
    }
}