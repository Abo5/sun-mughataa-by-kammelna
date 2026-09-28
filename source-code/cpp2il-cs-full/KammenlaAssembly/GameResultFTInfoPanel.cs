using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class GameResultFTInfoPanel : FastTrackInfoPanel
{
	public Image stageIndicatorBackground;

	public Sprite stageIndicatorBackgroundMiddle;

	public Sprite stageIndicatorBackgroundEdge;

	public Sprite GreenRound;

	public Sprite RedRound;

	public Sprite WhiteRound;

	private CardGame game;

	protected override void InitFT()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0067: Expected O, but got I
		//IL_0091: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 200;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base.InitFT();
	}

	protected override void InitLevelRanks()
	{
		//IL_0177: Expected O, but got I
		//IL_0140: Expected O, but got I
		//IL_01b2: Expected O, but got I4
		//IL_00c6: Expected O, but got I
		//IL_00e4: Expected O, but got I4
		base.InitLevelRanks();
		List<object> list = (List<object>)(object)levelRanks;
		int num = 0;
		while (true)
		{
			if (num >= list._size)
			{
				return;
			}
			RectTransform rectTransform;
			if (FTLevel != 2)
			{
				if (FTLevel != 1)
				{
					goto IL_001c;
				}
				object obj = list.get_Item(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v14 (System.Object)+48]");
				rectTransform = ((Graphic)0).rectTransform;
				bool flag = (object)rectTransform == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					break;
				}
			}
			else if (num == 7)
			{
				object obj3 = list.get_Item(7);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v11 (System.Object)+48]");
				rectTransform = ((Graphic)0).rectTransform;
			}
			else
			{
				object obj4 = list.get_Item(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v8 (System.Object)+48]");
				rectTransform = ((Graphic)0).rectTransform;
			}
			rectTransform.sizeDelta = (Vector2)0;
			goto IL_001c;
			IL_001c:
			num++;
			list = (List<object>)(object)levelRanks;
		}
		throw new NullReferenceException();
	}

	protected override void InitCurrentStage()
	{
		//IL_00a0: Expected O, but got I4
		//IL_0169: Expected O, but got I4
		base.InitCurrentStage();
		horizontalLayout.childAlignment = TextAnchor.MiddleCenter;
		stageIndicatorBackground.sprite = stageIndicatorBackgroundMiddle;
		if (FTStageFixedUI == 1)
		{
			horizontalLayout.childAlignment = TextAnchor.MiddleRight;
			stageIndicatorBackground.sprite = stageIndicatorBackgroundEdge;
			Transform transform = stageIndicatorBackground.transform;
			transform.eulerAngles = (Vector3)0;
		}
		if (FTLevel != 2)
		{
			if (FTLevel != 1)
			{
				return;
			}
			horizontalLayout.spacing = 24f;
			if (FTStage != 6)
			{
				return;
			}
		}
		else
		{
			horizontalLayout.spacing = 5f;
			if (FTStage != 8)
			{
				return;
			}
		}
		horizontalLayout.childAlignment = TextAnchor.MiddleLeft;
		stageIndicatorBackground.sprite = stageIndicatorBackgroundEdge;
		Transform transform2 = stageIndicatorBackground.transform;
		transform2.eulerAngles = (Vector3)0;
	}

	protected override void InitHearts()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_016c: Expected O, but got I4
		//IL_0175: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		//IL_007e: Expected O, but got I4
		//IL_0087: Expected O, but got I4
		//IL_00ab: Expected O, but got I
		//IL_01ac: Expected O, but got I
		//IL_01c6: Expected O, but got I4
		//IL_020c: Expected O, but got I4
		//IL_0115: Expected O, but got I
		//IL_0125: Expected O, but got I
		//IL_024c: Expected O, but got I
		//IL_026e: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8A02]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj5;
		if (obj3 != null)
		{
			base.InitHearts();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			obj6 = 0;
			if (!flag)
			{
				goto IL_0095;
			}
		}
		else
		{
			_ = 1;
			base.InitHearts();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = 0;
			obj6 = 0;
			if (obj7 != null)
			{
				goto IL_0095;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
		object obj8 = (nint)0 & (nint)1;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		obj5 = obj6;
		if (obj9 != null)
		{
			goto IL_00d0;
		}
		goto IL_01dc;
		IL_0105:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v18+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v17+8]");
		object obj11 = 0;
		goto IL_012a;
		IL_012a:
		_ = 1;
		return;
		IL_022a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v5+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4+8]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_012a;
		IL_0095:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
		object obj15 = (nint)0 & (nint)1;
		bool flag5 = obj15 == null;
		obj6 = obj5;
		if (!flag5)
		{
			goto IL_00d0;
		}
		goto IL_01dc;
		IL_01dc:
		_ = 1;
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v18+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		object obj18 = obj16;
		obj5 = obj6;
		if (obj17 != null)
		{
			goto IL_0105;
		}
		goto IL_022a;
		IL_00d0:
		obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v18+E4]");
		bool flag7 = (nint)0 == 0;
		obj18 = obj16;
		if (!flag7)
		{
			goto IL_0105;
		}
		goto IL_022a;
	}

	protected override void InitProgressBreadCrumps()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003d: Expected I, but got O
		//IL_0066: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_00d8: Expected O, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0105: Expected I, but got O
		//IL_0115: Expected O, but got I
		//IL_0125: Expected O, but got I
		//IL_014e: Expected O, but got I4
		//IL_0182: Expected O, but got I
		//IL_01cb: Expected O, but got I4
		//IL_01e5: Expected O, but got I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_020d: Expected O, but got I4
		//IL_0255: Expected O, but got I4
		//IL_0237: Expected O, but got I4
		//IL_0247: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Expected O, but got Unknown
		//IL_09ca: Expected O, but got I
		//IL_09e4: Expected O, but got I4
		//IL_092c: Expected O, but got I
		//IL_0a5a: Expected O, but got I
		//IL_0a6a: Expected O, but got I
		//IL_0a8c: Expected O, but got I4
		//IL_0a22: Expected O, but got I4
		//IL_0351: Expected O, but got I4
		//IL_098e: Expected O, but got I
		//IL_099e: Expected O, but got I
		//IL_06a0: Expected O, but got I4
		//IL_0399: Expected O, but got I4
		//IL_050d: Expected O, but got I4
		//IL_03cb: Expected I, but got O
		//IL_03db: Expected O, but got I
		//IL_03eb: Expected O, but got I
		//IL_0414: Expected O, but got I4
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Expected O, but got Unknown
		//IL_0768: Expected O, but got I
		//IL_078a: Expected O, but got I4
		//IL_053f: Expected I, but got O
		//IL_054f: Expected O, but got I
		//IL_055f: Expected O, but got I
		//IL_0588: Expected O, but got I4
		//IL_0b0d: Expected F4, but got I4
		//IL_0448: Expected O, but got I
		//IL_05bc: Expected O, but got I
		//IL_07fa: Expected O, but got I4
		//IL_081b: Expected F4, but got I4
		//IL_0621: Expected O, but got I
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Expected O, but got Unknown
		//IL_088e: Expected O, but got I
		//IL_08b0: Expected O, but got I4
		//IL_0296: Expected O, but got I4
		//IL_02af: Expected F4, but got I4
		base.InitProgressBreadCrumps();
		IGameScores gameScores = game.GameScores;
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2064;
		object obj2 = obj;
		nint num = (nint)gameScores;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v9 (Il2CppClass<IGameScores>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X1_v6+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v9 (Il2CppClass<IGameScores>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X1_v6+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v11-8]");
			if (0 == (nint)obj2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v10 (IGameScores)+10]");
				object obj6 = Enumerable.Last((IEnumerable<object>)0);
				object obj7 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2056;
				Sprite sprite = (Sprite)obj7;
				nint num4 = (nint)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v19 (Il2CppClass<System.Object>)+130]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X1_v9 (UnityEngine.Sprite)+130]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v19 (Il2CppClass<System.Object>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X1_v9 (UnityEngine.Sprite)+130]");
				bool flag2 = num5 < 0;
				object obj10 = !flag2;
				object obj11 = ~obj10;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v19 (Il2CppClass<System.Object>)+C8]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X1_v9 (UnityEngine.Sprite)+130]");
					object obj12 = num6 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v21-8]");
					if (0 == (nint)sprite)
					{
						CardGame cardGame = game;
						object obj13 = ((KGame)cardGame).<MySeatIndex>k__BackingField - 1;
						bool flag3 = (nint)obj13 < 3;
						object obj14 = !flag3;
						object obj15 = obj13 - 3;
						bool flag4 = obj15 == null;
						object obj16 = !flag4;
						object obj17 = obj14 & obj16;
						object obj18;
						if (obj17 == null)
						{
							obj9 = 118730752 + 3184;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X9_v18+v580 @ X8_v25*4]");
							obj18 = 0;
						}
						else
						{
							obj18 = 0;
						}
						List<Image> fTRoundsBreadCrumps = FTRoundsBreadCrumps;
						object obj19 = (nint)0 + (nint)872;
						object obj20 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 352;
						int num7 = 0;
						KGame kGame = default(KGame);
						while (true)
						{
							float delay;
							float pulseSize;
							float pulseDuration;
							Transform rect;
							KGame kGame2;
							object obj35;
							if (num7 < fTRoundsBreadCrumps._size)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v13 (System.Object)+18]");
								object obj27;
								if (0 == (nint)obj18)
								{
									object obj21 = FTRoundsWon - 1;
									if (num7 == (nint)obj21)
									{
										bool isSpectator = game.IsSpectator;
										bool flag5 = !isSpectator;
										object obj22 = !flag5;
										if (obj22 == null)
										{
											kGame = game;
											KPlayer myPlayer = ((KGame)game).MyPlayer;
											object obj23 = obj20;
											nint num8 = (nint)myPlayer;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v65 (Il2CppClass<KPlayer>)+130]");
											obj8 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X1_v34+130]");
											obj9 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v65 (Il2CppClass<KPlayer>)+130]");
											nint num9 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X1_v34+130]");
											bool flag6 = num9 < 0;
											object obj24 = !flag6;
											object obj25 = ~obj24;
											if (obj25 != null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v65 (Il2CppClass<KPlayer>)+C8]");
											nint num10 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X1_v34+130]");
											object obj26 = num10 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v67-8]");
											if (0 != (nint)obj23)
											{
												break;
											}
											SeatStatus seatStatus = myPlayer.SeatStatus;
											if (seatStatus != SeatStatus.IdleBlocked)
											{
												obj27 = obj19;
												object obj28 = ((List<object>)(object)FTRoundsBreadCrumps).get_Item(num7);
												RectTransform rectTransform = ((Graphic)obj28).rectTransform;
												object obj29 = typeof(SqlSingle[]) + 3912;
												object obj30 = obj29;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v71+E4]");
												obj9 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v71+E4]");
												bool flag7 = (nint)0 == 0;
												object obj31 = !flag7;
												if (obj31 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													kGame = (KGame)(object)rectTransform;
												}
												object obj32 = num7 * 1053609165;
												delay = (float)obj32 + 1.0712252E+09f;
												pulseSize = 1.0636755E+09f;
												pulseDuration = 2f;
												rect = rectTransform;
												goto IL_0b12;
											}
										}
									}
								}
								if (num7 == FTRoundsWon)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v13 (System.Object)+18]");
									Sprite sprite2;
									object obj40;
									Image image;
									if (0 == (nint)obj18)
									{
										bool isSpectator2 = game.IsSpectator;
										bool flag8 = !isSpectator2;
										object obj33 = !flag8;
										if (obj33 == null)
										{
											kGame2 = game;
											KPlayer myPlayer2 = ((KGame)game).MyPlayer;
											object obj34 = obj20;
											nint num11 = (nint)myPlayer2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v56 (Il2CppClass<KPlayer>)+130]");
											obj35 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X1_v30+130]");
											obj9 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v56 (Il2CppClass<KPlayer>)+130]");
											nint num12 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X1_v30+130]");
											bool flag9 = num12 < 0;
											object obj36 = !flag9;
											object obj37 = ~obj36;
											if (obj37 != null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v56 (Il2CppClass<KPlayer>)+C8]");
											nint num13 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X1_v30+130]");
											object obj38 = num13 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X8_v58-8]");
											if (0 != (nint)obj34)
											{
												break;
											}
											SeatStatus seatStatus2 = myPlayer2.SeatStatus;
											bool flag10 = seatStatus2 != SeatStatus.IdleBlocked;
											sprite = null;
											kGame = game;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v56 (Il2CppClass<KPlayer>)+130]");
											obj8 = 0;
											if (flag10)
											{
												goto IL_02c9;
											}
										}
										object obj39 = ((List<object>)(object)FTRoundsBreadCrumps).get_Item(num7);
										sprite2 = WhiteRound;
										obj40 = kGame;
										image = (Image)obj39;
									}
									else
									{
										object obj41 = ((List<object>)(object)FTRoundsBreadCrumps).get_Item(num7);
										sprite2 = RedRound;
										obj40 = kGame;
										image = (Image)obj41;
									}
									image.sprite = sprite2;
									object obj42 = ((List<object>)(object)FTRoundsBreadCrumps).get_Item(num7);
									GameObject gameObject = ((Component)obj42).gameObject;
									gameObject.SetActive(value: true);
									object obj43 = ((List<object>)(object)FTRoundsBreadCrumps).get_Item(num7);
									object obj44 = typeof(SqlSingle[]) + 3912;
									object obj45 = obj44;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v50+E4]");
									obj9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v50+E4]");
									bool flag11 = (nint)0 == 0;
									object obj46 = !flag11;
									Graphic rect2 = (Graphic)obj43;
									if (obj46 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj40 = obj43;
										rect2 = (Graphic)obj43;
									}
									AnimationExtensions.AnimFadeIn(rect2, num7);
									obj27 = obj19;
									object obj47 = ((List<object>)(object)FTRoundsBreadCrumps).get_Item(num7);
									RectTransform rectTransform2 = ((Graphic)obj47).rectTransform;
									object obj48 = num7 * 1053609165;
									delay = (float)obj48 + 1.0712252E+09f;
									kGame = (KGame)obj40;
									pulseSize = 1.0636755E+09f;
									pulseDuration = 1f;
									rect = rectTransform2;
									goto IL_0b12;
								}
								object obj49 = ((List<object>)(object)FTRoundsBreadCrumps).get_Item(num7);
								sprite = GreenRound;
								((Image)obj49).sprite = GreenRound;
								obj27 = 0;
								kGame2 = kGame;
								obj35 = obj8;
								goto IL_02c9;
							}
							object obj50 = typeof(UsageHint) + 72;
							object obj51 = obj50;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X0_v15+E4]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
								object obj52 = (nint)0 & (nint)1;
								if (obj52 != null)
								{
									goto IL_0949;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
								object obj53 = (nint)0 & (nint)1;
								bool flag12 = obj53 == null;
								object obj54 = !flag12;
								if (obj54 != null)
								{
									goto IL_0949;
								}
							}
							_ = 1;
							object obj55 = obj50;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v26+E4]");
							bool flag13 = (nint)0 == 0;
							object obj56 = !flag13;
							object obj57 = obj55;
							if (obj56 != null)
							{
								goto IL_097e;
							}
							goto IL_0a38;
							IL_09a3:
							_ = 1;
							return;
							IL_02c9:
							num7++;
							fTRoundsBreadCrumps = FTRoundsBreadCrumps;
							kGame = kGame2;
							obj8 = obj35;
							continue;
							IL_097e:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v26+B8]");
							object obj58 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v39+8]");
							object obj59 = 0;
							goto IL_09a3;
							IL_0b12:
							AnimationExtensions.AnimPulsing(rect, pulseDuration, pulseSize, delay);
							kGame2 = kGame;
							obj35 = obj8;
							sprite = null;
							goto IL_02c9;
							IL_0949:
							obj55 = obj50;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v26+E4]");
							bool flag14 = (nint)0 == 0;
							obj57 = obj55;
							if (!flag14)
							{
								goto IL_097e;
							}
							goto IL_0a38;
							IL_0a38:
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj60 = obj50;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v18+B8]");
							object obj61 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X8_v31+8]");
							obj59 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X8_v31+8]");
							bool flag15 = (nint)0 == 0;
							object obj62 = !flag15;
							if (obj62 == null)
							{
								throw new NullReferenceException();
							}
							goto IL_09a3;
						}
					}
				}
			}
		}
		throw new InvalidCastException();
	}
}
