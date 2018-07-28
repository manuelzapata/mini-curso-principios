using Principles.ISP.Refactor.Model;
using System.Collections.Generic;

namespace Principles.ISP.Refactor.Repository
{
    interface ITaskRepository
    {

        void CreateTask(Task task);

        List<Task> ListCompletedTasksByUser(int userId);

        void DeleteTask(Task task);

    }
}
