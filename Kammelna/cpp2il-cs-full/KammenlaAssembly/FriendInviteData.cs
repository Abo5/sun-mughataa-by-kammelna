using System;
using System.ComponentModel;
using Cpp2ILInjected;

public class FriendInviteData : IInviteData
{
	private string <UserCode>k__BackingField;

	private string <Token>k__BackingField;

	public InviteType Type => InviteType.Friendship;

	public string UserCode
	{
		get
		{
			return <UserCode>k__BackingField;
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

	public string Token
	{
		get
		{
			return <Token>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public override string ToString()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0023: Expected O, but got I4
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 616;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format((string)format, arg, <UserCode>k__BackingField, <Token>k__BackingField);
	}

	public FriendInviteData(string userCode, string token)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj = this + 16;
		obj = userCode;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 24;
		obj2 = token;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public static FriendInviteData Parse(string data)
	{
		//IL_0055: Expected O, but got I4
		//IL_0065: Expected O, but got I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		string text = default(string);
		if (text != null)
		{
			string[] array = text.Split(',');
			if (array != null)
			{
				bool flag = array.Length < 1;
				object obj = !flag;
				object obj2 = array.Length - 1;
				bool flag2 = obj2 == null;
				object obj3 = ~obj;
				object obj4 = obj3 | flag2;
				if (obj4 == null && array.Length != 2)
				{
					object obj5 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1376;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj6 = default(object);
					obj6..ctor();
					object obj7 = obj6 + 16;
					obj7 = array[1];
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj8 = obj6 + 24;
					obj8 = array[2];
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return (FriendInviteData)obj6;
				}
				goto IL_014f;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_014f;
		IL_014f:
		return (FriendInviteData)(object)new IndexOutOfRangeException();
	}
}
