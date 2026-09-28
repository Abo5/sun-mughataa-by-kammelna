using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using TMPro;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ProjectButtons : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<KeyValuePair<BalootProject, int>, IEnumerable<BalootProject>> <>9__22_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal IEnumerable<BalootProject> <GetProjects>b__22_0(KeyValuePair<BalootProject, int> pair)
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)2552;
			object obj2 = (object)pair >> 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCCE38");
			IEnumerable<BalootProject> result = default(IEnumerable<BalootProject>);
			return result;
		}
	}

	private Button buttonProjectSira;

	private TextMeshProUGUI labelCounterSira;

	private Button buttonProject50;

	private TextMeshProUGUI labelCounter50;

	private Button buttonProject100;

	private TextMeshProUGUI labelCounter100;

	private Button buttonProject400;

	private TextMeshProUGUI labelCounter400;

	private GameEventsChannel gameEventsChannel;

	private bool isShown;

	private Dictionary<BalootProject, int> projects;

	private BalootGame _balootGame;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_020a: Expected O, but got I
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_022a: Expected O, but got I
		//IL_0254: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I
		//IL_00c5: Expected I, but got O
		//IL_00f7: Expected O, but got I
		//IL_010f: Expected I, but got O
		//IL_0141: Expected O, but got I
		//IL_0159: Expected I, but got O
		//IL_018b: Expected O, but got I
		//IL_01a3: Expected I, but got O
		//IL_01b4: Expected O, but got I
		//IL_01e9: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)8;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)3640;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 120;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		((KGame)obj7).OnGameStateUpdated += action;
		Button button = buttonProjectSira;
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj10 = (nint)0 + (nint)3608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj10);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = buttonProject50;
		object obj11 = (nint)0 + (nint)3616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj11);
		button2.m_OnClick.AddListener(unityAction2);
		Button button3 = buttonProject100;
		object obj12 = (nint)0 + (nint)3624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj12);
		button3.m_OnClick.AddListener(unityAction3);
		Button button4 = buttonProject400;
		object obj13 = (nint)0 + (nint)3632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction4 = default(UnityAction);
		unityAction4..ctor(this, (IntPtr)obj13);
		object obj14 = (nint)0 + (nint)3648;
		button4.m_OnClick.AddListener(unityAction4);
		ResetProjects();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj14);
		gameEventsChannel.ToggleProjectsPanel += action2;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		gameEventsChannel.ToggleProjectsPanel -= action;
	}

	private void OnGameStateUpdated()
	{
		//IL_002e: Expected O, but got I4
		//IL_0065: Expected O, but got I4
		//IL_006e: Expected O, but got I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_019f: Expected O, but got I4
		//IL_00b1: Expected O, but got I4
		//IL_015f: Expected O, but got I
		//IL_0102: Expected O, but got I4
		bool isReplay = _balootGame.IsReplay;
		bool flag = !isReplay;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		bool isSpectator = _balootGame.IsSpectator;
		bool flag2 = !isSpectator;
		object obj2 = !flag2;
		object obj3 = 0;
		if (obj2 == null)
		{
			BalootPlayer myPlayer = _balootGame.MyPlayer;
			bool isHumanSeated = myPlayer.IsHumanSeated;
			bool flag3 = !isHumanSeated;
			obj3 = 0;
			if (!flag3)
			{
				BalootPlayer myPlayer2 = _balootGame.MyPlayer;
				List<Card> <Cards>k__BackingField = ((CardGamePlayer)myPlayer2).<Cards>k__BackingField;
				bool flag4 = <Cards>k__BackingField._size == 8;
				obj3 = 0;
				if (flag4)
				{
					return;
				}
			}
		}
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj6 = !flag5;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.DeclaredProjects, 0);
		ResetProjects();
		object obj7 = (nint)0 + (nint)2872;
		RectTransform target = UIExtensions.rectTransform(this);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target, -732f, 0.5f, snapping: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		isShown = false;
	}

	private void ResetProjects()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0026: Expected O, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_00d9: Expected O, but got I
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, int> dictionary = default(Dictionary<System.Int32Enum, int>);
		dictionary..ctor();
		object obj2 = (nint)0 + (nint)1672;
		dictionary.Add((System.Int32Enum)0, 0);
		dictionary.Add((System.Int32Enum)1, 0);
		dictionary.Add((System.Int32Enum)2, 0);
		dictionary.Add((System.Int32Enum)3, 0);
		object obj3 = this + 112;
		obj3 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X21_v7+8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v4+1A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v5+1C]");
		object obj6 = (nint)0 + (nint)1;
		_ = 0;
		UpdateLabels();
	}

	public void ToggleProjectsPanel()
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0011: Expected O, but got I
		//IL_0054: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (isShown)
		{
			object obj2 = (nint)0 + (nint)2872;
			RectTransform target = UIExtensions.rectTransform(this);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target, -732f, 0.5f, snapping: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			isShown = false;
			trackEvent = TrackerLibrary.GameHideProjectsClicked();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_00b8;
			}
			trackEvent2 = trackEvent;
		}
		else
		{
			Show();
			trackEvent = TrackerLibrary.GameShowProjectsClicked();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			trackEvent2 = trackEvent;
			if (!flag2)
			{
				goto IL_00b8;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		return;
		IL_00b8:
		Tracker.DesignEvent(trackEvent);
	}

	private void Show()
	{
		//IL_0011: Expected O, but got I
		UpdateLabels();
		RectTransform rectTransform = UIExtensions.rectTransform(this);
		object obj = (nint)0 + (nint)2872;
		rectTransform.SetAsLastSibling();
		RectTransform target = UIExtensions.rectTransform(this);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target, -328f, 0.5f, snapping: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		isShown = true;
	}

	private void Hide()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2872;
		RectTransform target = UIExtensions.rectTransform(this);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target, -732f, 0.5f, snapping: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		isShown = false;
	}

	private void UpdateLabels()
	{
		int num = ((Dictionary<System.Int32Enum, int>)(object)projects).get_Item((System.Int32Enum)0);
		int num2 = default(int);
		string text = num2.ToString();
		labelCounterSira.text = text;
		int num3 = ((Dictionary<System.Int32Enum, int>)(object)projects).get_Item((System.Int32Enum)1);
		string text2 = num2.ToString();
		labelCounter50.text = text2;
		int num4 = ((Dictionary<System.Int32Enum, int>)(object)projects).get_Item((System.Int32Enum)2);
		string text3 = num2.ToString();
		labelCounter100.text = text3;
		int num5 = ((Dictionary<System.Int32Enum, int>)(object)projects).get_Item((System.Int32Enum)3);
		string text4 = num2.ToString();
		labelCounter400.text = text4;
	}

	private void OnProjectButtonClick(BalootProject project)
	{
		//IL_0016: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00d5: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0124: Expected O, but got I
		//IL_0130: Expected O, but got I
		//IL_0177: Expected O, but got I4
		//IL_026a: Expected O, but got I
		//IL_0284: Expected O, but got I4
		//IL_0233: Expected O, but got I4
		//IL_019d: Expected I4, but got O
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		//IL_01e8: Expected O, but got I
		//IL_01ff: Expected I4, but got O
		//IL_0443: Expected O, but got I4
		//IL_033d: Expected O, but got I
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_037b: Expected O, but got I
		//IL_03f5: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6791]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6792]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6792]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		Dictionary<System.Int32Enum, int> dictionary = (Dictionary<System.Int32Enum, int>)(object)projects;
		goto IL_00f8;
		IL_029a:
		_ = 1;
		Dictionary<System.Int32Enum, int> dictionary2 = (Dictionary<System.Int32Enum, int>)(object)projects;
		goto IL_02af;
		IL_0412:
		throw new NullReferenceException();
		IL_020d:
		dictionary2 = (Dictionary<System.Int32Enum, int>)(object)projects;
		bool flag2 = projects == null;
		object obj5 = !flag2;
		int num2;
		int num = num2;
		if (obj5 != null)
		{
			goto IL_02af;
		}
		goto IL_0412;
		IL_0066:
		dictionary = (Dictionary<System.Int32Enum, int>)(object)projects;
		bool flag3 = projects == null;
		object obj6 = !flag3;
		if (obj6 != null)
		{
			goto IL_00f8;
		}
		goto IL_0412;
		IL_00f8:
		Dictionary<System.Int32Enum, int>.ValueCollection values = dictionary.Values;
		int num3 = Enumerable.Sum(values);
		object obj7 = (nint)0 + (nint)1680;
		object obj8 = (nint)0 + (nint)1696;
		int num4 = ((Dictionary<System.Int32Enum, int>)(object)projects).get_Item((System.Int32Enum)project);
		num2 = num4 + 1;
		((Dictionary<System.Int32Enum, int>)(object)projects).set_Item((System.Int32Enum)project, num2);
		object obj9 = num3 + 1;
		if ((nint)obj9 <= 2)
		{
			num2 = (int)obj7;
			int num5 = ((Dictionary<System.Int32Enum, int>)(object)projects).get_Item((System.Int32Enum)3);
			if (num5 < 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6792]");
				object obj10 = (nint)0 & (nint)1;
				bool flag4 = obj10 == null;
				num = (int)obj7;
				if (!flag4)
				{
					goto IL_020d;
				}
				goto IL_029a;
			}
		}
		ShowProjectsError();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6792]");
		object obj11 = (nint)0 & (nint)1;
		bool flag5 = obj11 == null;
		object obj12 = !flag5;
		num = num2;
		if (obj12 != null)
		{
			goto IL_020d;
		}
		goto IL_029a;
		IL_02af:
		Dictionary<System.Int32Enum, int>.ValueCollection values2 = dictionary2.Values;
		int newCount = Enumerable.Sum(values2);
		object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v13+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.DeclaredProjects, newCount);
		UpdateLabels();
		BalootGame balootGame = _balootGame;
		List<System.Int32Enum> <ProjectsToDeclare>k__BackingField = (List<System.Int32Enum>)(object)balootGame.<ProjectsToDeclare>k__BackingField;
		object obj16 = (nint)0 + (nint)1488;
		object obj17 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2032;
		object obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X21_v5 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
		object obj19 = (nint)0 + (nint)1;
		_ = 0;
		IEnumerable<BalootProject> collection = GetProjects();
		<ProjectsToDeclare>k__BackingField.AddRange((IEnumerable<System.Int32Enum>)collection);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		ITrackEvent trackEvent = TrackerLibrary.GameProjectClicked(friendlyName);
		object obj20 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v12+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
	}

	private void ShowProjectsError()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00c4: Expected O, but got I
		//IL_00ee: Expected O, but got I4
		//IL_0091: Expected O, but got I4
		gameEventsChannel.TriggerShakeProjectsButton();
		Transform transform = base.transform;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		Vector3 position = transform.position;
		object obj2 = typeof(UsageHint) + 744;
		object message = "ThisIsFakeReceiptData" + 768;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v5+B8]");
		object obj4 = 0;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = default(object);
		float num = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v6+28]");
		float duration = num * 0f;
		Toast.Show((string)message, (Vector2)0, duration);
		ResetProjects();
	}

	private IEnumerable<BalootProject> GetProjects()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0144: Expected O, but got I4
		//IL_00a5: Expected O, but got I
		//IL_00b5: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_0182: Expected O, but got I
		//IL_0192: Expected O, but got I
		//IL_01a2: Expected O, but got I
		//IL_01c4: Expected O, but got I4
		//IL_0204: Expected O, but got I4
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_0272: Expected O, but got I
		//IL_0283: Expected I, but got O
		//IL_02a1: Expected O, but got I
		//IL_0234: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3656;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E673C]");
		object obj3 = (nint)0 & (nint)1;
		Dictionary<BalootProject, int> dictionary2;
		object obj4;
		Dictionary<BalootProject, int> dictionary;
		if (obj3 != null)
		{
			dictionary = projects;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			dictionary2 = projects;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			dictionary = projects;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			dictionary2 = projects;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)232;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
		Func<KeyValuePair<System.Int32Enum, int>, object> func = (Func<KeyValuePair<System.Int32Enum, int>, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		dictionary = dictionary2;
		if (obj9 == null)
		{
			goto IL_01e2;
		}
		goto IL_0239;
		IL_01e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v10+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)2696;
		Func<KeyValuePair<System.Int32Enum, int>, object> func2 = default(Func<KeyValuePair<System.Int32Enum, int>, object>);
		func2..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+B8]");
		object obj16 = (nint)0 + (nint)8;
		obj16 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj7;
		func = func2;
		dictionary = dictionary2;
		goto IL_0239;
		IL_0239:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DDB334");
		IEnumerable<BalootProject> result = default(IEnumerable<BalootProject>);
		return result;
		IL_0099:
		obj10 = (nint)0 + (nint)232;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
		func = (Func<KeyValuePair<System.Int32Enum, int>, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			obj7 = obj10;
			dictionary2 = dictionary;
			goto IL_01e2;
		}
		goto IL_0239;
	}

	private int GetTotalProjects()
	{
		//IL_003a: Expected I4, but got O
		if (projects != null)
		{
			Dictionary<System.Int32Enum, int>.ValueCollection values = ((Dictionary<System.Int32Enum, int>)(object)projects).Values;
			return Enumerable.Sum(values);
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private void SetBadgeCounter(int counter)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.DeclaredProjects, counter);
	}

	private void <Awake>b__12_0()
	{
		OnProjectButtonClick(BalootProject.Sira);
	}

	private void <Awake>b__12_1()
	{
		OnProjectButtonClick(BalootProject.P50);
	}

	private void <Awake>b__12_2()
	{
		OnProjectButtonClick(BalootProject.P100);
	}

	private void <Awake>b__12_3()
	{
		OnProjectButtonClick(BalootProject.P400);
	}
}
