using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RenderTextureGraphicRaycaster : GraphicRaycaster
{
	public unsafe override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0058: Expected O, but got I
		//IL_006e: Expected O, but got Ref
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		if (ShouldTranslateScreenPoint())
		{
			object obj = typeof(RegisteredWaitHandle) + 456;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v7+B8]");
			object obj3 = 0;
			object obj4 = default(object);
			if (((RenderTextureInputMapper)obj3).TryMapScreenPointToRenderTexturePoint((Vector3)(&obj4), out *(Vector3*)resultAppendList))
			{
				object obj5 = eventData + 324;
				obj5 = obj4;
				base.Raycast(eventData, resultAppendList);
				obj5 = obj5;
				return;
			}
		}
		base.Raycast(eventData, resultAppendList);
	}

	private bool ShouldTranslateScreenPoint()
	{
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_02c2: Expected O, but got I4
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02ec: Expected O, but got I
		//IL_00b1: Expected O, but got I
		//IL_00e3: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_001d: Expected O, but got I
		//IL_014c: Expected I, but got O
		//IL_0130: Expected O, but got I4
		//IL_0139: Expected O, but got I4
		//IL_01f4: Expected O, but got I4
		//IL_01fd: Expected O, but got I4
		//IL_01a9: Expected O, but got I4
		//IL_02a5: Expected I4, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = 146685952;
		object obj3 = typeof(RegisteredWaitHandle) + 456;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D7]");
		object obj4 = (nint)0 & (nint)1;
		UnityEngine.Object obj7;
		UnityEngine.Object obj9;
		if (obj4 != null)
		{
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v15+B8]");
			object obj6 = 0;
			obj7 = (UnityEngine.Object)obj6;
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v22+E4]");
			bool flag = (nint)0 == 0;
			obj9 = (UnityEngine.Object)obj6;
			if (!flag)
			{
				goto IL_005a;
			}
		}
		else
		{
			_ = 1;
			object obj10 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v11+B8]");
			object obj11 = 0;
			obj7 = (UnityEngine.Object)obj11;
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v22+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			obj9 = (UnityEngine.Object)obj11;
			if (obj12 != null)
			{
				goto IL_005a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj9 == null;
		bool flag4 = !flag3;
		object obj13 = !flag4;
		object obj14 = 0;
		if (obj13 == null)
		{
			goto IL_0147;
		}
		goto IL_01b7;
		IL_01b7:
		return false;
		IL_0147:
		nint num = (nint)this;
		Camera camera = base.eventCamera;
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = camera == null;
			bool flag6 = !flag5;
			object obj16 = 0;
			if (!flag6)
			{
				goto IL_01b7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = camera == null;
			bool flag8 = !flag7;
			object obj17 = !flag8;
			object obj16 = 0;
			if (obj17 != null)
			{
				goto IL_01b7;
			}
		}
		if ((object)camera != null)
		{
			RenderTexture targetTexture = camera.targetTexture;
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v8+E4]");
			if ((nint)0 != 0)
			{
				return targetTexture != null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return targetTexture != null;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_005a:
		bool flag9 = obj7 == null;
		bool flag10 = !flag9;
		obj14 = 0;
		if (flag10)
		{
			goto IL_0147;
		}
		goto IL_01b7;
	}

	public RenderTextureGraphicRaycaster()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00b4: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3288;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73FA]");
		if ((object)((nint)0 & (nint)1) != null)
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
			if ((object)((nint)0 != 0) != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		base..ctor();
		return;
		IL_007d:
		base..ctor();
	}
}
