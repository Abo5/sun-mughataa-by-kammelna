using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Threading;
using Cpp2ILInjected;
using Server.Models;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class MassMainPanel : MonoBehaviour
{
	private MassTournamentEventChannel eventChannel;

	private Button helpBtn;

	private ThemeProvider[] themeProviders;

	private MassTournamentServerConnector _connector;

	private string MassTournamentVideoTutorialURL
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00da: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60ED]");
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
			RemoteConfigModel current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_011d;
			}
			goto IL_0156;
			IL_0156:
			return (string)(object)new NullReferenceException();
			IL_011d:
			TournamentsSection <Tournaments>k__BackingField = current.<Tournaments>k__BackingField;
			if (current.<Tournaments>k__BackingField != null)
			{
				return <Tournaments>k__BackingField.<MassTutorialUrl>k__BackingField;
			}
			goto IL_0156;
			IL_0074:
			current = RemoteConfig.Current;
			bool flag2 = current == null;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				goto IL_011d;
			}
			goto IL_0156;
		}
	}

	private MassEventModel TournamentData
	{
		get
		{
			if ((object)_connector != null)
			{
				MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)this).GetTournamentLiveData();
				if (tournamentLiveData != null)
				{
					return MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
				}
			}
			return (MassEventModel)(object)new NullReferenceException();
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0135: Expected I, but got O
		//IL_015f: Expected O, but got I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_0098: Expected I, but got O
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I
		//IL_0101: Expected I, but got O
		//IL_0112: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3160;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action;
		Button button = helpBtn;
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj7 = (nint)0 + (nint)3152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj7);
		button.m_OnClick.AddListener(unityAction);
		SetUpHelpBtn();
		MassTournamentEventChannel massTournamentEventChannel = eventChannel;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2664;
		object obj9 = (nint)0 + (nint)3144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj9);
		object obj10 = (nint)0 + (nint)2416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39978C8");
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3160;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action;
	}

	private void SetUpHelpBtn()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_003e: Expected O, but got I
		//IL_00ee: Expected O, but got I4
		//IL_00ab: Expected O, but got I4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0164: Expected O, but got I4
		GameObject gameObject = helpBtn.gameObject;
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60ED]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v14+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		goto IL_0114;
		IL_0114:
		TournamentsSection <Tournaments>k__BackingField = current.<Tournaments>k__BackingField;
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = StringsExtensions.IsNullOrEmpty(<Tournaments>k__BackingField.<MassTutorialUrl>k__BackingField);
		bool active = (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
		gameObject.SetActive(active);
		return;
		IL_0088:
		current = RemoteConfig.Current;
		bool flag4 = current == null;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0114;
	}

	private void Initialize(MassTournamentServerConnector connector)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 56;
		obj = connector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UpdateTheme();
	}

	private void UpdateTheme()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0078: Expected O, but got I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I
		MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)this).GetTournamentLiveData();
		MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
		IThemeColorProfile newProfile = cachedMassEvent.GenerateTheme();
		ThemeProvider[] array = themeProviders;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X22_v4+v26 @ X21_v5*8]");
				((ThemeProvider)0).UpdateTheme(newProfile);
			}
			while ((nint)obj2 < array.Length);
		}
	}

	private void OpenHelpURL()
	{
		//IL_0016: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0115: Expected O, but got I
		//IL_012f: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01eb: Expected O, but got I4
		//IL_0220: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60EF]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60ED]");
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
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60ED]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00af;
		}
		goto IL_0183;
		IL_019b:
		RemoteConfigModel current;
		TournamentsSection <Tournaments>k__BackingField = current.<Tournaments>k__BackingField;
		object obj9 = typeof(RegisteredWaitHandle) + 1552;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RoutingManager.Route(RoutingCommand.OpenCustomURL, <Tournaments>k__BackingField.<MassTutorialUrl>k__BackingField, (Games?)(object)0);
		return;
		IL_00af:
		current = RemoteConfig.Current;
		bool flag5 = current == null;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_019b;
		IL_0183:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		current = RemoteConfig.Current;
		goto IL_019b;
		IL_0082:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00af;
		}
		goto IL_0183;
	}
}
