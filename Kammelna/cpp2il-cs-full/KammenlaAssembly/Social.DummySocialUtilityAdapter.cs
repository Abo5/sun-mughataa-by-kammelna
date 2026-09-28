using System;
using System.Buffers.Text;
using Cpp2ILInjected;

namespace Social;

public class DummySocialUtilityAdapter : ISocialUtilityAdapter
{
	public void InitAuth()
	{
	}

	public void FacebookLogin()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlatformNotSupportedException ex = default(PlatformNotSupportedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)3952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public void AppleLogin()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlatformNotSupportedException ex = default(PlatformNotSupportedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)3944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public void GoogleLogin()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlatformNotSupportedException ex = default(PlatformNotSupportedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)3960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public void TwitterPostText(string text)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlatformNotSupportedException ex = default(PlatformNotSupportedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)3976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public void TwitterPostImage(string path, string text)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlatformNotSupportedException ex = default(PlatformNotSupportedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)3968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public void LogoutAll()
	{
	}

	public void FacebookLoginCallback(string accessToken, string userId, string email)
	{
	}

	public void GoogleLoginCallback(string idToken, string accessToken, string userId, string email)
	{
	}

	public void TwitterLoginCallback(string accessToken, string secret, string userId, string email)
	{
	}

	public void TwitterLinkCallback(string accessToken, string secret, string userID)
	{
	}
}
