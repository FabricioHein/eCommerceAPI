namespace eCommerceAPI.Interface
{
    public interface IAuthService
    {
        string Login(Usuario usuario);
        string Register(Usuario usuario);
    }
}
