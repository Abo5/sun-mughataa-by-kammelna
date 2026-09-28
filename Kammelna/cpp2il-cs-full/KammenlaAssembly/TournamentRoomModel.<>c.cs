using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Sfs2X.Entities.Data;
using Spine;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class TournamentRoomModel
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ISFSObject, TournamentRoomModel> <>9__21_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal TournamentRoomModel <FromArray>b__21_0(ISFSObject item)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1592;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TournamentRoomModel tournamentRoomModel = default(TournamentRoomModel);
			tournamentRoomModel..ctor(item);
			return tournamentRoomModel;
		}
	}

	private const string ROOM_ID = "rid";

	private const string INFO = "i";

	private const string STATUS = "stat";

	private const string PARTICIPANTS = "pn";

	private const string CURRENT_ROUND = "crd";

	private readonly int <RoomId>k__BackingField;

	private readonly TournamentData <Info>k__BackingField;

	private readonly TournamentStatus <Status>k__BackingField;

	private readonly int <Participants>k__BackingField;

	private readonly int <CurrentRound>k__BackingField;

	public int RoomId => <RoomId>k__BackingField;

	public TournamentData Info => <Info>k__BackingField;

	public TournamentStatus Status => <Status>k__BackingField;

	public int Participants => <Participants>k__BackingField;

	public int CurrentRound => <CurrentRound>k__BackingField;

	public TournamentRoomModel(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003f: Expected I, but got O
		//IL_004f: Expected O, but got I
		//IL_0304: Expected O, but got I
		//IL_0328: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0208: Expected O, but got I
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_0124: Expected I, but got O
		//IL_0134: Expected O, but got I
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_03c8: Expected O, but got I4
		//IL_016f: Expected O, but got I
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
		object varName = "placementId" + 4048;
		base..ctor();
		int num = SFSExtensions.Get(data, (string)varName, 0);
		<RoomId>k__BackingField = num;
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "https://www.kammelna.com/Home/Terms" + 136;
		nint num2 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00cb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X10_v13-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00cb;
		}
		object obj5 = (object)(num2 + (object)(obj4 + 1)) + 312;
		goto IL_02f4;
		IL_02f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v7+8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v257 @ X0_v7] (should have been resolved before IL gen)");
		object obj7 = default(object);
		bool flag = obj7 == null;
		object obj8 = !flag;
		object obj9 = ~obj8;
		TournamentRoomModel tournamentRoomModel = ((obj9 != null) ? null : this);
		bool flag2 = obj7 == null;
		TournamentRoomModel tournamentRoomModel2 = this;
		TournamentData tournamentData = null;
		if (flag2)
		{
			goto IL_01ed;
		}
		nint num3 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01b0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X10_v8-8]");
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
			goto IL_01b0;
		}
		object obj12 = (object)(num3 + (object)(obj11 + 29)) + 312;
		goto IL_038a;
		IL_01b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_038a;
		IL_01ed:
		object obj13 = "startPosition" + 104;
		object obj14 = (nint)0 + (nint)208;
		object varName2 = "placementId" + 296;
		object varName3 = "com.unity.services.authentication.profile" + 1816;
		object obj15 = tournamentRoomModel2 + 24;
		obj15 = tournamentData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		TournamentStatus tournamentStatus = default(TournamentStatus);
		<Status>k__BackingField = tournamentStatus;
		<Participants>k__BackingField = SFSExtensions.Get(data, (string)varName2, 0);
		<CurrentRound>k__BackingField = SFSExtensions.Get(data, (string)varName3, 0);
		return;
		IL_038a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v378 @ X0_v20] (should have been resolved before IL gen)");
		object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentData tournamentData2 = default(TournamentData);
		ISFSObject obj17 = default(ISFSObject);
		tournamentData2..ctor(obj17);
		obj6 = 0;
		tournamentRoomModel2 = tournamentRoomModel;
		tournamentData = tournamentData2;
		goto IL_01ed;
		IL_00cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_02f4;
	}

	public static List<TournamentRoomModel> FromArray(ISFSArray array)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_0091: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_00b1: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		//IL_0152: Expected O, but got I
		//IL_0162: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_023a: Expected O, but got I
		//IL_024b: Expected I, but got O
		//IL_0269: Expected O, but got I
		//IL_01fc: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 3904;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6107]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v4+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v4+8]");
		Func<object, object> func = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 == null)
		{
			goto IL_01aa;
		}
		goto IL_0201;
		IL_01aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v10+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)360;
		Func<object, object> func2 = default(Func<object, object>);
		func2..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v9+B8]");
		object obj16 = (nint)0 + (nint)8;
		obj16 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj7;
		func = func2;
		goto IL_0201;
		IL_0201:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3020370");
		List<TournamentRoomModel> result = default(List<TournamentRoomModel>);
		return result;
		IL_0085:
		obj10 = (nint)0 + (nint)528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v4+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v4+8]");
		func = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			obj7 = obj10;
			goto IL_01aa;
		}
		goto IL_0201;
	}
}
