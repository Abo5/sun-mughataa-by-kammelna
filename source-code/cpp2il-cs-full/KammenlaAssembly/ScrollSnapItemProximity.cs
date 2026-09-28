using Cpp2ILInjected;
using UnityEngine;

public struct ScrollSnapItemProximity
{
	public readonly RectTransform Item;

	public readonly float Proximity;

	public ScrollSnapItemProximity(RectTransform item, float proximity)
	{
		Item = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Proximity = proximity;
	}
}
