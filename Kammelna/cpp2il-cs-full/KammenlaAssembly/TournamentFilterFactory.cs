using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Unity.Services.Authentication.Shared;
using UnityEngine.Purchasing.Telemetry;

public static class TournamentFilterFactory
{
	public static readonly ITournamentFilter NoFilter;

	public static ITournamentFilter GetFilter(TournamentType type)
	{
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_02f7: Expected O, but got I
		//IL_01d6: Expected O, but got I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_014b: Expected O, but got I4
		TournamentType[] types;
		if (type > TournamentType.Private)
		{
			if (type != TournamentType.Mass)
			{
				switch (type)
				{
				case TournamentType.OfficialMonthly:
				{
					object obj2 = typeof(MemberAchievementClanFeedData) + 3208;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					OfficialMonthlyTournamentFilter officialMonthlyTournamentFilter = default(OfficialMonthlyTournamentFilter);
					officialMonthlyTournamentFilter..ctor();
					return officialMonthlyTournamentFilter;
				}
				case TournamentType.Official:
				{
					object obj = typeof(MemberAchievementClanFeedData) + 3216;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					OfficialTournamentFilter officialTournamentFilter = default(OfficialTournamentFilter);
					officialTournamentFilter..ctor();
					return officialTournamentFilter;
				}
				}
				goto IL_0261;
			}
			object obj3 = typeof(SqlSingle[]) + 320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			TournamentType[] array = default(TournamentType[]);
			bool flag = array == null;
			nint num = 1;
			if (flag)
			{
				goto IL_0248;
			}
			bool flag2 = array.Length == 0;
			num = 1;
			if (flag2)
			{
				goto IL_0256;
			}
			nint num2 = 1;
			object obj4 = 2;
			types = array;
		}
		else if (type != TournamentType.Public)
		{
			if (type != TournamentType.Private)
			{
				goto IL_0261;
			}
			object obj5 = typeof(SqlSingle[]) + 320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			TournamentType[] array2 = default(TournamentType[]);
			bool flag3 = array2 == null;
			nint num = 1;
			if (flag3)
			{
				goto IL_0248;
			}
			bool flag4 = array2.Length == 0;
			num = 1;
			if (flag4)
			{
				goto IL_0256;
			}
			nint num2 = 1;
			object obj4 = 1;
			types = array2;
		}
		else
		{
			object obj6 = typeof(SqlSingle[]) + 320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			nint num2 = 1;
			TournamentType[] array3 = default(TournamentType[]);
			types = array3;
		}
		object obj7 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		BaseTournamentFilter baseTournamentFilter = default(BaseTournamentFilter);
		baseTournamentFilter..ctor(types);
		return baseTournamentFilter;
		IL_0261:
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj9 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = "tournament_participate_warning_body_with_tickets_warning_daily" + 968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj11 = (nint)0 + (nint)864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (ITournamentFilter)new OutOfMemoryException();
		IL_0248:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0256;
		IL_0256:
		throw new IndexOutOfRangeException();
	}

	static TournamentFilterFactory()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_010a: Expected O, but got I4
		//IL_011a: Expected O, but got I
		//IL_013c: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_007b: Expected O, but got I4
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00d0: Expected O, but got I4
		object handle = typeof(SqlDouble) + 680;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X20_v4+E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2272;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X20_v4+98]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Array values = Enum.GetValues(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentType[] types;
		if (values != null)
		{
			object obj7 = typeof(SqlSingle[]) + 320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			TournamentType[] array = default(TournamentType[]);
			bool flag3 = array == null;
			object obj8 = !flag3;
			types = array;
			if (obj8 == null)
			{
				throw new InvalidCastException();
			}
		}
		else
		{
			types = null;
		}
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1552;
		BaseTournamentFilter baseTournamentFilter = default(BaseTournamentFilter);
		baseTournamentFilter..ctor(types);
		object obj10 = obj9;
		object obj11 = baseTournamentFilter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
