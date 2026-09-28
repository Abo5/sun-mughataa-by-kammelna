using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class JackarooCustomRulesPopup : MonoBehaviour, IInitializable
{
	private sealed class <>c__DisplayClass31_0
	{
		public Action confirmAction;

		public JackarooCustomRulesPopup <>4__this;

		public Action dismissAction;

		internal void <DoDeleteEntry>b__0()
		{
			Action action = confirmAction;
			if (confirmAction != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v12.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			<>4__this.EnableSwipes();
			<>4__this.RefreshContentFitters();
		}

		internal void <DoDeleteEntry>b__1()
		{
			Action action = dismissAction;
			if (dismissAction != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v12.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			<>4__this.EnableSwipes();
		}
	}

	private sealed class <RefreshLayoutRecursive>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public RectTransform root;

		private VerticalLayoutGroup <verticalLayoutGroup>5__2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <RefreshLayoutRecursive>d__40(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_008f: Expected I4, but got I8
			//IL_0192: Expected I4, but got O
			//IL_00ba: Expected O, but got I
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_0036: Expected I4, but got I8
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected O, but got Unknown
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected O, but got Unknown
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					<>1__state = -1;
					if ((object)<verticalLayoutGroup>5__2 == null)
					{
						goto IL_0184;
					}
					<verticalLayoutGroup>5__2.childControlHeight = false;
				}
				return <>1__state == 0;
			}
			<>1__state = -1;
			if ((object)root != null)
			{
				object obj = (nint)0 + (nint)216;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
				object obj2 = this + 40;
				object obj3 = default(object);
				obj2 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (obj2 != null)
				{
					((HorizontalOrVerticalLayoutGroup)obj2).childControlHeight = true;
					object obj4 = typeof(UsageHint) + 1648;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					WaitForSecondsRealtime waitForSecondsRealtime = default(WaitForSecondsRealtime);
					waitForSecondsRealtime..ctor(1f);
					object obj5 = this + 24;
					obj5 = waitForSecondsRealtime;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = 1;
					return <>1__state == 0;
				}
			}
			goto IL_0184;
			IL_0184:
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
			object obj2 = (nint)0 + (nint)1856;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private const string ruleWillBeDeleted = "Rule will be deleted";

	private PopupUI _customRulesPopup;

	private RectTransform _mainPanelRectTransform;

	private RectTransform _rectT;

	private Button _addNewRulesButton;

	private Button _closeButton;

	private Button _blockerButton;

	private Transform _saveEntryParent;

	private JackarooCustomRuleSaveEntry _saveEntryPrefab;

	private JackarooCustomRuleSaveEntry _defaultRuleSaveEntry;

	private readonly List<JackarooCustomRuleSaveEntry> _saveEntries;

	private SlideAnimationHelper _slideAnimationHelper;

	private List<JackarooCustomRuleUI> _jackarooCustomRulesUis;

	private InputFieldTMProUGUI _inputField;

	private Button _saveButton;

	private Button _backButton;

	private Button _deleteButton;

	private JackarooCustomRuleSaveEntry _currentSaveEntry;

	private bool _isEdit;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0845: Expected I, but got O
		//IL_0853: Expected I, but got O
		//IL_006f: Expected I, but got O
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I
		//IL_00b7: Expected I, but got O
		//IL_00c5: Expected I, but got O
		//IL_0611: Expected I, but got O
		//IL_06f9: Expected O, but got I
		//IL_0713: Expected O, but got I4
		//IL_0671: Expected I, but got O
		//IL_064c: Expected O, but got I
		//IL_0779: Expected I, but got O
		//IL_072f: Expected I, but got O
		//IL_0751: Expected O, but got I4
		//IL_0177: Expected O, but got I
		//IL_0189: Expected I, but got O
		//IL_0197: Expected I, but got O
		//IL_06d8: Expected O, but got I
		//IL_0249: Expected O, but got I
		//IL_025b: Expected I, but got O
		//IL_0269: Expected I, but got O
		//IL_031b: Expected O, but got I
		//IL_032d: Expected I, but got O
		//IL_033b: Expected I, but got O
		//IL_03ed: Expected O, but got I
		//IL_03ff: Expected I, but got O
		//IL_040d: Expected I, but got O
		//IL_04bf: Expected O, but got I
		//IL_04d1: Expected I, but got O
		//IL_04df: Expected I, but got O
		//IL_0588: Expected O, but got I
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected O, but got Unknown
		//IL_05a8: Expected O, but got I
		//IL_0791: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2448;
		object obj2 = (nint)0 + (nint)592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)obj2;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		bool flag = (object)_defaultRuleSaveEntry == null;
		Action<JackarooCustomRuleSaveEntry> action2 = null;
		object obj3 = this;
		Action<object> action3 = action;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag)
		{
			_defaultRuleSaveEntry.Setup(null, action, null, null, null);
			Button addNewRulesButton = _addNewRulesButton;
			bool flag2 = (object)_addNewRulesButton == null;
			Action<JackarooCustomRuleSaveEntry, Action, Action> action4 = null;
			Action<JackarooCustomRuleSaveEntry> action5 = null;
			action2 = null;
			obj3 = null;
			num = (nint)action;
			action3 = action;
			if (!flag2)
			{
				obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
				object obj4 = (nint)0 + (nint)568;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				num = (nint)obj4;
				UnityAction unityAction = default(UnityAction);
				unityAction..ctor(this, (IntPtr)obj4);
				bool flag3 = addNewRulesButton.m_OnClick == null;
				action4 = null;
				action5 = null;
				action2 = null;
				obj3 = this;
				action3 = (Action<object>)(object)unityAction;
				if (!flag3)
				{
					addNewRulesButton.m_OnClick.AddListener(unityAction);
					Button closeButton = _closeButton;
					bool flag4 = (object)_closeButton == null;
					action4 = null;
					action5 = null;
					action2 = null;
					obj3 = unityAction;
					num = 0;
					action3 = (Action<object>)(object)unityAction;
					if (!flag4)
					{
						object obj5 = (nint)0 + (nint)632;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						num = (nint)obj5;
						UnityAction unityAction2 = default(UnityAction);
						unityAction2..ctor(this, (IntPtr)obj5);
						bool flag5 = closeButton.m_OnClick == null;
						action4 = null;
						action5 = null;
						action2 = null;
						obj3 = this;
						action3 = (Action<object>)(object)unityAction2;
						if (!flag5)
						{
							closeButton.m_OnClick.AddListener(unityAction2);
							Button blockerButton = _blockerButton;
							bool flag6 = (object)_blockerButton == null;
							action4 = null;
							action5 = null;
							action2 = null;
							obj3 = unityAction2;
							num = 0;
							action3 = (Action<object>)(object)unityAction2;
							if (!flag6)
							{
								object obj6 = (nint)0 + (nint)640;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								num = (nint)obj6;
								UnityAction unityAction3 = default(UnityAction);
								unityAction3..ctor(this, (IntPtr)obj6);
								bool flag7 = blockerButton.m_OnClick == null;
								action4 = null;
								action5 = null;
								action2 = null;
								obj3 = this;
								action3 = (Action<object>)(object)unityAction3;
								if (!flag7)
								{
									blockerButton.m_OnClick.AddListener(unityAction3);
									Button saveButton = _saveButton;
									bool flag8 = (object)_saveButton == null;
									action4 = null;
									action5 = null;
									action2 = null;
									obj3 = unityAction3;
									num = 0;
									action3 = (Action<object>)(object)unityAction3;
									if (!flag8)
									{
										object obj7 = (nint)0 + (nint)648;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										num = (nint)obj7;
										UnityAction unityAction4 = default(UnityAction);
										unityAction4..ctor(this, (IntPtr)obj7);
										bool flag9 = saveButton.m_OnClick == null;
										action4 = null;
										action5 = null;
										action2 = null;
										obj3 = this;
										action3 = (Action<object>)(object)unityAction4;
										if (!flag9)
										{
											saveButton.m_OnClick.AddListener(unityAction4);
											Button backButton = _backButton;
											bool flag10 = (object)_backButton == null;
											action4 = null;
											action5 = null;
											action2 = null;
											obj3 = unityAction4;
											num = 0;
											action3 = (Action<object>)(object)unityAction4;
											if (!flag10)
											{
												object obj8 = (nint)0 + (nint)600;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												num = (nint)obj8;
												UnityAction unityAction5 = default(UnityAction);
												unityAction5..ctor(this, (IntPtr)obj8);
												bool flag11 = backButton.m_OnClick == null;
												action4 = null;
												action5 = null;
												action2 = null;
												obj3 = this;
												action3 = (Action<object>)(object)unityAction5;
												if (!flag11)
												{
													backButton.m_OnClick.AddListener(unityAction5);
													Button deleteButton = _deleteButton;
													bool flag12 = (object)_deleteButton == null;
													action4 = null;
													action5 = null;
													action2 = null;
													obj3 = unityAction5;
													num = 0;
													action3 = (Action<object>)(object)unityAction5;
													if (!flag12)
													{
														object obj9 = (nint)0 + (nint)576;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
														num = (nint)obj9;
														UnityAction unityAction6 = default(UnityAction);
														unityAction6..ctor(this, (IntPtr)obj9);
														bool flag13 = deleteButton.m_OnClick == null;
														action4 = null;
														action5 = null;
														action2 = null;
														obj3 = this;
														action3 = (Action<object>)(object)unityAction6;
														if (!flag13)
														{
															deleteButton.m_OnClick.AddListener(unityAction6);
															bool flag14 = _jackarooCustomRulesUis == null;
															action4 = null;
															action5 = null;
															action2 = null;
															obj3 = unityAction6;
															num = 0;
															action3 = (Action<object>)(object)unityAction6;
															if (!flag14)
															{
																object obj10 = (nint)0 + (nint)2728;
																action3 = (Action<object>)(typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184);
																obj2 = (nint)0 + (nint)2720;
																List<object>.Enumerator enumerator = ((List<object>)(object)_jackarooCustomRulesUis).GetEnumerator();
																num = 0;
																obj3 = obj10;
																if (!enumerator2.MoveNext())
																{
																	obj3 = obj2;
																	enumerator2.Dispose();
																	action4 = null;
																	action5 = null;
																	action2 = null;
																	goto IL_0609;
																}
																NullReferenceException ex = new NullReferenceException();
																object obj11 = 0;
																action4 = null;
																action5 = null;
																action2 = null;
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
		NullReferenceException ex2 = new NullReferenceException();
		bool flag15 = (nint)obj3 != 1;
		NullReferenceException ex3 = ex2;
		if (!flag15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj3 = obj2;
			enumerator2.Dispose();
			object obj12 = default(object);
			if (obj12 == null)
			{
				goto IL_0609;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj11 = obj12;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223A1C0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_069e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v29 (Il2CppClass<System.Action`1<System.Object>>)+B8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v12 (Il2CppStaticFields<System.Action`1<System.Object>>)+20]");
		LoadEntries((IReadOnlyList<JackarooCustomRulesSave>)0, _defaultRuleSaveEntry, _saveEntryPrefab, _saveEntryParent, _saveEntries);
		return;
		IL_0767:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		nint num3 = (nint)action3;
		goto IL_069e;
		IL_0669:
		num3 = (nint)action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v29 (Il2CppClass<System.Action`1<System.Object>>)+E4]");
		bool flag16 = (nint)0 == 0;
		nint num4 = num3;
		if (!flag16)
		{
			goto IL_069e;
		}
		goto IL_0767;
		IL_0609:
		nint num5 = (nint)action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v19 (Il2CppClass<System.Action`1<System.Object>>)+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45DC]");
			object obj13 = (nint)0 & (nint)1;
			if (obj13 != null)
			{
				goto IL_0669;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45DC]");
			object obj14 = (nint)0 & (nint)1;
			bool flag17 = obj14 == null;
			object obj15 = !flag17;
			if (obj15 != null)
			{
				goto IL_0669;
			}
		}
		_ = 1;
		num4 = (nint)action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v20 (Il2CppClass<System.Action`1<System.Object>>)+E4]");
		bool flag18 = (nint)0 == 0;
		object obj16 = !flag18;
		num3 = num4;
		if (obj16 != null)
		{
			goto IL_069e;
		}
		goto IL_0767;
	}

	private void OnAddNewRulesClicked()
	{
		//IL_0011: Expected O, but got I
		ResetRules(_jackarooCustomRulesUis);
		object text = (nint)0 + (nint)2000;
		_inputField.Text = (string)text;
		_inputField.Interactable = true;
		_slideAnimationHelper.SlideIn();
	}

	private void OnSaveRulesButtonClicked()
	{
		//IL_10ac: Expected O, but got I4
		//IL_10b4: Expected O, but got I
		//IL_10bd: Expected O, but got I4
		//IL_002d: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		//IL_1019: Expected O, but got I
		//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4f: Expected O, but got Unknown
		//IL_0b79: Expected O, but got I4
		//IL_0ba0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba5: Expected O, but got Unknown
		//IL_0bb8: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_008b: Expected O, but got I
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be0: Expected O, but got Unknown
		//IL_0c0a: Expected O, but got I4
		//IL_00c6: Expected O, but got I4
		//IL_0828: Expected O, but got I
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected O, but got Unknown
		//IL_0876: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_00fa: Expected O, but got I
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_011a: Expected O, but got I
		//IL_0c36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3b: Expected O, but got Unknown
		//IL_0c65: Expected O, but got I4
		//IL_0c90: Expected O, but got I4
		//IL_0c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca4: Expected O, but got Unknown
		//IL_08a3: Expected O, but got I
		//IL_08c3: Expected O, but got I4
		//IL_07d5: Expected O, but got I
		//IL_0800: Expected O, but got I4
		//IL_0cbf: Expected O, but got I
		//IL_0cd0: Expected I, but got O
		//IL_0ceb: Expected O, but got I
		//IL_0cfc: Expected I, but got O
		//IL_08f1: Expected O, but got I
		//IL_0911: Expected O, but got I4
		//IL_0d17: Expected O, but got I
		//IL_0d28: Expected I, but got O
		//IL_0d37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3c: Expected O, but got Unknown
		//IL_0fba: Expected O, but got I4
		//IL_01eb: Expected O, but got I
		//IL_0d57: Expected O, but got I
		//IL_0d68: Expected I, but got O
		//IL_0daa: Expected O, but got I
		//IL_0daa: Expected O, but got I
		//IL_0daa: Expected O, but got I
		//IL_093b: Expected O, but got I
		//IL_0950: Expected I8, but got I
		//IL_095f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0964: Expected O, but got Unknown
		//IL_098e: Expected O, but got I4
		//IL_03db: Expected O, but got I
		//IL_09d8: Expected O, but got I4
		//IL_0218: Expected O, but got I
		//IL_0a0a: Expected O, but got I
		//IL_0a3c: Expected O, but got I4
		//IL_0442: Expected O, but got I
		//IL_0a64: Expected O, but got I
		//IL_0a81: Expected O, but got I
		//IL_0a81: Expected O, but got I
		//IL_0a8e: Expected O, but got I4
		//IL_0a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Expected O, but got Unknown
		//IL_0ab8: Expected O, but got I
		//IL_027f: Expected O, but got I
		//IL_0de5: Expected O, but got I4
		//IL_0ef4: Expected O, but got I4
		//IL_0f04: Expected O, but got I
		//IL_0f14: Expected O, but got I
		//IL_0b19: Expected O, but got I4
		//IL_0eaf: Expected O, but got I4
		//IL_0ebf: Expected O, but got I
		//IL_0ecf: Expected O, but got I
		//IL_0e63: Expected O, but got I4
		//IL_0e19: Expected O, but got I4
		//IL_0519: Expected O, but got I4
		//IL_013e: Expected O, but got I
		//IL_014e: Expected O, but got I
		//IL_015e: Expected O, but got I
		//IL_0181: Expected O, but got I4
		//IL_0349: Expected O, but got I4
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected O, but got Unknown
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected O, but got Unknown
		//IL_0594: Expected O, but got I4
		//IL_05a4: Expected O, but got I
		//IL_05b9: Expected O, but got I
		//IL_05c9: Expected O, but got I
		//IL_05d9: Expected O, but got I
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_03be: Expected O, but got I
		//IL_0f9a: Expected O, but got I4
		//IL_0635: Expected O, but got I
		//IL_0f63: Expected O, but got I4
		//IL_0f73: Expected O, but got I
		//IL_0f83: Expected O, but got I
		//IL_06e1: Expected O, but got I4
		//IL_0781: Expected O, but got I
		//IL_0791: Expected O, but got I
		//IL_07a1: Expected O, but got I
		//IL_07c4: Expected O, but got I4
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected O, but got Unknown
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected O, but got Unknown
		//IL_075c: Expected O, but got I4
		//IL_076c: Expected O, but got I
		bool flag = (object)_inputField == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		IntPtr intPtr = default(IntPtr);
		string text = (string)(nint)intPtr;
		List<object> list = (List<object>)152989696;
		JackarooCustomRulesPopup jackarooCustomRulesPopup = default(JackarooCustomRulesPopup);
		object obj36;
		object obj8;
		long? num7;
		if (!flag)
		{
			string text2 = _inputField.Text;
			bool flag2 = text2 == null;
			enumerator = (List<object>.Enumerator)0;
			text = null;
			list = (List<object>)152989696;
			if (!flag2)
			{
				if (text2._stringLength == 0)
				{
					object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v64+E4]");
					bool flag3 = (nint)0 == 0;
					object obj3 = !flag3;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object message = "Picking audio files is not supported on iOS" + 552;
					Toast.Show((string)message, (Vector2)0, 0f);
					RectTransform rect = UIExtensions.rectTransform(_inputField);
					object obj4 = typeof(SqlSingle[]) + 3912;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v50+E4]");
					bool flag4 = (nint)0 == 0;
					object obj6 = !flag4;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					AnimationExtensions.ErrorFeedback(rect);
					return;
				}
				object obj7 = typeof(List<AdaptivePerformanceScaler>) + 1912;
				obj8 = (nint)0 + (nint)2000;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				text = (string)obj8;
				List<object> list2 = default(List<object>);
				list2..ctor();
				bool flag5 = _jackarooCustomRulesUis == null;
				enumerator = (List<object>.Enumerator)0;
				jackarooCustomRulesPopup = this;
				list = list2;
				if (!flag5)
				{
					object obj9 = (nint)0 + (nint)2728;
					object obj10 = (nint)0 + (nint)3536;
					object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 176;
					object obj12 = (nint)0 + (nint)2008;
					List<object>.Enumerator enumerator2 = ((List<object>)(object)_jackarooCustomRulesUis).GetEnumerator();
					List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
					object obj13 = default(object);
					JackarooCustomRuleSaveData jackarooCustomRuleSaveData = default(JackarooCustomRuleSaveData);
					JackarooCustomRuleSaveData jackarooCustomRuleSaveData2 = default(JackarooCustomRuleSaveData);
					JackarooCustomRuleSaveData jackarooCustomRuleSaveData3 = default(JackarooCustomRuleSaveData);
					List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
					List<object>.Enumerator enumerator5;
					while (true)
					{
						text = (string)obj9;
						if (!enumerator3.MoveNext())
						{
							break;
						}
						if (obj13 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ stack_-88+2C]");
							object obj14 = (nint)0 & (nint)1;
							if (obj14 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ stack_-88+58]");
								obj8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ stack_-88+58]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ stack_-88+60]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ stack_-88+60]");
										nint num = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X19_v16+34]");
										(object, int) tuple = ((List<(object, int)>)num).get_Item(0);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X19_v16+34]");
										nint num2 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X19_v16+34]");
										jackarooCustomRuleSaveData..ctor((int)num2, 0);
										object obj25;
										List<JackarooCustomRuleSaveData> list3;
										if (list2 != null)
										{
											object obj15 = obj12;
											int version = list2._version + 1;
											list2._version = version;
											object[] items = list2._items;
											if (list2._items != null)
											{
												bool flag6 = list2._size < items.Length;
												object obj16 = !flag6;
												if (obj16 == null)
												{
													int size = list2._size + 1;
													list2._size = size;
													object obj17 = list2._items + list2._size;
													object obj18 = obj17 + 32;
													obj18 = jackarooCustomRuleSaveData;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X19_v16+34]");
													list3 = (List<JackarooCustomRuleSaveData>)0;
													text = (string)(object)jackarooCustomRuleSaveData;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v70+20]");
													object obj19 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v76+C0]");
													object obj20 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v77+70]");
													list3 = (List<JackarooCustomRuleSaveData>)0;
													list2.AddWithResize((object)jackarooCustomRuleSaveData);
													text = (string)(object)jackarooCustomRuleSaveData;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ stack_-88+68]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ stack_-88+68]");
													nint num3 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X19_v16+148]");
													(object, int) tuple2 = ((List<(object, int)>)num3).get_Item(0);
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X19_v16+148]");
													nint num4 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X19_v16+148]");
													jackarooCustomRuleSaveData2..ctor((int)num4, 0);
													object obj21 = obj12;
													int version2 = list2._version + 1;
													list2._version = version2;
													object[] items2 = list2._items;
													if (list2._items != null)
													{
														bool flag7 = list2._size < items2.Length;
														object obj22 = !flag7;
														if (obj22 == null)
														{
															int size2 = list2._size + 1;
															list2._size = size2;
															object obj23 = list2._items + list2._size;
															object obj24 = obj23 + 32;
															obj24 = jackarooCustomRuleSaveData2;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															items = list2._items;
															obj25 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X19_v16+148]");
															list3 = (List<JackarooCustomRuleSaveData>)0;
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X8_v72+20]");
															object obj26 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v73+C0]");
															object obj27 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v74+70]");
															list3 = (List<JackarooCustomRuleSaveData>)0;
															list2.AddWithResize((object)jackarooCustomRuleSaveData2);
															items = list2._items;
															obj25 = 0;
														}
														continue;
													}
													NullReferenceException ex = new NullReferenceException();
													obj25 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X19_v16+148]");
													list3 = (List<JackarooCustomRuleSaveData>)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X19_v16+148]");
													text = (string)0;
												}
												else
												{
													NullReferenceException ex2 = new NullReferenceException();
													obj25 = 0;
												}
												goto IL_0f9f;
											}
										}
										NullReferenceException ex3 = new NullReferenceException();
										obj25 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X19_v16+34]");
										list3 = (List<JackarooCustomRuleSaveData>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X19_v16+34]");
										text = (string)0;
									}
									else
									{
										NullReferenceException ex4 = new NullReferenceException();
									}
								}
								else
								{
									NullReferenceException ex5 = new NullReferenceException();
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ stack_-88+50]");
								object obj28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ stack_-88+50]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ stack_-88+60]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ stack_-88+60]");
										nint num5 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v63+34]");
										(object, int) tuple3 = ((List<(object, int)>)num5).get_Item(0);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v63+34]");
										nint num6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v63+34]");
										jackarooCustomRuleSaveData3..ctor((int)num6, 0);
										object obj25;
										List<JackarooCustomRuleSaveData> list3;
										if (list2 != null)
										{
											object obj29 = obj12;
											int version3 = list2._version + 1;
											list2._version = version3;
											object[] items3 = list2._items;
											bool flag8 = list2._items == null;
											object[] items = list2._items;
											if (!flag8)
											{
												bool flag9 = list2._size < items3.Length;
												object obj30 = !flag9;
												if (obj30 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v65+20]");
													object obj31 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X8_v67+C0]");
													object obj32 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v68+70]");
													list3 = (List<JackarooCustomRuleSaveData>)0;
													list2.AddWithResize((object)jackarooCustomRuleSaveData3);
													items = list2._items;
													obj25 = 0;
												}
												else
												{
													int size3 = list2._size + 1;
													list2._size = size3;
													object obj33 = list2._items + list2._size;
													object obj34 = obj33 + 32;
													obj34 = jackarooCustomRuleSaveData3;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													items = list2._items;
													obj25 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v63+34]");
													list3 = (List<JackarooCustomRuleSaveData>)0;
												}
												continue;
											}
										}
										NullReferenceException ex6 = new NullReferenceException();
										obj25 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v63+34]");
										list3 = (List<JackarooCustomRuleSaveData>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v63+34]");
										text = (string)0;
									}
									else
									{
										NullReferenceException ex7 = new NullReferenceException();
									}
								}
								else
								{
									NullReferenceException ex8 = new NullReferenceException();
								}
							}
						}
						else
						{
							NullReferenceException ex9 = new NullReferenceException();
						}
						goto IL_0f9f;
						IL_0f9f:
						enumerator = enumerator4;
						enumerator5 = enumerator4;
						num7 = (long?)(object)0;
						jackarooCustomRulesPopup = this;
						list = list2;
						goto IL_10cb;
					}
					object obj35 = (nint)0 + (nint)2720;
					text = (string)obj35;
					enumerator3.Dispose();
					enumerator = enumerator4;
					enumerator5 = enumerator4;
					num7 = (long?)(object)0;
					obj36 = this;
					jackarooCustomRulesPopup = this;
					list = list2;
					goto IL_10f5;
				}
			}
		}
		goto IL_10cb;
		IL_0e39:
		object obj37 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X0_v33+E4]");
		bool flag10 = (nint)0 == 0;
		object obj38 = !flag10;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		JackarooCustomRulesSave jackarooCustomRulesSave = default(JackarooCustomRulesSave);
		int jackarooPreferredCustomRulesIndex;
		JackarooCustomRules.SetCurrentJackarooCustomRuleSave(jackarooCustomRulesSave, jackarooPreferredCustomRulesIndex);
		goto IL_0e93;
		IL_10cb:
		NullReferenceException ex10 = new NullReferenceException();
		bool flag11 = (nint)text != 1;
		OutOfMemoryException ex11 = (OutOfMemoryException)(object)ex10;
		if (!flag11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj39 = (nint)0 + (nint)2720;
			text = (string)obj39;
			enumerator.Dispose();
			object obj40 = default(object);
			bool flag12 = obj40 == null;
			num7 = (long?)obj40;
			obj36 = jackarooCustomRulesPopup;
			if (flag12)
			{
				goto IL_10f5;
			}
			ex11 = new OutOfMemoryException();
			num7 = (long?)obj40;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223A1C0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0e93:
		((JackarooCustomRulesPopup)obj36).CloseRulesPanel();
		return;
		IL_10f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X28_v1 (System.Object)+80]");
		int num11;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X28_v1 (System.Object)+80]");
			string text3 = ((InputFieldTMProUGUI)0).Text;
			object obj41 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			jackarooCustomRulesSave..ctor(text3, (List<JackarooCustomRuleSaveData>)(object)list);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X28_v1 (System.Object)+A8]");
			object obj42 = (nint)0 & (nint)1;
			if (obj42 == null)
			{
				object obj43 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
				object obj44 = obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v10+E4]");
				bool flag13 = (nint)0 == 0;
				object obj45 = !flag13;
				if (obj45 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				JackarooCustomRules.Save(jackarooCustomRulesSave, (long?)(object)0);
				object obj46 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2448;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj47 = (nint)0 + (nint)592;
				Action<object> action = default(Action<object>);
				action..ctor(obj36, (IntPtr)obj47);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj48 = (nint)0 + (nint)624;
				Action<object> action2 = default(Action<object>);
				action2..ctor(obj36, (IntPtr)obj48);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj49 = (nint)0 + (nint)608;
				Action<object> action3 = default(Action<object>);
				action3..ctor(obj36, (IntPtr)obj49);
				object obj50 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 936;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj51 = (nint)0 + (nint)616;
				Action<object, object, object> action4 = default(Action<object, object, object>);
				action4..ctor(obj36, (IntPtr)obj51);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X28_v1 (System.Object)+58]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X28_v1 (System.Object)+50]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X28_v1 (System.Object)+68]");
				AddSaveEntry((JackarooCustomRuleSaveEntry)num8, (Transform)num9, (List<JackarooCustomRuleSaveEntry>)0, jackarooCustomRulesSave, action, action2, action3, action4, isLoad: false);
				goto IL_0e93;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X28_v1 (System.Object)+A0]");
			object obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X28_v1 (System.Object)+A0]");
			bool flag14 = (nint)0 == 0;
			object obj25 = 0;
			List<JackarooCustomRuleSaveData> list3 = (List<JackarooCustomRuleSaveData>)(object)list;
			text = text3;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v21+68]");
				object obj53 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v21+68]");
				bool flag15 = (nint)0 == 0;
				obj25 = 0;
				list3 = (List<JackarooCustomRuleSaveData>)(object)list;
				text = text3;
				if (!flag15)
				{
					object obj54 = (nint)0 + (nint)3184;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v22+10]");
					num7 = 0L;
					obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
					object obj55 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X0_v24+E4]");
					bool flag16 = (nint)0 == 0;
					object obj56 = !flag16;
					if (obj56 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					JackarooCustomRules.Save(jackarooCustomRulesSave, num7);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X28_v1 (System.Object)+A0]");
					bool flag17 = (nint)0 == 0;
					obj25 = 0;
					list3 = null;
					text = (string)num7;
					if (!flag17)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X28_v1 (System.Object)+A0]");
						object obj57 = (nint)0 + (nint)104;
						obj57 = jackarooCustomRulesSave;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X28_v1 (System.Object)+68]");
						bool flag18 = (nint)0 == 0;
						obj25 = 0;
						list3 = null;
						text = (string)(object)jackarooCustomRulesSave;
						if (!flag18)
						{
							object obj58 = (nint)0 + (nint)2056;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X28_v1 (System.Object)+68]");
							nint num10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X28_v1 (System.Object)+A0]");
							num11 = ((List<object>)num10).IndexOf(0);
							object obj59 = 152989696;
							object obj60 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7776]");
							object obj61 = (nint)0 & (nint)1;
							if (obj61 != null)
							{
								object obj62 = obj60;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X0_v37+E4]");
								if ((nint)0 != 0)
								{
									goto IL_0b02;
								}
							}
							else
							{
								_ = 1;
								object obj62 = obj60;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X0_v37+E4]");
								bool flag19 = (nint)0 == 0;
								object obj63 = !flag19;
								if (obj63 != null)
								{
									goto IL_0b02;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							jackarooPreferredCustomRulesIndex = Preferences.JackarooPreferredCustomRulesIndex;
							object obj64 = num11 + 1;
							if (jackarooPreferredCustomRulesIndex == (nint)obj64)
							{
								goto IL_0e39;
							}
							goto IL_0e93;
						}
					}
				}
			}
		}
		goto IL_10cb;
		IL_0b02:
		jackarooPreferredCustomRulesIndex = Preferences.JackarooPreferredCustomRulesIndex;
		object obj65 = num11 + 1;
		if (jackarooPreferredCustomRulesIndex == (nint)obj65)
		{
			goto IL_0e39;
		}
		goto IL_0e93;
	}

	private void OpenRulesPanel()
	{
		_slideAnimationHelper.SlideIn();
	}

	private void CloseRulesPanel()
	{
		//IL_02b2: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_001f: Expected O, but got I
		//IL_02c8: Expected I, but got O
		//IL_0137: Expected I, but got O
		//IL_015a: Expected O, but got I4
		//IL_0230: Expected I, but got O
		//IL_01e2: Expected O, but got I4
		//IL_0066: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_01b4: Expected I, but got O
		//IL_00ef: Expected O, but got I
		bool flag = _jackarooCustomRulesUis == null;
		object obj = 152989696;
		nint num = default(nint);
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)2728;
			obj = (nint)0 + (nint)2720;
			List<object>.Enumerator enumerator = ((List<object>)(object)_jackarooCustomRulesUis).GetEnumerator();
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			object obj3 = default(object);
			List<object>.Enumerator enumerator5;
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			while (true)
			{
				num = (nint)obj2;
				if (!enumerator2.MoveNext())
				{
					break;
				}
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ stack_-68+2C]");
					object obj4 = (nint)0 & (nint)1;
					if (obj4 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ stack_-68+58]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ stack_-68+58]");
							((TwinSlidedKDropMenu)0).ResetClicks();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ stack_-68+58]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ stack_-68+58]");
								((BaseDropMenu<object>)0).Hide();
								continue;
							}
							NullReferenceException ex = new NullReferenceException();
							num = unchecked((nint)null);
						}
						else
						{
							NullReferenceException ex2 = new NullReferenceException();
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ stack_-68+50]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ stack_-68+50]");
							((BaseDropMenu<object>)0).Hide();
							continue;
						}
						NullReferenceException ex3 = new NullReferenceException();
					}
				}
				else
				{
					NullReferenceException ex4 = new NullReferenceException();
				}
				enumerator3 = enumerator4;
				enumerator5 = enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
				goto IL_02f2;
			}
			num = (nint)obj;
			enumerator2.Dispose();
			enumerator3 = enumerator4;
			enumerator5 = enumerator4;
			enumerator4 = (List<object>.Enumerator)0;
			goto IL_015f;
		}
		goto IL_02f2;
		IL_02f2:
		NullReferenceException ex5 = new NullReferenceException();
		bool flag2 = num != 1;
		OutOfMemoryException ex6 = (OutOfMemoryException)(object)ex5;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj;
			enumerator3.Dispose();
			object obj5 = default(object);
			bool flag3 = obj5 == null;
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj5;
			if (flag3)
			{
				goto IL_015f;
			}
			ex6 = new OutOfMemoryException();
			enumerator4 = (List<object>.Enumerator)obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223A1C0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_015f:
		if ((object)_slideAnimationHelper != null)
		{
			_slideAnimationHelper.SlideOut();
			return;
		}
		goto IL_02f2;
	}

	private static void ResetRules(List<JackarooCustomRuleUI> jackarooCustomRulesUis)
	{
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_011a: Expected I, but got O
		//IL_00b0: Expected I, but got O
		//IL_0062: Expected O, but got I4
		object obj2 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (jackarooCustomRulesUis != null)
		{
			object obj = (nint)0 + (nint)2728;
			obj2 = (nint)0 + (nint)2720;
			List<object>.Enumerator enumerator = ((List<object>)(object)jackarooCustomRulesUis).GetEnumerator();
			num = (nint)obj;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			NullReferenceException ex = new NullReferenceException();
			object obj3 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj2;
			enumerator2.Dispose();
			object obj4 = default(object);
			if (obj4 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj3 = obj4;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223A1C0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private static void LoadRules(List<JackarooCustomRuleUI> jackarooCustomRulesUis, List<JackarooCustomRuleSaveData> rules)
	{
		//IL_0018: Expected O, but got I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected I4, but got Unknown
		//IL_01dd: Expected O, but got I
		//IL_0202: Expected O, but got I
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0337: Expected O, but got I
		//IL_026b: Expected O, but got I
		//IL_03ac: Expected O, but got I
		//IL_03ce: Expected O, but got I4
		//IL_012b: Expected O, but got I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected I4, but got Unknown
		//IL_02db: Expected O, but got I
		//IL_0314: Expected O, but got I4
		//IL_00de: Expected O, but got I
		//IL_00ef: Expected O, but got I
		if (jackarooCustomRulesUis != null)
		{
			object obj = jackarooCustomRulesUis._size - 1;
			bool flag = (nint)obj < 0;
			int num = jackarooCustomRulesUis._size ^ 1;
			int num2 = jackarooCustomRulesUis._size ^ obj;
			int num3 = num & num2;
			bool flag2 = num3 < 0;
			if (rules == null)
			{
				if (flag != flag2)
				{
					return;
				}
				object obj2 = ((List<object>)(object)jackarooCustomRulesUis).get_Item(0);
				throw new NullReferenceException();
			}
			if (jackarooCustomRulesUis._size < 1)
			{
				return;
			}
			int num4 = 0;
			int num5 = 0;
			while (true)
			{
				object obj3 = ((List<object>)(object)jackarooCustomRulesUis).get_Item(num4);
				if (obj3 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v11 (System.Object)+2C]");
				object obj4 = -1;
				flag = (nint)obj4 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v11 (System.Object)+2C]");
				object obj5 = (nint)0 ^ (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v11 (System.Object)+2C]");
				object obj6 = 0 ^ obj4;
				object obj7 = obj5 & obj6;
				flag2 = (nint)obj7 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v11 (System.Object)+2C]");
				TwinSlidedKDropMenu twinSlidedKDropMenu;
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v11 (System.Object)+58]");
					twinSlidedKDropMenu = (TwinSlidedKDropMenu)0;
					object obj8 = ((List<object>)(object)rules).get_Item(num5);
					if (obj8 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v11 (System.Object)+58]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v11 (System.Object)+58]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v17 (System.Object)+10]");
					((TwinSlidedKDropMenu)num6).SetSelectedIndex(0);
					num5++;
					object obj9 = ((List<object>)(object)rules).get_Item(num5);
					bool flag3 = obj9 == null;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v11 (System.Object)+58]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v21 (System.Object)+10]");
					((TwinSlidedKDropMenu)num7).SetSelectedIndex2(0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v11 (System.Object)+58]");
					((TwinSlidedKDropMenu)0).ResetClicks();
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v11 (System.Object)+50]");
					object obj11 = 0;
					object obj12 = ((List<object>)(object)rules).get_Item(num5);
					if (obj12 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v11 (System.Object)+50]");
					if ((nint)0 == 0)
					{
						break;
					}
					object obj13 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v154 @ X8_v11+1E8] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v11 (System.Object)+50]");
					twinSlidedKDropMenu = (TwinSlidedKDropMenu)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v11 (System.Object)+50]");
					bool flag4 = (nint)0 == 0;
					object obj14 = !flag4;
					if (obj14 == null)
					{
						break;
					}
				}
				((BaseDropMenu<object>)(object)twinSlidedKDropMenu).Hide();
				num5++;
				num4++;
				object obj15 = num4 - jackarooCustomRulesUis._size;
				flag = (nint)obj15 < 0;
				int num8 = num4 ^ jackarooCustomRulesUis._size;
				int num9 = num4 ^ obj15;
				int num10 = num8 & num9;
				flag2 = num10 < 0;
				if (num4 < jackarooCustomRulesUis._size)
				{
					continue;
				}
				return;
			}
		}
		throw new NullReferenceException();
	}

	private void LoadEntries(IReadOnlyList<JackarooCustomRulesSave> jackarooCustomRulesSaves)
	{
		LoadEntries(jackarooCustomRulesSaves, _defaultRuleSaveEntry, _saveEntryPrefab, _saveEntryParent, _saveEntries);
	}

	private unsafe void LoadEntries(IReadOnlyList<JackarooCustomRulesSave> jackarooCustomRulesSaves, JackarooCustomRuleSaveEntry defaultRuleSaveEntry, JackarooCustomRuleSaveEntry saveEntryPrefab, Transform saveEntryParent, List<JackarooCustomRuleSaveEntry> saveEntries)
	{
		//IL_0a7e: Expected I4, but got O
		//IL_0a87: Expected O, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0031: Expected I, but got O
		//IL_0041: Expected O, but got I
		//IL_0aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af2: Expected O, but got Unknown
		//IL_0b02: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_0ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab5: Expected O, but got Unknown
		//IL_09a4: Expected I4, but got O
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_09ca: Expected O, but got I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_0181: Expected I, but got O
		//IL_0191: Expected O, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_0b72: Expected I4, but got O
		//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Expected O, but got Unknown
		//IL_01cc: Expected O, but got I
		//IL_04e2: Expected O, but got I4
		//IL_04fb: Expected O, but got I4
		//IL_0b3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b41: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_0c6c: Expected O, but got I4
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01fd: Expected O, but got I
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_051c: Expected I, but got O
		//IL_052c: Expected O, but got I
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_02d6: Expected I, but got O
		//IL_02e6: Expected O, but got I
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected O, but got Unknown
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Expected O, but got Unknown
		//IL_077d: Expected O, but got I
		//IL_0797: Expected O, but got I4
		//IL_0ca6: Expected I4, but got O
		//IL_0567: Expected O, but got I
		//IL_0c18: Expected O, but got I
		//IL_0c26: Expected I, but got O
		//IL_0321: Expected O, but got I
		//IL_06a4: Expected I, but got O
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Expected O, but got Unknown
		//IL_0667: Expected O, but got I
		//IL_03fe: Expected O, but got I
		//IL_040c: Expected I, but got O
		//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcf: Expected O, but got Unknown
		//IL_07cb: Expected I, but got O
		//IL_07f7: Expected O, but got I4
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected O, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected O, but got Unknown
		//IL_0427: Expected O, but got I
		//IL_0435: Expected I, but got O
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected O, but got Unknown
		//IL_071e: Expected O, but got I4
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected O, but got Unknown
		//IL_0590: Expected O, but got I
		//IL_0464: Expected O, but got I
		//IL_0472: Expected I, but got O
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0352: Expected O, but got I
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_0d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1a: Expected I4, but got Unknown
		//IL_0d27: Expected O, but got I4
		//IL_0d30: Expected O, but got I4
		//IL_0d80: Expected I4, but got O
		//IL_08f7: Expected O, but got I4
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Expected O, but got Unknown
		//IL_0ce0: Expected O, but got I
		//IL_0cf9: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E777F]");
		bool flag = false;
		bool flag2 = jackarooCustomRulesSaves == null;
		JackarooCustomRuleSaveEntry jackarooCustomRuleSaveEntry = defaultRuleSaveEntry;
		int num = (int)jackarooCustomRulesSaves;
		List<JackarooCustomRuleSaveEntry> list = (List<JackarooCustomRuleSaveEntry>)152989696;
		List<JackarooCustomRuleSaveEntry> list3 = default(List<JackarooCustomRuleSaveEntry>);
		List<JackarooCustomRuleSaveEntry> list2 = list3;
		bool flag4 = default(bool);
		if (!flag2)
		{
			object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3408;
			nint num2 = (nint)jackarooCustomRulesSaves;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v41 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v41 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0101;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v41 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			bool flag3 = flag4;
			object obj5;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X10_v29-8]");
				object obj4 = 0 - obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X10_v29-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj5 = obj3 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v41 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+12E]");
				obj2 = -1;
				obj4 = obj2 - 1;
				bool flag5 = obj4 == null;
				flag4 = (nint)obj2 != 1;
				flag3 = flag4;
				obj3 = obj5;
				if (flag4)
				{
					continue;
				}
				goto IL_0101;
			}
			obj2 = obj3;
			object obj6 = num2 + obj3;
			object obj7 = obj6 + 312;
			jackarooCustomRuleSaveEntry = defaultRuleSaveEntry;
			flag4 = flag3;
			obj5 = obj3;
			list = list3;
			goto IL_0ade;
		}
		goto IL_0cc5;
		IL_0ade:
		list2 = (List<JackarooCustomRuleSaveEntry>)(typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2448);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v54+8]");
		Transform transform = (Transform)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v359 @ X0_v54] (should have been resolved before IL gen)");
		Transform transform3 = default(Transform);
		Transform transform2 = transform3;
		JackarooCustomRuleSaveEntry jackarooCustomRuleSaveEntry3 = default(JackarooCustomRuleSaveEntry);
		JackarooCustomRuleSaveEntry jackarooCustomRuleSaveEntry2 = jackarooCustomRuleSaveEntry3;
		IReadOnlyList<JackarooCustomRulesSave> readOnlyList = default(IReadOnlyList<JackarooCustomRulesSave>);
		flag = (byte)(&readOnlyList) != 0;
		IReadOnlyList<JackarooCustomRulesSave> readOnlyList2 = default(IReadOnlyList<JackarooCustomRulesSave>);
		object obj11 = default(object);
		Action<object> action = default(Action<object>);
		Action<object> action2 = default(Action<object>);
		Action<object> action3 = default(Action<object>);
		Action<object, object, object> action4 = default(Action<object, object, object>);
		JackarooCustomRulesSave jackarooCustomRulesSave = default(JackarooCustomRulesSave);
		object obj18 = default(object);
		object obj28 = default(object);
		object obj30 = default(object);
		while (true)
		{
			if (readOnlyList2 != null)
			{
				object obj8 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				nint num3 = (nint)readOnlyList2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v49 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v49 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0251;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v49 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+B0]");
				object obj9 = (nint)0 + (nint)8;
				bool flag6 = flag4;
				object obj5;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X10_v24-8]");
					object obj4 = 0 - obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X10_v24-8]");
					if (0 == (nint)obj8)
					{
						break;
					}
					obj5 = obj9 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v49 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+12E]");
					obj2 = -1;
					obj4 = obj2 - 1;
					bool flag5 = obj4 == null;
					flag4 = (nint)obj2 != 1;
					flag6 = flag4;
					obj9 = obj5;
					if (flag4)
					{
						continue;
					}
					goto IL_0251;
				}
				obj2 = obj9;
				object obj10 = num3 + obj9;
				obj11 = obj10 + 312;
				flag4 = flag6;
				obj5 = obj9;
				goto IL_0b6a;
			}
			NullReferenceException ex = new NullReferenceException();
			num = (int)transform;
			goto IL_09b7;
			IL_03a6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			jackarooCustomRuleSaveEntry = null;
			goto IL_0bf8;
			IL_0bf8:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v815 @ X0_v64] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)592;
			action..ctor((object)this, (IntPtr)obj12);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)624;
			action2..ctor((object)this, (IntPtr)obj13);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)608;
			action3..ctor((object)this, (IntPtr)obj14);
			object obj15 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 936;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)616;
			action4..ctor((object)this, (IntPtr)obj16);
			AddSaveEntry(jackarooCustomRuleSaveEntry3, transform3, list, jackarooCustomRulesSave, action, action2, action3, action4);
			transform2 = (Transform)(object)action;
			jackarooCustomRuleSaveEntry2 = (JackarooCustomRuleSaveEntry)(object)jackarooCustomRulesSave;
			jackarooCustomRuleSaveEntry = (JackarooCustomRuleSaveEntry)(object)list;
			transform = transform3;
			flag = true;
			continue;
			IL_0d52:
			TextMeshProUGUI textMesh;
			string text;
			TextMeshProExtensions.Localize(textMesh, text);
			JackarooCustomRuleSaveEntry jackarooCustomRuleSaveEntry4;
			bool flag7 = (object)jackarooCustomRuleSaveEntry4._buttonImage == null;
			jackarooCustomRuleSaveEntry = null;
			num = (int)text;
			List<JackarooCustomRuleSaveEntry> list4;
			list2 = list4;
			if (flag7)
			{
				break;
			}
			jackarooCustomRuleSaveEntry4._buttonImage.sprite = jackarooCustomRuleSaveEntry4._activeSprite;
			return;
			IL_0825:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			int jackarooPreferredCustomRulesIndex = Preferences.JackarooPreferredCustomRulesIndex;
			bool flag8 = jackarooPreferredCustomRulesIndex == 0;
			bool flag9;
			flag = flag9;
			JackarooCustomRuleSaveEntry jackarooCustomRuleSaveEntry5 = jackarooCustomRuleSaveEntry4;
			list2 = list4;
			if (!flag8)
			{
				goto IL_0872;
			}
			goto IL_0949;
			IL_0251:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			jackarooCustomRuleSaveEntry = null;
			goto IL_0b6a;
			IL_0b6a:
			flag = (byte)(int)obj11 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X0_v60+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v551 @ X0_v60] (should have been resolved before IL gen)");
			object obj17 = obj18 & 1;
			if (obj17 != null)
			{
				if (readOnlyList2 != null)
				{
					object obj19 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 816;
					nint num4 = (nint)readOnlyList2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v54 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+12E]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v54 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+12E]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v54 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+B0]");
						object obj20 = (nint)0 + (nint)8;
						bool flag10 = flag4;
						object obj5;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X10_v19-8]");
							object obj4 = 0 - obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X10_v19-8]");
							if (0 == (nint)obj19)
							{
								break;
							}
							obj5 = obj20 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v54 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+12E]");
							obj2 = -1;
							obj4 = obj2 - 1;
							bool flag5 = obj4 == null;
							flag4 = (nint)obj2 != 1;
							flag10 = flag4;
							obj20 = obj5;
							if (flag4)
							{
								continue;
							}
							goto IL_03a6;
						}
						obj2 = obj20;
						object obj21 = num4 + obj20;
						object obj22 = obj21 + 312;
						flag4 = flag10;
						obj5 = obj20;
						goto IL_0bf8;
					}
					goto IL_03a6;
				}
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_09b7;
			}
			readOnlyList = readOnlyList2;
			object obj23 = 0;
			transform3 = transform2;
			jackarooCustomRuleSaveEntry3 = jackarooCustomRuleSaveEntry2;
			object obj24 = 0;
			while (true)
			{
				if (readOnlyList == null)
				{
					goto IL_0c52;
				}
				object obj25 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num5 = (nint)readOnlyList;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v33 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v33 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_05b8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v33 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+B0]");
				object obj26 = (nint)0 + (nint)8;
				object obj5;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X10_v7-8]");
					if (0 == (nint)obj25)
					{
						break;
					}
					obj5 = obj26 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v33 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+12E]");
					obj2 = -1;
					bool flag11 = (nint)obj2 != 1;
					obj26 = obj5;
					if (flag11)
					{
						continue;
					}
					goto IL_05b8;
				}
				obj2 = obj26;
				object obj27 = num5 + obj26;
				obj28 = obj27 + 312;
				obj5 = obj26;
				goto IL_0c9e;
				IL_0c52:
				bool flag12 = obj24 == null;
				object obj29 = !flag12;
				if (obj29 != null)
				{
					OutOfMemoryException ex3 = new OutOfMemoryException();
					if (num == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
						obj24 = obj30;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
						obj23 = obj30;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
					return;
				}
				break;
				IL_05b8:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				jackarooCustomRuleSaveEntry = null;
				goto IL_0c9e;
				IL_0c9e:
				flag = (byte)(int)obj28 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X0_v36+8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v740 @ X0_v36] (should have been resolved before IL gen)");
				goto IL_0c52;
			}
			object obj31 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
			object obj32 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				list2 = (List<JackarooCustomRuleSaveEntry>)(typeof(System.Buffers.Text.ParserHelpers) + 1624);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7776]");
				object obj33 = (nint)0 & (nint)1;
				bool flag13 = obj33 == null;
				jackarooCustomRuleSaveEntry5 = defaultRuleSaveEntry;
				jackarooCustomRuleSaveEntry4 = defaultRuleSaveEntry;
				list4 = list2;
				if (!flag13)
				{
					goto IL_069c;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				list2 = (List<JackarooCustomRuleSaveEntry>)(typeof(System.Buffers.Text.ParserHelpers) + 1624);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7776]");
				object obj34 = (nint)0 & (nint)1;
				bool flag14 = obj34 == null;
				object obj35 = !flag14;
				jackarooCustomRuleSaveEntry5 = defaultRuleSaveEntry;
				jackarooCustomRuleSaveEntry4 = defaultRuleSaveEntry;
				list4 = list2;
				if (obj35 != null)
				{
					goto IL_069c;
				}
			}
			_ = 1;
			nint num6 = (nint)list4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X0_v21 (Il2CppClass<System.Collections.Generic.List`1<JackarooCustomRuleSaveEntry>>)+E4]");
			flag = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X0_v21 (Il2CppClass<System.Collections.Generic.List`1<JackarooCustomRuleSaveEntry>>)+E4]");
			bool flag15 = (byte)(~(nuint)0u) != 0;
			object obj36 = !flag15;
			jackarooCustomRuleSaveEntry5 = jackarooCustomRuleSaveEntry4;
			list2 = list4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X0_v21 (Il2CppClass<System.Collections.Generic.List`1<JackarooCustomRuleSaveEntry>>)+E4]");
			flag9 = false;
			if (obj36 != null)
			{
				goto IL_06fb;
			}
			goto IL_0825;
			IL_0872:
			if (list == null)
			{
				break;
			}
			num = jackarooPreferredCustomRulesIndex - 1;
			bool flag16 = num >= list._size;
			flag9 = (byte)list._size != 0;
			jackarooCustomRuleSaveEntry4 = jackarooCustomRuleSaveEntry5;
			list4 = list2;
			if (flag16)
			{
				goto IL_0949;
			}
			flag = (byte)((nuint)0u + (nuint)2088u) != 0;
			jackarooCustomRuleSaveEntry = (JackarooCustomRuleSaveEntry)((bool*)(flag ? 1 : 0))->m_value;
			object obj37 = ((List<object>)(object)list).get_Item(num);
			if (obj37 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E777C]");
			flag = false;
			list = (List<JackarooCustomRuleSaveEntry>)(object)("<ds.DataTable.OnColumnChanging|INFO> {0}" + 3568);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v15 (System.Object)+38]");
			textMesh = (TextMeshProUGUI)0;
			text = (string)(object)list;
			jackarooCustomRuleSaveEntry4 = (JackarooCustomRuleSaveEntry)obj37;
			list4 = (List<JackarooCustomRuleSaveEntry>)152989696;
			goto IL_0d52;
			IL_09b7:
			readOnlyList = readOnlyList2;
			obj23 = 0;
			transform3 = transform2;
			jackarooCustomRuleSaveEntry3 = jackarooCustomRuleSaveEntry2;
			break;
			IL_069c:
			nint num7 = (nint)list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X0_v35 (Il2CppClass<System.Collections.Generic.List`1<JackarooCustomRuleSaveEntry>>)+E4]");
			flag = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X0_v35 (Il2CppClass<System.Collections.Generic.List`1<JackarooCustomRuleSaveEntry>>)+E4]");
			bool flag17 = (byte)(~(nuint)0u) != 0;
			num6 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X0_v35 (Il2CppClass<System.Collections.Generic.List`1<JackarooCustomRuleSaveEntry>>)+E4]");
			flag9 = false;
			jackarooCustomRuleSaveEntry4 = jackarooCustomRuleSaveEntry5;
			list4 = list2;
			if (!flag17)
			{
				goto IL_06fb;
			}
			goto IL_0825;
			IL_06fb:
			jackarooPreferredCustomRulesIndex = Preferences.JackarooPreferredCustomRulesIndex;
			bool flag18 = jackarooPreferredCustomRulesIndex == 0;
			object obj38 = !flag18;
			if (obj38 != null)
			{
				goto IL_0872;
			}
			flag9 = flag;
			jackarooCustomRuleSaveEntry4 = jackarooCustomRuleSaveEntry5;
			list4 = list2;
			goto IL_0949;
			IL_0949:
			bool flag19 = (object)jackarooCustomRuleSaveEntry4 == null;
			flag = flag9;
			list2 = list4;
			if (flag19)
			{
				break;
			}
			textMesh = jackarooCustomRuleSaveEntry4._buttonText;
			flag = (byte)(int)("<ds.DataTable.OnColumnChanging|INFO> {0}" + 3568) != 0;
			text = (string)((bool*)(flag ? 1 : 0))->m_value;
			list = (List<JackarooCustomRuleSaveEntry>)152989696;
			goto IL_0d52;
		}
		goto IL_0cc5;
		IL_0cc5:
		throw new NullReferenceException();
		IL_0101:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		jackarooCustomRuleSaveEntry = null;
		list = list3;
		goto IL_0ade;
	}

	private unsafe static void AddSaveEntry(JackarooCustomRuleSaveEntry saveEntryPrefab, Transform saveEntryParent, List<JackarooCustomRuleSaveEntry> saveEntries, JackarooCustomRulesSave customRulesSave, Action<JackarooCustomRuleSaveEntry> activateCallback, Action<JackarooCustomRuleSaveEntry> editCallback, Action<JackarooCustomRuleSaveEntry> deleteCallback, Action<JackarooCustomRuleSaveEntry, Action, Action> onSwipeAction, bool isLoad = true)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0011: Expected O, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_003b: Expected O, but got I
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I
		//IL_0120: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_0064: Expected O, but got I
		//IL_0182: Expected O, but got I
		//IL_022c: Expected O, but got I4
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = 152989696;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7748]");
		object obj5 = (nint)0 & (nint)1;
		if (obj5 != null)
		{
			object obj6 = (nint)0 + (nint)952;
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = obj6;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			object obj9 = typeof(MemberAchievementClanFeedData) + 2976;
			_ = 1;
			object obj6 = (nint)0 + (nint)952;
			object obj7 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			object obj8 = obj6;
			if (obj10 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
		goto IL_014f;
		IL_014f:
		JackarooCustomRuleSaveEntry jackarooCustomRuleSaveEntry = default(JackarooCustomRuleSaveEntry);
		jackarooCustomRuleSaveEntry.Setup(customRulesSave, activateCallback, editCallback, deleteCallback, onSwipeAction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
		object obj11 = (nint)0 & (nint)1;
		if (obj11 != null)
		{
			((List<object>)(object)saveEntries).Insert(0, (object)jackarooCustomRuleSaveEntry);
			return;
		}
		Transform transform = jackarooCustomRuleSaveEntry.transform;
		transform.SetSiblingIndex(1);
		int version = saveEntries._version + 1;
		saveEntries._version = version;
		JackarooCustomRuleSaveEntry[] items = saveEntries._items;
		bool flag3 = saveEntries._size < items.Length;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			int size = saveEntries._size + 1;
			saveEntries._size = size;
			object obj13 = items + saveEntries._size;
			object obj14 = obj13 + 32;
			obj14 = jackarooCustomRuleSaveEntry;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			((List<object>)(object)saveEntries).AddWithResize((object)jackarooCustomRuleSaveEntry);
		}
		return;
		IL_0099:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
		bool flag4 = (object)jackarooCustomRuleSaveEntry == null;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_014f;
	}

	private void ActivateCallback(JackarooCustomRuleSaveEntry jackarooCustomRuleSaveEntry)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0379: Expected O, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00d6: Expected O, but got I4
		//IL_013f: Expected O, but got I
		//IL_02b7: Expected O, but got I4
		//IL_03ca: Expected O, but got I
		//IL_03e4: Expected O, but got I
		//IL_023e: Expected O, but got I
		//IL_023e: Expected O, but got I
		//IL_02e7: Expected O, but got I
		//IL_02e7: Expected O, but got I
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_032a: Expected O, but got I4
		//IL_01a1: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = _defaultRuleSaveEntry == jackarooCustomRuleSaveEntry;
		JackarooCustomRuleSaveEntry defaultRuleSaveEntry = _defaultRuleSaveEntry;
		object text = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3512;
		object text2 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3568;
		if (flag2)
		{
			TextMeshProExtensions.Localize(defaultRuleSaveEntry._buttonText, (string)text2);
			defaultRuleSaveEntry._buttonImage.sprite = defaultRuleSaveEntry._activeSprite;
			object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v46+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			JackarooCustomRules.SetCurrentJackarooCustomRuleSave(null, 0);
		}
		else
		{
			TextMeshProExtensions.Localize(defaultRuleSaveEntry._buttonText, (string)text);
			defaultRuleSaveEntry._buttonImage.sprite = defaultRuleSaveEntry._inactiveSprite;
		}
		List<object> saveEntries = (List<object>)(object)_saveEntries;
		object obj7 = (nint)0 + (nint)2088;
		int num = 0;
		object obj14;
		do
		{
			IL_025b:
			if (num >= saveEntries._size)
			{
				return;
			}
			object obj8 = saveEntries.get_Item(num);
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				if ((UnityEngine.Object)obj8 != jackarooCustomRuleSaveEntry)
				{
					goto IL_03b5;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag4 = (UnityEngine.Object)obj8 != jackarooCustomRuleSaveEntry;
				bool flag5 = !flag4;
				object obj10 = !flag5;
				if (obj10 != null)
				{
					goto IL_03b5;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v11 (System.Object)+38]");
			TextMeshProExtensions.Localize((TextMeshProUGUI)0, (string)text2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v11 (System.Object)+30]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v11 (System.Object)+40]");
			((Image)num2).sprite = (Sprite)0;
			object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v12+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int saveIndex = num + 1;
			JackarooCustomRules.SetCurrentJackarooCustomRuleSave(jackarooCustomRuleSaveEntry.<JackarooCustomRulesSave>k__BackingField, saveIndex);
			saveEntries = (List<object>)(object)_saveEntries;
			num++;
			bool flag7 = _saveEntries == null;
			obj14 = !flag7;
			continue;
			IL_03b5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v11 (System.Object)+38]");
			TextMeshProExtensions.Localize((TextMeshProUGUI)0, (string)text);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v11 (System.Object)+30]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v11 (System.Object)+48]");
			((Image)num3).sprite = (Sprite)0;
			saveEntries = (List<object>)(object)_saveEntries;
			num++;
			goto IL_025b;
		}
		while (obj14 != null);
		throw new NullReferenceException();
	}

	private void EditCallback(JackarooCustomRuleSaveEntry saveEntry)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		object obj = this + 160;
		obj = saveEntry;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X21_v2-8]");
		GameObject gameObject = ((Component)0).gameObject;
		gameObject.SetActive(value: true);
		JackarooCustomRulesSave <JackarooCustomRulesSave>k__BackingField = saveEntry.<JackarooCustomRulesSave>k__BackingField;
		LoadRules(_jackarooCustomRulesUis, <JackarooCustomRulesSave>k__BackingField.<IndicesAndRules>k__BackingField);
		_inputField.Text = <JackarooCustomRulesSave>k__BackingField.<Name>k__BackingField;
		_inputField.Interactable = false;
		_slideAnimationHelper.SlideIn();
	}

	private void DoDeleteEntry(JackarooCustomRuleSaveEntry saveEntry, Action confirmAction, Action dismissAction)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00ff: Expected I, but got O
		//IL_011f: Expected I, but got O
		//IL_014e: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass31_0 <>c__DisplayClass31_ = default(<>c__DisplayClass31_0);
		<>c__DisplayClass31_..ctor();
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)1840;
		object obj4 = (nint)0 + (nint)1848;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgTitle = "Complete" + 256;
		object msgBody = "Read object reference Id '{0}' for {1}." + 3632;
		object obj6 = <>c__DisplayClass31_ + 16;
		obj6 = confirmAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = <>c__DisplayClass31_ + 24;
		obj7 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = <>c__DisplayClass31_ + 32;
		obj8 = dismissAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		DisableSwipes();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(<>c__DisplayClass31_, (IntPtr)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(<>c__DisplayClass31_, (IntPtr)obj4);
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v19+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowNegativeConfirmWithAction((string)msgTitle, (string)msgBody, action, action2);
	}

	private void EnableSwipes()
	{
		//IL_014f: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_0165: Expected I, but got O
		//IL_00f0: Expected I, but got O
		//IL_003b: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		bool flag = _saveEntries == null;
		object obj = 152989696;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)2704;
			obj = (nint)0 + (nint)2696;
			List<object>.Enumerator enumerator = ((List<object>)(object)_saveEntries).GetEnumerator();
			num = (nint)obj2;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			object obj3 = 0;
			NullReferenceException ex = new NullReferenceException();
			object obj4 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj;
			enumerator2.Dispose();
			object obj5 = default(object);
			if (obj5 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj4 = obj5;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223A200");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void DisableSwipes()
	{
		//IL_014f: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_0165: Expected I, but got O
		//IL_00f0: Expected I, but got O
		//IL_003b: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		bool flag = _saveEntries == null;
		object obj = 152989696;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)2704;
			obj = (nint)0 + (nint)2696;
			List<object>.Enumerator enumerator = ((List<object>)(object)_saveEntries).GetEnumerator();
			num = (nint)obj2;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			object obj3 = 0;
			NullReferenceException ex = new NullReferenceException();
			object obj4 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj;
			enumerator2.Dispose();
			object obj5 = default(object);
			if (obj5 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj4 = obj5;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223A200");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void DeleteCallback(JackarooCustomRuleSaveEntry saveEntry)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_028d: Expected O, but got I
		//IL_02a7: Expected O, but got I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0097: Expected O, but got I
		//IL_02ed: Expected O, but got I4
		//IL_0329: Expected O, but got I4
		//IL_0108: Expected O, but got I4
		//IL_0163: Expected I4, but got O
		//IL_045c: Expected O, but got I
		//IL_0476: Expected O, but got I4
		//IL_0486: Expected O, but got I4
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_01f3: Expected I4, but got O
		//IL_018f: Expected O, but got I
		//IL_01ae: Expected I4, but got O
		//IL_04cc: Expected O, but got I4
		//IL_04dc: Expected O, but got I4
		//IL_03b4: Expected O, but got I4
		//IL_0518: Expected O, but got I4
		//IL_0220: Expected O, but got I4
		//IL_0236: Expected I4, but got O
		//IL_0406: Expected O, but got I4
		//IL_041c: Expected O, but got I4
		//IL_042e: Expected O, but got I4
		//IL_075b: Expected O, but got I4
		//IL_0634: Expected O, but got I
		//IL_064e: Expected O, but got I4
		//IL_024c: Expected I4, but got O
		//IL_0592: Expected O, but got I
		//IL_068c: Expected O, but got I4
		//IL_06cc: Expected O, but got I
		//IL_0601: Expected O, but got I4
		//IL_07d5: Expected O, but got I4
		//IL_072c: Expected O, but got I
		object obj = (nint)0 + (nint)2056;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
		object obj3 = obj;
		int num = ((List<object>)(object)_saveEntries).IndexOf((object)saveEntry);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v6+E4]");
		object obj5;
		object obj7;
		if ((nint)0 != 0)
		{
			obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7776]");
			object obj6 = (nint)0 & (nint)1;
			bool flag = obj6 == null;
			obj7 = obj5;
			if (!flag)
			{
				goto IL_00bc;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7776]");
			object obj8 = (nint)0 & (nint)1;
			bool flag2 = obj8 == null;
			object obj9 = !flag2;
			obj7 = obj5;
			if (obj9 != null)
			{
				goto IL_00bc;
			}
		}
		_ = 1;
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v68+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		obj5 = obj7;
		if (obj11 != null)
		{
			goto IL_00f1;
		}
		goto IL_0303;
		IL_06b2:
		int jackarooPreferredCustomRulesIndex;
		int index = jackarooPreferredCustomRulesIndex - 1;
		object obj12 = (nint)0 + (nint)2088;
		object obj13 = obj12;
		object obj14 = ((List<object>)(object)_saveEntries).get_Item(index);
		object obj15 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X0_v21+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int jackarooPreferredCustomRulesIndex2 = Preferences.JackarooPreferredCustomRulesIndex;
		int saveIndex = jackarooPreferredCustomRulesIndex2 - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v19 (System.Object)+68]");
		JackarooCustomRules.SetCurrentJackarooCustomRuleSave((JackarooCustomRulesSave)0, saveIndex);
		goto IL_0731;
		IL_0731:
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		JackarooCustomRules.Delete(saveEntry.<JackarooCustomRulesSave>k__BackingField);
		bool flag6 = ((List<object>)(object)_saveEntries).Remove((object)saveEntry);
		return;
		IL_05dc:
		jackarooPreferredCustomRulesIndex = Preferences.JackarooPreferredCustomRulesIndex;
		bool flag7 = _saveEntries == null;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_06b2;
		IL_00bc:
		obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v68+E4]");
		bool flag8 = (nint)0 == 0;
		obj7 = obj5;
		if (!flag8)
		{
			goto IL_00f1;
		}
		goto IL_0303;
		IL_0303:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int jackarooPreferredCustomRulesIndex3 = Preferences.JackarooPreferredCustomRulesIndex;
		object obj20 = jackarooPreferredCustomRulesIndex3 - 1;
		bool flag9 = num != (nint)obj20;
		obj5 = obj7;
		if (flag9)
		{
			goto IL_012c;
		}
		goto IL_0350;
		IL_00f1:
		int jackarooPreferredCustomRulesIndex4 = Preferences.JackarooPreferredCustomRulesIndex;
		object obj21 = jackarooPreferredCustomRulesIndex4 - 1;
		bool flag10 = num == (nint)obj21;
		obj7 = obj5;
		if (!flag10)
		{
			goto IL_012c;
		}
		goto IL_0350;
		IL_0350:
		JackarooCustomRuleSaveEntry defaultRuleSaveEntry = _defaultRuleSaveEntry;
		object text = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3568;
		TextMeshProExtensions.Localize(defaultRuleSaveEntry._buttonText, (string)text);
		defaultRuleSaveEntry._buttonImage.sprite = defaultRuleSaveEntry._activeSprite;
		object obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v60+E4]");
		bool flag11 = (nint)0 == 0;
		object obj23 = !flag11;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		JackarooCustomRules.SetCurrentJackarooCustomRuleSave(null, 0);
		object obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v54+E4]");
		bool flag12 = (nint)0 == 0;
		object obj25 = !flag12;
		obj5 = obj7;
		object obj26 = null;
		obj3 = 0;
		int num2 = 0;
		obj13 = 0;
		if (obj25 != null)
		{
			goto IL_0179;
		}
		goto IL_043c;
		IL_069a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		jackarooPreferredCustomRulesIndex = Preferences.JackarooPreferredCustomRulesIndex;
		goto IL_06b2;
		IL_05af:
		object obj27 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v30+E4]");
		if ((nint)0 != 0)
		{
			goto IL_05dc;
		}
		goto IL_069a;
		IL_012c:
		obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v54+E4]");
		bool flag13 = (nint)0 == 0;
		obj26 = saveEntry;
		obj7 = obj5;
		num2 = (int)saveEntry;
		obj13 = obj3;
		if (!flag13)
		{
			goto IL_0179;
		}
		goto IL_043c;
		IL_043c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7776]");
		object obj28 = (nint)0 & (nint)1;
		bool flag14 = obj28 == null;
		object obj29 = !flag14;
		obj5 = obj7;
		obj26 = num2;
		obj3 = obj13;
		if (obj29 != null)
		{
			goto IL_01c4;
		}
		goto IL_049c;
		IL_0179:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7776]");
		object obj30 = (nint)0 & (nint)1;
		bool flag15 = obj30 == null;
		obj7 = obj5;
		num2 = (int)obj26;
		obj13 = obj3;
		if (!flag15)
		{
			goto IL_01c4;
		}
		goto IL_049c;
		IL_049c:
		_ = 1;
		object obj31 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v45+E4]");
		bool flag16 = (nint)0 == 0;
		object obj32 = !flag16;
		obj5 = obj7;
		obj26 = num2;
		obj3 = obj13;
		if (obj32 != null)
		{
			goto IL_0209;
		}
		goto IL_04f2;
		IL_01c4:
		obj31 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v45+E4]");
		bool flag17 = (nint)0 == 0;
		obj7 = obj5;
		num2 = (int)obj26;
		obj13 = obj3;
		if (!flag17)
		{
			goto IL_0209;
		}
		goto IL_04f2;
		IL_04f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int jackarooPreferredCustomRulesIndex5 = Preferences.JackarooPreferredCustomRulesIndex;
		object obj33 = jackarooPreferredCustomRulesIndex5 - 1;
		bool flag18 = num >= (nint)obj33;
		obj5 = obj7;
		obj3 = obj13;
		saveIndex = num2;
		if (!flag18)
		{
			goto IL_054f;
		}
		goto IL_0731;
		IL_0209:
		int jackarooPreferredCustomRulesIndex6 = Preferences.JackarooPreferredCustomRulesIndex;
		object obj34 = jackarooPreferredCustomRulesIndex6 - 1;
		bool flag19 = num < (nint)obj34;
		num2 = (int)obj26;
		if (flag19)
		{
			goto IL_054f;
		}
		saveIndex = (int)obj26;
		obj13 = obj3;
		goto IL_0731;
		IL_054f:
		object obj35 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X0_v16+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7776]");
			object obj36 = (nint)0 & (nint)1;
			if (obj36 != null)
			{
				goto IL_05af;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7776]");
			object obj37 = (nint)0 & (nint)1;
			bool flag20 = obj37 == null;
			object obj38 = !flag20;
			if (obj38 != null)
			{
				goto IL_05af;
			}
		}
		_ = 1;
		obj27 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v30+E4]");
		bool flag21 = (nint)0 == 0;
		object obj39 = !flag21;
		if (obj39 != null)
		{
			goto IL_05dc;
		}
		goto IL_069a;
	}

	public void Initialize()
	{
		ShowRulesPop();
	}

	private void ShowRulesPop()
	{
		//IL_0013: Expected O, but got I
		//IL_0020: Expected O, but got I
		//IL_025d: Expected I, but got O
		//IL_0103: Expected I, but got O
		//IL_0126: Expected O, but got I4
		//IL_01e9: Expected I, but got O
		//IL_019b: Expected O, but got I4
		//IL_0068: Expected O, but got I
		//IL_00f6: Expected O, but got I
		//IL_00bb: Expected O, but got I
		object obj2 = default(object);
		nint num = default(nint);
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		if (_jackarooCustomRulesUis != null)
		{
			object obj = (nint)0 + (nint)2728;
			obj2 = (nint)0 + (nint)2720;
			List<object>.Enumerator enumerator = ((List<object>)(object)_jackarooCustomRulesUis).GetEnumerator();
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			object obj3 = default(object);
			List<object>.Enumerator enumerator5;
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			while (true)
			{
				num = (nint)obj;
				if (!enumerator2.MoveNext())
				{
					break;
				}
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ stack_-58+2C]");
					object obj4 = (nint)0 & (nint)1;
					if (obj4 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ stack_-58+58]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ stack_-58+58]");
							((BaseDropMenu<object>)0).Hide();
							continue;
						}
						NullReferenceException ex = new NullReferenceException();
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ stack_-58+50]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ stack_-58+50]");
							((BaseDropMenu<object>)0).Hide();
							continue;
						}
						NullReferenceException ex2 = new NullReferenceException();
					}
				}
				else
				{
					NullReferenceException ex3 = new NullReferenceException();
				}
				enumerator3 = enumerator4;
				enumerator5 = enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
				goto IL_0287;
			}
			num = (nint)obj2;
			enumerator2.Dispose();
			enumerator3 = enumerator4;
			enumerator5 = enumerator4;
			enumerator4 = (List<object>.Enumerator)0;
			goto IL_012b;
		}
		goto IL_0287;
		IL_012b:
		if ((object)_customRulesPopup != null)
		{
			_customRulesPopup.Show();
			return;
		}
		goto IL_0287;
		IL_0287:
		NullReferenceException ex4 = new NullReferenceException();
		bool flag = num != 1;
		NullReferenceException ex5 = ex4;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj2;
			enumerator3.Dispose();
			object obj5 = default(object);
			bool flag2 = obj5 == null;
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj5;
			if (flag2)
			{
				goto IL_012b;
			}
			OutOfMemoryException ex6 = new OutOfMemoryException();
			enumerator4 = (List<object>.Enumerator)obj5;
			ex5 = (NullReferenceException)(object)ex6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223A1C0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void HideRulesPop()
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		PopupUI customRulesPopup = _customRulesPopup;
		nint num = (nint)customRulesPopup;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<PopupUI>)+198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<PopupUI>)+1A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void OnBlockerClicked()
	{
		//IL_0052: Expected I, but got O
		//IL_0062: Expected O, but got I
		//IL_0072: Expected O, but got I
		SlideAnimationHelper slideAnimationHelper = _slideAnimationHelper;
		if (slideAnimationHelper.<IsShown>k__BackingField)
		{
			CloseRulesPanel();
			return;
		}
		PopupUI customRulesPopup = _customRulesPopup;
		nint num = (nint)customRulesPopup;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4 (Il2CppClass<PopupUI>)+198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4 (Il2CppClass<PopupUI>)+1A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v62 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void RefreshContentFitters()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy permanentInstance = CoroutineDummy.PermanentInstance;
		object obj4 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<RefreshLayoutRecursive>d__40 <RefreshLayoutRecursive>d__ = default(<RefreshLayoutRecursive>d__40);
		<RefreshLayoutRecursive>d__..ctor(0);
		object obj5 = <RefreshLayoutRecursive>d__ + 32;
		obj5 = _rectT;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = permanentInstance.StartCoroutine(<RefreshLayoutRecursive>d__);
	}

	private static IEnumerator RefreshLayoutRecursive(RectTransform root)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<RefreshLayoutRecursive>d__40 <RefreshLayoutRecursive>d__ = default(<RefreshLayoutRecursive>d__40);
		<RefreshLayoutRecursive>d__..ctor(0);
		if (<RefreshLayoutRecursive>d__ != null)
		{
			object obj2 = <RefreshLayoutRecursive>d__ + 32;
			obj2 = root;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return <RefreshLayoutRecursive>d__;
		}
		return (IEnumerator)new NullReferenceException();
	}

	public JackarooCustomRulesPopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 104;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <Start>b__17_0()
	{
		_isEdit = false;
		GameObject gameObject = _deleteButton.gameObject;
		gameObject.SetActive(value: false);
		OnAddNewRulesClicked();
	}

	private void <Start>b__17_1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0090: Expected I, but got O
		//IL_00ba: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)584;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgTitle = "Complete" + 256;
		object msgBody = "Read object reference Id '{0}' for {1}." + 3632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowNegativeConfirm((string)msgTitle, (string)msgBody, action);
	}

	private void <Start>b__17_2()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		DeleteCallback(_currentSaveEntry);
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		GameObject obj2 = _currentSaveEntry.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			UnityEngine.Object.Destroy(obj2);
			CloseRulesPanel();
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object.Destroy(obj2);
			CloseRulesPanel();
		}
	}
}
