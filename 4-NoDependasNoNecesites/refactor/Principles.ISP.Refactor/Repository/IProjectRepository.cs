using Principles.ISP.Refactor.Model;
using System.Collections.Generic;

namespace Principles.ISP.Refactor.Repository
{
    interface IProjectRepository
    {

        void CreateProject(Project project);

        List<Project> ListProjectsByUser(int userId);

    }
}
