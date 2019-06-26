using System;
using System.Collections.Generic;
using System.Text;
using XamarinPokemons.Database.DbRepositories;
using XamarinPokemons.Models;

namespace XamarinPokemons.Database
{
    public interface I_CRUD
    {
        void Save(Object obj);
        void Delete(Object obj);

        Object Get(int id);
        IEnumerable<Object> GetAll();
    }
}
