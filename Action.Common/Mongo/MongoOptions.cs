using System;
using System.Collections.Generic;
using System.Text;

namespace Action.Common.Mongo
{
    class MongoOptions
    {
        public string ConnectionString { get; protected set; }
        public string Database { get; protected set; }
        public bool Seed { get; protected set; }
    }
}
