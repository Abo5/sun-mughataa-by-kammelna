using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server;
using ListView;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UI;

public class MatchupUi : ListViewItem<Matchup, int>
{
	private TextMeshProUGUI matchTitle;

	private TeamUi[] teamUis;

	private GameObject[] teamOverlay;

	private GameObject vsObject;

	private CanvasGroup background;

	private Graphic[] teamBackgrounds;

	private RectTransform[] elementsContainers;

	private float fullScale;

	private float partialScale;

	private TournamentSceneEventsChannel tournamentEventsChannel;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0100: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		//IL_00a2: Expected I, but got O
		//IL_00d3: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 272;
		object obj2 = (nint)0 + (nint)3944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj4 = (nint)0 + (nint)3936;
		tournamentEventsChannel.OnPlayersSelected += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action2 = default(Action<int>);
		action2..ctor((object)this, (IntPtr)obj4);
		tournamentEventsChannel.OnSeatSelected += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action3 = default(Action<int>);
		action3..ctor((object)this, (IntPtr)obj4);
		tournamentEventsChannel.OnTeamSelected += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action4 = default(Action<int>);
		action4..ctor((object)this, (IntPtr)obj4);
		tournamentEventsChannel.OnKickPlayer += action4;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0100: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		//IL_00a2: Expected I, but got O
		//IL_00d3: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 272;
		object obj2 = (nint)0 + (nint)3944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj4 = (nint)0 + (nint)3936;
		tournamentEventsChannel.OnPlayersSelected -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action2 = default(Action<int>);
		action2..ctor((object)this, (IntPtr)obj4);
		tournamentEventsChannel.OnSeatSelected -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action3 = default(Action<int>);
		action3..ctor((object)this, (IntPtr)obj4);
		tournamentEventsChannel.OnTeamSelected -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action4 = default(Action<int>);
		action4..ctor((object)this, (IntPtr)obj4);
		tournamentEventsChannel.OnKickPlayer -= action4;
	}

	public unsafe override void Setup(Matchup datum, bool firstTime)
	{
		//IL_000c: Expected O, but got I
		//IL_06b9: Expected O, but got I
		//IL_06e1: Expected O, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005c: Expected O, but got I
		//IL_00c6: Expected O, but got I4
		//IL_06ff: Expected O, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_042d: Expected O, but got I
		//IL_0468: Expected O, but got I
		//IL_0477: Expected O, but got I4
		//IL_0216: Expected O, but got I4
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_04c5: Expected O, but got Ref
		//IL_02a1: Expected O, but got I
		//IL_04db: Expected I, but got O
		//IL_04eb: Expected O, but got I
		//IL_0514: Expected O, but got I
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected O, but got Unknown
		//IL_02ee: Expected O, but got I
		//IL_02f6: Expected I, but got O
		//IL_0306: Expected O, but got I
		//IL_0316: Expected O, but got I
		//IL_0337: Expected O, but got I
		//IL_0337: Expected O, but got I
		//IL_0347: Expected O, but got I
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_0377: Expected O, but got I4
		//IL_038f: Expected O, but got I
		//IL_03f2: Expected O, but got I
		//IL_05ab: Expected O, but got I4
		//IL_05f1: Expected I4, but got O
		//IL_05fa: Expected O, but got I4
		object obj = (nint)0 + (nint)1856;
		object obj2 = datum;
		object obj3 = obj;
		bool flag = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, flag);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MatchupUi)+40]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MatchupUi)+40]");
		bool flag2 = (nint)0 == 0;
		bool flag3 = flag;
		object[] array = (object[])152985600;
		if (!flag2)
		{
			array = (object[])(typeof(TypeConverter<ushort, char>) + 3400);
			object text = "LAK" + 3960;
			object obj5 = typeof(Queue<string>) + 848;
			object obj6 = (nint)0 + (nint)2200;
			object obj7 = obj;
			bool flag5 = default(bool);
			bool flag4 = flag5;
			bool flag7 = default(bool);
			bool flag6 = flag7;
			object obj9 = default(object);
			object obj8 = obj9;
			object obj11 = default(object);
			object obj10 = obj11;
			object obj13 = default(object);
			object obj12 = obj13;
			bool flag9 = default(bool);
			bool flag8 = flag9;
			bool flag11 = default(bool);
			bool flag10 = flag11;
			object obj15 = default(object);
			object obj14 = obj15;
			object obj17 = default(object);
			object obj16 = obj17;
			TeamUi[] array3 = default(TeamUi[]);
			TeamUi[] array2 = array3;
			object obj19 = default(object);
			object obj18 = obj19;
			object obj20 = 4;
			object[] array4 = default(object[]);
			object obj31 = default(object);
			SessionModel sessionModel = default(SessionModel);
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v17+10]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v17+10]");
				bool flag12 = (nint)0 == 0;
				flag3 = flag;
				obj3 = obj7;
				flag5 = flag4;
				flag7 = flag6;
				obj9 = obj8;
				obj11 = obj10;
				obj13 = obj12;
				flag9 = flag8;
				flag11 = flag10;
				obj15 = obj14;
				obj17 = obj16;
				array3 = array2;
				obj19 = obj18;
				obj = obj20;
				if (flag12)
				{
					break;
				}
				obj19 = obj20 - 4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v18+18]");
				array3 = (TeamUi[])0;
				object obj22 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v18+18]");
				bool flag13 = (nint)obj22 < 0;
				obj17 = !flag13;
				object obj23 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v18+18]");
				obj15 = obj23 - 0;
				flag11 = (nint)obj15 < 0;
				flag9 = obj15 == null;
				object obj24 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v18+18]");
				obj13 = obj24 ^ 0;
				obj11 = obj19 ^ obj15;
				obj9 = obj13 & obj11;
				flag7 = (nint)obj9 < 0;
				object obj25 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v18+18]");
				flag5 = (nint)obj25 >= 0;
				flag3 = flag;
				obj3 = obj7;
				obj = obj20;
				object obj32;
				if (!flag5)
				{
					array3 = teamUis;
					bool flag14 = teamUis == null;
					flag3 = flag;
					obj3 = obj7;
					obj = obj20;
					if (flag14)
					{
						break;
					}
					bool flag15 = (nint)obj19 < array3.Length;
					obj17 = !flag15;
					obj15 = obj19 - array3.Length;
					flag11 = (nint)obj15 < 0;
					flag9 = obj15 == null;
					obj13 = obj19 ^ array3.Length;
					obj11 = obj19 ^ obj15;
					obj9 = obj13 & obj11;
					flag7 = (nint)obj9 < 0;
					flag3 = flag;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X10_v3 (TeamUi[])+v190 @ X22_v10*8]");
						TeamUi teamUi = (TeamUi)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X10_v3 (TeamUi[])+v190 @ X22_v10*8]");
						bool flag16 = (nint)0 == 0;
						flag3 = flag;
						obj3 = obj7;
						obj = obj20;
						if (flag16)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v18+v190 @ X22_v10*8]");
						obj2 = 0;
						nint num = (nint)teamUi;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v19 (Il2CppClass<TeamUi>)+308]");
						obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v19 (Il2CppClass<TeamUi>)+310]");
						obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X10_v3 (TeamUi[])+v190 @ X22_v10*8]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v18+v190 @ X22_v10*8]");
						((TeamUi)num2).Setup((QueueTeam)0, flag);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MatchupUi)+40]");
						obj4 = 0;
						obj = obj20 + 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MatchupUi)+40]");
						bool flag17 = (nint)0 == 0;
						object obj26 = !flag17;
						flag3 = flag;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v19 (Il2CppClass<TeamUi>)+310]");
						obj7 = 0;
						flag4 = flag5;
						flag6 = flag7;
						obj8 = obj9;
						obj10 = obj11;
						obj12 = obj13;
						flag8 = flag9;
						flag10 = flag11;
						obj14 = obj15;
						obj16 = obj17;
						array2 = teamUis;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v19 (Il2CppClass<TeamUi>)+308]");
						obj18 = 0;
						obj20 = obj;
						if (obj26 == null)
						{
							break;
						}
						continue;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MatchupUi)+40]");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MatchupUi)+40]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v7+18]");
					object obj28 = (nint)0 + (nint)1;
					object obj29 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					bool flag18 = array4 == null;
					object obj30 = obj28;
					array = array4;
					if (flag18)
					{
						break;
					}
					bool flag19 = obj31 == null;
					obj2 = (object)(&obj30);
					if (!flag19)
					{
						nint num3 = (nint)array4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
						obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag20 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
						obj32 = 0;
						if (flag20)
						{
							goto IL_067d;
						}
					}
					bool flag21 = array4.Length == 0;
					obj7 = obj3;
					if (!flag21)
					{
						object obj33 = array4 + 32;
						obj33 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						TextMeshProExtensions.Localize(matchTitle, (string)text, array4);
						object obj34 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v18+E4]");
						bool flag22 = (nint)0 == 0;
						object obj35 = !flag22;
						if (obj35 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
						bool flag23 = (object)sessionModel == null;
						obj30 = obj28;
						flag3 = (byte)(int)array4 != 0;
						obj3 = 0;
						array = array4;
						if (flag23)
						{
							break;
						}
						Room currentRoom = sessionModel.CurrentRoom;
						if (SFSKammelnaRoomExtensions.IsTournamentTeamsShuffled(currentRoom))
						{
							SetRandomView();
						}
						else
						{
							SetMatchesView();
						}
						return;
					}
				}
				ex = new IndexOutOfRangeException();
				obj3 = obj7;
				obj32 = obj2;
				goto IL_067d;
				IL_067d:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
				throw new OutOfMemoryException();
			}
		}
		throw new NullReferenceException();
	}

	private void Initialize(TeamUi playerUi, QueueTeam team, bool firstTime)
	{
		//IL_0008: Expected I, but got O
		//IL_0018: Expected O, but got I
		//IL_0028: Expected O, but got I
		nint num = (nint)playerUi;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<TeamUi>)+308]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<TeamUi>)+310]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void SelectSeat(int seat)
	{
		//IL_003a: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MatchupUi)+40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+18]");
		int seat2 = (int)((nint)seat + (nint)0);
		tournamentEventsChannel.TriggerSeatSelected(seat2);
	}

	public void SelectTeam(int teamIndex)
	{
		//IL_003a: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MatchupUi)+40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+18]");
		int teamIndex2 = (int)((nint)teamIndex + (nint)0);
		tournamentEventsChannel.TriggerTeamSelected(teamIndex2);
	}

	private void SetMatchesView()
	{
		//IL_0029: Expected O, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00ae: Expected O, but got I4
		//IL_0119: Expected O, but got I
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f8: Expected O, but got I4
		//IL_0165: Expected O, but got I
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		bool activeSelf = vsObject.activeSelf;
		bool flag = !activeSelf;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		vsObject.SetActive(value: true);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(background, 1f, 0.3f);
		Graphic[] array = teamBackgrounds;
		if (array.Length >= 1)
		{
			object obj2 = array + 32;
			object obj3 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X22_v6+v216 @ X21_v9*8]");
				TweenerCore<Color, Color, ColorOptions> tweenerCore2 = DOTweenModuleUI.DOFade((Graphic)0, 0f, 0.3f);
				obj3++;
			}
			while ((nint)obj3 < array.Length);
		}
		RectTransform[] array2 = elementsContainers;
		if (array2.Length >= 1)
		{
			object obj4 = array2 + 32;
			object obj5 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X22_v5+v239 @ X21_v6*8]");
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScale((Transform)0, partialScale, 0.3f);
				obj5++;
			}
			while ((nint)obj5 < array2.Length);
		}
	}

	private void SetRandomView()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009b: Expected O, but got I4
		//IL_0106: Expected O, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e5: Expected O, but got I4
		//IL_0152: Expected O, but got I
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		if (!vsObject.activeSelf)
		{
			return;
		}
		vsObject.SetActive(value: false);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(background, 0f, 0.3f);
		Graphic[] array = teamBackgrounds;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X22_v6+v220 @ X21_v9*8]");
				TweenerCore<Color, Color, ColorOptions> tweenerCore2 = DOTweenModuleUI.DOFade((Graphic)0, 0.37f, 0.3f);
				obj2++;
			}
			while ((nint)obj2 < array.Length);
		}
		RectTransform[] array2 = elementsContainers;
		if (array2.Length >= 1)
		{
			object obj3 = array2 + 32;
			object obj4 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X22_v5+v243 @ X21_v6*8]");
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScale((Transform)0, fullScale, 0.3f);
				obj4++;
			}
			while ((nint)obj4 < array2.Length);
		}
	}

	private void OnPlayersSelected(IEnumerable<QueuePlayer> players)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_003c: Expected O, but got I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_005d: Expected O, but got I4
		//IL_0081: Expected O, but got I
		int num = Enumerable.Count((IEnumerable<object>)players);
		GameObject[] array = teamOverlay;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				object obj3 = num - 2;
				bool active = obj3 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X22_v6+v102 @ X21_v6*8]");
				((GameObject)0).SetActive(active);
			}
			while ((nint)obj2 < array.Length);
		}
	}

	private void HideOverlays(int _)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		GameObject[] array = teamOverlay;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v4+v40 @ X20_v5*8]");
				((GameObject)0).SetActive(value: false);
			}
			while ((nint)obj2 < array.Length);
		}
	}

	public MatchupUi()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
