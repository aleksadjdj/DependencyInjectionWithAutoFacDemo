using System;

namespace DemoLibrary.Utilities
{
    public class DataAccess : IDataAccess
    {
        public void SaveData(string name)
        {
            Console.WriteLine($"Saving { name }");
        }

        public void LoadData()
        {
            Console.WriteLine("Loading Data");
        }
    }
}
