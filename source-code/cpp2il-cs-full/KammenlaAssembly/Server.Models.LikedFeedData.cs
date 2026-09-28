using System;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;

namespace Server.Models;

[Serializable]
public class LikedFeedData : UserFeedData, IAvatarFeedData
{
	private long <UserId>k__BackingField;

	private DateTime? <UserAvatarDate>k__BackingField;

	private string <UserName>k__BackingField;

	public long UserId
	{
		get
		{
			return <UserId>k__BackingField;
		}
		set
		{
			<UserId>k__BackingField = value;
		}
	}

	public DateTime? UserAvatarDate
	{
		get
		{
			return <UserAvatarDate>k__BackingField;
		}
		set
		{
			<UserAvatarDate>k__BackingField = value;
		}
	}

	public string UserName
	{
		get
		{
			return <UserName>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	long IAvatarFeedData.Id => <UserId>k__BackingField;

	string IAvatarFeedData.Name => <UserName>k__BackingField;

	DateTime? IAvatarFeedData.AvatarDate => <UserAvatarDate>k__BackingField;

	public override bool HasPreview => true;

	public override bool ForcedPreview => false;

	public override LocalizableText GetTitle()
	{
		return TextMeshProExtensions.FixOnly(<UserName>k__BackingField);
	}

	public override LocalizableText GetDetails()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "placementId" + 1208;
		return TextMeshProExtensions.Localize((string)text);
	}

	public override void ShowPreview(Action markSeen)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006f: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 840;
		long num = default(long);
		string dbId = num.ToString();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		MiniProfilePopup.Show(dbId, TrackingPlacement.UserFeedList);
		if (markSeen != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: markSeen.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
