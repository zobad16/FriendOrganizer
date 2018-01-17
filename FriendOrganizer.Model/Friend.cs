using System.ComponentModel.DataAnnotations;

namespace FriendOrganizer.Model
{
    public class Friend
    {
        public int Id { set; get; }

        [Required]
        [StringLength(50)]
        public string FirstName { set; get; }

        [StringLength(50)]
        public string LastName { set; get; }

        [StringLength(50)]
        public string Email { set;get; }
    }
}
