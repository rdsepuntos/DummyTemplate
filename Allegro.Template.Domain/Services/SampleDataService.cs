using Allegro.Template.Domain.Repositories;

namespace Allegro.Template.Domain.Services
{
    public class SampleDataService
    {
        private readonly ISampleDataRepository _sampleDataRepository;

        public SampleDataService(ISampleDataRepository sampleDataRepository)
        {
            _sampleDataRepository = sampleDataRepository;
        }
    }
}
