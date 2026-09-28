using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public struct AnimationCurveInfo
{
	public SelectedVector SelectedVector;

	public AnimationCurve SingleCurve;

	private AnimationCurve XCurve;

	private AnimationCurve YCurve;

	private AnimationCurve ZCurve;

	public AnimationCurve CurveX
	{
		get
		{
			//IL_0039: Expected O, but got I4
			//IL_004b: Expected O, but got I
			//IL_002b: Expected O, but got I4
			if (SelectedVector == SelectedVector.Single)
			{
				object obj = 8;
			}
			else
			{
				object obj = 16;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimationCurveInfo)+v16 @ X8_v3]");
			return (AnimationCurve)0;
		}
	}

	public AnimationCurve CurveY
	{
		get
		{
			//IL_0039: Expected O, but got I4
			//IL_004b: Expected O, but got I
			//IL_002b: Expected O, but got I4
			if (SelectedVector == SelectedVector.Single)
			{
				object obj = 8;
			}
			else
			{
				object obj = 24;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimationCurveInfo)+v16 @ X8_v3]");
			return (AnimationCurve)0;
		}
	}

	public AnimationCurve CurveZ
	{
		get
		{
			//IL_0039: Expected O, but got I4
			//IL_004b: Expected O, but got I
			//IL_002b: Expected O, but got I4
			if (SelectedVector == SelectedVector.Single)
			{
				object obj = 8;
			}
			else
			{
				object obj = 32;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimationCurveInfo)+v16 @ X8_v3]");
			return (AnimationCurve)0;
		}
	}

	public bool hasXCurve
	{
		get
		{
			//IL_001c: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			//IL_0042: Expected I4, but got O
			bool flag = SelectedVector < (SelectedVector)8;
			object obj = !flag;
			object obj2 = ~obj;
			object obj3 = 179 >> (int)SelectedVector;
			return (byte)(obj2 & obj3) != 0;
		}
	}

	public bool hasYCurve
	{
		get
		{
			//IL_001c: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			//IL_0042: Expected I4, but got O
			bool flag = SelectedVector < (SelectedVector)8;
			object obj = !flag;
			object obj2 = ~obj;
			object obj3 = 213 >> (int)SelectedVector;
			return (byte)(obj2 & obj3) != 0;
		}
	}

	public bool hasZCurve
	{
		get
		{
			//IL_001c: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			//IL_0042: Expected I4, but got O
			bool flag = SelectedVector < (SelectedVector)8;
			object obj = !flag;
			object obj2 = ~obj;
			object obj3 = 233 >> (int)SelectedVector;
			return (byte)(obj2 & obj3) != 0;
		}
	}

	private bool ShowX()
	{
		//IL_001c: Expected O, but got I4
		//IL_0035: Expected O, but got I4
		//IL_0042: Expected I4, but got O
		bool flag = SelectedVector < (SelectedVector)8;
		object obj = !flag;
		object obj2 = ~obj;
		object obj3 = 178 >> (int)SelectedVector;
		return (byte)(obj2 & obj3) != 0;
	}

	private bool ShowY()
	{
		//IL_001c: Expected O, but got I4
		//IL_0035: Expected O, but got I4
		//IL_0042: Expected I4, but got O
		bool flag = SelectedVector < (SelectedVector)8;
		object obj = !flag;
		object obj2 = ~obj;
		object obj3 = 212 >> (int)SelectedVector;
		return (byte)(obj2 & obj3) != 0;
	}

	private bool ShowZ()
	{
		//IL_001c: Expected O, but got I4
		//IL_0035: Expected O, but got I4
		//IL_0042: Expected I4, but got O
		bool flag = SelectedVector < (SelectedVector)8;
		object obj = !flag;
		object obj2 = ~obj;
		object obj3 = 232 >> (int)SelectedVector;
		return (byte)(obj2 & obj3) != 0;
	}

	private bool ShowSingle()
	{
		return SelectedVector == SelectedVector.Single;
	}
}
