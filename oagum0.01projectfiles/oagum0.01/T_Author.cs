//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace oagum0._01
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Author
    {
        public T_Author()
        {
            this.T_ArticleAuthor = new HashSet<T_ArticleAuthor>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public string CreatedBy { get; set; }
    
        public virtual ICollection<T_ArticleAuthor> T_ArticleAuthor { get; set; }
    }
}
