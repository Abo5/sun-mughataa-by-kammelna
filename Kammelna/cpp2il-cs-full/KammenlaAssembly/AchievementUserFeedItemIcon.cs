using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Xml.Schema;
using Cpp2ILInjected;
using Server.Models;
using UnityEngine.UI;

public class AchievementUserFeedItemIcon : UserFeedItemIcon
{
	private sealed class <>c__DisplayClass1_0
	{
		public Action onReady;

		internal void <Populate>b__0(bool success)
		{
			Actions.SafeInvoke(onReady);
		}
	}

	private Image achievement;

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
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0146: Expected O, but got I
		//IL_0157: Expected I, but got O
		//IL_0183: Expected O, but got I
		object obj = typeof(XmlSchemaInclude) + 3792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = onReady;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UserFeedData <Data>k__BackingField = feedItem.<Data>k__BackingField;
		if (feedItem.<Data>k__BackingField != null)
		{
			object obj4 = typeof(SqlSingle[]) + 2368;
			object obj5 = obj4;
			nint num = (nint)<Data>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X10_v2 (Il2CppClass<Server.Models.UserFeedData>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X9_v4+130]");
			bool flag = num2 < 0;
			object obj6 = !flag;
			object obj7 = ~obj6;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X10_v2 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X9_v4+130]");
				object obj8 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X10_v4-8]");
				if (0 == (nint)obj5)
				{
					object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj10 = (nint)0 + (nint)2104;
					Action<bool> action = default(Action<bool>);
					action..ctor(obj2, (IntPtr)obj10);
					Image img = achievement;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v3 (Server.Models.UserFeedData)+18]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v3 (Server.Models.UserFeedData)+20]");
					UIExtensions.LoadAchievementImage(img, (string)num4, 0, action);
					return;
				}
			}
		}
		Actions.SafeInvoke((Action)obj3);
	}
}
