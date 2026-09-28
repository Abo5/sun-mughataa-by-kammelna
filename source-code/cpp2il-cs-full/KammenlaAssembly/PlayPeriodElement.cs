using System;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using TMPro;
using UnityEngine;
using Util;

public class PlayPeriodElement : MonoBehaviour
{
	private TextMeshProUGUI title;

	private TextMeshProUGUI field;

	public void Populate(int index, DateTime start, DateTime end)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0809: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0072: Expected I4, but got O
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00f2: Expected O, but got I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_02a2: Expected O, but got I4
		//IL_02ab: Expected O, but got I4
		//IL_01ea: Expected O, but got I4
		//IL_0226: Expected O, but got I8
		//IL_0240: Expected O, but got I4
		//IL_0249: Expected O, but got I4
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_035e: Expected O, but got I4
		//IL_0374: Expected O, but got I
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_02f6: Expected O, but got I8
		//IL_030e: Expected O, but got I4
		//IL_03b3: Expected O, but got I
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_0420: Expected O, but got I4
		//IL_0474: Expected O, but got I8
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		//IL_04d3: Expected O, but got I4
		//IL_04e9: Expected O, but got I
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected O, but got Unknown
		//IL_0528: Expected O, but got I
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected O, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected O, but got Unknown
		//IL_058b: Expected O, but got I4
		//IL_05a1: Expected O, but got I
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected O, but got Unknown
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected O, but got Unknown
		//IL_063a: Expected O, but got I4
		//IL_0650: Expected O, but got I
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected O, but got Unknown
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Expected O, but got Unknown
		//IL_06bd: Expected O, but got I8
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected O, but got Unknown
		//IL_073f: Expected O, but got I4
		//IL_0755: Expected O, but got I
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Expected O, but got Unknown
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(SqlSingle[]) + 32;
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		bool flag2 = title;
		bool flag3 = !flag2;
		int num = (int)start;
		if (!flag3)
		{
			object text = "Network Authentication Required" + 3296;
			TextMeshProExtensions.LocalizeOrdinal(title, (string)text, index);
			num = index;
		}
		object input = "fetch_products" + 1400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text2 = LocalizationUtil.Localize((string)input);
		string[] array = default(string[]);
		TimeSpan timeOfDay;
		DateTime dateTime = default(DateTime);
		string text3;
		object obj16;
		if (array.Length != 0)
		{
			object obj8 = typeof(DataRelation) + 712;
			object obj9 = typeof(DataRelation) + 824;
			object obj10 = array + 32;
			obj10 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v20+E4]");
			TimeSpan time;
			if ((nint)0 != 0)
			{
				timeOfDay = dateTime.TimeOfDay;
				object obj12 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v21+E4]");
				bool flag5 = (nint)0 == 0;
				object obj13 = 0;
				time = timeOfDay;
				if (!flag5)
				{
					goto IL_0200;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				timeOfDay = dateTime.TimeOfDay;
				object obj12 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v21+E4]");
				bool flag6 = (nint)0 == 0;
				object obj14 = !flag6;
				object obj13 = 0;
				time = timeOfDay;
				if (obj14 != null)
				{
					goto IL_0200;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			text3 = DateTimeUtil.AmPmTime(time, shortWords: true);
			object obj15 = array.Length & 0xFFFFFFFEL;
			bool flag7 = obj15 == null;
			obj16 = 0;
			if (!flag7)
			{
				goto IL_031c;
			}
		}
		goto IL_07ca;
		IL_031c:
		object obj17 = array + 40;
		obj17 = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X21_v11-10]");
		bool flag8 = (nint)0 < (nint)2;
		object obj18 = !flag8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X21_v11-10]");
		object obj19 = -2;
		bool flag9 = obj19 == null;
		object obj20 = ~obj18;
		object obj21 = obj20 | flag9;
		if (obj21 == null)
		{
			object obj22 = (nint)0 + (nint)3488;
			object obj23 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
			object obj24 = "utf-32" + 3016;
			object obj25 = array + 48;
			obj25 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj26 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v27+E4]");
			bool flag10 = (nint)0 == 0;
			object obj27 = !flag10;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text4 = dateTime.ToString((string)obj24, invariantCulture);
			object obj28 = array.Length & 0xFFFFFFFCL;
			if (obj28 != null)
			{
				object obj29 = array + 56;
				obj29 = text4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X21_v15-20]");
				bool flag11 = (nint)0 < (nint)4;
				object obj30 = !flag11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X21_v15-20]");
				object obj31 = -4;
				bool flag12 = obj31 == null;
				object obj32 = ~obj30;
				object obj33 = obj32 | flag12;
				if (obj33 == null)
				{
					object obj34 = (nint)0 + (nint)2400;
					object input2 = "startPosition" + 3176;
					object obj35 = array + 64;
					obj35 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					string text5 = LocalizationUtil.Localize((string)input2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X21_v17-28]");
					bool flag13 = (nint)0 < (nint)5;
					object obj36 = !flag13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X21_v17-28]");
					object obj37 = -5;
					bool flag14 = obj37 == null;
					object obj38 = ~obj36;
					object obj39 = obj38 | flag14;
					if (obj39 == null)
					{
						object obj40 = array + 72;
						obj40 = text5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						DateTime dateTime2 = default(DateTime);
						TimeSpan timeOfDay2 = dateTime2.TimeOfDay;
						string text6 = DateTimeUtil.AmPmTime(timeOfDay2, shortWords: true);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X21_v19-30]");
						bool flag15 = (nint)0 < (nint)6;
						object obj41 = !flag15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X21_v19-30]");
						object obj42 = -6;
						bool flag16 = obj42 == null;
						object obj43 = ~obj41;
						object obj44 = obj43 | flag16;
						if (obj44 == null)
						{
							object obj45 = array + 80;
							obj45 = text6;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X21_v21-38]");
							object obj46 = 0 & 0xFFFFFFF8L;
							if (obj46 != null)
							{
								object obj47 = array + 88;
								obj47 = obj22;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
								string text7 = dateTime2.ToString((string)obj24, invariantCulture2);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X21_v23-40]");
								bool flag17 = (nint)0 < (nint)8;
								object obj48 = !flag17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X21_v23-40]");
								object obj49 = -8;
								bool flag18 = obj49 == null;
								object obj50 = ~obj48;
								object obj51 = obj50 | flag18;
								if (obj51 == null)
								{
									object obj52 = array + 96;
									obj52 = text7;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									string text8 = string.Concat(array);
									TextMeshProExtensions.FixArabic(field, text8);
									return;
								}
							}
						}
					}
				}
			}
		}
		goto IL_07ca;
		IL_07ca:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_0200:
		text3 = DateTimeUtil.AmPmTime(timeOfDay, shortWords: true);
		object obj53 = array.Length & 0xFFFFFFFEL;
		bool flag19 = obj53 == null;
		object obj54 = !flag19;
		obj16 = 0;
		if (obj54 != null)
		{
			goto IL_031c;
		}
		goto IL_07ca;
	}

	public void Populate(int index, MassEventPlayWindowViewModel period)
	{
		Populate(index, period.<StartingTime>k__BackingField, period.<FinishTime>k__BackingField);
	}
}
