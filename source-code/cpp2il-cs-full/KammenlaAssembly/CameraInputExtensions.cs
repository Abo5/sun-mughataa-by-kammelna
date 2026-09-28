using System;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public static class CameraInputExtensions
{
	public unsafe static Ray ScreenPointToRayThroughRenderTexture(Camera camera, Vector3 screenPoint)
	{
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0213: Expected O, but got I4
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_023d: Expected O, but got I
		//IL_00aa: Expected O, but got I
		//IL_00dc: Expected O, but got I4
		//IL_001d: Expected O, but got I
		//IL_0125: Expected O, but got I4
		//IL_016f: Expected O, but got Ref
		//IL_01df: Expected O, but got I4
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v15+B8]");
			object obj6 = 0;
			obj7 = (UnityEngine.Object)obj6;
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v11+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v11+B8]");
			object obj11 = 0;
			obj7 = (UnityEngine.Object)obj11;
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v11+E4]");
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
		ref Vector3 renderTexturePoint = ref *(Vector3*)null;
		obj7 = obj9;
		if (obj13 == null)
		{
			goto IL_0141;
		}
		goto IL_01b4;
		IL_01b4:
		if ((object)camera != null)
		{
			goto IL_01d1;
		}
		goto IL_01e8;
		IL_01d1:
		return camera.ScreenPointToRay((Vector3)0);
		IL_01e8:
		return (Ray)new NullReferenceException();
		IL_005a:
		bool flag5 = obj7 == null;
		bool flag6 = !flag5;
		renderTexturePoint = ref *(Vector3*)null;
		if (flag6)
		{
			goto IL_0141;
		}
		goto IL_01b4;
		IL_0141:
		if ((object)obj7 != null)
		{
			object obj14 = default(object);
			if (!((RenderTextureInputMapper)obj7).TryMapScreenPointToRenderTexturePoint((Vector3)(&obj14), out renderTexturePoint))
			{
				goto IL_01b4;
			}
			if ((object)camera != null)
			{
				goto IL_01d1;
			}
		}
		goto IL_01e8;
	}
}
