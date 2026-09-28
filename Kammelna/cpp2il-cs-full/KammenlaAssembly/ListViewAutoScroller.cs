using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using UnityEngine;

public class ListViewAutoScroller : ListViewScroller
{
	private enum BoundsMode
	{
		None,
		Wrap,
		PingPong
	}

	private float m_Speed = 1f;

	private float m_StartDelay;

	private bool m_PlayOnEnable = true;

	private BoundsMode m_Bounds;

	private float m_MinOffset;

	private float m_MaxOffset;

	private bool m_Playing;

	private float m_DelayRemaining;

	private int m_Direction = 1;

	private bool HasBounds
	{
		get
		{
			bool flag = m_Bounds == BoundsMode.None;
			return !flag;
		}
	}

	public bool IsPlaying => m_Playing;

	public float Speed
	{
		get
		{
			return m_Speed;
		}
		set
		{
			m_Speed = value;
		}
	}

	private void OnEnable()
	{
		//IL_013c: Expected O, but got I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00cf: Expected O, but got I4
		//IL_0116: Expected I, but got O
		if (!m_PlayOnEnable)
		{
			return;
		}
		while (true)
		{
			bool flag = !m_Playing;
			object obj = !flag;
			if (obj != null)
			{
				break;
			}
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				if (m_ListView == null)
				{
					break;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag2 = m_ListView == null;
				bool flag3 = !flag2;
				object obj4 = !flag3;
				if (obj4 != null)
				{
					break;
				}
			}
			m_Playing = true;
			m_Direction = 1;
			m_DelayRemaining = m_StartDelay;
			ListViewControllerBase listView = m_ListView;
			nint num = (nint)listView;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v95 @ X8_v10 (Il2CppClass<ListView.ListViewControllerBase>)+248] (should have been resolved before IL gen)");
		}
	}

	private void OnDisable()
	{
		//IL_0044: Expected I, but got O
		//IL_0054: Expected O, but got I
		//IL_0064: Expected O, but got I
		if (m_Playing)
		{
			m_Playing = false;
			ListViewControllerBase listView = m_ListView;
			nint num = (nint)listView;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X8_v2 (Il2CppClass<ListView.ListViewControllerBase>)+258]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X8_v2 (Il2CppClass<ListView.ListViewControllerBase>)+260]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v15 @ X2_v1 (should have been resolved before IL gen)");
		}
	}

	public void Play()
	{
		//IL_011a: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I4
		//IL_00f4: Expected I, but got O
		while (true)
		{
			bool flag = !m_Playing;
			object obj = !flag;
			if (obj != null)
			{
				break;
			}
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				if (m_ListView == null)
				{
					break;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag2 = m_ListView == null;
				bool flag3 = !flag2;
				object obj4 = !flag3;
				if (obj4 != null)
				{
					break;
				}
			}
			m_Playing = true;
			m_Direction = 1;
			m_DelayRemaining = m_StartDelay;
			ListViewControllerBase listView = m_ListView;
			nint num = (nint)listView;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v84 @ X8_v9 (Il2CppClass<ListView.ListViewControllerBase>)+248] (should have been resolved before IL gen)");
		}
	}

	public void Stop()
	{
		//IL_0044: Expected I, but got O
		//IL_0054: Expected O, but got I
		//IL_0064: Expected O, but got I
		if (m_Playing)
		{
			m_Playing = false;
			ListViewControllerBase listView = m_ListView;
			nint num = (nint)listView;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X8_v2 (Il2CppClass<ListView.ListViewControllerBase>)+258]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X8_v2 (Il2CppClass<ListView.ListViewControllerBase>)+260]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v15 @ X2_v1 (should have been resolved before IL gen)");
		}
	}

	public void Toggle()
	{
		//IL_0096: Expected O, but got I
		//IL_00b0: Expected O, but got I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I4
		//IL_0045: Expected O, but got I4
		//IL_004e: Expected O, but got I4
		//IL_0056: Expected I, but got O
		//IL_0066: Expected O, but got I
		//IL_0076: Expected O, but got I
		//IL_0196: Expected O, but got I4
		//IL_01de: Expected O, but got I4
		//IL_01e7: Expected O, but got I4
		//IL_01ef: Expected I, but got O
		if (m_Playing)
		{
			m_Playing = false;
			ListViewControllerBase listView = m_ListView;
			object obj = 608;
			object obj2 = 600;
			nint num = (nint)listView;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X10_v2 (Il2CppClass<ListView.ListViewControllerBase>)+v31 @ X9_v2]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X10_v2 (Il2CppClass<ListView.ListViewControllerBase>)+v30 @ X8_v13]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v33 @ X2_v7 (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E755B]");
		object obj5 = (nint)0 & (nint)1;
		bool flag = obj5 == null;
		object obj6 = !flag;
		if (obj6 == null)
		{
			_ = 1;
			bool flag2 = !m_Playing;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				return;
			}
		}
		object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if (m_ListView == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = m_ListView == null;
			bool flag4 = !flag3;
			object obj10 = !flag4;
			if (obj10 != null)
			{
				return;
			}
		}
		m_Playing = true;
		m_Direction = 1;
		m_DelayRemaining = m_StartDelay;
		ListViewControllerBase listView2 = m_ListView;
		object obj11 = 592;
		object obj12 = 584;
		nint num2 = (nint)listView2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v97 @ X10_v1 (Il2CppClass<ListView.ListViewControllerBase>)+v100 @ X9_v1] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void Update()
	{
		//IL_002d: Invalid comparison between F4 and I4
		//IL_0101: Expected O, but got I4
		//IL_011d: Invalid comparison between F4 and I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0206: Expected I4, but got I8
		if (!m_Playing)
		{
			return;
		}
		if (m_DelayRemaining > 0f)
		{
			float deltaTime = Time.deltaTime;
			float delayRemaining = m_DelayRemaining - deltaTime;
			m_DelayRemaining = delayRemaining;
			return;
		}
		ListViewControllerBase listView = m_ListView;
		float deltaTime2 = Time.deltaTime;
		float num = m_Speed * (float)m_Direction;
		float num2 = deltaTime2 * num;
		float num3 = listView.m_ScrollOffset + num2;
		ListViewControllerBase listView2 = m_ListView;
		if (m_Bounds != BoundsMode.None)
		{
			bool flag = m_MaxOffset < m_MinOffset;
			object obj = !flag;
			float num4 = m_MaxOffset - m_MinOffset;
			bool flag2 = num4 == 0f;
			object obj2 = ~obj;
			object obj3 = obj2 | flag2;
			if (obj3 == null)
			{
				if (m_Bounds != BoundsMode.PingPong)
				{
					if (m_Bounds == BoundsMode.Wrap)
					{
						if (num3 > m_MaxOffset)
						{
							goto IL_0255;
						}
						if (num3 < m_MinOffset)
						{
							num3 = m_MaxOffset;
						}
					}
				}
				else if (num3 > m_MaxOffset)
				{
					m_Direction = -1;
					num3 = m_MaxOffset;
				}
				else if (num3 < m_MinOffset)
				{
					m_Direction = 1;
					goto IL_0255;
				}
			}
		}
		goto IL_0246;
		IL_0246:
		listView2.m_ScrollOffset = num3;
		return;
		IL_0255:
		num3 = m_MinOffset;
		goto IL_0246;
	}

	private float ApplyBounds(float offset)
	{
		//IL_003c: Expected O, but got I4
		//IL_0058: Invalid comparison between F4 and I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0139: Expected I4, but got I8
		if (m_Bounds != BoundsMode.None)
		{
			bool flag = m_MaxOffset < m_MinOffset;
			object obj = !flag;
			float num = m_MaxOffset - m_MinOffset;
			bool flag2 = num == 0f;
			object obj2 = ~obj;
			object obj3 = obj2 | flag2;
			if (obj3 == null)
			{
				float num2 = default(float);
				if (m_Bounds != BoundsMode.PingPong)
				{
					if (m_Bounds == BoundsMode.Wrap && !(num2 > m_MaxOffset) && num2 < m_MinOffset)
					{
						return m_MaxOffset;
					}
				}
				else
				{
					if (num2 > m_MaxOffset)
					{
						m_Direction = -1;
						return m_MaxOffset;
					}
					if (num2 < m_MinOffset)
					{
						m_Direction = 1;
					}
				}
			}
		}
		return m_MinOffset;
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
