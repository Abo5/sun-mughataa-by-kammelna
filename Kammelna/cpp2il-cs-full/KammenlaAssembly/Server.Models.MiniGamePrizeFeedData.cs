using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;

namespace Server.Models;

[Serializable]
public class MiniGamePrizeFeedData : UserFeedData
{
	private int <Coins>k__BackingField;

	public int Coins
	{
		get
		{
			return <Coins>k__BackingField;
		}
		set
		{
			<Coins>k__BackingField = value;
		}
	}

	public override bool HasPreview => false;

	public override bool ForcedPreview => false;

	public override LocalizableText GetTitle()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "Material with texture name \"" + 1616;
		return TextMeshProExtensions.Localize((string)text);
	}

	public override LocalizableText GetDetails()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01dc: Expected O, but got I4
		//IL_0037: Expected I8, but got I4
		//IL_0157: Expected O, but got I4
		//IL_007f: Expected O, but got I4
		//IL_0095: Expected I, but got O
		//IL_00a5: Expected O, but got I
		//IL_00ce: Expected O, but got I
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		object key = "AvailableVoices" + 3920;
		object obj2 = typeof(TypeConverter<ushort, char>) + 3400;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = LocalizationText.GetText((string)key, <Coins>k__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		object obj5;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj6;
		if (array != null)
		{
			bool flag2 = text == null;
			obj5 = 1;
			if (!flag2)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v8 (Il2CppClass<System.Object[]>)+40]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v8 (Il2CppClass<System.Object[]>)+40]");
				obj6 = 0;
				if (flag3)
				{
					goto IL_0172;
				}
			}
			if (array.Length != 0)
			{
				object text2 = "m_StencilDeferredPS" + 1800;
				object obj7 = array + 32;
				obj7 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return TextMeshProExtensions.LocalizeWith((string)text2, array);
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj5 = 1;
		}
		ex = new IndexOutOfRangeException();
		obj6 = obj5;
		goto IL_0172;
		IL_0172:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (LocalizableText)(object)new OutOfMemoryException();
	}

	public override void ShowPreview(Action markSeen)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(System.IOAsyncCallback) + 3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InvalidOperationException ex = default(InvalidOperationException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)2768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}
}
