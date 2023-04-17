using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsDemo
{
    public enum SkillLevel
    {
        Anfänger = 1,
        Amateur,
        Fortgeschritten,
    }

    public class Skill
    {
        public int Skill_Id { get; set; }
        public string Skill_name { get; set; }
        public SkillLevel Skill_level { get; set; }
        public int Employee_id { get; set; }

        public Skill(int skill_Id, string skill_name, SkillLevel skill_level, int employee_id)
        {
            Skill_Id = skill_Id;
            Skill_name = skill_name;
            Skill_level = skill_level;
            Employee_id = employee_id;            
        }
    }

    public class Employee
    {
        public int Employee_id { get; set; }
        public string Employee_name { get; set; }

        public List<Skill> Skills = new List<Skill>();
    }
}
