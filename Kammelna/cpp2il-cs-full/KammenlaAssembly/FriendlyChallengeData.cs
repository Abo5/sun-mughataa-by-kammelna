using System;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;

[Serializable]
public class FriendlyChallengeData
{
	public static class Constants
	{
		public const string Challenger = "fcc";

		public const string Defender = "fcd";

		public const string ChallengeLevel = "fcl";

		public const string State = "fcst";

		public const string RoomId = "fcri";
	}

	private PlayerInfo <Challenger>k__BackingField;

	private PlayerInfo <Defender>k__BackingField;

	private int <ChallengeLevel>k__BackingField;

	private ChallengeAnnouncementState <State>k__BackingField;

	private int? <RoomId>k__BackingField;

	public PlayerInfo Challenger
	{
		get
		{
			return <Challenger>k__BackingField;
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

	public PlayerInfo Defender
	{
		get
		{
			return <Defender>k__BackingField;
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

	public int ChallengeLevel
	{
		get
		{
			return <ChallengeLevel>k__BackingField;
		}
		set
		{
			<ChallengeLevel>k__BackingField = value;
		}
	}

	public ChallengeAnnouncementState State
	{
		get
		{
			return <State>k__BackingField;
		}
		set
		{
			<State>k__BackingField = value;
		}
	}

	public int? RoomId
	{
		get
		{
			return <RoomId>k__BackingField;
		}
		set
		{
			<RoomId>k__BackingField = value;
		}
	}

	public FriendlyChallengeData()
	{
	}

	public FriendlyChallengeData(ISFSObject data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003f: Expected I, but got O
		//IL_004f: Expected O, but got I
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected O, but got Unknown
		//IL_0378: Expected O, but got I
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_03c3: Expected I, but got O
		//IL_03d3: Expected O, but got I
		//IL_008a: Expected O, but got I
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected O, but got Unknown
		//IL_011e: Expected O, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_01b8: Expected I, but got O
		//IL_01c8: Expected O, but got I
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_030f: Expected O, but got I4
		//IL_0203: Expected O, but got I
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_02f8: Expected O, but got I4
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "destinationTimeZone" + 3912;
		object obj3 = "destinationTimeZone" + 3952;
		nint num = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00cb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X10_v20-8]");
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
		object obj6 = (object)(num + (object)(obj5 + 29)) + 312;
		goto IL_034e;
		IL_0314:
		int? num2;
		<RoomId>k__BackingField = num2;
		return;
		IL_0275:
		object varName;
		num2 = SFSExtensions.Get(data, (string)varName, 0);
		goto IL_0314;
		IL_015f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_041c;
		IL_0306:
		num2 = (int?)(object)0;
		goto IL_0314;
		IL_00cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_034e;
		IL_034e:
		object varName2 = "destinationTimeZone" + 3992;
		object obj7 = "destinationTimeZone" + 4032;
		object obj8 = (nint)0 + (nint)48;
		varName = "destinationTimeZone" + 4024;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v260 @ X0_v5] (should have been resolved before IL gen)");
		ISFSObject data2 = default(ISFSObject);
		PlayerInfo playerInfo = PlayerInfo.FromSfsObject(data2);
		object obj9 = this + 16;
		obj9 = playerInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num3 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_015f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X10_v15-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_015f;
		}
		object obj12 = (object)(num3 + (object)(obj11 + 29)) + 312;
		goto IL_041c;
		IL_041c:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v355 @ X0_v12] (should have been resolved before IL gen)");
		ISFSObject data3 = default(ISFSObject);
		PlayerInfo playerInfo2 = PlayerInfo.FromSfsObject(data3);
		object obj13 = this + 24;
		obj13 = playerInfo2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num4 = SFSExtensions.Get(data, (string)varName2, 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		nint num5 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0244;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X10_v10-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj15 += 16;
			obj14--;
			if ((nint)obj14 != 1)
			{
				continue;
			}
			goto IL_0244;
		}
		object obj16 = (object)(num5 + (object)(obj15 + 1)) + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v443 @ X0_v32] (should have been resolved before IL gen)");
		object obj17 = default(object);
		if ((object)(obj17 != null) != null)
		{
			goto IL_0275;
		}
		goto IL_0306;
		IL_0244:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v411 @ X0_v29] (should have been resolved before IL gen)");
		object obj18 = default(object);
		if (obj18 != null)
		{
			goto IL_0275;
		}
		goto IL_0306;
	}
}
