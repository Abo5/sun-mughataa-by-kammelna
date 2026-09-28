using Cpp2ILInjected;
using UnityEngine;

public class ReplayPlayerColorsScriptableObject : ScriptableObject
{
	private Color <NormalColor>k__BackingField;

	private Color <PassedColor>k__BackingField;

	private Color <CommentColor>k__BackingField;

	public Color NormalColor
	{
		get
		{
			return (Color)this;
		}
		private set
		{
			Color color = default(Color);
			<NormalColor>k__BackingField = color;
		}
	}

	public Color PassedColor
	{
		get
		{
			return (Color)this;
		}
		private set
		{
			Color color = default(Color);
			<PassedColor>k__BackingField = color;
		}
	}

	public Color CommentColor
	{
		get
		{
			return (Color)this;
		}
		private set
		{
			Color color = default(Color);
			<CommentColor>k__BackingField = color;
		}
	}

	public ReplayPlayerColorsScriptableObject()
	{
		//IL_0012: Expected O, but got I
		//IL_0024: Expected O, but got I
		//IL_0036: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253630]");
		<NormalColor>k__BackingField = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253640]");
		<PassedColor>k__BackingField = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253650]");
		<CommentColor>k__BackingField = (Color)0;
		base..ctor();
	}
}
