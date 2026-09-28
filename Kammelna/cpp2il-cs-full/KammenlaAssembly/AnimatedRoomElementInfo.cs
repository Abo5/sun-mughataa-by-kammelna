using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem.XR;

[Serializable]
public struct AnimatedRoomElementInfo
{
	public AnimatedRoomElementType type;

	public string name;

	public Vector2 pivotPosition;

	public Vector2 tabletPivotPosition;

	public Vector3 rotation;

	public float width;

	public float height;

	public Vector2 tabletSize;

	public bool useWidthHeightAsScale;

	public int loopCount;

	public float duration;

	public Vector2Int spriteGridSize;

	public int sortOrder;

	public float delay;

	public bool isJackarooBoard;

	public bool isJackarooBoardPreview;

	public bool hasTabletScale
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected O, but got Unknown
			object obj = typeof(UsageHint) + 744;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			object obj4 = (object)tabletSize - obj3;
			object obj5 = obj4 * obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			object obj6 = obj5 - 786163454;
			bool flag = (nint)obj6 < 0;
			return !flag;
		}
	}
}
