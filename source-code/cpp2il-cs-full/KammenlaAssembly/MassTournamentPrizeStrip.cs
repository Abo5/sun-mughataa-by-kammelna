using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Server.Models;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UI;

public class MassTournamentPrizeStrip : MonoBehaviour
{
	private TextMeshProUGUI descriptionField;

	private Image image;

	private TextMeshProUGUI placeLabel;

	public unsafe void Populate(MassEventPrizeViewModel prize, MassEventModel massTournament)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_014c: Expected O, but got I4
		//IL_0173: Expected O, but got I4
		//IL_017d: Expected I, but got O
		//IL_0185: Expected O, but got Ref
		//IL_01aa: Expected O, but got Ref
		//IL_0234: Expected O, but got I4
		//IL_023e: Expected I, but got O
		//IL_01c0: Expected I, but got O
		//IL_01d0: Expected O, but got I
		//IL_01f2: Expected O, but got I4
		//IL_01fc: Expected I, but got O
		//IL_020c: Expected O, but got I
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		bool flag = prize == null;
		MassEventModel massEventModel = massTournament;
		string text = (string)(object)prize;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			text = prize.<Description>k__BackingField;
			TextMeshProExtensions.FixArabic(descriptionField, prize.<Description>k__BackingField);
			bool flag2 = massTournament == null;
			massEventModel = null;
			if (!flag2)
			{
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				UIExtensions.LoadMassTournamentPrizeImage(image, prize, massTournament.<Id>k__BackingField);
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v11+E4]");
				if ((nint)0 != 0)
				{
					bool flag3 = placeLabel != null;
					bool flag4 = !flag3;
					object obj3 = !flag4;
					massEventModel = null;
					if (obj3 == null)
					{
						return;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag5 = placeLabel != null;
					bool flag6 = !flag5;
					massEventModel = null;
					if (flag6)
					{
						return;
					}
				}
				object obj4 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object obj5 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object[] array = default(object[]);
				bool flag7 = array == null;
				object obj6 = 0;
				Action<bool> action = null;
				nint num = unchecked((nint)null);
				int num2 = default(int);
				text = (string)(&num2);
				if (!flag7)
				{
					object obj7 = default(object);
					bool flag8 = obj7 == null;
					string text2 = (string)(&num2);
					if (!flag8)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
						text2 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag9 = ex == null;
						obj6 = 0;
						action = null;
						num = unchecked((nint)null);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						if (flag9)
						{
							goto IL_02b8;
						}
					}
					bool flag10 = array.Length == 0;
					obj6 = 0;
					action = null;
					num = unchecked((nint)null);
					text = text2;
					if (!flag10)
					{
						object obj8 = array + 32;
						obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object text3 = "{0} color encoding is currently unsupported for outputting to HDR." + 1352;
						TextMeshProExtensions.Localize(placeLabel, (string)text3, array);
						return;
					}
					goto IL_02aa;
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_02aa;
		IL_02aa:
		ex = new IndexOutOfRangeException();
		goto IL_02b8;
		IL_02b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	public void Populate(int place, MassEventModel massTournament)
	{
		int index = place - 1;
		object prize = ((List<object>)(object)massTournament.<Prizes>k__BackingField).get_Item(index);
		Populate((MassEventPrizeViewModel)prize, massTournament);
	}
}
