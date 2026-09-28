using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ListViewItemExtra : MonoBehaviour
{
	[Serializable]
	public class AttentionNudgeConfig
	{
		private NudgeEffect _nudgeEffect = NudgeEffect.PunchScale;

		private float _duration;

		private float _strength;

		private int _vibrato;

		private float _elasticity;

		public void Play(Transform target, GameObject link)
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected O, but got Unknown
			//IL_003e: Expected O, but got I4
			//IL_00de: Expected O, but got I4
			//IL_0090: Expected O, but got I
			//IL_0124: Expected O, but got I
			//IL_0171: Expected O, but got I4
			if (_nudgeEffect == NudgeEffect.None)
			{
				return;
			}
			int num = ShortcutExtensions.DOComplete(target);
			object obj = typeof(UsageHint) + 816;
			target.localScale = (Vector3)0;
			if (_nudgeEffect != NudgeEffect.ShakeScale)
			{
				if (_nudgeEffect != NudgeEffect.PunchScale)
				{
					return;
				}
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v16+B8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v17+C]");
				float duration = 0f * _strength;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v17+10]");
				float elasticity = 0f * _strength;
				Tweener tweener = ShortcutExtensions.DOPunchScale(target, (Vector3)10, duration, 0, elasticity);
				if (tweener == null)
				{
					return;
				}
			}
			else
			{
				Tweener tweener = ShortcutExtensions.DOShakeScale(target, _duration, _strength, _vibrato);
				bool flag = tweener == null;
				object obj4 = !flag;
				if (obj4 == null)
				{
					return;
				}
			}
			object obj5 = (nint)0 + (nint)2992;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3059198");
		}

		public AttentionNudgeConfig()
		{
			//IL_001d: Expected F4, but got I
			//IL_002c: Expected I4, but got I8
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252EE0]");
			_duration = 0f;
			_vibrato = 10;
			base..ctor();
		}
	}

	private sealed class <>c__DisplayClass44_0
	{
		public Action onPin;

		public ListViewItemExtra <>4__this;

		public Action onDismiss;

		internal void <Setup>b__0()
		{
			Action action = onPin;
			if (onPin != null)
			{
				IntPtr invoke_impl = ((Delegate)action).invoke_impl;
				IntPtr method_code = ((Delegate)action).method_code;
				IntPtr method = ((Delegate)action).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void <Setup>b__1()
		{
			<>4__this.ConfirmDismiss(onDismiss);
		}

		internal void <Setup>b__2()
		{
			ListViewItemExtra listViewItemExtra = <>4__this;
			Actions.SafeInvoke(listViewItemExtra.OnPinnedHeaderClicked);
		}
	}

	private sealed class <>c__DisplayClass49_0
	{
		public Action onDismiss;

		internal void <ConfirmDismiss>b__0()
		{
			Action action = onDismiss;
			if (onDismiss != null)
			{
				IntPtr invoke_impl = ((Delegate)action).invoke_impl;
				IntPtr method_code = ((Delegate)action).method_code;
				IntPtr method = ((Delegate)action).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private Button _dismissButton;

	private string _dismissTitle;

	private string _dismissContent;

	private string _dismissConfirmLabel;

	private Button _pinButton;

	private bool _keepWhenPinned;

	private Button _pinnedHeaderButton;

	private AttentionNudgeConfig _attentionNudge;

	private PinnedForm _pinnedForm;

	private GameObject _miniPrefab;

	private float _pinnedTopOffset;

	private RectTransform _root;

	private CanvasGroup[] _fullOnlyContent;

	private float _pinnedHeight;

	private float _morphDuration;

	private Ease _morphEase;

	private float _fullHeight;

	private bool _fullHeightCaptured;

	private bool _isPinned;

	private bool _isDatumPinned;

	private Sequence _morph;

	private Action m_OnPinnedHeaderClicked;

	private Action m_OnPinnedChanged;

	private Action m_OnDatumPinnedChanged;

	public bool IsPinned => _isPinned;

	public bool IsDatumPinned => _isDatumPinned;

	public bool KeepWhenPinned => _keepWhenPinned;

	public PinnedForm Form => _pinnedForm;

	public GameObject MiniPrefab => _miniPrefab;

	public float PinnedTopOffset => _pinnedTopOffset;

	public float CurrentHeight
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0141: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_00c0: Expected O, but got I4
			//IL_00f4: Expected O, but got I4
			//IL_0190: Expected O, but got I4
			//IL_0199: Expected O, but got I4
			//IL_01a2: Expected O, but got I4
			//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01eb: Expected O, but got Unknown
			//IL_0236: Unknown result type (might be due to invalid IL or missing references)
			//IL_023b: Expected O, but got Unknown
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7563]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object root;
			UnityEngine.Object root2;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				root = _root;
				root2 = _root;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				root = _root;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				root2 = _root;
				if (obj5 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = root2 != null;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			object obj7 = 0;
			object obj8 = 0;
			if (obj6 != null)
			{
				goto IL_00ce;
			}
			goto IL_01b0;
			IL_028a:
			throw new InvalidCastException();
			IL_021a:
			RectTransform rectTransform;
			Rect rect = rectTransform.rect;
			object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v7+E4]");
			float result = default(float);
			if ((nint)0 != 0)
			{
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return result;
			IL_00ce:
			rectTransform = _root;
			bool flag5 = (object)_root == null;
			object obj11 = !flag5;
			if (obj11 != null)
			{
				goto IL_021a;
			}
			goto IL_027c;
			IL_0091:
			bool flag6 = root != null;
			bool flag7 = !flag6;
			obj7 = 0;
			obj8 = 0;
			if (!flag7)
			{
				goto IL_00ce;
			}
			goto IL_01b0;
			IL_01b0:
			Transform transform = base.transform;
			if ((object)transform == null)
			{
				goto IL_027c;
			}
			object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
			bool flag8 = transform != obj12;
			obj7 = obj8;
			rectTransform = (RectTransform)transform;
			if (!flag8)
			{
				goto IL_021a;
			}
			goto IL_028a;
			IL_027c:
			NullReferenceException ex = new NullReferenceException();
			goto IL_028a;
		}
	}

	public event Action OnPinnedHeaderClicked
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 168;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 168;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event Action OnPinnedChanged
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 176;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 176;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event Action OnDatumPinnedChanged
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 184;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 184;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public void Setup(bool firstTime, Action onPin, Action onDismiss)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_00cc: Expected O, but got I4
		//IL_04ce: Expected O, but got I4
		//IL_04dc: Expected O, but got I4
		//IL_01b7: Expected O, but got I4
		//IL_01c0: Expected O, but got I4
		//IL_01ce: Expected O, but got I4
		//IL_0608: Expected O, but got I4
		//IL_0616: Expected O, but got I4
		//IL_0251: Expected O, but got I4
		//IL_025a: Expected O, but got I4
		//IL_0270: Expected O, but got I4
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected O, but got Unknown
		//IL_0540: Expected O, but got I
		//IL_0551: Expected I, but got O
		//IL_0135: Expected O, but got I4
		//IL_059c: Expected O, but got I4
		//IL_05af: Expected O, but got I4
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected O, but got Unknown
		//IL_0412: Expected O, but got I4
		//IL_0478: Expected O, but got I4
		//IL_073c: Expected O, but got I4
		//IL_074d: Expected O, but got I4
		//IL_02f1: Expected O, but got I4
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Expected O, but got Unknown
		//IL_067a: Expected O, but got I
		//IL_068b: Expected I, but got O
		//IL_06d6: Expected O, but got I4
		//IL_06e9: Expected O, but got I4
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0355: Expected O, but got I
		//IL_0366: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		Action action = default(Action);
		obj4 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 32;
		Action action2 = default(Action);
		obj6 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag = !firstTime;
		UnityEngine.Object obj7 = (UnityEngine.Object)(object)action2;
		UnityEngine.Object pinButton;
		UnityEngine.Object pinButton2;
		object obj14;
		if (!flag)
		{
			bool flag2 = !_fullHeightCaptured;
			object obj8 = !flag2;
			obj7 = (UnityEngine.Object)(object)action2;
			if (obj8 == null)
			{
				object obj9 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v60+E4]");
				Action action3;
				if ((nint)0 != 0)
				{
					bool flag3 = _root != null;
					bool flag4 = !flag3;
					object obj10 = !flag4;
					action = null;
					obj7 = null;
					action3 = null;
					if (obj10 == null)
					{
						goto IL_0152;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag5 = _root != null;
					bool flag6 = !flag5;
					action = null;
					obj7 = null;
					action3 = null;
					if (flag6)
					{
						goto IL_0152;
					}
				}
				Rect rect = _root.rect;
				object obj11 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v64+E4]");
				bool flag7 = (nint)0 == 0;
				object obj13 = !flag7;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float fullHeight = default(float);
				_fullHeight = fullHeight;
				_fullHeightCaptured = true;
				pinButton = _pinButton;
				obj14 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v38+E4]");
				bool flag8 = (nint)0 == 0;
				object obj15 = !flag8;
				action = action3;
				obj7 = null;
				pinButton2 = _pinButton;
				if (obj15 != null)
				{
					goto IL_0193;
				}
				goto IL_049d;
			}
		}
		goto IL_0152;
		IL_05cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object dismissButton;
		bool flag9 = dismissButton != null;
		bool flag10 = !flag9;
		Action action4;
		action2 = action4;
		object obj16 = 0;
		UnityEngine.Object obj17 = null;
		object obj18 = 0;
		if (flag10)
		{
			goto IL_027e;
		}
		goto IL_0624;
		IL_022d:
		UnityEngine.Object dismissButton2;
		bool flag11 = dismissButton2 != null;
		bool flag12 = !flag11;
		object obj19 = !flag12;
		obj16 = 0;
		obj17 = null;
		action4 = action2;
		obj18 = 0;
		if (obj19 == null)
		{
			goto IL_027e;
		}
		goto IL_0624;
		IL_0709:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object pinnedHeaderButton;
		bool flag13 = pinnedHeaderButton != null;
		bool flag14 = !flag13;
		object obj20 = !flag14;
		Action action5;
		action2 = action5;
		object obj21 = 0;
		if (obj20 == null)
		{
			return;
		}
		goto IL_02ff;
		IL_027e:
		UnityEngine.Object pinnedHeaderButton2 = _pinnedHeaderButton;
		object obj22 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v5+E4]");
		bool flag15 = (nint)0 == 0;
		action5 = action2;
		UnityAction unityAction = (UnityAction)(object)obj17;
		pinnedHeaderButton = _pinnedHeaderButton;
		if (!flag15)
		{
			goto IL_02cf;
		}
		goto IL_0709;
		IL_0624:
		Button dismissButton3 = _dismissButton;
		dismissButton3.m_OnClick.RemoveAllListeners();
		Button dismissButton4 = _dismissButton;
		object obj23 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj24 = (nint)0 + (nint)3912;
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(obj2, (IntPtr)obj24);
		dismissButton4.m_OnClick.AddListener(unityAction2);
		pinnedHeaderButton2 = _pinnedHeaderButton;
		obj22 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v5+E4]");
		bool flag16 = (nint)0 == 0;
		object obj25 = !flag16;
		action2 = null;
		action5 = null;
		obj16 = 0;
		unityAction = unityAction2;
		pinnedHeaderButton = _pinnedHeaderButton;
		if (obj25 != null)
		{
			goto IL_02cf;
		}
		goto IL_0709;
		IL_02ff:
		Button pinnedHeaderButton3 = _pinnedHeaderButton;
		pinnedHeaderButton3.m_OnClick.RemoveAllListeners();
		Button pinnedHeaderButton4 = _pinnedHeaderButton;
		object obj26 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)3920;
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(obj2, (IntPtr)obj27);
		pinnedHeaderButton4.m_OnClick.AddListener(unityAction3);
		return;
		IL_02cf:
		bool flag17 = pinnedHeaderButton2 != null;
		bool flag18 = !flag17;
		obj21 = 0;
		if (!flag18)
		{
			goto IL_02ff;
		}
		return;
		IL_0152:
		obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v38+E4]");
		bool flag19 = (nint)0 == 0;
		pinButton = _pinButton;
		pinButton2 = _pinButton;
		if (!flag19)
		{
			goto IL_0193;
		}
		goto IL_049d;
		IL_049d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag20 = pinButton2 != null;
		bool flag21 = !flag20;
		object obj28 = 0;
		UnityEngine.Object obj29 = null;
		object obj30 = 0;
		if (flag21)
		{
			goto IL_01dc;
		}
		goto IL_04ea;
		IL_0193:
		bool flag22 = pinButton != null;
		bool flag23 = !flag22;
		object obj31 = !flag23;
		obj28 = 0;
		obj29 = null;
		obj30 = 0;
		if (obj31 == null)
		{
			goto IL_01dc;
		}
		goto IL_04ea;
		IL_04ea:
		Button pinButton3 = _pinButton;
		pinButton3.m_OnClick.RemoveAllListeners();
		Button pinButton4 = _pinButton;
		object obj32 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj33 = (nint)0 + (nint)3904;
		UnityAction unityAction4 = default(UnityAction);
		unityAction4..ctor(obj2, (IntPtr)obj33);
		pinButton4.m_OnClick.AddListener(unityAction4);
		dismissButton2 = _dismissButton;
		object obj34 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v14+E4]");
		bool flag24 = (nint)0 == 0;
		object obj35 = !flag24;
		action2 = null;
		action4 = null;
		obj28 = 0;
		UnityAction unityAction5 = unityAction4;
		dismissButton = _dismissButton;
		if (obj35 != null)
		{
			goto IL_022d;
		}
		goto IL_05cf;
		IL_01dc:
		dismissButton2 = _dismissButton;
		obj34 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v14+E4]");
		bool flag25 = (nint)0 == 0;
		action4 = action2;
		unityAction5 = (UnityAction)(object)obj29;
		dismissButton = _dismissButton;
		if (!flag25)
		{
			goto IL_022d;
		}
		goto IL_05cf;
	}

	public void ApplyPinned(bool pinned, bool animated)
	{
		Apply(pinned, animated);
	}

	public void SetDatumPinned(bool pinned)
	{
		if (_isDatumPinned != pinned)
		{
			_isDatumPinned = pinned;
			Actions.SafeInvoke(this.OnDatumPinnedChanged);
		}
	}

	public void ReassertPinned(bool pinned)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I4
		//IL_006c: Expected O, but got I4
		//IL_0075: Expected O, but got I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0116: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_035c: Expected O, but got I4
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_01e1: Expected O, but got I
		//IL_021d: Invalid comparison between F8 and I4
		//IL_022c: Invalid comparison between F8 and I4
		//IL_023f: Expected O, but got F8
		//IL_024c: Expected O, but got F8
		//IL_0281: Expected O, but got I4
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		if (_pinnedForm != PinnedForm.SeparatePrefab)
		{
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				bool flag = _root != null;
				bool flag2 = !flag;
				object obj3 = !flag2;
				object obj4 = 0;
				if (obj3 != null)
				{
					goto IL_00c9;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = _root != null;
				bool flag4 = !flag3;
				object obj4 = 0;
				if (!flag4)
				{
					goto IL_00c9;
				}
			}
		}
		goto IL_0181;
		IL_00c9:
		Rect rect = _root.rect;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = !pinned;
		object obj8 = !flag6;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
		}
		object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4024;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		object obj12 = default(object);
		object obj13 = default(object);
		object obj11 = obj12 - obj13;
		bool flag7 = (nint)obj11 < 0;
		bool flag8 = obj11 == null;
		object obj14 = obj12 ^ obj13;
		object obj15 = obj12 ^ obj11;
		object obj16 = obj14 & obj15;
		bool flag9 = (nint)obj16 < 0;
		bool flag10 = flag7 == flag9;
		object obj17 = !flag8;
		object obj18 = flag10 & obj17;
		object obj19 = ~obj18;
		if (obj19 == null)
		{
		}
		object obj20 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v15+B8]");
		object obj21 = 0;
		double num = (double)obj13 * 897988541.0;
		double num2 = (double)obj21 * 8.0;
		double num3 = num - num2;
		bool flag11 = num3 < 0.0;
		bool flag12 = num3 == 0.0;
		object obj22 = num ^ num2;
		object obj23 = num ^ num3;
		object obj24 = obj22 & obj23;
		bool flag13 = (nint)obj24 < 0;
		bool flag14 = flag11 == flag13;
		object obj25 = !flag12;
		object obj26 = flag14 & obj25;
		object obj27 = ~obj26;
		if (obj27 != null)
		{
			num = num2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		if (num2 < num)
		{
			return;
		}
		goto IL_0181;
		IL_0181:
		Apply(pinned, animated: false);
	}

	public void NudgeAttention()
	{
		Transform target = base.transform;
		GameObject link = base.gameObject;
		_attentionNudge.Play(target, link);
	}

	private void ConfirmDismiss(Action onDismiss)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_0386: Expected O, but got I
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0049: Expected O, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0098: Expected I, but got O
		//IL_00cc: Expected O, but got I4
		//IL_0105: Expected O, but got I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_012f: Expected I, but got O
		//IL_013f: Expected O, but got I
		//IL_01ef: Expected O, but got I4
		//IL_017a: Expected O, but got I
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_0221: Expected I, but got O
		//IL_0231: Expected O, but got I
		//IL_02cf: Expected O, but got I
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected I, but got Unknown
		//IL_0318: Expected O, but got I4
		//IL_0329: Expected O, but got I4
		//IL_026c: Expected O, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_0403: Expected O, but got I4
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7566]");
		nint num = 0;
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2136;
		object obj2 = default(object);
		Action action = default(Action);
		object obj9 = default(object);
		object obj10 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		object obj19 = default(object);
		IntPtr intPtr = default(IntPtr);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2..ctor();
			nint num2;
			object obj6;
			if (obj2 != null)
			{
				object obj3 = typeof(SqlSingle[]) + 2376;
				object obj4 = (nint)0 + (nint)3928;
				object cancelText = "COORDINATE_TYPE_GCJ_02" + 1864;
				object obj5 = obj2 + 16;
				obj5 = onDismiss;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action..ctor(obj2, (IntPtr)obj4);
				PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateNegativeConfirm(action, _dismissConfirmLabel, (string)cancelText);
				bool flag = popupWindowBuilder == null;
				obj6 = 0;
				if (!flag)
				{
					IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled(_dismissTitle);
					bool flag2 = popupWindowBuilderNeedsBody == null;
					obj6 = 0;
					if (!flag2)
					{
						object obj7 = typeof(System.IOAsyncCallback) + 384;
						num2 = (nint)popupWindowBuilderNeedsBody;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_01c3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
						obj9 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X10_v12-8]");
							if (0 == (nint)obj7)
							{
								break;
							}
							obj10 = obj9 + 16;
							obj8--;
							bool flag3 = (nint)obj8 != 1;
							obj9 = obj10;
							if (flag3)
							{
								continue;
							}
							goto IL_01c3;
						}
						goto IL_02d9;
					}
				}
			}
			goto IL_0337;
			IL_0205:
			object obj11 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj10 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v9-8]");
					bool flag4 = 0 == (nint)obj11;
					obj6 = 0;
					if (flag4)
					{
						break;
					}
					obj10 += 16;
					obj12--;
					if ((nint)obj12 != 1)
					{
						continue;
					}
					goto IL_02ad;
				}
				goto IL_0345;
			}
			goto IL_02ad;
			IL_0337:
			ex = new NullReferenceException();
			goto IL_0345;
			IL_0345:
			object obj13 = obj10 + 9;
			object obj14 = num + obj13;
			object obj15 = obj14 + 312;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v5+8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v206 @ X2_v2 (should have been resolved before IL gen)");
			continue;
			IL_02ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj18 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v16+8]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v249 @ X2_v9 (should have been resolved before IL gen)");
			goto IL_02d9;
			IL_02d9:
			object obj21 = num2 + obj9;
			num = (nint)(obj21 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v197 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag5 = ex == null;
			object obj22 = !flag5;
			obj10 = obj9;
			obj6 = 0;
			if (obj22 != null)
			{
				goto IL_0205;
			}
			goto IL_0337;
			IL_01c3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v293 @ X0_v18 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag6 = ex == null;
			obj6 = 0;
			num = intPtr;
			if (!flag6)
			{
				goto IL_0205;
			}
			goto IL_0337;
		}
	}

	private void Apply(bool pinned, bool animated)
	{
		//IL_0016: Expected O, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_019e: Expected O, but got I4
		//IL_01a7: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01dc: Expected I4, but got O
		//IL_0229: Expected O, but got I4
		//IL_0257: Expected O, but got I4
		//IL_0201: Expected O, but got I4
		//IL_05a1: Expected O, but got I4
		//IL_0249: Expected O, but got I4
		//IL_0265: Expected F8, but got I4
		//IL_04fe: Expected F4, but got I
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_02ba: Expected O, but got I4
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0323: Expected O, but got I
		//IL_0331: Expected I, but got O
		//IL_0590: Expected O, but got I4
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_0360: Expected O, but got I
		//IL_036e: Expected I, but got O
		//IL_0623: Expected O, but got I
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected O, but got Unknown
		//IL_055e: Expected O, but got I4
		//IL_0392: Expected F4, but got I
		//IL_05e6: Expected O, but got I
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected O, but got Unknown
		//IL_04b2: Expected O, but got I
		//IL_04d7: Expected O, but got I
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_03f3: Expected O, but got I4
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_0429: Expected O, but got I
		//IL_044c: Expected O, but got I
		//IL_046c: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7567]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			if (_isPinned == pinned)
			{
				goto IL_0054;
			}
		}
		else
		{
			_ = 1;
			if (_isPinned == pinned)
			{
				goto IL_0054;
			}
		}
		_isPinned = pinned;
		Actions.SafeInvoke(this.OnPinnedChanged);
		bool flag = _pinnedForm == PinnedForm.SeparatePrefab;
		bool flag2 = false;
		if (!flag)
		{
			goto IL_00e4;
		}
		return;
		IL_00e4:
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v3+E4]");
		UnityEngine.Object obj5;
		if ((nint)0 != 0)
		{
			bool flag3 = _root == null;
			bool flag4 = !flag3;
			object obj4 = 0;
			obj5 = null;
			if (!flag4)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = _root == null;
			bool flag6 = !flag5;
			object obj6 = !flag6;
			object obj4 = 0;
			obj5 = null;
			if (obj6 != null)
			{
				return;
			}
		}
		object obj7 = this + 160;
		bool flag7 = obj7 == null;
		bool flag8 = (byte)(int)obj5 != 0;
		if (!flag7)
		{
			TweenExtensions.Kill((Tween)obj7);
			object obj4 = 0;
			flag8 = false;
		}
		bool flag9 = !pinned;
		object obj8 = !flag9;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
			object obj10 = 136;
		}
		else
		{
			object obj10 = 148;
		}
		object obj11 = !flag9;
		object obj12 = ~obj11;
		double num = ((obj12 != null) ? 1.0 : 0.0);
		if (animated)
		{
			object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v13+E4]");
			bool flag10 = (nint)0 == 0;
			object obj15 = !flag10;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence morph = DOTween.Sequence();
			_morph = morph;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj16 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj17 = (nint)0 + (nint)1432;
			DOGetter<float> dOGetter = default(DOGetter<float>);
			dOGetter..ctor((object)this, (IntPtr)obj17);
			object obj18 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 136;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj19 = (nint)0 + (nint)1440;
			DOSetter<float> dOSetter = default(DOSetter<float>);
			dOSetter..ctor((object)this, (IntPtr)obj19);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListViewItemExtra)+v367 @ X8_v8]");
			TweenerCore<float, float, FloatOptions> t = DOTween.To(dOGetter, dOSetter, 0f, _morphDuration);
			Sequence sequence = TweenSettingsExtensions.Join(_morph, t);
			CanvasGroup[] fullOnlyContent = _fullOnlyContent;
			if (fullOnlyContent.Length >= 1)
			{
				object obj20 = fullOnlyContent + 32;
				object obj21 = 0;
				do
				{
					obj21++;
					bool interactable = (byte)((pinned ? 1u : 0u) ^ 1u) != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X25_v5+v388 @ X24_v6*8]");
					((CanvasGroup)0).interactable = interactable;
					bool blocksRaycasts = (byte)((pinned ? 1u : 0u) ^ 1u) != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X25_v5+v388 @ X24_v6*8]");
					((CanvasGroup)0).blocksRaycasts = blocksRaycasts;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X25_v5+v388 @ X24_v6*8]");
					TweenerCore<float, float, FloatOptions> t2 = DOTweenModuleUI.DOFade((CanvasGroup)0, (float)num, _morphDuration);
					Sequence sequence2 = TweenSettingsExtensions.Join(_morph, t2);
				}
				while ((nint)obj21 < fullOnlyContent.Length);
			}
			object obj22 = (nint)0 + (nint)2912;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			GameObject gameObject = base.gameObject;
			object obj23 = (nint)0 + (nint)2984;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3059198");
			return;
		}
		RectTransform root = _root;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListViewItemExtra)+v367 @ X8_v8]");
		root.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 0f);
		CanvasGroup[] fullOnlyContent2 = _fullOnlyContent;
		object obj24 = _fullOnlyContent + 32;
		if (pinned)
		{
			if (fullOnlyContent2.Length >= 1)
			{
				object obj25 = 0;
				do
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X21_v5+v456 @ X20_v8*8]");
					UIExtensions.Disable((CanvasGroup)0);
					obj25++;
				}
				while ((nint)obj25 < fullOnlyContent2.Length);
			}
		}
		else if (fullOnlyContent2.Length >= 1)
		{
			object obj26 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X21_v5+v469 @ X20_v5*8]");
				UIExtensions.Enable((CanvasGroup)0);
				obj26++;
			}
			while ((nint)obj26 < fullOnlyContent2.Length);
		}
		return;
		IL_0054:
		bool flag11 = _pinnedForm != PinnedForm.SeparatePrefab;
		flag2 = pinned;
		if (!flag11)
		{
			return;
		}
		goto IL_00e4;
	}

	private void SetHeight(float height)
	{
		_root.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
	}

	public ListViewItemExtra()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00aa: Expected F4, but got I
		object obj = "Unsupported map type" + 3592;
		object obj2 = "Added Tournament Prizes And Features" + 2152;
		object obj3 = "DNQUALIFIER" + 2320;
		object obj4 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2144;
		object obj5 = this + 40;
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = this + 48;
		obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = this + 56;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252EE0]");
		_ = 0;
		_ = 4575657221408423946L;
		object obj8 = default(object);
		obj8..ctor();
		object obj9 = this + 88;
		obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252EE8]");
		_pinnedHeight = 0f;
		_morphEase = Ease.OutQuad;
		base..ctor();
	}

	private float <Apply>b__50_0()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect rect = _root.rect;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v5+E4]");
		float result = default(float);
		if ((nint)0 != 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return result;
	}
}
