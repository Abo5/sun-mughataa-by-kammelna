using System;
using System.Buffers.Text;
using System.Diagnostics;
using Cpp2ILInjected;
using Server.Models;
using UnityEngine.UI;

public class ReceivedProfileGiftFeedItemIcon : UserFeedItemIcon
{
	private sealed class <>c__DisplayClass1_0
	{
		public Action onReady;

		internal void <Populate>b__0(bool onSuccess)
		{
			if (onSuccess)
			{
				Actions.SafeInvoke(onReady);
			}
		}
	}

	private Image icon;

	public override void Populate(UserFeedItem feedItem, Action onReady)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0091: Expected I, but got O
		//IL_00ba: Expected O, but got I4
		//IL_00ee: Expected O, but got I
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_013d: Expected O, but got I
		//IL_014e: Expected I, but got O
		//IL_016e: Expected I8, but got I
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = onReady;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UserFeedData <Data>k__BackingField = feedItem.<Data>k__BackingField;
		if (feedItem.<Data>k__BackingField == null)
		{
			return;
		}
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 3456;
		object obj5 = obj4;
		nint num = (nint)<Data>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X10_v2 (Il2CppClass<Server.Models.UserFeedData>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X9_v4+130]");
		bool flag = num2 < 0;
		object obj6 = !flag;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X10_v2 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X9_v4+130]");
			object obj8 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X10_v4-8]");
			if (0 == (nint)obj5)
			{
				object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj10 = (nint)0 + (nint)3328;
				Action<bool> action = default(Action<bool>);
				action..ctor(obj2, (IntPtr)obj10);
				Image img = icon;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3 (Server.Models.UserFeedData)+38]");
				UIExtensions.LoadProfileGiftImage(img, 0L, action);
			}
		}
	}
}
