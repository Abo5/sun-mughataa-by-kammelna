using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class ScreenManager : Singleton<ScreenManager>
{
	private class ClosablePopup
	{
		private readonly GameObject <popup>k__BackingField;

		private readonly Action <close>k__BackingField;

		private readonly bool <isPersistent>k__BackingField;

		public GameObject popup => <popup>k__BackingField;

		public Action close => <close>k__BackingField;

		public bool isPersistent => <isPersistent>k__BackingField;

		public ClosablePopup(GameObject popup, Action close, bool isPersistent)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			object obj = this + 16;
			obj = popup;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj2 = this + 24;
			obj2 = close;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private sealed class <>c__DisplayClass38_0
	{
		public AsyncOperationHandle<SceneInstance> loadingOperation;

		internal unsafe void <AnimateSceneTransition>b__0()
		{
			//IL_000c: Expected O, but got I
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected O, but got Unknown
			//IL_0096: Expected O, but got I
			//IL_00af: Expected I, but got O
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected O, but got Unknown
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_004f: Expected O, but got I4
			//IL_0075: Expected O, but got Ref
			object obj = (nint)0 + (nint)856;
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = (AsyncOperationHandle<SceneInstance>)(this + 16);
			if (((AsyncOperationHandle<SceneInstance>*)asyncOperationHandle)->IsDone)
			{
				object obj2 = typeof(RegisteredWaitHandle) + 3136;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AsyncOperationHandle<SceneInstance> asyncOperationHandle2 = default(AsyncOperationHandle<SceneInstance>);
				ActivateSceneOnCorrectRoom((AsyncOperationHandle<SceneInstance>)(&asyncOperationHandle2));
			}
			else
			{
				object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 216;
				object obj6 = (nint)0 + (nint)1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Action<AsyncOperationHandle<SceneInstance>> action = default(Action<AsyncOperationHandle<SceneInstance>>);
				action..ctor((object)null, (IntPtr)obj6);
				AsyncOperationHandle<SceneInstance> asyncOperationHandle3 = (AsyncOperationHandle<SceneInstance>)(this + 16);
				((AsyncOperationHandle<SceneInstance>*)asyncOperationHandle3)->Completed += action;
			}
		}
	}

	private sealed class <>c__DisplayClass41_0
	{
		public AsyncOperationHandle<SceneInstance> loadingOperation;

		internal unsafe void <ActivateSceneOnCorrectRoom>g__OnJoinRoom|0(Room obj)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_00ed: Expected O, but got I
			//IL_0105: Expected I, but got O
			//IL_0063: Expected O, but got I4
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Expected O, but got Unknown
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
			object obj3 = (nint)0 + (nint)1584;
			object obj4 = typeof(Queue<string>) + 848;
			object obj5 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj3);
			SFS.OnJoinRoom -= action;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if (sessionModel.IsInLobby)
			{
				AsyncOperationHandle<SceneInstance> asyncOperationHandle = (AsyncOperationHandle<SceneInstance>)(this + 16);
				SceneInstance result = ((AsyncOperationHandle<SceneInstance>*)asyncOperationHandle)->Result;
				SceneInstance sceneInstance = default(SceneInstance);
				AsyncOperation asyncOperation = sceneInstance.ActivateAsync();
			}
		}

		internal unsafe bool <ActivateSceneOnCorrectRoom>b__1()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0037: Invalid comparison between F4 and I4
			//IL_0046: Invalid comparison between F4 and I4
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected O, but got Unknown
			//IL_0067: Expected O, but got F4
			//IL_009c: Expected O, but got I4
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected I4, but got Unknown
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = (AsyncOperationHandle<SceneInstance>)(this + 16);
			float percentComplete = ((AsyncOperationHandle<SceneInstance>*)asyncOperationHandle)->PercentComplete;
			float num = percentComplete - 1.0636755E+09f;
			bool flag = num < 0f;
			bool flag2 = num == 0f;
			object obj = percentComplete ^ 0x3F666666;
			object obj2 = percentComplete ^ num;
			object obj3 = obj & obj2;
			bool flag3 = (nint)obj3 < 0;
			bool flag4 = flag == flag3;
			object obj4 = !flag2;
			return (byte)((flag4 & obj4) ? 1 : 0) != 0;
		}

		internal unsafe void <ActivateSceneOnCorrectRoom>b__2()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = (AsyncOperationHandle<SceneInstance>)(this + 16);
			SceneInstance result = ((AsyncOperationHandle<SceneInstance>*)asyncOperationHandle)->Result;
			SceneInstance sceneInstance = default(SceneInstance);
			AsyncOperation asyncOperation = sceneInstance.ActivateAsync();
		}
	}

	private sealed class <>c__DisplayClass43_0
	{
		public Scenes targetScene;

		public Action action;

		internal void <WaitForSceneExclusively>g__SceneManagerOnSceneLoaded|0(Scene scene, LoadSceneMode mode)
		{
			//IL_0135: Expected O, but got I
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Expected O, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_007a: Expected O, but got I
			//IL_0088: Expected I, but got O
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00cb: Expected O, but got I4
			object obj = (nint)0 + (nint)1552;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D70F1C");
			object obj3 = default(object);
			object obj2 = obj3 & 1;
			if (obj2 == null)
			{
				return;
			}
			Scene scene2 = default(Scene);
			string name = scene2.name;
			string name2 = ScenesEnumExtensions.GetName(targetScene);
			if (name.Equals(name2))
			{
				object obj4 = typeof(TypeConverter<ushort, char>) + 528;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj5 = (nint)0 + (nint)1592;
				UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
				unityAction..ctor((object)this, (IntPtr)obj5);
				object obj6 = typeof(RegisteredWaitHandle) + 2944;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v15+E4]");
				bool flag = (nint)0 == 0;
				object obj8 = !flag;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
				Action action = this.action;
				if (this.action != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v92.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
		}
	}

	private sealed class <>c__DisplayClass45_0
	{
		public GameObject go;

		internal bool <RemovePopup>b__0(ClosablePopup popup)
		{
			//IL_008b: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			if (popup != null)
			{
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return popup.<popup>k__BackingField == go;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private static readonly Stack<Scenes> PreviousScenesStack;

	private static readonly List<ClosablePopup> PopupsStack;

	private static bool isLoadingSceneAsynchronously;

	private static Scenes <LastVisitedScene>k__BackingField;

	private static Scenes _currentScene;

	private bool <BackButtonBlocked>k__BackingField;

	private bool <LoadingPreviousSceneBlocked>k__BackingField;

	private SceneTransitionAnimation _transitionAnimation;

	public static Scenes PreviousScene
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0153: Expected O, but got I
			//IL_017d: Expected O, but got I4
			//IL_00a9: Expected O, but got I
			//IL_005c: Expected O, but got I
			//IL_01bd: Expected O, but got I
			//IL_0109: Expected O, but got I4
			//IL_01ed: Expected O, but got I4
			//IL_0226: Expected O, but got I
			//IL_0216: Expected I4, but got O
			object obj = 152981504;
			object obj2 = typeof(RegisteredWaitHandle) + 3136;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D04]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = (nint)0 + (nint)2368;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v25+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				obj4 = (nint)0 + (nint)2368;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v25+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+B8]");
			object source = 0;
			object obj10 = obj7;
			bool flag3 = Enumerable.Any((IEnumerable<System.Int32Enum>)source);
			bool flag4 = !flag3;
			object obj11 = !flag4;
			Scenes result = (flag3 ? Scenes.FetchServer : ((Scenes)0));
			if (obj11 != null)
			{
				goto IL_00df;
			}
			goto IL_0203;
			IL_00df:
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v19+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v19+B8]");
			object obj14 = 0;
			if (obj14 != null)
			{
				return (Scenes)((Stack<System.Int32Enum>)obj14).Peek();
			}
			NullReferenceException ex = new NullReferenceException();
			return (Scenes)ex;
			IL_0203:
			return result;
			IL_0099:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v25+B8]");
			object source2 = 0;
			obj10 = obj4;
			bool flag6 = Enumerable.Any((IEnumerable<System.Int32Enum>)source2);
			bool flag7 = !flag6;
			result = (flag6 ? Scenes.FetchServer : ((Scenes)0));
			if (!flag7)
			{
				goto IL_00df;
			}
			goto IL_0203;
		}
	}

	public static Scenes LastVisitedScene
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_010a: Expected O, but got I
			object obj = 152981504;
			object obj2 = typeof(RegisteredWaitHandle) + 3136;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D05]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+14]");
			return (Scenes)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+14]");
			return (Scenes)0;
		}
		private set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00c2: Expected O, but got I4
			//IL_008c: Expected O, but got I
			//IL_00fa: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 3136;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D06]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = obj3;
				if (obj5 != null)
				{
					goto IL_007c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+B8]");
			object obj7 = 0;
			return;
			IL_007c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+B8]");
			object obj8 = 0;
		}
	}

	public static Scenes CurrentScene
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_010a: Expected O, but got I
			object obj = 152981504;
			object obj2 = typeof(RegisteredWaitHandle) + 3136;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D07]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+18]");
			return (Scenes)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+18]");
			return (Scenes)0;
		}
		private set
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0168: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a5: Expected O, but got I
			//IL_00bb: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_022e: Expected O, but got I4
			//IL_01a0: Expected O, but got I
			//IL_01b0: Expected O, but got I
			//IL_01c6: Expected O, but got I
			//IL_01e0: Expected O, but got I4
			//IL_01f0: Expected O, but got I
			//IL_012d: Expected O, but got I
			//IL_026e: Expected O, but got I
			object obj = 152981504;
			object obj2 = typeof(RegisteredWaitHandle) + 3136;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DF9]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			if (obj3 != null)
			{
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v15+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v15+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v15+B8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v8+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458A]");
			object obj9 = (nint)0 & (nint)1;
			bool flag3 = obj9 == null;
			object obj10 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v8+18]");
			object obj11 = 0;
			if (obj10 != null)
			{
				goto IL_00e8;
			}
			goto IL_01fe;
			IL_011d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v15+B8]");
			object obj12 = 0;
			return;
			IL_024c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v3+B8]");
			object obj14 = 0;
			return;
			IL_00e8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = obj4;
			obj11 = obj8;
			if (!flag4)
			{
				goto IL_011d;
			}
			goto IL_024c;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v15+B8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v17+18]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458A]");
			object obj17 = (nint)0 & (nint)1;
			bool flag5 = obj17 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v17+18]");
			obj11 = 0;
			if (!flag5)
			{
				goto IL_00e8;
			}
			goto IL_01fe;
			IL_01fe:
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v15+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			obj8 = obj11;
			obj15 = obj4;
			if (obj18 != null)
			{
				goto IL_011d;
			}
			goto IL_024c;
		}
	}

	public bool BackButtonBlocked
	{
		get
		{
			return <BackButtonBlocked>k__BackingField;
		}
		private set
		{
			<BackButtonBlocked>k__BackingField = value;
		}
	}

	public bool LoadingPreviousSceneBlocked
	{
		get
		{
			return <LoadingPreviousSceneBlocked>k__BackingField;
		}
		private set
		{
			<LoadingPreviousSceneBlocked>k__BackingField = value;
		}
	}

	public event Action OnDisableSceneRequested
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	protected override void OnAwake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0054: Expected O, but got I
		//IL_007e: Expected O, but got I4
		//IL_00d4: Expected O, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I4
		//IL_0104: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 3136;
		object obj2 = (nint)0 + (nint)1080;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+B8]");
		object obj5 = 0;
		_ = 0;
		object obj6 = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v8+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v8+18]");
		LogScreen((Scenes)0);
		PreloadExtraAssetsAsync();
		ScreenUtility.SetOrientation();
	}

	private static void PreloadExtraAssetsAsync()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0160: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_01e6: Expected O, but got I4
		//IL_018e: Expected O, but got I
		//IL_01a8: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D0B]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_01b6;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v11+18]");
		List<string> labelsForScene = AddressablesUtil.GetLabelsForScene((Scenes)0);
		AddressablesUtil.PreloadAssets(labelsForScene);
		List<string> labelsForCommonAssets = AddressablesUtil.GetLabelsForCommonAssets();
		AddressablesUtil.PreloadAssets(labelsForCommonAssets);
		return;
		IL_01fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		goto IL_00e5;
		IL_00b0:
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = obj9;
		if (!flag3)
		{
			goto IL_00e5;
		}
		goto IL_01fc;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj11 = (nint)0 & (nint)1;
		if (obj11 != null)
		{
			goto IL_00b0;
		}
		goto IL_01b6;
		IL_01b6:
		_ = 1;
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		obj10 = obj9;
		if (obj12 != null)
		{
			goto IL_00e5;
		}
		goto IL_01fc;
	}

	private void Update()
	{
		if (InputUtil.CancelPressedThisFrame)
		{
			Back();
		}
	}

	public static AsyncOperationHandle<SceneInstance> LoadScene(Scenes scene)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0100: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00ac: Expected O, but got I4
		//IL_0138: Expected O, but got I
		//IL_015b: Expected O, but got I4
		//IL_016c: Expected O, but got I4
		//IL_0389: Expected O, but got I
		//IL_03a3: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_01b5: Expected O, but got I
		//IL_0596: Expected O, but got I
		//IL_05b0: Expected O, but got I4
		//IL_0419: Expected O, but got I
		//IL_03e1: Expected O, but got I4
		//IL_0480: Expected O, but got I
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_02a2: Expected O, but got I4
		//IL_0217: Expected O, but got I
		//IL_0626: Expected O, but got I
		//IL_0636: Expected O, but got I
		//IL_0664: Expected O, but got I
		//IL_05ee: Expected O, but got I4
		//IL_054b: Expected O, but got I4
		//IL_04e2: Expected O, but got I
		//IL_04f2: Expected O, but got I
		//IL_0523: Expected O, but got I
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_033c: Expected O, but got I4
		//IL_0d2f: Expected O, but got I4
		//IL_090f: Expected O, but got I
		//IL_0929: Expected O, but got I4
		//IL_06a5: Expected O, but got I
		//IL_099f: Expected O, but got I
		//IL_0967: Expected O, but got I4
		//IL_0707: Expected O, but got I
		//IL_09f1: Expected O, but got I4
		//IL_0ab1: Expected O, but got I
		//IL_0acb: Expected O, but got I4
		//IL_0780: Expected O, but got I
		//IL_0b11: Expected O, but got I4
		//IL_0a21: Expected O, but got I
		//IL_0b51: Expected O, but got I
		//IL_0b61: Expected O, but got I
		//IL_0b77: Expected O, but got I
		//IL_0b91: Expected O, but got I4
		//IL_0ba9: Expected O, but got I
		//IL_07f2: Expected O, but got I
		//IL_0802: Expected O, but got I
		//IL_0818: Expected O, but got I
		//IL_083f: Expected O, but got I
		//IL_0a32: Expected O, but got I
		//IL_0a3a: Expected I, but got O
		//IL_0a6d: Expected O, but got I4
		//IL_0a75: Expected I, but got O
		//IL_0be7: Expected O, but got I4
		//IL_0c2f: Expected O, but got I
		//IL_0c4f: Expected O, but got I
		//IL_089a: Expected O, but got I
		//IL_08ba: Expected O, but got I
		//IL_08dc: Expected O, but got I4
		//IL_0c92: Expected O, but got I
		//IL_0ce5: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DFA]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		if (obj2 != null)
		{
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v70+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v70+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v70+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v96+10]");
		bool flag3 = (nint)0 != 1;
		object obj7 = 146685952;
		object obj8 = obj3;
		object obj9 = 146685952;
		if (!flag3)
		{
			goto IL_017a;
		}
		goto IL_0445;
		IL_09cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X0_v29+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		object obj12;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v27+B8]");
			obj12 = 0;
		}
		nint num2;
		object obj14;
		nint num = default(nint);
		if (obj12 != null)
		{
			object obj13 = (nint)0 + (nint)848;
			num = (nint)obj13;
			((Stack<System.Int32Enum>)obj12).Clear();
			obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v26+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			num2 = (nint)obj13;
			if (obj15 != null)
			{
				goto IL_0761;
			}
			goto IL_0a83;
		}
		goto IL_0d0f;
		IL_06f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v26+B8]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v23+18]");
		bool flag6 = (nint)0 == 3;
		object obj16 = obj14;
		if (!flag6)
		{
			goto IL_0734;
		}
		goto IL_09cf;
		IL_097d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v26+B8]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v23+18]");
		bool flag7 = (nint)0 != 3;
		obj16 = obj14;
		if (flag7)
		{
			goto IL_0734;
		}
		goto IL_09cf;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v70+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v101+10]");
		bool flag8 = (nint)0 == 1;
		obj7 = 146685952;
		if (flag8)
		{
			goto IL_017a;
		}
		obj8 = obj3;
		obj9 = 146685952;
		goto IL_0445;
		IL_017a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v70+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
			object obj18 = (nint)0 & (nint)1;
			if (obj18 != null)
			{
				goto IL_01d2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X22_v19+588]");
			object obj19 = (nint)0 & (nint)1;
			bool flag9 = obj19 == null;
			object obj20 = !flag9;
			if (obj20 != null)
			{
				goto IL_01d2;
			}
		}
		_ = 1;
		obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v1+E4]");
		bool flag10 = (nint)0 == 0;
		object obj21 = !flag10;
		object obj22 = obj8;
		if (obj21 != null)
		{
			goto IL_0207;
		}
		goto IL_03f7;
		IL_0734:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v26+E4]");
		bool flag11 = (nint)0 == 0;
		num2 = num;
		if (!flag11)
		{
			goto IL_0761;
		}
		goto IL_0a83;
		IL_0d0f:
		return (AsyncOperationHandle<SceneInstance>)new NullReferenceException();
		IL_0c7c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v6+1C]");
		object obj23 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v6+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v6+10]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v6+18]");
			Array.Clear((Array)num3, 0, 0);
		}
		string sceneName = ScenesEnumExtensions.GetName(scene);
		return AnimateSceneTransition(sceneName);
		IL_01d2:
		obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v1+E4]");
		bool flag12 = (nint)0 == 0;
		obj22 = obj8;
		if (!flag12)
		{
			goto IL_0207;
		}
		goto IL_03f7;
		IL_03f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v1+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v72+18]");
		bool flag13 = (nint)scene == (nint)0;
		obj9 = obj7;
		if (flag13)
		{
			goto IL_0246;
		}
		goto IL_0445;
		IL_0207:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v1+B8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v90+18]");
		bool flag14 = (nint)scene != (nint)0;
		obj9 = obj7;
		if (!flag14)
		{
			goto IL_0246;
		}
		goto IL_0445;
		IL_0246:
		object obj26 = typeof(RegisteredWaitHandle) + 2968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj27 = typeof(RegisteredWaitHandle) + 2944;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v83+E4]");
		bool flag15 = (nint)0 == 0;
		object obj29 = !flag15;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Scene activeScene = SceneManager.GetActiveScene();
		Scene scene2 = default(Scene);
		string arg = scene2.name;
		object format = "___# Content push apply failed [{0}]: {1}" + 856;
		object arg2 = default(object);
		string text = string.Format((string)format, arg2, arg);
		object obj30 = typeof(DataRelation) + 856;
		object obj31 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v88+E4]");
		bool flag16 = (nint)0 == 0;
		object obj32 = !flag16;
		AsyncOperationHandle<SceneInstance> asyncOperationHandle = (AsyncOperationHandle<SceneInstance>)text;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			asyncOperationHandle = (AsyncOperationHandle<SceneInstance>)text;
		}
		Debug.LogWarning(asyncOperationHandle);
		object obj33 = 0;
		_ = 0;
		_ = 0;
		return asyncOperationHandle;
		IL_0761:
		PushPreviousScene(scene);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DF9]");
		object obj34 = (nint)0 & (nint)1;
		bool flag17 = obj34 == null;
		num2 = num;
		if (!flag17)
		{
			goto IL_07a5;
		}
		goto IL_0ae1;
		IL_0a83:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PushPreviousScene(scene);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DF9]");
		object obj35 = (nint)0 & (nint)1;
		bool flag18 = obj35 == null;
		object obj36 = !flag18;
		num = num2;
		if (obj36 != null)
		{
			goto IL_07a5;
		}
		goto IL_0ae1;
		IL_07a5:
		object obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v43+E4]");
		bool flag19 = (nint)0 == 0;
		num2 = num;
		object obj38 = obj37;
		if (!flag19)
		{
			goto IL_07e2;
		}
		goto IL_0b2f;
		IL_0ae1:
		_ = 1;
		obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v43+E4]");
		bool flag20 = (nint)0 == 0;
		object obj39 = !flag20;
		num = num2;
		obj38 = obj37;
		if (obj39 != null)
		{
			goto IL_07e2;
		}
		goto IL_0b2f;
		IL_0531:
		object obj40;
		bool flag21 = obj40 == null;
		object obj41 = !flag21;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return ReloadScene();
		IL_0445:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v1+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X22_v2+588]");
			object obj42 = (nint)0 & (nint)1;
			if (obj42 != null)
			{
				goto IL_049d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X22_v2+588]");
			object obj43 = (nint)0 & (nint)1;
			bool flag22 = obj43 == null;
			object obj44 = !flag22;
			if (obj44 != null)
			{
				goto IL_049d;
			}
		}
		_ = 1;
		object obj45 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v64+E4]");
		bool flag23 = (nint)0 == 0;
		object obj46 = !flag23;
		object obj47 = obj45;
		if (obj46 != null)
		{
			goto IL_04d2;
		}
		goto IL_0604;
		IL_0bb7:
		_ = 1;
		obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v43+E4]");
		bool flag24 = (nint)0 == 0;
		object obj48 = !flag24;
		num = num2;
		object obj50;
		object obj49 = obj50;
		object obj51 = obj37;
		if (obj48 != null)
		{
			goto IL_088a;
		}
		goto IL_0c0d;
		IL_07e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v43+B8]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v41+18]");
		obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458A]");
		object obj53 = (nint)0 & (nint)1;
		bool flag25 = obj53 == null;
		num2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v41+18]");
		obj50 = 0;
		if (!flag25)
		{
			goto IL_084d;
		}
		goto IL_0bb7;
		IL_0b2f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v43+B8]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v15+18]");
		obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458A]");
		object obj55 = (nint)0 & (nint)1;
		bool flag26 = obj55 == null;
		object obj56 = !flag26;
		num = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v15+18]");
		obj50 = 0;
		if (obj56 != null)
		{
			goto IL_084d;
		}
		goto IL_0bb7;
		IL_049d:
		obj45 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v64+E4]");
		bool flag27 = (nint)0 == 0;
		obj47 = obj45;
		if (!flag27)
		{
			goto IL_04d2;
		}
		goto IL_0604;
		IL_0604:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj45 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v64+B8]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v64+E4]");
		obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v55+18]");
		bool flag28 = (nint)0 == (nint)scene;
		object obj58 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v64+E4]");
		object obj59 = 0;
		if (flag28)
		{
			goto IL_0531;
		}
		goto IL_0672;
		IL_04d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v64+B8]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v64+E4]");
		obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v64+18]");
		bool flag29 = (nint)0 != (nint)scene;
		obj58 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v64+E4]");
		obj59 = 0;
		if (!flag29)
		{
			goto IL_0531;
		}
		goto IL_0672;
		IL_0672:
		if (obj59 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X22_v2+588]");
			object obj61 = (nint)0 & (nint)1;
			if (obj61 != null)
			{
				goto IL_06c2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X22_v2+588]");
			object obj62 = (nint)0 & (nint)1;
			bool flag30 = obj62 == null;
			object obj63 = !flag30;
			if (obj63 != null)
			{
				goto IL_06c2;
			}
		}
		_ = 1;
		obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v26+E4]");
		bool flag31 = (nint)0 == 0;
		object obj64 = !flag31;
		object obj65 = obj14;
		if (obj64 != null)
		{
			goto IL_06f7;
		}
		goto IL_097d;
		IL_088a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v43+B8]");
		object obj66 = 0;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v36+8]");
		object obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v36+8]");
		bool flag32 = (nint)0 == 0;
		object obj68 = !flag32;
		if (obj68 != null)
		{
			goto IL_0c7c;
		}
		goto IL_0d0f;
		IL_0c0d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj69 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X0_v13+B8]");
		object obj70 = 0;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v9+8]");
		obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v9+8]");
		bool flag33 = (nint)0 == 0;
		num = num2;
		if (!flag33)
		{
			goto IL_0c7c;
		}
		goto IL_0d0f;
		IL_084d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v43+E4]");
		bool flag34 = (nint)0 == 0;
		num2 = num;
		obj51 = obj37;
		obj50 = obj49;
		if (!flag34)
		{
			goto IL_088a;
		}
		goto IL_0c0d;
		IL_06c2:
		obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v26+E4]");
		bool flag35 = (nint)0 == 0;
		obj65 = obj14;
		if (!flag35)
		{
			goto IL_06f7;
		}
		goto IL_097d;
	}

	private static void PushPreviousScene(Scenes sceneToBeLoaded)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0172: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00b3: Expected O, but got I
		//IL_0228: Expected O, but got I4
		//IL_01aa: Expected O, but got I
		//IL_01c8: Expected O, but got I
		//IL_01e2: Expected O, but got I4
		//IL_011e: Expected O, but got I
		//IL_0272: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D0C]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v20+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v20+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v20+B8]");
		object obj7 = 0;
		Stack<System.Int32Enum> stack = (Stack<System.Int32Enum>)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj8 = (nint)0 & (nint)1;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		Stack<System.Int32Enum> stack2 = (Stack<System.Int32Enum>)obj7;
		if (obj9 != null)
		{
			goto IL_00d8;
		}
		goto IL_01f8;
		IL_010d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v20+B8]");
		object obj10 = 0;
		Stack<System.Int32Enum> stack3 = stack;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X9_v1+18]");
		stack3.Push((System.Int32Enum)0);
		TrimPreviousScenesCircularStack(sceneToBeLoaded);
		return;
		IL_0246:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		bool flag4 = stack2 == null;
		object obj11 = !flag4;
		stack = stack2;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_010d;
		IL_00d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v20+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = obj4;
		stack2 = stack;
		if (!flag5)
		{
			goto IL_010d;
		}
		goto IL_0246;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v20+B8]");
		object obj13 = 0;
		stack = (Stack<System.Int32Enum>)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj14 = (nint)0 & (nint)1;
		bool flag6 = obj14 == null;
		stack2 = (Stack<System.Int32Enum>)obj13;
		if (!flag6)
		{
			goto IL_00d8;
		}
		goto IL_01f8;
		IL_01f8:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v20+E4]");
		bool flag7 = (nint)0 == 0;
		object obj15 = !flag7;
		stack = stack2;
		obj12 = obj4;
		if (obj15 != null)
		{
			goto IL_010d;
		}
		goto IL_0246;
	}

	private static void TrimPreviousScenesCircularStack(Scenes sceneToBeLoaded)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_0142: Expected O, but got I
		//IL_0129: Expected O, but got I
		//IL_0178: Expected O, but got I
		//IL_0217: Expected O, but got I4
		//IL_01e8: Expected O, but got I
		//IL_01a4: Expected I4, but got O
		object obj = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D0D]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v27+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v27+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v15+B8]");
		object obj7 = 0;
		Stack<System.Int32Enum> stack = (Stack<System.Int32Enum>)obj7;
		goto IL_0136;
		IL_0136:
		object obj8 = (nint)0 + (nint)856;
		if (!stack.Contains((System.Int32Enum)sceneToBeLoaded))
		{
			return;
		}
		object obj9 = (nint)0 + (nint)872;
		System.Int32Enum int32Enum = (System.Int32Enum)sceneToBeLoaded;
		System.Int32Enum int32Enum2;
		do
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v8+B8]");
			object obj12 = 0;
			int32Enum = (System.Int32Enum)obj9;
			int32Enum2 = ((Stack<System.Int32Enum>)obj12).Pop();
		}
		while (int32Enum2 != (System.Int32Enum)sceneToBeLoaded);
		return;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v27+B8]");
		object obj13 = 0;
		stack = (Stack<System.Int32Enum>)obj13;
		bool flag4 = obj13 == null;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0136;
	}

	private static void LogScreen(Scenes scene)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_007b: Expected O, but got I4
		//IL_0091: Expected O, but got I4
		//IL_009a: Expected O, but got I4
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_01bc: Expected O, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I4
		//IL_0131: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0179: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 2968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		string text = friendlyName.Substring(3);
		object obj2 = scene - 3;
		bool flag = (nint)obj2 < 1;
		object obj3 = !flag;
		object obj4 = obj2 - 1;
		bool flag2 = obj4 == null;
		object obj5 = !flag2;
		object obj6 = obj3 & obj5;
		object obj7 = 0;
		string text2 = (string)3;
		if (obj6 == null)
		{
			object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SFSConfig currentSFS = Config.CurrentSFS;
			bool flag4 = !currentSFS.<IsFastTrack>k__BackingField;
			obj7 = 0;
			text2 = (string)3;
			if (!flag4)
			{
				object obj11 = "[{0}]:{1}" + 3240;
				text2 = (string)obj11;
				text += (string)obj11;
				obj7 = 0;
			}
		}
		object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.Screen(text);
	}

	public void Back()
	{
		//IL_034a: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0031: Expected O, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0051: Expected O, but got I
		//IL_03fe: Expected O, but got I4
		//IL_0368: Expected O, but got I
		//IL_0379: Expected O, but got I
		//IL_0097: Expected O, but got I4
		//IL_03aa: Expected O, but got I
		//IL_03ba: Expected O, but got I
		//IL_0103: Expected O, but got I
		//IL_011d: Expected O, but got I4
		//IL_0240: Expected O, but got I
		//IL_015d: Expected O, but got I4
		//IL_025d: Expected O, but got I4
		//IL_0262: Expected I, but got O
		//IL_026b: Expected O, but got I4
		//IL_01eb: Expected O, but got I
		//IL_01ff: Expected I, but got O
		//IL_0208: Expected O, but got I4
		//IL_03cf: Expected O, but got I
		//IL_019f: Expected O, but got I
		//IL_028a: Expected O, but got I
		//IL_029e: Expected I, but got O
		//IL_021f: Expected O, but got I4
		//IL_02c5: Expected O, but got I
		bool flag = !<BackButtonBlocked>k__BackingField;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		object obj2 = typeof(RegisteredWaitHandle) + 3136;
		object obj3 = (nint)0 + (nint)2424;
		object obj4 = (nint)0 + (nint)96;
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj6 = (nint)0 + (nint)80;
		while (true)
		{
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v5+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v7+8]");
			if (!Enumerable.Any((IEnumerable<object>)0))
			{
				break;
			}
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v11+B8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v11+8]");
			List<object> list = (List<object>)0;
			int num = list._size - 1;
			object obj13 = obj4;
			object obj14 = list.get_Item(num);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v15 (System.Object)+20]");
			object obj15 = (nint)0 & (nint)1;
			bool flag4 = obj15 == null;
			object obj16 = !flag4;
			int num2 = num;
			if (obj16 == null)
			{
				object obj17 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v28+E4]");
				bool flag5 = (nint)0 == 0;
				object obj18 = !flag5;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj17 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v28+B8]");
				object obj19 = 0;
				obj13 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v18+8]");
				((List<object>)0).RemoveAt(num);
				num2 = num;
			}
			object obj20 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v16+E4]");
			object obj22;
			nint num3;
			object obj21;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v15 (System.Object)+10]");
				bool flag6 = (UnityEngine.Object)0 != null;
				bool flag7 = !flag6;
				num3 = unchecked((nint)null);
				obj21 = 0;
				if (flag7)
				{
					continue;
				}
				obj22 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v15 (System.Object)+10]");
				bool flag8 = (UnityEngine.Object)0 != null;
				bool flag9 = !flag8;
				obj22 = 0;
				num3 = unchecked((nint)null);
				obj21 = 0;
				if (flag9)
				{
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v15 (System.Object)+10]");
			bool activeInHierarchy = ((GameObject)0).activeInHierarchy;
			bool flag10 = !activeInHierarchy;
			num3 = unchecked((nint)null);
			obj21 = obj22;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v15 (System.Object)+18]");
				Actions.SafeInvoke((Action)0);
				return;
			}
		}
		if (!<LoadingPreviousSceneBlocked>k__BackingField)
		{
			object obj23 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				LoadPreviousScene();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			LoadPreviousScene();
		}
	}

	public static void AllowBackAction()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_00e3: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_012c: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(Queue<string>) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D10]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2184;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2184;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = default(object);
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		_ = 0;
	}

	public static void PreventBackAction()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_00e3: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_012c: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(Queue<string>) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D11]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2184;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2184;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = default(object);
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		_ = 1;
	}

	public static void PreventLoadingPreviousScene()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_00e3: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_012c: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(Queue<string>) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D12]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2184;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2184;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = default(object);
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		_ = 1;
	}

	public static void LoadPreviousScene()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_0129: Expected O, but got I
		//IL_01d6: Expected O, but got I
		//IL_01ec: Expected O, but got I
		//IL_0206: Expected O, but got I4
		//IL_0196: Expected O, but got I
		//IL_0236: Expected O, but got I4
		//IL_0277: Expected O, but got I
		//IL_034b: Expected O, but got I4
		//IL_0266: Expected O, but got I
		//IL_0624: Expected O, but got I
		//IL_02d6: Expected O, but got I4
		//IL_037c: Expected O, but got I
		//IL_039f: Expected O, but got I
		//IL_060f: Expected O, but got I
		//IL_04f5: Expected O, but got I4
		//IL_0307: Expected O, but got I
		//IL_0401: Expected O, but got I
		//IL_0411: Expected O, but got I
		//IL_0427: Expected O, but got I
		//IL_0446: Expected O, but got I
		//IL_05bb: Expected O, but got I4
		//IL_052d: Expected O, but got I
		//IL_053d: Expected O, but got I
		//IL_0553: Expected O, but got I
		//IL_056d: Expected O, but got I4
		//IL_057d: Expected O, but got I
		//IL_0499: Expected O, but got I
		//IL_064b: Expected O, but got I4
		//IL_0669: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DFB]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		if (obj2 != null)
		{
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v5+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v5+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v5+B8]");
		object obj6 = 0;
		object obj7 = obj6;
		goto IL_0136;
		IL_058b:
		_ = 1;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v30+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj11;
		object obj10 = obj11;
		object obj12 = obj8;
		if (obj9 != null)
		{
			goto IL_0489;
		}
		goto IL_05d9;
		IL_03f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v30+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v33+18]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458A]");
		object obj14 = (nint)0 & (nint)1;
		bool flag4 = obj14 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v33+18]");
		obj11 = 0;
		if (!flag4)
		{
			goto IL_0454;
		}
		goto IL_058b;
		IL_05d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj8 = obj;
		obj10 = obj11;
		goto IL_0489;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v5+B8]");
		obj6 = 0;
		obj7 = obj6;
		bool flag5 = obj6 == null;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0136;
		IL_0136:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X9_v2+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6+10]");
			object obj16 = (nint)0 & (nint)1;
			if (obj16 != null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v5+B8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6+10]");
			object obj17 = (nint)0 & (nint)1;
			bool flag6 = obj17 == null;
			object obj18 = !flag6;
			if (obj18 != null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v5+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v40+B8]");
			obj6 = 0;
		}
		object obj21 = (nint)0 + (nint)864;
		object obj22 = obj21;
		System.Int32Enum int32Enum = ((Stack<System.Int32Enum>)obj6).Peek();
		if (int32Enum == (System.Int32Enum)4)
		{
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v45+E4]");
			bool flag8 = (nint)0 == 0;
			object obj24 = !flag8;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj23 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v45+B8]");
			object obj25 = 0;
			object obj26 = (nint)0 + (nint)872;
			obj22 = obj26;
			System.Int32Enum int32Enum2 = ((Stack<System.Int32Enum>)obj25).Pop();
		}
		object obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v11+E4]");
		bool flag9 = (nint)0 == 0;
		object obj28 = !flag9;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v11+B8]");
		object obj29 = 0;
		object obj30 = (nint)0 + (nint)872;
		System.Int32Enum int32Enum3 = ((Stack<System.Int32Enum>)obj29).Pop();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DF9]");
		object obj31 = (nint)0 & (nint)1;
		if (obj31 != null)
		{
			obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v30+E4]");
			bool flag10 = (nint)0 == 0;
			object obj32 = obj8;
			if (!flag10)
			{
				goto IL_03f1;
			}
		}
		else
		{
			_ = 1;
			obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v30+E4]");
			bool flag11 = (nint)0 == 0;
			object obj33 = !flag11;
			object obj32 = obj8;
			if (obj33 != null)
			{
				goto IL_03f1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v30+B8]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v20+18]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458A]");
		object obj35 = (nint)0 & (nint)1;
		bool flag12 = obj35 == null;
		object obj36 = !flag12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v20+18]");
		obj11 = 0;
		if (obj36 != null)
		{
			goto IL_0454;
		}
		goto IL_058b;
		IL_0489:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v30+B8]");
		object obj37 = 0;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v30+E4]");
		bool flag13 = (nint)0 == 0;
		object obj38 = !flag13;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v30+B8]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v28+18]");
		string sceneName = ScenesEnumExtensions.GetName((Scenes)0);
		AsyncOperationHandle<SceneInstance> asyncOperationHandle = AnimateSceneTransition(sceneName);
		return;
		IL_0454:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v30+E4]");
		bool flag14 = (nint)0 == 0;
		obj11 = obj10;
		obj12 = obj8;
		if (!flag14)
		{
			goto IL_0489;
		}
		goto IL_05d9;
	}

	public static AsyncOperationHandle<SceneInstance> ReloadScene()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_018d: Expected O, but got I4
		//IL_013e: Expected O, but got I
		//IL_0286: Expected O, but got I
		//IL_00c5: Expected O, but got I4
		//IL_01bd: Expected O, but got I
		//IL_01d8: Expected O, but got I
		//IL_02d5: Expected O, but got I4
		//IL_022a: Expected O, but got I
		//IL_0319: Expected O, but got I
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_036c: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D13]");
		object obj2 = (nint)0 & (nint)1;
		AsyncOperationHandle<SceneInstance> asyncOperationHandle;
		if (obj2 != null)
		{
			asyncOperationHandle = (AsyncOperationHandle<SceneInstance>)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v35 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle`1<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance>)+E4]");
			bool flag = (nint)0 == 0;
			AsyncOperationHandle<SceneInstance> asyncOperationHandle2 = asyncOperationHandle;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			asyncOperationHandle = (AsyncOperationHandle<SceneInstance>)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v35 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle`1<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance>)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			AsyncOperationHandle<SceneInstance> asyncOperationHandle2 = asyncOperationHandle;
			if (obj3 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		asyncOperationHandle = (AsyncOperationHandle<SceneInstance>)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v35 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle`1<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance>)+B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v3+10]");
		bool flag3 = (nint)0 == 1;
		AsyncOperationHandle<SceneInstance> asyncOperationHandle3 = asyncOperationHandle;
		if (flag3)
		{
			goto IL_00bc;
		}
		goto IL_016b;
		IL_00bc:
		object obj5 = 0;
		_ = 0;
		_ = 0;
		return asyncOperationHandle;
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v1 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle`1<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance>)+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v14+B8]");
			obj4 = 0;
		}
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v3+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v3+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v4+1C]");
			object obj9 = (nint)0 + (nint)1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v4+18]");
			if ((nint)0 >= (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v4+10]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v4+18]");
				Array.Clear((Array)num, 0, 0);
			}
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v7+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v7+B8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v8+18]");
			string text = ScenesEnumExtensions.GetName((Scenes)0);
			object obj13 = typeof(SqlSingle[]) + 3048;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v11+E4]");
			bool flag6 = (nint)0 == 0;
			object obj15 = !flag6;
			object key = text;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				key = text;
			}
			return Addressables.LoadSceneAsync(key);
		}
		return (AsyncOperationHandle<SceneInstance>)new NullReferenceException();
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v35 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle`1<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance>)+B8]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v3+10]");
		bool flag7 = (nint)0 != 1;
		asyncOperationHandle3 = asyncOperationHandle;
		if (!flag7)
		{
			goto IL_00bc;
		}
		goto IL_016b;
	}

	private static AsyncOperationHandle<SceneInstance> AnimateSceneTransition(string sceneName)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_026e: Expected O, but got I
		//IL_02ab: Expected O, but got I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I4
		//IL_00e4: Expected O, but got I
		//IL_0112: Expected O, but got I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_018c: Expected O, but got I
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01e2: Expected I, but got O
		//IL_020c: Expected O, but got I4
		//IL_0242: Expected O, but got I
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2648;
		object obj2 = typeof(Queue<string>) + 840;
		object obj3 = (nint)0 + (nint)2184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj7 = default(object);
		if (obj7 != null)
		{
			object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj9 = typeof(SqlSingle[]) + 3048;
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v7+30]");
			bool activateOnLoad = (UnityEngine.Object)0 == null;
			object obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v14+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = Addressables.LoadSceneAsync(sceneName, LoadSceneMode.Single, activateOnLoad);
			if (obj4 != null)
			{
				object obj14 = typeof(SqlSingle[]) + 2376;
				object obj15 = (nint)0 + (nint)1560;
				object obj16 = typeof(RegisteredWaitHandle) + 3136;
				object obj17 = obj4 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Action action = default(Action);
				action..ctor(obj4, (IntPtr)obj15);
				object obj18 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v22+E4]");
				bool flag4 = (nint)0 == 0;
				object obj19 = !flag4;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AnimateTransitionOut(action);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+20]");
				_ = 0;
				return (AsyncOperationHandle<SceneInstance>)action;
			}
		}
		return (AsyncOperationHandle<SceneInstance>)new NullReferenceException();
	}

	public static void AnimateTransitionOut(Action callback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0236: Expected O, but got I
		//IL_0255: Expected O, but got I4
		//IL_025e: Expected O, but got I4
		//IL_0189: Expected O, but got I
		//IL_01a1: Expected O, but got I4
		//IL_01d9: Expected O, but got I4
		//IL_021a: Expected O, but got I
		object obj = typeof(Queue<string>) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D15]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2184;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			obj3 = (nint)0 + (nint)2184;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj3 = obj5;
		goto IL_0137;
		IL_01af:
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v14+30]");
		((SceneTransitionAnimation)0).TransitionOut(callback);
		return;
		IL_0137:
		object obj9 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+30]");
			bool flag4 = (UnityEngine.Object)0;
			bool flag5 = !flag4;
			object obj11 = 0;
			if (!flag5)
			{
				goto IL_01af;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+30]");
			bool flag6 = (UnityEngine.Object)0;
			bool flag7 = !flag6;
			object obj12 = !flag7;
			object obj11 = 0;
			if (obj12 != null)
			{
				goto IL_01af;
			}
		}
		if (callback != null)
		{
			IntPtr invoke_impl = ((Delegate)callback).invoke_impl;
			IntPtr method_code = ((Delegate)callback).method_code;
			IntPtr method = ((Delegate)callback).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v106 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
		return;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj13 = default(object);
		bool flag8 = obj13 == null;
		object obj14 = !flag8;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0137;
	}

	public static void AnimateTransitionIn(bool withSlider = true)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0236: Expected O, but got I
		//IL_0255: Expected O, but got I4
		//IL_025e: Expected O, but got I4
		//IL_0189: Expected O, but got I
		//IL_01a1: Expected O, but got I4
		//IL_01d9: Expected O, but got I4
		//IL_021a: Expected O, but got I
		object obj = typeof(Queue<string>) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D16]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2184;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			obj3 = (nint)0 + (nint)2184;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj3 = obj5;
		goto IL_0137;
		IL_0137:
		object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+30]");
			bool flag3 = (UnityEngine.Object)0;
			bool flag4 = !flag3;
			object obj9 = 0;
			if (flag4)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+30]");
			bool flag5 = (UnityEngine.Object)0;
			bool flag6 = !flag5;
			object obj10 = !flag6;
			object obj9 = 0;
			if (obj10 == null)
			{
				return;
			}
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v10+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v13+30]");
		((SceneTransitionAnimation)0).TransitionIn(withSlider);
		return;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj13 = default(object);
		bool flag8 = obj13 == null;
		object obj14 = !flag8;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0137;
	}

	private unsafe static void ActivateSceneOnCorrectRoom(AsyncOperationHandle<SceneInstance> loadingOperation)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_00dd: Expected O, but got I4
		//IL_00fa: Expected O, but got I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_01c3: Expected O, but got I4
		//IL_01ec: Expected O, but got I
		//IL_021e: Expected O, but got I4
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_026a: Expected O, but got I4
		//IL_0293: Expected O, but got I
		//IL_02b3: Expected O, but got I
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02e2: Expected O, but got I
		//IL_02f3: Expected I, but got O
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_033f: Expected O, but got I
		//IL_0350: Expected I, but got O
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_037f: Expected O, but got I
		//IL_0390: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [loadingOperation @ X0 (UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle`1<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance>)+10]");
		_ = 0;
		object obj3 = obj2 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncOperationHandle<SceneInstance> asyncOperationHandle = (AsyncOperationHandle<SceneInstance>)(obj2 + 16);
		SceneInstance result = ((AsyncOperationHandle<SceneInstance>*)asyncOperationHandle)->Result;
		Scenes? sceneEnum = ScenesEnumExtensions.GetSceneEnum((Scene)result);
		object obj4 = (??)sceneEnum & 1;
		if (obj4 != null)
		{
			object obj5 = (nint)0 + (nint)24;
			System.Int32Enum? int32Enum = default(System.Int32Enum?);
			System.Int32Enum value = int32Enum.Value;
			bool flag = value < (System.Int32Enum)15;
			object obj6 = !flag;
			object obj7 = value - 15;
			bool flag2 = obj7 == null;
			object obj8 = 1 << (int)value;
			object obj9 = obj8 & 0xE016;
			object obj10 = ~obj6;
			object obj11 = obj10 | flag2;
			object obj12 = ~obj11;
			if (obj12 != null || obj9 == null)
			{
				object obj13 = typeof(Queue<string>) + 848;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v19+E4]");
				bool flag3 = (nint)0 == 0;
				object obj15 = !flag3;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj16 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				bool isInLobby = sessionModel.IsInLobby;
				bool flag4 = !isInLobby;
				object obj17 = !flag4;
				if (obj17 == null)
				{
					object obj18 = typeof(Queue<string>) + 840;
					object obj19 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v24+E4]");
					bool flag5 = (nint)0 == 0;
					object obj20 = !flag5;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj21 = (nint)0 + (nint)2184;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v27+28]");
					Actions.SafeInvoke((Action)0);
					object obj22 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj23 = (nint)0 + (nint)1584;
					Action<object> action = default(Action<object>);
					action..ctor(obj2, (IntPtr)obj23);
					SFS.OnJoinRoom += action;
					SFS.JoinLobby();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					object obj24 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj25 = (nint)0 + (nint)1568;
					Func<bool> func = default(Func<bool>);
					func..ctor(obj2, (IntPtr)obj25);
					object obj26 = typeof(SqlSingle[]) + 2376;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj27 = (nint)0 + (nint)1576;
					Action action2 = default(Action);
					action2..ctor(obj2, (IntPtr)obj27);
					MonoBehaviour comp = default(MonoBehaviour);
					Coroutine coroutine = UIExtensions.SetTimeout(comp, 5f, func, action2);
					return;
				}
			}
		}
		AsyncOperationHandle<SceneInstance> asyncOperationHandle2 = (AsyncOperationHandle<SceneInstance>)(obj2 + 16);
		SceneInstance result2 = ((AsyncOperationHandle<SceneInstance>*)asyncOperationHandle2)->Result;
		SceneInstance sceneInstance = default(SceneInstance);
		AsyncOperation asyncOperation = sceneInstance.ActivateAsync();
	}

	public static void WaitForScene(Scenes targetScene, Action action)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00fc: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00a2: Expected O, but got I
		//IL_0134: Expected O, but got I
		//IL_014a: Expected O, but got I
		//IL_0164: Expected O, but got I4
		//IL_02ac: Expected O, but got I
		//IL_02c6: Expected O, but got I4
		//IL_01b5: Expected O, but got I
		//IL_033c: Expected O, but got I
		//IL_0304: Expected O, but got I4
		//IL_0217: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D18]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		if (obj2 != null)
		{
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v5+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v5+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v5+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v21+10]");
		object obj7 = (nint)0 & (nint)1;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		object obj9 = obj3;
		if (obj8 == null)
		{
			goto IL_017a;
		}
		goto IL_0360;
		IL_02d4:
		_ = 1;
		obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		object obj11 = obj9;
		if (obj10 != null)
		{
			goto IL_0207;
		}
		goto IL_031a;
		IL_028c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj12 = (nint)0 & (nint)1;
		bool flag5 = obj12 == null;
		object obj13 = !flag5;
		if (obj13 != null)
		{
			goto IL_01d2;
		}
		goto IL_02d4;
		IL_0360:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v1+E4]");
		if ((nint)0 != 0)
		{
			WaitForSceneExclusively(targetScene, action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		WaitForSceneExclusively(targetScene, action);
		return;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v5+B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v26+10]");
		object obj15 = (nint)0 & (nint)1;
		if (obj15 == null)
		{
			goto IL_017a;
		}
		obj9 = obj3;
		goto IL_0360;
		IL_017a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v5+E4]");
		if ((nint)0 == 0)
		{
			goto IL_028c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj16 = (nint)0 & (nint)1;
		if (obj16 != null)
		{
			goto IL_01d2;
		}
		goto IL_02d4;
		IL_031a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v1+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v7+18]");
		if ((nint)targetScene == (nint)0)
		{
			goto IL_023e;
		}
		goto IL_0360;
		IL_01d2:
		obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v1+E4]");
		bool flag6 = (nint)0 == 0;
		obj11 = obj9;
		if (!flag6)
		{
			goto IL_0207;
		}
		goto IL_031a;
		IL_0207:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v1+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v15+18]");
		if ((nint)targetScene == (nint)0)
		{
			goto IL_023e;
		}
		goto IL_0360;
		IL_023e:
		if (action != null)
		{
			IntPtr invoke_impl = ((Delegate)action).invoke_impl;
			IntPtr method_code = ((Delegate)action).method_code;
			IntPtr method = ((Delegate)action).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v178 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
			goto IL_028c;
		}
	}

	public static void WaitForSceneExclusively(Scenes targetScene, Action action)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0092: Expected I, but got O
		//IL_00bc: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(TypeConverter<ushort, char>) + 528;
		object obj4 = (nint)0 + (nint)1592;
		object obj5 = typeof(RegisteredWaitHandle) + 2944;
		object obj6 = obj2 + 24;
		obj6 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
		unityAction..ctor(obj2, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
	}

	public static void PushPopup(GameObject popup, Action closeAction, bool persistent = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_015d: Expected O, but got I4
		//IL_017b: Expected O, but got I
		//IL_018b: Expected O, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_00ae: Expected O, but got I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 3136;
		object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2680;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+8]");
		List<object> list = (List<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = default(object);
		obj6..ctor();
		object obj7 = obj6 + 16;
		obj7 = popup;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj6 + 24;
		obj8 = closeAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag2 = list._size < items.Length;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj10 = items + list._size;
			object obj11 = obj10 + 32;
			obj11 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize(obj6);
		}
	}

	public static void RemovePopup(GameObject go)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0097: Expected O, but got I4
		//IL_00ff: Expected O, but got I
		//IL_011a: Expected I, but got O
		//IL_00d2: Expected O, but got I
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(RegisteredWaitHandle) + 3136;
		object obj4 = typeof(List<Tween>) + 3760;
		object obj5 = (nint)0 + (nint)1600;
		object obj6 = obj2 + 16;
		obj6 = go;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v10+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj2, (IntPtr)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v5+8]");
		int num = ((List<object>)0).RemoveAll(predicate);
	}

	public ScreenManager()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(Queue<string>) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D1C]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2176;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2176;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}

	static ScreenManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0079: Expected O, but got I
		//IL_00a3: Expected O, but got I
		object obj = typeof(Queue<string>) + 1192;
		object obj2 = typeof(RegisteredWaitHandle) + 3136;
		object obj3 = typeof(List<Tween>) + 1248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Stack<System.Int32Enum> stack = default(Stack<System.Int32Enum>);
		stack..ctor();
		object obj4 = obj2;
		object obj5 = stack;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+B8]");
		object obj7 = (nint)0 + (nint)8;
		obj7 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v5+B8]");
		object obj9 = 0;
		_ = 1;
	}
}
