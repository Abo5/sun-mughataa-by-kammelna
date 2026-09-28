using Cpp2ILInjected;
using ListView;
using UnityEngine;

public class ListViewVerticalMouseScroller : ListViewMouseScroller
{
	private bool clamp;

	private float upperCap;

	private float lowerCap;

	private float UpperCap
	{
		get
		{
			//IL_002f: Expected F4, but got I4
			if (clamp)
			{
				return upperCap;
			}
			return 2.139095E+09f;
		}
	}

	private float LowerCap
	{
		get
		{
			//IL_0033: Expected F4, but got I8
			if (clamp)
			{
				return lowerCap;
			}
			return 4.2865787E+09f;
		}
	}

	private bool isClamp => clamp;

	protected override void OnScroll(Vector3 position)
	{
		//IL_0090: Expected F4, but got I8
		//IL_0099: Expected F4, but got I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00e9: Invalid comparison between F4 and I4
		//IL_00f8: Invalid comparison between F4 and I4
		//IL_010b: Expected O, but got F4
		//IL_0118: Expected O, but got F4
		//IL_014d: Expected O, but got I4
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		if (m_Scrolling)
		{
			ListViewControllerBase listView = m_ListView;
			Transform transform = base.transform;
			Vector3 lossyScale = transform.lossyScale;
			float num;
			float num2;
			if (clamp)
			{
				num = upperCap;
				num2 = lowerCap;
			}
			else
			{
				num2 = 4.2865787E+09f;
				num = 2.139095E+09f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListViewVerticalMouseScroller)+30]");
			object obj2 = default(object);
			object obj = 0 - obj2;
			object obj3 = obj / obj2;
			float num3 = m_StartOffset + (float)obj3;
			float num4 = num3 - num;
			bool flag = num4 < 0f;
			bool flag2 = num4 == 0f;
			object obj4 = num3 ^ num;
			object obj5 = num3 ^ num4;
			object obj6 = obj4 & obj5;
			bool flag3 = (nint)obj6 < 0;
			bool flag4 = flag == flag3;
			object obj7 = !flag2;
			object obj8 = flag4 & obj7;
			object obj9 = ~obj8;
			if (obj9 != null)
			{
				num = num3;
			}
			if (!(num3 < num2))
			{
				num2 = num;
			}
			listView.m_ScrollOffset = num2;
		}
	}

	public ListViewVerticalMouseScroller()
	{
		base.m_ScrollWheelSpeed = 1f;
		((ListViewScroller)this)..ctor();
	}
}
