
namespace zagana_api.Models
{
    public class Users
    {
        [Key]
        public Guid User_id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50)]
        public string First_name { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50)]
        public string Last_name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Birthday is required")]
        [StringLength(50)]
        public DateOnly Birthday { get; set; }

        [Required(ErrorMessage = "Date created is required")]
        [DataType(DataType.Date)]
        public DateTime Date_created { get; set; }

        // Constructor to initialize properties
        public Users()
        {
            User_id = Guid.NewGuid(); // Generate a new GUID as the User_id
            First_name = string.Empty;
            Last_name = string.Empty;
            Email = string.Empty;
            Birthday = DateOnly.FromDateTime(DateTime.Now);
            Date_created = DateTime.Now; // Set Date_created to current date
        }
    }
}