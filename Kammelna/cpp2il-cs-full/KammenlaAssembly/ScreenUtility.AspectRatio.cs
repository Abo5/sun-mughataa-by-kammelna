using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Threading;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

public static class ScreenUtility
{
	private enum ScreenForceMode
	{
		None,
		Phone,
		Tablet
	}

	public enum AspectRatio
	{
		SD,
		HD,
		WIDE
	}

	private const float ReferenceHeight = 1920f;

	private const float ReferenceWidth = 2560f;

	private const float MinimumTabletArea = 18f;

	private static ScreenForceMode _forcedMode;

	private const float AspectTolerance = 0.01f;

	private const float SD = 1.3333334f;

	private const float HD = 1.7777778f;

	private const float WIDE = 2.3333333f;

	private const float PortraitSD = 0.75f;

	private const float PortraitHD = 0.5625f;

	private const float PortraitWIDE = 0.42857143f;

	public static float ScaleFactor
	{
		get
		{
			if (IsTablet)
			{
				return ExpandScaleFactor;
			}
			return ShrinkScaleFactor;
		}
	}

	public static bool IsTablet
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_020b: Expected O, but got I
			//IL_01f3: Expected I4, but got O
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected O, but got Unknown
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Expected O, but got Unknown
			//IL_01ba: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 3192;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+B8]");
			object obj3 = 0;
			if (obj3 != null)
			{
				object obj4 = obj3 - 2;
				return obj4 == null;
			}
			string deviceModel = UnityEngine.Device.SystemInfo.deviceModel;
			if (deviceModel != null)
			{
				object value = "https://www.kammelna.com/Home/Terms" + 192;
				if (deviceModel.Contains((string)value))
				{
					return true;
				}
				object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v6+E4]");
				if ((nint)0 != 0)
				{
					Platform platform = KUtil.GetPlatform();
					if (platform == Platform.Web)
					{
						goto IL_010e;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Platform platform = KUtil.GetPlatform();
					if (platform == Platform.Web)
					{
						goto IL_010e;
					}
				}
				float num = DeviceScreenArea();
				if ((double)num < 18.0)
				{
					return false;
				}
				object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj9 = !flag;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return Preferences.ForceTablet;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_010e:
			return true;
		}
	}

	public static bool IsTabletSize
	{
		get
		{
			//IL_0026: Invalid comparison between F4 and I4
			//IL_003e: Expected O, but got F8
			//IL_004b: Expected O, but got F4
			float num = DeviceScreenArea();
			float num2 = num - 18f;
			bool flag = num2 < 0f;
			object obj = (double)num ^ 18.0;
			object obj2 = num ^ num2;
			object obj3 = obj & obj2;
			bool flag2 = (nint)obj3 < 0;
			return flag == flag2;
		}
	}

	public static bool HasScreenCutout
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00a3: Expected O, but got I4
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_005e: Expected O, but got I8
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			Rect safeArea = UnityEngine.Device.Screen.safeArea;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int height = UnityEngine.Device.Screen.height;
			object obj5 = default(object);
			object obj4 = (((nint)obj5 != 2139095040) ? obj5 : ((object)2147483648L));
			object obj6 = obj4 - height;
			bool flag2 = obj6 == null;
			return !flag2;
		}
	}

	public static float TopCutoutSize
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0080: Expected O, but got I4
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			int height = UnityEngine.Device.Screen.height;
			Rect safeArea = UnityEngine.Device.Screen.safeArea;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (IsTablet)
				{
					goto IL_0040;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool isTablet = IsTablet;
				bool flag = !isTablet;
				object obj3 = !flag;
				if (obj3 != null)
				{
					goto IL_0040;
				}
			}
			float num = ShrinkScaleFactor;
			goto IL_009d;
			IL_009d:
			object obj5 = default(object);
			object obj6 = default(object);
			object obj4 = obj5 + obj6;
			object obj7 = height - obj4;
			return (float)obj7 * num;
			IL_0040:
			num = ExpandScaleFactor;
			goto IL_009d;
		}
	}

	public static float BottomCutoutSize
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0128: Expected O, but got I4
			//IL_0180: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74E4]");
			object obj3 = (nint)0 & (nint)1;
			object obj5;
			object obj6 = default(object);
			object obj7;
			if (obj3 != null)
			{
				Rect safeArea = UnityEngine.Device.Screen.safeArea;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				obj5 = obj6;
				obj7 = obj6;
				object obj8 = obj4;
				if (!flag)
				{
					goto IL_009e;
				}
			}
			else
			{
				_ = 1;
				Rect safeArea2 = UnityEngine.Device.Screen.safeArea;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				obj5 = obj6;
				obj7 = obj6;
				object obj8 = obj4;
				if (obj9 != null)
				{
					goto IL_009e;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool isTablet = IsTablet;
			bool flag3 = !isTablet;
			object obj10 = !flag3;
			obj5 = obj7;
			if (obj10 != null)
			{
				goto IL_00cd;
			}
			goto IL_0197;
			IL_00cd:
			float expandScaleFactor = ExpandScaleFactor;
			return (float)obj5 * expandScaleFactor;
			IL_0197:
			float shrinkScaleFactor = ShrinkScaleFactor;
			return (float)obj7 * shrinkScaleFactor;
			IL_009e:
			isTablet = IsTablet;
			bool flag4 = !isTablet;
			obj7 = obj5;
			if (!flag4)
			{
				goto IL_00cd;
			}
			goto IL_0197;
		}
	}

	public static float CanvasWidth
	{
		get
		{
			int width = UnityEngine.Device.Screen.width;
			if (IsTablet)
			{
				float expandScaleFactor = ExpandScaleFactor;
				return expandScaleFactor * (float)width;
			}
			float shrinkScaleFactor = ShrinkScaleFactor;
			return shrinkScaleFactor * (float)width;
		}
	}

	public static float CanvasHeight
	{
		get
		{
			int height = UnityEngine.Device.Screen.height;
			if (IsTablet)
			{
				float expandScaleFactor = ExpandScaleFactor;
				return expandScaleFactor * (float)height;
			}
			float shrinkScaleFactor = ShrinkScaleFactor;
			return shrinkScaleFactor * (float)height;
		}
	}

	private static float ExpandScaleFactor
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			int width = UnityEngine.Device.Screen.width;
			int height = UnityEngine.Device.Screen.height;
			int width2 = UnityEngine.Device.Screen.width;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = height / width2;
			float val = 0.75f / (float)num;
			float num2 = Math.Max(val, 1f);
			int num3 = 1159725056 / width;
			return (float)num3 * num2;
		}
	}

	private static float ShrinkScaleFactor
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			int height = UnityEngine.Device.Screen.height;
			int height2 = UnityEngine.Device.Screen.height;
			int width = UnityEngine.Device.Screen.width;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = height2 / width;
			float val = 1.0718777E+09f / (float)num;
			float num2 = Math.Min(val, 1f);
			int num3 = 1156579328 / height;
			return (float)num3 / num2;
		}
	}

	private static float DeviceScreenRatio
	{
		get
		{
			int width = UnityEngine.Device.Screen.width;
			int height = UnityEngine.Device.Screen.height;
			return (float)width / (float)height;
		}
	}

	private static bool IsPortrait
	{
		get
		{
			//IL_0024: Expected O, but got I4
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected I4, but got Unknown
			//IL_0091: Expected O, but got I4
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected I4, but got Unknown
			int height = UnityEngine.Device.Screen.height;
			int width = UnityEngine.Device.Screen.width;
			object obj = height - width;
			bool flag = (nint)obj < 0;
			bool flag2 = obj == null;
			int num = height ^ width;
			int num2 = height ^ obj;
			int num3 = num & num2;
			bool flag3 = num3 < 0;
			bool flag4 = flag == flag3;
			object obj2 = !flag2;
			return (byte)((flag4 & obj2) ? 1 : 0) != 0;
		}
	}

	public static void SwitchToTablet()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_005e: Expected O, but got I
		//IL_0067: Expected O, but got I4
		//IL_0091: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 3192;
		object obj2 = typeof(RegisteredWaitHandle) + 3136;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+B8]");
		object obj4 = 0;
		obj4 = 2;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.ReloadScene();
	}

	public static void SwitchToPhone()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_005e: Expected O, but got I
		//IL_0067: Expected O, but got I4
		//IL_0091: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 3192;
		object obj2 = typeof(RegisteredWaitHandle) + 3136;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+B8]");
		object obj4 = 0;
		obj4 = 1;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.ReloadScene();
	}

	public static void SetOrientation()
	{
		//IL_009c: Expected O, but got I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_024a: Expected O, but got I4
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_027f: Expected O, but got I4
		//IL_01e9: Expected O, but got I8
		bool isTablet = IsTablet;
		bool flag = !isTablet;
		ScreenOrientation screenOrientation = (isTablet ? ScreenOrientation.Portrait : ScreenOrientation.Unknown);
		ScreenOrientation orientation;
		if (!flag)
		{
			screenOrientation = UnityEngine.Device.Screen.orientation;
			if (screenOrientation != ScreenOrientation.LandscapeLeft)
			{
				screenOrientation = UnityEngine.Device.Screen.orientation;
				if (screenOrientation != ScreenOrientation.LandscapeRight)
				{
					orientation = ScreenOrientation.LandscapeLeft;
					goto IL_0209;
				}
			}
		}
		bool isTablet2 = IsTablet;
		bool flag2 = !isTablet2;
		object obj = !flag2;
		if (obj == null)
		{
			ScreenOrientation orientation2 = UnityEngine.Device.Screen.orientation;
			if (orientation2 != ScreenOrientation.Portrait)
			{
				ScreenOrientation orientation3 = UnityEngine.Device.Screen.orientation;
				if (orientation3 != ScreenOrientation.PortraitUpsideDown)
				{
					orientation = ScreenOrientation.Portrait;
					goto IL_0209;
				}
			}
		}
		goto IL_0112;
		IL_0209:
		UnityEngine.Device.Screen.orientation = orientation;
		goto IL_0112;
		IL_0112:
		UnityEngine.Device.Screen.orientation = ScreenOrientation.AutoRotation;
		bool isTablet3 = IsTablet;
		bool autorotateToPortraitUpsideDown = (byte)((isTablet3 ? 1u : 0u) ^ 1u) != 0;
		UnityEngine.Device.Screen.autorotateToPortraitUpsideDown = autorotateToPortraitUpsideDown;
		bool autorotateToPortrait = (byte)((isTablet3 ? 1u : 0u) ^ 1u) != 0;
		UnityEngine.Device.Screen.autorotateToPortrait = autorotateToPortrait;
		bool autorotateToLandscapeLeft = (UnityEngine.Device.Screen.autorotateToLandscapeRight = IsTablet);
		UnityEngine.Device.Screen.autorotateToLandscapeLeft = autorotateToLandscapeLeft;
		bool autorotateToPortraitUpsideDown2 = UnityEngine.Device.Screen.autorotateToPortraitUpsideDown;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect safeArea = UnityEngine.Device.Screen.safeArea;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int height = UnityEngine.Device.Screen.height;
		object obj6 = default(object);
		object obj5 = (((nint)obj6 != 2139095040) ? obj6 : ((object)2147483648L));
		object obj7 = obj5 - height;
		bool flag4 = obj7 == null;
		object obj8 = !flag4;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
			autorotateToPortraitUpsideDown2 = false;
		}
		UnityEngine.Device.Screen.autorotateToPortraitUpsideDown = autorotateToPortraitUpsideDown2;
	}

	private static float DeviceDiagonalSizeInInches()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0132: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_01b8: Expected O, but got I4
		//IL_0160: Expected O, but got I
		//IL_017a: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		//IL_0102: Expected F4, but got I
		//IL_01f0: Expected O, but got I
		//IL_01fd: Expected F4, but got I
		object obj = 152989696;
		object obj2 = typeof(SqlSingle[]) + 3712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74E9]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D8]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_0188;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v12+20]");
		return 0f;
		IL_01ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v3+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v3+20]");
		return 0f;
		IL_00b0:
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = obj11;
		if (!flag3)
		{
			goto IL_00e5;
		}
		goto IL_01ce;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D8]");
		object obj13 = (nint)0 & (nint)1;
		if (obj13 != null)
		{
			goto IL_00b0;
		}
		goto IL_0188;
		IL_0188:
		_ = 1;
		obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		obj12 = obj11;
		if (obj14 != null)
		{
			goto IL_00e5;
		}
		goto IL_01ce;
	}

	private static float DeviceScreenArea()
	{
		//IL_0020: Expected O, but got I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_004a: Expected O, but got I
		//IL_01a8: Expected O, but got I4
		//IL_00aa: Expected O, but got I
		//IL_022e: Expected O, but got I4
		//IL_01d6: Expected O, but got I
		//IL_01f0: Expected O, but got I4
		//IL_0119: Expected O, but got I
		//IL_012e: Expected O, but got I
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0150: Expected O, but got I4
		int width = UnityEngine.Device.Screen.width;
		int height = UnityEngine.Device.Screen.height;
		object obj = 152989696;
		object obj2 = typeof(SqlSingle[]) + 3712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74E9]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D8]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00c7;
		}
		goto IL_01fe;
		IL_00fc:
		int num = width / height;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v19+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v11+20]");
		object obj9 = (nint)num * (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v11+20]");
		object obj10 = 0 * obj9;
		object obj11 = num * num;
		double num2 = (double)obj11 + 1.0;
		return (float)obj10 / (float)num2;
		IL_0244:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = obj2;
		goto IL_00fc;
		IL_00c7:
		obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v19+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = obj12;
		if (!flag3)
		{
			goto IL_00fc;
		}
		goto IL_0244;
		IL_0094:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D8]");
		object obj14 = (nint)0 & (nint)1;
		if (obj14 != null)
		{
			goto IL_00c7;
		}
		goto IL_01fe;
		IL_01fe:
		_ = 1;
		obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		obj13 = obj12;
		if (obj15 != null)
		{
			goto IL_00fc;
		}
		goto IL_0244;
	}

	private static float GetValue(AspectRatio ratio)
	{
		//IL_0040: Expected F8, but got I4
		//IL_006e: Expected F4, but got I4
		//IL_0060: Expected F4, but got I4
		//IL_011a: Expected O, but got I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected I4, but got Unknown
		//IL_0187: Expected O, but got I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_008e: Expected F4, but got I4
		int height = UnityEngine.Device.Screen.height;
		int width = UnityEngine.Device.Screen.width;
		double num = ((ratio != AspectRatio.WIDE) ? 0.5625 : 1054567863.0);
		float result = ((ratio != AspectRatio.WIDE) ? 1.0718777E+09f : 1.07514E+09f);
		if (ratio == AspectRatio.SD)
		{
			num = 0.75;
		}
		if (ratio == AspectRatio.SD)
		{
			result = 1.06814944E+09f;
		}
		object obj = height - width;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num2 = height ^ width;
		int num3 = height ^ obj;
		int num4 = num2 & num3;
		bool flag3 = num4 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			return (float)num;
		}
		return result;
	}

	public static bool CheckCurrentAspectRatio(AspectRatio aspectRatio, float tolerance = 0.01f)
	{
		//IL_0040: Expected F8, but got I4
		//IL_006e: Expected F8, but got I4
		//IL_0060: Expected F8, but got I4
		//IL_01e1: Expected O, but got I4
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected I4, but got Unknown
		//IL_024e: Expected O, but got I4
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_008e: Expected F8, but got I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_02cc: Invalid comparison between F8 and I4
		//IL_02db: Invalid comparison between F8 and I4
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected I4, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected I4, but got Unknown
		//IL_0330: Expected O, but got I4
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_036c: Expected O, but got I
		//IL_03a8: Invalid comparison between F8 and I4
		//IL_03b7: Invalid comparison between F8 and I4
		//IL_03ca: Expected O, but got F8
		//IL_03d7: Expected O, but got F8
		//IL_040c: Expected O, but got I4
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_00b5: Expected F8, but got I4
		//IL_00f0: Invalid comparison between I4 and F8
		//IL_012a: Invalid comparison between I4 and F4
		//IL_013b: Expected O, but got I4
		//IL_0153: Invalid comparison between F4 and I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected I4, but got Unknown
		int height = UnityEngine.Device.Screen.height;
		int width = UnityEngine.Device.Screen.width;
		double num = ((aspectRatio != AspectRatio.WIDE) ? 0.5625 : 1054567863.0);
		double num2 = ((aspectRatio != AspectRatio.WIDE) ? 1071877689.0 : 1075139925.0);
		if (aspectRatio == AspectRatio.SD)
		{
			num = 0.75;
		}
		if (aspectRatio == AspectRatio.SD)
		{
			num2 = 1068149419.0;
		}
		object obj = height - width;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num3 = height ^ width;
		int num4 = height ^ obj;
		int num5 = num3 & num4;
		bool flag3 = num5 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		double num6 = ((obj4 != null) ? num2 : num);
		int width2 = UnityEngine.Device.Screen.width;
		int height2 = UnityEngine.Device.Screen.height;
		int num7 = width2 / height2;
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4024;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		double num8 = (double)width2 - num6;
		bool flag5 = num8 < 0.0;
		bool flag6 = num8 == 0.0;
		int num9 = width2 ^ num6;
		int num10 = width2 ^ num8;
		int num11 = num9 & num10;
		bool flag7 = num11 < 0;
		bool flag8 = flag5 == flag7;
		object obj6 = !flag6;
		object obj7 = flag8 & obj6;
		object obj8 = ~obj7;
		double num12 = ((obj8 != null) ? num6 : ((double)width2));
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v11+B8]");
		object obj10 = 0;
		double num13 = num12 * 897988541.0;
		double num14 = (double)obj10 * 8.0;
		double num15 = num13 - num14;
		bool flag9 = num15 < 0.0;
		bool flag10 = num15 == 0.0;
		object obj11 = num13 ^ num14;
		object obj12 = num13 ^ num15;
		object obj13 = obj11 & obj12;
		bool flag11 = (nint)obj13 < 0;
		bool flag12 = flag9 == flag11;
		object obj14 = !flag10;
		object obj15 = flag12 & obj14;
		object obj16 = ~obj15;
		if (obj16 != null)
		{
			num13 = num14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		if (!(num14 < num13))
		{
			double num16 = num6 - (double)tolerance;
			if ((double)num7 < num16)
			{
				return false;
			}
			float num17 = tolerance + (float)num6;
			bool flag13 = (float)num7 < num17;
			object obj17 = !flag13;
			float num18 = (float)num7 - num17;
			bool flag14 = num18 == 0f;
			object obj18 = ~obj17;
			return (byte)((obj18 | flag14) ? 1 : 0) != 0;
		}
		return true;
	}
}
