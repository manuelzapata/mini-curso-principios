using Principles.ISP.Refactor.Model;
using Principles.ISP.Refactor.Repository;
using System.Collections.Generic;

namespace Principles.ISP.Refactor.Service
{
    class AdminService
    {

        private IUserRepository dataRepository;

        public AdminService(IUserRepository repository) {
            dataRepository = repository;
        }

        public bool SaveUser(User user) {

            bool result = true;

            /* business rules */
            dataRepository.CreateUser(user);

            return result;
        }

        public List<User> GetUsers() {

            /* Validations and business rules */
            var users = dataRepository.ListUsers();
            return users;

        }

        public bool DeleteUser(User user) {

            bool result = true;

            /* Validations and business rules */
            dataRepository.DeleteUser(user);

            return result;
        }

    }
}
