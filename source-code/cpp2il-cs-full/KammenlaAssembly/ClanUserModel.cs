using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities.Data;

[Serializable]
public class ClanUserModel
{
	public int ClanId;

	public int UserId;

	public string Name;

	public string ClanName;

	public int ClanTier;

	public string Title;

	public ClanPermissions Permissions;

	public ClanSubscriptionStatus SubscriptionStatus;

	public bool IsOwner;

	public ClanMembershipStatus Status = ClanMembershipStatus.Joined;

	public DateTime AvatarDate;

	public DateTime RequestedAt;

	public bool IsAdmin
	{
		get
		{
			bool flag = Permissions == ClanPermissions.None;
			return !flag;
		}
	}

	public bool CanManageRequests
	{
		get
		{
			//IL_0035: Expected O, but got I4
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected I4, but got Unknown
			if (IsOwner)
			{
				return true;
			}
			object obj = (int)Permissions >> 2;
			return (byte)(obj & 1) != 0;
		}
	}

	public bool CanManageActivities
	{
		get
		{
			//IL_0035: Expected O, but got I4
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected I4, but got Unknown
			if (IsOwner)
			{
				return true;
			}
			object obj = (int)Permissions >> 3;
			return (byte)(obj & 1) != 0;
		}
	}

	public ClanUserModel(ISFSObject cin)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003f: Expected I, but got O
		//IL_004f: Expected O, but got I
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected O, but got Unknown
		//IL_0775: Expected I, but got O
		//IL_0785: Expected O, but got I
		//IL_008a: Expected O, but got I
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected O, but got Unknown
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f2: Expected O, but got Unknown
		//IL_080c: Expected I, but got O
		//IL_081c: Expected O, but got I
		//IL_011e: Expected O, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected O, but got Unknown
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected O, but got Unknown
		//IL_089f: Expected I, but got O
		//IL_08af: Expected O, but got I
		//IL_01b2: Expected O, but got I
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected O, but got Unknown
		//IL_0942: Expected I, but got O
		//IL_0952: Expected O, but got I
		//IL_0246: Expected O, but got I
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_09bf: Expected O, but got I4
		//IL_02da: Expected O, but got I
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected O, but got Unknown
		//IL_046b: Expected I, but got O
		//IL_047b: Expected O, but got I
		//IL_0374: Expected I, but got O
		//IL_0384: Expected O, but got I
		//IL_0525: Expected O, but got I4
		//IL_0590: Expected I, but got O
		//IL_05a0: Expected O, but got I
		//IL_04b6: Expected O, but got I
		//IL_03bf: Expected O, but got I
		//IL_064f: Expected O, but got I4
		//IL_05db: Expected O, but got I
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected O, but got Unknown
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected O, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected O, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected O, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_0a96: Expected O, but got I4
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa3: Expected O, but got Unknown
		//IL_0acb: Expected O, but got I4
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected O, but got Unknown
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected O, but got Unknown
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected O, but got Unknown
		//IL_06e2: Expected O, but got I4
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got Unknown
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		if (cin == null)
		{
			return;
		}
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "clear_mass_tournaments" + 64;
		object obj3 = "clear_mass_tournaments" + 288;
		nint num = (nint)cin;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00cb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X10_v51-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj5 += 16;
			obj4--;
			if ((nint)obj4 != 1)
			{
				continue;
			}
			goto IL_00cb;
		}
		object obj6 = (object)(num + (object)(obj5 + 14)) + 312;
		goto IL_074a;
		IL_0865:
		object varName = "clear_mass_tournaments" + 224;
		object obj7 = "com.unity.services.authentication.profile" + 1496;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v442 @ X0_v13] (should have been resolved before IL gen)");
		int clanTier = default(int);
		ClanTier = clanTier;
		nint num2 = (nint)cin;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0287;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj9 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X10_v36-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj9 += 16;
			obj8--;
			if ((nint)obj8 != 1)
			{
				continue;
			}
			goto IL_0287;
		}
		object obj10 = (object)(num2 + (object)(obj9 + 18)) + 312;
		goto IL_08f8;
		IL_0447:
		object obj11 = "com.unity.services.authentication.profile" + 2504;
		ClanUserModel clanUserModel;
		bool flag = default(bool);
		clanUserModel.IsOwner = flag;
		nint num3 = (nint)cin;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04f7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ X10_v20-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj13 += 16;
			obj12--;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_04f7;
		}
		object obj14 = (object)(num3 + (object)(obj13 + 1)) + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v838 @ X0_v43] (should have been resolved before IL gen)");
		object obj15 = default(object);
		if (obj15 != null)
		{
			goto IL_0588;
		}
		goto IL_0a46;
		IL_031b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_099b;
		IL_099b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v614 @ X0_v23] (should have been resolved before IL gen)");
		bool flag2 = !flag;
		object obj16 = !flag2;
		object obj17 = ~obj16;
		clanUserModel = ((obj17 != null) ? null : this);
		if (flag)
		{
			nint num4 = (nint)cin;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v42 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v42 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0400;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v42 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj19 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X10_v26-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj19 += 16;
				obj18--;
				if ((nint)obj18 != 1)
				{
					continue;
				}
				goto IL_0400;
			}
			object obj20 = (object)(num4 + (object)(obj19 + 11)) + 312;
			goto IL_0a13;
		}
		clanUserModel = this;
		goto IL_0447;
		IL_061c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v900 @ X0_v33] (should have been resolved before IL gen)");
		goto IL_0635;
		IL_00cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_074a;
		IL_074a:
		object obj21 = "com.unity.services.authentication.profile" + 2520;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v269 @ X0_v4] (should have been resolved before IL gen)");
		int clanId = default(int);
		ClanId = clanId;
		nint num5 = (nint)cin;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_015f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj23 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X10_v46-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj23 += 16;
			obj22--;
			if ((nint)obj22 != 1)
			{
				continue;
			}
			goto IL_015f;
		}
		object obj24 = (object)(num5 + (object)(obj23 + 18)) + 312;
		goto IL_07ce;
		IL_0588:
		nint num6 = (nint)cin;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X8_v28 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X8_v28 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_061c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X8_v28 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj26 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X10_v15-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj26 += 16;
			obj25--;
			if ((nint)obj25 != 1)
			{
				continue;
			}
			goto IL_061c;
		}
		object obj27 = (object)(num6 + (object)(obj26 + 14)) + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v916 @ X0_v36] (should have been resolved before IL gen)");
		if ((object)(this != null) == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0635;
		IL_0287:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_08f8;
		IL_08f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v525 @ X0_v16] (should have been resolved before IL gen)");
		object obj28 = this + 48;
		object obj29 = default(object);
		obj28 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num7 = SFSExtensions.Get(cin, (string)varName, 0);
		nint num8 = (nint)cin;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_031b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj31 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X10_v31-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj31 += 16;
			obj30--;
			if ((nint)obj30 != 1)
			{
				continue;
			}
			goto IL_031b;
		}
		object obj32 = (object)(num8 + (object)(obj31 + 1)) + 312;
		goto IL_099b;
		IL_0635:
		ClanSubscriptionStatus clanSubscriptionStatus = default(ClanSubscriptionStatus);
		ClanSubscriptionStatus subscriptionStatus = ((~(~(object)(clanSubscriptionStatus >= (ClanSubscriptionStatus)5)) == null) ? clanSubscriptionStatus : ClanSubscriptionStatus.Active);
		bool flag3 = clanSubscriptionStatus < ClanSubscriptionStatus.Active;
		object obj33 = clanSubscriptionStatus ^ clanSubscriptionStatus;
		object obj34 = clanSubscriptionStatus & obj33;
		bool flag4 = (nint)obj34 < 0;
		bool flag5 = flag3 == flag4;
		object obj35 = !flag5;
		object obj36 = ~obj35;
		if (obj36 == null)
		{
			subscriptionStatus = ClanSubscriptionStatus.Active;
		}
		SubscriptionStatus = subscriptionStatus;
		goto IL_0a46;
		IL_015f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_07ce;
		IL_07ce:
		object obj37 = "com.unity.services.authentication.profile" + 2112;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v356 @ X0_v7] (should have been resolved before IL gen)");
		object obj38 = this + 32;
		object obj39 = default(object);
		obj38 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num9 = (nint)cin;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01f3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj41 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X10_v41-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj41 += 16;
			obj40--;
			if ((nint)obj40 != 1)
			{
				continue;
			}
			goto IL_01f3;
		}
		object obj42 = (object)(num9 + (object)(obj41 + 14)) + 312;
		goto IL_0865;
		IL_0a46:
		Status = ClanMembershipStatus.Joined;
		return;
		IL_0400:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0a13;
		IL_0a13:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v774 @ X0_v46] (should have been resolved before IL gen)");
		goto IL_0447;
		IL_04f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v805 @ X0_v40] (should have been resolved before IL gen)");
		object obj43 = default(object);
		if ((object)(obj43 != null) != null)
		{
			goto IL_0588;
		}
		goto IL_0a46;
		IL_01f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0865;
	}

	public ClanUserModel()
	{
	}

	public static ClanUserModel FromJoinRequest(ClanPendingMembershipViewModel pending, int clanId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 1;
		object obj2 = default(object);
		obj2..ctor();
		if (pending != null)
		{
			_ = pending.UserId;
			object obj3 = obj2 + 24;
			obj3 = pending.Name;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pending @ X0 (Kammelna.Server.Models.Clans.ClanPendingMembershipViewModel)+28]");
			_ = 0;
			_ = pending.CreatedAt;
			_ = 0;
			return (ClanUserModel)obj2;
		}
		return (ClanUserModel)(object)new NullReferenceException();
	}
}
