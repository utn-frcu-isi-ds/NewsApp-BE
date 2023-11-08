using NewsApp.Themes;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace NewsApp;

public class NewsAppTestDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Theme, int> _themeRepository;

    public NewsAppTestDataSeedContributor(IRepository<Theme, int> themeRepository)
    {
        _themeRepository  = themeRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        await _themeRepository.InsertAsync(new Theme { Name = "Primer tema" });

        await _themeRepository.InsertAsync(new Theme { Name = "Segundo tema" });

        await _themeRepository.InsertAsync(new Theme { Name = "Tercer tema" });
    }
}
