﻿using DevFreela.Application.inputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
	public class ProjectService : IProjectService
	{
		public int Create(NewProjectInputModel inputModel)
		{
			throw new NotImplementedException();
		}

		public void CreateComment(CreateCommentInputModel inputModel)
		{
			throw new NotImplementedException();
		}

		public void Detele(int id)
		{
			throw new NotImplementedException();
		}

		public void Finish(int id)
		{
			throw new NotImplementedException();
		}

		public List<ProjectViewModel> GetAll(string query)
		{
			throw new NotImplementedException();
		}

		public List<ProjectDetailsViewModel> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void Start(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(UpdateProjectInputModel inputModel)
		{
			throw new NotImplementedException();
		}
	}
}