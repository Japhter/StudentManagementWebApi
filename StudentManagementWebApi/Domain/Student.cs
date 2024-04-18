using System.ComponentModel.DataAnnotations;

namespace StudentManagementWebApi.Domain
{
    public class Student
    {
        public virtual int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string FirstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string EmailAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string IdNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string ContactNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string MethodOfContact { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual  Address Address  { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual byte[] ProfileImage { get; set; }
    }
    public class Address
    {
        [Key]
       public virtual   int Id { get; set; }
       public virtual   string StreetName { get; set; }
       public virtual   string Province { get; set; }
       public virtual   string PostalCode { get; set; }
    }
}
