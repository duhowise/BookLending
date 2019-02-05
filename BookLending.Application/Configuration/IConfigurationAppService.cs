﻿using System.Threading.Tasks;
using Abp.Application.Services;
using BookLending.Configuration.Dto;

namespace BookLending.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}