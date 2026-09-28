using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using GoogleMobileAds.Ump.Api;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

namespace Features.GameReplay;

public class GameReplayListUI : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<GameReplayCardData, <>f__AnonymousType9<GameReplayCardData, GameReplay>> <>9__14_0;

		public static Func<<>f__AnonymousType9<GameReplayCardData, GameReplay>, GameReplayCardData> <>9__14_5;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal <>f__AnonymousType9<GameReplayCardData, GameReplay> <RefreshGameReplaysWithFilter>b__14_0(GameReplayCardData gameReplayCardData)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			if (gameReplayCardData != null)
			{
				object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 136;
				object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 2712;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FDCC94");
				<>f__AnonymousType9<GameReplayCardData, GameReplay> result = default(<>f__AnonymousType9<GameReplayCardData, GameReplay>);
				return result;
			}
			return (<>f__AnonymousType9<GameReplayCardData, GameReplay>)(object)new NullReferenceException();
		}

		internal GameReplayCardData <RefreshGameReplaysWithFilter>b__14_5(<>f__AnonymousType9<GameReplayCardData, GameReplay> <>h__TransparentIdentifier0)
		{
			if (<>h__TransparentIdentifier0 != null)
			{
				return <>h__TransparentIdentifier0.<gameReplayCardData>i__Field;
			}
			return (GameReplayCardData)(object)new NullReferenceException();
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <GetGameReplays>d__9 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public GameReplayListUI <>4__this;

		private Task<List<GameReplayCardData>> <task>5__2;

		private TaskAwaiter<List<GameReplayCardData>> <>u__1;

		private unsafe void MoveNext()
		{
			//IL_076d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0772: Expected O, but got Unknown
			//IL_03f8: Expected O, but got I4
			//IL_0407: Expected I4, but got I8
			//IL_064e: Expected O, but got I
			//IL_0421: Unknown result type (might be due to invalid IL or missing references)
			//IL_0426: Expected O, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected O, but got Unknown
			//IL_011f: Expected O, but got I4
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Expected O, but got Unknown
			//IL_0078: Expected O, but got I4
			//IL_007d: Expected I, but got O
			//IL_057f: Expected I4, but got I8
			//IL_058a: Expected O, but got Ref
			//IL_0595: Expected O, but got Ref
			//IL_059e: Expected O, but got I4
			//IL_05d2: Expected O, but got I4
			//IL_00dc: Expected I, but got O
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Expected O, but got Unknown
			//IL_0262: Expected O, but got I4
			//IL_0297: Expected O, but got Ref
			//IL_0337: Expected O, but got I4
			//IL_0375: Expected O, but got Ref
			//IL_03b1: Expected O, but got I4
			//IL_03da: Expected O, but got Ref
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
			GameReplayListUI gameReplayListUI = <>4__this;
			if (<>1__state == 0)
			{
				goto IL_03ed;
			}
			nint num = default(nint);
			object obj2;
			NullReferenceException ex;
			object obj4;
			if ((object)<>4__this != null)
			{
				obj2 = <>4__this + 80;
				if (obj2 != null)
				{
					bool isCancellationRequested = ((CancellationTokenSource)obj2).IsCancellationRequested;
					bool flag = !isCancellationRequested;
					object obj3 = !flag;
					num = unchecked((nint)null);
					if (obj3 == null)
					{
						if (obj2 != null)
						{
							((CancellationTokenSource)obj2).Cancel();
							if (obj2 != null)
							{
								((CancellationTokenSource)obj2).Dispose();
								num = unchecked((nint)null);
								goto IL_00e1;
							}
							ex = new NullReferenceException();
							obj4 = null;
						}
						else
						{
							ex = new NullReferenceException();
							obj4 = null;
						}
						goto IL_0739;
					}
				}
				goto IL_00e1;
			}
			ex = new NullReferenceException();
			obj4 = num;
			goto IL_0739;
			IL_0570:
			<>1__state = -2;
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->SetResult();
			return;
			IL_079b:
			TaskAwaiter<object> taskAwaiter;
			object result = taskAwaiter.GetResult();
			if ((object)<>4__this != null)
			{
				object obj8 = <>4__this + 64;
				obj8 = result;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if ((object)gameReplayListUI.loading != null)
				{
					GameObject gameObject = gameReplayListUI.loading.gameObject;
					if ((object)gameObject != null)
					{
						gameObject.SetActive(value: false);
						List<GameReplayCardData> gameReplayCardDataList = gameReplayListUI._gameReplayCardDataList;
						if (gameReplayListUI._gameReplayCardDataList != null && gameReplayCardDataList._size != 0)
						{
							if ((object)gameReplayListUI.listView != null)
							{
								gameReplayListUI.listView.SetGameReplay(<>4__this, gameReplayListUI._gameReplayCardDataList, forceUpdate: true);
								goto IL_0570;
							}
							ex = new NullReferenceException();
							obj4 = null;
						}
						else
						{
							if ((object)gameReplayListUI.emptyState != null)
							{
								gameReplayListUI.emptyState.SetActive(value: true);
								gameReplayCardDataList = null;
								goto IL_0570;
							}
							ex = new NullReferenceException();
							obj4 = null;
						}
					}
					else
					{
						ex = new NullReferenceException();
						obj4 = null;
					}
				}
				else
				{
					ex = new NullReferenceException();
					obj4 = result;
				}
			}
			else
			{
				ex = new NullReferenceException();
				obj4 = result;
			}
			goto IL_0739;
			IL_0739:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_03ed:
			<>u__1 = (TaskAwaiter<List<GameReplayCardData>>)0;
			<>1__state = -1;
			taskAwaiter = (TaskAwaiter<object>)<>u__1;
			goto IL_079b;
			IL_00e1:
			object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v34+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan delay = TimeSpan.FromSeconds(8.000000000465661);
			object obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			CancellationTokenSource cancellationTokenSource = default(CancellationTokenSource);
			cancellationTokenSource..ctor(delay);
			obj2 = cancellationTokenSource;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if ((object)gameReplayListUI.loading != null)
			{
				gameReplayListUI.loading.StartLoading();
				if ((object)gameReplayListUI.emptyState != null)
				{
					gameReplayListUI.emptyState.SetActive(value: false);
					if (obj2 != null)
					{
						CancellationToken token = ((CancellationTokenSource)obj2).Token;
						object obj13 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
						object obj14 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v49+E4]");
						bool flag4 = (nint)0 == 0;
						object obj15 = !flag4;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Task<List<GameReplayCardData>> allSavedGames = GameReplayManager.GetAllSavedGames(token);
						object obj16 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
						obj16 = allSavedGames;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						bool flag5 = <>1__state == 0;
						List<GameReplayCardData> gameReplayCardDataList = null;
						double num2 = 8.000000000465661;
						if (flag5)
						{
							goto IL_03ed;
						}
						if (obj16 != null)
						{
							TaskAwaiter<object> awaiter = ((Task<object>)obj16).GetAwaiter();
							TaskAwaiter<object> awaiter2 = default(TaskAwaiter<object>);
							bool isCompleted = awaiter2.IsCompleted;
							bool flag6 = !isCompleted;
							object obj17 = !flag6;
							taskAwaiter = awaiter2;
							gameReplayCardDataList = null;
							num2 = 8.000000000465661;
							if (obj17 == null)
							{
								<>1__state = 0;
								object obj18 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 48));
								obj18 = awaiter2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj19 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v63+E4]");
								bool flag7 = (nint)0 == 0;
								object obj20 = !flag7;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
								((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_079b;
						}
						ex = new NullReferenceException();
						gameReplayCardDataList = null;
						num2 = 8.000000000465661;
						obj4 = allSavedGames;
					}
					else
					{
						ex = new NullReferenceException();
						List<GameReplayCardData> gameReplayCardDataList = null;
						double num2 = 8.000000000465661;
						obj4 = null;
					}
				}
				else
				{
					ex = new NullReferenceException();
					List<GameReplayCardData> gameReplayCardDataList = null;
					double num2 = 8.000000000465661;
					obj4 = null;
				}
			}
			else
			{
				ex = new NullReferenceException();
				List<GameReplayCardData> gameReplayCardDataList = null;
				double num2 = 8.000000000465661;
				obj4 = cancellationTokenSource;
			}
			goto IL_0739;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_006b: Expected O, but got I4
			//IL_0033: Expected O, but got Ref
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private sealed class <GetGameReplaysIe>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public GameReplayListUI <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <GetGameReplaysIe>d__13(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0127: Expected I4, but got I8
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Expected O, but got Unknown
			//IL_0165: Expected O, but got I4
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Expected O, but got Unknown
			//IL_0040: Expected I4, but got I8
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			//IL_01d8: Expected O, but got I
			//IL_01f2: Expected O, but got I4
			//IL_0097: Expected O, but got I
			//IL_0230: Expected O, but got I4
			//IL_040d: Expected I4, but got O
			//IL_0105: Expected O, but got I4
			//IL_0287: Expected O, but got I
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Expected O, but got Unknown
			//IL_02a7: Expected O, but got I
			//IL_02e7: Expected O, but got I
			//IL_035d: Expected O, but got I4
			GameReplayListUI gameReplayListUI;
			object obj;
			object obj6;
			object obj8;
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					gameReplayListUI = <>4__this;
					<>1__state = -1;
					obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v11+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EF]");
						object obj3 = (nint)0 & (nint)1;
						if (obj3 != null)
						{
							goto IL_00b4;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45EF]");
						object obj4 = (nint)0 & (nint)1;
						bool flag = obj4 == null;
						object obj5 = !flag;
						if (obj5 != null)
						{
							goto IL_00b4;
						}
					}
					_ = 1;
					obj6 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v14+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					obj8 = obj6;
					if (obj7 != null)
					{
						goto IL_00e9;
					}
					goto IL_0246;
				}
			}
			else
			{
				<>1__state = -1;
				object obj9 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+E4]");
				bool flag3 = (nint)0 == 0;
				object obj11 = !flag3;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				IEnumerator allSavedGamesWeb = GameReplayManager.GetAllSavedGamesWeb();
				object obj12 = this + 24;
				obj12 = allSavedGamesWeb;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 1;
			}
			return <>1__state == 0;
			IL_0246:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj;
			if ((object)<>4__this != null)
			{
				goto IL_0277;
			}
			goto IL_03ff;
			IL_03ff:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_03a5:
			if ((object)gameReplayListUI.listView != null)
			{
				gameReplayListUI.listView.SetGameReplay(<>4__this, gameReplayListUI._gameReplayCardDataList, forceUpdate: true);
				return <>1__state == 0;
			}
			goto IL_03ff;
			IL_00e9:
			bool flag4 = (object)<>4__this == null;
			object obj13 = !flag4;
			if (obj13 != null)
			{
				goto IL_0277;
			}
			goto IL_03ff;
			IL_0277:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v14+B8]");
			object obj14 = 0;
			object obj15 = <>4__this + 64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v13+58]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X20_v9-18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X20_v9-18]");
				GameObject gameObject = ((UnityEngine.Component)0).gameObject;
				if ((object)gameObject != null)
				{
					gameObject.SetActive(value: false);
					object obj16 = obj15;
					if (obj15 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v14+18]");
						bool flag5 = (nint)0 == 0;
						object obj17 = !flag5;
						if (obj17 != null)
						{
							goto IL_03a5;
						}
					}
					if ((object)gameReplayListUI.emptyState != null)
					{
						gameReplayListUI.emptyState.SetActive(value: true);
						goto IL_03a5;
					}
				}
			}
			goto IL_03ff;
			IL_00b4:
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v14+E4]");
			bool flag6 = (nint)0 == 0;
			obj8 = obj6;
			if (!flag6)
			{
				goto IL_00e9;
			}
			goto IL_0246;
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
			object obj2 = (nint)0 + (nint)1816;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private GameReplayListView listView;

	private ElegantLoadingIndicator loading;

	private GameObject emptyState;

	private GameReplayFilterModel _lastFilter;

	private List<GameReplayCardData> _gameReplayCardDataList;

	private readonly List<GameReplayCardData> _filteredGameReplayCardDataList;

	private CancellationTokenSource _cancellationTokenSource;

	private IEnumerator _loadingCoroutine;

	public void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 64;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X21_v2-20]");
		((GameReplayListView)0).SetGameReplay(this, (List<GameReplayCardData>)(object)list2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			Platform platform = KUtil.GetPlatform();
			if (platform == Platform.Web)
			{
				goto IL_00b7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Platform platform2 = KUtil.GetPlatform();
			if (platform2 == Platform.Web)
			{
				goto IL_00b7;
			}
		}
		Task gameReplays = GetGameReplays();
		return;
		IL_00b7:
		GetGameReplaysWeb();
	}

	private void OnDisable()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0102: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E820E]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		if (platform == Platform.Web)
		{
			goto IL_00a6;
		}
		goto IL_0145;
		IL_00a6:
		if (_loadingCoroutine != null)
		{
			StopCoroutine(_loadingCoroutine);
		}
		return;
		IL_0145:
		if (_cancellationTokenSource != null && !_cancellationTokenSource.IsCancellationRequested)
		{
			_cancellationTokenSource.Cancel();
			_cancellationTokenSource.Dispose();
		}
		return;
		IL_007d:
		Platform platform2 = KUtil.GetPlatform();
		if (platform2 == Platform.Web)
		{
			goto IL_00a6;
		}
		goto IL_0145;
	}

	private unsafe Task GetGameReplays()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00d1: Expected O, but got I4
		//IL_003f: Expected O, but got I
		//IL_005c: Expected O, but got Ref
		//IL_0074: Expected O, but got I
		//IL_0094: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
		<GetGameReplays>d__9 stateMachine = default(<GetGameReplays>d__9);
		object obj4 = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 32));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->Start(ref stateMachine);
		AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)((nint)(&stateMachine) | (nint)8);
		return ((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->Task;
	}

	private void GetGameReplaysWeb()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		object obj = this + 88;
		if (obj != null)
		{
			StopCoroutine((IEnumerator)obj);
		}
		loading.StartLoading();
		emptyState.SetActive(value: false);
		object obj2 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		_ = 0;
		object obj4 = obj3 + 32;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_loadingCoroutine = (IEnumerator)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine(_loadingCoroutine);
	}

	private void StopLoadingCoroutine()
	{
		if (_loadingCoroutine != null)
		{
			StopCoroutine(_loadingCoroutine);
		}
	}

	private IEnumerator GetGameReplaysIe()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	public unsafe void RefreshGameReplaysWithFilter(GameReplayFilterModel filterModel)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_008a: Expected O, but got I
		//IL_00b4: Expected I4, but got O
		//IL_00e4: Expected O, but got I
		//IL_10c3: Expected O, but got I
		//IL_10d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d7: Expected O, but got Unknown
		//IL_10e3: Expected O, but got I
		//IL_10ef: Expected O, but got I
		//IL_10fb: Expected O, but got I
		//IL_1107: Expected O, but got I
		//IL_1113: Expected O, but got I
		//IL_1123: Expected O, but got I
		//IL_1133: Expected O, but got I
		//IL_1155: Expected O, but got I4
		//IL_14ca: Expected I, but got O
		//IL_0176: Expected O, but got I4
		//IL_0207: Expected I, but got O
		//IL_1172: Unknown result type (might be due to invalid IL or missing references)
		//IL_1177: Expected O, but got Unknown
		//IL_118d: Expected O, but got I
		//IL_119e: Expected I, but got O
		//IL_11bc: Expected O, but got I
		//IL_0235: Expected I, but got O
		//IL_01b7: Expected O, but got I
		//IL_01c3: Expected O, but got I
		//IL_01a6: Expected O, but got I
		//IL_0268: Expected I, but got O
		//IL_03a3: Expected O, but got I
		//IL_03c3: Expected O, but got I
		//IL_03e5: Expected O, but got I4
		//IL_0314: Expected I, but got O
		//IL_033f: Expected O, but got I4
		//IL_02b7: Expected O, but got I
		//IL_02d7: Expected O, but got I
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_04ef: Expected I, but got O
		//IL_04ff: Expected O, but got I
		//IL_0413: Expected O, but got I
		//IL_0435: Expected O, but got I4
		//IL_05b5: Expected O, but got I
		//IL_05d9: Expected O, but got I4
		//IL_05f2: Expected O, but got I4
		//IL_05f7: Expected I, but got O
		//IL_035f: Expected O, but got I4
		//IL_0378: Expected I, but got O
		//IL_11e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e7: Expected O, but got Unknown
		//IL_11fd: Expected O, but got I
		//IL_1213: Expected I, but got O
		//IL_1213: Expected O, but got I4
		//IL_121b: Expected I4, but got O
		//IL_1231: Expected O, but got I
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Expected O, but got Unknown
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected O, but got Unknown
		//IL_0735: Expected O, but got I
		//IL_0472: Expected I, but got O
		//IL_04ac: Expected O, but got I4
		//IL_04bd: Expected I, but got O
		//IL_07eb: Expected O, but got I
		//IL_0626: Expected O, but got I4
		//IL_0633: Expected I, but got O
		//IL_1258: Expected O, but got I
		//IL_0896: Expected I, but got O
		//IL_0652: Expected O, but got I
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected O, but got Unknown
		//IL_0678: Expected O, but got I
		//IL_06aa: Expected O, but got I4
		//IL_06ca: Expected O, but got I
		//IL_06e3: Expected O, but got I4
		//IL_12b8: Expected I4, but got O
		//IL_12c8: Expected O, but got I
		//IL_12db: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e0: Expected O, but got Unknown
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected O, but got Unknown
		//IL_0b24: Expected O, but got I4
		//IL_0b45: Expected O, but got I4
		//IL_0b7e: Expected O, but got I4
		//IL_0b8f: Expected O, but got I4
		//IL_128c: Expected O, but got I
		//IL_1386: Expected O, but got I4
		//IL_08a8: Expected O, but got I4
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ba: Expected O, but got Unknown
		//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c8: Expected O, but got Unknown
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Expected O, but got Unknown
		//IL_0bc9: Expected O, but got I
		//IL_0857: Expected O, but got I
		//IL_0c64: Expected I, but got O
		//IL_0912: Expected O, but got I
		//IL_1430: Expected O, but got I
		//IL_09bd: Expected I, but got O
		//IL_0ce2: Expected O, but got I4
		//IL_13fc: Expected O, but got I
		//IL_1339: Expected I4, but got O
		//IL_0fcc: Expected O, but got I4
		//IL_0fdd: Expected O, but got I4
		//IL_0df4: Expected I, but got O
		//IL_0e03: Expected I4, but got O
		//IL_0c76: Expected O, but got I4
		//IL_0c83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c88: Expected O, but got Unknown
		//IL_0c91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c96: Expected O, but got Unknown
		//IL_130d: Expected O, but got I
		//IL_0c2d: Expected O, but got I
		//IL_0a0c: Expected I4, but got O
		//IL_09cf: Expected O, but got I4
		//IL_09dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e1: Expected O, but got Unknown
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ef: Expected O, but got Unknown
		//IL_1044: Expected O, but got I4
		//IL_0e7d: Expected I, but got O
		//IL_0e8c: Expected I4, but got O
		//IL_097e: Expected O, but got I
		//IL_0a72: Expected O, but got I4
		//IL_0a92: Expected O, but got I4
		//IL_0752: Expected O, but got I
		//IL_0ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad7: Expected O, but got Unknown
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae5: Expected O, but got Unknown
		if (_gameReplayCardDataList == null)
		{
			return;
		}
		object obj = this + 56;
		GameReplayFilterModel gameReplayFilterModel = default(GameReplayFilterModel);
		obj = gameReplayFilterModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X20_v5+10]");
		int num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X20_v5+10]");
		bool flag = (nint)0 == 0;
		object obj2 = 0;
		bool flag2;
		IEnumerable<object> source5;
		object obj22;
		Func<object, object> func6;
		nint num5;
		IEnumerable<object> enumerable;
		bool flag10;
		object[] array;
		object obj8;
		object obj10;
		object obj7;
		object obj11;
		object obj23;
		object obj6;
		bool flag3;
		nint num6;
		if (!flag)
		{
			object obj3 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v6 (System.Int32)+1C]");
			object obj4 = (nint)0 + (nint)1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v6 (System.Int32)+18]");
			flag2 = (nint)0 < (nint)1;
			int num2 = (int)gameReplayFilterModel;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v6 (System.Int32)+10]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v6 (System.Int32)+18]");
				Array.Clear((Array)num3, 0, 0);
				flag3 = false;
				num2 = 0;
			}
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v29+E4]");
			if ((nint)0 != 0)
			{
				obj6 = obj3;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj3;
				obj6 = obj3;
			}
			array = (object[])((nint)0 + (nint)3368);
			obj7 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3216;
			obj8 = (nint)0 + (nint)2128;
			object obj9 = (nint)0 + (nint)3104;
			obj10 = (nint)0 + (nint)2136;
			obj11 = (nint)0 + (nint)2144;
			object obj12 = (nint)0 + (nint)2152;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v29+B8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v61+8]");
			Func<object, object> selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v61+8]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v29+E4]");
				bool flag5 = (nint)0 == 0;
				object obj15 = !flag5;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj16 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v67+B8]");
					obj13 = 0;
				}
				object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1384;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj18 = (nint)0 + (nint)1800;
				Func<object, object> func = default(Func<object, object>);
				func..ctor(obj13, (IntPtr)obj18);
				object obj19 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v66+B8]");
				object obj20 = (nint)0 + (nint)8;
				obj20 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj12 = (nint)0 + (nint)2152;
				array = (object[])((nint)0 + (nint)3368);
				flag3 = false;
				selector = func;
			}
			IEnumerable<object> source = Enumerable.Select(_gameReplayCardDataList, selector);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor((object)this, (IntPtr)obj8);
			IEnumerable<object> source2 = Enumerable.Where(source, func2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func3 = default(Func<object, bool>);
			func3..ctor((object)this, (IntPtr)obj10);
			IEnumerable<object> source3 = Enumerable.Where(source2, func3);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func4 = default(Func<object, bool>);
			func4..ctor((object)this, (IntPtr)obj11);
			IEnumerable<object> source4 = Enumerable.Where(source3, func4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func5 = default(Func<object, bool>);
			func5..ctor((object)this, (IntPtr)obj12);
			source5 = Enumerable.Where(source4, func5);
			object obj21 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v79+E4]");
			int num4;
			if ((nint)0 != 0)
			{
				obj22 = (nint)0 + (nint)2680;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v79+B8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v6 (System.Int32)+10]");
				func6 = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v6 (System.Int32)+10]");
				bool flag6 = (nint)0 == 0;
				obj23 = obj22;
				num4 = num;
				if (!flag6)
				{
					goto IL_030c;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj6;
				obj22 = (nint)0 + (nint)2680;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v79+B8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v6 (System.Int32)+10]");
				func6 = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v6 (System.Int32)+10]");
				bool flag7 = (nint)0 == 0;
				object obj24 = !flag7;
				obj23 = obj22;
				num4 = num;
				if (obj24 != null)
				{
					goto IL_030c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v79+E4]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v79+E4]");
			bool flag8 = (nint)0 == 0;
			object obj25 = !flag8;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj26 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X8_v56+B8]");
				num4 = 0;
			}
			object obj27 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj28 = (nint)0 + (nint)1808;
			Func<object, object> func7 = default(Func<object, object>);
			func7..ctor((object)((int*)num4)->m_value, (IntPtr)obj28);
			num = (int)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v6 (System.Int32)+B8]");
			object obj29 = (nint)0 + (nint)16;
			obj29 = func7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num5 = (nint)obj23;
			enumerable = Enumerable.Select(source5, func7);
			bool flag9 = enumerable == null;
			obj22 = obj23;
			flag10 = false;
			obj2 = 0;
			flag3 = false;
			num6 = (nint)obj23;
			gameReplayFilterModel = (GameReplayFilterModel)(object)func7;
			if (!flag9)
			{
				goto IL_04d3;
			}
		}
		goto IL_10ac;
		IL_0ef9:
		NullReferenceException ex = new NullReferenceException();
		object obj30;
		gameReplayFilterModel = (GameReplayFilterModel)obj30;
		goto IL_0f3d;
		IL_0c55:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num5 = unchecked((nint)null);
		goto IL_1420;
		IL_030c:
		num5 = (nint)obj22;
		enumerable = Enumerable.Select(source5, func6);
		bool flag11 = enumerable == null;
		object obj31 = !flag11;
		flag10 = false;
		if (obj31 != null)
		{
			goto IL_04d3;
		}
		obj2 = 0;
		obj23 = obj22;
		flag3 = false;
		num6 = (nint)obj22;
		gameReplayFilterModel = (GameReplayFilterModel)(object)func6;
		goto IL_10ac;
		IL_0ec3:
		NullReferenceException ex2 = new NullReferenceException();
		object obj33 = default(object);
		object obj32 = obj33;
		int num8;
		int num7 = num8;
		int num10 = default(int);
		int num9 = num10;
		num6 = num5;
		object obj34 = default(object);
		gameReplayFilterModel = (GameReplayFilterModel)obj34;
		goto IL_0f3d;
		IL_10ac:
		throw new NullReferenceException();
		IL_0f0f:
		NullReferenceException ex3 = new NullReferenceException();
		obj32 = obj33;
		num7 = num8;
		num9 = num10;
		num6 = num5;
		goto IL_0f3d;
		IL_04d3:
		object obj35 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3216;
		nint num11 = (nint)enumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0593;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
		num9 = (int)((nint)0 + (nint)8);
		bool flag12 = flag2;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X10_v12 (System.Int32)-8]");
			obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X10_v12 (System.Int32)-8]");
			if (0 == (nint)obj35)
			{
				break;
			}
			num10 = num9 + 16;
			obj36--;
			flag2 = (nint)obj36 != 1;
			num9 = num10;
			flag12 = flag2;
			if (flag2)
			{
				continue;
			}
			goto IL_0593;
		}
		object obj37 = num11 + ((int*)num9)->m_value;
		object obj38 = obj37 + 312;
		array = (object[])obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X8_v47+8]");
		obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v799 @ X8_v47] (should have been resolved before IL gen)");
		object obj39 = default(object);
		bool flag13 = obj39 == null;
		obj2 = obj39;
		num8 = (int)(&obj2);
		object obj40 = 0;
		num10 = num9;
		flag2 = flag12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X10_v12 (System.Int32)-8]");
		obj32 = 0;
		obj2 = obj39;
		num7 = (int)(&obj2);
		obj40 = 0;
		num6 = num5;
		num = (int)(&obj2);
		if (!flag13)
		{
			goto IL_0701;
		}
		goto IL_0ef9;
		IL_1420:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X0_v21+8]");
		gameReplayFilterModel = (GameReplayFilterModel)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v635 @ X0_v21] (should have been resolved before IL gen)");
		object obj41 = obj8;
		object obj42 = obj10;
		object obj43 = obj7;
		object obj44 = obj33;
		object obj45 = obj11;
		num8 = num7;
		int num12 = num10;
		obj22 = obj23;
		object obj47;
		object obj46 = obj47;
		object obj48 = obj6;
		flag10 = flag3;
		object obj50;
		object obj49 = obj50;
		goto IL_136c;
		IL_0701:
		object obj51 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj52 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 592;
		obj11 = (nint)0 + (nint)2648;
		object obj53 = obj39;
		object obj56 = default(object);
		object obj58 = default(object);
		object obj61 = default(object);
		while (true)
		{
			object obj54 = obj53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X8_v30+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X8_v30+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0887;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X8_v30+B0]");
			int num13 = (int)((nint)0 + (nint)8);
			bool flag14 = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X10_v27 (System.Int32)-8]");
				obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X10_v27 (System.Int32)-8]");
				if (0 == (nint)obj51)
				{
					break;
				}
				num10 = num13 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X8_v30+12E]");
				array = (object[])(-1);
				flag2 = (nint)array != 1;
				num13 = num10;
				flag14 = flag2;
				if (flag2)
				{
					continue;
				}
				goto IL_0887;
			}
			array = (object[])((int*)num13)->m_value;
			object obj55 = obj54 + ((int*)num13)->m_value;
			obj56 = obj55 + 312;
			num10 = num13;
			flag2 = flag14;
			goto IL_12b0;
			IL_12b0:
			num = (int)obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X0_v56+8]");
			gameReplayFilterModel = (GameReplayFilterModel)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v969 @ X0_v56] (should have been resolved before IL gen)");
			object obj57 = obj58 & 1;
			if (obj57 == null)
			{
				break;
			}
			if (obj2 == null)
			{
				goto IL_0f0f;
			}
			object obj59 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ X8_v33+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ X8_v33+12E]");
			if ((nint)0 == 0)
			{
				goto IL_09ae;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ X8_v33+B0]");
			int num14 = (int)((nint)0 + (nint)8);
			bool flag15 = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ X10_v22 (System.Int32)-8]");
				obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ X10_v22 (System.Int32)-8]");
				if (0 == (nint)obj52)
				{
					break;
				}
				num10 = num14 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ X8_v33+12E]");
				array = (object[])(-1);
				flag2 = (nint)array != 1;
				num14 = num10;
				flag15 = flag2;
				if (flag2)
				{
					continue;
				}
				goto IL_09ae;
			}
			array = (object[])((int*)num14)->m_value;
			object obj60 = obj59 + ((int*)num14)->m_value;
			obj61 = obj60 + 312;
			num10 = num14;
			flag2 = flag15;
			goto IL_1331;
			IL_1331:
			num = (int)obj61;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1033 @ X0_v60] (should have been resolved before IL gen)");
			List<object> filteredGameReplayCardDataList = (List<object>)(object)_filteredGameReplayCardDataList;
			if (_filteredGameReplayCardDataList != null)
			{
				num = (int)obj11;
				int version = filteredGameReplayCardDataList._version + 1;
				filteredGameReplayCardDataList._version = version;
				array = filteredGameReplayCardDataList._items;
				if (filteredGameReplayCardDataList._items != null)
				{
					num10 = filteredGameReplayCardDataList._size;
					obj33 = array.Length;
					bool flag16 = filteredGameReplayCardDataList._size < array.Length;
					object obj62 = !flag16;
					if (obj62 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v6 (System.Int32)+20]");
						object obj63 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X8_v40+C0]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v6 (System.Int32)+70]");
						num5 = 0;
						((List<object>)(object)_filteredGameReplayCardDataList).AddWithResize(obj34);
					}
					else
					{
						num = filteredGameReplayCardDataList._size + 1;
						filteredGameReplayCardDataList._size = num;
						object obj64 = filteredGameReplayCardDataList._items + filteredGameReplayCardDataList._size;
						object obj65 = obj64 + 32;
						obj65 = obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					bool flag17 = obj2 == null;
					obj53 = obj2;
					obj32 = obj33;
					num7 = num8;
					num9 = num10;
					num6 = num5;
					obj30 = obj34;
					if (!flag17)
					{
						continue;
					}
					goto IL_0ef9;
				}
			}
			goto IL_0ec3;
			IL_09ae:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num5 = unchecked((nint)null);
			goto IL_1331;
			IL_0887:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num5 = unchecked((nint)null);
			goto IL_12b0;
		}
		bool flag18 = obj2 == null;
		num7 = num8;
		obj23 = obj22;
		obj47 = 7;
		flag3 = flag10;
		num6 = num5;
		object obj66 = obj2;
		obj50 = 0;
		obj41 = obj8;
		obj42 = obj10;
		obj43 = obj7;
		obj44 = obj33;
		obj45 = obj11;
		num12 = num10;
		obj46 = 7;
		obj48 = obj6;
		obj49 = 0;
		if (!flag18)
		{
			goto IL_0b9d;
		}
		goto IL_136c;
		IL_0593:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj67 = default(object);
		array = (object[])obj67;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v75+8]");
		obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v758 @ X0_v75] (should have been resolved before IL gen)");
		bool flag19 = obj39 == null;
		object obj68 = !flag19;
		obj2 = obj39;
		num8 = (int)(&obj2);
		obj40 = 0;
		num5 = unchecked((nint)null);
		if (obj68 != null)
		{
			goto IL_0701;
		}
		obj32 = obj33;
		obj2 = obj39;
		num7 = (int)(&obj2);
		obj40 = 0;
		num9 = num10;
		num6 = unchecked((nint)null);
		num = (int)(&obj2);
		goto IL_0ef9;
		IL_0b9d:
		object obj69 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj70 = obj66;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v14+12E]");
		array = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v14+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0c55;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v14+B0]");
		int num15 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X10_v10 (System.Int32)-8]");
			obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X10_v10 (System.Int32)-8]");
			if (0 == (nint)obj69)
			{
				break;
			}
			num10 = num15 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v14+12E]");
			array = (object[])(-1);
			bool flag20 = (nint)array != 1;
			num15 = num10;
			if (flag20)
			{
				continue;
			}
			goto IL_0c55;
		}
		array = (object[])((int*)num15)->m_value;
		object obj71 = obj70 + ((int*)num15)->m_value;
		object obj72 = obj71 + 312;
		num10 = num15;
		num5 = num6;
		goto IL_1420;
		IL_0f3d:
		obj33 = obj32;
		num10 = num9;
		obj23 = obj22;
		flag3 = flag10;
		goto IL_10ac;
		IL_136c:
		object obj74 = default(object);
		while (true)
		{
			bool flag21 = obj49 == null;
			object obj73 = !flag21;
			obj8 = obj41;
			obj10 = obj42;
			obj7 = obj43;
			obj33 = obj44;
			obj11 = obj45;
			num7 = num8;
			num10 = num12;
			obj23 = obj22;
			obj6 = obj48;
			flag3 = flag10;
			num6 = num5;
			if (obj73 != null)
			{
				OutOfMemoryException ex4 = new OutOfMemoryException();
				if ((nint)gameReplayFilterModel == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj50 = obj74;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					bool flag22 = obj2 == null;
					object obj75 = !flag22;
					obj40 = obj74;
					obj47 = 0;
					obj66 = obj2;
					if (obj75 == null)
					{
						obj41 = obj8;
						obj42 = obj10;
						obj43 = obj7;
						obj44 = obj33;
						obj45 = obj11;
						num8 = num7;
						obj40 = obj74;
						num12 = num10;
						obj22 = obj23;
						obj46 = 0;
						obj48 = obj6;
						flag10 = flag3;
						num5 = num6;
						obj49 = obj74;
						continue;
					}
					goto IL_0b9d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return;
			}
			break;
		}
		if ((nint)obj46 != 7)
		{
			bool flag23 = obj46 == null;
			object obj76 = !flag23;
			if (obj76 != null)
			{
				return;
			}
		}
		bool flag24 = (object)listView == null;
		obj8 = obj41;
		obj10 = obj42;
		obj7 = obj43;
		obj33 = obj44;
		obj11 = obj45;
		num7 = num8;
		num10 = num12;
		obj23 = obj22;
		obj6 = obj48;
		flag3 = flag10;
		num6 = num5;
		if (!flag24)
		{
			listView.SetGameReplay(this, _filteredGameReplayCardDataList, forceUpdate: true);
			List<GameReplayCardData> filteredGameReplayCardDataList2 = _filteredGameReplayCardDataList;
			bool flag25 = _filteredGameReplayCardDataList == null;
			obj8 = obj41;
			obj10 = obj42;
			obj7 = obj43;
			obj33 = obj44;
			obj11 = obj45;
			num7 = num8;
			num10 = num12;
			obj23 = obj22;
			obj6 = obj48;
			flag3 = true;
			num6 = (nint)_filteredGameReplayCardDataList;
			gameReplayFilterModel = (GameReplayFilterModel)(object)this;
			num = (int)_filteredGameReplayCardDataList;
			if (!flag25)
			{
				bool flag26 = (object)emptyState == null;
				obj8 = obj41;
				obj10 = obj42;
				obj7 = obj43;
				obj33 = obj44;
				obj11 = obj45;
				num7 = num8;
				num10 = num12;
				obj23 = obj22;
				obj6 = obj48;
				flag3 = true;
				num6 = (nint)_filteredGameReplayCardDataList;
				gameReplayFilterModel = (GameReplayFilterModel)(object)this;
				num = (int)_filteredGameReplayCardDataList;
				if (!flag26)
				{
					bool active = filteredGameReplayCardDataList2._size == 0;
					emptyState.SetActive(active);
					return;
				}
			}
		}
		goto IL_10ac;
	}

	public void DeleteCard(GameReplayCardData gameReplayCardData)
	{
		//IL_006f: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_0061: Expected O, but got I4
		bool flag = ((List<object>)(object)_gameReplayCardDataList).Remove((object)gameReplayCardData);
		bool flag2 = ((List<object>)(object)_filteredGameReplayCardDataList).Remove((object)gameReplayCardData);
		if (_lastFilter == null)
		{
			object obj = 64;
		}
		else
		{
			object obj = 72;
		}
		GameReplayListView gameReplayListView = listView;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayListUI)+v149 @ X8_v6]");
		gameReplayListView.SetGameReplay(this, (List<GameReplayCardData>)0);
		List<GameReplayCardData> gameReplayCardDataList = _gameReplayCardDataList;
		bool active = gameReplayCardDataList._size == 0;
		emptyState.SetActive(active);
	}

	public GameReplayListUI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 72;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private bool <RefreshGameReplaysWithFilter>b__14_1(<>f__AnonymousType9<GameReplayCardData, GameReplay> <>h__TransparentIdentifier0)
	{
		//IL_00ce: Expected I4, but got O
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		GameReplayFilterModel lastFilter = _lastFilter;
		if (_lastFilter != null)
		{
			object obj = (??)lastFilter.<GameType>k__BackingField & 1;
			if (obj == null)
			{
				return true;
			}
			if (<>h__TransparentIdentifier0 != null)
			{
				GameReplay <gameReplay>i__Field = <>h__TransparentIdentifier0.<gameReplay>i__Field;
				if (<>h__TransparentIdentifier0.<gameReplay>i__Field != null)
				{
					object obj2 = (object?)lastFilter.<GameType>k__BackingField >> 32;
					object obj3 = <gameReplay>i__Field.<GameType>k__BackingField - obj2;
					return obj3 == null;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool <RefreshGameReplaysWithFilter>b__14_2(<>f__AnonymousType9<GameReplayCardData, GameReplay> <>h__TransparentIdentifier0)
	{
		//IL_00dc: Expected I4, but got O
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected I4, but got Unknown
		GameReplayFilterModel lastFilter = _lastFilter;
		if (_lastFilter != null)
		{
			object obj = (??)lastFilter.<CheatingAllowed>k__BackingField & 1;
			if (obj == null)
			{
				return true;
			}
			if (<>h__TransparentIdentifier0 != null)
			{
				GameReplay <gameReplay>i__Field = <>h__TransparentIdentifier0.<gameReplay>i__Field;
				if (<>h__TransparentIdentifier0.<gameReplay>i__Field != null)
				{
					object obj2 = (??)lastFilter.<CheatingAllowed>k__BackingField & 0x100;
					bool flag = obj2 == null;
					object obj3 = flag ^ <gameReplay>i__Field.<IsCheatingAllowed>k__BackingField;
					return (byte)(obj3 & 1) != 0;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool <RefreshGameReplaysWithFilter>b__14_3(<>f__AnonymousType9<GameReplayCardData, GameReplay> <>h__TransparentIdentifier0)
	{
		//IL_00ce: Expected I4, but got O
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		GameReplayFilterModel lastFilter = _lastFilter;
		if (_lastFilter != null)
		{
			object obj = (??)lastFilter.<PlayingSpeed>k__BackingField & 1;
			if (obj == null)
			{
				return true;
			}
			if (<>h__TransparentIdentifier0 != null)
			{
				GameReplay <gameReplay>i__Field = <>h__TransparentIdentifier0.<gameReplay>i__Field;
				if (<>h__TransparentIdentifier0.<gameReplay>i__Field != null)
				{
					object obj2 = (object?)lastFilter.<PlayingSpeed>k__BackingField >> 32;
					object obj3 = <gameReplay>i__Field.<Timer>k__BackingField - obj2;
					return obj3 == null;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool <RefreshGameReplaysWithFilter>b__14_4(<>f__AnonymousType9<GameReplayCardData, GameReplay> <>h__TransparentIdentifier0)
	{
		//IL_00dc: Expected I4, but got O
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected I4, but got Unknown
		GameReplayFilterModel lastFilter = _lastFilter;
		if (_lastFilter != null)
		{
			object obj = (??)lastFilter.<IsLocked>k__BackingField & 1;
			if (obj == null)
			{
				return true;
			}
			if (<>h__TransparentIdentifier0 != null)
			{
				GameReplay <gameReplay>i__Field = <>h__TransparentIdentifier0.<gameReplay>i__Field;
				if (<>h__TransparentIdentifier0.<gameReplay>i__Field != null)
				{
					object obj2 = (??)lastFilter.<IsLocked>k__BackingField & 0x100;
					bool flag = obj2 == null;
					object obj3 = flag ^ <gameReplay>i__Field.<IsPasswordProtected>k__BackingField;
					return (byte)(obj3 & 1) != 0;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
