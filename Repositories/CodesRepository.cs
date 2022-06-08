using Domain;
using Domain.RepoInterfaces;
using Infrastructure.DbContext.Interfaces;
using Infrastructure.DbContext.Utils;
using Infrastructure.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class CodesRepository : ICodesRepository
    {
        private readonly IDbContext _dbContext;

        public CodesRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Code Get(string key, string group)
        {
            var parameters = new List<Parameter>()
            {
                new Parameter
                {
                    Name = "key",
                    Value = key,
                    Type = DbTypes.Varchar,
                    Size = 50,
                    IsNullable = false,
                },
                new Parameter
                {
                    Name = "group",
                    Value = group,
                    Type = DbTypes.Varchar,
                    Size = 100,
                    IsNullable = false,
                }
            };

            return _dbContext.GetData<Code>(Constants.Db.Sp.Codes.GET, parameters).FirstOrDefault();
        }
    }
}
