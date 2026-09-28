using System;
using System.Buffers.Text;
using System.Data;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.XR;
using UnityEngine.TextCore;

namespace ListView;

public abstract class ListViewControllerBase : MonoBehaviour, IScrollHandler, IEventSystemHandler
{
	protected float m_ScrollOffset;

	protected float m_Padding;

	private float m_ScrollDamping;

	private float m_MaxMomentum;

	protected float m_SettleSpeed;

	private float m_ScrollSpeed;

	protected GameObject[] m_Templates;

	protected bool m_EnableSettling;

	private float m_LastScrollOffset;

	protected bool m_Settling;

	protected Vector3 m_ItemSize;

	protected Vector3 m_StartPosition;

	protected bool m_Scrolling;

	protected float m_ScrollReturn;

	protected float m_ScrollDelta;

	protected Vector3 m_Size;

	protected Vector3 m_Extents;

	protected abstract float listHeight { get; }

	public float scrollOffset
	{
		get
		{
			return m_ScrollOffset;
		}
		set
		{
			m_ScrollOffset = value;
		}
	}

	public float scrollSpeed
	{
		get
		{
			return m_ScrollSpeed;
		}
		set
		{
			m_ScrollSpeed = value;
		}
	}

	public Vector3 itemSize => (Vector3)this;

	public Vector3 size
	{
		set
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			Vector3 vector = default(Vector3);
			m_Size = vector;
			object obj = default(object);
			double num = (double)obj * 0.5;
			Vector3 extents = vector * 63;
			m_Extents = extents;
		}
	}

	private event Action settlingCompleted
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 80;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 80;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	protected virtual void Awake()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_008f: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		GameObject[] templates = m_Templates;
		if (m_Templates != null)
		{
			if (templates.Length != 0)
			{
				Vector3 objectSize = GetObjectSize(templates[0]);
				Vector3 vector = default(Vector3);
				m_ItemSize = vector;
				return;
			}
			object obj = typeof(DataRelation) + 856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "LAK" + 1824;
			Debug.LogWarning(message, this);
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	protected virtual void Update()
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<ListView.ListViewControllerBase>)+1B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<ListView.ListViewControllerBase>)+1C0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void UpdateView()
	{
		//IL_000b: Expected I, but got O
		//IL_001b: Expected O, but got I
		//IL_002b: Expected O, but got I
		ComputeConditions();
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X8_v2 (Il2CppClass<ListView.ListViewControllerBase>)+1D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X8_v2 (Il2CppClass<ListView.ListViewControllerBase>)+1E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v31 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void ComputeConditions()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_03cd: Expected O, but got I
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected O, but got Unknown
		//IL_0169: Invalid comparison between F4 and I4
		//IL_0259: Invalid comparison between F4 and I4
		//IL_026a: Invalid comparison between F4 and I4
		//IL_0073: Invalid comparison between F4 and I4
		//IL_0082: Invalid comparison between F4 and I4
		//IL_0097: Expected O, but got F4
		//IL_00a4: Expected O, but got F4
		//IL_00d9: Expected O, but got I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_021d: Invalid comparison between F4 and I4
		//IL_0186: Invalid comparison between F4 and I4
		//IL_0293: Expected O, but got I4
		//IL_04bf: Invalid comparison between F4 and I4
		//IL_01af: Invalid comparison between F4 and I4
		//IL_01c0: Invalid comparison between F4 and I4
		//IL_02dd: Invalid comparison between F4 and I4
		//IL_032f: Expected O, but got F4
		//IL_0337: Invalid comparison between F4 and O
		//IL_0348: Expected O, but got I4
		//IL_0360: Invalid comparison between F4 and I4
		//IL_0371: Expected O, but got I4
		object obj = typeof(UsageHint) + 816;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewControllerBase)+60]");
		double num = 0.0 * -0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewControllerBase)+90]");
		double num2 = 0.0 + num;
		double num3 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+50]");
		double num4 = num3 * 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+48]");
		object obj4 = default(object);
		Vector3 startPosition = (Vector3)(0 * obj4);
		m_StartPosition = startPosition;
		float num10;
		float scrollDelta2;
		float num13;
		if (m_Scrolling)
		{
			float deltaTime = Time.deltaTime;
			float num5 = m_MaxMomentum;
			float num6 = m_ScrollOffset - m_LastScrollOffset;
			float num7 = num6 / deltaTime;
			float num8 = 0f - m_MaxMomentum;
			float num9 = num7 - m_MaxMomentum;
			bool flag = num9 < 0f;
			bool flag2 = num9 == 0f;
			object obj5 = num7 ^ m_MaxMomentum;
			object obj6 = num7 ^ num9;
			object obj7 = obj5 & obj6;
			bool flag3 = (nint)obj7 < 0;
			bool flag4 = flag == flag3;
			object obj8 = !flag2;
			object obj9 = flag4 & obj8;
			object obj10 = ~obj9;
			if (obj10 != null)
			{
				num5 = num7;
			}
			float scrollDelta = ((!(num7 < num8)) ? num5 : num8);
			m_ScrollDelta = scrollDelta;
			num10 = m_ScrollOffset;
			m_LastScrollOffset = m_ScrollOffset;
		}
		else
		{
			float deltaTime2 = Time.deltaTime;
			float num11 = m_ScrollDelta * deltaTime2;
			num10 = (m_ScrollOffset += num11);
			bool flag5;
			float scrollDelta3;
			if (!(m_ScrollReturn < 2.139095E+09f) && !(num10 > 0f))
			{
				scrollDelta2 = m_ScrollDelta;
				flag5 = m_ScrollDelta < 0f;
				bool flag6 = !(m_ScrollDelta > 0f);
				scrollDelta3 = m_ScrollDelta;
				if (!flag6)
				{
					goto IL_01e1;
				}
			}
			else
			{
				OnScrollEnded();
				scrollDelta2 = m_ScrollDelta;
				flag5 = m_ScrollDelta < 0f;
				bool flag7 = m_ScrollDelta > 0f;
				scrollDelta3 = m_ScrollDelta;
				if (flag7)
				{
					goto IL_01e1;
				}
			}
			object obj11 = !flag5;
			if (obj11 == null)
			{
				float deltaTime3 = Time.deltaTime;
				float num12 = m_ScrollDamping * deltaTime3;
				num13 = (m_ScrollDelta = scrollDelta3 + num12);
				bool flag8 = !(num13 > 0f);
				num10 = num13;
				if (!flag8)
				{
					goto IL_02fc;
				}
			}
		}
		goto IL_04a1;
		IL_01e1:
		float deltaTime4 = Time.deltaTime;
		float num14 = m_ScrollDamping * deltaTime4;
		num13 = (m_ScrollDelta = scrollDelta2 - num14);
		if (num13 < 0f)
		{
			goto IL_02fc;
		}
		num10 = num13;
		goto IL_04a1;
		IL_04a1:
		m_ScrollReturn = 3.4028235E+38f;
		float num15 = listHeight;
		if (num10 > 0f)
		{
			float num16 = listHeight;
			object obj12 = 0f - m_ScrollOffset;
			bool flag9 = (object)num10 < obj12;
			object obj13 = !flag9;
			float num17 = num10 - (float)obj12;
			bool flag10 = num17 == 0f;
			object obj14 = !flag10;
			object obj15 = obj13 & obj14;
			if (obj15 == null)
			{
				float num18 = listHeight;
				float scrollReturn = 897988540f - num10;
				m_ScrollReturn = scrollReturn;
			}
		}
		return;
		IL_02fc:
		m_ScrollDelta = 0f;
		OnScrollEnded();
		num10 = num13;
		goto IL_04a1;
	}

	protected abstract void UpdateItems();

	public virtual void ScrollNext()
	{
		float num = m_ScrollOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewControllerBase)+60]");
		float num2 = num - 0f;
		m_ScrollOffset = num2;
	}

	public virtual void ScrollPrevious()
	{
		float num = m_ScrollOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewControllerBase)+60]");
		float num2 = num + 0f;
		m_ScrollOffset = num2;
	}

	public virtual void ScrollTo(int index)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewControllerBase)+60]");
		float num = 0f * (float)index;
		m_ScrollOffset = num;
	}

	protected virtual void UpdateItem(IListViewItem item, int order, float offset, ref bool doneSettling)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00b4: Expected O, but got I
		//IL_00cc: Expected O, but got I
		//IL_00dc: Expected O, but got I
		//IL_00ec: Expected O, but got I
		//IL_00f1: Expected I, but got O
		//IL_0101: Expected O, but got I
		//IL_0111: Expected O, but got I
		object obj = typeof(UsageHint) + 816;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 2696;
		float num = offset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+5C]");
		float num2 = num * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewControllerBase)+6C]");
		float num3 = 0f + num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+54]");
		object obj6 = default(object);
		object obj5 = 0 * obj6;
		object obj7 = (object)m_StartPosition + obj5;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v7+B8]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v8+4]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v8+8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v8+C]");
		object obj13 = 0;
		nint num4 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v9 (Il2CppClass<ListView.ListViewControllerBase>)+228]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v9 (Il2CppClass<ListView.ListViewControllerBase>)+230]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v94 @ X6_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected unsafe virtual void UpdateItemTransform(IListViewItem item, int order, Vector3 targetPosition, Quaternion targetRotation, bool dontSettle, ref bool doneSettling)
	{
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected O, but got Unknown
		//IL_05d4: Expected O, but got I4
		//IL_00fa: Expected I, but got O
		//IL_010a: Expected O, but got I
		//IL_06f6: Expected I, but got O
		//IL_0706: Expected O, but got I
		//IL_0145: Expected O, but got I
		//IL_01ea: Expected O, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_0aac: Expected I, but got O
		//IL_0abc: Expected O, but got I
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_004e: Expected I, but got O
		//IL_005e: Expected O, but got I
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_0287: Expected O, but got I
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_062f: Invalid comparison between F8 and I4
		//IL_063e: Invalid comparison between F8 and I4
		//IL_0658: Expected O, but got F8
		//IL_0667: Expected O, but got F8
		//IL_069c: Expected O, but got I4
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected O, but got Unknown
		//IL_0099: Expected O, but got I
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_07b8: Invalid comparison between F4 and I4
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_0858: Expected I, but got O
		//IL_0868: Expected O, but got I
		//IL_0365: Expected F8, but got I4
		//IL_093c: Invalid comparison between F8 and I4
		//IL_038d: Expected O, but got I
		//IL_0ae9: Expected I, but got O
		//IL_0af9: Expected O, but got I
		//IL_041d: Expected native int or pointer, but got O
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected O, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected O, but got Unknown
		//IL_099d: Expected I, but got O
		//IL_09ad: Expected O, but got I
		//IL_043d: Expected O, but got I
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected O, but got Unknown
		//IL_052e: Expected O, but got I4
		//IL_0a75: Invalid comparison between F8 and I4
		//IL_0a84: Expected F4, but got I4
		//IL_0a8c: Expected O, but got F8
		//IL_04da: Expected O, but got I
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected O, but got Unknown
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected O, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected O, but got Unknown
		//IL_0573: Expected native int or pointer, but got O
		//IL_0581: Expected F4, but got I4
		//IL_0589: Expected O, but got F8
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected O, but got Unknown
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected O, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected O, but got Unknown
		//IL_0565: Expected O, but got I4
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected O, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected O, but got Unknown
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3512;
		object obj2 = targetPosition & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		int num2;
		if (obj3 == null && m_Settling && m_EnableSettling)
		{
			nint num = (nint)item;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v20 (Il2CppClass<ListView.IListViewItem>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v20 (Il2CppClass<ListView.IListViewItem>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00da;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v20 (Il2CppClass<ListView.IListViewItem>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X10_v42-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00da;
			}
			object obj6 = obj5 + 1;
			object obj7 = num + obj6;
			object obj8 = obj7 + 312;
			num2 = order;
			goto IL_0606;
		}
		nint num3 = (nint)item;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v10 (Il2CppClass<ListView.IListViewItem>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v10 (Il2CppClass<ListView.IListViewItem>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0186;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v10 (Il2CppClass<ListView.IListViewItem>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X10_v18-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_0186;
		}
		object obj11 = obj10 + 2;
		object obj12 = num3 + obj11;
		object obj13 = obj12 + 312;
		int num4 = order;
		goto IL_06e4;
		IL_0aa4:
		nint num5 = (nint)item;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v4 (Il2CppClass<ListView.IListViewItem>)+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v4 (Il2CppClass<ListView.IListViewItem>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02c8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v4 (Il2CppClass<ListView.IListViewItem>)+B0]");
		object obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X10_v6-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj15 += 16;
			obj14--;
			if ((nint)obj14 != 1)
			{
				continue;
			}
			goto IL_02c8;
		}
		object obj16 = obj15 + 16;
		object obj17 = num5 + obj16;
		object obj18 = obj17 + 312;
		goto IL_07a2;
		IL_00da:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = 1;
		goto IL_0606;
		IL_0606:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v429 @ X0_v22] (should have been resolved before IL gen)");
		double num6 = (double)m_SettleSpeed - 1.0;
		bool flag2 = num6 < 0.0;
		bool flag3 = num6 == 0.0;
		object obj19 = (double)m_SettleSpeed ^ 1.0;
		object obj20 = (double)m_SettleSpeed ^ num6;
		object obj21 = obj19 & obj20;
		bool flag4 = (nint)obj21 < 0;
		bool flag5 = flag2 == flag4;
		object obj22 = !flag3;
		object obj23 = flag5 & obj22;
		object obj24 = ~obj23;
		double num7 = ((obj24 != null) ? ((double)m_SettleSpeed) : 1.0);
		double num8 = ((!(m_SettleSpeed < 0f)) ? num7 : 0.0);
		object obj26 = default(object);
		object obj25 = obj26 - obj26;
		double num9 = (double)obj25 * num8;
		double num10 = (double)obj26 + num9;
		object obj28 = default(object);
		object obj27 = obj28 - obj28;
		double num11 = (double)obj27 * num8;
		double num12 = (double)obj28 + num11;
		object obj30 = default(object);
		object obj29 = obj30 - obj30;
		double num13 = (double)obj29 * num8;
		double num14 = (double)obj30 + num13;
		nint num15 = (nint)item;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v23 (Il2CppClass<ListView.IListViewItem>)+12E]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v23 (Il2CppClass<ListView.IListViewItem>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03ce;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v23 (Il2CppClass<ListView.IListViewItem>)+B0]");
		object obj32 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X10_v37-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj32 += 16;
			obj31--;
			if ((nint)obj31 != 1)
			{
				continue;
			}
			goto IL_03ce;
		}
		object obj33 = obj32 + 2;
		object obj34 = num15 + obj33;
		object obj35 = obj34 + 312;
		goto IL_08b1;
		IL_047e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = 3;
		goto IL_0974;
		IL_0974:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v820 @ X0_v28] (should have been resolved before IL gen)");
		Quaternion a = default(Quaternion);
		Quaternion b = default(Quaternion);
		Quaternion quaternion = Quaternion.Internal_Lerp(ref a, ref b, m_SettleSpeed);
		nint num16 = (nint)item;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v31 (Il2CppClass<ListView.IListViewItem>)+12E]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v31 (Il2CppClass<ListView.IListViewItem>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_051b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v31 (Il2CppClass<ListView.IListViewItem>)+B0]");
		object obj37 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X10_v27-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj37 += 16;
			obj36--;
			if ((nint)obj36 != 1)
			{
				continue;
			}
			goto IL_051b;
		}
		object obj38 = obj37 + 4;
		object obj39 = num16 + obj38;
		object obj40 = obj39 + 312;
		object obj41 = 0;
		goto IL_09f6;
		IL_08b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v719 @ X0_v25] (should have been resolved before IL gen)");
		double num17 = num10 - (double)obj26;
		double num18 = num12 - (double)obj28;
		double num19 = num14 - (double)obj30;
		double num20 = num17 * num17;
		double num21 = num18 * num18;
		double num22 = num20 + num21;
		double num23 = num19 * num19;
		double num24 = num23 + num22;
		if (!(num24 < 786163454.0))
		{
			((Quaternion*)(nint)targetRotation)->x = 0f;
		}
		nint num25 = (nint)item;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v28 (Il2CppClass<ListView.IListViewItem>)+12E]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v28 (Il2CppClass<ListView.IListViewItem>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_047e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v28 (Il2CppClass<ListView.IListViewItem>)+B0]");
		object obj43 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X10_v32-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj43 += 16;
			obj42--;
			if ((nint)obj42 != 1)
			{
				continue;
			}
			goto IL_047e;
		}
		object obj44 = obj43 + 3;
		object obj45 = num25 + obj44;
		object obj46 = obj45 + 312;
		goto IL_0974;
		IL_07a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v677 @ X0_v3] (should have been resolved before IL gen)");
		return;
		IL_0186:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num4 = 2;
		goto IL_06e4;
		IL_06e4:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v348 @ X0_v10] (should have been resolved before IL gen)");
		nint num26 = (nint)item;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v13 (Il2CppClass<ListView.IListViewItem>)+12E]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v13 (Il2CppClass<ListView.IListViewItem>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_022b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v13 (Il2CppClass<ListView.IListViewItem>)+B0]");
		object obj48 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X10_v13-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj48 += 16;
			obj47--;
			if ((nint)obj47 != 1)
			{
				continue;
			}
			goto IL_022b;
		}
		object obj49 = obj48 + 4;
		object obj50 = num26 + obj49;
		object obj51 = obj50 + 312;
		goto IL_074f;
		IL_03ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = 2;
		goto IL_08b1;
		IL_051b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj41 = 4;
		goto IL_09f6;
		IL_09f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v898 @ X0_v33] (should have been resolved before IL gen)");
		Quaternion quaternion2 = default(Quaternion);
		float num27 = (float)quaternion2 * m_SettleSpeed;
		float num29 = default(float);
		float num28 = num29 * 786163460f;
		float num30 = num27 + num28;
		double num32 = default(double);
		double num31 = num32 * num19;
		double num33 = num31 + (double)num30;
		double num35 = default(double);
		double num34 = num35 * num8;
		double num36 = num34 + num33;
		bool flag6 = num36 > 1065353199.0;
		float num37 = 1.0653532E+09f;
		Quaternion quaternion3 = (Quaternion)num36;
		num29 = m_SettleSpeed;
		if (!flag6)
		{
			((Quaternion*)(nint)targetRotation)->x = 0f;
			num37 = 1.0653532E+09f;
			quaternion3 = (Quaternion)num36;
			num29 = m_SettleSpeed;
		}
		goto IL_0aa4;
		IL_02c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_07a2;
		IL_022b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num4 = 4;
		goto IL_074f;
		IL_074f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v491 @ X0_v13] (should have been resolved before IL gen)");
		num19 = num32;
		num37 = num29;
		quaternion3 = quaternion2;
		num8 = num35;
		goto IL_0aa4;
	}

	protected virtual Vector3 GetObjectSize(GameObject g)
	{
		//IL_0016: Expected O, but got I
		//IL_00af: Expected O, but got I
		//IL_00c9: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_011a: Expected O, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0146: Expected O, but got I
		//IL_01ea: Expected O, but got I4
		//IL_01a0: Expected O, but got I4
		//IL_01b6: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D16]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0BB]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0BB]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		if ((object)g != null)
		{
			goto IL_00fa;
		}
		goto IL_0266;
		IL_01f8:
		Transform transform = g.transform;
		UnityEngine.Object obj5 = default(UnityEngine.Object);
		Vector3 result;
		if ((object)transform != null)
		{
			Vector3 lossyScale = transform.lossyScale;
			if ((object)obj5 != null)
			{
				Bounds bounds = ((Renderer)obj5).bounds;
				result = (Vector3)bounds;
				goto IL_0274;
			}
		}
		goto IL_0266;
		IL_0274:
		return result;
		IL_0266:
		return (Vector3)new NullReferenceException();
		IL_0066:
		bool flag2 = (object)g == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00fa;
		}
		goto IL_0266;
		IL_00fa:
		object obj7 = typeof(UsageHint) + 816;
		object obj8 = (nint)0 + (nint)1544;
		object obj9 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X9_v2+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E331E4");
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			bool flag3 = obj5;
			bool flag4 = !flag3;
			object obj13 = !flag4;
			if (obj13 != null)
			{
				goto IL_01f8;
			}
			result = (Vector3)flag3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = obj5;
			bool flag6 = !flag5;
			result = (Vector3)flag5;
			if (!flag6)
			{
				goto IL_01f8;
			}
		}
		goto IL_0274;
	}

	public virtual void OnScrollStarted()
	{
		m_Scrolling = true;
	}

	public virtual void OnScrollEnded()
	{
		//IL_0016: Invalid comparison between F4 and I4
		//IL_0072: Invalid comparison between F4 and I4
		//IL_0035: Invalid comparison between F4 and I4
		//IL_00ae: Expected F4, but got I
		m_Scrolling = false;
		if (!(m_ScrollOffset > 0f))
		{
			if (!(m_ScrollReturn < 2.139095E+09f))
			{
				return;
			}
		}
		else
		{
			StartSettling();
			m_ScrollOffset = 0f;
			m_ScrollDelta = 0f;
			if (!(m_ScrollReturn < 2.139095E+09f))
			{
				return;
			}
		}
		StartSettling();
		m_ScrollOffset = m_ScrollReturn;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70E2CC8]");
		m_ScrollReturn = 0f;
	}

	protected unsafe void SetMaterialClip(Material material, Matrix4x4 parentMatrix)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0035: Expected O, but got Ref
		//IL_0047: Expected O, but got I4
		object obj = "_InputUv1BufferOffset" + 1328;
		object obj2 = "[{0}]:{1}" + 2008;
		float num = default(float);
		material.SetMatrix((string)obj, (Matrix4x4)(&num));
		material.SetVector((string)obj2, (Vector4)0);
	}

	public virtual void OnScroll(PointerEventData eventData)
	{
		//IL_001c: Expected O, but got I4
		bool flag = !m_Settling;
		object obj = !flag;
		if (obj == null)
		{
			float deltaTime = Time.deltaTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [eventData @ X1 (UnityEngine.EventSystems.PointerEventData)+180]");
			float num = 0f * m_ScrollSpeed;
			float num2 = num * deltaTime;
			float num3 = m_ScrollOffset + num2;
			m_ScrollOffset = num3;
		}
	}

	protected virtual void StartSettling(Action onComplete = null)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		m_Settling = true;
		if (onComplete == null)
		{
			return;
		}
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = this + 80;
		Delegate obj3 = (Delegate)obj2;
		bool flag;
		Delegate obj5 = default(Delegate);
		do
		{
			Delegate obj4 = Delegate.Combine(obj3, onComplete);
			if ((object)obj4 == null || obj4 == obj)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag = (object)obj5 == obj3;
				obj3 = obj5;
				continue;
			}
			throw new InvalidCastException();
		}
		while (!flag);
	}

	protected virtual void EndSettling()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object obj = this + 80;
		object obj2 = obj;
		_ = 0;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ X8_v1+18] (should have been resolved before IL gen)");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	protected ListViewControllerBase()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253770]");
		m_Padding = 0f;
		m_ScrollSpeed = 0.3f;
		m_EnableSettling = true;
		m_ScrollReturn = 3.4028235E+38f;
		base..ctor();
	}
}
