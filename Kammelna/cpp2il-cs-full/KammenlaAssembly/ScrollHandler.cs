using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScrollHandler : MonoBehaviour, IScrollHandler, IEventSystemHandler
{
	private const float Threshold = 0.5f;

	public Action<PointerEventData> OnScrollBegin;

	public Action<PointerEventData> OnScrollChanged;

	public Action OnScrollEnd;

	private bool scrolling;

	private float timer;

	private void Update()
	{
		if (!scrolling)
		{
			return;
		}
		float deltaTime = Time.deltaTime;
		if ((double)(timer += deltaTime) > 0.5)
		{
			scrolling = false;
			Action onScrollEnd = OnScrollEnd;
			if (OnScrollEnd != null)
			{
				IntPtr invoke_impl = ((Delegate)onScrollEnd).invoke_impl;
				IntPtr method_code = ((Delegate)onScrollEnd).method_code;
				IntPtr method = ((Delegate)onScrollEnd).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v81 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public void OnScroll(PointerEventData eventData)
	{
		//IL_00a6: Expected O, but got I
		//IL_00b6: Expected O, but got I
		//IL_00c6: Expected O, but got I
		if (scrolling)
		{
			Action<PointerEventData> onScrollChanged = OnScrollChanged;
			if (OnScrollChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4 @ X9_v2 (System.Action`1<UnityEngine.EventSystems.PointerEventData>)+18] (should have been resolved before IL gen)");
			}
			timer = 0f;
			return;
		}
		timer = 0f;
		scrolling = true;
		Action<PointerEventData> onScrollBegin = OnScrollBegin;
		if (OnScrollBegin != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v4 (System.Action`1<UnityEngine.EventSystems.PointerEventData>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v4 (System.Action`1<UnityEngine.EventSystems.PointerEventData>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v4 (System.Action`1<UnityEngine.EventSystems.PointerEventData>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v62 @ X3_v1 (should have been resolved before IL gen)");
		}
	}
}
