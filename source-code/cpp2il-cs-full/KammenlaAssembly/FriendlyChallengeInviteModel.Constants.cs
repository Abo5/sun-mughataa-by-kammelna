using System;
using System.Data;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;

public class FriendlyChallengeInviteModel
{
	public static class Constants
	{
		public const string Challenger = "fcc";

		public const string Defender = "fcd";

		public const string ChallengeLevel = "fcl";

		public const string ExpiryTime = "fcit";

		public const string PrizeAmount = "fcpa";
	}

	private PlayerInfo <Challenger>k__BackingField;

	private PlayerInfo <Defender>k__BackingField;

	private int <ChallengeLevel>k__BackingField;

	private DateTime <ExpiryTime>k__BackingField;

	private int <PrizeAmount>k__BackingField;

	private bool <CheatingAllowed>k__BackingField;

	private int <PlayingSpeed>k__BackingField;

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

	public DateTime ExpiryTime
	{
		get
		{
			return <ExpiryTime>k__BackingField;
		}
		set
		{
			<ExpiryTime>k__BackingField = value;
		}
	}

	public int PrizeAmount
	{
		get
		{
			return <PrizeAmount>k__BackingField;
		}
		set
		{
			<PrizeAmount>k__BackingField = value;
		}
	}

	public bool CheatingAllowed
	{
		get
		{
			return <CheatingAllowed>k__BackingField;
		}
		set
		{
			<CheatingAllowed>k__BackingField = value;
		}
	}

	public int PlayingSpeed
	{
		get
		{
			return <PlayingSpeed>k__BackingField;
		}
		set
		{
			<PlayingSpeed>k__BackingField = value;
		}
	}

	public FriendlyChallengeInviteModel(ISFSObject data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003f: Expected I, but got O
		//IL_004f: Expected O, but got I
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_0328: Expected I, but got O
		//IL_0338: Expected O, but got I
		//IL_008a: Expected O, but got I
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected O, but got Unknown
		//IL_011e: Expected O, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01df: Expected O, but got I4
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
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "destinationTimeZone" + 3912;
		object obj3 = "destinationTimeZone" + 3952;
		nint num = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00cb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X10_v11-8]");
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
		goto IL_02dd;
		IL_00cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_02dd;
		IL_02dd:
		object varName = "destinationTimeZone" + 3992;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v240 @ X0_v4] (should have been resolved before IL gen)");
		ISFSObject data2 = default(ISFSObject);
		PlayerInfo playerInfo = PlayerInfo.FromSfsObject(data2);
		object obj7 = this + 16;
		obj7 = playerInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num2 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_015f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj9 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X10_v6-8]");
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
			goto IL_015f;
		}
		object obj10 = (object)(num2 + (object)(obj9 + 29)) + 312;
		goto IL_0381;
		IL_015f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0381;
		IL_0381:
		object varName2 = "destinationTimeZone" + 3984;
		object varName3 = "destinationTimeZone" + 4008;
		object varName4 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2728;
		object varName5 = "startPosition" + 3280;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v330 @ X0_v11] (should have been resolved before IL gen)");
		ISFSObject data3 = default(ISFSObject);
		PlayerInfo playerInfo2 = PlayerInfo.FromSfsObject(data3);
		object obj11 = this + 24;
		obj11 = playerInfo2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num3 = SFSExtensions.Get(data, (string)varName, 0);
		object obj12 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v19+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime? dateTime = SFSExtensions.Get(data, (string)varName2, (DateTime?)DateTime.Now);
		DateTime? dateTime2 = default(DateTime?);
		<ExpiryTime>k__BackingField = dateTime2.Value;
		<PrizeAmount>k__BackingField = SFSExtensions.Get(data, (string)varName3, 0);
		<CheatingAllowed>k__BackingField = SFSExtensions.Get(data, (string)varName4, defaultValue: false);
		<PlayingSpeed>k__BackingField = SFSExtensions.Get(data, (string)varName5, 10);
	}
}
