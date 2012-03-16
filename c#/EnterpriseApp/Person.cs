using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BusinessObjs
{
    public abstract class Person
    {
        public virtual string firstName { get; set; }
        public virtual string lastName { get; set; }
        public virtual int phoneNum { get; set; }
        public virtual string address { get; set; }
        public virtual string postalCode { get; set; }
        public virtual string city { get; set; }
        public virtual int status { get; set; }
        public virtual int idPerson { get; set; }
        
    }
}
