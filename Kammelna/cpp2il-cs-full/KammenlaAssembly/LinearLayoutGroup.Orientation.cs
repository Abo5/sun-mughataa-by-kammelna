using System.Buffers.Text;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.UI;

public class LinearLayoutGroup : HorizontalOrVerticalLayoutGroup
{
	public enum Orientation
	{
		Horizontal,
		Vertical
	}

	private Orientation orientation;

	public Orientation LayoutOrientation
	{
		get
		{
			return orientation;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00a4: Expected O, but got I4
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1648;
			Transform transform = base.transform;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				if ((object)transform != null)
				{
					goto IL_0036;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag = (object)transform == null;
				object obj3 = !flag;
				if (obj3 != null)
				{
					goto IL_0036;
				}
			}
			LayoutRebuilder.MarkLayoutForRebuild(null);
			return;
			IL_0036:
			object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
			RectTransform rect = (RectTransform)((transform != obj4) ? null : transform);
			LayoutRebuilder.MarkLayoutForRebuild(rect);
		}
	}

	public override void CalculateLayoutInputHorizontal()
	{
		//IL_0016: Expected O, but got I4
		base.CalculateLayoutInputHorizontal();
		object obj = orientation - 1;
		bool isVertical = obj == null;
		CalcAlongAxis(0, isVertical);
	}

	public override void CalculateLayoutInputVertical()
	{
		//IL_0010: Expected O, but got I4
		object obj = orientation - 1;
		bool isVertical = obj == null;
		CalcAlongAxis(1, isVertical);
	}

	private void CalcAlongAxis(int axis)
	{
		//IL_0010: Expected O, but got I4
		object obj = orientation - 1;
		bool isVertical = obj == null;
		CalcAlongAxis(axis, isVertical);
	}

	public override void SetLayoutHorizontal()
	{
		//IL_0010: Expected O, but got I4
		object obj = orientation - 1;
		bool isVertical = obj == null;
		SetChildrenAlongAxis(0, isVertical);
	}

	public override void SetLayoutVertical()
	{
		//IL_0010: Expected O, but got I4
		object obj = orientation - 1;
		bool isVertical = obj == null;
		SetChildrenAlongAxis(1, isVertical);
	}

	private void SetChildrenAlongAxis(int axis)
	{
		//IL_0010: Expected O, but got I4
		object obj = orientation - 1;
		bool isVertical = obj == null;
		SetChildrenAlongAxis(axis, isVertical);
	}
}
