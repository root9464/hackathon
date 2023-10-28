public class UserLogin
{
    public string email { get; set; }
    public string password { get; set; }
}

public class Tokenpair
{
    public string accessToken { get; set; }
    public string refreshToken { get; set; }
}

public class UserResponse
{
    public Tokenpair tokenPair { get; set; }
    public UserRole role { get; set; }
}
public enum UserRole
{
    Common,
    Organization
}