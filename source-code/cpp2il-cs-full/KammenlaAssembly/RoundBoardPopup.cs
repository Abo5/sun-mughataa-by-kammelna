using System;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RoundBoardPopup : PopupUI
{
	protected GameEventsChannel _gameEventsChannel;

	protected static readonly Color SignatureGreen1;

	protected static readonly Color SignatureGreen2;

	protected static readonly Color SignatureRed1;

	protected static readonly Color SignatureRed2;

	private const string UsString = "Us";

	private const string ThemString = "Them";

	private const string Team1String = "team 1";

	private const string Team2String = "team 2";

	public static RoundBoardPopup Instance;

	public TextMeshProUGUI Bidder;

	public GameObject CatchResultSection;

	public TextMeshProUGUI CatcherLabel;

	public TextMeshProUGUI CatchResultLabel;

	public TextMeshProUGUI Catcher;

	public TextMeshProUGUI CatchResult;

	public GameObject BetResultSection;

	public TextMeshProUGUI BetResultLabel;

	public TextMeshProUGUI BetResult;

	public TextMeshProUGUI ResultLabel;

	public Image ResultBackground;

	public Sprite GreenResultBackground;

	public Sprite RedResultBackground;

	public TextMeshProUGUI Team1Name;

	public TextMeshProUGUI Team2Name;

	public TextMeshProUGUI Team2Eatings;

	public TextMeshProUGUI Team2Points;

	public TextMeshProUGUI Team2Score;

	public TextMeshProUGUI Team1Eatings;

	public TextMeshProUGUI Team1Points;

	public TextMeshProUGUI Team1Score;

	protected CardGame game;

	protected bool closing;

	public override void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00eb: Expected O, but got I4
		//IL_0105: Expected O, but got I
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_012f: Expected O, but got I
		//IL_0168: Expected O, but got I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_007c: Expected I, but got O
		object obj = typeof(RegisteredWaitHandle) + 1520;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		base.Awake();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		object obj5 = (nint)0 + (nint)24;
		object obj6 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+B8]");
		object obj7 = (nint)0 + (nint)64;
		obj7 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		CardGame cardGame = default(CardGame);
		game = cardGame;
		object obj10 = this + 296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v5 (Il2CppClass<RoundBoardPopup>)+1C0]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		game.OnRoundEnd += action;
	}

	protected void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0038: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3 (Il2CppClass<RoundBoardPopup>)+1C0]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		game.OnRoundEnd -= action;
	}

	protected virtual void ShowRoundBoard()
	{
	}

	public virtual void OnOKClick()
	{
		Close();
		if ((object)_gameEventsChannel != null)
		{
			_gameEventsChannel.TriggerCloseEndRoundPopup();
		}
	}

	public virtual void Close()
	{
		//IL_001c: Expected O, but got I4
		bool flag = !closing;
		object obj = !flag;
		if (obj == null)
		{
			ShrinkToParent();
			closing = true;
		}
	}

	public virtual void ShowPopup()
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_012f: Expected O, but got I
		//IL_013d: Expected I, but got O
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		Transform transform = base.transform;
		transform.SetAsLastSibling();
		PopFromCenter(0.9f);
		closing = false;
		if (!game.IsSpectator || game.IsReplay)
		{
			object text = "Unsupported map type" + 416;
			object text2 = "The operation is not allowed on non-connected sockets." + 2808;
			TextMeshProExtensions.Localize(Team1Name, (string)text);
			TextMeshProExtensions.Localize(Team2Name, (string)text2);
			return;
		}
		object text3 = "startPosition" + 2448;
		TextMeshProExtensions.Localize(Team1Name, (string)text3);
		object text4 = "startPosition" + 2456;
		TextMeshProExtensions.Localize(Team2Name, (string)text4);
		object obj = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = (nint)0 + (nint)3128;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v18+E4]");
		if ((nint)0 != 0)
		{
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(3f, action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Coroutine coroutine2 = CoroutineDummy.WaitForSeconds(3f, action);
	}

	static RoundBoardPopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0041: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 1520;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252C60]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252C70]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252C80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252C90]");
		_ = 0;
	}

	private void <ShowPopup>b__38_0()
	{
		//IL_002d: Expected I, but got O
		//IL_003d: Expected O, but got I
		//IL_004d: Expected O, but got I
		if (game.IsSpectator)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v1 (Il2CppClass<RoundBoardPopup>)+1D8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v1 (Il2CppClass<RoundBoardPopup>)+1E0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v34 @ X2_v1 (should have been resolved before IL gen)");
		}
	}
}
