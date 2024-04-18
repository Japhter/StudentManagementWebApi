using StudentManagementWebApi.Domain;

namespace StudentManagementWebApi.Dto
{
    public class StudentDto
    {
        public  int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  string FirstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  string LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  string EmailAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  string IdNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  string ContactNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  string MethodOfContact { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public AddressDto Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  byte[] ProfileImage { get; set; }
    }
}
