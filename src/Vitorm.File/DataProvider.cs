﻿using System.Collections.Generic;

namespace Vitorm.File
{
    public partial class DataProvider : Vitorm.DataProvider.DataProvider
    {
        protected Dictionary<string, object> config;
        protected DbConfig dbConfig;

        public override void Init(Dictionary<string, object> config)
        {
            this.config = config;
            this.dbConfig = new(config);
        }

        public override Vitorm.DbContext CreateDbContext() => new Vitorm.File.DbContext(dbConfig);


    }
}