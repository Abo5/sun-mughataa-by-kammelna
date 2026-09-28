using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Mono.Btls;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class MonthlyTrophyDeepColorSetter : MonthlyTrophyUISubSetter<Color>
{
	private sealed class <>c__DisplayClass1_0
	{
		public Color color;

		internal void <Populate>b__0(Graphic g)
		{
			//IL_0010: Expected O, but got I
			//IL_0020: Expected O, but got I
			//IL_003a: Expected O, but got I
			//IL_0042: Expected I, but got O
			//IL_0052: Expected O, but got I
			//IL_0062: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonthlyTrophyDeepColorSetter+<>c__DisplayClass1_0)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonthlyTrophyDeepColorSetter+<>c__DisplayClass1_0)+1C]");
			object obj2 = 0;
			Color color = this.color;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonthlyTrophyDeepColorSetter+<>c__DisplayClass1_0)+14]");
			object obj3 = 0;
			nint num = (nint)g;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v1 (Il2CppClass<UnityEngine.UI.Graphic>)+2A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v1 (Il2CppClass<UnityEngine.UI.Graphic>)+2B0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v8 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private Graphic[] graphics;

	public override void Populate(UserAchievementModel trophy)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0075: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 192;
		object obj2 = (nint)0 + (nint)2912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		Color trophyAsset = GetTrophyAsset(trophy);
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2184;
		object obj5 = (nint)0 + (nint)2088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj3, (IntPtr)obj5);
		ArraysExtensions.ForEach(graphics, action);
	}
}
