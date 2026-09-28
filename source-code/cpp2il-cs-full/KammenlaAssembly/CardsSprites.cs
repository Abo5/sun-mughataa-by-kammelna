using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using UnityEngine;

public class CardsSprites : ScriptableObject
{
	private sealed class <>c__DisplayClass1_0
	{
		public string cardName;

		internal bool <GetFor>b__0(Sprite card)
		{
			//IL_0055: Expected I4, but got O
			if ((object)card != null)
			{
				string name = card.name;
				return name == cardName;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private Sprite[] playingCards;

	public Sprite GetFor(string cardName)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3320;
			object obj4 = (nint)0 + (nint)2760;
			object obj5 = obj2 + 16;
			obj5 = cardName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return (Sprite)Enumerable.FirstOrDefault(playingCards, func);
		}
		return (Sprite)(object)new NullReferenceException();
	}

	public Sprite GetFor(Card card)
	{
		if (card != null)
		{
			string cardName = card.ToString();
			return GetFor(cardName);
		}
		return null;
	}

	public Sprite[] GetAll()
	{
		return playingCards;
	}
}
