using System;
using System.Data;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using ListView;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;

public class ChallengeHistoryListTitle : ListViewItem<IListViewItemData<int>, int>
{
	private TextMeshProUGUI title;

	public unsafe override void Setup(IListViewItemData<int> datum, bool firstTime)
	{
		//IL_000c: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0035: Expected I, but got O
		//IL_005e: Expected O, but got I4
		//IL_0092: Expected O, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I4
		//IL_0130: Expected O, but got I
		//IL_019b: Expected O, but got I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_01f1: Expected O, but got I
		//IL_0257: Expected O, but got I4
		//IL_028c: Expected O, but got Ref
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02d3: Expected O, but got I4
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0364: Expected O, but got I
		object obj = (nint)0 + (nint)1472;
		bool firstTime2 = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime2);
		if (datum == null)
		{
			return;
		}
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 536;
		object obj3 = obj2;
		nint num = (nint)datum;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X9_v2 (Il2CppClass<ListView.IListViewItemData`1<System.Int32>>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v6+130]");
		bool flag = num2 < 0;
		object obj4 = !flag;
		object obj5 = ~obj4;
		if (obj5 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X9_v2 (Il2CppClass<ListView.IListViewItemData`1<System.Int32>>)+C8]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v6+130]");
		object obj6 = num3 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X9_v4-8]");
		if (0 != (nint)obj3)
		{
			return;
		}
		object obj7 = typeof(DataRelation) + 712;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime today = DateTime.Today;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [datum @ X1 (ListView.IListViewItemData`1<System.Int32>)+10]");
		if ((DateTime)0 == today)
		{
			object text = "ThisIsFakeReceiptData" + 544;
			TextMeshProExtensions.Localize(title, (string)text);
			return;
		}
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime today2 = DateTime.Today;
		DateTime dateTime2 = default(DateTime);
		DateTime dateTime = dateTime2.AddDays(-1.0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [datum @ X1 (ListView.IListViewItemData`1<System.Int32>)+10]");
		if ((DateTime)0 == dateTime)
		{
			object text2 = "WhiteSmoke" + 1512;
			TextMeshProExtensions.Localize(title, (string)text2);
			return;
		}
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v17+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime3 = default(DateTime);
		DayOfWeek dayOfWeek = dateTime3.DayOfWeek;
		object obj14 = default(object);
		string input = ((Enum)(&obj14)).ToString();
		object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v15+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text3 = LocalizationUtil.Localize(input);
		object obj18 = "utf-32" + 3016;
		string text4 = dateTime3.ToString((string)obj18);
		object obj19 = (nint)0 + (nint)3072;
		string text5 = text3 + (string)obj19 + text4;
		TextMeshProExtensions.FixArabic(title, text5);
	}

	public ChallengeHistoryListTitle()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
