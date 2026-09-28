using System;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Spine;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TarneebUserbox : Userbox
{
	private sealed class <>c__DisplayClass13_0
	{
		public TarneebUserbox <>4__this;

		public int myEating;

		public int HighestBid;

		public bool isTeamBidder;

		public int teamEating;

		public int opponentEating;

		internal unsafe void <UpdateEatingCount>b__0()
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected I4, but got Unknown
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected I4, but got Unknown
			//IL_0291: Expected O, but got I4
			//IL_00a0: Expected I, but got O
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			//IL_010d: Expected O, but got I4
			//IL_021b: Expected F4, but got I4
			//IL_01a5: Expected O, but got I4
			//IL_023a: Expected O, but got I4
			TarneebUserbox tarneebUserbox = <>4__this;
			string text = tarneebUserbox.eatingCount.text;
			int num = this + 24;
			string text2 = ((int*)num)->ToString();
			if (text != text2)
			{
				TarneebUserbox tarneebUserbox2 = <>4__this;
				TextMeshProUGUI eatingCount = tarneebUserbox2.eatingCount;
				int num2 = this + 24;
				string text3 = ((int*)num2)->ToString();
				nint num3 = (nint)eatingCount;
				eatingCount.text = text3;
				TarneebUserbox tarneebUserbox3 = <>4__this;
				RectTransform rectTransform = UIExtensions.rectTransform(tarneebUserbox3.eatingCount);
				object obj = typeof(SqlSingle[]) + 3912;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v20+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				Transform rect = rectTransform;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					rect = rectTransform;
				}
				AnimationExtensions.AnimEmphasise2(rect, 0f, 2f);
			}
			TarneebUserbox tarneebUserbox4;
			float duration;
			if (HighestBid != 0 && ~(isTeamBidder ? 1u : 0u) == 0)
			{
				if (teamEating < HighestBid)
				{
					object obj4 = 13 - HighestBid;
					tarneebUserbox4 = <>4__this;
					if (opponentEating <= (nint)obj4)
					{
						bool flag2 = (object)tarneebUserbox4 == null;
						object obj5 = !flag2;
						if (obj5 == null)
						{
							throw new NullReferenceException();
						}
						goto IL_01f1;
					}
					duration = 1f;
				}
				else
				{
					tarneebUserbox4 = <>4__this;
					duration = 1.06030694E+09f;
				}
				goto IL_027a;
			}
			tarneebUserbox4 = <>4__this;
			goto IL_01f1;
			IL_01f1:
			duration = 1f;
			goto IL_027a;
			IL_027a:
			TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOColor(tarneebUserbox4.eatingContainerImage, (Color)0, duration);
		}
	}

	private GameObject eatingObject;

	private TextMeshProUGUI eatingCount;

	private Vector2 eatingContainerSize;

	private Image eatingContainerImage;

	private RectTransform eatingContainer;

	private new TarneebPlayer player
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			TarneebPlayer tarneebPlayer = (TarneebPlayer)base.<player>k__BackingField;
			if (base.<player>k__BackingField != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3872;
				object obj2 = obj;
				nint num = (nint)tarneebPlayer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<TarneebPlayer>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<TarneebPlayer>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (TarneebPlayer)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return (TarneebPlayer)base.<player>k__BackingField;
		}
	}

	private new TarneebGame game
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			TarneebGame tarneebGame = (TarneebGame)base.game;
			if ((object)base.game != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3848;
				object obj2 = obj;
				nint num = (nint)tarneebGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<TarneebGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<TarneebGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (TarneebGame)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return (TarneebGame)base.game;
		}
	}

	protected override void Awake()
	{
		//IL_0011: Expected O, but got I
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_004b: Expected O, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00c5: Expected I, but got O
		//IL_00d5: Expected O, but got I
		//IL_00e5: Expected O, but got I
		Image image = default(Image);
		RectTransform rectTransform = default(RectTransform);
		Vector2 vector = default(Vector2);
		while (true)
		{
			base.Awake();
			object obj = (nint)0 + (nint)1312;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
			eatingContainerImage = image;
			object obj2 = this + 504;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj3 = (nint)0 + (nint)1360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
			eatingContainer = rectTransform;
			object obj4 = this + 512;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Vector2 sizeDelta = eatingContainer.sizeDelta;
			eatingContainerSize = vector;
			TextMeshProUGUI textMeshProUGUI = eatingCount;
			object obj5 = ", stale={0}" + 3424;
			object obj6 = obj5;
			nint num = (nint)textMeshProUGUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v10 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v10 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v73 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	protected override void OnGameStatusUpdate()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_002f: Expected I, but got O
		//IL_0058: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_01ff: Expected O, but got I
		//IL_0219: Expected O, but got I4
		//IL_0242: Expected I, but got O
		//IL_026b: Expected O, but got I4
		//IL_0102: Expected I, but got O
		//IL_012b: Expected O, but got I4
		//IL_029f: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_01b7: Expected O, but got I
		//IL_02e8: Expected I, but got O
		//IL_0311: Expected O, but got I4
		//IL_0345: Expected O, but got I
		//IL_038e: Expected I, but got O
		//IL_03b7: Expected O, but got I4
		//IL_03eb: Expected O, but got I
		//IL_0434: Expected I, but got O
		//IL_045d: Expected O, but got I4
		//IL_0491: Expected O, but got I
		//IL_04cd: Expected I, but got O
		//IL_04f6: Expected O, but got I4
		//IL_052a: Expected O, but got I
		base.OnGameStatusUpdate();
		CardGamePlayer cardGamePlayer = base.<player>k__BackingField;
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3872;
		object obj2 = obj;
		nint num = (nint)cardGamePlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (Il2CppClass<CardGamePlayer>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X1_v2+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		object obj6;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (Il2CppClass<CardGamePlayer>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X1_v2+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v7-8]");
			if (0 == (nint)obj2)
			{
				bool isRoundBidder = cardGamePlayer.IsRoundBidder;
				obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3848;
				if (!isRoundBidder)
				{
					SetBidInfo(Suit.NONE, 0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6857]");
					object obj7 = (nint)0 & (nint)1;
					bool flag2 = obj7 == null;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						goto IL_0227;
					}
					goto IL_05b9;
				}
				CardGame cardGame = base.game;
				object obj9 = obj6;
				nint num4 = (nint)cardGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v47 (Il2CppClass<CardGame>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X1_v18+130]");
				bool flag3 = num5 < 0;
				object obj10 = !flag3;
				object obj11 = ~obj10;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v47 (Il2CppClass<CardGame>)+C8]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X1_v18+130]");
					object obj12 = num6 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v49-8]");
					if (0 == (nint)obj9)
					{
						Suit <TrumpSuit>k__BackingField = cardGame.<TrumpSuit>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v41 (CardGame)+170]");
						SetBidInfo(<TrumpSuit>k__BackingField, 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6857]");
						object obj13 = (nint)0 & (nint)1;
						if (obj13 == null)
						{
							goto IL_0227;
						}
						goto IL_05b9;
					}
				}
			}
		}
		goto IL_0586;
		IL_0586:
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
		IL_05b9:
		TarneebPlayer tarneebPlayer = (TarneebPlayer)base.<player>k__BackingField;
		object obj14 = obj;
		nint num7 = (nint)tarneebPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v10 (Il2CppClass<TarneebPlayer>)+130]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X1_v6+130]");
		bool flag4 = num8 < 0;
		object obj15 = !flag4;
		object obj16 = ~obj15;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v10 (Il2CppClass<TarneebPlayer>)+C8]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X1_v6+130]");
			object obj17 = num9 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v12-8]");
			if (0 == (nint)obj14)
			{
				int eatingsCount = tarneebPlayer.EatingsCount;
				TarneebPlayer tarneebPlayer2 = (TarneebPlayer)base.<player>k__BackingField;
				object obj18 = obj;
				nint num10 = (nint)tarneebPlayer2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v16 (Il2CppClass<TarneebPlayer>)+130]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X1_v8+130]");
				bool flag5 = num11 < 0;
				object obj19 = !flag5;
				object obj20 = ~obj19;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v16 (Il2CppClass<TarneebPlayer>)+C8]");
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X1_v8+130]");
					object obj21 = num12 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v18-8]");
					if (0 == (nint)obj18)
					{
						int teamEatingsCount = tarneebPlayer2.TeamEatingsCount;
						TarneebPlayer tarneebPlayer3 = (TarneebPlayer)base.<player>k__BackingField;
						object obj22 = obj;
						nint num13 = (nint)tarneebPlayer3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v22 (Il2CppClass<TarneebPlayer>)+130]");
						nint num14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X1_v10+130]");
						bool flag6 = num14 < 0;
						object obj23 = !flag6;
						object obj24 = ~obj23;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v22 (Il2CppClass<TarneebPlayer>)+C8]");
							nint num15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X1_v10+130]");
							object obj25 = num15 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v24-8]");
							if (0 == (nint)obj22)
							{
								int opponentTeamEatingsCount = tarneebPlayer3.OpponentTeamEatingsCount;
								CardGame cardGame2 = base.game;
								object obj26 = obj6;
								nint num16 = (nint)cardGame2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v28 (Il2CppClass<CardGame>)+130]");
								nint num17 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X1_v12+130]");
								bool flag7 = num17 < 0;
								object obj27 = !flag7;
								object obj28 = ~obj27;
								if (obj28 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v28 (Il2CppClass<CardGame>)+C8]");
									nint num18 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X1_v12+130]");
									object obj29 = num18 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v30-8]");
									if (0 == (nint)obj26)
									{
										TarneebPlayer tarneebPlayer4 = (TarneebPlayer)base.<player>k__BackingField;
										object obj30 = obj;
										nint num19 = (nint)tarneebPlayer4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v34 (Il2CppClass<TarneebPlayer>)+130]");
										nint num20 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X1_v13+130]");
										bool flag8 = num20 < 0;
										object obj31 = !flag8;
										object obj32 = ~obj31;
										if (obj32 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v34 (Il2CppClass<TarneebPlayer>)+C8]");
											nint num21 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X1_v13+130]");
											object obj33 = num21 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v36-8]");
											if (0 == (nint)obj30)
											{
												bool isTeamBidder = tarneebPlayer4.IsTeamBidder;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v18 (CardGame)+170]");
												UpdateEatingCount(eatingsCount, teamEatingsCount, opponentTeamEatingsCount, 0, isTeamBidder);
												return;
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
		goto IL_0586;
		IL_0227:
		_ = 1;
		goto IL_05b9;
	}

	protected override void OnPlayerDidLastAction()
	{
		//IL_0016: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00e1: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_004f: Expected O, but got I
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0142: Expected I, but got O
		//IL_016b: Expected O, but got I4
		//IL_019f: Expected O, but got I
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0243: Expected I, but got O
		//IL_026c: Expected O, but got I4
		//IL_02a0: Expected O, but got I
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_0325: Expected I, but got O
		//IL_034e: Expected O, but got I4
		//IL_0382: Expected O, but got I
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected O, but got Unknown
		//IL_042a: Expected O, but got I4
		//IL_056d: Expected O, but got I
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_0477: Expected O, but got I4
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_04c4: Expected O, but got I4
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected O, but got Unknown
		//IL_0511: Expected O, but got I4
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6859]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			base.OnPlayerDidLastAction();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6858]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_006c;
			}
		}
		else
		{
			_ = 1;
			base.OnPlayerDidLastAction();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6858]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_006c;
			}
		}
		_ = 1;
		CardGame cardGame = base.game;
		if ((object)base.game != null)
		{
			goto IL_011e;
		}
		goto IL_05a0;
		IL_05ae:
		throw new InvalidCastException();
		IL_05a0:
		NullReferenceException ex = new NullReferenceException();
		goto IL_05ae;
		IL_011e:
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3848;
		object obj6 = obj5;
		nint num = (nint)cardGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6 (Il2CppClass<CardGame>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X1_v4+130]");
		bool flag2 = num2 < 0;
		object obj7 = !flag2;
		object obj8 = ~obj7;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6 (Il2CppClass<CardGame>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X1_v4+130]");
			object obj9 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v8-8]");
			if (0 == (nint)obj6)
			{
				CardGameLastActionInfo lastAction = cardGame.LastAction;
				if (lastAction != null)
				{
					object obj10 = "___# Content push apply failed [{0}]: {1}" + 2656;
					if (!(((LastActionInfo)lastAction).<Action>k__BackingField == (string)obj10))
					{
						return;
					}
					CardGame cardGame2 = base.game;
					if ((object)base.game != null)
					{
						object obj11 = obj5;
						nint num4 = (nint)cardGame2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v14 (Il2CppClass<CardGame>)+130]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X1_v7+130]");
						bool flag3 = num5 < 0;
						object obj12 = !flag3;
						object obj13 = ~obj12;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v14 (Il2CppClass<CardGame>)+C8]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X1_v7+130]");
							object obj14 = num6 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v16-8]");
							if (0 == (nint)obj11)
							{
								CardGameLastActionInfo lastAction2 = base.game.LastAction;
								if (lastAction2 != null)
								{
									GameSoundManager instance = GameSoundManager.Instance;
									CardGamePlayer cardGamePlayer = base.<player>k__BackingField;
									if (base.<player>k__BackingField != null)
									{
										object obj15 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3872;
										object obj16 = obj15;
										nint num7 = (nint)cardGamePlayer;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X9_v8 (Il2CppClass<CardGamePlayer>)+130]");
										nint num8 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X1_v9+130]");
										bool flag4 = num8 < 0;
										object obj17 = !flag4;
										object obj18 = ~obj17;
										if (obj18 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X9_v8 (Il2CppClass<CardGamePlayer>)+C8]");
											nint num9 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X1_v9+130]");
											object obj19 = num9 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X9_v10-8]");
											if (0 == (nint)obj16)
											{
												if ((object)instance != null)
												{
													instance.PlaySound(lastAction2.<BidType>k__BackingField, ((KPlayer)cardGamePlayer).<Index>k__BackingField);
													object obj20 = "startPosition" + 3024;
													bool flag5 = lastAction2.<BidType>k__BackingField == (string)obj20;
													bool flag6 = !flag5;
													object obj21 = !flag6;
													if (obj21 == null)
													{
														object obj22 = "getSecondRescanTask" + 2952;
														bool flag7 = lastAction2.<BidType>k__BackingField == (string)obj22;
														bool flag8 = !flag7;
														object obj23 = !flag8;
														if (obj23 == null)
														{
															object obj24 = "utf-32" + 2760;
															bool flag9 = lastAction2.<BidType>k__BackingField == (string)obj24;
															bool flag10 = !flag9;
															object obj25 = !flag10;
															if (obj25 == null)
															{
																object obj26 = "utf-32" + 1144;
																bool flag11 = lastAction2.<BidType>k__BackingField == (string)obj26;
																bool flag12 = !flag11;
																object obj27 = !flag12;
																if (obj27 == null)
																{
																	object obj28 = "clear_mass_tournaments" + 56;
																	if (!(lastAction2.<BidType>k__BackingField == (string)obj28))
																	{
																		string suitLocalizationString = SuitMethods.GetSuitLocalizationString(lastAction2.<BidType>k__BackingField);
																		ShowGameBubble(suitLocalizationString);
																		return;
																	}
																}
															}
														}
													}
													object obj29 = (nint)0 + (nint)2736;
													TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(bubbleImage, 0f, 0.3f);
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
													TweenerCore<Color, Color, ColorOptions> tweenerCore2 = ShortcutExtensionsTMPText.DOFade(bubbleText, 0f, 0.3f);
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
													return;
												}
												goto IL_05a0;
											}
										}
										throw new InvalidCastException();
									}
								}
								goto IL_05a0;
							}
						}
						goto IL_05ae;
					}
				}
				goto IL_05a0;
			}
		}
		goto IL_05ae;
		IL_006c:
		cardGame = base.game;
		bool flag13 = (object)base.game == null;
		object obj30 = !flag13;
		if (obj30 != null)
		{
			goto IL_011e;
		}
		goto IL_05a0;
	}

	private void SetBidInfo(Suit suite, int highestBid)
	{
		//IL_001f: Expected O, but got I4
		//IL_0119: Expected F4, but got O
		//IL_0119: Expected O, but got I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_014c: Expected O, but got I
		//IL_015a: Expected I, but got O
		//IL_016b: Expected O, but got I
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_024c: Expected O, but got I4
		//IL_02c1: Expected F4, but got O
		//IL_02c1: Expected O, but got I4
		if (suite == Suit.NONE)
		{
			bool flag = highestBid == 0;
			object obj = !flag;
			if (obj == null)
			{
				if (isMyUserbox)
				{
					GameObject gameObject = betObject.gameObject;
					gameObject.SetActive(value: false);
					return;
				}
				int num = ShortcutExtensions.DOKill(betContainer);
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(betContainer, (Vector2)0, (float)betContainerSize);
				object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj3 = (nint)0 + (nint)432;
				TweenCallback tweenCallback = default(TweenCallback);
				tweenCallback..ctor(this, (IntPtr)obj3);
				object obj4 = (nint)0 + (nint)2488;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
				return;
			}
		}
		int num2 = default(int);
		string text = num2.ToString();
		betText.text = text;
		betObject.SetActive(value: true);
		GameObject gameObject2;
		bool active;
		if (suite == Suit.NONE)
		{
			gameObject2 = betImage.gameObject;
			active = false;
		}
		else
		{
			Sprite suitSprite = spritesStore.GetSuitSprite(suite);
			betImage.sprite = suitSprite;
			gameObject2 = betImage.gameObject;
			active = true;
		}
		gameObject2.SetActive(active);
		GameObject gameObject3 = betObject.gameObject;
		gameObject3.SetActive(value: true);
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = betContainer;
			bool flag3 = !flag2;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!betContainer)
			{
				return;
			}
		}
		int num3 = ShortcutExtensions.DOKill(betContainer);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOSizeDelta(betContainer, (Vector2)0, (float)betContainerSize);
	}

	private void UpdateEatingCount(int myEating, int teamEating, int opponentEating, int HighestBid, bool isTeamBidder)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_00a3: Expected I, but got O
		//IL_00cd: Expected O, but got I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0145: Expected I, but got O
		//IL_016e: Expected O, but got I4
		//IL_01a2: Expected O, but got I
		//IL_0209: Expected F4, but got I4
		//IL_0295: Expected O, but got I4
		//IL_01fb: Expected F4, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 2392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(SqlSingle[]) + 2376;
			object obj4 = (nint)0 + (nint)2656;
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj6 = obj2 + 16;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj4);
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.35f, action);
			if (isMyUserbox)
			{
				return;
			}
			CardGamePlayer cardGamePlayer = base.<player>k__BackingField;
			if (base.<player>k__BackingField != null)
			{
				object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3872;
				object obj10 = obj9;
				nint num = (nint)cardGamePlayer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v13 (Il2CppClass<CardGamePlayer>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X1_v7+130]");
				bool flag2 = num2 < 0;
				object obj11 = !flag2;
				object obj12 = ~obj11;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v13 (Il2CppClass<CardGamePlayer>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X1_v7+130]");
					object obj13 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v15-8]");
					if (0 == (nint)obj10)
					{
						TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(duration: (!base.<player>k__BackingField.IsRoundBidder) ? 1.128661E+09f : ((float)eatingContainerSize), target: eatingContainer, endValue: (Vector2)0);
						return;
					}
				}
				goto IL_021c;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_021c;
		IL_021c:
		throw new InvalidCastException();
	}

	public TarneebUserbox()
	{
		base._restingLocalScale = 1f;
		((MonoBehaviour)this)..ctor();
	}

	private void <SetBidInfo>b__12_0()
	{
		GameObject gameObject = betObject.gameObject;
		gameObject.SetActive(value: false);
	}
}
