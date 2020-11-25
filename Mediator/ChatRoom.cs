
using System;

public class ChatRoom {
    public static void showMessage(User user, String message){
        Console.WriteLine(DateTime.Now + " [" + user.getName() + "] : " + message);
    }
}