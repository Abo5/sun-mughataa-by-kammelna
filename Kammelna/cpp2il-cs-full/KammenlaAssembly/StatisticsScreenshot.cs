using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Spine;
using UnityEngine;

public class StatisticsScreenshot : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Sprite> <>9__2_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <ShareStatistics>b__2_0(Sprite _)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected O, but got Unknown
			//IL_00c9: Expected O, but got I
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected O, but got Unknown
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected O, but got Unknown
			//IL_0116: Expected O, but got I4
			//IL_0083: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
			object key = "setMimeType" + 2032;
			object obj2 = (nint)0 + (nint)2392;
			object fileName = "October" + 88;
			object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = LocalizationText.GetText((string)key);
			string message = text + (string)obj2;
			string filePath = ScreenshotCamera.GetFilePath((string)fileName);
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			KUtil.ShareImage(message, filePath);
		}
	}

	private const string FileName = "OfflineStatistics";

	private ScreenshotCamera screenshotCamera;

	public void ShareStatistics()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_00f4: Expected O, but got I
		//IL_0104: Expected O, but got I
		//IL_012e: Expected O, but got I4
		//IL_0074: Expected O, but got I
		//IL_0084: Expected O, but got I
		//IL_0166: Expected O, but got I4
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0215: Expected O, but got I
		//IL_0226: Expected I, but got O
		//IL_0244: Expected O, but got I
		//IL_01b7: Expected O, but got I4
		//IL_0196: Expected O, but got I
		Transform transform = base.transform;
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1224;
		object obj2 = "October" + 88;
		transform.SetParent(null, worldPositionStays: false);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v7+E4]");
		object obj4;
		Action<Sprite> spriteCallback;
		string fileName;
		string text;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v7+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v6+8]");
			spriteCallback = (Action<Sprite>)0;
			fileName = (string)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v6+8]");
			bool flag = (nint)0 == 0;
			text = (string)obj2;
			if (!flag)
			{
				goto IL_00b9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v7+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v6+8]");
			spriteCallback = (Action<Sprite>)0;
			fileName = (string)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v6+8]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			text = (string)obj2;
			if (obj5 != null)
			{
				goto IL_00b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v12+B8]");
			obj4 = 0;
		}
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)1160;
		Action<object> action = default(Action<object>);
		action..ctor(obj4, (IntPtr)obj9);
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v11+B8]");
		object obj11 = (nint)0 + (nint)8;
		obj11 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag4 = (object)screenshotCamera == null;
		object obj12 = !flag4;
		spriteCallback = action;
		fileName = text;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00b9;
		IL_00b9:
		screenshotCamera.Capture(fileName, spriteCallback);
	}
}
