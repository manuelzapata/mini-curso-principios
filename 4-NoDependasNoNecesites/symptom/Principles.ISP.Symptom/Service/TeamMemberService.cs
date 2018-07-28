using Principles.ISP.Symptom.Model;
using System.Collections.Generic;

namespace Principles.ISP.Symptom.Service
{
    class TeamMemberService
    {

        private IRepository dataRepository;

        public TeamMemberService(IRepository repository)
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
