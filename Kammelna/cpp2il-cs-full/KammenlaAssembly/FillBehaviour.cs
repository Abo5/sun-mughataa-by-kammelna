using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public abstract class FillBehaviour : ProgressBehaviour
{
	private bool remap;

	private Vector2 remapRange;

	protected float Remap(float normalized)
	{
		//IL_003f: Invalid comparison between F4 and I4
		//IL_004e: Invalid comparison between F4 and I4
		//IL_0066: Expected O, but got F8
		//IL_0073: Expected O, but got F4
		//IL_00a8: Expected O, but got I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_0114: Invalid comparison between F4 and I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_00f4: Expected F4, but got I4
		float num2 = default(float);
		if (remap)
		{
			float num = num2 - 1f;
			bool flag = num < 0f;
			bool flag2 = num == 0f;
			object obj = (double)num2 ^ 1.0;
			object obj2 = num2 ^ num;
			object obj3 = obj & obj2;
			bool flag3 = (nint)obj3 < 0;
			bool flag4 = flag == flag3;
			object obj4 = !flag2;
			object obj5 = flag4 & obj4;
			object obj6 = ~obj5;
			float num3 = ((obj6 != null) ? num2 : 1f);
			float num4 = ((!(num2 < 0f)) ? num3 : 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FillBehaviour)+18]");
			object obj7 = 0 - remapRange;
			float num5 = num4 * (float)obj7;
			return (float)remapRange + num5;
		}
		return num2;
	}

	protected FillBehaviour()
	{
		//IL_0012: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DDA10]");
		remapRange = (Vector2)0;
		((object)this)..ctor();
	}
}
