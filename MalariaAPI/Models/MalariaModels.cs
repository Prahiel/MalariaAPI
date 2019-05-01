namespace MalariaAPI.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Malaria_Treatments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Malaria_Treatments()
        {

        }

        [Key]
        public int ID { get; set; }

        public string Treatment_Details { get; set; }

        public DateTime? Date_Created { get; set; }
    }

    public partial class Malaria_Prevention
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Malaria_Prevention()
        {

        }

        [Key]
        public int ID { get; set; }

        public string Prevention_Details { get; set; }

        public DateTime? Date_Created { get; set; }
    }

    public partial class Malaria_Facts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Malaria_Facts()
        {

        }

        [Key]
        public int ID { get; set; }
        public string Facts_Details { get; set; }
        public DateTime? Date_Created { get; set; }
    }

    public partial class Malaria_Controls
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Malaria_Controls()
        {

        }

        [Key]
        public int ID { get; set; }
        public string Control_Details { get; set; }
        public DateTime? Date_Created { get; set; }
    }

    public partial class Malaria_Areas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Malaria_Areas()
        {
            
        }

        [Key]
        public int ID { get; set; }
        public string Area_Details { get; set; }
        public DateTime? Date_Created { get; set; }
    }

    public class Malaria_Log
    {
        [Key]
        public int Id { get; set; }

        public string EntityName { get; set; }

        public string UserId { get; set; }
    }
}