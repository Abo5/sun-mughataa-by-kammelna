using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ServerDropdownMenu : MonoBehaviour
{
	private sealed class <>c__DisplayClass9_0
	{
		public GameObject listItem;

		public ServerDropdownMenu <>4__this;

		internal void <Start>b__0()
		{
			<>4__this.ItemClicked(listItem);
		}
	}

	private GameObject menuItemPrefab;

	private VerticalLayoutGroup serversList;

	private PopupUI serversListPopUp;

	private Button serversButton;

	private TextMeshProUGUI selectedServerText;

	private Transform _originalParent;

	private List<SFSConfig> _servers;

	private bool _isOpen;

	private Coroutine _setParentDelay;

	private void Start()
	{
		//IL_0987: Expected O, but got I4
		//IL_002d: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_08fc: Expected O, but got I
		//IL_0904: Expected I4, but got O
		//IL_00b1: Expected O, but got I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_011c: Expected O, but got I4
		//IL_012d: Expected I4, but got O
		//IL_0148: Expected O, but got I
		//IL_0154: Expected O, but got I
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_016f: Expected O, but got I
		//IL_05ee: Expected O, but got I
		//IL_05f6: Expected I4, but got O
		//IL_0619: Expected O, but got I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_08aa: Expected O, but got I4
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_0726: Expected I4, but got O
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_025c: Expected O, but got I4
		//IL_0285: Expected O, but got I
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_02ad: Expected O, but got I4
		//IL_02e1: Expected I4, but got O
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_0332: Expected O, but got I
		//IL_033a: Expected I, but got O
		//IL_034b: Expected I, but got O
		//IL_06be: Expected O, but got I4
		//IL_06c6: Expected I4, but got O
		//IL_038a: Expected O, but got I
		//IL_073d: Expected O, but got I4
		//IL_074e: Expected I4, but got O
		//IL_078d: Expected O, but got I4
		//IL_0803: Expected O, but got I4
		//IL_0814: Expected I4, but got O
		//IL_082b: Expected O, but got I4
		//IL_0431: Expected I4, but got O
		//IL_07b6: Expected O, but got I4
		//IL_0765: Expected O, but got I4
		//IL_0776: Expected I4, but got O
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected O, but got Unknown
		//IL_04e4: Expected O, but got I4
		//IL_07d6: Expected O, but got I4
		//IL_07ec: Expected I4, but got O
		//IL_055a: Expected O, but got I4
		//IL_0854: Expected O, but got I4
		//IL_086a: Expected I4, but got O
		//IL_0596: Expected I4, but got O
		//IL_0881: Expected O, but got I4
		//IL_05d4: Expected O, but got I4
		bool flag = (object)serversButton == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		IntPtr intPtr = default(IntPtr);
		bool flag2 = (byte)(nint)intPtr != 0;
		if (!flag)
		{
			Transform transform = serversButton.transform;
			bool flag3 = (object)transform == null;
			enumerator = (List<object>.Enumerator)0;
			flag2 = false;
			if (!flag3)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
				Transform parent = transform.parent;
				object obj2 = this + 72;
				obj2 = parent;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v26+E4]");
				bool flag4 = (nint)0 == 0;
				object obj4 = !flag4;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				List<SFSConfig> currentGameServers = Config.GetCurrentGameServers();
				object obj5 = this + 80;
				obj5 = currentGameServers;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag5 = obj5 == null;
				enumerator = (List<object>.Enumerator)0;
				nint num = 0;
				flag2 = (byte)(int)currentGameServers != 0;
				if (!flag5)
				{
					object obj6 = (nint)0 + (nint)864;
					object obj7 = (nint)0 + (nint)1128;
					object obj8 = "SERVICE_DISABLED" + 3384;
					object obj9 = (nint)0 + (nint)1472;
					List<object>.Enumerator enumerator2 = ((List<object>)obj5).GetEnumerator();
					num = 0;
					List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
					object obj11 = default(object);
					bool flag7 = default(bool);
					object obj19 = default(object);
					UnityAction unityAction = default(UnityAction);
					SFSConfig sFSConfig = default(SFSConfig);
					object textMesh = default(object);
					Selectable selectable = default(Selectable);
					List<object>.Enumerator enumerator5;
					List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
					while (enumerator3.MoveNext())
					{
						object obj10 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2952;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						obj11..ctor();
						if (obj11 != null)
						{
							object obj12 = obj11 + 24;
							obj12 = this;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							if ((object)serversList != null)
							{
								Transform transform2 = serversList.transform;
								object obj13 = typeof(MemberAchievementClanFeedData) + 2976;
								object obj14 = obj13;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X0_v48+E4]");
								bool flag6 = (nint)0 == 0;
								object obj15 = !flag6;
								if (obj15 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj16 = (nint)0 + (nint)920;
								object obj17 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
								object obj18 = obj11 + 16;
								obj18 = flag7;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								if (obj18 != null)
								{
									flag2 = (byte)(int)obj7 != 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
									if (obj19 != null)
									{
										object obj20 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										object obj21 = (nint)0 + (nint)1776;
										num = (nint)obj21;
										unityAction..ctor(obj11, (IntPtr)obj21);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v56+100]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v56+100]");
											((UnityEvent)0).AddListener(unityAction);
											if (obj18 != null)
											{
												Transform transform3 = ((GameObject)obj18).transform;
												if ((object)transform3 != null)
												{
													Transform transform4 = transform3.Find((string)obj8);
													if ((object)transform4 != null)
													{
														GameObject gameObject = transform4.gameObject;
														if ((object)gameObject != null)
														{
															flag2 = (byte)(int)obj9 != 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
															if (sFSConfig != null)
															{
																string displayName = sFSConfig.DisplayName;
																TextMeshProExtensions.FixArabic((TextMeshProUGUI)textMesh, displayName);
																if (obj18 != null)
																{
																	((UnityEngine.Object)obj18).name = sFSConfig.<ID>k__BackingField;
																	object obj22 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
																	object obj23 = obj22;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v77+E4]");
																	bool flag8 = (nint)0 == 0;
																	object obj24 = !flag8;
																	if (obj24 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	}
																	SFSConfig currentSFS = Config.CurrentSFS;
																	if (currentSFS != null)
																	{
																		bool flag9 = sFSConfig.<ID>k__BackingField == currentSFS.<ID>k__BackingField;
																		bool flag10 = !flag9;
																		obj17 = 0;
																		num = 0;
																		if (flag10)
																		{
																			continue;
																		}
																		if (obj18 != null)
																		{
																			flag2 = (byte)(int)obj7 != 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
																			if ((object)selectable != null)
																			{
																				selectable.interactable = false;
																				obj17 = 0;
																				num = 0;
																				continue;
																			}
																			NullReferenceException ex = new NullReferenceException();
																			obj17 = 0;
																			num = 0;
																		}
																		else
																		{
																			NullReferenceException ex2 = new NullReferenceException();
																			obj17 = 0;
																			num = 0;
																			flag2 = (byte)(int)currentSFS.<ID>k__BackingField != 0;
																		}
																	}
																	else
																	{
																		NullReferenceException ex3 = new NullReferenceException();
																		obj17 = 0;
																		num = 0;
																		flag2 = (byte)(int)sFSConfig.<ID>k__BackingField != 0;
																	}
																}
																else
																{
																	NullReferenceException ex4 = new NullReferenceException();
																	obj17 = 0;
																	num = 0;
																	flag2 = (byte)(int)displayName != 0;
																}
															}
															else
															{
																NullReferenceException ex5 = new NullReferenceException();
																obj17 = 0;
																num = 0;
															}
														}
														else
														{
															NullReferenceException ex6 = new NullReferenceException();
															obj17 = 0;
															num = 0;
															flag2 = false;
														}
													}
													else
													{
														NullReferenceException ex7 = new NullReferenceException();
														obj17 = 0;
														num = 0;
														flag2 = (byte)(int)obj8 != 0;
													}
												}
												else
												{
													NullReferenceException ex8 = new NullReferenceException();
													obj17 = 0;
													num = 0;
													flag2 = false;
												}
											}
											else
											{
												NullReferenceException ex9 = new NullReferenceException();
												obj17 = 0;
												num = 0;
												flag2 = (byte)(int)unityAction != 0;
											}
										}
										else
										{
											NullReferenceException ex10 = new NullReferenceException();
											obj17 = 0;
											flag2 = (byte)(int)obj11 != 0;
										}
									}
									else
									{
										NullReferenceException ex11 = new NullReferenceException();
										num = 0;
									}
								}
								else
								{
									NullReferenceException ex12 = new NullReferenceException();
									num = 0;
									flag2 = flag7;
								}
							}
							else
							{
								NullReferenceException ex13 = new NullReferenceException();
								flag2 = (byte)(int)this != 0;
							}
						}
						else
						{
							NullReferenceException ex14 = new NullReferenceException();
							flag2 = false;
						}
						enumerator = enumerator4;
						enumerator5 = enumerator4;
						enumerator4 = (List<object>.Enumerator)0;
						goto IL_099d;
					}
					object obj25 = (nint)0 + (nint)856;
					flag2 = (byte)(int)obj25 != 0;
					enumerator3.Dispose();
					enumerator = enumerator4;
					enumerator5 = enumerator4;
					enumerator4 = (List<object>.Enumerator)0;
					goto IL_061e;
				}
			}
		}
		goto IL_099d;
		IL_099d:
		NullReferenceException ex15 = new NullReferenceException();
		bool flag11 = !flag2;
		OutOfMemoryException ex16 = (OutOfMemoryException)(object)ex15;
		if (!flag11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj26 = (nint)0 + (nint)856;
			flag2 = (byte)(int)obj26 != 0;
			enumerator.Dispose();
			object obj27 = default(object);
			bool flag12 = obj27 == null;
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj27;
			if (flag12)
			{
				goto IL_061e;
			}
			ex16 = new OutOfMemoryException();
			enumerator4 = (List<object>.Enumerator)obj27;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2238554");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_061e:
		UpdateSelectedServerName();
		if ((object)serversButton != null)
		{
			serversButton.interactable = true;
			bool flag13 = (object)serversListPopUp == null;
			nint num = 0;
			flag2 = true;
			if (!flag13)
			{
				Transform transform5 = serversListPopUp.transform;
				UIExtensions.AttachToCanvas(transform5, CanvasLayer.SecondaryCanvas);
				return;
			}
		}
		goto IL_099d;
	}

	public void ToggleMenu()
	{
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_016f: Expected O, but got I
		//IL_017d: Expected I, but got O
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01bb: Expected O, but got I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0067: Expected I, but got O
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00aa: Expected O, but got I4
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0247: Expected O, but got I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_02b1: Expected O, but got I
		if (_isOpen)
		{
			_isOpen = false;
			serversListPopUp.ShrinkToParent();
			PopupUI popupUI = serversListPopUp;
			object obj = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = (nint)0 + (nint)1992;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj2);
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v26+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float seconds = popupUI.fadeDuration + 3.175927E+09f;
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(seconds, action);
			object obj6 = this + 96;
			obj6 = coroutine;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
		}
		_isOpen = true;
		PopupUI popupUI2 = serversListPopUp;
		GameObject popup = popupUI2.content.gameObject;
		object obj7 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)2000;
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj8);
		object obj9 = typeof(RegisteredWaitHandle) + 3136;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(popup, action2);
		if (_setParentDelay != null)
		{
			object obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v18+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CoroutineDummy.StopInstanceCoroutine(_setParentDelay);
		}
		Component component = serversListPopUp;
		Transform parent = serversListPopUp.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v12 (UnityEngine.Component)+28]");
		((Transform)0).SetParent(parent, worldPositionStays: true);
		Transform transform = serversButton.transform;
		PopupUI popupUI3 = serversListPopUp;
		transform.SetParent(popupUI3.blocker, worldPositionStays: true);
		serversListPopUp.PopFromCenter();
	}

	private void ItemClicked(GameObject sender)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00e8: Expected O, but got I4
		//IL_0111: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		string text = sender.name;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string serverID = Config.ServerID;
		if (!(text == serverID))
		{
			object obj4 = typeof(Queue<string>) + 856;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = (nint)0 + (nint)2216;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			string serverId = sender.name;
			SfsConnectionManager sfsConnectionManager = default(SfsConnectionManager);
			sfsConnectionManager.SwitchServerAndReloadScene(serverId);
			UpdateSelectedServerName();
			ToggleMenu();
		}
	}

	private void UpdateSelectedServerName()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_026b: Expected O, but got I4
		//IL_0061: Expected O, but got I4
		//IL_0085: Expected O, but got I
		//IL_0091: Expected O, but got I
		//IL_00a7: Expected O, but got I4
		//IL_028f: Expected I4, but got O
		//IL_01e1: Expected I4, but got O
		//IL_0193: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string serverID = Config.ServerID;
		List<SFSConfig> currentGameServers = Config.GetCurrentGameServers(includeRestricted: true);
		bool flag2 = currentGameServers == null;
		object obj4 = 0;
		bool flag3 = false;
		object obj6 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag2)
		{
			object obj5 = (nint)0 + (nint)864;
			obj6 = (nint)0 + (nint)856;
			List<object>.Enumerator enumerator = ((List<object>)(object)currentGameServers).GetEnumerator();
			obj4 = 0;
			flag3 = (byte)(int)obj5 != 0;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			SFSConfig sFSConfig = null;
			NullReferenceException ex = new NullReferenceException();
			object obj7 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag4 = !flag3;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			flag3 = (byte)(int)obj6 != 0;
			enumerator2.Dispose();
			object obj8 = default(object);
			if (obj8 == null)
			{
				return;
			}
			ex3 = new OutOfMemoryException();
			object obj7 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2238554");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void UpdateServersButton()
	{
		serversButton.interactable = true;
	}

	private void <ToggleMenu>b__10_0()
	{
		Transform transform = serversButton.transform;
		transform.SetParent(_originalParent, worldPositionStays: true);
	}
}
