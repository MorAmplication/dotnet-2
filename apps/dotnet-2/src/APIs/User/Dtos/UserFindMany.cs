using Dotnet_2.APIs.Common;
using Dotnet_2.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_2.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class UserFindMany : FindManyInput<User, UserWhereInput> { }
