using NewsApp.Themes;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NewsApp.Theme
{
    public class ThemeAppService_Test : NewsAppApplicationTestBase
    {
        private readonly IThemeAppService _themeAppService;

        public ThemeAppService_Test()
        {
            _themeAppService = GetRequiredService<IThemeAppService>();
        }

        [Fact]
        public async Task Should_Get_All_Themes()
        {

            //Act
            var themes = await _themeAppService.GetThemesAsync();

            //Assert
            themes.ShouldNotBeNull();
            themes.Count.ShouldBeGreaterThan(1);
        }
    }
}
