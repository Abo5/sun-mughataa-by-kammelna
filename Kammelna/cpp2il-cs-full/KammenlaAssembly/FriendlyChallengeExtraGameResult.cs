using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;

public class FriendlyChallengeExtraGameResult : BaseExtraGameResult
{
	private static class Constants
	{
		public const string Challenger = "fcc";

		public const string Defender = "fcd";

		public const string ChallengeLevel = "fcl";

		public const string IsLocked = "fcstal";

		public const string PrizeAmount = "fcpa";
	}

	private PlayerInfo <Challenger>k__BackingField;

	private PlayerInfo <Defender>k__BackingField;

	private int <ChallengeLevel>k__BackingField;

	private bool <IsLocked>k__BackingField;

	private int <PrizeAmount>k__BackingField;

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
			object obj = this + 24;
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
			object obj = this + 32;
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

	public bool IsLocked
	{
		get
		{
			return <IsLocked>k__BackingField;
		}
		set
		{
			<IsLocked>k__BackingField = value;
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

	public bool HasPrize
	{
		get
		{
			//IL_006a: Expected O, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected I4, but got Unknown
			bool flag = <PrizeAmount>k__BackingField < 0;
			bool flag2 = <PrizeAmount>k__BackingField == 0;
			int num = <PrizeAmount>k__BackingField ^ <PrizeAmount>k__BackingField;
			int num2 = <PrizeAmount>k__BackingField & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			return (byte)((flag4 & obj) ? 1 : 0) != 0;
		}
	}

	public FriendlyChallengeExtraGameResult(ISFSObject gameResultData)
		: base(gameResultData)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0053: Expected I, but got O
		//IL_0063: Expected O, but got I
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_009e: Expected O, but got I
		//IL_0124: Expected I, but got O
		//IL_0134: Expected O, but got I
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_016f: Expected O, but got I
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "destinationTimeZone" + 3912;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 936;
		object obj4 = "destinationTimeZone" + 3952;
		nint num = (nint)gameResultData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00df;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X10_v11-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj6 += 16;
			obj5--;
			if ((nint)obj5 != 1)
			{
				continue;
			}
			goto IL_00df;
		}
		object obj7 = (object)(num + (object)(obj6 + 29)) + 312;
		goto IL_0277;
		IL_00df:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0277;
		IL_0277:
		object varName = "destinationTimeZone" + 3992;
		object varName2 = "destinationTimeZone" + 4048;
		object varName3 = "destinationTimeZone" + 4008;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v229 @ X0_v4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerInfo playerInfo = default(PlayerInfo);
		ISFSObject data = default(ISFSObject);
		playerInfo..ctor(data);
		object obj8 = this + 24;
		obj8 = playerInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num2 = (nint)gameResultData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01b0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X10_v6-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_01b0;
		}
		object obj11 = (object)(num2 + (object)(obj10 + 29)) + 312;
		goto IL_030b;
		IL_030b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v314 @ X0_v12] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerInfo playerInfo2 = default(PlayerInfo);
		ISFSObject data2 = default(ISFSObject);
		playerInfo2..ctor(data2);
		object obj12 = this + 32;
		obj12 = playerInfo2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num3 = SFSExtensions.Get(gameResultData, (string)varName, 0);
		bool flag = SFSExtensions.Get(gameResultData, (string)varName2, defaultValue: false);
		int num4 = SFSExtensions.Get(gameResultData, (string)varName3, 0);
		return;
		IL_01b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_030b;
	}
}
