using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities.Data;
using Sfs2X.Entities.Variables;

namespace KammelnaOffline.OfflineServer;

internal class OfflineUserVariable : UserVariable, Variable
{
	private bool <IsPrivate>k__BackingField;

	private readonly VariableType <Type>k__BackingField;

	private readonly string <Name>k__BackingField;

	private readonly object <Value>k__BackingField;

	public bool IsPrivate
	{
		get
		{
			return <IsPrivate>k__BackingField;
		}
		set
		{
			<IsPrivate>k__BackingField = value;
		}
	}

	public VariableType Type => <Type>k__BackingField;

	public string Name => <Name>k__BackingField;

	public object Value => <Value>k__BackingField;

	public OfflineUserVariable(string name, VariableType variableType, object obj)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj2 = this + 24;
		obj2 = name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = this + 32;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public OfflineUserVariable(string name, int value)
	{
		//IL_000f: Expected O, but got I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		base..ctor();
		object obj2 = this + 24;
		obj2 = name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = this + 32;
		object obj4 = default(object);
		obj3 = obj4;
		_ = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public OfflineUserVariable(string name, string value)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj = this + 24;
		obj = name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 32;
		obj2 = value;
		_ = 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public OfflineUserVariable(string name, ISFSObject obj)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj2 = this + 24;
		obj2 = name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = this + 32;
		obj3 = obj;
		_ = 5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public OfflineUserVariable(string name, ISFSArray array)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj = this + 24;
		obj = name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 32;
		obj2 = array;
		_ = 6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public bool GetBoolValue()
	{
		//IL_00aa: Expected I4, but got O
		//IL_0038: Expected O, but got I4
		//IL_0048: Expected O, but got I
		//IL_0050: Expected I, but got O
		//IL_008e: Expected I4, but got O
		object obj = <Value>k__BackingField;
		if (<Value>k__BackingField != null)
		{
			object obj2 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X8_v3+28]");
			object obj3 = 0;
			nint num = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X8_v4 (Il2CppClass<System.Object>)+40]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X1_v2+40]");
			if (num2 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
				object obj4 = default(object);
				return (byte)(int)obj4 != 0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		InvalidCastException ex2 = new InvalidCastException();
		return (byte)(int)ex2 != 0;
	}

	public double GetDoubleValue()
	{
		//IL_0038: Expected O, but got I4
		//IL_0048: Expected O, but got I
		//IL_0050: Expected I, but got O
		//IL_008e: Expected F8, but got O
		object obj = <Value>k__BackingField;
		if (<Value>k__BackingField != null)
		{
			object obj2 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X8_v3+80]");
			object obj3 = 0;
			nint num = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X8_v4 (Il2CppClass<System.Object>)+40]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X1_v2+40]");
			if (num2 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
				object obj4 = default(object);
				return (double)obj4;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new InvalidCastException();
	}

	public int GetIntValue()
	{
		//IL_00aa: Expected I4, but got O
		//IL_0038: Expected O, but got I4
		//IL_0048: Expected O, but got I
		//IL_0050: Expected I, but got O
		//IL_008e: Expected I4, but got O
		object obj = <Value>k__BackingField;
		if (<Value>k__BackingField != null)
		{
			object obj2 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X8_v3+48]");
			object obj3 = 0;
			nint num = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X8_v4 (Il2CppClass<System.Object>)+40]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X1_v2+40]");
			if (num2 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
				object obj4 = default(object);
				return (int)obj4;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		InvalidCastException ex2 = new InvalidCastException();
		return (int)ex2;
	}

	public ISFSArray GetSFSArrayValue()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		if (<Value>k__BackingField != null)
		{
			object obj = typeof(System.IOAsyncCallback) + 960;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			ISFSArray iSFSArray = default(ISFSArray);
			if (iSFSArray != null)
			{
				return iSFSArray;
			}
			return (ISFSArray)new InvalidCastException();
		}
		return null;
	}

	public ISFSObject GetSFSObjectValue()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		if (<Value>k__BackingField != null)
		{
			object obj = typeof(System.IOAsyncCallback) + 976;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			ISFSObject iSFSObject = default(ISFSObject);
			if (iSFSObject != null)
			{
				return iSFSObject;
			}
			return (ISFSObject)new InvalidCastException();
		}
		return null;
	}

	public string GetStringValue()
	{
		//IL_0038: Expected O, but got I4
		string text = (string)<Value>k__BackingField;
		if (<Value>k__BackingField != null)
		{
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X8_v3+90]");
			if (text != null)
			{
				return (string)(object)new InvalidCastException();
			}
		}
		return (string)<Value>k__BackingField;
	}

	public bool IsNull()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		//IL_005f: Expected I4, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)2008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (byte)(int)ex2 != 0;
	}

	public ISFSArray ToSFSArray()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)2016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (ISFSArray)new OutOfMemoryException();
	}
}
