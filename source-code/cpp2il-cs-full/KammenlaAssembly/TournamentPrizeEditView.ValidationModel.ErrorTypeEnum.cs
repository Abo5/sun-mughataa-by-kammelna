using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using Spine;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentPrizeEditView : MonoBehaviour
{
	public enum TournamentPrize
	{
		FirstPrize = 1,
		SecondPrize
	}

	public class ValidationModel
	{
		public enum ErrorTypeEnum
		{
			NoError,
			PrizeInvalid,
			MissingFirstPrize,
			SecondPrizeBiggerThanFirst,
			PrizeIsBelowThreshold,
			NotEnoughAces
		}

		public static readonly ValidationModel NoError;

		public static readonly ValidationModel PrizeInvalid;

		public static readonly ValidationModel MissingFirstPrize;

		public static readonly ValidationModel SecondPrizeBiggerThanFirst;

		public static readonly ValidationModel PrizeIsBelowThreshold;

		public static readonly ValidationModel NotEnoughAces;

		public ErrorTypeEnum ErrorType;

		public bool IsValid => ErrorType == ErrorTypeEnum.NoError;

		public string ValidationErrorMessage
		{
			get
			{
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0014: Expected O, but got Unknown
				object obj = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 1784;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				Enum enumeration = default(Enum);
				return EnumExtensions.GetFriendlyName(enumeration);
			}
		}

		private ValidationModel(ErrorTypeEnum errorType)
		{
			ErrorType = errorType;
		}

		static ValidationModel()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0055: Expected O, but got I
			//IL_00a3: Expected O, but got I
			//IL_00f6: Expected O, but got I
			//IL_0144: Expected O, but got I
			//IL_0197: Expected O, but got I
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3808;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			_ = 0;
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj5 = default(object);
			obj5..ctor();
			_ = 1;
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5+B8]");
			object obj7 = (nint)0 + (nint)8;
			obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj8 = default(object);
			obj8..ctor();
			_ = 2;
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v7+B8]");
			object obj10 = (nint)0 + (nint)16;
			obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = default(object);
			obj11..ctor();
			_ = 3;
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v9+B8]");
			object obj13 = (nint)0 + (nint)24;
			obj13 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = default(object);
			obj14..ctor();
			_ = 4;
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v11+B8]");
			object obj16 = (nint)0 + (nint)32;
			obj16 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj17 = default(object);
			obj17..ctor();
			_ = 5;
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v13+B8]");
			object obj19 = (nint)0 + (nint)40;
			obj19 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private TournamentPrizeSelector Manager;

	private PopupUI popup;

	private TextMeshProUGUI title;

	private TextMeshProUGUI editMessage;

	private InputFieldTMProUGUI acesPrizeInput;

	private Button confirmChangeButton;

	private Button removePrizeButton;

	private GameObject quickPrizesButtonsArea;

	private Button quickPrizeThirtyButton;

	private TextMeshProUGUI quickPrizeThirtyText;

	private Button quickPrizeFiftyButton;

	private TextMeshProUGUI quickPrizeFiftyText;

	private TournamentPrize _tournamentPrize;

	private const int AcesPrizeStep = 1000;

	private unsafe int AcesPrize
	{
		get
		{
			//IL_0008: Expected O, but got Ref
			//IL_00c2: Expected I4, but got O
			//IL_007a: Expected O, but got I4
			object obj2 = default(object);
			object obj = (object)(&obj2);
			_ = 0;
			if ((object)acesPrizeInput != null)
			{
				string text = acesPrizeInput.Text;
				bool flag = int.TryParse(text, out System.Runtime.CompilerServices.Unsafe.As<object, int>(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 4)));
				bool flag2 = !flag;
				object obj3 = !flag2;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X29_v1-4]");
					return 0;
				}
				return 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private int FiftyPercent
	{
		get
		{
			//IL_00bd: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			//IL_0077: Expected I4, but got I8
			TournamentPrizeSelector manager = Manager;
			if ((object)Manager != null)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int num = (int)(manager.firstPrizeAces / 4652007308841189376L);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
				return num * 1000;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private int ThirtyPercent
	{
		get
		{
			//IL_00d5: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			//IL_00c2: Expected I4, but got F8
			TournamentPrizeSelector manager = Manager;
			if ((object)Manager != null)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double num = (double)manager.firstPrizeAces / 2.0000000002328306;
				double num2 = num / 4.652007308841189E+18;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
				double num3 = num2 * 1000.0;
				return (int)num3;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public ValidationModel GetValidationModel(TournamentCreationPopup manager)
	{
		//IL_005b: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_04a6: Expected O, but got I4
		//IL_0153: Expected O, but got I4
		//IL_0432: Expected O, but got I4
		//IL_06e0: Expected O, but got I
		//IL_06aa: Expected O, but got I
		//IL_00de: Expected O, but got I4
		//IL_0695: Expected O, but got I
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected I8, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected O, but got Unknown
		//IL_03eb: Expected O, but got I4
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected O, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected O, but got Unknown
		//IL_0535: Expected O, but got I4
		//IL_06c5: Expected O, but got I
		//IL_062f: Expected O, but got I4
		//IL_06fb: Expected O, but got I
		//IL_0716: Expected O, but got I
		//IL_05e5: Expected O, but got I4
		//IL_01c7: Expected O, but got I
		//IL_01cf: Expected I, but got O
		//IL_0200: Expected O, but got I4
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_033c: Expected O, but got I4
		//IL_05f8: Expected I, but got O
		//IL_0600: Expected I4, but got I8
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_0255: Expected O, but got I4
		//IL_027e: Expected O, but got I
		//IL_02d9: Expected I, but got O
		//IL_02e7: Expected I, but got O
		TournamentConfig config;
		int firstPrizeAces;
		int secondPrizeAces;
		object obj;
		object obj2;
		object obj6;
		if ((object)manager != null)
		{
			config = manager.Config;
			if (config != null)
			{
				firstPrizeAces = manager.firstPrizeAces;
				secondPrizeAces = manager.secondPrizeAces;
				obj = secondPrizeAces + firstPrizeAces;
				if (config.<TournamentPrizeCondition>k__BackingField == TournamentConfig.PrizeCondition.Disallowed)
				{
					obj2 = typeof(SkeletonBinary.SkeletonInput) + 3808;
					object obj3 = obj2;
					if ((nint)obj > 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v12+E4]");
						bool flag = (nint)0 == 0;
						object obj4 = !flag;
						if (obj4 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj3 = obj2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v12+B8]");
						return (ValidationModel)((nint)0 + (nint)8);
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v12+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					UserPermission userPermission = (UserPermission)0;
					obj6 = obj3;
					if (obj5 == null)
					{
						goto IL_0451;
					}
					goto IL_069a;
				}
				bool flag3 = config.<TournamentPrizeCondition>k__BackingField == TournamentConfig.PrizeCondition.Required;
				object obj7 = !flag3;
				UserPermission userPermission2 = (UserPermission)0;
				if (obj7 == null)
				{
					bool flag4 = obj == null;
					object obj8 = !flag4;
					userPermission2 = (UserPermission)0;
					if (obj8 == null)
					{
						FeaturesBottomSheet addonManager = manager.addonManager;
						if ((object)manager.addonManager == null || addonManager.SelectedAddons == null)
						{
							goto IL_0654;
						}
						object obj9 = (nint)0 + (nint)2296;
						nint num = (nint)obj9;
						bool flag5 = ((Dictionary<System.Int32Enum, object>)(object)addonManager.SelectedAddons).ContainsKey((System.Int32Enum)5);
						bool flag6 = !flag5;
						object obj10 = !flag6;
						UserPermission userPermission = (UserPermission)5;
						if (obj10 == null)
						{
							object obj11 = typeof(Queue<string>) + 848;
							object obj12 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v46+E4]");
							bool flag7 = (nint)0 == 0;
							object obj13 = !flag7;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj14 = (nint)0 + (nint)2200;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
							SessionModel sessionModel = default(SessionModel);
							if ((object)sessionModel == null)
							{
								goto IL_0654;
							}
							User localUser = sessionModel.LocalUser;
							bool flag8 = SFSKammelnaUserExtensions.Can(localUser, UserPermission.CreateTournamentsWithNoPrize);
							bool flag9 = !flag8;
							num = unchecked((nint)null);
							userPermission = UserPermission.CreateTournamentsWithNoPrize;
							nint num2 = unchecked((nint)null);
							userPermission2 = UserPermission.CreateTournamentsWithNoPrize;
							if (flag9)
							{
								goto IL_035f;
							}
						}
						obj2 = typeof(SkeletonBinary.SkeletonInput) + 3808;
						obj6 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v28+E4]");
						bool flag10 = (nint)0 == 0;
						object obj15 = !flag10;
						if (obj15 == null)
						{
							nint num2 = num;
							object obj3 = obj6;
							goto IL_0451;
						}
						goto IL_069a;
					}
				}
				goto IL_035f;
			}
		}
		goto IL_0654;
		IL_0451:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = obj2;
		goto IL_069a;
		IL_0654:
		return (ValidationModel)(object)new NullReferenceException();
		IL_069a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v28+B8]");
		return (ValidationModel)0;
		IL_035f:
		if (((uint)firstPrizeAces | (uint)config.<TournamentPrizeCondition>k__BackingField) != 0)
		{
			if (secondPrizeAces > firstPrizeAces)
			{
				object obj16 = typeof(SkeletonBinary.SkeletonInput) + 3808;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v38+E4]");
				bool flag11 = (nint)0 == 0;
				object obj18 = !flag11;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj17 = obj16;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v38+B8]");
				return (ValidationModel)((nint)0 + (nint)24);
			}
			int minimumPrize = manager.GetMinimumPrize();
			if ((nint)obj < minimumPrize)
			{
				object obj19 = typeof(SkeletonBinary.SkeletonInput) + 3808;
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v33+E4]");
				bool flag12 = (nint)0 == 0;
				object obj21 = !flag12;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj20 = obj19;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v33+B8]");
				return (ValidationModel)((nint)0 + (nint)32);
			}
			int fixedFeeCost = manager.GetFixedFeeCost();
			long num3 = obj + fixedFeeCost;
			bool flag13 = manager.CanCreatorAfford(num3);
			obj2 = typeof(SkeletonBinary.SkeletonInput) + 3808;
			obj6 = obj2;
			if (flag13)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v28+E4]");
				bool flag14 = (nint)0 == 0;
				object obj22 = !flag14;
				if (obj22 == null)
				{
					nint num2 = unchecked((nint)null);
					UserPermission userPermission = (UserPermission)num3;
					object obj3 = obj6;
					goto IL_0451;
				}
				goto IL_069a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v28+E4]");
			bool flag15 = (nint)0 == 0;
			object obj23 = !flag15;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v28+B8]");
			return (ValidationModel)((nint)0 + (nint)40);
		}
		object obj24 = typeof(SkeletonBinary.SkeletonInput) + 3808;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v17+E4]");
		bool flag16 = (nint)0 == 0;
		object obj26 = !flag16;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = obj24;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v17+B8]");
		return (ValidationModel)((nint)0 + (nint)16);
	}

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I
		//IL_00db: Expected I, but got O
		//IL_00ec: Expected O, but got I
		//IL_0118: Expected I, but got O
		//IL_0147: Expected O, but got I
		//IL_015f: Expected I, but got O
		//IL_0191: Expected O, but got I
		//IL_01a9: Expected I, but got O
		Button button = confirmChangeButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)1200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = removePrizeButton;
		object obj3 = (nint)0 + (nint)1224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj5 = (nint)0 + (nint)1240;
		button2.m_OnClick.AddListener(unityAction2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj5);
		object obj6 = (nint)0 + (nint)1208;
		acesPrizeInput.OnValueChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj6);
		acesPrizeInput.OnEndEdit += action2;
		Button button3 = quickPrizeFiftyButton;
		object obj7 = (nint)0 + (nint)1216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj7);
		button3.m_OnClick.AddListener(unityAction3);
		Button button4 = quickPrizeThirtyButton;
		object obj8 = (nint)0 + (nint)1232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction4 = default(UnityAction);
		unityAction4..ctor(this, (IntPtr)obj8);
		button4.m_OnClick.AddListener(unityAction4);
	}

	public void Populate(TournamentPrizeSelector manager, TournamentPrize prize)
	{
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_001f: Expected I4, but got O
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0181: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_01bd: Expected I, but got O
		//IL_01f9: Expected O, but got I4
		object obj = this + 32;
		TournamentPrizeSelector tournamentPrizeSelector = default(TournamentPrizeSelector);
		obj = tournamentPrizeSelector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject3;
		bool flag2;
		if (prize != TournamentPrize.SecondPrize)
		{
			bool flag = prize != TournamentPrize.FirstPrize;
			flag2 = (byte)(int)tournamentPrizeSelector != 0;
			if (flag)
			{
				goto IL_02c7;
			}
			object text = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 408;
			TextMeshProExtensions.Localize(title, (string)text);
			object text2 = "SERVICE_DISABLED" + 3632;
			TextMeshProExtensions.Localize(editMessage, (string)text2);
			GameObject gameObject = removePrizeButton.gameObject;
			gameObject.SetActive(value: false);
			quickPrizesButtonsArea.SetActive(value: false);
			GameObject gameObject2 = quickPrizeThirtyButton.gameObject;
			gameObject2.SetActive(value: false);
			gameObject3 = quickPrizeFiftyButton.gameObject;
			flag2 = false;
		}
		else
		{
			object text3 = "SERVICE_DISABLED" + 2416;
			TextMeshProExtensions.Localize(title, (string)text3);
			object text4 = "SERVICE_DISABLED" + 3704;
			TextMeshProExtensions.Localize(editMessage, (string)text4);
			TextMeshProUGUI textMeshProUGUI = quickPrizeFiftyText;
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			int num = default(int);
			string text5 = num.ToString();
			nint num2 = (nint)textMeshProUGUI;
			textMeshProUGUI.text = text5;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X0_v19+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			string text6 = num.ToString();
			quickPrizeThirtyText.text = text6;
			GameObject gameObject4 = removePrizeButton.gameObject;
			gameObject4.SetActive(value: true);
			quickPrizesButtonsArea.SetActive(value: true);
			GameObject gameObject5 = quickPrizeThirtyButton.gameObject;
			gameObject5.SetActive(value: true);
			gameObject3 = quickPrizeFiftyButton.gameObject;
			flag2 = true;
		}
		gameObject3.SetActive(flag2);
		goto IL_02c7;
		IL_02c7:
		SetInput();
	}

	private unsafe void SetInput()
	{
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected I4, but got Unknown
		//IL_0255: Expected O, but got I4
		//IL_0265: Expected O, but got I
		//IL_0275: Expected O, but got I
		//IL_01ca: Expected O, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected I4, but got Unknown
		//IL_01f4: Expected O, but got I4
		//IL_0204: Expected O, but got I
		//IL_0214: Expected O, but got I
		//IL_00f5: Expected O, but got I4
		int num = default(int);
		if (_tournamentPrize != TournamentPrize.SecondPrize)
		{
			if (_tournamentPrize != TournamentPrize.FirstPrize)
			{
				return;
			}
			TournamentPrizeSelector manager = Manager;
			int minimumPrize = manager.manager.GetMinimumPrize();
			string text = num.ToString();
			LocalizableText placeholder = TextMeshProExtensions.FixOnly(text);
			acesPrizeInput.SetPlaceholder(placeholder);
			int num2 = Manager + 136;
			string text3;
			if (((int*)num2)->m_value != 0)
			{
				string text2 = ((int*)num2)->ToString();
				bool flag = (object)acesPrizeInput == null;
				object obj = !flag;
				text3 = text2;
				if (obj == null)
				{
					goto IL_0292;
				}
			}
			else
			{
				object obj2 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v21+90]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v22+B8]");
				object obj4 = 0;
				text3 = (string)obj4;
			}
			acesPrizeInput.Text = text3;
			acesPrizeInput.ShowKeyboard();
			return;
		}
		TournamentPrizeSelector manager2 = Manager;
		int minimumPrize2 = manager2.manager.GetMinimumPrize();
		string text4 = num.ToString();
		LocalizableText placeholder2 = TextMeshProExtensions.FixOnly(text4);
		acesPrizeInput.SetPlaceholder(placeholder2);
		int num3 = Manager + 140;
		string text6;
		if (((int*)num3)->m_value != 0)
		{
			string text5 = ((int*)num3)->ToString();
			bool flag2 = (object)acesPrizeInput == null;
			object obj5 = !flag2;
			text6 = text5;
			if (obj5 == null)
			{
				goto IL_0292;
			}
		}
		else
		{
			object obj6 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v13+90]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v14+B8]");
			object obj8 = 0;
			text6 = (string)obj8;
		}
		acesPrizeInput.Text = text6;
		return;
		IL_0292:
		throw new NullReferenceException();
	}

	private void OnConfirm()
	{
		//IL_010f: Expected O, but got I4
		//IL_008f: Expected O, but got I4
		if (_tournamentPrize != TournamentPrize.SecondPrize)
		{
			if (_tournamentPrize == TournamentPrize.FirstPrize)
			{
				TournamentPrizeSelector manager = Manager;
				string text = acesPrizeInput.Text;
				int result;
				bool flag = int.TryParse(text, out result);
				bool flag2 = !flag;
				object obj = !flag2;
				object obj2 = ~obj;
				int firstPrizeAces = ((obj2 == null) ? result : 0);
				manager.firstPrizeAces = firstPrizeAces;
			}
		}
		else
		{
			TournamentPrizeSelector manager2 = Manager;
			string text2 = acesPrizeInput.Text;
			int result2;
			bool flag3 = int.TryParse(text2, out result2);
			bool flag4 = !flag3;
			object obj3 = !flag4;
			object obj4 = ~obj3;
			int secondPrizeAces = ((obj4 == null) ? result2 : 0);
			manager2.secondPrizeAces = secondPrizeAces;
		}
		Manager.OnPrizeChanged();
		popup.ShrinkToParent();
	}

	private void OnRemove()
	{
		TournamentPrizeSelector manager = Manager;
		manager.secondPrizeAces = 0;
		manager.OnPrizeChanged();
		popup.ShrinkToParent();
	}

	private void OnFiftyPrize()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		int num = default(int);
		string text = num.ToString();
		acesPrizeInput.Text = text;
	}

	private void OnThirtyPrize()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		int num = default(int);
		string text = num.ToString();
		acesPrizeInput.Text = text;
	}

	private void SnapAcesPrize(string value)
	{
		UIExtensions.EnsureNumeric(acesPrizeInput, 1000000000.0);
	}

	private unsafe void OnEditEnd(string value)
	{
		//IL_0038: Expected O, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0088: Expected O, but got I4
		//IL_00d7: Expected I, but got O
		//IL_00df: Expected O, but got Ref
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0150: Expected O, but got I4
		//IL_017f: Expected I4, but got I8
		//IL_01a3: Expected O, but got I4
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_01e2: Expected O, but got I4
		//IL_0208: Expected O, but got I8
		//IL_020d: Expected I, but got O
		//IL_0215: Expected O, but got Ref
		//IL_023a: Expected O, but got Ref
		//IL_02c7: Expected O, but got I8
		//IL_02cc: Expected I, but got O
		//IL_0250: Expected I, but got O
		//IL_0260: Expected O, but got I
		//IL_0286: Expected O, but got I8
		//IL_028b: Expected I, but got O
		//IL_029b: Expected O, but got I
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected O, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_0365: Expected O, but got I4
		//IL_0459: Expected O, but got I4
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if ((object)acesPrizeInput != null)
		{
			string text = acesPrizeInput.Text;
			int result;
			bool flag = int.TryParse(text, out result);
			object obj = result * 274877907;
			object obj2 = obj >> 38;
			object obj3 = obj2 + obj2;
			object obj4 = obj3 * 1000;
			object obj5 = result - obj4;
			bool flag2 = !flag;
			object obj6 = !flag2;
			object obj7 = ~obj6;
			if (obj7 != null || obj5 == null)
			{
				return;
			}
			bool flag3 = (object)acesPrizeInput == null;
			nint num = unchecked((nint)null);
			string text2 = (string)(&result);
			if (!flag3)
			{
				string text3 = acesPrizeInput.Text;
				bool flag4 = int.TryParse(text3, out result);
				object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v16+E4]");
				bool flag5 = (nint)0 == 0;
				object obj10 = !flag5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int num2 = (int)(result / 4652007308841189376L);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
				bool flag6 = !flag4;
				object obj11 = !flag6;
				object obj12 = ~obj11;
				if (obj12 != null)
				{
					num2 = 0;
				}
				if (num2 == 9218868437227405312L)
				{
				}
				string text4 = result.ToString();
				acesPrizeInput.Text = text4;
				object obj13 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object obj14 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object[] array = default(object[]);
				bool flag7 = array == null;
				object obj15 = 9218868437227405312L;
				num = unchecked((nint)null);
				object obj16 = default(object);
				text2 = (string)(&obj16);
				if (!flag7)
				{
					object obj17 = default(object);
					bool flag8 = obj17 == null;
					string text5 = (string)(&obj16);
					if (!flag8)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
						text5 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag9 = ex == null;
						obj15 = 9218868437227405312L;
						num = unchecked((nint)null);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
						text2 = (string)0;
						if (flag9)
						{
							goto IL_039f;
						}
					}
					bool flag10 = array.Length == 0;
					obj15 = 9218868437227405312L;
					num = unchecked((nint)null);
					text2 = text5;
					if (!flag10)
					{
						object obj18 = array + 32;
						obj18 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object text6 = "placementId" + 1016;
						LocalizableText text7 = TextMeshProExtensions.LocalizeWith((string)text6, array);
						object obj19 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
						object obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v27+E4]");
						bool flag11 = (nint)0 == 0;
						object obj21 = !flag11;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Toast.Show(text7, (Vector2)0, 0f);
						return;
					}
					goto IL_0391;
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0391;
		IL_0391:
		ex = new IndexOutOfRangeException();
		goto IL_039f;
		IL_039f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	public void Show()
	{
		popup.PopFromCenter();
		acesPrizeInput.Select();
	}
}
