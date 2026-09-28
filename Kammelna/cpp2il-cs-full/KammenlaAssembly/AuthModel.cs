using System;
using Cpp2ILInjected;

[Serializable]
public class AuthModel
{
	private readonly TokenModel <AccessToken>k__BackingField;

	private readonly TokenModel <RefreshToken>k__BackingField;

	public TokenModel AccessToken => <AccessToken>k__BackingField;

	public TokenModel RefreshToken => <RefreshToken>k__BackingField;

	public AuthModel(TokenModel accessToken, TokenModel refreshToken)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj = this + 16;
		obj = accessToken;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 24;
		obj2 = refreshToken;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
