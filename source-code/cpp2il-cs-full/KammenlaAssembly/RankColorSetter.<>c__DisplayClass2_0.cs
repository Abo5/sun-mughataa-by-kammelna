using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Mono.Btls;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class RankColorSetter : IRankSubSetter
{
	private sealed class <>c__DisplayClass2_0
	{
		public RankColorSetter <>4__this;

		public PlayerRank playerRank;

		internal void <Set>b__0(Graphic g)
		{
			//IL_002b: Expected I, but got O
			//IL_003b: Expected O, but got I
			//IL_004b: Expected O, but got I
			while (true)
			{
				RankColorSetter rankColorSetter = <>4__this;
				Color color = rankColorSetter.colors.GetFor(playerRank);
				nint num = (nint)g;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v7 (Il2CppClass<UnityEngine.UI.Graphic>)+2A8]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v7 (Il2CppClass<UnityEngine.UI.Graphic>)+2B0]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v64 @ X2_v3 (should have been resolved before IL gen)");
			}
		}
	}

	private Graphic[] graphics;

	private RankColors colors;

	public string Label
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			object obj = "Picking audio files is not supported on iOS" + 3912;
			object obj2 = "&action=sign-up" + 2696;
			string graphicName = GraphicName;
			return (string)obj + graphicName + (string)obj2;
		}
	}

	public string GraphicName
	{
		get
		{
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00c6: Expected O, but got I4
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			Graphic[] array = graphics;
			if (graphics != null)
			{
				string result;
				if (array.Length != 0)
				{
					if (array.Length != 1)
					{
						object obj = 153100288 + 1024;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object format = "Material with texture name \"" + 2792;
						object arg = default(object);
						return string.Format((string)format, arg);
					}
					bool flag = (object)array[0] == null;
					result = (string)(object)array[0];
					if (!flag)
					{
						return array[0].name;
					}
				}
				else
				{
					object obj2 = "Network Authentication Required" + 2368;
					result = (string)obj2;
				}
				return result;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public void Set(PlayerRank playerRank)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0097: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 4024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2184;
		object obj4 = (nint)0 + (nint)3072;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = playerRank;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		ArraysExtensions.ForEach(graphics, action);
	}
}
