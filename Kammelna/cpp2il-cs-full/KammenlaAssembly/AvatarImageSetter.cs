using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.UI;

public class AvatarImageSetter : AvatarComponent
{
	private sealed class <>c__DisplayClass6_0
	{
		public AvatarImageSetter <>4__this;

		public User userClient;

		internal void <Initialize>b__0()
		{
			AvatarImageSetter avatarImageSetter = <>4__this;
			UIExtensions.AssignAvatarImage(avatarImageSetter.Avatar, userClient);
		}
	}

	private Image Avatar;

	private bool useFullSize;

	private int UserDbId;

	private void OnMyAvatarImageUpdated()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_01a1: Expected O, but got I4
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0214: Expected O, but got I4
		//IL_021d: Expected O, but got I4
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_0269: Expected O, but got I4
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7334]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v27+E4]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v27+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj3 = obj5;
		goto IL_0137;
		IL_0137:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		if (intDbId != UserDbId)
		{
			return;
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		DateTime? avatarDate = SFSKammelnaUserExtensions.GetAvatarDate(localUser2);
		object obj9 = (??)avatarDate & 1;
		bool flag4 = obj9 == null;
		object obj10 = !flag4;
		DateTime value = (DateTime)0;
		if (obj10 == null)
		{
			object obj11 = typeof(DataRelation) + 712;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v21+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			value = now;
		}
		DateTime? avatarDate2 = value;
		int num = default(int);
		string dbId = num.ToString();
		Sprite avatarPlaceholder = ImageCacher.AvatarPlaceholder;
		Avatar.sprite = avatarPlaceholder;
		UIExtensions.AssignAvatarImage(Avatar, dbId, avatarDate2);
		return;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag6 = (object)sessionModel == null;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0137;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		SFS.OnPersonalAvatarUpdated -= action;
	}

	public override void Initialize(AvatarData avatarData)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0140: Expected O, but got I
		//IL_014e: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			if ((bool)avatarData.<AvatarImage>k__BackingField)
			{
				goto IL_0071;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = avatarData.<AvatarImage>k__BackingField;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				goto IL_0071;
			}
		}
		Sprite avatarPlaceholder = ImageCacher.AvatarPlaceholder;
		Avatar.sprite = avatarPlaceholder;
		Image avatar = Avatar;
		string <Dbid>k__BackingField = avatarData.<Dbid>k__BackingField;
		DateTime? <AvatarDate>k__BackingField = avatarData.<AvatarDate>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [avatarData @ X1 (AvatarData)+48]");
		UIExtensions.AssignAvatarImage(avatar, <Dbid>k__BackingField, <AvatarDate>k__BackingField, fullSize: false);
		object obj4 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = (nint)0 + (nint)2104;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj5);
		SFS.OnPersonalAvatarUpdated += action;
		return;
		IL_0071:
		Avatar.sprite = avatarData.<AvatarImage>k__BackingField;
	}

	public override void Initialize(User userClient)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0103: Expected O, but got I4
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0171: Expected O, but got I
		//IL_0182: Expected I, but got O
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01af: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = userClient;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			if (Avatar == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = Avatar == null;
			bool flag2 = !flag;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				return;
			}
		}
		Sprite avatarPlaceholder = ImageCacher.AvatarPlaceholder;
		Avatar.sprite = avatarPlaceholder;
		GameObject go = Avatar.gameObject;
		object obj8 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)480;
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj9);
		object varName = "___# Content push apply failed [{0}]: {1}" + 3224;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3 (System.Object)+18]");
		VariableBinderExtensions.Bind(go, (User)0, (string)varName, action);
	}

	public override void Clear()
	{
		Sprite avatarPlaceholder = ImageCacher.AvatarPlaceholder;
		Avatar.sprite = avatarPlaceholder;
	}

	public void UpdateAvatarImage(Sprite sprite)
	{
		Avatar.sprite = sprite;
	}

	public void UpdateAvatarImage(string userDbId, DateTime? timestamp)
	{
		Sprite avatarPlaceholder = ImageCacher.AvatarPlaceholder;
		Avatar.sprite = avatarPlaceholder;
		IntPtr intPtr = default(IntPtr);
		UIExtensions.AssignAvatarImage(Avatar, userDbId, timestamp, (byte)(nint)intPtr != 0);
	}

	public void UpdateAvatarImage(int userDbId, DateTime? timestamp)
	{
		int num = default(int);
		string dbId = num.ToString();
		Sprite avatarPlaceholder = ImageCacher.AvatarPlaceholder;
		Avatar.sprite = avatarPlaceholder;
		IntPtr intPtr = default(IntPtr);
		UIExtensions.AssignAvatarImage(Avatar, dbId, timestamp, (byte)(nint)intPtr != 0);
	}
}
