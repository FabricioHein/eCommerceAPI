using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using eCommerceAPI.Interface;


namespace eCommerceAPI.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUsuarioRepository _userRepository;

        private readonly IConfiguration _configuration;

        public AuthService(IUsuarioRepository userRepository, IConfiguration configuration) {
            _userRepository = userRepository;

            _configuration = configuration;
        }
        public string Register(Usuario usuario) 
        {
            var existingUser =  this._userRepository.GetUserByEmail(usuario.Email);

            if (existingUser == null)
            {
                // Hashing password, adding user, etc.
                usuario.Password = BCrypt.Net.BCrypt.HashPassword(usuario.Password);

                 this._userRepository.Add(usuario);

                return "User registered successfully.";
            }

            return "Email is already registered.";

        }

        public string Login(Usuario usuario) {

            var dbUser =  this._userRepository.GetUserByEmail(usuario.Email);

            if (dbUser == null || !BCrypt.Net.BCrypt.Verify(usuario.Password, dbUser.Password))
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, dbUser.Email)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}
