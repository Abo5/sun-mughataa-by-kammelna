using System.ComponentModel;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public static class TournamentAddonTypeExtensions
{
	public static TournamentAddonModel GetModelByType(TournamentAddonType type, string data)
	{
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0387: Expected O, but got I4
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		TournamentAddonModel result;
		if (type > TournamentAddonType.Message)
		{
			if (type > TournamentAddonType.Championship)
			{
				if (type == TournamentAddonType.SportCelebration)
				{
					object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1168;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1176;
					object obj3 = default(object);
					obj3..ctor();
					int teamId = int.Parse(data);
					object obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v22+E4]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					SportTeam sportTeamById = SportTeamsUtil.GetSportTeamById(teamId);
					object obj6 = obj3 + 24;
					obj6 = sportTeamById;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return (TournamentAddonModel)obj3;
				}
				if (type != TournamentAddonType.GrantTitle)
				{
					bool flag2 = type != TournamentAddonType.AdCampaign;
					result = null;
					if (flag2)
					{
						goto IL_02e0;
					}
					object obj7 = typeof(SqlSingle[]) + 2656;
					goto IL_02e5;
				}
				object obj8 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3248;
			}
			else
			{
				if (type == TournamentAddonType.TitleRestriction)
				{
					object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1200;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					TitleRestrictionTournamentAddon titleRestrictionTournamentAddon = default(TitleRestrictionTournamentAddon);
					titleRestrictionTournamentAddon..ctor(data);
					return titleRestrictionTournamentAddon;
				}
				bool flag3 = type != TournamentAddonType.Championship;
				result = null;
				if (flag3)
				{
					goto IL_02e0;
				}
				object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 584;
			}
		}
		else
		{
			if (type <= TournamentAddonType.RoomTheme)
			{
				if (type != TournamentAddonType.Cardback)
				{
					bool flag4 = type != TournamentAddonType.RoomTheme;
					result = null;
					if (flag4)
					{
						goto IL_02e0;
					}
					object obj7 = typeof(RegisteredWaitHandle) + 1432;
				}
				else
				{
					object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 384;
				}
				goto IL_02e5;
			}
			if (type == TournamentAddonType.VoiceChat)
			{
				object obj10 = typeof(UsageHint) + 1456;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj11 = default(object);
				obj11..ctor();
				return (TournamentAddonModel)obj11;
			}
			bool flag5 = type != TournamentAddonType.Message;
			result = null;
			if (flag5)
			{
				goto IL_02e0;
			}
			object obj8 = typeof(MemberAchievementClanFeedData) + 528;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = default(object);
		obj12..ctor();
		object obj13 = obj12 + 16;
		obj13 = data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (TournamentAddonModel)obj12;
		IL_02e0:
		return result;
		IL_02e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = default(object);
		obj14..ctor();
		int num = int.Parse(data);
		result = (TournamentAddonModel)obj14;
		goto IL_02e0;
	}
}
