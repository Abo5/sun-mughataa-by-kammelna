using System;
using System.Buffers.Text;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.Purchasing.Telemetry;

public class ScreenshotCamera : MonoBehaviour
{
	public enum Format
	{
		RAW,
		JPG,
		PNG,
		PPM
	}

	private sealed class <>c__DisplayClass18_0
	{
		public ScreenshotCamera <>4__this;

		public string fileName;

		public Action<Sprite> spriteCallback;

		internal void <Capture>b__0()
		{
			<>4__this.DoCapture(fileName, spriteCallback);
		}
	}

	private sealed class <>c__DisplayClass19_0
	{
		public string filePath;

		public byte[] fileHeader;

		public byte[] fileData;

		public Action<Sprite> spriteCallback;

		public ScreenshotCamera <>4__this;

		public Action <>9__1;

		internal void <DoCapture>b__0()
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_004a: Expected I, but got O
			//IL_006a: Expected I, but got O
			//IL_007a: Expected O, but got I
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Expected O, but got Unknown
			//IL_0125: Expected O, but got I
			//IL_012d: Expected I, but got O
			//IL_013b: Expected I, but got O
			//IL_017e: Expected O, but got I4
			FileStream fileStream = File.Create(filePath);
			byte[] array = fileHeader;
			if (fileHeader != null)
			{
				fileStream.Write(fileHeader, 0, array.Length);
			}
			byte[] array2 = fileData;
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			int num = array2.Length;
			nint num2 = (nint)fileStream;
			fileStream.Write(array2, 0, array2.Length);
			nint num3 = (nint)fileStream;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v5 (Il2CppClass<System.IO.FileStream>)+280]");
			Action action = (Action)0;
			fileStream.Close();
			object obj2 = this + 56;
			Action action2 = (Action)obj2;
			Action callback;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				nint num4 = 0;
				callback = action2;
				if (!flag)
				{
					goto IL_00f1;
				}
			}
			else
			{
				object obj4 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj5 = (nint)0 + (nint)1632;
				nint num4 = (nint)obj5;
				Action action3 = default(Action);
				action3..ctor(this, (IntPtr)obj5);
				<>9__1 = action3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				action2 = action3;
				num = 0;
				action = action3;
				callback = action3;
				if (obj6 != null)
				{
					goto IL_00f1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CoroutineDummy.WaitForMainThread(callback);
			return;
			IL_00f1:
			CoroutineDummy.WaitForMainThread(action2);
		}

		internal void <DoCapture>b__1()
		{
			//IL_0045: Expected O, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			//IL_0080: Expected O, but got I4
			if (spriteCallback != null)
			{
				ScreenshotCamera screenshotCamera = <>4__this;
				Vector2 pivot = default(Vector2);
				Sprite sprite = Sprite.Create(screenshotCamera.screenShot, (Rect)0, pivot);
				Action<Sprite> action = spriteCallback;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v59 @ X8_v4 (System.Action`1<UnityEngine.Sprite>)+18] (should have been resolved before IL gen)");
				object obj = <>4__this + 88;
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
		}
	}

	public int canvasWidth;

	public int canvasHeight;

	public int targetCaptureWidth;

	public int targetCaptureHeight;

	public Format format;

	private Camera _renderCamera;

	private Rect rect;

	private RenderTexture renderTexture;

	private Texture2D screenShot;

	public RenderTexture previewTexture
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected O, but got Unknown
			//IL_0122: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0198: Expected O, but got I
			//IL_0176: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FD4]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			UnityEngine.Object obj5;
			UnityEngine.Object obj7;
			object obj8;
			if (obj3 != null)
			{
				obj4 = this + 56;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v11+E4]");
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
				obj4 = this + 56;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v11+E4]");
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
			bool flag3 = obj7;
			bool flag4 = !flag3;
			object obj10 = !flag4;
			obj4 = obj8;
			if (obj10 != null)
			{
				goto IL_00d2;
			}
			goto IL_018c;
			IL_01db:
			Camera camera = default(Camera);
			if ((object)camera != null)
			{
				return camera.targetTexture;
			}
			return (RenderTexture)(object)new NullReferenceException();
			IL_00d2:
			camera = (Camera)obj4;
			goto IL_01db;
			IL_018c:
			object obj11 = (nint)0 + (nint)3648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			_renderCamera = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			goto IL_01db;
			IL_00a0:
			bool flag5 = obj5;
			bool flag6 = !flag5;
			obj8 = obj4;
			if (!flag6)
			{
				goto IL_00d2;
			}
			goto IL_018c;
		}
	}

	private Camera renderCamera
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_011a: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0190: Expected O, but got I
			//IL_016e: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FD4]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			UnityEngine.Object obj5;
			UnityEngine.Object obj7;
			object obj8;
			if (obj3 != null)
			{
				obj4 = this + 56;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v7+E4]");
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
				obj4 = this + 56;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v7+E4]");
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
			bool flag3 = obj7;
			bool flag4 = !flag3;
			object obj10 = !flag4;
			obj4 = obj8;
			if (obj10 != null)
			{
				goto IL_00d2;
			}
			goto IL_0184;
			IL_00d2:
			return (Camera)obj4;
			IL_0184:
			object obj11 = (nint)0 + (nint)3648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			Camera result = default(Camera);
			_renderCamera = result;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return result;
			IL_00a0:
			bool flag5 = obj5;
			bool flag6 = !flag5;
			obj8 = obj4;
			if (!flag6)
			{
				goto IL_00d2;
			}
			goto IL_0184;
		}
	}

	private static string PicturesPath
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object obj = ", stale={0}" + 3016;
			string persistentDataPath = UnityEngine.Device.Application.persistentDataPath;
			return persistentDataPath + (string)obj;
		}
	}

	public static string GetFilePath(string fileName)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		object obj = ", stale={0}" + 3016;
		object obj2 = ", stale={0}" + 2472;
		string persistentDataPath = UnityEngine.Device.Application.persistentDataPath;
		string path = persistentDataPath + (string)obj;
		DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
		string persistentDataPath2 = UnityEngine.Device.Application.persistentDataPath;
		string text = persistentDataPath2 + (string)obj;
		return text + fileName + (string)obj2;
	}

	public void TestCaptureScreenshot()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_011e: Expected O, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0079: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = "utf-32" + 3088;
		object obj6 = "HH:mm:ss.ffZ" + 2600;
		DateTime now = DateTime.Now;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		DateTime dateTime = default(DateTime);
		string text = dateTime.ToString((string)obj5, invariantCulture);
		string fileName = (string)obj6 + text;
		Capture(fileName);
	}

	public void Capture(string fileName, Action<Sprite> spriteCallback = null, bool isTransparentBackground = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I4
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_010c: Expected O, but got I
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_020f: Expected O, but got I4
		//IL_0185: Expected O, but got I
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0243: Expected O, but got I
		//IL_026f: Expected O, but got I4
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_02f3: Expected O, but got I4
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_0366: Expected O, but got I
		//IL_042f: Expected O, but got I4
		//IL_047b: Expected O, but got I4
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected O, but got Unknown
		//IL_04de: Expected O, but got I
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected O, but got Unknown
		//IL_0520: Expected I, but got O
		//IL_054a: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(RegisteredWaitHandle) + 432;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = fileName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 32;
		obj6 = spriteCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag = !isTransparentBackground;
		object obj7 = !flag;
		object obj8 = ~obj7;
		TextureFormat textureFormat = ((obj8 != null) ? TextureFormat.RGB24 : TextureFormat.RGBA32);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RenderTexture renderTexture = default(RenderTexture);
		renderTexture..ctor(canvasWidth, canvasHeight, 24);
		object obj9 = this + 80;
		obj9 = renderTexture;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FD4]");
		object obj11 = (nint)0 & (nint)1;
		object obj12;
		UnityEngine.Object obj13;
		UnityEngine.Object obj15;
		object obj16;
		if (obj11 != null)
		{
			obj12 = this + 56;
			obj13 = (UnityEngine.Object)obj12;
			object obj14 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v63+E4]");
			bool flag2 = (nint)0 == 0;
			obj15 = (UnityEngine.Object)obj12;
			obj16 = obj12;
			if (!flag2)
			{
				goto IL_0179;
			}
		}
		else
		{
			_ = 1;
			obj12 = this + 56;
			obj13 = (UnityEngine.Object)obj12;
			object obj14 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v63+E4]");
			bool flag3 = (nint)0 == 0;
			object obj17 = !flag3;
			obj15 = (UnityEngine.Object)obj12;
			obj16 = obj12;
			if (obj17 != null)
			{
				goto IL_0179;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj18 = (nint)0 + (nint)3648;
		bool flag4 = obj15;
		bool flag5 = !flag4;
		object obj19 = !flag5;
		obj12 = obj16;
		object obj20 = obj18;
		if (obj19 != null)
		{
			goto IL_01bf;
		}
		goto IL_028d;
		IL_04ac:
		Component component = default(Component);
		GameObject gameObject = component.gameObject;
		object obj21 = typeof(SqlSingle[]) + 2376;
		object obj22 = (nint)0 + (nint)1616;
		object obj23 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		gameObject.SetActive(value: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj22);
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v30+E4]");
		bool flag6 = (nint)0 == 0;
		object obj25 = !flag6;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy.WaitForEndOfFrame(action);
		return;
		IL_02c5:
		object obj26 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 656;
		Camera camera = default(Camera);
		camera.targetTexture = this.renderTexture;
		rect = (Rect)0;
		_ = canvasWidth;
		_ = canvasHeight;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Texture2D texture2D = default(Texture2D);
		texture2D..ctor(canvasWidth, canvasHeight, textureFormat, mipChain: false);
		object obj27 = this + 88;
		obj27 = texture2D;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FD4]");
		object obj28 = (nint)0 & (nint)1;
		UnityEngine.Object obj29;
		UnityEngine.Object obj31;
		if (obj28 != null)
		{
			obj29 = (UnityEngine.Object)obj12;
			object obj30 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v40+E4]");
			bool flag7 = (nint)0 == 0;
			obj31 = (UnityEngine.Object)obj12;
			if (!flag7)
			{
				goto IL_03c0;
			}
		}
		else
		{
			_ = 1;
			obj29 = (UnityEngine.Object)obj12;
			object obj30 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v40+E4]");
			bool flag8 = (nint)0 == 0;
			object obj32 = !flag8;
			obj31 = (UnityEngine.Object)obj12;
			if (obj32 != null)
			{
				goto IL_03c0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag9 = obj31;
		bool flag10 = !flag9;
		object obj33 = !flag10;
		if (obj33 != null)
		{
			goto IL_03ea;
		}
		goto IL_0489;
		IL_01bf:
		camera = (Camera)obj12;
		goto IL_02c5;
		IL_03c0:
		if ((bool)obj29)
		{
			goto IL_03ea;
		}
		goto IL_0489;
		IL_0489:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		_renderCamera = (Camera)component;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_04ac;
		IL_03ea:
		component = (Component)obj12;
		goto IL_04ac;
		IL_0179:
		obj18 = (nint)0 + (nint)3648;
		bool flag11 = obj13;
		bool flag12 = !flag11;
		obj20 = obj18;
		obj16 = obj12;
		if (!flag12)
		{
			goto IL_01bf;
		}
		goto IL_028d;
		IL_028d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		_renderCamera = camera;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj18 = obj20;
		obj12 = obj16;
		goto IL_02c5;
	}

	private void DoCapture(string filename, Action<Sprite> spriteCallback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00b7: Expected O, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_01bf: Expected O, but got I4
		//IL_0130: Expected O, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I
		//IL_021f: Expected O, but got I4
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_02f8: Expected O, but got I4
		//IL_02f8: Expected O, but got I
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_033b: Expected O, but got I4
		//IL_05e3: Expected I, but got O
		//IL_037f: Expected I, but got O
		//IL_0389: Expected O, but got I4
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected O, but got Unknown
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected O, but got Unknown
		//IL_0628: Expected O, but got I
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected O, but got Unknown
		//IL_042b: Expected I, but got O
		//IL_0435: Expected O, but got I4
		//IL_065c: Expected I, but got O
		//IL_0bb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb5: Expected O, but got Unknown
		//IL_03b5: Expected I, but got O
		//IL_03bf: Expected O, but got I4
		//IL_0719: Expected O, but got I
		//IL_0733: Expected O, but got I4
		//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdd: Expected O, but got Unknown
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_0486: Expected O, but got I4
		//IL_05c2: Expected I4, but got O
		//IL_06e6: Expected O, but got I4
		//IL_069f: Expected O, but got I
		//IL_0c05: Expected O, but got I
		//IL_04b2: Expected O, but got I4
		//IL_04cc: Expected O, but got I
		//IL_03e6: Expected I, but got O
		//IL_07d5: Expected O, but got I
		//IL_0771: Expected O, but got I4
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected O, but got Unknown
		//IL_08f9: Expected O, but got I4
		//IL_0521: Expected I, but got O
		//IL_0547: Expected I, but got O
		//IL_0557: Expected O, but got I
		//IL_057f: Expected I, but got O
		//IL_0945: Expected O, but got I4
		//IL_0899: Expected O, but got I
		//IL_08b3: Expected O, but got I4
		//IL_0c81: Expected I, but got O
		//IL_09a9: Expected I, but got O
		//IL_09e8: Expected O, but got I
		//IL_0ab6: Expected O, but got I4
		//IL_0b02: Expected O, but got I4
		//IL_0cab: Expected I, but got O
		//IL_0b79: Expected O, but got I4
		//IL_0cd0: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		object obj3 = null;
		object obj4;
		object obj9;
		UnityEngine.Object obj10;
		object obj12;
		object obj17;
		object obj15;
		Action<Sprite> action = default(Action<Sprite>);
		if (!flag)
		{
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj5 = obj2 + 40;
			obj5 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj2 + 48;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			string filePath = GetFilePath(filename);
			object obj7 = obj2 + 16;
			obj7 = filePath;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FD4]");
			object obj8 = (nint)0 & (nint)1;
			UnityEngine.Object obj13;
			if (obj8 != null)
			{
				obj9 = this + 56;
				obj10 = (UnityEngine.Object)obj9;
				object obj11 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v145+E4]");
				bool flag2 = (nint)0 == 0;
				obj12 = obj9;
				obj13 = (UnityEngine.Object)obj9;
				if (!flag2)
				{
					goto IL_0124;
				}
			}
			else
			{
				_ = 1;
				obj9 = this + 56;
				obj10 = (UnityEngine.Object)obj9;
				object obj11 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v145+E4]");
				bool flag3 = (nint)0 == 0;
				object obj14 = !flag3;
				obj12 = obj9;
				obj13 = (UnityEngine.Object)obj9;
				if (obj14 != null)
				{
					goto IL_0124;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = (nint)0 + (nint)3648;
			bool flag4 = obj13;
			bool flag5 = !flag4;
			object obj16 = !flag5;
			obj3 = null;
			obj9 = obj12;
			obj17 = obj15;
			if (obj16 != null)
			{
				goto IL_016f;
			}
			goto IL_0242;
		}
		goto IL_0b96;
		IL_06bc:
		object obj19;
		object obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v105+E4]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			goto IL_077f;
		}
		goto IL_07b6;
		IL_0c97:
		Camera camera = default(Camera);
		bool flag7 = (object)camera == null;
		nint num = unchecked((nint)null);
		action = null;
		object obj23;
		if (!flag7)
		{
			camera.targetTexture = null;
			object obj21 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v15+E4]");
			bool flag8 = (nint)0 == 0;
			object obj22 = !flag8;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy((UnityEngine.Object)obj23);
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
		}
		goto IL_0b96;
		IL_05e8:
		object obj24 = obj2 + 32;
		byte[] array;
		obj24 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj25 = typeof(SqlSingle[]) + 2376;
		object obj26 = (nint)0 + (nint)1624;
		obj19 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(obj2, (IntPtr)obj26);
		object obj27 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X0_v44+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FCF]");
			object obj28 = (nint)0 & (nint)1;
			if (obj28 != null)
			{
				goto IL_06bc;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FCF]");
			object obj29 = (nint)0 & (nint)1;
			bool flag9 = obj29 == null;
			object obj30 = !flag9;
			if (obj30 != null)
			{
				goto IL_06bc;
			}
		}
		_ = 1;
		obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v105+E4]");
		bool flag10 = (nint)0 == 0;
		object obj31 = !flag10;
		if (obj31 == null)
		{
			goto IL_077f;
		}
		goto IL_07b6;
		IL_08c1:
		_ = 1;
		UnityEngine.Object obj32 = (UnityEngine.Object)obj9;
		object obj33 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X8_v24+E4]");
		bool flag11 = (nint)0 == 0;
		object obj34 = !flag11;
		UnityEngine.Object obj35 = (UnityEngine.Object)obj9;
		if (obj34 != null)
		{
			goto IL_082f;
		}
		goto IL_090f;
		IL_0124:
		obj15 = (nint)0 + (nint)3648;
		bool flag12 = obj10;
		bool flag13 = !flag12;
		obj3 = null;
		obj17 = obj15;
		obj12 = obj9;
		if (!flag13)
		{
			goto IL_016f;
		}
		goto IL_0242;
		IL_0242:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Camera camera2 = default(Camera);
		_renderCamera = camera2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj15 = obj17;
		obj3 = camera2;
		obj9 = obj12;
		goto IL_0c50;
		IL_016f:
		camera2 = (Camera)obj9;
		goto IL_0c50;
		IL_0c50:
		if ((object)camera2 != null)
		{
			camera2.Render();
			obj23 = (RenderTexture.active = (RenderTexture)(this + 80));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X21_v6+8]");
			bool flag14 = (nint)0 == 0;
			obj3 = null;
			if (!flag14)
			{
				Rect rect = this.rect;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X21_v6+8]");
				((Texture2D)0).ReadPixels((Rect)0, 0, 0);
				int num2 = targetCaptureHeight;
				TextureScale.Bilinear(screenShot, targetCaptureWidth, targetCaptureHeight);
				RenderTexture.active = null;
				object obj36 = obj2 + 24;
				obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (format <= Format.JPG)
				{
					bool flag15 = format == Format.RAW;
					num = unchecked((nint)null);
					action = (Action<Sprite>)targetCaptureHeight;
					obj3 = null;
					if (flag15)
					{
						goto IL_058c;
					}
					bool flag16 = format != Format.JPG;
					num = unchecked((nint)null);
					action = (Action<Sprite>)targetCaptureHeight;
					obj3 = null;
					if (!flag16)
					{
						byte[] array2 = ImageConversion.EncodeToJPG(screenShot);
						num = unchecked((nint)null);
						array = array2;
						goto IL_05e8;
					}
				}
				else
				{
					if (format == Format.PNG)
					{
						array = ImageConversion.EncodeToPNG(screenShot);
						num = unchecked((nint)null);
						goto IL_05e8;
					}
					bool flag17 = format != Format.PPM;
					num = unchecked((nint)null);
					action = (Action<Sprite>)targetCaptureHeight;
					obj3 = null;
					if (!flag17)
					{
						object obj37 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
						object obj38 = obj37;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X0_v123+E4]");
						bool flag18 = (nint)0 == 0;
						object obj39 = !flag18;
						if (obj39 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj40 = 153100288 + 1024;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ScreenshotCamera)+4C]");
						rect = (Rect)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object obj41 = "October" + 1696;
						object obj42 = default(object);
						object obj43 = default(object);
						string s = string.Format((string)obj41, obj42, obj43);
						Encoding aSCII = Encoding.ASCII;
						bool flag19 = aSCII == null;
						num = unchecked((nint)null);
						action = (Action<Sprite>)obj43;
						obj3 = obj42;
						if (!flag19)
						{
							nint num3 = (nint)aSCII;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v50 (Il2CppClass<System.Text.Encoding>)+260]");
							action = (Action<Sprite>)0;
							object bytes = aSCII.GetBytes(s);
							obj36 = bytes;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							num = unchecked((nint)null);
							obj3 = bytes;
							goto IL_058c;
						}
						goto IL_0b96;
					}
				}
				object obj44 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj45 = "fetch_products" + 1096;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
				string paramName = default(string);
				ex..ctor(paramName);
				object obj46 = (nint)0 + (nint)1072;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				throw new OutOfMemoryException();
			}
		}
		goto IL_0b96;
		IL_0b96:
		throw new NullReferenceException();
		IL_0b15:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		_renderCamera = camera;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj3 = camera;
		goto IL_0c97;
		IL_0a71:
		camera = (Camera)obj9;
		goto IL_0c97;
		IL_090f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag20 = obj35;
		bool flag21 = !flag20;
		object obj47 = !flag21;
		obj3 = null;
		if (obj47 != null)
		{
			goto IL_085e;
		}
		goto IL_0958;
		IL_07f2:
		obj32 = (UnityEngine.Object)obj9;
		obj33 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X8_v24+E4]");
		bool flag22 = (nint)0 == 0;
		obj35 = (UnityEngine.Object)obj9;
		if (!flag22)
		{
			goto IL_082f;
		}
		goto IL_090f;
		IL_082f:
		bool flag23 = obj32;
		bool flag24 = !flag23;
		obj3 = null;
		if (!flag24)
		{
			goto IL_085e;
		}
		goto IL_0958;
		IL_085e:
		Component component = (Component)obj9;
		goto IL_0c6d;
		IL_0958:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		_renderCamera = (Camera)component;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj3 = component;
		goto IL_0c6d;
		IL_0c6d:
		bool flag25 = (object)component == null;
		num = unchecked((nint)null);
		action = (Action<Sprite>)obj26;
		UnityEngine.Object obj49;
		if (!flag25)
		{
			GameObject gameObject = component.gameObject;
			bool flag26 = (object)gameObject == null;
			num = unchecked((nint)null);
			action = (Action<Sprite>)obj26;
			obj3 = null;
			if (!flag26)
			{
				gameObject.SetActive(value: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FD4]");
				object obj48 = (nint)0 & (nint)1;
				UnityEngine.Object obj51;
				if (obj48 != null)
				{
					obj49 = (UnityEngine.Object)obj9;
					object obj50 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v17+E4]");
					bool flag27 = (nint)0 == 0;
					obj51 = (UnityEngine.Object)obj9;
					if (!flag27)
					{
						goto IL_0a42;
					}
				}
				else
				{
					_ = 1;
					obj49 = (UnityEngine.Object)obj9;
					object obj50 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v17+E4]");
					bool flag28 = (nint)0 == 0;
					object obj52 = !flag28;
					obj51 = (UnityEngine.Object)obj9;
					if (obj52 != null)
					{
						goto IL_0a42;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag29 = obj51;
				bool flag30 = !flag29;
				object obj53 = !flag30;
				obj3 = null;
				if (obj53 != null)
				{
					goto IL_0a71;
				}
				goto IL_0b15;
			}
		}
		goto IL_0b96;
		IL_077f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj54 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X0_v107+E4]");
		if ((nint)0 != 0)
		{
			goto IL_07b6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.SafelyCallInNewThread(action2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FD4]");
		object obj55 = (nint)0 & (nint)1;
		bool flag31 = obj55 == null;
		object obj56 = !flag31;
		if (obj56 != null)
		{
			goto IL_07f2;
		}
		goto IL_08c1;
		IL_058c:
		if ((object)screenShot != null)
		{
			byte[] rawTextureData = screenShot.GetRawTextureData();
			int num2 = (int)action;
			array = rawTextureData;
			goto IL_05e8;
		}
		goto IL_0b96;
		IL_0a42:
		bool flag32 = obj49;
		bool flag33 = !flag32;
		obj3 = null;
		if (!flag33)
		{
			goto IL_0a71;
		}
		goto IL_0b15;
		IL_07b6:
		KUtil.SafelyCallInNewThread(action2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FD4]");
		object obj57 = (nint)0 & (nint)1;
		if (obj57 != null)
		{
			goto IL_07f2;
		}
		goto IL_08c1;
	}

	public void UpdateRenderTexture()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0146: Expected O, but got I4
		//IL_00bc: Expected O, but got I
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_017a: Expected O, but got I
		//IL_01a6: Expected O, but got I4
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_022a: Expected O, but got I4
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_029e: Expected O, but got I
		//IL_0367: Expected O, but got I4
		//IL_03b3: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RenderTexture renderTexture = default(RenderTexture);
		renderTexture..ctor(canvasWidth, canvasHeight, 24);
		object obj2 = this + 80;
		obj2 = renderTexture;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FD4]");
		object obj4 = (nint)0 & (nint)1;
		object obj5;
		UnityEngine.Object obj6;
		UnityEngine.Object obj8;
		object obj9;
		if (obj4 != null)
		{
			obj5 = this + 56;
			obj6 = (UnityEngine.Object)obj5;
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v47+E4]");
			bool flag = (nint)0 == 0;
			obj8 = (UnityEngine.Object)obj5;
			obj9 = obj5;
			if (!flag)
			{
				goto IL_00b0;
			}
		}
		else
		{
			_ = 1;
			obj5 = this + 56;
			obj6 = (UnityEngine.Object)obj5;
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v47+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			obj8 = (UnityEngine.Object)obj5;
			obj9 = obj5;
			if (obj10 != null)
			{
				goto IL_00b0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj11 = (nint)0 + (nint)3648;
		bool flag3 = obj8;
		bool flag4 = !flag3;
		object obj12 = !flag4;
		obj5 = obj9;
		object obj13 = obj11;
		if (obj12 != null)
		{
			goto IL_00f6;
		}
		goto IL_01c4;
		IL_02f8:
		UnityEngine.Object obj14;
		if ((bool)obj14)
		{
			goto IL_0322;
		}
		goto IL_03c1;
		IL_03c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Component component = default(Component);
		_renderCamera = (Camera)component;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_03e4;
		IL_0322:
		component = (Component)obj5;
		goto IL_03e4;
		IL_00b0:
		obj11 = (nint)0 + (nint)3648;
		bool flag5 = obj6;
		bool flag6 = !flag5;
		obj13 = obj11;
		obj9 = obj5;
		if (!flag6)
		{
			goto IL_00f6;
		}
		goto IL_01c4;
		IL_01c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Camera camera = default(Camera);
		_renderCamera = camera;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = obj13;
		obj5 = obj9;
		goto IL_01fc;
		IL_00f6:
		camera = (Camera)obj5;
		goto IL_01fc;
		IL_01fc:
		object obj15 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 656;
		camera.targetTexture = this.renderTexture;
		rect = (Rect)0;
		_ = canvasWidth;
		_ = canvasHeight;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Texture2D texture2D = default(Texture2D);
		texture2D..ctor(canvasWidth, canvasHeight, TextureFormat.RGB24, mipChain: false);
		object obj16 = this + 88;
		obj16 = texture2D;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FD4]");
		object obj17 = (nint)0 & (nint)1;
		UnityEngine.Object obj19;
		if (obj17 != null)
		{
			obj14 = (UnityEngine.Object)obj5;
			object obj18 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v23+E4]");
			bool flag7 = (nint)0 == 0;
			obj19 = (UnityEngine.Object)obj5;
			if (!flag7)
			{
				goto IL_02f8;
			}
		}
		else
		{
			_ = 1;
			obj14 = (UnityEngine.Object)obj5;
			object obj18 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v23+E4]");
			bool flag8 = (nint)0 == 0;
			object obj20 = !flag8;
			obj19 = (UnityEngine.Object)obj5;
			if (obj20 != null)
			{
				goto IL_02f8;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag9 = obj19;
		bool flag10 = !flag9;
		object obj21 = !flag10;
		if (obj21 != null)
		{
			goto IL_0322;
		}
		goto IL_03c1;
		IL_03e4:
		GameObject gameObject = component.gameObject;
		gameObject.SetActive(value: true);
	}

	public ScreenshotCamera()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252B00]");
		canvasWidth = 0;
		format = Format.JPG;
		base..ctor();
	}
}
