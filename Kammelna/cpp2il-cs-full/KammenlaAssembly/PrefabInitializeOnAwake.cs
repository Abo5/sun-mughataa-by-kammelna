using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.TextCore;

public class PrefabInitializeOnAwake : MonoBehaviour
{
	private IInitializable target;

	private void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_003d: Expected O, but got I
		//IL_00db: Expected O, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0118: Expected O, but got I
		//IL_0078: Expected O, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3832;
		object obj3 = default(object);
		object obj8 = default(object);
		object obj10 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			object obj2 = this + 32;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2;
			object obj5 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3144;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+12E]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+B0]");
				obj8 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v4-8]");
					if (0 == (nint)obj5)
					{
						break;
					}
					obj8 += 16;
					obj7--;
					if ((nint)obj7 != 1)
					{
						continue;
					}
					goto IL_00b9;
				}
				goto IL_00e5;
			}
			goto IL_00b9;
			IL_00b9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v8+8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v124 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00e5;
			IL_00e5:
			object obj12 = obj6 + obj8;
			object obj13 = obj12 + 312;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v10+8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v139 @ X2_v3 (should have been resolved before IL gen)");
		}
	}
}
