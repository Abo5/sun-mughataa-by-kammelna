namespace Social;

public interface ISocialUtilityAdapter
{
	void InitAuth();

	void FacebookLogin();

	void AppleLogin();

	void GoogleLogin();

	void TwitterPostText(string text);

	void TwitterPostImage(string path, string text);

	void LogoutAll();

	void FacebookLoginCallback(string accessToken, string userId, string email);

	void GoogleLoginCallback(string idToken, string accessToken, string userId, string email);

	void TwitterLoginCallback(string accessToken, string secret, string userId, string email);

	void TwitterLinkCallback(string accessToken, string secret, string userID);
}
