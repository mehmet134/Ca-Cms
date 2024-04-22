using Ca.Cms.Application.Common.Interfaces;
using Ca.Cms.Application.Common.Models.Account;
using Ca.Cms.Infrastructure.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Ca.Cms.WebApi.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class AuthController2 : ControllerBase
    //{
    //    private readonly JwtAccountService _accountService;
    //    private readonly IConfiguration _configuration;

    //    public AuthController2(JwtAccountService accountService, IConfiguration configuration)
    //    {
    //        _accountService = accountService;
    //        _configuration = configuration;
    //    }

    //    [HttpPost("authenticate")]
    //    public async Task<IActionResult> Authenticate(AuthenticationRequest request)
    //    {
    //        var authenticatedUserClaims = await _accountService.AuthenticateAsync(request);
    //        if (authenticatedUserClaims == null) return Unauthorized();

    //        var expireInMinute = Convert.ToDouble(_configuration["Authentication:Jwt:ExpireTimeInMinute"]);
    //        var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:Jwt:SigningKey"]));
    //        var tokenOptions = new JwtSecurityToken(
    //            issuer: _configuration["Authentication:Jwt:Issuer"],
    //            audience: _configuration["Authentication:Jwt:Audience"],
    //            claims: authenticatedUserClaims,
    //            expires: DateTime.UtcNow.AddMinutes(expireInMinute),
    //            notBefore: DateTime.UtcNow,
    //            signingCredentials: new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
    //        );
    //        var accessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
    //        var refreshToken = AccountHelper.GenerateSalt();

    //        return Ok(new
    //        {
    //            AccessToken = accessToken,
    //            RefreshToken = refreshToken,
    //            ExpiresIn = TimeSpan.FromMinutes(expireInMinute).TotalSeconds,
    //        });
    //    }
    //}

}
