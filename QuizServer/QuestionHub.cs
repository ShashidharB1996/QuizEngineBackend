using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using QuizServer.Models;

namespace QuizServer
{
    public class QuestionHub : Hub
    {
      //public  Dictionary<int, Dictionary<string, List<string>>> dict = new Dictionary<int, Dictionary<string, List<string>>>();
        public static int count = 0;
        List<Question> Questions = new List<Question>()
        {new Question()
        {
            Quesid = 1,
            QuestionText = "Who is the CM of WestBengal?",
            Options = new List<Option>
                {
                    new Option{
                        Opid = 1,
                        OptionText ="Siddu"},
                    
                    new Option{
                        Opid = 2,
                        OptionText ="Didi"},
                    
                    new Option{
                        Opid = 3,
                        OptionText ="Modi"},
                    
                    new Option{
                        Opid = 4,
                        OptionText ="RaGa"}
                }
        },
        new Question()
        {
            Quesid = 2,
            QuestionText = "Who is the CM of Karnataka?",
            Options = new List<Option>
                {
                    new Option{
                        Opid = 1,
                        OptionText ="Siddu"},

                    new Option{
                        Opid = 2,
                        OptionText ="Didi"},

                    new Option{
                        Opid = 3,
                        OptionText ="Modi"},

                    new Option{
                        Opid = 4,
                        OptionText ="RaGa"}
                }
        }
        };


        public Task Send(string question)
        {
            //Console.WriteLine("DATSTSADFSTWSWSDWDDT", question);
            Console.WriteLine("post" + question);
            return Clients.All.SendAsync("send", question);
        }

/*         public Task Recieve()
        {
            return Clients.All.SendAsync("send", "this is from the server");
        } */

/*         public override Task OnConnectedAsync()
        {
            Console.WriteLine("Client Connected");
            Clients.Caller.SendAsync("Hello", "String to be sent");
            return base.OnConnectedAsync();
        } */

           public override Task OnConnectedAsync()
        {
/*             foreach (KeyValuePair<string, List<string>> item in dict)
            {
            Console.WriteLine("Client Connected");
            return Clients.Caller.SendAsync("Hello","from the server" );
            Console.WriteLine("Key: {0}, Value: {1}",
            item.Key, item.Value);
             } */
            Console.WriteLine("Client Connected");
            count++;
            var question = Questions[count];
            
            return Clients.Caller.SendAsync("Hello", Questions);
            //return base.OnConnectedAsync();
        }
        
    }
}
