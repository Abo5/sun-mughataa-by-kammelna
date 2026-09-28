using System;
using Cpp2ILInjected;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine;

namespace Server.Models;

[Serializable]
public class RankUpFeedData : UserFeedData, IRankFeedData
{
	private PlayerRank.Ranks <NewRank>k__BackingField;

	private Games <Game>k__BackingField;

	public PlayerRank.Ranks NewRank
	{
		get
		{
			return <NewRank>k__BackingField;
		}
		set
		{
			<NewRank>k__BackingField = value;
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

	PlayerRank.Ranks IRankFeedData.Rank => <NewRank>k__BackingField;

	public override bool HasPreview => false;

	public override bool ForcedPreview => false;

	public override LocalizableText GetTitle()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		return TextMeshProExtensions.Localize(friendlyName);
	}

	public unsafe override LocalizableText GetDetails()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0171: Expected O, but got Ref
		//IL_019f: Expected O, but got I4
		//IL_0067: Expected I, but got O
		//IL_0077: Expected O, but got I
		//IL_00a0: Expected O, but got I
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj3 = default(object);
		string key = ((Enum)(&obj3)).ToString();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = LocalizationText.GetText(key);
		object[] array = default(object[]);
		GameObject gameObject;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		GameObject gameObject2;
		if (array != null)
		{
			bool flag2 = text == null;
			gameObject = null;
			if (!flag2)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9 (Il2CppClass<System.Object[]>)+40]");
				gameObject = (GameObject)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9 (Il2CppClass<System.Object[]>)+40]");
				gameObject2 = (GameObject)0;
				if (flag3)
				{
					goto IL_0140;
				}
			}
			if (array.Length != 0)
			{
				object text2 = "placementId" + 2232;
				object obj6 = array + 32;
				obj6 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return TextMeshProExtensions.LocalizeWith((string)text2, array);
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			gameObject = null;
		}
		ex = new IndexOutOfRangeException();
		gameObject2 = gameObject;
		goto IL_0140;
		IL_0140:
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
		object obj2 = (nint)0 + (nint)1456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}
}
