using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Spine;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public class SlideShowCatchPage : SlideShowCommonsPage
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Transform> <>9__10_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <HideElements>b__10_0(Transform t)
		{
			//IL_001d: Expected O, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			t.localEulerAngles = (Vector3)0;
		}
	}

	private sealed class <>c__DisplayClass7_0
	{
		public DG.Tweening.Sequence seq;

		public SlideShowCatchPage <>4__this;

		internal void <AnimateShowElements>b__0(Transform card)
		{
			//IL_0012: Expected O, but got I
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0043: Expected O, but got I
			//IL_005a: Expected F4, but got O
			//IL_005a: Expected O, but got I4
			object obj = (nint)0 + (nint)2744;
			object obj2 = typeof(UsageHint) + 816;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5+B8]");
			object obj4 = 0;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(card, (Vector3)0, (float)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
			Tween t = default(Tween);
			DG.Tweening.Sequence sequence = TweenSettingsExtensions.Join(seq, t);
		}

		internal void <AnimateShowElements>b__1()
		{
			//IL_0011: Expected O, but got I
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_0051: Expected O, but got I
			//IL_0075: Expected F4, but got I
			//IL_0075: Expected O, but got I4
			SlideShowCatchPage slideShowCatchPage = <>4__this;
			object obj = (nint)0 + (nint)3032;
			object obj2 = typeof(UsageHint) + 816;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+B8]");
			object obj4 = 0;
			Transform glass = slideShowCatchPage.glass;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v7+48]");
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(glass, (Vector3)0, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30593E4");
		}

		internal void <AnimateShowElements>b__2()
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			SlideShowCatchPage slideShowCatchPage = <>4__this;
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			PlayerRank playerRank = default(PlayerRank);
			playerRank..ctor(Games.Baloot, 34210);
			slideShowCatchPage.meter.InitializeMeter(playerRank);
		}
	}

	private sealed class <>c__DisplayClass8_0
	{
		public DG.Tweening.Sequence seq;

		internal void <AnimateHideElements>b__0(Transform card)
		{
			//IL_0012: Expected O, but got I
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0043: Expected O, but got I
			//IL_0072: Expected O, but got I4
			object obj = (nint)0 + (nint)2744;
			object obj2 = typeof(UsageHint) + 816;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v6+48]");
			float duration = 0f * 0f;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(card, (Vector3)0, duration);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
			Tween t = default(Tween);
			DG.Tweening.Sequence sequence = TweenSettingsExtensions.Join(seq, t);
		}
	}

	private Transform[] cards;

	private Transform glass;

	private PointsMeter meter;

	private static PlayerRank MeterFill
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			PlayerRank playerRank = default(PlayerRank);
			playerRank..ctor(Games.Baloot, 34210);
			return playerRank;
		}
	}

	private static PlayerRank MeterEmpty
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			PlayerRank playerRank = default(PlayerRank);
			playerRank..ctor(Games.Baloot, 0);
			return playerRank;
		}
	}

	protected override Tween AnimateShowElements()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0095: Expected O, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0106: Expected I, but got O
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_025d: Expected O, but got I
		//IL_027e: Expected F4, but got I
		//IL_027e: Expected O, but got I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0153: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_02ca: Expected O, but got I
		//IL_02e1: Expected F4, but got O
		//IL_02e1: Expected O, but got I4
		//IL_0184: Expected I, but got O
		//IL_0199: Expected O, but got I
		//IL_01bd: Expected I, but got O
		//IL_01d7: Expected O, but got I
		//IL_01f1: Expected O, but got I
		//IL_0207: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3856;
			object obj5 = (nint)0 + (nint)3888;
			object obj6 = obj2 + 24;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DG.Tweening.Sequence sequence = DOTween.Sequence();
			object obj9 = obj2 + 16;
			obj9 = sequence;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			HideElements();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj5);
			ArraysExtensions.ForEach(cards, action);
			object obj10 = typeof(UsageHint) + 816;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v7+B8]");
			object obj12 = 0;
			Transform target = glass;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v8+54]");
			TweenerCore<Quaternion, Vector3, QuaternionOptions> t = ShortcutExtensions.DOLocalRotate(target, (Vector3)0, 0f);
			DG.Tweening.Sequence sequence2 = TweenSettingsExtensions.Append((DG.Tweening.Sequence)obj9, t);
			if ((object)meter != null)
			{
				object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				object obj14 = (nint)0 + (nint)3896;
				object obj15 = (nint)0 + (nint)3904;
				Transform target2 = meter.transform;
				object obj16 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v13+B8]");
				object obj17 = 0;
				TweenerCore<Quaternion, Vector3, QuaternionOptions> t2 = ShortcutExtensions.DOLocalRotate(target2, (Vector3)0, (float)obj17);
				DG.Tweening.Sequence sequence3 = TweenSettingsExtensions.Join((DG.Tweening.Sequence)obj9, t2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				TweenCallback tweenCallback = default(TweenCallback);
				tweenCallback..ctor(obj2, (IntPtr)obj14);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+10]");
				DG.Tweening.Sequence sequence4 = TweenSettingsExtensions.AppendCallback((DG.Tweening.Sequence)0, tweenCallback);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				TweenCallback tweenCallback2 = default(TweenCallback);
				tweenCallback2..ctor(obj2, (IntPtr)obj15);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+10]");
				DG.Tweening.Sequence sequence5 = TweenSettingsExtensions.AppendCallback((DG.Tweening.Sequence)0, tweenCallback2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+10]");
				DG.Tweening.Sequence sequence6 = TweenSettingsExtensions.AppendInterval((DG.Tweening.Sequence)0, 0.3f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+10]");
				return (Tween)0;
			}
		}
		return (Tween)(object)new NullReferenceException();
	}

	protected override Tween AnimateHideElements()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_0129: Expected I4, but got O
		//IL_0148: Expected I, but got O
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_0214: Expected I4, but got O
		//IL_02c9: Expected O, but got I8
		//IL_025f: Expected I, but got O
		//IL_0303: Expected O, but got I
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_0323: Expected O, but got I
		//IL_032f: Expected O, but got I
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_0382: Expected I, but got O
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 240;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		int num = ShortcutExtensions.DOKill(glass);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence sequence = DOTween.Sequence();
		bool flag2 = obj3 == null;
		int num2 = 0;
		bool flag3 = false;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag2)
		{
			object obj6 = typeof(SqlSingle[]) + 336;
			object obj7 = obj3 + 16;
			obj7 = sequence;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			IEnumerable<object> enumerable = default(IEnumerable<object>);
			bool flag4 = enumerable == null;
			num2 = 0;
			flag3 = true;
			if (!flag4)
			{
				bool flag5 = (byte)(int)(~glass) != 0;
				bool flag6 = true;
				if (!flag5)
				{
					nint num3 = (nint)enumerable;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
					flag6 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag7 = ex == null;
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
					flag3 = false;
					if (flag7)
					{
						goto IL_03dd;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v20 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
				bool flag8 = (nint)0 == 0;
				num2 = 0;
				flag3 = flag6;
				if (flag8)
				{
					goto IL_03cf;
				}
				object obj8 = enumerable + 32;
				obj8 = glass;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag9 = (object)meter == null;
				num2 = 0;
				flag3 = (byte)(int)glass != 0;
				if (!flag9)
				{
					Transform transform = meter.transform;
					bool flag10 = (object)transform == null;
					bool flag11 = false;
					if (!flag10)
					{
						nint num4 = (nint)enumerable;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v14 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
						flag11 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag12 = ex == null;
						num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v14 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
						flag3 = false;
						if (flag12)
						{
							goto IL_03dd;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v20 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
					object obj9 = 0 & 0xFFFFFFFEL;
					bool flag13 = obj9 == null;
					num2 = 0;
					flag3 = flag11;
					if (flag13)
					{
						goto IL_03cf;
					}
					object obj10 = (nint)0 + (nint)3040;
					object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3856;
					object obj12 = (nint)0 + (nint)3912;
					object obj13 = (nint)0 + (nint)2400;
					object obj14 = enumerable + 40;
					obj14 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					IEnumerable<object> enumeration = Enumerable.Union(cards, enumerable);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Action<object> action = default(Action<object>);
					action..ctor(obj3, (IntPtr)obj12);
					ArraysExtensions.ForEach(enumeration, action);
					object obj15 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					PlayerRank playerRank = default(PlayerRank);
					playerRank..ctor(Games.Baloot, 0);
					bool flag14 = (object)meter == null;
					num2 = 0;
					flag3 = false;
					if (!flag14)
					{
						meter.InitializeMeter(playerRank);
						return (Tween)obj7;
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_03cf;
		IL_03cf:
		ex = new IndexOutOfRangeException();
		goto IL_03dd;
		IL_03dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (Tween)(object)new OutOfMemoryException();
	}

	public override void SetHidden()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		base.SetHidden();
		HideElements();
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(Games.Baloot, 0);
		meter.InitializeMeter(playerRank);
	}

	private void HideElements()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_042b: Expected O, but got I4
		//IL_0033: Expected O, but got I4
		//IL_0049: Expected I, but got O
		//IL_0059: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_019a: Expected O, but got I8
		//IL_0139: Expected I, but got O
		//IL_0149: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_01c3: Expected O, but got I
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_02e3: Expected O, but got I
		//IL_02f3: Expected O, but got I
		//IL_0303: Expected O, but got I
		//IL_0325: Expected O, but got I4
		//IL_0345: Expected O, but got I
		//IL_0248: Expected O, but got I
		//IL_0258: Expected O, but got I
		//IL_0268: Expected O, but got I
		//IL_028a: Expected O, but got I4
		//IL_037d: Expected O, but got I4
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected O, but got Unknown
		//IL_0471: Expected O, but got I
		//IL_0482: Expected I, but got O
		//IL_04a0: Expected O, but got I
		//IL_02b8: Expected O, but got I
		//IL_03ad: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		bool flag = enumerable == null;
		Transform transform = (Transform)2;
		if (flag)
		{
			goto IL_03cf;
		}
		bool flag2 = (object)glass == null;
		transform = (Transform)2;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		Transform transform2;
		if (!flag2)
		{
			nint num = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			transform = (Transform)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag3 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			transform2 = (Transform)0;
			if (flag3)
			{
				goto IL_03f3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		object obj5;
		object obj9;
		Action<object> action;
		IEnumerable<object> enumeration;
		IEnumerable<object> enumerable3;
		object obj11;
		object obj8;
		if ((nint)0 != 0)
		{
			object obj2 = enumerable + 32;
			obj2 = glass;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag4 = (object)meter == null;
			transform = glass;
			if (flag4)
			{
				goto IL_03cf;
			}
			Transform transform3 = meter.transform;
			bool flag5 = (object)transform3 == null;
			transform = null;
			if (!flag5)
			{
				nint num2 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v23 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				transform = (Transform)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag6 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v23 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				transform2 = (Transform)0;
				if (flag6)
				{
					goto IL_03f3;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
			object obj3 = 0 & 0xFFFFFFFEL;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)3040;
				obj5 = typeof(SkeletonBinary.SkeletonInput) + 224;
				object obj6 = enumerable + 40;
				obj6 = transform3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				IEnumerable<object> enumerable2 = Enumerable.Union(cards, enumerable);
				object obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v26+E4]");
				if ((nint)0 != 0)
				{
					obj8 = (nint)0 + (nint)2400;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v26+B8]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13+8]");
					action = (Action<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13+8]");
					bool flag7 = (nint)0 == 0;
					object obj10 = !flag7;
					enumeration = enumerable2;
					if (obj10 == null)
					{
						enumerable3 = enumerable2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13+8]");
						Action<object> action2 = (Action<object>)0;
						obj11 = obj8;
						goto IL_035b;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj7 = obj5;
					obj11 = (nint)0 + (nint)2400;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v26+B8]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13+8]");
					Action<object> action2 = (Action<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13+8]");
					bool flag8 = (nint)0 == 0;
					object obj12 = !flag8;
					enumerable3 = enumerable2;
					enumeration = enumerable2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13+8]");
					action = (Action<object>)0;
					obj8 = obj11;
					if (obj12 == null)
					{
						goto IL_035b;
					}
				}
				goto IL_0439;
			}
		}
		goto IL_03dd;
		IL_03f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0439:
		ArraysExtensions.ForEach(enumeration, action);
		return;
		IL_035b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v26+E4]");
		bool flag9 = (nint)0 == 0;
		object obj13 = !flag9;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v19+B8]");
			obj9 = 0;
		}
		object obj15 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)3880;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj9, (IntPtr)obj16);
		object obj17 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v18+B8]");
		object obj18 = (nint)0 + (nint)8;
		obj18 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		enumeration = enumerable3;
		action = action3;
		obj8 = obj11;
		goto IL_0439;
		IL_03dd:
		ex = new IndexOutOfRangeException();
		transform2 = transform;
		goto IL_03f3;
		IL_03cf:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_03dd;
	}
}
