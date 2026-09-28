using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using UnityEngine.SceneManagement;

public static class ScenesEnumExtensions
{
	private enum TabletScene
	{
		FetchServer = 1,
		Login = 2,
		Menu = 3,
		Game = 4,
		FastTrackMenu = 5,
		MiniGame = 6,
		Store = 7,
		Settings = 8,
		PredictAndWin = 10,
		ReferralCenter = 11,
		Tutorial = 13,
		TournamentView = 14,
		MassTournament = 15
	}

	public unsafe static string GetName(Scenes scene)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		//IL_043d: Expected O, but got I4
		//IL_044d: Expected O, but got I
		//IL_046f: Expected O, but got I4
		//IL_0054: Expected O, but got I
		//IL_0076: Expected O, but got I4
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0144: Expected O, but got I4
		//IL_03ef: Expected O, but got I
		//IL_01a6: Expected O, but got I4
		//IL_0271: Expected O, but got Ref
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0220: Expected O, but got Ref
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_02c5: Expected O, but got I4
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		object handle = typeof(IAsyncEnumerable<>) + 3616;
		object obj = typeof(RegisteredWaitHandle) + 2968;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X23_v2+E0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X23_v2+98]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object value = default(object);
		Scenes scenes;
		if (Enum.IsDefined(typeFromHandle, value))
		{
			if (scene != Scenes.FastTrackMenu)
			{
				bool flag3 = scene != Scenes.Menu;
				scenes = scene;
				if (flag3)
				{
					goto IL_047d;
				}
			}
			object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v56+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SFSConfig currentSFS = Config.CurrentSFS;
			if (currentSFS != null)
			{
				bool flag5 = !currentSFS.<IsFastTrack>k__BackingField;
				object obj10 = !flag5;
				object obj11 = ~obj10;
				scenes = ((obj11 != null) ? Scenes.Menu : Scenes.FastTrackMenu);
				goto IL_047d;
			}
		}
		else
		{
			object obj12 = typeof(IAsyncEnumerable<>) + 3600;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D040");
			RuntimeTypeHandle handle2 = default(RuntimeTypeHandle);
			Type typeFromHandle2 = Type.GetTypeFromHandle(handle2);
			object obj13 = typeof(System.IOAsyncCallback) + 3728;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = "rightCtrl" + 1168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			InvalidEnumArgumentException ex = default(InvalidEnumArgumentException);
			string argumentName = default(string);
			ex..ctor(argumentName, (int)scene, typeFromHandle2);
			object obj15 = (nint)0 + (nint)904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			OutOfMemoryException ex2 = new OutOfMemoryException();
		}
		return (string)(object)new NullReferenceException();
		IL_0236:
		string friendlyName;
		return friendlyName;
		IL_047d:
		Scenes scenes2 = default(Scenes);
		string text;
		if (ScreenUtility.IsTablet)
		{
			object obj16 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			bool flag6 = scenes == Scenes.Game;
			object obj17 = (object)(&scenes2);
			text = friendlyName;
			if (!flag6)
			{
				goto IL_0236;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration2 = default(Enum);
			friendlyName = EnumExtensions.GetFriendlyName(enumeration2);
			bool flag7 = scenes != Scenes.Game;
			object obj17 = (object)(&scenes2);
			text = friendlyName;
			if (flag7)
			{
				goto IL_0236;
			}
		}
		object obj18 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v38+E4]");
		bool flag8 = (nint)0 == 0;
		object obj20 = !flag8;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		object obj21 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object format = "___# Content push apply failed [{0}]: {1}" + 2488;
		object arg = default(object);
		string text2 = string.Format((string)format, arg);
		return text + text2;
	}

	public static bool IsEqual(Scenes kammelnaScene, Scene unityScene)
	{
		//IL_000c: Expected O, but got I
		//IL_0076: Expected I4, but got O
		object obj = (nint)0 + (nint)1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D70F1C");
		bool flag = default(bool);
		if (flag)
		{
			Scene scene = default(Scene);
			string name = scene.name;
			string name2 = GetName(kammelnaScene);
			if (name != null)
			{
				return name.Equals(name2);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		return flag;
	}

	public unsafe static Scenes? GetSceneEnum(Scene addressableScene)
	{
		//IL_0008: Expected O, but got Ref
		//IL_013d: Expected O, but got Ref
		//IL_0036: Expected I4, but got I8
		//IL_0050: Expected O, but got I4
		//IL_00e7: Expected O, but got I
		//IL_0121: Expected O, but got I4
		//IL_00a7: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Scene scene = (Scene)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 20));
		string name = ((Scene*)scene)->name;
		if (name != null)
		{
			int num = name.IndexOf('_');
			int num2 = (int)(num & 0x80000000L);
			bool flag = num2 == 0;
			object obj3 = !flag;
			string text = name;
			if (obj3 == null)
			{
				int startIndex = name.IndexOf('_');
				string text2 = name.Remove(startIndex);
				text = text2;
			}
			System.Int32Enum value;
			if (ScreenUtility.IsTablet)
			{
				object obj4 = (nint)0 + (nint)1736;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72A08");
				object obj5 = default(object);
				if (obj5 == null)
				{
					goto IL_011b;
				}
				System.Int32Enum int32Enum = default(System.Int32Enum);
				value = int32Enum;
			}
			else
			{
				object obj6 = (nint)0 + (nint)1728;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72A08");
				object obj7 = default(object);
				if (obj7 == null)
				{
					goto IL_011b;
				}
				System.Int32Enum int32Enum2 = default(System.Int32Enum);
				value = int32Enum2;
			}
			return (Scenes?)new System.Int32Enum?(value);
		}
		return (Scenes?)new NullReferenceException();
		IL_011b:
		return (Scenes?)(object)0;
	}

	public static bool IsCustomRoomScene(Scenes scene)
	{
		//IL_001a: Expected O, but got I4
		//IL_0031: Expected O, but got I4
		//IL_003e: Expected I4, but got O
		bool flag = scene < (Scenes)16;
		object obj = !flag;
		object obj2 = ~obj;
		object obj3 = 57366 >> (int)scene;
		return (byte)(obj2 & obj3) != 0;
	}
}
