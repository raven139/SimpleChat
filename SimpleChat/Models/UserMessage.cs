//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleChat.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserMessage
    {
        public int Id { get; set; }
        public int UserSenderId { get; set; }
        public Nullable<int> UserReceiverId { get; set; }
        public int MessageId { get; set; }
    
        public virtual Message Message { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}