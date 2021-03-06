﻿using System.Collections.Generic;
using System.Linq;

namespace Sitecore.Glimpse
{
    public class RequestData
    {
        private readonly Dictionary<DataKey, object> _requestData = new Dictionary<DataKey, object>();

        public object this[DataKey dataKey]
        {
            get
            {
                return GetKeyValue(dataKey);
            }
            set
            {
                _requestData[dataKey] = value;
            }
        }

        public void Add(DataKey dataKey, object value)
        {
            _requestData.Add(dataKey, value);
        }

        public bool HasData()
        {
            if (_requestData == null) return false;

            if (_requestData.All(x => x.Value == null)) return false;

            return true;
        }

        public object GetKeyValue(DataKey key)
        {
            return _requestData.ContainsKey(key) ? _requestData[key] : null;
        }
    }

    public class RequestDataNotLoaded : RequestData
    {
    }
}
