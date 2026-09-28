using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class BracketNavigation : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<PlayerInfo, bool> <>9__12_3;

		public static Func<MatchData, bool> <>9__14_1;

		public static Func<PlayerInfo, bool> <>9__14_4;

		public static Func<MatchData, bool> <>9__14_2;

		public static Func<PlayerInfo, bool> <>9__14_5;

		public static Func<MatchData, bool> <>9__14_3;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3368;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <InitNavigation>b__12_3(PlayerInfo p)
		{
			//IL_003d: Expected I4, but got O
			if (p != null)
			{
				return p.IsHuman;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <FocusMyMatch>b__14_1(MatchData m)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01fe: Expected I4, but got O
			//IL_01c9: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BEC]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v10+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v10+E4]");
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
			if ((object)sessionModel != null)
			{
				goto IL_0150;
			}
			goto IL_01f0;
			IL_01f0:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0150:
			User localUser = sessionModel.LocalUser;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
			if (m != null)
			{
				bool flag3 = m.HasPlayer(intDbId);
				if (flag3)
				{
					object obj8 = m.<State>k__BackingField - 2;
					bool flag4 = obj8 == null;
					bool flag5 = !flag4;
					flag3 = flag5;
				}
				return flag3;
			}
			goto IL_01f0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag6 = (object)sessionModel == null;
			object obj9 = !flag6;
			if (obj9 != null)
			{
				goto IL_0150;
			}
			goto IL_01f0;
		}

		internal bool <FocusMyMatch>b__14_2(MatchData m)
		{
			//IL_01f6: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00ef: Expected O, but got I
			//IL_00ff: Expected O, but got I
			//IL_0121: Expected O, but got I4
			//IL_00b9: Expected O, but got I4
			//IL_0057: Expected O, but got I
			//IL_0067: Expected O, but got I
			//IL_01c9: Expected O, but got I4
			//IL_0152: Expected O, but got I4
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			//IL_0227: Expected O, but got Unknown
			//IL_023d: Expected O, but got I
			//IL_024e: Expected I, but got O
			//IL_026c: Expected O, but got I
			//IL_0182: Expected O, but got I
			Func<object, bool> predicate;
			bool flag3;
			if (m != null)
			{
				object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3368;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v6+E4]");
				object obj3;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v6+B8]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v7+18]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v7+18]");
					if ((nint)0 != 0)
					{
						goto IL_008d;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v6+B8]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v7+18]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v7+18]");
					bool flag = (nint)0 == 0;
					object obj4 = !flag;
					if (obj4 != null)
					{
						goto IL_008d;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj6 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v13+B8]");
					obj3 = 0;
				}
				object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2672;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj8 = (nint)0 + (nint)1864;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj3, (IntPtr)obj8);
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v12+B8]");
				object obj10 = (nint)0 + (nint)24;
				obj10 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				flag3 = Enumerable.Any(m.<Players>k__BackingField, func);
				if (!flag3)
				{
					goto IL_00c7;
				}
				goto IL_01b6;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00c7:
			return flag3;
			IL_01b6:
			object obj11 = m.<State>k__BackingField - 2;
			bool flag4 = obj11 == null;
			return !flag4;
			IL_008d:
			flag3 = Enumerable.Any(m.<Players>k__BackingField, predicate);
			bool flag5 = !flag3;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				goto IL_00c7;
			}
			goto IL_01b6;
		}

		internal bool <FocusMyMatch>b__14_4(PlayerInfo p)
		{
			//IL_003d: Expected I4, but got O
			if (p != null)
			{
				return p.IsHuman;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <FocusMyMatch>b__14_3(MatchData m)
		{
			//IL_01eb: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00ef: Expected O, but got I
			//IL_00ff: Expected O, but got I
			//IL_0121: Expected O, but got I4
			//IL_00b9: Expected O, but got I4
			//IL_0057: Expected O, but got I
			//IL_0067: Expected O, but got I
			//IL_01c9: Expected O, but got I4
			//IL_0152: Expected O, but got I4
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_021c: Expected O, but got Unknown
			//IL_0232: Expected O, but got I
			//IL_0243: Expected I, but got O
			//IL_0261: Expected O, but got I
			//IL_0182: Expected O, but got I
			Func<object, bool> predicate;
			bool flag3;
			if (m != null)
			{
				object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3368;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v6+E4]");
				object obj3;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v6+B8]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v7+28]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v7+28]");
					if ((nint)0 != 0)
					{
						goto IL_008d;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v6+B8]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v7+28]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v7+28]");
					bool flag = (nint)0 == 0;
					object obj4 = !flag;
					if (obj4 != null)
					{
						goto IL_008d;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj6 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v13+B8]");
					obj3 = 0;
				}
				object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2672;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj8 = (nint)0 + (nint)1872;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj3, (IntPtr)obj8);
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v12+B8]");
				object obj10 = (nint)0 + (nint)40;
				obj10 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				flag3 = Enumerable.Any(m.<Players>k__BackingField, func);
				if (!flag3)
				{
					goto IL_00c7;
				}
				goto IL_01b6;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00c7:
			return flag3;
			IL_01b6:
			object obj11 = m.<State>k__BackingField - 2;
			return obj11 == null;
			IL_008d:
			flag3 = Enumerable.Any(m.<Players>k__BackingField, predicate);
			bool flag4 = !flag3;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				goto IL_00c7;
			}
			goto IL_01b6;
		}

		internal bool <FocusMyMatch>b__14_5(PlayerInfo p)
		{
			//IL_003d: Expected I4, but got O
			if (p != null)
			{
				return p.IsHuman;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass12_0
	{
		public int size;

		public BracketNavigation <>4__this;
	}

	private sealed class <>c__DisplayClass12_1
	{
		public int round;

		public <>c__DisplayClass12_0 CS$<>8__locals1;

		public Func<MatchData, bool> <>9__1;

		public Func<MatchData, bool> <>9__2;

		internal void <InitNavigation>b__0(bool isOn)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0507: Expected O, but got I
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_005d: Expected O, but got I4
			//IL_00de: Expected O, but got I
			//IL_0111: Expected O, but got I4
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0095: Expected O, but got I
			//IL_00a3: Expected I, but got O
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected O, but got Unknown
			//IL_00c5: Expected O, but got I4
			//IL_031f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0324: Expected O, but got Unknown
			//IL_033a: Expected O, but got I
			//IL_0348: Expected I, but got O
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0211: Expected O, but got Unknown
			//IL_023b: Expected O, but got I4
			//IL_0264: Expected O, but got I
			//IL_0399: Expected O, but got I4
			//IL_03a2: Expected O, but got I4
			//IL_03b3: Expected O, but got I4
			//IL_0413: Unknown result type (might be due to invalid IL or missing references)
			//IL_0418: Expected O, but got Unknown
			//IL_053e: Expected O, but got I4
			//IL_0489: Invalid comparison between F8 and I8
			//IL_04ca: Expected I4, but got F8
			//IL_0584: Expected O, but got I4
			//IL_04ad: Expected I4, but got I8
			if (!isOn)
			{
				return;
			}
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+B8]");
			object obj3 = 0;
			object obj4 = obj3;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v174 @ X8_v8+198] (should have been resolved before IL gen)");
			object obj6 = this + 32;
			Func<object, bool> func = (Func<object, bool>)obj6;
			bool flag = obj6 == null;
			object obj7 = !flag;
			object obj10 = default(object);
			if (obj7 == null)
			{
				object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2384;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)1896;
				Func<object, bool> func2 = default(Func<object, bool>);
				func2..ctor((object)this, (IntPtr)obj9);
				<>9__1 = func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj10 = 0;
				func = func2;
			}
			object obj11 = (nint)0 + (nint)1024;
			object obj12 = obj11;
			IEnumerable<object> source = default(IEnumerable<object>);
			object obj13 = Enumerable.FirstOrDefault(source, func);
			bool flag2 = obj13 == null;
			object obj14 = !flag2;
			Func<object, bool> func3 = func;
			if (obj14 != null)
			{
				goto IL_01a5;
			}
			object obj15 = this + 40;
			if (obj15 != null)
			{
				obj12 = obj11;
				obj13 = Enumerable.FirstOrDefault(source, (Func<object, bool>)obj15);
				bool flag3 = obj13 == null;
				func3 = (Func<object, bool>)obj15;
				object obj16 = obj10;
				object obj17 = obj11;
				Func<object, bool> func4 = (Func<object, bool>)obj15;
				if (!flag3)
				{
					goto IL_01a5;
				}
			}
			else
			{
				object obj18 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2384;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj19 = (nint)0 + (nint)1904;
				Func<object, bool> func5 = default(Func<object, bool>);
				func5..ctor((object)this, (IntPtr)obj19);
				<>9__2 = func5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj12 = obj11;
				obj13 = Enumerable.FirstOrDefault(source, func5);
				bool flag4 = obj13 == null;
				object obj20 = !flag4;
				obj10 = 0;
				func3 = func5;
				object obj16 = 0;
				object obj17 = obj11;
				Func<object, bool> func4 = func5;
				if (obj20 != null)
				{
					goto IL_01a5;
				}
			}
			<>c__DisplayClass12_0 cS$<>8__locals = CS$<>8__locals1;
			BracketNavigation <>4__this = cS$<>8__locals.<>4__this;
			BracketGenerator tree = <>4__this.tree;
			object obj21 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v27+E4]");
			bool flag5 = (nint)0 == 0;
			object obj23 = !flag5;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double y = 1.0 - (double)round;
			double num = Math.Pow(2.0, y);
			double num2 = 1.0 - num;
			double num3 = num2 * (double)tree.tournamentSize;
			int matchId;
			if (num3 == 9.218868437227405E+18)
			{
				matchId = -2147483647;
			}
			else
			{
				double num4 = num3 + 1.0;
				matchId = (int)num4;
			}
			tree.ScrollToMatch(matchId, highlight: false);
			<>c__DisplayClass12_0 cS$<>8__locals2 = CS$<>8__locals1;
			bool flag6 = CS$<>8__locals1 == null;
			object obj24 = !flag6;
			if (obj24 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_02dd;
			IL_02dd:
			BracketNavigation <>4__this2 = cS$<>8__locals2.<>4__this;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(<>4__this2.zoomTarget, 1f, 0.6f);
			return;
			IL_01a5:
			<>c__DisplayClass12_0 cS$<>8__locals3 = CS$<>8__locals1;
			BracketNavigation <>4__this3 = cS$<>8__locals3.<>4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v13 (System.Object)+40]");
			bool highlight;
			if ((nint)0 == 2)
			{
				highlight = false;
			}
			else
			{
				object obj25 = typeof(Queue<string>) + 848;
				object obj26 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v16+E4]");
				bool flag7 = (nint)0 == 0;
				object obj27 = !flag7;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj28 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				User localUser = sessionModel.LocalUser;
				int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
				bool flag8 = ((MatchData)obj13).HasPlayer(intDbId);
				highlight = flag8;
			}
			BracketGenerator tree2 = <>4__this3.tree;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v13 (System.Object)+10]");
			tree2.ScrollToMatch(0, highlight);
			cS$<>8__locals2 = CS$<>8__locals1;
			goto IL_02dd;
		}

		internal bool <InitNavigation>b__1(MatchData m)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_00d8: Expected O, but got I
			//IL_0102: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			//IL_005a: Expected O, but got I
			//IL_0231: Expected I4, but got O
			//IL_0207: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			object obj3 = typeof(UnityEngine.IPlayerEditorConnectionNative) & 1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				if (!flag)
				{
					goto IL_008f;
				}
			}
			else
			{
				_ = 1;
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_008f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				goto IL_014e;
			}
			goto IL_0223;
			IL_0223:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_014e:
			User localUser = sessionModel.LocalUser;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
			if (m != null)
			{
				bool flag3 = m.HasPlayer(intDbId);
				if (flag3)
				{
					<>c__DisplayClass12_0 cS$<>8__locals = CS$<>8__locals1;
					if (CS$<>8__locals1 == null)
					{
						goto IL_0223;
					}
					int matchRound = TournamentMath.GetMatchRound(m.<ID>k__BackingField, cS$<>8__locals.size);
					object obj8 = matchRound - round;
					bool flag4 = obj8 == null;
					flag3 = flag4;
				}
				return flag3;
			}
			goto IL_0223;
			IL_008f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag5 = (object)sessionModel == null;
			object obj9 = !flag5;
			if (obj9 != null)
			{
				goto IL_014e;
			}
			goto IL_0223;
		}

		internal bool <InitNavigation>b__2(MatchData m)
		{
			//IL_0256: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00ef: Expected O, but got I
			//IL_00ff: Expected O, but got I
			//IL_0121: Expected O, but got I4
			//IL_00b9: Expected O, but got I4
			//IL_0057: Expected O, but got I
			//IL_0067: Expected O, but got I
			//IL_0152: Expected O, but got I4
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Expected O, but got Unknown
			//IL_029d: Expected O, but got I
			//IL_02ae: Expected I, but got O
			//IL_02cc: Expected O, but got I
			//IL_0182: Expected O, but got I
			//IL_0234: Expected O, but got I4
			Func<object, bool> predicate;
			bool flag3;
			if (m != null)
			{
				object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3368;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v10+E4]");
				object obj3;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v10+B8]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v10+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v10+8]");
					if ((nint)0 != 0)
					{
						goto IL_008d;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v10+B8]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v10+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v10+8]");
					bool flag = (nint)0 == 0;
					object obj4 = !flag;
					if (obj4 != null)
					{
						goto IL_008d;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj6 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v16+B8]");
					obj3 = 0;
				}
				object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2672;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj8 = (nint)0 + (nint)1880;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj3, (IntPtr)obj8);
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v15+B8]");
				object obj10 = (nint)0 + (nint)8;
				obj10 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				flag3 = Enumerable.Any(m.<Players>k__BackingField, func);
				if (!flag3)
				{
					goto IL_00c7;
				}
				goto IL_01b6;
			}
			goto IL_0248;
			IL_0248:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_01b6:
			if (m.<State>k__BackingField == MatchData.Status.Finished)
			{
				return false;
			}
			<>c__DisplayClass12_0 cS$<>8__locals = CS$<>8__locals1;
			if (CS$<>8__locals1 != null)
			{
				int matchRound = TournamentMath.GetMatchRound(m.<ID>k__BackingField, cS$<>8__locals.size);
				object obj11 = matchRound - round;
				return obj11 == null;
			}
			goto IL_0248;
			IL_008d:
			flag3 = Enumerable.Any(m.<Players>k__BackingField, predicate);
			bool flag4 = !flag3;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				goto IL_00c7;
			}
			goto IL_01b6;
			IL_00c7:
			return flag3;
		}
	}

	private GameObject navObject;

	private RectTransform navContainer;

	private ToggleGroup toggleGroup;

	private Toggle navPrefab;

	private BracketGenerator tree;

	private RectTransform zoomTarget;

	private bool _isInitialized;

	private readonly List<Toggle> _roundToggles;

	private static TournamentViewConnector Connector
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			return (TournamentViewConnector)0;
		}
	}

	private void Awake()
	{
		navObject.SetActive(_isInitialized);
	}

	private void OnEnable()
	{
		FocusMyMatch();
	}

	public void InitNavigation()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_05f7: Expected O, but got I
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected O, but got Unknown
		//IL_00bf: Expected O, but got I4
		//IL_00c8: Expected O, but got I4
		//IL_0075: Expected O, but got I4
		//IL_0651: Expected O, but got I
		//IL_0676: Expected O, but got I
		//IL_0167: Expected O, but got I4
		//IL_069b: Expected O, but got I
		//IL_01a2: Expected O, but got I
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_01fc: Expected O, but got I4
		//IL_0233: Expected F8, but got I
		//IL_0244: Invalid comparison between F8 and I8
		//IL_06b1: Invalid comparison between F8 and I4
		//IL_0268: Expected F8, but got I8
		//IL_0286: Expected O, but got I
		//IL_0292: Expected O, but got I
		//IL_029b: Expected O, but got I4
		//IL_02a4: Expected O, but got I4
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_03b8: Expected O, but got I4
		//IL_03e1: Expected O, but got I
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		//IL_044a: Expected O, but got I
		//IL_045b: Expected I, but got O
		//IL_0497: Expected I4, but got F8
		//IL_0516: Expected O, but got I4
		//IL_02b9: Expected O, but got I
		//IL_02c9: Expected O, but got I
		//IL_02d9: Expected O, but got I
		//IL_02ee: Invalid comparison between F8 and O
		//IL_02fd: Expected O, but got I4
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_057e: Invalid comparison between F8 and O
		//IL_0590: Expected O, but got I4
		//IL_05a1: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v6+B8]");
		object obj6 = 0;
		object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v10+E4]");
		if ((nint)0 != 0)
		{
			bool flag = (UnityEngine.Object)obj6 == null;
			bool flag2 = !flag;
			object obj9 = 0;
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = (UnityEngine.Object)obj6 == null;
			bool flag4 = !flag3;
			object obj10 = !flag4;
			object obj9 = 0;
			if (obj10 != null)
			{
				return;
			}
		}
		object obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v14+B8]");
		object obj12 = 0;
		object obj13 = obj12;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v375 @ X8_v16+188] (should have been resolved before IL gen)");
		object obj15 = default(object);
		if (obj15 == null)
		{
			return;
		}
		object obj16 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v19+B8]");
		object obj17 = 0;
		object obj18 = obj17;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v203 @ X8_v21+198] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v18+18]");
		if ((nint)0 == 0)
		{
			return;
		}
		bool flag5 = !_isInitialized;
		object obj20 = !flag5;
		if (obj20 != null)
		{
			return;
		}
		navObject.SetActive(value: true);
		object obj21 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v25+B8]");
		object obj22 = 0;
		object obj23 = obj22;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v27+190]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v205 @ X8_v27+188] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v22+6C]");
		_ = 0;
		object obj26 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v23+E4]");
		bool flag6 = (nint)0 == 0;
		object obj28 = !flag6;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v22+6C]");
		double num = Math.Log(0.0, 2.0);
		double num2 = ((num != 9.218868437227405E+18) ? num : 2147483648.0);
		if (!(num2 < 1.0))
		{
			object obj29 = (nint)0 + (nint)288;
			object obj30 = (nint)0 + (nint)1152;
			object obj31 = 0;
			object obj32 = 0;
			object obj34 = default(object);
			Toggle toggle = default(Toggle);
			UnityAction<bool> unityAction = default(UnityAction<bool>);
			TextMeshProUGUI textMesh = default(TextMeshProUGUI);
			while (true)
			{
				object obj33 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3384;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj34..ctor();
				object obj35 = obj34 + 24;
				obj35 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj36 = obj31 + 1;
				object obj37 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj38 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X0_v32+E4]");
				bool flag7 = (nint)0 == 0;
				object obj39 = !flag7;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj40 = (nint)0 + (nint)1056;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
				bool isOn = obj31 == null;
				toggle.isOn = isOn;
				toggle.group = toggleGroup;
				object obj41 = typeof(TypeConverter<ushort, char>) + 360;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj42 = (nint)0 + (nint)1888;
				unityAction..ctor(obj34, (IntPtr)obj42);
				toggle.onValueChanged.AddListener(unityAction);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v29 (System.Object)+10]");
				LocalizableText roundName = GetRoundName(0, (int)num2);
				TextMeshProExtensions.Localize(textMesh, roundName);
				List<object> roundToggles = (List<object>)(object)_roundToggles;
				object obj43 = obj30;
				int version = roundToggles._version + 1;
				roundToggles._version = version;
				object[] items = roundToggles._items;
				bool flag8 = roundToggles._size < items.Length;
				object obj44 = !flag8;
				if (obj44 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v48+20]");
					object obj45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v50+C0]");
					object obj46 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v51+70]");
					obj32 = 0;
					roundToggles.AddWithResize((object)toggle);
					bool flag9 = (object)num2 == obj36;
					object obj47 = 0;
					obj31 = obj36;
					obj25 = toggle;
					if (flag9)
					{
						break;
					}
				}
				else
				{
					int size = roundToggles._size + 1;
					roundToggles._size = size;
					object obj48 = items + roundToggles._size;
					object obj49 = obj48 + 32;
					obj49 = toggle;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag10 = (object)num2 != obj36;
					object obj47 = 0;
					obj31 = obj36;
					obj32 = 0;
					obj25 = toggle;
					if (!flag10)
					{
						break;
					}
				}
			}
		}
		_isInitialized = true;
	}

	private static LocalizableText GetRoundName(int round, int totalRounds)
	{
		//IL_023d: Expected O, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00eb: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0136: Expected I, but got O
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		object obj = totalRounds - round;
		object text3;
		if ((nint)obj != 2)
		{
			if ((nint)obj != 1)
			{
				if (totalRounds != round)
				{
					object obj2 = typeof(TypeConverter<ushort, char>) + 3400;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					int num = default(int);
					string content = num.ToString();
					object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v13+E4]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text = StringUtil.Size(content, 70);
					object[] array = default(object[]);
					int num2;
					IndexOutOfRangeException ex = default(IndexOutOfRangeException);
					int num4;
					if (array != null)
					{
						bool flag2 = text == null;
						num2 = 70;
						if (!flag2)
						{
							nint num3 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
							num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag3 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
							num4 = 0;
							if (flag3)
							{
								goto IL_0213;
							}
						}
						if (array.Length != 0)
						{
							object obj6 = array + 32;
							obj6 = text;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object text2 = "Read object reference Id '{0}' for {1}." + 3584;
							return TextMeshProExtensions.LocalizeWith((string)text2, array);
						}
					}
					else
					{
						NullReferenceException ex2 = new NullReferenceException();
						num2 = 70;
					}
					ex = new IndexOutOfRangeException();
					num4 = num2;
					goto IL_0213;
				}
				text3 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 32;
			}
			else
			{
				text3 = "SERVICE_DISABLED" + 2712;
			}
		}
		else
		{
			text3 = "Picking audio files is not supported on iOS" + 3072;
		}
		return TextMeshProExtensions.Localize((string)text3);
		IL_0213:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (LocalizableText)(object)new OutOfMemoryException();
	}

	public void FocusMyMatch()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0055: Expected O, but got I
		//IL_0063: Expected I, but got O
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00a6: Expected O, but got I4
		GameObject gameObject = base.gameObject;
		if (gameObject.activeInHierarchy)
		{
			object obj = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = (nint)0 + (nint)736;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj2);
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.3f, action);
		}
	}

	public BracketNavigation()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 88;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <FocusMyMatch>b__14_0()
	{
		//IL_0016: Expected O, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_0729: Expected O, but got I
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_02a7: Expected O, but got I
		//IL_02b7: Expected O, but got I
		//IL_02c7: Expected O, but got I
		//IL_02e9: Expected O, but got I4
		//IL_026e: Expected O, but got I4
		//IL_01f5: Expected O, but got I
		//IL_0205: Expected O, but got I
		//IL_0215: Expected O, but got I
		//IL_0321: Expected O, but got I4
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Expected O, but got Unknown
		//IL_0760: Expected O, but got I
		//IL_0771: Expected I, but got O
		//IL_078f: Expected O, but got I
		//IL_0382: Expected O, but got I4
		//IL_038b: Expected O, but got I4
		//IL_0351: Expected O, but got I
		//IL_044d: Expected O, but got I
		//IL_045d: Expected O, but got I
		//IL_047f: Expected O, but got I4
		//IL_04f0: Expected O, but got I
		//IL_051b: Expected O, but got I4
		//IL_03e6: Expected O, but got I
		//IL_03f6: Expected O, but got I
		//IL_0418: Expected O, but got I4
		//IL_04af: Expected O, but got I4
		//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ba: Expected O, but got Unknown
		//IL_07d0: Expected O, but got I
		//IL_07e1: Expected I, but got O
		//IL_07ff: Expected O, but got I
		//IL_081a: Expected O, but got I4
		//IL_0640: Expected O, but got I
		//IL_0650: Expected O, but got I
		//IL_0672: Expected O, but got I4
		//IL_04df: Expected O, but got I
		//IL_0566: Expected O, but got I
		//IL_0576: Expected O, but got I
		//IL_06a2: Expected O, but got I4
		//IL_0836: Unknown result type (might be due to invalid IL or missing references)
		//IL_083b: Expected O, but got Unknown
		//IL_0851: Expected O, but got I
		//IL_0862: Expected I, but got O
		//IL_0880: Expected O, but got I
		//IL_06fb: Expected O, but got I4
		//IL_06d2: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BEA]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B0]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B0]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v58+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		obj2 = obj4;
		goto IL_0162;
		IL_048d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v36+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		object obj12;
		object obj13;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v39+B8]");
			obj13 = 0;
		}
		object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)1848;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj13, (IntPtr)obj15);
		object obj16 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v38+B8]");
		object obj17 = (nint)0 + (nint)32;
		obj17 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj18 = 0;
		Func<object, bool> predicate = func;
		goto IL_04e4;
		IL_05c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v10 (System.Object)+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v4+6C]");
		int matchRound = TournamentMath.GetMatchRound((int)num, 0);
		int index = matchRound - 1;
		object obj19 = ((List<object>)(object)_roundToggles).get_Item(index);
		((Toggle)obj19).isOn = true;
		return;
		IL_03a9:
		object obj20 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v36+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v36+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v33+20]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v33+20]");
			bool flag4 = (nint)0 == 0;
			object obj21 = !flag4;
			if (obj21 == null)
			{
				goto IL_048d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v36+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v33+20]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v33+20]");
			bool flag5 = (nint)0 == 0;
			object obj22 = !flag5;
			if (obj22 == null)
			{
				goto IL_048d;
			}
		}
		goto IL_04e4;
		IL_0082:
		object obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v63+B8]");
		object obj24 = 0;
		obj9 = obj24;
		bool flag6 = obj24 == null;
		object obj25 = !flag6;
		if (obj25 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0162;
		IL_0162:
		object obj26 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ X8_v4+188] (should have been resolved before IL gen)");
		object obj27 = default(object);
		if (obj27 == null)
		{
			return;
		}
		object obj28 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v8+B8]");
		object obj29 = 0;
		object obj30 = obj29;
		obj12 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3368;
		object obj31 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v221 @ X8_v10+198] (should have been resolved before IL gen)");
		object obj32 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v46+E4]");
		object obj34;
		Func<object, bool> func2;
		object obj35;
		object obj33;
		if ((nint)0 != 0)
		{
			obj33 = (nint)0 + (nint)1816;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v46+B8]");
			obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v44+10]");
			func2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v44+10]");
			bool flag7 = (nint)0 == 0;
			obj35 = obj33;
			if (!flag7)
			{
				goto IL_0242;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj32 = obj12;
			obj33 = (nint)0 + (nint)1816;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v46+B8]");
			obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v44+10]");
			func2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v44+10]");
			bool flag8 = (nint)0 == 0;
			object obj36 = !flag8;
			obj35 = obj33;
			if (obj36 != null)
			{
				goto IL_0242;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v46+E4]");
		bool flag9 = (nint)0 == 0;
		object obj37 = !flag9;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj38 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v50+B8]");
			obj34 = 0;
		}
		object obj39 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj40 = (nint)0 + (nint)1840;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj34, (IntPtr)obj40);
		object obj41 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v49+B8]");
		object obj42 = (nint)0 + (nint)16;
		obj42 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj43 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC96CC");
		object obj44 = default(object);
		bool flag10 = obj44 == null;
		object obj45 = !flag10;
		obj18 = 0;
		obj33 = obj35;
		Func<object, bool> func4 = func3;
		if (obj45 == null)
		{
			goto IL_03a9;
		}
		goto IL_05c2;
		IL_059b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC96CC");
		if (obj44 != null)
		{
			goto IL_05c2;
		}
		return;
		IL_04e4:
		object obj46 = (nint)0 + (nint)1024;
		IEnumerable<object> source = default(IEnumerable<object>);
		obj44 = Enumerable.FirstOrDefault(source, predicate);
		bool flag11 = obj44 == null;
		object obj47 = !flag11;
		if (obj47 == null)
		{
			object obj48 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v21+E4]");
			object obj49;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v21+B8]");
				obj49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v21+30]");
				object obj50 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v21+30]");
				if ((nint)0 != 0)
				{
					goto IL_059b;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj48 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v21+B8]");
				obj49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v21+30]");
				object obj50 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v21+30]");
				bool flag12 = (nint)0 == 0;
				object obj51 = !flag12;
				if (obj51 != null)
				{
					goto IL_059b;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v21+E4]");
			bool flag13 = (nint)0 == 0;
			object obj52 = !flag13;
			if (obj52 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj53 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v27+B8]");
				obj49 = 0;
			}
			object obj54 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2384;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj55 = (nint)0 + (nint)1856;
			Func<object, bool> func5 = default(Func<object, bool>);
			func5..ctor(obj49, (IntPtr)obj55);
			object obj56 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v26+B8]");
			object obj57 = (nint)0 + (nint)48;
			obj57 = func5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC96CC");
			bool flag14 = obj44 == null;
			object obj58 = !flag14;
			if (obj58 == null)
			{
				return;
			}
		}
		goto IL_05c2;
		IL_0242:
		obj43 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC96CC");
		bool flag15 = obj44 == null;
		object obj59 = !flag15;
		if (obj59 == null)
		{
			func4 = func2;
			goto IL_03a9;
		}
		goto IL_05c2;
	}
}
