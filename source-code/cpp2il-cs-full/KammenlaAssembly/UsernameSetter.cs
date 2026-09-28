using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.UI;

public class UsernameSetter : AvatarComponent
{
	private sealed class <>c__DisplayClass2_0
	{
		public UsernameSetter <>4__this;

		public User userClient;

		internal void <Initialize>b__0()
		{
			<>4__this.SetUsername(userClient);
		}

		internal void <Initialize>b__1()
		{
			<>4__this.SetUsername(userClient);
		}

		internal void <Initialize>b__2()
		{
			<>4__this.SetUsername(userClient);
		}
	}

	private TextMeshProUGUI UserName;

	public override void Initialize(AvatarData avatarData)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_0165: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74EB]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object userName;
		UnityEngine.Object userName2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			userName = UserName;
			userName2 = UserName;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			userName = UserName;
			userName2 = UserName;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = userName2 != null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00b8;
		IL_00b8:
		TextMeshProExtensions.SetUsername(UserName, avatarData.<Username>k__BackingField, avatarData.<IsSubscribed>k__BackingField, avatarData.<IsVerified>k__BackingField);
		return;
		IL_0091:
		if (userName != null)
		{
			goto IL_00b8;
		}
	}

	public override void Initialize(User userClient)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_0098: Expected O, but got I
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00d6: Expected I, but got O
		//IL_00f4: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0143: Expected I, but got O
		//IL_0161: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_01b0: Expected I, but got O
		//IL_01ce: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 1568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = userClient;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject go = UserName.gameObject;
		VariableBinderExtensions.Unbind(go);
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)2320;
		object varName = "m_StencilDeferredPS" + 2848;
		GameObject go2 = UserName.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+18]");
		VariableBinderExtensions.Bind(go2, (User)0, (string)varName, action);
		object obj7 = (nint)0 + (nint)2328;
		object varName2 = "setMimeType" + 3808;
		GameObject go3 = UserName.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(obj2, (IntPtr)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+18]");
		VariableBinderExtensions.Bind(go3, (User)0, (string)varName2, action2);
		object obj8 = (nint)0 + (nint)2336;
		object varName3 = "https://www.kammelna.com/Home/Terms" + 4016;
		GameObject go4 = UserName.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(obj2, (IntPtr)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+18]");
		VariableBinderExtensions.Bind(go4, (User)0, (string)varName3, action3);
	}

	public override void Clear()
	{
		//IL_0009: Expected O, but got I4
		//IL_0015: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_016a: Expected O, but got I
		//IL_0184: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_007a: Expected O, but got I
		//IL_01d2: Expected O, but got I4
		//IL_022f: Expected O, but got I4
		object obj = 152989696;
		object obj2 = (nint)0 + (nint)2000;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74EA]");
		object obj3 = (nint)0 & (nint)1;
		string text;
		object obj4;
		object obj6;
		string text2;
		if (obj3 != null)
		{
			text = (string)obj2;
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74EB]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj4;
			text2 = (string)obj2;
			if (!flag)
			{
				goto IL_00a7;
			}
		}
		else
		{
			_ = 1;
			text = (string)obj2;
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74EB]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			obj6 = obj4;
			text2 = (string)obj2;
			if (obj8 != null)
			{
				goto IL_00a7;
			}
		}
		_ = 1;
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		UnityEngine.Object userName = UserName;
		text = text2;
		UnityEngine.Object userName2 = UserName;
		if (obj10 != null)
		{
			goto IL_00f0;
		}
		goto IL_01fc;
		IL_0117:
		TextMeshProExtensions.SetUsername(UserName, text, isSubscribed: false, isVerified: false);
		return;
		IL_00f0:
		if (userName != null)
		{
			goto IL_0117;
		}
		return;
		IL_01fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag4 = userName2 != null;
		bool flag5 = !flag4;
		object obj11 = !flag5;
		text = text2;
		if (obj11 == null)
		{
			return;
		}
		goto IL_0117;
		IL_00a7:
		obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v2+E4]");
		bool flag6 = (nint)0 == 0;
		userName = UserName;
		userName2 = UserName;
		text2 = text;
		if (!flag6)
		{
			goto IL_00f0;
		}
		goto IL_01fc;
	}

	private void SetUsername(User user)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_005b: Expected O, but got I
		//IL_0129: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		string userName = SFSKammelnaUserExtensions.GetUserName(user);
		bool isSubscribed = SFSKammelnaUserExtensions.IsSubscribed(user);
		bool isVerified = SFSKammelnaUserExtensions.IsVerified(user);
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74EB]");
		object obj2 = (nint)0 & (nint)1;
		UnityEngine.Object userName2;
		UnityEngine.Object userName3;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			userName2 = UserName;
			userName3 = UserName;
			if (!flag)
			{
				goto IL_00b9;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			userName2 = UserName;
			userName3 = UserName;
			if (obj4 != null)
			{
				goto IL_00b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = userName3 != null;
		bool flag4 = !flag3;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			return;
		}
		goto IL_00e0;
		IL_00e0:
		TextMeshProExtensions.SetUsername(UserName, userName, isSubscribed, isVerified);
		return;
		IL_00b9:
		if (userName2 != null)
		{
			goto IL_00e0;
		}
	}

	private void SetUsername(string userName, bool isSubscribed, bool isVerified)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_0156: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74EB]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object userName2;
		UnityEngine.Object userName3;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			userName2 = UserName;
			userName3 = UserName;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			userName2 = UserName;
			userName3 = UserName;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = userName3 != null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00b8;
		IL_00b8:
		TextMeshProExtensions.SetUsername(UserName, userName, isSubscribed, isVerified);
		return;
		IL_0091:
		if (userName2 != null)
		{
			goto IL_00b8;
		}
	}
}
