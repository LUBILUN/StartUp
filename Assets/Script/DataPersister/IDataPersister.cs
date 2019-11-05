using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Startup
{
    public interface IDataPersister
    {
        DataSetting GetDataSetting();
    }

    [Serializable]
    public class DataSetting
    {
        //数据持久性
        public enum PersistenceType
        {
            DoNotPersist,
            ReadOnly,
            WriteOnly,
            ReadWrite,
        }

        public string dataTag = System.Guid.NewGuid().ToString()
    }

}
