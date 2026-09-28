using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ListView;

public abstract class ListViewScroller : MonoBehaviour, IScrollHandler, IEventSystemHandler
{
	protected ListViewControllerBase m_ListView;

	protected bool m_Scrolling;

	protected Vector3 m_StartPosition;

	protected float m_StartOffset;

	protected virtual void OnScrollStarted(Vector3 start)
	{
		//IL_0065: Expected I, but got O
		if (m_Scrolling)
		{
			return;
		}
		m_Scrolling = true;
		Vector3 startPosition = default(Vector3);
		m_StartPosition = startPosition;
		ListViewControllerBase listView = m_ListView;
		m_StartOffset = listView.m_ScrollOffset;
		nint num = (nint)listView;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v30 @ X9_v1 (Il2CppClass<ListView.ListViewControllerBase>)+248] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void OnScroll(Vector3 position)
	{
		if (m_Scrolling)
		{
			ListViewControllerBase listView = m_ListView;
			object obj = default(object);
			float num = (float)obj + m_StartOffset;
			float scrollOffset = num - (float)m_StartPosition;
			listView.m_ScrollOffset = scrollOffset;
		}
	}

	protected virtual void OnScrollEnded()
	{
		//IL_0022: Expected I, but got O
		//IL_0032: Expected O, but got I
		//IL_0042: Expected O, but got I
		m_Scrolling = false;
		ListViewControllerBase listView = m_ListView;
		nint num = (nint)listView;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<ListView.ListViewControllerBase>)+258]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<ListView.ListViewControllerBase>)+260]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void OnScroll(PointerEventData eventData)
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		ListViewControllerBase listView = m_ListView;
		nint num = (nint)listView;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<ListView.ListViewControllerBase>)+268]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<ListView.ListViewControllerBase>)+270]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
