using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

namespace Features.GameReplay;

public class ReplayPlayer : MonoBehaviour
{
	private sealed class <>c__DisplayClass36_0
	{
		public int index;

		internal void <RoundsButtonsOnGameInitialized>b__0()
		{
			OnRoundButtonPressed(index);
		}
	}

	private sealed class <>c__DisplayClass52_0
	{
		public int index;

		public ReplayPlayer <>4__this;

		internal void <AklasButtonsOnGameInitialized>b__0()
		{
			<>4__this.OnAklaButtonPressed(index);
		}
	}

	private sealed class <>c__DisplayClass57_0
	{
		public List<ReplayEvent> replayPlayerEvents;

		internal int <AklasButtonsOnCommentChange>b__0(ReplayEvent commentEvent)
		{
			//IL_002c: Expected I4, but got O
			if (replayPlayerEvents != null)
			{
				return ((List<object>)(object)replayPlayerEvents).IndexOf((object)commentEvent);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private ReplayPlayerColorsScriptableObject _replayPlayerColors;

	private Button _previousButton;

	private Button _playPauseButton;

	private Button _nextButton;

	private Slider _playSlider;

	private TextMeshProUGUI _timeTextMeshProUGUI;

	private const string DefaultAklasText = "- / -";

	private readonly StringBuilder _stringBuilder;

	private TextMeshProUGUI _roundTextMeshProUGUI;

	private Button _speedButton;

	private CanvasGroup _roundsPanelCanvasGroup;

	private DOTweenAnimation _roundsPanelAnimation;

	private DOTweenAnimation _closeRoundsPanelButtonAnimation;

	private Button _closeRoundsPanelButton;

	private Button _roundsPanelButton;

	private bool _roundsPanelOpen;

	private Transform _roundsParent;

	private RoundButton _roundButtonPrefab;

	private readonly List<RoundButton> _roundsButtons;

	private Action _onRoundChange;

	private SpriteToggler _sheraButtonSpriteToggler;

	private Transform _sliderAklaButtonParent;

	private AklaButton _sliderAklaButton;

	private readonly List<AklaButton> _aklasButtons;

	private readonly List<float> _sliderAklasMappedTime;

	private readonly List<int> _commentedAklasIndices;

	private Action _onAklaChange;

	private Button _moreButton;

	private GameObject _moreButtonsParent;

	private Sequence _moreButtonsSequence;

	private bool _moreButtonsOpen;

	private CanvasGroup _blocker;

	private Button _hideCardsButton;

	private Button _commentButton;

	private Button _hidePanelButton;

	private bool _othersCardsHidden;

	private DOTweenAnimation _replayPlayerAnimation;

	private bool _panelHidden;

	private DOTweenAnimation _commentPreviewAnimation;

	private TextMeshProUGUI _commentTextMeshProUGUI;

	private Button _commentViewerButton;

	private DOTweenAnimation _commentInputAnimation;

	private ObjectToggler _addEditObjectToggler;

	private ObjectToggler _backDeleteObjectToggler;

	private InputField _commentInputField;

	private ToggleGroupIndexer _commentDurationToggleGroupIndexer;

	private Button _addCommentButton;

	private Button _backButton;

	private Button _editCommentButton;

	private Button _deleteCommentButton;

	private CommentEvent _currentComment;

	private static Action _onCommentChange;

	private Color _disabledColor;

	private Color _normalColor;

	private Color _highlightedColor;

	private Color _pressedColor;

	private ColorBlock _commentButtonColors;

	private Coroutine _showCommentCoroutine;

	private CardGame _cardGame;

	private bool _initialized;

	private Action _onGameInitialized;

	private Action _onRoundStart;

	private static GameReplayController GameReplayController
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0132: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_01b8: Expected O, but got I4
			//IL_0160: Expected O, but got I
			//IL_017a: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_0102: Expected O, but got I
			//IL_01f0: Expected O, but got I
			//IL_01fd: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v10+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_0188;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v16+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v12+18]");
			return (GameReplayController)0;
			IL_01ce:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v3+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v3+18]");
			return (GameReplayController)0;
			IL_00b0:
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v16+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = obj11;
			if (!flag3)
			{
				goto IL_00e5;
			}
			goto IL_01ce;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj13 = (nint)0 & (nint)1;
			if (obj13 != null)
			{
				goto IL_00b0;
			}
			goto IL_0188;
			IL_0188:
			_ = 1;
			obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v16+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			obj12 = obj11;
			if (obj14 != null)
			{
				goto IL_00e5;
			}
			goto IL_01ce;
		}
	}

	private void SetupPlayPauseButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button playPauseButton = _playPauseButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)2288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(null, (IntPtr)obj2);
		playPauseButton.m_OnClick.AddListener(unityAction);
	}

	private void SetupPreviousButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button previousButton = _previousButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		previousButton.m_OnClick.AddListener(unityAction);
	}

	private void SetupNextButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button nextButton = _nextButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		nextButton.m_OnClick.AddListener(unityAction);
	}

	private void HandleReplayPlayerControlButtons()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I
		//IL_0215: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0070: Expected O, but got I
		//IL_02a3: Expected O, but got I
		//IL_02bd: Expected O, but got I4
		//IL_0265: Expected O, but got I4
		//IL_00f2: Expected O, but got I
		//IL_0353: Expected O, but got I
		//IL_0363: Expected O, but got I
		//IL_030b: Expected O, but got I4
		//IL_03c3: Expected O, but got I
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_0400: Expected O, but got I4
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected I4, but got Unknown
		//IL_0444: Expected O, but got I4
		//IL_0174: Expected O, but got I
		//IL_0184: Expected O, but got I
		//IL_01a6: Expected O, but got I4
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81EA]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		Button button;
		object obj5;
		Button button2;
		if (obj2 != null)
		{
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			button = _previousButton;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			button2 = _previousButton;
			if (!flag)
			{
				goto IL_009f;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			button = _previousButton;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			button2 = _previousButton;
			if (obj7 != null)
			{
				goto IL_009f;
			}
		}
		_ = 1;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v18+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		obj3 = obj5;
		button = button2;
		if (obj9 != null)
		{
			goto IL_00dc;
		}
		goto IL_0283;
		IL_0378:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v3+E8]");
		bool flag4 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v3+E8]");
		bool flag5 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v3+E8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v3+E8]");
		object obj10 = num ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v3+E8]");
		object obj11 = 0 & obj10;
		bool flag6 = (nint)obj11 < 0;
		bool flag7 = flag4 == flag6;
		object obj12 = !flag5;
		bool interactable = (byte)((flag7 & obj12) ? 1 : 0) != 0;
		Selectable selectable;
		selectable.interactable = interactable;
		object obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v6+E4]");
		bool flag8 = (nint)0 == 0;
		object obj14 = !flag8;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isLastAkla = GameReplayManager.IsLastAkla;
		bool interactable2 = (byte)((isLastAkla ? 1u : 0u) ^ 1u) != 0;
		_nextButton.interactable = interactable2;
		return;
		IL_0164:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v28+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v20+18]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v20+18]");
		bool flag9 = (nint)0 == 0;
		object obj17 = !flag9;
		selectable = button;
		if (obj17 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0378;
		IL_0331:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj18 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v12+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v7+18]");
		obj16 = 0;
		obj3 = obj5;
		selectable = button2;
		goto IL_0378;
		IL_009f:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v18+E4]");
		bool flag10 = (nint)0 == 0;
		obj5 = obj3;
		button2 = button;
		if (!flag10)
		{
			goto IL_00dc;
		}
		goto IL_0283;
		IL_0283:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj20 = (nint)0 & (nint)1;
		bool flag11 = obj20 == null;
		object obj21 = !flag11;
		obj3 = obj5;
		button = button2;
		if (obj21 != null)
		{
			goto IL_011f;
		}
		goto IL_02db;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj22 = (nint)0 & (nint)1;
		bool flag12 = obj22 == null;
		obj5 = obj3;
		button2 = button;
		if (!flag12)
		{
			goto IL_011f;
		}
		goto IL_02db;
		IL_02db:
		_ = 1;
		object obj23 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v28+E4]");
		bool flag13 = (nint)0 == 0;
		object obj24 = !flag13;
		obj3 = obj5;
		button = button2;
		object obj25 = obj23;
		if (obj24 != null)
		{
			goto IL_0164;
		}
		goto IL_0331;
		IL_011f:
		obj23 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v28+E4]");
		bool flag14 = (nint)0 == 0;
		obj25 = obj23;
		obj5 = obj3;
		button2 = button;
		if (!flag14)
		{
			goto IL_0164;
		}
		goto IL_0331;
	}

	private static void UpdateSliderValue(Slider playSlider)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0036: Expected O, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_005e: Expected O, but got I4
		//IL_0098: Expected I, but got O
		//IL_00a8: Expected O, but got I
		//IL_00b8: Expected O, but got I
		//IL_008b: Expected F4, but got I4
		float num = ReplayPlayerSliderTime();
		object obj = num & 0x7FFFFFFF;
		bool flag = (nint)obj < 2139095040;
		object obj2 = !flag;
		object obj3 = obj - 2139095040;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			num = 0f;
		}
		nint num2 = (nint)playSlider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3 (Il2CppClass<UnityEngine.UI.Slider>)+428]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3 (Il2CppClass<UnityEngine.UI.Slider>)+430]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v49 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private static float ReplayPlayerSliderTime()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0154: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_01da: Expected O, but got I4
		//IL_0182: Expected O, but got I
		//IL_019c: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_0212: Expected O, but got I
		//IL_0222: Expected O, but got I
		//IL_0244: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_01aa;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v15+18]");
		object obj9 = 0;
		goto IL_010a;
		IL_010a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v13+E8]");
		return ReplayPlayerSliderTime(0);
		IL_01f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v5+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v4+18]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v4+18]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_010a;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj13 = (nint)0 & (nint)1;
		if (obj13 != null)
		{
			goto IL_00b0;
		}
		goto IL_01aa;
		IL_01aa:
		_ = 1;
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		object obj16 = obj14;
		if (obj15 != null)
		{
			goto IL_00e5;
		}
		goto IL_01f0;
		IL_00b0:
		obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+E4]");
		bool flag5 = (nint)0 == 0;
		obj16 = obj14;
		if (!flag5)
		{
			goto IL_00e5;
		}
		goto IL_01f0;
	}

	private static float ReplayPlayerSliderTime(int index)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01b5: Expected O, but got I
		//IL_01cf: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_024b: Expected O, but got I
		//IL_0265: Expected O, but got I4
		//IL_0215: Expected O, but got I4
		//IL_00d6: Expected O, but got I
		//IL_02eb: Expected O, but got I
		//IL_02fb: Expected O, but got I
		//IL_02ab: Expected O, but got I4
		//IL_0310: Expected O, but got I
		//IL_0140: Expected O, but got I
		//IL_0150: Expected O, but got I
		//IL_0172: Expected O, but got I4
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81EB]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		obj3 = obj5;
		if (obj9 != null)
		{
			goto IL_00c0;
		}
		goto IL_022b;
		IL_0300:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v3+F0]");
		object obj10 = 0;
		int num = index - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v4+18]");
		float inputMax = 0f - 1f;
		return FloatExtensions.Map(num, 0f, inputMax, 0f, 1f);
		IL_0130:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v23+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v21+18]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v21+18]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0300;
		IL_02c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v7+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v8+18]");
		obj12 = 0;
		goto IL_0300;
		IL_008b:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		obj5 = obj3;
		if (!flag5)
		{
			goto IL_00c0;
		}
		goto IL_022b;
		IL_022b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj16 = (nint)0 & (nint)1;
		bool flag6 = obj16 == null;
		object obj17 = !flag6;
		obj3 = obj5;
		if (obj17 != null)
		{
			goto IL_00fb;
		}
		goto IL_027b;
		IL_00c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj18 = (nint)0 & (nint)1;
		bool flag7 = obj18 == null;
		obj5 = obj3;
		if (!flag7)
		{
			goto IL_00fb;
		}
		goto IL_027b;
		IL_027b:
		_ = 1;
		object obj19 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v23+E4]");
		bool flag8 = (nint)0 == 0;
		object obj20 = !flag8;
		object obj21 = obj19;
		obj3 = obj5;
		if (obj20 != null)
		{
			goto IL_0130;
		}
		goto IL_02c9;
		IL_00fb:
		obj19 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v23+E4]");
		bool flag9 = (nint)0 == 0;
		obj21 = obj19;
		if (!flag9)
		{
			goto IL_0130;
		}
		goto IL_02c9;
	}

	private void UpdateTimeText()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01bd: Expected O, but got I
		//IL_01d7: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0253: Expected O, but got I
		//IL_026d: Expected O, but got I4
		//IL_021d: Expected O, but got I4
		//IL_00d6: Expected O, but got I
		//IL_02f3: Expected O, but got I
		//IL_0303: Expected O, but got I
		//IL_02b3: Expected O, but got I4
		//IL_0320: Expected O, but got I
		//IL_0148: Expected O, but got I
		//IL_0158: Expected O, but got I
		//IL_017a: Expected O, but got I4
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected O, but got Unknown
		//IL_0360: Expected O, but got I
		//IL_04ab: Expected O, but got I4
		//IL_03b8: Expected O, but got I
		//IL_0531: Expected O, but got I4
		//IL_04d9: Expected O, but got I
		//IL_04f3: Expected O, but got I4
		//IL_041a: Expected O, but got I
		//IL_042a: Expected O, but got I
		//IL_044c: Expected O, but got I4
		//IL_0569: Expected O, but got I
		//IL_0579: Expected O, but got I
		//IL_05b8: Expected O, but got I
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81EC]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v40+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		obj3 = obj5;
		if (obj9 != null)
		{
			goto IL_00c0;
		}
		goto IL_0233;
		IL_03d5:
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v28+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = obj10;
		if (!flag4)
		{
			goto IL_040a;
		}
		goto IL_0547;
		IL_0501:
		_ = 1;
		obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v28+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		obj11 = obj10;
		if (obj12 != null)
		{
			goto IL_040a;
		}
		goto IL_0547;
		IL_03a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj13 = (nint)0 & (nint)1;
		if (obj13 != null)
		{
			goto IL_03d5;
		}
		goto IL_0501;
		IL_008b:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v40+E4]");
		bool flag6 = (nint)0 == 0;
		obj5 = obj3;
		if (!flag6)
		{
			goto IL_00c0;
		}
		goto IL_0233;
		IL_0233:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj14 = (nint)0 & (nint)1;
		bool flag7 = obj14 == null;
		object obj15 = !flag7;
		obj3 = obj5;
		if (obj15 != null)
		{
			goto IL_00fb;
		}
		goto IL_0283;
		IL_00c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj16 = (nint)0 & (nint)1;
		bool flag8 = obj16 == null;
		obj5 = obj3;
		if (!flag8)
		{
			goto IL_00fb;
		}
		goto IL_0283;
		IL_0283:
		_ = 1;
		object obj17 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v23+E4]");
		bool flag9 = (nint)0 == 0;
		object obj18 = !flag9;
		obj3 = obj5;
		object obj19 = obj17;
		if (obj18 != null)
		{
			goto IL_0138;
		}
		goto IL_02d1;
		IL_00fb:
		obj17 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v23+E4]");
		bool flag10 = (nint)0 == 0;
		obj19 = obj17;
		obj5 = obj3;
		if (!flag10)
		{
			goto IL_0138;
		}
		goto IL_02d1;
		IL_02d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj17 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v23+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v33+18]");
		object obj21 = 0;
		obj3 = obj5;
		goto IL_0310;
		IL_0138:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v23+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v46+18]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v46+18]");
		bool flag11 = (nint)0 == 0;
		object obj23 = !flag11;
		if (obj23 != null)
		{
			goto IL_0310;
		}
		goto IL_062c;
		IL_0310:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v3+C0]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj25 = (nint)0 & (nint)1;
			if (obj25 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v23+E4]");
				if ((nint)0 != 0)
				{
					goto IL_03a2;
				}
			}
			else
			{
				_ = 1;
				obj17 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v23+E4]");
				bool flag12 = (nint)0 == 0;
				object obj26 = !flag12;
				if (obj26 != null)
				{
					goto IL_03a2;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj27 = (nint)0 & (nint)1;
			bool flag13 = obj27 == null;
			object obj28 = !flag13;
			if (obj28 != null)
			{
				goto IL_03d5;
			}
			goto IL_0501;
		}
		object obj29 = ", stale={0}" + 136;
		string text = (string)obj29;
		goto IL_061c;
		IL_040a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v28+B8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v25+18]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v25+18]");
		bool flag14 = (nint)0 == 0;
		object obj32 = !flag14;
		if (obj32 != null)
		{
			goto IL_057e;
		}
		goto IL_062c;
		IL_0547:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj33 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v17+B8]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v15+18]");
		obj31 = 0;
		goto IL_057e;
		IL_062c:
		throw new NullReferenceException();
		IL_061c:
		_timeTextMeshProUGUI.SetText(text);
		return;
		IL_057e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v9+C8]");
		int value = (int)((nint)0 + (nint)2);
		StringBuilder stringBuilder = _stringBuilder.Append(value);
		object value2 = (nint)0 + (nint)3680;
		StringBuilder stringBuilder2 = stringBuilder.Append((string)value2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+18]");
		StringBuilder stringBuilder3 = stringBuilder2.Append(0);
		string text2 = _stringBuilder.ToString();
		StringBuilder stringBuilder4 = _stringBuilder.Clear();
		text = text2;
		goto IL_061c;
	}

	private static void UpdateRoundText(TMP_Text roundTextMeshProUGUI)
	{
		//IL_001c: Expected O, but got I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0046: Expected O, but got I
		//IL_01fe: Expected O, but got I4
		//IL_00a6: Expected O, but got I
		//IL_0284: Expected O, but got I4
		//IL_022c: Expected O, but got I
		//IL_0246: Expected O, but got I4
		//IL_0108: Expected O, but got I
		//IL_0118: Expected O, but got I
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_016a: Expected O, but got I4
		//IL_02bc: Expected O, but got I
		//IL_02cc: Expected O, but got I
		//IL_02ee: Expected O, but got I4
		//IL_019d: Expected I8, but got I
		roundTextMeshProUGUI.isRightToLeftText = true;
		object obj = 152993792;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0090;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_0090;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00c3;
		}
		goto IL_0254;
		IL_00f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v27+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v18+18]");
		object obj9 = 0;
		goto IL_011d;
		IL_011d:
		object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object input = "Read object reference Id '{0}' for {1}." + 3592;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v20+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v14+B8]");
		long quantity = (nint)0 + (nint)1;
		string input2 = LocalizationUtil.Localize((string)input, quantity);
		string text = LocalizationUtil.FixArabic(input2);
		roundTextMeshProUGUI.SetText(text);
		return;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v6+18]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v6+18]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_011d;
		IL_0090:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj16 = (nint)0 & (nint)1;
		if (obj16 != null)
		{
			goto IL_00c3;
		}
		goto IL_0254;
		IL_0254:
		_ = 1;
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v27+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		object obj19 = obj17;
		if (obj18 != null)
		{
			goto IL_00f8;
		}
		goto IL_029a;
		IL_00c3:
		obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v27+E4]");
		bool flag6 = (nint)0 == 0;
		obj19 = obj17;
		if (!flag6)
		{
			goto IL_00f8;
		}
		goto IL_029a;
	}

	private void SetupSpeedButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button speedButton = _speedButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)2296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(null, (IntPtr)obj2);
		speedButton.m_OnClick.AddListener(unityAction);
	}

	private void SetupCloseRoundPanelButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button closeRoundsPanelButton = _closeRoundsPanelButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		closeRoundsPanelButton.m_OnClick.AddListener(unityAction);
	}

	private void SetupControlRoundsPanelButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button roundsPanelButton = _roundsPanelButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		roundsPanelButton.m_OnClick.AddListener(unityAction);
	}

	private void ToggleRoundsPanel()
	{
		if (_roundsPanelOpen)
		{
			_roundsPanelOpen = false;
			_roundsPanelAnimation.DOPlayBackwards();
			_closeRoundsPanelButtonAnimation.DOPlayBackwards();
			UIExtensions.Disable(_roundsPanelCanvasGroup);
		}
		else
		{
			_roundsPanelOpen = true;
			_roundsPanelAnimation.DOPlayForward();
			_closeRoundsPanelButtonAnimation.DOPlayForward();
			UIExtensions.Enable(_roundsPanelCanvasGroup);
		}
	}

	private void ShowRoundsPanel()
	{
		_roundsPanelOpen = true;
		_roundsPanelAnimation.DOPlayForward();
		_closeRoundsPanelButtonAnimation.DOPlayForward();
		UIExtensions.Enable(_roundsPanelCanvasGroup);
	}

	private void HideRoundsPanel()
	{
		_roundsPanelOpen = false;
		_roundsPanelAnimation.DOPlayBackwards();
		_closeRoundsPanelButtonAnimation.DOPlayBackwards();
		UIExtensions.Disable(_roundsPanelCanvasGroup);
	}

	private void SetupRoundsButtons()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01eb: Expected I, but got O
		//IL_0093: Expected O, but got I4
		//IL_020f: Expected O, but got I
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_023c: Expected I, but got O
		//IL_0119: Expected O, but got I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_0261: Expected O, but got I
		//IL_0283: Expected O, but got I
		//IL_029b: Expected I, but got O
		//IL_01b6: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)648;
		object obj3 = this + 608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		Delegate obj4 = Delegate.Combine(_onGameInitialized, action);
		if ((object)obj4 != null)
		{
			if (obj4 == obj)
			{
				obj3 = obj4;
				if (obj4 == obj)
				{
					goto IL_0203;
				}
			}
			goto IL_01c1;
		}
		obj3 = 0;
		goto IL_0203;
		IL_0241:
		object obj5 = typeof(RegisteredWaitHandle) + 616;
		object obj6 = (nint)0 + (nint)640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v5+B8]");
		object a = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj6);
		Delegate obj8 = Delegate.Combine((Delegate)a, action2);
		if ((object)obj8 != null)
		{
			if (obj8 == obj)
			{
				object obj9 = obj5;
				object obj10 = obj8;
				if (obj8 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return;
				}
			}
			goto IL_01c1;
		}
		object obj11 = obj5;
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0203:
		object obj13 = (nint)0 + (nint)656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj14 = this + 616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj13);
		Delegate obj15 = Delegate.Combine(_onRoundStart, action3);
		if ((object)obj15 != null)
		{
			if (obj15 == obj)
			{
				obj14 = obj15;
				if (obj15 == obj)
				{
					goto IL_0241;
				}
			}
			goto IL_01c1;
		}
		obj14 = 0;
		goto IL_0241;
		IL_01c1:
		throw new InvalidCastException();
	}

	private void OnDisableRoundsButtons()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01eb: Expected I, but got O
		//IL_0093: Expected O, but got I4
		//IL_020f: Expected O, but got I
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_023c: Expected I, but got O
		//IL_0119: Expected O, but got I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_0261: Expected O, but got I
		//IL_0283: Expected O, but got I
		//IL_029b: Expected I, but got O
		//IL_01b6: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)648;
		object obj3 = this + 608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		Delegate obj4 = Delegate.Remove(_onGameInitialized, action);
		if ((object)obj4 != null)
		{
			if (obj4 == obj)
			{
				obj3 = obj4;
				if (obj4 == obj)
				{
					goto IL_0203;
				}
			}
			goto IL_01c1;
		}
		obj3 = 0;
		goto IL_0203;
		IL_0241:
		object obj5 = typeof(RegisteredWaitHandle) + 616;
		object obj6 = (nint)0 + (nint)640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v5+B8]");
		object source = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj6);
		Delegate obj8 = Delegate.Remove((Delegate)source, action2);
		if ((object)obj8 != null)
		{
			if (obj8 == obj)
			{
				object obj9 = obj5;
				object obj10 = obj8;
				if (obj8 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return;
				}
			}
			goto IL_01c1;
		}
		object obj11 = obj5;
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0203:
		object obj13 = (nint)0 + (nint)656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj14 = this + 616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj13);
		Delegate obj15 = Delegate.Remove(_onRoundStart, action3);
		if ((object)obj15 != null)
		{
			if (obj15 == obj)
			{
				obj14 = obj15;
				if (obj15 == obj)
				{
					goto IL_0241;
				}
			}
			goto IL_01c1;
		}
		obj14 = 0;
		goto IL_0241;
		IL_01c1:
		throw new InvalidCastException();
	}

	private void RoundsButtonsOnGameInitialized()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01bd: Expected O, but got I
		//IL_01d7: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0253: Expected O, but got I
		//IL_026d: Expected O, but got I4
		//IL_021d: Expected O, but got I4
		//IL_00d6: Expected O, but got I
		//IL_02f3: Expected O, but got I
		//IL_0303: Expected O, but got I
		//IL_02b3: Expected O, but got I4
		//IL_0148: Expected O, but got I
		//IL_0158: Expected O, but got I
		//IL_017a: Expected O, but got I4
		//IL_08a0: Expected O, but got I
		//IL_0325: Expected O, but got I
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_03b6: Expected O, but got I4
		//IL_03df: Expected O, but got I
		//IL_044c: Expected O, but got I4
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_04fa: Expected O, but got I
		//IL_050a: Expected O, but got I
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		//IL_0539: Expected O, but got I
		//IL_054a: Expected I, but got O
		//IL_0564: Expected O, but got I
		//IL_057a: Expected O, but got I
		//IL_06b1: Expected O, but got I4
		//IL_05da: Expected O, but got I
		//IL_0737: Expected O, but got I4
		//IL_06df: Expected O, but got I
		//IL_06f9: Expected O, but got I4
		//IL_063c: Expected O, but got I
		//IL_064c: Expected O, but got I
		//IL_066e: Expected O, but got I4
		//IL_0794: Expected O, but got I
		//IL_076f: Expected O, but got I
		//IL_077f: Expected O, but got I
		//IL_07bc: Expected O, but got I
		//IL_07db: Expected O, but got I
		//IL_0821: Expected O, but got I
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81EE]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v63+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		obj3 = obj5;
		if (obj9 != null)
		{
			goto IL_00c0;
		}
		goto IL_0233;
		IL_0889:
		throw new NullReferenceException();
		IL_087c:
		((List<object>)(object)_roundsButtons).Reverse();
		return;
		IL_0890:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X21_v2+98]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v6+98]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v7+18]");
		int num = (int)(-1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v7+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_087c;
		}
		<>c__DisplayClass36_0 <>c__DisplayClass36_ = default(<>c__DisplayClass36_0);
		object obj20 = default(object);
		int num3 = default(int);
		UnityAction unityAction = default(UnityAction);
		while (true)
		{
			object obj12 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 816;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>c__DisplayClass36_..ctor();
			<>c__DisplayClass36_.index = num;
			object obj13 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj16 = (nint)0 + (nint)648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			List<object> roundsButtons = (List<object>)(object)_roundsButtons;
			int version = roundsButtons._version + 1;
			roundsButtons._version = version;
			object[] items = roundsButtons._items;
			bool flag5 = roundsButtons._size < items.Length;
			object obj17 = !flag5;
			if (obj17 == null)
			{
				int size = roundsButtons._size + 1;
				roundsButtons._size = size;
				object obj18 = items + roundsButtons._size;
				object obj19 = obj18 + 32;
				obj19 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				roundsButtons.AddWithResize(obj20);
			}
			int num2 = num + 1;
			string text = num3.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X0_v13 (System.Object)+28]");
			((TMP_Text)0).SetText(text);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X0_v13 (System.Object)+20]");
			object obj21 = 0;
			object obj22 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj23 = (nint)0 + (nint)3920;
			unityAction..ctor(<>c__DisplayClass36_, (IntPtr)obj23);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v24+100]");
			((UnityEvent)0).AddListener(unityAction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj24 = (nint)0 & (nint)1;
			if (obj24 != null)
			{
				object obj25 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v38+E4]");
				if ((nint)0 != 0)
				{
					goto IL_05c4;
				}
			}
			else
			{
				_ = 1;
				object obj25 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v38+E4]");
				bool flag6 = (nint)0 == 0;
				object obj26 = !flag6;
				if (obj26 != null)
				{
					goto IL_05c4;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj27 = (nint)0 & (nint)1;
			bool flag7 = obj27 == null;
			object obj28 = !flag7;
			if (obj28 != null)
			{
				goto IL_05f7;
			}
			goto IL_0707;
			IL_074d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj29 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v33+B8]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v33+18]");
			object obj31 = 0;
			goto IL_0784;
			IL_0784:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v30+98]");
			object obj32 = 0;
			int num4 = num2 - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v31+98]");
			object obj33 = ((List<object>)0).get_Item(num4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v24 (System.Object)+10]");
			ReplayEvent firstReplayEvent = EventsExtensions.GetFirstReplayEvent((List<ReplayEvent>)0, ReplayEventsTypes.Comment);
			bool flag8 = firstReplayEvent == null;
			bool commentState = !flag8;
			((RoundButton)obj20).SetCommentState(commentState);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v24 (System.Object)+10]");
			ReplayEvent firstReplayEvent2 = EventsExtensions.GetFirstReplayEvent((List<ReplayEvent>)0, ReplayEventsTypes.PlayCard);
			bool flag9 = firstReplayEvent2 == null;
			bool sheraState = !flag9;
			((RoundButton)obj20).SetSheraState(sheraState);
			num = num4 - 1;
			if (num4 > 0)
			{
				continue;
			}
			goto IL_087c;
			IL_05f7:
			object obj34 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v43+E4]");
			bool flag10 = (nint)0 == 0;
			object obj35 = obj34;
			if (!flag10)
			{
				goto IL_062c;
			}
			goto IL_074d;
			IL_0707:
			_ = 1;
			obj34 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v43+E4]");
			bool flag11 = (nint)0 == 0;
			object obj36 = !flag11;
			obj35 = obj34;
			if (obj36 != null)
			{
				goto IL_062c;
			}
			goto IL_074d;
			IL_05c4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj37 = (nint)0 & (nint)1;
			if (obj37 != null)
			{
				goto IL_05f7;
			}
			goto IL_0707;
			IL_062c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v43+B8]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v43+18]");
			obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v43+18]");
			bool flag12 = (nint)0 == 0;
			object obj39 = !flag12;
			if (obj39 == null)
			{
				break;
			}
			goto IL_0784;
		}
		goto IL_0889;
		IL_008b:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v63+E4]");
		bool flag13 = (nint)0 == 0;
		obj5 = obj3;
		if (!flag13)
		{
			goto IL_00c0;
		}
		goto IL_0233;
		IL_0233:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj40 = (nint)0 & (nint)1;
		bool flag14 = obj40 == null;
		object obj41 = !flag14;
		obj3 = obj5;
		if (obj41 != null)
		{
			goto IL_00fb;
		}
		goto IL_0283;
		IL_00c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj42 = (nint)0 & (nint)1;
		bool flag15 = obj42 == null;
		obj5 = obj3;
		if (!flag15)
		{
			goto IL_00fb;
		}
		goto IL_0283;
		IL_0283:
		_ = 1;
		object obj43 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v94+E4]");
		bool flag16 = (nint)0 == 0;
		object obj44 = !flag16;
		obj3 = obj5;
		object obj45 = obj43;
		if (obj44 != null)
		{
			goto IL_0138;
		}
		goto IL_02d1;
		IL_00fb:
		obj43 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v94+E4]");
		bool flag17 = (nint)0 == 0;
		obj45 = obj43;
		obj5 = obj3;
		if (!flag17)
		{
			goto IL_0138;
		}
		goto IL_02d1;
		IL_02d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj46 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v57+B8]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v55+18]");
		object obj48 = 0;
		obj3 = obj5;
		goto IL_0890;
		IL_0138:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v94+B8]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v67+18]");
		obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v67+18]");
		bool flag18 = (nint)0 == 0;
		object obj50 = !flag18;
		if (obj50 == null)
		{
			goto IL_0889;
		}
		goto IL_0890;
	}

	private static void OnRoundButtonPressed(int index)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_013f: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01c5: Expected O, but got I4
		//IL_016d: Expected O, but got I
		//IL_0187: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00fc: Expected O, but got I
		//IL_01fd: Expected O, but got I
		//IL_020d: Expected O, but got I
		//IL_022f: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_0195;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v19+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v14+18]");
		GameReplayController gameReplayController = (GameReplayController)0;
		goto IL_0101;
		IL_0101:
		gameReplayController.GoToRound(index);
		return;
		IL_01db:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v5+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v4+18]");
		gameReplayController = (GameReplayController)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v4+18]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0101;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj11 = (nint)0 & (nint)1;
		if (obj11 != null)
		{
			goto IL_00a7;
		}
		goto IL_0195;
		IL_0195:
		_ = 1;
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		object obj14 = obj12;
		if (obj13 != null)
		{
			goto IL_00dc;
		}
		goto IL_01db;
		IL_00a7:
		obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v19+E4]");
		bool flag5 = (nint)0 == 0;
		obj14 = obj12;
		if (!flag5)
		{
			goto IL_00dc;
		}
		goto IL_01db;
	}

	private void RoundsButtonsOnRoundStart()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01b5: Expected O, but got I
		//IL_01cf: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_024b: Expected O, but got I
		//IL_0265: Expected O, but got I4
		//IL_0215: Expected O, but got I4
		//IL_00d6: Expected O, but got I
		//IL_02eb: Expected O, but got I
		//IL_02fb: Expected O, but got I
		//IL_02ab: Expected O, but got I4
		//IL_0140: Expected O, but got I
		//IL_0150: Expected O, but got I
		//IL_0172: Expected O, but got I4
		//IL_0349: Expected O, but got I
		//IL_0399: Expected O, but got I4
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81EF]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v17+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		obj3 = obj5;
		if (obj9 != null)
		{
			goto IL_00c0;
		}
		goto IL_022b;
		IL_03a7:
		throw new NullReferenceException();
		IL_0300:
		List<object> roundsButtons = (List<object>)(object)_roundsButtons;
		int num = 0;
		object obj12;
		do
		{
			if (num < roundsButtons._size)
			{
				object obj10 = roundsButtons.get_Item(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v4+B8]");
				object obj11 = -num;
				bool currentState = obj11 == null;
				((RoundButton)obj10).SetCurrentState(currentState);
				num++;
				roundsButtons = (List<object>)(object)_roundsButtons;
				bool flag4 = _roundsButtons == null;
				obj12 = !flag4;
				continue;
			}
			return;
		}
		while (obj12 != null);
		goto IL_03a7;
		IL_0130:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v30+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v21+18]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v21+18]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 != null)
		{
			goto IL_0300;
		}
		goto IL_03a7;
		IL_008b:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v17+E4]");
		bool flag6 = (nint)0 == 0;
		obj5 = obj3;
		if (!flag6)
		{
			goto IL_00c0;
		}
		goto IL_022b;
		IL_022b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj16 = (nint)0 & (nint)1;
		bool flag7 = obj16 == null;
		object obj17 = !flag7;
		obj3 = obj5;
		if (obj17 != null)
		{
			goto IL_00fb;
		}
		goto IL_027b;
		IL_00c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj18 = (nint)0 & (nint)1;
		bool flag8 = obj18 == null;
		obj5 = obj3;
		if (!flag8)
		{
			goto IL_00fb;
		}
		goto IL_027b;
		IL_027b:
		_ = 1;
		object obj19 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v30+E4]");
		bool flag9 = (nint)0 == 0;
		object obj20 = !flag9;
		object obj21 = obj19;
		obj3 = obj5;
		if (obj20 != null)
		{
			goto IL_0130;
		}
		goto IL_02c9;
		IL_00fb:
		obj19 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v30+E4]");
		bool flag10 = (nint)0 == 0;
		obj21 = obj19;
		if (!flag10)
		{
			goto IL_0130;
		}
		goto IL_02c9;
		IL_02c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj22 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v11+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v8+18]");
		obj14 = 0;
		goto IL_0300;
	}

	private void RoundsButtonsOnCommentChange()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01bd: Expected O, but got I
		//IL_01d7: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0253: Expected O, but got I
		//IL_026d: Expected O, but got I4
		//IL_021d: Expected O, but got I4
		//IL_00d6: Expected O, but got I
		//IL_02f3: Expected O, but got I
		//IL_0303: Expected O, but got I
		//IL_02b3: Expected O, but got I4
		//IL_0326: Expected O, but got I
		//IL_0148: Expected O, but got I
		//IL_0158: Expected O, but got I
		//IL_017a: Expected O, but got I4
		//IL_0455: Expected O, but got I4
		//IL_037e: Expected O, but got I
		//IL_04db: Expected O, but got I4
		//IL_0483: Expected O, but got I
		//IL_049d: Expected O, but got I4
		//IL_03e0: Expected O, but got I
		//IL_03f0: Expected O, but got I
		//IL_0412: Expected O, but got I4
		//IL_0538: Expected O, but got I
		//IL_0513: Expected O, but got I
		//IL_0523: Expected O, but got I
		//IL_055b: Expected O, but got I
		//IL_057a: Expected O, but got I
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F0]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v36+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		obj3 = obj5;
		if (obj9 != null)
		{
			goto IL_00c0;
		}
		goto IL_0233;
		IL_04f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v13+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v12+18]");
		object obj12 = 0;
		goto IL_0528;
		IL_039b:
		object obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v24+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = obj13;
		if (!flag4)
		{
			goto IL_03d0;
		}
		goto IL_04f1;
		IL_04ab:
		_ = 1;
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v24+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		obj14 = obj13;
		if (obj15 != null)
		{
			goto IL_03d0;
		}
		goto IL_04f1;
		IL_008b:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v36+E4]");
		bool flag6 = (nint)0 == 0;
		obj5 = obj3;
		if (!flag6)
		{
			goto IL_00c0;
		}
		goto IL_0233;
		IL_0233:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj16 = (nint)0 & (nint)1;
		bool flag7 = obj16 == null;
		object obj17 = !flag7;
		obj3 = obj5;
		if (obj17 != null)
		{
			goto IL_00fb;
		}
		goto IL_0283;
		IL_00c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj18 = (nint)0 & (nint)1;
		bool flag8 = obj18 == null;
		obj5 = obj3;
		if (!flag8)
		{
			goto IL_00fb;
		}
		goto IL_0283;
		IL_0283:
		_ = 1;
		object obj19 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v19+E4]");
		bool flag9 = (nint)0 == 0;
		object obj20 = !flag9;
		obj3 = obj5;
		object obj21 = obj19;
		if (obj20 != null)
		{
			goto IL_0138;
		}
		goto IL_02d1;
		IL_00fb:
		obj19 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v19+E4]");
		bool flag10 = (nint)0 == 0;
		obj21 = obj19;
		obj5 = obj3;
		if (!flag10)
		{
			goto IL_0138;
		}
		goto IL_02d1;
		IL_02d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj19 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v19+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v30+18]");
		object obj23 = 0;
		obj3 = obj5;
		goto IL_0310;
		IL_0138:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v19+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v43+18]");
		obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v43+18]");
		bool flag11 = (nint)0 == 0;
		object obj25 = !flag11;
		if (obj25 != null)
		{
			goto IL_0310;
		}
		goto IL_05cc;
		IL_0310:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
		object obj26 = (nint)0 & (nint)1;
		if (obj26 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v19+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0368;
			}
		}
		else
		{
			_ = 1;
			obj19 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v19+E4]");
			bool flag12 = (nint)0 == 0;
			object obj27 = !flag12;
			if (obj27 != null)
			{
				goto IL_0368;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj28 = (nint)0 & (nint)1;
		bool flag13 = obj28 == null;
		object obj29 = !flag13;
		if (obj29 != null)
		{
			goto IL_039b;
		}
		goto IL_04ab;
		IL_05cc:
		throw new NullReferenceException();
		IL_0528:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v5+98]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v6+98]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v3+B8]");
		object obj31 = ((List<object>)num).get_Item(0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v6 (System.Object)+10]");
		ReplayEvent firstReplayEvent = EventsExtensions.GetFirstReplayEvent((List<ReplayEvent>)0, ReplayEventsTypes.Comment);
		List<RoundButton> roundsButtons = _roundsButtons;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v3+B8]");
		object obj32 = ((List<object>)(object)roundsButtons).get_Item(0);
		bool flag14 = firstReplayEvent == null;
		bool commentState = !flag14;
		((RoundButton)obj32).SetCommentState(commentState);
		return;
		IL_03d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v24+B8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v22+18]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v22+18]");
		bool flag15 = (nint)0 == 0;
		object obj34 = !flag15;
		if (obj34 != null)
		{
			goto IL_0528;
		}
		goto IL_05cc;
		IL_0368:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj35 = (nint)0 & (nint)1;
		if (obj35 != null)
		{
			goto IL_039b;
		}
		goto IL_04ab;
	}

	private void SetupSheraButton()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_02ad: Expected I, but got O
		//IL_0093: Expected O, but got I4
		//IL_02d1: Expected O, but got I
		//IL_02f3: Expected I, but got O
		//IL_0119: Expected O, but got I4
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_032e: Expected O, but got I
		//IL_0346: Expected I, but got O
		//IL_01ee: Expected O, but got I4
		//IL_0213: Expected O, but got I
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0242: Expected O, but got I
		//IL_025a: Expected I, but got O
		//IL_0274: Expected O, but got I
		//IL_01ca: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)672;
		object obj3 = this + 616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		Delegate obj4 = Delegate.Combine(_onRoundStart, action);
		if ((object)obj4 != null)
		{
			if (obj4 == obj)
			{
				obj3 = obj4;
				if (obj4 == obj)
				{
					goto IL_02c5;
				}
			}
			goto IL_0275;
		}
		obj3 = 0;
		goto IL_02c5;
		IL_0275:
		InvalidCastException ex = new InvalidCastException();
		goto IL_0283;
		IL_0207:
		object obj5 = (nint)0 + (nint)3640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj7 = (nint)0 + (nint)632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(null, (IntPtr)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v19+100]");
		((UnityEvent)0).AddListener(unityAction);
		return;
		IL_02f8:
		object obj8 = typeof(RegisteredWaitHandle) + 616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v5+B8]");
		object a = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		object obj10;
		action2..ctor(this, (IntPtr)obj10);
		Delegate obj11 = Delegate.Combine((Delegate)a, action2);
		SpriteToggler sheraButtonSpriteToggler;
		if ((object)obj11 != null)
		{
			if (obj11 == obj)
			{
				object obj12 = obj8;
				object obj13 = obj11;
				if (obj11 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					sheraButtonSpriteToggler = _sheraButtonSpriteToggler;
					bool flag = (object)_sheraButtonSpriteToggler == null;
					object obj14 = !flag;
					if (obj14 != null)
					{
						goto IL_0207;
					}
					goto IL_0283;
				}
			}
			goto IL_0275;
		}
		object obj15 = obj8;
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		sheraButtonSpriteToggler = _sheraButtonSpriteToggler;
		goto IL_0207;
		IL_02c5:
		obj10 = (nint)0 + (nint)664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj10);
		Delegate obj17 = Delegate.Combine(_onRoundStart, action3);
		if ((object)obj17 != null)
		{
			if (obj17 == obj)
			{
				obj3 = obj17;
				if (obj17 == obj)
				{
					goto IL_02f8;
				}
			}
			goto IL_0275;
		}
		obj3 = 0;
		goto IL_02f8;
		IL_0283:
		throw new NullReferenceException();
	}

	private void OnDisableSheraButton()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01eb: Expected I, but got O
		//IL_0093: Expected O, but got I4
		//IL_020f: Expected O, but got I
		//IL_0231: Expected I, but got O
		//IL_0119: Expected O, but got I4
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_026c: Expected O, but got I
		//IL_0284: Expected I, but got O
		//IL_01b6: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)672;
		object obj3 = this + 616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		Delegate obj4 = Delegate.Remove(_onRoundStart, action);
		if ((object)obj4 != null)
		{
			if (obj4 == obj)
			{
				obj3 = obj4;
				if (obj4 == obj)
				{
					goto IL_0203;
				}
			}
			goto IL_01c1;
		}
		obj3 = 0;
		goto IL_0203;
		IL_0236:
		object obj5 = typeof(RegisteredWaitHandle) + 616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v5+B8]");
		object source = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		object obj7;
		action2..ctor(this, (IntPtr)obj7);
		Delegate obj8 = Delegate.Remove((Delegate)source, action2);
		if ((object)obj8 != null)
		{
			if (obj8 == obj)
			{
				object obj9 = obj5;
				object obj10 = obj8;
				if (obj8 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return;
				}
			}
			goto IL_01c1;
		}
		object obj11 = obj5;
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0203:
		obj7 = (nint)0 + (nint)664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj7);
		Delegate obj13 = Delegate.Remove(_onRoundStart, action3);
		if ((object)obj13 != null)
		{
			if (obj13 == obj)
			{
				obj3 = obj13;
				if (obj13 == obj)
				{
					goto IL_0236;
				}
			}
			goto IL_01c1;
		}
		obj3 = 0;
		goto IL_0236;
		IL_01c1:
		throw new InvalidCastException();
	}

	private static void OnSheraButtonPressed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0269: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_02ef: Expected O, but got I4
		//IL_0297: Expected O, but got I
		//IL_02b1: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00fc: Expected O, but got I
		//IL_0112: Expected O, but got I
		//IL_0131: Expected O, but got I
		//IL_03b5: Expected O, but got I4
		//IL_0327: Expected O, but got I
		//IL_0337: Expected O, but got I
		//IL_034d: Expected O, but got I
		//IL_0367: Expected O, but got I4
		//IL_0377: Expected O, but got I
		//IL_0182: Expected O, but got I
		//IL_044b: Expected O, but got I4
		//IL_03eb: Expected O, but got I
		//IL_0405: Expected O, but got I4
		//IL_01f4: Expected O, but got I
		//IL_0204: Expected O, but got I
		//IL_0226: Expected O, but got I4
		//IL_048b: Expected O, but got I
		//IL_049b: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v27+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v27+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_02bf;
		IL_04a8:
		GameReplayController gameReplayController2;
		GameReplayController gameReplayController = gameReplayController2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v3+B8]");
		gameReplayController.GoToRound(0);
		return;
		IL_01e4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v33+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v26+18]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v26+18]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_04a8;
		IL_0469:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v7+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v5+18]");
		obj8 = 0;
		GameReplayController gameReplayController3;
		gameReplayController2 = gameReplayController3;
		goto IL_04a8;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj12 = (nint)0 & (nint)1;
		if (obj12 != null)
		{
			goto IL_00a7;
		}
		goto IL_02bf;
		IL_02bf:
		_ = 1;
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		object obj15 = obj13;
		if (obj14 != null)
		{
			goto IL_00dc;
		}
		goto IL_0305;
		IL_00a7:
		obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		obj15 = obj13;
		if (!flag5)
		{
			goto IL_00dc;
		}
		goto IL_0305;
		IL_0305:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v13+B8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v16+18]");
		gameReplayController2 = (GameReplayController)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
		object obj17 = (nint)0 & (nint)1;
		bool flag6 = obj17 == null;
		object obj18 = !flag6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v16+18]");
		gameReplayController3 = (GameReplayController)0;
		if (obj18 != null)
		{
			goto IL_013f;
		}
		goto IL_0385;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v13+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v35+18]");
		gameReplayController2 = (GameReplayController)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
		object obj20 = (nint)0 & (nint)1;
		bool flag7 = obj20 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v35+18]");
		gameReplayController3 = (GameReplayController)0;
		if (!flag7)
		{
			goto IL_013f;
		}
		goto IL_0385;
		IL_0385:
		_ = 1;
		obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v13+E4]");
		bool flag8 = (nint)0 == 0;
		object obj21 = !flag8;
		gameReplayController2 = gameReplayController3;
		if (obj21 != null)
		{
			goto IL_016c;
		}
		goto IL_03cb;
		IL_013f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v13+E4]");
		bool flag9 = (nint)0 == 0;
		gameReplayController3 = gameReplayController2;
		if (!flag9)
		{
			goto IL_016c;
		}
		goto IL_03cb;
		IL_03cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj22 = (nint)0 & (nint)1;
		bool flag10 = obj22 == null;
		object obj23 = !flag10;
		gameReplayController2 = gameReplayController3;
		if (obj23 != null)
		{
			goto IL_01a7;
		}
		goto IL_041b;
		IL_016c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj24 = (nint)0 & (nint)1;
		bool flag11 = obj24 == null;
		gameReplayController3 = gameReplayController2;
		if (!flag11)
		{
			goto IL_01a7;
		}
		goto IL_041b;
		IL_041b:
		_ = 1;
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v33+E4]");
		bool flag12 = (nint)0 == 0;
		object obj26 = !flag12;
		gameReplayController2 = gameReplayController3;
		object obj27 = obj25;
		if (obj26 != null)
		{
			goto IL_01e4;
		}
		goto IL_0469;
		IL_01a7:
		obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v33+E4]");
		bool flag13 = (nint)0 == 0;
		gameReplayController3 = gameReplayController2;
		obj27 = obj25;
		if (!flag13)
		{
			goto IL_01e4;
		}
		goto IL_0469;
	}

	private void SheraButtonOnRoundStart()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0161: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01e7: Expected O, but got I4
		//IL_018f: Expected O, but got I
		//IL_01a9: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00fc: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_021f: Expected O, but got I
		//IL_022f: Expected O, but got I
		//IL_0373: Expected O, but got I
		//IL_0249: Expected O, but got I
		//IL_0277: Expected O, but got I
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected I4, but got Unknown
		//IL_02e5: Expected O, but got I4
		//IL_0334: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v24+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v24+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_01b7;
		IL_0363:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X20_v4+98]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v6+98]");
		List<object> list = (List<object>)0;
		int num = list._size - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X20_v4+B8]");
		object obj8 = -num;
		bool flag3 = (nint)obj8 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X20_v4+B8]");
		int num2 = (int)((nint)0 ^ (nint)num);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X20_v4+B8]");
		int num3 = 0 ^ obj8;
		int num4 = num2 & num3;
		bool flag4 = num4 < 0;
		bool flag5 = flag3 == flag4;
		object obj9 = !flag5;
		object obj10 = ~obj9;
		int index;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X20_v4+B8]");
			index = 0;
		}
		else
		{
			index = num;
		}
		object obj11 = list.get_Item(index);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v6 (System.Object)+10]");
		ReplayEvent firstReplayEvent = EventsExtensions.GetFirstReplayEvent((List<ReplayEvent>)0, ReplayEventsTypes.PlayCard);
		bool isON = firstReplayEvent == null;
		_sheraButtonSpriteToggler.ToggleManual(isON);
		return;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v30+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v21+18]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v21+18]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 != null)
		{
			goto IL_0363;
		}
		throw new NullReferenceException();
		IL_01fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v18+B8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v12+18]");
		obj13 = 0;
		goto IL_0363;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj17 = (nint)0 & (nint)1;
		if (obj17 != null)
		{
			goto IL_00a7;
		}
		goto IL_01b7;
		IL_01b7:
		_ = 1;
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v30+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		object obj20 = obj18;
		if (obj19 != null)
		{
			goto IL_00dc;
		}
		goto IL_01fd;
		IL_00a7:
		obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v30+E4]");
		bool flag8 = (nint)0 == 0;
		obj20 = obj18;
		if (!flag8)
		{
			goto IL_00dc;
		}
		goto IL_01fd;
	}

	private void SheraButtonOnCommentChanged()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01d7: Expected O, but got I
		//IL_01f1: Expected O, but got I4
		//IL_01fa: Expected O, but got I4
		//IL_020b: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_007e: Expected O, but got I4
		//IL_008f: Expected O, but got I4
		//IL_0287: Expected O, but got I
		//IL_02a1: Expected O, but got I4
		//IL_0249: Expected O, but got I4
		//IL_00f0: Expected O, but got I
		//IL_032f: Expected O, but got I
		//IL_033f: Expected O, but got I
		//IL_02ef: Expected O, but got I4
		//IL_0162: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_0fae: Expected O, but got I
		//IL_0361: Expected O, but got I
		//IL_0372: Expected O, but got I
		//IL_039a: Expected O, but got I
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected I4, but got Unknown
		//IL_0408: Expected O, but got I4
		//IL_0457: Expected O, but got I
		//IL_05a1: Expected O, but got I
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected O, but got Unknown
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected O, but got Unknown
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected O, but got Unknown
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected O, but got Unknown
		//IL_048e: Expected O, but got I
		//IL_1001: Expected O, but got I
		//IL_1011: Expected O, but got I
		//IL_0625: Expected O, but got I4
		//IL_102b: Expected O, but got I
		//IL_04ee: Expected O, but got I
		//IL_070d: Expected O, but got I
		//IL_06ab: Expected O, but got I4
		//IL_0653: Expected O, but got I
		//IL_066d: Expected O, but got I4
		//IL_073a: Expected O, but got I
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected I4, but got Unknown
		//IL_07a8: Expected O, but got I4
		//IL_0550: Expected O, but got I
		//IL_0560: Expected O, but got I
		//IL_0582: Expected O, but got I4
		//IL_06e3: Expected O, but got I
		//IL_06f3: Expected O, but got I
		//IL_07f7: Expected O, but got I
		//IL_0941: Expected O, but got I
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Expected O, but got Unknown
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Expected O, but got Unknown
		//IL_097b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0980: Expected O, but got Unknown
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0990: Expected O, but got Unknown
		//IL_082e: Expected O, but got I
		//IL_09c5: Expected O, but got I4
		//IL_088e: Expected O, but got I
		//IL_0a4b: Expected O, but got I4
		//IL_09f3: Expected O, but got I
		//IL_0a0d: Expected O, but got I4
		//IL_08f0: Expected O, but got I
		//IL_0900: Expected O, but got I
		//IL_0922: Expected O, but got I4
		//IL_0a83: Expected O, but got I
		//IL_0a93: Expected O, but got I
		//IL_1056: Expected O, but got I
		//IL_0aad: Expected O, but got I
		//IL_0ada: Expected O, but got I
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Expected I4, but got Unknown
		//IL_0b48: Expected O, but got I4
		//IL_0b8d: Expected O, but got I
		//IL_0ba2: Expected O, but got I
		//IL_0bbc: Expected O, but got I
		//IL_0cf4: Expected O, but got I4
		//IL_0c1c: Expected O, but got I
		//IL_0d7a: Expected O, but got I4
		//IL_0d22: Expected O, but got I
		//IL_0d3c: Expected O, but got I4
		//IL_0c7e: Expected O, but got I
		//IL_0c8e: Expected O, but got I
		//IL_0cb0: Expected O, but got I4
		//IL_0db2: Expected O, but got I
		//IL_0dc2: Expected O, but got I
		//IL_1081: Expected O, but got I
		//IL_0ddd: Expected O, but got I
		//IL_0e0a: Expected O, but got I
		//IL_0e3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e43: Expected I4, but got Unknown
		//IL_0e78: Expected O, but got I4
		//IL_0ec6: Expected O, but got I
		//IL_0edb: Expected O, but got I
		//IL_0f36: Expected O, but got I4
		//IL_0f3f: Expected O, but got I4
		//IL_0f48: Expected O, but got I4
		//IL_0f51: Expected O, but got I4
		//IL_0f0d: Expected O, but got I4
		//IL_0f16: Expected O, but got I4
		//IL_0f1f: Expected O, but got I4
		//IL_0f28: Expected O, but got I4
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F1]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj6;
		object obj7;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = 152993792;
			obj6 = obj3;
			obj7 = 152993792;
			if (!flag)
			{
				goto IL_009d;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj8 = (nint)0 & (nint)1;
			bool flag2 = obj8 == null;
			object obj9 = !flag2;
			obj5 = 152993792;
			obj6 = obj3;
			obj7 = 152993792;
			if (obj9 != null)
			{
				goto IL_009d;
			}
		}
		_ = 1;
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v131+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		obj3 = obj6;
		obj5 = obj7;
		if (obj11 != null)
		{
			goto IL_00da;
		}
		goto IL_0267;
		IL_0d4a:
		_ = 1;
		object obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v59+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		object obj14 = obj12;
		if (obj13 != null)
		{
			goto IL_0c6e;
		}
		goto IL_0d90;
		IL_0f97:
		throw new NullReferenceException();
		IL_0fc9:
		object obj16;
		object obj15 = obj16;
		object obj18;
		object obj17 = obj18;
		object obj20;
		object obj19 = obj20;
		object obj22;
		object obj21 = obj22;
		object obj24 = default(object);
		object obj23 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v9+2A8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v9+2B0]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v424 @ X2_v4 (should have been resolved before IL gen)");
		goto IL_101b;
		IL_009d:
		obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v131+E4]");
		bool flag5 = (nint)0 == 0;
		obj6 = obj3;
		obj7 = obj5;
		if (!flag5)
		{
			goto IL_00da;
		}
		goto IL_0267;
		IL_0267:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj27 = (nint)0 & (nint)1;
		bool flag6 = obj27 == null;
		object obj28 = !flag6;
		obj3 = obj6;
		obj5 = obj7;
		if (obj28 != null)
		{
			goto IL_0115;
		}
		goto IL_02bf;
		IL_00da:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj29 = (nint)0 & (nint)1;
		bool flag7 = obj29 == null;
		obj6 = obj3;
		if (!flag7)
		{
			goto IL_0115;
		}
		goto IL_02bf;
		IL_02bf:
		_ = 1;
		object obj30 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v141+E4]");
		bool flag8 = (nint)0 == 0;
		object obj31 = !flag8;
		obj3 = obj6;
		object obj32 = obj30;
		if (obj31 != null)
		{
			goto IL_0152;
		}
		goto IL_030d;
		IL_0115:
		obj30 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v141+E4]");
		bool flag9 = (nint)0 == 0;
		obj32 = obj30;
		obj6 = obj3;
		if (!flag9)
		{
			goto IL_0152;
		}
		goto IL_030d;
		IL_030d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj33 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v125+B8]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v99+18]");
		object obj35 = 0;
		obj3 = obj6;
		goto IL_0f9e;
		IL_0152:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v141+B8]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v111+18]");
		obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v111+18]");
		bool flag10 = (nint)0 == 0;
		object obj37 = !flag10;
		if (obj37 == null)
		{
			goto IL_0f97;
		}
		goto IL_0f9e;
		IL_0f9e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X20_v3+98]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v6+98]");
		List<object> list = (List<object>)0;
		object obj39 = (nint)0 + (nint)232;
		int num = list._size - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X20_v3+B8]");
		object obj40 = -num;
		bool flag11 = (nint)obj40 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X20_v3+B8]");
		int num2 = (int)((nint)0 ^ (nint)num);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X20_v3+B8]");
		int num3 = 0 ^ obj40;
		int num4 = num2 & num3;
		bool flag12 = num4 < 0;
		bool flag13 = flag11 == flag12;
		object obj41 = !flag13;
		object obj42 = ~obj41;
		int index;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X20_v3+B8]");
			index = 0;
		}
		else
		{
			index = num;
		}
		object obj43 = list.get_Item(index);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v6 (System.Object)+10]");
		ReplayEvent firstReplayEvent = EventsExtensions.GetFirstReplayEvent((List<ReplayEvent>)0, ReplayEventsTypes.Comment);
		if (firstReplayEvent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj44 = (nint)0 & (nint)1;
			if (obj44 != null)
			{
				object obj45 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v106+E4]");
				if ((nint)0 != 0)
				{
					goto IL_04d8;
				}
			}
			else
			{
				_ = 1;
				object obj45 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v106+E4]");
				bool flag14 = (nint)0 == 0;
				object obj46 = !flag14;
				if (obj46 != null)
				{
					goto IL_04d8;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj47 = (nint)0 & (nint)1;
			bool flag15 = obj47 == null;
			object obj48 = !flag15;
			if (obj48 != null)
			{
				goto IL_050b;
			}
			goto IL_067b;
		}
		object obj49 = (nint)0 + (nint)3872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		obj16 = _replayPlayerColors + 52;
		obj18 = _replayPlayerColors + 48;
		obj20 = _replayPlayerColors + 44;
		obj22 = _replayPlayerColors + 40;
		goto IL_0fc9;
		IL_0878:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj50 = (nint)0 & (nint)1;
		if (obj50 != null)
		{
			goto IL_08ab;
		}
		goto IL_0a1b;
		IL_1071:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X22_v8+98]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v36+98]");
		List<object> list2 = (List<object>)0;
		int num5 = list2._size - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X22_v8+B8]");
		object obj52 = -num5;
		bool flag16 = (nint)obj52 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X22_v8+B8]");
		int num6 = (int)((nint)0 ^ (nint)num5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X22_v8+B8]");
		int num7 = 0 ^ obj52;
		int num8 = num6 & num7;
		bool flag17 = num8 < 0;
		bool flag18 = flag16 == flag17;
		object obj53 = !flag18;
		object obj54 = ~obj53;
		int index2;
		if (obj54 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X22_v8+B8]");
			index2 = 0;
		}
		else
		{
			index2 = num5;
		}
		object obj55 = list2.get_Item(index2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X0_v30 (System.Object)+10]");
		ReplayEvent firstReplayEvent2;
		int num9 = ((List<object>)0).IndexOf(firstReplayEvent2);
		object obj56 = (nint)0 + (nint)3872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		int num10;
		object obj57;
		object obj58;
		object obj59;
		object obj60;
		if (num10 < num9)
		{
			obj57 = 56;
			obj58 = 60;
			obj59 = 64;
			obj60 = 68;
		}
		else
		{
			obj57 = 40;
			obj58 = 44;
			obj59 = 48;
			obj60 = 52;
		}
		obj16 = (object)_replayPlayerColors + obj60;
		obj18 = (object)_replayPlayerColors + obj59;
		obj20 = (object)_replayPlayerColors + obj58;
		obj22 = (object)_replayPlayerColors + obj57;
		goto IL_0fc9;
		IL_0c06:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj61 = (nint)0 & (nint)1;
		if (obj61 != null)
		{
			goto IL_0c39;
		}
		goto IL_0d4a;
		IL_08ab:
		object obj62 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v87+E4]");
		bool flag19 = (nint)0 == 0;
		object obj63 = obj62;
		if (!flag19)
		{
			goto IL_08e0;
		}
		goto IL_0a61;
		IL_0a1b:
		_ = 1;
		obj62 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v87+E4]");
		bool flag20 = (nint)0 == 0;
		object obj64 = !flag20;
		obj63 = obj62;
		if (obj64 != null)
		{
			goto IL_08e0;
		}
		goto IL_0a61;
		IL_1046:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X22_v4+98]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v28+98]");
		List<object> list3 = (List<object>)0;
		int num11 = list3._size - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X22_v4+B8]");
		object obj66 = -num11;
		bool flag21 = (nint)obj66 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X22_v4+B8]");
		int num12 = (int)((nint)0 ^ (nint)num11);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X22_v4+B8]");
		int num13 = 0 ^ obj66;
		int num14 = num12 & num13;
		bool flag22 = num14 < 0;
		bool flag23 = flag21 == flag22;
		object obj67 = !flag23;
		object obj68 = ~obj67;
		int index3;
		if (obj68 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X22_v4+B8]");
			index3 = 0;
		}
		else
		{
			index3 = num11;
		}
		object obj69 = list3.get_Item(index3);
		object obj70 = (nint)0 + (nint)3952;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X0_v23 (System.Object)+10]");
		num10 = ((List<object>)0).IndexOf(firstReplayEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
		object obj71 = (nint)0 & (nint)1;
		if (obj71 != null)
		{
			object obj72 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v53+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0c06;
			}
		}
		else
		{
			_ = 1;
			object obj72 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v53+E4]");
			bool flag24 = (nint)0 == 0;
			object obj73 = !flag24;
			if (obj73 != null)
			{
				goto IL_0c06;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj74 = (nint)0 & (nint)1;
		bool flag25 = obj74 == null;
		object obj75 = !flag25;
		if (obj75 != null)
		{
			goto IL_0c39;
		}
		goto IL_0d4a;
		IL_08e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v87+B8]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v74+18]");
		object obj77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v74+18]");
		bool flag26 = (nint)0 == 0;
		object obj78 = !flag26;
		if (obj78 == null)
		{
			goto IL_0f97;
		}
		goto IL_1046;
		IL_0a61:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj79 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v75+B8]");
		object obj80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v65+18]");
		obj77 = 0;
		goto IL_1046;
		IL_04d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj81 = (nint)0 & (nint)1;
		if (obj81 != null)
		{
			goto IL_050b;
		}
		goto IL_067b;
		IL_067b:
		_ = 1;
		object obj82 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v112+E4]");
		bool flag27 = (nint)0 == 0;
		object obj83 = !flag27;
		object obj84 = obj82;
		if (obj83 != null)
		{
			goto IL_0540;
		}
		goto IL_06c1;
		IL_050b:
		obj82 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v112+E4]");
		bool flag28 = (nint)0 == 0;
		obj84 = obj82;
		if (!flag28)
		{
			goto IL_0540;
		}
		goto IL_06c1;
		IL_06c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj85 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v100+B8]");
		object obj86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v82+18]");
		object obj87 = 0;
		goto IL_101b;
		IL_0540:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v112+B8]");
		object obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v91+18]");
		obj87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v91+18]");
		bool flag29 = (nint)0 == 0;
		object obj89 = !flag29;
		if (obj89 == null)
		{
			goto IL_0f97;
		}
		goto IL_101b;
		IL_101b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X20_v6+98]");
		object obj90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v18+98]");
		List<object> list4 = (List<object>)0;
		int num15 = list4._size - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X20_v6+B8]");
		object obj91 = -num15;
		bool flag30 = (nint)obj91 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X20_v6+B8]");
		int num16 = (int)((nint)0 ^ (nint)num15);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X20_v6+B8]");
		int num17 = 0 ^ obj91;
		int num18 = num16 & num17;
		bool flag31 = num18 < 0;
		bool flag32 = flag30 == flag31;
		object obj92 = !flag32;
		object obj93 = ~obj92;
		int index4;
		if (obj93 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X20_v6+B8]");
			index4 = 0;
		}
		else
		{
			index4 = num15;
		}
		object obj94 = list4.get_Item(index4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v15 (System.Object)+10]");
		firstReplayEvent2 = EventsExtensions.GetFirstReplayEvent((List<ReplayEvent>)0, ReplayEventsTypes.PlayCard);
		if (firstReplayEvent2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj95 = (nint)0 & (nint)1;
			if (obj95 != null)
			{
				object obj96 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v81+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0878;
				}
			}
			else
			{
				_ = 1;
				object obj96 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v81+E4]");
				bool flag33 = (nint)0 == 0;
				object obj97 = !flag33;
				if (obj97 != null)
				{
					goto IL_0878;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj98 = (nint)0 & (nint)1;
			bool flag34 = obj98 == null;
			object obj99 = !flag34;
			if (obj99 != null)
			{
				goto IL_08ab;
			}
			goto IL_0a1b;
		}
		object obj100 = (nint)0 + (nint)3872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		obj16 = _replayPlayerColors + 68;
		obj18 = _replayPlayerColors + 64;
		obj20 = _replayPlayerColors + 60;
		obj22 = _replayPlayerColors + 56;
		goto IL_0fc9;
		IL_0c39:
		obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v59+E4]");
		bool flag35 = (nint)0 == 0;
		obj14 = obj12;
		if (!flag35)
		{
			goto IL_0c6e;
		}
		goto IL_0d90;
		IL_0d90:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj101 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v47+B8]");
		object obj102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v47+18]");
		object obj103 = 0;
		goto IL_1071;
		IL_0c6e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v59+B8]");
		object obj104 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v56+18]");
		obj103 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v56+18]");
		bool flag36 = (nint)0 == 0;
		object obj105 = !flag36;
		if (obj105 == null)
		{
			goto IL_0f97;
		}
		goto IL_1071;
	}

	private void SetupAklasButtons()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01eb: Expected I, but got O
		//IL_0093: Expected O, but got I4
		//IL_020f: Expected O, but got I
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_023c: Expected I, but got O
		//IL_0119: Expected O, but got I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_0261: Expected O, but got I
		//IL_0283: Expected O, but got I
		//IL_029b: Expected I, but got O
		//IL_01b6: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)584;
		object obj3 = this + 608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		Delegate obj4 = Delegate.Combine(_onGameInitialized, action);
		if ((object)obj4 != null)
		{
			if (obj4 == obj)
			{
				obj3 = obj4;
				if (obj4 == obj)
				{
					goto IL_0203;
				}
			}
			goto IL_01c1;
		}
		obj3 = 0;
		goto IL_0203;
		IL_0241:
		object obj5 = typeof(RegisteredWaitHandle) + 616;
		object obj6 = (nint)0 + (nint)576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v5+B8]");
		object a = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj6);
		Delegate obj8 = Delegate.Combine((Delegate)a, action2);
		if ((object)obj8 != null)
		{
			if (obj8 == obj)
			{
				object obj9 = obj5;
				object obj10 = obj8;
				if (obj8 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return;
				}
			}
			goto IL_01c1;
		}
		object obj11 = obj5;
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0203:
		object obj13 = (nint)0 + (nint)592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj14 = this + 616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj13);
		Delegate obj15 = Delegate.Combine(_onRoundStart, action3);
		if ((object)obj15 != null)
		{
			if (obj15 == obj)
			{
				obj14 = obj15;
				if (obj15 == obj)
				{
					goto IL_0241;
				}
			}
			goto IL_01c1;
		}
		obj14 = 0;
		goto IL_0241;
		IL_01c1:
		throw new InvalidCastException();
	}

	private void OnDisableAklasButtons()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01eb: Expected I, but got O
		//IL_0093: Expected O, but got I4
		//IL_020f: Expected O, but got I
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_023c: Expected I, but got O
		//IL_0119: Expected O, but got I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_0261: Expected O, but got I
		//IL_0283: Expected O, but got I
		//IL_029b: Expected I, but got O
		//IL_01b6: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)584;
		object obj3 = this + 608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		Delegate obj4 = Delegate.Remove(_onGameInitialized, action);
		if ((object)obj4 != null)
		{
			if (obj4 == obj)
			{
				obj3 = obj4;
				if (obj4 == obj)
				{
					goto IL_0203;
				}
			}
			goto IL_01c1;
		}
		obj3 = 0;
		goto IL_0203;
		IL_0241:
		object obj5 = typeof(RegisteredWaitHandle) + 616;
		object obj6 = (nint)0 + (nint)576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v5+B8]");
		object source = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj6);
		Delegate obj8 = Delegate.Remove((Delegate)source, action2);
		if ((object)obj8 != null)
		{
			if (obj8 == obj)
			{
				object obj9 = obj5;
				object obj10 = obj8;
				if (obj8 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return;
				}
			}
			goto IL_01c1;
		}
		object obj11 = obj5;
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0203:
		object obj13 = (nint)0 + (nint)592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj14 = this + 616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj13);
		Delegate obj15 = Delegate.Remove(_onRoundStart, action3);
		if ((object)obj15 != null)
		{
			if (obj15 == obj)
			{
				obj14 = obj15;
				if (obj15 == obj)
				{
					goto IL_0241;
				}
			}
			goto IL_01c1;
		}
		obj14 = 0;
		goto IL_0241;
		IL_01c1:
		throw new InvalidCastException();
	}

	private void AklasButtonsOnGameInitialized()
	{
		//IL_023b: Expected O, but got I
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_025c: Expected O, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0060: Expected O, but got I4
		//IL_00e9: Expected O, but got I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_019f: Expected O, but got I
		//IL_01bf: Expected I, but got O
		//IL_01d9: Expected O, but got I
		//IL_020e: Expected O, but got I
		object obj = (nint)0 + (nint)472;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj3 = (nint)0 + (nint)3928;
		int num = 0;
		<>c__DisplayClass52_0 <>c__DisplayClass52_ = default(<>c__DisplayClass52_0);
		object obj12 = default(object);
		UnityAction unityAction = default(UnityAction);
		int num2 = default(int);
		do
		{
			object obj4 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>c__DisplayClass52_..ctor();
			object obj5 = <>c__DisplayClass52_ + 24;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			List<object> aklasButtons = (List<object>)(object)_aklasButtons;
			int version = aklasButtons._version + 1;
			aklasButtons._version = version;
			object[] items = aklasButtons._items;
			bool flag2 = aklasButtons._size < items.Length;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				int size = aklasButtons._size + 1;
				aklasButtons._size = size;
				object obj10 = items + aklasButtons._size;
				object obj11 = obj10 + 32;
				obj11 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				aklasButtons.AddWithResize(obj12);
			}
			GameObject gameObject = ((UnityEngine.Component)obj12).gameObject;
			gameObject.SetActive(value: false);
			<>c__DisplayClass52_.index = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v13 (System.Object)+20]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			unityAction..ctor(<>c__DisplayClass52_, (IntPtr)obj3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v12+100]");
			((UnityEvent)0).AddListener(unityAction);
			num++;
			string text = num2.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v13 (System.Object)+28]");
			((TMP_Text)0).SetText(text);
		}
		while (num != 8);
	}

	private void OnAklaButtonPressed(int index)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0161: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01e7: Expected O, but got I4
		//IL_018f: Expected O, but got I
		//IL_01a9: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00fc: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_021f: Expected O, but got I
		//IL_022f: Expected O, but got I
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_02b7: Expected O, but got I4
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02df: Expected O, but got I4
		//IL_030c: Expected F4, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v25+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v25+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_01b7;
		IL_0239:
		GameReplayController gameReplayController;
		int aklaIndex = gameReplayController.<AklasIndices>k__BackingField.get_Item(index);
		gameReplayController.GoToAkla(aklaIndex);
		HandleAklasSliderButtons(index);
		HandleReplayPlayerControlButtons();
		Slider playSlider = _playSlider;
		float num = ReplayPlayerSliderTime();
		object obj7 = num & 0x7FFFFFFF;
		bool flag3 = (nint)obj7 < 2139095040;
		object obj8 = !flag3;
		object obj9 = obj7 - 2139095040;
		bool flag4 = obj9 == null;
		object obj10 = !flag4;
		object obj11 = obj8 & obj10;
		object obj12 = ~obj11;
		if (obj12 == null)
		{
			num = 0f;
		}
		playSlider.value = num;
		UpdateTimeText();
		UpdateRoundText(_roundTextMeshProUGUI);
		return;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v31+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v22+18]");
		gameReplayController = (GameReplayController)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v22+18]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 != null)
		{
			goto IL_0239;
		}
		throw new NullReferenceException();
		IL_01fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v19+B8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v13+18]");
		gameReplayController = (GameReplayController)0;
		goto IL_0239;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj17 = (nint)0 & (nint)1;
		if (obj17 != null)
		{
			goto IL_00a7;
		}
		goto IL_01b7;
		IL_01b7:
		_ = 1;
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v31+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		object obj20 = obj18;
		if (obj19 != null)
		{
			goto IL_00dc;
		}
		goto IL_01fd;
		IL_00a7:
		obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v31+E4]");
		bool flag7 = (nint)0 == 0;
		obj20 = obj18;
		if (!flag7)
		{
			goto IL_00dc;
		}
		goto IL_01fd;
	}

	private unsafe void AklasButtonsOnRoundStart()
	{
		//IL_0c56: Expected O, but got I4
		//IL_001b: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected I4, but got Unknown
		//IL_0050: Expected O, but got I
		//IL_01a4: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_022f: Expected O, but got I4
		//IL_01d2: Expected O, but got I
		//IL_01ec: Expected O, but got I4
		//IL_011c: Expected O, but got I
		//IL_012c: Expected O, but got I
		//IL_014e: Expected O, but got I4
		//IL_02bf: Expected O, but got I
		//IL_02d5: Expected O, but got I
		//IL_026c: Expected O, but got I
		//IL_027c: Expected O, but got I
		//IL_029c: Expected O, but got I4
		//IL_0413: Expected O, but got I4
		//IL_0165: Expected O, but got I4
		//IL_032d: Expected O, but got I
		//IL_049e: Expected O, but got I4
		//IL_0441: Expected O, but got I
		//IL_045b: Expected O, but got I4
		//IL_0394: Expected O, but got I
		//IL_03a4: Expected O, but got I
		//IL_03c6: Expected O, but got I4
		//IL_04db: Expected O, but got I
		//IL_04eb: Expected O, but got I
		//IL_0570: Expected O, but got I
		//IL_05a2: Expected O, but got I
		//IL_0b6f: Expected O, but got I4
		//IL_08dc: Expected I, but got O
		//IL_0b09: Expected O, but got I4
		//IL_0b0e: Expected I, but got O
		//IL_077f: Expected O, but got I
		//IL_0794: Expected O, but got I
		//IL_07ef: Expected O, but got I4
		//IL_0813: Expected O, but got I
		//IL_0835: Expected O, but got I
		//IL_096b: Expected O, but got I4
		//IL_0979: Expected O, but got I4
		//IL_09c4: Expected O, but got I
		//IL_09e6: Expected O, but got I4
		//IL_0607: Expected O, but got I4
		List<float> sliderAklasMappedTime = _sliderAklasMappedTime;
		bool flag = _sliderAklasMappedTime == null;
		List<int> list = (List<int>)152993792;
		ReplayPlayer replayPlayer = this;
		int num = default(int);
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v3 (System.Collections.Generic.List`1<System.Single>)+1C]");
			object obj = (nint)0 + (nint)1;
			_ = 0;
			num = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				int value = ((int*)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v65 (System.Int32)+E4]");
				if ((nint)0 != 0)
				{
					goto IL_009f;
				}
			}
			else
			{
				_ = 1;
				int value = ((int*)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v65 (System.Int32)+E4]");
				bool flag2 = (nint)0 == 0;
				object obj3 = !flag2;
				if (obj3 != null)
				{
					goto IL_009f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj4 = (nint)0 & (nint)1;
			bool flag3 = obj4 == null;
			object obj5 = !flag3;
			if (obj5 != null)
			{
				goto IL_00d2;
			}
			goto IL_01fa;
		}
		goto IL_0b9d;
		IL_04b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int value2 = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v42 (System.Int32)+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v34+18]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v34+18]");
		bool flag4 = (nint)0 == 0;
		replayPlayer = this;
		if (!flag4)
		{
			goto IL_0515;
		}
		goto IL_0b9d;
		IL_0b26:
		object obj8;
		bool flag5 = obj8 == null;
		replayPlayer = this;
		GameObject gameObject;
		int index;
		List<int> list2;
		ReplayPlayer go;
		if (!flag5)
		{
			gameObject = ((UnityEngine.Component)obj8).gameObject;
			bool flag6 = (object)gameObject == null;
			object obj9 = !flag6;
			replayPlayer = (ReplayPlayer)obj8;
			index = num;
			list2 = list;
			go = (ReplayPlayer)obj8;
			if (obj9 != null)
			{
				goto IL_0bcb;
			}
		}
		goto IL_0b9d;
		IL_0515:
		List<object> list3 = (List<object>)(object)_aklasButtons;
		bool flag7 = _aklasButtons == null;
		replayPlayer = this;
		if (!flag7)
		{
			if (list != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v14+F0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v14+F0]");
				if ((nint)0 != 0)
				{
					object obj11 = (nint)0 + (nint)1488;
					int num2 = 0;
					while (num2 < list3._size)
					{
						object obj12 = list3.get_Item(num2);
						int num3 = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X20_v4 (System.Collections.Generic.List`1<System.Int32>)+18]");
						if ((nint)num3 < (nint)0)
						{
							bool flag8 = obj12 == null;
							num = num2;
							replayPlayer = this;
							if (!flag8)
							{
								GameObject gameObject2 = ((UnityEngine.Component)obj12).gameObject;
								bool flag9 = (object)gameObject2 == null;
								num = num2;
								replayPlayer = this;
								if (!flag9)
								{
									gameObject2.SetActive(value: true);
									RectTransform rectTransform = UIExtensions.rectTransform((UnityEngine.Component)obj12);
									int num4 = list.get_Item(num2);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X24_v6+18]");
									float inputMax = 0f - 1f;
									float item = FloatExtensions.Map(num4, 0f, inputMax, 0f, 1f);
									List<float> sliderAklasMappedTime2 = _sliderAklasMappedTime;
									bool flag10 = _sliderAklasMappedTime == null;
									num = num2;
									replayPlayer = this;
									if (!flag10)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v34 (System.Collections.Generic.List`1<System.Single>)+1C]");
										object obj13 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v34 (System.Collections.Generic.List`1<System.Single>)+10]");
										object obj14 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v34 (System.Collections.Generic.List`1<System.Single>)+10]");
										bool flag11 = (nint)0 == 0;
										num = num2;
										replayPlayer = this;
										if (!flag11)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v34 (System.Collections.Generic.List`1<System.Single>)+18]");
											nint num5 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X9_v10+18]");
											bool flag12 = num5 < 0;
											object obj15 = !flag12;
											if (obj15 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v34 (System.Collections.Generic.List`1<System.Single>)+18]");
												object obj16 = (nint)0 + (nint)1;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v34 (System.Collections.Generic.List`1<System.Single>)+10]");
												nint num6 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v34 (System.Collections.Generic.List`1<System.Single>)+18]");
												object obj17 = num6 + 0;
											}
											else
											{
												_sliderAklasMappedTime.AddWithResize(item);
											}
											bool flag13 = (object)rectTransform == null;
											num = num2;
											replayPlayer = this;
											if (!flag13)
											{
												rectTransform.anchorMax = (Vector2)0;
												rectTransform.anchorMin = (Vector2)0;
												ReplayPlayerColorsScriptableObject replayPlayerColors = _replayPlayerColors;
												bool flag14 = (object)_replayPlayerColors == null;
												num = num2;
												replayPlayer = this;
												if (!flag14)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v24 (System.Object)+30]");
													object obj18 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v24 (System.Object)+30]");
													bool flag15 = (nint)0 == 0;
													object obj19 = !flag15;
													if (obj19 != null)
													{
														object obj20 = obj18;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v28+2B0]");
														nint num7 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v240 @ X8_v28+2A8] (should have been resolved before IL gen)");
														num2++;
														list3 = (List<object>)(object)_aklasButtons;
														bool flag16 = _aklasButtons == null;
														object obj21 = !flag16;
														if (obj21 != null)
														{
															continue;
														}
														num = num2;
														replayPlayer = this;
													}
													else
													{
														num = num2;
														replayPlayer = this;
													}
												}
											}
										}
									}
								}
							}
						}
						else
						{
							bool flag17 = obj12 == null;
							num = num2;
							replayPlayer = this;
							if (!flag17)
							{
								GameObject gameObject3 = ((UnityEngine.Component)obj12).gameObject;
								bool flag18 = (object)gameObject3 == null;
								num = num2;
								replayPlayer = this;
								if (!flag18)
								{
									gameObject3.SetActive(value: false);
									num2++;
									list3 = (List<object>)(object)_aklasButtons;
									bool flag19 = _aklasButtons == null;
									nint num7 = unchecked((nint)null);
									num = num2;
									replayPlayer = this;
									if (!flag19)
									{
										continue;
									}
								}
							}
						}
						goto IL_0b9d;
					}
				}
				else
				{
					num = 0;
					while (num < list3._size)
					{
						obj8 = list3.get_Item(num);
						int num8 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X20_v4 (System.Collections.Generic.List`1<System.Int32>)+18]");
						if ((nint)num8 < (nint)0)
						{
							goto IL_0b26;
						}
						bool flag20 = obj8 == null;
						replayPlayer = this;
						if (!flag20)
						{
							GameObject gameObject4 = ((UnityEngine.Component)obj8).gameObject;
							bool flag21 = (object)gameObject4 == null;
							replayPlayer = this;
							if (!flag21)
							{
								gameObject4.SetActive(value: false);
								num++;
								list3 = (List<object>)(object)_aklasButtons;
								bool flag22 = _aklasButtons == null;
								object obj22 = !flag22;
								nint num7 = unchecked((nint)null);
								if (obj22 != null)
								{
									continue;
								}
								replayPlayer = this;
							}
						}
						goto IL_0b9d;
					}
				}
			}
			else if (list3._size >= 1)
			{
				goto IL_0c13;
			}
			AklasButtonsOnCommentChange();
			return;
		}
		goto IL_0b9d;
		IL_0384:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v53 (System.Int32)+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v44+18]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v44+18]");
		bool flag23 = (nint)0 == 0;
		object obj24 = !flag23;
		if (obj24 != null)
		{
			goto IL_0515;
		}
		replayPlayer = this;
		goto IL_0b9d;
		IL_009f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj25 = (nint)0 & (nint)1;
		if (obj25 != null)
		{
			goto IL_00d2;
		}
		goto IL_01fa;
		IL_01fa:
		_ = 1;
		int value3 = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v48 (System.Int32)+E4]");
		bool flag24 = (nint)0 == 0;
		object obj26 = !flag24;
		int num9 = value3;
		if (obj26 != null)
		{
			goto IL_010c;
		}
		goto IL_0245;
		IL_00d2:
		value3 = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v48 (System.Int32)+E4]");
		bool flag25 = (nint)0 == 0;
		num9 = value3;
		if (!flag25)
		{
			goto IL_010c;
		}
		goto IL_0245;
		IL_0245:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		value3 = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v48 (System.Int32)+B8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v52+18]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v52+18]");
		bool flag26 = (nint)0 == 0;
		list = (List<int>)152993792;
		replayPlayer = this;
		if (!flag26)
		{
			goto IL_02af;
		}
		goto IL_0b9d;
		IL_010c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v48 (System.Int32)+B8]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v62+18]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v62+18]");
		bool flag27 = (nint)0 == 0;
		object obj30 = !flag27;
		if (obj30 != null)
		{
			goto IL_02af;
		}
		list = (List<int>)152993792;
		replayPlayer = this;
		goto IL_0b9d;
		IL_02af:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v12+F8]");
		list = (List<int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
		object obj31 = (nint)0 & (nint)1;
		if (obj31 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v48 (System.Int32)+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0317;
			}
		}
		else
		{
			_ = 1;
			value3 = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v48 (System.Int32)+E4]");
			bool flag28 = (nint)0 == 0;
			object obj32 = !flag28;
			if (obj32 != null)
			{
				goto IL_0317;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj33 = (nint)0 & (nint)1;
		bool flag29 = obj33 == null;
		object obj34 = !flag29;
		if (obj34 != null)
		{
			goto IL_034a;
		}
		goto IL_0469;
		IL_0b9d:
		NullReferenceException ex = new NullReferenceException();
		index = num;
		gameObject = (GameObject)(object)ex;
		list2 = list;
		go = replayPlayer;
		goto IL_0bcb;
		IL_0c13:
		object obj35 = list3.get_Item(0);
		throw new NullReferenceException();
		IL_0bcb:
		gameObject.SetActive(value: true);
		RectTransform rectTransform2 = UIExtensions.rectTransform(go);
		int num10 = list2.get_Item(index);
		NullReferenceException ex2 = new NullReferenceException();
		list3 = (List<object>)(object)ex2;
		goto IL_0c13;
		IL_0317:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj36 = (nint)0 & (nint)1;
		if (obj36 != null)
		{
			goto IL_034a;
		}
		goto IL_0469;
		IL_0469:
		_ = 1;
		int value4 = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v53 (System.Int32)+E4]");
		bool flag30 = (nint)0 == 0;
		object obj37 = !flag30;
		int num11 = value4;
		if (obj37 != null)
		{
			goto IL_0384;
		}
		goto IL_04b4;
		IL_034a:
		value4 = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v53 (System.Int32)+E4]");
		bool flag31 = (nint)0 == 0;
		num11 = value4;
		if (!flag31)
		{
			goto IL_0384;
		}
		goto IL_04b4;
	}

	private void AklasButtonsOnCommentChange()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0d5d: Expected O, but got I4
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d71: Expected O, but got Unknown
		//IL_0d87: Expected O, but got I
		//IL_014d: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0074: Expected O, but got I4
		//IL_007d: Expected O, but got I4
		//IL_01e5: Expected O, but got I4
		//IL_017b: Expected O, but got I
		//IL_0195: Expected O, but got I4
		//IL_019e: Expected O, but got I4
		//IL_01a7: Expected O, but got I4
		//IL_00d8: Expected O, but got I
		//IL_00e8: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0260: Expected O, but got I
		//IL_0225: Expected O, but got I
		//IL_0235: Expected O, but got I
		//IL_0470: Expected O, but got I
		//IL_0491: Expected O, but got I
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02c3: Expected O, but got I
		//IL_02cf: Expected O, but got I
		//IL_02db: Expected O, but got I
		//IL_02f6: Expected I, but got O
		//IL_0c74: Expected O, but got I4
		//IL_031c: Expected I4, but got O
		//IL_04f1: Expected O, but got I
		//IL_0344: Expected O, but got I
		//IL_0cfa: Expected O, but got I4
		//IL_0ca2: Expected O, but got I
		//IL_0cbc: Expected O, but got I4
		//IL_0583: Expected O, but got I4
		//IL_0db4: Expected O, but got I
		//IL_0dc4: Expected O, but got I
		//IL_0538: Expected O, but got I4
		//IL_03a4: Expected O, but got I
		//IL_0609: Expected O, but got I4
		//IL_05b1: Expected O, but got I
		//IL_05cb: Expected O, but got I4
		//IL_0406: Expected O, but got I
		//IL_0416: Expected O, but got I
		//IL_0438: Expected O, but got I4
		//IL_0666: Expected O, but got I
		//IL_0641: Expected O, but got I
		//IL_0651: Expected O, but got I
		//IL_0a39: Expected O, but got I4
		//IL_0a4f: Expected O, but got I
		//IL_0b52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b57: Expected O, but got Unknown
		//IL_0b81: Expected O, but got I4
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected O, but got Unknown
		//IL_06ba: Expected O, but got I
		//IL_06c6: Expected O, but got I
		//IL_06d2: Expected O, but got I
		//IL_0703: Expected O, but got I4
		//IL_0acb: Expected O, but got I
		//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_07b3: Expected I4, but got I8
		//IL_07cd: Expected O, but got I4
		//IL_0c17: Expected O, but got I4
		//IL_0bb7: Expected O, but got I
		//IL_0bd1: Expected O, but got I4
		//IL_076b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0b1a: Expected O, but got I4
		//IL_07eb: Expected O, but got I
		//IL_08e0: Expected O, but got I
		//IL_0902: Expected O, but got I
		//IL_0912: Expected O, but got I
		//IL_0922: Expected O, but got I
		//IL_097a: Expected O, but got I
		//IL_098f: Expected O, but got I
		//IL_09bd: Expected O, but got I4
		//IL_0720: Expected O, but got I
		//IL_0730: Expected O, but got I
		//IL_0740: Expected O, but got I
		//IL_09e1: Expected O, but got I
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fb: Expected O, but got Unknown
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass57_0 <>c__DisplayClass57_ = default(<>c__DisplayClass57_0);
		<>c__DisplayClass57_..ctor();
		object obj2 = 152993792;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
		object obj4 = (nint)0 & (nint)1;
		if (obj4 != null)
		{
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v98+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0046;
			}
		}
		else
		{
			_ = 1;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v98+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 != null)
			{
				goto IL_0046;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj7 = (nint)0 & (nint)1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		object obj9 = 146685952;
		object obj10 = 146685952;
		if (obj8 != null)
		{
			goto IL_008b;
		}
		goto IL_01b5;
		IL_03c1:
		List<int> list = (List<int>)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v70 (System.Collections.Generic.List`1<System.Int32>)+E4]");
		bool flag3 = (nint)0 == 0;
		List<int> list2 = list;
		if (!flag3)
		{
			goto IL_03f6;
		}
		goto IL_061f;
		IL_05d9:
		_ = 1;
		list = (List<int>)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v70 (System.Collections.Generic.List`1<System.Int32>)+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		list2 = list;
		if (obj11 != null)
		{
			goto IL_03f6;
		}
		goto IL_061f;
		IL_038e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj12 = (nint)0 & (nint)1;
		if (obj12 != null)
		{
			goto IL_03c1;
		}
		goto IL_05d9;
		IL_0046:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj13 = (nint)0 & (nint)1;
		bool flag5 = obj13 == null;
		obj9 = 146685952;
		obj10 = 146685952;
		if (!flag5)
		{
			goto IL_008b;
		}
		goto IL_01b5;
		IL_01b5:
		_ = 1;
		object obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v104+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		obj9 = obj10;
		object obj16 = obj14;
		if (obj15 != null)
		{
			goto IL_00c8;
		}
		goto IL_0203;
		IL_008b:
		obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v104+E4]");
		bool flag7 = (nint)0 == 0;
		obj10 = obj9;
		obj16 = obj14;
		if (!flag7)
		{
			goto IL_00c8;
		}
		goto IL_0203;
		IL_0203:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj17 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v92+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v76+18]");
		object obj19 = 0;
		obj9 = obj10;
		goto IL_0242;
		IL_00c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v104+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v86+18]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v86+18]");
		bool flag8 = (nint)0 == 0;
		object obj21 = !flag8;
		if (obj21 != null)
		{
			goto IL_0242;
		}
		goto IL_0d3a;
		IL_0242:
		object obj22 = <>c__DisplayClass57_ + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v5+F0]");
		obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		List<ReplayEvent> replayEvents = EventsExtensions.GetReplayEvents((List<ReplayEvent>)obj22, ReplayEventsTypes.Comment);
		int[] array;
		object obj26;
		int num;
		if (replayEvents._size != 0)
		{
			object obj23 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3104;
			List<int> list3 = (List<int>)((nint)0 + (nint)3936);
			object obj24 = (nint)0 + (nint)3928;
			object obj25 = (nint)0 + (nint)1320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, int> func = default(Func<object, int>);
			func..ctor((object)<>c__DisplayClass57_, (IntPtr)list3);
			obj26 = obj24;
			IEnumerable<int> source = Enumerable.Select(replayEvents, func);
			num = (int)obj25;
			array = Enumerable.ToArray(source);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj27 = (nint)0 & (nint)1;
			if (obj27 != null)
			{
				object obj28 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v79+E4]");
				if ((nint)0 != 0)
				{
					goto IL_038e;
				}
			}
			else
			{
				_ = 1;
				object obj28 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v79+E4]");
				bool flag9 = (nint)0 == 0;
				object obj29 = !flag9;
				if (obj29 != null)
				{
					goto IL_038e;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj30 = (nint)0 & (nint)1;
			bool flag10 = obj30 == null;
			object obj31 = !flag10;
			if (obj31 != null)
			{
				goto IL_03c1;
			}
			goto IL_05d9;
		}
		List<int> commentedAklasIndices = _commentedAklasIndices;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v10 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj32 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
		object obj33 = (nint)0 & (nint)1;
		if (obj33 != null)
		{
			object obj34 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v21+E4]");
			if ((nint)0 != 0)
			{
				goto IL_04db;
			}
		}
		else
		{
			_ = 1;
			object obj34 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v21+E4]");
			bool flag11 = (nint)0 == 0;
			object obj35 = !flag11;
			if (obj35 != null)
			{
				goto IL_04db;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X27_v2+5ED]");
		object obj36 = (nint)0 & (nint)1;
		bool flag12 = obj36 == null;
		object obj37 = !flag12;
		if (obj37 != null)
		{
			goto IL_050e;
		}
		goto IL_0cca;
		IL_03f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v70 (System.Collections.Generic.List`1<System.Int32>)+B8]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X8_v68+18]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X8_v68+18]");
		bool flag13 = (nint)0 == 0;
		object obj40 = !flag13;
		if (obj40 != null)
		{
			goto IL_0656;
		}
		goto IL_0d3a;
		IL_0ab5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj41 = (nint)0 & (nint)1;
		bool flag14 = obj41 == null;
		object obj43;
		object obj42 = obj43;
		if (!flag14)
		{
			goto IL_0af0;
		}
		goto IL_0be7;
		IL_0da4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v11+B8]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v8+18]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v9+C8]");
		HandleAklasSliderButtons(0);
		return;
		IL_0d3a:
		throw new NullReferenceException();
		IL_04db:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj46 = (nint)0 & (nint)1;
		if (obj46 != null)
		{
			goto IL_050e;
		}
		goto IL_0cca;
		IL_0cca:
		_ = 1;
		object obj47 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v13+E4]");
		bool flag15 = (nint)0 == 0;
		object obj48 = !flag15;
		object obj49 = obj47;
		if (obj48 == null)
		{
			goto IL_0d10;
		}
		goto IL_0da4;
		IL_050e:
		obj49 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v11+E4]");
		bool flag16 = (nint)0 == 0;
		object obj50 = !flag16;
		if (obj50 == null)
		{
			obj47 = obj49;
			goto IL_0d10;
		}
		goto IL_0da4;
		IL_0af0:
		obj49 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v11+E4]");
		bool flag17 = (nint)0 == 0;
		object obj51 = !flag17;
		object obj52;
		if (obj51 == null)
		{
			obj52 = obj49;
			obj42 = obj43;
			goto IL_0c2d;
		}
		goto IL_0da4;
		IL_0d10:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj49 = obj3;
		goto IL_0da4;
		IL_061f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		list = (List<int>)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v70 (System.Collections.Generic.List`1<System.Int32>)+B8]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v58+18]");
		obj39 = 0;
		goto IL_0656;
		IL_0be7:
		_ = 1;
		obj52 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X0_v38+E4]");
		bool flag18 = (nint)0 == 0;
		object obj54 = !flag18;
		obj49 = obj52;
		if (obj54 == null)
		{
			goto IL_0c2d;
		}
		goto IL_0da4;
		IL_0c2d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj49 = obj42;
		goto IL_0da4;
		IL_0656:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v28+F8]");
		List<int> list4 = (List<int>)0;
		if (array.Length >= 1)
		{
			object obj55 = array + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X21_v9 (System.Collections.Generic.List`1<System.Int32>)+18]");
			int num2 = (int)(-1);
			object obj56 = (nint)0 + (nint)1488;
			object obj57 = (nint)0 + (nint)608;
			object obj58 = (nint)0 + (nint)1336;
			object obj60 = default(object);
			object obj59 = obj60;
			object obj62 = default(object);
			object obj61 = obj62;
			object obj64 = default(object);
			object obj63 = obj64;
			Color color2 = default(Color);
			Color color = color2;
			object obj65 = obj26;
			object obj66 = 0;
			int num3 = num;
			bool flag22;
			do
			{
				int num4 = (int)(num2 & 0x80000000L);
				bool flag19 = num4 == 0;
				object obj67 = !flag19;
				int num6;
				List<int> list3;
				if (obj67 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X28_v6+v256 @ X27_v7*4]");
					list3 = (List<int>)0;
					obj65 = obj56;
					int num5 = list4.get_Item(num2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X28_v6+v256 @ X27_v7*4]");
					bool flag20 = (nint)0 > (nint)num5;
					num3 = num2;
					num6 = num2;
					if (flag20)
					{
						goto IL_08ae;
					}
					while (num2 != 0)
					{
						num2--;
						obj65 = obj56;
						int num7 = list4.get_Item(num2);
						bool flag21 = (nint)list3 <= num7;
						num3 = num2;
						num6 = num2;
						if (flag21)
						{
							continue;
						}
						goto IL_08ae;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X21_v9 (System.Collections.Generic.List`1<System.Int32>)+18]");
					num2 = (int)(-1);
				}
				goto IL_0762;
				IL_0762:
				obj66++;
				flag22 = (nint)obj66 >= array.Length;
				obj26 = obj65;
				num = num3;
				continue;
				IL_08ae:
				object obj68 = ((List<object>)(object)_aklasButtons).get_Item(num6);
				ReplayPlayerColorsScriptableObject replayPlayerColors = _replayPlayerColors;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v61 (System.Object)+30]");
				object obj69 = 0;
				color = replayPlayerColors.<CommentColor>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v47 (ReplayPlayerColorsScriptableObject)+3C]");
				obj63 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v47 (ReplayPlayerColorsScriptableObject)+40]");
				obj61 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v47 (ReplayPlayerColorsScriptableObject)+44]");
				obj59 = 0;
				object obj70 = obj69;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v307 @ X8_v48+2A8] (should have been resolved before IL gen)");
				list3 = _commentedAklasIndices;
				obj65 = obj56;
				int num8 = list4.get_Item(num6);
				object obj71 = obj58;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X23_v10 (System.Collections.Generic.List`1<System.Int32>)+1C]");
				object obj72 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X23_v10 (System.Collections.Generic.List`1<System.Int32>)+10]");
				object obj73 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X23_v10 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X9_v11+18]");
				bool flag23 = num9 < 0;
				object obj74 = !flag23;
				if (obj74 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v49+20]");
					object obj75 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v52+C0]");
					object obj76 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v53+70]");
					obj65 = 0;
					list3.AddWithResize(num8);
					num2 = num6;
					num3 = num8;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X23_v10 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj77 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X23_v10 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj78 = obj73 + 0;
					num2 = num6;
					num3 = num8;
				}
				goto IL_0762;
			}
			while (!flag22);
		}
		object obj79 = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
		object obj80 = (nint)0 & (nint)1;
		if (obj80 != null)
		{
			obj43 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			object obj81 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X0_v46+E4]");
			bool flag24 = (nint)0 == 0;
			obj42 = obj43;
			if (!flag24)
			{
				goto IL_0ab5;
			}
		}
		else
		{
			_ = 1;
			obj43 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			object obj81 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X0_v46+E4]");
			bool flag25 = (nint)0 == 0;
			object obj82 = !flag25;
			obj42 = obj43;
			if (obj82 != null)
			{
				goto IL_0ab5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj83 = (nint)0 & (nint)1;
		bool flag26 = obj83 == null;
		object obj84 = !flag26;
		obj43 = obj42;
		if (obj84 != null)
		{
			goto IL_0af0;
		}
		goto IL_0be7;
	}

	private void HandleAklasSliderButtons(int index)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01b5: Expected O, but got I
		//IL_01cf: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_024b: Expected O, but got I
		//IL_0265: Expected O, but got I4
		//IL_0215: Expected O, but got I4
		//IL_00d6: Expected O, but got I
		//IL_02eb: Expected O, but got I
		//IL_02fb: Expected O, but got I
		//IL_02ab: Expected O, but got I4
		//IL_0310: Expected O, but got I
		//IL_0140: Expected O, but got I
		//IL_0150: Expected O, but got I
		//IL_0172: Expected O, but got I4
		//IL_0348: Expected O, but got I
		//IL_03b0: Expected O, but got I4
		//IL_042c: Expected O, but got I4
		//IL_0435: Expected O, but got I4
		//IL_043e: Expected O, but got I4
		//IL_0447: Expected O, but got I4
		//IL_045c: Expected O, but got I
		//IL_047e: Expected O, but got I4
		//IL_0403: Expected O, but got I4
		//IL_040c: Expected O, but got I4
		//IL_0415: Expected O, but got I4
		//IL_041e: Expected O, but got I4
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F4]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v23+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		obj3 = obj5;
		if (obj9 != null)
		{
			goto IL_00c0;
		}
		goto IL_022b;
		IL_048c:
		throw new NullReferenceException();
		IL_0300:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+F8]");
		List<int> list = (List<int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X21_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		object obj10 = (nint)0 + (nint)608;
		int num = 0;
		while (true)
		{
			int item = list.get_Item(num);
			bool flag4 = _commentedAklasIndices.Contains(item);
			bool flag5 = !flag4;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				object obj12 = ((List<object>)(object)_aklasButtons).get_Item(num);
				ReplayPlayerColorsScriptableObject replayPlayerColors = _replayPlayerColors;
				if (index < num)
				{
					object obj13 = 36;
					object obj14 = 32;
					object obj15 = 28;
					object obj16 = 24;
				}
				else
				{
					object obj13 = 52;
					object obj14 = 48;
					object obj15 = 44;
					object obj16 = 40;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v12 (System.Object)+30]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v12 (System.Object)+30]");
				bool flag6 = (nint)0 == 0;
				object obj18 = !flag6;
				if (obj18 == null)
				{
					break;
				}
				object obj19 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v354 @ X8_v10+2A8] (should have been resolved before IL gen)");
			}
			num++;
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X21_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
			if ((nint)num2 >= (nint)0)
			{
				return;
			}
		}
		goto IL_048c;
		IL_0130:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v42+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v25+18]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v25+18]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		if (obj22 != null)
		{
			goto IL_0300;
		}
		goto IL_048c;
		IL_008b:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v23+E4]");
		bool flag8 = (nint)0 == 0;
		obj5 = obj3;
		if (!flag8)
		{
			goto IL_00c0;
		}
		goto IL_022b;
		IL_022b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj23 = (nint)0 & (nint)1;
		bool flag9 = obj23 == null;
		object obj24 = !flag9;
		obj3 = obj5;
		if (obj24 != null)
		{
			goto IL_00fb;
		}
		goto IL_027b;
		IL_00c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj25 = (nint)0 & (nint)1;
		bool flag10 = obj25 == null;
		obj5 = obj3;
		if (!flag10)
		{
			goto IL_00fb;
		}
		goto IL_027b;
		IL_027b:
		_ = 1;
		object obj26 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v42+E4]");
		bool flag11 = (nint)0 == 0;
		object obj27 = !flag11;
		object obj28 = obj26;
		obj3 = obj5;
		if (obj27 != null)
		{
			goto IL_0130;
		}
		goto IL_02c9;
		IL_00fb:
		obj26 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v42+E4]");
		bool flag12 = (nint)0 == 0;
		obj28 = obj26;
		if (!flag12)
		{
			goto IL_0130;
		}
		goto IL_02c9;
		IL_02c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj29 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v17+B8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v12+18]");
		obj21 = 0;
		goto IL_0300;
	}

	private void SetupMoreButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_0065: Expected O, but got I
		//IL_0080: Expected O, but got I
		//IL_0098: Expected I, but got O
		//IL_00b2: Expected O, but got I
		Button moreButton = _moreButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		moreButton.m_OnClick.AddListener(unityAction);
		object obj3 = (nint)0 + (nint)3640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj4 = (nint)0 + (nint)536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v8+100]");
		((UnityEvent)0).AddListener(unityAction2);
	}

	private void SetupMoreButtonsAnimation()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0150: Expected O, but got I
		//IL_015c: Expected O, but got I
		//IL_0186: Expected O, but got I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_007a: Expected O, but got I
		//IL_00ba: Expected O, but got I
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00d1: Expected O, but got I4
		//IL_01a4: Expected O, but got I
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_0116: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = (nint)0 + (nint)2720;
		object obj3 = (nint)0 + (nint)2384;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence moreButtonsSequence = DOTween.Sequence();
		_moreButtonsSequence = moreButtonsSequence;
		object obj6 = this + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C58");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30506C0");
		object obj7 = (nint)0 + (nint)1664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E33B8C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v15+18]");
		if ((nint)0 >= (nint)1)
		{
			object obj8 = (nint)0 + (nint)2728;
			object obj10 = default(object);
			object obj9 = obj10 + 32;
			object obj11 = 0;
			object obj13;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X23_v4+v137 @ X21_v8*8]");
				object obj12 = 0;
				obj11++;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C58");
				Sequence moreButtonsSequence2 = _moreButtonsSequence;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X24_v5+68]");
				Sequence sequence = TweenSettingsExtensions.Insert(moreButtonsSequence2, 0f, (Tween)0);
				obj13 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v15+18]");
			}
			while ((nint)obj13 < 0);
		}
	}

	private void ToggleMoreButtons()
	{
		//IL_00cc: Expected O, but got I
		//IL_0044: Expected O, but got I
		//IL_0083: Expected I, but got O
		//IL_0093: Expected O, but got I
		//IL_00a3: Expected O, but got I
		bool moreButtonsOpen = (byte)((_moreButtonsOpen ? 1u : 0u) ^ 1u) != 0;
		_moreButtonsOpen = moreButtonsOpen;
		if (~(_moreButtonsOpen ? 1u : 0u) == 0)
		{
			_moreButtonsOpen = false;
			Sequence moreButtonsSequence = _moreButtonsSequence;
			object obj = (nint)0 + (nint)2408;
			moreButtonsSequence.isBackwards = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
			UIExtensions.Disable(_blocker);
			DOTweenAnimation commentInputAnimation = _commentInputAnimation;
			nint num = (nint)commentInputAnimation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v13 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+188]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v13 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+190]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v86 @ X2_v1 (should have been resolved before IL gen)");
		}
		_moreButtonsOpen = true;
		Sequence moreButtonsSequence2 = _moreButtonsSequence;
		moreButtonsSequence2.isBackwards = false;
		object obj4 = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		UIExtensions.Enable(_blocker);
	}

	private void ShowMoreButtons()
	{
		//IL_0011: Expected O, but got I
		_moreButtonsOpen = true;
		Sequence moreButtonsSequence = _moreButtonsSequence;
		object obj = (nint)0 + (nint)2408;
		moreButtonsSequence.isBackwards = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		UIExtensions.Enable(_blocker);
	}

	private void HideMoreButtons()
	{
		//IL_0011: Expected O, but got I
		_moreButtonsOpen = false;
		Sequence moreButtonsSequence = _moreButtonsSequence;
		object obj = (nint)0 + (nint)2408;
		moreButtonsSequence.isBackwards = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		UIExtensions.Disable(_blocker);
	}

	private void SetupCommentButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button commentButton = _commentButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		commentButton.m_OnClick.AddListener(unityAction);
	}

	private void SetupUnHideCardsButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button hideCardsButton = _hideCardsButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		hideCardsButton.m_OnClick.AddListener(unityAction);
	}

	private void SetupHidePanelButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button hidePanelButton = _hidePanelButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		hidePanelButton.m_OnClick.AddListener(unityAction);
	}

	private void SetupCommentViewerButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button commentViewerButton = _commentViewerButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		commentViewerButton.m_OnClick.AddListener(unityAction);
	}

	private void ResetCommentInputField()
	{
		//IL_0011: Expected O, but got I
		object text = (nint)0 + (nint)2000;
		_commentInputField.text = (string)text;
		_commentDurationToggleGroupIndexer.SelectedIndex = 1;
	}

	private void SetupAddCommentButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button addCommentButton = _addCommentButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		addCommentButton.m_OnClick.AddListener(unityAction);
	}

	private static void OnCommentChange()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_0029: Expected O, but got I
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 616;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+28]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v43 @ X2_v1 (should have been resolved before IL gen)");
		}
	}

	private void SetupBackCommentButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button backButton = _backButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		backButton.m_OnClick.AddListener(unityAction);
	}

	private void SetupEditCommentButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button editCommentButton = _editCommentButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		editCommentButton.m_OnClick.AddListener(unityAction);
	}

	private void SetupDeleteCommentButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button deleteCommentButton = _deleteCommentButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		deleteCommentButton.m_OnClick.AddListener(unityAction);
	}

	private void InitializeCommentButtonColor()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00aa: Expected O, but got I
		//IL_00f7: Expected O, but got I
		//IL_0109: Expected O, but got I
		//IL_0058: Expected O, but got I
		Button commentButton = _commentButton;
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1832;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (UnityEngine.UI.Button)+94]");
			_disabledColor = (Color)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (UnityEngine.UI.Button)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (UnityEngine.UI.Button)+9C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (UnityEngine.UI.Button)+A0]");
			_ = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			commentButton = _commentButton;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (UnityEngine.UI.Button)+94]");
			_disabledColor = (Color)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (UnityEngine.UI.Button)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (UnityEngine.UI.Button)+9C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (UnityEngine.UI.Button)+A0]");
			_ = 0;
		}
		_normalColor = (Color)((Selectable)commentButton).m_Colors;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (UnityEngine.UI.Button)+64]");
		_highlightedColor = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (UnityEngine.UI.Button)+74]");
		_pressedColor = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (UnityEngine.UI.Button)+A4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (UnityEngine.UI.Button)+84]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (UnityEngine.UI.Button)+94]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (UnityEngine.UI.Button)+64]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (UnityEngine.UI.Button)+74]");
		_ = 0;
		_commentButtonColors = ((Selectable)commentButton).m_Colors;
	}

	public void ShowComment(CommentEvent commentEvent)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0048: Expected O, but got I
		//IL_0050: Expected I, but got O
		//IL_0088: Expected I, but got O
		//IL_009b: Expected F4, but got I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		_currentComment = commentEvent;
		object obj = this + 424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		DisableCommentButtonColors();
		TextMeshProExtensions.FixArabic(_commentTextMeshProUGUI, commentEvent.<Comment>k__BackingField);
		DOTweenAnimation commentPreviewAnimation = _commentPreviewAnimation;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)568;
		nint num = (nint)commentPreviewAnimation;
		commentPreviewAnimation.DOPlayForward();
		int num2 = EventsExtensions.ToDuration(commentEvent.<CommentDuration>k__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		Coroutine showCommentCoroutine = UIExtensions.WaitForSeconds((MonoBehaviour)(object)_commentPreviewAnimation, num2, action);
		_showCommentCoroutine = showCommentCoroutine;
		object obj4 = this + 584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private unsafe void DisableCommentButtonColors()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0109: Expected O, but got I4
		//IL_00ce: Expected O, but got Ref
		//IL_017d: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1832;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81AA]");
		object obj2 = (nint)0 & (nint)1;
		Color disabledColor;
		Color disabledColor4;
		if (obj2 != null)
		{
			disabledColor = _disabledColor;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			Color disabledColor2 = _disabledColor;
			Color disabledColor3 = _disabledColor;
			disabledColor4 = _disabledColor;
			if (!flag)
			{
				goto IL_009c;
			}
		}
		else
		{
			_ = 1;
			disabledColor = _disabledColor;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			Color disabledColor2 = _disabledColor;
			Color disabledColor3 = _disabledColor;
			disabledColor4 = _disabledColor;
			if (obj4 != null)
			{
				goto IL_009c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		_ = _disabledColor;
		_ = _disabledColor;
		_commentButtonColors = (ColorBlock)disabledColor4;
		Selectable commentButton = _commentButton;
		bool flag3 = (object)_commentButton == null;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00bf;
		IL_009c:
		_commentButtonColors = (ColorBlock)disabledColor;
		commentButton = _commentButton;
		goto IL_00bf;
		IL_00bf:
		object obj6 = default(object);
		commentButton.colors = (ColorBlock)(&obj6);
	}

	private unsafe void EnableCommentButtonColors()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f9: Expected O, but got I4
		//IL_00be: Expected O, but got Ref
		//IL_0159: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1832;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81AB]");
		object obj2 = (nint)0 & (nint)1;
		Color normalColor;
		Color normalColor2;
		if (obj2 != null)
		{
			normalColor = _normalColor;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			normalColor2 = _normalColor;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			normalColor = _normalColor;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			normalColor2 = _normalColor;
			if (obj4 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		_commentButtonColors = (ColorBlock)normalColor2;
		_ = _highlightedColor;
		_ = _pressedColor;
		Selectable commentButton = _commentButton;
		bool flag3 = (object)_commentButton == null;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00af;
		IL_0088:
		_commentButtonColors = (ColorBlock)normalColor;
		_ = _highlightedColor;
		_ = _pressedColor;
		commentButton = _commentButton;
		goto IL_00af;
		IL_00af:
		object obj6 = default(object);
		commentButton.colors = (ColorBlock)(&obj6);
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_013d: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01c3: Expected O, but got I4
		//IL_016b: Expected O, but got I
		//IL_0185: Expected O, but got I4
		//IL_00f2: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81AC]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45F0]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_0193;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v15+B8]");
		object obj7 = (nint)0 + (nint)80;
		obj7 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetupButtons();
		return;
		IL_01d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj;
		goto IL_00dc;
		IL_00a7:
		obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = obj8;
		if (!flag3)
		{
			goto IL_00dc;
		}
		goto IL_01d9;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45F0]");
		object obj10 = (nint)0 & (nint)1;
		if (obj10 != null)
		{
			goto IL_00a7;
		}
		goto IL_0193;
		IL_0193:
		_ = 1;
		obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		obj9 = obj8;
		if (obj11 != null)
		{
			goto IL_00dc;
		}
		goto IL_01d9;
	}

	private void SetupButtons()
	{
		SetupPlayPauseButton();
		SetupPreviousButton();
		SetupNextButton();
		SetupSpeedButton();
		SetupControlRoundsPanelButton();
		SetupCloseRoundPanelButton();
		SetupSheraButton();
		SetupAklasButtons();
		SetupRoundsButtons();
		SetupMoreButtonsAnimation();
		SetupMoreButton();
		InitializeCommentButtonColor();
		SetupCommentButton();
		SetupUnHideCardsButton();
		SetupHidePanelButton();
		SetupCommentViewerButton();
		SetupAddCommentButton();
		SetupBackCommentButton();
		SetupEditCommentButton();
		SetupDeleteCommentButton();
	}

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0109: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0129: Expected O, but got I
		//IL_0153: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_006e: Expected I, but got O
		//IL_007f: Expected O, but got I
		//IL_00ab: Expected I, but got O
		//IL_00bc: Expected O, but got I
		//IL_00e8: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)600;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		CardGame cardGame = default(CardGame);
		_cardGame = cardGame;
		object obj7 = this + 592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		object obj8 = (nint)0 + (nint)616;
		_cardGame.OnGameInitialized += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj8);
		object obj9 = (nint)0 + (nint)608;
		_cardGame.OnGameStateUpdated += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj9);
		_cardGame.OnRoundStart += action3;
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_025e: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_005d: Expected I, but got O
		//IL_006e: Expected O, but got I
		//IL_009a: Expected I, but got O
		//IL_00ea: Expected O, but got I
		//IL_00f6: Expected O, but got I
		//IL_0125: Expected I, but got O
		//IL_017f: Expected I, but got O
		//IL_01d9: Expected I, but got O
		//IL_0233: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)600;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)616;
		_cardGame.OnGameInitialized -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj3);
		object obj4 = (nint)0 + (nint)608;
		_cardGame.OnGameStateUpdated -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj4);
		_cardGame.OnRoundStart -= action3;
		OnDisableRoundsButtons();
		OnDisableSheraButton();
		OnDisableAklasButtons();
		List<KPlayer> players = _cardGame.Players;
		object obj5 = (nint)0 + (nint)2880;
		object obj6 = (nint)0 + (nint)624;
		object obj7 = ((List<object>)(object)players).get_Item(0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj6);
		((KPlayer)obj7).OnDidLastAction -= action4;
		List<KPlayer> players2 = _cardGame.Players;
		object obj8 = ((List<object>)(object)players2).get_Item(1);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj6);
		((KPlayer)obj8).OnDidLastAction -= action5;
		List<KPlayer> players3 = _cardGame.Players;
		object obj9 = ((List<object>)(object)players3).get_Item(2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action6 = default(Action);
		action6..ctor(this, (IntPtr)obj6);
		((KPlayer)obj9).OnDidLastAction -= action6;
		List<KPlayer> players4 = _cardGame.Players;
		object obj10 = ((List<object>)(object)players4).get_Item(3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action7 = default(Action);
		action7..ctor(this, (IntPtr)obj6);
		((KPlayer)obj10).OnDidLastAction -= action7;
	}

	private void OnDisableButtons()
	{
		OnDisableRoundsButtons();
		OnDisableSheraButton();
		OnDisableAklasButtons();
	}

	private void OnGameInitialized()
	{
		//IL_003a: Expected O, but got I
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_005a: Expected O, but got I
		//IL_0089: Expected I, but got O
		//IL_00e3: Expected I, but got O
		//IL_013d: Expected I, but got O
		//IL_0197: Expected I, but got O
		//IL_01ea: Expected I4, but got I8
		//IL_0219: Expected O, but got I
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0241: Expected O, but got I4
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0269: Expected O, but got I4
		//IL_02d6: Expected I, but got O
		//IL_02a9: Expected I, but got O
		//IL_0296: Expected F4, but got I4
		_initialized = true;
		_playSlider.value = 0f;
		List<KPlayer> players = _cardGame.Players;
		object obj = (nint)0 + (nint)2880;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)624;
		object obj4 = ((List<object>)(object)players).get_Item(0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		((KPlayer)obj4).OnDidLastAction += action;
		List<KPlayer> players2 = _cardGame.Players;
		object obj5 = ((List<object>)(object)players2).get_Item(1);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj3);
		((KPlayer)obj5).OnDidLastAction += action2;
		List<KPlayer> players3 = _cardGame.Players;
		object obj6 = ((List<object>)(object)players3).get_Item(2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj3);
		((KPlayer)obj6).OnDidLastAction += action3;
		List<KPlayer> players4 = _cardGame.Players;
		object obj7 = ((List<object>)(object)players4).get_Item(3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj3);
		((KPlayer)obj7).OnDidLastAction += action4;
		Action onGameInitialized = _onGameInitialized;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v178.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		Action onRoundStart = _onRoundStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v179.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		HandleAklasSliderButtons(-1);
		HandleReplayPlayerControlButtons();
		Slider playSlider = _playSlider;
		float num = ReplayPlayerSliderTime();
		object obj8 = (nint)0 + (nint)600;
		object obj9 = num & 0x7FFFFFFF;
		bool flag = (nint)obj9 < 2139095040;
		object obj10 = !flag;
		object obj11 = obj9 - 2139095040;
		bool flag2 = obj11 == null;
		object obj12 = !flag2;
		object obj13 = obj10 & obj12;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			num = 0f;
		}
		nint num2 = (nint)playSlider;
		playSlider.value = num;
		UpdateTimeText();
		UpdateRoundText(_roundTextMeshProUGUI);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj8);
		_cardGame.OnGameInitialized -= action5;
	}

	private void OnOnDidLastAction()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0058: Expected O, but got I4
		//IL_0060: Expected I4, but got O
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I4
		//IL_00cf: Expected O, but got I
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0266: Expected O, but got I
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		//IL_03b1: Expected O, but got I4
		//IL_04e9: Expected O, but got I4
		//IL_014b: Expected O, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_02c6: Expected O, but got I
		//IL_0447: Expected O, but got I4
		//IL_03e7: Expected O, but got I
		//IL_0401: Expected O, but got I4
		//IL_056f: Expected O, but got I4
		//IL_0517: Expected O, but got I
		//IL_0531: Expected O, but got I4
		//IL_01b5: Expected O, but got I
		//IL_01c5: Expected O, but got I
		//IL_01e7: Expected O, but got I4
		//IL_0328: Expected O, but got I
		//IL_0338: Expected O, but got I
		//IL_035a: Expected O, but got I4
		//IL_0487: Expected O, but got I
		//IL_0497: Expected O, but got I
		//IL_05a7: Expected O, but got I
		//IL_05b7: Expected O, but got I
		CardGameLastActionInfo lastAction = _cardGame.LastAction;
		object obj = "___# Content push apply failed [{0}]: {1}" + 2656;
		bool flag = ((LastActionInfo)lastAction).<Action>k__BackingField == (string)obj;
		bool flag2 = !flag;
		object obj2 = !flag2;
		int num = (int)obj;
		object obj6;
		object obj8;
		object obj13;
		if (obj2 == null)
		{
			object obj3 = "___# Content push apply failed [{0}]: {1}" + 2664;
			if (((LastActionInfo)lastAction).<Action>k__BackingField == (string)obj3)
			{
				object obj4 = 152993792;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
				object obj5 = (nint)0 & (nint)1;
				if (obj5 != null)
				{
					obj6 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v45+E4]");
					bool flag3 = (nint)0 == 0;
					obj8 = obj6;
					if (!flag3)
					{
						goto IL_0135;
					}
				}
				else
				{
					_ = 1;
					obj6 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v45+E4]");
					bool flag4 = (nint)0 == 0;
					object obj9 = !flag4;
					obj8 = obj6;
					if (obj9 != null)
					{
						goto IL_0135;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
				object obj10 = (nint)0 & (nint)1;
				bool flag5 = obj10 == null;
				object obj11 = !flag5;
				obj6 = obj8;
				if (obj11 != null)
				{
					goto IL_0170;
				}
				goto IL_0417;
			}
			object obj12 = "___# Content push apply failed [{0}]: {1}" + 2680;
			if (!(((LastActionInfo)lastAction).<Action>k__BackingField == (string)obj12))
			{
				return;
			}
			obj13 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
			object obj14 = (nint)0 & (nint)1;
			if (obj14 != null)
			{
				object obj15 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v25+E4]");
				if ((nint)0 != 0)
				{
					goto IL_02b0;
				}
			}
			else
			{
				_ = 1;
				object obj15 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v25+E4]");
				bool flag6 = (nint)0 == 0;
				object obj16 = !flag6;
				if (obj16 != null)
				{
					goto IL_02b0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
			object obj17 = (nint)0 & (nint)1;
			bool flag7 = obj17 == null;
			object obj18 = !flag7;
			if (obj18 != null)
			{
				goto IL_02e3;
			}
			goto IL_053f;
		}
		goto IL_05d2;
		IL_0170:
		object obj19 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v51+E4]");
		bool flag8 = (nint)0 == 0;
		object obj20 = obj19;
		if (!flag8)
		{
			goto IL_01a5;
		}
		goto IL_0465;
		IL_0417:
		_ = 1;
		obj19 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v51+E4]");
		bool flag9 = (nint)0 == 0;
		object obj21 = !flag9;
		obj20 = obj19;
		obj6 = obj8;
		if (obj21 != null)
		{
			goto IL_01a5;
		}
		goto IL_0465;
		IL_049c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v33+C8]");
		num = (int)((nint)0 + (nint)1);
		goto IL_05e0;
		IL_05d9:
		throw new NullReferenceException();
		IL_05d2:
		HandleReplayPlayerControlButtons();
		return;
		IL_05e0:
		HandleAklasSliderButtons(num);
		goto IL_05d2;
		IL_02b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj22 = (nint)0 & (nint)1;
		if (obj22 != null)
		{
			goto IL_02e3;
		}
		goto IL_053f;
		IL_053f:
		_ = 1;
		object obj23 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v31+E4]");
		bool flag10 = (nint)0 == 0;
		object obj24 = !flag10;
		object obj25 = obj23;
		if (obj24 != null)
		{
			goto IL_0318;
		}
		goto IL_0585;
		IL_02e3:
		obj23 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v31+E4]");
		bool flag11 = (nint)0 == 0;
		obj25 = obj23;
		if (!flag11)
		{
			goto IL_0318;
		}
		goto IL_0585;
		IL_0585:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj26 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v19+B8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v15+18]");
		object obj28 = 0;
		goto IL_05bc;
		IL_0318:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v31+B8]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v25+18]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v25+18]");
		bool flag12 = (nint)0 == 0;
		object obj30 = !flag12;
		if (obj30 != null)
		{
			goto IL_05bc;
		}
		goto IL_05d9;
		IL_05bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v13+C8]");
		num = 0;
		goto IL_05e0;
		IL_0135:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj31 = (nint)0 & (nint)1;
		bool flag13 = obj31 == null;
		obj8 = obj6;
		if (!flag13)
		{
			goto IL_0170;
		}
		goto IL_0417;
		IL_01a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v51+B8]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v46+18]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v46+18]");
		bool flag14 = (nint)0 == 0;
		object obj34 = !flag14;
		if (obj34 != null)
		{
			goto IL_049c;
		}
		goto IL_05d9;
		IL_0465:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj35 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v39+B8]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v36+18]");
		obj33 = 0;
		goto IL_049c;
	}

	private void OnGameRoundStart()
	{
		//IL_0031: Expected I4, but got I8
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_007c: Expected O, but got I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00a4: Expected O, but got I4
		//IL_00d1: Expected F4, but got I4
		if (_initialized)
		{
			HandleAklasSliderButtons(-1);
			HandleReplayPlayerControlButtons();
			Slider playSlider = _playSlider;
			float num = ReplayPlayerSliderTime();
			object obj = num & 0x7FFFFFFF;
			bool flag = (nint)obj < 2139095040;
			object obj2 = !flag;
			object obj3 = obj - 2139095040;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			object obj5 = obj2 & obj4;
			object obj6 = ~obj5;
			if (obj6 == null)
			{
				num = 0f;
			}
			playSlider.value = num;
			UpdateTimeText();
			UpdateRoundText(_roundTextMeshProUGUI);
			Action onRoundStart = _onRoundStart;
			IntPtr invoke_impl = ((Delegate)onRoundStart).invoke_impl;
			IntPtr method_code = ((Delegate)onRoundStart).method_code;
			IntPtr method = ((Delegate)onRoundStart).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v33 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void OnGameStateUpdated()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_008a: Expected O, but got I4
		//IL_00b7: Expected F4, but got I4
		if (_initialized)
		{
			Slider playSlider = _playSlider;
			float num = ReplayPlayerSliderTime();
			object obj = num & 0x7FFFFFFF;
			bool flag = (nint)obj < 2139095040;
			object obj2 = !flag;
			object obj3 = obj - 2139095040;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			object obj5 = obj2 & obj4;
			object obj6 = ~obj5;
			if (obj6 == null)
			{
				num = 0f;
			}
			playSlider.value = num;
			UpdateTimeText();
			UpdateRoundText(_roundTextMeshProUGUI);
		}
	}

	private void UpdatePlayer()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0040: Expected O, but got I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0068: Expected O, but got I4
		//IL_0095: Expected F4, but got I4
		Slider playSlider = _playSlider;
		float num = ReplayPlayerSliderTime();
		object obj = num & 0x7FFFFFFF;
		bool flag = (nint)obj < 2139095040;
		object obj2 = !flag;
		object obj3 = obj - 2139095040;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			num = 0f;
		}
		playSlider.value = num;
		UpdateTimeText();
		UpdateRoundText(_roundTextMeshProUGUI);
	}

	public ReplayPlayer()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0049: Expected O, but got I
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2344;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 3088;
		object obj3 = typeof(List<AdaptivePerformanceScaler>) + 32;
		object obj4 = (nint)0 + (nint)584;
		object obj5 = typeof(List<AdaptivePerformanceScaler>) + 3320;
		object obj6 = typeof(List<AdaptivePerformanceScaler>) + 1800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		StringBuilder stringBuilder = default(StringBuilder);
		stringBuilder..ctor();
		object obj7 = this + 80;
		obj7 = stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj8 = this + 168;
		obj8 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor(8);
		object obj9 = this + 208;
		obj9 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<float> list3 = default(List<float>);
		list3..ctor();
		object obj10 = this + 216;
		obj10 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<int> list4 = default(List<int>);
		list4..ctor();
		object obj11 = this + 224;
		obj11 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <SetupPreviousButton>b__5_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_01d9: Expected O, but got I4
		//IL_00a2: Expected O, but got I
		//IL_0277: Expected O, but got I4
		//IL_021f: Expected O, but got I
		//IL_0239: Expected O, but got I4
		//IL_0102: Expected O, but got I
		//IL_02fd: Expected O, but got I4
		//IL_02a5: Expected O, but got I
		//IL_02bf: Expected O, but got I4
		//IL_0164: Expected O, but got I
		//IL_0174: Expected O, but got I
		//IL_0196: Expected O, but got I4
		//IL_0335: Expected O, but got I
		//IL_0345: Expected O, but got I
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_039c: Expected O, but got I4
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_03c4: Expected O, but got I4
		//IL_03f1: Expected F4, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81FB]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v37+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v37+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		GameReplayManager.GoToPreviousAkla();
		HandleReplayPlayerControlButtons();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
		object obj6 = (nint)0 & (nint)1;
		bool flag3 = obj6 == null;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			goto IL_00bf;
		}
		goto IL_0247;
		IL_034a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v3+C8]");
		HandleAklasSliderButtons(0);
		Slider playSlider = _playSlider;
		float num = ReplayPlayerSliderTime();
		object obj8 = num & 0x7FFFFFFF;
		bool flag4 = (nint)obj8 < 2139095040;
		object obj9 = !flag4;
		object obj10 = obj8 - 2139095040;
		bool flag5 = obj10 == null;
		object obj11 = !flag5;
		object obj12 = obj9 & obj11;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			num = 0f;
		}
		playSlider.value = num;
		UpdateTimeText();
		UpdateRoundText(_roundTextMeshProUGUI);
		return;
		IL_0154:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v31+B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v23+18]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v23+18]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_034a;
		IL_0313:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v11+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v8+18]");
		obj15 = 0;
		goto IL_034a;
		IL_007c:
		GameReplayManager.GoToPreviousAkla();
		HandleReplayPlayerControlButtons();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
		object obj19 = (nint)0 & (nint)1;
		if (obj19 != null)
		{
			goto IL_00bf;
		}
		goto IL_0247;
		IL_0247:
		_ = 1;
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v17+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 != null)
		{
			goto IL_00ec;
		}
		goto IL_0285;
		IL_00bf:
		obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v17+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00ec;
		}
		goto IL_0285;
		IL_0285:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj22 = (nint)0 & (nint)1;
		bool flag8 = obj22 == null;
		object obj23 = !flag8;
		if (obj23 != null)
		{
			goto IL_011f;
		}
		goto IL_02cd;
		IL_00ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj24 = (nint)0 & (nint)1;
		if (obj24 != null)
		{
			goto IL_011f;
		}
		goto IL_02cd;
		IL_02cd:
		_ = 1;
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v31+E4]");
		bool flag9 = (nint)0 == 0;
		object obj26 = !flag9;
		object obj27 = obj25;
		if (obj26 != null)
		{
			goto IL_0154;
		}
		goto IL_0313;
		IL_011f:
		obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v31+E4]");
		bool flag10 = (nint)0 == 0;
		obj27 = obj25;
		if (!flag10)
		{
			goto IL_0154;
		}
		goto IL_0313;
	}

	private void <SetupNextButton>b__6_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_01d9: Expected O, but got I4
		//IL_00a2: Expected O, but got I
		//IL_0277: Expected O, but got I4
		//IL_021f: Expected O, but got I
		//IL_0239: Expected O, but got I4
		//IL_0102: Expected O, but got I
		//IL_02fd: Expected O, but got I4
		//IL_02a5: Expected O, but got I
		//IL_02bf: Expected O, but got I4
		//IL_0164: Expected O, but got I
		//IL_0174: Expected O, but got I
		//IL_0196: Expected O, but got I4
		//IL_0335: Expected O, but got I
		//IL_0345: Expected O, but got I
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_03aa: Expected O, but got I4
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03d2: Expected O, but got I4
		//IL_03ff: Expected F4, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81FC]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v37+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v37+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		GameReplayManager.GoToNextAkla();
		HandleReplayPlayerControlButtons();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
		object obj6 = (nint)0 & (nint)1;
		bool flag3 = obj6 == null;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			goto IL_00bf;
		}
		goto IL_0247;
		IL_034a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v3+C8]");
		int index = (int)((nint)0 + (nint)1);
		HandleAklasSliderButtons(index);
		Slider playSlider = _playSlider;
		float num = ReplayPlayerSliderTime();
		object obj8 = num & 0x7FFFFFFF;
		bool flag4 = (nint)obj8 < 2139095040;
		object obj9 = !flag4;
		object obj10 = obj8 - 2139095040;
		bool flag5 = obj10 == null;
		object obj11 = !flag5;
		object obj12 = obj9 & obj11;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			num = 0f;
		}
		playSlider.value = num;
		UpdateTimeText();
		UpdateRoundText(_roundTextMeshProUGUI);
		return;
		IL_0154:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v31+B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v24+18]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v24+18]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_034a;
		IL_0313:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v11+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v9+18]");
		obj15 = 0;
		goto IL_034a;
		IL_007c:
		GameReplayManager.GoToNextAkla();
		HandleReplayPlayerControlButtons();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81F9]");
		object obj19 = (nint)0 & (nint)1;
		if (obj19 != null)
		{
			goto IL_00bf;
		}
		goto IL_0247;
		IL_0247:
		_ = 1;
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v17+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 != null)
		{
			goto IL_00ec;
		}
		goto IL_0285;
		IL_00bf:
		obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v17+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00ec;
		}
		goto IL_0285;
		IL_0285:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj22 = (nint)0 & (nint)1;
		bool flag8 = obj22 == null;
		object obj23 = !flag8;
		if (obj23 != null)
		{
			goto IL_011f;
		}
		goto IL_02cd;
		IL_00ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45ED]");
		object obj24 = (nint)0 & (nint)1;
		if (obj24 != null)
		{
			goto IL_011f;
		}
		goto IL_02cd;
		IL_02cd:
		_ = 1;
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v31+E4]");
		bool flag9 = (nint)0 == 0;
		object obj26 = !flag9;
		object obj27 = obj25;
		if (obj26 != null)
		{
			goto IL_0154;
		}
		goto IL_0313;
		IL_011f:
		obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v31+E4]");
		bool flag10 = (nint)0 == 0;
		obj27 = obj25;
		if (!flag10)
		{
			goto IL_0154;
		}
		goto IL_0313;
	}

	private void <SetupMoreButton>b__62_0()
	{
		ToggleMoreButtons();
	}

	private void <SetupMoreButton>b__62_1()
	{
		//IL_0011: Expected O, but got I
		//IL_0055: Expected O, but got I
		//IL_0090: Expected I, but got O
		//IL_00a0: Expected O, but got I
		//IL_00b0: Expected O, but got I
		while (true)
		{
			_moreButtonsOpen = false;
			Sequence moreButtonsSequence = _moreButtonsSequence;
			object obj = (nint)0 + (nint)2408;
			moreButtonsSequence.isBackwards = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
			UIExtensions.Disable(_blocker);
			_commentInputAnimation.DOPlayBackwards();
			object text = (nint)0 + (nint)2000;
			_commentInputField.text = (string)text;
			_commentDurationToggleGroupIndexer.SelectedIndex = 1;
			DOTweenAnimation commentPreviewAnimation = _commentPreviewAnimation;
			nint num = (nint)commentPreviewAnimation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v11 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+188]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v11 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+190]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v76 @ X2_v4 (should have been resolved before IL gen)");
		}
	}

	private void <SetupCommentButton>b__73_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0172: Expected O, but got I4
		//IL_00a8: Expected O, but got I4
		//IL_01bc: Expected O, but got I4
		//IL_01c5: Expected O, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_0103: Expected O, but got I4
		//IL_0133: Expected O, but got I4
		//IL_0219: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E81FD]");
		object obj2 = (nint)0 & (nint)1;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (obj2 != null)
		{
			trackEvent = TrackerLibrary.ShowCommentClicked();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v10+E4]");
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
			trackEvent = TrackerLibrary.ShowCommentClicked();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v10+E4]");
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
		bool flag3 = _currentComment == null;
		object obj5 = !flag3;
		object obj6 = 0;
		if (obj5 != null)
		{
			goto IL_00b6;
		}
		goto IL_01d3;
		IL_00b6:
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = "Cannot populate JSON object onto type '{0}'." + 3912;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v32+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show((string)message, (Vector2)0, 0f);
		return;
		IL_01d3:
		_addEditObjectToggler.ToggleManual(isON: false);
		_backDeleteObjectToggler.ToggleManual(isON: false);
		_commentInputAnimation.DOPlayForward();
		_moreButtonsOpen = false;
		Sequence moreButtonsSequence = _moreButtonsSequence;
		object obj10 = (nint)0 + (nint)2408;
		moreButtonsSequence.isBackwards = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		UIExtensions.Disable(_blocker);
		UIExtensions.Enable(_blocker);
		return;
		IL_0085:
		Tracker.DesignEvent(trackEvent);
		bool flag5 = _currentComment == null;
		obj6 = 0;
		if (!flag5)
		{
			goto IL_00b6;
		}
		goto IL_01d3;
	}

	private void <SetupUnHideCardsButton>b__75_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b8: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		//IL_0083: Expected O, but got I4
		//IL_0133: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		bool othersCardsHidden = (byte)((_othersCardsHidden ? 1u : 0u) ^ 1u) != 0;
		_othersCardsHidden = othersCardsHidden;
		object obj2 = obj;
		if (~(_othersCardsHidden ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GameReplayManager.ShowOthersCards();
			Button hideCardsButton = _hideCardsButton;
			bool flag2 = (object)_hideCardsButton == null;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v14+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GameReplayManager.HideOthersCards();
			Button hideCardsButton = _hideCardsButton;
		}
		object obj6 = (nint)0 + (nint)88;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		bool isON = !_othersCardsHidden;
		BaseToggler baseToggler = default(BaseToggler);
		baseToggler.ToggleManual(isON);
		_moreButtonsOpen = false;
		Sequence moreButtonsSequence = _moreButtonsSequence;
		object obj7 = (nint)0 + (nint)2408;
		moreButtonsSequence.isBackwards = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		UIExtensions.Disable(_blocker);
	}

	private void <SetupHidePanelButton>b__78_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0192: Expected O, but got I4
		//IL_008e: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_009f: Expected I, but got O
		//IL_00c4: Expected O, but got I
		//IL_0031: Expected O, but got I4
		//IL_003a: Expected O, but got I4
		//IL_0042: Expected I, but got O
		//IL_0072: Expected O, but got I4
		//IL_00f3: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		ITrackEvent trackEvent = TrackerLibrary.ToggleShowControlPanelClicked(_panelHidden);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		bool panelHidden = (byte)((_panelHidden ? 1u : 0u) ^ 1u) != 0;
		_panelHidden = panelHidden;
		DOTweenAnimation replayPlayerAnimation = _replayPlayerAnimation;
		if (~(_panelHidden ? 1u : 0u) == 0)
		{
			object obj4 = 400;
			object obj5 = 392;
			nint num = (nint)replayPlayerAnimation;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ X10_v4 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+v68 @ X9_v10] (should have been resolved before IL gen)");
			Button hidePanelButton = _hidePanelButton;
			bool flag2 = (object)_hidePanelButton == null;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			object obj7 = 416;
			object obj8 = 408;
			nint num2 = (nint)replayPlayerAnimation;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ X10_v3 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+v114 @ X9_v8] (should have been resolved before IL gen)");
			Button hidePanelButton = _hidePanelButton;
		}
		object obj9 = (nint)0 + (nint)88;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		BaseToggler baseToggler = default(BaseToggler);
		baseToggler.ToggleManual(_panelHidden);
		_moreButtonsOpen = false;
		Sequence moreButtonsSequence = _moreButtonsSequence;
		object obj10 = (nint)0 + (nint)2408;
		moreButtonsSequence.isBackwards = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		UIExtensions.Disable(_blocker);
		_roundsPanelOpen = false;
		_roundsPanelAnimation.DOPlayBackwards();
		_closeRoundsPanelButtonAnimation.DOPlayBackwards();
		UIExtensions.Disable(_roundsPanelCanvasGroup);
	}

	private void <SetupCommentViewerButton>b__82_0()
	{
		//IL_0021: Expected O, but got I
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		//IL_00a7: Expected O, but got I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_018d: Expected O, but got I4
		_commentInputAnimation.DOPlayForward();
		_moreButtonsOpen = false;
		Sequence moreButtonsSequence = _moreButtonsSequence;
		object obj = (nint)0 + (nint)2408;
		moreButtonsSequence.isBackwards = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		UIExtensions.Disable(_blocker);
		DOTweenAnimation commentPreviewAnimation = _commentPreviewAnimation;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		nint num = (nint)commentPreviewAnimation;
		commentPreviewAnimation.DOPlayBackwards();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GameReplayManager.Pause(pause: true);
		UIExtensions.Enable(_blocker);
		_addEditObjectToggler.ToggleManual(isON: true);
		_backDeleteObjectToggler.ToggleManual(isON: true);
		CommentEvent currentComment = _currentComment;
		_commentInputField.text = currentComment.<Comment>k__BackingField;
		CommentEvent currentComment2 = _currentComment;
		_commentDurationToggleGroupIndexer.SelectedIndex = (int)currentComment2.<CommentDuration>k__BackingField;
		if (_showCommentCoroutine != null)
		{
			object obj5 = this + 584;
			((MonoBehaviour)(object)_commentPreviewAnimation).StopCoroutine(_showCommentCoroutine);
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private void <SetupAddCommentButton>b__94_0()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_012f: Expected O, but got I4
		//IL_0138: Expected O, but got I4
		//IL_006c: Expected O, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00b8: Expected O, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00f7: Expected O, but got I4
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_01a2: Expected O, but got I4
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_01cb: Expected O, but got I
		//IL_0210: Expected O, but got I
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_02e7: Expected O, but got I
		InputField commentInputField = _commentInputField;
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag = StringsExtensions.IsNullOrEmpty(commentInputField.m_Text);
			bool flag2 = !flag;
			object obj3 = 0;
			if (!flag2)
			{
				goto IL_007a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = StringsExtensions.IsNullOrEmpty(commentInputField.m_Text);
			bool flag4 = !flag3;
			object obj4 = !flag4;
			object obj3 = 0;
			if (obj4 != null)
			{
				goto IL_007a;
			}
		}
		int selectedIndex = _commentDurationToggleGroupIndexer.SelectedIndex;
		InputField commentInputField2 = _commentInputField;
		object obj5 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CommentEvent currentComment = GameReplayManager.AddComment(commentInputField2.m_Text, (CommentDuration)selectedIndex);
		_currentComment = currentComment;
		object obj8 = this + 424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object text = (nint)0 + (nint)2000;
		_commentInputField.text = (string)text;
		_commentDurationToggleGroupIndexer.SelectedIndex = 1;
		_commentInputAnimation.DOPlayBackwards();
		_moreButtonsOpen = false;
		Sequence moreButtonsSequence = _moreButtonsSequence;
		object obj9 = (nint)0 + (nint)2408;
		moreButtonsSequence.isBackwards = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		UIExtensions.Disable(_blocker);
		ShowComment(_currentComment);
		object obj10 = typeof(RegisteredWaitHandle) + 616;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v20+B8]");
		object obj12 = 0;
		object obj13 = obj12;
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v135 @ X8_v22+18] (should have been resolved before IL gen)");
		}
		UIExtensions.Disable(_blocker);
		return;
		IL_007a:
		object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v44+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "Picking audio files is not supported on iOS" + 528;
		Toast.Show((string)message, (Vector2)0, 0f);
	}

	private void <SetupBackCommentButton>b__97_0()
	{
		//IL_001c: Expected O, but got I
		_commentInputAnimation.DOPlayBackwards();
		object text = (nint)0 + (nint)2000;
		_commentInputField.text = (string)text;
		_commentDurationToggleGroupIndexer.SelectedIndex = 1;
		UIExtensions.Disable(_blocker);
	}

	private void <SetupEditCommentButton>b__98_0()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00cb: Expected O, but got I
		InputField commentInputField = _commentInputField;
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		int selectedIndex = _commentDurationToggleGroupIndexer.SelectedIndex;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CommentEvent currentComment = GameReplayManager.EditComment(_currentComment, commentInputField.m_Text, (CommentDuration)selectedIndex);
		_currentComment = currentComment;
		object obj4 = this + 424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_commentInputAnimation.DOPlayBackwards();
		object text = (nint)0 + (nint)2000;
		_commentInputField.text = (string)text;
		_commentDurationToggleGroupIndexer.SelectedIndex = 1;
		ShowComment(_currentComment);
		UIExtensions.Disable(_blocker);
	}

	private void <SetupDeleteCommentButton>b__99_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00f7: Expected O, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0065: Expected O, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_011d: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GameReplayManager.DeleteComment(_currentComment);
		_currentComment = null;
		object obj4 = this + 424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object text = (nint)0 + (nint)2000;
		_commentInputField.text = (string)text;
		_commentDurationToggleGroupIndexer.SelectedIndex = 1;
		_commentInputAnimation.DOPlayBackwards();
		UIExtensions.Disable(_blocker);
		object obj5 = typeof(RegisteredWaitHandle) + 616;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v12+B8]");
		object obj7 = 0;
		object obj8 = obj7;
		if (obj7 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v101 @ X8_v14+18] (should have been resolved before IL gen)");
		}
		EnableCommentButtonColors();
	}

	private void <ShowComment>b__109_0()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		_commentPreviewAnimation.DOPlayBackwards();
		_currentComment = null;
		object obj = this + 424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		EnableCommentButtonColors();
		_showCommentCoroutine = null;
		object obj2 = this + 584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
