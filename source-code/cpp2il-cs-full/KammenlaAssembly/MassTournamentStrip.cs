using System;
using System.Buffers.Text;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using ListView;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class MassTournamentStrip : ListViewItem<MassTournamentDataHolder, int>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action <>9__10_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3184;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <JoinTournamentRoom>b__10_0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			//IL_00de: Expected O, but got I4
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected O, but got Unknown
			object obj = 152985600;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D3E]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object message;
			if (obj3 != null)
			{
				obj4 = "Index = {0} position = {1}" + 1736;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				message = obj4;
				if (!flag)
				{
					goto IL_0094;
				}
			}
			else
			{
				_ = 1;
				obj4 = "Index = {0} position = {1}" + 1736;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				message = obj4;
				if (obj6 != null)
				{
					goto IL_0094;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.ShowError((string)message);
			return;
			IL_0094:
			PopupWindow.ShowError((string)obj4);
		}
	}

	private ThemeProvider themeProvider;

	private Image bigAd;

	private TextMeshProUGUI dateLabel;

	private DateTimeText dateText;

	private TextMeshProUGUI participantsCount;

	private ComponentReference<MassTournamentPrizesPanel> prizePanelReference;

	private MassEventModel _model;

	public override void Setup(MassTournamentDataHolder datum, bool firstTime)
	{
		//IL_000c: Expected O, but got I
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0048: Expected O, but got I
		//IL_0060: Expected I, but got O
		object obj = (nint)0 + (nint)1832;
		bool firstTime2 = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime2);
		MassTournamentInfo massTournamentInfo = SFSKammelnaRoomExtensions.GetMassTournamentInfo(datum.<Room>k__BackingField);
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2616;
		object obj3 = (nint)0 + (nint)3632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		MassTournamentManager.GetMassEvent(massTournamentInfo.<Id>k__BackingField, action);
	}

	private void Populate(MassEventModel model)
	{
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02c5: Expected O, but got I
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_00c5: Expected O, but got I4
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0180: Expected O, but got I4
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01ff: Expected O, but got I4
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		object obj = this + 176;
		obj = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X21_v3-70]");
		object obj2 = 0;
		object varName = "placementId" + 296;
		object defaultValue = "Material with texture name \"" + 3392;
		TextMeshProUGUI tm = participantsCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+18]");
		VariableBinderExtensions.Bind(tm, (Room)0, (string)varName, (string)defaultValue);
		IThemeColorProfile newProfile = model.GenerateTheme();
		object obj3 = typeof(DataRelation) + 712;
		themeProvider.UpdateTheme(newProfile);
		UIExtensions.LoadMassTournamentImage(bigAd, model, ImageCacher.MassTournamentImageType.BigAd);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		if (model.<StartingDate>k__BackingField > now)
		{
			object text = "LAK" + 3904;
			TextMeshProExtensions.Localize(dateLabel, (string)text);
			dateText.SetDate(model.<StartingDate>k__BackingField);
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v20+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now2 = DateTime.Now;
			TimeSpan timeSpan = model.<StartingDate>k__BackingField - now2;
			object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v26+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan timeSpan2 = default(TimeSpan);
			double totalSeconds = timeSpan2.TotalSeconds;
			object methodName = "Read object reference Id '{0}' for {1}." + 1096;
			float time = (float)totalSeconds + 1f;
			Invoke((string)methodName, time);
		}
		else
		{
			object text2 = "LAK" + 3896;
			TextMeshProExtensions.Localize(dateLabel, (string)text2);
			dateText.SetDate(model.<FinishDate>k__BackingField);
		}
	}

	private void Refresh()
	{
		if (_model != null)
		{
			Populate(_model);
		}
	}

	public void JoinTournamentRoom()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00ed: Expected O, but got I
		//IL_00fd: Expected O, but got I
		//IL_011f: Expected O, but got I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_006a: Expected O, but got I
		//IL_007a: Expected O, but got I
		//IL_009c: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_023c: Expected O, but got I
		//IL_024d: Expected I, but got O
		//IL_026b: Expected O, but got I
		//IL_0187: Expected O, but got I
		MassEventModel model = _model;
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3184;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v11+E4]");
		object obj3;
		object obj4;
		Action failureCallback;
		object obj6;
		if ((nint)0 != 0)
		{
			obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v11+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8+8]");
			failureCallback = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8+8]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				obj6 = obj3;
				goto IL_0135;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v11+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8+8]");
			failureCallback = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8+8]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj3 = obj6;
			if (obj7 == null)
			{
				goto IL_0135;
			}
		}
		goto IL_018c;
		IL_0135:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v14+B8]");
			obj4 = 0;
		}
		object obj10 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)1040;
		Action action = default(Action);
		action..ctor(obj4, (IntPtr)obj11);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v13+B8]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		failureCallback = action;
		obj3 = obj6;
		goto IL_018c;
		IL_018c:
		MassTournamentManager.JoinRoom(model.<Id>k__BackingField, null, failureCallback);
		ITrackEvent trackEvent = TrackerLibrary.TournamentMassEntered(_model);
		object obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	public void ShowPrizes()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0077: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2648;
		object obj2 = (nint)0 + (nint)3624;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj4 = (nint)0 + (nint)2128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	public MassTournamentStrip()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}

	private void <ShowPrizes>b__11_0(MassTournamentPrizesPanel popup)
	{
		popup.Populate(_model);
	}
}
