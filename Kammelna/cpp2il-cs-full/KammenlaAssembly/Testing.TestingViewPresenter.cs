using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Server.Models;
using Sfs2X.Entities;
using Testing.Achievements;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

namespace Testing;

public class TestingViewPresenter : MonoBehaviour
{
	private GameObject _achievementTestPanelPrefab;

	private Button _devTestButton;

	private readonly Dictionary<string, ITestPanel> _activePanels;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_013d: Expected O, but got I
		//IL_0167: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_0227: Expected O, but got I
		//IL_0235: Expected I, but got O
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B39]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v20+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v20+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isProduction = Config.IsProduction;
		bool flag2 = !isProduction;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			goto IL_011d;
		}
		goto IL_024d;
		IL_024d:
		object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
		GameObject obj7 = base.gameObject;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			UnityEngine.Object.Destroy(obj7);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.Destroy(obj7);
		return;
		IL_011d:
		object obj9 = typeof(Queue<string>) + 848;
		object obj10 = (nint)0 + (nint)2200;
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		if (SFSKammelnaUserExtensions.Can(localUser, UserPermission.RunServerCommands))
		{
			Button devTestButton = _devTestButton;
			if ((object)_devTestButton != null)
			{
				object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj14 = (nint)0 + (nint)1560;
				UnityAction unityAction = default(UnityAction);
				unityAction..ctor(this, (IntPtr)obj14);
				devTestButton.m_OnClick.AddListener(unityAction);
			}
			return;
		}
		goto IL_024d;
		IL_0074:
		if (!Config.IsProduction)
		{
			goto IL_011d;
		}
		goto IL_024d;
	}

	public void OnDestroy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button devTestButton = _devTestButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)1560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		devTestButton.m_OnClick.RemoveListener(unityAction);
	}

	public void OpenAchievementTestPanel()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object panelKey = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3296;
		ShowPanel((string)panelKey, _achievementTestPanelPrefab);
	}

	public unsafe void ClosePanel(string panelKey)
	{
		//IL_0011: Expected O, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_005d: Expected I, but got O
		//IL_006d: Expected O, but got I
		//IL_00fc: Expected O, but got I4
		//IL_00a8: Expected O, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0132: Expected O, but got Ref
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3112;
		if (!((Dictionary<object, object>)(object)_activePanels).TryGetValue((object)panelKey, out object value))
		{
			return;
		}
		object obj2 = typeof(System.IOAsyncCallback) + 1648;
		nint num = (nint)value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v9 (Il2CppClass<System.Object>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v9 (Il2CppClass<System.Object>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00e9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v9 (Il2CppClass<System.Object>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X10_v6-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00e9;
		}
		object obj5 = obj4 + 1;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		object obj8 = (object)(&value);
		goto IL_015c;
		IL_015c:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v207 @ X0_v7] (should have been resolved before IL gen)");
		return;
		IL_00e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj8 = 1;
		goto IL_015c;
	}

	private unsafe void ShowPanel(string panelKey, GameObject prefab)
	{
		//IL_0010: Expected O, but got I
		//IL_07a2: Expected O, but got I4
		//IL_07ab: Expected O, but got I4
		//IL_0022: Expected O, but got I
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0062: Expected O, but got I
		//IL_006e: Expected O, but got I
		//IL_008d: Expected O, but got Ref
		//IL_0201: Expected O, but got I4
		//IL_06ce: Expected O, but got I4
		//IL_023d: Expected I, but got O
		//IL_026e: Expected O, but got I4
		//IL_0276: Expected O, but got Ref
		//IL_00f6: Expected O, but got I
		//IL_03dd: Expected I, but got O
		//IL_00a5: Expected O, but got I4
		//IL_03f6: Expected I, but got O
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02d4: Expected O, but got I4
		//IL_0131: Expected O, but got I
		//IL_02fd: Expected O, but got I
		//IL_0813: Expected O, but got I
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Expected O, but got Unknown
		//IL_0429: Expected I, but got O
		//IL_0439: Expected O, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_04e7: Expected O, but got I
		//IL_0517: Expected O, but got I4
		//IL_0340: Expected O, but got I
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0653: Expected I, but got O
		//IL_0474: Expected O, but got I
		//IL_053a: Expected I, but got O
		//IL_054a: Expected O, but got I
		//IL_0871: Expected O, but got I
		//IL_038d: Expected O, but got I
		//IL_0395: Expected I, but got O
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected O, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected O, but got Unknown
		//IL_05aa: Expected O, but got I
		//IL_05df: Expected O, but got I
		//IL_05e4: Expected I, but got O
		//IL_05fc: Expected O, but got I
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		//IL_049d: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B3D]");
		object obj = 0;
		bool flag = _activePanels == null;
		object value = null;
		object obj2 = prefab;
		Dictionary<object, object>.Enumerator enumerator = (Dictionary<object, object>.Enumerator)0;
		Dictionary<object, object>.Enumerator enumerator2 = (Dictionary<object, object>.Enumerator)0;
		object obj3 = panelKey;
		string text = panelKey;
		GameObject gameObject = prefab;
		object obj5 = default(object);
		object obj6 = default(object);
		object obj8 = default(object);
		object obj9 = default(object);
		object obj13 = default(object);
		object obj14 = default(object);
		Dictionary<object, object>.Enumerator enumerator7 = default(Dictionary<object, object>.Enumerator);
		Dictionary<object, object>.Enumerator enumerator6;
		Dictionary<object, object>.Enumerator enumerator5 = default(Dictionary<object, object>.Enumerator);
		if (!flag)
		{
			object obj4 = (nint)0 + (nint)2760;
			obj5 = typeof(System.IOAsyncCallback) + 1648;
			obj6 = (nint)0 + (nint)3112;
			object obj7 = typeof(SqlSingle[]) + 2376;
			obj8 = (nint)0 + (nint)1552;
			obj9 = (nint)0 + (nint)2752;
			Dictionary<object, object>.Enumerator enumerator3 = ((Dictionary<object, object>)(object)_activePanels).GetEnumerator();
			obj2 = prefab;
			Dictionary<object, object>.Enumerator enumerator4 = default(Dictionary<object, object>.Enumerator);
			obj = (object)(&enumerator4);
			object obj10 = default(object);
			object obj17 = default(object);
			while (true)
			{
				obj3 = obj4;
				if (!enumerator4.MoveNext())
				{
					break;
				}
				if (obj10 != null)
				{
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v26+12E]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v26+12E]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v26+B0]");
						obj13 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X10_v4-8]");
							obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X10_v4-8]");
							object obj15 = 0 - obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X10_v4-8]");
							if (0 == (nint)obj5)
							{
								break;
							}
							obj13 += 16;
							obj12--;
							obj15 = obj12 - 1;
							bool flag2 = obj15 == null;
							if ((nint)obj12 != 1)
							{
								continue;
							}
							goto IL_0092;
						}
						obj12 = obj13 + 1;
						object obj16 = obj11 + obj12;
						obj17 = obj16 + 312;
						goto IL_00aa;
					}
					goto IL_0092;
				}
				goto IL_069d;
				IL_00aa:
				obj = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v413 @ X0_v50] (should have been resolved before IL gen)");
				continue;
				IL_0092:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj2 = 1;
				goto IL_00aa;
			}
			obj3 = obj9;
			enumerator4.Dispose();
			value = null;
			enumerator = enumerator5;
			enumerator6 = enumerator7;
			enumerator2 = enumerator5;
			enumerator5 = (Dictionary<object, object>.Enumerator)0;
			text = panelKey;
			gameObject = prefab;
			goto IL_0216;
		}
		goto IL_0853;
		IL_062a:
		Component devTestButton;
		GameObject gameObject2 = devTestButton.gameObject;
		bool flag3 = (object)gameObject2 == null;
		object obj18;
		obj14 = obj18;
		nint num = unchecked((nint)null);
		object obj19;
		obj13 = obj19;
		object obj20;
		obj2 = obj20;
		obj3 = null;
		object obj21;
		obj = obj21;
		text = (string)value;
		Action action = default(Action);
		gameObject = (GameObject)(object)action;
		if (!flag3)
		{
			gameObject2.SetActive(value: false);
			return;
		}
		goto IL_0853;
		IL_0216:
		if (_activePanels != null)
		{
			num = (nint)obj6;
			bool flag4 = ((Dictionary<object, object>)(object)_activePanels).TryGetValue((object)text, out value);
			bool flag5 = !flag4;
			object obj22 = !flag5;
			object obj23 = (object)(&value);
			object obj24 = text;
			if (obj22 != null)
			{
				goto IL_03c5;
			}
			Transform transform = base.transform;
			object obj25 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v36+E4]");
			bool flag6 = (nint)0 == 0;
			object obj27 = !flag6;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			obj = (nint)0 + (nint)544;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			object obj28 = default(object);
			bool flag7 = obj28 == null;
			obj3 = transform;
			if (!flag7)
			{
				obj = (nint)0 + (nint)1304;
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
				bool flag8 = _activePanels == null;
				object obj29 = default(object);
				value = obj29;
				obj2 = obj29;
				if (!flag8)
				{
					obj = (nint)0 + (nint)3120;
					num = (nint)obj;
					((Dictionary<object, object>)(object)_activePanels).set_Item((object)text, obj29);
					value = obj29;
					obj23 = obj29;
					obj24 = text;
					goto IL_03c5;
				}
			}
		}
		goto IL_0853;
		IL_03c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		action..ctor(this, (IntPtr)obj8);
		bool flag9 = value == null;
		num = unchecked((nint)null);
		obj2 = obj8;
		obj3 = this;
		text = (string)value;
		gameObject = (GameObject)(object)action;
		if (!flag9)
		{
			nint num2 = (nint)value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v6 (Il2CppClass<System.String>)+12E]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v6 (Il2CppClass<System.String>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_04c5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v6 (Il2CppClass<System.String>)+B0]");
			obj19 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X10_v3-8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X10_v3-8]");
				if (0 == (nint)obj5)
				{
					break;
				}
				obj13 = obj19 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v6 (Il2CppClass<System.String>)+12E]");
				obj30 = -1;
				bool flag10 = (nint)obj30 != 1;
				obj19 = obj13;
				if (flag10)
				{
					continue;
				}
				goto IL_04c5;
			}
			obj30 = obj19;
			object obj31 = num2 + obj19;
			object obj32 = obj31 + 312;
			obj21 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v30+8]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v548 @ X0_v30] (should have been resolved before IL gen)");
			devTestButton = _devTestButton;
			bool flag11 = (object)_devTestButton == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X10_v3-8]");
			obj18 = 0;
			num = unchecked((nint)null);
			obj13 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v30+8]");
			obj2 = 0;
			obj3 = action;
			obj = obj32;
			text = (string)value;
			gameObject = (GameObject)(object)action;
			if (!flag11)
			{
				goto IL_062a;
			}
		}
		goto IL_0853;
		IL_04c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj33 = default(object);
		obj21 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X0_v26+8]");
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v530 @ X0_v26] (should have been resolved before IL gen)");
		devTestButton = _devTestButton;
		bool flag12 = (object)_devTestButton == null;
		object obj34 = !flag12;
		obj18 = obj14;
		obj19 = obj13;
		if (obj34 != null)
		{
			goto IL_062a;
		}
		num = unchecked((nint)null);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X0_v26+8]");
		obj2 = 0;
		obj3 = action;
		obj = obj33;
		text = (string)value;
		gameObject = (GameObject)(object)action;
		goto IL_0853;
		IL_069d:
		NullReferenceException ex = new NullReferenceException();
		value = null;
		enumerator = enumerator5;
		enumerator6 = enumerator7;
		enumerator2 = enumerator5;
		enumerator5 = (Dictionary<object, object>.Enumerator)0;
		text = panelKey;
		gameObject = prefab;
		goto IL_0853;
		IL_0853:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag13 = (nint)obj3 != 1;
		NullReferenceException ex3 = ex2;
		if (!flag13)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj3 = obj9;
			enumerator.Dispose();
			object obj35 = default(object);
			bool flag14 = obj35 == null;
			enumerator5 = (Dictionary<object, object>.Enumerator)obj35;
			if (flag14)
			{
				goto IL_0216;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			enumerator5 = (Dictionary<object, object>.Enumerator)obj35;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B0DC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public TestingViewPresenter()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj2 = this + 48;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <ShowPanel>b__7_0()
	{
		GameObject gameObject = _devTestButton.gameObject;
		gameObject.SetActive(value: true);
	}
}
