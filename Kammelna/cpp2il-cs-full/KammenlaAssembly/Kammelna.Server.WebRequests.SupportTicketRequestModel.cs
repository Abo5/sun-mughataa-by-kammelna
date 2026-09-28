using System;
using System.Buffers.Text;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using ReportEnums;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.InputSystem.XR;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class SupportTicketRequestModel
{
	private ProblemCategory <Category>k__BackingField;

	private SubscriptionAndCoinsIssues <SubscriptionAndCoinsIssue>k__BackingField;

	private GameProblems <GameProblem>k__BackingField;

	private MembershipProblems <MembershipProblems>k__BackingField;

	private PlayerReportType <PlayerReportType>k__BackingField;

	private SuggestionsAndInquiriesType <SuggestionsAndInquiriesType>k__BackingField;

	private WebOrdersProblems <WebOrdersIssues>k__BackingField;

	private string <Description>k__BackingField;

	private string <UsersInfo>k__BackingField;

	private string <UserContactEmail>k__BackingField;

	private string <UserPhoneNumber>k__BackingField;

	private string <ReceiptText>k__BackingField;

	private string <TransactionNumber>k__BackingField;

	private string <UserBankName>k__BackingField;

	private string <VisaLast4Digits>k__BackingField;

	private string <OtherProblemAppScreen>k__BackingField;

	private string <OtherFreezingProblem>k__BackingField;

	private DateTime? <ProblemTime>k__BackingField;

	private Games? <Game>k__BackingField;

	private Platform <Platform>k__BackingField;

	private ConnectionSpeed? <ConnectionSpeed>k__BackingField;

	private PaymentMethod <PaymentMethod>k__BackingField;

	private Banks <Bank>k__BackingField;

	private BankPurchaseType <BankPurchaseType>k__BackingField;

	private ProblemAppScreen <ProblemAppScreen>k__BackingField;

	private FreezingType <FreezingType>k__BackingField;

	private string <ServerID>k__BackingField;

	private string <DeviceType>k__BackingField;

	private string <DeviceModel>k__BackingField;

	private string <DeviceName>k__BackingField;

	private string <OperatingSystem>k__BackingField;

	private string <AppVersion>k__BackingField;

	private string <ImageAttachment>k__BackingField;

	private long? <GameId>k__BackingField;

	public ProblemCategory Category
	{
		get
		{
			return <Category>k__BackingField;
		}
		set
		{
			<Category>k__BackingField = value;
		}
	}

	public SubscriptionAndCoinsIssues SubscriptionAndCoinsIssue
	{
		get
		{
			return <SubscriptionAndCoinsIssue>k__BackingField;
		}
		set
		{
			<SubscriptionAndCoinsIssue>k__BackingField = value;
		}
	}

	public GameProblems GameProblem
	{
		get
		{
			return <GameProblem>k__BackingField;
		}
		set
		{
			<GameProblem>k__BackingField = value;
		}
	}

	public MembershipProblems MembershipProblems
	{
		get
		{
			return <MembershipProblems>k__BackingField;
		}
		set
		{
			<MembershipProblems>k__BackingField = value;
		}
	}

	public PlayerReportType PlayerReportType
	{
		get
		{
			return <PlayerReportType>k__BackingField;
		}
		set
		{
			<PlayerReportType>k__BackingField = value;
		}
	}

	public SuggestionsAndInquiriesType SuggestionsAndInquiriesType
	{
		get
		{
			return <SuggestionsAndInquiriesType>k__BackingField;
		}
		set
		{
			<SuggestionsAndInquiriesType>k__BackingField = value;
		}
	}

	public WebOrdersProblems WebOrdersIssues
	{
		get
		{
			return <WebOrdersIssues>k__BackingField;
		}
		set
		{
			<WebOrdersIssues>k__BackingField = value;
		}
	}

	public string Description
	{
		get
		{
			return <Description>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string UsersInfo
	{
		get
		{
			return <UsersInfo>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string UserContactEmail
	{
		get
		{
			return <UserContactEmail>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string UserPhoneNumber
	{
		get
		{
			return <UserPhoneNumber>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 72;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string ReceiptText
	{
		get
		{
			return <ReceiptText>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 80;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string TransactionNumber
	{
		get
		{
			return <TransactionNumber>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 88;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string UserBankName
	{
		get
		{
			return <UserBankName>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 96;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string VisaLast4Digits
	{
		get
		{
			return <VisaLast4Digits>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 104;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string OtherProblemAppScreen
	{
		get
		{
			return <OtherProblemAppScreen>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 112;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string OtherFreezingProblem
	{
		get
		{
			return <OtherFreezingProblem>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 120;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public DateTime? ProblemTime
	{
		get
		{
			return <ProblemTime>k__BackingField;
		}
		set
		{
			<ProblemTime>k__BackingField = value;
		}
	}

	public Games? Game
	{
		get
		{
			return <Game>k__BackingField;
		}
		set
		{
			<Game>k__BackingField = value;
		}
	}

	public Platform Platform
	{
		get
		{
			return <Platform>k__BackingField;
		}
		set
		{
			<Platform>k__BackingField = value;
		}
	}

	public ConnectionSpeed? ConnectionSpeed
	{
		get
		{
			return <ConnectionSpeed>k__BackingField;
		}
		set
		{
			<ConnectionSpeed>k__BackingField = value;
		}
	}

	public PaymentMethod PaymentMethod
	{
		get
		{
			return <PaymentMethod>k__BackingField;
		}
		set
		{
			<PaymentMethod>k__BackingField = value;
		}
	}

	public Banks Bank
	{
		get
		{
			return <Bank>k__BackingField;
		}
		set
		{
			<Bank>k__BackingField = value;
		}
	}

	public BankPurchaseType BankPurchaseType
	{
		get
		{
			return <BankPurchaseType>k__BackingField;
		}
		set
		{
			<BankPurchaseType>k__BackingField = value;
		}
	}

	public ProblemAppScreen ProblemAppScreen
	{
		get
		{
			return <ProblemAppScreen>k__BackingField;
		}
		set
		{
			<ProblemAppScreen>k__BackingField = value;
		}
	}

	public FreezingType FreezingType
	{
		get
		{
			return <FreezingType>k__BackingField;
		}
		set
		{
			<FreezingType>k__BackingField = value;
		}
	}

	public string ServerID
	{
		get
		{
			return <ServerID>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 184;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string DeviceType
	{
		get
		{
			return <DeviceType>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 192;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string DeviceModel
	{
		get
		{
			return <DeviceModel>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 200;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string DeviceName
	{
		get
		{
			return <DeviceName>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 208;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string OperatingSystem
	{
		get
		{
			return <OperatingSystem>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 216;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string AppVersion
	{
		get
		{
			return <AppVersion>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 224;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string ImageAttachment
	{
		get
		{
			return <ImageAttachment>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 232;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public long? GameId
	{
		get
		{
			return <GameId>k__BackingField;
		}
		set
		{
			<GameId>k__BackingField = value;
		}
	}

	public unsafe static SupportTicketRequestModel MakeDefaultInstance(ProblemCategory category)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0046: Expected O, but got I
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0089: Expected O, but got I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00ed: Expected O, but got Ref
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_018e: Expected O, but got I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01f7: Expected O, but got I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02f6: Expected O, but got I4
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj4 = (nint)0 + (nint)2744;
			object obj5 = (nint)0 + (nint)2144;
			object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Games currentGame = Preferences.CurrentGame;
			System.Int32Enum? int32Enum = (System.Int32Enum)currentGame;
			DeviceType deviceType = UnityEngine.Device.SystemInfo.deviceType;
			object obj10 = default(object);
			string text = ((Enum)(&obj10)).ToString();
			object obj11 = obj2 + 192;
			obj11 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			string version = UnityEngine.Device.Application.version;
			object obj12 = obj2 + 224;
			obj12 = version;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			ConnectionSpeed connectionSpeed = SFS.ConnectionSpeed;
			System.Int32Enum? int32Enum2 = (System.Int32Enum)connectionSpeed;
			object obj13 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v24+E4]");
			bool flag2 = (nint)0 == 0;
			object obj14 = !flag2;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj15 = typeof(UsageHint) + 72;
			Platform platform = KUtil.GetPlatform();
			object obj16 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v28+E4]");
			bool flag3 = (nint)0 == 0;
			object obj17 = !flag3;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string serverID = Config.ServerID;
			object obj18 = obj2 + 184;
			obj18 = serverID;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			string deviceModel = UnityEngine.Device.SystemInfo.deviceModel;
			object obj19 = obj2 + 200;
			obj19 = deviceModel;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			string deviceName = UnityEngine.Device.SystemInfo.deviceName;
			object obj20 = obj2 + 208;
			obj20 = deviceName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			string operatingSystem = UnityEngine.Device.SystemInfo.operatingSystem;
			object obj21 = obj2 + 216;
			obj21 = operatingSystem;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj22 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v50+E4]");
			bool flag4 = (nint)0 == 0;
			object obj23 = !flag4;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string email = UserInfo.Email;
			object obj24 = obj2 + 64;
			obj24 = email;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (SupportTicketRequestModel)obj2;
		}
		return (SupportTicketRequestModel)(object)new NullReferenceException();
	}
}
