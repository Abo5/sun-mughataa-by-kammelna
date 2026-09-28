using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

public class CardsOrganizer<T> where T : UiCard
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<T, bool> <>9__17_0;

		public static Func<T, bool> <>9__18_0;

		public static Func<T, bool> <>9__19_0;

		public static Func<T, bool> <>9__19_1;

		public static Func<T, bool> <>9__19_2;

		static <>c()
		{
			//IL_000c: Expected O, but got I
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0287: Expected O, but got I
			//IL_028f: Expected I, but got O
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Expected O, but got Unknown
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Expected O, but got Unknown
			//IL_02c5: Expected O, but got I4
			//IL_02cd: Expected I, but got O
			//IL_009c: Expected O, but got I
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00c4: Expected O, but got I4
			//IL_0053: Expected O, but got I
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_0114: Expected O, but got I
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_0360: Expected O, but got I
			//IL_0370: Expected O, but got I
			//IL_0386: Expected O, but got I
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Expected O, but got Unknown
			//IL_03ae: Expected O, but got I4
			//IL_03be: Expected O, but got I
			//IL_0300: Expected O, but got I
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Expected O, but got Unknown
			//IL_01b6: Expected O, but got I
			//IL_01ca: Expected O, but got I
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected O, but got Unknown
			//IL_0155: Expected O, but got I
			//IL_016b: Expected O, but got I
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected O, but got Unknown
			//IL_0198: Expected O, but got I
			//IL_0450: Expected O, but got I
			//IL_0460: Expected O, but got I
			//IL_0476: Expected O, but got I
			//IL_047f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Expected O, but got Unknown
			//IL_049e: Expected O, but got I4
			//IL_04ae: Expected O, but got I
			//IL_03e6: Expected O, but got I
			//IL_03fa: Expected O, but got I
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Expected O, but got Unknown
			//IL_0422: Expected O, but got I4
			//IL_0211: Expected O, but got I
			//IL_0227: Expected O, but got I
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Expected O, but got Unknown
			//IL_0254: Expected O, but got I
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			if (obj2 != null)
			{
				nint num = 0;
				nint num2 = num;
				object obj3 = num + 309;
				object obj4 = obj3 & 1;
				bool flag = obj4 == null;
				nint num3 = num;
				if (!flag)
				{
					goto IL_0086;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X0_v6+C0]");
				object obj5 = 0;
				nint num2 = (nint)obj5;
				object obj6 = obj5 + 309;
				object obj7 = obj6 & 1;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				nint num3 = (nint)obj5;
				if (obj8 != null)
				{
					goto IL_0086;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag3 = obj10 == null;
			object obj12 = default(object);
			object obj11 = obj12;
			nint num4 = 0;
			if (flag3)
			{
				goto IL_00e8;
			}
			object obj13 = obj12;
			goto IL_00ff;
			IL_01a6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v28+B8]");
			object obj14 = 0;
			obj14 = obj13;
			object obj15 = (nint)0 + (nint)309;
			object obj16 = obj15 & 1;
			bool flag4 = obj16 == null;
			nint num5 = 0;
			if (!flag4)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_01fb:
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<CardsOrganizer`1+<>c>)+10]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<CardsOrganizer`1+<>c>)+10]");
			object obj18 = (nint)0 + (nint)309;
			object obj19 = obj18 & 1;
			bool flag5 = obj19 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<CardsOrganizer`1+<>c>)+10]");
			object obj20 = 0;
			if (!flag5)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_04bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
			IL_0436:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v16+C0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			object obj22 = (nint)0 + (nint)309;
			object obj23 = obj22 & 1;
			bool flag6 = obj23 == null;
			object obj24 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj20 = 0;
			if (obj24 != null)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_0086:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)309;
			object obj26 = obj25 & 1;
			bool flag7 = obj26 == null;
			object obj27 = !flag7;
			object obj28 = default(object);
			obj11 = obj28;
			num4 = 0;
			obj13 = obj28;
			if (obj27 == null)
			{
				goto IL_00e8;
			}
			goto IL_00ff;
			IL_00e8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			obj13 = obj11;
			goto IL_00ff;
			IL_00ff:
			obj13..ctor();
			object obj29 = (nint)0 + (nint)309;
			object obj30 = obj29 & 1;
			if (obj30 != null)
			{
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<CardsOrganizer`1+<>c>)+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<CardsOrganizer`1+<>c>)+10]");
				object obj32 = (nint)0 + (nint)309;
				object obj33 = obj32 & 1;
				bool flag8 = obj33 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<CardsOrganizer`1+<>c>)+10]");
				object obj34 = 0;
				if (!flag8)
				{
					goto IL_01a6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v21+C0]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj36 = (nint)0 + (nint)309;
				object obj37 = obj36 & 1;
				bool flag9 = obj37 == null;
				object obj38 = !flag9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj34 = 0;
				if (obj38 != null)
				{
					goto IL_01a6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v19+B8]");
			object obj39 = 0;
			obj39 = obj13;
			object obj40 = (nint)0 + (nint)309;
			object obj41 = obj40 & 1;
			bool flag10 = obj41 == null;
			object obj42 = !flag10;
			num5 = 0;
			if (obj42 != null)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_0262:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <GetCardSpacingForBottomRow>b__17_0(T card)
		{
			//IL_0067: Expected I4, but got O
			if ((object)card != null)
			{
				GameObject gameObject = card.gameObject;
				if ((object)gameObject != null)
				{
					return gameObject.activeSelf;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <GetCardRotationForBottomRow>b__18_0(T card)
		{
			//IL_0067: Expected I4, but got O
			if ((object)card != null)
			{
				GameObject gameObject = card.gameObject;
				if ((object)gameObject != null)
				{
					return gameObject.activeSelf;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <ReorganizeCards>b__19_0(T card)
		{
			//IL_0067: Expected I4, but got O
			if ((object)card != null)
			{
				GameObject gameObject = card.gameObject;
				if ((object)gameObject != null)
				{
					return gameObject.activeSelf;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <ReorganizeCards>b__19_1(T card)
		{
			//IL_0067: Expected I4, but got O
			if ((object)card != null)
			{
				GameObject gameObject = card.gameObject;
				if ((object)gameObject != null)
				{
					return gameObject.activeSelf;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <ReorganizeCards>b__19_2(T card)
		{
			//IL_0067: Expected I4, but got O
			if ((object)card != null)
			{
				GameObject gameObject = card.gameObject;
				if ((object)gameObject != null)
				{
					return gameObject.activeSelf;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public float BasePositionY;

	public float BottomRowSize = 8f;

	public float AnimationSpeed;

	public float AnimationDelay;

	public float originalHandYPos;

	public Hand hand;

	private T[] <Cards>k__BackingField;

	private bool isMyTurn;

	public T[] Cards
	{
		get
		{
			return <Cards>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private static int CardHeightPixelDifference
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00a8: Expected O, but got I4
			//IL_004b: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool allowDifferentCardElevation = Preferences.AllowDifferentCardElevation;
			bool flag2 = !allowDifferentCardElevation;
			object obj4 = !flag2;
			object obj5 = ~obj4;
			if (obj5 == null)
			{
				return 12;
			}
			return 0;
		}
	}

	private static bool AllowMyTurnHandAnimation
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00df: Expected O, but got I4
			//IL_009c: Expected O, but got I4
			//IL_0148: Expected O, but got I4
			//IL_017c: Expected O, but got I4
			object obj = 152973312;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E33BF]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v8+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool allowMyTurnHandAnimation = Preferences.AllowMyTurnHandAnimation;
			if (!allowMyTurnHandAnimation)
			{
				goto IL_00aa;
			}
			goto IL_011e;
			IL_00aa:
			return allowMyTurnHandAnimation;
			IL_011e:
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Games currentGame = Preferences.CurrentGame;
			object obj8 = currentGame - 2;
			bool flag3 = obj8 == null;
			return !flag3;
			IL_007d:
			allowMyTurnHandAnimation = Preferences.AllowMyTurnHandAnimation;
			bool flag4 = !allowMyTurnHandAnimation;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				goto IL_00aa;
			}
			goto IL_011e;
		}
	}

	private static bool AllowVibration
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00b2: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E33C0]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return Preferences.AllowVibration;
			IL_0074:
			return Preferences.AllowVibration;
		}
	}

	public float GetCardSpacingForBottomRow()
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0164: Expected O, but got I4
		//IL_0092: Expected O, but got I
		//IL_00a8: Expected O, but got I
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I
		//IL_0208: Expected O, but got I
		//IL_0218: Expected O, but got I
		//IL_023a: Expected O, but got I4
		//IL_0192: Expected O, but got I
		//IL_01a8: Expected O, but got I
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_00f3: Expected O, but got I
		//IL_0103: Expected O, but got I
		//IL_0125: Expected O, but got I4
		//IL_025e: Expected O, but got I
		//IL_0274: Expected O, but got I
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_0510: Expected O, but got I4
		//IL_02da: Expected O, but got I
		//IL_02f0: Expected O, but got I
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_0323: Expected O, but got I
		//IL_05c0: Expected O, but got I
		//IL_05d8: Expected O, but got I
		//IL_05ee: Expected O, but got I
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_053e: Expected O, but got I
		//IL_0554: Expected O, but got I
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected O, but got Unknown
		//IL_057c: Expected O, but got I4
		//IL_0592: Expected O, but got I
		//IL_0341: Expected O, but got I
		//IL_0359: Expected O, but got I
		//IL_036f: Expected O, but got I
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_0397: Expected O, but got I4
		//IL_03af: Expected O, but got I
		//IL_0631: Expected O, but got I
		//IL_0418: Expected O, but got I
		//IL_042e: Expected O, but got I
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		//IL_0456: Expected O, but got I4
		//IL_0684: Expected O, but got I
		//IL_069f: Expected O, but got I
		//IL_06b5: Expected O, but got I
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected O, but got Unknown
		//IL_06dd: Expected O, but got I4
		//IL_0498: Expected O, but got I
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v2 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v2 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v32+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v32+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X9_v19 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X9_v19 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj6 = (nint)0 + (nint)309;
		object obj7 = obj6 & 1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X9_v19 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj9 = 0;
		if (obj8 != null)
		{
			goto IL_00e3;
		}
		goto IL_01ee;
		IL_0636:
		Func<object, bool> predicate;
		int num3 = Enumerable.Count(<Cards>k__BackingField, predicate);
		bool flag3 = num3 < 5;
		float result = 4f;
		if (!flag3)
		{
			double num4 = (double)num3 + -1.0;
			double num5 = 14.0 / num4;
			result = (float)num5;
		}
		return result;
		IL_05a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v8+B8]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v13 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v13 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		object obj13 = (nint)0 + (nint)309;
		object obj14 = obj13 & 1;
		if (obj14 == null)
		{
			goto IL_03bd;
		}
		object obj15 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v13 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		object obj16 = 0;
		goto IL_03d4;
		IL_02c4:
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v37 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v37 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj18 = (nint)0 + (nint)309;
		object obj19 = obj18 & 1;
		bool flag4 = obj19 == null;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v37 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj20 = 0;
		if (!flag4)
		{
			goto IL_0331;
		}
		goto IL_05a0;
		IL_007c:
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X9_v24 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X9_v24 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj21 = (nint)0 + (nint)309;
		object obj22 = obj21 & 1;
		bool flag5 = obj22 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X9_v24 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		obj9 = 0;
		if (!flag5)
		{
			goto IL_00e3;
		}
		goto IL_01ee;
		IL_01ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v31+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X9_v18+8]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X9_v18+8]");
		bool flag6 = (nint)0 == 0;
		object obj24 = !flag6;
		if (obj24 == null)
		{
			goto IL_0248;
		}
		goto IL_0636;
		IL_00e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v36+B8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X9_v23+8]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X9_v23+8]");
		bool flag7 = (nint)0 == 0;
		object obj26 = !flag7;
		if (obj26 == null)
		{
			goto IL_0248;
		}
		goto IL_0636;
		IL_0248:
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v8 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v8 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj28 = (nint)0 + (nint)309;
		object obj29 = obj28 & 1;
		if (obj29 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				goto IL_02c4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v10+E4]");
			bool flag8 = (nint)0 == 0;
			object obj30 = !flag8;
			if (obj30 != null)
			{
				goto IL_02c4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v18 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v18 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj31 = (nint)0 + (nint)309;
		object obj32 = obj31 & 1;
		bool flag9 = obj32 == null;
		object obj33 = !flag9;
		num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v18 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		obj20 = 0;
		if (obj33 != null)
		{
			goto IL_0331;
		}
		goto IL_05a0;
		IL_03d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num12 = 0;
		object obj34 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v22 (Il2CppRgctx<CardsOrganizer`1>)+30]");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj34, (IntPtr)0);
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X9_v8 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X9_v8 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj36 = (nint)0 + (nint)309;
		object obj37 = obj36 & 1;
		bool flag10 = obj37 == null;
		object obj38 = !flag10;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v17+B8]");
		object obj39 = 0;
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v25 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v25 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj41 = (nint)0 + (nint)309;
		object obj42 = obj41 & 1;
		bool flag11 = obj42 == null;
		object obj43 = !flag11;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v19+B8]");
		object obj44 = (nint)0 + (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		predicate = func;
		goto IL_0636;
		IL_03bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		obj15 = obj11;
		goto IL_03d4;
		IL_0331:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v26+B8]");
		object obj45 = 0;
		obj11 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v32 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v32 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		object obj46 = (nint)0 + (nint)309;
		object obj47 = obj46 & 1;
		bool flag12 = obj47 == null;
		object obj48 = !flag12;
		obj15 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v32 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		obj16 = 0;
		if (obj48 == null)
		{
			goto IL_03bd;
		}
		goto IL_03d4;
	}

	public float GetCardRotationForBottomRow(int cardIndex)
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0164: Expected O, but got I4
		//IL_0092: Expected O, but got I
		//IL_00a8: Expected O, but got I
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I
		//IL_0208: Expected O, but got I
		//IL_0218: Expected O, but got I
		//IL_023a: Expected O, but got I4
		//IL_0192: Expected O, but got I
		//IL_01a8: Expected O, but got I
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_067e: Expected O, but got I4
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Expected I4, but got Unknown
		//IL_06ec: Expected O, but got I4
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected O, but got Unknown
		//IL_00f3: Expected O, but got I
		//IL_0103: Expected O, but got I
		//IL_0125: Expected O, but got I4
		//IL_025e: Expected O, but got I
		//IL_0274: Expected O, but got I
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Expected O, but got Unknown
		//IL_04fa: Expected O, but got I4
		//IL_02da: Expected O, but got I
		//IL_02f0: Expected O, but got I
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_0323: Expected O, but got I
		//IL_05aa: Expected O, but got I
		//IL_05c2: Expected O, but got I
		//IL_05d8: Expected O, but got I
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected O, but got Unknown
		//IL_0528: Expected O, but got I
		//IL_053e: Expected O, but got I
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_0566: Expected O, but got I4
		//IL_057c: Expected O, but got I
		//IL_0341: Expected O, but got I
		//IL_0359: Expected O, but got I
		//IL_036f: Expected O, but got I
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_0397: Expected O, but got I4
		//IL_03af: Expected O, but got I
		//IL_061b: Expected O, but got I
		//IL_0418: Expected O, but got I
		//IL_042e: Expected O, but got I
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		//IL_0456: Expected O, but got I4
		//IL_0720: Expected O, but got I
		//IL_073b: Expected O, but got I
		//IL_0751: Expected O, but got I
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected O, but got Unknown
		//IL_0779: Expected O, but got I4
		//IL_0498: Expected O, but got I
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v2 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v2 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v33+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v33+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X9_v19 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X9_v19 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj6 = (nint)0 + (nint)309;
		object obj7 = obj6 & 1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X9_v19 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj9 = 0;
		if (obj8 != null)
		{
			goto IL_00e3;
		}
		goto IL_01ee;
		IL_0620:
		Func<object, bool> predicate;
		int num3 = Enumerable.Count(<Cards>k__BackingField, predicate);
		double num4 = (double)num3 + -1.0;
		double num5 = num4 * 4.0;
		double num6 = num5 * 0.5;
		object obj10 = num3 - 4;
		bool flag3 = (nint)obj10 < 0;
		bool flag4 = obj10 == null;
		int num7 = num3 ^ 4;
		int num8 = num3 ^ obj10;
		int num9 = num7 & num8;
		bool flag5 = num9 < 0;
		bool flag6 = flag3 == flag5;
		object obj11 = !flag4;
		object obj12 = flag6 & obj11;
		object obj13 = ~obj12;
		double num10 = ((obj13 != null) ? num6 : 7.0);
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4389120");
		object obj15 = default(object);
		object obj14 = obj15 * cardIndex;
		return (float)num10 - (float)obj14;
		IL_058a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v9+B8]");
		object obj16 = 0;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v15 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v15 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		object obj19 = (nint)0 + (nint)309;
		object obj20 = obj19 & 1;
		if (obj20 == null)
		{
			goto IL_03bd;
		}
		object obj21 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v15 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		object obj22 = 0;
		goto IL_03d4;
		IL_02c4:
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v39 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v39 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj24 = (nint)0 + (nint)309;
		object obj25 = obj24 & 1;
		bool flag7 = obj25 == null;
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v39 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj26 = 0;
		if (!flag7)
		{
			goto IL_0331;
		}
		goto IL_058a;
		IL_007c:
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X9_v24 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X9_v24 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj27 = (nint)0 + (nint)309;
		object obj28 = obj27 & 1;
		bool flag8 = obj28 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X9_v24 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		obj9 = 0;
		if (!flag8)
		{
			goto IL_00e3;
		}
		goto IL_01ee;
		IL_01ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v32+B8]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X9_v18+10]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X9_v18+10]");
		bool flag9 = (nint)0 == 0;
		object obj30 = !flag9;
		if (obj30 == null)
		{
			goto IL_0248;
		}
		goto IL_0620;
		IL_00e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v37+B8]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X9_v23+10]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X9_v23+10]");
		bool flag10 = (nint)0 == 0;
		object obj32 = !flag10;
		if (obj32 == null)
		{
			goto IL_0248;
		}
		goto IL_0620;
		IL_0248:
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v10 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v10 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj34 = (nint)0 + (nint)309;
		object obj35 = obj34 & 1;
		if (obj35 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				goto IL_02c4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v11+E4]");
			bool flag11 = (nint)0 == 0;
			object obj36 = !flag11;
			if (obj36 != null)
			{
				goto IL_02c4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v20 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v20 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj37 = (nint)0 + (nint)309;
		object obj38 = obj37 & 1;
		bool flag12 = obj38 == null;
		object obj39 = !flag12;
		num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v20 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		obj26 = 0;
		if (obj39 != null)
		{
			goto IL_0331;
		}
		goto IL_058a;
		IL_03d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num18 = 0;
		object obj40 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v24 (Il2CppRgctx<CardsOrganizer`1>)+50]");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj40, (IntPtr)0);
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X9_v8 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X9_v8 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj42 = (nint)0 + (nint)309;
		object obj43 = obj42 & 1;
		bool flag13 = obj43 == null;
		object obj44 = !flag13;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v18+B8]");
		object obj45 = 0;
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v27 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v27 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj47 = (nint)0 + (nint)309;
		object obj48 = obj47 & 1;
		bool flag14 = obj48 == null;
		object obj49 = !flag14;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v20+B8]");
		object obj50 = (nint)0 + (nint)16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		predicate = func;
		goto IL_0620;
		IL_03bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		obj21 = obj17;
		goto IL_03d4;
		IL_0331:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v27+B8]");
		object obj51 = 0;
		obj17 = obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v34 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v34 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		object obj52 = (nint)0 + (nint)309;
		object obj53 = obj52 & 1;
		bool flag15 = obj53 == null;
		object obj54 = !flag15;
		obj21 = obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v34 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		obj22 = 0;
		if (obj54 == null)
		{
			goto IL_03bd;
		}
		goto IL_03d4;
	}

	public void ReorganizeCards()
	{
		//IL_1b87: Expected O, but got I
		//IL_1b9d: Expected O, but got I
		//IL_1ba6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bab: Expected O, but got Unknown
		//IL_1bc5: Expected O, but got I4
		//IL_005f: Expected O, but got I
		//IL_0075: Expected O, but got I
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_00a2: Expected O, but got I
		//IL_0031: Expected O, but got I4
		//IL_01b6: Expected O, but got I
		//IL_01c6: Expected O, but got I
		//IL_01e8: Expected O, but got I4
		//IL_0140: Expected O, but got I
		//IL_0156: Expected O, but got I
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_017e: Expected O, but got I4
		//IL_018e: Expected O, but got I
		//IL_1bf1: Invalid comparison between F4 and I4
		//IL_00c0: Expected O, but got I
		//IL_00d0: Expected O, but got I
		//IL_00f2: Expected O, but got I4
		//IL_020c: Expected O, but got I
		//IL_0222: Expected O, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_024a: Expected O, but got I4
		//IL_0578: Expected O, but got I
		//IL_058e: Expected O, but got I
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected O, but got Unknown
		//IL_05b6: Expected O, but got I4
		//IL_02b2: Expected O, but got I
		//IL_02c8: Expected O, but got I
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02fb: Expected O, but got I
		//IL_0284: Expected O, but got I4
		//IL_19c1: Expected O, but got I
		//IL_19d9: Expected O, but got I
		//IL_19ef: Expected O, but got I
		//IL_19f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fd: Expected O, but got Unknown
		//IL_193f: Expected O, but got I
		//IL_1955: Expected O, but got I
		//IL_195e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1963: Expected O, but got Unknown
		//IL_197d: Expected O, but got I4
		//IL_1993: Expected O, but got I
		//IL_061e: Expected O, but got I
		//IL_0634: Expected O, but got I
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected O, but got Unknown
		//IL_065c: Expected O, but got I4
		//IL_05f0: Expected O, but got I4
		//IL_0319: Expected O, but got I
		//IL_0331: Expected O, but got I
		//IL_0347: Expected O, but got I
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_036f: Expected O, but got I4
		//IL_0387: Expected O, but got I
		//IL_04c3: Expected O, but got I
		//IL_04d3: Expected O, but got I
		//IL_06ba: Expected O, but got I
		//IL_06d0: Expected O, but got I
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected O, but got Unknown
		//IL_06f8: Expected O, but got I4
		//IL_0708: Expected O, but got I
		//IL_03cc: Expected O, but got I
		//IL_1a32: Expected O, but got I
		//IL_0786: Expected O, but got I
		//IL_079c: Expected O, but got I
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected O, but got Unknown
		//IL_07c4: Expected O, but got I4
		//IL_067a: Expected O, but got I
		//IL_0400: Expected O, but got I
		//IL_0416: Expected O, but got I
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_043e: Expected O, but got I4
		//IL_0730: Expected O, but got I
		//IL_0740: Expected O, but got I
		//IL_0762: Expected O, but got I4
		//IL_1c18: Expected O, but got I
		//IL_1c33: Expected O, but got I
		//IL_1c49: Expected O, but got I
		//IL_1c52: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c57: Expected O, but got Unknown
		//IL_1c71: Expected O, but got I4
		//IL_082c: Expected O, but got I
		//IL_0842: Expected O, but got I
		//IL_084b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0850: Expected O, but got Unknown
		//IL_0875: Expected O, but got I
		//IL_07fe: Expected O, but got I4
		//IL_0b5a: Expected O, but got I
		//IL_0b70: Expected O, but got I
		//IL_0b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7e: Expected O, but got Unknown
		//IL_0b98: Expected O, but got I4
		//IL_0480: Expected O, but got I
		//IL_0ace: Expected O, but got I
		//IL_0ae6: Expected O, but got I
		//IL_0afc: Expected O, but got I
		//IL_0b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0a: Expected O, but got Unknown
		//IL_0a4c: Expected O, but got I
		//IL_0a62: Expected O, but got I
		//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a70: Expected O, but got Unknown
		//IL_0a8a: Expected O, but got I4
		//IL_0aa0: Expected O, but got I
		//IL_0893: Expected O, but got I
		//IL_08ab: Expected O, but got I
		//IL_08c1: Expected O, but got I
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Expected O, but got Unknown
		//IL_08e9: Expected O, but got I4
		//IL_0901: Expected O, but got I
		//IL_0c00: Expected O, but got I
		//IL_0c16: Expected O, but got I
		//IL_0c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c24: Expected O, but got Unknown
		//IL_0c43: Expected O, but got I
		//IL_0bd2: Expected O, but got I4
		//IL_0946: Expected O, but got I
		//IL_0b3f: Expected O, but got I
		//IL_0dc5: Expected O, but got I
		//IL_0dd5: Expected O, but got I
		//IL_0df7: Expected O, but got I4
		//IL_0d4f: Expected O, but got I
		//IL_0d65: Expected O, but got I
		//IL_0d6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d73: Expected O, but got Unknown
		//IL_0d8d: Expected O, but got I4
		//IL_0d9d: Expected O, but got I
		//IL_097a: Expected O, but got I
		//IL_0990: Expected O, but got I
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_099e: Expected O, but got Unknown
		//IL_09b8: Expected O, but got I4
		//IL_0cd9: Expected O, but got I4
		//IL_0c61: Expected O, but got I
		//IL_0c71: Expected O, but got I
		//IL_1c94: Expected O, but got I
		//IL_1caf: Expected O, but got I
		//IL_1cc5: Expected O, but got I
		//IL_1cce: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd3: Expected O, but got Unknown
		//IL_1ced: Expected O, but got I4
		//IL_111c: Expected O, but got I
		//IL_0e1b: Expected O, but got I
		//IL_0e31: Expected O, but got I
		//IL_0e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3f: Expected O, but got Unknown
		//IL_0e59: Expected O, but got I4
		//IL_09fa: Expected O, but got I
		//IL_11ee: Expected O, but got I4
		//IL_1253: Expected O, but got I4
		//IL_125b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1260: Expected O, but got Unknown
		//IL_1165: Expected O, but got I
		//IL_116d: Expected I4, but got O
		//IL_119e: Expected O, but got I4
		//IL_11b6: Expected O, but got I
		//IL_0ec1: Expected O, but got I
		//IL_0ed7: Expected O, but got I
		//IL_0ee0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee5: Expected O, but got Unknown
		//IL_0f0a: Expected O, but got I
		//IL_0e93: Expected O, but got I4
		//IL_1296: Expected O, but got I8
		//IL_1af4: Expected O, but got I
		//IL_1b0c: Expected O, but got I
		//IL_1b22: Expected O, but got I
		//IL_1b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b30: Expected O, but got Unknown
		//IL_1a72: Expected O, but got I
		//IL_1a88: Expected O, but got I
		//IL_1a91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a96: Expected O, but got Unknown
		//IL_1ab0: Expected O, but got I4
		//IL_1ac6: Expected O, but got I
		//IL_1da3: Expected O, but got I4
		//IL_1dac: Expected O, but got I4
		//IL_1db5: Expected O, but got I4
		//IL_1284: Expected O, but got I8
		//IL_0f28: Expected O, but got I
		//IL_0f40: Expected O, but got I
		//IL_0f56: Expected O, but got I
		//IL_0f5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f64: Expected O, but got Unknown
		//IL_0f7e: Expected O, but got I4
		//IL_0f96: Expected O, but got I
		//IL_0fdb: Expected O, but got I
		//IL_1b65: Expected O, but got I
		//IL_100f: Expected O, but got I
		//IL_1025: Expected O, but got I
		//IL_102e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1033: Expected O, but got Unknown
		//IL_104d: Expected O, but got I4
		//IL_12b8: Expected O, but got I
		//IL_12ce: Expected O, but got I
		//IL_1d0b: Expected O, but got I
		//IL_1d26: Expected O, but got I
		//IL_1d3c: Expected O, but got I
		//IL_1d45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d4a: Expected O, but got Unknown
		//IL_1d64: Expected O, but got I4
		//IL_13a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a5: Expected O, but got Unknown
		//IL_13cf: Expected O, but got I4
		//IL_108f: Expected O, but got I
		//IL_134f: Expected O, but got I4
		//IL_12fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ff: Expected O, but got Unknown
		//IL_1381: Expected F8, but got I4
		//IL_1df2: Expected O, but got I4
		//IL_140f: Expected O, but got I4
		//IL_1457: Expected O, but got I
		//IL_1441: Expected F8, but got I4
		//IL_14fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1501: Expected O, but got Unknown
		//IL_15b4: Expected O, but got I4
		//IL_15cd: Expected O, but got I4
		//IL_14a7: Expected O, but got I
		//IL_1588: Expected F8, but got I4
		//IL_1542: Expected O, but got I4
		//IL_155d: Expected O, but got I4
		//IL_15e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e8: Expected O, but got Unknown
		//IL_1605: Expected O, but got I4
		//IL_161f: Expected O, but got I4
		//IL_1e15: Expected O, but got I
		//IL_1e2a: Expected O, but got I
		//IL_1e3b: Expected O, but got I
		//IL_181f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1824: Expected O, but got Unknown
		//IL_173d: Expected O, but got I4
		//IL_18c4: Expected O, but got I
		//IL_18cd: Expected O, but got I4
		//IL_175c: Expected O, but got I
		//IL_1777: Expected O, but got I
		//IL_185f: Expected O, but got I
		//IL_1868: Expected O, but got I4
		//IL_1795: Unknown result type (might be due to invalid IL or missing references)
		//IL_179a: Expected O, but got Unknown
		//IL_17ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b2: Expected O, but got Unknown
		//IL_17dc: Expected O, but got I4
		//IL_17f5: Expected F8, but got I4
		//IL_18f5: Expected O, but got I
		//IL_18fe: Expected O, but got I4
		//IL_188e: Expected O, but got I
		//IL_1897: Expected O, but got I4
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v151+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				goto IL_003f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v151+E4]");
			if ((nint)0 == 0)
			{
				goto IL_003f;
			}
		}
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X9_v91 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X9_v91 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj7 = (nint)0 + (nint)309;
		object obj8 = obj7 & 1;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X9_v91 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj10 = 0;
		if (obj9 != null)
		{
			goto IL_00b0;
		}
		goto IL_019c;
		IL_0c51:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X0_v114+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X9_v67+28]");
		Func<object, bool> func = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X9_v67+28]");
		if ((nint)0 != 0)
		{
			goto IL_0c96;
		}
		goto IL_0e05;
		IL_1b6a:
		throw new NullReferenceException();
		IL_1ad4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X0_v83+B8]");
		object obj12 = 0;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v108 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v108 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		object obj15 = (nint)0 + (nint)309;
		object obj16 = obj15 & 1;
		if (obj16 == null)
		{
			goto IL_0fa4;
		}
		object obj17 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v108 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		object obj18 = 0;
		goto IL_0fbb;
		IL_003f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X9_v96 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X9_v96 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj19 = (nint)0 + (nint)309;
		object obj20 = obj19 & 1;
		bool flag4 = obj20 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X9_v96 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		obj10 = 0;
		if (!flag4)
		{
			goto IL_00b0;
		}
		goto IL_019c;
		IL_019c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v147+B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X9_v90+18]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X9_v90+18]");
		bool flag5 = (nint)0 == 0;
		object obj22 = !flag5;
		if (obj22 == null)
		{
			goto IL_01f6;
		}
		goto IL_1bd3;
		IL_00b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v150+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X9_v95+18]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X9_v95+18]");
		bool flag6 = (nint)0 == 0;
		object obj24 = !flag6;
		if (obj24 == null)
		{
			goto IL_01f6;
		}
		goto IL_1bd3;
		IL_01f6:
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v149 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v149 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj26 = (nint)0 + (nint)309;
		object obj27 = obj26 & 1;
		bool flag7 = obj27 == null;
		object obj28 = !flag7;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v142+E4]");
			bool flag8 = (nint)0 == 0;
			object obj29 = !flag8;
			if (obj29 == null)
			{
				goto IL_0292;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v142+E4]");
			if ((nint)0 == 0)
			{
				goto IL_0292;
			}
		}
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v159 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v159 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj31 = (nint)0 + (nint)309;
		object obj32 = obj31 & 1;
		bool flag9 = obj32 == null;
		object obj33 = !flag9;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v159 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj34 = 0;
		if (obj33 != null)
		{
			goto IL_0309;
		}
		goto IL_19a1;
		IL_0ea1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X8_v133 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X8_v133 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj36 = (nint)0 + (nint)309;
		object obj37 = obj36 & 1;
		bool flag10 = obj37 == null;
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X8_v133 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj38 = 0;
		if (!flag10)
		{
			goto IL_0f18;
		}
		goto IL_1ad4;
		IL_11db:
		T[] array = <Cards>k__BackingField;
		object obj39 = 0;
		goto IL_11f3;
		IL_0e05:
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v103 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v103 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj41 = (nint)0 + (nint)309;
		object obj42 = obj41 & 1;
		bool flag11 = obj42 == null;
		object obj43 = !flag11;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X0_v103+E4]");
			bool flag12 = (nint)0 == 0;
			object obj44 = !flag12;
			if (obj44 == null)
			{
				goto IL_0ea1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X0_v103+E4]");
			if ((nint)0 == 0)
			{
				goto IL_0ea1;
			}
		}
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v113 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v113 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj45 = (nint)0 + (nint)309;
		object obj46 = obj45 & 1;
		bool flag13 = obj46 == null;
		object obj47 = !flag13;
		num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v113 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		obj38 = 0;
		if (obj47 != null)
		{
			goto IL_0f18;
		}
		goto IL_1ad4;
		IL_0292:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v178 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v178 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj48 = (nint)0 + (nint)309;
		object obj49 = obj48 & 1;
		bool flag14 = obj49 == null;
		num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v178 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		obj34 = 0;
		if (!flag14)
		{
			goto IL_0309;
		}
		goto IL_19a1;
		IL_19a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v124+B8]");
		object obj50 = 0;
		object obj51 = obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v154 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v154 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		object obj53 = (nint)0 + (nint)309;
		object obj54 = obj53 & 1;
		if (obj54 == null)
		{
			goto IL_0395;
		}
		object obj55 = obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v154 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		object obj56 = 0;
		goto IL_03ac;
		IL_11f3:
		int num14;
		bool flag15 = num14 < 0;
		bool flag16 = num14 == 0;
		int num15 = num14 ^ num14;
		int num16 = num14 & num15;
		bool flag17 = num16 < 0;
		bool flag18 = flag15 == flag17;
		object obj57 = !flag16;
		object obj58 = flag18 & obj57;
		object obj59 = ~obj58;
		object obj60 = ((obj59 != null) ? ((object)3267887104L) : ((object)3273654272L));
		int num18;
		double num17 = (double)num18 + -1.0;
		double num19 = 14.0 / num17;
		object obj61 = 0;
		object obj62 = 0;
		object obj63 = 0;
		double num20 = 14.0;
		int num21 = 0;
		int num33;
		object obj86;
		Func<object, bool> func2;
		RotateMode rotateMode;
		do
		{
			if ((nint)obj62 >= array.Length)
			{
				return;
			}
			object obj64 = (object)array + obj62;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ X8_v66+20]");
			Component component = (Component)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E33BE]");
			object obj65 = (nint)0 & (nint)1;
			if (obj65 != null)
			{
				object obj66 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				object obj67 = obj66;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v65+E4]");
				if ((nint)0 != 0)
				{
					goto IL_132c;
				}
			}
			else
			{
				_ = 1;
				object obj68 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				object obj67 = obj68;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v65+E4]");
				bool flag19 = (nint)0 == 0;
				object obj69 = !flag19;
				if (obj69 != null)
				{
					goto IL_132c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool allowDifferentCardElevation = Preferences.AllowDifferentCardElevation;
			bool flag20 = !allowDifferentCardElevation;
			object obj70 = !flag20;
			object obj71 = ~obj70;
			double num22 = ((obj71 != null) ? 0.0 : 12.0);
			goto IL_1446;
			IL_132c:
			bool allowDifferentCardElevation2 = Preferences.AllowDifferentCardElevation;
			bool flag21 = !allowDifferentCardElevation2;
			object obj72 = !flag21;
			object obj73 = ~obj72;
			num22 = ((obj73 != null) ? 0.0 : 12.0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ X8_v66+20]");
			bool flag22 = (nint)0 == 0;
			object obj74 = !flag22;
			if (obj74 == null)
			{
				break;
			}
			goto IL_1446;
			IL_168e:
			int num24;
			double num23 = (double)num24 + -1.0;
			double num26;
			double num25 = num26 * num23;
			double num27 = num25 * 0.5;
			double num28 = num26;
			double num30;
			double num29 = num30;
			object obj75 = obj57;
			object obj76 = obj39;
			object obj77;
			obj63 = obj77;
			object obj79;
			object obj78 = obj79;
			goto IL_1e00;
			IL_156b:
			double num31;
			num30 = num31 + 3263954944.0;
			num26 = 1076029626.0;
			obj79 = obj61;
			num24 = num14;
			goto IL_168e;
			IL_15db:
			obj79 = obj61 - num14;
			double num32;
			num30 = (double)obj60 + num32;
			object obj80 = num18 - 4;
			bool flag23 = obj80 == null;
			obj57 = !flag23;
			bool flag24 = num18 > 4;
			obj39 = obj76;
			obj77 = obj63;
			num26 = 4.0;
			num24 = num18;
			num27 = 7.0;
			num28 = num19;
			num29 = num30;
			obj75 = obj57;
			obj78 = obj79;
			if (!flag24)
			{
				goto IL_168e;
			}
			goto IL_1e00;
			IL_1446:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ X8_v66+20]");
			GameObject gameObject = ((Component)0).gameObject;
			num31 = (double)BasePositionY - num22;
			if (gameObject.activeSelf)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X24_v10 (UnityEngine.Component)+28]");
				object obj81 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X24_v10 (UnityEngine.Component)+28]");
				if ((nint)0 != 0)
				{
					object obj82 = obj39;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X8_v83+14]");
					if (obj82 != null)
					{
						object obj83 = obj63 & 1;
						if (obj83 != null)
						{
							bool flag25 = (nint)obj62 < num33;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X8_v83+14]");
							obj39 = 0;
							obj77 = 0;
							if (flag25)
							{
								goto IL_156b;
							}
							num32 = num31;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X8_v83+14]");
							obj76 = 0;
							obj63 = 0;
						}
						else
						{
							num31 = BasePositionY;
							bool flag26 = (nint)obj62 < num33;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X8_v83+14]");
							obj39 = 0;
							obj77 = 1;
							if (flag26)
							{
								goto IL_156b;
							}
							num32 = BasePositionY;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X8_v83+14]");
							obj76 = 0;
							obj63 = 1;
						}
						goto IL_15db;
					}
				}
			}
			object obj84 = obj63 & 1;
			if (obj84 != null)
			{
				num31 = BasePositionY;
				bool flag27 = (nint)obj62 >= num33;
				obj77 = 1;
				num32 = BasePositionY;
				obj76 = obj39;
				obj63 = 1;
				if (!flag27)
				{
					goto IL_156b;
				}
			}
			else
			{
				bool flag28 = (nint)obj62 < num33;
				obj77 = 0;
				num32 = num31;
				obj76 = obj39;
				obj63 = 0;
				if (flag28)
				{
					goto IL_156b;
				}
			}
			goto IL_15db;
			IL_1e00:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ X8_v66+20]");
			((UiCard)0).Index = num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ X8_v66+20]");
			((UiCard)0).CardPositionY = (float)num29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ X8_v66+20]");
			Transform transform = ((Component)0).transform;
			Transform parent = transform.parent;
			double num34 = num28 * (double)obj78;
			double num35 = num27 - num34;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(parent, (Vector3)0, 0f);
			num17 = AnimationDelay;
			object obj85 = (nint)0 + (nint)2744;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ X8_v66+20]");
			GameObject gameObject2 = ((Component)0).gameObject;
			bool activeSelf = gameObject2.activeSelf;
			obj61 += activeSelf;
			array = <Cards>k__BackingField;
			obj62++;
			num21--;
			bool flag29 = <Cards>k__BackingField == null;
			obj86 = !flag29;
			obj57 = obj75;
			obj39 = obj76;
			num20 = 0.0;
			func2 = null;
			rotateMode = RotateMode.Fast;
		}
		while (obj86 != null);
		goto IL_1b6a;
		IL_0309:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v140+B8]");
		object obj87 = 0;
		obj51 = obj87;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v173 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v173 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		object obj88 = (nint)0 + (nint)309;
		object obj89 = obj88 & 1;
		bool flag30 = obj89 == null;
		object obj90 = !flag30;
		obj55 = obj87;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v173 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		obj56 = 0;
		if (obj90 == null)
		{
			goto IL_0395;
		}
		goto IL_03ac;
		IL_0395:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		obj55 = obj51;
		goto IL_03ac;
		IL_03ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v163 (Il2CppRgctx<CardsOrganizer`1>)+38]");
		object obj91 = 0;
		object obj92 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v163 (Il2CppRgctx<CardsOrganizer`1>)+60]");
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj92, (IntPtr)0);
		nint num37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X9_v80 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj93 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X9_v80 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj94 = (nint)0 + (nint)309;
		object obj95 = obj94 & 1;
		bool flag31 = obj95 == null;
		object obj96 = !flag31;
		if (obj96 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v131+B8]");
		object obj97 = 0;
		nint num38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v166 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj98 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v166 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj99 = (nint)0 + (nint)309;
		object obj100 = obj99 & 1;
		bool flag32 = obj100 == null;
		object obj101 = !flag32;
		if (obj101 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v133+B8]");
		object obj102 = (nint)0 + (nint)24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		predicate = func3;
		goto IL_1bd3;
		IL_110c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X0_v78 (System.Object)+28]");
		object obj103 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X0_v78 (System.Object)+28]");
		bool flag33 = (nint)0 == 0;
		Func<object, bool> func4;
		func2 = func4;
		object obj104 = obj91;
		RotateMode rotateMode2;
		rotateMode = rotateMode2;
		if (flag33)
		{
			goto IL_11db;
		}
		object obj105 = (nint)0 + (nint)248;
		rotateMode = (RotateMode)obj105;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v97+14]");
		System.Int32Enum? int32Enum = (System.Int32Enum)0;
		bool flag34 = <Cards>k__BackingField == null;
		object obj106 = !flag34;
		object obj107 = default(object);
		obj39 = obj107;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v97+14]");
		func2 = (Func<object, bool>)0;
		obj104 = obj91;
		array = <Cards>k__BackingField;
		if (obj106 != null)
		{
			goto IL_11f3;
		}
		goto IL_1b6a;
		IL_0be0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		nint num39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X9_v68 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj108 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X9_v68 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj109 = (nint)0 + (nint)309;
		object obj110 = obj109 & 1;
		bool flag35 = obj110 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X9_v68 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj111 = 0;
		if (!flag35)
		{
			goto IL_0c51;
		}
		goto IL_0dab;
		IL_0c96:
		nint num40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v141 (Il2CppRgctx<CardsOrganizer`1>)+80]");
		rotateMode2 = RotateMode.Fast;
		object obj112 = Enumerable.FirstOrDefault(<Cards>k__BackingField, func);
		bool flag36 = obj112 == null;
		object obj113 = !flag36;
		func4 = func;
		if (obj113 != null)
		{
			goto IL_110c;
		}
		func2 = func;
		obj104 = obj91;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v141 (Il2CppRgctx<CardsOrganizer`1>)+80]");
		rotateMode = RotateMode.Fast;
		goto IL_11db;
		IL_0dab:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v108+B8]");
		object obj114 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X9_v61+28]");
		func = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X9_v61+28]");
		bool flag37 = (nint)0 == 0;
		object obj115 = !flag37;
		if (obj115 != null)
		{
			goto IL_0c96;
		}
		goto IL_0e05;
		IL_1bd3:
		int num41 = Enumerable.Count(<Cards>k__BackingField, predicate);
		num33 = ((!(BottomRowSize < (float)num41)) ? 1 : 7);
		Func<object, bool> func5 = default(Func<object, bool>);
		do
		{
			num33--;
			nint num42 = 0;
			IEnumerable<object> source = Enumerable.Take((IEnumerable<object>)<Cards>k__BackingField, num33);
			nint num43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v14 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			object obj116 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v14 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			object obj117 = (nint)0 + (nint)309;
			object obj118 = obj117 & 1;
			bool flag38 = obj118 == null;
			object obj119 = !flag38;
			if (obj119 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v39+E4]");
				bool flag39 = (nint)0 == 0;
				object obj120 = !flag39;
				if (obj120 == null)
				{
					goto IL_05fe;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v39+E4]");
				if ((nint)0 == 0)
				{
					goto IL_05fe;
				}
			}
			nint num44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X9_v20 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			object obj121 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X9_v20 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			object obj122 = (nint)0 + (nint)309;
			object obj123 = obj122 & 1;
			bool flag40 = obj123 == null;
			object obj124 = !flag40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X9_v20 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			object obj125 = 0;
			if (obj124 != null)
			{
				goto IL_04b3;
			}
			goto IL_0716;
			IL_080c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v47 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			object obj126 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v47 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			object obj127 = (nint)0 + (nint)309;
			object obj128 = obj127 & 1;
			bool flag41 = obj128 == null;
			nint num46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v47 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			object obj129 = 0;
			if (!flag41)
			{
				goto IL_0883;
			}
			goto IL_0aae;
			IL_0883:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v29+B8]");
			object obj130 = 0;
			object obj131 = obj130;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v42 (Il2CppRgctx<CardsOrganizer`1>)+20]");
			object obj132 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v42 (Il2CppRgctx<CardsOrganizer`1>)+20]");
			object obj133 = (nint)0 + (nint)309;
			object obj134 = obj133 & 1;
			bool flag42 = obj134 == null;
			object obj135 = !flag42;
			object obj136 = obj130;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v42 (Il2CppRgctx<CardsOrganizer`1>)+20]");
			object obj137 = 0;
			if (obj135 == null)
			{
				goto IL_090f;
			}
			goto IL_0926;
			IL_04f8:
			nint num47 = 0;
			Func<object, bool> predicate2;
			num14 = Enumerable.Count(source, predicate2);
			num18 = num41 - num14;
			continue;
			IL_05fe:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X9_v23 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			obj121 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X9_v23 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			object obj138 = (nint)0 + (nint)309;
			object obj139 = obj138 & 1;
			bool flag43 = obj139 == null;
			object obj140 = !flag43;
			if (obj140 != null)
			{
				goto IL_04b3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X9_v23 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			obj125 = 0;
			goto IL_0716;
			IL_0aae:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			nint num49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v13+B8]");
			object obj141 = 0;
			obj131 = obj141;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v23 (Il2CppRgctx<CardsOrganizer`1>)+20]");
			obj132 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v23 (Il2CppRgctx<CardsOrganizer`1>)+20]");
			object obj142 = (nint)0 + (nint)309;
			object obj143 = obj142 & 1;
			if (obj143 == null)
			{
				goto IL_090f;
			}
			obj136 = obj141;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v23 (Il2CppRgctx<CardsOrganizer`1>)+20]");
			obj137 = 0;
			goto IL_0926;
			IL_0716:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v36+B8]");
			object obj144 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X9_v19+20]");
			predicate2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X9_v19+20]");
			bool flag44 = (nint)0 == 0;
			object obj145 = !flag44;
			if (obj145 != null)
			{
				goto IL_04f8;
			}
			goto IL_0770;
			IL_04b3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v120+B8]");
			object obj146 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X9_v73+20]");
			predicate2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X9_v73+20]");
			if ((nint)0 != 0)
			{
				goto IL_04f8;
			}
			goto IL_0770;
			IL_0770:
			nint num50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v18 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			object obj147 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v18 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			object obj148 = (nint)0 + (nint)309;
			object obj149 = obj148 & 1;
			bool flag45 = obj149 == null;
			object obj150 = !flag45;
			if (obj150 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v31+E4]");
				bool flag46 = (nint)0 == 0;
				object obj151 = !flag46;
				if (obj151 == null)
				{
					goto IL_080c;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v31+E4]");
				if ((nint)0 == 0)
				{
					goto IL_080c;
				}
			}
			nint num51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v28 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			obj126 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v28 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			object obj152 = (nint)0 + (nint)309;
			object obj153 = obj152 & 1;
			bool flag47 = obj153 == null;
			object obj154 = !flag47;
			num46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v28 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			obj129 = 0;
			if (obj154 != null)
			{
				goto IL_0883;
			}
			goto IL_0aae;
			IL_090f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			obj136 = obj131;
			goto IL_0926;
			IL_0926:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v32 (Il2CppRgctx<CardsOrganizer`1>)+38]");
			obj91 = 0;
			object obj155 = obj136;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v32 (Il2CppRgctx<CardsOrganizer`1>)+70]");
			func5..ctor(obj155, (IntPtr)0);
			nint num53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X9_v9 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			object obj156 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X9_v9 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			object obj157 = (nint)0 + (nint)309;
			object obj158 = obj157 & 1;
			bool flag48 = obj158 == null;
			object obj159 = !flag48;
			if (obj159 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v20+B8]");
			object obj160 = 0;
			nint num54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v35 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			object obj161 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v35 (Il2CppRgctx<CardsOrganizer`1>)+28]");
			object obj162 = (nint)0 + (nint)309;
			object obj163 = obj162 & 1;
			bool flag49 = obj163 == null;
			object obj164 = !flag49;
			if (obj164 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X0_v22+B8]");
			object obj165 = (nint)0 + (nint)32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate2 = func5;
			goto IL_04f8;
		}
		while (num18 < num14);
		nint num55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v60 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj166 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v60 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj167 = (nint)0 + (nint)309;
		object obj168 = obj167 & 1;
		bool flag50 = obj168 == null;
		object obj169 = !flag50;
		if (obj169 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X0_v115+E4]");
			bool flag51 = (nint)0 == 0;
			object obj170 = !flag51;
			if (obj170 == null)
			{
				goto IL_0be0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X0_v115+E4]");
			if ((nint)0 == 0)
			{
				goto IL_0be0;
			}
		}
		nint num56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X9_v62 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		obj108 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X9_v62 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj171 = (nint)0 + (nint)309;
		object obj172 = obj171 & 1;
		bool flag52 = obj172 == null;
		object obj173 = !flag52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X9_v62 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		obj111 = 0;
		if (obj173 != null)
		{
			goto IL_0c51;
		}
		goto IL_0dab;
		IL_0f18:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X0_v101+B8]");
		object obj174 = 0;
		obj13 = obj174;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v128 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v128 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		object obj175 = (nint)0 + (nint)309;
		object obj176 = obj175 & 1;
		bool flag53 = obj176 == null;
		object obj177 = !flag53;
		obj17 = obj174;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v128 (Il2CppRgctx<CardsOrganizer`1>)+20]");
		obj18 = 0;
		if (obj177 == null)
		{
			goto IL_0fa4;
		}
		goto IL_0fbb;
		IL_0fbb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ X8_v117 (Il2CppRgctx<CardsOrganizer`1>)+38]");
		obj91 = 0;
		object obj178 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ X8_v117 (Il2CppRgctx<CardsOrganizer`1>)+78]");
		Func<object, bool> func6 = default(Func<object, bool>);
		func6..ctor(obj178, (IntPtr)0);
		nint num58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ X9_v51 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj179 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ X9_v51 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj180 = (nint)0 + (nint)309;
		object obj181 = obj180 & 1;
		bool flag54 = obj181 == null;
		object obj182 = !flag54;
		if (obj182 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X0_v90+B8]");
		object obj183 = 0;
		nint num59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X8_v120 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj184 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X8_v120 (Il2CppRgctx<CardsOrganizer`1>)+28]");
		object obj185 = (nint)0 + (nint)309;
		object obj186 = obj185 & 1;
		bool flag55 = obj186 == null;
		object obj187 = !flag55;
		if (obj187 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ X0_v92+B8]");
		object obj188 = (nint)0 + (nint)40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v125 (Il2CppRgctx<CardsOrganizer`1>)+80]");
		rotateMode2 = RotateMode.Fast;
		obj112 = Enumerable.FirstOrDefault(<Cards>k__BackingField, func6);
		bool flag56 = obj112 == null;
		func4 = func6;
		func2 = func6;
		obj104 = obj91;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v125 (Il2CppRgctx<CardsOrganizer`1>)+80]");
		rotateMode = RotateMode.Fast;
		if (!flag56)
		{
			goto IL_110c;
		}
		goto IL_11db;
		IL_0fa4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		obj17 = obj13;
		goto IL_0fbb;
	}

	public void HighlightMyTurnToPlay(bool isMyTurnToPlay)
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0118: Expected O, but got I
		//IL_01c4: Expected O, but got I4
		//IL_0021: Expected O, but got I4
		//IL_0181: Expected O, but got I4
		//IL_0038: Expected O, but got I4
		//IL_004e: Expected O, but got I
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_02a2: Expected O, but got I4
		//IL_00d3: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_047b: Expected O, but got I
		//IL_0491: Expected O, but got I
		//IL_0365: Expected O, but got I
		//IL_0630: Expected O, but got I4
		//IL_03f6: Expected O, but got I4
		//IL_0564: Expected O, but got I
		//IL_056c: Expected I, but got O
		//IL_059c: Expected O, but got I
		//IL_05b6: Expected O, but got I4
		//IL_05bf: Expected F4, but got I4
		//IL_05d8: Expected I, but got O
		//IL_05e1: Expected F4, but got I4
		object obj4;
		object obj6;
		bool flag = default(bool);
		if (flag)
		{
			bool flag2 = !isMyTurn;
			object obj = !flag2;
			if (obj != null)
			{
				return;
			}
			object obj2 = 152973312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E33BF]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v65+E4]");
				bool flag3 = (nint)0 == 0;
				obj6 = obj4;
				if (!flag3)
				{
					goto IL_00b4;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v65+E4]");
				bool flag4 = (nint)0 == 0;
				object obj7 = !flag4;
				obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_00b4;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool allowMyTurnHandAnimation = Preferences.AllowMyTurnHandAnimation;
			bool flag5 = !allowMyTurnHandAnimation;
			obj4 = obj6;
			if (!flag5)
			{
				goto IL_02f1;
			}
			goto IL_034f;
		}
		object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E33BF]");
		object obj9 = (nint)0 & (nint)1;
		if (obj9 != null)
		{
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v19+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0162;
			}
		}
		else
		{
			_ = 1;
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v19+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 != null)
			{
				goto IL_0162;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (Preferences.AllowMyTurnHandAnimation)
		{
			goto IL_0203;
		}
		goto IL_04a0;
		IL_02f1:
		object obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v50+E4]");
		if ((nint)0 != 0)
		{
			Games currentGame = Preferences.CurrentGame;
			bool flag7 = currentGame != Games.Jackaroo;
			obj6 = obj4;
			if (!flag7)
			{
				goto IL_034f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Games currentGame2 = Preferences.CurrentGame;
			bool flag8 = currentGame2 == Games.Jackaroo;
			obj6 = obj4;
			if (flag8)
			{
				goto IL_034f;
			}
		}
		Transform transform = hand.transform;
		int num = ShortcutExtensions.DOKill(transform);
		Transform transform2 = hand.transform;
		float num2 = originalHandYPos + 24f;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(transform2, num2, 0.3f);
		object obj13 = (nint)0 + (nint)2904;
		nint num3 = (nint)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		hand.PlayItsMyTurnSound();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E33C0]");
		object obj14 = (nint)0 & (nint)1;
		bool flag9 = obj14 == null;
		object obj15 = !flag9;
		float num4 = 1.0502537E+09f;
		flag = false;
		obj6 = obj4;
		nint num5 = (nint)obj13;
		float num6 = 1.0502537E+09f;
		float num7 = num2;
		bool flag10 = false;
		if (obj15 != null)
		{
			goto IL_03aa;
		}
		goto IL_0600;
		IL_03d7:
		bool allowVibration = Preferences.AllowVibration;
		bool flag11 = !allowVibration;
		object obj16 = !flag11;
		if (obj16 != null)
		{
			goto IL_068f;
		}
		goto IL_069f;
		IL_065e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (Preferences.AllowVibration)
		{
			goto IL_068f;
		}
		goto IL_069f;
		IL_03aa:
		object obj17 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v34+E4]");
		if ((nint)0 != 0)
		{
			goto IL_03d7;
		}
		goto IL_065e;
		IL_0162:
		bool allowMyTurnHandAnimation2 = Preferences.AllowMyTurnHandAnimation;
		bool flag12 = !allowMyTurnHandAnimation2;
		object obj18 = !flag12;
		if (obj18 != null)
		{
			goto IL_0203;
		}
		goto IL_04a0;
		IL_0203:
		object obj19 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			Games currentGame3 = Preferences.CurrentGame;
			if (currentGame3 != Games.Jackaroo)
			{
				goto IL_043e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Games currentGame4 = Preferences.CurrentGame;
			if (currentGame4 != Games.Jackaroo)
			{
				goto IL_043e;
			}
		}
		goto IL_04a0;
		IL_069f:
		isMyTurn = true;
		return;
		IL_068f:
		hand.PlayItsMyTurnVibration();
		goto IL_069f;
		IL_043e:
		Transform transform3 = hand.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOLocalMoveY(transform3, originalHandYPos, 0.15f);
		object obj20 = (nint)0 + (nint)2776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		object obj21 = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		goto IL_04a0;
		IL_04a0:
		isMyTurn = false;
		return;
		IL_0600:
		_ = 1;
		obj17 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v34+E4]");
		bool flag13 = (nint)0 == 0;
		object obj22 = !flag13;
		num3 = num5;
		num4 = num6;
		num2 = num7;
		flag = flag10;
		if (obj22 != null)
		{
			goto IL_03d7;
		}
		goto IL_065e;
		IL_00b4:
		bool allowMyTurnHandAnimation3 = Preferences.AllowMyTurnHandAnimation;
		bool flag14 = !allowMyTurnHandAnimation3;
		object obj23 = !flag14;
		if (obj23 != null)
		{
			goto IL_02f1;
		}
		obj6 = obj4;
		goto IL_034f;
		IL_034f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E33C0]");
		object obj24 = (nint)0 & (nint)1;
		bool flag15 = obj24 == null;
		num5 = num3;
		num6 = num4;
		num7 = num2;
		flag10 = flag;
		obj4 = obj6;
		if (!flag15)
		{
			goto IL_03aa;
		}
		goto IL_0600;
	}
}
