using System;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions;

public class ScrollConflictManager : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler, IScrollHandler
{
	private class ScrollConflictParent : IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler, IScrollHandler
	{
		private readonly ScrollRect ScrollRectParent;

		private readonly ListViewVerticalMouseScroller ListViewParent;

		public ScrollConflictParent(ScrollRect scrollRectParent, ListViewVerticalMouseScroller listViewMouseScroller)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			object obj = this + 16;
			obj = scrollRectParent;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj2 = this + 24;
			obj2 = listViewMouseScroller;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		public bool isNull()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0152: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			//IL_00f0: Expected O, but got I4
			//IL_01a7: Expected O, but got I4
			//IL_01b0: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B8D]");
			object obj3 = (nint)0 & (nint)1;
			Object scrollRectParent;
			Object scrollRectParent2;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				scrollRectParent = ScrollRectParent;
				scrollRectParent2 = ScrollRectParent;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				scrollRectParent = ScrollRectParent;
				scrollRectParent2 = ScrollRectParent;
				if (obj5 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = scrollRectParent2 == null;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			object obj7 = 0;
			Object obj8 = null;
			if (obj6 != null)
			{
				goto IL_00c6;
			}
			goto IL_01c3;
			IL_00c6:
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v11+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return ListViewParent == null;
			IL_01c3:
			return flag3;
			IL_0091:
			flag3 = scrollRectParent == null;
			bool flag6 = !flag3;
			obj7 = 0;
			obj8 = null;
			if (!flag6)
			{
				goto IL_00c6;
			}
			goto IL_01c3;
		}

		public bool isHorizontal()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0123: Expected O, but got I4
			//IL_00b2: Expected O, but got I4
			//IL_0177: Expected O, but got I4
			//IL_0180: Expected O, but got I4
			//IL_027c: Expected O, but got I4
			//IL_0285: Expected O, but got I4
			//IL_01de: Expected O, but got I4
			//IL_02a7: Expected I4, but got O
			//IL_0216: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B2B]");
			object obj3 = (nint)0 & (nint)1;
			Object scrollRectParent;
			Object scrollRectParent2;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v16+E4]");
				bool flag = (nint)0 == 0;
				scrollRectParent = ScrollRectParent;
				scrollRectParent2 = ScrollRectParent;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v16+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				scrollRectParent = ScrollRectParent;
				scrollRectParent2 = ScrollRectParent;
				if (obj5 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = scrollRectParent2;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			object obj7 = 0;
			if (obj6 != null)
			{
				goto IL_00c0;
			}
			goto IL_018e;
			IL_01ec:
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v9+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return ListViewParent != null;
			IL_00c0:
			ScrollRect scrollRectParent3 = ScrollRectParent;
			if ((object)ScrollRectParent != null)
			{
				return scrollRectParent3.m_Horizontal;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_018e:
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				bool flag6 = ListViewParent;
				bool flag7 = !flag6;
				object obj11 = 0;
				if (!flag7)
				{
					goto IL_01ec;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag8 = ListViewParent;
				bool flag9 = !flag8;
				object obj12 = !flag9;
				object obj11 = 0;
				if (obj12 != null)
				{
					goto IL_01ec;
				}
			}
			return false;
			IL_0091:
			bool flag10 = scrollRectParent;
			bool flag11 = !flag10;
			obj7 = 0;
			if (!flag11)
			{
				goto IL_00c0;
			}
			goto IL_018e;
		}

		public bool isVertical()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0123: Expected O, but got I4
			//IL_00b2: Expected O, but got I4
			//IL_0177: Expected O, but got I4
			//IL_0180: Expected O, but got I4
			//IL_027c: Expected O, but got I4
			//IL_0285: Expected O, but got I4
			//IL_01de: Expected O, but got I4
			//IL_02a7: Expected I4, but got O
			//IL_0216: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B2C]");
			object obj3 = (nint)0 & (nint)1;
			Object scrollRectParent;
			Object scrollRectParent2;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v16+E4]");
				bool flag = (nint)0 == 0;
				scrollRectParent = ScrollRectParent;
				scrollRectParent2 = ScrollRectParent;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v16+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				scrollRectParent = ScrollRectParent;
				scrollRectParent2 = ScrollRectParent;
				if (obj5 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = scrollRectParent2;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			object obj7 = 0;
			if (obj6 != null)
			{
				goto IL_00c0;
			}
			goto IL_018e;
			IL_01ec:
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v9+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return ListViewParent == null;
			IL_00c0:
			ScrollRect scrollRectParent3 = ScrollRectParent;
			if ((object)ScrollRectParent != null)
			{
				return scrollRectParent3.m_Vertical;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_018e:
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				bool flag6 = ListViewParent;
				bool flag7 = !flag6;
				object obj11 = 0;
				if (!flag7)
				{
					goto IL_01ec;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag8 = ListViewParent;
				bool flag9 = !flag8;
				object obj12 = !flag9;
				object obj11 = 0;
				if (obj12 != null)
				{
					goto IL_01ec;
				}
			}
			return false;
			IL_0091:
			bool flag10 = scrollRectParent;
			bool flag11 = !flag10;
			obj7 = 0;
			if (!flag11)
			{
				goto IL_00c0;
			}
			goto IL_018e;
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0137: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			//IL_018c: Expected O, but got I4
			//IL_0195: Expected O, but got I4
			//IL_0243: Expected O, but got I4
			//IL_00dd: Expected I, but got O
			//IL_00ed: Expected O, but got I
			//IL_00fd: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B2D]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 == null)
			{
				goto IL_0107;
			}
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			Object scrollRectParent = ScrollRectParent;
			Object scrollRectParent2 = ScrollRectParent;
			if (!flag)
			{
				goto IL_0091;
			}
			goto IL_0159;
			IL_01a8:
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				if (!(ListViewParent != null))
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag2 = ListViewParent != null;
				bool flag3 = !flag2;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					return;
				}
			}
			ListViewParent.OnBeginDrag(eventData);
			return;
			IL_0091:
			bool flag4 = scrollRectParent != null;
			bool flag5 = !flag4;
			object obj7 = 0;
			Object obj8 = null;
			if (!flag5)
			{
				goto IL_00c6;
			}
			goto IL_01a8;
			IL_00c6:
			ScrollRect scrollRectParent3 = ScrollRectParent;
			nint num = (nint)scrollRectParent3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v9 (Il2CppClass<UnityEngine.UI.ScrollRect>)+3F8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v9 (Il2CppClass<UnityEngine.UI.ScrollRect>)+400]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v90 @ X3_v1 (should have been resolved before IL gen)");
			goto IL_0107;
			IL_0107:
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			scrollRectParent = ScrollRectParent;
			scrollRectParent2 = ScrollRectParent;
			if (obj11 != null)
			{
				goto IL_0091;
			}
			goto IL_0159;
			IL_0159:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = scrollRectParent2 != null;
			bool flag8 = !flag7;
			object obj12 = !flag8;
			obj7 = 0;
			obj8 = null;
			if (obj12 != null)
			{
				goto IL_00c6;
			}
			goto IL_01a8;
		}

		public void OnEndDrag(PointerEventData eventData)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0137: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			//IL_018c: Expected O, but got I4
			//IL_0195: Expected O, but got I4
			//IL_0243: Expected O, but got I4
			//IL_00dd: Expected I, but got O
			//IL_00ed: Expected O, but got I
			//IL_00fd: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B2E]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 == null)
			{
				goto IL_0107;
			}
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			Object scrollRectParent = ScrollRectParent;
			Object scrollRectParent2 = ScrollRectParent;
			if (!flag)
			{
				goto IL_0091;
			}
			goto IL_0159;
			IL_01a8:
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				if (!(ListViewParent != null))
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag2 = ListViewParent != null;
				bool flag3 = !flag2;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					return;
				}
			}
			ListViewParent.OnEndDrag(eventData);
			return;
			IL_0091:
			bool flag4 = scrollRectParent != null;
			bool flag5 = !flag4;
			object obj7 = 0;
			Object obj8 = null;
			if (!flag5)
			{
				goto IL_00c6;
			}
			goto IL_01a8;
			IL_00c6:
			ScrollRect scrollRectParent3 = ScrollRectParent;
			nint num = (nint)scrollRectParent3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v9 (Il2CppClass<UnityEngine.UI.ScrollRect>)+408]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v9 (Il2CppClass<UnityEngine.UI.ScrollRect>)+410]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v90 @ X3_v1 (should have been resolved before IL gen)");
			goto IL_0107;
			IL_0107:
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			scrollRectParent = ScrollRectParent;
			scrollRectParent2 = ScrollRectParent;
			if (obj11 != null)
			{
				goto IL_0091;
			}
			goto IL_0159;
			IL_0159:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = scrollRectParent2 != null;
			bool flag8 = !flag7;
			object obj12 = !flag8;
			obj7 = 0;
			obj8 = null;
			if (obj12 != null)
			{
				goto IL_00c6;
			}
			goto IL_01a8;
		}

		public void OnDrag(PointerEventData eventData)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0137: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			//IL_018c: Expected O, but got I4
			//IL_0195: Expected O, but got I4
			//IL_0243: Expected O, but got I4
			//IL_00dd: Expected I, but got O
			//IL_00ed: Expected O, but got I
			//IL_00fd: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B2F]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 == null)
			{
				goto IL_0107;
			}
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			Object scrollRectParent = ScrollRectParent;
			Object scrollRectParent2 = ScrollRectParent;
			if (!flag)
			{
				goto IL_0091;
			}
			goto IL_0159;
			IL_01a8:
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				if (!(ListViewParent != null))
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag2 = ListViewParent != null;
				bool flag3 = !flag2;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					return;
				}
			}
			ListViewParent.OnDrag(eventData);
			return;
			IL_0091:
			bool flag4 = scrollRectParent != null;
			bool flag5 = !flag4;
			object obj7 = 0;
			Object obj8 = null;
			if (!flag5)
			{
				goto IL_00c6;
			}
			goto IL_01a8;
			IL_00c6:
			ScrollRect scrollRectParent3 = ScrollRectParent;
			nint num = (nint)scrollRectParent3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v9 (Il2CppClass<UnityEngine.UI.ScrollRect>)+418]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v9 (Il2CppClass<UnityEngine.UI.ScrollRect>)+420]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v90 @ X3_v1 (should have been resolved before IL gen)");
			goto IL_0107;
			IL_0107:
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			scrollRectParent = ScrollRectParent;
			scrollRectParent2 = ScrollRectParent;
			if (obj11 != null)
			{
				goto IL_0091;
			}
			goto IL_0159;
			IL_0159:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = scrollRectParent2 != null;
			bool flag8 = !flag7;
			object obj12 = !flag8;
			obj7 = 0;
			obj8 = null;
			if (obj12 != null)
			{
				goto IL_00c6;
			}
			goto IL_01a8;
		}

		public void OnScroll(PointerEventData eventData)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0137: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			//IL_018c: Expected O, but got I4
			//IL_0195: Expected O, but got I4
			//IL_0243: Expected O, but got I4
			//IL_00dd: Expected I, but got O
			//IL_00ed: Expected O, but got I
			//IL_00fd: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B30]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 == null)
			{
				goto IL_0107;
			}
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			Object scrollRectParent = ScrollRectParent;
			Object scrollRectParent2 = ScrollRectParent;
			if (!flag)
			{
				goto IL_0091;
			}
			goto IL_0159;
			IL_01a8:
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				if (!(ListViewParent != null))
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag2 = ListViewParent != null;
				bool flag3 = !flag2;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					return;
				}
			}
			ListViewParent.OnDrag(eventData);
			return;
			IL_0091:
			bool flag4 = scrollRectParent != null;
			bool flag5 = !flag4;
			object obj7 = 0;
			Object obj8 = null;
			if (!flag5)
			{
				goto IL_00c6;
			}
			goto IL_01a8;
			IL_00c6:
			ScrollRect scrollRectParent3 = ScrollRectParent;
			nint num = (nint)scrollRectParent3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v9 (Il2CppClass<UnityEngine.UI.ScrollRect>)+418]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v9 (Il2CppClass<UnityEngine.UI.ScrollRect>)+420]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v90 @ X3_v1 (should have been resolved before IL gen)");
			goto IL_0107;
			IL_0107:
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			scrollRectParent = ScrollRectParent;
			scrollRectParent2 = ScrollRectParent;
			if (obj11 != null)
			{
				goto IL_0091;
			}
			goto IL_0159;
			IL_0159:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = scrollRectParent2 != null;
			bool flag8 = !flag7;
			object obj12 = !flag8;
			obj7 = 0;
			obj8 = null;
			if (obj12 != null)
			{
				goto IL_00c6;
			}
			goto IL_01a8;
		}
	}

	public ScrollRect ParentScrollRect;

	public ListViewVerticalMouseScroller ParentListView;

	private ScrollRect _myScrollRect;

	private bool scrollOther;

	private bool scrollOtherHorizontally;

	private ScrollHandler parentScrollHandler;

	private ScrollConflictParent parentScroll;

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0130: Expected O, but got I
		//IL_0152: Expected O, but got I4
		//IL_016a: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_007b: Expected O, but got I
		//IL_00aa: Expected O, but got I
		//IL_01b6: Expected O, but got I4
		//IL_0d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d27: Expected O, but got Unknown
		//IL_0d3f: Expected O, but got I
		//IL_0231: Expected O, but got I
		//IL_02bd: Expected O, but got I4
		//IL_0d73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d78: Expected O, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_0338: Expected O, but got I
		//IL_03f8: Expected O, but got I
		//IL_04c6: Expected O, but got I
		//IL_04f0: Expected O, but got I4
		//IL_0500: Expected O, but got I
		//IL_0486: Expected O, but got I4
		//IL_048f: Expected O, but got I4
		//IL_0425: Expected O, but got I
		//IL_0454: Expected O, but got I
		//IL_05e8: Expected O, but got I
		//IL_04ab: Expected O, but got I4
		//IL_053f: Expected O, but got I4
		//IL_054d: Expected O, but got I4
		//IL_0607: Expected O, but got I4
		//IL_0610: Expected O, but got I4
		//IL_059a: Expected O, but got I
		//IL_05b2: Expected O, but got I4
		//IL_0624: Expected O, but got I
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected O, but got Unknown
		//IL_06c4: Expected O, but got I
		//IL_0c21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c26: Expected O, but got Unknown
		//IL_0c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3d: Expected O, but got Unknown
		//IL_0c5f: Expected O, but got I4
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected O, but got Unknown
		//IL_072f: Expected O, but got I4
		//IL_0858: Expected O, but got I4
		//IL_07be: Expected O, but got I4
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected O, but got Unknown
		//IL_076d: Expected O, but got I4
		//IL_0c03: Expected O, but got I4
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected O, but got Unknown
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected O, but got Unknown
		//IL_0819: Expected O, but got I4
		//IL_0940: Expected O, but got I
		//IL_0950: Unknown result type (might be due to invalid IL or missing references)
		//IL_0955: Expected O, but got Unknown
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Expected O, but got Unknown
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Expected O, but got Unknown
		//IL_09c1: Expected O, but got I
		//IL_09cf: Expected I, but got O
		//IL_0c8b: Expected O, but got I4
		//IL_0cb7: Expected O, but got I4
		//IL_0cc0: Expected O, but got I4
		//IL_0cc9: Expected O, but got I4
		//IL_0cd2: Expected O, but got I4
		//IL_0ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab7: Expected O, but got Unknown
		//IL_0ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acb: Expected O, but got Unknown
		//IL_0ae1: Expected O, but got I
		//IL_0aef: Expected I, but got O
		//IL_0b1d: Expected O, but got I4
		//IL_0b26: Expected O, but got I4
		//IL_0cfc: Expected O, but got I4
		//IL_0bb3: Expected O, but got I4
		//IL_0bbc: Expected O, but got I4
		//IL_0a8a: Expected O, but got I4
		//IL_0a93: Expected O, but got I4
		//IL_0b82: Expected O, but got I4
		//IL_0b8b: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B8C]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		Object obj5;
		Object obj8;
		Delegate obj9;
		Delegate obj7;
		object obj10;
		if (obj3 != null)
		{
			obj4 = this + 32;
			obj5 = (Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v116+E4]");
			obj7 = (Delegate)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v116+E4]");
			bool flag = (nint)0 == 0;
			obj8 = (Object)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v116+E4]");
			obj9 = (Delegate)0;
			obj10 = obj4;
			if (!flag)
			{
				goto IL_00c0;
			}
		}
		else
		{
			_ = 1;
			obj4 = this + 32;
			obj5 = (Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v116+E4]");
			obj7 = (Delegate)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v116+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			obj8 = (Object)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v116+E4]");
			obj9 = (Delegate)0;
			obj10 = obj4;
			if (obj11 != null)
			{
				goto IL_00c0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj8;
		bool flag4 = !flag3;
		object obj12 = !flag4;
		obj4 = obj10;
		obj7 = obj9;
		if (obj12 != null)
		{
			goto IL_00f2;
		}
		goto IL_01d4;
		IL_0462:
		Object obj13;
		bool flag5 = obj13 == null;
		bool flag6 = !flag5;
		object obj14 = !flag6;
		object obj15 = 0;
		Object obj16 = null;
		if (obj14 != null)
		{
			goto IL_055b;
		}
		object obj17 = 0;
		goto IL_061e;
		IL_0da4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0aa9:
		object obj18;
		obj10 = obj18 + 48;
		object obj19 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)1344;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj20);
		Delegate obj21 = Delegate.Combine((Delegate)obj10, action);
		bool flag7 = (object)obj21 == null;
		object obj22 = 0;
		obj17 = 0;
		obj7 = obj21;
		InvalidCastException ex;
		object obj23;
		if (!flag7)
		{
			obj23 = obj19;
			if (obj21 == obj19)
			{
				obj10 = obj21;
				bool flag8 = obj21 == obj19;
				obj22 = 0;
				obj17 = 0;
				obj7 = obj21;
				if (flag8)
				{
					goto IL_0da4;
				}
			}
			ex = new InvalidCastException();
			obj22 = 0;
			obj17 = 0;
			obj7 = obj21;
			obj4 = obj10;
			goto IL_0bd1;
		}
		obj10 = 0;
		goto IL_0da4;
		IL_00c0:
		bool flag9 = obj5;
		bool flag10 = !flag9;
		obj10 = obj4;
		if (!flag10)
		{
			goto IL_00f2;
		}
		goto IL_01d4;
		IL_01d4:
		Transform transform = base.transform;
		ScrollRect parentScrollRect;
		if ((object)transform != null)
		{
			Transform parent = transform.parent;
			if ((object)parent != null)
			{
				object obj24 = (nint)0 + (nint)504;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
				ScrollRect scrollRect = default(ScrollRect);
				parentScrollRect = scrollRect;
				obj4 = obj10;
				goto IL_0d08;
			}
		}
		goto IL_0ce8;
		IL_055b:
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v39+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X22_v5+18]");
			bool flag11 = (Object)0 == null;
			bool flag12 = !flag11;
			obj17 = 0;
			if (!flag12)
			{
				goto IL_05c0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X22_v5+18]");
			bool flag13 = (Object)0 == null;
			bool flag14 = !flag13;
			object obj26 = !flag14;
			obj17 = 0;
			if (obj26 != null)
			{
				goto IL_05c0;
			}
		}
		goto IL_061e;
		IL_08b4:
		obj7 = (Delegate)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v2 (System.Delegate)+E4]");
		bool flag15 = (nint)0 == 0;
		ex = (InvalidCastException)obj4;
		if (!flag15)
		{
			if ((bool)(Object)obj4)
			{
				goto IL_090f;
			}
			return;
		}
		goto IL_0bd1;
		IL_00f2:
		parentScrollRect = (ScrollRect)obj4;
		goto IL_0d08;
		IL_0d08:
		ParentScrollRect = parentScrollRect;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj27 = this + 40;
		object obj28 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v7+E4]");
		obj7 = (Delegate)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			if ((bool)(Object)obj27)
			{
				goto IL_027a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag16 = (Object)obj27;
			bool flag17 = !flag16;
			object obj29 = !flag17;
			if (obj29 != null)
			{
				goto IL_027a;
			}
		}
		Transform transform2 = base.transform;
		bool flag18 = (object)transform2 == null;
		obj10 = obj4;
		ListViewVerticalMouseScroller parentListView;
		if (!flag18)
		{
			Transform parent2 = transform2.parent;
			bool flag19 = (object)parent2 == null;
			obj10 = obj4;
			if (!flag19)
			{
				obj7 = (Delegate)((nint)0 + (nint)464);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
				ListViewVerticalMouseScroller listViewVerticalMouseScroller = default(ListViewVerticalMouseScroller);
				parentListView = listViewVerticalMouseScroller;
				goto IL_0d64;
			}
		}
		goto IL_0ce8;
		IL_090f:
		bool flag20 = obj4 == null;
		obj10 = obj4;
		if (!flag20)
		{
			obj7 = (Delegate)((nint)0 + (nint)4088);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			obj10 = this + 64;
			object obj30 = default(object);
			obj10 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (obj10 != null)
			{
				object a = obj10 + 32;
				object obj31 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3016;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj7 = (Delegate)((nint)0 + (nint)1336);
				Action<object> action2 = default(Action<object>);
				action2..ctor((object)this, (IntPtr)obj7);
				Delegate obj32 = Delegate.Combine((Delegate)a, action2);
				object obj35;
				if ((object)obj32 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					object obj33 = default(object);
					if (obj33 != null)
					{
						a = obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						object obj34 = default(object);
						if (obj34 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							obj18 = obj10;
							bool flag21 = obj10 == null;
							obj35 = obj34;
							obj22 = 0;
							obj17 = 0;
							obj10 = obj10;
							if (!flag21)
							{
								goto IL_0aa9;
							}
							goto IL_0ce8;
						}
					}
					throw new InvalidCastException();
				}
				a = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj18 = obj10;
				bool flag22 = obj10 == null;
				object obj36 = !flag22;
				obj35 = 0;
				obj22 = 0;
				obj17 = 0;
				obj10 = obj10;
				if (obj36 != null)
				{
					goto IL_0aa9;
				}
			}
		}
		goto IL_0ce8;
		IL_05c0:
		base.enabled = false;
		return;
		IL_082f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj38;
		object obj37 = obj38;
		goto IL_0846;
		IL_061e:
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj40 = this + 48;
		object obj41 = default(object);
		obj40 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj7 = (Delegate)obj40;
		bool flag23 = obj40 == null;
		obj10 = obj4;
		object obj45;
		if (!flag23)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v2 (System.Delegate)+29]");
			scrollOtherHorizontally = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v2 (System.Delegate)+29]");
			if ((nint)0 == 1)
			{
				obj7 = (Delegate)(nint)obj7.method;
				bool flag24 = obj7.method != (IntPtr)1;
				obj23 = obj41;
				if (!flag24)
				{
					object obj42 = typeof(DataRelation) + 856;
					object obj43 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v72+E4]");
					bool flag25 = (nint)0 == 0;
					object obj44 = !flag25;
					if (obj44 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					obj7 = (Delegate)(object)("WhiteSmoke" + 1912);
					Debug.Log(obj7);
					obj23 = 0;
				}
				bool flag26 = obj45 == null;
				obj10 = obj4;
				if (!flag26)
				{
					bool flag27 = ((ScrollConflictParent)obj45).isHorizontal();
					bool flag28 = !flag27;
					object obj46 = !flag28;
					if (obj46 == null)
					{
						object obj47 = typeof(DataRelation) + 856;
						object obj48 = obj47;
						obj38 = "The operation is not allowed on non-connected sockets." + 48;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X0_v66+E4]");
						bool flag29 = (nint)0 == 0;
						object obj49 = !flag29;
						obj37 = obj38;
						if (obj49 == null)
						{
							goto IL_082f;
						}
						goto IL_0846;
					}
					goto IL_08b4;
				}
			}
			else
			{
				bool flag30 = obj45 == null;
				obj10 = obj4;
				if (!flag30)
				{
					bool flag31 = ((ScrollConflictParent)obj45).isVertical();
					bool flag32 = !flag31;
					obj23 = obj41;
					if (!flag32)
					{
						goto IL_08b4;
					}
					object obj50 = typeof(DataRelation) + 856;
					object obj48 = obj50;
					obj37 = "The operation is not allowed on non-connected sockets." + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X0_v66+E4]");
					bool flag33 = (nint)0 == 0;
					object obj51 = !flag33;
					if (obj51 == null)
					{
						obj23 = obj41;
						obj38 = obj37;
						goto IL_082f;
					}
					goto IL_0846;
				}
			}
		}
		goto IL_0ce8;
		IL_0846:
		Debug.Log(obj37);
		obj23 = 0;
		goto IL_08b4;
		IL_027a:
		parentListView = (ListViewVerticalMouseScroller)obj27;
		goto IL_0d64;
		IL_0d64:
		object obj52 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2824;
		ParentListView = parentListView;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj53 = default(object);
		obj53..ctor();
		object obj54 = obj53 + 16;
		obj54 = ParentScrollRect;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj55 = obj53 + 24;
		obj55 = ParentListView;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj45 = this + 72;
		obj45 = obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj56 = obj45;
		bool flag34 = obj45 == null;
		obj10 = obj4;
		if (!flag34)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B8D]");
			object obj57 = (nint)0 & (nint)1;
			Object obj59;
			if (obj57 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X22_v5+10]");
				obj13 = (Object)0;
				object obj58 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v40+E4]");
				bool flag35 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X22_v5+10]");
				obj59 = (Object)0;
				if (!flag35)
				{
					goto IL_0462;
				}
			}
			else
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X22_v5+10]");
				obj13 = (Object)0;
				object obj58 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v40+E4]");
				bool flag36 = (nint)0 == 0;
				object obj60 = !flag36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X22_v5+10]");
				obj59 = (Object)0;
				if (obj60 != null)
				{
					goto IL_0462;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag37 = obj59 == null;
			bool flag38 = !flag37;
			obj15 = 0;
			obj16 = null;
			obj17 = 0;
			if (!flag38)
			{
				goto IL_055b;
			}
			goto IL_061e;
		}
		goto IL_0ce8;
		IL_0bd1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag39 = (Object)(object)ex;
		bool flag40 = !flag39;
		object obj61 = !flag40;
		if (obj61 == null)
		{
			return;
		}
		goto IL_090f;
		IL_0ce8:
		throw new NullReferenceException();
	}

	private void OnScrollBegin(PointerEventData eventData)
	{
		scrollOther = true;
		_myScrollRect.enabled = false;
	}

	public void OnScroll(PointerEventData eventData)
	{
		if (scrollOther)
		{
			parentScroll.OnScroll(eventData);
		}
	}

	private void OnScrollEnd()
	{
		scrollOther = false;
		_myScrollRect.enabled = true;
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		if (scrollOtherHorizontally)
		{
			Vector2 <position>k__BackingField = eventData.<position>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [eventData @ X1 (UnityEngine.EventSystems.PointerEventData)+148]");
			if ((nint)<position>k__BackingField <= 0)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [eventData @ X1 (UnityEngine.EventSystems.PointerEventData)+148]");
			if (0 <= (nint)eventData.<position>k__BackingField)
			{
				return;
			}
		}
		scrollOther = true;
		_myScrollRect.enabled = false;
		parentScroll.OnBeginDrag(eventData);
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		if (scrollOther)
		{
			scrollOther = false;
			_myScrollRect.enabled = true;
			parentScroll.OnEndDrag(eventData);
		}
	}

	public void OnDrag(PointerEventData eventData)
	{
		if (scrollOther)
		{
			parentScroll.OnDrag(eventData);
		}
	}
}
