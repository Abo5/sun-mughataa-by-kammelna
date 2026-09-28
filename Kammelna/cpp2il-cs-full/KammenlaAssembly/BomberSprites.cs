using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public class BomberSprites
{
	public Sprite bomberRank;

	public Sprite bomberFrame;

	public BomberSprites(Sprite rank, Sprite frame)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj = this + 16;
		obj = rank;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 24;
		obj2 = frame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
