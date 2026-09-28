using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using KammelnaOffline;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.UI;

public class ServerFetcher : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<TutorialOnboarding> <>9__21_0;

		public static Func<bool> <>9__29_0;

		public static Func<bool> <>9__29_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2960;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <LoadPopup>b__21_0(TutorialOnboarding onBoarding)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_0079: Expected I, but got O
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2968;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = typeof(SqlSingle[]) + 2376;
			object obj4 = (nint)0 + (nint)1808;
			object obj5 = obj2 + 16;
			obj5 = onBoarding;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj4);
			SplashAnimation.Interrupt(action);
		}

		internal bool <GoToLogin>b__29_0()
		{
			return SplashAnimation.IsDone;
		}

		internal bool <GoToLogin>b__29_1()
		{
			return SplashAnimation.IsPlaying;
		}
	}

	private sealed class <>c__DisplayClass21_0
	{
		public TutorialOnboarding onBoarding;

		internal void <LoadPopup>b__1()
		{
			onBoarding.Initialize();
		}
	}

	private sealed class <>c__DisplayClass22_0
	{
		public ComponentReference<NewVersionPopup> popupRef;

		internal void <LoadPopup>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0063: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1616;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PrefabInitializer.InitializePrefab(popupRef, CanvasLayer.SecondaryCanvas);
		}
	}

	private sealed class <>c__DisplayClass23_0
	{
		public ComponentReference<DownPopup> popupRef;

		internal void <LoadPopup>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0063: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1616;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PrefabInitializer.InitializePrefab(popupRef);
		}
	}

	private sealed class <GoToLogin>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public ServerFetcher <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <GoToLogin>d__29(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0116: Expected I4, but got I8
			//IL_013d: Expected I4, but got I8
			//IL_041d: Expected I4, but got O
			//IL_005e: Expected I4, but got I8
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Expected O, but got Unknown
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Expected O, but got Unknown
			//IL_033a: Expected O, but got I4
			//IL_054a: Expected O, but got I
			//IL_055a: Expected O, but got I
			//IL_057c: Expected O, but got I4
			//IL_01d6: Expected O, but got I4
			//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ca: Expected O, but got Unknown
			//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f1: Expected O, but got Unknown
			//IL_0381: Expected O, but got I4
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Expected O, but got Unknown
			//IL_0227: Expected O, but got I4
			//IL_059e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a3: Expected O, but got Unknown
			//IL_05b9: Expected O, but got I
			//IL_05c1: Expected I, but got O
			//IL_05d2: Expected I, but got O
			//IL_05f0: Expected O, but got I
			//IL_060b: Expected O, but got I4
			//IL_0464: Expected O, but got I
			//IL_0474: Expected O, but got I
			//IL_0496: Expected O, but got I4
			//IL_03b1: Expected O, but got I
			//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b7: Expected O, but got Unknown
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02de: Expected O, but got Unknown
			//IL_026e: Expected O, but got I4
			//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bd: Expected O, but got Unknown
			//IL_04d3: Expected O, but got I
			//IL_04db: Expected I, but got O
			//IL_04ec: Expected I, but got O
			//IL_050a: Expected O, but got I
			//IL_0525: Expected O, but got I4
			//IL_029e: Expected O, but got I
			bool result;
			if (<>1__state <= 1)
			{
				if (<>1__state != 0)
				{
					bool flag = <>1__state != 1;
					result = false;
					if (!flag)
					{
						<>1__state = -1;
						object obj = typeof(UsageHint) + 1640;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						WaitForSeconds waitForSeconds = default(WaitForSeconds);
						waitForSeconds..ctor(0.6f);
						object obj2 = this + 24;
						obj2 = waitForSeconds;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						<>1__state = 2;
						return true;
					}
					goto IL_043c;
				}
				ServerFetcher serverFetcher = <>4__this;
				<>1__state = -1;
				if ((object)<>4__this == null || (object)serverFetcher.loading == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				serverFetcher.loading.ConnectionSuccess();
				if (!ScreenUtility.IsTablet)
				{
					object obj3 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2960;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v12+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj4 = obj3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v12+B8]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v14+18]");
					Func<bool> predicate = (Func<bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v14+18]");
					bool flag3 = (nint)0 == 0;
					object obj7 = !flag3;
					Func<bool> func = null;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v12+E4]");
						bool flag4 = (nint)0 == 0;
						object obj8 = !flag4;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj9 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v20+B8]");
							obj6 = 0;
						}
						object obj10 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj11 = (nint)0 + (nint)1792;
						nint num = (nint)obj11;
						Func<bool> func2 = default(Func<bool>);
						func2..ctor(obj6, (IntPtr)obj11);
						object obj12 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v19+B8]");
						object obj13 = (nint)0 + (nint)24;
						obj13 = func2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj14 = 0;
						func = func2;
						predicate = func2;
					}
					object obj15 = typeof(UsageHint) + 1688;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					WaitWhile waitWhile = default(WaitWhile);
					waitWhile..ctor(predicate);
					object obj16 = this + 24;
					obj16 = waitWhile;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = 3;
					return true;
				}
				bool isDone = SplashAnimation.IsDone;
				bool flag5 = !isDone;
				object obj17 = !flag5;
				if (obj17 == null)
				{
					SplashAnimation.SwitchToScene();
					object obj18 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2960;
					object obj19 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v32+E4]");
					bool flag6 = (nint)0 == 0;
					object obj20 = !flag6;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj19 = obj18;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v32+B8]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v27+10]");
					Func<bool> predicate2 = (Func<bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v27+10]");
					bool flag7 = (nint)0 == 0;
					object obj22 = !flag7;
					Func<bool> func3 = null;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v32+E4]");
						bool flag8 = (nint)0 == 0;
						object obj23 = !flag8;
						if (obj23 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj24 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v33+B8]");
							obj21 = 0;
						}
						object obj25 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj26 = (nint)0 + (nint)1784;
						nint num = (nint)obj26;
						Func<bool> func4 = default(Func<bool>);
						func4..ctor(obj21, (IntPtr)obj26);
						object obj27 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v32+B8]");
						object obj28 = (nint)0 + (nint)16;
						obj28 = func4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj14 = 0;
						func3 = func4;
						predicate2 = func4;
					}
					object obj29 = typeof(UsageHint) + 1680;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					WaitUntil waitUntil = default(WaitUntil);
					waitUntil..ctor(predicate2);
					object obj30 = this + 24;
					obj30 = waitUntil;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = 1;
					return true;
				}
			}
			else
			{
				if (<>1__state != 2)
				{
					bool flag9 = <>1__state != 3;
					result = false;
					if (flag9)
					{
						goto IL_043c;
					}
				}
				<>1__state = -1;
				bool isDone = false;
			}
			<GoToLogin>g__Login|29_2();
			result = false;
			goto IL_043c;
			IL_043c:
			return result;
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
			object obj2 = (nint)0 + (nint)1832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private ConnectionIndicator loading;

	private GameObject errorContainer;

	private Button goOfflineButton;

	private RectTransform optionButtons;

	private TextMeshProUGUI statusMessage;

	private TextMeshProUGUI errorMessage;

	public KammelnaConfigLoader configLoader;

	private ServerFetcherEventsChannel serverFetcherEventsChannel;

	private ComponentReference<NewVersionPopup> versionPopupRef;

	private ComponentReference<DownPopup> downPopupRef;

	private ComponentReference<TutorialOnboarding> userBoardingRef;

	private bool isTrying;

	private bool AutoSwitchScene
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00c0: Expected O, but got I4
			object obj = typeof(UsageHint) + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6967]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool isNewPlayer = UserInfo.IsNewPlayer;
			return (byte)((isNewPlayer ? 1u : 0u) ^ 1u) != 0;
			IL_0074:
			bool isNewPlayer2 = UserInfo.IsNewPlayer;
			return (byte)((isNewPlayer2 ? 1u : 0u) ^ 1u) != 0;
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_011f: Expected O, but got I4
		//IL_0084: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 3136;
		object obj2 = typeof(UsageHint) + 72;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PreventLoadingPreviousScene();
		LoadRemoteConfig();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			bool isNewPlayer = UserInfo.IsNewPlayer;
			bool flag2 = !isNewPlayer;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				goto IL_0092;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!UserInfo.IsNewPlayer)
			{
				goto IL_0092;
			}
		}
		LoadPopup(userBoardingRef);
		RegisterSFSSceneCallbacks();
		return;
		IL_0092:
		RegisterSFSSceneCallbacks();
	}

	private void OnDestroy()
	{
		UnregisterSFSSceneCallbacks();
	}

	private void RegisterSFSSceneCallbacks()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_00c7: Expected I, but got O
		//IL_005d: Expected I, but got O
		//IL_006e: Expected O, but got I
		//IL_009a: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2592;
		object obj2 = (nint)0 + (nint)2048;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action = default(Action<System.Int32Enum>);
		action..ctor((object)this, (IntPtr)obj2);
		SfsConnectionManager.OnConnectionStateChange += (Action<LoginStatus>)(object)action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)2040;
		serverFetcherEventsChannel.OnBoardingFinish += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj5);
		serverFetcherEventsChannel.OnGameSelected += action3;
	}

	private void UnregisterSFSSceneCallbacks()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_00c7: Expected I, but got O
		//IL_005d: Expected I, but got O
		//IL_006e: Expected O, but got I
		//IL_009a: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2592;
		object obj2 = (nint)0 + (nint)2048;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action = default(Action<System.Int32Enum>);
		action..ctor((object)this, (IntPtr)obj2);
		SfsConnectionManager.OnConnectionStateChange -= (Action<LoginStatus>)(object)action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)2040;
		serverFetcherEventsChannel.OnBoardingFinish -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj5);
		serverFetcherEventsChannel.OnGameSelected -= action3;
	}

	private void OnLoginStatusChange(LoginStatus status)
	{
		//IL_00c5: Expected O, but got I4
		//IL_00d3: Expected O, but got I4
		//IL_00ed: Expected O, but got I4
		//IL_0013: Expected O, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_007c: Expected O, but got I4
		//IL_00a9: Expected O, but got I4
		bool flag = status < LoginStatus.LoggedOut;
		object obj = !flag;
		object obj2 = status - 10;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = 1 << (int)status;
		object obj6 = obj5 & 0x730;
		if (obj6 != null)
		{
			object obj7 = typeof(RegisteredWaitHandle) + 1552;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v2+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RoutingManager.Route(RoutingCommand.Login_Error, null, (Games?)(object)0);
		}
	}

	private void LoadRemoteConfig()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0077: Expected O, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0097: Expected O, but got I
		//IL_00dc: Expected I, but got O
		//IL_0106: Expected O, but got I4
		//IL_014f: Expected I, but got O
		//IL_016c: Expected I, but got O
		isTrying = true;
		object text = "Complete" + 368;
		object obj = "LAK" + 2144;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj3 = (nint)0 + (nint)2008;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj5 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
		object obj6 = (nint)0 + (nint)2016;
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)2024;
		loading.StartLoading();
		TextMeshProExtensions.Localize(statusMessage, (string)text);
		SplashAnimation.SetStatusMessage((string)obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj3);
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Config.Initialize(configLoader, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<bool> func = default(Func<bool>);
		func..ctor((object)this, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj8);
		Coroutine coroutine = UIExtensions.SetTimeout(this, 15f, func, action2);
	}

	private void CheckAndPrepareServers()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_010f: Expected O, but got I4
		//IL_0211: Expected O, but got I4
		//IL_0259: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E686A]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v21+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v21+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isWrongVersion = Config.IsWrongVersion;
		bool flag2 = !isWrongVersion;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			goto IL_011d;
		}
		goto IL_021f;
		IL_0184:
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			if (Config.IsDown)
			{
				goto IL_01d3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool isDown = Config.IsDown;
			bool flag3 = !isDown;
			object obj7 = !flag3;
			if (obj7 != null)
			{
				goto IL_01d3;
			}
		}
		PrepareServers();
		return;
		IL_021f:
		LoadPopup(versionPopupRef);
		return;
		IL_01d3:
		LoadPopup(downPopupRef);
		return;
		IL_0074:
		if (!Config.IsWrongVersion)
		{
			goto IL_011d;
		}
		goto IL_021f;
		IL_011d:
		object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			if (KUtil.IsGenuine())
			{
				goto IL_0184;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = KUtil.IsGenuine();
			bool flag5 = !flag4;
			object obj10 = !flag5;
			if (obj10 != null)
			{
				goto IL_0184;
			}
		}
		goto IL_021f;
	}

	private static void LoadPopup(ComponentReference<TutorialOnboarding> popupRef)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_016a: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01b6: Expected O, but got I
		//IL_01c6: Expected O, but got I
		//IL_01e8: Expected O, but got I4
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_02fa: Expected O, but got I
		//IL_030b: Expected I, but got O
		//IL_0329: Expected O, but got I
		//IL_00f2: Expected O, but got I
		//IL_0261: Expected O, but got I
		//IL_028b: Expected O, but got I4
		//IL_0250: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2960;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E686B]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+E4]");
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
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v4+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_00e6;
		}
		goto IL_01fe;
		IL_00e6:
		object obj11 = (nint)0 + (nint)2440;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = obj11;
		Action<object> action2 = action;
		if (!flag4)
		{
			goto IL_012f;
		}
		goto IL_02b1;
		IL_02b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj13;
		action = action2;
		goto IL_012f;
		IL_012f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0085:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v4+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		if (!flag5)
		{
			goto IL_00e6;
		}
		goto IL_01fe;
		IL_01fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)1800;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v9+B8]");
		object obj19 = (nint)0 + (nint)8;
		obj19 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = (nint)0 + (nint)2440;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action = action3;
		obj13 = obj11;
		action2 = action3;
		if (obj20 != null)
		{
			goto IL_012f;
		}
		goto IL_02b1;
	}

	private static void LoadPopup(ComponentReference<NewVersionPopup> popupRef)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1816;
		object obj5 = obj2 + 16;
		obj5 = popupRef;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		SplashAnimation.Interrupt(action);
	}

	private static void LoadPopup(ComponentReference<DownPopup> popupRef)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1824;
		object obj5 = obj2 + 16;
		obj5 = popupRef;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		SplashAnimation.Interrupt(action);
	}

	private void PrepareServers()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_017e: Expected O, but got I4
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I
		//IL_01ba: Expected O, but got I4
		//IL_0212: Expected O, but got I4
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_0252: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6968]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = Config.Validate();
		bool flag3 = !flag2;
		object obj6 = !flag3;
		if (obj6 != null)
		{
			goto IL_009f;
		}
		goto IL_01c8;
		IL_0127:
		if (UserInfo.IsNewPlayer)
		{
			return;
		}
		goto IL_0260;
		IL_0260:
		object obj7 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = default(object);
		obj8..ctor();
		_ = 0;
		object obj9 = obj8 + 32;
		obj9 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj8);
		return;
		IL_009f:
		isTrying = false;
		object obj10 = 152985600;
		object obj11 = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6967]");
		object obj12 = (nint)0 & (nint)1;
		if (obj12 != null)
		{
			object obj13 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v27+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0127;
			}
		}
		else
		{
			_ = 1;
			object obj13 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v27+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			if (obj14 != null)
			{
				goto IL_0127;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isNewPlayer = UserInfo.IsNewPlayer;
		bool flag5 = !isNewPlayer;
		object obj15 = !flag5;
		if (obj15 != null)
		{
			return;
		}
		goto IL_0260;
		IL_007d:
		if (Config.Validate())
		{
			goto IL_009f;
		}
		goto IL_01c8;
		IL_01c8:
		object message = "Cannot populate JSON object onto type '{0}'." + 2432;
		ShowError((string)message);
	}

	public void OnTryAgainButtonClick()
	{
		if (!isTrying)
		{
			HideError();
			LoadRemoteConfig();
		}
	}

	private void OnBoardingFinish()
	{
		PrepareServers();
	}

	private void OnGameSelected()
	{
		PrepareServers();
	}

	private void SwitchToLogin()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj2);
	}

	private IEnumerator GoToLogin()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private void ShowError(string message = "Check your internet connection,\nand try again later.")
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "Complete" + 2664;
		string text2 = default(string);
		TextMeshProExtensions.Localize(statusMessage, text2);
		TextMeshProExtensions.Localize(errorMessage, (string)text);
		SplashAnimation.AnimateTransition();
		loading.ConnectionFail();
		errorContainer.SetActive(value: true);
		ShowOptionButtons();
		isTrying = false;
	}

	private void HideError()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		errorContainer.SetActive(value: false);
		GameObject gameObject = optionButtons.gameObject;
		object text = "Complete" + 368;
		gameObject.SetActive(value: false);
		TextMeshProExtensions.Localize(statusMessage, (string)text);
		GameObject gameObject2 = statusMessage.gameObject;
		gameObject2.SetActive(value: true);
	}

	private void ShowOptionButtons()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I4
		GameObject gameObject = optionButtons.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = goOfflineButton.gameObject;
		bool active;
		if (OfflineUserInfo.IsCached)
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Games currentGame = Preferences.CurrentGame;
			bool flag2 = currentGame == Games.Baloot;
			active = flag2;
		}
		else
		{
			active = false;
		}
		gameObject2.SetActive(active);
	}

	private void HideOptionButtons()
	{
		GameObject gameObject = optionButtons.gameObject;
		gameObject.SetActive(value: false);
	}

	private void <LoadRemoteConfig>b__19_0(bool isOk)
	{
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_007a: Expected O, but got I4
		//IL_00fc: Expected O, but got I4
		if (isOk)
		{
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = typeof(RegisteredWaitHandle) + 3776;
			object format = "WhiteSmoke" + 3104;
			object obj3 = typeof(DataRelation) + 856;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ServerEnvironment environment = Config.Environment;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			string backendURL = Config.BackendURL;
			object arg = default(object);
			string text = string.Format((string)format, arg, backendURL);
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object message = text;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message = text;
			}
			Debug.Log(message);
			CheckAndPrepareServers();
		}
		else
		{
			object message2 = "Cannot populate JSON object onto type '{0}'." + 2432;
			ShowError((string)message2);
		}
	}

	private bool <LoadRemoteConfig>b__19_1()
	{
		return !isTrying;
	}

	private void <LoadRemoteConfig>b__19_2()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "Complete" + 368;
		SplashAnimation.AnimateTransition();
		TextMeshProExtensions.Localize(statusMessage, (string)text);
		ShowOptionButtons();
	}

	internal static void <GoToLogin>g__Login|29_2()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		if (Authentication.CanLogin())
		{
			object obj = typeof(Queue<string>) + 856;
			object obj2 = (nint)0 + (nint)2216;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SfsConnectionManager sfsConnectionManager = default(SfsConnectionManager);
			sfsConnectionManager.AutoLogin();
		}
		else
		{
			object obj5 = typeof(RegisteredWaitHandle) + 3136;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.LoadScene(Scenes.Login);
		}
	}
}
