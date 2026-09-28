using System;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class LinkSocialPlatformRequestModel
{
	private SocialPlatform <SocialPlatform>k__BackingField;

	private string <FirebaseToken>k__BackingField;

	private string <TwitterID>k__BackingField;

	public SocialPlatform SocialPlatform
	{
		get
		{
			return <SocialPlatform>k__BackingField;
		}
		set
		{
			<SocialPlatform>k__BackingField = value;
		}
	}

	public string FirebaseToken
	{
		get
		{
			return <FirebaseToken>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string TwitterID
	{
		get
		{
			return <TwitterID>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
