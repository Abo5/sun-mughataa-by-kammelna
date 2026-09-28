using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Cpp2ILInjected;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public static class InputUtil
{
	public enum NavDirection
	{
		None,
		Up,
		Down,
		Left,
		Right
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<TouchControl, bool> <>9__15_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_ActiveTouchCount>b__15_0(TouchControl t)
		{
			//IL_0064: Expected I4, but got O
			if (t != null && t.<press>k__BackingField != null)
			{
				return t.<press>k__BackingField.isPressed;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public static Vector2 PointerPosition
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0161: Expected O, but got I4
			//IL_008a: Expected O, but got I
			//IL_01c5: Expected I4, but got O
			//IL_01e7: Expected O, but got I4
			//IL_018f: Expected O, but got I
			//IL_01a9: Expected O, but got I4
			//IL_00ec: Expected O, but got I
			//IL_00fc: Expected O, but got I
			//IL_011e: Expected O, but got I4
			//IL_00af: Expected I4, but got O
			//IL_0264: Expected O, but got I
			//IL_020f: Expected I4, but got O
			//IL_021f: Expected O, but got I
			//IL_022f: Expected O, but got I
			//IL_0330: Unknown result type (might be due to invalid IL or missing references)
			//IL_0335: Expected O, but got Unknown
			//IL_03a5: Expected O, but got I
			//IL_02bf: Expected O, but got I
			//IL_03cf: Expected O, but got I4
			//IL_02ec: Expected O, but got I
			//IL_030e: Expected O, but got I4
			//IL_0371: Expected O, but got I
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1448;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F0B]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v26+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v26+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458C]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				goto IL_00a7;
			}
			goto IL_01b7;
			IL_033a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v3+188]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v3+188]");
				return ((InputControl<Vector2>)0).ReadValue();
			}
			goto IL_037f;
			IL_037f:
			return (Vector2)new NullReferenceException();
			IL_0321:
			object obj7 = typeof(MemberAchievementClanFeedData) + 1536;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v9+B8]");
			object obj9 = 0;
			object obj10 = obj9;
			if (obj9 != null)
			{
				goto IL_033a;
			}
			bool flag3;
			return (Vector2)flag3;
			IL_0074:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458C]");
			object obj11 = (nint)0 & (nint)1;
			if (obj11 != null)
			{
				goto IL_00a7;
			}
			goto IL_01b7;
			IL_01b7:
			_ = 1;
			flag3 = (byte)(int)obj != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v7 (System.Boolean)+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			bool flag5 = flag3;
			if (obj12 != null)
			{
				goto IL_00dc;
			}
			goto IL_01fd;
			IL_00a7:
			flag3 = (byte)(int)obj != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v7 (System.Boolean)+E4]");
			bool flag6 = (nint)0 == 0;
			flag5 = flag3;
			if (!flag6)
			{
				goto IL_00dc;
			}
			goto IL_01fd;
			IL_01fd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			flag3 = (byte)(int)obj != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v7 (System.Boolean)+B8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v22+10]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v22+10]");
			if ((nint)0 != 0)
			{
				goto IL_0254;
			}
			goto IL_0321;
			IL_00dc:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v7 (System.Boolean)+B8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v31+10]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v31+10]");
			bool flag7 = (nint)0 == 0;
			object obj16 = !flag7;
			if (obj16 != null)
			{
				goto IL_0254;
			}
			goto IL_0321;
			IL_0254:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X19_v10+1B8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X19_v10+1B8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v19+170]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v19+170]");
					flag3 = ((ButtonControl)0).isPressed;
					if (!flag3)
					{
						goto IL_0321;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X19_v10+1B8]");
					obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X19_v10+1B8]");
					bool flag8 = (nint)0 == 0;
					object obj18 = !flag8;
					if (obj18 != null)
					{
						goto IL_033a;
					}
				}
			}
			goto IL_037f;
		}
	}

	public static bool PointerHeld
	{
		get
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
			//IL_0618: Expected I4, but got O
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Expected O, but got Unknown
			//IL_01a8: Expected O, but got I
			//IL_03c9: Expected O, but got I
			//IL_03e3: Expected O, but got I4
			//IL_03ec: Expected O, but got I4
			//IL_03f5: Expected O, but got I4
			//IL_0226: Expected O, but got I
			//IL_023e: Expected O, but got I4
			//IL_0247: Expected O, but got I4
			//IL_0473: Expected O, but got I
			//IL_0495: Expected O, but got I4
			//IL_0433: Expected O, but got I4
			//IL_02a2: Expected O, but got I
			//IL_04d1: Expected O, but got I
			//IL_04eb: Expected O, but got I4
			//IL_0302: Expected O, but got I
			//IL_0561: Expected O, but got I
			//IL_0571: Expected O, but got I
			//IL_0529: Expected O, but got I4
			//IL_0364: Expected O, but got I
			//IL_0374: Expected O, but got I
			//IL_0396: Expected O, but got I4
			//IL_05a6: Expected O, but got I
			//IL_0601: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F0C]");
			object obj = (nint)0 & (nint)1;
			object obj2;
			object obj4;
			if (obj != null)
			{
				obj2 = typeof(MemberAchievementClanFeedData) + 1536;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458D]");
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
				obj2 = typeof(MemberAchievementClanFeedData) + 1536;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458D]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v39+B8]");
			object obj8 = 0;
			object obj9 = obj8;
			if (obj8 != null)
			{
				goto IL_0172;
			}
			goto IL_01cf;
			IL_02c7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v16+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458C]");
				object obj10 = (nint)0 & (nint)1;
				if (obj10 != null)
				{
					goto IL_031f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X20_v8+58C]");
				object obj11 = (nint)0 & (nint)1;
				bool flag3 = obj11 == null;
				object obj12 = !flag3;
				if (obj12 != null)
				{
					goto IL_031f;
				}
			}
			_ = 1;
			object obj14;
			object obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v29+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			object obj16 = obj13;
			if (obj15 != null)
			{
				goto IL_0354;
			}
			goto IL_053f;
			IL_04ab:
			return false;
			IL_0292:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v16+B8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v31+10]");
			if ((nint)0 != 0)
			{
				goto IL_02c7;
			}
			goto IL_04ab;
			IL_0082:
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v45+B8]");
			object obj19 = 0;
			obj9 = obj19;
			bool flag5 = obj19 == null;
			object obj20 = !flag5;
			if (obj20 != null)
			{
				goto IL_0172;
			}
			goto IL_01cf;
			IL_0172:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v36+1C0]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v36+1C0]");
				if (((ButtonControl)0).isPressed)
				{
					return true;
				}
				goto IL_01cf;
			}
			goto IL_060a;
			IL_060a:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0596:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v15+1B8]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v15+1B8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v16+170]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v16+170]");
					return ((ButtonControl)0).isPressed;
				}
			}
			goto IL_060a;
			IL_01cf:
			obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1448;
			object obj22 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v4+E4]");
			object obj25;
			object obj24;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458C]");
				object obj23 = (nint)0 & (nint)1;
				bool flag6 = obj23 == null;
				obj24 = 146685952;
				obj25 = 146685952;
				if (!flag6)
				{
					goto IL_0255;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458C]");
				object obj26 = (nint)0 & (nint)1;
				bool flag7 = obj26 == null;
				object obj27 = !flag7;
				obj24 = 146685952;
				obj25 = 146685952;
				if (obj27 != null)
				{
					goto IL_0255;
				}
			}
			_ = 1;
			object obj28 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v16+E4]");
			bool flag8 = (nint)0 == 0;
			object obj29 = !flag8;
			obj24 = obj25;
			object obj30 = obj28;
			if (obj29 != null)
			{
				goto IL_0292;
			}
			goto IL_0451;
			IL_053f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj31 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v22+B8]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v18+10]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v18+10]");
			if ((nint)0 != 0)
			{
				goto IL_0596;
			}
			goto IL_060a;
			IL_031f:
			obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v29+E4]");
			bool flag9 = (nint)0 == 0;
			obj16 = obj13;
			if (!flag9)
			{
				goto IL_0354;
			}
			goto IL_053f;
			IL_0354:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v29+B8]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v25+10]");
			obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v25+10]");
			bool flag10 = (nint)0 == 0;
			object obj35 = !flag10;
			if (obj35 != null)
			{
				goto IL_0596;
			}
			goto IL_060a;
			IL_0255:
			obj28 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v16+E4]");
			bool flag11 = (nint)0 == 0;
			obj30 = obj28;
			obj25 = obj24;
			if (!flag11)
			{
				goto IL_0292;
			}
			goto IL_0451;
			IL_0451:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj28 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v16+B8]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v7+10]");
			bool flag12 = (nint)0 == 0;
			object obj37 = !flag12;
			obj24 = obj25;
			if (obj37 != null)
			{
				goto IL_02c7;
			}
			goto IL_04ab;
		}
	}

	public static bool PointerPressedThisFrame
	{
		get
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
			//IL_0618: Expected I4, but got O
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Expected O, but got Unknown
			//IL_01a8: Expected O, but got I
			//IL_03c9: Expected O, but got I
			//IL_03e3: Expected O, but got I4
			//IL_03ec: Expected O, but got I4
			//IL_03f5: Expected O, but got I4
			//IL_0226: Expected O, but got I
			//IL_023e: Expected O, but got I4
			//IL_0247: Expected O, but got I4
			//IL_0473: Expected O, but got I
			//IL_0495: Expected O, but got I4
			//IL_0433: Expected O, but got I4
			//IL_02a2: Expected O, but got I
			//IL_04d1: Expected O, but got I
			//IL_04eb: Expected O, but got I4
			//IL_0302: Expected O, but got I
			//IL_0561: Expected O, but got I
			//IL_0571: Expected O, but got I
			//IL_0529: Expected O, but got I4
			//IL_0364: Expected O, but got I
			//IL_0374: Expected O, but got I
			//IL_0396: Expected O, but got I4
			//IL_05a6: Expected O, but got I
			//IL_0601: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F0D]");
			object obj = (nint)0 & (nint)1;
			object obj2;
			object obj4;
			if (obj != null)
			{
				obj2 = typeof(MemberAchievementClanFeedData) + 1536;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458D]");
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
				obj2 = typeof(MemberAchievementClanFeedData) + 1536;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458D]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v39+B8]");
			object obj8 = 0;
			object obj9 = obj8;
			if (obj8 != null)
			{
				goto IL_0172;
			}
			goto IL_01cf;
			IL_02c7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v16+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458C]");
				object obj10 = (nint)0 & (nint)1;
				if (obj10 != null)
				{
					goto IL_031f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X20_v8+58C]");
				object obj11 = (nint)0 & (nint)1;
				bool flag3 = obj11 == null;
				object obj12 = !flag3;
				if (obj12 != null)
				{
					goto IL_031f;
				}
			}
			_ = 1;
			object obj14;
			object obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v29+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			object obj16 = obj13;
			if (obj15 != null)
			{
				goto IL_0354;
			}
			goto IL_053f;
			IL_04ab:
			return false;
			IL_0292:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v16+B8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v31+10]");
			if ((nint)0 != 0)
			{
				goto IL_02c7;
			}
			goto IL_04ab;
			IL_0082:
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v45+B8]");
			object obj19 = 0;
			obj9 = obj19;
			bool flag5 = obj19 == null;
			object obj20 = !flag5;
			if (obj20 != null)
			{
				goto IL_0172;
			}
			goto IL_01cf;
			IL_0172:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v36+1C0]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v36+1C0]");
				if (((ButtonControl)0).wasPressedThisFrame)
				{
					return true;
				}
				goto IL_01cf;
			}
			goto IL_060a;
			IL_060a:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0596:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v15+1B8]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v15+1B8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v16+170]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v16+170]");
					return ((ButtonControl)0).wasPressedThisFrame;
				}
			}
			goto IL_060a;
			IL_01cf:
			obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1448;
			object obj22 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v4+E4]");
			object obj25;
			object obj24;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458C]");
				object obj23 = (nint)0 & (nint)1;
				bool flag6 = obj23 == null;
				obj24 = 146685952;
				obj25 = 146685952;
				if (!flag6)
				{
					goto IL_0255;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458C]");
				object obj26 = (nint)0 & (nint)1;
				bool flag7 = obj26 == null;
				object obj27 = !flag7;
				obj24 = 146685952;
				obj25 = 146685952;
				if (obj27 != null)
				{
					goto IL_0255;
				}
			}
			_ = 1;
			object obj28 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v16+E4]");
			bool flag8 = (nint)0 == 0;
			object obj29 = !flag8;
			obj24 = obj25;
			object obj30 = obj28;
			if (obj29 != null)
			{
				goto IL_0292;
			}
			goto IL_0451;
			IL_053f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj31 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v22+B8]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v18+10]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v18+10]");
			if ((nint)0 != 0)
			{
				goto IL_0596;
			}
			goto IL_060a;
			IL_031f:
			obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v29+E4]");
			bool flag9 = (nint)0 == 0;
			obj16 = obj13;
			if (!flag9)
			{
				goto IL_0354;
			}
			goto IL_053f;
			IL_0354:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v29+B8]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v25+10]");
			obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v25+10]");
			bool flag10 = (nint)0 == 0;
			object obj35 = !flag10;
			if (obj35 != null)
			{
				goto IL_0596;
			}
			goto IL_060a;
			IL_0255:
			obj28 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v16+E4]");
			bool flag11 = (nint)0 == 0;
			obj30 = obj28;
			obj25 = obj24;
			if (!flag11)
			{
				goto IL_0292;
			}
			goto IL_0451;
			IL_0451:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj28 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v16+B8]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v7+10]");
			bool flag12 = (nint)0 == 0;
			object obj37 = !flag12;
			obj24 = obj25;
			if (obj37 != null)
			{
				goto IL_02c7;
			}
			goto IL_04ab;
		}
	}

	public static bool PointerReleasedThisFrame
	{
		get
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
			//IL_0618: Expected I4, but got O
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Expected O, but got Unknown
			//IL_01a8: Expected O, but got I
			//IL_03c9: Expected O, but got I
			//IL_03e3: Expected O, but got I4
			//IL_03ec: Expected O, but got I4
			//IL_03f5: Expected O, but got I4
			//IL_0226: Expected O, but got I
			//IL_023e: Expected O, but got I4
			//IL_0247: Expected O, but got I4
			//IL_0473: Expected O, but got I
			//IL_0495: Expected O, but got I4
			//IL_0433: Expected O, but got I4
			//IL_02a2: Expected O, but got I
			//IL_04d1: Expected O, but got I
			//IL_04eb: Expected O, but got I4
			//IL_0302: Expected O, but got I
			//IL_0561: Expected O, but got I
			//IL_0571: Expected O, but got I
			//IL_0529: Expected O, but got I4
			//IL_0364: Expected O, but got I
			//IL_0374: Expected O, but got I
			//IL_0396: Expected O, but got I4
			//IL_05a6: Expected O, but got I
			//IL_0601: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F0E]");
			object obj = (nint)0 & (nint)1;
			object obj2;
			object obj4;
			if (obj != null)
			{
				obj2 = typeof(MemberAchievementClanFeedData) + 1536;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458D]");
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
				obj2 = typeof(MemberAchievementClanFeedData) + 1536;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458D]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v39+B8]");
			object obj8 = 0;
			object obj9 = obj8;
			if (obj8 != null)
			{
				goto IL_0172;
			}
			goto IL_01cf;
			IL_02c7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v16+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458C]");
				object obj10 = (nint)0 & (nint)1;
				if (obj10 != null)
				{
					goto IL_031f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X20_v8+58C]");
				object obj11 = (nint)0 & (nint)1;
				bool flag3 = obj11 == null;
				object obj12 = !flag3;
				if (obj12 != null)
				{
					goto IL_031f;
				}
			}
			_ = 1;
			object obj14;
			object obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v29+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			object obj16 = obj13;
			if (obj15 != null)
			{
				goto IL_0354;
			}
			goto IL_053f;
			IL_04ab:
			return false;
			IL_0292:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v16+B8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v31+10]");
			if ((nint)0 != 0)
			{
				goto IL_02c7;
			}
			goto IL_04ab;
			IL_0082:
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v45+B8]");
			object obj19 = 0;
			obj9 = obj19;
			bool flag5 = obj19 == null;
			object obj20 = !flag5;
			if (obj20 != null)
			{
				goto IL_0172;
			}
			goto IL_01cf;
			IL_0172:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v36+1C0]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v36+1C0]");
				if (((ButtonControl)0).wasReleasedThisFrame)
				{
					return true;
				}
				goto IL_01cf;
			}
			goto IL_060a;
			IL_060a:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0596:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v15+1B8]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v15+1B8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v16+170]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v16+170]");
					return ((ButtonControl)0).wasReleasedThisFrame;
				}
			}
			goto IL_060a;
			IL_01cf:
			obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1448;
			object obj22 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v4+E4]");
			object obj25;
			object obj24;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458C]");
				object obj23 = (nint)0 & (nint)1;
				bool flag6 = obj23 == null;
				obj24 = 146685952;
				obj25 = 146685952;
				if (!flag6)
				{
					goto IL_0255;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458C]");
				object obj26 = (nint)0 & (nint)1;
				bool flag7 = obj26 == null;
				object obj27 = !flag7;
				obj24 = 146685952;
				obj25 = 146685952;
				if (obj27 != null)
				{
					goto IL_0255;
				}
			}
			_ = 1;
			object obj28 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v16+E4]");
			bool flag8 = (nint)0 == 0;
			object obj29 = !flag8;
			obj24 = obj25;
			object obj30 = obj28;
			if (obj29 != null)
			{
				goto IL_0292;
			}
			goto IL_0451;
			IL_053f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj31 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v22+B8]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v18+10]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v18+10]");
			if ((nint)0 != 0)
			{
				goto IL_0596;
			}
			goto IL_060a;
			IL_031f:
			obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v29+E4]");
			bool flag9 = (nint)0 == 0;
			obj16 = obj13;
			if (!flag9)
			{
				goto IL_0354;
			}
			goto IL_053f;
			IL_0354:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v29+B8]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v25+10]");
			obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v25+10]");
			bool flag10 = (nint)0 == 0;
			object obj35 = !flag10;
			if (obj35 != null)
			{
				goto IL_0596;
			}
			goto IL_060a;
			IL_0255:
			obj28 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v16+E4]");
			bool flag11 = (nint)0 == 0;
			obj30 = obj28;
			obj25 = obj24;
			if (!flag11)
			{
				goto IL_0292;
			}
			goto IL_0451;
			IL_0451:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj28 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v16+B8]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v7+10]");
			bool flag12 = (nint)0 == 0;
			object obj37 = !flag12;
			obj24 = obj25;
			if (obj37 != null)
			{
				goto IL_02c7;
			}
			goto IL_04ab;
		}
	}

	public static bool HasMouse
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 1536;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object obj3 = 0;
			bool flag = obj3 == null;
			return !flag;
		}
	}

	public static Vector2 ScrollDelta
	{
		get
		{
			//IL_0016: Expected O, but got I
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected O, but got Unknown
			//IL_013b: Expected O, but got I
			//IL_0155: Expected O, but got I4
			//IL_009a: Expected O, but got I
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_005d: Expected O, but got I
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Expected I, but got Unknown
			//IL_019d: Expected O, but got I
			//IL_01bf: Expected O, but got I4
			//IL_01e5: Expected O, but got I
			//IL_00f6: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F0F]");
			object obj = (nint)0 & (nint)1;
			object obj2;
			object obj4;
			nint num = default(nint);
			if (obj != null)
			{
				obj2 = typeof(MemberAchievementClanFeedData) + 1536;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458D]");
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
				num = (nint)0 + (nint)3328;
				_ = 1;
				obj2 = typeof(MemberAchievementClanFeedData) + 1536;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458D]");
				object obj5 = (nint)0 & (nint)1;
				bool flag2 = obj5 == null;
				object obj6 = !flag2;
				obj4 = obj2;
				if (obj6 != null)
				{
					goto IL_0082;
				}
			}
			num = (nint)(typeof(MemberAchievementClanFeedData) + 1536);
			_ = 1;
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v10+B8]");
			object obj8 = 0;
			object obj9 = obj8;
			bool flag3 = obj8 == null;
			object obj10 = !flag3;
			if (obj10 != null)
			{
				goto IL_00bf;
			}
			goto IL_01e0;
			IL_00bf:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v15+1B8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v15+1B8]");
				return ((InputControl<Vector2>)0).ReadValue();
			}
			return (Vector2)new NullReferenceException();
			IL_01e0:
			return (Vector2)num;
			IL_0082:
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v19+B8]");
			object obj12 = 0;
			obj9 = obj12;
			if (obj12 != null)
			{
				goto IL_00bf;
			}
			goto IL_01e0;
		}
	}

	public static int PrimaryTouchId
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_023d: Expected O, but got I4
			//IL_008a: Expected O, but got I
			//IL_00a2: Expected O, but got I4
			//IL_00ab: Expected O, but got I4
			//IL_02d5: Expected O, but got I4
			//IL_026b: Expected O, but got I
			//IL_0285: Expected O, but got I4
			//IL_028e: Expected O, but got I4
			//IL_0297: Expected O, but got I4
			//IL_0106: Expected O, but got I
			//IL_0357: Expected I4, but got I8
			//IL_0315: Expected O, but got I
			//IL_0337: Expected O, but got I4
			//IL_0377: Expected O, but got I
			//IL_0391: Expected O, but got I4
			//IL_0166: Expected O, but got I
			//IL_0407: Expected O, but got I
			//IL_0417: Expected O, but got I
			//IL_03cf: Expected O, but got I4
			//IL_04bf: Expected I4, but got O
			//IL_01c8: Expected O, but got I
			//IL_01d8: Expected O, but got I
			//IL_01fa: Expected O, but got I4
			//IL_044c: Expected O, but got I
			//IL_04a8: Expected O, but got I
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1448;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F10]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458C]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			object obj7 = 146685952;
			object obj8 = 146685952;
			if (obj6 != null)
			{
				goto IL_00b9;
			}
			goto IL_02a5;
			IL_03e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v28+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v21+10]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v21+10]");
			if ((nint)0 != 0)
			{
				goto IL_043c;
			}
			goto IL_04b1;
			IL_0183:
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v35+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = obj12;
			if (!flag3)
			{
				goto IL_01b8;
			}
			goto IL_03e5;
			IL_01b8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v35+B8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v28+10]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v28+10]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 != null)
			{
				goto IL_043c;
			}
			goto IL_04b1;
			IL_0074:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458C]");
			object obj16 = (nint)0 & (nint)1;
			bool flag5 = obj16 == null;
			obj7 = 146685952;
			obj8 = 146685952;
			if (!flag5)
			{
				goto IL_00b9;
			}
			goto IL_02a5;
			IL_02a5:
			_ = 1;
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v20+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			obj7 = obj8;
			object obj19 = obj17;
			if (obj18 != null)
			{
				goto IL_00f6;
			}
			goto IL_02f3;
			IL_00b9:
			obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v20+E4]");
			bool flag7 = (nint)0 == 0;
			obj19 = obj17;
			obj8 = obj7;
			if (!flag7)
			{
				goto IL_00f6;
			}
			goto IL_02f3;
			IL_02f3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v20+B8]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v4+10]");
			bool flag8 = (nint)0 == 0;
			object obj21 = !flag8;
			obj7 = obj8;
			if (obj21 != null)
			{
				goto IL_012b;
			}
			goto IL_034d;
			IL_00f6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v20+B8]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v34+10]");
			if ((nint)0 != 0)
			{
				goto IL_012b;
			}
			goto IL_034d;
			IL_034d:
			return -1;
			IL_012b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v20+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458C]");
				object obj23 = (nint)0 & (nint)1;
				if (obj23 != null)
				{
					goto IL_0183;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X20_v7+58C]");
				object obj24 = (nint)0 & (nint)1;
				bool flag9 = obj24 == null;
				object obj25 = !flag9;
				if (obj25 != null)
				{
					goto IL_0183;
				}
			}
			_ = 1;
			obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v35+E4]");
			bool flag10 = (nint)0 == 0;
			object obj26 = !flag10;
			obj13 = obj12;
			if (obj26 != null)
			{
				goto IL_01b8;
			}
			goto IL_03e5;
			IL_04b1:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_043c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v16+1B8]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v16+1B8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v17+180]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v17+180]");
					return ((InputControl<int>)0).ReadValue();
				}
			}
			goto IL_04b1;
		}
	}

	public static int ActiveTouchCount
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0222: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_02a8: Expected O, but got I4
			//IL_0250: Expected O, but got I
			//IL_026a: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_0105: Expected O, but got I
			//IL_02e0: Expected O, but got I
			//IL_02f0: Expected O, but got I
			//IL_0312: Expected O, but got I4
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Expected O, but got Unknown
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Expected O, but got Unknown
			//IL_0344: Expected O, but got I
			//IL_0354: Expected O, but got I
			//IL_0364: Expected O, but got I
			//IL_0386: Expected O, but got I4
			//IL_0195: Expected O, but got I
			//IL_01a5: Expected O, but got I
			//IL_01b5: Expected O, but got I
			//IL_01d7: Expected O, but got I4
			//IL_03be: Expected O, but got I4
			//IL_0409: Expected O, but got I
			//IL_0418: Unknown result type (might be due to invalid IL or missing references)
			//IL_041d: Expected O, but got Unknown
			//IL_0433: Expected O, but got I
			//IL_0444: Expected I, but got O
			//IL_0462: Expected O, but got I
			object obj = 152981504;
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1448;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F11]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458C]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_0278;
			IL_03e3:
			IEnumerable<object> source = default(IEnumerable<object>);
			Func<object, bool> predicate;
			return Enumerable.Count(source, predicate);
			IL_039c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v40+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			object obj10;
			object obj9;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj10;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v40+B8]");
			object obj11 = 0;
			object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)928;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj11, (IntPtr)obj13);
			object obj14 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v23+B8]");
			object obj15 = (nint)0 + (nint)8;
			obj15 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj17;
			object obj16 = obj17;
			predicate = func;
			goto IL_03e3;
			IL_012a:
			object obj18 = typeof(Queue<string>) + 192;
			obj10 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v40+E4]");
			if ((nint)0 != 0)
			{
				obj16 = (nint)0 + (nint)3616;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v40+B8]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v25+8]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v25+8]");
				bool flag4 = (nint)0 == 0;
				object obj20 = !flag4;
				if (obj20 == null)
				{
					obj17 = obj16;
					goto IL_039c;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj10;
				obj17 = (nint)0 + (nint)3616;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v40+B8]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v24+8]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v24+8]");
				bool flag5 = (nint)0 == 0;
				object obj22 = !flag5;
				obj16 = obj17;
				if (obj22 == null)
				{
					goto IL_039c;
				}
			}
			goto IL_03e3;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458C]");
			object obj23 = (nint)0 & (nint)1;
			if (obj23 != null)
			{
				goto IL_00b0;
			}
			goto IL_0278;
			IL_0278:
			_ = 1;
			object obj24 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v50+E4]");
			bool flag6 = (nint)0 == 0;
			object obj25 = !flag6;
			object obj26 = obj24;
			if (obj25 != null)
			{
				goto IL_00e5;
			}
			goto IL_02be;
			IL_00b0:
			obj24 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v50+E4]");
			bool flag7 = (nint)0 == 0;
			obj26 = obj24;
			if (!flag7)
			{
				goto IL_00e5;
			}
			goto IL_02be;
			IL_02be:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj27 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v5+B8]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v4+10]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v4+10]");
			bool flag8 = (nint)0 == 0;
			object obj30 = !flag8;
			if (obj30 != null)
			{
				goto IL_012a;
			}
			goto IL_0320;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v50+B8]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v27+10]");
			obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v27+10]");
			if ((nint)0 != 0)
			{
				goto IL_012a;
			}
			goto IL_0320;
			IL_0320:
			return 0;
		}
	}

	public static bool SubmitPressedThisFrame
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_01d0: Expected O, but got I
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_020d: Expected O, but got I
			//IL_0242: Expected O, but got I
			//IL_01b8: Expected I4, but got O
			//IL_0277: Expected O, but got I
			//IL_028e: Expected I4, but got O
			//IL_004f: Expected O, but got I
			//IL_006d: Expected O, but got I4
			//IL_00ea: Expected O, but got I4
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2224;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object obj3 = 0;
			object obj4 = obj3;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+198]");
				if ((nint)0 == 0)
				{
					goto IL_01aa;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+198]");
				bool wasPressedThisFrame = ((ButtonControl)0).wasPressedThisFrame;
				bool flag = !wasPressedThisFrame;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_0156;
				}
			}
			object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1328;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v11+B8]");
			object obj8 = 0;
			if (obj8 != null)
			{
				KeyControl keyControl = ((Keyboard)obj8).get_Item(Key.Enter);
				if (keyControl == null)
				{
					goto IL_01aa;
				}
				bool wasPressedThisFrame2 = keyControl.wasPressedThisFrame;
				bool flag2 = !wasPressedThisFrame2;
				object obj9 = !flag2;
				if (obj9 != null)
				{
					goto IL_0156;
				}
			}
			object obj10 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v14+B8]");
			object obj11 = 0;
			if (obj11 != null)
			{
				KeyControl keyControl2 = ((Keyboard)obj11).get_Item(Key.NumpadEnter);
				if (keyControl2 == null)
				{
					goto IL_01aa;
				}
				if (keyControl2.wasPressedThisFrame)
				{
					goto IL_0156;
				}
			}
			object obj12 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v17+B8]");
			object obj13 = 0;
			bool flag3 = obj13 == null;
			bool result = (byte)(int)obj13 != 0;
			if (!flag3)
			{
				KeyControl keyControl3 = ((Keyboard)obj13).get_Item(Key.Space);
				if (keyControl3 != null)
				{
					return keyControl3.wasPressedThisFrame;
				}
				goto IL_01aa;
			}
			goto IL_029c;
			IL_0156:
			result = true;
			goto IL_029c;
			IL_01aa:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_029c:
			return result;
		}
	}

	public static bool CancelPressedThisFrame
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_016a: Expected O, but got I
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected O, but got Unknown
			//IL_01e4: Expected O, but got I
			//IL_01fb: Expected I4, but got O
			//IL_0152: Expected I4, but got O
			//IL_004f: Expected O, but got I
			//IL_006d: Expected O, but got I4
			//IL_01a7: Expected O, but got I
			//IL_00b6: Expected O, but got I
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2224;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object obj3 = 0;
			object obj4 = obj3;
			if (obj3 == null)
			{
				goto IL_00e5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+1A0]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+1A0]");
				bool wasPressedThisFrame = ((ButtonControl)0).wasPressedThisFrame;
				bool flag = !wasPressedThisFrame;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_00d7;
				}
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v17+B8]");
				object obj7 = 0;
				object obj8 = obj7;
				if (obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v19+1B8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v19+1B8]");
						if (((ButtonControl)0).wasPressedThisFrame)
						{
							goto IL_00d7;
						}
						goto IL_00e5;
					}
				}
			}
			goto IL_0144;
			IL_013f:
			bool result;
			return result;
			IL_00e5:
			object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1328;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v11+B8]");
			object obj11 = 0;
			bool flag2 = obj11 == null;
			result = (byte)(int)obj11 != 0;
			if (flag2)
			{
				goto IL_013f;
			}
			KeyControl keyControl = ((Keyboard)obj11).get_Item(Key.Escape);
			if (keyControl != null)
			{
				return keyControl.wasPressedThisFrame;
			}
			goto IL_0144;
			IL_00d7:
			result = true;
			goto IL_013f;
			IL_0144:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public static bool HasGamepad
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2224;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object obj3 = 0;
			bool flag = obj3 == null;
			return !flag;
		}
	}

	public static NavDirection NavPressedThisFrame
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0679: Expected O, but got I
			//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bd: Expected O, but got Unknown
			//IL_06b6: Expected O, but got I
			//IL_0029: Expected O, but got I
			//IL_06eb: Expected O, but got I
			//IL_0661: Expected I4, but got O
			//IL_0720: Expected O, but got I
			//IL_0755: Expected O, but got I
			//IL_0084: Expected O, but got I
			//IL_00bb: Expected O, but got I
			//IL_0116: Expected O, but got I
			//IL_014d: Expected O, but got I
			//IL_01a8: Expected O, but got I
			//IL_01df: Expected O, but got I
			//IL_023a: Expected O, but got I
			//IL_0271: Expected O, but got I
			//IL_02cc: Expected O, but got I
			//IL_0303: Expected O, but got I
			//IL_035e: Expected O, but got I
			//IL_0395: Expected O, but got I
			//IL_03f0: Expected O, but got I
			//IL_0427: Expected O, but got I
			//IL_0482: Expected O, but got I
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2224;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object obj3 = 0;
			object obj4 = obj3;
			if (obj3 == null)
			{
				goto IL_04a9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X19_v2+1C8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X19_v2+1C8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v27+120]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v27+120]");
					if (((ButtonControl)0).wasPressedThisFrame)
					{
						return NavDirection.Up;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X19_v2+1E0]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X19_v2+1E0]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v28+120]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v28+120]");
							if (((ButtonControl)0).wasPressedThisFrame)
							{
								return NavDirection.Up;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X19_v2+1C8]");
							object obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X19_v2+1C8]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v29+128]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v29+128]");
									if (((ButtonControl)0).wasPressedThisFrame)
									{
										return NavDirection.Down;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X19_v2+1E0]");
									object obj8 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X19_v2+1E0]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v30+128]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v30+128]");
											if (((ButtonControl)0).wasPressedThisFrame)
											{
												return NavDirection.Down;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X19_v2+1C8]");
											object obj9 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X19_v2+1C8]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v31+130]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v31+130]");
													if (((ButtonControl)0).wasPressedThisFrame)
													{
														return NavDirection.Left;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X19_v2+1E0]");
													object obj10 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X19_v2+1E0]");
													if ((nint)0 != 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v32+130]");
														if ((nint)0 != 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v32+130]");
															if (((ButtonControl)0).wasPressedThisFrame)
															{
																return NavDirection.Left;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X19_v2+1C8]");
															object obj11 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X19_v2+1C8]");
															if ((nint)0 != 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v33+138]");
																if ((nint)0 != 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v33+138]");
																	if (((ButtonControl)0).wasPressedThisFrame)
																	{
																		return NavDirection.Right;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X19_v2+1E0]");
																	object obj12 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X19_v2+1E0]");
																	if ((nint)0 != 0)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v34+138]");
																		if ((nint)0 != 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v34+138]");
																			if (((ButtonControl)0).wasPressedThisFrame)
																			{
																				return NavDirection.Right;
																			}
																			goto IL_04a9;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			goto IL_0653;
			IL_0653:
			NullReferenceException ex = new NullReferenceException();
			return (NavDirection)ex;
			IL_04a9:
			object obj13 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1328;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v9+B8]");
			object obj15 = 0;
			if (obj15 != null)
			{
				KeyControl keyControl = ((Keyboard)obj15).get_Item(Key.UpArrow);
				if (keyControl == null)
				{
					goto IL_0653;
				}
				if (keyControl.wasPressedThisFrame)
				{
					return NavDirection.Up;
				}
			}
			object obj16 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v12+B8]");
			object obj17 = 0;
			if (obj17 != null)
			{
				KeyControl keyControl2 = ((Keyboard)obj17).get_Item(Key.DownArrow);
				if (keyControl2 == null)
				{
					goto IL_0653;
				}
				if (keyControl2.wasPressedThisFrame)
				{
					return NavDirection.Down;
				}
			}
			object obj18 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v15+B8]");
			object obj19 = 0;
			if (obj19 != null)
			{
				KeyControl keyControl3 = ((Keyboard)obj19).get_Item(Key.LeftArrow);
				if (keyControl3 == null)
				{
					goto IL_0653;
				}
				if (keyControl3.wasPressedThisFrame)
				{
					return NavDirection.Left;
				}
			}
			object obj20 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v18+B8]");
			object obj21 = 0;
			if (obj21 != null)
			{
				KeyControl keyControl4 = ((Keyboard)obj21).get_Item(Key.RightArrow);
				if (keyControl4 == null)
				{
					goto IL_0653;
				}
				if (keyControl4.wasPressedThisFrame)
				{
					return NavDirection.Right;
				}
			}
			return NavDirection.None;
		}
	}

	public static bool KeyPressedThisFrame(Key key)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0084: Expected O, but got I
		//IL_008d: Expected I4, but got O
		//IL_005e: Expected I4, but got O
		//IL_006c: Expected I4, but got O
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1328;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
		object obj3 = 0;
		if ((int)(~obj3) == 0)
		{
			KeyControl keyControl = ((Keyboard)obj3).get_Item(key);
			if (keyControl != null)
			{
				return keyControl.wasPressedThisFrame;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		return (byte)(int)obj3 != 0;
	}

	public static void EnableGyroscope()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0143: Expected O, but got I
		//IL_015d: Expected O, but got I4
		//IL_00a3: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0191: Expected O, but got I
		//IL_01b3: Expected O, but got I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		object obj = 152981504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F12]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3488;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458F]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3488;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458F]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v5+B8]");
		object obj9 = 0;
		InputDevice device = (InputDevice)obj9;
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			return;
		}
		goto IL_00c8;
		IL_00c8:
		object obj11 = typeof(System.IOAsyncCallback) + 3120;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			InputSystem.EnableDevice(device);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		InputSystem.EnableDevice(device);
		return;
		IL_008b:
		object obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v14+B8]");
		object obj14 = 0;
		device = (InputDevice)obj14;
		if (obj14 != null)
		{
			goto IL_00c8;
		}
	}

	public unsafe static bool TryReadGyroAngularVelocity(out Vector3 angularVelocity)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0140: Expected O, but got I
		//IL_015a: Expected O, but got I4
		//IL_00a3: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_018e: Expected O, but got I
		//IL_01b0: Expected O, but got I4
		//IL_0246: Expected O, but got I
		//IL_01ed: Expected I4, but got O
		//IL_0107: Expected O, but got I
		object obj = 152981504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F13]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3488;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458F]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3488;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458F]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v11+B8]");
		object obj9 = 0;
		object obj10 = obj9;
		bool flag3 = obj9 == null;
		object obj11 = !flag3;
		object obj12 = obj9;
		if (obj11 != null)
		{
			goto IL_00d0;
		}
		goto IL_01c6;
		IL_01ed:
		bool flag4 = obj10 == null;
		bool result = !flag4;
		object obj13 = default(object);
		ref Vector3 reference = ref *(Vector3*)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v7+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v7+8]");
		_ = 0;
		return result;
		IL_00d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X20_v2+188]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X20_v2+188]");
			Vector3 vector = ((InputControl<Vector3>)0).ReadValue();
			goto IL_01ed;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_01c6:
		object obj14 = typeof(UsageHint) + 816;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v6+B8]");
		obj13 = 0;
		obj10 = obj12;
		goto IL_01ed;
		IL_008b:
		object obj16 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v19+B8]");
		object obj17 = 0;
		obj10 = obj17;
		bool flag5 = obj17 == null;
		obj12 = obj17;
		if (!flag5)
		{
			goto IL_00d0;
		}
		goto IL_01c6;
	}
}
