//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESTM.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_DEPARTMENT
    {
        public TB_DEPARTMENT()
        {
            this.TB_USERS = new HashSet<TB_USERS>();
        }
    
        public string DEPARTMENT_ID { get; set; }
        public string DEPARTMENT_NAME { get; set; }
        public string PARENT_ID { get; set; }
        public string DEPARTMENT_LEVEL { get; set; }
        public string STATUS { get; set; }
    
        public virtual ICollection<TB_USERS> TB_USERS { get; set; }
    }
}
