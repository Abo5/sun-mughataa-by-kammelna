using System;
using System.Collections;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using KammelnaOffline.Common;
using KammelnaOffline.OfflineServer;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Core;
using Sfs2X.Entities.Data;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.UI;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

namespace KammelnaOffline.Baloot.Tutorial;

public class TutorialGameController : BalootGameController
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Card, bool> <>9__28_0;

		public static Func<Card, int> <>9__28_1;

		public static Func<CardData, int> <>9__30_0;

		public static Func<CardData, Card> <>9__32_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 272;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <GetEatingsSFSArray>b__28_0(Card card)
		{
			bool flag = card == null;
			return !flag;
		}

		internal int <GetEatingsSFSArray>b__28_1(Card card)
		{
			//IL_003d: Expected I4, but got O
			if (card != null)
			{
				return card.AsInt();
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal int <AddArrayCards>b__30_0(CardData cardData)
		{
			//IL_004a: Expected I4, but got O
			Card card = CardDataExtension.ToCard(cardData);
			if (card != null)
			{
				return card.AsInt();
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal Card <GetWantedToPlayCards>b__32_0(CardData data)
		{
			return CardDataExtension.ToCard(data);
		}
	}

	private sealed class <>c__DisplayClass32_0
	{
		public Suit suit;

		internal bool <GetWantedToPlayCards>b__1(Card balootCard)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (balootCard != null)
			{
				object obj = balootCard.<Suit>k__BackingField - suit;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <InitializeTutorialGame>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public TutorialGameController <>4__this;

		private IEnumerator <tutorialGame>5__2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <InitializeTutorialGame>d__16(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0156: Expected I4, but got I8
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Expected O, but got Unknown
			//IL_0199: Expected O, but got I4
			//IL_0392: Unknown result type (might be due to invalid IL or missing references)
			//IL_0397: Expected O, but got Unknown
			//IL_03af: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b4: Expected O, but got Unknown
			//IL_0036: Expected I4, but got I8
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			//IL_0061: Expected I, but got O
			//IL_0071: Expected O, but got I
			//IL_011b: Expected O, but got I4
			//IL_0238: Unknown result type (might be due to invalid IL or missing references)
			//IL_023d: Expected O, but got Unknown
			//IL_0276: Expected O, but got I4
			//IL_00ac: Expected O, but got I
			//IL_032d: Expected I4, but got O
			//IL_013a: Expected O, but got I4
			//IL_02aa: Expected O, but got I
			//IL_02cc: Expected O, but got I4
			//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f6: Expected O, but got Unknown
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Expected O, but got Unknown
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Expected O, but got Unknown
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ea: Expected O, but got Unknown
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected O, but got Unknown
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected O, but got Unknown
			TutorialGameController tutorialGameController = <>4__this;
			object obj8;
			object obj11;
			object obj9;
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					<>1__state = -1;
					IEnumerator enumerator = <tutorialGame>5__2;
					object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
					nint num = (nint)enumerator;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v14 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v14 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_00ed;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v14 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
					object obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X10_v10-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj3 += 16;
						obj2--;
						if ((nint)obj2 != 1)
						{
							continue;
						}
						goto IL_00ed;
					}
					object obj4 = obj3 + 1;
					object obj5 = num + obj4;
					object obj6 = obj5 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v330 @ X0_v32] (should have been resolved before IL gen)");
					object obj7 = default(object);
					bool flag = obj7 == null;
					obj8 = obj7;
					object obj10 = default(object);
					obj9 = obj10;
					obj11 = obj7;
					if (!flag)
					{
						goto IL_0229;
					}
					goto IL_02e2;
				}
			}
			else
			{
				<>1__state = -1;
				object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2288;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj14 = !flag2;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				IEnumerator enumerator2 = TutorialGameAssetFetcher.GeTutorialGame(tutorialGameController.<TutorialType>k__BackingField);
				object obj15 = this + 40;
				obj15 = enumerator2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj16 = this + 24;
				obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 1;
			}
			goto IL_0309;
			IL_00ed:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v292 @ X0_v29] (should have been resolved before IL gen)");
			object obj17 = default(object);
			bool flag3 = obj17 == null;
			object obj18 = !flag3;
			obj8 = obj17;
			if (obj18 != null)
			{
				goto IL_0229;
			}
			obj9 = 1;
			obj11 = obj17;
			goto IL_02e2;
			IL_02e2:
			object obj19 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
			object obj20 = obj19;
			object obj21 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			tutorialGameController.StartGame();
			goto IL_0309;
			IL_0229:
			object obj22 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2280;
			object obj23 = obj22;
			object obj24 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v23+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X1_v11+130]");
			bool flag4 = num2 < 0;
			object obj25 = !flag4;
			object obj26 = ~obj25;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v23+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X1_v11+130]");
				object obj27 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v25-8]");
				bool flag5 = 0 != (nint)obj23;
				obj9 = 1;
				obj11 = obj8;
				if (!flag5)
				{
					goto IL_02e2;
				}
			}
			InvalidCastException ex = new InvalidCastException();
			return (byte)(int)ex != 0;
			IL_0309:
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
			object obj2 = (nint)0 + (nint)928;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private readonly TutorialType <TutorialType>k__BackingField;

	private static TutorialGame <LastTutorialGame>k__BackingField;

	public List<Card> cardsAI2;

	public List<Card> cardsAI3;

	public List<Card> cardsAI4;

	private readonly List<Card[]> _playedCardsList;

	private Card[] _currentHandPlayedCards;

	private int _playCardIndex;

	public TutorialType TutorialType => <TutorialType>k__BackingField;

	public static TutorialGame LastTutorialGame
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			return (TutorialGame)0;
		}
		private set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public TutorialGameController(TutorialType tutorialType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 4008;
		object obj2 = typeof(TypeConverter<ushort, char>) + 1944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = this + 224;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj4 = this + 232;
		object obj5 = default(object);
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		<TutorialType>k__BackingField = tutorialType;
	}

	protected override AbstractAiLogic CreateAiLogic()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		BalootTutorialAiLogic balootTutorialAiLogic = default(BalootTutorialAiLogic);
		balootTutorialAiLogic..ctor(this);
		return balootTutorialAiLogic;
	}

	protected override void InitializeGame()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_002f: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		_ = 0;
		object obj4 = obj3 + 32;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy permanentInstance = CoroutineDummy.PermanentInstance;
		Coroutine coroutine = permanentInstance.StartCoroutine((IEnumerator)obj3);
	}

	private IEnumerator InitializeTutorialGame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private void StartGame()
	{
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01c6: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0048: Expected O, but got I
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_01eb: Expected O, but got I
		//IL_00a0: Expected O, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_0210: Expected O, but got I
		//IL_00f8: Expected O, but got I
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0160: Expected O, but got I
		//IL_0165: Expected I, but got O
		//IL_0175: Expected O, but got I
		//IL_0185: Expected O, but got I
		List<object> list = default(List<object>);
		List<object> list2 = default(List<object>);
		List<object> list3 = default(List<object>);
		while (true)
		{
			ResetTrackLogic();
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v5+B8]");
			object obj3 = 0;
			object obj4 = obj3;
			object obj5 = typeof(List<AdaptivePerformanceScaler>) + 416;
			object obj6 = (nint)0 + (nint)2640;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v7+24]");
			Dealer = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v7+58]");
			List<Card> collection = CardDataExtension.ToCards((List<CardData>)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			list..ctor((IEnumerable<object>)collection);
			object obj7 = this + 200;
			obj7 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v11+B8]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v13+60]");
			List<Card> collection2 = CardDataExtension.ToCards((List<CardData>)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			list2..ctor((IEnumerable<object>)collection2);
			object obj11 = this + 208;
			obj11 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v16+B8]");
			object obj13 = 0;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v18+68]");
			List<Card> collection3 = CardDataExtension.ToCards((List<CardData>)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			list3..ctor((IEnumerable<object>)collection3);
			object obj15 = this + 216;
			obj15 = list3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 150;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v7-68]");
			((OfflineRoom)0).UpdateScore(150, 150);
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v19 (Il2CppClass<KammelnaOffline.Baloot.Tutorial.TutorialGameController>)+1E8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v19 (Il2CppClass<KammelnaOffline.Baloot.Tutorial.TutorialGameController>)+1F0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v124 @ X2_v6 (should have been resolved before IL gen)");
		}
	}

	protected override void CardDistributionFirstPhase()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00e7: Expected O, but got I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_010d: Expected O, but got I
		//IL_0095: Expected O, but got I
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1968;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<Card> allBalootCards = BalootCardUtils.AllBalootCards;
		List<object> list = Enumerable.ToList((IEnumerable<object>)allBalootCards);
		object obj4 = this + 104;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		CardsTutorialFirstPhase();
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+B8]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v8+28]");
		Card card = CardDataExtension.ToCard((CardData)0);
		object obj9 = this + 160;
		obj9 = card;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void CardsTutorialFirstPhase()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_02f8: Expected O, but got I
		//IL_0051: Expected O, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0335: Expected O, but got I
		//IL_00e8: Expected O, but got I
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0185: Expected O, but got I4
		//IL_0195: Expected O, but got I4
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_0372: Expected O, but got I
		//IL_01de: Expected O, but got I
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_03af: Expected O, but got I
		//IL_0275: Expected O, but got I
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		BalootOfflinePlayer[] players = base.Players;
		if (players != null)
		{
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v6+B8]");
			object obj3 = 0;
			object obj4 = obj3;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v8+70]");
				List<Card> list = CardDataExtension.ToCards((List<CardData>)0);
				if (players[0] != null)
				{
					object obj5 = players[0] + 24;
					obj5 = list;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					BalootOfflinePlayer[] players2 = base.Players;
					if (players2 != null)
					{
						object obj6 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v12+B8]");
						object obj7 = 0;
						object obj8 = obj7;
						if (obj7 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v14+88]");
							List<Card> list2 = CardDataExtension.ToCards((List<CardData>)0);
							if (players2[1] != null)
							{
								object obj9 = players2[1] + 24;
								obj9 = list2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								BalootOfflinePlayer[] players3 = base.Players;
								if (players3 != null)
								{
									bool flag = players3.Length < 2;
									object obj10 = !flag;
									object obj11 = players3.Length - 2;
									bool flag2 = obj11 == null;
									object obj12 = ~obj10;
									object obj13 = obj12 | flag2;
									if (obj13 != null)
									{
										goto IL_02d9;
									}
									object obj14 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v18+B8]");
									object obj15 = 0;
									object obj16 = obj15;
									if (obj15 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v20+90]");
										List<Card> list3 = CardDataExtension.ToCards((List<CardData>)0);
										if (players3[2] != null)
										{
											object obj17 = players3[2] + 24;
											obj17 = list3;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											BalootOfflinePlayer[] players4 = base.Players;
											if (players4 != null)
											{
												object obj18 = obj;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v24+B8]");
												object obj19 = 0;
												object obj20 = obj19;
												if (obj19 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v26+98]");
													List<Card> list4 = CardDataExtension.ToCards((List<CardData>)0);
													if (players4[3] != null)
													{
														object obj21 = players4[3] + 24;
														obj21 = list4;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														return;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_02d9;
		IL_02d9:
		throw new IndexOutOfRangeException();
	}

	protected override void CardDistributionSecondPhase()
	{
		//IL_003d: Expected O, but got I4
		//IL_0058: Expected O, but got I4
		//IL_0083: Expected O, but got I
		//IL_00b8: Expected O, but got I
		//IL_014e: Expected O, but got I4
		//IL_01d3: Expected O, but got I
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		BalootOfflinePlayer[] players = base.Players;
		BalootBiddingManager biddingManager = base.BiddingManager;
		if (biddingManager != null)
		{
			int floorCardPlayer = biddingManager.FloorCardPlayer;
			if (players != null)
			{
				object obj = floorCardPlayer - 1;
				bool flag = (nint)obj < players.Length;
				object obj2 = !flag;
				if (obj2 != null)
				{
					goto IL_0283;
				}
				object obj3 = (object)players + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v6+20]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v6+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v7+18]");
					List<object> list = (List<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v7+18]");
					if ((nint)0 != 0)
					{
						int version = list._version + 1;
						list._version = version;
						object[] items = list._items;
						if (list._items != null)
						{
							bool flag2 = list._size < items.Length;
							object obj5 = !flag2;
							if (obj5 == null)
							{
								int size = list._size + 1;
								list._size = size;
								object obj6 = list._items + list._size;
								object obj7 = obj6 + 32;
								obj7 = FloorCard;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v7+18]");
								((List<object>)0).AddWithResize((object)FloorCard);
							}
							CardsTutorialSecPhase();
							List<Card> deck = Deck;
							if (Deck != null)
							{
								int version2 = deck._version + 1;
								deck._size = 0;
								deck._version = version2;
								if (deck._size >= 1)
								{
									Array.Clear(deck._items, 0, deck._size);
								}
								return;
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0283;
		IL_0283:
		throw new IndexOutOfRangeException();
	}

	private void CardsTutorialSecPhase()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_036e: Expected O, but got I
		//IL_0068: Expected O, but got I
		//IL_03ab: Expected O, but got I
		//IL_011c: Expected O, but got I
		//IL_019c: Expected O, but got I4
		//IL_01ac: Expected O, but got I4
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_03e8: Expected O, but got I
		//IL_022e: Expected O, but got I
		//IL_0425: Expected O, but got I
		//IL_02e1: Expected O, but got I
		BalootOfflinePlayer[] players = base.Players;
		if (players != null)
		{
			BalootOfflinePlayer balootOfflinePlayer = players[0];
			if (players[0] != null)
			{
				object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v9+B8]");
				object obj3 = 0;
				object obj4 = obj3;
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v11+78]");
					List<Card> collection = CardDataExtension.ToCards((List<CardData>)0);
					if (((OfflinePlayer)balootOfflinePlayer).<Cards>k__BackingField != null)
					{
						((List<object>)(object)((OfflinePlayer)balootOfflinePlayer).<Cards>k__BackingField).AddRange((IEnumerable<object>)collection);
						BalootOfflinePlayer[] players2 = base.Players;
						if (players2 != null)
						{
							BalootOfflinePlayer balootOfflinePlayer2 = players2[1];
							if (players2[1] != null)
							{
								object obj5 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v16+B8]");
								object obj6 = 0;
								object obj7 = obj6;
								if (obj6 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v18+A0]");
									List<Card> collection2 = CardDataExtension.ToCards((List<CardData>)0);
									if (((OfflinePlayer)balootOfflinePlayer2).<Cards>k__BackingField != null)
									{
										((List<object>)(object)((OfflinePlayer)balootOfflinePlayer2).<Cards>k__BackingField).AddRange((IEnumerable<object>)collection2);
										BalootOfflinePlayer[] players3 = base.Players;
										if (players3 != null)
										{
											bool flag = players3.Length < 2;
											object obj8 = !flag;
											object obj9 = players3.Length - 2;
											bool flag2 = obj9 == null;
											object obj10 = ~obj8;
											object obj11 = obj10 | flag2;
											if (obj11 != null)
											{
												goto IL_0328;
											}
											BalootOfflinePlayer balootOfflinePlayer3 = players3[2];
											if (players3[2] != null)
											{
												object obj12 = obj;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v23+B8]");
												object obj13 = 0;
												object obj14 = obj13;
												if (obj13 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v25+A8]");
													List<Card> collection3 = CardDataExtension.ToCards((List<CardData>)0);
													if (((OfflinePlayer)balootOfflinePlayer3).<Cards>k__BackingField != null)
													{
														((List<object>)(object)((OfflinePlayer)balootOfflinePlayer3).<Cards>k__BackingField).AddRange((IEnumerable<object>)collection3);
														BalootOfflinePlayer[] players4 = base.Players;
														if (players4 != null)
														{
															BalootOfflinePlayer balootOfflinePlayer4 = players4[3];
															if (players4[3] != null)
															{
																object obj15 = obj;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v30+B8]");
																object obj16 = 0;
																object obj17 = obj16;
																if (obj16 != null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v32+B0]");
																	List<Card> collection4 = CardDataExtension.ToCards((List<CardData>)0);
																	if (((OfflinePlayer)balootOfflinePlayer4).<Cards>k__BackingField != null)
																	{
																		((List<object>)(object)((OfflinePlayer)balootOfflinePlayer4).<Cards>k__BackingField).AddRange((IEnumerable<object>)collection4);
																		return;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0328;
		IL_0328:
		throw new IndexOutOfRangeException();
	}

	protected override void CheckEkkah(Card card, int playerIndex, bool forceEkkah = false)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_01c0: Expected O, but got I
		//IL_00a2: Expected O, but got I4
		//IL_00bc: Expected O, but got I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected I4, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected I4, but got Unknown
		//IL_013b: Expected O, but got I4
		//IL_0200: Expected O, but got I4
		BalootOfflinePlayer[] players = base.Players;
		if (players != null)
		{
			BalootOfflinePlayer balootOfflinePlayer = players[0];
			if (players[0] != null)
			{
				List<Card> <Cards>k__BackingField = ((OfflinePlayer)balootOfflinePlayer).<Cards>k__BackingField;
				if (((OfflinePlayer)balootOfflinePlayer).<Cards>k__BackingField != null)
				{
					object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v10+B8]");
					object obj3 = 0;
					if (obj3 != null)
					{
						int playerIndex2 = playerIndex - 1;
						object obj4 = playerIndex - 1;
						bool flag = obj4 == null;
						object obj5 = !flag;
						object obj6 = <Cards>k__BackingField._size - obj5;
						int num = obj6 - 7;
						int num2 = 7 - obj6;
						bool flag2 = num < 0;
						int num3 = num ^ num;
						int num4 = num & num3;
						bool flag3 = num4 < 0;
						bool flag4 = flag2 == flag3;
						object obj7 = !flag4;
						object obj8 = ~obj7;
						int round = ((obj8 != null) ? num : num2);
						AiCheatOption aiOptions = ((TutorialGame)obj3).GetAiOptions(playerIndex2, round);
						object obj9 = aiOptions - 1;
						bool forceEkkah2 = obj9 == null;
						base.CheckEkkah(card, playerIndex, forceEkkah2);
						return;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	protected override void CatchCheating(ISFSObject sfsObject)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0226: Expected O, but got I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00ec: Expected O, but got I4
		//IL_0243: Expected O, but got I4
		//IL_0253: Expected O, but got I
		//IL_0263: Expected O, but got I
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_0297: Expected O, but got I
		//IL_02a7: Expected O, but got I
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_08db: Expected O, but got I
		//IL_08fa: Expected O, but got I
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_01ae: Expected O, but got I4
		//IL_01d7: Expected O, but got I
		//IL_036b: Expected O, but got I4
		//IL_0374: Expected O, but got I4
		//IL_0322: Expected O, but got I4
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected O, but got Unknown
		//IL_0454: Expected O, but got I4
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected O, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		//IL_04fd: Expected I, but got O
		//IL_050d: Expected O, but got I
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected O, but got Unknown
		//IL_03d2: Expected O, but got I4
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Expected O, but got Unknown
		//IL_0960: Expected I, but got O
		//IL_0970: Expected O, but got I
		//IL_0548: Expected O, but got I
		//IL_09d3: Expected O, but got I4
		//IL_09ed: Expected O, but got I4
		//IL_05dc: Expected O, but got I
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected O, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected O, but got Unknown
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected O, but got Unknown
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected O, but got Unknown
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected O, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected O, but got Unknown
		//IL_0aa7: Expected O, but got I
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected O, but got Unknown
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected O, but got Unknown
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Expected O, but got Unknown
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected O, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected O, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected O, but got Unknown
		//IL_084a: Unknown result type (might be due to invalid IL or missing references)
		//IL_084f: Expected O, but got Unknown
		//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a15: Expected O, but got Unknown
		//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3d: Expected O, but got Unknown
		//IL_0a67: Expected O, but got I4
		//IL_0a79: Expected O, but got I4
		//IL_06e2: Expected O, but got I
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected O, but got Unknown
		//IL_0724: Expected O, but got I4
		//IL_0888: Expected O, but got I4
		//IL_075f: Expected O, but got I
		//IL_07b3: Expected O, but got I4
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected O, but got Unknown
		//IL_082d: Expected O, but got I4
		object varName = "m_StencilDeferredPS" + 2232;
		object defaultValue = (nint)0 + (nint)2000;
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		string text = SFSExtensions.Get(sfsObject, (string)varName, (string)defaultValue);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			if (StringsExtensions.IsNullOrEmpty(text))
			{
				goto IL_009b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = StringsExtensions.IsNullOrEmpty(text);
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				goto IL_009b;
			}
		}
		object obj5 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X25_v7+90]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v14+B8]");
		object defaultValue2 = 0;
		object varName2 = "utf-32" + 1680;
		string text2 = SFSExtensions.Get(sfsObject, (string)varName2, (string)defaultValue2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X25_v7+90]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v18+B8]");
		object defaultValue3 = 0;
		object varName3 = "alignContent" + 136;
		string text3 = SFSExtensions.Get(sfsObject, (string)varName3, (string)defaultValue3);
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v23+E4]");
		if ((nint)0 != 0)
		{
			bool flag3 = StringsExtensions.IsNullOrEmpty(text2);
			bool flag4 = !flag3;
			object obj9 = 0;
			if (flag4)
			{
				goto IL_0382;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = StringsExtensions.IsNullOrEmpty(text2);
			bool flag6 = !flag5;
			object obj10 = !flag6;
			object obj9 = 0;
			if (obj10 == null)
			{
				goto IL_0382;
			}
		}
		goto IL_041a;
		IL_0589:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_093f;
		IL_08cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v7+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v5+D8]");
		SFSEvent sFSEvent = default(SFSEvent);
		sFSEvent..ctor((string)0);
		object cmd = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3280;
		SFSExtensions.PutCommand(sFSEvent, (string)cmd);
		SFSExtensions.PutResponseParams(sFSEvent, sFSObject);
		object obj12 = typeof(Queue<string>) + 824;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v11+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj15 = (nint)0 + (nint)2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SFS sFS = default(SFS);
		sFS.SFS_OnExtensionResponse(sFSEvent);
		return;
		IL_0680:
		Team1TotalScore = 152;
		goto IL_09fb;
		IL_09fb:
		((OfflineGameController)this).<GameStatus>k__BackingField = CardGameStage.CardGameStages.MoveNextRequired;
		object obj16 = "fetch_products" + 1824;
		SFSExtensions.Put(((OfflineGameController)this).<RoundState>k__BackingField, (string)obj16, 5);
		object obj17 = typeof(RegisteredWaitHandle) + 2008;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v7+E4]");
		bool flag8 = (nint)0 == 0;
		object obj19 = !flag8;
		bool flag9 = false;
		string text4 = (string)5;
		ISFSObject iSFSObject = (ISFSObject)obj16;
		bool flag10;
		string text5;
		ISFSObject iSFSObject2;
		object obj20;
		if (obj19 == null)
		{
			flag10 = false;
			text5 = (string)5;
			iSFSObject2 = (ISFSObject)obj16;
			obj20 = obj18;
			goto IL_0134;
		}
		goto IL_08cb;
		IL_093f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v539 @ X0_v28] (should have been resolved before IL gen)");
		object obj21 = "___# Content push apply failed [{0}]: {1}" + 2808;
		nint num = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v33 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v33 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_061d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v33 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj23 = (nint)0 + (nint)8;
		object obj24;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X10_v8-8]");
			if (0 == (nint)obj24)
			{
				break;
			}
			obj23 += 16;
			obj22--;
			if ((nint)obj22 != 1)
			{
				continue;
			}
			goto IL_061d;
		}
		object obj25 = obj23 + 39;
		object obj26 = num + obj25;
		object obj27 = obj26 + 312;
		goto IL_09b9;
		IL_0382:
		object obj28 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v75+E4]");
		if ((nint)0 != 0)
		{
			bool flag11 = StringsExtensions.IsNullOrEmpty(text3);
			bool flag12 = !flag11;
			object obj29 = !flag12;
			if (obj29 != null)
			{
				goto IL_041a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (StringsExtensions.IsNullOrEmpty(text3))
			{
				goto IL_041a;
			}
		}
		goto IL_049b;
		IL_0866:
		Team2TotalScore = 152;
		goto IL_09fb;
		IL_009b:
		SetUpCheatingData(sFSObject, text, firstPhase: true);
		obj17 = typeof(RegisteredWaitHandle) + 2008;
		obj20 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v89+E4]");
		bool flag13 = (nint)0 == 0;
		object obj30 = !flag13;
		flag10 = true;
		text5 = text;
		iSFSObject2 = sFSObject;
		flag9 = true;
		text4 = text;
		iSFSObject = sFSObject;
		obj18 = obj20;
		if (obj30 == null)
		{
			goto IL_0134;
		}
		goto IL_08cb;
		IL_041a:
		object obj31 = "utf-32" + 1704;
		bool flag14 = text == (string)obj31;
		bool flag15 = !flag14;
		object obj32 = !flag15;
		if (obj32 == null)
		{
			object obj33 = "utf-32" + 1696;
			if (!(text == (string)obj33))
			{
				return;
			}
		}
		goto IL_049b;
		IL_0134:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj18 = obj17;
		flag9 = flag10;
		text4 = text5;
		iSFSObject = iSFSObject2;
		goto IL_08cb;
		IL_049b:
		object obj34 = "utf-32" + 1696;
		bool firstPhase = text == (string)obj34;
		SetUpCheatingData(sFSObject, text, firstPhase);
		obj24 = typeof(System.IOAsyncCallback) + 976;
		object obj35 = "utf-32" + 1192;
		nint num2 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v28 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v28 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0589;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v28 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj37 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X10_v13-8]");
			if (0 == (nint)obj24)
			{
				break;
			}
			obj37 += 16;
			obj36--;
			if ((nint)obj36 != 1)
			{
				continue;
			}
			goto IL_0589;
		}
		object obj38 = obj37 + 39;
		object obj39 = num2 + obj38;
		object obj40 = obj39 + 312;
		goto IL_093f;
		IL_061d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_09b9;
		IL_09b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v618 @ X0_v31] (should have been resolved before IL gen)");
		object obj41 = <TutorialType>k__BackingField - 11;
		bool flag16 = (nint)obj41 < 2;
		object obj42 = !flag16;
		if (obj42 == null)
		{
			object key = "com.unity.services.authentication.profile" + 1792;
			SFSExtensions.Put(sFSObject, (string)key, val: true);
			goto IL_0680;
		}
		object obj43 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
		object obj44 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v45+B8]");
		object obj45 = 0;
		object obj46 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v47+34]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v47+D8]");
			List<Card> list = CardDataExtension.ToCards((List<CardData>)0);
			object obj47 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
			object obj48 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X0_v43+E4]");
			bool flag17 = (nint)0 == 0;
			object obj49 = !flag17;
			if (obj49 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Card item = CardUtils.FromString(text2);
			object obj50 = (nint)0 + (nint)2672;
			if (((List<object>)(object)list).Contains((object)item))
			{
				object obj51 = obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X0_v49+E4]");
				bool flag18 = (nint)0 == 0;
				object obj52 = !flag18;
				if (obj52 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Card item2 = CardUtils.FromString(text3);
				bool flag19 = ((List<object>)(object)list).Contains((object)item2);
				object key2 = "com.unity.services.authentication.profile" + 1792;
				SFSExtensions.Put(sFSObject, (string)key2, flag19);
				bool flag20 = !flag19;
				object obj53 = !flag20;
				if (obj53 != null)
				{
					goto IL_0680;
				}
				goto IL_0866;
			}
		}
		object key3 = "com.unity.services.authentication.profile" + 1792;
		SFSExtensions.Put(sFSObject, (string)key3, val: false);
		goto IL_0866;
	}

	protected override void OnPlayCard(Card card, int playerIndex, ISFSObject param)
	{
		TrackPlayedCards(card);
		base.OnPlayCard(card, playerIndex, param);
	}

	private void TrackPlayedCards(Card card)
	{
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_00a2: Expected O, but got I4
		//IL_0042: Expected O, but got I
		//IL_006b: Expected O, but got I
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_014c: Expected O, but got I
		//IL_01cd: Expected O, but got I4
		//IL_0264: Expected O, but got I
		//IL_0274: Expected O, but got I
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		object obj = this + 232;
		object obj2 = obj;
		bool flag = obj == null;
		object obj3 = card;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			bool flag2 = card == null;
			Card card2 = card;
			if (!flag2)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v19+40]");
				card2 = (Card)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v19+40]");
				obj3 = 0;
				if (flag3)
				{
					goto IL_02e9;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X20_v3+8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X22_v1+18]");
			bool flag4 = num < 0;
			object obj5 = !flag4;
			obj3 = card2;
			if (obj5 != null)
			{
				goto IL_02db;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X20_v3+8]");
			object obj6 = obj + 0;
			object obj7 = obj6 + 32;
			obj7 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (_playCardIndex <= 2)
			{
				int playCardIndex = _playCardIndex + 1;
				_playCardIndex = playCardIndex;
				return;
			}
			List<object> playedCardsList = (List<object>)(object)_playedCardsList;
			bool flag5 = _playedCardsList == null;
			obj3 = card;
			if (!flag5)
			{
				object obj8 = (nint)0 + (nint)4016;
				obj3 = _currentHandPlayedCards;
				object obj9 = obj8;
				int version = playedCardsList._version + 1;
				playedCardsList._version = version;
				object[] items = playedCardsList._items;
				if (playedCardsList._items != null)
				{
					bool flag6 = playedCardsList._size < items.Length;
					object obj10 = !flag6;
					if (obj10 == null)
					{
						int size = playedCardsList._size + 1;
						playedCardsList._size = size;
						object obj11 = playedCardsList._items + playedCardsList._size;
						object obj12 = obj11 + 32;
						obj12 = _currentHandPlayedCards;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v12+20]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v16+C0]");
						object obj14 = 0;
						((List<object>)(object)_playedCardsList).AddWithResize((object)_currentHandPlayedCards);
					}
					_playCardIndex = 0;
					object obj15 = typeof(TypeConverter<ushort, char>) + 1944;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					Card[] currentHandPlayedCards = default(Card[]);
					_currentHandPlayedCards = currentHandPlayedCards;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return;
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_02db;
		IL_02e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_02db:
		ex = new IndexOutOfRangeException();
		goto IL_02e9;
	}

	private void ResetTrackLogic()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		_playCardIndex = 0;
		List<Card[]> playedCardsList = _playedCardsList;
		object obj = typeof(TypeConverter<ushort, char>) + 1944;
		int version = playedCardsList._version + 1;
		playedCardsList._size = 0;
		playedCardsList._version = version;
		if (playedCardsList._size >= 1)
		{
			Array.Clear(playedCardsList._items, 0, playedCardsList._size);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = this + 232;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void SetUpCheatingData(ISFSObject data, string mode, bool firstPhase)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03d8: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected O, but got Unknown
		//IL_0571: Expected I, but got O
		//IL_0581: Expected O, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0110: Expected I, but got O
		//IL_0120: Expected O, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0489: Expected I, but got O
		//IL_0499: Expected O, but got I
		//IL_01ef: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_042f: Expected O, but got I
		//IL_015b: Expected O, but got I
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected O, but got Unknown
		//IL_0283: Expected O, but got I
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_05be: Expected O, but got I
		//IL_05db: Expected I, but got O
		//IL_05eb: Expected O, but got I
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0550: Expected O, but got I
		//IL_0317: Expected O, but got I
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2536;
		nint num = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00bc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X10_v30-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00bc;
		}
		object obj5 = obj4 + 39;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_03b9;
		IL_03b9:
		object obj8 = "tournament_participate_warning_body_with_tickets_warning_daily" + 728;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v3+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v215 @ X0_v3] (should have been resolved before IL gen)");
		if (firstPhase)
		{
			object obj10 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2512;
			nint num2 = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v27 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v27 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_019c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v27 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj12 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X10_v25-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj12 += 16;
				obj11--;
				if ((nint)obj11 != 1)
				{
					continue;
				}
				goto IL_019c;
			}
			object obj13 = obj12 + 35;
			object obj14 = num2 + obj13;
			object obj15 = obj14 + 312;
			goto IL_041f;
		}
		goto IL_055a;
		IL_055a:
		object obj23 = default(object);
		while (true)
		{
			object obj16 = "destinationTimeZone" + 2752;
			nint num3 = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0230;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj18 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X10_v19-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj18 += 16;
				obj17--;
				if ((nint)obj17 != 1)
				{
					continue;
				}
				goto IL_0230;
			}
			object obj19 = obj18 + 35;
			object obj20 = num3 + obj19;
			object obj21 = obj20 + 312;
			goto IL_0462;
			IL_0538:
			object obj22 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X0_v18+8]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v140 @ X4_v1 (should have been resolved before IL gen)");
			continue;
			IL_0358:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0538;
			IL_02c4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_04e2;
			IL_0230:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0462;
			IL_0462:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v405 @ X0_v7] (should have been resolved before IL gen)");
			SFSArray eatingsSFSArray = GetEatingsSFSArray(_currentHandPlayedCards, _playedCardsList);
			nint num4 = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02c4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj26 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X10_v14-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj26 += 16;
				obj25--;
				if ((nint)obj25 != 1)
				{
					continue;
				}
				goto IL_02c4;
			}
			object obj27 = obj26 + 49;
			object obj28 = num4 + obj27;
			object obj29 = obj28 + 312;
			goto IL_04e2;
			IL_04e2:
			object obj30 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2728;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v490 @ X0_v12] (should have been resolved before IL gen)");
			object obj31 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
			object obj32 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v17+B8]");
			object tutorialGame = 0;
			SFSArray handSFSArray = GetHandSFSArray((TutorialGame)tutorialGame);
			object obj33 = obj30;
			nint num5 = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj35 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X10_v9-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj35 += 16;
					obj34--;
					if ((nint)obj34 != 1)
					{
						continue;
					}
					goto IL_0358;
				}
				object obj36 = obj35 + 49;
				object obj37 = num5 + obj36;
				obj23 = obj37 + 312;
				goto IL_0538;
			}
			goto IL_0358;
		}
		IL_019c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_041f;
		IL_041f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v32+8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v384 @ X0_v32] (should have been resolved before IL gen)");
		goto IL_055a;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_03b9;
	}

	private static SFSArray GetEatingsSFSArray(Card[] currentHandPlayedCards, List<Card[]> playedCardsList)
	{
		//IL_0011: Expected O, but got I
		//IL_0039: Expected I, but got O
		//IL_0061: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_073f: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0347: Expected O, but got I
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_0367: Expected O, but got I
		//IL_0373: Expected O, but got I
		//IL_037f: Expected O, but got I
		//IL_00f4: Expected O, but got I4
		//IL_0131: Expected O, but got I4
		//IL_044e: Expected O, but got I
		//IL_045e: Expected O, but got I
		//IL_0480: Expected O, but got I4
		//IL_0179: Expected O, but got I4
		//IL_03e7: Expected O, but got I
		//IL_03f7: Expected O, but got I
		//IL_0419: Expected O, but got I4
		//IL_05aa: Expected O, but got I
		//IL_05ba: Expected O, but got I
		//IL_05dc: Expected O, but got I4
		//IL_04c0: Expected O, but got I4
		//IL_07f6: Expected O, but got I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_0649: Expected I, but got O
		//IL_0543: Expected O, but got I
		//IL_0553: Expected O, but got I
		//IL_0575: Expected O, but got I4
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Expected O, but got Unknown
		//IL_082f: Expected O, but got I
		//IL_0840: Expected I, but got O
		//IL_085e: Expected O, but got I
		//IL_0879: Expected O, but got I4
		//IL_060c: Expected O, but got I4
		//IL_04f0: Expected O, but got I
		//IL_01dd: Expected O, but got I
		//IL_0212: Expected I4, but got O
		//IL_022e: Expected O, but got I4
		//IL_06cf: Expected O, but got I4
		//IL_0895: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected O, but got Unknown
		//IL_08b5: Expected I, but got O
		//IL_08d3: Expected O, but got I
		//IL_08ee: Expected O, but got I4
		//IL_069b: Expected I, but got O
		//IL_063c: Expected O, but got I
		//IL_026a: Expected O, but got I4
		//IL_02ec: Expected O, but got I
		//IL_02fc: Expected O, but got I
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		bool flag = playedCardsList == null;
		int[] array = (int[])(object)playedCardsList;
		Card[] result = currentHandPlayedCards;
		List<object>.Enumerator enumerator;
		SFSArray sFSArray = default(SFSArray);
		int[] array2;
		if (!flag)
		{
			object obj = (nint)0 + (nint)4048;
			int size = playedCardsList._size;
			int num = playedCardsList._size - 1;
			nint num2 = (nint)obj;
			object obj2 = ((List<object>)(object)playedCardsList).get_Item(num);
			bool flag2 = currentHandPlayedCards == null;
			array = (int[])num;
			result = currentHandPlayedCards;
			if (!flag2)
			{
				bool flag3 = currentHandPlayedCards.Length == 0;
				List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
				enumerator = enumerator2;
				array = (int[])num;
				result = currentHandPlayedCards;
				if (!flag3)
				{
					bool flag4 = currentHandPlayedCards[0] == null;
					object obj3 = num;
					if (!flag4)
					{
						bool flag5 = obj2 == null;
						array = (int[])num;
						result = currentHandPlayedCards;
						if (flag5)
						{
							goto IL_07d8;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v20 (System.Object)+18]");
						bool flag6 = (nint)0 == 0;
						enumerator = enumerator2;
						array = (int[])num;
						result = currentHandPlayedCards;
						if (flag6)
						{
							goto IL_06e4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v20 (System.Object)+20]");
						size = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v20 (System.Object)+20]");
						bool flag7 = (nint)0 == 0;
						object obj4 = !flag7;
						object obj5 = ~obj4;
						bool flag8;
						if (obj5 == null)
						{
							Card card = currentHandPlayedCards[0];
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v20 (System.Object)+20]");
							object obj6 = card - 0;
							flag8 = obj6 == null;
						}
						else
						{
							flag8 = true;
						}
						obj3 = num;
						if (!flag8)
						{
							object obj7 = (nint)0 + (nint)4016;
							object obj8 = obj7;
							int version = playedCardsList._version + 1;
							playedCardsList._version = version;
							size = (int)playedCardsList._items;
							bool flag9 = playedCardsList._items == null;
							array = (int[])num;
							result = currentHandPlayedCards;
							if (flag9)
							{
								goto IL_07d8;
							}
							int size2 = playedCardsList._size;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X9_v8 (System.Int32)+18]");
							bool flag10 = (nint)size2 < (nint)0;
							object obj9 = !flag10;
							if (obj9 == null)
							{
								int size3 = playedCardsList._size + 1;
								playedCardsList._size = size3;
								object obj10 = playedCardsList._items + playedCardsList._size;
								object obj11 = obj10 + 32;
								obj11 = currentHandPlayedCards;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								obj3 = currentHandPlayedCards;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v48+20]");
								object obj12 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v49+C0]");
								object obj13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v50+70]");
								num2 = 0;
								((List<object>)(object)playedCardsList).AddWithResize((object)currentHandPlayedCards);
								obj3 = currentHandPlayedCards;
							}
						}
					}
					object obj14 = typeof(RegisteredWaitHandle) + 1888;
					object obj15 = (nint)0 + (nint)3016;
					object obj16 = typeof(TrackedDeviceRaycaster.<>c) + 272;
					object obj17 = (nint)0 + (nint)3280;
					object obj18 = (nint)0 + (nint)904;
					object obj19 = (nint)0 + (nint)2984;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					sFSArray..ctor();
					List<object>.Enumerator enumerator3 = ((List<object>)(object)playedCardsList).GetEnumerator();
					Func<object, int> func = default(Func<object, int>);
					IEnumerable<object> source3 = default(IEnumerable<object>);
					Func<object, bool> func2 = default(Func<object, bool>);
					while (enumerator2.MoveNext())
					{
						object obj20 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v51+E4]");
						object obj21;
						Func<object, bool> predicate;
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v51+B8]");
							obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v36+8]");
							predicate = (Func<object, bool>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v36+8]");
							bool flag11 = (nint)0 == 0;
							object obj22 = !flag11;
							if (obj22 == null)
							{
								goto IL_048e;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj20 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v51+B8]");
							obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v36+8]");
							predicate = (Func<object, bool>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v36+8]");
							bool flag12 = (nint)0 == 0;
							object obj23 = !flag12;
							if (obj23 == null)
							{
								goto IL_048e;
							}
						}
						goto IL_04f5;
						IL_0641:
						num2 = (nint)obj19;
						IEnumerable<object> source2;
						Func<object, int> selector;
						IEnumerable<int> source = Enumerable.Select(source2, selector);
						array2 = Enumerable.ToArray(source);
						if (sFSArray != null)
						{
							sFSArray.AddIntArray(array2);
							num2 = unchecked((nint)null);
							continue;
						}
						goto IL_06bc;
						IL_05ea:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v41+E4]");
						bool flag13 = (nint)0 == 0;
						object obj24 = !flag13;
						object obj26;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj25 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v31+B8]");
							obj26 = 0;
						}
						object obj27 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 456;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						func..ctor(obj26, (IntPtr)obj18);
						object obj28 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v30+B8]");
						object obj29 = (nint)0 + (nint)16;
						obj29 = func;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj30 = 0;
						selector = func;
						goto IL_0641;
						IL_04f5:
						source2 = Enumerable.Where(source3, predicate);
						object obj31 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v41+E4]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v41+B8]");
							obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v27+10]");
							selector = (Func<object, int>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v27+10]");
							bool flag14 = (nint)0 == 0;
							object obj32 = !flag14;
							if (obj32 == null)
							{
								goto IL_05ea;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj31 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v41+B8]");
							obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v27+10]");
							selector = (Func<object, int>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v27+10]");
							bool flag15 = (nint)0 == 0;
							object obj33 = !flag15;
							if (obj33 == null)
							{
								goto IL_05ea;
							}
						}
						goto IL_0641;
						IL_048e:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v51+E4]");
						size = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v51+E4]");
						bool flag16 = (nint)0 == 0;
						object obj34 = !flag16;
						if (obj34 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj35 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v42+B8]");
							obj21 = 0;
						}
						object obj36 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj37 = (nint)0 + (nint)896;
						func2..ctor(obj21, (IntPtr)obj37);
						object obj38 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v41+B8]");
						object obj39 = (nint)0 + (nint)8;
						obj39 = func2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj30 = 0;
						predicate = func2;
						goto IL_04f5;
					}
					enumerator2.Dispose();
					result = (Card[])(object)sFSArray;
					goto IL_06b7;
				}
				goto IL_06e4;
			}
		}
		goto IL_07d8;
		IL_06e4:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		bool flag17 = (nint)array != 1;
		OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		if (!flag17)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj40 = (nint)0 + (nint)3008;
			array = (int[])obj40;
			enumerator.Dispose();
			object obj41 = default(object);
			if (obj41 == null)
			{
				goto IL_06b7;
			}
			ex2 = new OutOfMemoryException();
			enumerator4 = (List<object>.Enumerator)obj41;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BCC8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		SFSArray result2 = default(SFSArray);
		return result2;
		IL_06b7:
		return (SFSArray)(object)result;
		IL_06bc:
		NullReferenceException ex3 = new NullReferenceException();
		enumerator4 = (List<object>.Enumerator)0;
		array = array2;
		result = (Card[])(object)sFSArray;
		goto IL_07d8;
		IL_07d8:
		NullReferenceException ex4 = new NullReferenceException();
		enumerator = enumerator4;
		goto IL_06e4;
	}

	public static SFSArray GetHandSFSArray(TutorialGame tutorialGame)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 1888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSArray sFSArray = default(SFSArray);
		sFSArray..ctor();
		if ((object)tutorialGame != null)
		{
			AddArrayCards(sFSArray, tutorialGame._hand1);
			AddArrayCards(sFSArray, tutorialGame._hand2);
			AddArrayCards(sFSArray, tutorialGame._hand3);
			AddArrayCards(sFSArray, tutorialGame._hand4);
			return sFSArray;
		}
		return (SFSArray)(object)new NullReferenceException();
	}

	private static void AddArrayCards(ISFSArray array, IReadOnlyCollection<CardData> cardsData)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_012c: Expected O, but got I4
		//IL_033c: Expected O, but got I
		//IL_034c: Expected O, but got I
		//IL_036e: Expected O, but got I4
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_02ad: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01e7: Expected I, but got O
		//IL_01f7: Expected O, but got I
		//IL_0173: Expected O, but got I4
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_03a6: Expected O, but got I
		//IL_03b7: Expected I, but got O
		//IL_03d5: Expected O, but got I
		//IL_0430: Expected O, but got I
		//IL_0232: Expected O, but got I
		//IL_01a3: Expected O, but got I
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2176;
		nint num = (nint)cardsData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<CardData>>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<CardData>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<CardData>>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v13-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj4 = num + obj3;
		object obj5 = obj4 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v30+8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v280 @ X0_v30] (should have been resolved before IL gen)");
		object obj7 = default(object);
		if ((nint)obj7 < 1)
		{
			return;
		}
		goto IL_00ee;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v27+8]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v152 @ X0_v27] (should have been resolved before IL gen)");
		object obj8 = default(object);
		if ((nint)obj8 >= 1)
		{
			goto IL_00ee;
		}
		return;
		IL_00ee:
		object obj9 = typeof(TrackedDeviceRaycaster.<>c) + 272;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v7+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v17+18]");
		Func<CardData, int> selector = (Func<CardData, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v17+18]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj15 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v23+B8]");
				obj12 = 0;
			}
			object obj16 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 504;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj17 = (nint)0 + (nint)888;
			Func<CardData, int> func = default(Func<CardData, int>);
			func..ctor(obj12, (IntPtr)obj17);
			object obj18 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v22+B8]");
			object obj19 = (nint)0 + (nint)24;
			obj19 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<int> source = Enumerable.Select(cardsData, selector);
		int[] array2 = Enumerable.ToArray(source);
		object obj20 = typeof(System.IOAsyncCallback) + 960;
		nint num2 = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0273;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
		object obj22 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X10_v8-8]");
			if (0 == (nint)obj20)
			{
				break;
			}
			obj22 += 16;
			obj21--;
			if ((nint)obj21 != 1)
			{
				continue;
			}
			goto IL_0273;
		}
		object obj23 = obj22 + 23;
		object obj24 = num2 + obj23;
		object obj25 = obj24 + 312;
		goto IL_0418;
		IL_0418:
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v12+8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v211 @ X3_v3 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0273:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0418;
	}

	public override void SendGameState()
	{
		//IL_0016: Expected O, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_0404: Expected O, but got I
		//IL_041c: Expected O, but got I
		//IL_068b: Expected O, but got I
		//IL_069b: Expected O, but got I
		//IL_06b1: Expected O, but got I
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected O, but got Unknown
		//IL_06d9: Expected O, but got I4
		//IL_06e9: Expected O, but got I
		//IL_0451: Expected O, but got I
		//IL_0467: Expected O, but got I
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected O, but got Unknown
		//IL_0494: Expected O, but got I
		//IL_0816: Expected O, but got I
		//IL_074b: Expected O, but got I
		//IL_075b: Expected O, but got I
		//IL_0771: Expected O, but got I
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected O, but got Unknown
		//IL_0799: Expected O, but got I4
		//IL_07a9: Expected O, but got I
		//IL_0723: Expected O, but got I4
		//IL_04d7: Expected O, but got I
		//IL_04e7: Expected O, but got I
		//IL_04fd: Expected O, but got I
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected O, but got Unknown
		//IL_052a: Expected O, but got I
		//IL_024a: Expected O, but got I
		//IL_07db: Expected O, but got I4
		//IL_0565: Expected O, but got I
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected O, but got Unknown
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected O, but got Unknown
		//IL_05a8: Expected I, but got O
		//IL_05b8: Expected O, but got I
		//IL_028a: Expected O, but got I4
		//IL_05f3: Expected O, but got I
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_034d: Expected I, but got O
		//IL_035d: Expected O, but got I
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Expected O, but got Unknown
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Expected O, but got Unknown
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected O, but got Unknown
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected O, but got Unknown
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected O, but got Unknown
		//IL_03a0: Expected O, but got I
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80ED]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A5]");
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
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A5]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v61+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		bool flag3 = obj8 == null;
		obj2 = obj4;
		if (!flag3)
		{
			goto IL_017a;
		}
		goto IL_07e9;
		IL_0643:
		object obj11;
		object obj10 = obj11 + 44;
		nint num;
		object obj12 = num + obj10;
		object obj13 = obj12 + 312;
		goto IL_08d0;
		IL_08d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v475 @ X0_v6] (should have been resolved before IL gen)");
		goto IL_083b;
		IL_0555:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v39+B8]");
		object obj14 = 0;
		int[] array = (int[])obj14;
		object obj15 = typeof(System.IOAsyncCallback) + 976;
		object obj16 = obj15;
		object obj17 = "placementId" + 520;
		object obj18 = obj17;
		ISFSObject iSFSObject;
		nint num2 = (nint)iSFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v49 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v49 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0634;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v49 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X10_v3-8]");
			bool flag4 = 0 == (nint)obj16;
			num = num2;
			if (flag4)
			{
				break;
			}
			obj11 += 16;
			obj19--;
			if ((nint)obj19 != 1)
			{
				continue;
			}
			goto IL_0634;
		}
		goto IL_0643;
		IL_0082:
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v67+B8]");
		object obj21 = 0;
		obj9 = obj21;
		bool flag5 = obj21 == null;
		object obj22 = !flag5;
		if (obj22 != null)
		{
			goto IL_017a;
		}
		goto IL_07e9;
		IL_017a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v4+34]");
		if ((nint)0 == 1)
		{
			int moveNumber = MoveNumber;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v4+38]");
			if ((nint)moveNumber >= (nint)0)
			{
				iSFSObject = ((OfflineGameController)this).<RoundState>k__BackingField;
				object obj23 = (nint)0 + (nint)3168;
				object obj24 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X21_v10+38]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X21_v10+38]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v32+10]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v32+10]");
					object obj27 = (nint)0 + (nint)309;
					object obj28 = obj27 & 1;
					bool flag6 = obj28 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v32+10]");
					object obj29 = 0;
					if (!flag6)
					{
						goto IL_04a2;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X21_v10+38]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v40+10]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v40+10]");
					object obj31 = (nint)0 + (nint)309;
					object obj32 = obj31 & 1;
					bool flag7 = obj32 == null;
					object obj33 = !flag7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v40+10]");
					object obj29 = 0;
					if (obj33 != null)
					{
						goto IL_04a2;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v31+E4]");
				bool flag8 = (nint)0 == 0;
				object obj34 = !flag8;
				if (obj34 != null)
				{
					goto IL_04c7;
				}
				goto IL_0731;
			}
		}
		BalootOfflinePlayer[] players = base.Players;
		IEnumerable<Card> cards;
		if (players != null)
		{
			BalootOfflinePlayer balootOfflinePlayer = players[0];
			if (players[0] != null)
			{
				object obj35 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v16+B8]");
				object obj36 = 0;
				object obj37 = obj36;
				if (obj36 != null)
				{
					List<Card> <Cards>k__BackingField = ((OfflinePlayer)balootOfflinePlayer).<Cards>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v18+80]");
					List<Card> wantedToPlayCards = GetWantedToPlayCards(<Cards>k__BackingField, (IReadOnlyList<ListWrapper<CardData>>)0);
					if (wantedToPlayCards == null)
					{
						goto IL_083b;
					}
					bool flag9 = wantedToPlayCards._size == 0;
					object obj38 = !flag9;
					cards = wantedToPlayCards;
					if (obj38 != null)
					{
						goto IL_0842;
					}
					BalootOfflinePlayer[] players2 = base.Players;
					if (players2 != null)
					{
						BalootOfflinePlayer balootOfflinePlayer2 = players2[0];
						if (players2[0] != null)
						{
							cards = ((OfflinePlayer)balootOfflinePlayer2).<Cards>k__BackingField;
							goto IL_0842;
						}
					}
				}
			}
		}
		goto IL_07e9;
		IL_083b:
		base.SendGameState();
		return;
		IL_07e9:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_0634:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_08d0;
		IL_03e1:
		int[] array2;
		array = array2;
		goto IL_0634;
		IL_0842:
		iSFSObject = ((OfflineGameController)this).<RoundState>k__BackingField;
		array2 = OfflineGameController.CardsToInt(cards);
		if (((OfflineGameController)this).<RoundState>k__BackingField != null)
		{
			object obj39 = typeof(System.IOAsyncCallback) + 976;
			obj16 = obj39;
			object obj40 = "placementId" + 520;
			obj18 = obj40;
			num = (nint)iSFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			bool flag10 = (nint)0 == 0;
			array = array2;
			if (flag10)
			{
				goto IL_0634;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X10_v3-8]");
				bool flag11 = 0 == (nint)obj16;
				array = array2;
				if (flag11)
				{
					break;
				}
				obj11 += 16;
				obj41--;
				if ((nint)obj41 != 1)
				{
					continue;
				}
				goto IL_03e1;
			}
			goto IL_0643;
		}
		goto IL_07e9;
		IL_04a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v31+E4]");
		if ((nint)0 != 0)
		{
			goto IL_04c7;
		}
		goto IL_0731;
		IL_0731:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X21_v10+38]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v35+10]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v35+10]");
		object obj44 = (nint)0 + (nint)309;
		object obj45 = obj44 & 1;
		bool flag12 = obj45 == null;
		object obj46 = !flag12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v35+10]");
		object obj47 = 0;
		if (obj46 != null)
		{
			goto IL_0538;
		}
		goto IL_07b7;
		IL_04c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X21_v10+38]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v52+10]");
		obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v52+10]");
		object obj49 = (nint)0 + (nint)309;
		object obj50 = obj49 & 1;
		bool flag13 = obj50 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v52+10]");
		obj47 = 0;
		if (!flag13)
		{
			goto IL_0538;
		}
		goto IL_07b7;
		IL_07b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		bool flag14 = iSFSObject == null;
		object obj51 = !flag14;
		if (obj51 != null)
		{
			goto IL_0555;
		}
		goto IL_07e9;
		IL_0538:
		if (iSFSObject != null)
		{
			goto IL_0555;
		}
		goto IL_07e9;
	}

	private static List<Card> GetWantedToPlayCards(List<Card> playerCards, IReadOnlyList<ListWrapper<CardData>> cardsWantedToPlayList)
	{
		//IL_1119: Expected O, but got I4
		//IL_1122: Expected O, but got I4
		//IL_1133: Expected O, but got I4
		//IL_001d: Expected O, but got I4
		//IL_0026: Expected O, but got I4
		//IL_0037: Expected O, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0069: Expected I, but got O
		//IL_0079: Expected O, but got I
		//IL_0117: Expected O, but got I
		//IL_0134: Expected O, but got I4
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_00b4: Expected O, but got I
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0215: Expected I, but got O
		//IL_0225: Expected O, but got I
		//IL_1159: Expected O, but got I
		//IL_02cb: Expected O, but got I
		//IL_02ef: Expected O, but got I4
		//IL_030c: Expected O, but got I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_0188: Expected O, but got I
		//IL_01a5: Expected O, but got I4
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		//IL_0430: Expected O, but got I
		//IL_044d: Expected O, but got I
		//IL_0260: Expected O, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		//IL_047c: Expected O, but got I
		//IL_0323: Expected O, but got I4
		//IL_032c: Expected O, but got I4
		//IL_0339: Expected O, but got I4
		//IL_0342: Expected O, but got I4
		//IL_1192: Expected O, but got I
		//IL_04b2: Expected O, but got I4
		//IL_04bb: Expected O, but got I4
		//IL_04d4: Expected O, but got I4
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		//IL_0382: Expected O, but got I
		//IL_03ab: Expected O, but got I
		//IL_03b8: Expected O, but got I4
		//IL_03c1: Expected O, but got I4
		//IL_03ca: Expected O, but got I4
		//IL_03e7: Expected O, but got I4
		//IL_03f0: Expected O, but got I4
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0289: Expected O, but got I
		//IL_04fa: Expected O, but got I
		//IL_051a: Expected O, but got I4
		//IL_06aa: Expected O, but got I4
		//IL_06b3: Expected O, but got I4
		//IL_0534: Expected O, but got I
		//IL_0553: Expected O, but got I
		//IL_06e9: Expected O, but got I4
		//IL_06f2: Expected O, but got I4
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected I4, but got Unknown
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_0603: Expected O, but got I4
		//IL_1206: Unknown result type (might be due to invalid IL or missing references)
		//IL_120b: Expected O, but got Unknown
		//IL_056d: Expected O, but got I
		//IL_0579: Expected O, but got I
		//IL_0d87: Expected O, but got I
		//IL_0d97: Expected O, but got I
		//IL_0db9: Expected O, but got I4
		//IL_0dc9: Expected O, but got I
		//IL_11bf: Expected O, but got I4
		//IL_11c8: Expected O, but got I4
		//IL_11d0: Expected O, but got I4
		//IL_11e1: Expected O, but got I4
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_0992: Expected I4, but got O
		//IL_09a0: Expected O, but got I4
		//IL_09ba: Expected O, but got I4
		//IL_0c7d: Expected O, but got I
		//IL_0c8d: Expected O, but got I
		//IL_0cb4: Expected O, but got I
		//IL_0b49: Expected O, but got I
		//IL_0b74: Expected O, but got I4
		//IL_0b84: Expected O, but got I4
		//IL_0bc6: Expected O, but got I4
		//IL_0ea0: Expected O, but got I
		//IL_0df9: Expected O, but got I4
		//IL_0ed3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed8: Expected O, but got Unknown
		//IL_0757: Expected O, but got I
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected O, but got Unknown
		//IL_078b: Expected O, but got I
		//IL_0798: Expected O, but got I
		//IL_0663: Expected O, but got I4
		//IL_066b: Expected O, but got I4
		//IL_0684: Expected O, but got I4
		//IL_128d: Expected O, but got I4
		//IL_09da: Unknown result type (might be due to invalid IL or missing references)
		//IL_09df: Expected O, but got Unknown
		//IL_0d0b: Expected O, but got I
		//IL_12b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b7: Expected O, but got Unknown
		//IL_12cd: Expected O, but got I
		//IL_12de: Expected I, but got O
		//IL_12fc: Expected O, but got I
		//IL_0f0a: Expected O, but got I4
		//IL_0be8: Expected O, but got I
		//IL_0c33: Expected O, but got I4
		//IL_1264: Expected O, but got I4
		//IL_0947: Expected O, but got I4
		//IL_0d34: Expected O, but got I4
		//IL_0e5a: Expected O, but got I4
		//IL_0e63: Expected O, but got I4
		//IL_0e29: Expected O, but got I
		//IL_0f57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5c: Expected O, but got Unknown
		//IL_0f86: Expected O, but got I4
		//IL_0c50: Expected I4, but got O
		//IL_0a38: Expected O, but got I
		//IL_0a4d: Expected O, but got I
		//IL_0a6d: Expected O, but got I4
		//IL_0a76: Expected O, but got I4
		//IL_0a7e: Expected O, but got I4
		//IL_0fbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc0: Expected O, but got Unknown
		//IL_0f2e: Expected O, but got I4
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected O, but got Unknown
		//IL_0fdb: Expected O, but got I
		//IL_0fec: Expected I, but got O
		//IL_0ff8: Expected O, but got I
		//IL_080a: Expected O, but got I4
		//IL_0aac: Expected O, but got I
		//IL_0abc: Expected O, but got I
		//IL_0ae5: Expected O, but got I4
		//IL_1028: Expected O, but got I4
		//IL_08f3: Expected O, but got I
		//IL_0903: Expected O, but got I
		//IL_0913: Expected O, but got I
		//IL_0928: Expected O, but got I4
		//IL_0854: Expected O, but got I4
		//IL_0b09: Expected O, but got I
		//IL_0b2b: Expected O, but got I
		//IL_10a0: Expected O, but got I
		//IL_089a: Expected I, but got O
		//IL_08ce: Expected O, but got I4
		//IL_08d6: Expected I4, but got O
		bool flag = playerCards == null;
		object obj = 0;
		List<System.Int32Enum>.Enumerator enumerator = (List<System.Int32Enum>.Enumerator)0;
		Func<CardData, object> func = (Func<CardData, object>)(object)cardsWantedToPlayList;
		object obj2 = 152993792;
		IReadOnlyList<ListWrapper<CardData>> readOnlyList = cardsWantedToPlayList;
		object obj6 = default(object);
		object obj10;
		object obj7 = default(object);
		if (!flag)
		{
			bool flag2 = cardsWantedToPlayList == null;
			obj = 0;
			enumerator = (List<System.Int32Enum>.Enumerator)0;
			func = (Func<CardData, object>)(object)cardsWantedToPlayList;
			obj2 = 152993792;
			readOnlyList = cardsWantedToPlayList;
			if (!flag2)
			{
				object obj3 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2136;
				nint num = (nint)cardsWantedToPlayList;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v52 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ListWrapper`1<CardData>>>)+12E]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v52 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ListWrapper`1<CardData>>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00fd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v52 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ListWrapper`1<CardData>>>)+B0]");
				object obj5 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X10_v24-8]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X10_v24-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					obj7 = obj5 + 16;
					obj4--;
					bool flag3 = (nint)obj4 != 1;
					obj5 = obj7;
					if (flag3)
					{
						continue;
					}
					goto IL_00fd;
				}
				object obj8 = num + obj5;
				object obj9 = obj8 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v114+8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v479 @ X0_v114] (should have been resolved before IL gen)");
				object obj11 = playerCards._size + 1;
				object obj12 = default(object);
				bool flag4 = obj11 > obj12;
				obj7 = obj5;
				if (flag4)
				{
					goto IL_0153;
				}
				goto IL_01cc;
			}
		}
		goto IL_0e81;
		IL_0406:
		object obj13 = typeof(List<AdaptivePerformanceScaler>) + 424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)2776;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X0_v64+10]");
		List<CardData> list = default(List<CardData>);
		list..ctor((IEnumerable<CardData>)0);
		object obj16 = typeof(List<AdaptivePerformanceScaler>) + 3760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)3944;
		func = (Func<CardData, object>)obj17;
		List<System.Int32Enum> list2 = default(List<System.Int32Enum>);
		list2..ctor();
		bool flag5 = list == null;
		object obj18;
		obj6 = obj18;
		obj = 0;
		enumerator = (List<System.Int32Enum>.Enumerator)0;
		object obj19;
		obj7 = obj19;
		object obj21;
		object obj20 = obj21;
		obj2 = 152993792;
		readOnlyList = (IReadOnlyList<ListWrapper<CardData>>)list;
		System.Int32Enum int32Enum = default(System.Int32Enum);
		CardData item;
		Func<CardData, object> func2;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X0_v66 (System.Collections.Generic.List`1<CardData>)+18]");
			func2 = (Func<CardData, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X0_v66 (System.Collections.Generic.List`1<CardData>)+18]");
			bool flag6 = (nint)0 < (nint)1;
			obj2 = 152993792;
			if (!flag6)
			{
				object obj22 = (nint)0 + (nint)2800;
				bool flag7 = list2 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X0_v66 (System.Collections.Generic.List`1<CardData>)+18]");
				Func<CardData, object> func3 = (Func<CardData, object>)0;
				if (!flag7)
				{
					obj2 = (nint)0 + (nint)2784;
					object obj23 = (nint)0 + (nint)3960;
					obj6 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X0_v66 (System.Collections.Generic.List`1<CardData>)+18]");
					int num2 = 0;
					obj7 = obj19;
					obj20 = obj21;
					while (true)
					{
						num2--;
						obj15 = obj22;
						CardData cardData = list.get_Item(num2);
						int32Enum = (System.Int32Enum)((object)cardData >> 32);
						object obj24 = int32Enum - 4;
						bool flag8 = obj24 == null;
						object obj25 = !flag8;
						object obj26 = ~obj25;
						bool flag9;
						if (obj26 == null)
						{
							object obj27 = cardData - 13;
							flag9 = obj27 == null;
						}
						else
						{
							flag9 = false;
						}
						object obj28 = !flag9;
						func = (Func<CardData, object>)cardData;
						if (obj28 == null)
						{
							obj15 = obj2;
							bool flag10 = list.Remove(cardData);
							object obj29 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v68 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
							object obj30 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v68 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
							obj20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v68 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
							flag7 = (nint)0 == 0;
							obj = 0;
							enumerator = (List<System.Int32Enum>.Enumerator)0;
							func2 = (Func<CardData, object>)num2;
							func = (Func<CardData, object>)cardData;
							readOnlyList = (IReadOnlyList<ListWrapper<CardData>>)list;
							if (flag7)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v68 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
							obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X9_v22+18]");
							obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v68 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X9_v22+18]");
							bool flag11 = num3 < 0;
							object obj31 = !flag11;
							if (obj31 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v91+20]");
								object obj32 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1245 @ X8_v94+C0]");
								object obj33 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1215 @ X8_v95+70]");
								obj15 = 0;
								list2.AddWithResize(int32Enum);
								func = (Func<CardData, object>)int32Enum;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v68 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
								object obj34 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v68 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v68 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
								object obj35 = num4 + 0;
								func = (Func<CardData, object>)cardData;
							}
						}
						bool flag12 = num2 <= 0;
						func2 = (Func<CardData, object>)num2;
						obj21 = obj20;
						if (!flag12)
						{
							continue;
						}
						goto IL_0692;
					}
					goto IL_0e81;
				}
				bool flag15;
				do
				{
					int num5 = func3 - 1;
					obj15 = obj22;
					CardData cardData2 = list.get_Item(num5);
					obj20 = (object)cardData2 >> 32;
					object obj36 = obj20 - 4;
					bool flag13 = obj36 == null;
					object obj37 = !flag13;
					object obj26 = ~obj37;
					bool flag14;
					if (obj26 == null)
					{
						object obj38 = cardData2 - 13;
						flag14 = obj38 == null;
					}
					else
					{
						flag14 = false;
					}
					obj = 0;
					enumerator = (List<System.Int32Enum>.Enumerator)0;
					func2 = (Func<CardData, object>)num5;
					item = cardData2;
					obj2 = 152993792;
					readOnlyList = (IReadOnlyList<ListWrapper<CardData>>)list;
					if (!flag14)
					{
						flag15 = num5 > 0;
						func3 = (Func<CardData, object>)num5;
						func2 = (Func<CardData, object>)num5;
						obj21 = obj20;
						func = (Func<CardData, object>)cardData2;
						obj2 = 152993792;
						continue;
					}
					object obj39 = (nint)0 + (nint)2784;
					obj15 = obj39;
					bool flag16 = ((List<CardData>)readOnlyList).Remove(item);
					throw new NullReferenceException();
				}
				while (flag15);
			}
			goto IL_0692;
		}
		goto IL_0e81;
		IL_0cf1:
		List<object> list3;
		IEnumerable<object> collection;
		list3.AddRange(collection);
		object obj40 = (nint)0 + (nint)1912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C94B6C");
		object obj41 = default(object);
		bool flag17 = obj41 == null;
		object obj42 = !flag17;
		object obj43 = ~obj42;
		if (obj43 == null)
		{
			return (List<Card>)(object)list3;
		}
		List<Card> result;
		return result;
		IL_0cc2:
		collection = Enumerable.Select((IEnumerable<CardData>)readOnlyList, func);
		if (list3 != null)
		{
			goto IL_0cf1;
		}
		goto IL_0e81;
		IL_0153:
		return null;
		IL_0e81:
		item = (CardData)func;
		throw new NullReferenceException();
		IL_0c48:
		Func<object, bool> func4;
		int32Enum = (System.Int32Enum)func4;
		IEnumerable<Card> enumerable;
		func2 = (Func<CardData, object>)(object)enumerable;
		List<object> list4;
		list3 = list4;
		List<Card> list5;
		result = list5;
		goto IL_11f7;
		IL_00fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v111+8]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v369 @ X0_v111] (should have been resolved before IL gen)");
		object obj44 = playerCards._size + 1;
		object obj45 = default(object);
		if (obj44 > obj45)
		{
			goto IL_0153;
		}
		goto IL_01cc;
		IL_01cc:
		object obj46 = typeof(List<AdaptivePerformanceScaler>) + 416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list6 = default(List<object>);
		list6..ctor();
		object obj47 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2384;
		nint num6 = (nint)cardsWantedToPlayList;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v60 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ListWrapper`1<CardData>>>)+12E]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v60 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ListWrapper`1<CardData>>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02b1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v60 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ListWrapper`1<CardData>>>)+B0]");
		obj19 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X10_v11-8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X10_v11-8]");
			if (0 == (nint)obj47)
			{
				break;
			}
			obj7 = obj19 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v60 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ListWrapper`1<CardData>>>)+12E]");
			obj21 = -1;
			bool flag18 = (nint)obj21 != 1;
			obj19 = obj7;
			if (flag18)
			{
				continue;
			}
			goto IL_02b1;
		}
		obj21 = obj19;
		object obj48 = num6 + obj19;
		object obj49 = obj48 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X0_v105+8]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v829 @ X0_v105] (should have been resolved before IL gen)");
		object obj51 = default(object);
		bool flag19 = obj51 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X10_v11-8]");
		obj18 = 0;
		Func<CardData, object> func5 = (Func<CardData, object>)playerCards._size;
		obj = 0;
		enumerator = (List<System.Int32Enum>.Enumerator)0;
		obj7 = obj19;
		obj20 = obj19;
		func = (Func<CardData, object>)playerCards._size;
		obj2 = 152993792;
		readOnlyList = cardsWantedToPlayList;
		if (!flag19)
		{
			goto IL_0406;
		}
		goto IL_0e81;
		IL_0692:
		bool flag20 = list2 == null;
		obj = 0;
		enumerator = (List<System.Int32Enum>.Enumerator)0;
		readOnlyList = (IReadOnlyList<ListWrapper<CardData>>)list;
		if (flag20)
		{
			goto IL_0e81;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v68 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
		bool flag21 = (nint)0 < (nint)1;
		obj = 0;
		enumerator = (List<System.Int32Enum>.Enumerator)0;
		list3 = list6;
		Func<object, bool> func6 = (Func<object, bool>)(object)func;
		result = playerCards;
		readOnlyList = (IReadOnlyList<ListWrapper<CardData>>)list;
		NullReferenceException ex;
		List<System.Int32Enum>.Enumerator enumerator5;
		object obj58 = default(object);
		if (!flag21)
		{
			List<System.Int32Enum>.Enumerator enumerator2 = list2.GetEnumerator();
			object obj57;
			object obj59;
			object obj62 = default(object);
			List<System.Int32Enum>.Enumerator enumerator4;
			List<System.Int32Enum>.Enumerator enumerator3 = default(List<System.Int32Enum>.Enumerator);
			if (list6 != null)
			{
				object obj52 = (nint)0 + (nint)2040;
				object obj53 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1968;
				object obj54 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
				object obj55 = (nint)0 + (nint)920;
				object obj56 = (nint)0 + (nint)2656;
				object obj61 = default(object);
				Func<object, bool> func7 = default(Func<object, bool>);
				while (true)
				{
					bool flag22 = enumerator.MoveNext();
					bool flag23 = !flag22;
					obj57 = obj58;
					func4 = (Func<object, bool>)int32Enum;
					enumerable = (IEnumerable<Card>)(object)func2;
					obj59 = obj15;
					if (flag23)
					{
						break;
					}
					object obj60 = typeof(TrackedDeviceRaycaster.<>c) + 280;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					obj61..ctor();
					bool flag24 = obj61 == null;
					list4 = list6;
					list5 = playerCards;
					obj = obj62;
					enumerator = enumerator3;
					enumerator4 = enumerator3;
					enumerator3 = (List<System.Int32Enum>.Enumerator)0;
					func6 = null;
					readOnlyList = (IReadOnlyList<ListWrapper<CardData>>)list;
					if (!flag24)
					{
						object obj63 = obj53;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X0_v81+E4]");
						bool flag25 = (nint)0 == 0;
						object obj64 = !flag25;
						if (obj64 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						IEnumerable<Card> allBalootCards = BalootCardUtils.AllBalootCards;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						func7..ctor(obj61, (IntPtr)obj55);
						IEnumerable<object> collection2 = Enumerable.Where(allBalootCards, func7);
						obj15 = obj56;
						list6.AddRange(collection2);
						obj58 = 0;
						int32Enum = (System.Int32Enum)func7;
						func2 = (Func<CardData, object>)(object)allBalootCards;
						continue;
					}
					goto IL_0f1d;
				}
			}
			else
			{
				object obj65 = (nint)0 + (nint)2040;
				item = (CardData)obj65;
				bool flag26 = enumerator.MoveNext();
				bool flag27 = !flag26;
				object obj66 = !flag27;
				obj57 = obj58;
				func4 = (Func<object, bool>)int32Enum;
				enumerable = (IEnumerable<Card>)(object)func2;
				obj59 = obj15;
				list4 = list6;
				list5 = playerCards;
				obj = obj62;
				enumerator = enumerator3;
				enumerator4 = enumerator3;
				enumerator3 = (List<System.Int32Enum>.Enumerator)0;
				readOnlyList = (IReadOnlyList<ListWrapper<CardData>>)list;
				if (obj66 != null)
				{
					object obj67 = typeof(TrackedDeviceRaycaster.<>c) + 280;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj68 = default(object);
					obj68..ctor();
					bool flag28 = obj68 == null;
					object obj69 = !flag28;
					func6 = null;
					if (obj69 == null)
					{
						goto IL_0f1d;
					}
					object obj70 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1968;
					object obj71 = obj70;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X0_v44+E4]");
					bool flag29 = (nint)0 == 0;
					object obj72 = !flag29;
					if (obj72 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					IEnumerable<Card> allBalootCards2 = BalootCardUtils.AllBalootCards;
					object obj73 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj74 = (nint)0 + (nint)920;
					Func<object, bool> func8 = default(Func<object, bool>);
					func8..ctor(obj68, (IntPtr)obj74);
					object obj75 = (nint)0 + (nint)3280;
					obj15 = obj75;
					IEnumerable<object> enumerable2 = Enumerable.Where(allBalootCards2, func8);
					ex = new NullReferenceException();
					obj58 = 0;
					func4 = func8;
					enumerator5 = enumerator;
					enumerable = allBalootCards2;
					func6 = func8;
					goto IL_1053;
				}
			}
			object obj76 = (nint)0 + (nint)2032;
			func6 = (Func<object, bool>)obj76;
			enumerator.Dispose();
			obj58 = obj57;
			list4 = list6;
			list5 = playerCards;
			obj = obj62;
			enumerator = enumerator3;
			enumerator4 = enumerator3;
			enumerator3 = (List<System.Int32Enum>.Enumerator)0;
			obj15 = obj59;
			readOnlyList = (IReadOnlyList<ListWrapper<CardData>>)list;
			goto IL_0c48;
		}
		goto IL_11f7;
		IL_0f1d:
		ex = new NullReferenceException();
		func4 = (Func<object, bool>)int32Enum;
		enumerator5 = enumerator;
		enumerable = (IEnumerable<Card>)(object)func2;
		goto IL_1053;
		IL_1053:
		bool flag30 = (nint)func6 != 1;
		NullReferenceException ex2 = ex;
		if (!flag30)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj77 = (nint)0 + (nint)2032;
			func6 = (Func<object, bool>)obj77;
			enumerator5.Dispose();
			object obj78 = default(object);
			bool flag31 = obj78 == null;
			enumerator = enumerator5;
			List<System.Int32Enum>.Enumerator enumerator3 = (List<System.Int32Enum>.Enumerator)obj78;
			if (flag31)
			{
				goto IL_0c48;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			enumerator3 = (List<System.Int32Enum>.Enumerator)obj78;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BD08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		List<Card> result2 = default(List<Card>);
		return result2;
		IL_11f7:
		object obj79 = typeof(TrackedDeviceRaycaster.<>c) + 272;
		object obj80 = obj79;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ X0_v4+E4]");
		object obj81;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ X0_v4+B8]");
			obj81 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X8_v6+20]");
			func = (Func<CardData, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X8_v6+20]");
			bool flag32 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X8_v6+20]");
			Func<CardData, object> func9 = (Func<CardData, object>)0;
			if (!flag32)
			{
				goto IL_0cc2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj80 = obj79;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ X0_v4+B8]");
			obj81 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X8_v6+20]");
			func = (Func<CardData, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X8_v6+20]");
			bool flag33 = (nint)0 == 0;
			object obj82 = !flag33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X8_v6+20]");
			Func<CardData, object> func9 = (Func<CardData, object>)0;
			if (obj82 != null)
			{
				goto IL_0cc2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ X0_v4+E4]");
		bool flag34 = (nint)0 == 0;
		object obj83 = !flag34;
		if (obj83 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj84 = obj79;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1155 @ X8_v14+B8]");
			obj81 = 0;
		}
		object obj85 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj86 = (nint)0 + (nint)912;
		Func<CardData, object> func10 = default(Func<CardData, object>);
		func10..ctor(obj81, (IntPtr)obj86);
		object obj87 = obj79;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X8_v11+B8]");
		object obj88 = (nint)0 + (nint)32;
		obj88 = func10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		collection = Enumerable.Select((IEnumerable<CardData>)readOnlyList, func10);
		bool flag35 = list3 == null;
		object obj89 = !flag35;
		obj58 = 0;
		func2 = func10;
		func = func10;
		if (obj89 != null)
		{
			goto IL_0cf1;
		}
		goto IL_0e81;
		IL_02b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v102+8]");
		obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v777 @ X0_v102] (should have been resolved before IL gen)");
		bool flag36 = obj51 == null;
		object obj90 = !flag36;
		obj18 = obj6;
		obj19 = obj7;
		func5 = (Func<CardData, object>)playerCards._size;
		if (obj90 != null)
		{
			goto IL_0406;
		}
		obj = 0;
		enumerator = (List<System.Int32Enum>.Enumerator)0;
		func = (Func<CardData, object>)playerCards._size;
		obj2 = 152993792;
		readOnlyList = cardsWantedToPlayList;
		goto IL_0e81;
	}

	protected override void OnEndRound()
	{
		//IL_0016: Expected O, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_0230: Expected O, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01ec: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80EF]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A5]");
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
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A5]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v13+B8]");
		object obj8 = 0;
		TutorialGame tutorialGame = (TutorialGame)obj8;
		obj2 = obj4;
		goto IL_0162;
		IL_0162:
		tutorialGame.OnEndRound();
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v6+B8]");
		object obj10 = 0;
		object obj11 = obj10;
		object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1512;
		object obj13 = typeof(RegisteredWaitHandle) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v8+20]");
		LastRoutingParams lastRoutingParams = default(LastRoutingParams);
		lastRoutingParams..ctor(RoutingCommand.NO_MESSAGE);
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj15 = !flag3;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj13;
		}
		object obj16 = lastRoutingParams;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base.OnEndRound();
		return;
		IL_0082:
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v18+B8]");
		object obj18 = 0;
		tutorialGame = (TutorialGame)obj18;
		bool flag4 = obj18 == null;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0162;
	}

	protected override void DiscardOfflineGame()
	{
	}

	protected override void UpdateOfflineGameStats()
	{
	}
}
