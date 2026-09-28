using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using DataTracking;
using ListView;
using Mono.Btls;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace Features.GameReplay;

public class GameReplayCard : ListViewItem<GameReplayDataHolder, int>
{
	private sealed class <>c__DisplayClass19_0
	{
		public GameReplayCard <>4__this;

		public int themeId;

		internal void <RefreshRoomThemeBorder>b__0(bool isSuccess)
		{
			//IL_0129: Expected O, but got I
			//IL_009a: Expected O, but got I
			//IL_00e3: Expected O, but got I
			//IL_00f8: Expected O, but got I
			//IL_0117: Expected O, but got I
			GameReplayCard gameReplayCard = <>4__this;
			gameReplayCard._roomThemeId = themeId;
			gameReplayCard._themeBorder.enabled = isSuccess;
			GameReplayCard gameReplayCard2 = <>4__this;
			GameObject gameObject = gameReplayCard2._defaultBorder.gameObject;
			bool active = (byte)((isSuccess ? 1u : 0u) ^ 1u) != 0;
			gameObject.SetActive(active);
			GameReplayCard gameReplayCard3 = <>4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X20_v3 (Features.GameReplay.GameReplayCard)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6+10]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				GameReplayCard gameReplayCard4 = <>4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v9 (Features.GameReplay.GameReplayCard)+40]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X9_v3+10]");
				object obj4 = 0;
				ThemeProvider themeProvider = gameReplayCard4._themeProvider;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v4+18]");
				themeProvider.UpdateTheme((IThemeColorProfile)0);
			}
		}
	}

	private Button _replayButton;

	private Button _deleteButton;

	private Button _shareButton;

	private AvatarInitializer[] _avatars;

	private TextMeshProUGUI _team1Points;

	private TextMeshProUGUI _team2Points;

	private TextMeshProUGUI _gameTitle;

	private TextMeshProUGUI _gameDate;

	private ThemeProvider _themeProvider;

	private Image _defaultBorder;

	private Image _themeBorder;

	private RoomInfoIcons _roomInfoIcons;

	private RankSprites _rankSprites;

	private TextMeshProUGUI _rankText;

	private int _roomThemeId;

	private GameReplayCardData Data
	{
		get
		{
			//IL_0030: Expected O, but got I
			//IL_0012: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
				return (GameReplayCardData)0;
			}
			return (GameReplayCardData)(object)new NullReferenceException();
		}
	}

	public override void Setup(GameReplayDataHolder gameReplayDataHolder, bool firstTime)
	{
		//IL_001a: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
		if (!gameReplayDataHolder.Equals(0))
		{
			((ListViewItem<object, int>)(object)this).Setup((object)gameReplayDataHolder, firstTime);
			Refresh();
		}
	}

	private void Refresh()
	{
		//IL_0016: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00e1: Expected O, but got I4
		//IL_0076: Expected O, but got I
		//IL_0098: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_013a: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_016f: Expected O, but got I
		//IL_0b25: Expected O, but got I
		//IL_0219: Expected O, but got I
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0235: Expected I, but got O
		//IL_0245: Expected O, but got I
		//IL_0265: Expected O, but got I4
		//IL_0b5a: Expected O, but got I
		//IL_027a: Expected O, but got I
		//IL_02af: Expected O, but got I
		//IL_02f5: Expected O, but got I4
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_032e: Expected O, but got I
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected O, but got Unknown
		//IL_06b6: Expected O, but got I4
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Expected I4, but got Unknown
		//IL_035b: Expected O, but got I
		//IL_0732: Expected O, but got I4
		//IL_03a1: Expected O, but got I4
		//IL_03bf: Expected O, but got I
		//IL_0405: Expected O, but got I4
		//IL_07ab: Expected O, but got I
		//IL_0423: Expected O, but got I
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected O, but got Unknown
		//IL_080b: Expected O, but got I4
		//IL_0814: Expected O, but got I4
		//IL_0469: Expected O, but got I4
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected O, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected O, but got Unknown
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected O, but got Unknown
		//IL_053d: Expected O, but got I
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Expected O, but got Unknown
		//IL_0550: Expected O, but got I4
		//IL_08a9: Expected I, but got O
		//IL_08e9: Expected I, but got O
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Expected O, but got Unknown
		//IL_05da: Expected O, but got I4
		//IL_099f: Expected O, but got I4
		//IL_0a03: Expected O, but got I
		//IL_0a48: Expected O, but got I
		//IL_063e: Expected O, but got I
		//IL_0664: Expected O, but got I4
		//IL_0ba2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Expected O, but got Unknown
		//IL_0bd1: Expected O, but got I4
		//IL_0a6d: Expected I8, but got I
		//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0bef: Expected O, but got I
		//IL_0aff: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8385]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8384]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8384]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
		if ((nint)0 != 0)
		{
			goto IL_012a;
		}
		goto IL_0b00;
		IL_0b00:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0b0e;
		IL_0b0e:
		throw new IndexOutOfRangeException();
		IL_012a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v4+10]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v4+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v5+10]");
			object obj7 = 0;
			int num = default(int);
			string text = num.ToString();
			if ((object)_team1Points != null)
			{
				_team1Points.text = text;
				TextMeshProUGUI team2Points = _team2Points;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v10+10]");
					if ((nint)0 != 0)
					{
						string text2 = num.ToString();
						if ((object)_team2Points != null)
						{
							object obj9 = (nint)0 + (nint)2264;
							object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 1048;
							nint num2 = (nint)team2Points;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v13 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
							object obj11 = 0;
							_team2Points.text = text2;
							string text3 = text2;
							object obj12 = 0;
							PlayerRank playerRank = default(PlayerRank);
							PlayerInfo playerInfo = default(PlayerInfo);
							PlayerProfileModel playerProfileModel = default(PlayerProfileModel);
							DateTimeOffset dateTimeOffset2 = default(DateTimeOffset);
							Enum enumeration = default(Enum);
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
								object obj13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v17+10]");
								object obj14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v17+10]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v18+20]");
								object obj15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v18+20]");
								if ((nint)0 == 0)
								{
									break;
								}
								object obj16 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X9_v6+18]");
								bool flag2 = (nint)obj16 < 0;
								object obj17 = !flag2;
								Selectable replayButton;
								if (obj17 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v18+20]");
									object obj18 = 0 + obj12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X9_v7+20]");
									object obj19 = (nint)0 + (nint)1;
									if (obj19 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v18+28]");
										object obj20 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v18+28]");
										if ((nint)0 == 0)
										{
											break;
										}
										object obj21 = obj12;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X9_v19+18]");
										bool flag3 = (nint)obj21 < 0;
										object obj22 = !flag3;
										if (obj22 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v18+30]");
											object obj23 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v18+30]");
											if ((nint)0 == 0)
											{
												break;
											}
											object obj24 = obj12;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X10_v7+18]");
											bool flag4 = (nint)obj24 < 0;
											object obj25 = !flag4;
											if (obj25 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v18+38]");
												object obj26 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v18+38]");
												if ((nint)0 == 0)
												{
													break;
												}
												object obj27 = obj12;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v47+18]");
												bool flag5 = (nint)obj27 < 0;
												object obj28 = !flag5;
												if (obj28 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v18+28]");
													object obj29 = 0 + obj12;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v18+30]");
													object obj30 = 0 + obj12;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v18+38]");
													object obj31 = 0 + obj12;
													object obj32 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X9_v21+20]");
													nint num3 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v48+20]");
													playerRank..ctor((int)num3, isNew: false);
													object obj33 = typeof(System.Buffers.Text.ParserHelpers) + 936;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X9_v7+20]");
													nint num4 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X9_v20+20]");
													playerInfo..ctor((int)num4, (string)0, playerRank);
													DateTime? <AvatarDate>k__BackingField = (DateTime)0;
													if (playerInfo == null)
													{
														break;
													}
													playerInfo.<AvatarDate>k__BackingField = <AvatarDate>k__BackingField;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
													playerProfileModel..ctor(playerInfo);
													AvatarInitializer[] avatars = _avatars;
													if (_avatars == null)
													{
														break;
													}
													bool flag6 = (nint)obj12 < avatars.Length;
													object obj34 = !flag6;
													if (obj34 == null)
													{
														object obj35 = (object)_avatars + obj12;
														AvatarData avatarData = playerProfileModel;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v54+20]");
														if ((nint)0 == 0)
														{
															break;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v54+20]");
														((AvatarInitializer)0).Initialize(avatarData);
														replayButton = _replayButton;
														bool flag7 = (object)_replayButton == null;
														object obj36 = !flag7;
														if (obj36 == null)
														{
															break;
														}
														goto IL_07d4;
													}
												}
											}
										}
									}
									else
									{
										object obj37 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
										object obj38 = obj37;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v51+E4]");
										bool flag8 = (nint)0 == 0;
										object obj39 = !flag8;
										if (obj39 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										int index = obj12 + 1;
										PlayerProfileModel playerProfileModel2 = PlayerProfilesHandler.AiProfileModel(index);
										AvatarInitializer[] avatars2 = _avatars;
										if (_avatars == null)
										{
											break;
										}
										bool flag9 = (nint)obj12 < avatars2.Length;
										object obj40 = !flag9;
										if (obj40 == null)
										{
											if (playerProfileModel2 == null)
											{
												break;
											}
											object obj41 = (object)_avatars + obj12;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v45+20]");
											if ((nint)0 == 0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v45+20]");
											((AvatarInitializer)0).InitializeAI(playerProfileModel2.<userName>k__BackingField);
											replayButton = _replayButton;
											if ((object)_replayButton == null)
											{
												break;
											}
											goto IL_07d4;
										}
									}
								}
								goto IL_0b0e;
								IL_09f1:
								RefreshRoomThemeBorder();
								object obj42 = (nint)0 + (nint)2000;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X21_v3+18]");
								string text4;
								if ((nint)0 == 0)
								{
									text4 = (string)obj42;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X21_v3+18]");
									text4 = (string)0;
								}
								TextMeshProExtensions.FixArabic(_gameTitle, text4);
								object obj43 = typeof(DataRelation) + 768;
								object obj44 = obj43;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X0_v28+E4]");
								bool flag10 = (nint)0 == 0;
								object obj45 = !flag10;
								if (obj45 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X21_v3+80]");
								DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(0L);
								object obj46 = "com.unity.services.authentication.profile" + 3312;
								string text5 = dateTimeOffset2.ToString((string)obj46);
								if ((object)_gameDate == null)
								{
									break;
								}
								_gameDate.text = text5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
								object obj47 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
								if ((nint)0 == 0 || (object)_roomInfoIcons == null)
								{
									break;
								}
								RoomInfoIcons roomInfoIcons = _roomInfoIcons;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v38+10]");
								roomInfoIcons.UpdateIcons((GameReplayCardData)0);
								return;
								IL_09ae:
								if ((object)_rankText == null)
								{
									break;
								}
								string text6 = _rankText.text;
								TextMeshProExtensions.Localize(_rankText, text6);
								goto IL_09f1;
								IL_07d4:
								replayButton.interactable = true;
								obj12++;
								bool flag11 = (nint)obj12 != 4;
								obj11 = 0;
								text3 = (string)1;
								if (flag11)
								{
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v5+10]");
								if ((nint)0 == 0)
								{
									break;
								}
								TextMeshProUGUI rankText = _rankText;
								object obj48 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2624;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
								string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
								if ((object)_rankText == null)
								{
									break;
								}
								nint num5 = (nint)rankText;
								_rankText.text = friendlyName;
								TextMeshProUGUI rankText2 = _rankText;
								if ((object)_rankText == null)
								{
									break;
								}
								nint num6 = (nint)rankText2;
								string text7 = _rankText.text;
								object obj49 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
								object obj50 = obj49;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v27+E4]");
								if ((nint)0 != 0)
								{
									if (!StringsExtensions.IsNullOrEmpty(text7))
									{
										goto IL_09ae;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									bool flag12 = StringsExtensions.IsNullOrEmpty(text7);
									bool flag13 = !flag12;
									object obj51 = !flag13;
									if (obj51 == null)
									{
										goto IL_09ae;
									}
								}
								goto IL_09f1;
							}
						}
					}
				}
			}
		}
		goto IL_0b00;
		IL_0066:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
		bool flag14 = (nint)0 == 0;
		object obj52 = !flag14;
		if (obj52 != null)
		{
			goto IL_012a;
		}
		goto IL_0b00;
	}

	private void RefreshRoomThemeBorder()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_01a3: Expected O, but got I
		//IL_004b: Expected O, but got I
		//IL_0060: Expected O, but got I
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_013f: Expected O, but got I
		//IL_0150: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 4024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v6+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v7+10]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v8+20]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v8+20]");
			_ = 0;
			int roomThemeId = _roomThemeId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v8+20]");
			if ((nint)roomThemeId != 0)
			{
				object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj8 = (nint)0 + (nint)1576;
				Action<bool> action = default(Action<bool>);
				action..ctor(obj2, (IntPtr)obj8);
				Image themeBorder = _themeBorder;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v8+20]");
				UIExtensions.LoadItemImage(themeBorder, 0, ImageCacher.ItemImageType.StoreTitle, FilterMode.Point, action);
			}
		}
		else
		{
			_themeBorder.enabled = false;
			_roomThemeId = 0;
			GameObject gameObject = _defaultBorder.gameObject;
			gameObject.SetActive(value: true);
			_themeProvider.UpdateTheme(null);
		}
	}

	public void OnReplayClick()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_014c: Expected O, but got I
		//IL_0161: Expected O, but got I
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_01de: Expected O, but got I
		//IL_01bd: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8206]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2184;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v8+E4]");
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
			object obj4 = (nint)0 + (nint)2184;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v8+E4]");
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
		goto IL_0133;
		IL_0133:
		ScreenManager screenManager = default(ScreenManager);
		screenManager.Back();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v4+10]");
		object obj9 = 0;
		object obj10 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v5+10]");
			GameReplayManager.GoToReplay((GameReplay)0, TrackingPlacement.GameReplaysList);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v5+10]");
			GameReplayManager.GoToReplay((GameReplay)0, TrackingPlacement.GameReplaysList);
		}
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)screenManager == null;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	public void OnDeleteClick()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0090: Expected I, but got O
		//IL_00ba: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1984;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgTitle = "Complete" + 256;
		object msgBody = "Complete" + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowNegativeConfirm((string)msgTitle, (string)msgBody, action);
	}

	private void DoDeleteGameReplay()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0115: Expected O, but got I4
		//IL_009e: Expected O, but got I
		//IL_00c0: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_019f: Expected O, but got I4
		//IL_01cd: Expected O, but got I
		//IL_01dd: Expected O, but got I
		//IL_0153: Expected O, but got I
		//IL_015c: Expected O, but got I4
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_0213: Expected O, but got I
		//IL_0213: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8208]");
		object obj2 = (nint)0 & (nint)1;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (obj2 != null)
		{
			trackEvent = TrackerLibrary.DeleteReplayClicked();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v7+E4]");
			bool flag = (nint)0 == 0;
			trackEvent2 = trackEvent;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			trackEvent = TrackerLibrary.DeleteReplayClicked();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			trackEvent2 = trackEvent;
			if (obj4 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
		object obj5 = 0;
		object obj6 = 0;
		goto IL_0161;
		IL_0161:
		object obj7 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v3+10]");
		GameReplayManager.DeleteGameReplay((GameReplayCardData)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
		object obj10 = 0;
		object obj11 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v3+10]");
		((GameReplayListUI)num).DeleteCard((GameReplayCardData)0);
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			PopupWindow.DismissMessage();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.DismissMessage();
		return;
		IL_0085:
		Tracker.DesignEvent(trackEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayCard)+40]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		obj6 = 0;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0161;
	}

	public GameReplayCard()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 1752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = this + 152;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
