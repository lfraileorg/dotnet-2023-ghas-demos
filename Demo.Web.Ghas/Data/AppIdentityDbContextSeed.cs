// using Microsoft.AspNetCore.Identity;
// using System.Threading.Tasks;

// namespace Demo.Web.Ghas.Data
// {
//     public class AppIdentityDbContextSeed
//     {
//         const string Default_Password = "P@ssw9rd.120";
//         public static async Task SeedAsync(UserManager<IdentityUser> userManager)
//         {
//             var defaultUser = new IdentityUser { UserName = "demouser@microsoft.com", Email = "demouser@microsoft.com" };
            
//             await userManager.CreateAsync(defaultUser, Default_Password);

//             string adminUserName = "admin@microsoft.com";
//             var adminUser = new IdentityUser { UserName = adminUserName, Email = adminUserName };
//             await userManager.CreateAsync(adminUser, Default_Password);
//             adminUser = await userManager.FindByNameAsync(adminUserName);

//         }

    
//     }
// }
