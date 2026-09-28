using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class KContentSizeFitter : ContentSizeFitter
{
	private Vector2 _sizeMin;

	private Vector2 _sizeMax;

	public override void SetLayoutHorizontal()
	{
		//IL_00f9: Expected O, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0146: Expected F4, but got O
		//IL_0139: Expected F4, but got O
		if (m_HorizontalFit == FitMode.Unconstrained)
		{
			return;
		}
		base.SetLayoutHorizontal();
		if (m_HorizontalFit != FitMode.MinSize)
		{
			Transform go = base.transform;
			RectTransform rectTransform = UIExtensions.rectTransform(go);
			Vector2 sizeDelta = rectTransform.sizeDelta;
			Vector2 vector = _sizeMax;
			Vector2 vector2 = default(Vector2);
			object obj = vector2 - _sizeMax;
			bool flag = (nint)obj < 0;
			bool flag2 = obj == null;
			object obj2 = (object)vector2 ^ (object)_sizeMax;
			object obj3 = (object)vector2 ^ obj;
			object obj4 = obj2 & obj3;
			bool flag3 = (nint)obj4 < 0;
			bool flag4 = flag == flag3;
			object obj5 = !flag2;
			object obj6 = flag4 & obj5;
			object obj7 = ~obj6;
			if (obj7 != null)
			{
				vector = vector2;
			}
			float size = ((vector2 >= _sizeMin) ? ((float)vector) : ((float)_sizeMin));
			rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, size);
		}
	}

	public override void SetLayoutVertical()
	{
		//IL_0081: Expected F4, but got I
		//IL_0091: Expected F4, but got I
		//IL_00b1: Invalid comparison between F4 and I4
		//IL_00c0: Invalid comparison between F4 and I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00e8: Expected O, but got F4
		//IL_011d: Expected O, but got I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		if (m_VerticalFit == FitMode.Unconstrained)
		{
			return;
		}
		base.SetLayoutVertical();
		if (m_VerticalFit != FitMode.MinSize)
		{
			Transform go = base.transform;
			RectTransform rectTransform = UIExtensions.rectTransform(go);
			Vector2 sizeDelta = rectTransform.sizeDelta;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KContentSizeFitter)+38]");
			float num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KContentSizeFitter)+40]");
			float num2 = 0f;
			float num4 = default(float);
			float num3 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KContentSizeFitter)+40]");
			float num5 = num3 - 0f;
			bool flag = num5 < 0f;
			bool flag2 = num5 == 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KContentSizeFitter)+40]");
			object obj = num4 ^ 0;
			object obj2 = num4 ^ num5;
			object obj3 = obj & obj2;
			bool flag3 = (nint)obj3 < 0;
			bool flag4 = flag == flag3;
			object obj4 = !flag2;
			object obj5 = flag4 & obj4;
			object obj6 = ~obj5;
			if (obj6 != null)
			{
				num2 = num4;
			}
			if (!(num4 < num))
			{
				num = num2;
			}
			rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num);
		}
	}

	public KContentSizeFitter()
	{
		//IL_0012: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253190]");
		_sizeMin = (Vector2)0;
		base..ctor();
	}
}
