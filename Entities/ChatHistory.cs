using System;
using System.Collections.Generic;
using HomeHealth.data.tables;

namespace HomeHealth.Entities
{
    public class ChatHistory
    {
        public ChatHistory(){
            Conversation = new HashSet<Messages>();
        }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<Messages> Conversation;

    }
}