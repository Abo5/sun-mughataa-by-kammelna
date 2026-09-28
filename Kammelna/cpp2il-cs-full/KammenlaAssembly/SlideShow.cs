using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public class SlideShow : MonoBehaviour
{
	private int tabCount;

	private RectTransform body;

	private DiscreteProgressIndicator pagination;

	private int currentTab;

	private Canvas _canvas;

	private float tabWidth
	{
		get
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected I4, but got Unknown
			Vector2 sizeDelta = body.sizeDelta;
			Canvas go = canvas;
			RectTransform rectTransform = UIExtensions.rectTransform(go);
			Vector3 localScale = rectTransform.localScale;
			object obj = default(object);
			int num = obj / tabCount;
			return (float)num * (float)obj;
		}
	}

	private Canvas canvas
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected O, but got Unknown
			//IL_012b: Expected O, but got I4
			//IL_00c4: Expected O, but got I4
			//IL_00cd: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_019c: Expected O, but got I
			//IL_0182: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7AD5]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			Object obj5;
			Object obj7;
			object obj8;
			if (obj3 != null)
			{
				obj4 = this + 64;
				obj5 = (Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				obj7 = (Object)obj4;
				obj8 = obj4;
				if (!flag)
				{
					goto IL_00a0;
				}
			}
			else
			{
				_ = 1;
				obj4 = this + 64;
				obj5 = (Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				obj7 = (Object)obj4;
				obj8 = obj4;
				if (obj9 != null)
				{
					goto IL_00a0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj7 == null;
			bool flag4 = !flag3;
			obj4 = obj8;
			object obj10 = 0;
			if (flag4)
			{
				goto IL_00e3;
			}
			goto IL_0190;
			IL_00e3:
			return (Canvas)obj4;
			IL_0190:
			object obj11 = (nint)0 + (nint)408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
			Canvas canvas = default(Canvas);
			_canvas = canvas;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (Canvas)obj8;
			IL_00a0:
			bool flag5 = obj5 == null;
			bool flag6 = !flag5;
			object obj12 = !flag6;
			obj10 = 0;
			obj8 = obj4;
			if (obj12 == null)
			{
				goto IL_00e3;
			}
			goto IL_0190;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public void OnSlide(SwipeGesture gest)
	{
		//IL_0079: Expected I4, but got I8
		if ((nint)gest.SwipeDirection > 0)
		{
			int index = currentTab + 1;
			SlideTo(index);
		}
		else if ((nint)gest.SwipeDirection < 0)
		{
			int index2 = (int)(currentTab + 4294967295L);
			SlideTo(index2);
		}
	}

	private void SlideTo(int index)
	{
		//IL_001d: Expected O, but got I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected I4, but got Unknown
		//IL_007b: Expected O, but got I4
		//IL_01d4: Expected O, but got I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected I4, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		int num = tabCount - 1;
		object obj = index - num;
		bool flag = (nint)obj < 0;
		int num2 = index ^ num;
		int num3 = index ^ obj;
		int num4 = num2 & num3;
		bool flag2 = num4 < 0;
		bool flag3 = flag == flag2;
		object obj2 = !flag3;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			num = index;
		}
		bool flag4 = index < 0;
		int num5 = index ^ index;
		int num6 = index & num5;
		bool flag5 = num6 < 0;
		bool flag6 = flag4 == flag5;
		object obj4 = !flag6;
		object obj5 = ~obj4;
		int num7 = ((obj5 != null) ? num : 0);
		if (num7 != currentTab)
		{
			Vector2 sizeDelta = body.sizeDelta;
			Canvas go = canvas;
			RectTransform rectTransform = UIExtensions.rectTransform(go);
			Vector3 localScale = rectTransform.localScale;
			object obj6 = default(object);
			int num8 = obj6 / tabCount;
			object obj7 = num8 * obj6;
			float endValue = (float)obj7 * (float)num7;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOMoveX(body, endValue, 0.4f);
			currentTab = num7;
			DiscreteProgressIndicator discreteProgressIndicator = pagination;
			int currentProgress = num7 + 1;
			discreteProgressIndicator.currentProgress = currentProgress;
			discreteProgressIndicator.UpdateProgress();
		}
	}
}
