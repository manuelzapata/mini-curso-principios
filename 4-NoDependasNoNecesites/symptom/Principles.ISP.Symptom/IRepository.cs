using Principles.ISP.Symptom.Model;
using System.Collections.Generic;

namespace Principles.ISP.Symptom
{
    interface IRepository
    {

        //User methods

        void CreateUser(User user);

        List<User> ListUsers();

        void DeleteUser(User user);

        //Project methods

        void CreateProject(Project project);

        List<Project> ListProjectsByUser(int userId);

        //Task methods

        void CreateTask(Task task);

        List<Task> ListCompletedTasksByUser(int userId);

        void DeleteTask(Task task);

    }
}
