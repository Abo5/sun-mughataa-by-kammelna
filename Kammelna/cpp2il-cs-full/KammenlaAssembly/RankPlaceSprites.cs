using System;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public class RankPlaceSprites : ScriptableObject
{
	private Sprite rank1Sprite;

	private Sprite rank2Sprite;

	private Sprite rank3Sprite;

	public Sprite GetRankImageSprite(int place)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_009d: Expected O, but got I
		//IL_005b: Expected O, but got I
		object obj = place - 1;
		bool flag = (nint)obj < 3;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = obj << 3;
			object obj4 = (object)this + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X8_v3+18]");
			return (Sprite)0;
		}
		object obj5 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		ex..ctor();
		object obj6 = (nint)0 + (nint)1440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (Sprite)(object)new OutOfMemoryException();
	}
}
