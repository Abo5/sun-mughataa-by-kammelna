using System;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class SpriteSheetPlayer : MonoBehaviour
{
	private Image imageRenderer;

	private SpriteRenderer spriteRenderer;

	private Texture2D spriteSheet;

	public Vector2Int gridSize;

	public float duration;

	public bool allowAnimationComplete = true;

	public int loopCount = -1;

	public float loopDelay;

	public LoopType method;

	public Vector2Int frameRange;

	public Sprite[] sprites;

	private int _currentFrame;

	private Action<int, Sprite> m_OnFrameChanged;

	private Action m_OnCompleted;

	private int FramesCount
	{
		get
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetPlayer)+3C]");
			return (int)(0 * gridSize);
		}
	}

	public float PlaybackProgress
	{
		get
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetPlayer)+3C]");
			object obj = 0 * gridSize;
			return (float)_currentFrame / (float)obj;
		}
	}

	public Texture2D SpriteSheet => spriteSheet;

	private Vector2Int ActualFrameRange
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0083: Expected O, but got I
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			object obj = typeof(UsageHint) + 768;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+B8]");
			object obj3 = 0;
			if ((object)frameRange == obj3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetPlayer)+3C]");
				object obj4 = 0 * gridSize;
				return (Vector2Int)(4294967295L + obj4);
			}
			object obj5 = (object)frameRange >> 32;
			return (Vector2Int)((object)frameRange | obj5);
		}
	}

	public event Action<int, Sprite> OnFrameChanged
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 512;
			object obj2 = this + 112;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 512;
			object obj2 = this + 112;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action OnCompleted
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 120;
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
			object obj2 = this + 120;
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

	public void SetTexture(Texture2D spriteTexture)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		object obj = this + 48;
		obj = spriteTexture;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Sprite[] array = SpriteExensions.CreateSprites((Texture2D)obj, gridSize);
		object obj2 = this + 96;
		obj2 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Play()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01c8: Expected O, but got I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_0212: Expected O, but got I4
		//IL_0162: Expected O, but got I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_0119: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected O, but got Unknown
		//IL_06e0: Expected O, but got I
		//IL_022b: Expected I4, but got O
		//IL_070d: Expected O, but got I
		//IL_0719: Expected O, but got I
		//IL_074d: Expected O, but got I4
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_03d5: Expected O, but got I
		//IL_03e3: Expected I, but got O
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		//IL_0412: Expected O, but got I
		//IL_0420: Expected I, but got O
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected O, but got Unknown
		//IL_02d9: Expected O, but got I
		//IL_02e7: Expected I, but got O
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_07ac: Expected O, but got I
		//IL_0316: Expected O, but got I
		//IL_0324: Expected I, but got O
		//IL_05c1: Expected O, but got I4
		//IL_0773: Expected O, but got I
		//IL_062d: Expected O, but got I
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected I4, but got Unknown
		//IL_0487: Expected O, but got I4
		//IL_04f0: Expected O, but got I4
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected O, but got Unknown
		//IL_055c: Expected O, but got I
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected I4, but got Unknown
		//IL_0386: Expected O, but got I4
		//IL_067c: Expected O, but got I
		//IL_068a: Expected I, but got O
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E78FD]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = spriteSheet;
			obj6 = spriteSheet;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = spriteSheet;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = spriteSheet;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_0608:
		DOGetter<int> dOGetter = default(DOGetter<int>);
		DOSetter<int> dOSetter = default(DOSetter<int>);
		int num;
		float num2;
		TweenerCore<int, int, NoOptions> tweenerCore = DOTween.To(dOGetter, dOSetter, num, num2);
		object obj9 = (nint)0 + (nint)2824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Sequence s2 = default(Sequence);
		Tween t = default(Tween);
		Sequence s = TweenSettingsExtensions.Append(s2, t);
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)2232;
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj11);
		Sequence s3 = TweenSettingsExtensions.AppendCallback(s, tweenCallback);
		Sequence sequence = TweenSettingsExtensions.AppendInterval(s3, loopDelay);
		return;
		IL_0518:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		float num4;
		float num3 = num4;
		int num6;
		int num5 = num6;
		goto IL_0537;
		IL_0167:
		object obj12 = typeof(UsageHint) + 768;
		object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj14 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v11+B8]");
		object obj15 = 0;
		int frame = (((object)frameRange != obj15) ? ((int)frameRange) : 0);
		object obj16 = (nint)0 + (nint)3256;
		object obj17 = (nint)0 + (nint)3064;
		SetFrame(frame);
		object obj18 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v46+E4]");
		bool flag5 = (nint)0 == 0;
		object obj19 = !flag5;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence2 = DOTween.Sequence();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30593E4");
		Sequence s4;
		DOGetter<int> dOGetter2 = default(DOGetter<int>);
		DOSetter<int> dOSetter2 = default(DOSetter<int>);
		if (method == LoopType.Yoyo)
		{
			float interval = loopDelay * 0.5f;
			s4 = TweenSettingsExtensions.AppendInterval(s2, interval);
			object obj20 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj21 = (nint)0 + (nint)2240;
			dOGetter2..ctor((object)this, (IntPtr)obj21);
			object obj22 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj23 = (nint)0 + (nint)2248;
			dOSetter2..ctor((object)this, (IntPtr)obj23);
			object obj24 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v51+B8]");
			object obj25 = 0;
			if ((object)frameRange == obj25)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetPlayer)+3C]");
				object obj26 = 0 * gridSize;
				num5 = (int)(4294967295L + obj26);
				num3 = duration;
				object obj27 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X0_v87+E4]");
				bool flag6 = (nint)0 == 0;
				object obj28 = !flag6;
				if (obj28 == null)
				{
					num4 = duration;
					num6 = num5;
					goto IL_0518;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetPlayer)+58]");
				num6 = 0;
				num4 = duration;
				object obj27 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X0_v87+E4]");
				bool flag7 = (nint)0 == 0;
				object obj29 = !flag7;
				num3 = duration;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetPlayer)+58]");
				num5 = 0;
				if (obj29 == null)
				{
					goto IL_0518;
				}
			}
			goto IL_0537;
		}
		object obj30 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj31 = (nint)0 + (nint)2240;
		dOGetter..ctor((object)this, (IntPtr)obj31);
		object obj32 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj33 = (nint)0 + (nint)2248;
		dOSetter..ctor((object)this, (IntPtr)obj33);
		object obj34 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v26+B8]");
		object obj35 = 0;
		float num7;
		int num8;
		if ((object)frameRange == obj35)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetPlayer)+3C]");
			object obj36 = 0 * gridSize;
			num = (int)(4294967295L + obj36);
			num2 = duration;
			object obj37 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v68+E4]");
			bool flag8 = (nint)0 == 0;
			object obj38 = !flag8;
			if (obj38 == null)
			{
				num7 = duration;
				num8 = num;
				goto IL_05e9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetPlayer)+58]");
			num8 = 0;
			num7 = duration;
			object obj37 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v68+E4]");
			bool flag9 = (nint)0 == 0;
			object obj39 = !flag9;
			num2 = duration;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetPlayer)+58]");
			num = 0;
			if (obj39 == null)
			{
				goto IL_05e9;
			}
		}
		goto IL_0608;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
		return;
		IL_00b7:
		int num9 = ShortcutExtensions.DOKill(this, allowAnimationComplete);
		object obj40 = this + 96;
		object obj41 = obj40;
		object obj43;
		if (obj40 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v7+18]");
			bool flag10 = (nint)0 == 0;
			object obj42 = !flag10;
			obj43 = 0;
			if (obj42 != null)
			{
				goto IL_0167;
			}
		}
		Sprite[] array = SpriteExensions.CreateSprites(spriteSheet, gridSize);
		sprites = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj43 = 0;
		goto IL_0167;
		IL_0537:
		TweenerCore<int, int, NoOptions> tweenerCore2 = DOTween.To(dOGetter2, dOSetter2, num5, num3);
		object obj44 = (nint)0 + (nint)2824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t2 = default(Tween);
		Sequence sequence3 = TweenSettingsExtensions.Append(s4, t2);
		return;
		IL_05e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num2 = num7;
		num = num8;
		goto IL_0608;
	}

	private int GetFrame()
	{
		return _currentFrame;
	}

	private void SetFrame(int frameIndex)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01d7: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		//IL_028b: Expected O, but got I4
		//IL_0159: Expected O, but got I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02d9: Expected O, but got I
		//IL_02f0: Expected O, but got I
		//IL_0324: Expected O, but got I4
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected O, but got Unknown
		//IL_03c7: Expected O, but got I4
		//IL_05c0: Expected O, but got I
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected O, but got Unknown
		//IL_04a5: Expected O, but got I4
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected O, but got Unknown
		//IL_041c: Expected O, but got I
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E78FE]");
		object obj3 = (nint)0 & (nint)1;
		int num;
		UnityEngine.Object obj5;
		int num2;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			num = _currentFrame;
			_currentFrame = frameIndex;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v25+E4]");
			bool flag = (nint)0 == 0;
			obj5 = imageRenderer;
			num2 = _currentFrame;
			obj6 = imageRenderer;
			if (!flag)
			{
				goto IL_00af;
			}
		}
		else
		{
			_ = 1;
			num = _currentFrame;
			_currentFrame = frameIndex;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v25+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = imageRenderer;
			num2 = _currentFrame;
			obj6 = imageRenderer;
			if (obj7 != null)
			{
				goto IL_00af;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		Sprite sprite = null;
		num = num2;
		if (flag4)
		{
			goto IL_00ed;
		}
		goto IL_0245;
		IL_0438:
		Action<int, Sprite> onFrameChanged = this.OnFrameChanged;
		if (this.OnFrameChanged != null)
		{
			Sprite[] array = sprites;
			if (sprites == null)
			{
				goto IL_057a;
			}
			bool flag5 = frameIndex < array.Length;
			object obj8 = !flag5;
			if (obj8 != null)
			{
				goto IL_0588;
			}
			object obj9 = sprites + frameIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v225 @ X8_v6 (System.Action`2<System.Int32, UnityEngine.Sprite>)+18] (should have been resolved before IL gen)");
		}
		object obj10 = typeof(UsageHint) + 768;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v9+B8]");
		object obj12 = 0;
		if ((object)frameRange == obj12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetPlayer)+3C]");
			object obj13 = 0 * gridSize;
			object obj14 = 4294967295L + obj13;
			if (_currentFrame != (nint)obj14)
			{
				return;
			}
		}
		else
		{
			int currentFrame = _currentFrame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetPlayer)+58]");
			if ((nint)currentFrame != 0)
			{
				return;
			}
		}
		Action onCompleted = this.OnCompleted;
		if (this.OnCompleted != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v372.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		return;
		IL_0381:
		Sprite[] array2 = sprites;
		if (sprites != null)
		{
			bool flag6 = _currentFrame < array2.Length;
			object obj15 = !flag6;
			if (obj15 != null)
			{
				goto IL_0588;
			}
			if ((object)spriteRenderer != null)
			{
				object obj16 = sprites + _currentFrame;
				SpriteRenderer obj17 = spriteRenderer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v20+20]");
				obj17.sprite = (Sprite)0;
				if (num2 != frameIndex)
				{
					goto IL_0438;
				}
				return;
			}
		}
		goto IL_057a;
		IL_0136:
		UnityEngine.Object obj18;
		bool flag7 = obj18;
		bool flag8 = !flag7;
		object obj19 = !flag8;
		num2 = num;
		if (obj19 == null)
		{
			goto IL_016f;
		}
		goto IL_0381;
		IL_00af:
		bool flag9 = obj5;
		bool flag10 = !flag9;
		object obj20 = !flag10;
		sprite = null;
		num2 = num;
		if (obj20 == null)
		{
			goto IL_00ed;
		}
		goto IL_0245;
		IL_0245:
		Sprite[] array3 = sprites;
		UnityEngine.Object obj25;
		object obj23;
		if (sprites != null)
		{
			bool flag11 = _currentFrame < array3.Length;
			object obj21 = !flag11;
			if (obj21 != null)
			{
				goto IL_0588;
			}
			if ((object)imageRenderer != null)
			{
				object obj22 = sprites + _currentFrame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v24+20]");
				sprite = (Sprite)0;
				Image image = imageRenderer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v24+20]");
				image.sprite = (Sprite)0;
				obj18 = spriteRenderer;
				obj23 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v21+E4]");
				bool flag12 = (nint)0 == 0;
				object obj24 = !flag12;
				num = num2;
				obj25 = spriteRenderer;
				if (obj24 != null)
				{
					goto IL_0136;
				}
				goto IL_0344;
			}
		}
		goto IL_057a;
		IL_0588:
		throw new IndexOutOfRangeException();
		IL_057a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0588;
		IL_016f:
		if (num == frameIndex)
		{
			return;
		}
		goto IL_0438;
		IL_00ed:
		obj18 = spriteRenderer;
		obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v21+E4]");
		bool flag13 = (nint)0 == 0;
		obj25 = spriteRenderer;
		num2 = num;
		if (!flag13)
		{
			goto IL_0136;
		}
		goto IL_0344;
		IL_0344:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag14 = obj25;
		bool flag15 = !flag14;
		num = num2;
		if (flag15)
		{
			goto IL_016f;
		}
		goto IL_0381;
	}

	private void <Play>b__27_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004a: Expected O, but got I
		//IL_0031: Expected I4, but got O
		object obj = typeof(UsageHint) + 768;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+B8]");
		object obj3 = 0;
		if ((object)frameRange == obj3)
		{
			SetFrame(0);
		}
		else
		{
			SetFrame((int)frameRange);
		}
	}
}
