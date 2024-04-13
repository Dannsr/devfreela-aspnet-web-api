using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infraestructure.Persistence
{
	public class DevFreelaDbContext
	{
		public DevFreelaDbContext()
		{
			Projects = new List<Project>
			{
				new Project("Meu projeto APSNET Core 1", "Minha Descricao de Projeto 1", 1, 1, 10000),
				new Project("Meu projeto APSNET Core 2", "Minha Descricao de Projeto 1", 1, 1, 20000),
				new Project("Meu projeto APSNET Core 3", "Minha Descricao de Projeto 1", 1, 1, 30000),
			};
			Users = new List<User>
			{
				new User("Daniel Silva", "danieconomics@hotmail.com", new DateTime(04 / 10 / 2004)),
				new User("Martins", "martins@hotmail.com", new DateTime(01 / 12 / 2001)),
				new User("Aderson Silva", "anderson@hotmail.com", new DateTime(09 / 01 / 1970)),
			};
			Skills = new List<Skill>
			{
				new Skill(".Net Core"),
				new Skill("C#"),
				new Skill("SQL"),
			};
		}
		public List<Project> Projects { get; set; }
		public List<User> Users { get; set; }
		public List<Skill> Skills { get; set; }

		public List<ProjectComment> ProjectComments { get; set; }
	}
}
