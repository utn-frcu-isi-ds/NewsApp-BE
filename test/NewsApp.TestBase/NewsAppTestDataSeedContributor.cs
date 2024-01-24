using NewsApp.Themes;
using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;

namespace NewsApp;

public class NewsAppTestDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Theme, int> _themeRepository;
    private readonly IdentityUserManager _identityUserManager;
    private readonly IIdentityUserRepository _identityUserRepository;


    public NewsAppTestDataSeedContributor(IRepository<Theme, int> themeRepository, IdentityUserManager identityUserManager, IIdentityUserRepository identityUserRepository)
    {
        _themeRepository  = themeRepository;
        _identityUserManager = identityUserManager;
        _identityUserRepository = identityUserRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        // Add users
        IdentityUser identityUser1 = new IdentityUser(Guid.NewGuid(), "test_user1", "testuser1@email.com");
        await _identityUserManager.CreateAsync(identityUser1, "1q2w3E*");
        await _identityUserManager.AddToRoleAsync(identityUser1, "Admin");        

        await _themeRepository.InsertAsync(new Theme { Name = "Primer tema", UserId = identityUser1.Id });
        
        await _themeRepository.InsertAsync(new Theme { Name = "Segundo tema", UserId = identityUser1.Id });

        await _themeRepository.InsertAsync(new Theme { Name = "Tercer tema", UserId = identityUser1.Id });
    }
}
