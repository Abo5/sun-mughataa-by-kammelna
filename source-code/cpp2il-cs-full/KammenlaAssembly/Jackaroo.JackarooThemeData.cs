using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Jackaroo;

[Serializable]
public class JackarooThemeData
{
	private Color <Bottom>k__BackingField;

	private Color <Left>k__BackingField;

	private Color <Top>k__BackingField;

	private Color <Right>k__BackingField;

	private Sprite <BoardSprite>k__BackingField;

	private Sprite <BottomMarble>k__BackingField;

	private Sprite <LeftMarble>k__BackingField;

	private Sprite <TopMarble>k__BackingField;

	private Sprite <RightMarble>k__BackingField;

	private bool <ColorizeNodes>k__BackingField;

	private Color <NodeDefaultColor>k__BackingField;

	private Color <NodeSelectedColor>k__BackingField;

	private Color <HighlightDefaultColor>k__BackingField;

	private bool <HighlightLastNode>k__BackingField;

	public Color Bottom
	{
		get
		{
			return (Color)this;
		}
		private set
		{
			Color color = default(Color);
			<Bottom>k__BackingField = color;
		}
	}

	public Color Left
	{
		get
		{
			return (Color)this;
		}
		private set
		{
			Color color = default(Color);
			<Left>k__BackingField = color;
		}
	}

	public Color Top
	{
		get
		{
			return (Color)this;
		}
		private set
		{
			Color color = default(Color);
			<Top>k__BackingField = color;
		}
	}

	public Color Right
	{
		get
		{
			return (Color)this;
		}
		private set
		{
			Color color = default(Color);
			<Right>k__BackingField = color;
		}
	}

	public Sprite BoardSprite
	{
		get
		{
			return <BoardSprite>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 80;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Sprite BottomMarble
	{
		get
		{
			return <BottomMarble>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 88;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Sprite LeftMarble
	{
		get
		{
			return <LeftMarble>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 96;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Sprite TopMarble
	{
		get
		{
			return <TopMarble>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 104;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Sprite RightMarble
	{
		get
		{
			return <RightMarble>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 112;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool ColorizeNodes
	{
		get
		{
			return <ColorizeNodes>k__BackingField;
		}
		private set
		{
			<ColorizeNodes>k__BackingField = value;
		}
	}

	public Color NodeDefaultColor
	{
		get
		{
			return (Color)this;
		}
		private set
		{
			Color color = default(Color);
			<NodeDefaultColor>k__BackingField = color;
		}
	}

	public Color NodeSelectedColor
	{
		get
		{
			return (Color)this;
		}
		private set
		{
			Color color = default(Color);
			<NodeSelectedColor>k__BackingField = color;
		}
	}

	public Color HighlightDefaultColor
	{
		get
		{
			return (Color)this;
		}
		private set
		{
			Color color = default(Color);
			<HighlightDefaultColor>k__BackingField = color;
		}
	}

	public bool HighlightLastNode
	{
		get
		{
			return <HighlightLastNode>k__BackingField;
		}
		private set
		{
			<HighlightLastNode>k__BackingField = value;
		}
	}

	public unsafe JackarooThemeData(Color bottom, Color left, Color top, Color right, Sprite boardSprite = null, Sprite bottomMarble = null, Sprite leftMarble = null, Sprite topMarble = null, Sprite rightMarble = null, bool colorizeNodes = false, Color nodeDefaultColor = default(Color), Color nodeSelectedColor = default(Color), Color highlightDefaultColor = default(Color), bool highlightLastNode = false)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0052: Expected O, but got I
		//IL_0064: Expected O, but got I
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		object obj2 = default(object);
		object obj = (object)(&obj2);
		base..ctor();
		Color color = default(Color);
		<Bottom>k__BackingField = color;
		Color color2 = default(Color);
		<Left>k__BackingField = color2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+10]");
		<Top>k__BackingField = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+20]");
		<Right>k__BackingField = (Color)0;
		object obj3 = this + 80;
		obj3 = bottom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = this + 88;
		obj4 = left;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = this + 96;
		obj5 = top;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = this + 104;
		obj6 = right;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = this + 112;
		obj7 = boardSprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+50]");
		_ = 0;
	}

	public Color GetPlayerColor(int rotatedIndex)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0090: Expected O, but got I
		object obj = rotatedIndex - 1;
		bool flag = (nint)obj < 4;
		object obj2 = !flag;
		if (obj2 == null)
		{
			return (Color)this;
		}
		int num = default(int);
		string message = num.ToString();
		object obj3 = typeof(System.IOAsyncCallback) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		ex..ctor(message);
		object obj4 = (nint)0 + (nint)944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (Color)new OutOfMemoryException();
	}

	public Sprite GetPlayerMarbleSprite(int rotatedIndex)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_005b: Expected O, but got I
		//IL_00b3: Expected O, but got I
		object obj = rotatedIndex - 1;
		bool flag = (nint)obj < 4;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = obj << 3;
			object obj4 = (object)this + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v3+58]");
			return (Sprite)0;
		}
		int num = default(int);
		string message = num.ToString();
		object obj5 = typeof(System.IOAsyncCallback) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		ex..ctor(message);
		object obj6 = (nint)0 + (nint)952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (Sprite)(object)new OutOfMemoryException();
	}
}
