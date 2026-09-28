using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using PredictAndWinModel;
using TMPro;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class PredictAndWinCard : MonoBehaviour
{
	private sealed class <>c__DisplayClass42_0
	{
		public int team1Score;

		public int team2Score;

		internal bool <ValidatedScore>b__0((int, int) t)
		{
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			if (team1Score == (nint)t)
			{
				object obj = (object)t >> 32;
				object obj2 = team2Score - obj;
				return obj2 == null;
			}
			return false;
		}

		internal (int, int) <ValidatedScore>b__1((int, int) x, (int, int) y)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0092: Expected O, but got I4
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Expected O, but got Unknown
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			//IL_0141: Expected O, but got I4
			//IL_0036: Unsupported input type for neg.
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_0044: Unsupported input type for neg.
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			int num = team1Score;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num = team1Score;
			}
			object obj4 = x - team1Score;
			if ((nint)x < team1Score)
			{
				obj4 = 0 - obj4;
			}
			object obj5 = y - num;
			if (y < obj5)
			{
				obj5 = 0 - obj5;
			}
			object obj6 = obj4 - obj5;
			bool flag2 = (nint)obj6 < 0;
			object obj7 = obj4 ^ obj5;
			object obj8 = obj4 ^ obj6;
			object obj9 = obj7 & obj8;
			bool flag3 = (nint)obj9 < 0;
			bool flag4 = flag2 == flag3;
			object obj10 = !flag4;
			object obj11 = ~obj10;
			if (obj11 == null)
			{
				return x;
			}
			return y;
		}

		internal (int, int) <ValidatedScore>b__3((int, int) x, (int, int) y)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0097: Expected O, but got I4
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
			//IL_0146: Expected O, but got I4
			//IL_0036: Unsupported input type for neg.
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_0044: Unsupported input type for neg.
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			//IL_0176: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			int num = team2Score;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num = team2Score;
			}
			object obj4 = (object)y >> 32;
			object obj5 = (object)x >> 32;
			object obj6 = obj5 - team2Score;
			if ((nint)obj5 < team2Score)
			{
				obj6 = 0 - obj6;
			}
			object obj7 = obj4 - num;
			if (obj4 < obj7)
			{
				obj7 = 0 - obj7;
			}
			object obj8 = obj6 - obj7;
			bool flag2 = (nint)obj8 < 0;
			object obj9 = obj6 ^ obj7;
			object obj10 = obj6 ^ obj8;
			object obj11 = obj9 & obj10;
			bool flag3 = (nint)obj11 < 0;
			bool flag4 = flag2 == flag3;
			object obj12 = !flag4;
			object obj13 = ~obj12;
			(int, int) result = ((obj13 != null) ? y : x);
			bool flag5 = flag2 == flag3;
			object obj14 = !flag5;
			object obj15 = ~obj14;
			if (obj15 == null)
			{
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
			return result;
		}

		internal (int, int) <ValidatedScore>b__4((int, int) x, (int, int) y)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0097: Expected O, but got I4
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
			//IL_0146: Expected O, but got I4
			//IL_0036: Unsupported input type for neg.
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_0044: Unsupported input type for neg.
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			//IL_0176: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			int num = team2Score;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num = team2Score;
			}
			object obj4 = (object)y >> 32;
			object obj5 = (object)x >> 32;
			object obj6 = obj5 - team2Score;
			if ((nint)obj5 < team2Score)
			{
				obj6 = 0 - obj6;
			}
			object obj7 = obj4 - num;
			if (obj4 < obj7)
			{
				obj7 = 0 - obj7;
			}
			object obj8 = obj6 - obj7;
			bool flag2 = (nint)obj8 < 0;
			object obj9 = obj6 ^ obj7;
			object obj10 = obj6 ^ obj8;
			object obj11 = obj9 & obj10;
			bool flag3 = (nint)obj11 < 0;
			bool flag4 = flag2 == flag3;
			object obj12 = !flag4;
			object obj13 = ~obj12;
			(int, int) result = ((obj13 != null) ? y : x);
			bool flag5 = flag2 == flag3;
			object obj14 = !flag5;
			object obj15 = ~obj14;
			if (obj15 == null)
			{
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
			return result;
		}

		internal (int, int) <ValidatedScore>b__6((int, int) x, (int, int) y)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0092: Expected O, but got I4
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Expected O, but got Unknown
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			//IL_0141: Expected O, but got I4
			//IL_0036: Unsupported input type for neg.
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_0044: Unsupported input type for neg.
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			int num = team1Score;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num = team1Score;
			}
			object obj4 = x - team1Score;
			if ((nint)x < team1Score)
			{
				obj4 = 0 - obj4;
			}
			object obj5 = y - num;
			if (y < obj5)
			{
				obj5 = 0 - obj5;
			}
			object obj6 = obj4 - obj5;
			bool flag2 = (nint)obj6 < 0;
			object obj7 = obj4 ^ obj5;
			object obj8 = obj4 ^ obj6;
			object obj9 = obj7 & obj8;
			bool flag3 = (nint)obj9 < 0;
			bool flag4 = flag2 == flag3;
			object obj10 = !flag4;
			object obj11 = ~obj10;
			if (obj11 == null)
			{
				return x;
			}
			return y;
		}
	}

	private sealed class <>c__DisplayClass42_1
	{
		public int closestValidValue;

		internal bool <ValidatedScore>b__2((int, int) t)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object obj = closestValidValue - t;
			return obj == null;
		}

		internal bool <ValidatedScore>b__5((int, int) t)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			object obj = (object)t >> 32;
			object obj2 = closestValidValue - obj;
			return obj2 == null;
		}
	}

	private PredictAndWinEventsChannel eventsChannel;

	private LayoutElement Container;

	private LayoutElement Content;

	private Sprite CorrectScoreIcon;

	private Sprite CorrectWinnerIcon;

	private Sprite ParticipationIcon;

	private AssetReferenceGameObject ineligibleReasonPopupPrefab;

	private TextMeshProUGUI LeagueName;

	private DateTimeText remainingTime;

	private GameObject Sponsor;

	private Image SponsorIcon;

	private RotatingLoadingIndicator SponsorLoading;

	private Button ShowGifts;

	private Button PredictMatch;

	private Button PredictionStatus;

	private Button ineligibleStatusButton;

	private GameObject rewardContainer;

	private Image rewardIcon;

	private TextMeshProUGUI rewardText;

	private GameObject seasonalMatchLabel;

	private PredictionCardTeam teamHome;

	private PredictionCardTeam teamAway;

	private MatchPredictionModel <Model>k__BackingField;

	private UserMatchPredictionModel <UserMatchPredictionModel>k__BackingField;

	private const string PredictScore = "Predict Score";

	private const string AwaitingScore = "Awaiting Score";

	private const string CorrectScore = "Correct Score";

	private const string CorrectWin = "Correct Winner";

	private const string WrongPrediction = "Wrong Prediction";

	private const string Unqualified = "Unqualified";

	public MatchPredictionModel Model
	{
		get
		{
			return <Model>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 208;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public UserMatchPredictionModel UserMatchPredictionModel
	{
		get
		{
			return <UserMatchPredictionModel>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 216;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_04a0: Expected I, but got O
		//IL_04b1: Expected O, but got I
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_0033: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_00d3: Expected I, but got O
		//IL_00b1: Expected O, but got I4
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I4
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_032e: Expected O, but got I
		//IL_033c: Expected I, but got O
		//IL_0145: Expected O, but got I4
		//IL_0186: Expected I, but got O
		//IL_0378: Expected O, but got I
		//IL_0386: Expected I, but got O
		//IL_0164: Expected O, but got I4
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected O, but got Unknown
		//IL_03c2: Expected O, but got I
		//IL_03d5: Expected I, but got O
		//IL_0199: Expected O, but got I4
		//IL_0411: Expected O, but got I
		//IL_041f: Expected I, but got O
		//IL_01f8: Expected O, but got I4
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected O, but got Unknown
		//IL_0239: Expected I, but got O
		//IL_0465: Expected O, but got I
		//IL_0473: Expected I, but got O
		//IL_0217: Expected O, but got I4
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected O, but got Unknown
		//IL_0254: Expected O, but got I4
		//IL_05e0: Expected O, but got I4
		//IL_02b3: Expected O, but got I4
		//IL_02bc: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3080;
		object obj2 = (nint)0 + (nint)1576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)1584;
		object obj4 = teamHome + 128;
		Delegate obj5 = (Delegate)obj4;
		object obj8 = default(object);
		object obj9 = default(object);
		Delegate obj13 = default(Delegate);
		Action<object> action2 = default(Action<object>);
		object obj18 = default(object);
		Delegate obj20 = default(Delegate);
		Action<object> action3 = default(Action<object>);
		object obj25 = default(object);
		Delegate obj27 = default(Delegate);
		Action<object> action4 = default(Action<object>);
		object obj33 = default(object);
		Delegate obj35 = default(Delegate);
		while (true)
		{
			Delegate obj6 = Delegate.Combine(obj5, action);
			object obj11;
			Delegate obj12;
			if ((object)obj6 == null)
			{
				object obj7 = 0;
			}
			else
			{
				obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag = obj9 == null;
				object obj10 = !flag;
				object obj7 = obj9;
				if (obj10 == null)
				{
					obj11 = 0;
					obj12 = null;
					goto IL_02df;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			bool flag2 = (object)obj13 == obj5;
			obj5 = obj13;
			if (!flag2)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action2..ctor((object)this, (IntPtr)obj2);
			object obj14 = teamAway + 128;
			Delegate obj15 = (Delegate)obj14;
			while (true)
			{
				Delegate obj16 = Delegate.Combine(obj15, action2);
				if ((object)obj16 == null)
				{
					object obj17 = 0;
				}
				else
				{
					obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag3 = obj18 == null;
					object obj19 = !flag3;
					object obj17 = obj18;
					if (obj19 == null)
					{
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj20 == obj15;
				obj15 = obj20;
				if (!flag4)
				{
					continue;
				}
				goto IL_016e;
			}
			obj11 = 0;
			obj12 = null;
			goto IL_02df;
			IL_016e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action3..ctor((object)this, (IntPtr)obj3);
			object obj21 = teamHome + 136;
			Delegate obj22 = (Delegate)obj21;
			while (true)
			{
				Delegate obj23 = Delegate.Combine(obj22, action3);
				if ((object)obj23 == null)
				{
					object obj24 = 0;
				}
				else
				{
					obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag5 = obj25 == null;
					object obj26 = !flag5;
					object obj24 = obj25;
					if (obj26 == null)
					{
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag6 = (object)obj27 == obj22;
				obj22 = obj27;
				if (!flag6)
				{
					continue;
				}
				goto IL_0221;
			}
			obj11 = 0;
			obj12 = null;
			goto IL_02df;
			IL_02df:
			InvalidCastException ex = new InvalidCastException();
			object obj28 = obj8;
			break;
			IL_0221:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action4..ctor((object)this, (IntPtr)obj3);
			object obj29 = teamAway + 136;
			Delegate obj30 = (Delegate)obj29;
			while (true)
			{
				Delegate obj31 = Delegate.Combine(obj30, action4);
				object obj32;
				if ((object)obj31 == null)
				{
					obj32 = obj8;
					obj28 = 0;
				}
				else
				{
					obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag7 = obj33 == null;
					object obj34 = !flag7;
					obj11 = 0;
					obj12 = null;
					obj32 = obj;
					obj28 = obj33;
					if (obj34 == null)
					{
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag8 = (object)obj35 == obj30;
				obj8 = obj32;
				obj30 = obj35;
				obj11 = 0;
				obj12 = obj35;
				if (flag8)
				{
					goto end_IL_0038;
				}
			}
			goto IL_02df;
			continue;
			end_IL_0038:
			break;
		}
		Button showGifts = ShowGifts;
		object obj36 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj37 = (nint)0 + (nint)1592;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj37);
		showGifts.m_OnClick.AddListener(unityAction);
		Button predictMatch = PredictMatch;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj38 = (nint)0 + (nint)1560;
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj38);
		predictMatch.m_OnClick.AddListener(unityAction2);
		Button predictionStatus = PredictionStatus;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj39 = (nint)0 + (nint)1696;
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(teamHome, (IntPtr)obj39);
		predictionStatus.m_OnClick.AddListener(unityAction3);
		Button button = ineligibleStatusButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj40 = (nint)0 + (nint)1600;
		UnityAction unityAction4 = default(UnityAction);
		unityAction4..ctor(this, (IntPtr)obj40);
		button.m_OnClick.AddListener(unityAction4);
		object obj41 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj42 = (nint)0 + (nint)1568;
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj42);
		eventsChannel.OnPredictionSubmitted += action5;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0357: Expected I, but got O
		//IL_0368: Expected O, but got I
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_0033: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_00d3: Expected I, but got O
		//IL_00b1: Expected O, but got I4
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I4
		//IL_0145: Expected O, but got I4
		//IL_0186: Expected I, but got O
		//IL_0164: Expected O, but got I4
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected O, but got Unknown
		//IL_0199: Expected O, but got I4
		//IL_01f8: Expected O, but got I4
		//IL_0239: Expected I, but got O
		//IL_0217: Expected O, but got I4
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected O, but got Unknown
		//IL_0254: Expected O, but got I4
		//IL_0497: Expected O, but got I4
		//IL_02b3: Expected O, but got I4
		//IL_02bc: Expected O, but got I4
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_031c: Expected O, but got I
		//IL_032a: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3080;
		object obj2 = (nint)0 + (nint)1576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)1584;
		object obj4 = teamHome + 128;
		Delegate obj5 = (Delegate)obj4;
		object obj8 = default(object);
		object obj9 = default(object);
		Delegate obj13 = default(Delegate);
		Action<object> action2 = default(Action<object>);
		object obj18 = default(object);
		Delegate obj20 = default(Delegate);
		Action<object> action3 = default(Action<object>);
		object obj25 = default(object);
		Delegate obj27 = default(Delegate);
		Action<object> action4 = default(Action<object>);
		object obj33 = default(object);
		Delegate obj35 = default(Delegate);
		Action<object> action5 = default(Action<object>);
		object obj32;
		while (true)
		{
			Delegate obj6 = Delegate.Remove(obj5, action);
			if ((object)obj6 == null)
			{
				object obj7 = 0;
			}
			else
			{
				obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag = obj9 == null;
				object obj10 = !flag;
				object obj7 = obj9;
				if (obj10 == null)
				{
					object obj11 = 0;
					Delegate obj12 = null;
					break;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			bool flag2 = (object)obj13 == obj5;
			obj5 = obj13;
			if (!flag2)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action2..ctor((object)this, (IntPtr)obj2);
			object obj14 = teamAway + 128;
			Delegate obj15 = (Delegate)obj14;
			while (true)
			{
				Delegate obj16 = Delegate.Remove(obj15, action2);
				if ((object)obj16 == null)
				{
					object obj17 = 0;
				}
				else
				{
					obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag3 = obj18 == null;
					object obj19 = !flag3;
					object obj17 = obj18;
					if (obj19 == null)
					{
						object obj11 = 0;
						Delegate obj12 = null;
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj20 == obj15;
				obj15 = obj20;
				if (!flag4)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action3..ctor((object)this, (IntPtr)obj3);
				object obj21 = teamHome + 136;
				Delegate obj22 = (Delegate)obj21;
				while (true)
				{
					Delegate obj23 = Delegate.Remove(obj22, action3);
					if ((object)obj23 == null)
					{
						object obj24 = 0;
					}
					else
					{
						obj8 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag5 = obj25 == null;
						object obj26 = !flag5;
						object obj24 = obj25;
						if (obj26 == null)
						{
							object obj11 = 0;
							Delegate obj12 = null;
							break;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					bool flag6 = (object)obj27 == obj22;
					obj22 = obj27;
					if (!flag6)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					action4..ctor((object)this, (IntPtr)obj3);
					object obj28 = teamAway + 136;
					Delegate obj29 = (Delegate)obj28;
					while (true)
					{
						Delegate obj30 = Delegate.Remove(obj29, action4);
						object obj31;
						object obj11;
						Delegate obj12;
						if ((object)obj30 == null)
						{
							obj31 = obj8;
							obj32 = 0;
						}
						else
						{
							obj8 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag7 = obj33 == null;
							object obj34 = !flag7;
							obj11 = 0;
							obj12 = null;
							obj31 = obj;
							obj32 = obj33;
							if (obj34 == null)
							{
								break;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
						bool flag8 = (object)obj35 == obj29;
						obj8 = obj31;
						obj29 = obj35;
						obj11 = 0;
						obj12 = obj35;
						if (flag8)
						{
							object obj36 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3960;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj37 = (nint)0 + (nint)1568;
							action5..ctor((object)this, (IntPtr)obj37);
							eventsChannel.OnPredictionSubmitted -= action5;
							return;
						}
					}
					break;
				}
				break;
			}
			break;
		}
		obj32 = obj8;
		throw new InvalidCastException();
	}

	private void OnPredictionSubmitted(UserMatchPredictionModel userModel)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		MatchPredictionModel <predictionMatch>k__BackingField = userModel.<predictionMatch>k__BackingField;
		MatchPredictionModel matchPredictionModel = <Model>k__BackingField;
		if (<predictionMatch>k__BackingField.<id>k__BackingField == matchPredictionModel.<id>k__BackingField)
		{
			object obj = this + 216;
			obj = userModel;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (obj == null)
			{
				AnimateToMyPredictions();
			}
		}
	}

	private void OnReadyStateChange(PredictionCardTeam team)
	{
		//IL_0016: Expected O, but got I
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_01f8: Expected O, but got I
		//IL_0212: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0258: Expected O, but got I4
		//IL_00ee: Expected O, but got I4
		//IL_011c: Expected O, but got I4
		//IL_0131: Expected O, but got I
		//IL_013a: Expected O, but got I4
		//IL_010e: Expected O, but got I4
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_01b5: Expected O, but got I4
		//IL_02dc: Expected O, but got I
		//IL_02f6: Expected O, but got I4
		//IL_0320: Expected O, but got I
		//IL_03bb: Expected O, but got I4
		//IL_03c4: Expected O, but got I4
		//IL_0376: Expected O, but got I4
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected O, but got Unknown
		//IL_03fc: Expected O, but got I
		//IL_040d: Expected I, but got O
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected O, but got Unknown
		//IL_0450: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64DA]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64DB]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64DB]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v1+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		UnityEngine.Object obj9 = teamHome;
		UnityEngine.Object obj10 = teamHome;
		if (obj8 != null)
		{
			goto IL_00c3;
		}
		goto IL_027a;
		IL_00c3:
		bool flag4 = team == obj9;
		bool flag5 = !flag4;
		object obj11 = !flag5;
		object obj12 = ~obj11;
		if (obj12 == null)
		{
			object obj13 = 200;
		}
		else
		{
			object obj13 = 192;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PredictAndWinCard)+v112 @ X8_v10]");
		object obj14 = 0;
		object obj15 = 152985600;
		object obj16 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		string text = team.scorePrediction.Text;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v14+E4]");
		if ((nint)0 != 0)
		{
			bool flag6 = StringUtil.IsNumber(text);
			bool flag7 = !flag6;
			object obj18 = !flag7;
			if (obj18 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!StringUtil.IsNumber(text))
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X21_v8+4F4]");
		object obj19 = (nint)0 & (nint)1;
		bool flag8 = obj19 == null;
		object obj20 = !flag8;
		if (obj20 == null)
		{
			_ = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X19_v3 (System.Object)+38]");
		string text2 = ((InputFieldTMProUGUI)0).Text;
		object obj21 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v18+E4]");
		if ((nint)0 != 0)
		{
			bool flag9 = StringUtil.IsNumber(text2);
			bool flag10 = !flag9;
			object obj22 = 0;
			if (!flag10)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag11 = StringUtil.IsNumber(text2);
			bool flag12 = !flag11;
			object obj23 = !flag12;
			object obj22 = 0;
			if (obj23 != null)
			{
				return;
			}
		}
		object obj24 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = (nint)0 + (nint)1696;
		Action action = default(Action);
		action..ctor(obj14, (IntPtr)obj25);
		object obj26 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v33+E4]");
		bool flag13 = (nint)0 == 0;
		object obj28 = !flag13;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.2f, action);
		return;
		IL_027a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj9 = obj10;
		goto IL_00c3;
		IL_0082:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v1+E4]");
		bool flag14 = (nint)0 == 0;
		obj9 = teamHome;
		obj10 = teamHome;
		if (!flag14)
		{
			goto IL_00c3;
		}
		goto IL_027a;
	}

	private PredictionCardTeam GetOtherTeam(PredictionCardTeam team)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b2: Expected O, but got I4
		//IL_0055: Expected O, but got I4
		//IL_0083: Expected O, but got I4
		//IL_00cd: Expected O, but got I
		//IL_0075: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = team == teamHome;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			object obj6 = 200;
		}
		else
		{
			object obj6 = 192;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PredictAndWinCard)+v71 @ X8_v5]");
		return (PredictionCardTeam)0;
	}

	private void OnScoreChange(PredictionCardTeam team)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0114: Expected O, but got I4
		//IL_00c8: Expected O, but got I4
		//IL_00d1: Expected O, but got I4
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0169: Expected O, but got I4
		//IL_01e9: Expected O, but got I4
		//IL_0594: Expected O, but got I4
		//IL_0453: Expected O, but got I4
		//IL_052b: Expected O, but got I4
		//IL_02fb: Expected O, but got I4
		//IL_0aac: Expected O, but got I4
		//IL_0618: Expected O, but got I4
		//IL_06f9: Expected O, but got I4
		//IL_036f: Expected O, but got I4
		//IL_06b1: Expected O, but got I4
		//IL_0816: Expected O, but got I4
		//IL_040e: Expected O, but got I4
		//IL_07c7: Expected O, but got I4
		//IL_08ab: Expected O, but got I4
		//IL_08fb: Expected O, but got I4
		//IL_096f: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64DC]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v132+E4]");
			bool flag = (nint)0 == 0;
			obj5 = teamHome;
			obj6 = teamHome;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v132+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = teamHome;
			obj6 = teamHome;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = team == obj6;
		PredictionCardTeam predictionCardTeam = teamHome;
		object obj8 = 0;
		goto IL_0173;
		IL_06fe:
		PredictionCardTeam predictionCardTeam2 = teamHome;
		string text = predictionCardTeam2.scorePrediction.Text;
		object obj10;
		object obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v10+E4]");
		if ((nint)0 != 0)
		{
			if (StringUtil.IsNumber(text))
			{
				goto IL_0777;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = StringUtil.IsNumber(text);
			bool flag5 = !flag4;
			object obj11 = !flag5;
			if (obj11 != null)
			{
				goto IL_0777;
			}
		}
		bool flag6 = false;
		goto IL_0832;
		IL_0832:
		GameObject gameObject = PredictMatch.gameObject;
		gameObject.SetActive(flag6);
		GameObject gameObject2 = PredictionStatus.gameObject;
		bool flag7 = (byte)((flag6 ? 1u : 0u) ^ 1u) != 0;
		gameObject2.SetActive(flag7);
		PredictionCardTeam predictionCardTeam3 = teamHome;
		bool flag8 = !flag7;
		object obj12 = !flag8;
		int result;
		if (obj12 == null)
		{
			string text2 = predictionCardTeam3.scorePrediction.Text;
			bool flag9 = int.TryParse(text2, out result);
			bool flag10 = !flag9;
			object obj13 = !flag10;
			object obj14 = ~obj13;
			int team1Score = ((obj14 == null) ? result : 0);
			PredictionCardTeam predictionCardTeam4 = teamAway;
			string text3 = predictionCardTeam4.scorePrediction.Text;
			bool flag11 = int.TryParse(text3, out result);
			bool flag12 = !flag11;
			object obj15 = !flag12;
			object obj16 = ~obj15;
			int team2Score = ((obj16 == null) ? result : 0);
			AssignWinnerOrDrawTags(team1Score, team2Score, isFinal: false);
		}
		else
		{
			GameObject gameObject3 = predictionCardTeam3.winStateNotch.gameObject;
			gameObject3.SetActive(value: false);
			PredictionCardTeam predictionCardTeam5 = teamAway;
			GameObject gameObject4 = predictionCardTeam5.winStateNotch.gameObject;
			gameObject4.SetActive(value: false);
		}
		return;
		IL_06e3:
		InputFieldTMProUGUI scorePrediction;
		string text4;
		scorePrediction.Text = text4;
		obj8 = 0;
		goto IL_06fe;
		IL_0091:
		flag3 = team == obj5;
		predictionCardTeam = teamHome;
		bool flag13 = (object)teamHome == null;
		object obj17 = !flag13;
		obj8 = 0;
		if (obj17 == null)
		{
			goto IL_0a05;
		}
		goto IL_0173;
		IL_0173:
		obj10 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		string text5 = predictionCardTeam.scorePrediction.Text;
		object obj18 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			bool flag14 = StringUtil.IsNumber(text5);
			bool flag15 = !flag14;
			object obj19 = !flag15;
			if (obj19 != null)
			{
				goto IL_0231;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (StringUtil.IsNumber(text5))
			{
				goto IL_0231;
			}
		}
		goto IL_0461;
		IL_0777:
		PredictionCardTeam predictionCardTeam6 = teamAway;
		string text6 = predictionCardTeam6.scorePrediction.Text;
		object obj20 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X8_v23+E4]");
		bool flag16 = (nint)0 == 0;
		object obj21 = !flag16;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag17 = StringUtil.IsNumber(text6);
		flag6 = flag17;
		goto IL_0832;
		IL_0660:
		PredictionCardTeam predictionCardTeam7 = teamAway;
		string text7 = predictionCardTeam7.scorePrediction.Text;
		bool flag18 = int.TryParse(text7, out result);
		bool flag19 = !flag18;
		object obj22 = !flag19;
		object obj23 = ~obj22;
		int team2Score2 = ((obj23 == null) ? result : 0);
		int updatedTeamIndex = (flag3 ? 1 : 0) ^ 1;
		(int, int) tuple = ValidatedScore(0, team2Score2, updatedTeamIndex);
		scorePrediction = predictionCardTeam7.scorePrediction;
		text4 = result.ToString();
		goto IL_06e3;
		IL_0231:
		PredictionCardTeam predictionCardTeam8 = teamAway;
		string text8 = predictionCardTeam8.scorePrediction.Text;
		object obj24 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v41+E4]");
		if ((nint)0 != 0)
		{
			if (StringUtil.IsNumber(text8))
			{
				goto IL_02aa;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag20 = StringUtil.IsNumber(text8);
			bool flag21 = !flag20;
			object obj25 = !flag21;
			if (obj25 != null)
			{
				goto IL_02aa;
			}
		}
		goto IL_0461;
		IL_04da:
		PredictionCardTeam predictionCardTeam9 = teamHome;
		string text9 = predictionCardTeam9.scorePrediction.Text;
		bool flag22 = int.TryParse(text9, out result);
		bool flag23 = !flag22;
		object obj26 = !flag23;
		object obj27 = ~obj26;
		int team1Score2 = ((obj27 == null) ? result : 0);
		updatedTeamIndex = (flag3 ? 1 : 0) ^ 1;
		(int, int) tuple2 = ValidatedScore(team1Score2, 0, updatedTeamIndex);
		scorePrediction = predictionCardTeam9.scorePrediction;
		text4 = result.ToString();
		bool flag24 = (object)predictionCardTeam9.scorePrediction == null;
		object obj28 = !flag24;
		if (obj28 != null)
		{
			goto IL_06e3;
		}
		goto IL_0a05;
		IL_0461:
		PredictionCardTeam predictionCardTeam10 = teamHome;
		string text10 = predictionCardTeam10.scorePrediction.Text;
		object obj29 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v30+E4]");
		if ((nint)0 != 0)
		{
			if (StringUtil.IsNumber(text10))
			{
				goto IL_04da;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag25 = StringUtil.IsNumber(text10);
			bool flag26 = !flag25;
			object obj30 = !flag26;
			if (obj30 != null)
			{
				goto IL_04da;
			}
		}
		PredictionCardTeam predictionCardTeam11 = teamAway;
		string text11 = predictionCardTeam11.scorePrediction.Text;
		object obj31 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v33+E4]");
		if ((nint)0 != 0)
		{
			bool flag27 = StringUtil.IsNumber(text11);
			bool flag28 = !flag27;
			object obj32 = !flag28;
			if (obj32 != null)
			{
				goto IL_0660;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (StringUtil.IsNumber(text11))
			{
				goto IL_0660;
			}
		}
		goto IL_06fe;
		IL_02aa:
		PredictionCardTeam predictionCardTeam12 = teamHome;
		string text12 = predictionCardTeam12.scorePrediction.Text;
		bool flag29 = int.TryParse(text12, out result);
		bool flag30 = !flag29;
		object obj33 = !flag30;
		object obj34 = ~obj33;
		int team1Score3 = ((obj34 == null) ? result : 0);
		PredictionCardTeam predictionCardTeam13 = teamAway;
		string text13 = predictionCardTeam13.scorePrediction.Text;
		bool flag31 = int.TryParse(text13, out result);
		bool flag32 = !flag31;
		object obj35 = !flag32;
		object obj36 = ~obj35;
		int team2Score3 = ((obj36 == null) ? result : 0);
		updatedTeamIndex = (flag3 ? 1 : 0) ^ 1;
		(int, int) tuple3 = ValidatedScore(team1Score3, team2Score3, updatedTeamIndex);
		PredictionCardTeam predictionCardTeam14 = teamHome;
		string text14 = result.ToString();
		predictionCardTeam14.scorePrediction.Text = text14;
		PredictionCardTeam predictionCardTeam15 = teamAway;
		scorePrediction = predictionCardTeam15.scorePrediction;
		text4 = result.ToString();
		bool flag33 = (object)predictionCardTeam15.scorePrediction == null;
		object obj37 = !flag33;
		if (obj37 != null)
		{
			goto IL_06e3;
		}
		goto IL_0a05;
		IL_0a05:
		throw new NullReferenceException();
	}

	private (int, int) ValidatedScore(int team1Score, int team2Score, int updatedTeamIndex)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01ba: Expected O, but got I
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected I4, but got Unknown
		//IL_01dd: Expected O, but got I4
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected I4, but got Unknown
		//IL_023c: Expected O, but got I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_073d: Expected O, but got I
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected I4, but got Unknown
		//IL_0760: Expected O, but got I4
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Expected I4, but got Unknown
		//IL_07bf: Expected O, but got I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I
		//IL_0118: Expected I, but got O
		//IL_0138: Expected I4, but got O
		//IL_0152: Expected O, but got I
		//IL_015a: Expected I4, but got O
		//IL_02c0: Expected O, but got I4
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_061f: Expected O, but got I4
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected O, but got Unknown
		//IL_04cd: Expected O, but got I
		//IL_04de: Expected I, but got O
		//IL_04ea: Expected O, but got I
		//IL_04f2: Expected I4, but got O
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected O, but got Unknown
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Expected O, but got Unknown
		//IL_06c0: Expected O, but got I
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_033d: Expected O, but got I
		//IL_034e: Expected I, but got O
		//IL_035a: Expected O, but got I
		//IL_0362: Expected I4, but got O
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected O, but got Unknown
		//IL_05a7: Expected O, but got I
		//IL_05b8: Expected I, but got O
		//IL_05c4: Expected O, but got I
		//IL_05f0: Expected O, but got I
		//IL_07ec: Expected I, but got O
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_0409: Expected O, but got I
		//IL_041a: Expected I, but got O
		//IL_0426: Expected O, but got I
		//IL_0452: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		int num = updatedTeamIndex;
		int item;
		int item2;
		object obj28;
		IEnumerable<(int, int)> source;
		Func<(int, int), (int, int), (int, int)> func3;
		Func<(int, int), (int, int), (int, int)> func4 = default(Func<(int, int), (int, int), (int, int)>);
		if (!flag)
		{
			bool flag2 = <Model>k__BackingField == null;
			num = updatedTeamIndex;
			if (!flag2)
			{
				List<(int, int)> validScores = <Model>k__BackingField.GetValidScores();
				if (validScores == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Object)+10]");
					object obj3 = ~(nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Object)+10]");
					int num2 = 0 & obj3;
					object obj4 = num2 - 99;
					bool flag3 = (nint)obj4 < 0;
					int num3 = num2 ^ 0x63;
					int num4 = num2 ^ obj4;
					int num5 = num3 & num4;
					bool flag4 = num5 < 0;
					bool flag5 = flag3 == flag4;
					object obj5 = !flag5;
					object obj6 = ~obj5;
					item = ((obj6 != null) ? 99 : num2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Object)+14]");
					object obj7 = ~(nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Object)+14]");
					int num6 = 0 & obj7;
					object obj8 = num6 - 99;
					bool flag6 = (nint)obj8 < 0;
					int num7 = num6 ^ 0x63;
					int num8 = num6 ^ obj8;
					int num9 = num7 & num8;
					bool flag7 = num9 < 0;
					bool flag8 = flag6 == flag7;
					object obj9 = !flag8;
					object obj10 = ~obj9;
					item2 = ((obj10 != null) ? 99 : num6);
					goto IL_0715;
				}
				object obj11 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj12 = default(object);
				obj12..ctor();
				bool flag9 = <Model>k__BackingField == null;
				num = updatedTeamIndex;
				if (!flag9)
				{
					object obj13 = typeof(List<Tween>) + 3040;
					object obj14 = (nint)0 + (nint)1544;
					List<(int, int)> validScores2 = <Model>k__BackingField.GetValidScores();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Predicate<(int, int)> predicate = default(Predicate<(int, int)>);
					predicate..ctor(obj2, (IntPtr)obj14);
					bool flag10 = validScores2 == null;
					num = 0;
					int num10 = (int)obj14;
					if (!flag10)
					{
						object obj15 = (nint)0 + (nint)3432;
						num10 = (int)obj15;
						if (validScores2.Exists(predicate))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Object)+10]");
							item = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Object)+14]");
							item2 = 0;
							goto IL_0715;
						}
						if (updatedTeamIndex != 1)
						{
							bool flag11 = updatedTeamIndex == 0;
							object obj16 = !flag11;
							num = 0;
							if (obj16 != null)
							{
								object obj17 = 153100288 + 1024;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
								object obj18 = "___# Content push apply failed [{0}]: {1}" + 1256;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
								object obj19 = "tournament_participate_warning_body_with_tickets_warning_daily" + 3456;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
								string format = default(string);
								object arg = default(object);
								object arg2 = default(object);
								string message = string.Format(format, arg, arg2);
								object obj20 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 640;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								ArgumentException ex = default(ArgumentException);
								ex..ctor(message);
								object obj21 = (nint)0 + (nint)1608;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
								return ((int, int))new OutOfMemoryException();
							}
							bool flag12 = <Model>k__BackingField == null;
							num = 0;
							if (!flag12)
							{
								List<(int, int)> validScores3 = <Model>k__BackingField.GetValidScores();
								object obj22 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 616;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj23 = (nint)0 + (nint)1552;
								Func<(int, int), (int, int), (int, int)> func = default(Func<(int, int), (int, int), (int, int)>);
								func..ctor(obj2, (IntPtr)obj23);
								object obj24 = (nint)0 + (nint)1776;
								num10 = (int)obj24;
								(int, int) tuple = Enumerable.Aggregate(validScores3, func);
								bool flag13 = obj12 == null;
								num = 0;
								if (!flag13)
								{
									bool flag14 = <Model>k__BackingField == null;
									num = 0;
									if (!flag14)
									{
										List<(int, int)> validScores4 = <Model>k__BackingField.GetValidScores();
										object obj25 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3888;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										object obj26 = (nint)0 + (nint)1584;
										Func<(int, int), bool> func2 = default(Func<(int, int), bool>);
										func2..ctor(obj12, (IntPtr)obj26);
										object obj27 = (nint)0 + (nint)3216;
										IEnumerable<(int, int)> enumerable = Enumerable.Where(validScores4, func2);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										obj28 = (nint)0 + (nint)1560;
										source = enumerable;
										func3 = func4;
										goto IL_07db;
									}
								}
							}
						}
						else
						{
							bool flag15 = <Model>k__BackingField == null;
							num = 0;
							if (!flag15)
							{
								List<(int, int)> validScores5 = <Model>k__BackingField.GetValidScores();
								object obj29 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 616;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj30 = (nint)0 + (nint)1568;
								Func<(int, int), (int, int), (int, int)> func5 = default(Func<(int, int), (int, int), (int, int)>);
								func5..ctor(obj2, (IntPtr)obj30);
								object obj24 = (nint)0 + (nint)1776;
								num10 = (int)obj24;
								(int, int) tuple2 = Enumerable.Aggregate(validScores5, func5);
								bool flag16 = obj12 == null;
								num = 0;
								if (!flag16)
								{
									object obj31 = (object)tuple2 >> 32;
									bool flag17 = <Model>k__BackingField == null;
									num = 0;
									if (!flag17)
									{
										List<(int, int)> validScores6 = <Model>k__BackingField.GetValidScores();
										object obj32 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3888;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										object obj33 = (nint)0 + (nint)1592;
										Func<(int, int), bool> func6 = default(Func<(int, int), bool>);
										func6..ctor(obj12, (IntPtr)obj33);
										object obj34 = (nint)0 + (nint)3216;
										IEnumerable<(int, int)> enumerable2 = Enumerable.Where(validScores6, func6);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										obj28 = (nint)0 + (nint)1576;
										source = enumerable2;
										func3 = func4;
										goto IL_07db;
									}
								}
							}
						}
					}
				}
			}
		}
		throw new NullReferenceException();
		IL_07db:
		func4..ctor(obj2, (IntPtr)obj28);
		return Enumerable.Aggregate(source, func3);
		IL_0715:
		(int, int) tuple3 = (item, item2);
		(int, int) result = default((int, int));
		return result;
	}

	private void AssignWinnerOrDrawTags(int team1Score, int team2Score, bool isFinal)
	{
		if (team1Score > team2Score)
		{
			PredictionTeamState state = (isFinal ? PredictionTeamState.Winner : PredictionTeamState.PredictedWinner);
			teamHome.SetState(state);
			PredictionCardTeam predictionCardTeam = teamAway;
			GameObject gameObject = predictionCardTeam.winStateNotch.gameObject;
			gameObject.SetActive(value: false);
			return;
		}
		PredictionCardTeam predictionCardTeam2 = teamHome;
		if (team1Score < team2Score)
		{
			GameObject gameObject2 = predictionCardTeam2.winStateNotch.gameObject;
			gameObject2.SetActive(value: false);
			PredictionTeamState state2 = (isFinal ? PredictionTeamState.Winner : PredictionTeamState.PredictedWinner);
			teamAway.SetState(state2);
		}
		else
		{
			PredictionTeamState state3 = (isFinal ? PredictionTeamState.Draw : PredictionTeamState.PredictedDraw);
			predictionCardTeam2.SetState(state3);
			teamAway.SetState(state3);
		}
	}

	public void Populate(MatchPredictionModel model)
	{
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected O, but got Unknown
		//IL_001f: Expected O, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00fe: Expected O, but got I4
		//IL_0621: Expected O, but got I4
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01c1: Expected O, but got I
		//IL_01cf: Expected I, but got O
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_038a: Expected O, but got I4
		//IL_033b: Expected O, but got I4
		//IL_0506: Expected O, but got I4
		//IL_04b7: Expected O, but got I4
		//IL_0540: Expected O, but got I
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		object obj = this + 208;
		obj = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X21_v3-18]");
		((GameObject)0).SetActive(model.<isSeasonMatch>k__BackingField);
		PredictionCardTeam predictionCardTeam = teamHome;
		GameObject gameObject = predictionCardTeam.winStateNotch.gameObject;
		gameObject.SetActive(value: false);
		PredictionCardTeam predictionCardTeam2 = teamAway;
		GameObject gameObject2 = predictionCardTeam2.winStateNotch.gameObject;
		gameObject2.SetActive(value: false);
		FileInfoModel <sponsorLogo>k__BackingField = model.<sponsorLogo>k__BackingField;
		bool flag3;
		GameObject sponsor;
		if (model.<sponsorLogo>k__BackingField != null)
		{
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v39+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = StringsExtensions.IsNullOrEmpty(<sponsorLogo>k__BackingField.<url>k__BackingField);
			flag3 = (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
			sponsor = Sponsor;
			bool flag4 = (object)Sponsor == null;
			object obj5 = !flag4;
			if (obj5 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			sponsor = Sponsor;
			flag3 = false;
		}
		GameObject gameObject3 = sponsor.gameObject;
		gameObject3.SetActive(flag3);
		GameObject gameObject4 = SponsorIcon.gameObject;
		gameObject4.SetActive(value: false);
		if (flag3)
		{
			object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = (nint)0 + (nint)1552;
			Action<bool> action = default(Action<bool>);
			action..ctor((object)this, (IntPtr)obj7);
			UIExtensions.LoadPredictAndWinImage(SponsorIcon, model, ImageCacher.PredictAndWinImageType.SponsorLogo, setNative: false, action, SponsorLoading);
		}
		MatchPredictionModel matchPredictionModel = <Model>k__BackingField;
		League <league>k__BackingField = matchPredictionModel.<league>k__BackingField;
		TextMeshProExtensions.FixArabic(LeagueName, <league>k__BackingField.<leagueName>k__BackingField);
		remainingTime.SetDate(model.<expiryDate>k__BackingField);
		GameObject gameObject5 = PredictMatch.gameObject;
		PredictionCardTeam predictionCardTeam3 = teamHome;
		object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		string text = predictionCardTeam3.scorePrediction.Text;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v15+E4]");
		if ((nint)0 != 0)
		{
			if (StringUtil.IsNumber(text))
			{
				goto IL_02eb;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = StringUtil.IsNumber(text);
			bool flag6 = !flag5;
			object obj10 = !flag6;
			if (obj10 != null)
			{
				goto IL_02eb;
			}
		}
		bool active = false;
		goto IL_03a6;
		IL_02eb:
		PredictionCardTeam predictionCardTeam4 = teamAway;
		string text2 = predictionCardTeam4.scorePrediction.Text;
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v32+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = StringUtil.IsNumber(text2);
		active = flag8;
		goto IL_03a6;
		IL_0467:
		PredictionCardTeam predictionCardTeam5 = teamAway;
		string text3 = predictionCardTeam5.scorePrediction.Text;
		object obj13 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v27+E4]");
		bool flag9 = (nint)0 == 0;
		object obj14 = !flag9;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag10 = StringUtil.IsNumber(text3);
		bool active2 = (byte)((flag10 ? 1u : 0u) ^ 1u) != 0;
		goto IL_0522;
		IL_03a6:
		gameObject5.SetActive(active);
		GameObject gameObject6 = ineligibleStatusButton.gameObject;
		gameObject6.SetActive(value: false);
		GameObject gameObject7 = PredictionStatus.gameObject;
		PredictionCardTeam predictionCardTeam6 = teamHome;
		string text4 = predictionCardTeam6.scorePrediction.Text;
		object obj15 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v19+E4]");
		if ((nint)0 != 0)
		{
			if (StringUtil.IsNumber(text4))
			{
				goto IL_0467;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag11 = StringUtil.IsNumber(text4);
			bool flag12 = !flag11;
			object obj16 = !flag12;
			if (obj16 != null)
			{
				goto IL_0467;
			}
		}
		active2 = true;
		goto IL_0522;
		IL_0522:
		gameObject7.SetActive(active2);
		object obj17 = (nint)0 + (nint)288;
		object text5 = "Picking audio files is not supported on iOS" + 1208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh, (string)text5);
		MatchPredictionModel matchPredictionModel2 = <Model>k__BackingField;
		teamHome.Populate(matchPredictionModel2.<homeTeam>k__BackingField);
		MatchPredictionModel matchPredictionModel3 = <Model>k__BackingField;
		teamAway.Populate(matchPredictionModel3.<awayTeam>k__BackingField);
	}

	public void Populate(UserMatchPredictionModel userMatchPredictionModel)
	{
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_008b: Expected O, but got I4
		//IL_00ff: Expected O, but got I4
		//IL_025e: Expected O, but got I
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_031a: Expected O, but got I4
		//IL_0334: Expected O, but got I4
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_035c: Expected O, but got I4
		//IL_03a4: Expected O, but got I
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected O, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		object obj = this + 216;
		obj = userMatchPredictionModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Populate(userMatchPredictionModel.<predictionMatch>k__BackingField);
		GameObject gameObject = PredictMatch.gameObject;
		gameObject.SetActive(value: false);
		MatchPredictionModel <predictionMatch>k__BackingField = userMatchPredictionModel.<predictionMatch>k__BackingField;
		object obj2 = typeof(DataRelation) + 712;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		bool flag2 = <predictionMatch>k__BackingField.<expiryDate>k__BackingField < now;
		GameObject gameObject2 = PredictionStatus.gameObject;
		bool flag3 = userMatchPredictionModel.<predictionReward>k__BackingField == PredictionRewardType.NotDetermined;
		object obj5 = !flag3;
		object obj6 = ~obj5;
		bool active = obj6 != null && flag2;
		gameObject2.SetActive(active);
		string text;
		if (userMatchPredictionModel.<predictionReward>k__BackingField != PredictionRewardType.NotDetermined)
		{
			UserMatchPredictionModel userMatchPredictionModel2 = <UserMatchPredictionModel>k__BackingField;
			MatchPredictionModel matchPredictionModel = <Model>k__BackingField;
			teamHome.SetFinalScore(userMatchPredictionModel2.<homeTeamScore>k__BackingField, matchPredictionModel.<homeTeamScore>k__BackingField);
			UserMatchPredictionModel userMatchPredictionModel3 = <UserMatchPredictionModel>k__BackingField;
			MatchPredictionModel matchPredictionModel2 = <Model>k__BackingField;
			teamAway.SetFinalScore(userMatchPredictionModel3.<awayTeamScore>k__BackingField, matchPredictionModel2.<awayTeamScore>k__BackingField);
			MatchPredictionModel matchPredictionModel3 = <Model>k__BackingField;
			AssignWinnerOrDrawTags(matchPredictionModel3.<homeTeamScore>k__BackingField, matchPredictionModel3.<awayTeamScore>k__BackingField, isFinal: true);
			if (userMatchPredictionModel.<predictionReward>k__BackingField == PredictionRewardType.Ineligible)
			{
				GameObject gameObject3 = ineligibleStatusButton.gameObject;
				gameObject3.SetActive(value: true);
				rewardContainer.SetActive(value: false);
				return;
			}
			GameObject gameObject4 = ineligibleStatusButton.gameObject;
			gameObject4.SetActive(value: false);
			rewardContainer.SetActive(value: true);
			object obj7 = userMatchPredictionModel.<predictionReward>k__BackingField - 2;
			bool flag4 = (nint)obj7 < 2;
			object obj8 = !flag4;
			object obj9 = obj7 - 2;
			bool flag5 = obj9 == null;
			object obj10 = !flag5;
			object obj11 = obj8 & obj10;
			Sprite sprite = null;
			if (obj11 == null)
			{
				object obj12 = obj7 << 3;
				object obj13 = (object)this + obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v33+38]");
				sprite = (Sprite)0;
			}
			rewardIcon.sprite = sprite;
			object obj14;
			if (userMatchPredictionModel.<predictionReward>k__BackingField <= PredictionRewardType.CorrectScore)
			{
				if (userMatchPredictionModel.<predictionReward>k__BackingField != PredictionRewardType.Ineligible)
				{
					bool flag6 = userMatchPredictionModel.<predictionReward>k__BackingField != PredictionRewardType.CorrectScore;
					text = null;
					if (flag6)
					{
						goto IL_0518;
					}
					obj14 = "Complete" + 1752;
				}
				else
				{
					obj14 = "UInt16" + 3648;
				}
			}
			else if (userMatchPredictionModel.<predictionReward>k__BackingField != PredictionRewardType.CorrectWinner)
			{
				bool flag7 = userMatchPredictionModel.<predictionReward>k__BackingField != PredictionRewardType.Participation;
				text = null;
				if (flag7)
				{
					goto IL_0518;
				}
				obj14 = "WhiteSmoke" + 504;
			}
			else
			{
				obj14 = "Complete" + 1760;
			}
			text = (string)obj14;
			goto IL_0518;
		}
		AssignWinnerOrDrawTags(userMatchPredictionModel.<homeTeamScore>k__BackingField, userMatchPredictionModel.<awayTeamScore>k__BackingField, isFinal: false);
		object obj15 = (nint)0 + (nint)288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		object text2 = "AvailableVoices" + 112;
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh, (string)text2);
		UserMatchPredictionModel userMatchPredictionModel4 = <UserMatchPredictionModel>k__BackingField;
		teamHome.SetPredictedScore(userMatchPredictionModel4.<homeTeamScore>k__BackingField);
		UserMatchPredictionModel userMatchPredictionModel5 = <UserMatchPredictionModel>k__BackingField;
		teamAway.SetPredictedScore(userMatchPredictionModel5.<awayTeamScore>k__BackingField);
		return;
		IL_0518:
		TextMeshProExtensions.Localize(rewardText, text);
	}

	private Sprite GetRewardSprite(PredictionRewardType type)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_0090: Expected O, but got I
		object obj = type - 2;
		bool flag = (nint)obj < 2;
		object obj2 = !flag;
		object obj3 = obj - 2;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = obj << 3;
			object obj7 = (object)this + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X8_v3+38]");
			return (Sprite)0;
		}
		return null;
	}

	private string GetRewardText(PredictionRewardType type)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		string result;
		object obj;
		if (type <= PredictionRewardType.CorrectScore)
		{
			if (type != PredictionRewardType.Ineligible)
			{
				bool flag = type != PredictionRewardType.CorrectScore;
				result = null;
				if (flag)
				{
					goto IL_00f6;
				}
				obj = "Complete" + 1752;
			}
			else
			{
				obj = "UInt16" + 3648;
			}
		}
		else if (type != PredictionRewardType.CorrectWinner)
		{
			bool flag2 = type != PredictionRewardType.Participation;
			result = null;
			if (flag2)
			{
				goto IL_00f6;
			}
			obj = "WhiteSmoke" + 504;
		}
		else
		{
			obj = "Complete" + 1760;
		}
		result = (string)obj;
		goto IL_00f6;
		IL_00f6:
		return result;
	}

	private void OnPredictButtonClicked()
	{
		//IL_01aa: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0082: Expected O, but got I4
		//IL_00f6: Expected O, but got I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_021f: Expected O, but got I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		UserMatchPredictionModel model = <UserMatchPredictionModel>k__BackingField;
		bool flag = <UserMatchPredictionModel>k__BackingField == null;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = typeof(UsageHint) + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UserMatchPredictionModel userMatchPredictionModel = default(UserMatchPredictionModel);
			userMatchPredictionModel..ctor();
			PredictionCardTeam predictionCardTeam = teamHome;
			string text = predictionCardTeam.scorePrediction.Text;
			int result;
			bool flag2 = int.TryParse(text, out result);
			bool flag3 = !flag2;
			object obj3 = !flag3;
			object obj4 = ~obj3;
			int <homeTeamScore>k__BackingField = ((obj4 == null) ? result : 0);
			userMatchPredictionModel.<homeTeamScore>k__BackingField = <homeTeamScore>k__BackingField;
			PredictionCardTeam predictionCardTeam2 = teamAway;
			string text2 = predictionCardTeam2.scorePrediction.Text;
			int result2;
			bool flag4 = int.TryParse(text2, out result2);
			bool flag5 = !flag4;
			object obj5 = !flag5;
			object obj6 = ~obj5;
			int <awayTeamScore>k__BackingField = ((obj6 == null) ? result2 : 0);
			userMatchPredictionModel.<awayTeamScore>k__BackingField = <awayTeamScore>k__BackingField;
			object obj7 = typeof(DataRelation) + 712;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v14+E4]");
			bool flag6 = (nint)0 == 0;
			object obj9 = !flag6;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			object obj10 = userMatchPredictionModel + 40;
			obj10 = <Model>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			model = userMatchPredictionModel;
		}
		eventsChannel.TriggerShowTweetPreview(model);
	}

	private void OnShowGiftsClicked()
	{
		if (<UserMatchPredictionModel>k__BackingField != null)
		{
			eventsChannel.TriggerShowPredictionRewards(<UserMatchPredictionModel>k__BackingField);
		}
		else
		{
			eventsChannel.TriggerShowMatchRewards(<Model>k__BackingField);
		}
	}

	private void ShowIneligibleReasonPopup()
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
		PrefabInitializer.InitializePrefab(ineligibleReasonPopupPrefab, CanvasLayer.SecondaryCanvas);
	}

	private void AnimateToMyPredictions()
	{
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected O, but got Unknown
		//IL_03d5: Expected O, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0011: Expected O, but got I
		//IL_0045: Expected O, but got I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0119: Expected O, but got I4
		//IL_00bd: Expected I, but got O
		//IL_01cc: Expected O, but got I4
		//IL_01ee: Expected O, but got I4
		//IL_020e: Expected O, but got I
		//IL_021a: Expected O, but got I
		//IL_0228: Expected O, but got I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_057d: Expected O, but got I
		//IL_058f: Expected F4, but got O
		//IL_058f: Expected O, but got I4
		//IL_041c: Expected O, but got I4
		//IL_042a: Expected O, but got I4
		//IL_034b: Expected O, but got I4
		//IL_02da: Expected O, but got I
		//IL_04be: Expected O, but got I4
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected O, but got Unknown
		//IL_0381: Expected O, but got I
		//IL_0470: Expected O, but got I4
		//IL_0481: Expected O, but got I4
		//IL_0504: Expected O, but got I
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected O, but got Unknown
		//IL_039c: Expected O, but got I
		//IL_05d4: Expected O, but got I
		//IL_05eb: Expected F4, but got O
		//IL_05eb: Expected O, but got I4
		//IL_0620: Expected O, but got I
		//IL_0639: Expected F4, but got O
		//IL_0639: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		UnityEngine.Object obj5;
		UnityEngine.Object obj7;
		if ((object)Container != null)
		{
			object obj2 = (nint)0 + (nint)216;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v87+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			UnityEngine.Object obj6 = default(UnityEngine.Object);
			obj5 = obj6;
			obj7 = obj6;
			if (obj4 == null)
			{
				goto IL_0063;
			}
		}
		else
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v87+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			obj7 = null;
			if (obj8 == null)
			{
				obj5 = null;
				goto IL_0063;
			}
		}
		goto IL_007a;
		IL_0494:
		object obj10;
		object obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X0_v56+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "___# Content push apply failed [{0}]: {1}" + 880;
		Debug.LogError(message);
		goto IL_04f8;
		IL_035e:
		UnityEngine.Object obj12;
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade((CanvasGroup)obj12, 0f, 0.3f);
		object obj13 = (nint)0 + (nint)2752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		object obj14 = (nint)0 + (nint)2864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		goto IL_04f8;
		IL_0329:
		bool flag4 = obj12 != null;
		bool flag5 = !flag4;
		object obj15 = 0;
		UnityEngine.Object obj16 = null;
		if (!flag5)
		{
			goto IL_035e;
		}
		goto IL_0494;
		IL_0063:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj7 = obj5;
		goto IL_007a;
		IL_007a:
		obj10 = typeof(DataRelation) + 856;
		if (obj7 != null)
		{
			nint num = (nint)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v118 @ X8_v53 (Il2CppClass<UnityEngine.Object>)+358] (should have been resolved before IL gen)");
			float preferredHeight = default(float);
			Container.preferredHeight = preferredHeight;
		}
		else
		{
			object message2 = "___# Content push apply failed [{0}]: {1}" + 976;
			object obj17 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v78+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogError(message2);
		}
		Content.ignoreLayout = true;
		RectTransform rectTransform = UIExtensions.rectTransform(Content);
		PredictAndWinEventsChannel predictAndWinEventsChannel = eventsChannel;
		rectTransform.SetParent(predictAndWinEventsChannel.<CardToHistoryAnimationTarget>k__BackingField, worldPositionStays: true);
		RectTransform rectTransform2 = UIExtensions.rectTransform(Content);
		Vector3 localPosition = rectTransform2.localPosition;
		RectTransform rectTransform3 = UIExtensions.rectTransform(Content);
		rectTransform3.anchorMax = (Vector2)0;
		RectTransform rectTransform4 = UIExtensions.rectTransform(Content);
		rectTransform4.anchorMin = (Vector2)0;
		RectTransform rectTransform5 = UIExtensions.rectTransform(Content);
		object obj19 = (nint)0 + (nint)2872;
		object obj20 = (nint)0 + (nint)2904;
		rectTransform5.localPosition = (Vector3)0;
		RectTransform target = UIExtensions.rectTransform(Content);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOAnchorPosX(target, 0f, 0.6f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		RectTransform target2 = UIExtensions.rectTransform(Content);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = DOTweenModuleUI.DOAnchorPosY(target2, 0f, 0.6f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		RectTransform target3 = UIExtensions.rectTransform(Content);
		object obj21 = typeof(UsageHint) + 816;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v13+B8]");
		object obj23 = 0;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore4 = ShortcutExtensions.DOScale(target3, (Vector3)0, (float)obj23);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		UnityEngine.Object obj28;
		if ((object)Content != null)
		{
			object obj24 = (nint)0 + (nint)3664;
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			object obj26 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v60+E4]");
			bool flag7 = (nint)0 == 0;
			UnityEngine.Object obj27 = default(UnityEngine.Object);
			obj12 = obj27;
			obj28 = obj27;
			if (!flag7)
			{
				goto IL_0329;
			}
		}
		else
		{
			object obj26 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v60+E4]");
			bool flag8 = (nint)0 == 0;
			object obj29 = !flag8;
			obj12 = null;
			object obj25 = 8;
			obj28 = null;
			if (obj29 != null)
			{
				goto IL_0329;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag9 = obj28 != null;
		bool flag10 = !flag9;
		object obj30 = !flag10;
		obj12 = obj28;
		obj15 = 0;
		obj16 = null;
		if (obj30 != null)
		{
			goto IL_035e;
		}
		goto IL_0494;
		IL_04f8:
		object obj31 = (nint)0 + (nint)2760;
		RectTransform target4 = UIExtensions.rectTransform(Container);
		object obj32 = typeof(UsageHint) + 744;
		object obj33 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v20+B8]");
		object obj34 = 0;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore5 = DOTweenModuleUI.DOSizeDelta(target4, (Vector2)0, (float)obj34);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		object obj35 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v24+B8]");
		object obj36 = 0;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore6 = DOTweenModuleUI.DOPreferredSize(Container, (Vector2)0, (float)obj36);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
	}

	private void <Populate>b__44_0(bool isSuccess)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cd: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6475]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = this == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			return;
		}
		goto IL_011d;
		IL_011d:
		GameObject gameObject = SponsorIcon.gameObject;
		gameObject.SetActive(isSuccess);
		return;
		IL_0074:
		if (this == null)
		{
			return;
		}
		goto IL_011d;
	}
}
