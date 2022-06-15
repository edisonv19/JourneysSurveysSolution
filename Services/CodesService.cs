using Domain;
using Domain.RepoInterfaces;
using Services.Interfaces;

namespace Services
{
    public class CodesService : ICodesService
    {
        private readonly ICodesRepository _codesRepository;

        public CodesService(ICodesRepository codesRepository)
        {
            _codesRepository = codesRepository;
        }

        public Code Get(string key, string group)
        {
            return _codesRepository.Get(key, group);
        }
    }
}
