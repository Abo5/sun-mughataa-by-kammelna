using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public static class CanvasLayerExtensions
{
	public static Transform GetCanvas(CanvasLayer layer)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_0102: Expected O, but got I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_001f: Expected O, but got I4
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_01bf: Expected O, but got I4
		//IL_01d8: Expected O, but got I4
		//IL_00ab: Expected O, but got I4
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_02a6: Expected O, but got I
		GameObject gameObject;
		if (layer != CanvasLayer.SecondaryCanvas)
		{
			bool flag = layer == CanvasLayer.MainCanvas;
			object obj = !flag;
			if (obj != null)
			{
				object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 248;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj3 = 147423232 + 1832;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				object obj4 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D040");
				RuntimeTypeHandle handle = default(RuntimeTypeHandle);
				Type typeFromHandle = Type.GetTypeFromHandle(handle);
				object obj5 = "Unsupported map type" + 2048;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				object obj6 = "java.io.FileOutputStream" + 1336;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				string format = default(string);
				object arg = default(object);
				object arg2 = default(object);
				string message = string.Format(format, arg, arg2, typeFromHandle);
				object obj7 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
				string paramName = default(string);
				object actualValue = default(object);
				ex..ctor(paramName, actualValue, message);
				object obj8 = (nint)0 + (nint)3064;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				return (Transform)(object)new OutOfMemoryException();
			}
			object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v44+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			gameObject = KUtil.GetMainCanvas();
			bool flag3 = (object)gameObject == null;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				goto IL_00b9;
			}
		}
		else
		{
			object obj13 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object caller = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2632;
			gameObject = KUtil.GetSecondaryCanvas((string)caller);
			if ((object)gameObject == null)
			{
				goto IL_00b9;
			}
		}
		return gameObject.transform;
		IL_00b9:
		throw new NullReferenceException();
	}
}
