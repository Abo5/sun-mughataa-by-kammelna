using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Unity.Properties;
using UnityEngine;

[Serializable]
public class EnumSprites
{
	private Sprite peaceful;

	private Sprite excitement;

	private Sprite game;

	private Sprite negative;

	private Sprite sorry;

	private Sprite[] Sprites;

	public void Setup()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0156: Expected O, but got I4
		//IL_0166: Expected O, but got I
		//IL_0188: Expected O, but got I4
		//IL_00c9: Expected O, but got I
		//IL_00e9: Expected O, but got I4
		//IL_0067: Expected O, but got I4
		//IL_0077: Expected O, but got I
		//IL_0126: Expected O, but got I4
		//IL_01d2: Expected O, but got I
		//IL_01f4: Expected O, but got I4
		//IL_01fd: Expected O, but got I4
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02d4: Expected O, but got I
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0366: Expected O, but got I4
		//IL_0376: Expected O, but got I4
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		//IL_0455: Expected O, but got I4
		//IL_0465: Expected O, but got I4
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected O, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(IAsyncEnumerable<>) + 3264;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E76C0]");
		object obj3 = (nint)0 & (nint)1;
		RuntimeTypeHandle handle;
		RuntimeTypeHandle handle2;
		if (obj3 != null)
		{
			handle = (RuntimeTypeHandle)obj2;
			object obj4 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X21_v12+E0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v31+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			handle2 = (RuntimeTypeHandle)obj2;
			if (!flag)
			{
				goto IL_00ac;
			}
		}
		else
		{
			_ = 1;
			handle = (RuntimeTypeHandle)obj2;
			object obj4 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X21_v12+E0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v31+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			handle2 = (RuntimeTypeHandle)obj2;
			if (obj7 != null)
			{
				goto IL_00ac;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Type typeFromHandle = Type.GetTypeFromHandle(handle2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X21_v8+98]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = 0;
		Type enumType = typeFromHandle;
		if (obj9 != null)
		{
			goto IL_00ff;
		}
		goto IL_0213;
		IL_04bd:
		NullReferenceException ex = new NullReferenceException();
		goto IL_04cb;
		IL_04cb:
		throw new IndexOutOfRangeException();
		IL_024c:
		object obj11 = typeof(TypeConverter<ushort, char>) + 3968;
		Array values;
		int length = values.Length;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj12 = this + 56;
		object obj13 = default(object);
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj12 != null)
		{
			object obj14 = obj12 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X20_v8-28]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (Sprites != null)
			{
				object obj15 = Sprites + 40;
				obj15 = excitement;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Sprite[] sprites = Sprites;
				if (Sprites != null)
				{
					bool flag4 = sprites.Length < 2;
					object obj16 = !flag4;
					object obj17 = sprites.Length - 2;
					bool flag5 = obj17 == null;
					object obj18 = ~obj16;
					object obj19 = obj18 | flag5;
					if (obj19 != null)
					{
						goto IL_04cb;
					}
					object obj20 = Sprites + 48;
					obj20 = game;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if (Sprites != null)
					{
						object obj21 = Sprites + 56;
						obj21 = negative;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Sprite[] sprites2 = Sprites;
						if (Sprites != null)
						{
							bool flag6 = sprites2.Length < 4;
							object obj22 = !flag6;
							object obj23 = sprites2.Length - 4;
							bool flag7 = obj23 == null;
							object obj24 = ~obj22;
							object obj25 = obj24 | flag7;
							if (obj25 == null)
							{
								object obj26 = Sprites + 64;
								obj26 = sorry;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								return;
							}
							goto IL_04cb;
						}
					}
				}
			}
		}
		goto IL_04bd;
		IL_00ac:
		typeFromHandle = Type.GetTypeFromHandle(handle);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X21_v12+98]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v10+E4]");
		bool flag8 = (nint)0 == 0;
		obj10 = 0;
		enumType = typeFromHandle;
		if (!flag8)
		{
			goto IL_00ff;
		}
		goto IL_0213;
		IL_0213:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		values = Enum.GetValues(enumType);
		if (values != null)
		{
			goto IL_024c;
		}
		goto IL_04bd;
		IL_00ff:
		values = Enum.GetValues(typeFromHandle);
		bool flag9 = values == null;
		object obj27 = !flag9;
		if (obj27 != null)
		{
			goto IL_024c;
		}
		goto IL_04bd;
	}

	public Sprite GetSprite(ReplyCategory category)
	{
		//IL_0044: Expected O, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		Sprite[] sprites = Sprites;
		if (Sprites != null)
		{
			bool flag = (int)category < sprites.Length;
			object obj = !flag;
			if (obj == null)
			{
				object obj2 = Sprites + category;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v2+20]");
				return (Sprite)0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return (Sprite)(object)new IndexOutOfRangeException();
	}
}
