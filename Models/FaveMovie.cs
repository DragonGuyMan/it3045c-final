using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class FaveMovie
    {
        public int Id { get; set; }
        public string TeamMemberName { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReleaseDate { get; set; }
    }
}
