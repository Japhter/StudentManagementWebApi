namespace StudentManagementWebApi.Domain
{
    public class Enrolment
    {
        public virtual int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string Institution { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string QualificationType  { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string DateRegistered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string GraduationDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string AverageToDate { get; set; }
    }
}
