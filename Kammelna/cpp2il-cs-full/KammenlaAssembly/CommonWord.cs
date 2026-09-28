using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

public class CommonWord
{
	private string <Word>k__BackingField;

	private ReplyCategory <Category>k__BackingField;

	private bool <IsForSubscribers>k__BackingField;

	private Games? <Game>k__BackingField;

	public string Word
	{
		get
		{
			return <Word>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public ReplyCategory Category
	{
		get
		{
			return <Category>k__BackingField;
		}
		set
		{
			<Category>k__BackingField = value;
		}
	}

	public bool IsForSubscribers
	{
		get
		{
			return <IsForSubscribers>k__BackingField;
		}
		set
		{
			<IsForSubscribers>k__BackingField = value;
		}
	}

	public Games? Game
	{
		get
		{
			return <Game>k__BackingField;
		}
		set
		{
			<Game>k__BackingField = value;
		}
	}

	public CommonWord()
	{
	}

	public CommonWord(string word, ReplyCategory category, bool isForSubscribers = true, Games? game = null)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = word;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override bool Equals(object obj)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_0086: Expected O, but got I
		//IL_00c7: Expected O, but got I
		if (obj != null)
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2072;
			object obj3 = obj2;
			nint num = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X9_v2 (Il2CppClass<System.Object>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v6+130]");
			bool flag = num2 < 0;
			object obj4 = !flag;
			object obj5 = ~obj4;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X9_v2 (Il2CppClass<System.Object>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v6+130]");
				object obj6 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X9_v4-8]");
				if (0 == (nint)obj3)
				{
					string text = <Word>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
					return text == (string)0;
				}
			}
		}
		return false;
	}

	public unsafe override int GetHashCode()
	{
		//IL_000a: Expected I4, but got O
		//IL_0047: Expected I4, but got O
		int num = (int)<Word>k__BackingField;
		if (<Word>k__BackingField != null)
		{
			int value = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v3 @ X8_v1 (System.Int32)+158] (should have been resolved before IL gen)");
		}
		return (int)<Word>k__BackingField;
	}
}
