using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Server.Models;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class MassTournamentParticipantBadge : MassWidget, IInitializable
{
	private Transform frontPanel;

	private Transform backPanel;

	private Transform badge;

	private PopupUI popup;

	private Image sponsorLogoImage;

	private TextMeshProUGUI participationIdLabel;

	private TextMeshProUGUI pointsLabel;

	private TextMeshProUGUI stageLabel;

	private DiscreteProgressIndicator triesIndicator;

	private float flipTime = 0.8f;

	private MassEventModel _info;

	void IInitializable.Initialize()
	{
		Show();
	}

	protected override void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0094: Expected I, but got O
		//IL_005b: Expected I, but got O
		//IL_0071: Expected O, but got I
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2640;
		object obj2 = (nint)0 + (nint)3440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		eventChannel.OnMassPlayerStateChanged += action;
		MassTournamentServerConnector connector = _connector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)2368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39978C8");
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2640;
		object obj2 = (nint)0 + (nint)3440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		eventChannel.OnMassPlayerStateChanged -= action;
	}

	private void Reload(MassTournamentPlayerState player)
	{
		MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)(object)this).GetTournamentLiveData();
		MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
		UIExtensions.LoadMassTournamentImage(sponsorLogoImage, cachedMassEvent, ImageCacher.MassTournamentImageType.BigLogo);
		UpdatePlayerState(player);
	}

	private unsafe void UpdatePlayerState(MassTournamentPlayerState player)
	{
		//IL_0069: Expected I, but got O
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00be: Expected O, but got I4
		//IL_00dc: Expected I, but got O
		//IL_00e4: Expected O, but got Ref
		//IL_0109: Expected O, but got Ref
		//IL_0181: Expected I, but got O
		//IL_011f: Expected I, but got O
		//IL_012f: Expected O, but got I
		//IL_014d: Expected I, but got O
		//IL_015d: Expected O, but got I
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_02e7: Expected O, but got I4
		//IL_02ef: Expected I, but got O
		//IL_021a: Expected O, but got I4
		//IL_0222: Expected I, but got O
		//IL_032b: Expected O, but got I4
		//IL_0330: Expected I, but got O
		//IL_0338: Expected O, but got I4
		//IL_0274: Expected O, but got I
		//IL_0290: Expected O, but got I4
		//IL_02b7: Expected O, but got I4
		//IL_02bf: Expected I, but got O
		bool flag = player == null;
		MassTournamentPlayerState massTournamentPlayerState = player;
		object[] array = default(object[]);
		int num4;
		object obj7;
		nint num2;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			bool flag2 = (object)participationIdLabel == null;
			massTournamentPlayerState = player;
			if (!flag2)
			{
				participationIdLabel.SetText(player.<UniqueId>k__BackingField);
				int num = default(int);
				string text = num.ToString();
				bool flag3 = (object)pointsLabel == null;
				num2 = unchecked((nint)null);
				massTournamentPlayerState = null;
				if (!flag3)
				{
					object obj = typeof(TypeConverter<ushort, char>) + 3400;
					pointsLabel.SetText(text);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					object obj2 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					bool flag4 = array == null;
					num2 = unchecked((nint)null);
					object obj3 = default(object);
					massTournamentPlayerState = (MassTournamentPlayerState)(&obj3);
					if (!flag4)
					{
						object obj4 = default(object);
						bool flag5 = obj4 == null;
						MassTournamentPlayerState massTournamentPlayerState2 = (MassTournamentPlayerState)(&obj3);
						if (!flag5)
						{
							nint num3 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
							massTournamentPlayerState2 = (MassTournamentPlayerState)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag6 = ex == null;
							num2 = unchecked((nint)null);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
							massTournamentPlayerState = (MassTournamentPlayerState)0;
							if (flag6)
							{
								goto IL_0377;
							}
						}
						bool flag7 = array.Length == 0;
						num2 = unchecked((nint)null);
						massTournamentPlayerState = massTournamentPlayerState2;
						if (flag7)
						{
							goto IL_0369;
						}
						object obj5 = "SetRoomVariables request error" + 2568;
						object obj6 = array + 32;
						obj6 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						TextMeshProExtensions.Localize(stageLabel, (string)obj5, array);
						if (player.<TriesLeft>k__BackingField < 1)
						{
							goto IL_02c4;
						}
						bool flag8 = (object)_connector == null;
						obj7 = 0;
						num2 = (nint)array;
						massTournamentPlayerState = (MassTournamentPlayerState)obj5;
						if (!flag8)
						{
							MassEventStageViewModel activeStage = _connector.GetActiveStage();
							if (activeStage == null)
							{
								goto IL_02c4;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v27 (Server.Models.MassEventStageViewModel)+24]");
							massTournamentPlayerState = (MassTournamentPlayerState)0;
							bool flag9 = (object)triesIndicator == null;
							object obj8 = !flag9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v27 (Server.Models.MassEventStageViewModel)+24]");
							num4 = 0;
							if (obj8 != null)
							{
								goto IL_0302;
							}
							obj7 = 0;
							num2 = (nint)array;
						}
					}
				}
			}
		}
		goto IL_035b;
		IL_02c4:
		bool flag10 = (object)triesIndicator == null;
		num4 = 0;
		obj7 = 0;
		num2 = (nint)array;
		massTournamentPlayerState = null;
		if (!flag10)
		{
			goto IL_0302;
		}
		goto IL_035b;
		IL_0302:
		triesIndicator.MaxProgress = num4;
		bool flag11 = (object)triesIndicator == null;
		obj7 = 0;
		num2 = unchecked((nint)null);
		massTournamentPlayerState = (MassTournamentPlayerState)num4;
		if (!flag11)
		{
			triesIndicator.CurrentProgress = player.<TriesLeft>k__BackingField;
			return;
		}
		goto IL_035b;
		IL_0377:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0369:
		ex = new IndexOutOfRangeException();
		goto IL_0377;
		IL_035b:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0369;
	}

	public void Show()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		//IL_00a4: Expected O, but got I4
		popup.SlideFromTop();
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1488;
		object obj3 = typeof(RegisteredWaitHandle) + 3136;
		GameObject gameObject = popup.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(popup, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(gameObject, action);
	}

	public void Hide()
	{
		popup.SlideToTop();
	}

	public void FlipBadge()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0103: Expected O, but got I
		//IL_012d: Expected O, but got I4
		//IL_0061: Expected O, but got I4
		//IL_0098: Expected I, but got O
		//IL_00c8: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj3 = (nint)0 + (nint)3432;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		double num = (double)flipTime * 0.5;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t = ShortcutExtensions.DORotate(badge, (Vector3)0, 0f);
		Sequence s2 = TweenSettingsExtensions.Append(s, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj3);
		Sequence s3 = TweenSettingsExtensions.AppendCallback(s2, tweenCallback);
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t2 = ShortcutExtensions.DORotate(badge, (Vector3)0, 0f);
		Sequence sequence = TweenSettingsExtensions.Append(s3, t2);
	}

	public void FlipBadge2()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0103: Expected O, but got I
		//IL_012d: Expected O, but got I4
		//IL_0061: Expected O, but got I4
		//IL_0098: Expected I, but got O
		//IL_00c8: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj3 = (nint)0 + (nint)3424;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		double num = (double)flipTime * 0.5;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t = ShortcutExtensions.DORotate(badge, (Vector3)0, 0f);
		Sequence s2 = TweenSettingsExtensions.Append(s, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj3);
		Sequence s3 = TweenSettingsExtensions.AppendCallback(s2, tweenCallback);
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t2 = ShortcutExtensions.DORotate(badge, (Vector3)0, 0f);
		Sequence sequence = TweenSettingsExtensions.Append(s3, t2);
	}

	private void DisplaySide(bool back)
	{
		GameObject gameObject = backPanel.gameObject;
		gameObject.SetActive(back);
		GameObject gameObject2 = frontPanel.gameObject;
		bool active = (byte)((back ? 1u : 0u) ^ 1u) != 0;
		gameObject2.SetActive(active);
	}

	private void <FlipBadge>b__18_0()
	{
		DisplaySide(back: true);
	}

	private void <FlipBadge2>b__19_0()
	{
		DisplaySide(back: false);
	}
}
