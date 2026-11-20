using System.ComponentModel.DataAnnotations.Schema;

namespace Academy2.Models
{
    public class DependentDiscipline
    {
        public int discipline { get; set; }
        public int dependent_discipline { get; set; }

        public Discipline? Discipline { get; set; }
        public Discipline? DependentDisciplineNavigation { get; set; }
    }

    public class RequiredDiscipline
    {
        public int discipline { get; set; }
        public int required_discipline { get; set; }

        public Discipline? Discipline { get; set; }
        public Discipline? RequiredDisciplineNavigation { get; set; }
    }
}