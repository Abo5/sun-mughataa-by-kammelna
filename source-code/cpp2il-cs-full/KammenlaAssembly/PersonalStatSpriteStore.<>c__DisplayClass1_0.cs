using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Mono.Btls;
using UnityEngine;

public class PersonalStatSpriteStore : ScriptableObject
{
	private sealed class <>c__DisplayClass1_0
	{
		public PerformanceReportType type;

		internal bool <GetConfig>b__0(ReportTypedSprite s)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (s != null)
			{
				object obj = s.ReportType - type;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private List<ReportTypedSprite> sprites;

	public ReportTypedSprite GetConfig(PerformanceReportType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0065: Expected I, but got O
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_012f: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3120;
			object obj4 = (nint)0 + (nint)400;
			object obj5 = (nint)0 + (nint)1152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			ReportTypedSprite reportTypedSprite = (ReportTypedSprite)Enumerable.FirstOrDefault(sprites, func);
			if (reportTypedSprite != null)
			{
				return reportTypedSprite;
			}
			string arg = base.name;
			object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = "{0} color encoding is currently unsupported for outputting to HDR." + 824;
			object arg2 = default(object);
			string text = string.Format((string)format, arg, arg2);
			object obj7 = typeof(DataRelation) + 856;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			object message = text;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message = text;
			}
			Debug.LogError(message);
			return reportTypedSprite;
		}
		return (ReportTypedSprite)(object)new NullReferenceException();
	}
}
