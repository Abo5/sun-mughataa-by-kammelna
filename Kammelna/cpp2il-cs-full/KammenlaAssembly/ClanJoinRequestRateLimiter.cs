using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;

public static class ClanJoinRequestRateLimiter
{
	private sealed class <>c__DisplayClass9_0
	{
		public long windowStart;

		internal bool <TryConsume>b__0(long ticks)
		{
			//IL_000f: Expected O, but got I8
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected I8, but got Unknown
			object obj = ticks - windowStart;
			bool flag = (nint)obj < 0;
			long num = ticks ^ windowStart;
			long num2 = ticks ^ obj;
			long num3 = num & num2;
			bool flag2 = num3 < 0;
			bool flag3 = flag == flag2;
			return !flag3;
		}
	}

	private const string STAMPS_KEY = "clan_join_request_stamps";

	private const bool DEFAULT_ENABLED = true;

	private const int DEFAULT_LIMIT = 5;

	private const int DEFAULT_WINDOW_MINUTES = 10;

	private static bool _enabled;

	private static int _limit;

	private static TimeSpan _window;

	private static List<long> _stamps;

	public static void Configure(ClanRateLimitConfig config)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0186: Expected O, but got I4
		//IL_02a0: Expected O, but got I
		//IL_02ad: Expected O, but got I4
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02eb: Expected O, but got I4
		//IL_012c: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		//IL_01e9: Expected O, but got I
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0248: Expected O, but got I4
		//IL_026e: Expected F8, but got I4
		//IL_028a: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87A6]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v19+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = config == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0148;
		IL_0148:
		object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1232;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v4+B8]");
		object obj12 = 0;
		obj12 = config._joinRequestLimiterEnabled;
		object obj13 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = Math.Max(1, config._joinRequestLimit);
		object obj16 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v8+B8]");
		object obj17 = 0;
		int num2 = Math.Max(1, config._joinRequestWindowMinutes);
		object obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan = TimeSpan.FromMinutes(num2);
		object obj21 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v13+B8]");
		object obj22 = 0;
		return;
		IL_007d:
		bool flag7 = config == null;
		bool flag8 = !flag7;
		obj7 = 0;
		obj8 = null;
		if (!flag8)
		{
			return;
		}
		goto IL_0148;
	}

	public unsafe static bool TryConsume(out TimeSpan retryAfter)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0ada: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adf: Expected O, but got Unknown
		//IL_0486: Expected O, but got I
		//IL_04b8: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_003d: Expected O, but got I
		//IL_04f0: Expected O, but got I
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_0757: Expected O, but got I4
		//IL_014a: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_0acb: Expected I4, but got O
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01c1: Expected O, but got I
		//IL_01d2: Expected I, but got O
		//IL_0200: Expected O, but got I
		//IL_0231: Expected O, but got I
		//IL_024e: Expected O, but got I
		//IL_027a: Expected O, but got I
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0552: Expected O, but got I4
		//IL_05ab: Expected O, but got I4
		//IL_031d: Expected O, but got I4
		//IL_0b2f: Expected O, but got I
		//IL_0b44: Expected O, but got I
		//IL_0353: Expected O, but got I
		//IL_0371: Expected O, but got I
		//IL_0386: Expected O, but got I
		//IL_0936: Expected O, but got I
		//IL_0968: Expected O, but got I4
		//IL_0971: Expected O, but got I4
		//IL_05e0: Expected O, but got I
		//IL_060f: Expected O, but got I4
		//IL_0618: Expected O, but got I4
		//IL_0621: Expected O, but got I4
		//IL_03d4: Expected O, but got I4
		//IL_09b1: Expected O, but got I4
		//IL_079c: Expected O, but got I
		//IL_07ac: Expected O, but got I
		//IL_07bc: Expected O, but got I
		//IL_07f3: Expected O, but got I4
		//IL_0803: Expected O, but got I
		//IL_09f6: Expected O, but got I
		//IL_0a10: Expected O, but got I4
		//IL_0bf0: Expected O, but got I
		//IL_0c1f: Expected O, but got I4
		//IL_083e: Expected O, but got I
		//IL_03f8: Expected O, but got I
		//IL_041a: Expected O, but got I
		//IL_0449: Expected O, but got I4
		//IL_06e1: Expected O, but got I4
		//IL_068a: Expected O, but got I
		//IL_08df: Expected O, but got I4
		//IL_08e7: Expected O, but got I8
		//IL_0a83: Expected O, but got I4
		//IL_0a64: Expected O, but got I4
		//IL_0885: Expected O, but got I4
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Expected O, but got Unknown
		//IL_0ba9: Expected O, but got I
		//IL_0bbf: Expected O, but got I
		//IL_06f8: Expected O, but got I4
		//IL_0906: Expected O, but got I4
		//IL_089c: Expected O, but got I4
		//IL_08a4: Expected O, but got I8
		object obj = typeof(CardUtils.<>c) + 824;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v4+E4]");
		object obj7;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v4+B8]");
			object obj6 = 0;
			ref TimeSpan reference = ref *(TimeSpan*)obj6;
			obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = obj7;
			if (!flag)
			{
				goto IL_007a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12+B8]");
			object obj10 = 0;
			ref TimeSpan reference = ref *(TimeSpan*)obj10;
			obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			object obj8 = obj7;
			if (obj11 != null)
			{
				goto IL_007a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v14+B8]");
		object obj12 = 0;
		if ((nint)obj12 == 1)
		{
			goto IL_00aa;
		}
		goto IL_050d;
		IL_08fd:
		object obj13 = 0;
		bool result = true;
		goto IL_0b8e;
		IL_0ab8:
		return result;
		IL_0828:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88C1]");
		object obj14 = (nint)0 & (nint)1;
		long ticks;
		object obj15;
		TimeSpan timeSpan;
		object obj17;
		if (obj14 != null)
		{
			obj15 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v32+E4]");
			bool flag3 = (nint)0 == 0;
			object obj16 = !flag3;
			if (obj16 != null)
			{
				goto IL_08fd;
			}
			obj13 = 0;
			timeSpan = (TimeSpan)ticks;
			obj17 = obj15;
		}
		else
		{
			_ = 1;
			obj15 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v32+E4]");
			bool flag4 = (nint)0 == 0;
			obj13 = 0;
			timeSpan = (TimeSpan)ticks;
			obj17 = obj15;
			if (!flag4)
			{
				goto IL_08fd;
			}
		}
		goto IL_0a99;
		IL_007a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v14+B8]");
		object obj18 = 0;
		if ((nint)obj18 == 1)
		{
			goto IL_00aa;
		}
		goto IL_050d;
		IL_050d:
		result = true;
		goto IL_0ab8;
		IL_00aa:
		object obj19 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v14+E4]");
		List<long> list2;
		List<long> list3;
		if ((nint)0 != 0)
		{
			List<long> list = LoadStamps();
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			list2 = list;
			list3 = list;
			if (!flag5)
			{
				goto IL_0129;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			List<long> list4 = LoadStamps();
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v15+E4]");
			bool flag6 = (nint)0 == 0;
			object obj21 = !flag6;
			list2 = list4;
			list3 = list4;
			if (obj21 != null)
			{
				goto IL_0129;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		list2 = list3;
		goto IL_0129;
		IL_0a99:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj15 = obj3;
		bool flag7;
		result = flag7;
		goto IL_0b8e;
		IL_0b8e:
		object obj22 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3680;
		object obj23 = (nint)0 + (nint)2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v32+B8]");
		object obj24 = (nint)0 + (nint)16;
		obj24 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F81418");
		goto IL_0ab8;
		IL_0a2e:
		_ = 1;
		obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v32+E4]");
		bool flag8 = (nint)0 == 0;
		object obj26;
		object obj25 = obj26;
		obj13 = 0;
		obj17 = obj15;
		if (!flag8)
		{
			goto IL_0a7a;
		}
		goto IL_0a99;
		IL_0129:
		DateTime utcNow = DateTime.UtcNow;
		object obj27 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v17+B8]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v18+8]");
		DateTime dateTime = utcNow - (TimeSpan)0;
		DateTime dateTime2 = default(DateTime);
		long ticks2 = dateTime2.Ticks;
		TimeSpan timeSpan3;
		object obj64;
		object obj51;
		if (obj4 != null)
		{
			object obj29 = typeof(List<Tween>) + 3288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj30 = (nint)0 + (nint)3832;
			Predicate<long> predicate = default(Predicate<long>);
			predicate..ctor(obj4, (IntPtr)obj30);
			if (list2 != null)
			{
				object obj31 = (nint)0 + (nint)1560;
				obj26 = obj31;
				int num = list2.RemoveAll(predicate);
				object obj32 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X9_v3+B8]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X19_v7 (System.Collections.Generic.List`1<System.Int64>)+18]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X9_v4+4]");
				object obj34 = num2 - 0;
				bool flag9 = (nint)obj34 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X19_v7 (System.Collections.Generic.List`1<System.Int64>)+18]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X9_v4+4]");
				object obj35 = num3 ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X19_v7 (System.Collections.Generic.List`1<System.Int64>)+18]");
				object obj36 = 0 ^ obj34;
				object obj37 = obj35 & obj36;
				bool flag10 = (nint)obj37 < 0;
				bool flag11 = flag9 == flag10;
				flag7 = !flag11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X19_v7 (System.Collections.Generic.List`1<System.Int64>)+18]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X9_v4+4]");
				if (num4 >= 0)
				{
					long ticks3 = Enumerable.Min(list2);
					object obj38 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v42+E4]");
					bool flag12 = (nint)0 == 0;
					object obj39 = !flag12;
					if (obj39 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					DateTime dateTime3 = new DateTime(ticks3, DateTimeKind.Utc);
					object obj40 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v46+E4]");
					bool flag13 = (nint)0 == 0;
					object obj41 = !flag13;
					if (obj41 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj40 = obj3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v46+B8]");
					object obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v31+8]");
					DateTime dateTime4 = dateTime3 + (TimeSpan)0;
					TimeSpan timeSpan2 = dateTime4 - utcNow;
					ref TimeSpan reference = ref *(TimeSpan*)timeSpan2;
					object obj43 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v32+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v32+B8]");
						object obj44 = 0;
						timeSpan3 = (TimeSpan)obj44;
						bool flag14 = timeSpan2 < (TimeSpan)obj44;
						bool flag15 = !flag14;
						object obj45 = !flag15;
						obj25 = 0;
						obj26 = 0;
						timeSpan = (TimeSpan)obj44;
						if (obj45 == null)
						{
							goto IL_0637;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj46 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v44+B8]");
						object obj47 = 0;
						timeSpan3 = (TimeSpan)obj47;
						bool flag16 = timeSpan2 < (TimeSpan)obj47;
						bool flag17 = !flag16;
						obj25 = 0;
						obj26 = 0;
						timeSpan = (TimeSpan)obj47;
						if (flag17)
						{
							goto IL_0637;
						}
					}
					object obj48 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v66+E4]");
					bool flag18 = (nint)0 == 0;
					object obj49 = !flag18;
					if (obj49 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj48 = obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v66+B8]");
					object obj50 = 0;
					obj51 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v62+E4]");
					bool flag19 = (nint)0 == 0;
					object obj52 = !flag19;
					obj25 = obj26;
					timeSpan3 = timeSpan;
					if (obj52 != null)
					{
						goto IL_0674;
					}
					goto IL_09d6;
				}
				object obj53 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v83+E4]");
				bool flag20 = (nint)0 == 0;
				object obj54 = !flag20;
				if (obj54 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime dateTime5 = default(DateTime);
				ticks = dateTime5.Ticks;
				object obj55 = (nint)0 + (nint)1528;
				object obj56 = obj55;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X19_v7 (System.Collections.Generic.List`1<System.Int64>)+1C]");
				object obj57 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X19_v7 (System.Collections.Generic.List`1<System.Int64>)+10]");
				object obj58 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X19_v7 (System.Collections.Generic.List`1<System.Int64>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X19_v7 (System.Collections.Generic.List`1<System.Int64>)+18]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X9_v11+18]");
					bool flag21 = num5 < 0;
					object obj59 = !flag21;
					if (obj59 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X19_v7 (System.Collections.Generic.List`1<System.Int64>)+18]");
						object obj60 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X19_v7 (System.Collections.Generic.List`1<System.Int64>)+10]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X19_v7 (System.Collections.Generic.List`1<System.Int64>)+18]");
						object obj61 = num6 + 0;
						object obj62 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v100+E4]");
						bool flag22 = (nint)0 == 0;
						object obj63 = !flag22;
						if (obj63 == null)
						{
							obj64 = obj26;
							goto IL_0811;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v56+20]");
						object obj65 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v64+C0]");
						object obj66 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v65+70]");
						obj64 = 0;
						list2.AddWithResize(ticks);
						object obj62 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v100+E4]");
						bool flag23 = (nint)0 == 0;
						object obj67 = !flag23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v65+70]");
						obj26 = 0;
						if (obj67 == null)
						{
							goto IL_0811;
						}
					}
					goto IL_0828;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_09d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88C1]");
		object obj68 = (nint)0 & (nint)1;
		bool flag24 = obj68 == null;
		object obj69 = !flag24;
		obj25 = obj26;
		timeSpan3 = timeSpan;
		if (obj69 != null)
		{
			goto IL_06b7;
		}
		goto IL_0a2e;
		IL_0674:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88C1]");
		object obj70 = (nint)0 & (nint)1;
		bool flag25 = obj70 == null;
		obj26 = obj25;
		timeSpan = timeSpan3;
		if (!flag25)
		{
			goto IL_06b7;
		}
		goto IL_0a2e;
		IL_06b7:
		obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v32+E4]");
		bool flag26 = (nint)0 == 0;
		object obj71 = !flag26;
		if (obj71 != null)
		{
			goto IL_0a7a;
		}
		obj13 = 0;
		obj26 = obj25;
		timeSpan = timeSpan3;
		obj17 = obj15;
		goto IL_0a99;
		IL_0811:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj26 = obj64;
		goto IL_0828;
		IL_0637:
		obj51 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v62+E4]");
		bool flag27 = (nint)0 == 0;
		obj26 = obj25;
		timeSpan = timeSpan3;
		if (!flag27)
		{
			goto IL_0674;
		}
		goto IL_09d6;
		IL_0a7a:
		obj13 = 0;
		obj26 = obj25;
		result = false;
		goto IL_0b8e;
	}

	private static List<long> LoadStamps()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ff: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_0137: Expected O, but got I
		//IL_0147: Expected O, but got I
		//IL_0169: Expected O, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01bf: Expected O, but got I
		//IL_01f3: Expected O, but got I4
		//IL_022e: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1232;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87A7]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v35+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v35+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v16+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v13+10]");
		List<long> result = (List<long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v13+10]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_00ca;
		}
		goto IL_0177;
		IL_00ca:
		return result;
		IL_0177:
		object obj10 = typeof(List<AdaptivePerformanceScaler>) + 1808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<long> list = default(List<long>);
		list..ctor();
		object obj11 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3680;
		object obj12 = (nint)0 + (nint)2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F81144");
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v7+B8]");
		object obj15 = (nint)0 + (nint)16;
		List<long> list2 = default(List<long>);
		obj15 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return list2;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v35+B8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v18+10]");
		result = (List<long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v18+10]");
		if ((nint)0 != 0)
		{
			goto IL_00ca;
		}
		goto IL_0177;
	}

	private static void Persist(List<long> stamps)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_004b: Expected O, but got I
		//IL_0075: Expected O, but got I4
		//IL_0099: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1232;
		object obj2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3680;
		object obj3 = (nint)0 + (nint)2504;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+B8]");
		object obj6 = (nint)0 + (nint)16;
		obj6 = stamps;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F81418");
	}

	static ClanJoinRequestRateLimiter()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0084: Expected O, but got I
		//IL_008d: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_0066: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1232;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+B8]");
		object obj4 = 0;
		obj4 = 1;
		_ = 5;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan = TimeSpan.FromMinutes(8.000000000465661);
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+B8]");
		object obj8 = 0;
	}
}
