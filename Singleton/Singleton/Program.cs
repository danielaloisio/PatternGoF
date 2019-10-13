using Singleton.Domain;
using Singleton.Repository;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = UserRepository.GetInstance();

            repo.Insert(new User { Id = 1, Name = "Daniel", Age = 30 });
            repo.Insert(new User { Id = 2, Name = "Daniel2", Age = 30 });

            var getAll = repo.GetAll();

            var repo2 = UserRepository.GetInstance();

            var getAll3 = repo.GetAll();

            Console.WriteLine(JsonSerializer.Serialize(getAll3));
        }

    }
}
