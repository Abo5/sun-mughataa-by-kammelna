using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class CoroutineDummy : MonoBehaviour
{
	public class MainThreadCallBack
	{
		public Action callBack;

		public float seconds;
	}

	private sealed class <WaitForFramesInternal>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public int frameCount;

		public Action callback;

		private int <i>5__2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <WaitForFramesInternal>d__20(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_007f: Expected I4, but got I8
			//IL_0043: Expected O, but got I4
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected O, but got Unknown
			//IL_00b2: Expected O, but got I4
			//IL_0060: Expected I4, but got I8
			int num = <>1__state;
			if (<>1__state != 1)
			{
				bool flag = num == 0;
				object obj = !flag;
				if (obj != null)
				{
					return false;
				}
				<>1__state = -1;
				<i>5__2 = 0;
			}
			else
			{
				<>1__state = -1;
				num = ++<i>5__2;
			}
			if (num < frameCount)
			{
				object obj2 = this + 24;
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 1;
				return true;
			}
			Actions.SafeInvoke(callback);
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)3736;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private sealed class <WaitForSecondsRealTimeInternal>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public float seconds;

		public Action callback;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <WaitForSecondsRealTimeInternal>d__18(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0055: Expected I4, but got I8
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_0036: Expected I4, but got I8
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					<>1__state = -1;
					Actions.SafeInvoke(callback);
				}
			}
			else
			{
				<>1__state = -1;
				object obj = typeof(UsageHint) + 1648;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				WaitForSecondsRealtime waitForSecondsRealtime = default(WaitForSecondsRealtime);
				waitForSecondsRealtime..ctor(seconds);
				object obj2 = this + 24;
				obj2 = waitForSecondsRealtime;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				<>1__state = 1;
			}
			return <>1__state == 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)3744;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private sealed class <_WaitForEndOfFrame>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public Action callback;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <_WaitForEndOfFrame>d__19(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_006b: Expected I4, but got I8
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			//IL_0036: Expected I4, but got I8
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					<>1__state = -1;
					Actions.SafeInvoke(callback);
				}
				return <>1__state == 0;
			}
			<>1__state = -1;
			object obj = typeof(UsageHint) + 1632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			WaitForEndOfFrame waitForEndOfFrame = default(WaitForEndOfFrame);
			waitForEndOfFrame..ctor();
			object obj2 = this + 24;
			obj2 = waitForEndOfFrame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<>1__state = 1;
			return <>1__state == 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)3752;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private sealed class <_WaitForPermission>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public UserAuthorization permission;

		public Action<bool> callback;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <_WaitForPermission>d__21(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00da: Expected I4, but got I8
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected O, but got Unknown
			//IL_0118: Expected O, but got I4
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected O, but got Unknown
			//IL_0036: Expected I4, but got I8
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			//IL_0074: Expected O, but got I4
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					<>1__state = -1;
					object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v12+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool arg = Application.HasUserAuthorization(permission);
					Actions.SafeInvoke(callback, arg);
				}
				return <>1__state == 0;
			}
			<>1__state = -1;
			object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncOperation asyncOperation = Application.RequestUserAuthorization(permission);
			object obj7 = this + 24;
			obj7 = asyncOperation;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			return <>1__state == 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)3760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private sealed class <_WaitForSeconds>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public float seconds;

		public Action callback;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <_WaitForSeconds>d__17(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0055: Expected I4, but got I8
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_0036: Expected I4, but got I8
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					<>1__state = -1;
					Actions.SafeInvoke(callback);
				}
			}
			else
			{
				<>1__state = -1;
				object obj = typeof(UsageHint) + 1640;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				WaitForSeconds waitForSeconds = default(WaitForSeconds);
				waitForSeconds..ctor(seconds);
				object obj2 = this + 24;
				obj2 = waitForSeconds;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				<>1__state = 1;
			}
			return <>1__state == 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)3768;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private static readonly ConcurrentQueue<MainThreadCallBack> mainThreadCallBacks;

	private static CoroutineDummy _instance;

	private static CoroutineDummy _permanentInstance;

	public static CoroutineDummy Instance
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected O, but got Unknown
			//IL_01cd: Expected O, but got I4
			//IL_00b1: Expected O, but got I
			//IL_00c1: Expected O, but got I
			//IL_00f0: Expected O, but got I
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_020d: Expected O, but got I
			//IL_021d: Expected O, but got I
			//IL_0247: Expected O, but got I4
			//IL_0257: Expected O, but got I
			//IL_029b: Expected O, but got I4
			//IL_02a4: Expected O, but got I4
			//IL_02ad: Expected O, but got I4
			//IL_0123: Expected O, but got I4
			//IL_012c: Expected O, but got I4
			//IL_0164: Expected O, but got I4
			//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cf: Expected O, but got Unknown
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02de: Expected O, but got Unknown
			//IL_039a: Expected O, but got I
			//IL_03a7: Expected O, but got I
			//IL_0323: Expected O, but got I
			//IL_0357: Expected O, but got I4
			//IL_03bd: Expected O, but got I
			object obj = 152981504;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D6C]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v48+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_00a1;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v48+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_00a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v21+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v10+8]");
			UnityEngine.Object obj11 = (UnityEngine.Object)0;
			object obj12 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v15+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v10+8]");
			UnityEngine.Object obj14 = (UnityEngine.Object)0;
			if (obj13 != null)
			{
				goto IL_00fe;
			}
			goto IL_0265;
			IL_013a:
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v41+E4]");
			bool flag4 = (nint)0 == 0;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v41+B8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v16+8]");
			return (CoroutineDummy)0;
			IL_02bb:
			object obj18 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2096;
			object obj19 = "Complete" + 1712;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			GameObject gameObject = default(GameObject);
			gameObject..ctor((string)obj19);
			if ((object)gameObject != null)
			{
				object obj20 = (nint)0 + (nint)640;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
				object obj21 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v8+E4]");
				bool flag5 = (nint)0 == 0;
				object obj22 = !flag5;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj21 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v8+B8]");
				object obj23 = (nint)0 + (nint)8;
				CoroutineDummy coroutineDummy = default(CoroutineDummy);
				obj23 = coroutineDummy;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return coroutineDummy;
			}
			return (CoroutineDummy)(object)new NullReferenceException();
			IL_00fe:
			bool flag6 = obj11;
			bool flag7 = !flag6;
			object obj24 = 0;
			object obj25 = 0;
			if (!flag7)
			{
				goto IL_013a;
			}
			goto IL_02bb;
			IL_00a1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v48+B8]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v19+8]");
			obj11 = (UnityEngine.Object)0;
			obj12 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v15+E4]");
			bool flag8 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v19+8]");
			obj14 = (UnityEngine.Object)0;
			if (!flag8)
			{
				goto IL_00fe;
			}
			goto IL_0265;
			IL_0265:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag9 = obj14;
			bool flag10 = !flag9;
			object obj27 = !flag10;
			obj24 = 0;
			obj25 = 0;
			if (obj27 != null)
			{
				goto IL_013a;
			}
			goto IL_02bb;
		}
	}

	public static CoroutineDummy PermanentInstance
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected O, but got Unknown
			//IL_01d1: Expected O, but got I4
			//IL_00b1: Expected O, but got I
			//IL_00c1: Expected O, but got I
			//IL_00f8: Expected O, but got I
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0211: Expected O, but got I
			//IL_0221: Expected O, but got I
			//IL_024b: Expected O, but got I4
			//IL_0263: Expected O, but got I
			//IL_02a3: Expected O, but got I4
			//IL_02ac: Expected O, but got I4
			//IL_02b5: Expected O, but got I4
			//IL_0127: Expected O, but got I4
			//IL_0130: Expected O, but got I4
			//IL_0168: Expected O, but got I4
			//IL_02da: Unknown result type (might be due to invalid IL or missing references)
			//IL_02df: Expected O, but got Unknown
			//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ee: Expected O, but got Unknown
			//IL_03fa: Expected O, but got I
			//IL_0407: Expected O, but got I
			//IL_0334: Expected O, but got I4
			//IL_0383: Expected O, but got I
			//IL_03b7: Expected O, but got I4
			//IL_041d: Expected O, but got I
			object obj = 152981504;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D6D]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v52+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_00a1;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v52+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_00a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v25+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v11+10]");
			UnityEngine.Object obj11 = (UnityEngine.Object)0;
			object obj12 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			obj4 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v11+10]");
			UnityEngine.Object obj14 = (UnityEngine.Object)0;
			if (obj13 != null)
			{
				goto IL_0106;
			}
			goto IL_0271;
			IL_013e:
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v45+E4]");
			bool flag4 = (nint)0 == 0;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v45+B8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v17+10]");
			return (CoroutineDummy)0;
			IL_02cb:
			object obj18 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2096;
			object obj19 = "October" + 3784;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			GameObject gameObject = default(GameObject);
			gameObject..ctor((string)obj19);
			object obj20 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v4+E4]");
			bool flag5 = (nint)0 == 0;
			object obj21 = !flag5;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			if ((object)gameObject != null)
			{
				object obj22 = (nint)0 + (nint)640;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
				object obj23 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v11+E4]");
				bool flag6 = (nint)0 == 0;
				object obj24 = !flag6;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj23 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v11+B8]");
				object obj25 = (nint)0 + (nint)16;
				CoroutineDummy coroutineDummy = default(CoroutineDummy);
				obj25 = coroutineDummy;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return coroutineDummy;
			}
			return (CoroutineDummy)(object)new NullReferenceException();
			IL_0106:
			bool flag7 = obj11;
			bool flag8 = !flag7;
			object obj26 = 0;
			object obj27 = 0;
			if (!flag8)
			{
				goto IL_013e;
			}
			goto IL_02cb;
			IL_00a1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v52+B8]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v20+10]");
			obj11 = (UnityEngine.Object)0;
			obj12 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v19+E4]");
			bool flag9 = (nint)0 == 0;
			obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v20+10]");
			obj14 = (UnityEngine.Object)0;
			if (!flag9)
			{
				goto IL_0106;
			}
			goto IL_0271;
			IL_0271:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag10 = obj14;
			bool flag11 = !flag10;
			object obj29 = !flag11;
			obj26 = 0;
			obj27 = 0;
			obj4 = obj7;
			if (obj29 != null)
			{
				goto IL_013e;
			}
			goto IL_02cb;
		}
	}

	private unsafe void Update()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_015a: Expected O, but got I
		//IL_0129: Expected O, but got I
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_035e: Expected O, but got I4
		//IL_024f: Expected O, but got I4
		//IL_028f: Expected O, but got I4
		//IL_02be: Expected O, but got I4
		//IL_0389: Expected O, but got I
		//IL_0389: Expected F4, but got I
		//IL_0231: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E07]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v40+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v40+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v31+B8]");
		object obj7 = 0;
		ConcurrentQueue<object> concurrentQueue = (ConcurrentQueue<object>)obj7;
		if (obj7 != null)
		{
			goto IL_014e;
		}
		goto IL_02cb;
		IL_02cb:
		throw new NullReferenceException();
		IL_014e:
		object obj8 = (nint)0 + (nint)3216;
		object obj9 = obj8;
		if (!concurrentQueue.TryDequeue(out var result))
		{
			return;
		}
		bool flag3 = result == null;
		nint num = (nint)(&result);
		if (!flag3)
		{
			object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			object obj13 = default(object);
			object obj14;
			if ((nint)obj13 < 981668463)
			{
				if (result != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ stack_-48_v4 (System.Object)+10]");
					Actions.SafeInvoke((Action)0);
					return;
				}
				NullReferenceException ex = new NullReferenceException();
				obj14 = 981668463;
				nint num2 = (nint)(&result);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return;
			}
			bool flag5 = result == null;
			obj14 = 981668463;
			num = (nint)(&result);
			if (!flag5)
			{
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v14+E4]");
				bool flag6 = (nint)0 == 0;
				object obj16 = !flag6;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ stack_-48_v4 (System.Object)+18]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ stack_-48_v4 (System.Object)+10]");
				Coroutine coroutine = WaitForSecondsPermanently(num3, (Action)0);
				return;
			}
		}
		goto IL_02cb;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v40+B8]");
		object obj17 = 0;
		concurrentQueue = (ConcurrentQueue<object>)obj17;
		bool flag7 = obj17 == null;
		object obj18 = !flag7;
		if (obj18 != null)
		{
			goto IL_014e;
		}
		goto IL_02cb;
	}

	public static void WaitForMainThread(Action callback)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E08]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		WaitForMainThread(0f, callback);
		return;
		IL_007d:
		WaitForMainThread(0f, callback);
	}

	public static void WaitForMainThread(float seconds, Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I4
		//IL_00c5: Expected O, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj2 = typeof(CardUtils.<>c) + 2744;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = default(object);
		obj6..ctor();
		object obj7 = obj6 + 16;
		obj7 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((ConcurrentQueue<object>)obj5).Enqueue(obj6);
	}

	public static Coroutine WaitForSeconds(float seconds, Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy instance = Instance;
		object obj4 = typeof(CardUtils.<>c) + 2736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = default(object);
		obj5..ctor();
		_ = 0;
		object obj6 = obj5 + 40;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if ((object)instance != null)
		{
			return instance.StartCoroutine((IEnumerator)obj5);
		}
		return (Coroutine)(object)new NullReferenceException();
	}

	public static Coroutine WaitForSecondsPermanently(float seconds, Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy permanentInstance = PermanentInstance;
		object obj4 = typeof(CardUtils.<>c) + 2736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = default(object);
		obj5..ctor();
		_ = 0;
		object obj6 = obj5 + 40;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if ((object)permanentInstance != null)
		{
			return permanentInstance.StartCoroutine((IEnumerator)obj5);
		}
		return (Coroutine)(object)new NullReferenceException();
	}

	public static Coroutine WaitForSecondsRealtime(float seconds, Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy instance = Instance;
		object obj4 = typeof(CardUtils.<>c) + 2712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = default(object);
		obj5..ctor();
		_ = 0;
		object obj6 = obj5 + 40;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if ((object)instance != null)
		{
			return instance.StartCoroutine((IEnumerator)obj5);
		}
		return (Coroutine)(object)new NullReferenceException();
	}

	public static Coroutine WaitForPermission(UserAuthorization permission, Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy permanentInstance = PermanentInstance;
		object obj4 = typeof(CardUtils.<>c) + 2728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = default(object);
		obj5..ctor();
		_ = 0;
		object obj6 = obj5 + 40;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if ((object)permanentInstance != null)
		{
			return permanentInstance.StartCoroutine((IEnumerator)obj5);
		}
		return (Coroutine)(object)new NullReferenceException();
	}

	public static void WaitForEndOfFrame(Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0086: Expected O, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy instance = Instance;
		object obj4 = typeof(CardUtils.<>c) + 2720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = default(object);
		obj5..ctor();
		_ = 0;
		object obj6 = obj5 + 32;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = instance.StartCoroutine((IEnumerator)obj5);
	}

	public static void WaitForFrames(int frameCount, Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0086: Expected O, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy instance = Instance;
		object obj4 = typeof(CardUtils.<>c) + 2704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = default(object);
		obj5..ctor();
		_ = 0;
		object obj6 = obj5 + 40;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = instance.StartCoroutine((IEnumerator)obj5);
	}

	private static IEnumerator _WaitForSeconds(float seconds, Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 2736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 40;
		obj3 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private static IEnumerator WaitForSecondsRealTimeInternal(float seconds, Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 2712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 40;
		obj3 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private static IEnumerator _WaitForEndOfFrame(Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 2720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private static IEnumerator WaitForFramesInternal(int frameCount, Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 2704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 40;
		obj3 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private static IEnumerator _WaitForPermission(UserAuthorization permission, Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 2728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 40;
		obj3 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	public static void StopInstanceCoroutine(Coroutine target)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		if (target != null)
		{
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CoroutineDummy instance = Instance;
			instance.StopCoroutine(target);
		}
	}

	public static void StopPermanentCoroutine(Coroutine target)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		if (target != null)
		{
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CoroutineDummy permanentInstance = PermanentInstance;
			permanentInstance.StopCoroutine(target);
		}
	}

	static CoroutineDummy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3784;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ConcurrentQueue<object> concurrentQueue = default(ConcurrentQueue<object>);
		concurrentQueue..ctor();
		object obj3 = obj2;
		object obj4 = concurrentQueue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
