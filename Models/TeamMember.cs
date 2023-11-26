using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace FinalProject.Models
{
    public class TeamMember
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birthdate { get; set; }

        public string CollegeProgram { get; set; }

        public string ProgramYear { get; set; }
    }
}
