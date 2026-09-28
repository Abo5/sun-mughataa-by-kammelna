using System;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class AutoSwapRenderTextureRaycaster : MonoBehaviour
{
	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00df: Expected O, but got I
		//IL_0109: Expected O, but got I4
		//IL_00b9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_018b: Expected O, but got I
		//IL_0199: Expected O, but got I4
		//IL_01a2: Expected O, but got I4
		//IL_01f4: Expected O, but got I
		//IL_0209: Expected I, but got O
		//IL_0232: Expected O, but got I4
		//IL_0266: Expected O, but got I
		//IL_0346: Expected O, but got I4
		//IL_0350: Expected O, but got I4
		//IL_0359: Expected O, but got I4
		//IL_02e9: Expected O, but got I4
		//IL_02f3: Expected O, but got I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_030a: Expected O, but got I4
		//IL_042e: Expected O, but got I4
		//IL_0440: Expected O, but got I4
		//IL_0451: Expected O, but got I4
		//IL_03c9: Expected O, but got I4
		//IL_03d3: Expected O, but got I4
		//IL_03f2: Expected O, but got I4
		//IL_0539: Expected O, but got I4
		//IL_054b: Expected O, but got I4
		//IL_0555: Expected O, but got I4
		//IL_04d3: Expected O, but got I4
		//IL_04e5: Expected O, but got I4
		//IL_0584: Expected I4, but got O
		//IL_04fd: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73E9]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)344;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v34+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)344;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v34+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9820");
		goto IL_0146;
		IL_0146:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3 (System.Boolean)+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		object obj9 = typeof(RegisteredWaitHandle) + 448;
		object obj10 = (nint)0 + (nint)3656;
		bool flag3 = default(bool);
		object obj11 = (flag3 ? 1 : 0) + 32;
		object obj12 = 0;
		bool flag4 = flag3;
		UnityEngine.Object obj18 = default(UnityEngine.Object);
		Camera camera2 = default(Camera);
		object obj30;
		do
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X26_v4+v135 @ X23_v5*8]");
			GraphicRaycaster graphicRaycaster = (GraphicRaycaster)0;
			object obj13 = obj9;
			nint num = (nint)graphicRaycaster;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X9_v4 (Il2CppClass<UnityEngine.UI.GraphicRaycaster>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v7+130]");
			bool flag5 = num2 < 0;
			object obj14 = !flag5;
			object obj15 = ~obj14;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X9_v4 (Il2CppClass<UnityEngine.UI.GraphicRaycaster>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v7+130]");
				object obj16 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X9_v9-8]");
				if (0 == (nint)obj13)
				{
					goto IL_01af;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			object obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				flag4 = obj18 == null;
				bool flag6 = !flag4;
				object obj19 = !flag6;
				obj8 = 0;
				if (obj19 != null)
				{
					goto IL_01af;
				}
				object obj20 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				flag4 = obj18 == null;
				bool flag7 = !flag4;
				object obj21 = !flag7;
				obj8 = 0;
				object obj20 = 0;
				if (obj21 != null)
				{
					goto IL_01af;
				}
			}
			Camera worldCamera = ((Canvas)obj18).worldCamera;
			object obj22 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v9+E4]");
			Camera camera;
			if ((nint)0 != 0)
			{
				flag4 = worldCamera == null;
				bool flag8 = !flag4;
				object obj23 = !flag8;
				obj8 = 0;
				if (obj23 != null)
				{
					goto IL_01af;
				}
				camera = camera2;
				object obj24 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				flag4 = worldCamera == null;
				bool flag9 = !flag4;
				object obj25 = !flag9;
				camera2 = worldCamera;
				obj8 = 0;
				camera = worldCamera;
				object obj24 = 0;
				if (obj25 != null)
				{
					goto IL_01af;
				}
			}
			Camera worldCamera2 = ((Canvas)obj18).worldCamera;
			RenderTexture targetTexture = worldCamera2.targetTexture;
			object obj26 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v10+E4]");
			object obj28;
			if ((nint)0 != 0)
			{
				flag4 = targetTexture == null;
				bool flag10 = !flag4;
				object obj27 = !flag10;
				camera2 = camera;
				obj8 = 0;
				if (obj27 != null)
				{
					goto IL_01af;
				}
				obj28 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				flag4 = targetTexture == null;
				bool flag11 = !flag4;
				object obj29 = !flag11;
				camera2 = camera;
				obj8 = 0;
				obj28 = 0;
				if (obj29 != null)
				{
					goto IL_01af;
				}
			}
			ReplaceRaycaster(graphicRaycaster);
			camera2 = camera;
			obj8 = obj28;
			flag4 = (byte)(int)graphicRaycaster != 0;
			goto IL_01af;
			IL_01af:
			obj12++;
			obj30 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3 (System.Boolean)+18]");
		}
		while ((nint)obj30 < 0);
		return;
		IL_0091:
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9820");
		bool flag12 = !flag3;
		object obj31 = !flag12;
		if (obj31 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0146;
	}

	private static void ReplaceRaycaster(GraphicRaycaster original)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_0087: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		GameObject gameObject = original.gameObject;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.DestroyImmediate(original);
		object obj4 = (nint)0 + (nint)848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
		_ = original.m_IgnoreReversedGraphics;
		_ = original.m_BlockingObjects;
	}
}
