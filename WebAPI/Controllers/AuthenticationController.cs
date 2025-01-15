using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Security;
using WebAPI.Users.Models;
using WebAPI.Users.Repository;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly TokenProvider _tokenProvider;

        public AuthenticationController(IUserRepository userRepository, IMapper mapper, TokenProvider tokenProvider)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _tokenProvider = tokenProvider;
        }

        [HttpPost]
        public async Task<ActionResult<string>> Login(UserLoginDto loginDto)
        {
            var foundUser = await _userRepository.FindAsync(x => x.UserName == loginDto.UserName && x.PasswordHash == loginDto.PasswordHash);

            if (foundUser.Count() == 0)
                return NotFound("Wrong login or password");

            var token = _tokenProvider.CreateToken(foundUser.First());
            return Ok(token);
        }

        [HttpPost]
        public async Task<ActionResult> Register(UserRegisterDto registerDto)
        {
            var foundUser = await _userRepository.FindAsync(x =>
                x.UserName == registerDto.UserName ||
                x.Email == registerDto.Email
            );

            // Walidacja email
            try
            {
                var email = new System.Net.Mail.MailAddress(registerDto.Email);
            } catch (FormatException)
            {
                return BadRequest("Invalid email");
            }

            if (foundUser.Any())
                return BadRequest("User with this username or email already exists");

            User user = _mapper.Map<User>(registerDto);
            user.Guid = Guid.NewGuid();
            await _userRepository.AddAsync(user);

            return Ok("Registered succesfly");
        }
    }
}
