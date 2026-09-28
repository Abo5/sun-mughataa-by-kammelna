using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions;

public class ScrollRectMultiTouchFix : ScrollRect
{
	private int pid = -100;

	public override void OnBeginDrag(PointerEventData eventData)
	{
		pid = eventData.<pointerId>k__BackingField;
		base.OnBeginDrag(eventData);
	}

	public override void OnDrag(PointerEventData eventData)
	{
		if (pid == eventData.<pointerId>k__BackingField)
		{
			base.OnDrag(eventData);
		}
	}

	public override void OnEndDrag(PointerEventData eventData)
	{
		//IL_000f: Expected I4, but got I8
		pid = -100;
		base.OnEndDrag(eventData);
	}
}
