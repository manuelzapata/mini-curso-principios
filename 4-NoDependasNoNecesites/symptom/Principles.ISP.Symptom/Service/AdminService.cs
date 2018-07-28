using Principles.ISP.Symptom.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Principles.ISP.Symptom.Service
{
    class AdminService
    {

        private IRepository dataRepository;

        public AdminService(IRepository repository) {
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
