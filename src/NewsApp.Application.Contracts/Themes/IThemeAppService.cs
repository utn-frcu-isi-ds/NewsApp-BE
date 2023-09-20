using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace NewsApp.Themes
{
    public interface IThemeAppService : ICrudAppService<ThemeDto,int>
    {

    }
}
