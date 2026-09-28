using System;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;

public class CommunityBadgeScreenshot : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Sprite> <>9__3_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <ShareCommunityBadge>b__3_0(Sprite s)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0177: Expected O, but got I4
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected O, but got Unknown
			//IL_01dd: Expected O, but got I
			//IL_0214: Expected O, but got I4
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected O, but got Unknown
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected O, but got Unknown
			//IL_011a: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7367]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v8+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = "Cannot populate JSON object onto type '{0}'." + 3968;
			Platform platform = KUtil.GetPlatform();
			bool flag2 = platform == Platform.Web;
			object fileName = obj6;
			if (flag2)
			{
				goto IL_00bd;
			}
			goto IL_01d1;
			IL_00bd:
			Texture2D texture = s.texture;
			byte[] array = ImageConversion.EncodeToPNG(texture);
			object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			byte[] inArray = array;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				inArray = array;
			}
			string fileData = Convert.ToBase64String(inArray);
			WebInterface.Download((string)obj6, fileData);
			return;
			IL_01d1:
			object message = (nint)0 + (nint)2000;
			string filePath = ScreenshotCamera.GetFilePath((string)fileName);
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			KUtil.ShareImage((string)message, filePath);
			return;
			IL_007d:
			obj6 = "Cannot populate JSON object onto type '{0}'." + 3968;
			Platform platform2 = KUtil.GetPlatform();
			bool flag5 = platform2 != Platform.Web;
			fileName = obj6;
			if (!flag5)
			{
				goto IL_00bd;
			}
			goto IL_01d1;
		}
	}

	private const string FileName = "CommunityBadge";

	private AvatarInitializer communityBadge;

	private ScreenshotCamera screenshotCamera;

	public void ShareCommunityBadge(string dbId)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0108: Expected O, but got I
		//IL_0118: Expected O, but got I
		//IL_0142: Expected O, but got I4
		//IL_0088: Expected O, but got I
		//IL_0098: Expected O, but got I
		//IL_017a: Expected O, but got I4
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_0229: Expected O, but got I
		//IL_023a: Expected I, but got O
		//IL_0258: Expected O, but got I
		//IL_01cb: Expected O, but got I4
		//IL_01aa: Expected O, but got I
		Transform transform = base.transform;
		transform.SetParent(null, worldPositionStays: false);
		object obj = typeof(CardUtils.<>c) + 2040;
		object obj2 = "Cannot populate JSON object onto type '{0}'." + 3968;
		communityBadge.InitializeFriendWithDbId(dbId);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v8+E4]");
		object obj4;
		Action<Sprite> spriteCallback;
		string fileName;
		string text;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v8+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v6+8]");
			spriteCallback = (Action<Sprite>)0;
			fileName = (string)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v6+8]");
			bool flag = (nint)0 == 0;
			text = (string)obj2;
			if (!flag)
			{
				goto IL_00cd;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v8+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v6+8]");
			spriteCallback = (Action<Sprite>)0;
			fileName = (string)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v6+8]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			text = (string)obj2;
			if (obj5 != null)
			{
				goto IL_00cd;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v12+B8]");
			obj4 = 0;
		}
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)1272;
		Action<object> action = default(Action<object>);
		action..ctor(obj4, (IntPtr)obj9);
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v11+B8]");
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
		goto IL_00cd;
		IL_00cd:
		screenshotCamera.Capture(fileName, spriteCallback, isTransparentBackground: true);
	}
}
