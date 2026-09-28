using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine;

namespace Server.Models;

[Serializable]
public class ForfeitGameFeedData : UserFeedData
{
	private int <LostPoints>k__BackingField;

	private Games <Game>k__BackingField;

	public int LostPoints
	{
		get
		{
			return <LostPoints>k__BackingField;
		}
		set
		{
			<LostPoints>k__BackingField = value;
		}
	}

	public Games Game
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

	public override bool HasPreview => false;

	public override bool ForcedPreview => false;

	public override LocalizableText GetTitle()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 824;
		return TextMeshProExtensions.Localize((string)text);
	}

	public unsafe override LocalizableText GetDetails()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_0386: Expected O, but got I4
		//IL_03a3: Expected O, but got I4
		//IL_0067: Expected O, but got Ref
		//IL_007d: Expected I, but got O
		//IL_008d: Expected O, but got I
		//IL_00b6: Expected O, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0122: Expected O, but got Ref
		//IL_01ef: Expected O, but got I4
		//IL_0200: Expected O, but got I4
		//IL_0180: Expected O, but got I4
		//IL_0189: Expected O, but got I4
		//IL_028e: Expected O, but got I8
		//IL_0223: Expected I, but got O
		//IL_0233: Expected O, but got I
		//IL_026c: Expected O, but got I
		//IL_01a8: Expected O, but got I4
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (<LostPoints>k__BackingField < 0)
		{
		}
		object obj5 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		GameObject gameObject;
		string text2;
		object obj13;
		string text3;
		object obj12;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		GameObject gameObject2;
		if (array != null)
		{
			object obj6 = default(object);
			bool flag2 = obj6 == null;
			int num = default(int);
			gameObject = (GameObject)(&num);
			if (!flag2)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
				gameObject = (GameObject)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
				gameObject2 = (GameObject)0;
				if (flag3)
				{
					goto IL_0313;
				}
			}
			if (array.Length != 0)
			{
				object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
				object obj8 = array + 32;
				obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj9 = default(object);
				string key = ((Enum)(&obj9)).ToString();
				object obj10 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v15+E4]");
				if ((nint)0 != 0)
				{
					string text = LocalizationText.GetText(key);
					bool flag4 = text == null;
					object obj11 = !flag4;
					obj12 = 0;
					text2 = text;
					if (obj11 != null)
					{
						goto IL_021b;
					}
					obj13 = 0;
					gameObject = null;
					text3 = text;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					string text4 = LocalizationText.GetText(key);
					bool flag5 = text4 == null;
					obj12 = 0;
					text2 = text4;
					obj13 = 0;
					gameObject = null;
					text3 = text4;
					if (!flag5)
					{
						goto IL_021b;
					}
				}
				goto IL_027a;
			}
			goto IL_02fd;
		}
		goto IL_032b;
		IL_027a:
		object obj14 = array.Length & 0xFFFFFFFEL;
		bool flag6 = obj14 == null;
		obj12 = obj13;
		if (!flag6)
		{
			object text5 = "fetch_products" + 1064;
			object obj15 = array + 40;
			obj15 = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return TextMeshProExtensions.LocalizeWith((string)text5, array);
		}
		goto IL_02fd;
		IL_021b:
		nint num3 = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
		gameObject = (GameObject)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		bool flag7 = ex == null;
		obj13 = obj12;
		text3 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
		gameObject2 = (GameObject)0;
		if (!flag7)
		{
			goto IL_027a;
		}
		goto IL_0313;
		IL_0313:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_032b;
		IL_02fd:
		ex = new IndexOutOfRangeException();
		gameObject2 = gameObject;
		goto IL_0313;
		IL_032b:
		return (LocalizableText)(object)new NullReferenceException();
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
		object obj2 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}
}
