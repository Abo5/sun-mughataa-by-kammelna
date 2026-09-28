using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class MassOverviewWidget : MassWidget
{
	private sealed class <CountdownUntil>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public DateTime targetTime;

		public MassOverviewWidget <>4__this;

		private YieldInstruction <waitForSeconds>5__2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <CountdownUntil>d__10(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_02dc: Expected I4, but got I8
			//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Expected O, but got Unknown
			//IL_0324: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			//IL_0342: Expected O, but got I
			//IL_003e: Expected I4, but got I8
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			//IL_0367: Expected I4, but got O
			//IL_01a7: Expected O, but got I4
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Expected O, but got Unknown
			//IL_00d8: Expected O, but got I4
			//IL_0244: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Expected O, but got Unknown
			MassOverviewWidget massOverviewWidget = <>4__this;
			object obj4;
			DateTime dateTime;
			double num;
			object obj7;
			DateTime dateTime2;
			double num2 = default(double);
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_02c7;
				}
				<>1__state = -1;
				object obj2 = typeof(UsageHint) + 1640;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				WaitForSeconds waitForSeconds = default(WaitForSeconds);
				waitForSeconds..ctor(30f);
				object obj3 = this + 48;
				obj3 = waitForSeconds;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj4 = typeof(DataRelation) + 712;
				dateTime = targetTime;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v24+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				WaitForSeconds waitForSeconds2 = waitForSeconds;
				num = 30.0;
				obj7 = obj4;
				num2 = 30.0;
				dateTime2 = targetTime;
				if (obj6 == null)
				{
					goto IL_011a;
				}
			}
			else
			{
				<>1__state = -1;
				obj7 = typeof(DataRelation) + 712;
				dateTime2 = targetTime;
				object obj5 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v24+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					obj4 = obj7;
					IntPtr intPtr = default(IntPtr);
					WaitForSeconds waitForSeconds2 = (WaitForSeconds)(nint)intPtr;
					num = num2;
					dateTime = targetTime;
					goto IL_011a;
				}
			}
			goto IL_0141;
			IL_011a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj4;
			num2 = num;
			dateTime2 = dateTime;
			goto IL_0141;
			IL_02c7:
			return false;
			IL_0141:
			DateTime now = DateTime.Now;
			if (dateTime2 > now)
			{
				object obj9 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v13+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now2 = DateTime.Now;
				TimeSpan time = targetTime - now2;
				if ((object)<>4__this != null && massOverviewWidget.timer != null)
				{
					massOverviewWidget.timer.SetTime(time, targetTime);
					object obj11 = this + 24;
					obj11 = <waitForSeconds>5__2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = 1;
					return true;
				}
			}
			else if ((object)<>4__this != null && (object)massOverviewWidget.timerParent != null)
			{
				massOverviewWidget.timerParent.SetActive(value: false);
				goto IL_02c7;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
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
			object obj2 = (nint)0 + (nint)776;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private ComponentReference<MassTournamentPrizesPanel> prizePanelReference;

	private Image sponsorLogo;

	private Image smallAd;

	private TextMeshProUGUI currentStageText;

	private GameObject timerParent;

	private TimerComponentsUi timer;

	protected override void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0129: Expected O, but got I
		//IL_015d: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0090: Expected I, but got O
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00fc: Expected I, but got O
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		GameObject go = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)3256;
		object varName = "alignContent" + 2944;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go, currentRoom, (string)varName, action);
		GameObject go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object varName2 = "___# Content push apply failed [{0}]: {1}" + 3960;
		SessionModel sessionModel2 = default(SessionModel);
		Room currentRoom2 = sessionModel2.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go2, currentRoom2, (string)varName2, action2);
		Reload();
	}

	private void Reload()
	{
		MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)(object)this).GetTournamentLiveData();
		MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
		UIExtensions.LoadMassTournamentImage(sponsorLogo, cachedMassEvent, ImageCacher.MassTournamentImageType.BigLogo);
		MassTournamentInfo tournamentLiveData2 = ((MassTournamentServerConnector)(object)sponsorLogo).GetTournamentLiveData();
		MassEventModel cachedMassEvent2 = MassTournamentManager.GetCachedMassEvent(tournamentLiveData2.<Id>k__BackingField);
		UIExtensions.LoadMassTournamentImage(smallAd, cachedMassEvent2, ImageCacher.MassTournamentImageType.SmallAd);
		UpdateCurrentStageText();
		UpdateTimer();
	}

	private void UpdateCurrentStageText()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0069: Expected O, but got I4
		//IL_00ed: Expected O, but got I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_016c: Expected O, but got I4
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		CancelInvoke();
		MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)(object)this).GetTournamentLiveData();
		MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		if (cachedMassEvent.<StartingDate>k__BackingField > now)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now2 = DateTime.Now;
			TimeSpan timeSpan = cachedMassEvent.<StartingDate>k__BackingField - now2;
			object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v23+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan timeSpan2 = default(TimeSpan);
			double totalSeconds = timeSpan2.TotalSeconds;
			object methodName = "Read object reference Id '{0}' for {1}." + 1480;
			Invoke((string)methodName, (float)totalSeconds);
			object text = "LAK" + 3912;
			TextMeshProExtensions.Localize(currentStageText, (string)text);
		}
		else
		{
			GameObject gameObject = currentStageText.gameObject;
			gameObject.SetActive(value: false);
			timerParent.SetActive(value: false);
		}
	}

	private void UpdateTimer()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_009a: Expected O, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		DateTime targetTime = GetTargetTime();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy instance = CoroutineDummy.Instance;
		object obj4 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = default(object);
		obj5..ctor();
		_ = 0;
		object obj6 = obj5 + 40;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = instance.StartCoroutine((IEnumerator)obj5);
	}

	private IEnumerator CountdownUntil(DateTime targetTime)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 40;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private DateTime GetTargetTime()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0099: Expected O, but got I4
		//IL_00ee: Expected O, but got I4
		if ((object)_connector != null)
		{
			MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)(object)this).GetTournamentLiveData();
			if (tournamentLiveData != null)
			{
				MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
				if (cachedMassEvent != null)
				{
					object obj = typeof(DataRelation) + 712;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v7+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					DateTime now = DateTime.Now;
					bool flag2 = cachedMassEvent.<StartingDate>k__BackingField > now;
					bool flag3 = !flag2;
					DateTime result = (DateTime)0;
					if (!flag3)
					{
						result = cachedMassEvent.<StartingDate>k__BackingField;
					}
					return result;
				}
			}
		}
		return (DateTime)new NullReferenceException();
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
		object obj2 = (nint)0 + (nint)3248;
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

	private void <ShowPrizes>b__12_0(MassTournamentPrizesPanel popup)
	{
		MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)(object)this).GetTournamentLiveData();
		MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
		popup.Populate(cachedMassEvent);
	}
}
