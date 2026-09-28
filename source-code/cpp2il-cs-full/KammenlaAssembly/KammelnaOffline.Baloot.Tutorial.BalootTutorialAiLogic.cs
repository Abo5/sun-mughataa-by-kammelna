using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine.Purchasing.Telemetry;

namespace KammelnaOffline.Baloot.Tutorial;

public class BalootTutorialAiLogic : BalootAiLogic
{
	private new TutorialGameController _gameController
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			TutorialGameController gameController = (TutorialGameController)base._gameController;
			if (base._gameController != null)
			{
				object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
				object obj2 = obj;
				nint num = (nint)gameController;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<KammelnaOffline.Baloot.Tutorial.TutorialGameController>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<KammelnaOffline.Baloot.Tutorial.TutorialGameController>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (TutorialGameController)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return (TutorialGameController)base._gameController;
		}
	}

	public BalootTutorialAiLogic(TutorialGameController gameController)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = gameController;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override Card PlayCard(List<Card> cards, int playerIndex)
	{
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01ef: Expected I, but got O
		//IL_0218: Expected O, but got I4
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_024c: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_012d: Expected I, but got O
		//IL_0156: Expected O, but got I4
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0370: Expected O, but got I
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_018a: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_006b: Expected I, but got O
		//IL_0094: Expected O, but got I4
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		object obj9;
		if (playerIndex != 4)
		{
			if (playerIndex != 3)
			{
				if (playerIndex != 2)
				{
					object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj2 = "placementId" + 152;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					object obj3 = "Added Tournament Prizes And Features" + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
					string paramName = default(string);
					string message = default(string);
					ex..ctor(paramName, message);
					object obj4 = (nint)0 + (nint)2392;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					return (Card)(object)new OutOfMemoryException();
				}
				BalootGameController gameController = base._gameController;
				if (base._gameController != null)
				{
					object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
					List<Card> list = (List<Card>)obj5;
					nint num = (nint)gameController;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v34 (Il2CppClass<KammelnaOffline.Baloot.BalootGameController>)+130]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X1_v1 (System.Collections.Generic.List`1<Card>)+130]");
					bool flag = num2 < 0;
					object obj6 = !flag;
					object obj7 = ~obj6;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v34 (Il2CppClass<KammelnaOffline.Baloot.BalootGameController>)+C8]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X1_v1 (System.Collections.Generic.List`1<Card>)+130]");
						object obj8 = num3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v36-8]");
						if (0 == (nint)list)
						{
							obj9 = base._gameController + 200;
							goto IL_03d3;
						}
					}
					goto IL_02d6;
				}
			}
			else
			{
				BalootGameController gameController2 = base._gameController;
				if (base._gameController != null)
				{
					object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
					List<Card> list = (List<Card>)obj10;
					nint num4 = (nint)gameController2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v24 (Il2CppClass<KammelnaOffline.Baloot.BalootGameController>)+130]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X1_v1 (System.Collections.Generic.List`1<Card>)+130]");
					bool flag2 = num5 < 0;
					object obj11 = !flag2;
					object obj12 = ~obj11;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v24 (Il2CppClass<KammelnaOffline.Baloot.BalootGameController>)+C8]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X1_v1 (System.Collections.Generic.List`1<Card>)+130]");
						object obj13 = num6 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v26-8]");
						if (0 == (nint)list)
						{
							obj9 = base._gameController + 208;
							goto IL_03d3;
						}
					}
					goto IL_02d6;
				}
			}
		}
		else
		{
			BalootGameController gameController3 = base._gameController;
			if (base._gameController != null)
			{
				object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
				List<Card> list = (List<Card>)obj14;
				nint num7 = (nint)gameController3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v14 (Il2CppClass<KammelnaOffline.Baloot.BalootGameController>)+130]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X1_v1 (System.Collections.Generic.List`1<Card>)+130]");
				bool flag3 = num8 < 0;
				object obj15 = !flag3;
				object obj16 = ~obj15;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v14 (Il2CppClass<KammelnaOffline.Baloot.BalootGameController>)+C8]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X1_v1 (System.Collections.Generic.List`1<Card>)+130]");
					object obj17 = num9 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v16-8]");
					if (0 == (nint)list)
					{
						obj9 = base._gameController + 216;
						goto IL_03d3;
					}
				}
				goto IL_02d6;
			}
		}
		goto IL_02e4;
		IL_02e4:
		throw new NullReferenceException();
		IL_02d6:
		InvalidCastException ex2 = new InvalidCastException();
		goto IL_02e4;
		IL_03d3:
		IEnumerable<object> enumerable = (IEnumerable<object>)obj9;
		if (obj9 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X19_v2 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
			if ((nint)0 != 0)
			{
				object result = Enumerable.First((IEnumerable<object>)obj9);
				((List<object>)obj9).RemoveAt(0);
				return (Card)result;
			}
			return null;
		}
		goto IL_02e4;
	}

	public unsafe override string Bid(int biddingState, List<Card> cards, int playerIndex)
	{
		//IL_0016: Expected O, but got I
		//IL_0230: Expected O, but got I
		//IL_024a: Expected O, but got I4
		//IL_0056: Expected O, but got I
		//IL_028c: Expected O, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00da: Expected I, but got O
		//IL_0103: Expected O, but got I4
		//IL_03f2: Expected O, but got I
		//IL_0137: Expected O, but got I
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected O, but got Unknown
		//IL_044d: Expected O, but got Ref
		//IL_016e: Expected O, but got I
		//IL_047e: Expected O, but got I
		//IL_04ae: Expected O, but got I4
		//IL_036a: Expected O, but got I
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected O, but got Unknown
		//IL_03c1: Expected O, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80DA]");
		object obj = (nint)0 & (nint)1;
		BalootBiddingOption[] array;
		BalootBiddingOption[] array2;
		if (obj != null)
		{
			array = BalootBiddingOptions.GetBiddingOptionsFromState(biddingState);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80D8]");
			object obj2 = (nint)0 & (nint)1;
			bool flag = obj2 == null;
			array2 = array;
			if (!flag)
			{
				goto IL_007b;
			}
		}
		else
		{
			_ = 1;
			array2 = BalootBiddingOptions.GetBiddingOptionsFromState(biddingState);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80D8]");
			object obj3 = (nint)0 & (nint)1;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			array = array2;
			if (obj4 != null)
			{
				goto IL_007b;
			}
		}
		_ = 1;
		BalootGameController gameController = base._gameController;
		bool flag3 = base._gameController == null;
		object obj5 = !flag3;
		IEnumerable<System.Int32Enum> source = (IEnumerable<System.Int32Enum>)(object)array2;
		BalootGameController balootGameController = base._gameController;
		if (obj5 != null)
		{
			goto IL_00b6;
		}
		goto IL_02ac;
		IL_04e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		return EnumExtensions.GetFriendlyName(enumeration);
		IL_03e6:
		object obj6 = (nint)0 + (nint)3168;
		object obj7 = obj6;
		if (Enumerable.Contains(source, (System.Int32Enum)7))
		{
			goto IL_0429;
		}
		goto IL_04bc;
		IL_02c2:
		if ((nint)balootGameController == 8)
		{
			goto IL_031c;
		}
		if ((nint)balootGameController != 11)
		{
			if ((nint)balootGameController == 12)
			{
				goto IL_031c;
			}
		}
		else if (playerIndex == 4)
		{
			object obj8 = (nint)0 + (nint)3168;
			obj7 = obj8;
			bool flag4 = Enumerable.Contains(source, (System.Int32Enum)7);
			bool flag5 = !flag4;
			object obj9 = !flag5;
			if (obj9 != null)
			{
				goto IL_0429;
			}
		}
		goto IL_04bc;
		IL_007b:
		gameController = base._gameController;
		bool flag6 = base._gameController == null;
		source = (IEnumerable<System.Int32Enum>)(object)array;
		balootGameController = base._gameController;
		if (!flag6)
		{
			goto IL_00b6;
		}
		goto IL_02ac;
		IL_02ac:
		NullReferenceException ex = new NullReferenceException();
		source = (IEnumerable<System.Int32Enum>)ex;
		goto IL_02c2;
		IL_00b6:
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
		object obj11 = obj10;
		nint num = (nint)gameController;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X9_v9 (Il2CppClass<KammelnaOffline.Baloot.BalootGameController>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X1_v12+130]");
		bool flag7 = num2 < 0;
		object obj12 = !flag7;
		object obj13 = ~obj12;
		object obj17;
		object obj18;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X9_v9 (Il2CppClass<KammelnaOffline.Baloot.BalootGameController>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X1_v12+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X9_v12-8]");
			if (0 == (nint)obj11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v23 (KammelnaOffline.Baloot.BalootGameController)+C0]");
				balootGameController = (BalootGameController)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v23 (KammelnaOffline.Baloot.BalootGameController)+C0]");
				if ((nint)0 > (nint)7)
				{
					goto IL_02c2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v23 (KammelnaOffline.Baloot.BalootGameController)+C0]");
				if ((nint)0 != 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v23 (KammelnaOffline.Baloot.BalootGameController)+C0]");
					if ((nint)0 != 4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v23 (KammelnaOffline.Baloot.BalootGameController)+C0]");
						if ((nint)0 == 7)
						{
							goto IL_031c;
						}
					}
					else if (playerIndex == 3)
					{
						goto IL_03e6;
					}
				}
				else if (playerIndex == 3)
				{
					object obj15 = (nint)0 + (nint)3168;
					obj7 = obj15;
					if (Enumerable.Contains(source, (System.Int32Enum)2))
					{
						object obj16 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1960;
						obj17 = obj16;
						object obj19 = default(object);
						obj18 = (object)(&obj19);
						goto IL_04e5;
					}
				}
				goto IL_04bc;
			}
		}
		return (string)(object)new InvalidCastException();
		IL_0429:
		object obj20 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1960;
		obj17 = obj20;
		object obj21 = default(object);
		obj18 = (object)(&obj21);
		goto IL_04e5;
		IL_04bc:
		return base.Bid(biddingState, cards, playerIndex);
		IL_031c:
		if (playerIndex == 2)
		{
			goto IL_03e6;
		}
		goto IL_04bc;
	}

	public override string GetAction(int playerIndex)
	{
		//IL_0016: Expected O, but got I
		//IL_020a: Expected O, but got I
		//IL_0224: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0091: Expected I4, but got O
		//IL_0099: Expected I, but got O
		//IL_00c2: Expected O, but got I4
		//IL_025e: Expected O, but got I4
		//IL_00f6: Expected O, but got I
		//IL_01b4: Expected O, but got I
		//IL_01cc: Expected O, but got I4
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80DB]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80D8]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80D8]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		BalootGameController gameController = base._gameController;
		bool flag2 = base._gameController == null;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0075;
		IL_0066:
		gameController = base._gameController;
		goto IL_0075;
		IL_0075:
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
		int num = (int)obj6;
		nint num2 = (nint)gameController;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v12 (Il2CppClass<KammelnaOffline.Baloot.BalootGameController>)+130]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X1_v2 (System.Int32)+130]");
		bool flag3 = num3 < 0;
		object obj7 = !flag3;
		object obj8 = ~obj7;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v12 (Il2CppClass<KammelnaOffline.Baloot.BalootGameController>)+C8]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X1_v2 (System.Int32)+130]");
			object obj9 = num4 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v15-8]");
			if ((nint)0 == num)
			{
				if (playerIndex == 4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v15 (KammelnaOffline.Baloot.BalootGameController)+C0]");
					if ((nint)0 == 11 && gameController.MoveNumber == 5)
					{
						return "___# Content push apply failed [{0}]: {1}" + 2712;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80BF]");
				object obj10 = (nint)0 & (nint)1;
				bool flag4 = obj10 == null;
				BalootTutorialAiLogic balootTutorialAiLogic = (BalootTutorialAiLogic)152993792;
				if (!flag4)
				{
					return "___# Content push apply failed [{0}]: {1}" + 2664;
				}
				object result = "___# Content push apply failed [{0}]: {1}" + 2664;
				_ = 1;
				return (string)result;
			}
		}
		return (string)(object)new InvalidCastException();
	}
}
