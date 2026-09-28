using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ClanLockedLevelPopup : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<GameObject> <>9__35_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Initialize>b__35_0(GameObject e)
		{
			e.SetActive(value: true);
		}
	}

	private sealed class <>c__DisplayClass36_0
	{
		public float startWidth;

		public RectTransform rect;

		internal float <SetPointProgress>b__0()
		{
			return startWidth;
		}

		internal void <SetPointProgress>b__1(float w)
		{
			rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, w);
		}
	}

	private sealed class <>c__DisplayClass37_0
	{
		public ClanLockedLevelPopup <>4__this;

		public float[] thresholds;

		public float start;

		internal void <SetCurrentLevel>b__0()
		{
			//IL_002a: Expected O, but got I4
			//IL_00dd: Expected O, but got I4
			//IL_0145: Invalid comparison between F4 and I4
			//IL_0156: Expected O, but got I4
			//IL_015f: Invalid comparison between F4 and I4
			//IL_0170: Expected O, but got I4
			//IL_0267: Unknown result type (might be due to invalid IL or missing references)
			//IL_026c: Expected O, but got Unknown
			//IL_01cc: Expected O, but got I
			//IL_01f0: Expected O, but got I4
			//IL_023d: Expected O, but got I4
			ClanLockedLevelPopup clanLockedLevelPopup = <>4__this;
			Image levelProgressBar = clanLockedLevelPopup.levelProgressBar;
			object obj = 0;
			while (true)
			{
				ClanLevelProgress[] levels = clanLockedLevelPopup.levels;
				if ((nint)obj >= levels.Length)
				{
					return;
				}
				float[] array = thresholds;
				bool flag = (nint)obj < array.Length;
				object obj2 = !flag;
				if (obj2 != null)
				{
					break;
				}
				object obj3 = (object)array + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X10_v6+20]");
				float num = 0f - start;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X10_v6+20]");
				float num2 = 0f - levelProgressBar.m_FillAmount;
				float num3 = num2 * num;
				bool flag2 = num3 < 0f;
				object obj4 = !flag2;
				bool flag3 = num3 == 0f;
				object obj5 = !flag3;
				object obj6 = obj4 & obj5;
				if (obj6 == null && (nint)obj < clanLockedLevelPopup._currentEmblemTier)
				{
					object obj7 = (object)levels + obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X9_v7+20]");
					ClanLevelProgress clanLevelProgress = (ClanLevelProgress)0;
					bool flag4 = !clanLevelProgress.<IsAchieved>k__BackingField;
					object obj8 = !flag4;
					if (obj8 == null)
					{
						clanLevelProgress.<IsAchieved>k__BackingField = true;
						GameObject gameObject = clanLevelProgress.indicator.gameObject;
						bool flag5 = (object)gameObject == null;
						object obj9 = !flag5;
						if (obj9 == null)
						{
							throw new NullReferenceException();
						}
						gameObject.SetActive(value: true);
						TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(clanLevelProgress.indicator, 1f, 0.5f);
						clanLevelProgress.BounceIcon();
						clanLockedLevelPopup = <>4__this;
					}
				}
				obj++;
			}
			throw new IndexOutOfRangeException();
		}
	}

	private sealed class <SetCurrentLevelDelayed>d__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public ClanLockedLevelPopup <>4__this;

		public float level;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <SetCurrentLevelDelayed>d__46(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0090: Expected I4, but got I8
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Expected O, but got Unknown
			//IL_00ce: Expected O, but got I4
			//IL_0130: Expected O, but got I
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Expected O, but got Unknown
			//IL_014b: Expected O, but got I
			//IL_0036: Expected I4, but got I8
			//IL_0101: Expected I4, but got O
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					<>1__state = -1;
					if ((object)<>4__this == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					<>4__this.SetCurrentLevel(level);
				}
				return <>1__state == 0;
			}
			<>1__state = -1;
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1264;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
			object obj4 = 0;
			object obj5 = this + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v5+10]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			return <>1__state == 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)3960;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private const string NEXT_LEVEL_KEY = "clan_locked_next_level";

	private const string NEXT_REWARD_TITLE_KEY = "clan_locked_next_reward_title";

	private const string LEVEL_ORDINAL_KEY = "ORDINAL_LEVELS";

	private static readonly string[] LEVEL_NAME_KEYS;

	private static readonly string[] LEVEL_NAME_CLAN_KEYS;

	private ClanTierIcon header;

	private GameObject levelContainer;

	private ClanLevelProgress[] levels;

	private Image levelProgressBar;

	private TextMeshProUGUI nextLevelText;

	private TextMeshProUGUI nextRewardTitle;

	private TextMeshProUGUI targetLevelText;

	private GameObject targetLevelIcon;

	private Button upgradeButton;

	private float fillDuration = 0.5f;

	private Image pointProgressBar;

	private TextMeshProUGUI pointText;

	private float pointPadding;

	private ClanLogoPreviewer clanPreviewer;

	private GameObject clanPreviewerContainer;

	private GameObject[] effects;

	private ParticleSystem particlesEffect;

	private ParticleSystem shineEffect;

	private Color[] particleColors;

	private PopupUI popup;

	private int _currentEmblemTier;

	private float _initialFill;

	private float _initialPointWidth;

	private int _targetTier = -1;

	private static readonly WaitForEndOfFrame EndOfFrameWait;

	private Coroutine _fillRoutine;

	private ClanModel _clan;

	private void Awake()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I4
		//IL_0113: Expected I, but got O
		//IL_013d: Expected O, but got I4
		Image image = levelProgressBar;
		_initialFill = image.m_FillAmount;
		RectTransform rectTransform = pointProgressBar.rectTransform;
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)1192;
		object obj4 = typeof(RegisteredWaitHandle) + 56;
		Rect rect = rectTransform.rect;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float initialPointWidth = default(float);
		_initialPointWidth = initialPointWidth;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1192;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action;
	}

	private void OnConfigChanged()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_00b9: Expected I4, but got O
		//IL_00b9: Expected O, but got I
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		object obj = this + 216;
		if (obj != null && base.isActiveAndEnabled)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj2 = this + 204;
			object obj3 = obj2 & 0x80000000L;
			if (obj3 != null)
			{
				obj2 = _clan + 72;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4-AC]");
			((ClanTierIcon)0).SetTier((int)obj2);
			SetupPoints(_clan);
		}
	}

	public void Initialize(ClanModel clan, int tier = -1)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_002c: Expected O, but got I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_008b: Expected O, but got I4
		//IL_0118: Expected O, but got I
		//IL_00ce: Expected O, but got I
		//IL_00e8: Expected O, but got I4
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0309: Expected O, but got I
		//IL_0319: Expected O, but got I
		//IL_0329: Expected O, but got I
		//IL_034b: Expected O, but got I4
		//IL_0363: Expected O, but got I
		//IL_015c: Expected O, but got I4
		//IL_0176: Expected O, but got I4
		//IL_027e: Expected O, but got I
		//IL_028e: Expected O, but got I
		//IL_029e: Expected O, but got I
		//IL_02c0: Expected O, but got I4
		//IL_0393: Expected O, but got I4
		//IL_05f4: Expected O, but got I4
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected I4, but got Unknown
		//IL_0194: Expected O, but got I4
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected I4, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_0500: Expected O, but got I4
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		//IL_0661: Expected O, but got I
		//IL_0672: Expected I, but got O
		//IL_0690: Expected O, but got I
		//IL_02e6: Expected O, but got I
		//IL_0529: Expected O, but got I
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_03c3: Expected O, but got I
		//IL_0562: Expected O, but got I
		//IL_0570: Expected I, but got O
		//IL_0491: Expected O, but got I4
		//IL_06bc: Expected I4, but got O
		//IL_06bc: Expected O, but got I
		if (clan == null)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = this + 204;
		obj2 = tier;
		object obj3 = clan + 72;
		bool flag = tier < 0;
		int num = tier ^ tier;
		int num2 = tier & num;
		bool flag2 = num2 < 0;
		bool flag3 = flag == flag2;
		object obj4 = !flag3;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			object obj6 = obj3;
		}
		else
		{
			object obj6 = obj2;
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X24_v3-6C]");
			bool flag4 = (UnityEngine.Object)0 != null;
			bool flag5 = !flag4;
			object obj8 = !flag5;
			if (obj8 != null)
			{
				goto IL_013a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X24_v3-6C]");
			if ((UnityEngine.Object)0 != null)
			{
				goto IL_013a;
			}
		}
		goto IL_0212;
		IL_0212:
		object obj9 = typeof(CardUtils.<>c) + 904;
		bool active = (byte)(_targetTier >> 31) != 0;
		levelContainer.SetActive(active);
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v24+E4]");
		object obj12;
		Action<object> action;
		object obj14;
		object obj11;
		if ((nint)0 != 0)
		{
			obj11 = (nint)0 + (nint)2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v24+B8]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v27+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v27+8]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				obj14 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v27+8]");
				Action<object> action2 = (Action<object>)0;
				goto IL_0371;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj9;
			obj14 = (nint)0 + (nint)2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v24+B8]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v27+8]");
			Action<object> action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v27+8]");
			bool flag7 = (nint)0 == 0;
			object obj15 = !flag7;
			obj11 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v27+8]");
			action = (Action<object>)0;
			if (obj15 == null)
			{
				goto IL_0371;
			}
		}
		goto IL_0613;
		IL_0613:
		ArraysExtensions.ForEach(effects, action);
		ResetProgress();
		PopupUI popupUI = popup;
		popupUI.partOfNavigation = true;
		popupUI.PopFromCenter();
		if (clan.Logo != null)
		{
			object obj16 = this + 216;
			obj16 = clan;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag8 = _targetTier < 0;
			int num3 = _targetTier ^ _targetTier;
			int num4 = _targetTier & num3;
			bool flag9 = num4 < 0;
			bool flag10 = flag8 == flag9;
			object obj17 = !flag10;
			object obj18 = ~obj17;
			object obj19 = ((obj18 != null) ? obj2 : obj3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X21_v8-B8]");
			((ClanTierIcon)0).SetTier((int)obj19);
			SetupPoints(clan);
			return;
		}
		object obj20 = typeof(Queue<string>) + 728;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v12+E4]");
		bool flag11 = (nint)0 == 0;
		object obj22 = !flag11;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj23 = (nint)0 + (nint)1976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj24 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = (nint)0 + (nint)1184;
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj25);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.GetClan(clan.ClanId, action3);
		return;
		IL_013a:
		GameObject gameObject = upgradeButton.gameObject;
		object obj26 = tier + 1;
		bool flag12 = obj26 == null;
		object obj27 = !flag12;
		bool flag13;
		bool flag14;
		bool flag15;
		if (obj27 == null)
		{
			object obj28 = _currentEmblemTier - 1;
			flag13 = (nint)obj28 < 0;
			flag14 = obj28 == null;
			int num5 = _currentEmblemTier ^ 1;
			int num6 = _currentEmblemTier ^ obj28;
			int num7 = num5 & num6;
			flag15 = num7 < 0;
		}
		else
		{
			flag15 = false;
			flag14 = true;
			flag13 = false;
		}
		bool flag16 = flag13 == flag15;
		object obj29 = !flag14;
		bool active2 = (byte)((flag16 & obj29) ? 1 : 0) != 0;
		gameObject.SetActive(active2);
		goto IL_0212;
		IL_0371:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v24+E4]");
		bool flag17 = (nint)0 == 0;
		object obj30 = !flag17;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj31 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v33+B8]");
			obj12 = 0;
		}
		object obj32 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj33 = (nint)0 + (nint)3928;
		Action<object> action4 = default(Action<object>);
		action4..ctor(obj12, (IntPtr)obj33);
		object obj34 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v32+B8]");
		object obj35 = (nint)0 + (nint)8;
		obj35 = action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = obj14;
		action = action4;
		goto IL_0613;
	}

	public void SetPointProgress(float value)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_012a: Expected O, but got I4
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_0184: Expected O, but got I
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01a4: Expected O, but got I
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01c4: Expected O, but got I
		//IL_01d0: Expected O, but got I
		//IL_01f8: Expected O, but got I
		//IL_021c: Expected I, but got O
		//IL_023c: Expected I, but got O
		//IL_026b: Expected O, but got I4
		//IL_0335: Invalid comparison between F4 and I4
		//IL_0344: Invalid comparison between F4 and I4
		//IL_035c: Expected O, but got F8
		//IL_0369: Expected O, but got F4
		//IL_039e: Expected O, but got I4
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03cb: Invalid comparison between F4 and I4
		//IL_040d: Invalid comparison between F4 and I4
		//IL_02b0: Expected F4, but got I4
		//IL_02be: Expected F4, but got I4
		object obj = typeof(CardUtils.<>c) + 912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if ((object)pointProgressBar != null)
		{
			RectTransform rectTransform = pointProgressBar.rectTransform;
			if (obj2 != null)
			{
				object obj3 = obj2 + 24;
				obj3 = rectTransform;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (obj3 != null)
				{
					Transform parent = ((Transform)obj3).parent;
					if ((object)parent != null)
					{
						object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
						if (parent != obj4)
						{
							goto IL_02df;
						}
						object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
						Rect rect = ((RectTransform)parent).rect;
						object obj6 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v15+E4]");
						bool flag = (nint)0 == 0;
						object obj7 = !flag;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (obj3 != null)
						{
							object obj8 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 56;
							object obj9 = (nint)0 + (nint)3936;
							object obj10 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 136;
							object obj11 = (nint)0 + (nint)3944;
							object obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
							object obj13 = (nint)0 + (nint)2864;
							object obj14 = (nint)0 + (nint)3200;
							Rect rect2 = ((RectTransform)obj3).rect;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3 (System.Object)+18]");
							int num = ShortcutExtensions.DOKill((Component)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							DOGetter<float> dOGetter = default(DOGetter<float>);
							dOGetter..ctor(obj2, (IntPtr)obj9);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							DOSetter<float> dOSetter = default(DOSetter<float>);
							dOSetter..ctor(obj2, (IntPtr)obj11);
							object obj15 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v25+E4]");
							bool flag2 = (nint)0 == 0;
							object obj16 = !flag2;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							float num2 = value - 1f;
							bool flag3 = num2 < 0f;
							bool flag4 = num2 == 0f;
							object obj17 = (double)value ^ 1.0;
							object obj18 = value ^ num2;
							object obj19 = obj17 & obj18;
							bool flag5 = (nint)obj19 < 0;
							bool flag6 = flag3 == flag5;
							object obj20 = !flag4;
							object obj21 = flag6 & obj20;
							object obj22 = ~obj21;
							float num3 = ((obj22 != null) ? value : 1f);
							if (value < 0f)
							{
								num3 = 0f;
							}
							float num4 = pointPadding + pointPadding;
							object obj23 = default(object);
							float num5 = (float)obj23 - num4;
							float num6 = ((!(num5 < 0f)) ? num5 : 0f);
							float endValue = num3 * num6;
							TweenerCore<float, float, FloatOptions> tweenerCore = DOTween.To(dOGetter, dOSetter, endValue, fillDuration);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
							return;
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_02df;
		IL_02df:
		throw new InvalidCastException();
	}

	public void SetCurrentLevel(float level)
	{
		//IL_0010: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0066: Expected I4, but got O
		//IL_0086: Expected O, but got I4
		//IL_00bb: Expected I4, but got O
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00fc: Expected I, but got O
		//IL_011e: Expected O, but got I4
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0177: Expected O, but got I4
		//IL_01cb: Expected O, but got I
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01eb: Expected O, but got I
		//IL_01f7: Expected O, but got I
		//IL_0743: Expected O, but got I4
		//IL_0368: Invalid comparison between F4 and I4
		//IL_0377: Invalid comparison between F4 and I4
		//IL_038a: Expected O, but got F8
		//IL_0397: Expected O, but got F4
		//IL_03cc: Expected O, but got I4
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_021f: Expected I, but got O
		//IL_077e: Invalid comparison between F4 and I4
		//IL_027c: Expected O, but got I4
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Expected O, but got Unknown
		//IL_0413: Expected F4, but got I4
		//IL_08c5: Expected O, but got I4
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected O, but got Unknown
		//IL_02e4: Expected O, but got I4
		//IL_0447: Invalid comparison between F4 and I4
		//IL_07d1: Expected O, but got F4
		//IL_046b: Expected F4, but got I8
		//IL_07e7: Expected I, but got O
		//IL_07fe: Expected O, but got F4
		//IL_04e5: Invalid comparison between F4 and I
		//IL_04f6: Expected O, but got I4
		//IL_0514: Invalid comparison between F4 and I
		//IL_0525: Expected O, but got I4
		//IL_0556: Expected O, but got F4
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected O, but got Unknown
		//IL_058f: Expected O, but got I
		//IL_05bb: Invalid comparison between F4 and I4
		//IL_05ca: Invalid comparison between F4 and I4
		//IL_05e2: Expected O, but got F8
		//IL_05ef: Expected O, but got F4
		//IL_0624: Expected O, but got I4
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected O, but got Unknown
		//IL_0815: Invalid comparison between F4 and I4
		//IL_0670: Expected F4, but got I4
		//IL_069d: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E866E]");
		ClanLevelProgress[] array = (ClanLevelProgress[])0;
		RectTransform rectTransform = (RectTransform)(typeof(CardUtils.<>c) + 920);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj = default(object);
		obj..ctor();
		bool flag = obj == null;
		int num = 0;
		float num2 = level;
		if (!flag)
		{
			object obj2 = obj + 16;
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			array = levels;
			bool flag2 = levels == null;
			num = (int)this;
			num2 = level;
			if (!flag2)
			{
				array = (ClanLevelProgress[])array.Length;
				if (array.Length == 0)
				{
					return;
				}
				bool flag3 = (object)levelProgressBar == null;
				num = (int)this;
				num2 = level;
				if (!flag3)
				{
					rectTransform = (RectTransform)(typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1648);
					RectTransform rectTransform2 = levelProgressBar.rectTransform;
					nint num3 = (nint)rectTransform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v16 (Il2CppClass<UnityEngine.RectTransform>)+E4]");
					bool flag4 = (nint)0 == 0;
					object obj3 = !flag4;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						rectTransform = rectTransform2;
					}
					LayoutRebuilder.ForceRebuildLayoutImmediate(rectTransform2);
					array = levels;
					bool flag5 = levels == null;
					num = 0;
					num2 = level;
					if (!flag5)
					{
						object obj4 = typeof(TypeConverter<ushort, char>) + 3912;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						rectTransform = (RectTransform)(obj + 24);
						int num4 = default(int);
						rectTransform = (RectTransform)num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						array = levels;
						bool flag6 = levels == null;
						num = num4;
						num2 = level;
						if (!flag6)
						{
							object obj5 = (nint)0 + (nint)2864;
							object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
							object obj7 = (nint)0 + (nint)3952;
							object obj8 = (nint)0 + (nint)2664;
							int num5 = 0;
							int num6 = num4;
							ClanLevelProgress[] array2 = levels;
							TweenCallback tweenCallback = default(TweenCallback);
							while (true)
							{
								array = (ClanLevelProgress[])array2.Length;
								bool flag7 = num5 >= array2.Length;
								num = num6;
								num2 = level;
								if (!flag7)
								{
									nint num7 = (nint)rectTransform;
									float levelCenterFill = GetLevelCenterFill(num5);
									bool flag8 = (object)rectTransform == null;
									num = num5;
									num2 = level;
									if (flag8)
									{
										break;
									}
									int num8 = num5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X27_v9 (Il2CppClass<UnityEngine.RectTransform>)+18]");
									bool flag9 = (nint)num8 < (nint)0;
									object obj9 = !flag9;
									if (obj9 == null)
									{
										double num9 = 1.0 - (double)levelCenterFill;
										object obj10 = rectTransform + num5;
										int num10 = num5 + 1;
										array = levels;
										bool flag10 = levels == null;
										object obj11 = !flag10;
										num = num5;
										num2 = level;
										num5 = num10;
										num6 = num10;
										array2 = levels;
										if (obj11 == null)
										{
											break;
										}
										continue;
									}
								}
								else
								{
									float num11 = num2 + -1f;
									double num12 = (double)array + -1.0;
									float num13 = num11 - (float)num12;
									bool flag11 = num13 < 0f;
									bool flag12 = num13 == 0f;
									object obj12 = (double)num11 ^ num12;
									object obj13 = num11 ^ num13;
									object obj14 = obj12 & obj13;
									bool flag13 = (nint)obj14 < 0;
									bool flag14 = flag11 == flag13;
									object obj15 = !flag12;
									object obj16 = flag14 & obj15;
									object obj17 = ~obj16;
									float num14 = ((obj17 != null) ? num11 : ((float)num12));
									num2 = ((!(num11 < 0f)) ? num14 : 0f);
									object obj18 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
									object obj19 = obj18;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v8+E4]");
									bool flag15 = (nint)0 == 0;
									object obj20 = !flag15;
									if (obj20 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
									float num15 = ((num14 != 2.139095E+09f) ? num2 : 2.1474836E+09f);
									ClanLevelProgress[] array3 = levels;
									bool flag16 = levels == null;
									array = (ClanLevelProgress[])num15;
									if (flag16)
									{
										break;
									}
									float num16 = num15 + 1f;
									float num17 = (float)array3.Length - 1f;
									if (num16 < num17)
									{
										num17 = num15 + 1f;
									}
									nint num18 = (nint)rectTransform;
									bool flag17 = (object)rectTransform == null;
									array = (ClanLevelProgress[])num15;
									if (flag17)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X10_v2 (Il2CppClass<UnityEngine.RectTransform>)+18]");
									bool flag18 = num15 < 0f;
									object obj21 = !flag18;
									if (obj21 == null)
									{
										float num19 = num17;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X10_v2 (Il2CppClass<UnityEngine.RectTransform>)+18]");
										bool flag19 = num19 < 0f;
										object obj22 = !flag19;
										if (obj22 == null)
										{
											Component component = levelProgressBar;
											bool flag20 = (object)levelProgressBar == null;
											array = (ClanLevelProgress[])num15;
											if (flag20)
											{
												break;
											}
											object obj23 = rectTransform + 32;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X10_v5+v190 @ X9_v8 (System.Single)*4]");
											nint num20 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X10_v5+v225 @ X8_v9 (System.Single)*4]");
											object obj24 = num20 - 0;
											float num21 = num2 - num15;
											float num22 = num21 - 1f;
											bool flag21 = num22 < 0f;
											bool flag22 = num22 == 0f;
											object obj25 = (double)num21 ^ 1.0;
											object obj26 = num21 ^ num22;
											object obj27 = obj25 & obj26;
											bool flag23 = (nint)obj27 < 0;
											bool flag24 = flag21 == flag23;
											object obj28 = !flag22;
											object obj29 = flag24 & obj28;
											object obj30 = ~obj29;
											float num23 = ((obj30 != null) ? num21 : 1f);
											float num24 = ((!(num21 < 0f)) ? num23 : 0f);
											float num25 = num24 * (float)obj24;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X10_v5+v225 @ X8_v9 (System.Single)*4]");
											float endValue = 0f + num25;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v10 (UnityEngine.Component)+F4]");
											_ = 0;
											int num26 = ShortcutExtensions.DOKill(levelProgressBar);
											TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFillAmount(levelProgressBar, endValue, fillDuration);
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											tweenCallback..ctor(obj, (IntPtr)obj7);
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30587F0");
											return;
										}
									}
								}
								throw new IndexOutOfRangeException();
							}
						}
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	private void Setup(ClanModel clan)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_007f: Expected I4, but got O
		//IL_007f: Expected O, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		object obj = this + 216;
		obj = clan;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 204;
		object obj3 = obj2 & 0x80000000L;
		if (obj3 != null)
		{
			obj2 = clan + 72;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3-AC]");
		((ClanTierIcon)0).SetTier((int)obj2);
		SetupPoints(clan);
	}

	private void StartLevelFill(float level)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		object obj = this + 208;
		if (obj != null)
		{
			StopCoroutine((Coroutine)obj);
		}
		object obj2 = typeof(CardUtils.<>c) + 928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		_ = 0;
		object obj4 = obj3 + 32;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine fillRoutine = StartCoroutine((IEnumerator)obj3);
		_fillRoutine = fillRoutine;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private unsafe void SetupPoints(ClanModel clan)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_0149: Expected I4, but got I8
		//IL_0163: Expected O, but got I4
		//IL_053b: Expected O, but got I4
		//IL_0555: Expected O, but got I4
		//IL_0286: Expected O, but got I4
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected I4, but got Unknown
		//IL_0358: Expected O, but got I4
		//IL_0368: Expected O, but got I
		//IL_0378: Expected O, but got I
		//IL_0396: Expected F4, but got I4
		//IL_061e: Expected O, but got I4
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected O, but got Unknown
		//IL_0508: Expected F8, but got I4
		//IL_03fa: Expected O, but got I4
		//IL_040c: Expected O, but got I4
		//IL_0438: Invalid comparison between F8 and I4
		//IL_0447: Invalid comparison between F8 and I4
		//IL_045f: Expected O, but got F8
		//IL_046c: Expected O, but got F8
		//IL_04a1: Expected O, but got I4
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected O, but got Unknown
		//IL_0664: Invalid comparison between F8 and I4
		//IL_04ed: Expected F8, but got I4
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E866F]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v36+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v36+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		goto IL_0100;
		IL_0100:
		if (current.<Clans>k__BackingField == null)
		{
			return;
		}
		int num = clan.Tier + 1;
		int num2 = (int)(_targetTier & 0x80000000L);
		bool flag2 = num2 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			ClanTierConfig tier = current.<Clans>k__BackingField.GetTier(_targetTier);
			if (tier != null)
			{
				num = _targetTier;
			}
		}
		ClanTierConfig tier2 = current.<Clans>k__BackingField.GetTier(num);
		object obj6 = _targetTier + 1;
		bool flag3 = obj6 == null;
		object obj7 = !flag3;
		int num3 = ((obj7 != null) ? _targetTier : num);
		SetNextRewardTitle(num3);
		int tier3 = ((tier2 != null) ? num : clan.Tier);
		if (clan.Logo != null)
		{
			clanPreviewer.Initialize(clan.Logo, tier3);
		}
		bool isMaxed = tier2 == null;
		bool flag4 = _targetTier < 0;
		bool flag5 = _targetTier == 0;
		int num4 = _targetTier ^ _targetTier;
		int num5 = _targetTier & num4;
		bool flag6 = num5 < 0;
		bool flag7 = flag4 == flag6;
		object obj8 = !flag5;
		object obj9 = flag7 & obj8;
		object obj10 = ~obj9;
		int tier4 = ((obj10 != null) ? clan.Tier : _targetTier);
		SetupEffects(tier4);
		int nextLevelIndex = num - 1;
		SetupTargetLevel(clan.Tier, nextLevelIndex, isMaxed, clan.Name);
		if (tier2 == null)
		{
			int num6 = clan + 48;
			string text = ((int*)num6)->ToString();
			pointText.text = text;
			object obj11 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v9+90]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v10+B8]");
			object text2 = 0;
			nextLevelText.text = (string)text2;
			StartLevelFill(clan.Tier);
			SetPointProgress(1f);
			return;
		}
		int num7 = current.<Clans>k__BackingField.GetTier(clan.Tier)?.XpThreshold ?? 0;
		TextMeshProUGUI textMeshProUGUI = pointText;
		object obj13 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object format = "utf-32" + 3752;
		object arg = default(object);
		object arg2 = default(object);
		string text3 = string.Format((string)format, arg, arg2);
		textMeshProUGUI.text = text3;
		double num11;
		if (num7 != tier2.XpThreshold)
		{
			object obj14 = clan.Points - num7;
			object obj15 = tier2.XpThreshold - num7;
			double num8 = (double)obj14 / (double)obj15;
			double num9 = num8 - 1.0;
			bool flag8 = num9 < 0.0;
			bool flag9 = num9 == 0.0;
			object obj16 = num8 ^ 1.0;
			object obj17 = num8 ^ num9;
			object obj18 = obj16 & obj17;
			bool flag10 = (nint)obj18 < 0;
			bool flag11 = flag8 == flag10;
			object obj19 = !flag9;
			object obj20 = flag11 & obj19;
			object obj21 = ~obj20;
			double num10 = ((obj21 != null) ? num8 : 1.0);
			num11 = ((!(num8 < 0.0)) ? num10 : 0.0);
		}
		else
		{
			num11 = 0.0;
		}
		float level = (float)num11 + (float)clan.Tier;
		StartLevelFill(level);
		SetNextLevelText(nextLevelIndex);
		float pointProgress = (float)clan.Points / (float)tier2.XpThreshold;
		SetPointProgress(pointProgress);
		return;
		IL_0074:
		current = RemoteConfig.Current;
		bool flag12 = current == null;
		object obj22 = !flag12;
		if (obj22 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0100;
	}

	private unsafe void SetupEffects(int tier)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0011: Expected O, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_003b: Expected O, but got I
		//IL_012c: Expected O, but got I4
		//IL_00c3: Expected O, but got I4
		//IL_00cc: Expected O, but got I4
		//IL_00e8: Expected O, but got I4
		//IL_00f1: Expected O, but got I4
		//IL_017f: Expected O, but got I4
		//IL_018d: Expected O, but got I4
		//IL_0196: Expected O, but got I4
		//IL_020a: Expected O, but got I4
		//IL_021a: Expected O, but got I4
		//IL_0285: Expected O, but got I4
		//IL_03cb: Expected O, but got I4
		//IL_055a: Expected O, but got I4
		//IL_02b2: Expected O, but got I4
		//IL_046b: Expected O, but got I4
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected I4, but got Unknown
		//IL_04d9: Expected O, but got I4
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected I4, but got Unknown
		//IL_031c: Expected O, but got I4
		//IL_0343: Expected O, but got I4
		//IL_0355: Expected O, but got Ref
		//IL_0362: Expected O, but got Ref
		//IL_036b: Expected O, but got I4
		//IL_0373: Expected O, but got Ref
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = 152993792;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8670]");
		object obj5 = (nint)0 & (nint)1;
		UnityEngine.Object obj7;
		UnityEngine.Object obj8;
		if (obj5 != null)
		{
			_ = 0;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v22+E4]");
			bool flag = (nint)0 == 0;
			obj7 = particlesEffect;
			obj8 = particlesEffect;
			if (!flag)
			{
				goto IL_009f;
			}
		}
		else
		{
			_ = 1;
			_ = 0;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v22+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj7 = particlesEffect;
			obj8 = particlesEffect;
			if (obj9 != null)
			{
				goto IL_009f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj8 != null;
		bool flag4 = !flag3;
		object obj10 = 0;
		UnityEngine.Object obj11 = null;
		object obj12 = 0;
		ParticleSystem.MinMaxGradient minMaxGradient = (ParticleSystem.MinMaxGradient)0;
		if (!flag4)
		{
			goto IL_01a4;
		}
		goto IL_0378;
		IL_0378:
		object obj13 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = shineEffect != null;
			bool flag6 = !flag5;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(shineEffect != null))
			{
				return;
			}
		}
		if ((object)shineEffect != null)
		{
			GameObject gameObject = shineEffect.gameObject;
			if ((object)gameObject != null)
			{
				object obj15 = tier - 1;
				bool flag7 = (nint)obj15 < 0;
				bool flag8 = obj15 == null;
				int num = tier ^ 1;
				int num2 = tier ^ obj15;
				int num3 = num & num2;
				bool flag9 = num3 < 0;
				bool flag10 = flag7 == flag9;
				object obj16 = !flag8;
				bool active = (byte)((flag10 & obj16) ? 1 : 0) != 0;
				gameObject.SetActive(active);
				return;
			}
		}
		goto IL_04f4;
		IL_0502:
		throw new IndexOutOfRangeException();
		IL_04f4:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0502;
		IL_009f:
		bool flag11 = obj7 != null;
		bool flag12 = !flag11;
		object obj17 = !flag12;
		obj10 = 0;
		obj11 = null;
		if (obj17 != null)
		{
			goto IL_01a4;
		}
		obj12 = 0;
		minMaxGradient = (ParticleSystem.MinMaxGradient)0;
		goto IL_0378;
		IL_01a4:
		Color[] array = particleColors;
		if (particleColors != null)
		{
			bool flag13 = array.Length == 0;
			obj12 = obj10;
			minMaxGradient = (ParticleSystem.MinMaxGradient)obj11;
			if (flag13)
			{
				goto IL_0378;
			}
			object obj18 = tier - 1;
			object obj19 = array.Length - 1;
			object obj20 = obj18 - obj19;
			bool flag14 = (nint)obj20 < 0;
			object obj21 = obj18 ^ obj19;
			object obj22 = obj18 ^ obj20;
			object obj23 = obj21 & obj22;
			bool flag15 = (nint)obj23 < 0;
			bool flag16 = flag14 == flag15;
			object obj24 = !flag16;
			object obj25 = ~obj24;
			if (obj25 == null)
			{
				obj19 = obj18;
			}
			bool flag17 = (nint)obj18 < 0;
			object obj26 = obj18 ^ obj18;
			object obj27 = obj18 & obj26;
			bool flag18 = (nint)obj27 < 0;
			bool flag19 = flag17 == flag18;
			object obj28 = !flag19;
			object obj29 = ~obj28;
			object obj30 = ((obj29 != null) ? obj19 : ((object)0));
			if ((object)particlesEffect != null)
			{
				ParticleSystem.MainModule main = particlesEffect.main;
				Color[] array2 = particleColors;
				if (particleColors != null)
				{
					bool flag20 = (nint)obj30 < array2.Length;
					object obj31 = !flag20;
					if (obj31 == null)
					{
						object obj32 = (object)particleColors + obj30;
						ParticleSystem.MinMaxGradient minMaxGradient2 = (Color)0;
						ParticleSystem.MainModule mainModule = (ParticleSystem.MainModule)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
						object obj33 = default(object);
						((ParticleSystem.MainModule*)mainModule)->startColor = (ParticleSystem.MinMaxGradient)(&obj33);
						obj12 = 0;
						minMaxGradient = (ParticleSystem.MinMaxGradient)(&obj33);
						goto IL_0378;
					}
					goto IL_0502;
				}
			}
		}
		goto IL_04f4;
	}

	private void ResetProgress()
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c2: Expected O, but got I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I
		int num = ShortcutExtensions.DOKill(levelProgressBar);
		levelProgressBar.fillAmount = _initialFill;
		RectTransform rectTransform = pointProgressBar.rectTransform;
		int num2 = ShortcutExtensions.DOKill(rectTransform);
		RectTransform rectTransform2 = pointProgressBar.rectTransform;
		rectTransform2.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, _initialPointWidth);
		ClanLevelProgress[] array = levels;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X21_v4+v27 @ X20_v5*8]");
				((ClanLevelProgress)0).ResetProgress();
			}
			while ((nint)obj2 < array.Length);
		}
	}

	private void SetNextRewardTitle(int tier)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01d1: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_0319: Expected O, but got I4
		//IL_0243: Expected O, but got I4
		//IL_0259: Expected I, but got O
		//IL_0269: Expected O, but got I
		//IL_0292: Expected O, but got I
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8671]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v22+E4]");
			bool flag = (nint)0 == 0;
			obj5 = nextRewardTitle;
			obj6 = nextRewardTitle;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = nextRewardTitle;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v22+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = nextRewardTitle;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (obj8 != null)
		{
			return;
		}
		goto IL_0170;
		IL_0334:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0170:
		object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object input = "Network Authentication Required" + 3280;
		object obj12 = typeof(TypeConverter<ushort, char>) + 3400;
		object obj13 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v2+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = LocalizationUtil.LocalizeOrdinal((string)input, tier);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		object obj15;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj16;
		if (array != null)
		{
			bool flag6 = text == null;
			obj15 = 1;
			if (!flag6)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v12 (Il2CppClass<System.Object[]>)+40]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag7 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v12 (Il2CppClass<System.Object[]>)+40]");
				obj16 = 0;
				if (flag7)
				{
					goto IL_0334;
				}
			}
			if (array.Length != 0)
			{
				object obj17 = array + 32;
				obj17 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object text2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3824;
				TextMeshProExtensions.Localize(nextRewardTitle, (string)text2, array);
				return;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj15 = 1;
		}
		ex = new IndexOutOfRangeException();
		obj16 = obj15;
		goto IL_0334;
		IL_0091:
		bool flag8 = obj5 == null;
		bool flag9 = !flag8;
		obj9 = 0;
		obj10 = null;
		if (!flag9)
		{
			return;
		}
		goto IL_0170;
	}

	private unsafe void SetNextLevelText(int nextLevelIndex)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_0171: Expected O, but got I4
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected I4, but got Unknown
		//IL_01cf: Expected O, but got I4
		//IL_0129: Expected O, but got I
		//IL_0526: Expected O, but got I4
		//IL_055e: Expected O, but got I4
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_026d: Expected O, but got I4
		//IL_029b: Expected O, but got I
		//IL_0302: Expected I, but got O
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_039f: Expected O, but got I4
		//IL_0436: Expected O, but got I8
		//IL_03db: Expected I, but got O
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected O, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1264;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8672]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v47+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v47+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v33+B8]");
		object obj7 = 0;
		object obj8 = obj7;
		if (obj7 != null)
		{
			goto IL_014e;
		}
		goto IL_04b1;
		IL_04b1:
		NullReferenceException ex = new NullReferenceException();
		goto IL_04bf;
		IL_04bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_014e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4+18]");
		int num = (int)(-1);
		int num2 = default(int);
		object obj9 = num2 - num;
		bool flag3 = (nint)obj9 < 0;
		int num3 = num2 ^ num;
		int num4 = num2 ^ obj9;
		int num5 = num3 & num4;
		bool flag4 = num5 < 0;
		bool flag5 = flag3 == flag4;
		object obj10 = !flag5;
		object obj11 = ~obj10;
		if (obj11 == null)
		{
			num = num2;
		}
		bool flag6 = num2 < 0;
		int num6 = num2 ^ num2;
		int num7 = num2 & num6;
		bool flag7 = num7 < 0;
		bool flag8 = flag6 == flag7;
		object obj12 = !flag8;
		object obj13 = ~obj12;
		int num8 = ((obj13 != null) ? num : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4+18]");
		bool flag9 = (nint)num8 < (nint)0;
		object obj14 = !flag9;
		if (obj14 == null)
		{
			object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj16 = typeof(TypeConverter<ushort, char>) + 3400;
			object obj17 = obj8 + num8;
			object obj18 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v9+E4]");
			bool flag10 = (nint)0 == 0;
			object obj19 = !flag10;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v6+20]");
			string text = LocalizationUtil.Localize((string)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object[] array = default(object[]);
			bool flag11 = array == null;
			num2 = 2;
			if (flag11)
			{
				goto IL_04b1;
			}
			bool flag12 = text == null;
			int num9 = 2;
			if (!flag12)
			{
				nint num10 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
				num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag13 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
				num2 = 0;
				if (flag13)
				{
					goto IL_04bf;
				}
			}
			bool flag14 = array.Length == 0;
			num2 = num9;
			if (!flag14)
			{
				object obj20 = array + 32;
				obj20 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj21 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj22 = default(object);
				bool flag15 = obj22 == null;
				int num12 = default(int);
				int num11 = (int)(&num12);
				if (!flag15)
				{
					nint num13 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
					num11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag16 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
					num2 = 0;
					if (flag16)
					{
						goto IL_04bf;
					}
				}
				object obj23 = array.Length & 0xFFFFFFFEL;
				bool flag17 = obj23 == null;
				num2 = num11;
				if (!flag17)
				{
					object text2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3816;
					object obj24 = array + 40;
					obj24 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					TextMeshProExtensions.Localize(nextLevelText, (string)text2, array);
					return;
				}
			}
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_04b1;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v47+B8]");
		object obj25 = 0;
		obj8 = obj25;
		bool flag18 = obj25 == null;
		object obj26 = !flag18;
		if (obj26 != null)
		{
			goto IL_014e;
		}
		goto IL_04b1;
	}

	private void SetupTargetLevel(int currentTier, int nextLevelIndex, bool isMaxed, string clanName = null)
	{
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00fe: Expected I4, but got I8
		//IL_0118: Expected O, but got I4
		//IL_02af: Expected O, but got I4
		//IL_006a: Expected O, but got I4
		//IL_068d: Expected O, but got I
		//IL_069d: Expected O, but got I
		//IL_0148: Expected O, but got I4
		//IL_059d: Expected O, but got I
		//IL_02e2: Expected O, but got I4
		//IL_02f8: Expected O, but got I
		//IL_0363: Expected O, but got I4
		//IL_0725: Expected O, but got I4
		//IL_0190: Expected O, but got I4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected I4, but got Unknown
		//IL_01ee: Expected O, but got I4
		//IL_0625: Expected O, but got I4
		//IL_075d: Expected O, but got I4
		//IL_0390: Expected O, but got I4
		//IL_065d: Expected O, but got I4
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0244: Expected O, but got I
		//IL_0432: Expected I, but got O
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected O, but got Unknown
		//IL_04ed: Expected O, but got I
		//IL_0515: Expected I4, but got O
		bool flag = default(bool);
		GameObject gameObject;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (flag)
		{
			bool flag2 = (object)clanPreviewerContainer == null;
			int num = nextLevelIndex;
			int num2 = currentTier;
			if (!flag2)
			{
				clanPreviewerContainer.SetActive(value: false);
				gameObject = targetLevelIcon;
				bool flag3 = (object)targetLevelIcon == null;
				object obj = !flag3;
				if (obj != null)
				{
					goto IL_0533;
				}
				num = 0;
				num2 = 0;
			}
		}
		else
		{
			bool flag4 = (object)clanPreviewerContainer == null;
			int num = nextLevelIndex;
			int num2 = currentTier;
			if (!flag4)
			{
				clanPreviewerContainer.SetActive(value: true);
				object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1264;
				object obj3 = obj2;
				int num3 = (int)(_targetTier & 0x80000000L);
				bool flag5 = num3 == 0;
				object obj4 = !flag5;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v12+E4]");
					bool flag6 = (nint)0 == 0;
					object obj5 = !flag6;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj3 = obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v12+B8]");
					object obj6 = 0;
					object obj7 = obj6;
					bool flag7 = obj6 == null;
					num = 0;
					num2 = 1;
					if (!flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v17+18]");
						int num4 = (int)(-1);
						object obj8 = nextLevelIndex - num4;
						bool flag8 = (nint)obj8 < 0;
						int num5 = nextLevelIndex ^ num4;
						int num6 = nextLevelIndex ^ obj8;
						int num7 = num5 & num6;
						bool flag9 = num7 < 0;
						bool flag10 = flag8 == flag9;
						object obj9 = !flag10;
						object obj10 = ~obj9;
						if (obj10 == null)
						{
							num4 = nextLevelIndex;
						}
						bool flag11 = nextLevelIndex < 0;
						int num8 = nextLevelIndex ^ nextLevelIndex;
						int num9 = nextLevelIndex & num8;
						bool flag12 = num9 < 0;
						bool flag13 = flag11 == flag12;
						object obj11 = !flag13;
						object obj12 = ~obj11;
						if (obj12 == null)
						{
							num4 = 0;
						}
						int num10 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v17+18]");
						bool flag14 = (nint)num10 < (nint)0;
						object obj13 = !flag14;
						num = 0;
						num2 = 1;
						if (obj13 != null)
						{
							goto IL_0550;
						}
						object obj14 = obj6 + num4;
						TextMeshProUGUI textMesh = targetLevelText;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v18+20]");
						TextMeshProExtensions.Localize(textMesh, (string)0);
						bool flag15 = (object)targetLevelIcon == null;
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v18+20]");
						num2 = 0;
						if (!flag15)
						{
							targetLevelIcon.SetActive(value: true);
							return;
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v12+E4]");
					bool flag16 = (nint)0 == 0;
					object obj15 = !flag16;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj3 = obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v12+B8]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v8+8]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v8+8]");
					bool flag17 = (nint)0 == 0;
					num = 0;
					num2 = 1;
					if (!flag17)
					{
						object obj18 = currentTier - 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v9+18]");
						object obj19 = -1;
						object obj20 = obj18 - obj19;
						bool flag18 = (nint)obj20 < 0;
						object obj21 = obj18 ^ obj19;
						object obj22 = obj18 ^ obj20;
						object obj23 = obj21 & obj22;
						bool flag19 = (nint)obj23 < 0;
						bool flag20 = flag18 == flag19;
						object obj24 = !flag20;
						object obj25 = ~obj24;
						if (obj25 == null)
						{
							obj19 = obj18;
						}
						bool flag21 = (nint)obj18 < 0;
						object obj26 = obj18 ^ obj18;
						object obj27 = obj18 & obj26;
						bool flag22 = (nint)obj27 < 0;
						bool flag23 = flag21 == flag22;
						object obj28 = !flag23;
						object obj29 = ~obj28;
						object obj30 = ((obj29 != null) ? obj19 : ((object)0));
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v9+18]");
						bool flag24 = (nint)obj30 < 0;
						object obj31 = !flag24;
						num = 0;
						num2 = 1;
						if (obj31 != null)
						{
							goto IL_0550;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v8+8]");
						object obj32 = 0 + obj30;
						object obj33 = typeof(TypeConverter<ushort, char>) + 3400;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						object[] array = default(object[]);
						bool flag25 = array == null;
						num = 0;
						num2 = 1;
						if (!flag25)
						{
							bool flag26 = clanName == null;
							int num11 = 1;
							if (!flag26)
							{
								nint num12 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
								num11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag27 = ex == null;
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
								num2 = 0;
								if (flag27)
								{
									goto IL_055e;
								}
							}
							bool flag28 = array.Length == 0;
							num = 0;
							num2 = num11;
							if (flag28)
							{
								goto IL_0550;
							}
							object obj34 = array + 32;
							obj34 = clanName;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							TextMeshProUGUI textMesh2 = targetLevelText;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v10+20]");
							TextMeshProExtensions.Localize(textMesh2, (string)0, array);
							gameObject = targetLevelIcon;
							bool flag29 = (object)targetLevelIcon == null;
							num = (int)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v10+20]");
							num2 = 0;
							if (!flag29)
							{
								goto IL_0533;
							}
						}
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0550;
		IL_055e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0533:
		gameObject.SetActive(value: false);
		return;
		IL_0550:
		ex = new IndexOutOfRangeException();
		goto IL_055e;
	}

	private IEnumerator SetCurrentLevelDelayed(float level)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private float GetLevelCenterFill(int index)
	{
		//IL_0058: Expected O, but got I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_014a: Expected O, but got I4
		//IL_030f: Expected O, but got I4
		//IL_0175: Expected O, but got I4
		//IL_01d4: Invalid comparison between F4 and I4
		//IL_01e3: Invalid comparison between F4 and I4
		//IL_01fb: Expected O, but got F8
		//IL_0208: Expected O, but got F4
		//IL_023d: Expected O, but got I4
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0339: Invalid comparison between F4 and I4
		//IL_0289: Expected F4, but got I4
		if ((object)levelProgressBar != null)
		{
			RectTransform rectTransform = levelProgressBar.rectTransform;
			ClanLevelProgress[] array = levels;
			if (levels != null)
			{
				bool flag = index < array.Length;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_02a9;
				}
				object obj2 = levels + index;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v7+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v7+20]");
					Transform transform = ((Component)0).transform;
					if ((object)transform != null)
					{
						object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
						if (transform != obj3)
						{
							throw new InvalidCastException();
						}
						object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
						Rect rect = ((RectTransform)transform).rect;
						object obj5 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v15+E4]");
						bool flag2 = (nint)0 == 0;
						object obj6 = !flag2;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj7 = default(object);
						double num = (double)obj7 * 0.5;
						float num2 = num2 + (float)num;
						Vector3 vector = transform.TransformPoint((Vector3)0);
						if ((object)rectTransform != null)
						{
							Vector3 vector2 = rectTransform.InverseTransformPoint((Vector3)0);
							Rect rect2 = rectTransform.rect;
							Rect rect3 = rectTransform.rect;
							float num3 = num2 - num2;
							float num4 = num3 / 0f;
							float num5 = num4 - 1f;
							bool flag3 = num5 < 0f;
							bool flag4 = num5 == 0f;
							object obj8 = (double)num4 ^ 1.0;
							object obj9 = num4 ^ num5;
							object obj10 = obj8 & obj9;
							bool flag5 = (nint)obj10 < 0;
							bool flag6 = flag3 == flag5;
							object obj11 = !flag4;
							object obj12 = flag6 & obj11;
							object obj13 = ~obj12;
							float result = ((obj13 != null) ? num4 : 1f);
							if (num4 < 0f)
							{
								return 0f;
							}
							return result;
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_02a9;
		IL_02a9:
		throw new IndexOutOfRangeException();
	}

	static ClanLockedLevelPopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0087: Expected O, but got I8
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I4
		//IL_010b: Expected O, but got I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0187: Expected O, but got I8
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01f5: Expected O, but got I4
		//IL_020b: Expected O, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_031d: Expected O, but got I8
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_038b: Expected O, but got I4
		//IL_03a1: Expected O, but got I
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_041d: Expected O, but got I8
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_048b: Expected O, but got I4
		//IL_04a1: Expected O, but got I
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected O, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected O, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected O, but got Unknown
		//IL_0535: Expected O, but got I
		//IL_0582: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			object obj2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3768;
			object obj4 = default(object);
			object obj3 = obj4 + 32;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X20_v4-8]");
			object obj5 = 0 & 0xFFFFFFFEL;
			if (obj5 != null)
			{
				object obj6 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3800;
				object obj7 = obj4 + 40;
				obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X20_v6-10]");
				bool flag = (nint)0 < (nint)2;
				object obj8 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X20_v6-10]");
				object obj9 = -2;
				bool flag2 = obj9 == null;
				object obj10 = ~obj8;
				object obj11 = obj10 | flag2;
				if (obj11 == null)
				{
					object obj12 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3784;
					object obj13 = obj4 + 48;
					obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X20_v8-18]");
					object obj14 = 0 & 0xFFFFFFFCL;
					if (obj14 != null)
					{
						object obj15 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3752;
						object obj16 = obj4 + 56;
						obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X20_v10-20]");
						bool flag3 = (nint)0 < (nint)4;
						object obj17 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X20_v10-20]");
						object obj18 = -4;
						bool flag4 = obj18 == null;
						object obj19 = ~obj17;
						object obj20 = obj19 | flag4;
						if (obj20 == null)
						{
							object obj21 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3736;
							object obj22 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1264;
							object obj23 = obj4 + 64;
							obj23 = obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj24 = obj22;
							object obj25 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v22+18]");
							if ((nint)0 != 0)
							{
								object obj26 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3776;
								object obj28 = default(object);
								object obj27 = obj28 + 32;
								obj27 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X20_v12-8]");
								object obj29 = 0 & 0xFFFFFFFEL;
								if (obj29 != null)
								{
									object obj30 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3808;
									object obj31 = obj28 + 40;
									obj31 = obj30;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X20_v14-10]");
									bool flag5 = (nint)0 < (nint)2;
									object obj32 = !flag5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X20_v14-10]");
									object obj33 = -2;
									bool flag6 = obj33 == null;
									object obj34 = ~obj32;
									object obj35 = obj34 | flag6;
									if (obj35 == null)
									{
										object obj36 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3792;
										object obj37 = obj28 + 48;
										obj37 = obj36;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X20_v16-18]");
										object obj38 = 0 & 0xFFFFFFFCL;
										if (obj38 != null)
										{
											object obj39 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3760;
											object obj40 = obj28 + 56;
											obj40 = obj39;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X20_v18-20]");
											bool flag7 = (nint)0 < (nint)4;
											object obj41 = !flag7;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X20_v18-20]");
											object obj42 = -4;
											bool flag8 = obj42 == null;
											object obj43 = ~obj41;
											object obj44 = obj43 | flag8;
											if (obj44 == null)
											{
												object obj45 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3744;
												object obj46 = typeof(UsageHint) + 1632;
												object obj47 = obj28 + 64;
												obj47 = obj45;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												object obj48 = obj22;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v36+B8]");
												object obj49 = (nint)0 + (nint)8;
												obj49 = obj28;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												WaitForEndOfFrame waitForEndOfFrame = default(WaitForEndOfFrame);
												waitForEndOfFrame..ctor();
												object obj50 = obj22;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v37+B8]");
												object obj51 = (nint)0 + (nint)16;
												obj51 = waitForEndOfFrame;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
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
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void <Initialize>b__35_1(ClanModel full)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e5: Expected O, but got I4
		//IL_0099: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		//IL_0125: Expected O, but got I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01e7: Expected O, but got I4
		//IL_0226: Expected I4, but got O
		//IL_0226: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8677]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = this == null;
		bool flag3 = full == null;
		object obj5 = 0;
		if (!flag3)
		{
			goto IL_0133;
		}
		return;
		IL_0133:
		bool flag4 = !flag2;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			object obj7 = this + 216;
			obj7 = full;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = full + 72;
			object obj9 = this + 204;
			bool flag5 = (nint)obj9 < 0;
			object obj10 = obj9 ^ obj9;
			object obj11 = obj9 & obj10;
			bool flag6 = (nint)obj11 < 0;
			bool flag7 = flag5 == flag6;
			object obj12 = !flag7;
			object obj13 = ~obj12;
			if (obj13 != null)
			{
				obj8 = obj9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X21_v4-B8]");
			((ClanTierIcon)0).SetTier((int)obj8);
			SetupPoints(full);
		}
		return;
		IL_0074:
		flag2 = this == null;
		bool flag8 = full == null;
		object obj14 = !flag8;
		obj5 = 0;
		if (obj14 == null)
		{
			return;
		}
		goto IL_0133;
	}
}
