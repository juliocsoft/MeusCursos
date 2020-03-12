using System;
using System.Collections.Generic;
using GTSharp.Domain.Entities;

namespace GTSharp.Domain.Repositories
{
    public interface ITodoRepository
    {
        void Create(TodoItem todoItem);
        void Update(TodoItem todoItem);
        TodoItem GetById(Guid id, string user);
        IEnumerable<TodoItem> GetAll(string user);
        IEnumerable<TodoItem> GetAllDone(string user);
        IEnumerable<TodoItem> GetAllUndone(string user);
        IEnumerable<TodoItem> GetByPeriod(string user, DateTime date, bool done);
    }
}