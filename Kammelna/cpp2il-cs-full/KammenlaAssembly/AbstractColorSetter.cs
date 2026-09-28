using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public abstract class AbstractColorSetter
{
	private string Name;

	protected abstract string NameBase { get; }

	protected abstract GameObject Target { get; }

	protected AbstractColorSetter()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		object format = "utf-32" + 3720;
		string nameBase = NameBase;
		object target = Target;
		string text = string.Format((string)format, nameBase, target);
		object obj = this + 16;
		obj = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public abstract void SetColor(Color color);

	public void Rename()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object format = "utf-32" + 3720;
		string nameBase = NameBase;
		object target = Target;
		string text = string.Format((string)format, nameBase, target);
		object obj = this + 16;
		obj = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
