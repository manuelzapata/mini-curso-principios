using Principles.ISP.Refactor.Model;
using Principles.ISP.Refactor.Repository;
using System.Collections.Generic;

namespace Principles.ISP.Refactor.Service
{
    class ManagerService
    {

        private IProjectRepository dataRepository;

        public ManagerService(IProjectRepository repository)
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
