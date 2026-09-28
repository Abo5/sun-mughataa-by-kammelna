using System;
using System.Data;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;

public class MassTournamentInfo
{
	private static class Constants
	{
		public const string Id = "meid";

		public const string RoomId = "rid";

		public const string RoomGroup = "rg";

		public const string Game = "ga";

		public const string ServerId = "sv";

		public const string Name = "tn";

		public const string Organizer = "o";

		public const string AvailabilityTime = "ad";

		public const string StartingTime = "t";

		public const string FinishTime = "fd";

		public const string IsRegisterByCode = "rc";
	}

	private readonly long <Id>k__BackingField;

	private readonly int <RoomId>k__BackingField;

	private readonly string <RoomGroup>k__BackingField;

	private readonly Games <Game>k__BackingField;

	private readonly string <AssignedServerId>k__BackingField;

	private readonly string <Name>k__BackingField;

	private readonly string <Organizer>k__BackingField;

	private readonly bool <IsRegisterByCode>k__BackingField;

	private readonly DateTime <AvailabilityTime>k__BackingField;

	private readonly DateTime <StartingTime>k__BackingField;

	private readonly DateTime <FinishTime>k__BackingField;

	public long Id => <Id>k__BackingField;

	public int RoomId => <RoomId>k__BackingField;

	public string RoomGroup => <RoomGroup>k__BackingField;

	public Games Game => <Game>k__BackingField;

	public string AssignedServerId => <AssignedServerId>k__BackingField;

	public string Name => <Name>k__BackingField;

	public string Organizer => <Organizer>k__BackingField;

	public bool IsRegisterByCode => <IsRegisterByCode>k__BackingField;

	public DateTime AvailabilityTime => <AvailabilityTime>k__BackingField;

	public DateTime StartingTime => <StartingTime>k__BackingField;

	public DateTime FinishTime => <FinishTime>k__BackingField;

	public MassTournamentInfo(int roomId)
	{
		<RoomId>k__BackingField = roomId;
	}

	public MassTournamentInfo(ISFSObject obj)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0048: Expected O, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0063: Expected O, but got I
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02fe: Expected I8, but got I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_01a6: Expected O, but got I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01d7: Expected O, but got I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0369: Expected O, but got I4
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_0395: Expected O, but got I4
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_03fb: Expected O, but got I4
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_0427: Expected O, but got I4
		//IL_020f: Expected O, but got I4
		//IL_025e: Expected O, but got I4
		//IL_03b3: Expected O, but got I
		//IL_03c3: Expected O, but got I
		//IL_02ad: Expected O, but got I4
		//IL_0445: Expected O, but got I
		//IL_0455: Expected O, but got I
		//IL_0495: Expected O, but got I
		//IL_04a5: Expected O, but got I
		object varName = "m_StencilDeferredPS" + 1184;
		object varName2 = "placementId" + 4048;
		object varName3 = "placementId" + 3944;
		object obj2 = "fetch_products" + 2312;
		object obj3 = (nint)0 + (nint)96;
		object varName4 = "startPosition" + 1456;
		object defaultValue = (nint)0 + (nint)2000;
		object obj4 = typeof(DataRelation) + 712;
		base..ctor();
		long num = SFSExtensions.Get(obj, (string)varName, 0L);
		<Id>k__BackingField = num;
		int num2 = SFSExtensions.Get(obj, (string)varName2, 0);
		<RoomId>k__BackingField = num2;
		string text = SFSExtensions.Get(obj, (string)varName3, (string)null);
		object obj5 = this + 32;
		obj5 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		Games games = default(Games);
		<Game>k__BackingField = games;
		string text2 = SFSExtensions.Get(obj, (string)varName4, (string)defaultValue);
		object obj6 = this + 48;
		obj6 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string text3 = SFSExtensions.Get(obj, "startPosition" + 3448, (string)defaultValue);
		object obj7 = this + 56;
		obj7 = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string text4 = SFSExtensions.Get(obj, "not" + 632, (string)defaultValue);
		object obj8 = this + 64;
		obj8 = text4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = "___# Content push apply failed [{0}]: {1}" + 3224;
		string text5 = (string)obj9;
		if ((object)((object)((??)SFSExtensions.Get(obj, (string)obj9, (DateTime?)(object)0) & 1) != null) == null)
		{
			object obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v49+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v49+B8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v19+10]");
			text5 = (string)0;
		}
		object obj12 = "destinationTimeZone" + 4056;
		<AvailabilityTime>k__BackingField = (DateTime)text5;
		object obj13 = "startPosition" + 2136;
		string text6 = (string)obj13;
		DateTime? dateTime = SFSExtensions.Get(obj, (string)obj13, (DateTime?)(object)0);
		object obj14 = (??)dateTime & 1;
		bool flag = obj14 == null;
		object obj15 = !flag;
		if (obj15 == null)
		{
			object obj16 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v45+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v45+B8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v17+10]");
			text6 = (string)0;
		}
		object varName5 = "placementId" + 2320;
		<StartingTime>k__BackingField = (DateTime)text6;
		string text7 = (string)obj12;
		DateTime? dateTime2 = SFSExtensions.Get(obj, (string)obj12, (DateTime?)(object)0);
		object obj18 = (??)dateTime2 & 1;
		bool flag2 = obj18 == null;
		object obj19 = !flag2;
		if (obj19 == null)
		{
			object obj20 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v41+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj20 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v41+B8]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v15+10]");
			text7 = (string)0;
		}
		<FinishTime>k__BackingField = (DateTime)text7;
		bool flag3 = SFSExtensions.Get(obj, (string)varName5, defaultValue: false);
		<IsRegisterByCode>k__BackingField = flag3;
	}
}
