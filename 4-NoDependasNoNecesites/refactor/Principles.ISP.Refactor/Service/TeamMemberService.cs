using Principles.ISP.Refactor.Model;
using Principles.ISP.Refactor.Repository;
using System.Collections.Generic;

namespace Principles.ISP.Refactor.Service
{
    class TeamMemberService
    {

        private ITaskRepository dataRepository;

        public TeamMemberService(ITaskRepository repository)
        {
            dataRepository = repository;
        }

        public bool SaveTask(Task task)
        {

            bool result = true;

            /* business rules */
            dataRepository.CreateTask(task);

            return result;
        }

        public List<Task> GetCompletedTasks(int userId)
        {

            /* Validations and business rules */

            var tasks = dataRepository.ListCompletedTasksByUser(userId);
            return tasks;

        }

        public bool DeleteTask(Task task)
        {

            bool result = true;

            /* Validations and business rules */
            dataRepository.DeleteTask(task);

            return result;
        }

    }
}
