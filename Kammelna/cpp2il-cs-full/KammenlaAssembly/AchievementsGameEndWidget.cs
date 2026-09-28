using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Xml.Schema;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class AchievementsGameEndWidget : GameEndWidget
{
	private sealed class <>c__DisplayClass13_0
	{
		public AchievementsGameEndWidget <>4__this;

		public Sequence mainSequence;

		public TweenCallback <>9__2;

		internal void <AnimateAchievements>b__0(EndGameAchievementItem item)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0099: Expected O, but got I4
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Expected O, but got Unknown
			//IL_00ee: Expected O, but got I
			//IL_012a: Expected O, but got I4
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Expected O, but got Unknown
			//IL_0186: Expected O, but got I
			//IL_01a5: Expected O, but got I
			//IL_01db: Expected O, but got I
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Expected O, but got Unknown
			//IL_0215: Expected O, but got I
			//IL_0227: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Expected O, but got Unknown
			//IL_0251: Expected O, but got I4
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_026a: Expected O, but got Unknown
			//IL_0278: Expected O, but got I4
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0291: Expected O, but got Unknown
			//IL_029d: Expected O, but got I
			//IL_02b5: Expected O, but got I
			//IL_02c3: Expected O, but got I4
			//IL_02e3: Expected I, but got O
			//IL_0330: Expected O, but got I
			//IL_033c: Expected O, but got I
			//IL_0348: Expected O, but got I
			//IL_0350: Expected I, but got O
			//IL_03f2: Expected I, but got O
			//IL_040e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0413: Expected O, but got Unknown
			//IL_0435: Expected O, but got I4
			//IL_043e: Expected O, but got I4
			//IL_04d0: Expected I, but got O
			//IL_0462: Expected O, but got I
			//IL_0470: Expected I, but got O
			//IL_0505: Expected O, but got I
			//IL_0492: Expected O, but got I4
			//IL_0535: Expected O, but got I
			//IL_0546: Expected I, but got O
			object obj = typeof(XmlSchemaInclude) + 3808;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj4 = obj2 + 48;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 40;
			obj5 = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence = DOTween.Sequence();
			AchievementsGameEndWidget achievementsGameEndWidget = <>4__this;
			object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj9 = (nint)0 + (nint)912;
			RectTransform rectTransform = UIExtensions.rectTransform(achievementsGameEndWidget.stampsTarget);
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
			object obj12 = obj2 + 16;
			object obj13 = default(object);
			obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X22_v8+18]");
			object obj14 = 0;
			object obj15 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v7+50]");
			((EndGameAchievementItem)obj15).Populate((GameAchievementViewModel)0, visible: true);
			GameObject gameObject = ((Component)obj12).gameObject;
			gameObject.SetActive(value: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (System.Object)+28]");
			RectTransform rectTransform2 = UIExtensions.rectTransform((Component)0);
			object obj16 = obj2 + 32;
			obj16 = rectTransform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (System.Object)+10]");
			RectTransform rectTransform3 = UIExtensions.rectTransform((Component)0);
			object obj17 = obj2 + 24;
			obj17 = rectTransform3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			((RectTransform)obj17).pivot = (Vector2)0;
			object obj18 = typeof(UsageHint) + 816;
			((Transform)obj17).position = (Vector3)0;
			object obj19 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			object obj20 = (nint)0 + (nint)2128;
			object obj21 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v20+B8]");
			object obj22 = 0;
			((Transform)obj17).localScale = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(obj2, (IntPtr)obj20);
			Sequence sequence2 = TweenSettingsExtensions.AppendCallback(sequence, tweenCallback);
			AchievementsGameEndWidget achievementsGameEndWidget2 = <>4__this;
			object stampsTarget = achievementsGameEndWidget2.stampsTarget;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj23 = (nint)0 + (nint)2904;
			object obj24 = (nint)0 + (nint)1752;
			object obj25 = (nint)0 + (nint)2136;
			nint num = (nint)stampsTarget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v23 (Il2CppClass<System.Object>)+190]");
			TweenCallback tweenCallback2 = default(TweenCallback);
			tweenCallback2..ctor(stampsTarget, (IntPtr)0);
			Sequence sequence3 = TweenSettingsExtensions.AppendCallback(sequence, tweenCallback2);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale((Transform)obj17, 5.5f, 0.4f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Tween t = default(Tween);
			Sequence sequence4 = TweenSettingsExtensions.Append(sequence, t);
			Sequence sequence5 = TweenSettingsExtensions.AppendInterval(sequence, 4f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TweenCallback tweenCallback3 = default(TweenCallback);
			tweenCallback3..ctor(<>4__this, (IntPtr)obj24);
			Sequence sequence6 = TweenSettingsExtensions.AppendCallback(sequence, tweenCallback3);
			object obj26 = this + 32;
			TweenCallback callback = (TweenCallback)obj26;
			bool flag3 = obj26 == null;
			object obj27 = !flag3;
			object obj28 = 0;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj29 = (nint)0 + (nint)2120;
				TweenCallback tweenCallback4 = default(TweenCallback);
				tweenCallback4..ctor(this, (IntPtr)obj29);
				<>9__2 = tweenCallback4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj28 = 0;
				callback = tweenCallback4;
			}
			Sequence sequence7 = TweenSettingsExtensions.AppendCallback(sequence, callback);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TweenCallback tweenCallback5 = default(TweenCallback);
			tweenCallback5..ctor(obj2, (IntPtr)obj25);
			Sequence sequence8 = TweenSettingsExtensions.AppendCallback(sequence, tweenCallback5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (System.Object)+18]");
			TweenerCore<Vector3, Vector3, VectorOptions> t2 = ShortcutExtensions.DOScale((Transform)0, 1f, 0.4f);
			Sequence sequence9 = TweenSettingsExtensions.Append(sequence, t2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj30 = (nint)0 + (nint)2144;
			TweenCallback tweenCallback6 = default(TweenCallback);
			tweenCallback6..ctor(obj2, (IntPtr)obj30);
			Sequence sequence10 = TweenSettingsExtensions.AppendCallback(sequence, tweenCallback6);
			Sequence sequence11 = TweenSettingsExtensions.Append(mainSequence, sequence);
			Sequence sequence12 = TweenSettingsExtensions.AppendInterval(mainSequence, 0.4f);
		}

		internal void <AnimateAchievements>b__2()
		{
			//IL_0029: Expected I, but got O
			//IL_0039: Expected O, but got I
			//IL_0049: Expected O, but got I
			AchievementsGameEndWidget achievementsGameEndWidget = <>4__this;
			PopupUI stampsTarget = achievementsGameEndWidget.stampsTarget;
			nint num = (nint)stampsTarget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v2 (Il2CppClass<PopupUI>)+198]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v2 (Il2CppClass<PopupUI>)+1A0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v30 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass13_1
	{
		public EndGameAchievementItem clone;

		public RectTransform cloneTransform;

		public RectTransform itemTransform;

		public EndGameAchievementItem item;

		public <>c__DisplayClass13_0 CS$<>8__locals1;

		internal void <AnimateAchievements>b__1()
		{
			//IL_00b9: Expected O, but got I
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_0100: Expected O, but got I
			//IL_0120: Expected I, but got O
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Expected O, but got Unknown
			GameObject gameObject = clone.gameObject;
			gameObject.SetActive(value: true);
			EndGameAchievementItem endGameAchievementItem = clone;
			endGameAchievementItem.group.alpha = 1f;
			EndGameAchievementItem endGameAchievementItem2 = clone;
			endGameAchievementItem2.normalView.SetActive(value: false);
			endGameAchievementItem2.bigView.SetActive(value: true);
			<>c__DisplayClass13_0 cS$<>8__locals = CS$<>8__locals1;
			AchievementsGameEndWidget <>4__this = cS$<>8__locals.<>4__this;
			object obj = (nint)0 + (nint)2480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
			SingleSound singleSound = default(SingleSound);
			SoundChannel.PlaySFXSound(singleSound);
			<>c__DisplayClass13_0 cS$<>8__locals2 = CS$<>8__locals1;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = (nint)0 + (nint)1760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(cS$<>8__locals2.<>4__this, (IntPtr)obj3);
			object obj4 = clone + 88;
			Delegate obj5 = (Delegate)obj4;
			bool flag;
			Delegate obj7 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, action);
				if ((object)obj6 == null || obj6 == obj2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj7 == obj5;
					obj5 = obj7;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}

		internal void <AnimateAchievements>b__3()
		{
			//IL_0011: Expected O, but got I
			//IL_0039: Expected O, but got I4
			object obj = (nint)0 + (nint)2904;
			Vector3 position = itemTransform.position;
			float duration = default(float);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOMove(cloneTransform, (Vector3)0, duration);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		}

		internal void <AnimateAchievements>b__4()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Expected O, but got I
			//IL_0045: Expected I, but got O
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Expected O, but got Unknown
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Expected O, but got Unknown
			//IL_0118: Expected O, but got I4
			<>c__DisplayClass13_0 cS$<>8__locals = CS$<>8__locals1;
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)1760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(cS$<>8__locals.<>4__this, (IntPtr)obj2);
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = clone + 88;
			Delegate obj5 = (Delegate)obj4;
			bool flag;
			Delegate obj7 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, action);
				Delegate obj8;
				if ((object)obj6 == null || obj6 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj7 == obj5;
					obj5 = obj7;
					obj8 = obj7;
					continue;
				}
				obj8 = null;
				throw new InvalidCastException();
			}
			while (!flag);
			GameObject gameObject = clone.gameObject;
			object obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			UnityEngine.Object obj11 = gameObject;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = gameObject;
			}
			UnityEngine.Object.Destroy(obj11);
			EndGameAchievementItem endGameAchievementItem = item;
			endGameAchievementItem.group.alpha = 1f;
		}
	}

	private GameEndPopup manager;

	private LayoutElement _layoutElement;

	private float widgetHeight;

	public LayoutElement achievementSection;

	public RectTransform achievementsContainer;

	public EndGameAchievementItem achievementItemPrefab;

	public PopupUI stampsTarget;

	private TrophySoundAlbum trophySoundAlbum;

	private List<EndGameAchievementItem> achievementItems;

	public override void PrepareAnimation(CardGameEndScores gameEnd)
	{
		//IL_0009: Expected O, but got I4
		//IL_0015: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_027d: Expected O, but got I
		//IL_029f: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00f4: Expected O, but got I
		//IL_006a: Expected O, but got I
		//IL_0381: Expected O, but got I4
		//IL_02d9: Expected O, but got I
		//IL_02e9: Expected O, but got I
		//IL_02ff: Expected O, but got I
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0327: Expected O, but got I4
		//IL_0347: Expected O, but got I
		//IL_0157: Expected O, but got I
		//IL_0167: Expected O, but got I
		//IL_017d: Expected O, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_01a5: Expected O, but got I4
		//IL_01b5: Expected O, but got I
		//IL_01f2: Expected O, but got I
		//IL_03b9: Expected O, but got I
		//IL_03c9: Expected O, but got I
		//IL_03df: Expected O, but got I
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected O, but got Unknown
		//IL_022b: Expected I, but got O
		//IL_023b: Expected O, but got I
		//IL_024b: Expected O, but got I
		//IL_0422: Expected O, but got I
		object obj = 152985600;
		object obj2 = (nint)0 + (nint)3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6758]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_0255;
		}
		RectTransform rectTransform = achievementsContainer;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X21_v11+38]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X21_v11+38]");
		bool flag = (nint)0 == 0;
		object obj6 = obj4;
		RectTransform rectTransform2 = achievementsContainer;
		if (!flag)
		{
			goto IL_00a1;
		}
		goto IL_02bf;
		IL_039f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X21_v3+38]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v3+10]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v3+10]");
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag2 = obj10 == null;
		rectTransform = rectTransform2;
		if (flag2)
		{
			goto IL_01cb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v3+10]");
		object obj11 = 0;
		Transform transform = rectTransform2;
		goto IL_01e2;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v27+10]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v27+10]");
		object obj13 = (nint)0 + (nint)309;
		object obj14 = obj13 & 1;
		bool flag3 = obj14 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v27+10]");
		object obj15 = 0;
		obj6 = obj4;
		rectTransform2 = rectTransform;
		if (!flag3)
		{
			goto IL_0112;
		}
		goto IL_0355;
		IL_0112:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		obj6 = obj4;
		rectTransform2 = rectTransform;
		if (!flag4)
		{
			goto IL_0147;
		}
		goto IL_039f;
		IL_0147:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X21_v11+38]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v22+10]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v22+10]");
		object obj17 = (nint)0 + (nint)309;
		object obj18 = obj17 & 1;
		bool flag5 = obj18 == null;
		object obj19 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v22+10]");
		obj11 = 0;
		transform = rectTransform;
		if (obj19 == null)
		{
			goto IL_01cb;
		}
		goto IL_01e2;
		IL_01cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		transform = rectTransform;
		goto IL_01e2;
		IL_01e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v13+B8]");
		object except = 0;
		UIExtensions.DestroyAllChildren(transform, (GameObject[])except);
		_layoutElement.preferredHeight = 0f;
		LayoutElement layoutElement = _layoutElement;
		nint num = (nint)layoutElement;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v18 (Il2CppClass<UnityEngine.UI.LayoutElement>)+358]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v18 (Il2CppClass<UnityEngine.UI.LayoutElement>)+360]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v147 @ X2_v2 (should have been resolved before IL gen)");
		goto IL_0255;
		IL_0255:
		_ = 1;
		rectTransform = achievementsContainer;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X21_v11+38]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X21_v11+38]");
		bool flag6 = (nint)0 == 0;
		object obj22 = !flag6;
		obj6 = obj4;
		rectTransform2 = achievementsContainer;
		if (obj22 != null)
		{
			goto IL_00a1;
		}
		goto IL_02bf;
		IL_02bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X21_v3+38]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v9+10]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v9+10]");
		object obj24 = (nint)0 + (nint)309;
		object obj25 = obj24 & 1;
		bool flag7 = obj25 == null;
		object obj26 = !flag7;
		obj4 = obj6;
		rectTransform = rectTransform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v9+10]");
		obj15 = 0;
		if (obj26 != null)
		{
			goto IL_0112;
		}
		goto IL_0355;
		IL_0355:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v1+E4]");
		bool flag8 = (nint)0 == 0;
		object obj27 = !flag8;
		obj4 = obj6;
		rectTransform = rectTransform2;
		if (obj27 != null)
		{
			goto IL_0147;
		}
		goto IL_039f;
	}

	public override void Populate(CardGameEndScores rankReport)
	{
	}

	public override Sequence AnimatedPopulate(CardGameEndScores rankReport)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_006c: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_00e0: Expected O, but got I4
		//IL_0123: Expected O, but got I4
		GameObject gameObject = base.gameObject;
		if ((object)gameObject != null)
		{
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj2 = (nint)0 + (nint)2872;
			gameObject.SetActive(value: true);
			InitAchievements(rankReport);
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence = DOTween.Sequence();
			TweenerCore<Vector2, Vector2, VectorOptions> t = DOTweenModuleUI.DOPreferredSize(_layoutElement, (Vector2)0, 0f);
			Sequence sequence2 = TweenSettingsExtensions.Append(sequence, t);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOMinSize(achievementSection, (Vector2)0, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Tween t2 = default(Tween);
			Sequence sequence3 = TweenSettingsExtensions.Append(sequence, t2);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOPreferredSize(achievementSection, (Vector2)0, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Tween t3 = default(Tween);
			Sequence sequence4 = TweenSettingsExtensions.Join(sequence, t3);
			Sequence sequence5 = TweenSettingsExtensions.AppendInterval(sequence, 0.8f);
			Sequence t4 = AnimateAchievements(null);
			Sequence sequence6 = TweenSettingsExtensions.Append(sequence, t4);
			return sequence;
		}
		return (Sequence)(object)new NullReferenceException();
	}

	public override bool ShouldShow(CardGameEndScores rankReport)
	{
		//IL_00c8: Expected I4, but got O
		//IL_00a8: Expected O, but got I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected I4, but got Unknown
		if (rankReport != null)
		{
			List<GameAchievementViewModel> achievements = rankReport.Achievements;
			if (achievements != null)
			{
				bool flag = achievements._size < 0;
				bool flag2 = achievements._size == 0;
				int num = achievements._size ^ achievements._size;
				int num2 = achievements._size & num;
				bool flag3 = num2 < 0;
				bool flag4 = flag == flag3;
				object obj = !flag2;
				return (byte)((flag4 & obj) ? 1 : 0) != 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private Sequence AnimateAchievements(Sequence sequence)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0094: Expected O, but got I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_0111: Expected I, but got O
		object obj = typeof(XmlSchemaInclude) + 3800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1904;
			object obj5 = (nint)0 + (nint)2112;
			object obj6 = obj2 + 16;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence2 = DOTween.Sequence();
			object obj9 = obj2 + 24;
			obj9 = sequence2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Sequence sequence3 = TweenSettingsExtensions.AppendInterval((Sequence)obj9, 0.3f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj5);
			if (achievementItems != null)
			{
				((List<object>)(object)achievementItems).ForEach(action);
				return (Sequence)obj9;
			}
		}
		return (Sequence)(object)new NullReferenceException();
	}

	private void InitAchievements(CardGameEndScores gameEnd)
	{
		//IL_0009: Expected O, but got I4
		//IL_0015: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_0311: Expected O, but got I
		//IL_0333: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00f4: Expected O, but got I
		//IL_006a: Expected O, but got I
		//IL_0415: Expected O, but got I4
		//IL_036d: Expected O, but got I
		//IL_037d: Expected O, but got I
		//IL_0393: Expected O, but got I
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_03bb: Expected O, but got I4
		//IL_03db: Expected O, but got I
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0173: Expected O, but got I
		//IL_0183: Expected O, but got I
		//IL_0199: Expected O, but got I
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01c1: Expected O, but got I4
		//IL_01ee: Expected O, but got I
		//IL_0225: Expected O, but got I4
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_026c: Expected O, but got I
		//IL_0278: Expected O, but got I
		//IL_02a3: Expected I, but got O
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = (nint)0 + (nint)3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E675C]");
		object obj3 = (nint)0 & (nint)1;
		RectTransform rectTransform;
		object obj6;
		RectTransform rectTransform2;
		object obj4;
		if (obj3 != null)
		{
			rectTransform = achievementsContainer;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X22_v7+38]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X22_v7+38]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			rectTransform2 = achievementsContainer;
			if (!flag)
			{
				goto IL_00a1;
			}
		}
		else
		{
			_ = 1;
			rectTransform = achievementsContainer;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X22_v7+38]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X22_v7+38]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			rectTransform2 = achievementsContainer;
			if (obj7 != null)
			{
				goto IL_00a1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X22_v3+38]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v6+10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v6+10]");
		object obj10 = (nint)0 + (nint)309;
		object obj11 = obj10 & 1;
		bool flag3 = obj11 == null;
		object obj12 = !flag3;
		obj4 = obj6;
		rectTransform = rectTransform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v6+10]");
		object obj13 = 0;
		if (obj12 != null)
		{
			goto IL_0112;
		}
		goto IL_03e9;
		IL_014f:
		object obj14 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X22_v7+38]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v12+10]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v12+10]");
		object obj17 = (nint)0 + (nint)309;
		object obj18 = obj17 & 1;
		bool flag4 = obj18 == null;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v29+B8]");
		object except = 0;
		Transform transform;
		UIExtensions.DestroyAllChildren(transform, (GameObject[])except);
		object obj20 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v31+E4]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.RemoveMyselfFromCache();
		object obj22 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1256;
		object obj23 = (nint)0 + (nint)1744;
		object obj24 = (nint)0 + (nint)3304;
		List<GameAchievementViewModel> achievements = gameEnd.Achievements;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor((object)this, (IntPtr)obj23);
		IEnumerable<object> source = Enumerable.Select(achievements, func);
		List<object> list = Enumerable.ToList(source);
		object obj25 = this + 104;
		obj25 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_043b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj6;
		Transform transform2;
		transform = transform2;
		goto IL_014f;
		IL_0112:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v1+E4]");
		bool flag6 = (nint)0 == 0;
		transform = rectTransform;
		obj6 = obj4;
		transform2 = rectTransform;
		if (!flag6)
		{
			goto IL_014f;
		}
		goto IL_043b;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v19+10]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v19+10]");
		object obj26 = (nint)0 + (nint)309;
		object obj27 = obj26 & 1;
		bool flag7 = obj27 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v19+10]");
		obj13 = 0;
		obj6 = obj4;
		rectTransform2 = rectTransform;
		if (!flag7)
		{
			goto IL_0112;
		}
		goto IL_03e9;
		IL_03e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v1+E4]");
		bool flag8 = (nint)0 == 0;
		object obj28 = !flag8;
		obj4 = obj6;
		transform = rectTransform2;
		transform2 = rectTransform2;
		if (obj28 != null)
		{
			goto IL_014f;
		}
		goto IL_043b;
	}

	private void SpeedUpSeq()
	{
		GameEndPopup gameEndPopup = manager;
		Sequence animationSequence = gameEndPopup.animationSequence;
		if (gameEndPopup.animationSequence != null)
		{
			animationSequence.timeScale = 20f;
		}
	}

	private void SlowDownSeq()
	{
		GameEndPopup gameEndPopup = manager;
		Sequence animationSequence = gameEndPopup.animationSequence;
		if (gameEndPopup.animationSequence != null)
		{
			animationSequence.timeScale = 1f;
		}
	}

	private void PlayAchievementSound()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	private EndGameAchievementItem <InitAchievements>b__14_0(GameAchievementViewModel achievement)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0103: Expected O, but got I
		//IL_011d: Expected O, but got I
		//IL_0147: Expected O, but got I4
		//IL_015f: Expected O, but got I
		//IL_00de: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_006d: Expected O, but got I
		//IL_00a4: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E675D]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = (nint)0 + (nint)528;
			RectTransform rectTransform = achievementsContainer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X20_v8 (UnityEngine.RectTransform)+50]");
			object obj4 = 0;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X20_v8 (UnityEngine.RectTransform)+50]");
			object obj7 = 0;
			RectTransform rectTransform2 = rectTransform;
			if (!flag)
			{
				goto IL_00ba;
			}
		}
		else
		{
			_ = 1;
			object obj3 = (nint)0 + (nint)528;
			RectTransform rectTransform = achievementsContainer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X20_v8 (UnityEngine.RectTransform)+50]");
			object obj4 = 0;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X20_v8 (UnityEngine.RectTransform)+50]");
			object obj7 = 0;
			RectTransform rectTransform2 = rectTransform;
			if (obj8 != null)
			{
				goto IL_00ba;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		EndGameAchievementItem endGameAchievementItem = default(EndGameAchievementItem);
		if ((object)endGameAchievementItem != null)
		{
			goto IL_01ab;
		}
		goto IL_01fa;
		IL_01fa:
		return (EndGameAchievementItem)(object)new NullReferenceException();
		IL_01ab:
		endGameAchievementItem.Populate(achievement, visible: false);
		Transform transform = endGameAchievementItem.transform;
		if ((object)transform != null)
		{
			transform.SetAsFirstSibling();
			return endGameAchievementItem;
		}
		goto IL_01fa;
		IL_00ba:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		bool flag3 = (object)endGameAchievementItem == null;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_01ab;
		}
		goto IL_01fa;
	}
}
