using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Device;

public class ScreenCutoutFixer : MonoBehaviour
{
	private enum FixMode
	{
		MoveDown,
		ShrinkDown,
		ExpendDown,
		MoveUp,
		ShrinkUp,
		ExpendUp,
		FullShrink
	}

	private FixMode mode;

	private float extraMargin;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_005e: Expected O, but got I8
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect safeArea = UnityEngine.Device.Screen.safeArea;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int height = UnityEngine.Device.Screen.height;
		object obj5 = default(object);
		object obj4 = (((nint)obj5 != 2139095040) ? obj5 : ((object)2147483648L));
		if ((nint)obj4 != height)
		{
			InitFix();
		}
	}

	private void InitFix()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_0171: Expected O, but got I4
		float topCutoutSize = ScreenUtility.TopCutoutSize;
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74E4]");
		object obj2 = (nint)0 & (nint)1;
		object obj4;
		object obj5 = default(object);
		object obj6;
		if (obj2 != null)
		{
			Rect safeArea = UnityEngine.Device.Screen.safeArea;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			obj4 = obj5;
			obj6 = obj5;
			object obj7 = obj3;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Rect safeArea2 = UnityEngine.Device.Screen.safeArea;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			obj4 = obj5;
			obj6 = obj5;
			object obj7 = obj3;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isTablet = ScreenUtility.IsTablet;
		bool flag3 = !isTablet;
		object obj9 = !flag3;
		obj4 = obj6;
		if (obj9 != null)
		{
			goto IL_00cd;
		}
		goto IL_0188;
		IL_019e:
		float topDistance = topCutoutSize + extraMargin;
		float num2;
		float num = (float)obj4 * num2;
		float bottomDistance = num + extraMargin;
		Fix(topDistance, bottomDistance);
		return;
		IL_00cd:
		num2 = ScreenUtility.ExpandScaleFactor;
		goto IL_019e;
		IL_0188:
		num2 = ScreenUtility.ShrinkScaleFactor;
		obj4 = obj6;
		goto IL_019e;
		IL_009e:
		isTablet = ScreenUtility.IsTablet;
		bool flag4 = !isTablet;
		obj6 = obj4;
		if (!flag4)
		{
			goto IL_00cd;
		}
		goto IL_0188;
	}

	private void Fix(float topDistance, float bottomDistance)
	{
		//IL_000c: Expected O, but got I
		//IL_0182: Expected O, but got I4
		//IL_022b: Expected O, but got I4
		//IL_021c: Expected O, but got I4
		//IL_0112: Expected O, but got I4
		//IL_015c: Expected O, but got I4
		//IL_0209: Expected O, but got I4
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01c9: Expected O, but got I
		object obj = (nint)0 + (nint)4040;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		RectTransform rectTransform = default(RectTransform);
		Vector2 offsetMax = rectTransform.offsetMax;
		Vector2 offsetMin = rectTransform.offsetMin;
		if (mode > FixMode.ExpendDown)
		{
			if (mode <= FixMode.ShrinkUp)
			{
				if (mode != FixMode.MoveUp)
				{
					if (mode != FixMode.ShrinkUp)
					{
						goto IL_0187;
					}
					goto IL_021d;
				}
			}
			else
			{
				if (mode == FixMode.ExpendUp)
				{
					goto IL_020e;
				}
				bool flag = mode != FixMode.FullShrink;
				obj2 = 0;
				if (flag)
				{
					goto IL_0187;
				}
			}
			rectTransform.offsetMax = (Vector2)0;
		}
		else if (mode != FixMode.MoveDown)
		{
			if (mode == FixMode.ShrinkDown)
			{
				goto IL_020e;
			}
			bool flag2 = mode != FixMode.ExpendDown;
			obj2 = 0;
			if (flag2)
			{
				goto IL_0187;
			}
		}
		else
		{
			rectTransform.offsetMax = (Vector2)0;
		}
		goto IL_021d;
		IL_021d:
		rectTransform.offsetMin = (Vector2)0;
		return;
		IL_0187:
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		ex..ctor();
		object obj4 = (nint)0 + (nint)1016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
		IL_020e:
		rectTransform.offsetMax = (Vector2)0;
	}

	public bool WillChangePosition()
	{
		//IL_0179: Expected I4, but got O
		//IL_0211: Expected O, but got I4
		//IL_023f: Expected O, but got I4
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_0283: Expected O, but got I4
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		RectTransform rectTransform = UIExtensions.rectTransform(this);
		if ((object)rectTransform != null)
		{
			Vector2 pivot = rectTransform.pivot;
			float num = default(float);
			bool flag = FloatExtensions.IsNearlyEqualTo(num, 1f, 0.01f);
			Vector2 pivot2 = rectTransform.pivot;
			bool flag2 = FloatExtensions.IsNearlyEqualTo(1f, 0f, 0.01f);
			Vector2 pivot3 = rectTransform.pivot;
			bool flag3 = FloatExtensions.IsNearlyEqualTo(0f, 0.5f, 0.01f);
			bool flag4 = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			bool flag5 = (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
			bool result = (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
			if (mode != FixMode.FullShrink)
			{
				result = true;
			}
			if (mode == FixMode.ExpendUp)
			{
				result = flag5;
			}
			if (mode == FixMode.ShrinkUp)
			{
				result = flag4;
			}
			bool result2 = mode != FixMode.ExpendDown || flag4;
			if (mode == FixMode.ShrinkDown)
			{
				result2 = flag5;
			}
			object obj = mode - 3;
			bool flag6 = (nint)obj < 0;
			bool flag7 = obj == null;
			object obj2 = mode ^ FixMode.MoveUp;
			object obj3 = mode ^ obj;
			object obj4 = obj2 & obj3;
			bool flag8 = (nint)obj4 < 0;
			bool flag9 = flag6 == flag8;
			object obj5 = !flag7;
			object obj6 = flag9 & obj5;
			object obj7 = ~obj6;
			if (obj7 == null)
			{
				return result;
			}
			return result2;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
