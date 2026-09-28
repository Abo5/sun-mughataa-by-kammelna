using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class ScrollPositionPreserver : MonoBehaviour
{
	private class ResizeHandler : MonoBehaviour
	{
		private Action m_OnDimensionsChanged;

		public event Action OnDimensionsChanged
		{
			add
			{
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_009d: Expected O, but got Unknown
				//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a8: Expected O, but got Unknown
				object obj = typeof(SqlSingle[]) + 2376;
				object obj2 = this + 32;
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
				object obj2 = this + 32;
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

		private void OnRectTransformDimensionsChange()
		{
			Action onDimensionsChanged = this.OnDimensionsChanged;
			if (this.OnDimensionsChanged != null)
			{
				IntPtr invoke_impl = ((Delegate)onDimensionsChanged).invoke_impl;
				IntPtr method_code = ((Delegate)onDimensionsChanged).method_code;
				IntPtr method = ((Delegate)onDimensionsChanged).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private ScrollRect _scrollRect;

	private RectTransform _content;

	private RectTransform _viewport;

	private ResizeHandler _resizeHandler;

	private Vector2 _savedAbsoluteOffset;

	private bool _initialized;

	private void Awake()
	{
		//IL_0006: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 32;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void Start()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0037: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_007a: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_00e4: Expected O, but got I
		//IL_018b: Expected O, but got I
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_01a0: Expected O, but got I
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_0278: Expected O, but got I4
		//IL_0281: Expected O, but got I4
		//IL_021d: Expected O, but got I4
		//IL_0226: Expected O, but got I4
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_0303: Expected O, but got I
		//IL_031b: Expected I, but got O
		//IL_02b2: Expected O, but got I
		//IL_023d: Expected O, but got I4
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		ScrollRect scrollRect = _scrollRect;
		object obj = this + 40;
		obj = scrollRect.m_Content;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X20_v5-8]");
		object obj2 = 0;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v6+40]");
		bool flag2 = (UnityEngine.Object)0 != null;
		Component scrollRect2 = _scrollRect;
		Transform transform;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v13 (UnityEngine.Component)+40]");
			transform = (Transform)0;
		}
		else
		{
			Transform transform2 = _scrollRect.transform;
			bool flag3 = (object)transform2 == null;
			transform = transform2;
			if (!flag3)
			{
				object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
				bool flag4 = transform2 != obj6;
				transform = transform2;
				if (flag4)
				{
					throw new InvalidCastException();
				}
			}
		}
		object obj7 = this + 48;
		obj7 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X21_v5-8]");
		GameObject gameObject = ((Component)0).gameObject;
		object obj8 = (nint)0 + (nint)1512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		object obj9 = this + 56;
		object obj10 = default(object);
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v22+E4]");
		object obj13;
		object obj14;
		UnityEngine.Object obj15;
		if ((nint)0 != 0)
		{
			bool flag5 = (UnityEngine.Object)obj9 == null;
			bool flag6 = !flag5;
			object obj12 = !flag6;
			obj13 = 0;
			if (obj12 != null)
			{
				goto IL_0294;
			}
			obj14 = 0;
			obj15 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = (UnityEngine.Object)obj9 == null;
			bool flag8 = !flag7;
			obj13 = 0;
			obj14 = 0;
			obj15 = null;
			if (!flag8)
			{
				goto IL_0294;
			}
		}
		goto IL_02e3;
		IL_02e3:
		object obj16 = typeof(SqlSingle[]) + 2376;
		object obj17 = (nint)0 + (nint)1360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj17);
		object obj18 = _resizeHandler + 32;
		Delegate obj19 = (Delegate)obj18;
		bool flag9;
		Delegate obj21 = default(Delegate);
		do
		{
			Delegate obj20 = Delegate.Combine(obj19, action);
			if ((object)obj20 == null || obj20 == obj16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag9 = (object)obj21 == obj19;
				obj19 = obj21;
				continue;
			}
			throw new InvalidCastException();
		}
		while (!flag9);
		_scrollRect.verticalNormalizedPosition = 1f;
		_initialized = true;
		SaveOffset();
		return;
		IL_0294:
		GameObject gameObject2 = ((Component)obj).gameObject;
		object obj22 = (nint)0 + (nint)1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
		UnityEngine.Object obj23 = default(UnityEngine.Object);
		obj9 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj14 = obj13;
		obj15 = obj23;
		goto IL_02e3;
	}

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3808;
		object obj2 = (nint)0 + (nint)1352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Canvas.WillRenderCanvases willRenderCanvases = default(Canvas.WillRenderCanvases);
		willRenderCanvases..ctor(this, (IntPtr)obj2);
		Canvas.willRenderCanvases += willRenderCanvases;
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3808;
		object obj2 = (nint)0 + (nint)1352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Canvas.WillRenderCanvases willRenderCanvases = default(Canvas.WillRenderCanvases);
		willRenderCanvases..ctor(this, (IntPtr)obj2);
		Canvas.willRenderCanvases -= willRenderCanvases;
	}

	private void OnDestroy()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_018c: Expected O, but got I
		//IL_01a4: Expected I, but got O
		//IL_0159: Expected O, but got I4
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7545]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object resizeHandler;
		UnityEngine.Object resizeHandler2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			resizeHandler = _resizeHandler;
			resizeHandler2 = _resizeHandler;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			resizeHandler = _resizeHandler;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			resizeHandler2 = _resizeHandler;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = resizeHandler2 != null;
		bool flag4 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		if (!flag4)
		{
			goto IL_016c;
		}
		return;
		IL_016c:
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)1360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj9);
		object obj10 = _resizeHandler + 32;
		Delegate obj11 = (Delegate)obj10;
		bool flag5;
		Delegate obj13 = default(Delegate);
		do
		{
			Delegate obj12 = Delegate.Remove(obj11, action);
			if ((object)obj12 == null || obj12 == obj8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag5 = (object)obj13 == obj11;
				obj11 = obj13;
				continue;
			}
			throw new InvalidCastException();
		}
		while (!flag5);
		return;
		IL_0091:
		bool flag6 = resizeHandler != null;
		bool flag7 = !flag6;
		object obj14 = !flag7;
		obj6 = 0;
		obj7 = null;
		if (obj14 == null)
		{
			return;
		}
		goto IL_016c;
	}

	private void OnBeforeCanvasRender()
	{
		if (_initialized)
		{
			SaveOffset();
		}
	}

	private void SaveOffset()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		//IL_00f5: Expected O, but got I4
		//IL_0186: Expected O, but got F4
		//IL_0110: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect rect = _content.rect;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Rect rect2 = _viewport.rect;
		Rect rect3 = _content.rect;
		Rect rect4 = _viewport.rect;
		float horizontalNormalizedPosition = _scrollRect.horizontalNormalizedPosition;
		object obj5 = default(object);
		object obj4 = obj5 - obj5;
		object obj6 = (((nint)obj4 >= 0) ? obj4 : ((object)0));
		object obj8 = default(object);
		object obj7 = obj8 - obj8;
		object obj9 = (((nint)obj7 >= 0) ? obj7 : ((object)0));
		float verticalNormalizedPosition = _scrollRect.verticalNormalizedPosition;
		float num = (float)obj9 * horizontalNormalizedPosition;
		float num2 = (float)obj6 * verticalNormalizedPosition;
		_savedAbsoluteOffset = (Vector2)num;
	}

	private void RestoreOffset()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0101: Invalid comparison between F4 and I4
		//IL_0386: Expected F4, but got I4
		//IL_0121: Expected F4, but got I4
		//IL_0240: Invalid comparison between F4 and I4
		//IL_0252: Expected F4, but got I4
		//IL_0161: Invalid comparison between F8 and I4
		//IL_0170: Invalid comparison between F8 and I4
		//IL_0188: Expected O, but got F8
		//IL_0195: Expected O, but got F8
		//IL_01ca: Expected O, but got I4
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_0294: Invalid comparison between F8 and I4
		//IL_02a3: Invalid comparison between F8 and I4
		//IL_02bb: Expected O, but got F8
		//IL_02c8: Expected O, but got F8
		//IL_02fd: Expected O, but got I4
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_039d: Invalid comparison between F8 and I4
		//IL_03bd: Invalid comparison between F4 and I4
		//IL_0216: Expected F4, but got I4
		//IL_0349: Expected F4, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect rect = _content.rect;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Rect rect2 = _viewport.rect;
		object obj5 = default(object);
		object obj4 = obj5 - obj5;
		object obj6 = (((nint)obj4 >= 0) ? obj4 : ((object)0));
		Rect rect3 = _content.rect;
		Rect rect4 = _viewport.rect;
		object obj7 = default(object);
		float num = (float)obj7 - (float)obj7;
		float num2 = ((!(num < 0f)) ? num : 0f);
		bool flag2 = (nint)obj6 <= 0;
		float horizontalNormalizedPosition = 0f;
		if (!flag2)
		{
			double num3 = (double)_savedAbsoluteOffset / (double)obj6;
			double num4 = num3 - 1.0;
			bool flag3 = num4 < 0.0;
			bool flag4 = num4 == 0.0;
			object obj8 = num3 ^ 1.0;
			object obj9 = num3 ^ num4;
			object obj10 = obj8 & obj9;
			bool flag5 = (nint)obj10 < 0;
			bool flag6 = flag3 == flag5;
			object obj11 = !flag4;
			object obj12 = flag6 & obj11;
			object obj13 = ~obj12;
			double num5 = ((obj13 != null) ? num3 : 1.0);
			horizontalNormalizedPosition = ((!(num3 < 0.0)) ? ((float)num5) : 0f);
		}
		_scrollRect.horizontalNormalizedPosition = horizontalNormalizedPosition;
		bool flag7 = !(num2 > 0f);
		float verticalNormalizedPosition = 0f;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ScrollPositionPreserver)+44]");
			float num6 = 0f / num2;
			double num7 = (double)num6 - 1.0;
			bool flag8 = num7 < 0.0;
			bool flag9 = num7 == 0.0;
			object obj14 = (double)num6 ^ 1.0;
			object obj15 = (double)num6 ^ num7;
			object obj16 = obj14 & obj15;
			bool flag10 = (nint)obj16 < 0;
			bool flag11 = flag8 == flag10;
			object obj17 = !flag9;
			object obj18 = flag11 & obj17;
			object obj19 = ~obj18;
			double num8 = ((obj19 != null) ? ((double)num6) : 1.0);
			verticalNormalizedPosition = ((!(num6 < 0f)) ? ((float)num8) : 0f);
		}
		_scrollRect.verticalNormalizedPosition = verticalNormalizedPosition;
	}
}
