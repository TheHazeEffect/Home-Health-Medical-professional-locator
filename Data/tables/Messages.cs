﻿using System;
using System.Collections.Generic;
using HomeHealth.Identity;

namespace HomeHealth.data.tables
{
    public partial class Messages
    {
        public int MessageId { get; set; }

        public string Content {get;set;}
        public string SenderId { get; set; }
        public string ReceiverId  { get; set; }

        public DateTime TimeStamp { get; set; }

        public virtual ApplicationUser Sender { get; set; }
        public virtual ApplicationUser Reciever { get; set; }
    }
}
