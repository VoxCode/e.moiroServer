using e.moiroServer.Data.Models.Identity;
using e.moiroServer.Models;
using e.moiroServer.Models.Identity;
using e.moiroServer.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace e.moiroServer.Controllers
{
    public class IdentityController : ApiController
    {
        private readonly UserManager<User> userManager;
        private readonly IIdentityService identityService;
        private readonly AppSettings appSettings;

        public IdentityController(
            UserManager<User> userManager,
            IIdentityService identityService,
            IOptions<AppSettings> appSettings)
        {
            this.userManager = userManager;
            this.identityService = identityService;
            this.appSettings = appSettings.Value;
        }


        [HttpPost]
        [Route(nameof(Register))]
        public async Task<ActionResult> Register(RegisterRequestModel model)
        {
            string role = "Viewer";

            var user = new User
            {
                Email = model.Email,
                UserName = model.UserName,
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                if (model.UserName == "admin")
                {
                    role = "Administrator";
                }
                await userManager.AddToRoleAsync(user, role);
                return Ok();
            }

            return BadRequest(result.Errors);
        }


        [HttpPost]
        [Route(nameof(Login))]
        public async Task<ActionResult<LoginResponseModel>> Login(LoginRequestModel model)
        {
            var user = await userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
                return Unauthorized();
            }

            var passwordValid = await userManager.CheckPasswordAsync(user, model.Password);
            if (!passwordValid)
            {
                return Unauthorized();
            }
            var roles = await userManager.GetRolesAsync(user);
            var token = identityService.GenerateJwtToken(
                user.Id,
                user.UserName,
                appSettings.Secret,
                roles);

            return new LoginResponseModel
            {
                Token = token
            };
        }

        [HttpPost]
        [Route(nameof(ChangeRole))]
        public async Task<ActionResult> ChangeRole(RoleChangeModel roleChangemodel)
        {
            var user = await userManager.FindByNameAsync(roleChangemodel.UserName);
            if (user != null)
            {
                var delResult = await userManager.RemoveFromRoleAsync(user, roleChangemodel.OldRole);

                if (delResult.Succeeded)
                {
                    var addResult = await userManager.AddToRoleAsync(user, roleChangemodel.NewRole);
                    if (addResult.Succeeded)
                    {
                        return Ok();
                    }
                }
            }
            return BadRequest();
        }
    }
}
