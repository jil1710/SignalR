using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SignalR_POC.Models
{
    public partial class Notification
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Message { get; set; } = null!;
        public string MessageType { get; set; } = null!;
        public DateTime NotificationDateTime { get; set; }
    }
}
