//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Game
    {
        public Game()
        {
            this.Votes = new HashSet<Vote>();
            this.Votes1 = new HashSet<Vote>();
        }
    
        public int gameId { get; set; }
        public string gameTitle { get; set; }
        public int voteId { get; set; }
    
        public virtual ICollection<Vote> Votes { get; set; }
        public virtual ICollection<Vote> Votes1 { get; set; }
    }
}
