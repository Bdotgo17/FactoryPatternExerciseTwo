using System;
using System.Collections.Generic;

namespace FactoryPatternExerciseTwoPartTwo
{
    public interface IDataAccess
    {
        public void SaveData();
        public List<Product> LoadData();
    }
}

