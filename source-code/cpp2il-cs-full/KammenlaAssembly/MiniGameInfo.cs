using System;
using System.Collections.Generic;
using System.Data;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class MiniGameInfo : MonoBehaviour
{
	private const bool TestingMode = false;

	public static readonly bool IsTesting;

	public static float Delay;

	public static DateTime MiniGameNextTrialTime
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Expected O, but got Unknown
			//IL_0133: Expected O, but got I4
			//IL_009e: Expected O, but got I4
			object obj = typeof(DataRelation) + 712;
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime2 = default(DateTime);
			DateTime dateTime = dateTime2.AddHours(2.0000000002328306);
			DateTime dateTime3 = dateTime2.AddDays(1.0);
			DateTime date = dateTime2.Date;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan value = TimeSpan.FromHours(2.0000000002328306);
			DateTime dateTime4 = dateTime2.Subtract(value);
			return dateTime2.ToLocalTime();
		}
	}

	public static bool CanPlayMiniGameNow
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0127: Expected O, but got I4
			//IL_00e5: Expected O, but got I4
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected I4, but got Unknown
			//IL_01b5: Expected O, but got I4
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Expected I4, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 784;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64B7]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = obj3;
				if (!flag)
				{
					goto IL_007c;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = obj3;
				if (obj5 != null)
				{
					goto IL_007c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			int miniGameRemainingTrials = MiniGameRemainingTrials;
			bool flag3 = miniGameRemainingTrials < 0;
			bool flag4 = miniGameRemainingTrials == 0;
			int num = miniGameRemainingTrials ^ miniGameRemainingTrials;
			int num2 = miniGameRemainingTrials & num;
			bool flag5 = num2 < 0;
			bool flag6 = flag3 == flag5;
			object obj6 = !flag4;
			return (byte)((flag6 & obj6) ? 1 : 0) != 0;
			IL_007c:
			int miniGameRemainingTrials2 = MiniGameRemainingTrials;
			bool flag7 = miniGameRemainingTrials2 < 0;
			bool flag8 = miniGameRemainingTrials2 == 0;
			int num3 = miniGameRemainingTrials2 ^ miniGameRemainingTrials2;
			int num4 = miniGameRemainingTrials2 & num3;
			bool flag9 = num4 < 0;
			bool flag10 = flag7 == flag9;
			object obj7 = !flag8;
			return (byte)((flag10 & obj7) ? 1 : 0) != 0;
		}
	}

	public static bool StillHaveMovesLeft
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00de: Expected O, but got I
			//IL_0108: Expected O, but got I4
			//IL_00b1: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0168: Expected O, but got I
			//IL_0235: Expected I4, but got O
			//IL_01d8: Expected O, but got I
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ed: Expected O, but got Unknown
			//IL_0215: Expected O, but got I4
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Expected I4, but got Unknown
			object obj = 152985600;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63F5]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)184;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = (nint)0 + (nint)184;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			bool flag4 = default(bool);
			bool flag3 = !flag4;
			bool flag5 = flag4;
			if (flag3)
			{
				goto IL_00c7;
			}
			goto IL_0158;
			IL_00c7:
			return flag4;
			IL_0158:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v1 (System.Boolean)+58]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v1 (System.Boolean)+58]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v3+10]");
				bool flag6 = (nint)0 < (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v3+10]");
				bool flag7 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v3+10]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v3+10]");
				object obj9 = num ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v3+10]");
				object obj10 = 0 & obj9;
				bool flag8 = (nint)obj10 < 0;
				bool flag9 = flag6 == flag8;
				object obj11 = !flag7;
				return (byte)((flag9 & obj11) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			bool flag10 = !flag4;
			object obj12 = !flag10;
			flag5 = flag4;
			if (obj12 == null)
			{
				goto IL_00c7;
			}
			goto IL_0158;
		}
	}

	public static bool DelayIsActive
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_02bd: Expected O, but got I4
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected O, but got Unknown
			//IL_00a7: Expected O, but got I
			//IL_033f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0344: Expected O, but got Unknown
			//IL_036e: Expected O, but got I4
			//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e9: Expected O, but got Unknown
			//IL_02ff: Expected O, but got I
			//IL_0319: Expected O, but got I4
			//IL_0130: Expected O, but got I
			//IL_0145: Expected O, but got I
			//IL_0173: Expected O, but got I4
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected O, but got Unknown
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Expected O, but got Unknown
			//IL_01e8: Expected O, but got I
			//IL_0212: Expected O, but got I4
			//IL_03c9: Expected I4, but got O
			object obj = 152985600;
			object obj2 = typeof(MemberAchievementClanFeedData) + 784;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64B8]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v12+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = typeof(DataRelation) + 712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64B9]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			object obj9 = obj6;
			if (obj8 != null)
			{
				goto IL_00cc;
			}
			goto IL_032f;
			IL_0120:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v27+B8]");
			object obj10 = 0;
			object obj11;
			object key = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v11+10]");
			DateTime date = Prefs.GetDate((string)key, (DateTime)0);
			object obj12 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v30+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			bool flag4 = date > now;
			if (flag4)
			{
				object obj14 = typeof(Queue<string>) + 848;
				object obj15 = (nint)0 + (nint)2200;
				object obj16 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v37+E4]");
				bool flag5 = (nint)0 == 0;
				object obj17 = !flag5;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				if ((object)sessionModel == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				User localUser = sessionModel.LocalUser;
				bool flag6 = SFSKammelnaUserExtensions.IsSubscribed(localUser);
				flag4 = (byte)((flag6 ? 1u : 0u) ^ 1u) != 0;
			}
			return flag4;
			IL_0394:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj18 = obj9;
			obj6 = obj9;
			object obj19;
			obj11 = obj19;
			goto IL_0120;
			IL_00cc:
			obj11 = "m_StencilDeferredPS" + 1808;
			obj18 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v27+E4]");
			bool flag7 = (nint)0 == 0;
			object obj20 = obj18;
			obj9 = obj6;
			obj19 = obj11;
			if (!flag7)
			{
				goto IL_0120;
			}
			goto IL_0394;
			IL_007d:
			obj6 = typeof(DataRelation) + 712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64B9]");
			object obj21 = (nint)0 & (nint)1;
			bool flag8 = obj21 == null;
			obj9 = obj6;
			if (!flag8)
			{
				goto IL_00cc;
			}
			goto IL_032f;
			IL_032f:
			_ = 1;
			obj11 = "m_StencilDeferredPS" + 1808;
			obj18 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v27+E4]");
			bool flag9 = (nint)0 == 0;
			object obj22 = !flag9;
			obj6 = obj9;
			obj20 = obj18;
			obj19 = obj11;
			if (obj22 != null)
			{
				goto IL_0120;
			}
			goto IL_0394;
		}
	}

	public static bool CanNotPlayMiniGameOnWeb
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f9: Expected O, but got I
			//IL_0123: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_016c: Expected O, but got I4
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Expected O, but got Unknown
			//IL_01c3: Expected O, but got I4
			//IL_01f7: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63F6]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00a0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			goto IL_00a0;
			IL_00a0:
			User localUser = sessionModel.LocalUser;
			if (SFSKammelnaUserExtensions.IsSubscribed(localUser))
			{
				return false;
			}
			object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v2+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Platform platform = KUtil.GetPlatform();
			object obj12 = platform - 3;
			return obj12 == null;
		}
	}

	public static float SecondsTillNextMiniGameTrial
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_014c: Expected O, but got I4
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_006f: Expected O, but got I4
			//IL_00d5: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 784;
			object obj2 = typeof(DataRelation) + 712;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			DateTime miniGameNextTrialTime = MiniGameNextTrialTime;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			TimeSpan timeSpan = miniGameNextTrialTime - now;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan timeSpan2 = default(TimeSpan);
			double totalSeconds = timeSpan2.TotalSeconds;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
			return (float)totalSeconds;
		}
	}

	public static int MiniGameRemainingTrials
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f6: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected O, but got Unknown
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_01ae: Expected O, but got I4
			//IL_012e: Expected O, but got I
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected O, but got Unknown
			//IL_0156: Expected O, but got I4
			//IL_0224: Expected I4, but got O
			object obj = 152985600;
			object obj2 = typeof(MemberAchievementClanFeedData) + 784;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63F8]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v25+E4]");
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
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v25+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v12+B8]");
			object obj8 = 0;
			object obj9 = obj8 & 1;
			bool flag3 = obj9 == null;
			object obj10 = !flag3;
			if (obj10 != null)
			{
				goto IL_00c0;
			}
			goto IL_0164;
			IL_00c0:
			return 2;
			IL_0164:
			object obj11 = typeof(Queue<string>) + 848;
			object obj12 = (nint)0 + (nint)2200;
			object obj13 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v2+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				User localUser = sessionModel.LocalUser;
				return SFSKammelnaUserExtensions.GetMiniGameTrials(localUser);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v25+B8]");
			object obj15 = 0;
			object obj16 = obj15 & 1;
			if (obj16 != null)
			{
				goto IL_00c0;
			}
			goto IL_0164;
		}
	}

	public static DateTime LastPlayedTime
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			//IL_0069: Expected O, but got I4
			//IL_0087: Expected O, but got I
			//IL_009c: Expected O, but got I
			object obj = typeof(DataRelation) + 712;
			object key = "m_StencilDeferredPS" + 1816;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+10]");
			return Prefs.GetDate((string)key, (DateTime)0);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "m_StencilDeferredPS" + 1816;
			Prefs.SetDate((string)key, value);
		}
	}

	public static DateTime MiniGameDelay
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			//IL_0069: Expected O, but got I4
			//IL_0087: Expected O, but got I
			//IL_009c: Expected O, but got I
			object obj = typeof(DataRelation) + 712;
			object key = "m_StencilDeferredPS" + 1808;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+10]");
			return Prefs.GetDate((string)key, (DateTime)0);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "m_StencilDeferredPS" + 1808;
			Prefs.SetDate((string)key, value);
		}
	}

	static MiniGameInfo()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_016a: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0066: Expected O, but got I4
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_01b1: Expected O, but got I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01e3: Expected O, but got I
		//IL_01f8: Expected O, but got I
		//IL_0226: Expected O, but got I4
		//IL_00da: Expected O, but got I4
		//IL_0126: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj2 = typeof(MemberAchievementClanFeedData) + 784;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(DataRelation) + 712;
		bool isEditor = Application.isEditor;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+B8]");
		object obj7 = 0;
		obj7 = 0;
		object key = "m_StencilDeferredPS" + 1808;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj5;
		}
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v8+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v9+10]");
		DateTime date = Prefs.GetDate((string)key, (DateTime)0);
		object obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = date - now;
		object obj14 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v17+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan2 = default(TimeSpan);
		double totalSeconds = timeSpan2.TotalSeconds;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v12+B8]");
		object obj17 = 0;
	}
}
