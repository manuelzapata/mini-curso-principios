using Principles.ISP.Symptom.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Principles.ISP.Symptom.Service
{
    class ManagerService
    {

        private IRepository dataRepository;

        public ManagerService(IRepository repository)
        {
            dataRepository = repository;
        }

        public bool CreateProject(Project project) {

            bool result = true;

            /* business rules */
            dataRepository.CreateProject(project);

            return result;

        }

        public List<Project> GetProjects(int userId) {

            /* Validations and business rules */
            var projects = dataRepository.ListProjectsByUser(userId);
            return projects;

        }

    }
}
