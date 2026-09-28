using System;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Mono.Btls;
using Sfs2X.Core;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

public static class NavigationController
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action <>9__0_0;

		public static Action<bool> <>9__0_1;

		public static Action <>9__0_2;

		public static Action <>9__0_3;

		public static Action <>9__0_4;

		public static Action <>9__0_5;

		public static Action <>9__0_6;

		public static EventListenerDelegate <>9__0_7;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 680;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Init>b__0_0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0061: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 3136;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.LoadScene(Scenes.Game);
		}

		internal void <Init>b__0_1(bool needsServerRefetch)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_003b: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 3136;
			object obj2 = obj;
			if (needsServerRefetch)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.LoadScene(Scenes.FetchServer);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
				if ((nint)0 != 0)
				{
					ScreenManager.LoadPreviousScene();
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				ScreenManager.LoadPreviousScene();
			}
		}

		internal void <Init>b__0_2()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00b6: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 3136;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CD0]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = obj3;
				if (!flag)
				{
					goto IL_007c;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = obj3;
				if (obj5 != null)
				{
					goto IL_007c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.ReloadScene();
			return;
			IL_007c:
			AsyncOperationHandle<SceneInstance> asyncOperationHandle2 = ScreenManager.ReloadScene();
		}

		internal void <Init>b__0_3()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_014e: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_01d4: Expected O, but got I4
			//IL_017c: Expected O, but got I
			//IL_0196: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_0253: Expected O, but got I4
			//IL_020c: Expected O, but got I
			object obj = 152981504;
			object obj2 = typeof(RegisteredWaitHandle) + 3136;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CD1]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v14+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v14+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_01a4;
			IL_0231:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v1+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.LoadScene(Scenes.FetchServer);
			return;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v1+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v17+18]");
			if ((nint)0 == 2)
			{
				return;
			}
			goto IL_0231;
			IL_01ea:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v1+B8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v6+18]");
			if ((nint)0 == 2)
			{
				return;
			}
			goto IL_0231;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
			object obj12 = (nint)0 & (nint)1;
			if (obj12 != null)
			{
				goto IL_00b0;
			}
			goto IL_01a4;
			IL_01a4:
			_ = 1;
			obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v1+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			object obj14 = obj10;
			if (obj13 != null)
			{
				goto IL_00e5;
			}
			goto IL_01ea;
			IL_00b0:
			obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v1+E4]");
			bool flag5 = (nint)0 == 0;
			obj14 = obj10;
			if (!flag5)
			{
				goto IL_00e5;
			}
			goto IL_01ea;
		}

		internal void <Init>b__0_4()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0061: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 3136;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.LoadScene(Scenes.FetchServer);
		}

		internal void <Init>b__0_5()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0061: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 3136;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.LoadScene(Scenes.Login);
		}

		internal void <Init>b__0_6()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0061: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 3136;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.LoadScene(Scenes.Login);
		}

		internal void <Init>b__0_7(BaseEvent evt)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0061: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 3136;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.LoadScene(Scenes.Login);
		}
	}

	private static void Init()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_05de: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_0678: Expected O, but got I4
		//IL_0616: Expected O, but got I
		//IL_0626: Expected O, but got I
		//IL_0648: Expected O, but got I4
		//IL_0fb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb5: Expected O, but got Unknown
		//IL_0fcb: Expected O, but got I
		//IL_0fd3: Expected I, but got O
		//IL_0fe4: Expected I, but got O
		//IL_1002: Expected O, but got I
		//IL_00f2: Expected O, but got I4
		//IL_010b: Expected O, but got I4
		//IL_06e0: Expected O, but got I4
		//IL_06e9: Expected O, but got I4
		//IL_06f2: Expected O, but got I4
		//IL_06fb: Expected O, but got I4
		//IL_0703: Expected I, but got O
		//IL_070c: Expected O, but got I4
		//IL_06a8: Expected O, but got I
		//IL_0744: Expected O, but got I
		//IL_0754: Expected O, but got I
		//IL_0776: Expected O, but got I4
		//IL_0131: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_01a7: Expected O, but got I4
		//IL_01c0: Expected O, but got I4
		//IL_07be: Expected O, but got I4
		//IL_088a: Expected O, but got I
		//IL_089a: Expected O, but got I
		//IL_08bc: Expected O, but got I4
		//IL_1028: Unknown result type (might be due to invalid IL or missing references)
		//IL_102d: Expected O, but got Unknown
		//IL_1043: Expected O, but got I
		//IL_104b: Expected I, but got O
		//IL_105c: Expected I, but got O
		//IL_107a: Expected O, but got I
		//IL_025c: Expected O, but got I4
		//IL_0275: Expected O, but got I4
		//IL_01e6: Expected O, but got I
		//IL_01f6: Expected O, but got I
		//IL_0826: Expected O, but got I4
		//IL_082f: Expected O, but got I4
		//IL_0838: Expected O, but got I4
		//IL_0841: Expected O, but got I4
		//IL_0849: Expected I, but got O
		//IL_0852: Expected O, but got I4
		//IL_07ee: Expected O, but got I
		//IL_09d0: Expected O, but got I
		//IL_09e0: Expected O, but got I
		//IL_0a02: Expected O, but got I4
		//IL_0904: Expected O, but got I4
		//IL_0311: Expected O, but got I4
		//IL_032a: Expected O, but got I4
		//IL_029b: Expected O, but got I
		//IL_02ab: Expected O, but got I
		//IL_10a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a5: Expected O, but got Unknown
		//IL_10bb: Expected O, but got I
		//IL_10c3: Expected I, but got O
		//IL_10d4: Expected I, but got O
		//IL_10f2: Expected O, but got I
		//IL_0b16: Expected O, but got I
		//IL_0b26: Expected O, but got I
		//IL_0b48: Expected O, but got I4
		//IL_0a4a: Expected O, but got I4
		//IL_096c: Expected O, but got I4
		//IL_0975: Expected O, but got I4
		//IL_097e: Expected O, but got I4
		//IL_0987: Expected O, but got I4
		//IL_098f: Expected I, but got O
		//IL_0998: Expected O, but got I4
		//IL_0934: Expected O, but got I
		//IL_03c6: Expected O, but got I4
		//IL_03df: Expected O, but got I4
		//IL_0350: Expected O, but got I
		//IL_0360: Expected O, but got I
		//IL_1118: Unknown result type (might be due to invalid IL or missing references)
		//IL_111d: Expected O, but got Unknown
		//IL_1133: Expected O, but got I
		//IL_113b: Expected I, but got O
		//IL_114c: Expected I, but got O
		//IL_116a: Expected O, but got I
		//IL_0c5c: Expected O, but got I
		//IL_0c6c: Expected O, but got I
		//IL_0c8e: Expected O, but got I4
		//IL_0b90: Expected O, but got I4
		//IL_0ab2: Expected O, but got I4
		//IL_0abb: Expected O, but got I4
		//IL_0ac4: Expected O, but got I4
		//IL_0acd: Expected O, but got I4
		//IL_0ad5: Expected I, but got O
		//IL_0ade: Expected O, but got I4
		//IL_0a7a: Expected O, but got I
		//IL_047b: Expected O, but got I4
		//IL_0494: Expected O, but got I4
		//IL_0405: Expected O, but got I
		//IL_0415: Expected O, but got I
		//IL_1190: Unknown result type (might be due to invalid IL or missing references)
		//IL_1195: Expected O, but got Unknown
		//IL_11ab: Expected O, but got I
		//IL_11b3: Expected I, but got O
		//IL_11c4: Expected I, but got O
		//IL_11e2: Expected O, but got I
		//IL_0da2: Expected O, but got I
		//IL_0db2: Expected O, but got I
		//IL_0dd4: Expected O, but got I4
		//IL_0cd6: Expected O, but got I4
		//IL_0bf8: Expected O, but got I4
		//IL_0c01: Expected O, but got I4
		//IL_0c0a: Expected O, but got I4
		//IL_0c13: Expected O, but got I4
		//IL_0c1b: Expected I, but got O
		//IL_0c24: Expected O, but got I4
		//IL_0bc0: Expected O, but got I
		//IL_0530: Expected O, but got I4
		//IL_0549: Expected O, but got I4
		//IL_04ba: Expected O, but got I
		//IL_04ca: Expected O, but got I
		//IL_1208: Unknown result type (might be due to invalid IL or missing references)
		//IL_120d: Expected O, but got Unknown
		//IL_1223: Expected O, but got I
		//IL_122b: Expected I, but got O
		//IL_123c: Expected I, but got O
		//IL_125a: Expected O, but got I
		//IL_0ee8: Expected O, but got I
		//IL_0ef8: Expected O, but got I
		//IL_0f1a: Expected O, but got I4
		//IL_0e1c: Expected O, but got I4
		//IL_0d3e: Expected O, but got I4
		//IL_0d47: Expected O, but got I4
		//IL_0d50: Expected O, but got I4
		//IL_0d59: Expected O, but got I4
		//IL_0d61: Expected I, but got O
		//IL_0d6a: Expected O, but got I4
		//IL_0d06: Expected O, but got I
		//IL_056f: Expected O, but got I
		//IL_057f: Expected O, but got I
		//IL_1280: Unknown result type (might be due to invalid IL or missing references)
		//IL_1285: Expected O, but got Unknown
		//IL_129b: Expected O, but got I
		//IL_12a3: Expected I, but got O
		//IL_12b4: Expected I, but got O
		//IL_12d2: Expected O, but got I
		//IL_0f62: Expected O, but got I4
		//IL_0e84: Expected O, but got I4
		//IL_0e8d: Expected O, but got I4
		//IL_0e96: Expected O, but got I4
		//IL_0e9f: Expected O, but got I4
		//IL_0ea7: Expected I, but got O
		//IL_0eb0: Expected O, but got I4
		//IL_0e4c: Expected O, but got I
		//IL_12f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fd: Expected O, but got Unknown
		//IL_1313: Expected O, but got I
		//IL_1324: Expected I, but got O
		//IL_1342: Expected O, but got I
		//IL_0f92: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 680;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CCC]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		if (obj2 != null)
		{
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v91+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v91+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v91+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v37+8]");
		Action value = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v37+8]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			goto IL_00c1;
		}
		goto IL_0656;
		IL_03f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v26+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X9_v12+30]");
		Action value2 = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X9_v12+30]");
		bool flag4 = (nint)0 == 0;
		object obj10 = default(object);
		object obj9 = obj10;
		nint num2 = default(nint);
		nint num = num2;
		if (!flag4)
		{
			goto IL_044a;
		}
		goto IL_0cb4;
		IL_0c3a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v26+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X9_v12+30]");
		value2 = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X9_v12+30]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		obj10 = obj9;
		num2 = num;
		object obj14;
		object obj13 = obj14;
		if (obj12 != null)
		{
			goto IL_044a;
		}
		goto IL_0cb4;
		IL_0395:
		Action value3;
		SFS.OnForcedDisconnect += value3;
		obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v26+E4]");
		bool flag6 = (nint)0 == 0;
		obj13 = 0;
		obj9 = obj10;
		num = num2;
		obj14 = 0;
		object obj15 = obj11;
		if (!flag6)
		{
			goto IL_03f5;
		}
		goto IL_0c3a;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v91+B8]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v37+8]");
		value = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v37+8]");
		if ((nint)0 != 0)
		{
			goto IL_00c1;
		}
		goto IL_0656;
		IL_0656:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v91+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v87+B8]");
			obj6 = 0;
		}
		object obj18 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = (nint)0 + (nint)2472;
		num2 = (nint)obj19;
		Action action = default(Action);
		action..ctor(obj6, (IntPtr)obj19);
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v85+B8]");
		object obj21 = (nint)0 + (nint)8;
		obj21 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SFS.OnOfflineGameStarted += action;
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v78+E4]");
		bool flag8 = (nint)0 == 0;
		object obj23 = !flag8;
		obj10 = 0;
		object obj24 = 0;
		object obj25 = 0;
		nint num3 = (nint)obj19;
		object obj26 = 0;
		object obj27 = obj22;
		if (obj23 != null)
		{
			goto IL_0121;
		}
		goto IL_0722;
		IL_055f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X0_v1+B8]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X9_v2+40]");
		EventListenerDelegate value4 = (EventListenerDelegate)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X9_v2+40]");
		if ((nint)0 != 0)
		{
			goto IL_05a4;
		}
		goto IL_0f40;
		IL_0cb4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v26+E4]");
		bool flag9 = (nint)0 == 0;
		object obj29 = !flag9;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj30 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v32+B8]");
			obj8 = 0;
		}
		object obj31 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj32 = (nint)0 + (nint)2512;
		num2 = (nint)obj32;
		Action action2 = default(Action);
		action2..ctor(obj8, (IntPtr)obj32);
		object obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v30+B8]");
		object obj34 = (nint)0 + (nint)48;
		obj34 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SFS.OnKickedToLogin += action2;
		object obj35 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X0_v13+E4]");
		bool flag10 = (nint)0 == 0;
		object obj36 = !flag10;
		obj10 = 0;
		object obj37 = 0;
		object obj38 = 0;
		nint num4 = (nint)obj32;
		object obj39 = 0;
		object obj40 = obj35;
		if (obj36 != null)
		{
			goto IL_04aa;
		}
		goto IL_0d80;
		IL_00c1:
		SFS.OnOfflineGameStarted += value;
		obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v78+E4]");
		bool flag11 = (nint)0 == 0;
		obj24 = 0;
		obj25 = obj10;
		num3 = num2;
		obj26 = 0;
		obj27 = obj22;
		if (!flag11)
		{
			goto IL_0121;
		}
		goto IL_0722;
		IL_0722:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v78+B8]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X9_v32+10]");
		Action<bool> value5 = (Action<bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X9_v32+10]");
		bool flag12 = (nint)0 == 0;
		object obj42 = !flag12;
		obj10 = obj25;
		num2 = num3;
		obj24 = obj26;
		if (obj42 != null)
		{
			goto IL_0176;
		}
		goto IL_079c;
		IL_0121:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v78+B8]");
		obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X9_v32+10]");
		value5 = (Action<bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X9_v32+10]");
		bool flag13 = (nint)0 == 0;
		obj25 = obj10;
		num3 = num2;
		if (!flag13)
		{
			goto IL_0176;
		}
		goto IL_079c;
		IL_079c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v78+E4]");
		bool flag14 = (nint)0 == 0;
		object obj43 = !flag14;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj44 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v76+B8]");
			obj41 = 0;
		}
		object obj45 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj46 = (nint)0 + (nint)2480;
		num2 = (nint)obj46;
		Action<bool> action3 = default(Action<bool>);
		action3..ctor(obj41, (IntPtr)obj46);
		object obj47 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v74+B8]");
		object obj48 = (nint)0 + (nint)16;
		obj48 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SFS.OnReturnedFromOffline += action3;
		object obj49 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v65+E4]");
		bool flag15 = (nint)0 == 0;
		object obj50 = !flag15;
		obj10 = 0;
		object obj51 = 0;
		object obj52 = 0;
		nint num5 = (nint)obj46;
		object obj53 = 0;
		object obj54 = obj49;
		if (obj50 != null)
		{
			goto IL_01d6;
		}
		goto IL_0868;
		IL_044a:
		SFS.OnKickedToLogin += value2;
		obj35 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X0_v13+E4]");
		bool flag16 = (nint)0 == 0;
		obj37 = 0;
		obj38 = obj10;
		num4 = num2;
		obj39 = 0;
		obj40 = obj35;
		if (!flag16)
		{
			goto IL_04aa;
		}
		goto IL_0d80;
		IL_0ec6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj55 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X0_v1+B8]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X9_v2+40]");
		value4 = (EventListenerDelegate)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X9_v2+40]");
		bool flag17 = (nint)0 == 0;
		object obj56 = !flag17;
		object obj57;
		obj10 = obj57;
		nint num6;
		num2 = num6;
		object obj59;
		object obj58 = obj59;
		if (obj56 != null)
		{
			goto IL_05a4;
		}
		goto IL_0f40;
		IL_0176:
		SFS.OnReturnedFromOffline += value5;
		obj49 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v65+E4]");
		bool flag18 = (nint)0 == 0;
		obj51 = 0;
		obj52 = obj10;
		num5 = num2;
		obj53 = 0;
		obj54 = obj49;
		if (!flag18)
		{
			goto IL_01d6;
		}
		goto IL_0868;
		IL_0868:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj49 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v65+B8]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X9_v27+18]");
		Action value6 = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X9_v27+18]");
		bool flag19 = (nint)0 == 0;
		object obj61 = !flag19;
		obj10 = obj52;
		num2 = num5;
		obj51 = obj53;
		if (obj61 != null)
		{
			goto IL_022b;
		}
		goto IL_08e2;
		IL_01d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v65+B8]");
		obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X9_v27+18]");
		value6 = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X9_v27+18]");
		bool flag20 = (nint)0 == 0;
		obj52 = obj10;
		num5 = num2;
		if (!flag20)
		{
			goto IL_022b;
		}
		goto IL_08e2;
		IL_08e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v65+E4]");
		bool flag21 = (nint)0 == 0;
		object obj62 = !flag21;
		if (obj62 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj63 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v65+B8]");
			obj60 = 0;
		}
		object obj64 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj65 = (nint)0 + (nint)2488;
		num2 = (nint)obj65;
		Action action4 = default(Action);
		action4..ctor(obj60, (IntPtr)obj65);
		object obj66 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v63+B8]");
		object obj67 = (nint)0 + (nint)24;
		obj67 = action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SFS.OnGameSwitchedOffline += action4;
		object obj68 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v52+E4]");
		bool flag22 = (nint)0 == 0;
		object obj69 = !flag22;
		obj10 = 0;
		object obj70 = 0;
		object obj71 = 0;
		nint num7 = (nint)obj65;
		object obj72 = 0;
		object obj73 = obj68;
		if (obj69 != null)
		{
			goto IL_028b;
		}
		goto IL_09ae;
		IL_04aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X0_v13+B8]");
		object obj74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X9_v7+38]");
		Action value7 = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X9_v7+38]");
		bool flag23 = (nint)0 == 0;
		obj38 = obj10;
		num4 = num2;
		if (!flag23)
		{
			goto IL_04ff;
		}
		goto IL_0dfa;
		IL_0d80:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj35 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X0_v13+B8]");
		obj74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X9_v7+38]");
		value7 = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X9_v7+38]");
		bool flag24 = (nint)0 == 0;
		object obj75 = !flag24;
		obj10 = obj38;
		num2 = num4;
		obj37 = obj39;
		if (obj75 != null)
		{
			goto IL_04ff;
		}
		goto IL_0dfa;
		IL_022b:
		SFS.OnGameSwitchedOffline += value6;
		obj68 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v52+E4]");
		bool flag25 = (nint)0 == 0;
		obj70 = 0;
		obj71 = obj10;
		num7 = num2;
		obj72 = 0;
		obj73 = obj68;
		if (!flag25)
		{
			goto IL_028b;
		}
		goto IL_09ae;
		IL_09ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj68 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v52+B8]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X9_v22+20]");
		Action value8 = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X9_v22+20]");
		bool flag26 = (nint)0 == 0;
		object obj77 = !flag26;
		obj10 = obj71;
		num2 = num7;
		obj70 = obj72;
		if (obj77 != null)
		{
			goto IL_02e0;
		}
		goto IL_0a28;
		IL_028b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v52+B8]");
		obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X9_v22+20]");
		value8 = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X9_v22+20]");
		bool flag27 = (nint)0 == 0;
		obj71 = obj10;
		num7 = num2;
		if (!flag27)
		{
			goto IL_02e0;
		}
		goto IL_0a28;
		IL_0a28:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v52+E4]");
		bool flag28 = (nint)0 == 0;
		object obj78 = !flag28;
		if (obj78 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj79 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v54+B8]");
			obj76 = 0;
		}
		object obj80 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj81 = (nint)0 + (nint)2496;
		num2 = (nint)obj81;
		Action action5 = default(Action);
		action5..ctor(obj76, (IntPtr)obj81);
		object obj82 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v52+B8]");
		object obj83 = (nint)0 + (nint)32;
		obj83 = action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SFS.OnConnectionStuck += action5;
		object obj84 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v39+E4]");
		bool flag29 = (nint)0 == 0;
		object obj85 = !flag29;
		obj10 = 0;
		object obj86 = 0;
		object obj87 = 0;
		nint num8 = (nint)obj81;
		object obj88 = 0;
		object obj89 = obj84;
		if (obj85 != null)
		{
			goto IL_0340;
		}
		goto IL_0af4;
		IL_05a4:
		SFS.OnLogoutNotReliable += value4;
		return;
		IL_0dfa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X0_v13+E4]");
		bool flag30 = (nint)0 == 0;
		object obj90 = !flag30;
		if (obj90 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj91 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v21+B8]");
			obj74 = 0;
		}
		object obj92 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj93 = (nint)0 + (nint)2520;
		num2 = (nint)obj93;
		Action action6 = default(Action);
		action6..ctor(obj74, (IntPtr)obj93);
		object obj94 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X8_v19+B8]");
		object obj95 = (nint)0 + (nint)56;
		obj95 = action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SFS.OnLogout += action6;
		obj55 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X0_v1+E4]");
		bool flag31 = (nint)0 == 0;
		object obj96 = !flag31;
		obj10 = 0;
		obj58 = 0;
		obj57 = 0;
		num6 = (nint)obj93;
		obj59 = 0;
		object obj97 = obj55;
		if (obj96 != null)
		{
			goto IL_055f;
		}
		goto IL_0ec6;
		IL_02e0:
		SFS.OnConnectionStuck += value8;
		obj84 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v39+E4]");
		bool flag32 = (nint)0 == 0;
		obj86 = 0;
		obj87 = obj10;
		num8 = num2;
		obj88 = 0;
		obj89 = obj84;
		if (!flag32)
		{
			goto IL_0340;
		}
		goto IL_0af4;
		IL_0af4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj84 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v39+B8]");
		object obj98 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X9_v17+28]");
		value3 = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X9_v17+28]");
		bool flag33 = (nint)0 == 0;
		object obj99 = !flag33;
		obj10 = obj87;
		num2 = num8;
		obj86 = obj88;
		if (obj99 != null)
		{
			goto IL_0395;
		}
		goto IL_0b6e;
		IL_0340:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v39+B8]");
		obj98 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X9_v17+28]");
		value3 = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X9_v17+28]");
		bool flag34 = (nint)0 == 0;
		obj87 = obj10;
		num8 = num2;
		if (!flag34)
		{
			goto IL_0395;
		}
		goto IL_0b6e;
		IL_0b6e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v39+E4]");
		bool flag35 = (nint)0 == 0;
		object obj100 = !flag35;
		if (obj100 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj101 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v43+B8]");
			obj98 = 0;
		}
		object obj102 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj103 = (nint)0 + (nint)2504;
		num2 = (nint)obj103;
		Action action7 = default(Action);
		action7..ctor(obj98, (IntPtr)obj103);
		object obj104 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v41+B8]");
		object obj105 = (nint)0 + (nint)40;
		obj105 = action7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SFS.OnForcedDisconnect += action7;
		obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v26+E4]");
		bool flag36 = (nint)0 == 0;
		object obj106 = !flag36;
		obj10 = 0;
		obj13 = 0;
		obj9 = 0;
		num = (nint)obj103;
		obj14 = 0;
		obj15 = obj11;
		if (obj106 != null)
		{
			goto IL_03f5;
		}
		goto IL_0c3a;
		IL_04ff:
		SFS.OnLogout += value7;
		obj55 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X0_v1+E4]");
		bool flag37 = (nint)0 == 0;
		obj58 = 0;
		obj57 = obj10;
		num6 = num2;
		obj59 = 0;
		obj97 = obj55;
		if (!flag37)
		{
			goto IL_055f;
		}
		goto IL_0ec6;
		IL_0f40:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X0_v1+E4]");
		bool flag38 = (nint)0 == 0;
		object obj107 = !flag38;
		if (obj107 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj108 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v10+B8]");
			obj28 = 0;
		}
		object obj109 = typeof(DataRelation) + 3728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj110 = (nint)0 + (nint)2528;
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(obj28, (IntPtr)obj110);
		object obj111 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X8_v9+B8]");
		object obj112 = (nint)0 + (nint)64;
		obj112 = eventListenerDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SFS.OnLogoutNotReliable += eventListenerDelegate;
	}
}
