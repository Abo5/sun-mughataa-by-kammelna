using System;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ScrollRectScrollAnimator : MonoBehaviour
{
	private enum Direction
	{
		TopToBottom,
		BottomToTop
	}

	private ScrollRect m_ScrollRect;

	private Direction m_Direction;

	private float m_Duration = 1f;

	private Ease m_Ease;

	private float m_StartDelay;

	private int m_Loops = 1;

	private LoopType m_LoopType;

	private bool m_PlayOnEnable = true;

	private UnityEvent m_OnComplete;

	private Tween m_Tween;

	private const float TOP = 1f;

	private const float BOTTOM = 0f;

	private bool IsLooping
	{
		get
		{
			//IL_001c: Expected O, but got I4
			//IL_002c: Expected O, but got I4
			//IL_0046: Expected O, but got I4
			//IL_0053: Expected I4, but got O
			bool flag = m_Loops < 1;
			object obj = !flag;
			object obj2 = m_Loops - 1;
			bool flag2 = obj2 == null;
			object obj3 = !flag2;
			return (byte)(obj & obj3) != 0;
		}
	}

	public bool IsPlaying
	{
		get
		{
			//IL_000b: Expected I4, but got O
			//IL_0034: Expected I4, but got O
			if ((int)(~m_Tween) == 0)
			{
				return TweenExtensions.IsActive(m_Tween);
			}
			return (byte)(int)m_Tween != 0;
		}
	}

	private void OnEnable()
	{
		if (m_PlayOnEnable)
		{
			Play();
		}
	}

	private void OnDisable()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_003f: Expected O, but got I4
		object obj = this + 80;
		if (obj != null)
		{
			TweenExtensions.Kill((Tween)obj);
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public void Play()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0146: Expected O, but got I4
		//IL_0193: Expected O, but got I4
		//IL_01cd: Expected F8, but got I4
		//IL_01ff: Expected F4, but got I4
		//IL_0346: Expected O, but got I
		//IL_0210: Expected O, but got I
		//IL_0236: Expected O, but got I4
		//IL_0246: Expected O, but got I4
		//IL_0260: Expected O, but got I4
		//IL_0361: Expected O, but got I
		//IL_0377: Expected O, but got I
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected O, but got Unknown
		//IL_02ad: Expected O, but got I
		//IL_02bb: Expected I, but got O
		//IL_02c7: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74DE]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object scrollRect;
		UnityEngine.Object scrollRect2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v20+E4]");
			bool flag = (nint)0 == 0;
			scrollRect = m_ScrollRect;
			scrollRect2 = m_ScrollRect;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			scrollRect = m_ScrollRect;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v20+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			scrollRect2 = m_ScrollRect;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = scrollRect2 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0154;
		IL_0154:
		object obj7 = this + 80;
		if (obj7 != null)
		{
			TweenExtensions.Kill((Tween)obj7);
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		double num = ((m_Direction != Direction.TopToBottom) ? 1.0 : 0.0);
		float verticalNormalizedPosition = ((m_Direction != Direction.TopToBottom) ? 0f : 1f);
		m_ScrollRect.verticalNormalizedPosition = verticalNormalizedPosition;
		Tweener tweener = DOTweenModuleUI.DOVerticalNormalizedPos(m_ScrollRect, (float)num, m_Duration);
		object obj8 = (nint)0 + (nint)2800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		object obj9 = (nint)0 + (nint)2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		bool flag5 = m_Loops < 1;
		object obj10 = !flag5;
		object obj11 = m_Loops - 1;
		bool flag6 = obj11 == null;
		object obj12 = !flag6;
		object obj13 = obj10 & obj12;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			int loops = m_Loops;
		}
		else
		{
			int loops = 1;
		}
		object obj15 = (nint)0 + (nint)3080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30593E4");
		object obj16 = (nint)0 + (nint)3272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
		object obj17 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)1384;
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj18);
		object obj19 = (nint)0 + (nint)2528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		Tween tween = default(Tween);
		m_Tween = tween;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0091:
		if (scrollRect == null)
		{
			return;
		}
		goto IL_0154;
	}

	public void Stop()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_003f: Expected O, but got I4
		object obj = this + 80;
		if (obj != null)
		{
			TweenExtensions.Kill((Tween)obj);
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private void HandleComplete()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0034: Expected O, but got I
		object obj = this + 80;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X19_v2-8]");
		((UnityEvent)0).Invoke();
	}

	private void Reset()
	{
		//IL_000c: Expected O, but got I
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1112;
		object obj2 = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
	}
}
