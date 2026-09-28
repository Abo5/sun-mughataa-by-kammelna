using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using Util.Extensions;

public class ShareScreenShot : MonoBehaviour
{
	private Camera screenShotCam;

	private string FileName;

	private List<GameObject> hideOnCapture;

	private ScreenshotCamera _SsCamScript;

	private CameraClearFlags _originalCameraClearFlags;

	private Color _originalCameraBackgroundColor;

	public void ShareSs()
	{
		CaptureRoutine();
	}

	private void CaptureRoutine()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0134: Expected O, but got I4
		//IL_00c4: Expected O, but got I4
		//IL_00cd: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_01ae: Expected O, but got I
		//IL_00e4: Expected O, but got I4
		//IL_0183: Expected O, but got I4
		//IL_0194: Expected O, but got I4
		//IL_01fd: Expected O, but got I
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_0253: Expected O, but got I4
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_0290: Expected O, but got I
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_0321: Expected I, but got O
		//IL_0350: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F32]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj7;
		object obj4;
		object obj8;
		if (obj3 != null)
		{
			obj4 = this + 32;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v32+E4]");
			bool flag = (nint)0 == 0;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (!flag)
			{
				goto IL_00a0;
			}
		}
		else
		{
			_ = 1;
			obj4 = this + 32;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v32+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (obj9 != null)
			{
				goto IL_00a0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj7 == null;
		bool flag4 = !flag3;
		object obj10 = 0;
		obj4 = obj8;
		object obj11 = 0;
		if (!flag4)
		{
			goto IL_01a2;
		}
		goto IL_01f1;
		IL_01f1:
		object obj12 = (nint)0 + (nint)4080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj13 = this + 56;
		object obj14 = default(object);
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj17 = typeof(SqlSingle[]) + 2376;
		object obj18 = (nint)0 + (nint)3808;
		object obj19 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		if ((UnityEngine.Object)obj13 == null)
		{
			ScreenshotCamera ssCamScript = CreateScreenshotCameraInstance();
			_SsCamScript = ssCamScript;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		ComponentListsExtensions.SetActive(hideOnCapture, active: false);
		PrepareCameraForCapture();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj18);
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v17+E4]");
		bool flag6 = (nint)0 == 0;
		object obj21 = !flag6;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy.WaitForEndOfFrame(action);
		return;
		IL_01a2:
		object obj22 = (nint)0 + (nint)408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
		Canvas canvas = default(Canvas);
		Camera worldCamera = canvas.worldCamera;
		obj4 = worldCamera;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = obj10;
		obj8 = obj4;
		goto IL_01f1;
		IL_00a0:
		bool flag7 = obj5 == null;
		bool flag8 = !flag7;
		object obj23 = !flag8;
		obj10 = 0;
		if (obj23 != null)
		{
			goto IL_01a2;
		}
		obj11 = 0;
		obj8 = obj4;
		goto IL_01f1;
	}

	private void DoCapture()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0058: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj2 = (nint)0 + (nint)3800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		_SsCamScript.Capture(FileName, action);
	}

	private void RestoreCameraDefaults()
	{
		//IL_0026: Expected O, but got I4
		screenShotCam.clearFlags = _originalCameraClearFlags;
		screenShotCam.backgroundColor = (Color)0;
	}

	private void PrepareCameraForCapture()
	{
		//IL_0070: Expected O, but got I4
		CameraClearFlags clearFlags = screenShotCam.clearFlags;
		_originalCameraClearFlags = clearFlags;
		Color backgroundColor = screenShotCam.backgroundColor;
		Color originalCameraBackgroundColor = default(Color);
		_originalCameraBackgroundColor = originalCameraBackgroundColor;
		screenShotCam.clearFlags = CameraClearFlags.Color;
		screenShotCam.backgroundColor = (Color)0;
	}

	private ScreenshotCamera CreateScreenshotCameraInstance()
	{
		//IL_003d: Expected O, but got I
		if ((object)screenShotCam != null)
		{
			GameObject gameObject = screenShotCam.gameObject;
			if ((object)gameObject != null)
			{
				object obj = (nint)0 + (nint)872;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
				int height = Screen.height;
				ScreenshotCamera screenshotCamera = default(ScreenshotCamera);
				if ((object)screenshotCamera != null)
				{
					screenshotCamera.canvasHeight = height;
					int width = Screen.width;
					screenshotCamera.canvasWidth = width;
					int height2 = Screen.height;
					screenshotCamera.targetCaptureHeight = height2;
					int width2 = Screen.width;
					screenshotCamera.targetCaptureWidth = width2;
					return screenshotCamera;
				}
			}
		}
		return (ScreenshotCamera)(object)new NullReferenceException();
	}

	public ShareScreenShot()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		object obj = "SERVICE_DISABLED" + 2000;
		object obj2 = this + 40;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <DoCapture>b__8_0(Sprite s)
	{
		//IL_002b: Expected O, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I4
		//IL_00c9: Expected O, but got I
		//IL_01cd: Expected O, but got I
		//IL_01e7: Expected O, but got I4
		//IL_0123: Expected O, but got I
		//IL_022d: Expected O, but got I4
		//IL_027d: Expected O, but got I4
		screenShotCam.clearFlags = _originalCameraClearFlags;
		screenShotCam.backgroundColor = (Color)0;
		ComponentListsExtensions.SetActive(hideOnCapture, active: true);
		GameObject gameObject = screenShotCam.gameObject;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		gameObject.SetActive(value: true);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = (nint)0 + (nint)2000;
		string filePath = ScreenshotCamera.GetFilePath(FileName);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v13+E4]");
		string text;
		string text2;
		if ((nint)0 != 0)
		{
			text = (string)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FD2]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			text2 = (string)obj4;
			if (!flag2)
			{
				goto IL_0148;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			text = (string)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FD2]");
			object obj7 = (nint)0 & (nint)1;
			bool flag3 = obj7 == null;
			object obj8 = !flag3;
			text2 = (string)obj4;
			if (obj8 != null)
			{
				goto IL_0148;
			}
		}
		_ = 1;
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v24+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		text = text2;
		object obj11 = obj9;
		if (obj10 != null)
		{
			goto IL_0185;
		}
		goto IL_024b;
		IL_0148:
		obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v24+E4]");
		bool flag5 = (nint)0 == 0;
		obj11 = obj9;
		text2 = text;
		if (!flag5)
		{
			goto IL_0185;
		}
		goto IL_024b;
		IL_024b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Diffusion diffusion = KUtil.Diffusion;
		bool flag6 = (object)diffusion == null;
		object obj12 = !flag6;
		text = text2;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0193;
		IL_0185:
		diffusion = KUtil.Diffusion;
		goto IL_0193;
		IL_0193:
		diffusion.Share(text, filePath);
	}
}
