using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Themes
{
    public class ThemeAppService : CrudAppService<Theme,ThemeDto,int>, IThemeAppService 
    {
        public ThemeAppService(IRepository<Theme, int> repository)
            : base(repository)
        {

        }
    }
}
