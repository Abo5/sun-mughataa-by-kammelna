using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class SlapCardAnimationV2 : SlapCardAnimationBase
{
	protected override void ApplyStartRotation(Transform playedCard, Quaternion startRotation)
	{
		//IL_000e: Expected O, but got I4
		playedCard.localRotation = (Quaternion)0;
	}

	protected override void OnScaleComplete(SpriteRenderer card, Transform playedCard)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		base.OnGrounded(playedCard);
		int cardOrder = GetCardOrder();
		object obj = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3648;
		int sortingLayerID = SortingLayer.NameToID((string)obj);
		card.sortingLayerID = sortingLayerID;
		card.sortingOrder = cardOrder;
	}

	protected override int GetCardOrder()
	{
		//IL_0032: Expected O, but got I4
		//IL_0205: Expected O, but got I4
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_00d6: Expected O, but got I
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0145: Expected O, but got I4
		//IL_0258: Expected I4, but got O
		//IL_0184: Expected O, but got I4
		//IL_0051: Expected O, but got I
		SpriteRenderer[] groundCards = _groundCards;
		if (_groundCards != null)
		{
			object obj = 0;
			int num = 0;
			bool flag6;
			do
			{
				bool flag = (nint)obj >= groundCards.Length;
				int num2 = num;
				if (!flag)
				{
					object obj2 = (object)groundCards + obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v5+20]");
					bool flag2 = (nint)0 == 0;
					num2 = num;
					if (flag2)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v5+20]");
					int sortingOrder = ((Renderer)0).sortingOrder;
					if (sortingOrder > num)
					{
						SpriteRenderer[] groundCards2 = _groundCards;
						bool flag3 = _groundCards == null;
						num2 = num;
						if (flag3)
						{
							break;
						}
						bool flag4 = (nint)obj < groundCards2.Length;
						object obj3 = !flag4;
						if (obj3 != null)
						{
							IndexOutOfRangeException ex = new IndexOutOfRangeException();
							return (int)ex;
						}
						object obj4 = (object)_groundCards + obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v9+20]");
						bool flag5 = (nint)0 == 0;
						object obj5 = !flag5;
						num2 = num;
						if (obj5 == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v9+20]");
						int sortingOrder2 = ((Renderer)0).sortingOrder;
						num = sortingOrder2;
					}
					obj++;
					groundCards = _groundCards;
					flag6 = _groundCards == null;
					num2 = num;
					continue;
				}
				bool flag7 = num2 < 0;
				bool flag8 = num2 == 0;
				int num3 = num2 ^ num2;
				int num4 = num2 & num3;
				bool flag9 = num4 < 0;
				bool flag10 = flag7 == flag9;
				object obj6 = !flag10;
				object obj7 = obj6 | flag8;
				object obj8 = ~obj7;
				if (obj8 == null)
				{
					return 0;
				}
				return num2 + 1;
			}
			while (!flag6);
		}
		throw new NullReferenceException();
	}

	public SlapCardAnimationV2()
	{
		//IL_0012: Expected F4, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_004e: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0088: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252FD0]");
		distanceFromCenter = 0f;
		groundScale = 1f;
		object obj = typeof(UsageHint) + 744;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5+B8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v6+8]");
		object obj4 = default(object);
		object obj3 = 0 * obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v6+8]");
		object obj5 = (nint)0 * (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252FA0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252F98]");
		_ = 0;
		_ = 1061997773;
		((MonoBehaviour)this)..ctor();
	}
}
