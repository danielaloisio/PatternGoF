using Singleton.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Singleton.Repository
{
    public sealed class UserRepository
    {
        private readonly IList<User> _users;
        private static UserRepository _instance = null;
        private static readonly object SyncObj = new object();

        private UserRepository() => _users = new List<User>();

        public static UserRepository GetInstance()
        {
            if (_instance != null) return _instance;

            lock (SyncObj)
            {
                if (_instance == null) _instance = new UserRepository();
            }

            return _instance;
        }

        public IList<User> GetAll()
        {
            return _instance._users;
        }

        public void Insert(User user)
        {
            _instance._users.Add(user);
        }

    }
}
