using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.InputSystem.UI;
using UnityEngine.Rendering;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class UpcomingMatchesList : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<MatchPredictionModel, bool> <>9__10_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 1424;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_UpcomingMatchModels>b__10_0(MatchPredictionModel m)
		{
			//IL_0097: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			if (m != null)
			{
				object obj = typeof(DataRelation) + 712;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now = DateTime.Now;
				return m.<expiryDate>k__BackingField > now;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private bool _isInitialized;

	private readonly Dictionary<int, PredictAndWinCard> _cards;

	private PredictionSeasonBanner _banner;

	private PredictAndWinEventsChannel eventsChannel;

	private PredictionSeasonBanner bannerPrefab;

	private PredictAndWinCard cardPrefab;

	private RectTransform cardsContainer;

	private RotatingLoadingIndicator loadingIndicator;

	private GameObject emptyState;

	private IEnumerable<MatchPredictionModel> UpcomingMatchModels
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected O, but got Unknown
			//IL_01ac: Expected O, but got I4
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0250: Expected O, but got I
			//IL_0260: Expected O, but got I
			//IL_0270: Expected O, but got I
			//IL_0292: Expected O, but got I4
			//IL_00fb: Expected O, but got I
			//IL_010b: Expected O, but got I
			//IL_011b: Expected O, but got I
			//IL_013d: Expected O, but got I4
			//IL_0204: Expected O, but got I4
			//IL_02d2: Expected O, but got I4
			//IL_032c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0331: Expected O, but got Unknown
			//IL_0347: Expected O, but got I
			//IL_0358: Expected I, but got O
			//IL_0376: Expected O, but got I
			//IL_0302: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6518]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj6;
			if (obj3 != null)
			{
				obj4 = typeof(TrackedDeviceRaycaster.<>c) + 1424;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v15+E4]");
				bool flag = (nint)0 == 0;
				obj6 = obj4;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(TrackedDeviceRaycaster.<>c) + 1424;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v15+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			IEnumerable<MatchPredictionModel> upcomingMatchModels = PredictAndWinManager.UpcomingMatchModels;
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			obj4 = obj6;
			IEnumerable<MatchPredictionModel> enumerable = upcomingMatchModels;
			object obj10 = obj8;
			IEnumerable<MatchPredictionModel> enumerable2 = upcomingMatchModels;
			if (obj9 != null)
			{
				goto IL_00ef;
			}
			goto IL_0232;
			IL_02b0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			object obj13;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v10+B8]");
				obj13 = 0;
			}
			object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)2176;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj13, (IntPtr)obj15);
			object obj16 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v9+B8]");
			object obj17 = (nint)0 + (nint)8;
			obj17 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj19;
			object obj18 = obj19;
			enumerable = enumerable2;
			Func<object, bool> predicate = func;
			goto IL_0307;
			IL_0307:
			return (IEnumerable<MatchPredictionModel>)Enumerable.Where(enumerable, predicate);
			IL_00ef:
			obj18 = (nint)0 + (nint)3600;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v4+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v4+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v4+8]");
			bool flag5 = (nint)0 == 0;
			object obj20 = !flag5;
			if (obj20 == null)
			{
				obj19 = obj18;
				obj6 = obj4;
				enumerable2 = enumerable;
				goto IL_02b0;
			}
			goto IL_0307;
			IL_0099:
			IEnumerable<MatchPredictionModel> upcomingMatchModels2 = PredictAndWinManager.UpcomingMatchModels;
			obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v4+E4]");
			bool flag6 = (nint)0 == 0;
			enumerable = upcomingMatchModels2;
			obj10 = obj8;
			obj6 = obj4;
			enumerable2 = upcomingMatchModels2;
			if (!flag6)
			{
				goto IL_00ef;
			}
			goto IL_0232;
			IL_0232:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj6;
			obj19 = (nint)0 + (nint)3600;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v4+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v4+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v4+8]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			obj18 = obj19;
			enumerable = enumerable2;
			if (obj21 == null)
			{
				goto IL_02b0;
			}
			goto IL_0307;
		}
	}

	private PredictionSeasonModel _predictionSeasonModel
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6519]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+10]");
			return (PredictionSeasonModel)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+10]");
			return (PredictionSeasonModel)0;
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I
		//IL_00c4: Expected I, but got O
		//IL_00ee: Expected O, but got I4
		//IL_0077: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3440;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3960;
		object obj5 = (nint)0 + (nint)3448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.3f, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj5);
		eventsChannel.OnPredictionSubmitted += action2;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3960;
		object obj2 = (nint)0 + (nint)3448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		eventsChannel.OnPredictionSubmitted -= action;
	}

	private void OnEnable()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0066: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3456;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		emptyState.SetActive(value: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			PredictAndWinManager.CallWhenLoaded(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PredictAndWinManager.CallWhenLoaded(action);
	}

	private unsafe void Populate()
	{
		//IL_0016: Expected O, but got I
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_017a: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_019d: Expected O, but got I4
		//IL_01a6: Expected O, but got I4
		//IL_01b7: Expected O, but got I4
		//IL_01c0: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0075: Expected O, but got I4
		//IL_007e: Expected O, but got I4
		//IL_008f: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_0246: Expected O, but got I
		//IL_027f: Expected O, but got I
		//IL_01fe: Expected O, but got I4
		//IL_00fb: Expected O, but got I
		//IL_0127: Expected O, but got I4
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02b4: Expected I4, but got O
		//IL_02c4: Expected O, but got I
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected O, but got Unknown
		//IL_05de: Expected I, but got O
		//IL_05ee: Expected O, but got I
		//IL_013d: Expected O, but got I
		//IL_06c8: Expected O, but got I
		//IL_06ec: Expected O, but got I4
		//IL_06fd: Expected O, but got I4
		//IL_036b: Expected O, but got I4
		//IL_0388: Expected O, but got I4
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Expected O, but got Unknown
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected O, but got Unknown
		//IL_0843: Expected O, but got I
		//IL_084f: Expected O, but got I
		//IL_085b: Expected O, but got I
		//IL_0867: Expected O, but got I
		//IL_0629: Expected O, but got I
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03ca: Expected O, but got I
		//IL_03ec: Expected O, but got I4
		//IL_08e9: Expected O, but got I
		//IL_0731: Expected O, but got I4
		//IL_1413: Expected O, but got I
		//IL_1425: Unknown result type (might be due to invalid IL or missing references)
		//IL_142a: Expected O, but got Unknown
		//IL_13a1: Expected O, but got I
		//IL_13db: Expected O, but got I
		//IL_0328: Expected O, but got I4
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0760: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected O, but got Unknown
		//IL_0786: Expected O, but got I
		//IL_07b0: Expected O, but got I4
		//IL_07d8: Expected O, but got I
		//IL_07e9: Expected O, but got I4
		//IL_04c4: Expected I, but got O
		//IL_04e1: Expected O, but got I4
		//IL_14ab: Expected I4, but got O
		//IL_14bb: Expected O, but got I
		//IL_14ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d3: Expected O, but got Unknown
		//IL_0924: Expected O, but got I
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Expected O, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected O, but got Unknown
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Expected O, but got Unknown
		//IL_048b: Expected O, but got I4
		//IL_0439: Expected I, but got O
		//IL_0d31: Expected O, but got I4
		//IL_0d3a: Expected O, but got I4
		//IL_0d8b: Expected O, but got I4
		//IL_0d94: Expected O, but got I4
		//IL_1463: Expected O, but got I
		//IL_1475: Unknown result type (might be due to invalid IL or missing references)
		//IL_147a: Expected O, but got Unknown
		//IL_0566: Expected O, but got I
		//IL_057b: Expected O, but got I
		//IL_0519: Expected I, but got O
		//IL_1599: Expected O, but got I4
		//IL_09db: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e0: Expected O, but got Unknown
		//IL_0db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db6: Expected O, but got Unknown
		//IL_0dce: Expected O, but got I
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_093f: Expected O, but got Unknown
		//IL_0955: Expected O, but got I
		//IL_0960: Unknown result type (might be due to invalid IL or missing references)
		//IL_0965: Expected O, but got Unknown
		//IL_0a2a: Expected O, but got I
		//IL_0ef7: Expected O, but got I
		//IL_1643: Expected O, but got I
		//IL_0e09: Expected O, but got I
		//IL_0edd: Expected O, but got I4
		//IL_160f: Expected O, but got I
		//IL_1548: Expected I4, but got O
		//IL_1558: Expected O, but got I
		//IL_0a65: Expected O, but got I
		//IL_12d4: Expected O, but got I4
		//IL_12ed: Expected O, but got I4
		//IL_0e8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e91: Expected O, but got Unknown
		//IL_1500: Expected O, but got I
		//IL_1512: Unknown result type (might be due to invalid IL or missing references)
		//IL_1517: Expected O, but got Unknown
		//IL_0fa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa9: Expected O, but got Unknown
		//IL_0ff0: Expected O, but got I4
		//IL_0e17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1c: Expected O, but got Unknown
		//IL_0e32: Expected O, but got I
		//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Expected O, but got Unknown
		//IL_1364: Expected O, but got I4
		//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0a96: Expected O, but got I
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Expected O, but got Unknown
		//IL_0c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2b: Expected O, but got Unknown
		//IL_0c4f: Expected O, but got I4
		//IL_1248: Expected O, but got I4
		//IL_119c: Expected O, but got I4
		//IL_0ccf: Expected I, but got O
		//IL_0cfc: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E651D]");
		object obj = (nint)0 & (nint)1;
		PredictAndWinCard predictAndWinCard;
		PredictionSeasonModel predictionSeasonModel;
		object obj3;
		PredictAndWinCard predictAndWinCard2;
		PredictionSeasonModel predictionSeasonModel2;
		if (obj != null)
		{
			predictAndWinCard = (PredictAndWinCard)(typeof(System.Buffers.Text.ParserHelpers) + 1544);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459C]");
			object obj2 = (nint)0 & (nint)1;
			bool flag = obj2 == null;
			predictionSeasonModel = (PredictionSeasonModel)146685952;
			obj3 = 0;
			predictAndWinCard2 = predictAndWinCard;
			predictionSeasonModel2 = (PredictionSeasonModel)146685952;
			obj3 = 0;
			if (!flag)
			{
				goto IL_00a6;
			}
		}
		else
		{
			_ = 1;
			predictAndWinCard = (PredictAndWinCard)(typeof(System.Buffers.Text.ParserHelpers) + 1544);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459C]");
			object obj4 = (nint)0 & (nint)1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			predictionSeasonModel = (PredictionSeasonModel)146685952;
			obj3 = 0;
			predictAndWinCard2 = predictAndWinCard;
			predictionSeasonModel2 = (PredictionSeasonModel)146685952;
			obj3 = 0;
			if (obj5 != null)
			{
				goto IL_00a6;
			}
		}
		_ = 1;
		UpcomingMatchesList upcomingMatchesList = (UpcomingMatchesList)(object)predictAndWinCard2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v30 (UpcomingMatchesList)+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		predictAndWinCard = predictAndWinCard2;
		predictionSeasonModel = predictionSeasonModel2;
		UpcomingMatchesList upcomingMatchesList2 = upcomingMatchesList;
		if (obj6 != null)
		{
			goto IL_00eb;
		}
		goto IL_0224;
		IL_06a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj8 = default(object);
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v68+8]");
		PredictionSeasonModel predictionSeasonModel3 = (PredictionSeasonModel)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v339 @ X0_v68] (should have been resolved before IL gen)");
		object obj9 = default(object);
		bool flag4 = obj9 == null;
		object obj10 = !flag4;
		bool flag5 = (byte)(&obj3) != 0;
		object obj11 = 0;
		object obj12 = null;
		obj3 = obj9;
		if (obj10 != null)
		{
			goto IL_080f;
		}
		object obj14 = default(object);
		object obj13 = obj14;
		bool flag6 = (byte)(&obj3) != 0;
		obj11 = 0;
		object obj15 = null;
		object obj17 = default(object);
		object obj16 = obj17;
		obj3 = obj9;
		bool flag7 = (byte)(&obj3) != 0;
		goto IL_10b6;
		IL_11a1:
		NullReferenceException ex = new NullReferenceException();
		obj13 = obj14;
		nint num;
		IntPtr intPtr = num;
		flag6 = flag5;
		obj16 = obj17;
		predictionSeasonModel3 = predictionSeasonModel2;
		goto IL_124d;
		IL_13f8:
		throw new NullReferenceException();
		IL_00a6:
		upcomingMatchesList = (UpcomingMatchesList)(object)predictAndWinCard;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v30 (UpcomingMatchesList)+E4]");
		bool flag8 = (nint)0 == 0;
		upcomingMatchesList2 = upcomingMatchesList;
		predictAndWinCard2 = predictAndWinCard;
		predictionSeasonModel2 = predictionSeasonModel;
		if (!flag8)
		{
			goto IL_00eb;
		}
		goto IL_0224;
		IL_0224:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		upcomingMatchesList = (UpcomingMatchesList)(object)predictAndWinCard2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v30 (UpcomingMatchesList)+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v58+10]");
		flag7 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v58+10]");
		bool flag9 = (byte)(~(nuint)0u) != 0;
		predictAndWinCard = predictAndWinCard2;
		predictionSeasonModel = predictionSeasonModel2;
		IntPtr intPtr2 = default(IntPtr);
		predictionSeasonModel3 = (PredictionSeasonModel)(nint)intPtr2;
		if (!flag9)
		{
			goto IL_028d;
		}
		goto IL_0598;
		IL_00eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v30 (UpcomingMatchesList)+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v66+10]");
		flag7 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v66+10]");
		bool flag10 = (byte)(~(nuint)0u) != 0;
		object obj20 = !flag10;
		if (obj20 != null)
		{
			goto IL_028d;
		}
		predictionSeasonModel3 = (PredictionSeasonModel)(nint)intPtr2;
		predictionSeasonModel2 = predictionSeasonModel;
		goto IL_0598;
		IL_028d:
		object obj21 = this + 48;
		object obj22 = typeof(MemberAchievementClanFeedData) + 2976;
		flag7 = (byte)(int)obj22 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v32 (System.Boolean)+E4]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v32 (System.Boolean)+E4]");
		UnityEngine.Object obj23;
		UnityEngine.Object obj24 = default(UnityEngine.Object);
		if ((nint)0 != 0)
		{
			bool flag11 = (UnityEngine.Object)obj21;
			bool flag12 = !flag11;
			obj23 = obj24;
			if (flag12)
			{
				goto IL_039e;
			}
			predictionSeasonModel3 = null;
			upcomingMatchesList = (UpcomingMatchesList)flag11;
			predictionSeasonModel2 = predictionSeasonModel;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag13 = (UnityEngine.Object)obj21;
			bool flag14 = !flag13;
			object obj25 = !flag14;
			obj23 = (UnityEngine.Object)obj21;
			obj24 = (UnityEngine.Object)obj21;
			predictionSeasonModel3 = null;
			upcomingMatchesList = (UpcomingMatchesList)flag13;
			predictionSeasonModel2 = predictionSeasonModel;
			if (obj25 == null)
			{
				goto IL_039e;
			}
		}
		goto IL_0598;
		IL_10c4:
		NullReferenceException ex2 = new NullReferenceException();
		obj13 = obj14;
		intPtr = num;
		flag6 = flag5;
		obj15 = obj12;
		obj16 = obj17;
		goto IL_124d;
		IL_1633:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X0_v24+8]");
		predictionSeasonModel3 = (PredictionSeasonModel)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v922 @ X0_v24] (should have been resolved before IL gen)");
		object obj26 = obj14;
		num = intPtr;
		object obj28;
		object obj27 = obj28;
		object obj30;
		object obj29 = obj30;
		object obj32;
		object obj31 = obj32;
		object obj34;
		object obj33 = obj34;
		flag5 = flag6;
		object obj35 = obj17;
		RectTransform rectTransform2;
		RectTransform rectTransform = rectTransform2;
		UnityEngine.Object obj36 = obj24;
		object obj38;
		object obj37 = obj38;
		object obj40;
		object obj39 = obj40;
		goto IL_157f;
		IL_039e:
		object obj41 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj42 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v46+E4]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v46+E4]");
		bool flag15 = (nint)0 == 0;
		object obj43 = !flag15;
		UnityEngine.Object obj44 = bannerPrefab;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			rectTransform2 = cardsContainer;
			obj23 = bannerPrefab;
			obj44 = bannerPrefab;
		}
		object obj45 = (nint)0 + (nint)600;
		obj12 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		PredictionSeasonModel predictionSeasonModel4 = default(PredictionSeasonModel);
		obj21 = predictionSeasonModel4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459C]");
		object obj46 = (nint)0 & (nint)1;
		nint num2;
		if (obj46 != null)
		{
			num2 = (nint)predictAndWinCard;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v89 (Il2CppClass<PredictAndWinCard>)+E4]");
			bool flag16 = (byte)(~(nuint)0u) != 0;
			nint num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v89 (Il2CppClass<PredictAndWinCard>)+E4]");
			flag7 = false;
			if (!flag16)
			{
				goto IL_0471;
			}
		}
		else
		{
			_ = 1;
			nint num3 = (nint)predictAndWinCard;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X0_v82 (Il2CppClass<PredictAndWinCard>)+E4]");
			bool flag17 = (byte)(~(nuint)0u) != 0;
			object obj47 = !flag17;
			num2 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X0_v82 (Il2CppClass<PredictAndWinCard>)+E4]");
			flag7 = false;
			if (obj47 != null)
			{
				goto IL_0471;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		nint num4 = (nint)predictAndWinCard;
		bool flag18 = obj21 == null;
		obj24 = obj23;
		predictionSeasonModel3 = predictionSeasonModel4;
		if (!flag18)
		{
			goto IL_0546;
		}
		goto IL_13f8;
		IL_1166:
		NullReferenceException ex3 = new NullReferenceException();
		obj13 = obj14;
		intPtr = num;
		flag6 = flag5;
		obj16 = obj17;
		MatchPredictionModel matchPredictionModel = default(MatchPredictionModel);
		predictionSeasonModel3 = (PredictionSeasonModel)matchPredictionModel.<id>k__BackingField;
		goto IL_124d;
		IL_1130:
		NullReferenceException ex4 = new NullReferenceException();
		obj13 = obj14;
		intPtr = num;
		flag6 = flag5;
		obj15 = obj12;
		obj16 = obj17;
		goto IL_124d;
		IL_157f:
		object obj49;
		object obj50 = default(object);
		object obj52;
		while (true)
		{
			bool flag19 = obj39 == null;
			object obj48 = !flag19;
			obj14 = obj26;
			intPtr = num;
			obj28 = obj27;
			obj30 = obj29;
			obj32 = obj31;
			obj34 = obj33;
			flag6 = flag5;
			obj12 = obj49;
			obj17 = obj35;
			rectTransform2 = rectTransform;
			obj24 = obj36;
			if (obj48 != null)
			{
				OutOfMemoryException ex5 = new OutOfMemoryException();
				if ((nint)predictionSeasonModel3 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj40 = obj50;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					bool flag20 = obj3 == null;
					object obj51 = !flag20;
					obj11 = obj50;
					obj52 = obj3;
					obj38 = 0;
					if (obj51 == null)
					{
						obj26 = obj14;
						num = intPtr;
						obj27 = obj28;
						obj29 = obj30;
						obj31 = obj32;
						obj33 = obj34;
						flag5 = flag6;
						obj11 = obj50;
						obj49 = obj12;
						obj35 = obj17;
						rectTransform = rectTransform2;
						obj36 = obj24;
						obj37 = 0;
						obj39 = obj50;
						continue;
					}
					goto IL_0da2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return;
			}
			break;
		}
		if ((nint)obj37 != 6)
		{
			bool flag21 = obj37 == null;
			object obj53 = !flag21;
			if (obj53 != null)
			{
				return;
			}
		}
		object obj54 = (nint)0 + (nint)2264;
		UpcomingMatchesList upcomingMatchesList3 = default(UpcomingMatchesList);
		IEnumerable<MatchPredictionModel> upcomingMatchModels = upcomingMatchesList3.UpcomingMatchModels;
		predictionSeasonModel3 = (PredictionSeasonModel)obj54;
		bool flag22 = Enumerable.Any((IEnumerable<object>)upcomingMatchModels);
		bool flag23 = (object)emptyState == null;
		obj14 = obj26;
		intPtr = num;
		obj28 = obj27;
		obj30 = obj29;
		obj32 = obj31;
		obj34 = obj33;
		flag6 = flag5;
		obj12 = obj49;
		obj17 = obj35;
		rectTransform2 = rectTransform;
		obj24 = obj36;
		if (!flag23)
		{
			object obj55 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1648;
			bool active = (byte)((flag22 ? 1u : 0u) ^ 1u) != 0;
			emptyState.SetActive(active);
			object obj56 = obj55;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v962 @ X0_v6+E4]");
			bool flag24 = (nint)0 == 0;
			object obj57 = !flag24;
			if (obj57 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(cardsContainer);
			_isInitialized = true;
			bool flag25 = (object)loadingIndicator == null;
			obj14 = obj26;
			intPtr = num;
			obj28 = obj27;
			obj30 = obj29;
			obj32 = obj31;
			obj34 = obj33;
			flag6 = flag5;
			obj12 = null;
			obj17 = obj35;
			rectTransform2 = rectTransform;
			obj24 = obj36;
			predictionSeasonModel3 = null;
			flag7 = true;
			if (!flag25)
			{
				loadingIndicator.FinishLoading();
				return;
			}
		}
		goto IL_13f8;
		IL_11d7:
		NullReferenceException ex6 = new NullReferenceException();
		obj13 = obj14;
		intPtr = num;
		flag6 = flag5;
		obj15 = null;
		obj16 = obj17;
		predictionSeasonModel3 = (PredictionSeasonModel)(object)matchPredictionModel;
		goto IL_124d;
		IL_10fa:
		NullReferenceException ex7 = new NullReferenceException();
		obj13 = obj14;
		intPtr = num;
		flag6 = flag5;
		obj15 = obj12;
		obj16 = obj17;
		goto IL_124d;
		IL_0471:
		bool flag26 = obj21 == null;
		object obj58 = !flag26;
		num4 = num2;
		if (obj58 != null)
		{
			goto IL_0546;
		}
		obj24 = obj23;
		predictionSeasonModel3 = predictionSeasonModel4;
		goto IL_13f8;
		IL_0546:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v80 (Il2CppClass<PredictAndWinCard>)+B8]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v51 (Il2CppStaticFields<PredictAndWinCard>)+10]");
		predictionSeasonModel3 = (PredictionSeasonModel)0;
		object obj59 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v51 (Il2CppStaticFields<PredictAndWinCard>)+10]");
		((PredictionSeasonBanner)obj59).Initialize((PredictionSeasonModel)0);
		obj24 = obj23;
		upcomingMatchesList = (UpcomingMatchesList)obj21;
		predictionSeasonModel2 = predictionSeasonModel;
		goto IL_0598;
		IL_0da2:
		object obj60 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj61 = obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v11+12E]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v11+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0e5a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v11+B0]");
		object obj62 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X10_v9-8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X10_v9-8]");
			if (0 == (nint)obj60)
			{
				break;
			}
			obj17 = obj62 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v11+12E]");
			obj7 = -1;
			bool flag27 = (nint)obj7 != 1;
			obj62 = obj17;
			if (flag27)
			{
				continue;
			}
			goto IL_0e5a;
		}
		obj7 = obj62;
		object obj63 = obj61 + obj62;
		object obj64 = obj63 + 312;
		obj49 = obj12;
		obj17 = obj62;
		goto IL_1633;
		IL_1212:
		NullReferenceException ex8 = new NullReferenceException();
		obj13 = obj14;
		intPtr = num;
		flag6 = flag5;
		obj16 = obj17;
		predictionSeasonModel3 = (PredictionSeasonModel)matchPredictionModel.<id>k__BackingField;
		goto IL_124d;
		IL_080f:
		rectTransform2 = (RectTransform)(typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528);
		obj34 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 904;
		obj32 = (nint)0 + (nint)1304;
		obj30 = (nint)0 + (nint)1312;
		obj28 = (nint)0 + (nint)592;
		obj24 = (UnityEngine.Object)((nint)0 + (nint)1320);
		num = intPtr;
		object obj65 = obj9;
		bool flag29 = default(bool);
		object obj70 = default(object);
		object obj75 = default(object);
		PredictAndWinCard predictAndWinCard3 = default(PredictAndWinCard);
		while (true)
		{
			object obj66 = obj65;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v23+12E]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v23+12E]");
			if ((nint)0 == 0)
			{
				goto IL_09a9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v23+B0]");
			object obj67 = (nint)0 + (nint)8;
			bool flag28 = flag29;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X10_v25-8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X10_v25-8]");
				object obj68 = 0 - rectTransform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X10_v25-8]");
				if (0 == (nint)rectTransform2)
				{
					break;
				}
				obj17 = obj67 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v23+12E]");
				obj7 = -1;
				obj68 = obj7 - 1;
				bool flag30 = obj68 == null;
				flag29 = (nint)obj7 != 1;
				flag28 = flag29;
				obj67 = obj17;
				if (flag29)
				{
					continue;
				}
				goto IL_09a9;
			}
			obj7 = obj67;
			object obj69 = obj66 + obj67;
			obj70 = obj69 + 312;
			flag29 = flag28;
			obj17 = obj67;
			goto IL_14a3;
			IL_14a3:
			flag7 = (byte)(int)obj70 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X0_v37+8]");
			predictionSeasonModel3 = (PredictionSeasonModel)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v715 @ X0_v37] (should have been resolved before IL gen)");
			object obj71 = upcomingMatchesList3 & 1;
			if (obj71 == null)
			{
				break;
			}
			if (obj3 == null)
			{
				goto IL_10fa;
			}
			object obj72 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X8_v26+12E]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X8_v26+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0aea;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X8_v26+B0]");
			object obj73 = (nint)0 + (nint)8;
			bool flag31 = flag29;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ X10_v20-8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ X10_v20-8]");
				object obj68 = 0 - obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ X10_v20-8]");
				if (0 == (nint)obj34)
				{
					break;
				}
				obj17 = obj73 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X8_v26+12E]");
				obj7 = -1;
				obj68 = obj7 - 1;
				bool flag30 = obj68 == null;
				flag29 = (nint)obj7 != 1;
				flag31 = flag29;
				obj73 = obj17;
				if (flag29)
				{
					continue;
				}
				goto IL_0aea;
			}
			obj7 = obj73;
			object obj74 = obj72 + obj73;
			obj75 = obj74 + 312;
			flag29 = flag31;
			obj17 = obj73;
			goto IL_1540;
			IL_1540:
			flag7 = (byte)(int)obj75 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X0_v41+8]");
			predictionSeasonModel3 = (PredictionSeasonModel)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v953 @ X0_v41] (should have been resolved before IL gen)");
			if (matchPredictionModel == null)
			{
				goto IL_10c4;
			}
			if (_cards != null)
			{
				obj15 = obj32;
				MatchPredictionModel matchPredictionModel2;
				if (((Dictionary<int, object>)(object)_cards).ContainsKey(matchPredictionModel.<id>k__BackingField))
				{
					if (_cards == null)
					{
						goto IL_1212;
					}
					obj15 = obj30;
					object obj76 = ((Dictionary<int, object>)(object)_cards).get_Item(matchPredictionModel.<id>k__BackingField);
					if (obj76 == null)
					{
						goto IL_1166;
					}
					((PredictAndWinCard)obj76).Populate(matchPredictionModel);
					obj12 = null;
					matchPredictionModel2 = matchPredictionModel;
				}
				else
				{
					predictionSeasonModel2 = (PredictionSeasonModel)(object)cardsContainer;
					object obj77 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj78 = obj77;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ X0_v48+E4]");
					bool flag32 = (byte)(~(nuint)0u) != 0;
					object obj79 = !flag32;
					if (obj79 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					obj15 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
					if ((object)predictAndWinCard3 == null)
					{
						goto IL_11a1;
					}
					predictAndWinCard3.Populate(matchPredictionModel);
					if (_cards == null)
					{
						goto IL_11d7;
					}
					num = (nint)obj24;
					((Dictionary<int, object>)(object)_cards).set_Item(matchPredictionModel.<id>k__BackingField, (object)predictAndWinCard3);
					obj12 = predictAndWinCard3;
					matchPredictionModel2 = (MatchPredictionModel)matchPredictionModel.<id>k__BackingField;
				}
				bool flag33 = obj3 == null;
				obj65 = obj3;
				obj13 = obj14;
				intPtr = num;
				flag6 = flag5;
				obj15 = obj12;
				obj16 = obj17;
				predictionSeasonModel3 = (PredictionSeasonModel)(object)matchPredictionModel2;
				if (!flag33)
				{
					continue;
				}
				goto IL_10b6;
			}
			goto IL_1130;
			IL_0aea:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj12 = null;
			goto IL_1540;
			IL_09a9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj12 = null;
			goto IL_14a3;
		}
		bool flag34 = obj3 == null;
		intPtr = num;
		flag6 = flag5;
		obj52 = obj3;
		obj38 = 6;
		obj40 = 0;
		obj26 = obj14;
		obj27 = obj28;
		obj29 = obj30;
		obj31 = obj32;
		obj33 = obj34;
		obj49 = obj12;
		obj35 = obj17;
		rectTransform = rectTransform2;
		obj36 = obj24;
		obj37 = 6;
		obj39 = 0;
		if (!flag34)
		{
			goto IL_0da2;
		}
		goto IL_157f;
		IL_0598:
		IEnumerable<MatchPredictionModel> upcomingMatchModels2 = upcomingMatchesList.UpcomingMatchModels;
		if (upcomingMatchModels2 != null)
		{
			object obj80 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3488;
			nint num6 = (nint)upcomingMatchModels2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v18 (Il2CppClass<System.Collections.Generic.IEnumerable`1<MatchPredictionModel>>)+12E]");
			object obj81 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v18 (Il2CppClass<System.Collections.Generic.IEnumerable`1<MatchPredictionModel>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_06a6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v18 (Il2CppClass<System.Collections.Generic.IEnumerable`1<MatchPredictionModel>>)+B0]");
			obj16 = (nint)0 + (nint)8;
			bool flag35 = flag29;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X10_v11-8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X10_v11-8]");
				object obj68 = 0 - obj80;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X10_v11-8]");
				if (0 == (nint)obj80)
				{
					break;
				}
				obj17 = obj16 + 16;
				obj81--;
				obj68 = obj81 - 1;
				bool flag30 = obj68 == null;
				flag29 = (nint)obj81 != 1;
				flag35 = flag29;
				obj16 = obj17;
				if (flag29)
				{
					continue;
				}
				goto IL_06a6;
			}
			object obj82 = num6 + obj16;
			object obj83 = obj82 + 312;
			obj7 = obj83;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v38+8]");
			predictionSeasonModel3 = (PredictionSeasonModel)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v439 @ X8_v38] (should have been resolved before IL gen)");
			bool flag36 = obj9 == null;
			flag5 = (byte)(&obj3) != 0;
			obj11 = 0;
			flag29 = flag35;
			obj17 = obj16;
			obj3 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X10_v11-8]");
			obj13 = 0;
			flag6 = (byte)(&obj3) != 0;
			obj11 = 0;
			obj15 = obj12;
			obj3 = obj9;
			flag7 = (byte)(&obj3) != 0;
			if (!flag36)
			{
				goto IL_080f;
			}
			goto IL_10b6;
		}
		goto IL_13f8;
		IL_0e5a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj49 = null;
		goto IL_1633;
		IL_10b6:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_124d;
		IL_124d:
		obj14 = obj13;
		obj12 = obj15;
		obj17 = obj16;
		goto IL_13f8;
	}

	private void OnPredictionSubmitted(UserMatchPredictionModel model)
	{
		IEnumerable<MatchPredictionModel> upcomingMatchModels = UpcomingMatchModels;
		if (!Enumerable.Any((IEnumerable<object>)upcomingMatchModels))
		{
			emptyState.SetActive(value: true);
		}
	}

	public UpcomingMatchesList()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<int, object> dictionary = default(Dictionary<int, object>);
		dictionary..ctor();
		object obj2 = this + 40;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <Start>b__13_0()
	{
		if (!_isInitialized)
		{
			loadingIndicator.StartLoading();
		}
	}
}
