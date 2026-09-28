using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Device;

public class WindowRectTransformSize : MonoBehaviour
{
	private float _widthRatio;

	private float _heightRatio;

	private float _horizontalShiftRatio;

	private float _verticalShiftRatio;

	private RectTransform _rectTransform;

	private Canvas _canvas;

	private void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_0018: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		object obj = (nint)0 + (nint)4040;
		object obj2 = (nint)0 + (nint)408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj3 = this + 48;
		object obj4 = default(object);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
		object obj5 = this + 56;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UpdateRectTransform();
	}

	private void Update()
	{
		UpdateRectTransform();
	}

	private void UpdateRectTransform()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01d5: Expected O, but got I4
		//IL_00c4: Expected O, but got I4
		//IL_00cd: Expected O, but got I4
		//IL_00db: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0254: Expected O, but got I
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_02b4: Expected O, but got I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0224: Expected O, but got I4
		//IL_023a: Expected O, but got I4
		//IL_016d: Expected O, but got I4
		//IL_0176: Expected O, but got I4
		//IL_0346: Expected O, but got I
		//IL_031b: Expected O, but got I4
		//IL_040a: Expected O, but got I4
		//IL_0482: Invalid comparison between F4 and I4
		//IL_0493: Expected O, but got I4
		//IL_049c: Invalid comparison between F4 and I4
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_04d4: Expected O, but got I4
		//IL_04f1: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7404]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		Object obj5;
		Object obj7;
		object obj8;
		if (obj3 != null)
		{
			obj4 = this + 48;
			obj5 = (Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v33+E4]");
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
			obj4 = this + 48;
			obj5 = (Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v33+E4]");
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
		object obj10 = 0;
		Object obj11 = null;
		obj4 = obj8;
		object obj12 = 0;
		if (flag4)
		{
			goto IL_00f1;
		}
		goto IL_0248;
		IL_0421:
		int width = UnityEngine.Device.Screen.width;
		int height = UnityEngine.Device.Screen.height;
		int num = width / height;
		if (num < 1068149419)
		{
		}
		float scaleFactor = _canvas.scaleFactor;
		bool flag5 = scaleFactor < 0f;
		object obj13 = !flag5;
		bool flag6 = scaleFactor == 0f;
		object obj14 = ~obj13;
		object obj15 = obj14 | flag6;
		if (obj15 == null)
		{
			((RectTransform)obj8).sizeDelta = (Vector2)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			((RectTransform)obj8).anchoredPosition = (Vector2)0;
		}
		return;
		IL_033a:
		object obj16 = (nint)0 + (nint)408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
		Canvas canvas = default(Canvas);
		_canvas = canvas;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v17+E4]");
		if ((nint)0 != 0)
		{
			bool flag7 = _canvas == null;
			bool flag8 = !flag7;
			obj8 = obj4;
			if (!flag8)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag9 = _canvas == null;
			bool flag10 = !flag9;
			object obj18 = !flag10;
			obj8 = obj4;
			if (obj18 != null)
			{
				return;
			}
		}
		goto IL_0421;
		IL_0149:
		Object obj19;
		bool flag11 = obj19 == null;
		bool flag12 = !flag11;
		object obj20 = !flag12;
		object obj21 = 0;
		if (obj20 != null)
		{
			goto IL_033a;
		}
		obj8 = obj4;
		goto IL_0421;
		IL_00a0:
		bool flag13 = obj5 == null;
		bool flag14 = !flag13;
		object obj22 = !flag14;
		obj10 = 0;
		obj11 = null;
		obj12 = 0;
		obj8 = obj4;
		if (obj22 == null)
		{
			goto IL_00f1;
		}
		goto IL_0248;
		IL_0248:
		object obj23 = (nint)0 + (nint)4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Object obj24 = default(Object);
		_rectTransform = (RectTransform)obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj25 = this + 56;
		obj19 = (Object)obj25;
		object obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v23+E4]");
		bool flag15 = (nint)0 == 0;
		object obj27 = !flag15;
		obj4 = obj8;
		Object obj28 = (Object)obj25;
		obj10 = obj12;
		obj11 = obj24;
		object obj29 = obj25;
		if (obj27 != null)
		{
			goto IL_0149;
		}
		goto IL_02ea;
		IL_00f1:
		obj25 = this + 56;
		obj19 = (Object)obj25;
		obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v23+E4]");
		bool flag16 = (nint)0 == 0;
		obj28 = (Object)obj25;
		obj29 = obj25;
		obj8 = obj4;
		if (!flag16)
		{
			goto IL_0149;
		}
		goto IL_02ea;
		IL_02ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag17 = obj28 == null;
		bool flag18 = !flag17;
		obj21 = 0;
		obj25 = obj29;
		obj4 = obj8;
		if (!flag18)
		{
			goto IL_033a;
		}
		goto IL_0421;
	}

	public WindowRectTransformSize()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252EC0]");
		_widthRatio = 0f;
		_horizontalShiftRatio = 0.21302083f;
		base..ctor();
	}
}
