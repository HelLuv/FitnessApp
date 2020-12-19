using System.Collections.Generic;

namespace Fitness.BL.Controller
{
    public abstract class ControllerBase : IDataSaver
    {
        private readonly IDataSaver manager = new DatabaseSaver();

        protected void Save<T>(List<T> item) where T : class
        {
            manager.Save(item);
        }

        protected List<T> Load<T>() where T : class
        {
            return manager.Load<T>();
        }

        List<T> IDataSaver.Load<T>()
        {
            throw new System.NotImplementedException();
        }

        void IDataSaver.Save<T>(List<T> item)
        {
            throw new System.NotImplementedException();
        }
    }
}

