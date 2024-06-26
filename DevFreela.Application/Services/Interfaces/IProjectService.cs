﻿using DevFreela.Application.inputModels;
using DevFreela.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Interfaces
{
	public interface IProjectService
	{
		List<ProjectViewModel> GetAll(string query);
		ProjectDetailsViewModel GetById(int id);
		int Create(NewProjectInputModel inputModel);

		void Update(UpdateProjectInputModel inputModel);
		void Detele(int id);
		void CreateComment(CreateCommentInputModel inputModel);
		void Start(int id);
		void Finish(int id);
	}
}
