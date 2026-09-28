using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public static class OnScreenBaseCamera
{
	public static Camera Resolve()
	{
		//IL_01bd: Expected O, but got I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I4
		//IL_0100: Expected O, but got I
		//IL_014e: Expected O, but got I4
		Camera main = Camera.main;
		bool flag = RendersToScreen(main);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			object tag = "ThisIsFakeReceiptData" + 3744;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			GameObject gameObject = GameObject.FindGameObjectWithTag((string)tag);
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				if (gameObject == null)
				{
					goto IL_008d;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = gameObject == null;
				bool flag4 = !flag3;
				object obj4 = !flag4;
				if (obj4 != null)
				{
					goto IL_008d;
				}
			}
			if ((object)gameObject == null)
			{
				return (Camera)(object)new NullReferenceException();
			}
			object obj5 = (nint)0 + (nint)1760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E3438C");
			object obj6 = default(object);
			if (obj6 != null)
			{
				Camera camera = default(Camera);
				bool flag5 = RendersToScreen(camera);
				bool flag6 = !flag5;
				object obj7 = !flag6;
				object obj8 = ~obj7;
				if (obj8 == null)
				{
					return camera;
				}
				return main;
			}
		}
		goto IL_008d;
		IL_008d:
		return main;
	}

	private static bool RendersToScreen(Camera camera)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00de: Expected O, but got I4
		//IL_009a: Expected O, but got I4
		//IL_0287: Expected I4, but got O
		//IL_0123: Expected O, but got I4
		//IL_012c: Expected O, but got I4
		//IL_01f9: Expected O, but got I4
		//IL_0213: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73F8]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v18+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = camera == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		object obj6 = 0;
		if (obj5 != null)
		{
			goto IL_00a8;
		}
		goto IL_013a;
		IL_00a8:
		return false;
		IL_01bc:
		return false;
		IL_013a:
		if ((object)camera != null)
		{
			RenderTexture targetTexture = camera.targetTexture;
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v4+E4]");
			if ((nint)0 != 0)
			{
				if (targetTexture != null)
				{
					goto IL_01bc;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag4 = targetTexture != null;
				bool flag5 = !flag4;
				object obj8 = !flag5;
				if (obj8 != null)
				{
					goto IL_01bc;
				}
			}
			object obj9 = (nint)0 + (nint)1224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
			object obj10 = default(object);
			if (obj10 == null)
			{
				return true;
			}
			object obj11 = default(object);
			if (obj11 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ stack_-38_v3+2C]");
				return (nint)0 == 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0074:
		bool flag6 = camera == null;
		bool flag7 = !flag6;
		obj6 = 0;
		if (!flag7)
		{
			goto IL_00a8;
		}
		goto IL_013a;
	}
}
