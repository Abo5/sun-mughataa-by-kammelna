using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

public class SawaCatchPopup : MonoBehaviour
{
	protected static readonly Color SignatureGreen1;

	protected static readonly Color SignatureGreen2;

	protected static readonly Color SignatureRed1;

	protected static readonly Color SignatureRed2;

	private PopupUI popup;

	private TextMeshProUGUI catcherName;

	private Timer timer;

	private TextMeshProUGUI nonCatcherLabel;

	private Button closeButton;

	private List<PlayerCheatingBox> players;

	public TextMeshProUGUI ResultLabel;

	public Image ResultBackground;

	public Sprite GreenResultBackground;

	public Sprite RedResultBackground;

	private CardGame _game;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00dc: Expected O, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00fc: Expected O, but got I
		//IL_0126: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0091: Expected O, but got I
		//IL_00bb: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1408;
		object obj4 = (nint)0 + (nint)872;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 112;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		object obj9 = typeof(SqlSingle[]) + 2376;
		object obj10 = (nint)0 + (nint)864;
		((KGame)obj7).OnCheating += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj10);
		_game.OnRoundEnd += action2;
	}

	private void OnCheating(CheatingInfo cheatingInfo)
	{
		//IL_095d: Expected O, but got I4
		//IL_0056: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_016d: Expected O, but got I4
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected I, but got Unknown
		//IL_01a2: Expected O, but got I
		//IL_01d8: Expected I, but got O
		//IL_01fb: Expected O, but got I
		//IL_0207: Expected O, but got I
		//IL_022c: Expected I, but got O
		//IL_09d0: Expected O, but got I4
		//IL_0243: Expected I, but got O
		//IL_029e: Expected O, but got I4
		//IL_04f6: Expected F4, but got I4
		//IL_050a: Expected F4, but got I4
		//IL_02bc: Expected I, but got O
		//IL_0317: Expected O, but got I4
		//IL_0342: Expected I, but got O
		//IL_0352: Expected O, but got I
		//IL_0362: Expected O, but got I
		//IL_0394: Expected O, but got I4
		//IL_039c: Expected I, but got O
		//IL_03a5: Expected O, but got I4
		//IL_03c3: Expected I, but got O
		//IL_03fc: Expected O, but got I4
		//IL_0405: Expected O, but got I4
		//IL_05c7: Expected I, but got O
		//IL_043c: Expected O, but got I4
		//IL_0458: Expected O, but got I4
		//IL_0461: Expected O, but got I4
		//IL_0473: Expected O, but got I4
		//IL_0483: Expected O, but got I
		//IL_0493: Expected O, but got I
		//IL_04a8: Expected I, but got O
		//IL_04b1: Expected I4, but got O
		//IL_0603: Expected I, but got O
		//IL_063d: Expected I, but got O
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected O, but got Unknown
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Expected O, but got Unknown
		//IL_083a: Expected I, but got O
		//IL_085c: Expected O, but got I4
		//IL_088d: Expected I, but got O
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected O, but got Unknown
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Expected O, but got Unknown
		//IL_06d3: Expected I, but got O
		//IL_0705: Expected O, but got I4
		//IL_0736: Expected I, but got O
		//IL_08a4: Expected I, but got O
		//IL_08cd: Expected O, but got I
		//IL_08dd: Expected O, but got I
		//IL_08e5: Expected I, but got O
		//IL_08f5: Expected O, but got I
		//IL_0920: Expected I, but got O
		//IL_074d: Expected I, but got O
		//IL_0776: Expected O, but got I
		//IL_077f: Expected F4, but got O
		//IL_078f: Expected O, but got I
		//IL_0797: Expected I, but got O
		//IL_07a7: Expected O, but got I
		//IL_07d2: Expected I, but got O
		//IL_093f: Expected O, but got I4
		//IL_09fb: Expected O, but got I
		//IL_07f1: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66B0]");
		nint num = 0;
		bool flag = cheatingInfo == null;
		TextMeshProUGUI textMeshProUGUI = (TextMeshProUGUI)152985600;
		CheatingInfo cheatingInfo2 = cheatingInfo;
		if (!flag)
		{
			if (!cheatingInfo.IsWrongSawa)
			{
				return;
			}
			bool flag2 = (object)popup == null;
			textMeshProUGUI = (TextMeshProUGUI)152985600;
			cheatingInfo2 = cheatingInfo;
			if (!flag2)
			{
				popup.PopFromCenter();
				bool flag3 = (object)_game == null;
				textMeshProUGUI = (TextMeshProUGUI)152985600;
				cheatingInfo2 = cheatingInfo;
				if (!flag3)
				{
					textMeshProUGUI = catcherName;
					Room room = _game.Room;
					string text;
					if (SFSKammelnaRoomExtensions.IsCheatingAllowed(room))
					{
						bool flag4 = cheatingInfo.<CurrentCatcher>k__BackingField == null;
						cheatingInfo2 = cheatingInfo;
						if (flag4)
						{
							goto IL_04bf;
						}
						text = cheatingInfo.<CurrentCatcher>k__BackingField.NickName;
					}
					else
					{
						object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
						object obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v48+E4]");
						bool flag5 = (nint)0 == 0;
						object obj3 = !flag5;
						if (obj3 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						num = (nint)("<ds.DataTable.OnColumnChanging|INFO> {0}" + 2448);
						text = LocalizationUtil.Localize((string)num);
					}
					TextMeshProExtensions.FixArabic(textMeshProUGUI, text);
					List<object> list = (List<object>)(object)players;
					bool flag6 = players == null;
					nint num2 = unchecked((nint)null);
					cheatingInfo2 = cheatingInfo;
					if (!flag6)
					{
						object obj4 = (nint)0 + (nint)1904;
						object obj5 = (nint)0 + (nint)2856;
						object obj7 = default(object);
						object obj6 = obj7;
						object obj9 = default(object);
						object obj8 = obj9;
						object obj11 = default(object);
						object obj10 = obj11;
						KPlayer kPlayer2 = default(KPlayer);
						KPlayer kPlayer = kPlayer2;
						nint num3 = unchecked((nint)null);
						int num4 = 0;
						object obj15;
						do
						{
							bool flag7 = num4 >= list._size;
							obj7 = obj6;
							obj9 = obj8;
							obj11 = obj10;
							kPlayer2 = kPlayer;
							num2 = num3;
							num = list._size;
							textMeshProUGUI = (TextMeshProUGUI)num4;
							cheatingInfo2 = cheatingInfo;
							if (!flag7)
							{
								num2 = (nint)obj4;
								object obj12 = list.get_Item(num4);
								bool flag8 = cheatingInfo.<CardsInHands>k__BackingField == null;
								obj7 = obj6;
								obj9 = obj8;
								obj11 = obj10;
								kPlayer2 = kPlayer;
								num = list._size;
								textMeshProUGUI = (TextMeshProUGUI)num4;
								cheatingInfo2 = cheatingInfo;
								if (flag8)
								{
									break;
								}
								num2 = (nint)obj5;
								object obj13 = ((List<object>)(object)cheatingInfo.<CardsInHands>k__BackingField).get_Item(num4);
								bool flag9 = obj12 == null;
								obj7 = obj6;
								obj9 = obj8;
								obj11 = obj10;
								kPlayer2 = kPlayer;
								num = list._size;
								textMeshProUGUI = (TextMeshProUGUI)num4;
								cheatingInfo2 = cheatingInfo;
								if (flag9)
								{
									break;
								}
								kPlayer2 = cheatingInfo.<CurrentCatcher>k__BackingField;
								num = (nint)obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v21 (Il2CppClass<System.Object>)+188]");
								obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v21 (Il2CppClass<System.Object>)+190]");
								obj9 = 0;
								int num5 = num4 + 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v218 @ X8_v21 (Il2CppClass<System.Object>)+188] (should have been resolved before IL gen)");
								bool flag10 = players == null;
								obj7 = 0;
								num2 = (nint)obj13;
								textMeshProUGUI = (TextMeshProUGUI)num5;
								cheatingInfo2 = cheatingInfo;
								if (flag10)
								{
									break;
								}
								num2 = (nint)obj4;
								int num6 = num5 - 1;
								object obj14 = ((List<object>)(object)players).get_Item(num6);
								bool flag11 = obj14 == null;
								obj7 = 0;
								textMeshProUGUI = (TextMeshProUGUI)num6;
								cheatingInfo2 = cheatingInfo;
								if (flag11)
								{
									break;
								}
								((BaseCheatingBox)obj14).DisableCards();
								list = (List<object>)(object)players;
								textMeshProUGUI = (TextMeshProUGUI)(num6 + 1);
								bool flag12 = players == null;
								obj15 = !flag12;
								obj7 = 0;
								cheatingInfo2 = cheatingInfo;
								obj6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v21 (Il2CppClass<System.Object>)+190]");
								obj8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v21 (Il2CppClass<System.Object>)+188]");
								obj10 = 0;
								kPlayer = cheatingInfo.<CurrentCatcher>k__BackingField;
								num3 = (nint)obj4;
								num4 = (int)textMeshProUGUI;
								continue;
							}
							if ((object)timer == null)
							{
								break;
							}
							float num7 = cheatingInfo2.<TimerSeconds>k__BackingField;
							timer.StartTimer(cheatingInfo2.<TimerSeconds>k__BackingField);
							if ((object)closeButton == null)
							{
								break;
							}
							GameObject gameObject = closeButton.gameObject;
							bool flag13 = (object)_game == null;
							textMeshProUGUI = (TextMeshProUGUI)(object)gameObject;
							if (flag13)
							{
								break;
							}
							bool isSpectator = _game.IsSpectator;
							bool flag14 = (object)gameObject == null;
							textMeshProUGUI = (TextMeshProUGUI)(object)gameObject;
							if (flag14)
							{
								break;
							}
							bool active = (byte)((isSpectator ? 1u : 0u) ^ 1u) != 0;
							gameObject.SetActive(active);
							bool flag15 = (object)nonCatcherLabel == null;
							num2 = unchecked((nint)null);
							textMeshProUGUI = (TextMeshProUGUI)(object)gameObject;
							if (flag15)
							{
								break;
							}
							GameObject gameObject2 = nonCatcherLabel.gameObject;
							bool flag16 = (object)_game == null;
							num2 = unchecked((nint)null);
							textMeshProUGUI = (TextMeshProUGUI)(object)gameObject2;
							if (flag16)
							{
								break;
							}
							bool isSpectator2 = _game.IsSpectator;
							bool flag17 = (object)gameObject2 == null;
							num2 = unchecked((nint)null);
							textMeshProUGUI = (TextMeshProUGUI)(object)gameObject2;
							if (flag17)
							{
								break;
							}
							gameObject2.SetActive(isSpectator2);
							Image resultBackground;
							if (cheatingInfo2.<Correct>k__BackingField)
							{
								object text2 = "Complete" + 1744;
								TextMeshProExtensions.Localize(ResultLabel, (string)text2);
								cheatingInfo2 = (CheatingInfo)(object)ResultLabel;
								textMeshProUGUI = (TextMeshProUGUI)(typeof(RegisteredWaitHandle) + 2792);
								nint num8 = (nint)textMeshProUGUI;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v22 (Il2CppClass<TMPro.TextMeshProUGUI>)+E4]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v22 (Il2CppClass<TMPro.TextMeshProUGUI>)+E4]");
								bool flag18 = (nint)0 == 0;
								object obj16 = !flag18;
								if (obj16 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag19 = cheatingInfo2 == null;
								num2 = unchecked((nint)null);
								if (flag19)
								{
									break;
								}
								nint num9 = (nint)textMeshProUGUI;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v16 (Il2CppClass<TMPro.TextMeshProUGUI>)+B8]");
								nint num10 = 0;
								ProfilerMarker k_ParseMarkupTextMarker = TextMeshProUGUI.k_ParseMarkupTextMarker;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v17 (Il2CppStaticFields<TMPro.TextMeshProUGUI>)+1C]");
								object obj17 = 0;
								num7 = (float)TextMeshProUGUI.k_GenerateTextPhaseIMarker;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v17 (Il2CppStaticFields<TMPro.TextMeshProUGUI>)+14]");
								object obj18 = 0;
								nint num11 = (nint)cheatingInfo2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v18 (Il2CppClass<CheatingInfo>)+2A8]");
								obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v222 @ X8_v18 (Il2CppClass<CheatingInfo>)+2A8] (should have been resolved before IL gen)");
								resultBackground = ResultBackground;
								bool flag20 = (object)ResultBackground == null;
								num2 = unchecked((nint)null);
								num = num11;
								if (flag20)
								{
									break;
								}
								object obj19 = 96;
							}
							else
							{
								object text3 = "WhiteSmoke" + 480;
								TextMeshProExtensions.Localize(ResultLabel, (string)text3);
								cheatingInfo2 = (CheatingInfo)(object)ResultLabel;
								textMeshProUGUI = (TextMeshProUGUI)(typeof(RegisteredWaitHandle) + 2792);
								nint num12 = (nint)textMeshProUGUI;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v16 (Il2CppClass<TMPro.TextMeshProUGUI>)+E4]");
								bool flag21 = (nint)0 == 0;
								object obj20 = !flag21;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag22 = cheatingInfo2 == null;
								num2 = unchecked((nint)null);
								if (flag22)
								{
									break;
								}
								nint num13 = (nint)textMeshProUGUI;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v9 (Il2CppClass<TMPro.TextMeshProUGUI>)+B8]");
								nint num14 = 0;
								ProfilerMarker k_ParseMarkupTextMarker = TextMeshProUGUI.k_ComputeTextMetricsMarker;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v10 (Il2CppStaticFields<TMPro.TextMeshProUGUI>)+3C]");
								object obj17 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v10 (Il2CppStaticFields<TMPro.TextMeshProUGUI>)+34]");
								object obj18 = 0;
								nint num15 = (nint)cheatingInfo2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v11 (Il2CppClass<CheatingInfo>)+2A8]");
								obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v224 @ X8_v11 (Il2CppClass<CheatingInfo>)+2A8] (should have been resolved before IL gen)");
								resultBackground = ResultBackground;
								bool flag23 = (object)ResultBackground == null;
								num2 = unchecked((nint)null);
								num = num15;
								if (flag23)
								{
									break;
								}
								object obj19 = 104;
							}
							Image image = resultBackground;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SawaCatchPopup)+v306 @ X8_v5]");
							image.sprite = (Sprite)0;
							return;
						}
						while (obj15 != null);
					}
				}
			}
		}
		goto IL_04bf;
		IL_04bf:
		throw new NullReferenceException();
	}

	private void Show()
	{
		popup.PopFromCenter();
	}

	private void Hide()
	{
		popup.ShrinkToParent();
	}

	public void Close()
	{
		_game.SendCatchClose();
		popup.ShrinkToParent();
	}

	static SawaCatchPopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0041: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 2792;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252C60]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252C70]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252C80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252C90]");
		_ = 0;
	}
}
