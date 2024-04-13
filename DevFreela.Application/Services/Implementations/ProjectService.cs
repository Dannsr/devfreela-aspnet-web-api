﻿using DevFreela.Application.inputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Infraestructure.Persistence;
using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
	public class ProjectService : IProjectService
	{
		private readonly DevFreelaDbContext _dbContext;

		public ProjectService(DevFreelaDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public int Create(NewProjectInputModel inputModel)
		{
			var project = new Project(inputModel.Title, inputModel.Description, inputModel.IdClient, inputModel.IdFreelancer, inputModel.TotalCost);
			_dbContext.Projects.Add(project);
			return project.Id;
		}

		public void CreateComment(CreateCommentInputModel inputModel)
		{
			var comment = new ProjectComment(inputModel.Content, inputModel.IdProject, inputModel.IdUser);
			_dbContext.ProjectComments.Add(comment);
		}

		public void Detele(int id)
		{
			var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
			project.Cancel();
		}

		public void Finish(int id)
		{
			throw new NotImplementedException();
		}

		public List<ProjectViewModel> GetAll(string query)
		{
			var projects = _dbContext.Projects;
			var projectsViewModel = projects.Select(p => new ProjectViewModel(p.Title, p.CreatedAt)).ToList();
			return projectsViewModel;
		}

		public ProjectDetailsViewModel GetById(int id)
		{
			var projects = _dbContext.Projects.SingleOrDefault(p => p.Id == id);

			var projectDetailsViewModel = new ProjectDetailsViewModel(projects.Id, projects.Title, projects.Description, projects.TotalCost, projects.StartedAt, projects.FinishedAt);

			return projectDetailsViewModel;
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
