//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatBot
{
    using System;
    using System.Collections.Generic;
    
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            this.BotReply = new HashSet<BotReply>();
        }
    
        public int QuestionId { get; set; }
        public string UserInput { get; set; }
        public int IntentId { get; set; }
        public int ScoreId { get; set; }
        public System.DateTime DateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BotReply> BotReply { get; set; }
        public virtual Intent Intent { get; set; }
        public virtual Score Score { get; set; }
    }
}