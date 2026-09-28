using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Kammelna.Server.WebRequests;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public static class PredictAndWinManager
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<MatchPredictionModel, bool> <>9__6_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_UpcomingMatchModels>b__6_0(MatchPredictionModel pm)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00d0: Expected I4, but got O
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected O, but got Unknown
			//IL_004d: Expected O, but got I
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			//IL_0098: Expected O, but got I4
			//IL_0110: Expected O, but got I
			//IL_012b: Expected I, but got O
			//IL_0140: Expected O, but got I
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3048;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (obj2 != null)
			{
				object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
				object obj4 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 120;
				object obj5 = (nint)0 + (nint)1616;
				object obj6 = obj2 + 16;
				obj6 = pm;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj7 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj8 = !flag;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj7 = obj3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v9+B8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj5);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v4+8]");
				return Enumerable.All((IEnumerable<object>)0, func);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass6_0
	{
		public MatchPredictionModel pm;

		internal bool <get_UpcomingMatchModels>b__1(UserMatchPredictionModel upm)
		{
			//IL_00b9: Expected I4, but got O
			//IL_008c: Expected O, but got I4
			if (upm != null)
			{
				MatchPredictionModel <predictionMatch>k__BackingField = upm.<predictionMatch>k__BackingField;
				if (upm.<predictionMatch>k__BackingField != null)
				{
					MatchPredictionModel matchPredictionModel = pm;
					if (pm != null)
					{
						object obj = <predictionMatch>k__BackingField.<id>k__BackingField - matchPredictionModel.<id>k__BackingField;
						bool flag = obj == null;
						return !flag;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <RequestPredictionMatches>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public Action callback;

		private GetPredictionHistoryRequest <matchesHistoryRequest>5__2;

		private GetPredictionSeasonRequest <predictionSeasonRequest>5__3;

		private Coroutine[] <>7__wrap3;

		private int <>7__wrap4;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <RequestPredictionMatches>d__30(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00bc: Expected I4, but got I8
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			//IL_0021: Expected O, but got I4
			//IL_0a94: Expected I4, but got O
			//IL_0127: Expected O, but got I4
			//IL_003e: Expected I4, but got I8
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Expected O, but got Unknown
			//IL_034e: Expected O, but got I
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Expected O, but got Unknown
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0362: Unknown result type (might be due to invalid IL or missing references)
			//IL_0367: Expected O, but got Unknown
			//IL_0391: Expected O, but got I4
			//IL_0226: Expected O, but got I
			//IL_0235: Unknown result type (might be due to invalid IL or missing references)
			//IL_023a: Expected O, but got Unknown
			//IL_028a: Expected O, but got I4
			//IL_0753: Expected O, but got I4
			//IL_03e8: Expected O, but got I
			//IL_0770: Unknown result type (might be due to invalid IL or missing references)
			//IL_0775: Expected O, but got Unknown
			//IL_079f: Expected O, but got I4
			//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b5: Expected O, but got Unknown
			//IL_04cb: Expected O, but got I
			//IL_0b71: Expected O, but got I
			//IL_0b80: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b85: Expected O, but got Unknown
			//IL_0baa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0baf: Expected O, but got Unknown
			//IL_050b: Expected O, but got I4
			//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d8: Expected O, but got Unknown
			//IL_048e: Expected O, but got I4
			//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07fb: Expected O, but got Unknown
			//IL_081c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0821: Expected O, but got Unknown
			//IL_0582: Expected O, but got I
			//IL_05b1: Expected O, but got I4
			//IL_0aee: Expected O, but got I
			//IL_0afe: Expected O, but got I
			//IL_0b12: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b17: Expected O, but got Unknown
			//IL_0889: Unknown result type (might be due to invalid IL or missing references)
			//IL_088e: Expected O, but got Unknown
			//IL_0b44: Expected O, but got I
			//IL_08cd: Expected O, but got I8
			//IL_0690: Expected O, but got I4
			//IL_061b: Expected O, but got I
			//IL_062b: Expected O, but got I
			//IL_064d: Expected O, but got I4
			//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f8: Expected O, but got Unknown
			//IL_0919: Unknown result type (might be due to invalid IL or missing references)
			//IL_091e: Expected O, but got Unknown
			//IL_0948: Expected O, but got I4
			//IL_06c8: Expected O, but got I
			//IL_06d8: Expected O, but got I
			//IL_096f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0974: Expected O, but got Unknown
			//IL_09a3: Expected O, but got I4
			//IL_09b9: Expected O, but got I
			//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_09de: Expected O, but got Unknown
			//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_09fa: Expected O, but got Unknown
			//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a17: Expected O, but got Unknown
			//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a3f: Expected O, but got Unknown
			//IL_0a61: Expected O, but got I4
			object obj2;
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj == null)
				{
					<>1__state = -1;
					obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v73+E4]");
					if ((nint)0 != 0)
					{
						Platform platform = KUtil.GetPlatform();
						if (platform != Platform.Web)
						{
							goto IL_02da;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Platform platform2 = KUtil.GetPlatform();
						if (platform2 != Platform.Web)
						{
							goto IL_02da;
						}
					}
				}
				goto IL_032d;
			}
			<>1__state = -1;
			int num = ++<>7__wrap4;
			object obj4 = this + 56;
			object obj5 = obj4;
			if (obj4 != null)
			{
				goto IL_0106;
			}
			goto IL_0a78;
			IL_0572:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v12 (Kammelna.Server.WebRequests.GetPredictionSeasonRequest)+20]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v12 (Kammelna.Server.WebRequests.GetPredictionSeasonRequest)+20]");
			object obj8;
			OneShotEvent oneShotEvent;
			if ((nint)0 != 0)
			{
				object obj7 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v14+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj7 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v14+B8]");
				object obj10 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X20_v7+30]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object name = "HH:mm:ss.ffZ" + 896;
				bool flag3 = PlayerPrefsX.SetBool((string)name, value: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459B]");
				object obj11 = (nint)0 & (nint)1;
				if (obj11 != null)
				{
					object obj12 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v32+E4]");
					bool flag4 = (nint)0 == 0;
					object obj13 = obj12;
					if (!flag4)
					{
						goto IL_060b;
					}
				}
				else
				{
					_ = 1;
					object obj12 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v32+E4]");
					bool flag5 = (nint)0 == 0;
					object obj14 = !flag5;
					object obj13 = obj12;
					if (obj14 != null)
					{
						goto IL_060b;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj15 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v26+B8]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v21+30]");
				oneShotEvent = (OneShotEvent)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v21+30]");
				if ((nint)0 != 0)
				{
					goto IL_06fd;
				}
			}
			goto IL_0a78;
			IL_0a86:
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			return (byte)(int)ex != 0;
			IL_0267:
			CachedModel<List<MatchPredictionModel>> upcomingPredictionsModel = CachedModels.UpcomingPredictionsModel;
			bool flag6 = upcomingPredictionsModel == null;
			object obj17 = !flag6;
			CachedModel<object> cachedModel = (CachedModel<object>)(object)upcomingPredictionsModel;
			if (obj17 != null)
			{
				goto IL_03dc;
			}
			goto IL_0a78;
			IL_03dc:
			object obj18 = (nint)0 + (nint)504;
			object obj19 = obj18;
			object model = cachedModel.Model;
			List<MatchPredictionModel> matches;
			List<MatchPredictionModel> matches2;
			if (model != null)
			{
				object obj20 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v29+E4]");
				bool flag7 = (nint)0 == 0;
				matches = (List<MatchPredictionModel>)model;
				object obj21 = obj19;
				matches2 = (List<MatchPredictionModel>)model;
				if (!flag7)
				{
					goto IL_045f;
				}
			}
			else
			{
				object obj22 = typeof(List<AdaptivePerformanceScaler>) + 2264;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj23 = (nint)0 + (nint)3952;
				obj19 = obj23;
				List<object> list = default(List<object>);
				list..ctor();
				object obj20 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v29+E4]");
				bool flag8 = (nint)0 == 0;
				object obj24 = !flag8;
				matches = (List<MatchPredictionModel>)(object)list;
				object obj21 = obj23;
				matches2 = (List<MatchPredictionModel>)(object)list;
				if (obj24 != null)
				{
					goto IL_045f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			InitializeUpcomingMatches(matches2);
			GetPredictionSeasonRequest getPredictionSeasonRequest = <predictionSeasonRequest>5__3;
			if (<predictionSeasonRequest>5__3 != null)
			{
				goto IL_0572;
			}
			goto IL_0a78;
			IL_060b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v32+B8]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v25+30]");
			oneShotEvent = (OneShotEvent)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v25+30]");
			bool flag9 = (nint)0 == 0;
			object obj26 = !flag9;
			if (obj26 != null)
			{
				goto IL_06fd;
			}
			goto IL_0a78;
			IL_02da:
			object obj27 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v75+E4]");
			if ((nint)0 != 0)
			{
				if (KUtil.NoPlayServices)
				{
					goto IL_032d;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool noPlayServices = KUtil.NoPlayServices;
				bool flag10 = !noPlayServices;
				object obj28 = !flag10;
				if (obj28 != null)
				{
					goto IL_032d;
				}
			}
			object obj29 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
			object obj30 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v78+E4]");
			bool flag11 = (nint)0 == 0;
			object obj31 = !flag11;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj30 = obj29;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v78+B8]");
			object obj32 = 0;
			object obj33 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2672;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v56+18]");
			GetPredictionHistoryRequest getPredictionHistoryRequest = default(GetPredictionHistoryRequest);
			getPredictionHistoryRequest..ctor(0);
			object obj34 = this + 40;
			obj34 = getPredictionHistoryRequest;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj35 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2688;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			GetPredictionSeasonRequest getPredictionSeasonRequest2 = default(GetPredictionSeasonRequest);
			getPredictionSeasonRequest2..ctor();
			object obj36 = this + 48;
			obj36 = getPredictionSeasonRequest2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj37 = typeof(TypeConverter<ushort, char>) + 2096;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			Coroutine coroutine = WebRequestExtensions.Send((IWebRequest<object>)obj34);
			object obj38 = default(object);
			if (obj38 == null)
			{
				goto IL_0a78;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v88+18]");
			if ((nint)0 != 0)
			{
				object obj39 = obj38 + 32;
				obj39 = coroutine;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Coroutine coroutine2 = WebRequestExtensions.Send((IWebRequest<object>)obj36);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X22_v13-8]");
				object obj40 = 0 & 0xFFFFFFFEL;
				if (obj40 != null)
				{
					object obj41 = obj38 + 40;
					obj41 = coroutine2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj42 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
					object obj43 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v98+E4]");
					bool flag12 = (nint)0 == 0;
					object obj44 = !flag12;
					if (obj44 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object wireKey = "placementId" + 672;
					Coroutine coroutine3 = ContentSyncService.EnsureFreshCoroutine((string)wireKey);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v88+18]");
					bool flag13 = (nint)0 < (nint)2;
					object obj45 = !flag13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v88+18]");
					object obj46 = -2;
					bool flag14 = obj46 == null;
					object obj47 = ~obj45;
					object obj48 = obj47 | flag14;
					if (obj48 == null)
					{
						object obj49 = obj38 + 48;
						obj49 = coroutine3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj50 = this + 56;
						obj50 = obj38;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						_ = 0;
						obj4 = this + 56;
						obj5 = obj4;
						bool flag15 = obj4 == null;
						object obj51 = !flag15;
						num = 0;
						if (obj51 != null)
						{
							goto IL_0106;
						}
						goto IL_0a78;
					}
				}
			}
			goto IL_0a86;
			IL_045f:
			InitializeUpcomingMatches(matches);
			getPredictionSeasonRequest = <predictionSeasonRequest>5__3;
			bool flag16 = <predictionSeasonRequest>5__3 == null;
			object obj52 = !flag16;
			if (obj52 != null)
			{
				goto IL_0572;
			}
			goto IL_0a78;
			IL_0106:
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X9_v3+18]");
			bool flag17 = (nint)num2 < (nint)0;
			object obj53 = !flag17;
			int num3 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X9_v3+18]");
			if ((nint)num3 < (nint)0)
			{
				if (obj53 == null)
				{
					object obj54 = obj5 + num;
					object obj55 = this + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v47+20]");
					obj55 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = 1;
					return true;
				}
				goto IL_0a86;
			}
			<>7__wrap3 = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			GetPredictionHistoryRequest getPredictionHistoryRequest2 = <matchesHistoryRequest>5__2;
			if (<matchesHistoryRequest>5__2 != null)
			{
				obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
				object obj56 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v8+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v7 (Kammelna.Server.WebRequests.GetPredictionHistoryRequest)+20]");
					InitializeMatchesHistory((KammelnaResponseModel<List<UserMatchPredictionModel>>)0);
					object obj57 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
					object obj58 = obj57;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v54+E4]");
					if ((nint)0 != 0)
					{
						goto IL_0267;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v7 (Kammelna.Server.WebRequests.GetPredictionHistoryRequest)+20]");
					InitializeMatchesHistory((KammelnaResponseModel<List<UserMatchPredictionModel>>)0);
					object obj59 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
					object obj58 = obj59;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v54+E4]");
					bool flag18 = (nint)0 == 0;
					object obj60 = !flag18;
					if (obj60 != null)
					{
						goto IL_0267;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				CachedModel<List<MatchPredictionModel>> upcomingPredictionsModel2 = CachedModels.UpcomingPredictionsModel;
				bool flag19 = upcomingPredictionsModel2 == null;
				cachedModel = (CachedModel<object>)(object)upcomingPredictionsModel2;
				if (!flag19)
				{
					goto IL_03dc;
				}
			}
			goto IL_0a78;
			IL_0a78:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0a86;
			IL_032d:
			return false;
			IL_06fd:
			oneShotEvent.IsReady = true;
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
			object obj2 = (nint)0 + (nint)1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private static readonly List<MatchPredictionModel> MatchPredictions;

	public static readonly List<UserMatchPredictionModel> UserMatchPredictions;

	public static PredictionSeasonModel PredictionSeason;

	private static int _pageNumber;

	private static bool _isFullHistoryLoaded;

	private const string IsNewUserModelAvailableKey = "Is_New_Predict_And_Win_User_Model_Available";

	private const string IsSendAvatarKey = "Is_Send_User_Avatar_With_Predict_And_Win";

	private static readonly OneShotEvent <readyState>k__BackingField;

	public static IEnumerable<MatchPredictionModel> UpcomingMatchModels
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_01bb: Expected O, but got I4
			//IL_00b1: Expected O, but got I
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0271: Expected O, but got I
			//IL_0281: Expected O, but got I
			//IL_0291: Expected O, but got I
			//IL_02b3: Expected O, but got I4
			//IL_01fb: Expected O, but got I
			//IL_022d: Expected O, but got I4
			//IL_010a: Expected O, but got I
			//IL_011a: Expected O, but got I
			//IL_012a: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_02f3: Expected O, but got I4
			//IL_034d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Expected O, but got Unknown
			//IL_0368: Expected O, but got I
			//IL_0379: Expected I, but got O
			//IL_0397: Expected O, but got I
			//IL_0323: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6480]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3040;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
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
				obj4 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3040;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v17+B8]");
			object obj10 = 0;
			IEnumerable<object> enumerable = (IEnumerable<object>)obj10;
			object obj11 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			obj4 = obj7;
			object obj13 = obj11;
			IEnumerable<object> enumerable2 = (IEnumerable<object>)obj10;
			if (obj12 != null)
			{
				goto IL_00fe;
			}
			goto IL_0253;
			IL_02d1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			object obj16;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj15 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v10+B8]");
				obj16 = 0;
			}
			object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj18 = (nint)0 + (nint)1608;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj16, (IntPtr)obj18);
			object obj19 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v9+B8]");
			object obj20 = (nint)0 + (nint)8;
			obj20 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj22;
			object obj21 = obj22;
			enumerable = enumerable2;
			Func<object, bool> predicate = func;
			goto IL_0328;
			IL_0328:
			return (IEnumerable<MatchPredictionModel>)Enumerable.Where(enumerable, predicate);
			IL_00fe:
			obj21 = (nint)0 + (nint)3600;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+8]");
			bool flag5 = (nint)0 == 0;
			object obj23 = !flag5;
			if (obj23 == null)
			{
				obj22 = obj21;
				obj7 = obj4;
				enumerable2 = enumerable;
				goto IL_02d1;
			}
			goto IL_0328;
			IL_00a1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+B8]");
			object obj24 = 0;
			enumerable = (IEnumerable<object>)obj24;
			obj11 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+E4]");
			bool flag6 = (nint)0 == 0;
			obj13 = obj11;
			obj7 = obj4;
			enumerable2 = (IEnumerable<object>)obj24;
			if (!flag6)
			{
				goto IL_00fe;
			}
			goto IL_0253;
			IL_0253:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj7;
			obj22 = (nint)0 + (nint)3600;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+8]");
			bool flag7 = (nint)0 == 0;
			object obj25 = !flag7;
			obj21 = obj22;
			enumerable = enumerable2;
			if (obj25 == null)
			{
				goto IL_02d1;
			}
			goto IL_0328;
		}
	}

	public static bool IsNewUserModelAvailable
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2120;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2120;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool IsGlowInMainMenu
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_018e: Expected O, but got I4
			//IL_0096: Expected O, but got I
			//IL_01ce: Expected O, but got I4
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected O, but got Unknown
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Expected O, but got Unknown
			//IL_0224: Expected O, but got I
			//IL_023e: Expected O, but got I4
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Expected O, but got Unknown
			//IL_0122: Expected O, but got I
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E5]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v5+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CachedModel<List<MatchPredictionModel>> upcomingPredictionsModel = CachedModels.UpcomingPredictionsModel;
			bool flag2 = upcomingPredictionsModel == null;
			object obj5 = !flag2;
			CachedModel<object> cachedModel = (CachedModel<object>)(object)upcomingPredictionsModel;
			if (obj5 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_008a;
			IL_008a:
			object obj6 = (nint)0 + (nint)496;
			object obj9;
			if (cachedModel.IsValid())
			{
				object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v21+E4]");
				object name;
				if ((nint)0 != 0)
				{
					obj9 = "HH:mm:ss.ffZ" + 896;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E6]");
					object obj10 = (nint)0 & (nint)1;
					bool flag3 = obj10 == null;
					name = obj9;
					if (!flag3)
					{
						goto IL_0147;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = "HH:mm:ss.ffZ" + 896;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E6]");
					object obj11 = (nint)0 & (nint)1;
					bool flag4 = obj11 == null;
					object obj12 = !flag4;
					name = obj9;
					if (obj12 != null)
					{
						goto IL_0147;
					}
				}
				_ = 1;
				return PlayerPrefsX.GetBool((string)name, defaultValue: false);
			}
			return true;
			IL_0074:
			CachedModel<List<MatchPredictionModel>> upcomingPredictionsModel2 = CachedModels.UpcomingPredictionsModel;
			cachedModel = (CachedModel<object>)(object)upcomingPredictionsModel2;
			goto IL_008a;
			IL_0147:
			return PlayerPrefsX.GetBool((string)obj9, defaultValue: false);
		}
	}

	public static bool HasNewPredictionsSinceLastVisit
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object name = "HH:mm:ss.ffZ" + 896;
			return PlayerPrefsX.GetBool((string)name, defaultValue: false);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object name = "HH:mm:ss.ffZ" + 896;
			bool flag = PlayerPrefsX.SetBool((string)name, value);
		}
	}

	public static bool IsSendAvatarWithScreenshot
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2128;
			return Prefs.GetBool((string)key, defaultValue: true);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_00c9: Expected O, but got I
			//IL_00d9: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_007d: Expected O, but got I
			//IL_008d: Expected O, but got I
			//IL_009d: Expected O, but got I
			//IL_0038: Expected O, but got I
			//IL_0048: Expected O, but got I
			object key = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2128;
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1544;
			Prefs.SetBool((string)key, value);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+B8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v8+20]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v8+20]");
				if ((nint)0 != 0)
				{
					goto IL_006d;
				}
				return;
			}
			goto IL_00a7;
			IL_00a7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v6+B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+20]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+20]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				return;
			}
			goto IL_006d;
			IL_006d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v7+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v7+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v7+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v65 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00a7;
		}
	}

	private static OneShotEvent readyState
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6485]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+30]");
			return (OneShotEvent)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+30]");
			return (OneShotEvent)0;
		}
	}

	public static event Action OnSendAvatarWithScreenshotChanged
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1544;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+20]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1544;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+20]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static event Action OnMoreItemsLoaded
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1544;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+28]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1544;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+28]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static void OnLogout()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0161: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01e7: Expected O, but got I4
		//IL_018f: Expected O, but got I
		//IL_01a9: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00fc: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_025a: Expected O, but got I
		//IL_026a: Expected O, but got I
		//IL_021f: Expected O, but got I
		//IL_022f: Expected O, but got I
		//IL_0285: Expected O, but got I
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_02d7: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64EA]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v20+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v20+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459B]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_01b7;
		IL_0234:
		OneShotEvent oneShotEvent;
		oneShotEvent.IsReady = false;
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v4+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v5+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v6+1C]");
		object obj10 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v6+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v6+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v6+18]");
			Array.Clear((Array)num, 0, 0);
		}
		object key = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2120;
		Prefs.SetBool((string)key, value: false);
		return;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v29+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v20+30]");
		oneShotEvent = (OneShotEvent)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v20+30]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0234;
		IL_01fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v13+B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v11+30]");
		oneShotEvent = (OneShotEvent)0;
		goto IL_0234;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459B]");
		object obj15 = (nint)0 & (nint)1;
		if (obj15 != null)
		{
			goto IL_00a7;
		}
		goto IL_01b7;
		IL_01b7:
		_ = 1;
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v29+E4]");
		bool flag4 = (nint)0 == 0;
		object obj17 = !flag4;
		object obj18 = obj16;
		if (obj17 != null)
		{
			goto IL_00dc;
		}
		goto IL_01fd;
		IL_00a7:
		obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v29+E4]");
		bool flag5 = (nint)0 == 0;
		obj18 = obj16;
		if (!flag5)
		{
			goto IL_00dc;
		}
		goto IL_01fd;
	}

	public static IEnumerator RequestPredictionMatches(Action callback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	public static void RequestMoreMatchesHistory()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01a9: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_00cf: Expected O, but got I
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0256: Expected O, but got I
		//IL_0270: Expected O, but got I4
		//IL_01e1: Expected O, but got I
		//IL_01f1: Expected O, but got I
		//IL_0218: Expected O, but got I
		//IL_0321: Expected I, but got O
		//IL_02a0: Expected O, but got I
		//IL_02c8: Expected O, but got I
		//IL_02d8: Expected O, but got I
		//IL_02fa: Expected O, but got I4
		//IL_014f: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_016f: Expected O, but got I
		//IL_011a: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6486]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_0179;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v20+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = obj4;
		if (!flag)
		{
			goto IL_0085;
		}
		goto IL_01bf;
		IL_0179:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v20+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		obj5 = obj4;
		if (obj6 != null)
		{
			goto IL_0085;
		}
		goto IL_01bf;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v20+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v20+E4]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v10+1C]");
		bool flag3 = (nint)0 != 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v20+E4]");
		object obj9 = 0;
		object obj10 = obj4;
		object obj11 = obj7;
		if (!flag3)
		{
			goto IL_00ed;
		}
		goto IL_0236;
		IL_00ed:
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v10+28]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v10+28]");
			if ((nint)0 == 0)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v12+B8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v13+28]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v13+28]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v15+18]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v15+40]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v15+28]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v136 @ X2_v3 (should have been resolved before IL gen)");
		goto IL_0179;
		IL_0236:
		object obj19 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 424;
		object obj20 = (nint)0 + (nint)1632;
		bool flag5 = obj9 == null;
		object obj21 = !flag5;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj22 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v4+B8]");
			obj11 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj20);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v3+18]");
		KammelnaRequests.GetMatchesHistory(0, action);
		return;
		IL_01bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v20+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v20+E4]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v10+1C]");
		bool flag6 = (nint)0 == 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v20+E4]");
		obj9 = 0;
		obj10 = obj4;
		obj11 = obj7;
		if (flag6)
		{
			goto IL_00ed;
		}
		goto IL_0236;
	}

	private static void InitializeMatchesHistory(KammelnaResponseModel<List<UserMatchPredictionModel>> response)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_00c5: Expected O, but got I4
		//IL_049d: Expected O, but got I
		//IL_007e: Expected O, but got I4
		//IL_00f6: Expected O, but got I
		//IL_0118: Expected O, but got I
		//IL_0130: Expected O, but got I
		//IL_0146: Expected O, but got I
		//IL_0482: Expected O, but got I
		//IL_0591: Expected O, but got I
		//IL_0599: Expected I4, but got O
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected O, but got Unknown
		//IL_05cb: Expected O, but got I4
		//IL_0450: Expected O, but got I
		//IL_0358: Expected O, but got I
		//IL_0372: Expected O, but got I4
		//IL_03ab: Expected O, but got I
		//IL_0565: Expected O, but got I4
		//IL_056e: Expected O, but got I4
		//IL_0193: Expected O, but got I
		//IL_01ad: Expected O, but got I4
		//IL_03ef: Expected O, but got I
		//IL_03ff: Expected O, but got I
		//IL_0421: Expected O, but got I4
		//IL_01e8: Expected O, but got I4
		//IL_02d6: Expected O, but got I
		//IL_02e6: Expected O, but got I
		//IL_0518: Expected O, but got I
		//IL_0528: Expected O, but got I
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_027e: Expected O, but got I4
		object obj = (nint)0 + (nint)2840;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		bool flag = ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)response.<Model>k__BackingField);
		object obj3 = obj2;
		object obj9;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v45+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v45+B8]");
			object obj5 = 0;
			_ = 1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v45+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v45+B8]");
			object obj7 = 0;
			object obj8 = (nint)0 + (nint)2944;
			obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v41+8]");
			((List<object>)0).AddRange(response.<Model>k__BackingField);
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v44+B8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v45+18]");
			object obj12 = (nint)0 + (nint)1;
		}
		object obj13 = (nint)0 + (nint)832;
		bool flag4 = (byte)(int)obj13 != 0;
		bool cachedModelUpdated = ((KammelnaResponseModel<object>)(object)response).CachedModelUpdated;
		object key = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2120;
		bool flag5 = !cachedModelUpdated;
		object obj14 = !flag5;
		if (obj14 != null)
		{
			goto IL_0315;
		}
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v28+E4]");
		if ((nint)0 != 0)
		{
			goto IL_017d;
		}
		goto IL_038b;
		IL_01bb:
		_ = 1;
		goto IL_04a2;
		IL_052d:
		Prefs.SetBool((string)key, value: true);
		obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v28+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		obj9 = 0;
		flag4 = true;
		if (obj16 != null)
		{
			goto IL_017d;
		}
		goto IL_038b;
		IL_0380:
		_ = 1;
		goto IL_052d;
		IL_017d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E3]");
		object obj17 = (nint)0 & (nint)1;
		bool flag7 = obj17 == null;
		object obj18 = !flag7;
		if (obj18 == null)
		{
			goto IL_01bb;
		}
		goto IL_04a2;
		IL_038b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E3]");
		object obj19 = (nint)0 & (nint)1;
		if (obj19 == null)
		{
			goto IL_01bb;
		}
		goto IL_04a2;
		IL_04a2:
		bool flag8 = Prefs.GetBool((string)key);
		object obj20 = obj2;
		bool flag9 = !flag8;
		string text = null;
		int num = 0;
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v20+E4]");
			bool flag10 = (nint)0 == 0;
			object obj21 = !flag10;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj20 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v20+B8]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v21+8]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v22+18]");
			bool flag11 = (nint)0 < (nint)1;
			text = null;
			num = 0;
			if (!flag11)
			{
				object obj24 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
				object obj25 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v21+E4]");
				bool flag12 = (nint)0 == 0;
				object obj26 = !flag12;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				CounterBubbleManager.UpdateCounter(CounterBubbleType.PredictAndWinHistory, 1);
				obj20 = obj2;
				text = null;
				num = 1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v20+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v20+B8]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v18+28]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v18+28]");
			if ((nint)0 == 0)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj29 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v17+B8]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v15+28]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v15+28]");
			bool flag13 = (nint)0 == 0;
			object obj31 = !flag13;
			if (obj31 == null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v143 @ X8_v17+18] (should have been resolved before IL gen)");
		goto IL_0315;
		IL_0315:
		object obj32 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v30+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E4]");
			object obj33 = (nint)0 & (nint)1;
			bool flag14 = obj33 == null;
			object obj34 = !flag14;
			if (obj34 == null)
			{
				goto IL_0380;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E4]");
			object obj35 = (nint)0 & (nint)1;
			if (obj35 == null)
			{
				goto IL_0380;
			}
		}
		goto IL_052d;
	}

	private static void InitializeUpcomingMatches(List<MatchPredictionModel> matches)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_0129: Expected O, but got I
		//IL_01ba: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6487]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v21+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v21+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v9+B8]");
		object obj7 = 0;
		List<object> list = (List<object>)obj7;
		goto IL_0136;
		IL_0136:
		int version = list._version + 1;
		list._size = 0;
		list._version = version;
		if (list._size >= 1)
		{
			Array.Clear(list._items, 0, list._size);
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v9+B8]");
			object obj9 = 0;
			list = (List<object>)obj9;
		}
		list.AddRange(matches);
		return;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v21+B8]");
		object obj10 = 0;
		list = (List<object>)obj10;
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0136;
	}

	private static void InitializePredictionSeason(KammelnaResponseModel<PredictionSeasonModel> response)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_009c: Expected O, but got I
		//IL_005c: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+B8]");
			object obj3 = (nint)0 + (nint)16;
			obj3 = response.<Model>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+B8]");
			object obj5 = (nint)0 + (nint)16;
			obj5 = response.<Model>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static void ResetModels()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_00be: Expected O, but got I4
		//IL_0164: Expected O, but got I
		//IL_0139: Expected O, but got I
		//IL_0149: Expected O, but got I
		//IL_01fb: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01ce: Expected O, but got I
		//IL_01d7: Expected O, but got I4
		//IL_026d: Expected O, but got I4
		//IL_0283: Expected O, but got I
		//IL_0332: Expected O, but got I
		//IL_0354: Expected O, but got I4
		//IL_024d: Expected O, but got I
		//IL_0256: Expected O, but got I4
		//IL_02e5: Expected O, but got I
		//IL_02f5: Expected O, but got I
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_0384: Expected O, but got I
		//IL_0394: Expected O, but got I
		//IL_03a4: Expected O, but got I
		//IL_03c6: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64EE]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v38+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v38+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v27+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v4+8]");
		object obj8 = 0;
		goto IL_014e;
		IL_02d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v20+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v16+30]");
		OneShotEvent oneShotEvent = (OneShotEvent)0;
		goto IL_02fa;
		IL_02fa:
		oneShotEvent.IsReady = false;
		object key = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2120;
		Prefs.SetBool((string)key, value: false);
		return;
		IL_03d4:
		throw new NullReferenceException();
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v38+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v4+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_014e;
		}
		goto IL_03d4;
		IL_014e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v2+1C]");
		object obj11 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v2+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v2+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v2+18]");
			Array.Clear((Array)num, 0, 0);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v18+B8]");
			obj7 = 0;
			object obj13 = 0;
			int num2 = 0;
		}
		object obj14 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v5+1C]");
		object obj15 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v5+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v5+10]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v5+18]");
			Array.Clear((Array)num3, 0, 0);
			object obj13 = 0;
			int num2 = 0;
		}
		object obj16 = 146685952;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459B]");
		object obj17 = (nint)0 & (nint)1;
		if (obj17 != null)
		{
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v20+E4]");
			bool flag4 = (nint)0 == 0;
			object obj19 = obj18;
			if (!flag4)
			{
				goto IL_02d5;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6000]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v20+E4]");
			bool flag5 = (nint)0 == 0;
			object obj20 = !flag5;
			object obj19 = obj18;
			if (obj20 != null)
			{
				goto IL_02d5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6000]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v8+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v8+30]");
		oneShotEvent = (OneShotEvent)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v8+30]");
		bool flag6 = (nint)0 == 0;
		object obj23 = !flag6;
		if (obj23 != null)
		{
			goto IL_02fa;
		}
		goto IL_03d4;
	}

	public static void CallWhenLoaded(Action action)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_013f: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01c5: Expected O, but got I4
		//IL_016d: Expected O, but got I
		//IL_0187: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00fc: Expected O, but got I
		//IL_01fd: Expected O, but got I
		//IL_020d: Expected O, but got I
		//IL_022f: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6488]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459B]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_0195;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v19+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v14+30]");
		OneShotEvent oneShotEvent = (OneShotEvent)0;
		goto IL_0101;
		IL_0101:
		oneShotEvent.CallWhenReady(action);
		return;
		IL_01db:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v5+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v4+30]");
		oneShotEvent = (OneShotEvent)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v4+30]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0101;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459B]");
		object obj11 = (nint)0 & (nint)1;
		if (obj11 != null)
		{
			goto IL_00a7;
		}
		goto IL_0195;
		IL_0195:
		_ = 1;
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		object obj14 = obj12;
		if (obj13 != null)
		{
			goto IL_00dc;
		}
		goto IL_01db;
		IL_00a7:
		obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v19+E4]");
		bool flag5 = (nint)0 == 0;
		obj14 = obj12;
		if (!flag5)
		{
			goto IL_00dc;
		}
		goto IL_01db;
	}

	static PredictAndWinManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_008d: Expected O, but got I
		//IL_00d5: Expected O, but got I
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2264;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		object obj3 = typeof(List<Tween>) + 176;
		object obj4 = typeof(MemberAchievementClanFeedData) + 3440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj5 = obj2;
		object obj6 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4+B8]");
		object obj8 = (nint)0 + (nint)8;
		obj8 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OneShotEvent oneShotEvent = default(OneShotEvent);
		oneShotEvent..ctor();
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v5+B8]");
		object obj10 = (nint)0 + (nint)48;
		obj10 = oneShotEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
