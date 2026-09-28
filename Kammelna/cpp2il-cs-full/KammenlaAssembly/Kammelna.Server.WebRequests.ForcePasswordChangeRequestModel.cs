using System;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class ForcePasswordChangeRequestModel
{
	private string <UserEmail>k__BackingField;

	private string <OldPassword>k__BackingField;

	private string <NewPassword>k__BackingField;

	public string UserEmail
	{
		get
		{
			return <UserEmail>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string OldPassword
	{
		get
		{
			return <OldPassword>k__BackingField;
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

	public string NewPassword
	{
		get
		{
			return <NewPassword>k__BackingField;
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
