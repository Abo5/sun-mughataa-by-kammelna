using Cpp2ILInjected;
using UnityEngine.UI;

public class SliderSnap : Slider
{
	private float[] snapPoints;

	private float snapThreshold = 0.05f;

	protected override void Set(float input, bool sendCallback)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0068: Expected O, but got I4
		//IL_00bf: Expected F4, but got O
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00e1: Invalid comparison between O and F4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		float[] array = snapPoints;
		if (snapPoints == null || array.Length < 1)
		{
			goto IL_009b;
		}
		object obj = snapPoints + 32;
		object obj2 = array.Length & 0x7FFFFFFF;
		float input2;
		object obj3 = default(object);
		while (true)
		{
			input2 = (float)obj;
			obj += 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			if (obj3 < (object)snapThreshold)
			{
				break;
			}
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_009b;
		}
		goto IL_00a8;
		IL_009b:
		input2 = input;
		goto IL_00a8;
		IL_00a8:
		base.Set(input2, sendCallback);
	}
}
