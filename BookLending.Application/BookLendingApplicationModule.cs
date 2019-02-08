using System.Reflection;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.AutoMapper;
using Abp.Modules;
using BookLending.Authorization.Roles;
using BookLending.Authorization.Users;
using BookLending.Authors;
using BookLending.Books;
using BookLending.Categories;
using BookLending.Models;
using BookLending.Roles.Dto;
using BookLending.Users.Dto;

namespace BookLending
{
    [DependsOn(typeof(BookLendingCoreModule), typeof(AbpAutoMapperModule))]
    public class BookLendingApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            // TODO: Is there somewhere else to store these, with the dto classes
            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Role and permission
                cfg.CreateMap<Permission, string>().ConvertUsing(r => r.Name);
                cfg.CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);

                cfg.CreateMap<CreateRoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
                cfg.CreateMap<RoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
                
                cfg.CreateMap<UserDto, User>();
                cfg.CreateMap<UserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());

                cfg.CreateMap<CreateUserDto, User>();
                cfg.CreateMap<CreateUserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());



                cfg.CreateMap<Author,GetAuthorInput>().ReverseMap();
                cfg.CreateMap<Author,UpdateAuthorInput>().ReverseMap();
                cfg.CreateMap<Author,GetAuthorOutput>().ReverseMap();
                cfg.CreateMap<Author,CreateAuthorInput>().ReverseMap();



                cfg.CreateMap<Book,GetBookInput>().ReverseMap();
                cfg.CreateMap<Book,UpdateBookInput>().ReverseMap();
                cfg.CreateMap<Book,GetBookOutput>().ReverseMap();
                cfg.CreateMap<Book,CreateAuthorInput>().ReverseMap();




                cfg.CreateMap<Category,GetCategoryInput>().ReverseMap();
                cfg.CreateMap<Category, UpdateCategoryInput>().ReverseMap();
                cfg.CreateMap<Category, GetCategoryOutput>().ReverseMap();
                cfg.CreateMap<Category, CreateCategoryInput>().ReverseMap();
            });
        }
    }
}
