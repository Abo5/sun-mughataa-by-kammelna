using System;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public abstract class ClanFeedData
{
	private ClanFeedType <Type>k__BackingField;

	public ClanFeedType Type
	{
		get
		{
			return <Type>k__BackingField;
		}
		set
		{
			<Type>k__BackingField = value;
		}
	}

	public virtual AvatarData AvatarData => null;

	protected static AvatarData BuildAvatarData(long userId, string userName, DateTime? avatarDate, int cardbackId = 0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AvatarData avatarData = default(AvatarData);
		avatarData..ctor();
		long num = default(long);
		string text = num.ToString();
		if (avatarData != null)
		{
			object obj2 = avatarData + 16;
			obj2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj3 = avatarData + 24;
			obj3 = userName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			avatarData.<AvatarDate>k__BackingField = avatarDate;
			IntPtr intPtr = default(IntPtr);
			avatarData.<CardbackId>k__BackingField = (int)(nint)intPtr;
			return avatarData;
		}
		return (AvatarData)(object)new NullReferenceException();
	}
}
