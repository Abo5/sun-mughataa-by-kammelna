using System;
using Cpp2ILInjected;
using ListView;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.EventSystems;

public class ListViewMouseScroller : ListViewScroller, IScrollHandler, IEventSystemHandler, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
	private float m_ScrollWheelSpeed = 1f;

	private Camera _mainCamera;

	private float m_ListDepth;

	private Vector3 screenPoint;

	private void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = (nint)0 + (nint)408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
		Canvas canvas = default(Canvas);
		Camera worldCamera = canvas.worldCamera;
		object obj2 = this + 64;
		obj2 = worldCamera;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public new void OnScroll(PointerEventData eventData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I
		//IL_010f: Invalid comparison between F8 and I4
		//IL_011e: Invalid comparison between F8 and I4
		//IL_0131: Expected O, but got F8
		//IL_013e: Expected O, but got F8
		//IL_0173: Expected O, but got I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_01aa: Invalid comparison between I4 and F8
		//IL_007c: Expected I, but got O
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4024;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v4+B8]");
		object obj3 = 0;
		object obj4 = default(object);
		double num = (double)obj4 * 897988541.0;
		double num2 = (double)obj3 * 8.0;
		double num3 = num - num2;
		bool flag = num3 < 0.0;
		bool flag2 = num3 == 0.0;
		object obj5 = num ^ num2;
		object obj6 = num ^ num3;
		object obj7 = obj5 & obj6;
		bool flag3 = (nint)obj7 < 0;
		bool flag4 = flag == flag3;
		object obj8 = !flag2;
		object obj9 = flag4 & obj8;
		object obj10 = ~obj9;
		if (obj10 != null)
		{
			num = num2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		if (!(0.0 < num))
		{
			ListViewControllerBase listView = m_ListView;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [eventData @ X1 (UnityEngine.EventSystems.PointerEventData)+180]");
			float num4 = 0f * m_ScrollWheelSpeed;
			float scrollOffset = listView.m_ScrollOffset + num4;
			listView.m_ScrollOffset = scrollOffset;
			nint num5 = (nint)listView;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v8 (Il2CppClass<ListView.ListViewControllerBase>)+258]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v8 (Il2CppClass<ListView.ListViewControllerBase>)+260]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v146 @ X2_v1 (should have been resolved before IL gen)");
		}
	}

	protected override void OnScroll(Vector3 position)
	{
		if (m_Scrolling)
		{
			ListViewControllerBase listView = m_ListView;
			Transform transform = base.transform;
			Vector3 lossyScale = transform.lossyScale;
			object obj2 = default(object);
			object obj = (object)m_StartPosition - obj2;
			object obj3 = obj / obj2;
			float scrollOffset = m_StartOffset + (float)obj3;
			listView.m_ScrollOffset = scrollOffset;
		}
	}

	public void OnDrag(PointerEventData eventData)
	{
		//IL_0038: Expected O, but got I4
		//IL_0041: Expected I, but got O
		screenPoint = eventData.<position>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [eventData @ X1 (UnityEngine.EventSystems.PointerEventData)+148]");
		_ = 0;
		_ = m_ListDepth;
		Vector3 vector = _mainCamera.ScreenToWorldPoint((Vector3)0);
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v42 @ X8_v1 (Il2CppClass<ListViewMouseScroller>)+198] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		//IL_0096: Expected O, but got I4
		//IL_009f: Expected I, but got O
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Transform transform2 = _mainCamera.transform;
		Vector3 position2 = transform2.position;
		object obj = default(object);
		float listDepth = (float)obj - (float)obj;
		m_ListDepth = listDepth;
		screenPoint = eventData.<position>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [eventData @ X1 (UnityEngine.EventSystems.PointerEventData)+148]");
		_ = 0;
		Vector3 vector = _mainCamera.ScreenToWorldPoint((Vector3)0);
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v66 @ X8_v1 (Il2CppClass<ListViewMouseScroller>)+188] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private Vector3 GetWorldPoint(Vector2 pointerPosition)
	{
		//IL_0045: Expected O, but got I4
		Vector3 vector = default(Vector3);
		screenPoint = vector;
		_ = m_ListDepth;
		if ((object)_mainCamera != null)
		{
			return _mainCamera.ScreenToWorldPoint((Vector3)0);
		}
		return (Vector3)new NullReferenceException();
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<ListViewMouseScroller>)+1A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<ListViewMouseScroller>)+1B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		//IL_0038: Expected O, but got I4
		//IL_0041: Expected I, but got O
		screenPoint = eventData.<position>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [eventData @ X1 (UnityEngine.EventSystems.PointerEventData)+148]");
		_ = 0;
		_ = m_ListDepth;
		Vector3 vector = _mainCamera.ScreenToWorldPoint((Vector3)0);
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v42 @ X8_v1 (Il2CppClass<ListViewMouseScroller>)+188] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void Reset()
	{
		//IL_000c: Expected O, but got I
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1032;
		object obj2 = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
	}
}
