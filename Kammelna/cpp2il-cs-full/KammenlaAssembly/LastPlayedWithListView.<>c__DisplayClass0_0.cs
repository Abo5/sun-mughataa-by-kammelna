using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using UnityEngine;

public class LastPlayedWithListView : UiListView<PlayerInfoWrapper, LastMatchStrip>
{
	private sealed class <>c__DisplayClass0_0
	{
		public string template;

		internal PlayerInfoWrapper <SetPlayers>b__0(PlayerInfo info)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 952;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 24;
			obj3 = info;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 16;
			obj4 = template;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (PlayerInfoWrapper)obj2;
		}
	}

	public void SetPlayers(IEnumerable<PlayerInfo> players)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0104: Expected O, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004c: Expected O, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_008e: Expected I, but got O
		//IL_00b6: Expected I, but got O
		//IL_00c6: Expected O, but got I
		//IL_00d6: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1576;
		object obj2 = default(object);
		Func<object, object> func = default(Func<object, object>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2..ctor();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LastPlayedWithListView)+38]");
			object obj3 = Enumerable.First((IEnumerable<object>)0);
			string text = ((UnityEngine.Object)obj3).name;
			object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2688;
			object obj5 = (nint)0 + (nint)3504;
			object obj6 = obj2 + 16;
			obj6 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			func..ctor(obj2, (IntPtr)obj5);
			IEnumerable<object> source = Enumerable.Select(players, func);
			List<object> list = Enumerable.ToList(source);
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v3 (Il2CppClass<LastPlayedWithListView>)+2A8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v3 (Il2CppClass<LastPlayedWithListView>)+2B0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v102 @ X3_v2 (should have been resolved before IL gen)");
		}
	}

	public LastPlayedWithListView()
	{
		((UiListView<object, object>)(object)this)..ctor();
	}
}
