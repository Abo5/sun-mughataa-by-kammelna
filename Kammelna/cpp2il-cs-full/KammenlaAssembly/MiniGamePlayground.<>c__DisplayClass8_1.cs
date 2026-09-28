using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class MiniGamePlayground : MonoBehaviour
{
	private sealed class <>c__DisplayClass8_0
	{
		public RectTransform zone;

		public MiniGamePlayground <>4__this;

		internal void <DiscardCards>b__0()
		{
			MiniGamePlayground miniGamePlayground = <>4__this;
			MiniGame miniGame = miniGamePlayground.miniGame;
			MiniGameVisuals visuals = miniGame.visuals;
			visuals.Playground.IsReady = true;
		}
	}

	private sealed class <>c__DisplayClass8_1
	{
		public Image dropCard;

		public <>c__DisplayClass8_0 CS$<>8__locals1;

		internal void <DiscardCards>b__1()
		{
			Transform transform = dropCard.transform;
			<>c__DisplayClass8_0 cS$<>8__locals = CS$<>8__locals1;
			transform.SetParent(cS$<>8__locals.zone);
		}
	}

	private GameObject deck;

	private Image shadow;

	private List<Image> deckCards;

	private List<RectTransform> dropZones;

	private MiniGame miniGame;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0140: Expected O, but got I
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0160: Expected O, but got I
		//IL_018a: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0091: Expected O, but got I
		//IL_00c8: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)184;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2760;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 64;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		object obj9 = typeof(Queue<string>) + 848;
		object obj10 = (nint)0 + (nint)2200;
		((MiniGame)obj7).OnInitialized += action;
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int activeCardbackID = SFSKammelnaUserExtensions.GetActiveCardbackID(localUser);
		UIExtensions.LoadItemImage(deckCards, activeCardbackID, ImageCacher.ItemImageType.InGame);
		ResetUi();
	}

	private void ResetUi()
	{
		//IL_0044: Expected F4, but got I4
		//IL_004d: Expected O, but got I4
		//IL_0052: Expected I, but got O
		//IL_0272: Expected I, but got O
		//IL_006d: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00ae: Expected F4, but got O
		//IL_032c: Expected I, but got O
		//IL_012c: Expected I, but got O
		//IL_0149: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_021b: Expected O, but got I4
		//IL_0224: Expected O, but got I4
		//IL_0201: Expected I, but got O
		//IL_00fa: Expected O, but got I
		//IL_011f: Expected O, but got I4
		nint num2 = default(nint);
		object obj3 = default(object);
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		if ((object)deck != null)
		{
			deck.SetActive(value: false);
			UIExtensions.SetAlpha(shadow, 0f);
			bool flag = deckCards == null;
			float num = 0f;
			object obj = 0;
			num2 = unchecked((nint)null);
			if (!flag)
			{
				object obj2 = (nint)0 + (nint)2128;
				obj3 = (nint)0 + (nint)2120;
				List<object>.Enumerator enumerator = ((List<object>)(object)deckCards).GetEnumerator();
				object obj4 = typeof(UsageHint) + 744;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
				num = (float)enumerator2;
				List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
				Graphic graphic = default(Graphic);
				object obj7 = default(object);
				while (true)
				{
					num2 = (nint)obj2;
					if (!enumerator3.MoveNext())
					{
						break;
					}
					if ((object)graphic != null)
					{
						RectTransform rectTransform = graphic.rectTransform;
						if ((object)rectTransform != null)
						{
							object obj5 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v17+B8]");
							object obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v18+10]");
							num = 0f * (float)obj7;
							rectTransform.anchoredPosition = (Vector2)0;
							continue;
						}
						NullReferenceException ex = new NullReferenceException();
						num2 = unchecked((nint)null);
					}
					else
					{
						NullReferenceException ex2 = new NullReferenceException();
					}
					enumerator4 = enumerator2;
					enumerator2 = (List<object>.Enumerator)0;
					obj = 0;
					goto IL_02f9;
				}
				num2 = (nint)obj3;
				enumerator3.Dispose();
				enumerator4 = enumerator2;
				enumerator2 = (List<object>.Enumerator)0;
				obj = 0;
				goto IL_0157;
			}
		}
		goto IL_02f9;
		IL_02f9:
		NullReferenceException ex3 = new NullReferenceException();
		bool flag2 = num2 != 1;
		OutOfMemoryException ex4 = (OutOfMemoryException)(object)ex3;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num2 = (nint)obj3;
			enumerator4.Dispose();
			object obj8 = default(object);
			bool flag3 = obj8 == null;
			List<object>.Enumerator enumerator2 = (List<object>.Enumerator)obj8;
			if (flag3)
			{
				goto IL_0157;
			}
			ex4 = new OutOfMemoryException();
			enumerator2 = (List<object>.Enumerator)obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237004");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0157:
		MiniGame miniGame = this.miniGame;
		if ((object)this.miniGame != null)
		{
			MiniGameVisuals visuals = miniGame.visuals;
			if ((object)miniGame.visuals != null && visuals.Playground != null)
			{
				visuals.Playground.IsReady = false;
				return;
			}
		}
		goto IL_02f9;
	}

	private void OnInitialized()
	{
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		//IL_003e: Expected O, but got I
		//IL_0097: Expected I, but got O
		//IL_009f: Expected I4, but got O
		//IL_00d2: Expected O, but got I4
		//IL_00db: Expected F4, but got I4
		//IL_00e4: Expected F4, but got I4
		//IL_0107: Expected O, but got I
		//IL_0113: Expected O, but got I
		//IL_011f: Expected O, but got I
		//IL_012b: Expected O, but got I
		//IL_013c: Expected O, but got I4
		//IL_0145: Expected F4, but got I4
		//IL_014e: Expected F4, but got I4
		//IL_0156: Expected I4, but got O
		//IL_05f2: Expected O, but got I4
		//IL_0613: Expected O, but got I4
		//IL_016d: Expected I4, but got O
		//IL_01a7: Expected O, but got I4
		//IL_01c0: Expected O, but got I4
		//IL_01f6: Expected I4, but got I8
		//IL_0216: Expected F4, but got I4
		//IL_0216: Expected O, but got I4
		//IL_03a6: Expected O, but got I
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_028b: Expected O, but got I4
		//IL_0294: Expected O, but got I4
		//IL_029f: Expected O, but got I4
		//IL_02a8: Expected F4, but got I4
		//IL_02ba: Expected O, but got I4
		//IL_02c3: Expected O, but got I4
		//IL_02dd: Expected F4, but got I4
		//IL_044b: Expected O, but got I
		//IL_045b: Expected O, but got I
		//IL_0471: Expected O, but got I
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected O, but got Unknown
		//IL_0499: Expected O, but got I4
		//IL_04a9: Expected O, but got I
		//IL_04e8: Expected O, but got I4
		//IL_03db: Expected O, but got I
		//IL_03f1: Expected O, but got I
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0515: Expected O, but got I
		//IL_0525: Expected O, but got I
		//IL_053b: Expected O, but got I
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected O, but got Unknown
		//IL_0563: Expected O, but got I4
		//IL_034c: Expected O, but got I
		//IL_042c: Expected O, but got I
		ResetUi();
		bool flag = (object)deck == null;
		int num = 152985600;
		if (!flag)
		{
			object obj = (nint)0 + (nint)2736;
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			object obj3 = (nint)0 + (nint)2752;
			object obj4 = (nint)0 + (nint)2456;
			deck.SetActive(value: true);
			TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(shadow, 1f, 1.1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(this, (IntPtr)obj3);
			bool flag2 = (byte)(int)obj4 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
			List<object> list = (List<object>)(object)deckCards;
			bool flag3 = deckCards == null;
			object obj5 = 0;
			float num2 = 1.0418651E+09f;
			float num3 = 1.06619206E+09f;
			int num4 = default(int);
			num = num4;
			if (!flag3)
			{
				object obj6 = (nint)0 + (nint)872;
				object obj7 = (nint)0 + (nint)2760;
				obj4 = (nint)0 + (nint)552;
				object obj8 = (nint)0 + (nint)3120;
				object obj10 = default(object);
				object obj9 = obj10;
				object obj11 = 0;
				float num5 = 1.0418651E+09f;
				float num6 = 1.06619206E+09f;
				bool flag4 = (byte)(int)obj4 != 0;
				int num7 = 0;
				object obj14;
				List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
				do
				{
					bool flag5 = num7 >= list._size;
					obj10 = obj9;
					object obj12 = obj11;
					obj5 = 0;
					num2 = num5;
					num3 = num6;
					flag2 = flag4;
					obj3 = 1045220557;
					num = num7;
					if (!flag5)
					{
						flag2 = (byte)(int)obj6 != 0;
						object obj13 = list.get_Item(num7);
						bool flag6 = obj13 == null;
						obj10 = obj9;
						obj12 = obj11;
						obj5 = 0;
						num2 = num5;
						num3 = num6;
						obj3 = 1045220557;
						num = num7;
						if (flag6)
						{
							break;
						}
						RectTransform rectTransform = ((Graphic)obj13).rectTransform;
						int num8 = UnityEngine.Random.Range(-4, 4);
						TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOAnchorPos(rectTransform, (Vector2)0, num8);
						float num9 = (float)num7 * 1.025759E+09f;
						num2 = num9 + 1.04522054E+09f;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
						num = num7 + 1;
						list = (List<object>)(object)deckCards;
						obj12 = obj11 + 4;
						bool flag7 = deckCards == null;
						obj14 = !flag7;
						obj10 = 1045220557;
						obj5 = 0;
						num3 = 1.025759E+09f;
						flag2 = false;
						obj3 = 1045220557;
						obj9 = 1045220557;
						obj11 = obj12;
						num5 = num2;
						num6 = 1.025759E+09f;
						flag4 = false;
						num7 = num;
						continue;
					}
					if (dropZones == null)
					{
						break;
					}
					List<object>.Enumerator enumerator = ((List<object>)(object)dropZones).GetEnumerator();
					while (enumerator2.MoveNext())
					{
						object obj15 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X20_v5+38]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X20_v5+38]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v10+10]");
							object obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v10+10]");
							object obj18 = (nint)0 + (nint)309;
							object obj19 = obj18 & 1;
							if (obj19 == null)
							{
								goto IL_04b7;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v10+10]");
							object obj20 = 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X20_v5+38]");
							object obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v18+10]");
							object obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v18+10]");
							object obj22 = (nint)0 + (nint)309;
							object obj23 = obj22 & 1;
							bool flag8 = obj23 == null;
							object obj24 = !flag8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v18+10]");
							object obj20 = 0;
							if (obj24 == null)
							{
								goto IL_04b7;
							}
						}
						goto IL_04c6;
						IL_04c6:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v11+E4]");
						bool flag9 = (nint)0 == 0;
						object obj25 = !flag9;
						if (obj25 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X20_v5+38]");
						object obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v13+10]");
						object obj27 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v13+10]");
						object obj28 = (nint)0 + (nint)309;
						object obj29 = obj28 & 1;
						bool flag10 = obj29 == null;
						object obj30 = !flag10;
						if (obj30 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v15+B8]");
						object except = 0;
						UIExtensions.DestroyAllChildren(null, (GameObject[])except);
						flag2 = false;
						continue;
						IL_04b7:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						goto IL_04c6;
					}
					enumerator2.Dispose();
					return;
				}
				while (obj14 != null);
			}
		}
		throw new NullReferenceException();
	}

	public void DiscardCards(List<MiniGameCard> selectedCards)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00b0: Expected O, but got I
		//IL_00d9: Expected O, but got I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected I4, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0153: Expected O, but got I4
		//IL_0619: Expected O, but got I
		//IL_0625: Expected O, but got I
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected O, but got Unknown
		//IL_0654: Expected I, but got O
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0223: Expected O, but got I
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_0296: Expected O, but got I4
		//IL_02bf: Expected O, but got I
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_036a: Expected O, but got I
		//IL_0381: Expected I4, but got I8
		//IL_03a1: Expected I4, but got I8
		//IL_03a1: Expected I4, but got I8
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected O, but got Unknown
		//IL_06b7: Expected O, but got I
		//IL_06ca: Expected I4, but got I8
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected O, but got Unknown
		//IL_070c: Expected O, but got I4
		//IL_0441: Expected O, but got I4
		//IL_049b: Expected O, but got I4
		//IL_04d4: Expected O, but got I4
		//IL_04d4: Expected O, but got I
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_051d: Expected O, but got I
		//IL_052e: Expected I, but got O
		//IL_0552: Expected O, but got I4
		//IL_055e: Expected O, but got I
		//IL_05a9: Expected O, but got I4
		//IL_05ba: Expected O, but got I4
		//IL_05dd: Expected O, but got I4
		//IL_05ee: Expected O, but got I4
		//IL_05f7: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		MiniGame miniGame = this.miniGame;
		MiniGameVisuals visuals = miniGame.visuals;
		visuals.Playground.IsReady = false;
		MiniGame miniGame2 = this.miniGame;
		MiniGameState <State>k__BackingField = miniGame2.<State>k__BackingField;
		List<object> list = (List<object>)(object)dropZones;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj5 = (nint)0 + (nint)3504;
		int num = <State>k__BackingField.<RemainingMoves>k__BackingField / list._size;
		object obj6 = num * list._size;
		int index = <State>k__BackingField.<RemainingMoves>k__BackingField - obj6;
		object obj7 = obj5;
		object obj8 = list.get_Item(index);
		object obj9 = obj2 + 16;
		obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v16+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		bool flag2 = selectedCards._size < 1;
		Tween tween = (Tween)obj8;
		if (!flag2)
		{
			object obj13 = default(object);
			object obj12 = obj13;
			double num3 = default(double);
			double num2 = num3;
			double num5 = default(double);
			double num4 = num5;
			object obj15 = default(object);
			object obj14 = obj15;
			object obj17 = default(object);
			object obj16 = obj17;
			object obj19 = default(object);
			object obj18 = obj19;
			object obj20 = obj7;
			object obj21 = obj8;
			int num6 = 0;
			object obj23 = default(object);
			object obj32 = default(object);
			TweenCallback tweenCallback = default(TweenCallback);
			bool flag5;
			do
			{
				object obj22 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3736;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj23..ctor();
				object obj24 = obj23 + 24;
				obj24 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj25 = (nint)0 + (nint)448;
				object obj26 = ((List<object>)(object)selectedCards).get_Item(num6);
				Transform transform = ((Component)obj26).transform;
				Transform parent = transform.parent;
				object obj27 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj28 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v34+E4]");
				bool flag3 = (nint)0 == 0;
				object obj29 = !flag3;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj30 = (nint)0 + (nint)936;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
				object obj31 = obj23 + 16;
				obj31 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Transform transform2 = ((Component)obj31).transform;
				Transform transform3 = ((Component)obj26).transform;
				int siblingIndex = transform3.GetSiblingIndex();
				transform2.SetSiblingIndex(siblingIndex);
				GameObject gameObject = ((Component)obj26).gameObject;
				gameObject.SetActive(value: false);
				object obj33 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v26+10]");
				Vector3 position = ((Transform)0).position;
				int num7 = UnityEngine.Random.Range(-30, 30);
				int num8 = UnityEngine.Random.Range(-60, -40);
				object obj34 = typeof(UsageHint) + 816;
				object obj35 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v32+B8]");
				object obj36 = 0;
				int num9 = UnityEngine.Random.Range(-30, 30);
				object obj37 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
				object obj38 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v57+E4]");
				bool flag4 = (nint)0 == 0;
				object obj39 = !flag4;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Sequence sequence = DOTween.Sequence();
				Transform target = ((Component)obj31).transform;
				TweenerCore<Vector3, Vector3, VectorOptions> t = ShortcutExtensions.DOScale(target, 0.75f, 0.5f);
				Sequence sequence2 = TweenSettingsExtensions.Join(sequence, t);
				float duration = (float)obj16 + (float)num7;
				Transform target2 = ((Component)obj31).transform;
				TweenerCore<Vector3, Vector3, VectorOptions> t2 = ShortcutExtensions.DOMove(target2, (Vector3)0, duration);
				Sequence sequence3 = TweenSettingsExtensions.Join(sequence, t2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v33+48]");
				float duration2 = 0f * (float)num9;
				Transform target3 = ((Component)obj31).transform;
				TweenerCore<Quaternion, Vector3, QuaternionOptions> t3 = ShortcutExtensions.DOLocalRotate(target3, (Vector3)0, duration2);
				Sequence sequence4 = TweenSettingsExtensions.Join(sequence, t3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v27 (System.Object)+10]");
				TweenerCore<Color, Color, ColorOptions> t4 = DOTweenModuleUI.DOColor((Image)0, (Color)0, 1f);
				Sequence sequence5 = TweenSettingsExtensions.Join(sequence, t4);
				object obj40 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj41 = (nint)0 + (nint)1864;
				tweenCallback..ctor(obj23, (IntPtr)obj41);
				Sequence sequence6 = TweenSettingsExtensions.AppendCallback(sequence, tweenCallback);
				obj17 = num6 * 1036831949;
				object obj42 = (nint)0 + (nint)2784;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
				Sequence sequence7 = TweenSettingsExtensions.Join(s, sequence);
				num6++;
				flag5 = num6 < selectedCards._size;
				obj7 = 0;
				tween = sequence;
				obj12 = 1050253722;
				num2 = 1.0;
				num4 = 1.0;
				obj14 = 1036831949;
				obj16 = obj17;
				obj18 = 0;
				obj20 = 0;
				obj21 = sequence;
			}
			while (flag5);
		}
		object obj43 = (nint)0 + (nint)1856;
		object obj44 = (nint)0 + (nint)2512;
		object obj45 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback2 = default(TweenCallback);
		tweenCallback2..ctor(obj2, (IntPtr)obj43);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	public RectTransform GetDeckTopCard()
	{
		object obj = Enumerable.Last((IEnumerable<object>)deckCards);
		if (obj != null)
		{
			return ((Graphic)obj).rectTransform;
		}
		return (RectTransform)(object)new NullReferenceException();
	}

	private RectTransform GetDropZone()
	{
		//IL_0087: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected I4, but got Unknown
		MiniGame miniGame = this.miniGame;
		if ((object)this.miniGame != null)
		{
			MiniGameState <State>k__BackingField = miniGame.<State>k__BackingField;
			if (miniGame.<State>k__BackingField != null)
			{
				List<object> list = (List<object>)(object)dropZones;
				if (dropZones != null)
				{
					int num = <State>k__BackingField.<RemainingMoves>k__BackingField / list._size;
					object obj = num * list._size;
					int index = <State>k__BackingField.<RemainingMoves>k__BackingField - obj;
					return (RectTransform)((List<object>)(object)dropZones).get_Item(index);
				}
			}
		}
		return (RectTransform)(object)new NullReferenceException();
	}

	private void MarkReady(bool isReady)
	{
		MiniGame miniGame = this.miniGame;
		MiniGameVisuals visuals = miniGame.visuals;
		visuals.Playground.IsReady = isReady;
	}

	private void <OnInitialized>b__7_0()
	{
		MiniGame miniGame = this.miniGame;
		MiniGameVisuals visuals = miniGame.visuals;
		visuals.Playground.IsReady = true;
	}
}
