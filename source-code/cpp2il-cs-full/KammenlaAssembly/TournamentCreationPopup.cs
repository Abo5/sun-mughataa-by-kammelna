using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Spine;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;
using Util;
using Util.SystemHelpers;

public class TournamentCreationPopup : MonoBehaviour, IInitializable
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<int, string> <>9__114_1;

		public static Func<TournamentAddonModel, TournamentAddonCreationModel> <>9__116_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3464;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal unsafe string <OnConfigChanged>b__114_1(int size)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0276: Expected O, but got I4
			//IL_0030: Expected O, but got Ref
			//IL_0046: Expected I, but got O
			//IL_0056: Expected O, but got I
			//IL_007f: Expected O, but got I
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected O, but got Unknown
			//IL_00f3: Expected O, but got Ref
			//IL_0164: Expected O, but got I8
			//IL_0109: Expected I, but got O
			//IL_0119: Expected O, but got I
			//IL_0142: Expected O, but got I
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Expected O, but got Unknown
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Expected O, but got Unknown
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Expected O, but got Unknown
			//IL_01ee: Expected O, but got I4
			object obj = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj2 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object[] array = default(object[]);
			if (array != null)
			{
				object obj3 = default(object);
				bool flag = obj3 == null;
				int num = default(int);
				object obj4 = (object)(&num);
				IndexOutOfRangeException ex = default(IndexOutOfRangeException);
				object obj5;
				if (!flag)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag2 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
					obj5 = 0;
					if (flag2)
					{
						goto IL_0237;
					}
				}
				if (array.Length != 0)
				{
					object obj6 = array + 32;
					obj6 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object obj7 = default(object);
					bool flag3 = obj7 == null;
					int num3 = default(int);
					obj4 = (object)(&num3);
					if (!flag3)
					{
						nint num4 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v12 (Il2CppClass<System.Object[]>)+40]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag4 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v12 (Il2CppClass<System.Object[]>)+40]");
						obj5 = 0;
						if (flag4)
						{
							goto IL_0237;
						}
					}
					object obj8 = array.Length & 0xFFFFFFFEL;
					if (obj8 != null)
					{
						object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
						object input = "utf-32" + 4048;
						object obj10 = array + 40;
						obj10 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj11 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v23+E4]");
						bool flag5 = (nint)0 == 0;
						object obj12 = !flag5;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						return LocalizationUtil.Localize((string)input, array);
					}
				}
				ex = new IndexOutOfRangeException();
				obj5 = obj4;
				goto IL_0237;
			}
			goto IL_024f;
			IL_0237:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
			OutOfMemoryException ex2 = new OutOfMemoryException();
			goto IL_024f;
			IL_024f:
			return (string)(object)new NullReferenceException();
		}

		internal TournamentAddonCreationModel <SendCreateTournament>b__116_0(TournamentAddonModel addon)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1464;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TournamentAddonCreationModel tournamentAddonCreationModel = default(TournamentAddonCreationModel);
			tournamentAddonCreationModel..ctor(addon);
			return tournamentAddonCreationModel;
		}
	}

	private sealed class <>c__DisplayClass115_0
	{
		public bool isWaiting;

		public TournamentCreationPopup <>4__this;

		public Action <>9__3;

		internal void <CreateTournament>b__0(ISFSObject _)
		{
			isWaiting = false;
			<>4__this.SendCreateTournament();
		}

		internal bool <CreateTournament>b__1()
		{
			return !isWaiting;
		}

		internal void <CreateTournament>b__2()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Expected O, but got Unknown
			//IL_0154: Expected O, but got I
			//IL_015c: Expected I, but got O
			//IL_016a: Expected I, but got O
			//IL_01ad: Expected O, but got I4
			TournamentCreationPopup tournamentCreationPopup = <>4__this;
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object message = "Index = {0} position = {1}" + 1736;
			tournamentCreationPopup.createTournament.interactable = true;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			PopupWindow.ShowError((string)message);
			object obj5 = this + 32;
			Action action = (Action)obj5;
			Action action3;
			if (obj5 != null)
			{
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				nint num = 0;
				Action action2 = null;
				action3 = action;
				if (!flag2)
				{
					goto IL_0113;
				}
			}
			else
			{
				object obj7 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj8 = (nint)0 + (nint)3760;
				nint num = (nint)obj8;
				Action action4 = default(Action);
				action4..ctor(this, (IntPtr)obj8);
				<>9__3 = action4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				action = action4;
				Action action2 = action4;
				action3 = action4;
				if (obj9 != null)
				{
					goto IL_0113;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			action = action3;
			goto IL_0113;
			IL_0113:
			Coroutine coroutine = CoroutineDummy.WaitForSecondsPermanently(3f, action);
		}

		internal void <CreateTournament>b__3()
		{
			if (isWaiting)
			{
				SFS.Disconnect();
			}
		}
	}

	private sealed class <>c__DisplayClass116_0
	{
		public TournamentCreationPopup <>4__this;

		public TournamentCreationModel tournamentCreationModel;

		internal unsafe void <SendCreateTournament>b__1(KammelnaResponseModel<Tournament> response)
		{
			//IL_0b4d: Expected O, but got I4
			//IL_0b5e: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0034: Expected O, but got I4
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_0071: Expected I, but got O
			//IL_0093: Expected O, but got I4
			//IL_0ab8: Expected O, but got I
			//IL_0ae0: Expected I4, but got O
			//IL_00d3: Expected O, but got I4
			//IL_00d8: Expected I, but got O
			//IL_0aff: Expected I4, but got O
			//IL_00f7: Expected O, but got I
			//IL_06e7: Expected O, but got I
			//IL_06fc: Expected I, but got O
			//IL_071e: Expected O, but got I4
			//IL_014a: Expected O, but got I4
			//IL_014f: Expected I, but got O
			//IL_017b: Expected O, but got I4
			//IL_0180: Expected I, but got O
			//IL_0820: Expected O, but got I4
			//IL_01a4: Expected I, but got O
			//IL_01c6: Expected O, but got I4
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Expected O, but got Unknown
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Expected O, but got Unknown
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0210: Expected O, but got Unknown
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Expected O, but got Unknown
			//IL_025f: Expected O, but got I4
			//IL_02af: Expected O, but got I4
			//IL_02c0: Expected I, but got O
			//IL_08ce: Expected F8, but got I4
			//IL_08d7: Expected O, but got I4
			//IL_08df: Expected F8, but got I4
			//IL_08f0: Expected I, but got O
			//IL_08f9: Expected O, but got I4
			//IL_02f1: Expected O, but got I4
			//IL_0302: Expected I, but got O
			//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09bb: Expected O, but got Unknown
			//IL_0354: Expected O, but got I4
			//IL_036d: Expected I, but got O
			//IL_03f8: Expected O, but got I4
			//IL_0401: Expected O, but got I4
			//IL_042a: Expected I, but got O
			//IL_0433: Expected O, but got I4
			//IL_045f: Expected O, but got I4
			//IL_0468: Expected O, but got I4
			//IL_0491: Expected I, but got O
			//IL_049a: Expected O, but got I4
			//IL_04c7: Expected O, but got I
			//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04db: Expected I4, but got Unknown
			//IL_04e7: Expected O, but got I
			//IL_04f0: Expected O, but got I4
			//IL_04f8: Expected F8, but got O
			//IL_0509: Expected I, but got O
			//IL_0747: Expected O, but got I
			//IL_053d: Expected O, but got I4
			//IL_05f6: Expected I, but got O
			//IL_0a04: Expected O, but got I
			//IL_0634: Expected I, but got O
			//IL_0668: Expected O, but got I4
			//IL_06bd: Expected O, but got I4
			//IL_06d6: Expected I, but got O
			TournamentCreationPopup tournamentCreationPopup = <>4__this;
			bool flag = (object)<>4__this == null;
			List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
			KammelnaResponseModel<Tournament> kammelnaResponseModel = response;
			TournamentCreationPopup tournamentCreationPopup2 = (TournamentCreationPopup)152985600;
			object obj7 = default(object);
			if (!flag)
			{
				bool flag2 = (object)tournamentCreationPopup.createTournament == null;
				enumerator = (List<object>.Enumerator)0;
				kammelnaResponseModel = response;
				tournamentCreationPopup2 = (TournamentCreationPopup)152985600;
				if (!flag2)
				{
					tournamentCreationPopup2 = (TournamentCreationPopup)(typeof(System.Buffers.Text.ParserHelpers) + 1432);
					tournamentCreationPopup.createTournament.interactable = true;
					nint num = (nint)tournamentCreationPopup2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v36 (Il2CppClass<TournamentCreationPopup>)+E4]");
					bool flag3 = (nint)0 == 0;
					object obj = !flag3;
					if (obj == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					PopupWindow.SetLoading(loading: false);
					bool flag4 = response == null;
					enumerator = (List<object>.Enumerator)0;
					nint num2 = unchecked((nint)null);
					kammelnaResponseModel = null;
					if (!flag4)
					{
						object obj2 = (nint)0 + (nint)1584;
						kammelnaResponseModel = (KammelnaResponseModel<Tournament>)obj2;
						if (!((KammelnaResponseModel<object>)(object)response).Succeeded)
						{
							object obj3 = (nint)0 + (nint)1568;
							string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
							nint num3 = (nint)tournamentCreationPopup2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v22 (Il2CppClass<TournamentCreationPopup>)+E4]");
							bool flag5 = (nint)0 == 0;
							object obj4 = !flag5;
							if (obj4 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							PopupWindow.ShowError(errorMessage);
							return;
						}
						TournamentCreationPopup tournamentCreationPopup3 = <>4__this;
						bool flag6 = (object)<>4__this == null;
						enumerator = (List<object>.Enumerator)0;
						num2 = unchecked((nint)null);
						if (!flag6)
						{
							bool flag7 = (object)tournamentCreationPopup3.popup == null;
							enumerator = (List<object>.Enumerator)0;
							num2 = unchecked((nint)null);
							if (!flag7)
							{
								tournamentCreationPopup3.popup.SlideOut();
								nint num4 = (nint)tournamentCreationPopup2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v48 (Il2CppClass<TournamentCreationPopup>)+E4]");
								bool flag8 = (nint)0 == 0;
								object obj5 = !flag8;
								if (obj5 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object title = "DNQUALIFIER" + 3784;
								object body = "startPosition" + 3944;
								object obj6 = "com.unity.services.authentication.profile" + 944;
								PopupWindow.ShowInfo((string)title, (string)body, (string)obj6);
								obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
								object obj8 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v51+E4]");
								bool flag9 = (nint)0 == 0;
								object obj9 = !flag9;
								if (obj9 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								string text = Tracker.ItemId(ResourceItemId.TournamentCreate);
								tournamentCreationPopup2 = <>4__this;
								bool flag10 = (object)<>4__this == null;
								enumerator = (List<object>.Enumerator)0;
								ResourceCurrency resourceCurrency = ResourceCurrency.None;
								num2 = (nint)obj6;
								kammelnaResponseModel = null;
								if (!flag10)
								{
									bool flag11 = (object)tournamentCreationPopup2.prizeSelector == null;
									enumerator = (List<object>.Enumerator)0;
									resourceCurrency = ResourceCurrency.None;
									num2 = (nint)obj6;
									kammelnaResponseModel = null;
									if (!flag11)
									{
										int totalPrize = tournamentCreationPopup2.prizeSelector.totalPrize;
										TournamentConfig config = <>4__this.Config;
										bool flag12 = config == null;
										enumerator = (List<object>.Enumerator)0;
										int num5 = totalPrize;
										resourceCurrency = ResourceCurrency.None;
										num2 = (nint)obj6;
										kammelnaResponseModel = null;
										if (!flag12)
										{
											int fixedFeeCost = <>4__this.GetFixedFeeCost();
											float num6 = config.<CreationFee>k__BackingField * (float)totalPrize;
											float num7 = num6 + (float)fixedFeeCost;
											Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Access, text, num7, ResourceCurrency.Aces);
											TournamentCreationModel tournamentCreationModel = this.tournamentCreationModel;
											bool flag13 = this.tournamentCreationModel == null;
											enumerator = (List<object>.Enumerator)0;
											object obj10 = 0;
											int num8 = fixedFeeCost;
											double num9 = num7;
											num5 = totalPrize;
											resourceCurrency = ResourceCurrency.Aces;
											num2 = (nint)text;
											kammelnaResponseModel = (KammelnaResponseModel<Tournament>)3;
											if (!flag13)
											{
												bool flag14 = tournamentCreationModel.addons == null;
												enumerator = (List<object>.Enumerator)0;
												obj10 = 0;
												num8 = fixedFeeCost;
												num9 = num7;
												num5 = totalPrize;
												resourceCurrency = ResourceCurrency.Aces;
												num2 = (nint)text;
												kammelnaResponseModel = (KammelnaResponseModel<Tournament>)3;
												if (!flag14)
												{
													List<object>.Enumerator enumerator2 = ((List<object>)(object)tournamentCreationModel.addons).GetEnumerator();
													tournamentCreationPopup2 = (TournamentCreationPopup)((nint)0 + (nint)2496);
													num5 = typeof(RegisteredWaitHandle) + 56;
													object obj11 = (nint)0 + (nint)2376;
													obj10 = 0;
													List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
													num9 = (double)enumerator3;
													resourceCurrency = ResourceCurrency.Aces;
													num2 = (nint)text;
													List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
													object obj13 = default(object);
													double num11 = default(double);
													int num12;
													while (true)
													{
														kammelnaResponseModel = (KammelnaResponseModel<Tournament>)(object)tournamentCreationPopup2;
														if (!enumerator4.MoveNext())
														{
															break;
														}
														int value = ((int*)num5)->m_value;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v68 (System.Int32)+E4]");
														bool flag15 = (nint)0 == 0;
														object obj12 = !flag15;
														if (obj12 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														RemoteConfigModel current = RemoteConfig.Current;
														if (current != null)
														{
															if (current.<Tournaments>k__BackingField != null)
															{
																Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig> addons = current.<Tournaments>k__BackingField.Addons;
																if (obj13 != null)
																{
																	if (addons != null)
																	{
																		num2 = (nint)obj11;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ stack_-78+10]");
																		object obj14 = ((Dictionary<System.Int32Enum, object>)(object)addons).get_Item((System.Int32Enum)0);
																		if (obj14 != null)
																		{
																			nint num10 = (nint)obj14;
																			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v514 @ X8_v42 (Il2CppClass<System.Object>)+178] (should have been resolved before IL gen)");
																			object obj15 = obj7;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X0_v82+E4]");
																			bool flag16 = (nint)0 == 0;
																			object obj16 = !flag16;
																			if (obj16 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																			}
																			string text2 = Tracker.ItemId(ResourceItemId.TournamentCreate);
																			Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Access, text2, num11, ResourceCurrency.Aces);
																			obj10 = 0;
																			num9 = num11;
																			resourceCurrency = ResourceCurrency.Aces;
																			num2 = (nint)text2;
																			continue;
																		}
																		NullReferenceException ex = new NullReferenceException();
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ stack_-78+10]");
																		kammelnaResponseModel = (KammelnaResponseModel<Tournament>)0;
																	}
																	else
																	{
																		NullReferenceException ex2 = new NullReferenceException();
																		kammelnaResponseModel = null;
																	}
																}
																else
																{
																	NullReferenceException ex3 = new NullReferenceException();
																	kammelnaResponseModel = null;
																}
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
														enumerator = enumerator3;
														num12 = 0;
														num8 = fixedFeeCost;
														goto IL_0b6c;
													}
													object obj17 = (nint)0 + (nint)2488;
													kammelnaResponseModel = (KammelnaResponseModel<Tournament>)obj17;
													enumerator4.Dispose();
													enumerator = enumerator3;
													num12 = 0;
													num8 = fixedFeeCost;
													goto IL_0777;
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
			goto IL_0b6c;
			IL_08fe:
			if ((object)<>4__this != null)
			{
				<>4__this.TrackAnimatedRoomThemeAddon();
				TournamentCreationPopup tournamentCreationPopup4 = <>4__this;
				if ((object)<>4__this != null)
				{
					if (tournamentCreationPopup4.clanId < 1)
					{
						return;
					}
					if ((object)tournamentCreationPopup4.tournamentTypeInput != null)
					{
						int selectedIndex = tournamentCreationPopup4.tournamentTypeInput.SelectedIndex;
						object obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1608;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						Enum enumeration = default(Enum);
						string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
						ClanServerConnector.NotifyActivityCreated(ClanActivityType.Tournament, friendlyName);
						return;
					}
				}
			}
			goto IL_0b6c;
			IL_0b6c:
			NullReferenceException ex6 = new NullReferenceException();
			bool flag17 = (nint)kammelnaResponseModel != 1;
			OutOfMemoryException ex7 = (OutOfMemoryException)(object)ex6;
			if (!flag17)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj19 = (nint)0 + (nint)2488;
				kammelnaResponseModel = (KammelnaResponseModel<Tournament>)obj19;
				enumerator.Dispose();
				object obj20 = default(object);
				bool flag18 = obj20 == null;
				int num12 = (int)obj20;
				if (flag18)
				{
					goto IL_0777;
				}
				ex7 = new OutOfMemoryException();
				num12 = (int)obj20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22393A4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_0777:
			TournamentCreationPopup tournamentCreationPopup5 = <>4__this;
			if ((object)<>4__this != null && (object)tournamentCreationPopup5.prizeSelector != null)
			{
				int totalPrize2 = tournamentCreationPopup5.prizeSelector.totalPrize;
				bool flag19 = totalPrize2 < 1;
				kammelnaResponseModel = null;
				if (flag19)
				{
					goto IL_08fe;
				}
				object obj21 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v27+E4]");
				bool flag20 = (nint)0 == 0;
				object obj22 = !flag20;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text3 = Tracker.ItemId(ResourceItemId.TournamentCreate);
				TournamentCreationPopup tournamentCreationPopup6 = <>4__this;
				bool flag21 = (object)<>4__this == null;
				kammelnaResponseModel = null;
				if (!flag21)
				{
					bool flag22 = (object)tournamentCreationPopup6.prizeSelector == null;
					kammelnaResponseModel = null;
					if (!flag22)
					{
						int totalPrize3 = tournamentCreationPopup6.prizeSelector.totalPrize;
						Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Access, text3, totalPrize3, ResourceCurrency.Aces);
						object obj10 = 0;
						double num9 = totalPrize3;
						ResourceCurrency resourceCurrency = ResourceCurrency.Aces;
						nint num2 = (nint)text3;
						kammelnaResponseModel = (KammelnaResponseModel<Tournament>)3;
						goto IL_08fe;
					}
				}
			}
			goto IL_0b6c;
		}
	}

	private sealed class <>c__DisplayClass131_0
	{
		public TournamentPrizeEditView.ValidationModel validationModel;

		public TournamentCreationPopup <>4__this;

		internal unsafe void <ValidPrize>b__0()
		{
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Expected O, but got Unknown
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected O, but got Unknown
			//IL_00bb: Expected O, but got I4
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Expected O, but got Unknown
			//IL_0195: Expected O, but got I4
			//IL_062e: Expected O, but got I4
			//IL_02ab: Expected O, but got I4
			//IL_02d2: Expected O, but got I4
			//IL_037f: Expected O, but got I4
			//IL_0315: Expected I, but got O
			//IL_0347: Expected O, but got I4
			//IL_039e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Expected O, but got Unknown
			//IL_03ab: Expected O, but got I
			//IL_03cf: Expected O, but got I4
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Expected O, but got Unknown
			//IL_0432: Expected O, but got I4
			//IL_0459: Unknown result type (might be due to invalid IL or missing references)
			//IL_045e: Expected O, but got Unknown
			//IL_046b: Expected I8, but got I4
			//IL_0500: Expected O, but got I8
			//IL_0518: Expected O, but got I4
			//IL_049c: Expected I, but got O
			//IL_04ce: Expected O, but got I4
			//IL_0537: Unknown result type (might be due to invalid IL or missing references)
			//IL_053c: Expected O, but got Unknown
			//IL_0573: Unknown result type (might be due to invalid IL or missing references)
			//IL_0578: Expected O, but got Unknown
			//IL_05a2: Expected O, but got I4
			//IL_0663: Expected O, but got I4
			TournamentPrizeEditView.ValidationModel validationModel = this.validationModel;
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			if (this.validationModel != null)
			{
				if (validationModel.ErrorType <= TournamentPrizeEditView.ValidationModel.ErrorTypeEnum.SecondPrizeBiggerThanFirst)
				{
					if (validationModel.ErrorType != TournamentPrizeEditView.ValidationModel.ErrorTypeEnum.MissingFirstPrize)
					{
						if (validationModel.ErrorType == TournamentPrizeEditView.ValidationModel.ErrorTypeEnum.SecondPrizeBiggerThanFirst)
						{
							string validationErrorMessage = this.validationModel.ValidationErrorMessage;
							object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
							object obj2 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v32+E4]");
							bool flag = (nint)0 == 0;
							object obj3 = !flag;
							if (obj3 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Toast.Show(validationErrorMessage, (Vector2)0, 0f);
						}
						return;
					}
				}
				else if (validationModel.ErrorType != TournamentPrizeEditView.ValidationModel.ErrorTypeEnum.PrizeIsBelowThreshold)
				{
					if (validationModel.ErrorType != TournamentPrizeEditView.ValidationModel.ErrorTypeEnum.NotEnoughAces)
					{
						return;
					}
					TournamentCreationPopup tournamentCreationPopup = <>4__this;
					if ((object)<>4__this != null)
					{
						long creatorBalance = <>4__this.GetCreatorBalance();
						object obj4 = typeof(MemberAchievementClanFeedData) + 2608;
						object obj5 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v29+E4]");
						bool flag2 = (nint)0 == 0;
						object obj6 = !flag2;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						long remaining = tournamentCreationPopup.totalCreationPrice - creatorBalance;
						NotEnoughAcesPopup.ShowNotEnoughAces(remaining, TrackingFeature.Tournament);
						return;
					}
					goto IL_05c0;
				}
				string validationErrorMessage2 = this.validationModel.ValidationErrorMessage;
				object obj7 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				TournamentCreationPopup tournamentCreationPopup2 = <>4__this;
				bool flag3 = (object)<>4__this == null;
				nint num = 2;
				if (!flag3)
				{
					TournamentConfig config = <>4__this.Config;
					KDropMenu sizeInput = tournamentCreationPopup2.sizeInput;
					bool flag4 = (object)tournamentCreationPopup2.sizeInput == null;
					num = 2;
					if (!flag4)
					{
						bool flag5 = config == null;
						num = 2;
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v10 (KDropMenu)+34]");
							int size = config.GetSize(0);
							object obj8 = 153100288 + 1024;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
							object[] array = default(object[]);
							bool flag6 = array == null;
							object obj9 = 0;
							int num2 = default(int);
							num = (nint)(&num2);
							if (!flag6)
							{
								IntPtr intPtr = default(IntPtr);
								bool flag7 = intPtr == (IntPtr)0;
								nint num3 = (nint)(&num2);
								if (!flag7)
								{
									nint num4 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v26 (Il2CppClass<System.Object[]>)+40]");
									num3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag8 = ex == null;
									obj9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v26 (Il2CppClass<System.Object[]>)+40]");
									num = 0;
									if (flag8)
									{
										goto IL_05dc;
									}
								}
								bool flag9 = array.Length == 0;
								obj9 = 0;
								num = num3;
								if (!flag9)
								{
									object obj10 = array + 32;
									obj10 = (nint)intPtr;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									bool flag10 = (object)<>4__this == null;
									obj9 = 0;
									num = intPtr;
									if (flag10)
									{
										goto IL_05c0;
									}
									int minimumPrize = <>4__this.GetMinimumPrize();
									object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
									object obj12 = obj11;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v25+E4]");
									bool flag11 = (nint)0 == 0;
									object obj13 = !flag11;
									if (obj13 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									object input = "AvailableVoices" + 3920;
									string text = LocalizationUtil.Localize((string)input, minimumPrize);
									bool flag12 = text == null;
									nint num5 = minimumPrize;
									if (!flag12)
									{
										nint num6 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v25 (Il2CppClass<System.Object[]>)+40]");
										num5 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										bool flag13 = ex == null;
										obj9 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v25 (Il2CppClass<System.Object[]>)+40]");
										num = 0;
										if (flag13)
										{
											goto IL_05dc;
										}
									}
									object obj14 = array.Length & 0xFFFFFFFEL;
									bool flag14 = obj14 == null;
									obj9 = 0;
									num = num5;
									if (!flag14)
									{
										object obj15 = array + 40;
										obj15 = text;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										LocalizableText text2 = TextMeshProExtensions.LocalizeWith(validationErrorMessage2, array);
										object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
										object obj17 = obj16;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v24+E4]");
										bool flag15 = (nint)0 == 0;
										object obj18 = !flag15;
										if (obj18 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Toast.Show(text2, (Vector2)0, 0f);
										return;
									}
								}
								goto IL_05ce;
							}
						}
					}
				}
			}
			goto IL_05c0;
			IL_05dc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
			throw new OutOfMemoryException();
			IL_05ce:
			ex = new IndexOutOfRangeException();
			goto IL_05dc;
			IL_05c0:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_05ce;
		}
	}

	private sealed class <>c__DisplayClass139_0
	{
		public LocalizableText errorFeedback;

		internal void <ValidateWithFeedback>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0068: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Toast.Show(errorFeedback, (Vector2)0, 0f);
		}
	}

	private sealed class <>c__DisplayClass96_0
	{
		public Color color;

		internal void <OnStartTimeChanged>b__0(Graphic graphic)
		{
			//IL_0010: Expected O, but got I
			//IL_0020: Expected O, but got I
			//IL_003a: Expected O, but got I
			//IL_0042: Expected I, but got O
			//IL_0052: Expected O, but got I
			//IL_0062: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentCreationPopup+<>c__DisplayClass96_0)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentCreationPopup+<>c__DisplayClass96_0)+1C]");
			object obj2 = 0;
			Color color = this.color;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentCreationPopup+<>c__DisplayClass96_0)+14]");
			object obj3 = 0;
			nint num = (nint)graphic;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v1 (Il2CppClass<UnityEngine.UI.Graphic>)+2A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v1 (Il2CppClass<UnityEngine.UI.Graphic>)+2B0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v8 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass99_0
	{
		public TournamentCreationPopup <>4__this;

		public TournamentType newType;

		public TournamentType currentType;

		internal void <OnTournamentTypeClicked>g__Continue|0()
		{
			TournamentCreationPopup tournamentCreationPopup = <>4__this;
			TournamentsCreationPopupEventsChannel eventsChannel = tournamentCreationPopup.eventsChannel;
			eventsChannel.<TournamentType>k__BackingField = newType;
			tournamentCreationPopup.ClearInput();
		}

		internal void <OnTournamentTypeClicked>g__Back|1()
		{
			TournamentCreationPopup tournamentCreationPopup = <>4__this;
			tournamentCreationPopup.tournamentTypeInput.SelectedIndex = (int)currentType;
		}
	}

	private TournamentsCreationPopupEventsChannel eventsChannel;

	private TournamentPrizeEditView prizeEditView;

	private TournamentPrizeSelector prizeSelector;

	private InputFieldTMProUGUI nameInput;

	private InputFieldTMProUGUI passwordInput;

	private ToggleGroupIndexer tournamentTypeInput;

	private ToggleGroupIndexer schedulingMode;

	private InputFieldTMProUGUI startTimeInput;

	private Color originalInputColor;

	private KDropMenu sizeInput;

	private KDropMenu bestOfInput;

	private ToggleGroup watchersChatInput;

	private ToggleGroup chooseTeamInput;

	private ToggleGroup cheatingInput;

	private ToggleGroup speedInput;

	private KRankPicker rankInput;

	private TextMeshProUGUI viewTitleLabel;

	private TextMeshProUGUI instantTimeLabel;

	private DateTimeText timeLabel;

	private GameObject schedulingDisabledMessage;

	private Image cheatingIndicator;

	private Image speedIndicator;

	private Image rankIndicator;

	private Button tournamentOptionsButton;

	private Image schedulingIndicator;

	private TextMeshProUGUI sizeIndicator;

	private TextMeshProUGUI bestOfIndicator;

	private Image watchersChatIndicator;

	private Image chooseTeamIndicator;

	private TextMeshProUGUI feesText;

	private TextMeshProUGUI addonsText;

	private TextMeshProUGUI totalText;

	private TextMeshProUGUI featuresPrizesLabel;

	private Image[] cardBacks;

	private Image roomTheme;

	private SportTeamColorizer sportRoomTheme;

	private Sprite defaultCardBacks;

	private Sprite defaultRoomTheme;

	private Button createTournament;

	public FeaturesBottomSheet addonManager;

	private SlideAnimationHelper popup;

	private RankSprites rankSprites;

	private RoomInfoSprites iconSprites;

	private TournamentSprites tournamentSprites;

	private long totalCreationPrice;

	private int clanId;

	private bool isInstantModeLastOption;

	private bool isWatchersChatLastOption;

	private bool isCheatingAllowedLastOption;

	private bool isChooseTeamAllowedLastOption;

	private int selectedSpeedIndexLastOption;

	private int selectedRankIndexLastOption;

	private int selectedSizeIndexLastOption;

	private int selectedBestOfIndexLastOption;

	private bool IsClanTournament
	{
		get
		{
			//IL_006a: Expected O, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected I4, but got Unknown
			bool flag = clanId < 0;
			bool flag2 = clanId == 0;
			int num = clanId ^ clanId;
			int num2 = clanId & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			return (byte)((flag4 & obj) ? 1 : 0) != 0;
		}
	}

	public int firstPrizeAces
	{
		get
		{
			//IL_0041: Expected I4, but got O
			TournamentPrizeSelector tournamentPrizeSelector = prizeSelector;
			if ((object)prizeSelector != null)
			{
				return tournamentPrizeSelector.firstPrizeAces;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int secondPrizeAces
	{
		get
		{
			//IL_0041: Expected I4, but got O
			TournamentPrizeSelector tournamentPrizeSelector = prizeSelector;
			if ((object)prizeSelector != null)
			{
				return tournamentPrizeSelector.secondPrizeAces;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private bool InstantMode
	{
		get
		{
			//IL_0050: Expected I4, but got O
			if ((object)schedulingMode != null)
			{
				int selectedIndex = schedulingMode.SelectedIndex;
				return selectedIndex == 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private DateTime StartTime
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0182: Expected O, but got I4
			//IL_0115: Expected O, but got I4
			object obj2;
			string text;
			CultureInfo provider;
			if ((object)startTimeInput != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
				obj2 = typeof(DataRelation) + 712;
				text = startTimeInput.Text;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
				CultureInfo cultureInfo;
				if ((nint)0 != 0)
				{
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					object obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v6+E4]");
					bool flag = (nint)0 == 0;
					provider = invariantCulture;
					cultureInfo = invariantCulture;
					if (!flag)
					{
						goto IL_00af;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
					object obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v6+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					provider = invariantCulture2;
					cultureInfo = invariantCulture2;
					if (obj5 != null)
					{
						goto IL_00af;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				provider = cultureInfo;
				goto IL_00af;
			}
			return (DateTime)new NullReferenceException();
			IL_00af:
			if (DateTime.TryParse(text, provider, DateTimeStyles.None, out var result))
			{
				return result;
			}
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v15+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return DateTime.Now;
		}
	}

	private int Size
	{
		get
		{
			//IL_007c: Expected I4, but got O
			TournamentConfig config = Config;
			KDropMenu kDropMenu = sizeInput;
			if ((object)sizeInput != null && config != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X8_v1 (KDropMenu)+34]");
				return config.GetSize(0);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private int BestOf
	{
		get
		{
			//IL_007b: Expected I4, but got O
			KDropMenu kDropMenu = bestOfInput;
			if ((object)bestOfInput != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (KDropMenu)+34]");
				if ((nint)0 == 1)
				{
					return 3;
				}
				return 1;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private int? FinalBestOf
	{
		get
		{
			//IL_0047: Expected O, but got I4
			KDropMenu kDropMenu = bestOfInput;
			if ((object)bestOfInput != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3 (KDropMenu)+34]");
				if ((nint)0 == 2)
				{
					return 3;
				}
				return (int?)(object)0;
			}
			return (int?)new NullReferenceException();
		}
	}

	private bool isChatOpenForWatchers
	{
		get
		{
			int selectedIndex = ToggleGroupExtensions.GetSelectedIndex(watchersChatInput);
			return selectedIndex == 0;
		}
	}

	private bool isChooseTeamsAllowed
	{
		get
		{
			int selectedIndex = ToggleGroupExtensions.GetSelectedIndex(chooseTeamInput);
			return selectedIndex == 0;
		}
	}

	private bool Cheating
	{
		get
		{
			int selectedIndex = ToggleGroupExtensions.GetSelectedIndex(cheatingInput);
			return selectedIndex == 0;
		}
	}

	private TournamentType type
	{
		get
		{
			//IL_0041: Expected I4, but got O
			if ((object)tournamentTypeInput != null)
			{
				return (TournamentType)tournamentTypeInput.SelectedIndex;
			}
			NullReferenceException ex = new NullReferenceException();
			return (TournamentType)ex;
		}
	}

	public string tournamentName
	{
		get
		{
			if ((object)nameInput != null)
			{
				return nameInput.Text;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	private string password
	{
		get
		{
			if ((object)passwordInput != null)
			{
				return passwordInput.Text;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	private PlayerRank.Ranks MinRank
	{
		get
		{
			//IL_0041: Expected I4, but got O
			if ((object)rankInput != null)
			{
				return rankInput.SelectedItem;
			}
			NullReferenceException ex = new NullReferenceException();
			return (PlayerRank.Ranks)ex;
		}
	}

	private int Speed
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00ea: Expected O, but got I4
			//IL_00f3: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EA9]");
			object obj2 = (nint)0 & (nint)1;
			int selectedIndex;
			int selectedIndex2;
			if (obj2 != null)
			{
				selectedIndex = ToggleGroupExtensions.GetSelectedIndex(speedInput);
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v2+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = 0;
				selectedIndex2 = selectedIndex;
				if (!flag)
				{
					goto IL_0094;
				}
			}
			else
			{
				_ = 1;
				selectedIndex = ToggleGroupExtensions.GetSelectedIndex(speedInput);
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v2+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = 0;
				selectedIndex2 = selectedIndex;
				if (obj5 != null)
				{
					goto IL_0094;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return KUtil.GetSpeedIndexValue(selectedIndex2);
			IL_0094:
			return KUtil.GetSpeedIndexValue(selectedIndex);
		}
	}

	public TournamentConfig Config
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0164: Expected O, but got I4
			//IL_016d: Expected O, but got I4
			//IL_020c: Expected O, but got I4
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Expected O, but got Unknown
			//IL_00bd: Expected O, but got I4
			//IL_0223: Expected O, but got I4
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected O, but got Unknown
			if ((object)tournamentTypeInput != null)
			{
				object obj = typeof(RegisteredWaitHandle) + 56;
				if (tournamentTypeInput.SelectedIndex == 0)
				{
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v10+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					object obj4 = 0;
					if (obj3 == null)
					{
						goto IL_017b;
					}
					goto IL_018a;
				}
				if ((object)tournamentTypeInput != null)
				{
					int selectedIndex = tournamentTypeInput.SelectedIndex;
					object obj2 = obj;
					if (selectedIndex != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v10+E4]");
						bool flag2 = (nint)0 == 0;
						object obj5 = !flag2;
						if (obj5 == null)
						{
							object obj4 = 0;
							goto IL_017b;
						}
						goto IL_018a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v10+E4]");
					bool flag3 = (nint)0 == 0;
					object obj6 = !flag3;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					RemoteConfigModel current = RemoteConfig.Current;
					if (current != null && current.<Tournaments>k__BackingField != null)
					{
						return (TournamentConfig)(current.<Tournaments>k__BackingField + 48);
					}
				}
			}
			goto IL_0228;
			IL_017b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			goto IL_018a;
			IL_018a:
			RemoteConfigModel current2 = RemoteConfig.Current;
			if (current2 != null && current2.<Tournaments>k__BackingField != null)
			{
				return (TournamentConfig)(current2.<Tournaments>k__BackingField + 40);
			}
			goto IL_0228;
			IL_0228:
			return (TournamentConfig)(object)new NullReferenceException();
		}
	}

	public long GetCreatorBalance()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_009c: Expected O, but got I4
		//IL_00c5: Expected O, but got I
		//IL_002c: Expected O, but got I4
		//IL_011e: Expected I8, but got O
		//IL_0059: Expected I8, but got I4
		//IL_0110: Expected I8, but got I4
		if (clanId > 0)
		{
			long balance;
			bool flag = TryGetClanVaultBalance(out balance);
			bool flag2 = !flag;
			object obj = !flag2;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				return balance;
			}
			return 0L;
		}
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		if ((object)sessionModel != null)
		{
			User localUser = sessionModel.LocalUser;
			int aces = SFSKammelnaUserExtensions.GetAces(localUser);
			return aces;
		}
		NullReferenceException ex = new NullReferenceException();
		return (long)ex;
	}

	public bool CanCreatorAfford(long cost)
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00ce: Expected O, but got I4
		//IL_00f7: Expected O, but got I
		//IL_01dd: Expected I4, but got O
		//IL_0038: Expected O, but got I8
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected I8, but got Unknown
		//IL_014a: Expected O, but got I8
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected I8, but got Unknown
		//IL_01b7: Expected O, but got I4
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected I4, but got Unknown
		if (clanId >= 1)
		{
			if (TryGetClanVaultBalance(out var balance))
			{
				object obj = balance - cost;
				bool flag = (nint)obj < 0;
				long num = balance ^ cost;
				long num2 = balance ^ obj;
				long num3 = num & num2;
				bool flag2 = num3 < 0;
				return flag == flag2;
			}
			return true;
		}
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		if ((object)sessionModel != null)
		{
			User localUser = sessionModel.LocalUser;
			int aces = SFSKammelnaUserExtensions.GetAces(localUser);
			object obj6 = cost - aces;
			bool flag4 = (nint)obj6 < 0;
			bool flag5 = obj6 == null;
			long num4 = cost ^ aces;
			long num5 = cost ^ obj6;
			long num6 = num4 & num5;
			bool flag6 = num6 < 0;
			bool flag7 = flag4 == flag6;
			object obj7 = !flag7;
			return (byte)((obj7 | flag5) ? 1 : 0) != 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private static bool TryGetClanVaultBalance(out long balance)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0146: Expected O, but got I
		//IL_0160: Expected O, but got I4
		//IL_00a3: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_01d2: Expected I4, but got O
		//IL_0194: Expected O, but got I
		//IL_01b6: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E11]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B5]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B5]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v5+B8]");
		object obj9 = 0;
		CoordinatorVariableBinder coordinatorVariableBinder = (CoordinatorVariableBinder)obj9;
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_00c8;
		}
		goto IL_01c4;
		IL_00c8:
		object scope = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3440;
		object variableName = "utf-32" + 336;
		string current = coordinatorVariableBinder.GetCurrent((string)scope, (string)variableName);
		return long.TryParse(current, out balance);
		IL_01c4:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_008b:
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v13+B8]");
		object obj12 = 0;
		coordinatorVariableBinder = (CoordinatorVariableBinder)obj12;
		if (obj12 != null)
		{
			goto IL_00c8;
		}
		goto IL_01c4;
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0291: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		//IL_0082: Expected O, but got I
		//IL_00ae: Expected I, but got O
		//IL_00bf: Expected O, but got I
		//IL_00eb: Expected I, but got O
		//IL_00fc: Expected O, but got I
		//IL_0128: Expected I, but got O
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_014d: Expected O, but got I
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_016d: Expected O, but got I
		//IL_0199: Expected I, but got O
		//IL_01c3: Expected O, but got I4
		//IL_0206: Expected I, but got O
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_0249: Expected O, but got I
		//IL_0261: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3456;
		object obj4 = (nint)0 + (nint)1528;
		startTimeInput.OnValueChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InputField.OnValidateInput onValidateInput = default(InputField.OnValidateInput);
		onValidateInput..ctor(null, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)760;
		nameInput.OnValidateInput += onValidateInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj5);
		object obj6 = (nint)0 + (nint)768;
		nameInput.OnValueChanged += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj6);
		object obj7 = (nint)0 + (nint)776;
		passwordInput.OnEndEdit += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj7);
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)752;
		object obj10 = typeof(RegisteredWaitHandle) + 56;
		object obj11 = (nint)0 + (nint)792;
		passwordInput.OnValueChanged += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj9);
		object obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v21+E4]");
		bool flag = (nint)0 == 0;
		object obj13 = !flag;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action6 = default(Action);
		action6..ctor(this, (IntPtr)obj11);
		eventsChannel.OnRefreshView += action6;
		Button button = createTournament;
		object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj15 = (nint)0 + (nint)744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj15);
		button.m_OnClick.AddListener(unityAction);
	}

	public void Initialize()
	{
		clanId = 0;
		popup.SlideIn();
		TournamentsCreationPopupEventsChannel tournamentsCreationPopupEventsChannel = eventsChannel;
		tournamentsCreationPopupEventsChannel.<TournamentType>k__BackingField = TournamentType.Public;
		tournamentTypeInput.SetIsOnWithoutNotify(0);
		ClearInput();
	}

	public void Initialize(TournamentType popupType)
	{
		clanId = 0;
		popup.SlideIn();
		TournamentsCreationPopupEventsChannel tournamentsCreationPopupEventsChannel = eventsChannel;
		tournamentsCreationPopupEventsChannel.<TournamentType>k__BackingField = popupType;
		tournamentTypeInput.SetIsOnWithoutNotify((int)popupType);
		ClearInput();
	}

	public void Initialize(TournamentType popupType, int scopedClanId)
	{
		clanId = scopedClanId;
		popup.SlideIn();
		TournamentsCreationPopupEventsChannel tournamentsCreationPopupEventsChannel = eventsChannel;
		tournamentsCreationPopupEventsChannel.<TournamentType>k__BackingField = popupType;
		tournamentTypeInput.SetIsOnWithoutNotify((int)popupType);
		ClearInput();
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_008f: Expected O, but got I
		//IL_00a7: Expected I, but got O
		//IL_00d1: Expected O, but got I4
		//IL_006e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)752;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		object obj4 = (nint)0 + (nint)792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		eventsChannel.OnRefreshView -= action2;
	}

	private unsafe void OnStartTimeChanged(string value)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_135d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1362: Expected O, but got Unknown
		//IL_079f: Expected O, but got I4
		//IL_00c8: Expected O, but got Ref
		//IL_0117: Expected O, but got I4
		//IL_0173: Expected O, but got Ref
		//IL_0253: Expected O, but got Ref
		//IL_0201: Expected O, but got Ref
		//IL_026b: Expected F8, but got O
		//IL_028b: Expected O, but got Ref
		//IL_02bf: Expected O, but got Ref
		//IL_0802: Expected O, but got I
		//IL_081c: Expected O, but got I4
		//IL_031e: Expected O, but got I
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected O, but got Unknown
		//IL_087e: Expected O, but got I4
		//IL_125e: Expected F8, but got I
		//IL_126e: Expected F8, but got I
		//IL_127e: Expected O, but got I
		//IL_128e: Expected O, but got I4
		//IL_0bb9: Expected O, but got I
		//IL_0bd3: Expected O, but got I4
		//IL_0b22: Expected O, but got I
		//IL_03fe: Expected O, but got Ref
		//IL_12be: Expected O, but got I
		//IL_12d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12dc: Expected O, but got Unknown
		//IL_0b73: Expected O, but got I4
		//IL_12f7: Expected O, but got I
		//IL_1308: Expected I, but got O
		//IL_0c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Expected O, but got Unknown
		//IL_0c6e: Expected O, but got I4
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_0461: Expected O, but got Ref
		//IL_046a: Expected O, but got I4
		//IL_0c99: Expected F8, but got I4
		//IL_0cdc: Expected F8, but got I4
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		//IL_04f5: Expected O, but got I4
		//IL_0d0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0f: Expected O, but got Unknown
		//IL_0d37: Expected F8, but got I4
		//IL_0d49: Expected O, but got I4
		//IL_13fb: Expected O, but got Ref
		//IL_0d75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7a: Expected O, but got Unknown
		//IL_0da5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daa: Expected O, but got Unknown
		//IL_0dd4: Expected O, but got I4
		//IL_05d0: Expected O, but got Ref
		//IL_14ef: Expected F8, but got I4
		//IL_053c: Expected I, but got O
		//IL_054c: Expected O, but got I
		//IL_0583: Expected O, but got Ref
		//IL_0593: Expected O, but got I
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected O, but got Unknown
		//IL_1438: Expected O, but got I4
		//IL_0e96: Expected F8, but got I4
		//IL_0656: Expected O, but got I4
		//IL_0e1b: Expected I, but got O
		//IL_0e2b: Expected O, but got I
		//IL_0e51: Expected F8, but got I4
		//IL_0e6a: Expected O, but got I
		//IL_0ebe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Expected O, but got Unknown
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected O, but got Unknown
		//IL_1531: Expected F8, but got I4
		//IL_0902: Expected O, but got I4
		//IL_091c: Expected O, but got I4
		//IL_0925: Expected O, but got I4
		//IL_070d: Expected O, but got I4
		//IL_071f: Expected O, but got I4
		//IL_0f04: Expected O, but got I4
		//IL_09c3: Expected O, but got I8
		//IL_0943: Expected I, but got O
		//IL_0953: Expected O, but got I
		//IL_09a1: Expected O, but got I
		//IL_0f2f: Expected F8, but got I4
		//IL_0f5d: Expected O, but got I4
		//IL_0747: Expected O, but got I4
		//IL_0750: Expected O, but got I4
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Expected O, but got Unknown
		//IL_0a2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a34: Expected O, but got Unknown
		//IL_0fb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb6: Expected O, but got Unknown
		//IL_0a59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5e: Expected O, but got Unknown
		//IL_0a88: Expected O, but got I4
		//IL_1459: Expected O, but got I4
		//IL_1469: Expected F8, but got I
		//IL_147f: Expected O, but got I4
		//IL_10ab: Expected O, but got I4
		//IL_10c5: Expected O, but got I4
		//IL_10ce: Expected O, but got I4
		//IL_1014: Expected O, but got I4
		//IL_1026: Expected O, but got I4
		//IL_116c: Expected O, but got I8
		//IL_10ec: Expected I, but got O
		//IL_10fc: Expected O, but got I
		//IL_114a: Expected O, but got I
		//IL_104e: Expected O, but got I4
		//IL_1057: Expected O, but got I4
		//IL_11b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11bc: Expected O, but got Unknown
		//IL_11d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11dd: Expected O, but got Unknown
		//IL_1202: Unknown result type (might be due to invalid IL or missing references)
		//IL_1207: Expected O, but got Unknown
		//IL_1231: Expected O, but got I4
		//IL_1563: Expected O, but got I4
		//IL_1573: Expected F8, but got I
		//IL_1589: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3504;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
		object obj3 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v4+E4]");
		CultureInfo cultureInfo;
		CultureInfo cultureInfo2;
		if ((nint)0 != 0)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			cultureInfo = invariantCulture;
			cultureInfo2 = invariantCulture;
			if (!flag)
			{
				goto IL_0073;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			cultureInfo = invariantCulture2;
			cultureInfo2 = invariantCulture2;
			if (obj7 != null)
			{
				goto IL_0073;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		cultureInfo = cultureInfo2;
		goto IL_0073;
		IL_13a2:
		DateTime dateTime;
		TournamentConfig config;
		IFormatProvider formatProvider;
		if ((object)schedulingMode != null)
		{
			int selectedIndex = schedulingMode.SelectedIndex;
			bool flag3 = selectedIndex == 0;
			formatProvider = null;
			if (flag3)
			{
				goto IL_14a7;
			}
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X0_v48+E4]");
			DateTime dateTime2;
			if ((nint)0 != 0)
			{
				DateTime now = DateTime.Now;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EB1]");
				object obj9 = (nint)0 & (nint)1;
				bool flag4 = obj9 == null;
				dateTime = now;
				dateTime2 = now;
				if (!flag4)
				{
					goto IL_0b4f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				DateTime now2 = DateTime.Now;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EB1]");
				object obj10 = (nint)0 & (nint)1;
				bool flag5 = obj10 == null;
				object obj11 = !flag5;
				dateTime = now2;
				dateTime2 = now2;
				if (obj11 != null)
				{
					goto IL_0b4f;
				}
			}
			_ = 1;
			config = Config;
			bool flag6 = config == null;
			dateTime = dateTime2;
			formatProvider = null;
			if (!flag6)
			{
				goto IL_0c30;
			}
		}
		goto IL_131c;
		IL_0c30:
		object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X0_v50+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan = TimeSpan.FromSeconds(config.<MaxStartTime>k__BackingField);
		DateTime dateTime3 = dateTime + timeSpan;
		DateTime result;
		bool flag8 = result > dateTime3;
		bool flag9 = !flag8;
		double num = config.<MaxStartTime>k__BackingField;
		DateTimeStyles dateTimeStyles = DateTimeStyles.None;
		formatProvider = (IFormatProvider)dateTime3;
		object[] array = default(object[]);
		TimeSpan timeSpan4 = default(TimeSpan);
		string text2;
		DateTimeStyles dateTimeStyles2;
		object obj29;
		IFormatProvider formatProvider3;
		string text3;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj28;
		if (!flag9)
		{
			object obj15 = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			bool flag10 = (object)tournamentTypeInput == null;
			num = config.<MaxStartTime>k__BackingField;
			dateTimeStyles = DateTimeStyles.None;
			formatProvider = (IFormatProvider)2;
			if (!flag10)
			{
				int selectedIndex2 = tournamentTypeInput.SelectedIndex;
				object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1608;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				Enum enumeration = default(Enum);
				string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
				object obj17 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v31+E4]");
				bool flag11 = (nint)0 == 0;
				object obj19 = !flag11;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text = LocalizationUtil.Localize(friendlyName);
				bool flag12 = array == null;
				num = config.<MaxStartTime>k__BackingField;
				dateTimeStyles = DateTimeStyles.None;
				formatProvider = null;
				if (!flag12)
				{
					bool flag13 = text == null;
					IFormatProvider formatProvider2 = null;
					if (!flag13)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v51 (Il2CppClass<System.Object[]>)+40]");
						formatProvider2 = (IFormatProvider)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag14 = ex == null;
						num = config.<MaxStartTime>k__BackingField;
						dateTimeStyles = DateTimeStyles.None;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v51 (Il2CppClass<System.Object[]>)+40]");
						formatProvider = (IFormatProvider)0;
						if (flag14)
						{
							goto IL_1338;
						}
					}
					bool flag15 = array.Length == 0;
					num = config.<MaxStartTime>k__BackingField;
					dateTimeStyles = DateTimeStyles.None;
					formatProvider = formatProvider2;
					if (flag15)
					{
						goto IL_132a;
					}
					object obj20 = array + 32;
					obj20 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					TournamentConfig config2 = Config;
					bool flag16 = config2 == null;
					num = config.<MaxStartTime>k__BackingField;
					dateTimeStyles = DateTimeStyles.None;
					formatProvider = (IFormatProvider)(object)text;
					if (!flag16)
					{
						object obj21 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X0_v74+E4]");
						bool flag17 = (nint)0 == 0;
						object obj22 = !flag17;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						TimeSpan timeSpan2 = TimeSpan.FromSeconds(config2.<MaxStartTime>k__BackingField);
						object obj23 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X0_v78+E4]");
						bool flag18 = (nint)0 == 0;
						object obj24 = !flag18;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						TimeSpan ts = TimeSpan.FromSeconds(2.0);
						TimeSpan timeSpan3 = timeSpan4.Add(ts);
						object obj25 = typeof(DataRelation) + 824;
						object obj26 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X8_v40+E4]");
						if ((nint)0 != 0)
						{
							string durationText = DateTimeUtil.GetDurationText(timeSpan3);
							bool flag19 = durationText == null;
							object obj27 = !flag19;
							dateTimeStyles = DateTimeStyles.AllowInnerWhite;
							obj28 = 0;
							text2 = durationText;
							if (obj27 != null)
							{
								goto IL_10e4;
							}
							dateTimeStyles2 = DateTimeStyles.AllowInnerWhite;
							obj29 = 0;
							formatProvider3 = (IFormatProvider)2;
							text3 = durationText;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							string durationText2 = DateTimeUtil.GetDurationText(timeSpan3);
							bool flag20 = durationText2 == null;
							dateTimeStyles = DateTimeStyles.AllowInnerWhite;
							obj28 = 0;
							text2 = durationText2;
							dateTimeStyles2 = DateTimeStyles.AllowInnerWhite;
							obj29 = 0;
							formatProvider3 = (IFormatProvider)2;
							text3 = durationText2;
							if (!flag20)
							{
								goto IL_10e4;
							}
						}
						goto IL_1158;
					}
				}
			}
			goto IL_131c;
		}
		goto IL_14a7;
		IL_131c:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_132a;
		IL_0073:
		if (!DateTime.TryParse(value, cultureInfo, DateTimeStyles.None, out result))
		{
			return;
		}
		bool flag21 = (object)timeLabel == null;
		dateTimeStyles = DateTimeStyles.None;
		obj28 = (object)(&result);
		formatProvider = cultureInfo;
		DateTime dateTime4;
		DateTime dateTime5;
		object obj36;
		object obj39;
		object obj37;
		if (!flag21)
		{
			GameObject gameObject = timeLabel.gameObject;
			object obj30 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v24+E4]");
			bool flag22 = (nint)0 == 0;
			object obj31 = !flag22;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now3 = DateTime.Now;
			bool active = result > now3;
			bool flag23 = (object)gameObject == null;
			dateTimeStyles = DateTimeStyles.None;
			obj28 = (object)(&result);
			formatProvider = (IFormatProvider)now3;
			if (!flag23)
			{
				gameObject.SetActive(active);
				DateTime now4 = DateTime.Now;
				bool flag24 = result >= now4;
				bool flag25 = !flag24;
				dateTimeStyles = DateTimeStyles.None;
				formatProvider = (IFormatProvider)now4;
				if (!flag25)
				{
					bool flag26 = (object)timeLabel == null;
					dateTimeStyles = DateTimeStyles.None;
					obj28 = (object)(&result);
					formatProvider = (IFormatProvider)now4;
					if (flag26)
					{
						goto IL_131c;
					}
					timeLabel.SetDate(result);
					dateTimeStyles = DateTimeStyles.None;
					formatProvider = (IFormatProvider)result;
				}
				bool flag27 = obj4 == null;
				obj28 = (object)(&result);
				if (!flag27)
				{
					num = (double)originalInputColor;
					_ = originalInputColor;
					bool flag28 = (object)schedulingMode == null;
					obj28 = (object)(&result);
					if (!flag28)
					{
						int selectedIndex3 = schedulingMode.SelectedIndex;
						bool flag29 = selectedIndex3 == 0;
						obj28 = (object)(&result);
						formatProvider = null;
						if (!flag29)
						{
							object obj32 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v127+E4]");
							if ((nint)0 != 0)
							{
								DateTime now5 = DateTime.Now;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EB0]");
								object obj33 = (nint)0 & (nint)1;
								bool flag30 = obj33 == null;
								dateTime4 = now5;
								dateTime5 = now5;
								if (!flag30)
								{
									goto IL_034b;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								DateTime now6 = DateTime.Now;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EB0]");
								object obj34 = (nint)0 & (nint)1;
								bool flag31 = obj34 == null;
								object obj35 = !flag31;
								dateTime4 = now6;
								dateTime5 = now6;
								if (obj35 != null)
								{
									goto IL_034b;
								}
							}
							_ = 1;
							obj36 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
							obj37 = obj36;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X0_v128+E4]");
							bool flag32 = (nint)0 == 0;
							object obj38 = !flag32;
							dateTime4 = dateTime5;
							obj39 = obj36;
							if (obj38 != null)
							{
								goto IL_039c;
							}
							goto IL_089c;
						}
						goto IL_13a2;
					}
				}
			}
		}
		goto IL_131c;
		IL_034b:
		obj36 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		obj37 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X0_v128+E4]");
		bool flag33 = (nint)0 == 0;
		obj39 = obj36;
		dateTime5 = dateTime4;
		if (!flag33)
		{
			goto IL_039c;
		}
		goto IL_089c;
		IL_089c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj36 = obj39;
		dateTime4 = dateTime5;
		goto IL_039c;
		IL_14a7:
		object obj40;
		double num3;
		if ((object)startTimeInput != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+18]");
			num3 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+10]");
			num = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+14]");
			obj40 = 0;
			startTimeInput.TextColor = (Color)0;
			bool flag34 = (object)timeLabel == null;
			formatProvider = null;
			if (!flag34)
			{
				object obj41 = (nint)0 + (nint)688;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31C20");
				object obj42 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2184;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj43 = (nint)0 + (nint)3792;
				Action<object> action = default(Action<object>);
				action..ctor(obj4, (IntPtr)obj43);
				IEnumerable<object> enumeration2 = default(IEnumerable<object>);
				ArraysExtensions.ForEach(enumeration2, action);
				return;
			}
		}
		goto IL_131c;
		IL_039c:
		TimeSpan timeSpan5 = TimeSpan.FromHours(1.0);
		DateTime dateTime6 = dateTime4 + timeSpan5;
		bool flag35 = result < dateTime6;
		bool flag36 = !flag35;
		num = 1.0;
		dateTimeStyles = DateTimeStyles.None;
		obj28 = (object)(&result);
		formatProvider = (IFormatProvider)dateTime6;
		object[] array2 = default(object[]);
		string text5;
		DateTimeStyles dateTimeStyles3;
		object obj57;
		IFormatProvider formatProvider5;
		string text6;
		if (!flag36)
		{
			object obj44 = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			bool flag37 = (object)tournamentTypeInput == null;
			num = 1.0;
			dateTimeStyles = DateTimeStyles.None;
			obj28 = (object)(&result);
			formatProvider = (IFormatProvider)2;
			if (!flag37)
			{
				int selectedIndex4 = tournamentTypeInput.SelectedIndex;
				object obj45 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1608;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				Enum enumeration3 = default(Enum);
				string friendlyName2 = EnumExtensions.GetFriendlyName(enumeration3);
				object obj46 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
				object obj47 = obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v70+E4]");
				bool flag38 = (nint)0 == 0;
				object obj48 = !flag38;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text4 = LocalizationUtil.Localize(friendlyName2);
				bool flag39 = array2 == null;
				num = 1.0;
				dateTimeStyles = DateTimeStyles.None;
				obj28 = (object)(&result);
				formatProvider = null;
				if (!flag39)
				{
					bool flag40 = text4 == null;
					IFormatProvider formatProvider4 = null;
					if (!flag40)
					{
						nint num4 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v90 (Il2CppClass<System.Object[]>)+40]");
						formatProvider4 = (IFormatProvider)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag41 = ex == null;
						num = 1.0;
						dateTimeStyles = DateTimeStyles.None;
						obj28 = (object)(&result);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v90 (Il2CppClass<System.Object[]>)+40]");
						formatProvider = (IFormatProvider)0;
						if (flag41)
						{
							goto IL_1338;
						}
					}
					bool flag42 = array2.Length == 0;
					num = 1.0;
					dateTimeStyles = DateTimeStyles.None;
					obj28 = (object)(&result);
					formatProvider = formatProvider4;
					if (!flag42)
					{
						object obj49 = array2 + 32;
						obj49 = text4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj50 = obj36;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X0_v159+E4]");
						bool flag43 = (nint)0 == 0;
						object obj51 = !flag43;
						if (obj51 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						TimeSpan timeSpan6 = TimeSpan.FromHours(1.0);
						object obj52 = obj36;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X0_v163+E4]");
						bool flag44 = (nint)0 == 0;
						object obj53 = !flag44;
						if (obj53 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						TimeSpan ts2 = TimeSpan.FromSeconds(2.0);
						TimeSpan timeSpan7 = timeSpan4.Add(ts2);
						object obj54 = typeof(DataRelation) + 824;
						object obj55 = obj54;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X8_v79+E4]");
						if ((nint)0 != 0)
						{
							string durationText3 = DateTimeUtil.GetDurationText(timeSpan7);
							bool flag45 = durationText3 == null;
							object obj56 = !flag45;
							dateTimeStyles = DateTimeStyles.AllowInnerWhite;
							obj28 = 0;
							text5 = durationText3;
							if (obj56 != null)
							{
								goto IL_093b;
							}
							dateTimeStyles3 = DateTimeStyles.AllowInnerWhite;
							obj57 = 0;
							formatProvider5 = (IFormatProvider)2;
							text6 = durationText3;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							string durationText4 = DateTimeUtil.GetDurationText(timeSpan7);
							bool flag46 = durationText4 == null;
							dateTimeStyles = DateTimeStyles.AllowInnerWhite;
							obj28 = 0;
							text5 = durationText4;
							dateTimeStyles3 = DateTimeStyles.AllowInnerWhite;
							obj57 = 0;
							formatProvider5 = (IFormatProvider)2;
							text6 = durationText4;
							if (!flag46)
							{
								goto IL_093b;
							}
						}
						goto IL_09af;
					}
					goto IL_132a;
				}
			}
			goto IL_131c;
		}
		goto IL_13a2;
		IL_132a:
		ex = new IndexOutOfRangeException();
		goto IL_1338;
		IL_1158:
		object obj58 = array.Length & 0xFFFFFFFEL;
		bool flag47 = obj58 == null;
		num = 2.0;
		dateTimeStyles = dateTimeStyles2;
		obj28 = obj29;
		formatProvider = formatProvider3;
		if (flag47)
		{
			goto IL_132a;
		}
		object obj59 = array + 40;
		obj59 = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object text7 = "startPosition" + 3592;
		LocalizableText text8 = TextMeshProExtensions.LocalizeWith((string)text7, array);
		object obj60 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj61 = obj60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v47+E4]");
		bool flag48 = (nint)0 == 0;
		object obj62 = !flag48;
		if (obj62 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show(text8, (Vector2)0, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70E1320]");
		num = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70E1320]");
		_ = 0;
		obj40 = 0;
		num3 = 4.0;
		dateTimeStyles = DateTimeStyles.None;
		obj28 = obj29;
		formatProvider = null;
		goto IL_14a7;
		IL_10e4:
		nint num5 = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v49 (Il2CppClass<System.Object[]>)+40]");
		formatProvider3 = (IFormatProvider)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		bool flag49 = ex == null;
		dateTimeStyles2 = dateTimeStyles;
		obj29 = obj28;
		text3 = text2;
		num = 2.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v49 (Il2CppClass<System.Object[]>)+40]");
		formatProvider = (IFormatProvider)0;
		if (!flag49)
		{
			goto IL_1158;
		}
		goto IL_1338;
		IL_093b:
		nint num6 = (nint)array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v88 (Il2CppClass<System.Object[]>)+40]");
		formatProvider5 = (IFormatProvider)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		bool flag50 = ex == null;
		dateTimeStyles3 = dateTimeStyles;
		obj57 = obj28;
		text6 = text5;
		num = 2.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v88 (Il2CppClass<System.Object[]>)+40]");
		formatProvider = (IFormatProvider)0;
		if (!flag50)
		{
			goto IL_09af;
		}
		goto IL_1338;
		IL_0b4f:
		config = Config;
		bool flag51 = config == null;
		object obj63 = !flag51;
		if (obj63 != null)
		{
			goto IL_0c30;
		}
		formatProvider = null;
		goto IL_131c;
		IL_09af:
		object obj64 = array2.Length & 0xFFFFFFFEL;
		bool flag52 = obj64 == null;
		num = 2.0;
		dateTimeStyles = dateTimeStyles3;
		obj28 = obj57;
		formatProvider = formatProvider5;
		if (flag52)
		{
			goto IL_132a;
		}
		object obj65 = array2 + 40;
		obj65 = text6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object text9 = "startPosition" + 3584;
		LocalizableText text10 = TextMeshProExtensions.LocalizeWith((string)text9, array2);
		object obj66 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj67 = obj66;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X8_v86+E4]");
		bool flag53 = (nint)0 == 0;
		object obj68 = !flag53;
		if (obj68 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show(text10, (Vector2)0, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70E1320]");
		num = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70E1320]");
		_ = 0;
		obj40 = 0;
		num3 = 4.0;
		dateTimeStyles = DateTimeStyles.None;
		obj28 = obj57;
		formatProvider = null;
		goto IL_13a2;
		IL_1338:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void OnNameChanged(string newName)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		string text = nameInput.Text;
		object obj = eventsChannel + 24;
		obj = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void OnTournamentSizeChanged(int _)
	{
		TournamentConfig config = Config;
		KDropMenu kDropMenu = sizeInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v1 (KDropMenu)+34]");
		int size = config.GetSize(0);
		int num = default(int);
		string text = num.ToString();
		sizeIndicator.SetText(text);
		OnPrizeChanged();
	}

	public void OnTournamentTypeClicked(int _)
	{
		//IL_0010: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected O, but got Unknown
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Expected O, but got Unknown
		//IL_070a: Expected O, but got I
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_007c: Expected O, but got I4
		//IL_00c9: Expected O, but got I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0147: Expected I, but got O
		//IL_0157: Expected O, but got I
		//IL_0209: Expected O, but got I4
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_02b1: Expected O, but got I
		//IL_0192: Expected O, but got I
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected O, but got Unknown
		//IL_07c0: Expected O, but got I
		//IL_07d1: Expected I, but got O
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected O, but got Unknown
		//IL_02ec: Expected O, but got I
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_038c: Expected O, but got I4
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_03ce: Expected O, but got I
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_083f: Expected O, but got I
		//IL_0850: Expected I, but got O
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_085f: Expected O, but got Unknown
		//IL_0409: Expected O, but got I
		//IL_04a1: Expected O, but got I4
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_04cf: Expected O, but got I
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		//IL_0587: Expected O, but got I4
		//IL_050a: Expected O, but got I
		//IL_05a5: Expected I, but got O
		//IL_05b5: Expected O, but got I
		//IL_0653: Expected O, but got I
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected O, but got Unknown
		//IL_06a4: Expected O, but got I4
		//IL_06ad: Expected O, but got I4
		//IL_05f0: Expected O, but got I
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		//IL_08bd: Expected O, but got I4
		//IL_08c5: Expected O, but got I
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected O, but got Unknown
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E16]");
		TournamentsCreationPopupEventsChannel tournamentsCreationPopupEventsChannel = (TournamentsCreationPopupEventsChannel)0;
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3512;
		object obj2 = default(object);
		object obj8 = default(object);
		object obj10 = default(object);
		object obj17 = default(object);
		object obj20 = default(object);
		Action action = default(Action);
		object obj23 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		object obj35 = default(object);
		TournamentsCreationPopupEventsChannel tournamentsCreationPopupEventsChannel2 = default(TournamentsCreationPopupEventsChannel);
		Action action2 = default(Action);
		object obj45 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2..ctor();
			object obj7;
			if (obj2 != null)
			{
				object obj3 = obj2 + 16;
				obj3 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				tournamentsCreationPopupEventsChannel = eventsChannel;
				if ((object)eventsChannel != null)
				{
					tournamentsCreationPopupEventsChannel = (TournamentsCreationPopupEventsChannel)tournamentsCreationPopupEventsChannel.<TournamentType>k__BackingField;
					TournamentType <TournamentType>k__BackingField = tournamentsCreationPopupEventsChannel.<TournamentType>k__BackingField;
					if ((object)tournamentTypeInput != null)
					{
						int selectedIndex = tournamentTypeInput.SelectedIndex;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Object)+1C]");
						tournamentsCreationPopupEventsChannel = (TournamentsCreationPopupEventsChannel)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Object)+1C]");
						if ((nint)0 == selectedIndex)
						{
							break;
						}
						IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
						if (popupWindowBuilderNeedsTitle != null)
						{
							object obj4 = typeof(System.IOAsyncCallback) + 392;
							object obj5 = "Added Tournament Prizes And Features" + 2208;
							nint num = (nint)popupWindowBuilderNeedsTitle;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v14 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
							object obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v14 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_01db;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v14 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
							obj7 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X10_v12-8]");
								if (0 == (nint)obj4)
								{
									break;
								}
								obj8 = obj7 + 16;
								obj6--;
								bool flag = (nint)obj6 != 1;
								obj7 = obj8;
								if (flag)
								{
									continue;
								}
								goto IL_01db;
							}
							object obj9 = num + obj7;
							tournamentsCreationPopupEventsChannel = (TournamentsCreationPopupEventsChannel)(obj9 + 312);
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v273 @ X8_v3 (TournamentsCreationPopupEventsChannel)] (should have been resolved before IL gen)");
							bool flag2 = obj10 == null;
							obj8 = obj7;
							if (!flag2)
							{
								goto IL_0276;
							}
						}
					}
				}
			}
			goto IL_06bb;
			IL_06c9:
			object obj11 = obj8 + 9;
			object obj12 = (object)tournamentsCreationPopupEventsChannel + obj11;
			object obj13 = obj12 + 312;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v5+8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v281 @ X2_v2 (should have been resolved before IL gen)");
			continue;
			IL_0631:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v29+8]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v298 @ X2_v15 (should have been resolved before IL gen)");
			goto IL_065d;
			IL_0335:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj19 = obj20;
			goto IL_078c;
			IL_078c:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v497 @ X8_v21] (should have been resolved before IL gen)");
			object obj21 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj22 = (nint)0 + (nint)3808;
			action..ctor(obj2, (IntPtr)obj22);
			tournamentsCreationPopupEventsChannel = (TournamentsCreationPopupEventsChannel)(object)("com.unity.services.authentication.profile" + 944);
			PopupButton popupButton = PopupButton.Neutral((string)(object)tournamentsCreationPopupEventsChannel, action, dismiss: true);
			bool flag3 = obj23 == null;
			object obj24 = 0;
			obj8 = obj7;
			if (flag3)
			{
				goto IL_06bb;
			}
			object obj25 = typeof(System.IOAsyncCallback) + 368;
			object obj26 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v26+12E]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v26+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0452;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v26+B0]");
			object obj28 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X10_v20-8]");
				if (0 == (nint)obj25)
				{
					break;
				}
				obj7 = obj28 + 16;
				obj27--;
				bool flag4 = (nint)obj27 != 1;
				obj28 = obj7;
				if (flag4)
				{
					continue;
				}
				goto IL_0452;
			}
			object obj29 = obj26 + obj28;
			object obj30 = obj29 + 312;
			obj7 = obj28;
			goto IL_081f;
			IL_065d:
			object obj32;
			object obj31 = obj32 + obj8;
			object obj33 = obj31 + 312;
			tournamentsCreationPopupEventsChannel = (TournamentsCreationPopupEventsChannel)obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v622 @ X0_v35] (should have been resolved before IL gen)");
			bool flag5 = ex == null;
			object obj34 = !flag5;
			obj24 = 0;
			if (obj34 != null)
			{
				goto IL_059d;
			}
			goto IL_06bb;
			IL_0553:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			tournamentsCreationPopupEventsChannel = (TournamentsCreationPopupEventsChannel)obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v607 @ X0_v32] (should have been resolved before IL gen)");
			bool flag6 = ex == null;
			obj24 = 0;
			obj8 = obj7;
			if (!flag6)
			{
				goto IL_059d;
			}
			goto IL_06bb;
			IL_059d:
			nint num2 = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v35 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v35 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v35 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj8 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v27-8]");
					bool flag7 = 0 == (nint)obj25;
					obj24 = 0;
					tournamentsCreationPopupEventsChannel = (TournamentsCreationPopupEventsChannel)num2;
					if (flag7)
					{
						break;
					}
					obj8 += 16;
					obj36--;
					if ((nint)obj36 != 1)
					{
						continue;
					}
					goto IL_0631;
				}
				goto IL_06c9;
			}
			goto IL_0631;
			IL_06bb:
			ex = new NullReferenceException();
			goto IL_06c9;
			IL_01db:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v393 @ X0_v43 (TournamentsCreationPopupEventsChannel)] (should have been resolved before IL gen)");
			bool flag8 = obj10 == null;
			object obj37 = !flag8;
			obj7 = obj8;
			if (obj37 != null)
			{
				goto IL_0276;
			}
			tournamentsCreationPopupEventsChannel = tournamentsCreationPopupEventsChannel2;
			goto IL_06bb;
			IL_0452:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_081f;
			IL_0276:
			object obj38 = typeof(System.IOAsyncCallback) + 384;
			object obj39 = "Cannot populate JSON object onto type '{0}'." + 2168;
			object obj40 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v20+12E]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v20+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0335;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v20+B0]");
			object obj42 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X10_v25-8]");
				if (0 == (nint)obj38)
				{
					break;
				}
				obj7 = obj42 + 16;
				obj41--;
				bool flag9 = (nint)obj41 != 1;
				obj42 = obj7;
				if (flag9)
				{
					continue;
				}
				goto IL_0335;
			}
			object obj43 = obj40 + obj42;
			obj19 = obj43 + 312;
			obj7 = obj42;
			goto IL_078c;
			IL_081f:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v572 @ X0_v21] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj44 = (nint)0 + (nint)3800;
			action2..ctor(obj2, (IntPtr)obj44);
			tournamentsCreationPopupEventsChannel = (TournamentsCreationPopupEventsChannel)(object)("AvailableVoices" + 768);
			PopupButton popupButton2 = PopupButton.Neutral((string)(object)tournamentsCreationPopupEventsChannel, action2, dismiss: true);
			bool flag10 = obj45 == null;
			obj24 = 0;
			obj8 = obj7;
			if (!flag10)
			{
				obj32 = obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v33+12E]");
				object obj46 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v33+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0553;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v33+B0]");
				obj8 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v27-8]");
					if (0 == (nint)obj25)
					{
						break;
					}
					obj7 = obj8 + 16;
					obj46--;
					bool flag11 = (nint)obj46 != 1;
					obj8 = obj7;
					if (flag11)
					{
						continue;
					}
					goto IL_0553;
				}
				goto IL_065d;
			}
			goto IL_06bb;
		}
	}

	public void OnTournamentOptionsCancelClicked()
	{
		//IL_0099: Expected I, but got O
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		int selectedIndex = (isInstantModeLastOption ? 1 : 0) ^ 1;
		schedulingMode.SelectedIndex = selectedIndex;
		int index = (isChooseTeamAllowedLastOption ? 1 : 0) ^ 1;
		ToggleGroupExtensions.SetSelectedIndex(chooseTeamInput, index);
		int index2 = (isWatchersChatLastOption ? 1 : 0) ^ 1;
		ToggleGroupExtensions.SetSelectedIndex(watchersChatInput, index2);
		sizeInput.SetSelectedIndex(selectedSizeIndexLastOption);
		KDropMenu kDropMenu = bestOfInput;
		int num = selectedBestOfIndexLastOption;
		nint num2 = (nint)kDropMenu;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v6 (Il2CppClass<KDropMenu>)+1E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v6 (Il2CppClass<KDropMenu>)+1F0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v62 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void OnTournamentOptionsSaveClicked()
	{
		//IL_00e8: Expected I4, but got O
		int selectedIndex = schedulingMode.SelectedIndex;
		bool isInstant = selectedIndex == 0;
		Sprite schedulingIcon = tournamentSprites.GetSchedulingIcon(isInstant);
		schedulingIndicator.sprite = schedulingIcon;
		int selectedIndex2 = ToggleGroupExtensions.GetSelectedIndex(watchersChatInput);
		bool isEnabled = selectedIndex2 == 0;
		Sprite chatIcon = tournamentSprites.GetChatIcon(isEnabled);
		watchersChatIndicator.sprite = chatIcon;
		int selectedIndex3 = ToggleGroupExtensions.GetSelectedIndex(chooseTeamInput);
		bool isEnabled2 = selectedIndex3 == 0;
		Sprite chooseTeammateIcon = tournamentSprites.GetChooseTeammateIcon(isEnabled2);
		chooseTeamIndicator.sprite = chooseTeammateIcon;
		OnTournamentSizeChanged((int)chooseTeammateIcon);
		KDropMenu kDropMenu = bestOfInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X8_v2 (KDropMenu)+34]");
		if ((nint)0 == 1)
		{
		}
		int num = default(int);
		string text = num.ToString();
		bestOfIndicator.SetText(text);
		int selectedIndex4 = schedulingMode.SelectedIndex;
		bool flag = selectedIndex4 == 0;
		isInstantModeLastOption = flag;
		int selectedIndex5 = ToggleGroupExtensions.GetSelectedIndex(chooseTeamInput);
		bool flag2 = selectedIndex5 == 0;
		isChooseTeamAllowedLastOption = flag2;
		int selectedIndex6 = ToggleGroupExtensions.GetSelectedIndex(watchersChatInput);
		bool flag3 = selectedIndex6 == 0;
		isWatchersChatLastOption = flag3;
		KDropMenu kDropMenu2 = sizeInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v9 (KDropMenu)+34]");
		selectedSizeIndexLastOption = 0;
		KDropMenu kDropMenu3 = bestOfInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v11 (KDropMenu)+34]");
		selectedBestOfIndexLastOption = 0;
	}

	public void OnRoomsOptionsCancelClicked()
	{
		int index = (isCheatingAllowedLastOption ? 1 : 0) ^ 1;
		ToggleGroupExtensions.SetSelectedIndex(cheatingInput, index);
		ToggleGroupExtensions.SetSelectedIndex(speedInput, selectedSpeedIndexLastOption);
		rankInput.SetSelectedRank((PlayerRank.Ranks)selectedRankIndexLastOption);
	}

	public void OnRoomsOptionsSaveClicked()
	{
		int selectedIndex = ToggleGroupExtensions.GetSelectedIndex(cheatingInput);
		bool isCheating = selectedIndex == 0;
		Sprite cheatingIcon = iconSprites.GetCheatingIcon(isCheating);
		cheatingIndicator.sprite = cheatingIcon;
		OnSpeedChanged(isOn: true);
		OnRankChanged(1);
		int selectedIndex2 = ToggleGroupExtensions.GetSelectedIndex(cheatingInput);
		bool flag = selectedIndex2 == 0;
		isCheatingAllowedLastOption = flag;
		int selectedIndex3 = ToggleGroupExtensions.GetSelectedIndex(speedInput);
		selectedSpeedIndexLastOption = selectedIndex3;
		KRankPicker kRankPicker = rankInput;
		selectedRankIndexLastOption = ((DummyBaseDropMenu)kRankPicker).<SelectedIndex>k__BackingField;
	}

	public void OnSchedulingChanged(bool isOn)
	{
		if (isOn)
		{
			int selectedIndex = schedulingMode.SelectedIndex;
			bool isInstant = selectedIndex == 0;
			Sprite schedulingIcon = tournamentSprites.GetSchedulingIcon(isInstant);
			schedulingIndicator.sprite = schedulingIcon;
		}
	}

	private void OnBestOfChanged(int _)
	{
		KDropMenu kDropMenu = bestOfInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X8_v1 (KDropMenu)+34]");
		if ((nint)0 == 1)
		{
		}
		int num = default(int);
		string text = num.ToString();
		bestOfIndicator.SetText(text);
	}

	public void OnWatchersChatChanged(bool isOn)
	{
		if (isOn)
		{
			int selectedIndex = ToggleGroupExtensions.GetSelectedIndex(watchersChatInput);
			bool isEnabled = selectedIndex == 0;
			Sprite chatIcon = tournamentSprites.GetChatIcon(isEnabled);
			watchersChatIndicator.sprite = chatIcon;
		}
	}

	public void OnChooseTeamChanged(bool isOn)
	{
		if (isOn)
		{
			int selectedIndex = ToggleGroupExtensions.GetSelectedIndex(chooseTeamInput);
			bool isEnabled = selectedIndex == 0;
			Sprite chooseTeammateIcon = tournamentSprites.GetChooseTeammateIcon(isEnabled);
			chooseTeamIndicator.sprite = chooseTeammateIcon;
		}
	}

	public void OnCheatingChanged(bool isOn)
	{
		if (isOn)
		{
			int selectedIndex = ToggleGroupExtensions.GetSelectedIndex(cheatingInput);
			bool isCheating = selectedIndex == 0;
			Sprite cheatingIcon = iconSprites.GetCheatingIcon(isCheating);
			cheatingIndicator.sprite = cheatingIcon;
		}
	}

	public void OnSpeedChanged(bool isOn)
	{
		//IL_0022: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_004c: Expected O, but got I
		//IL_0137: Expected O, but got I4
		//IL_0140: Expected O, but got I4
		//IL_00a0: Expected O, but got I4
		//IL_00df: Expected O, but got I4
		if (!isOn)
		{
			return;
		}
		object obj = 152985600;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EA9]");
		object obj3 = (nint)0 & (nint)1;
		int selectedIndex;
		int selectedIndex2;
		if (obj3 != null)
		{
			selectedIndex = ToggleGroupExtensions.GetSelectedIndex(speedInput);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = 0;
			selectedIndex2 = selectedIndex;
			if (!flag)
			{
				goto IL_00b6;
			}
		}
		else
		{
			_ = 1;
			selectedIndex = ToggleGroupExtensions.GetSelectedIndex(speedInput);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = 0;
			selectedIndex2 = selectedIndex;
			if (obj6 != null)
			{
				goto IL_00b6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int speedIndexValue = KUtil.GetSpeedIndexValue(selectedIndex2);
		goto IL_0172;
		IL_00b6:
		speedIndexValue = KUtil.GetSpeedIndexValue(selectedIndex);
		bool flag3 = (object)iconSprites == null;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0172;
		IL_0172:
		Sprite speedIcon = iconSprites.GetSpeedIcon(speedIndexValue);
		speedIndicator.sprite = speedIcon;
	}

	private void OnRankChanged(int _)
	{
		PlayerRank.Ranks selectedItem = rankInput.SelectedItem;
		object sprite = ((RanksData<object>)(object)rankSprites).GetFor(selectedItem, isNew: false);
		rankIndicator.sprite = (Sprite)sprite;
	}

	public void OnPrizeChanged()
	{
		//IL_006d: Invalid comparison between F4 and I4
		//IL_009e: Expected I4, but got F4
		//IL_0135: Expected I4, but got I8
		//IL_0091: Expected I4, but got I8
		//IL_00d3: Expected I4, but got I8
		int totalPrize = prizeSelector.totalPrize;
		TournamentConfig config = Config;
		int fixedFeeCost = GetFixedFeeCost();
		float num = config.<CreationFee>k__BackingField * (float)totalPrize;
		float num2 = num + (float)fixedFeeCost;
		long creationPrice = GetCreationPrice();
		totalCreationPrice = creationPrice;
		int number = (int)((num2 != 2.139095E+09f) ? ((int)num2) : 2147483648L);
		TextMeshProExtensions.SetNumber(feesText, number, useCommas: true);
		TextMeshProExtensions.SetNumber(totalText, (int)totalCreationPrice, useCommas: true);
		int totalPrize2 = prizeSelector.totalPrize;
		long getSelectedAddonsPrice = addonManager.GetSelectedAddonsPrice;
		int number2 = (int)(totalPrize2 + getSelectedAddonsPrice);
		TextMeshProExtensions.SetNumber(addonsText, number2, useCommas: true);
	}

	private long GetCreationPrice()
	{
		//IL_014c: Expected I8, but got O
		//IL_00f0: Expected O, but got I8
		//IL_0108: Invalid comparison between F4 and I4
		//IL_0139: Expected I8, but got F4
		if ((object)prizeSelector != null)
		{
			int totalPrize = prizeSelector.totalPrize;
			if ((object)addonManager != null)
			{
				long getSelectedAddonsPrice = addonManager.GetSelectedAddonsPrice;
				if ((object)prizeSelector != null)
				{
					int totalPrize2 = prizeSelector.totalPrize;
					TournamentConfig config = Config;
					if (config != null)
					{
						int fixedFeeCost = GetFixedFeeCost();
						float num = config.<CreationFee>k__BackingField * (float)totalPrize2;
						float num2 = num + (float)fixedFeeCost;
						object obj = getSelectedAddonsPrice + totalPrize;
						float num3 = num2 + (float)obj;
						if (num3 == 2.139095E+09f)
						{
							return -9223372036854775808L;
						}
						return (long)num3;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (long)ex;
	}

	private float GetBaseFees()
	{
		int totalPrize = prizeSelector.totalPrize;
		TournamentConfig config = Config;
		int fixedFeeCost = GetFixedFeeCost();
		float num = config.<CreationFee>k__BackingField * (float)totalPrize;
		return num + (float)fixedFeeCost;
	}

	private void OnConfigChanged()
	{
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_010b: Expected O, but got I
		//IL_0119: Expected I, but got O
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0150: Expected O, but got I
		//IL_0160: Expected O, but got I
		//IL_0182: Expected O, but got I4
		//IL_009c: Expected O, but got I
		//IL_00ac: Expected O, but got I
		//IL_00ce: Expected O, but got I4
		//IL_01b2: Expected O, but got I4
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected O, but got Unknown
		//IL_02d4: Expected O, but got I
		//IL_02e5: Expected I, but got O
		//IL_0303: Expected O, but got I
		//IL_01e2: Expected O, but got I
		TournamentConfig config = Config;
		IEnumerable<int> sizes;
		object obj;
		object obj3;
		Func<int, object> selector;
		if (config.CanCreateTournament)
		{
			TournamentConfig config2 = Config;
			sizes = config2.GetSizes();
			obj = typeof(SkeletonBinary.SkeletonInput) + 3464;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v27+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v27+B8]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v20+8]");
				selector = (Func<int, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v20+8]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					goto IL_0190;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v27+B8]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v20+8]");
				selector = (Func<int, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v20+8]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					goto IL_0190;
				}
			}
			goto IL_01e7;
		}
		object obj6 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = (nint)0 + (nint)704;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj7);
		popup.SlideOut(action);
		return;
		IL_0190:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v27+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v26+B8]");
			obj3 = 0;
		}
		object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)3720;
		Func<int, object> func = default(Func<int, object>);
		func..ctor(obj3, (IntPtr)obj11);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v25+B8]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		selector = func;
		goto IL_01e7;
		IL_01e7:
		IEnumerable<object> source = Enumerable.Select(sizes, selector);
		List<object> newItems = Enumerable.ToList(source);
		((BaseDropMenu<object>)(object)sizeInput).SetupItems(newItems, (Action)null, (Action)null);
		KDropMenu kDropMenu = sizeInput;
		TournamentConfig config3 = Config;
		int[][] allowedSizes = config3.AllowedSizes;
		int max = allowedSizes.Length - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X20_v6 (KDropMenu)+34]");
		int selectedIndex = FloatExtensions.EnsureRange(0, 0, max);
		kDropMenu.SetSelectedIndex(selectedIndex);
		UpdateSchedulingToggle();
		UpdateTournamentTypeToggle();
	}

	public void CreateTournament()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0138: Expected O, but got I4
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01b1: Expected O, but got I
		//IL_01c2: Expected I, but got O
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_0205: Expected O, but got I4
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_0277: Expected O, but got I
		//IL_0288: Expected I, but got O
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_02b7: Expected O, but got I
		//IL_02c8: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (ValidName() && ValidStartTime() && ValidSize() && ValidatePassword() && ValidPrize())
		{
			createTournament.interactable = false;
			object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v21+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object msgBody = "LAK" + 2136;
			PopupWindow.ShowLoading((string)msgBody, dismissible: false);
			_ = 1;
			GameObject go = base.gameObject;
			object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj8 = (nint)0 + (nint)3736;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj8);
			object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v28+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object command = "getSecondRescanTask" + 1712;
			SfsRequestListener.SendZoneRequest(go, (string)command, null, keepListening: false, action);
			object obj12 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)3744;
			Func<bool> func = default(Func<bool>);
			func..ctor(obj2, (IntPtr)obj13);
			object obj14 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)3752;
			Action action2 = default(Action);
			action2..ctor(obj2, (IntPtr)obj15);
			Coroutine coroutine = UIExtensions.SetTimeout(this, 5f, func, action2);
		}
	}

	private unsafe void SendCreateTournament()
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_00bc: Expected O, but got I4
		//IL_00c5: Expected O, but got I4
		//IL_0767: Expected O, but got I
		//IL_0781: Expected O, but got I4
		//IL_061a: Expected O, but got I
		//IL_0116: Expected O, but got Ref
		//IL_013e: Expected O, but got I
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_018e: Expected O, but got I4
		//IL_00fa: Expected F8, but got I4
		//IL_0103: Expected O, but got I4
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected O, but got Unknown
		//IL_0694: Expected O, but got I4
		//IL_07ce: Expected O, but got I4
		//IL_081b: Expected O, but got I
		//IL_082b: Expected O, but got I
		//IL_084d: Expected O, but got I4
		//IL_06bf: Expected F8, but got I4
		//IL_0708: Expected O, but got I4
		//IL_0715: Expected F8, but got I4
		//IL_071e: Expected O, but got I4
		//IL_023e: Expected O, but got I4
		//IL_01e5: Expected O, but got I4
		//IL_0278: Expected O, but got I4
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Expected O, but got Unknown
		//IL_0885: Expected O, but got I
		//IL_0896: Expected I, but got O
		//IL_08b4: Expected O, but got I
		//IL_026a: Expected O, but got I4
		//IL_0215: Expected O, but got I
		//IL_0339: Expected O, but got I4
		//IL_08e6: Expected O, but got I
		//IL_0900: Expected O, but got I4
		//IL_032b: Expected O, but got I4
		//IL_035f: Expected O, but got I
		//IL_03c7: Expected O, but got I4
		//IL_039b: Expected O, but got Ref
		//IL_03a4: Expected native int or pointer, but got O
		//IL_03b9: Expected O, but got I
		//IL_03e0: Expected O, but got Ref
		//IL_03ed: Expected native int or pointer, but got O
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected O, but got Unknown
		//IL_0956: Expected O, but got I4
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected O, but got Unknown
		//IL_052b: Expected I4, but got O
		//IL_052b: Expected I4, but got O
		//IL_052b: Expected O, but got I
		//IL_052b: Expected I4, but got O
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected O, but got Unknown
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Expected O, but got Unknown
		//IL_0996: Expected O, but got I
		//IL_09b1: Expected I, but got O
		//IL_09c6: Expected O, but got I
		//IL_0591: Expected O, but got I
		//IL_05a7: Expected O, but got Ref
		//IL_05b1: Expected native int or pointer, but got O
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(SkeletonBinary.SkeletonInput) + 3480;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj4 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = typeof(DataRelation) + 712;
		object obj7;
		double num;
		object obj9;
		if (schedulingMode.SelectedIndex != 0)
		{
			DateTime startTime = StartTime;
			obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v103+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			TimeSpan timeSpan = (TimeSpan)0;
			double num2 = default(double);
			num = num2;
			object obj10 = default(object);
			obj9 = obj10;
			if (obj8 == null)
			{
				goto IL_00e3;
			}
			goto IL_0108;
		}
		object obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v11+E4]");
		DateTime dateTime;
		DateTime dateTime2;
		if ((nint)0 != 0)
		{
			DateTime now = DateTime.Now;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EAF]");
			object obj12 = (nint)0 & (nint)1;
			bool flag2 = obj12 == null;
			dateTime = now;
			dateTime2 = now;
			if (!flag2)
			{
				goto IL_0647;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			DateTime now2 = DateTime.Now;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EAF]");
			object obj13 = (nint)0 & (nint)1;
			bool flag3 = obj13 == null;
			object obj14 = !flag3;
			dateTime = now2;
			dateTime2 = now2;
			if (obj14 != null)
			{
				goto IL_0647;
			}
		}
		_ = 1;
		TournamentConfig config = Config;
		bool flag4 = config == null;
		object obj15 = !flag4;
		dateTime = dateTime2;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0656;
		IL_0647:
		config = Config;
		goto IL_0656;
		IL_0108:
		DateTime dateTime3 = (DateTime)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
		DateTime startingTime = ((DateTime*)dateTime3)->ToUniversalTime();
		FeaturesBottomSheet featuresBottomSheet = addonManager;
		object obj16 = (nint)0 + (nint)2312;
		object obj17 = typeof(SkeletonBinary.SkeletonInput) + 3464;
		Dictionary<System.Int32Enum, object>.ValueCollection values = ((Dictionary<System.Int32Enum, object>)(object)featuresBottomSheet.SelectedAddons).Values;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v41+E4]");
		bool flag5 = (nint)0 == 0;
		object obj19 = !flag5;
		Dictionary<System.Int32Enum, object>.ValueCollection source = values;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj17;
			source = values;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v41+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v49+10]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v49+10]");
		bool flag6 = (nint)0 == 0;
		object obj21 = !flag6;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v41+E4]");
			bool flag7 = (nint)0 == 0;
			object obj22 = !flag7;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj23 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v55+B8]");
				obj20 = 0;
			}
			object obj24 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3856;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)3728;
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj20, (IntPtr)obj25);
			object obj26 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v54+B8]");
			object obj27 = (nint)0 + (nint)16;
			obj27 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<object> source2 = Enumerable.Select(source, selector);
		List<object> list = Enumerable.ToList(source2);
		TournamentPrizeSelector tournamentPrizeSelector = prizeSelector;
		object obj28 = tournamentPrizeSelector.secondPrizeAces + tournamentPrizeSelector.firstPrizeAces;
		List<TournamentAddonCreationModel> list2 = (((nint)obj28 < 1) ? ((List<TournamentAddonCreationModel>)1) : ((List<TournamentAddonCreationModel>)(1 + 1)));
		int selectedIndex = tournamentTypeInput.SelectedIndex;
		string text = nameInput.Text;
		string text2 = passwordInput.Text;
		TournamentConfig config2 = Config;
		KDropMenu kDropMenu = sizeInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v26 (KDropMenu)+34]");
		int size = config2.GetSize(0);
		KDropMenu kDropMenu2 = bestOfInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v28 (KDropMenu)+34]");
		if ((nint)0 == 1)
		{
			object obj29 = 3;
		}
		else
		{
			object obj29 = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EA8]");
		object obj30 = (nint)0 & (nint)1;
		bool flag8 = obj30 == null;
		object obj31 = !flag8;
		if (obj31 == null)
		{
			_ = 1;
			kDropMenu2 = bestOfInput;
		}
		object obj32 = (nint)0 + (nint)3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v28 (KDropMenu)+34]");
		int? num4;
		if ((nint)0 == 2)
		{
			_ = 0;
			int? num3 = (int?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 88));
			*(int?*)(nint)num3 = 3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
			num4 = (int?)(object)0;
		}
		else
		{
			num4 = (int?)(object)0;
		}
		TournamentPrizeSelector tournamentPrizeSelector2 = prizeSelector;
		_ = 0;
		int? num5 = (int?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 88));
		*(int?*)(nint)num5 = tournamentPrizeSelector2.secondPrizeAces;
		int selectedIndex2 = schedulingMode.SelectedIndex;
		int selectedIndex3 = ToggleGroupExtensions.GetSelectedIndex(cheatingInput);
		PlayerRank.Ranks selectedItem = rankInput.SelectedItem;
		object obj33 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		int selectedIndex4 = ToggleGroupExtensions.GetSelectedIndex(speedInput);
		object obj34 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v34+E4]");
		bool flag9 = (nint)0 == 0;
		object obj35 = !flag9;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int speedIndexValue = KUtil.GetSpeedIndexValue(selectedIndex4);
		bool cheatingAllowed = selectedIndex3 == 0;
		bool isInstant = selectedIndex2 == 0;
		int selectedIndex5 = tournamentTypeInput.SelectedIndex;
		int selectedIndex6 = ToggleGroupExtensions.GetSelectedIndex(watchersChatInput);
		int selectedIndex7 = ToggleGroupExtensions.GetSelectedIndex(chooseTeamInput);
		object obj36 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-64]");
		nint num6 = 0;
		int? finalBestOf = num4;
		int prize = tournamentPrizeSelector2.firstPrizeAces;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
		TournamentCreationModel tournamentCreationModel = default(TournamentCreationModel);
		bool watchersChatEnabled = default(bool);
		tournamentCreationModel..ctor((TournamentType)selectedIndex, text, text2, size, (int)num6, finalBestOf, (TournamentPrizeType)list2, prize, (int?)(object)0, isInstant, startingTime, cheatingAllowed, (PlayerRank.Ranks)speedIndexValue, (int)list, isHidden: false, watchersChatEnabled, (byte)(int)obj4 != 0, list2);
		object obj37 = obj4 + 24;
		obj37 = tournamentCreationModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag10 = clanId < 1;
		string text3 = text;
		if (!flag10)
		{
			object obj38 = obj37;
			_ = 0;
			object obj39 = (nint)0 + (nint)3136;
			text3 = (string)obj39;
			int? num7 = (int?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 88));
			*(int?*)(nint)num7 = clanId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
			_ = 0;
		}
		object obj40 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 656;
		object obj41 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj4, (IntPtr)obj41);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+18]");
		KammelnaRequests.CreateTournament((TournamentCreationModel)0, action);
		return;
		IL_00e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num = config.<InstantTournamentStartTime>k__BackingField;
		obj9 = 0;
		goto IL_0108;
		IL_0656:
		object obj42 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj43 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v22+E4]");
		bool flag11 = (nint)0 == 0;
		object obj44 = !flag11;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan2 = TimeSpan.FromMinutes(config.<InstantTournamentStartTime>k__BackingField);
		DateTime dateTime4 = dateTime + timeSpan2;
		obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v103+E4]");
		bool flag12 = (nint)0 == 0;
		object obj45 = !flag12;
		num = config.<InstantTournamentStartTime>k__BackingField;
		obj9 = 0;
		if (obj45 == null)
		{
			TimeSpan timeSpan = timeSpan2;
			goto IL_00e3;
		}
		goto IL_0108;
	}

	private void TrackAnimatedRoomThemeAddon()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0040: Expected O, but got I4
		//IL_0048: Expected I4, but got O
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0072: Expected I, but got O
		//IL_0082: Expected O, but got I
		//IL_021a: Expected O, but got I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_02ab: Expected O, but got I
		//IL_00bd: Expected O, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		IRoomThemeAddon roomThemeAddon = addonManager.RoomThemeAddon;
		bool flag = roomThemeAddon == null;
		object obj2 = 0;
		int itemID = (int)roomThemeAddon;
		if (flag)
		{
			goto IL_024a;
		}
		object obj3 = typeof(System.IOAsyncCallback) + 944;
		nint num = (nint)roomThemeAddon;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v11 (Il2CppClass<IRoomThemeAddon>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v11 (Il2CppClass<IRoomThemeAddon>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00fe;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v11 (Il2CppClass<IRoomThemeAddon>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X10_v7-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj5 += 16;
			obj4--;
			if ((nint)obj4 != 1)
			{
				continue;
			}
			goto IL_00fe;
		}
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_029b;
		IL_029b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v12+8]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v127 @ X8_v12] (should have been resolved before IL gen)");
		goto IL_024a;
		IL_024a:
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v5+E4]");
		StoreItem storeItem2;
		if ((nint)0 != 0)
		{
			StoreItem storeItem = Store.GetStoreItem(itemID);
			bool flag2 = StoreItemExtensions.IsAnimatedRoomTheme(storeItem);
			bool flag3 = !flag2;
			storeItem2 = storeItem;
			if (flag3)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			StoreItem storeItem3 = Store.GetStoreItem(itemID);
			bool flag4 = StoreItemExtensions.IsAnimatedRoomTheme(storeItem3);
			bool flag5 = !flag4;
			object obj9 = !flag5;
			storeItem2 = storeItem3;
			if (obj9 == null)
			{
				return;
			}
		}
		ITrackEvent trackEvent = TrackerLibrary.TournamentAnimatedRoomThemeAddon(storeItem2.<id>k__BackingField, storeItem2.<name>k__BackingField);
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v8+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
		return;
		IL_00fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj12 = default(object);
		obj7 = obj12;
		goto IL_029b;
	}

	private void ClearInput()
	{
		//IL_0011: Expected O, but got I
		//IL_0019: Expected I4, but got O
		//IL_0076: Expected O, but got I
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_0c0c: Expected I4, but got O
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0c47: Expected I4, but got O
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_039b: Expected O, but got I4
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected O, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_047d: Expected O, but got I4
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected O, but got Unknown
		//IL_04bc: Expected F8, but got I4
		//IL_04ea: Expected O, but got I4
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected O, but got Unknown
		//IL_054d: Expected O, but got I4
		//IL_0577: Expected I8, but got I4
		//IL_0597: Expected F8, but got I4
		//IL_0656: Expected F8, but got I4
		//IL_05df: Expected I, but got O
		//IL_0615: Expected F8, but got I4
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected O, but got Unknown
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Expected O, but got Unknown
		//IL_06d2: Expected O, but got I4
		//IL_06df: Expected F8, but got I4
		//IL_06ef: Expected I4, but got O
		//IL_0724: Expected O, but got I4
		//IL_0731: Expected F8, but got I4
		//IL_078f: Expected O, but got I4
		//IL_079c: Expected F8, but got I4
		//IL_07e2: Expected O, but got I4
		//IL_07ef: Expected F8, but got I4
		//IL_0825: Expected O, but got I4
		//IL_0832: Expected F8, but got I4
		//IL_086c: Expected O, but got I4
		//IL_0889: Expected O, but got I4
		//IL_0891: Unknown result type (might be due to invalid IL or missing references)
		//IL_0896: Expected O, but got Unknown
		//IL_08cb: Expected O, but got I4
		//IL_0c92: Expected I, but got O
		//IL_0ca2: Expected O, but got I
		//IL_0cd5: Expected O, but got I4
		//IL_0ce2: Expected F8, but got I4
		//IL_0905: Expected I, but got O
		//IL_0915: Expected O, but got I
		//IL_093f: Expected O, but got I4
		//IL_094c: Expected F8, but got I4
		//IL_0988: Expected O, but got I4
		//IL_0995: Expected F8, but got I4
		//IL_09b4: Expected I4, but got O
		//IL_09d6: Expected O, but got I4
		//IL_09e3: Expected F8, but got I4
		//IL_0a11: Expected O, but got I4
		//IL_0a1e: Expected F8, but got I4
		//IL_0a3d: Expected O, but got I
		//IL_0a59: Expected O, but got I4
		//IL_0a66: Expected F8, but got I4
		//IL_0adc: Expected O, but got I4
		//IL_0ae9: Expected F8, but got I4
		//IL_0b52: Expected O, but got I4
		//IL_0b5f: Expected F8, but got I4
		bool flag = (object)tournamentTypeInput == null;
		IntPtr intPtr = default(IntPtr);
		bool flag2 = (byte)(nint)intPtr != 0;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			object obj = (nint)0 + (nint)472;
			flag2 = (byte)(int)obj != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
			object obj2 = default(object);
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v10+28]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v10+28]");
					GameObject gameObject = ((Component)0).gameObject;
					bool flag3 = (object)gameObject == null;
					flag2 = false;
					if (!flag3)
					{
						bool activeSelf = gameObject.activeSelf;
						gameObject.SetActive(value: true);
						TournamentsCreationPopupEventsChannel tournamentsCreationPopupEventsChannel = eventsChannel;
						bool flag4 = (object)eventsChannel == null;
						object[] array = null;
						flag2 = true;
						if (!flag4)
						{
							bool flag5 = (object)tournamentTypeInput == null;
							array = null;
							flag2 = true;
							if (!flag5)
							{
								tournamentTypeInput.SelectedIndex = (int)tournamentsCreationPopupEventsChannel.<TournamentType>k__BackingField;
								ToggleGroupExtensions.SetSelectedIndex(chooseTeamInput, 0);
								ToggleGroupExtensions.SetSelectedIndex(watchersChatInput, 0);
								ToggleGroupIndexer toggleGroupIndexer = schedulingMode;
								bool flag6 = (object)schedulingMode == null;
								array = null;
								flag2 = false;
								if (!flag6)
								{
									Toggle[] toggles = toggleGroupIndexer.Toggles;
									bool flag7 = toggleGroupIndexer.Toggles == null;
									array = null;
									flag2 = false;
									if (!flag7)
									{
										bool flag8 = toggles.Length == 0;
										array = null;
										flag2 = false;
										if (flag8)
										{
											goto IL_0b94;
										}
										bool flag9 = (object)toggles[0] == null;
										array = null;
										flag2 = false;
										if (!flag9)
										{
											toggles[0].isOn = true;
											gameObject.SetActive(activeSelf);
											bool flag10 = (object)tournamentTypeInput == null;
											array = null;
											flag2 = activeSelf;
											if (!flag10)
											{
												object obj3 = "Complete" + 2912;
												object obj4 = "Complete" + 2928;
												int selectedIndex = tournamentTypeInput.SelectedIndex;
												object obj5 = ((selectedIndex != 1) ? obj4 : obj3);
												TextMeshProExtensions.Localize(viewTitleLabel, (string)obj5);
												bool flag11 = (object)tournamentTypeInput == null;
												array = null;
												flag2 = (byte)(int)obj5 != 0;
												if (!flag11)
												{
													object obj6 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 4088;
													int selectedIndex2 = tournamentTypeInput.SelectedIndex;
													object obj7 = ((selectedIndex2 != 1) ? "Added Tournament Prizes And Features" : obj6);
													TextMeshProExtensions.Localize(featuresPrizesLabel, (string)obj7);
													bool flag12 = (object)nameInput == null;
													array = null;
													flag2 = (byte)(int)obj7 != 0;
													if (!flag12)
													{
														nameInput.Text = null;
														bool flag13 = (object)eventsChannel == null;
														array = null;
														flag2 = false;
														if (!flag13)
														{
															object obj8 = eventsChannel + 24;
															obj8 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															bool flag14 = (object)passwordInput == null;
															array = null;
															flag2 = false;
															if (!flag14)
															{
																passwordInput.Text = null;
																bool flag15 = (object)startTimeInput == null;
																array = null;
																flag2 = false;
																if (!flag15)
																{
																	object obj9 = typeof(TypeConverter<ushort, char>) + 3400;
																	startTimeInput.Text = null;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
																	TournamentConfig config = Config;
																	bool flag16 = config == null;
																	array = null;
																	flag2 = true;
																	if (!flag16)
																	{
																		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
																		object obj11 = obj10;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v37+E4]");
																		bool flag17 = (nint)0 == 0;
																		object obj12 = !flag17;
																		if (obj12 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		}
																		object obj13 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
																		TimeSpan timeSpan = TimeSpan.FromMinutes(config.<InstantTournamentStartTime>k__BackingField);
																		object obj14 = obj10;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v41+E4]");
																		bool flag18 = (nint)0 == 0;
																		object obj15 = !flag18;
																		if (obj15 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		}
																		object input = "m_StencilDeferredPS" + 1888;
																		TimeSpan timeSpan2 = default(TimeSpan);
																		int minutes = timeSpan2.Minutes;
																		object obj16 = obj13;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v45+E4]");
																		bool flag19 = (nint)0 == 0;
																		object obj17 = !flag19;
																		if (obj17 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		}
																		string text = LocalizationUtil.Localize((string)input, minutes);
																		object[] array2 = default(object[]);
																		bool flag20 = array2 == null;
																		double num = config.<InstantTournamentStartTime>k__BackingField;
																		array = null;
																		flag2 = (byte)minutes != 0;
																		if (!flag20)
																		{
																			bool flag21 = text == null;
																			bool flag22 = (byte)minutes != 0;
																			if (!flag21)
																			{
																				nint num2 = (nint)array2;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
																				flag22 = false;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																				bool flag23 = ex == null;
																				num = config.<InstantTournamentStartTime>k__BackingField;
																				array = null;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
																				flag2 = false;
																				if (flag23)
																				{
																					goto IL_0ba2;
																				}
																			}
																			bool flag24 = array2.Length == 0;
																			num = config.<InstantTournamentStartTime>k__BackingField;
																			array = null;
																			flag2 = flag22;
																			if (flag24)
																			{
																				goto IL_0b94;
																			}
																			object obj18 = "SetRoomVariables request error" + 2936;
																			object obj19 = array2 + 32;
																			obj19 = text;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																			TextMeshProExtensions.Localize(instantTimeLabel, (string)obj18, array2);
																			bool flag25 = (object)timeLabel == null;
																			object obj20 = 0;
																			num = config.<InstantTournamentStartTime>k__BackingField;
																			array = array2;
																			flag2 = (byte)(int)obj18 != 0;
																			if (!flag25)
																			{
																				GameObject gameObject2 = timeLabel.gameObject;
																				bool flag26 = (object)gameObject2 == null;
																				obj20 = 0;
																				num = config.<InstantTournamentStartTime>k__BackingField;
																				array = array2;
																				flag2 = false;
																				if (!flag26)
																				{
																					gameObject2.SetActive(value: false);
																					KDropMenu kDropMenu = sizeInput;
																					TournamentConfig config2 = Config;
																					bool flag27 = config2 == null;
																					obj20 = 0;
																					num = config.<InstantTournamentStartTime>k__BackingField;
																					array = null;
																					flag2 = false;
																					if (!flag27)
																					{
																						int[][] allowedSizes = config2.AllowedSizes;
																						bool flag28 = config2.AllowedSizes == null;
																						obj20 = 0;
																						num = config.<InstantTournamentStartTime>k__BackingField;
																						array = null;
																						flag2 = false;
																						if (!flag28)
																						{
																							bool flag29 = (object)sizeInput == null;
																							obj20 = 0;
																							num = config.<InstantTournamentStartTime>k__BackingField;
																							array = null;
																							flag2 = false;
																							if (!flag29)
																							{
																								bool flag30 = (byte)(allowedSizes.Length - 1) != 0;
																								object obj21 = (flag30 ? 1 : 0) - 1;
																								bool flag31 = (nint)obj21 < 0;
																								object obj22 = (flag30 ? 1 : 0) ^ 1;
																								object obj23 = flag30 ^ obj21;
																								object obj24 = obj22 & obj23;
																								bool flag32 = (nint)obj24 < 0;
																								bool flag33 = flag31 == flag32;
																								object obj25 = !flag33;
																								object obj26 = ~obj25;
																								flag2 = obj26 != null || flag30;
																								nint num3 = (nint)kDropMenu;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v20 (Il2CppClass<KDropMenu>)+1F0]");
																								array = (object[])0;
																								sizeInput.SetSelectedIndex(flag2 ? 1 : 0);
																								KDropMenu kDropMenu2 = bestOfInput;
																								bool flag34 = (object)bestOfInput == null;
																								obj20 = 0;
																								num = config.<InstantTournamentStartTime>k__BackingField;
																								if (!flag34)
																								{
																									nint num4 = (nint)kDropMenu2;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v21 (Il2CppClass<KDropMenu>)+1F0]");
																									array = (object[])0;
																									bestOfInput.SetSelectedIndex(0);
																									bool flag35 = (object)prizeSelector == null;
																									obj20 = 0;
																									num = config.<InstantTournamentStartTime>k__BackingField;
																									flag2 = false;
																									if (!flag35)
																									{
																										prizeSelector.ClearInput();
																										bool flag36 = (object)cheatingInput == null;
																										obj20 = 0;
																										num = config.<InstantTournamentStartTime>k__BackingField;
																										flag2 = false;
																										if (!flag36)
																										{
																											flag2 = (byte)(int)obj != 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
																											object obj27 = default(object);
																											bool flag37 = obj27 == null;
																											obj20 = 0;
																											num = config.<InstantTournamentStartTime>k__BackingField;
																											if (!flag37)
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v64+28]");
																												bool flag38 = (nint)0 == 0;
																												obj20 = 0;
																												num = config.<InstantTournamentStartTime>k__BackingField;
																												if (!flag38)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v64+28]");
																													GameObject gameObject3 = ((Component)0).gameObject;
																													bool flag39 = (object)gameObject3 == null;
																													obj20 = 0;
																													num = config.<InstantTournamentStartTime>k__BackingField;
																													flag2 = false;
																													if (!flag39)
																													{
																														bool activeSelf2 = gameObject3.activeSelf;
																														gameObject3.SetActive(value: true);
																														ToggleGroupExtensions.SetSelectedIndex(cheatingInput, 0);
																														ToggleGroupExtensions.SetSelectedIndex(speedInput, 2);
																														bool flag40 = (object)rankInput == null;
																														obj20 = 0;
																														num = config.<InstantTournamentStartTime>k__BackingField;
																														array = null;
																														flag2 = true;
																														if (!flag40)
																														{
																															rankInput.SetSelectedRank(PlayerRank.Ranks.Beginner);
																															gameObject3.SetActive(activeSelf2);
																															OnConfigChanged();
																															RefreshTournamentOptions();
																															bool flag41 = (object)addonManager == null;
																															obj20 = 0;
																															num = config.<InstantTournamentStartTime>k__BackingField;
																															array = null;
																															flag2 = activeSelf2;
																															if (!flag41)
																															{
																																addonManager.OnConfigChanged();
																																return;
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
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0b94;
		IL_0b94:
		ex = new IndexOutOfRangeException();
		goto IL_0ba2;
		IL_0ba2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void RefreshTournamentOptions()
	{
		//IL_0159: Expected O, but got I4
		//IL_01d4: Expected O, but got I4
		//IL_022b: Expected O, but got I4
		//IL_02a6: Expected O, but got I4
		//IL_02fd: Expected O, but got I4
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_0334: Expected O, but got I
		//IL_037e: Expected O, but got I4
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected I4, but got Unknown
		//IL_03dd: Expected O, but got I4
		//IL_045b: Expected I4, but got O
		Transform transform = schedulingMode.transform;
		Transform parent = transform.parent;
		GameObject gameObject = parent.gameObject;
		int selectedIndex = tournamentTypeInput.SelectedIndex;
		bool active = selectedIndex == 0;
		gameObject.SetActive(active);
		GameObject gameObject2 = schedulingIndicator.gameObject;
		int selectedIndex2 = tournamentTypeInput.SelectedIndex;
		bool active2 = selectedIndex2 == 0;
		gameObject2.SetActive(active2);
		GameObject gameObject3 = prizeSelector.gameObject;
		int selectedIndex3 = tournamentTypeInput.SelectedIndex;
		bool active3 = selectedIndex3 == 0;
		gameObject3.SetActive(active3);
		Transform transform2 = passwordInput.transform;
		Transform parent2 = transform2.parent;
		GameObject gameObject4 = parent2.gameObject;
		int selectedIndex4 = tournamentTypeInput.SelectedIndex;
		object obj = selectedIndex4 - 1;
		bool active4 = obj == null;
		gameObject4.SetActive(active4);
		Transform transform3 = watchersChatInput.transform;
		Transform parent3 = transform3.parent;
		GameObject gameObject5 = parent3.gameObject;
		int selectedIndex5 = tournamentTypeInput.SelectedIndex;
		object obj2 = selectedIndex5 - 1;
		bool active5 = obj2 == null;
		gameObject5.SetActive(active5);
		GameObject gameObject6 = watchersChatIndicator.gameObject;
		int selectedIndex6 = tournamentTypeInput.SelectedIndex;
		object obj3 = selectedIndex6 - 1;
		bool active6 = obj3 == null;
		gameObject6.SetActive(active6);
		Transform transform4 = chooseTeamInput.transform;
		Transform parent4 = transform4.parent;
		GameObject gameObject7 = parent4.gameObject;
		int selectedIndex7 = tournamentTypeInput.SelectedIndex;
		object obj4 = selectedIndex7 - 1;
		bool active7 = obj4 == null;
		gameObject7.SetActive(active7);
		GameObject gameObject8 = chooseTeamIndicator.gameObject;
		int selectedIndex8 = tournamentTypeInput.SelectedIndex;
		object obj5 = selectedIndex8 - 1;
		bool active8 = obj5 == null;
		gameObject8.SetActive(active8);
		object obj6 = this + 404;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252E70]");
		obj6 = 0;
		selectedRankIndexLastOption = 1;
		TournamentConfig config = Config;
		int[][] allowedSizes = config.AllowedSizes;
		int num = allowedSizes.Length - 1;
		object obj7 = num - 1;
		bool flag = (nint)obj7 < 0;
		int num2 = num ^ 1;
		int num3 = num ^ obj7;
		int num4 = num2 & num3;
		bool flag2 = num4 < 0;
		bool flag3 = flag == flag2;
		object obj8 = !flag3;
		object obj9 = ~obj8;
		if (obj9 != null)
		{
			num = 1;
		}
		selectedSizeIndexLastOption = num;
		selectedBestOfIndexLastOption = 0;
		int selectedIndex9 = schedulingMode.SelectedIndex;
		bool isInstant = selectedIndex9 == 0;
		Sprite schedulingIcon = tournamentSprites.GetSchedulingIcon(isInstant);
		schedulingIndicator.sprite = schedulingIcon;
		OnTournamentSizeChanged((int)schedulingIcon);
		KDropMenu kDropMenu = bestOfInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v8 (KDropMenu)+34]");
		if ((nint)0 == 1)
		{
		}
		int num5 = default(int);
		string text = num5.ToString();
		bestOfIndicator.SetText(text);
		int selectedIndex10 = ToggleGroupExtensions.GetSelectedIndex(watchersChatInput);
		bool isEnabled = selectedIndex10 == 0;
		Sprite chatIcon = tournamentSprites.GetChatIcon(isEnabled);
		watchersChatIndicator.sprite = chatIcon;
		int selectedIndex11 = ToggleGroupExtensions.GetSelectedIndex(chooseTeamInput);
		bool isEnabled2 = selectedIndex11 == 0;
		Sprite chooseTeammateIcon = tournamentSprites.GetChooseTeammateIcon(isEnabled2);
		chooseTeamIndicator.sprite = chooseTeammateIcon;
		int index = (isCheatingAllowedLastOption ? 1 : 0) ^ 1;
		ToggleGroupExtensions.SetSelectedIndex(cheatingInput, index);
		ToggleGroupExtensions.SetSelectedIndex(speedInput, selectedSpeedIndexLastOption);
		rankInput.SetSelectedRank((PlayerRank.Ranks)selectedRankIndexLastOption);
		int selectedIndex12 = ToggleGroupExtensions.GetSelectedIndex(cheatingInput);
		bool isCheating = selectedIndex12 == 0;
		Sprite cheatingIcon = iconSprites.GetCheatingIcon(isCheating);
		cheatingIndicator.sprite = cheatingIcon;
		OnSpeedChanged(isOn: true);
		OnRankChanged(1);
	}

	public void RefreshView()
	{
		OnPrizeChanged();
		RefreshRoomPreview();
		RefreshCardBackPreview();
	}

	private void RefreshRoomPreview()
	{
		GameObject gameObject = sportRoomTheme.gameObject;
		gameObject.SetActive(value: false);
		IRoomThemeAddon roomThemeAddon = addonManager.RoomThemeAddon;
		if (roomThemeAddon != null)
		{
			IRoomThemeAddon roomThemeAddon2 = addonManager.RoomThemeAddon;
			UpdateRoomThemePreview(roomThemeAddon2);
		}
		else
		{
			roomTheme.sprite = defaultRoomTheme;
		}
	}

	private void RefreshCardBackPreview()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bc: Expected O, but got I4
		//IL_00d8: Expected O, but got I
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		int? cardBackId = addonManager.CardBackId;
		object obj = (??)cardBackId & 1;
		if (obj != null)
		{
			int? cardBackId2 = addonManager.CardBackId;
			int? num = default(int?);
			int value = num.Value;
			UIExtensions.LoadItemImage(cardBacks, value, ImageCacher.ItemImageType.InGame);
			return;
		}
		Image[] array = cardBacks;
		if (array.Length >= 1)
		{
			object obj2 = array + 32;
			object obj3 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X22_v4+v77 @ X21_v5*8]");
				((Image)0).sprite = defaultCardBacks;
				obj3++;
			}
			while ((nint)obj3 < array.Length);
		}
	}

	private void UpdateCardBackPreview(int cardBackID)
	{
		UIExtensions.LoadItemImage(cardBacks, cardBackID, ImageCacher.ItemImageType.InGame);
	}

	private void DefaultCardBackPreview()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006f: Expected O, but got I
		Image[] array = cardBacks;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X22_v4+v40 @ X21_v5*8]");
				((Image)0).sprite = defaultCardBacks;
			}
			while ((nint)obj2 < array.Length);
		}
	}

	private void DefaultRoomThemePreview()
	{
		roomTheme.sprite = defaultRoomTheme;
	}

	private void UpdateRoomThemePreview(IRoomThemeAddon roomThemeAddon)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00ce: Expected O, but got I
		//IL_0086: Expected O, but got I
		//IL_0109: Expected O, but got I
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1168;
		object obj2 = obj;
		nint num = (nint)roomThemeAddon;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5 (Il2CppClass<IRoomThemeAddon>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v1+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5 (Il2CppClass<IRoomThemeAddon>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v1+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X10_v9-8]");
			if (0 == (nint)obj2)
			{
				SportTeamRoomPreview((SportTeamsCelebrationTournamentAddon)roomThemeAddon);
				return;
			}
		}
		object obj6 = typeof(System.IOAsyncCallback) + 944;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5 (Il2CppClass<IRoomThemeAddon>)+12E]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5 (Il2CppClass<IRoomThemeAddon>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_014a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5 (Il2CppClass<IRoomThemeAddon>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X10_v7-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj8 += 16;
			obj7--;
			if ((nint)obj7 != 1)
			{
				continue;
			}
			goto IL_014a;
		}
		object obj9 = num + obj8;
		object obj10 = obj9 + 312;
		goto IL_01a8;
		IL_014a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_01a8;
		IL_01a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v218 @ X0_v3] (should have been resolved before IL gen)");
		int itemId = default(int);
		UIExtensions.LoadItemImage(roomTheme, itemId, ImageCacher.ItemImageType.InGame);
	}

	private void SportTeamRoomPreview(SportTeamsCelebrationTournamentAddon teamAddon)
	{
		GameObject gameObject = sportRoomTheme.gameObject;
		gameObject.SetActive(value: true);
		sportRoomTheme.Initialize(teamAddon.<sportTeam>k__BackingField);
	}

	private void UpdateSchedulingToggle()
	{
		//IL_0016: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0151: Expected O, but got I4
		//IL_017c: Expected F8, but got I4
		//IL_01aa: Expected O, but got I4
		//IL_031e: Expected O, but got I
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_044e: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EAD]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EB1]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EB1]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		TournamentConfig config = Config;
		if (config != null)
		{
			goto IL_0113;
		}
		goto IL_04aa;
		IL_04aa:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_0113:
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan = TimeSpan.FromSeconds(config.<MaxStartTime>k__BackingField);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan2 = TimeSpan.FromHours(1.0);
		bool flag4 = timeSpan < timeSpan2;
		ToggleGroupIndexer toggleGroupIndexer = schedulingMode;
		if ((object)schedulingMode != null)
		{
			Toggle[] toggles = toggleGroupIndexer.Toggles;
			if (toggleGroupIndexer.Toggles != null && (object)toggles[1] != null)
			{
				bool interactable = (byte)((flag4 ? 1u : 0u) ^ 1u) != 0;
				toggles[1].interactable = interactable;
				ToggleGroupIndexer toggleGroupIndexer2 = schedulingMode;
				if ((object)schedulingMode != null)
				{
					Toggle[] toggles2 = toggleGroupIndexer2.Toggles;
					if (toggleGroupIndexer2.Toggles != null && (object)toggles2[1] != null)
					{
						object obj10 = (nint)0 + (nint)184;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
						Behaviour behaviour = default(Behaviour);
						if ((object)behaviour != null)
						{
							bool flag5 = (byte)((flag4 ? 1u : 0u) ^ 1u) != 0;
							behaviour.enabled = flag5;
							if ((object)schedulingDisabledMessage != null)
							{
								schedulingDisabledMessage.SetActive(flag4);
								if ((object)timeLabel != null)
								{
									GameObject gameObject = timeLabel.gameObject;
									bool active;
									if (flag4)
									{
										active = false;
									}
									else
									{
										DateTimeText dateTimeText = timeLabel;
										if ((object)timeLabel == null)
										{
											goto IL_04aa;
										}
										object obj11 = typeof(DataRelation) + 712;
										object obj12 = obj11;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v23+E4]");
										bool flag6 = (nint)0 == 0;
										object obj13 = !flag6;
										if (obj13 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										DateTime now = DateTime.Now;
										bool flag7 = dateTimeText.<Date>k__BackingField >= now;
										active = flag7;
									}
									if ((object)gameObject != null)
									{
										gameObject.SetActive(active);
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_04aa;
		IL_0066:
		config = Config;
		bool flag8 = config == null;
		object obj14 = !flag8;
		if (obj14 != null)
		{
			goto IL_0113;
		}
		goto IL_04aa;
	}

	private void UpdateTournamentTypeToggle()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		ToggleGroupIndexer toggleGroupIndexer = tournamentTypeInput;
		if ((object)tournamentTypeInput != null)
		{
			Toggle[] toggles = toggleGroupIndexer.Toggles;
			if (toggleGroupIndexer.Toggles != null)
			{
				object obj = typeof(RegisteredWaitHandle) + 56;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				RemoteConfigModel current = RemoteConfig.Current;
				if (current != null)
				{
					TournamentsSection <Tournaments>k__BackingField = current.<Tournaments>k__BackingField;
					if (current.<Tournaments>k__BackingField != null && <Tournaments>k__BackingField.<Public>k__BackingField != null)
					{
						bool canCreateTournament = <Tournaments>k__BackingField.<Public>k__BackingField.CanCreateTournament;
						if ((object)toggles[0] != null)
						{
							toggles[0].interactable = canCreateTournament;
							ToggleGroupIndexer toggleGroupIndexer2 = tournamentTypeInput;
							if ((object)tournamentTypeInput != null)
							{
								Toggle[] toggles2 = toggleGroupIndexer2.Toggles;
								if (toggleGroupIndexer2.Toggles != null)
								{
									RemoteConfigModel current2 = RemoteConfig.Current;
									if (current2 != null)
									{
										TournamentsSection <Tournaments>k__BackingField2 = current2.<Tournaments>k__BackingField;
										if (current2.<Tournaments>k__BackingField != null && <Tournaments>k__BackingField2.<Private>k__BackingField != null)
										{
											bool canCreateTournament2 = <Tournaments>k__BackingField2.<Private>k__BackingField.CanCreateTournament;
											if ((object)toggles2[1] != null)
											{
												toggles2[1].interactable = canCreateTournament2;
												return;
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
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private bool ValidateInput()
	{
		if (ValidName() && ValidStartTime() && ValidSize() && ValidatePassword())
		{
			return ValidPrize();
		}
		return false;
	}

	private bool ValidPrize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0153: Expected I4, but got O
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I
		//IL_0122: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = obj2 + 24;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if ((object)prizeEditView != null)
			{
				TournamentPrizeEditView.ValidationModel validationModel = prizeEditView.GetValidationModel(this);
				object obj4 = obj2 + 16;
				obj4 = validationModel;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if ((object)prizeSelector != null)
				{
					Transform gameObj = prizeSelector.transform;
					if (obj4 != null)
					{
						object obj5 = typeof(SqlSingle[]) + 2376;
						object obj6 = (nint)0 + (nint)3776;
						bool isValid = ((TournamentPrizeEditView.ValidationModel)obj4).IsValid;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						Action action = default(Action);
						action..ctor(obj2, (IntPtr)obj6);
						return ((TournamentCreationPopup)(object)action).ValidateWithFeedback((Component)gameObj, isValid, action);
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool ValidName()
	{
		//IL_014a: Expected I4, but got O
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_007c: Expected O, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00f4: Expected O, but got I4
		//IL_010e: Expected O, but got I4
		//IL_0117: Expected I4, but got O
		if ((object)nameInput != null)
		{
			string text = nameInput.Text;
			if (text != null)
			{
				object obj = typeof(System.IOAsyncCallback) + 3096;
				string input = text.Trim();
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text2 = InputSanitizer.SanitizeHtmlTags(input);
				if ((object)nameInput != null)
				{
					nameInput.Text = text2;
					if (text2 != null)
					{
						object text3 = "startPosition" + 4056;
						LocalizableText localizableText = TextMeshProExtensions.Localize((string)text3);
						object obj4 = text2._stringLength - 3;
						bool flag2 = (nint)obj4 < 38;
						object obj5 = !flag2;
						bool condition = (byte)(int)(~obj5) != 0;
						return ((TournamentCreationPopup)(object)localizableText).ValidateWithFeedback((Component)nameInput, condition, localizableText);
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private unsafe bool ValidatePassword()
	{
		//IL_01a3: Expected I4, but got O
		//IL_009c: Expected O, but got I4
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01ec: Expected O, but got I
		//IL_01fa: Expected I, but got O
		//IL_0115: Expected O, but got I4
		//IL_018b: Expected O, but got Ref
		bool flag4;
		if ((object)tournamentTypeInput != null)
		{
			int selectedIndex = tournamentTypeInput.SelectedIndex;
			if (selectedIndex != 1)
			{
				return true;
			}
			if ((object)passwordInput != null)
			{
				string text = passwordInput.Text;
				if (text != null)
				{
					bool flag = text._stringLength < 4;
					object obj = 0;
					if (flag)
					{
						goto IL_0123;
					}
					if ((object)passwordInput != null)
					{
						string text2 = passwordInput.Text;
						if (text2 != null)
						{
							bool flag2 = text2._stringLength <= 8;
							obj = 0;
							if (!flag2)
							{
								goto IL_0123;
							}
							if ((object)passwordInput != null)
							{
								string text3 = passwordInput.Text;
								int result;
								bool flag3 = int.TryParse(text3, out result);
								flag4 = flag3;
								obj = (object)(&result);
								goto IL_01c2;
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_01c2:
		object obj2 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = (nint)0 + (nint)736;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		bool flag5 = ((TournamentCreationPopup)(object)action).ValidateWithFeedback((Component)passwordInput, flag4, action);
		return flag4;
		IL_0123:
		flag4 = false;
		goto IL_01c2;
	}

	private void OnPasswordEndEdit(string _)
	{
		string text = passwordInput.Text;
		if (text._stringLength >= 1)
		{
			UIExtensions.EnsurePin(passwordInput);
		}
	}

	private void OnPasswordValueChanged(string pwd)
	{
		UIExtensions.EnsurePin(passwordInput, pwd._stringLength);
	}

	private void EnterRandomPassword()
	{
		int num = UnityEngine.Random.Range(1000, 99999999);
		int num2 = default(int);
		string text = num2.ToString();
		passwordInput.Text = text;
	}

	private bool ValidStartTime()
	{
		//IL_0537: Expected I4, but got O
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_01c8: Expected O, but got I4
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected O, but got Unknown
		//IL_0585: Expected O, but got I
		//IL_0593: Expected I, but got O
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_03e9: Expected O, but got I
		//IL_0403: Expected O, but got I4
		//IL_0102: Expected O, but got I
		//IL_0451: Expected O, but got I4
		//IL_03a4: Expected O, but got I4
		//IL_05c9: Expected O, but got I
		//IL_05d7: Expected I, but got O
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_04ac: Expected O, but got I
		//IL_04c6: Expected O, but got I4
		//IL_028b: Expected O, but got I
		//IL_0513: Expected O, but got I4
		//IL_0309: Expected O, but got I4
		//IL_0334: Expected F8, but got I4
		//IL_0375: Expected F8, but got I4
		bool result;
		object obj;
		DateTime startTime;
		DateTime dateTime;
		DateTime dateTime2;
		bool flag5;
		DateTime dateTime3;
		object obj7;
		if ((object)tournamentTypeInput != null)
		{
			int selectedIndex = tournamentTypeInput.SelectedIndex;
			bool flag = selectedIndex == 1;
			result = (byte)selectedIndex != 0;
			if (flag)
			{
				goto IL_0556;
			}
			if ((object)schedulingMode != null)
			{
				int selectedIndex2 = schedulingMode.SelectedIndex;
				obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
				if (selectedIndex2 != 0)
				{
					startTime = StartTime;
					object obj2 = typeof(DataRelation) + 712;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v49+E4]");
					if ((nint)0 != 0)
					{
						DateTime now = DateTime.Now;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EB0]");
						object obj4 = (nint)0 & (nint)1;
						bool flag2 = obj4 == null;
						dateTime = now;
						dateTime2 = now;
						if (!flag2)
						{
							goto IL_012f;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						DateTime now2 = DateTime.Now;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EB0]");
						object obj5 = (nint)0 & (nint)1;
						bool flag3 = obj5 == null;
						object obj6 = !flag3;
						dateTime = now2;
						dateTime2 = now2;
						if (obj6 != null)
						{
							goto IL_012f;
						}
					}
					_ = 1;
					obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v50+E4]");
					bool flag4 = (nint)0 == 0;
					object obj8 = !flag4;
					dateTime = dateTime2;
					if (obj8 != null)
					{
						goto IL_0164;
					}
					goto IL_0467;
				}
				dateTime3 = (DateTime)0;
				flag5 = true;
				goto IL_055b;
			}
		}
		goto IL_0529;
		IL_0467:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		dateTime = dateTime2;
		goto IL_0164;
		IL_0164:
		TimeSpan timeSpan = TimeSpan.FromHours(1.0);
		DateTime dateTime4 = dateTime + timeSpan;
		bool flag6 = startTime > dateTime4;
		double num = 1.0;
		dateTime3 = dateTime4;
		flag5 = flag6;
		goto IL_055b;
		IL_055b:
		object obj9 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)720;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj10);
		bool flag7 = ((TournamentCreationPopup)(object)action).ValidateWithFeedback((Component)tournamentOptionsButton, flag5, action);
		bool flag9;
		DateTime startTime2;
		DateTime dateTime6;
		TournamentConfig config;
		bool flag8;
		DateTime dateTime5;
		if ((object)schedulingMode != null)
		{
			if (schedulingMode.SelectedIndex == 0)
			{
				flag8 = flag5;
				flag9 = true;
				dateTime5 = (DateTime)0;
				goto IL_05b3;
			}
			startTime2 = StartTime;
			object obj11 = typeof(DataRelation) + 712;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v22+E4]");
			DateTime dateTime7;
			if ((nint)0 != 0)
			{
				DateTime now3 = DateTime.Now;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EB1]");
				object obj13 = (nint)0 & (nint)1;
				bool flag10 = obj13 == null;
				dateTime6 = now3;
				dateTime7 = now3;
				if (!flag10)
				{
					goto IL_02b8;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				DateTime now4 = DateTime.Now;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EB1]");
				object obj14 = (nint)0 & (nint)1;
				bool flag11 = obj14 == null;
				object obj15 = !flag11;
				dateTime6 = now4;
				dateTime7 = now4;
				if (obj15 != null)
				{
					goto IL_02b8;
				}
			}
			_ = 1;
			config = Config;
			bool flag12 = config == null;
			object obj16 = !flag12;
			dateTime6 = dateTime7;
			if (obj16 != null)
			{
				goto IL_02df;
			}
		}
		goto IL_0529;
		IL_0529:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_02df:
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v33+E4]");
		bool flag13 = (nint)0 == 0;
		object obj18 = !flag13;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan2 = TimeSpan.FromSeconds(config.<MaxStartTime>k__BackingField);
		DateTime dateTime8 = dateTime6 + timeSpan2;
		bool flag14 = startTime2 < dateTime8;
		flag8 = false;
		num = config.<MaxStartTime>k__BackingField;
		flag9 = flag14;
		dateTime5 = dateTime8;
		goto IL_05b3;
		IL_0556:
		return result;
		IL_05b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = (nint)0 + (nint)728;
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj19);
		bool flag15 = ((TournamentCreationPopup)(object)action2).ValidateWithFeedback((Component)tournamentOptionsButton, flag9, action2);
		result = flag5 && flag9;
		goto IL_0556;
		IL_02b8:
		config = Config;
		if (config != null)
		{
			goto IL_02df;
		}
		goto IL_0529;
		IL_012f:
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v50+E4]");
		bool flag16 = (nint)0 == 0;
		dateTime2 = dateTime;
		if (!flag16)
		{
			goto IL_0164;
		}
		goto IL_0467;
	}

	private bool ValidSize()
	{
		//IL_020e: Expected I4, but got O
		//IL_00a5: Expected O, but got I4
		//IL_00ae: Expected O, but got I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_0261: Expected O, but got I
		//IL_0279: Expected I, but got O
		//IL_0162: Expected O, but got I4
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected I4, but got Unknown
		//IL_01cf: Expected O, but got I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected I4, but got Unknown
		//IL_01ed: Expected O, but got I4
		//IL_01f6: Expected O, but got I4
		TournamentConfig config = Config;
		KDropMenu kDropMenu = sizeInput;
		bool condition;
		if ((object)sizeInput != null && config != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3 (KDropMenu)+34]");
			int size = config.GetSize(0);
			TournamentConfig config2 = Config;
			if (config2 != null)
			{
				int minSize = config2.MinSize;
				if (size < minSize)
				{
					condition = false;
					object obj = 0;
					object obj2 = 0;
					goto IL_0241;
				}
				TournamentConfig config3 = Config;
				KDropMenu kDropMenu2 = sizeInput;
				if ((object)sizeInput != null && config3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v8 (KDropMenu)+34]");
					int size2 = config3.GetSize(0);
					TournamentConfig config4 = Config;
					if (config4 != null)
					{
						int maxSize = config4.MaxSize;
						object obj3 = size2 - maxSize;
						bool flag = (nint)obj3 < 0;
						bool flag2 = obj3 == null;
						int num = size2 ^ maxSize;
						int num2 = size2 ^ obj3;
						int num3 = num & num2;
						bool flag3 = num3 < 0;
						bool flag4 = flag == flag3;
						object obj4 = !flag4;
						bool flag5 = (byte)((obj4 | flag2) ? 1 : 0) != 0;
						condition = flag5;
						object obj = 0;
						object obj2 = 0;
						goto IL_0241;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0241:
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		return ((TournamentCreationPopup)(object)action).ValidateWithFeedback((Component)tournamentOptionsButton, condition, action);
	}

	private bool ValidateWithFeedback(Component gameObj, bool condition, LocalizableText errorFeedback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00aa: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(SqlSingle[]) + 2376;
			object obj4 = (nint)0 + (nint)3784;
			object obj5 = obj2 + 16;
			obj5 = errorFeedback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj4);
			return ((TournamentCreationPopup)(object)action).ValidateWithFeedback(gameObj, condition, action);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool ValidateWithFeedback(Component gameObj, bool condition, Action errorFeedback)
	{
		//IL_0249: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00e7: Expected O, but got I4
		//IL_00f0: Expected O, but got I4
		//IL_006a: Expected O, but got I4
		//IL_0073: Expected O, but got I4
		//IL_007c: Expected O, but got I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_01fa: Expected O, but got I4
		//IL_0181: Expected O, but got I4
		bool flag = !condition;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v4+E4]");
			object obj6;
			if ((nint)0 != 0)
			{
				bool flag2 = gameObj != null;
				bool flag3 = !flag2;
				object obj4 = !flag3;
				object obj5 = 0;
				obj6 = 0;
				if (obj4 == null)
				{
					goto IL_008a;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag4 = gameObj != null;
				bool flag5 = !flag4;
				object obj5 = 0;
				obj6 = 0;
				if (flag5)
				{
					goto IL_008a;
				}
			}
			RectTransform rect = UIExtensions.rectTransform(gameObj);
			object obj7 = typeof(SqlSingle[]) + 3912;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v9+E4]");
			if ((nint)0 != 0)
			{
				AnimationExtensions.ErrorFeedback(rect);
				bool flag6 = errorFeedback == null;
				object obj9 = !flag6;
				double num = 0.5;
				double num2 = 15.0;
				object obj5 = obj6;
				if (obj9 != null)
				{
					goto IL_00a7;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				AnimationExtensions.ErrorFeedback(rect);
				bool flag7 = errorFeedback == null;
				object obj10 = !flag7;
				double num = 0.5;
				double num2 = 15.0;
				object obj5 = obj6;
				if (obj10 != null)
				{
					goto IL_00a7;
				}
			}
		}
		goto IL_0257;
		IL_0257:
		return condition;
		IL_008a:
		if (errorFeedback != null)
		{
			goto IL_00a7;
		}
		goto IL_0257;
		IL_00a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: errorFeedback.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		goto IL_0257;
	}

	public float GetFeePercent()
	{
		TournamentConfig config = Config;
		return config.<CreationFee>k__BackingField;
	}

	public int GetMinimumPrize()
	{
		//IL_00b9: Expected I4, but got O
		TournamentConfig config = Config;
		TournamentConfig config2 = Config;
		KDropMenu kDropMenu = sizeInput;
		if ((object)sizeInput != null && config2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1 (KDropMenu)+34]");
			int size = config2.GetSize(0);
			if (config != null)
			{
				return config.GetPrizeForSize(size);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public int GetFixedFeeCost()
	{
		//IL_00b9: Expected I4, but got O
		TournamentConfig config = Config;
		TournamentConfig config2 = Config;
		KDropMenu kDropMenu = sizeInput;
		if ((object)sizeInput != null && config2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1 (KDropMenu)+34]");
			int size = config2.GetSize(0);
			if (config != null)
			{
				return config.GetFixedFeeForSize(size);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private TimeSpan GetInstantTournamentStartTime()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0075: Expected F8, but got I4
		//IL_0054: Expected F8, but got I4
		TournamentConfig config = Config;
		if (config != null)
		{
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				return TimeSpan.FromMinutes(config.<InstantTournamentStartTime>k__BackingField);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return TimeSpan.FromMinutes(config.<InstantTournamentStartTime>k__BackingField);
		}
		return (TimeSpan)new NullReferenceException();
	}

	private TimeSpan GetMinimumTimeBeforeStart()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00bb: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EB0]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return TimeSpan.FromHours(1.0);
		IL_0074:
		return TimeSpan.FromHours(1.0);
	}

	private TimeSpan GetMaximumTimeBeforeStart()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0075: Expected F8, but got I4
		//IL_0054: Expected F8, but got I4
		TournamentConfig config = Config;
		if (config != null)
		{
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				return TimeSpan.FromSeconds(config.<MaxStartTime>k__BackingField);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return TimeSpan.FromSeconds(config.<MaxStartTime>k__BackingField);
		}
		return (TimeSpan)new NullReferenceException();
	}

	private int GetMinimumSize()
	{
		//IL_0047: Expected I4, but got O
		TournamentConfig config = Config;
		if (config != null)
		{
			return config.MinSize;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private int GetMaximumSize()
	{
		//IL_0047: Expected I4, but got O
		TournamentConfig config = Config;
		if (config != null)
		{
			return config.MaxSize;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private void <OnConfigChanged>b__114_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e1: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E24]");
		object obj3 = (nint)0 & (nint)1;
		GameObject gameObject;
		UnityEngine.Object obj5;
		if (obj3 != null)
		{
			gameObject = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = gameObject;
			object obj6 = 0;
			if (!flag)
			{
				goto IL_0098;
			}
		}
		else
		{
			_ = 1;
			gameObject = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = gameObject;
			object obj6 = 0;
			if (obj7 != null)
			{
				goto IL_0098;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.Destroy(gameObject);
		return;
		IL_0098:
		UnityEngine.Object.Destroy(obj5);
	}

	private void <ValidatePassword>b__133_0()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I4
		//IL_014f: Expected O, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0098: Expected O, but got I4
		//IL_013b: Expected O, but got I4
		string text = passwordInput.Text;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		if (text._stringLength > 0)
		{
			object text2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 24;
			LocalizableText text3 = TextMeshProExtensions.Localize((string)text2);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Toast.Show(text3, (Vector2)0, 0f);
			return;
		}
		object text4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 32;
		LocalizableText text5 = TextMeshProExtensions.Localize((string)text4);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show(text5, (Vector2)0, 0f);
		int num = UnityEngine.Random.Range(1000, 99999999);
		int num2 = default(int);
		string text6 = num2.ToString();
		passwordInput.Text = text6;
	}

	private void <ValidStartTime>b__137_0()
	{
		string text = startTimeInput.Text;
		OnStartTimeChanged(text);
	}

	private void <ValidStartTime>b__137_1()
	{
		string text = startTimeInput.Text;
		OnStartTimeChanged(text);
	}

	private void <ValidSize>b__138_0()
	{
		TournamentConfig config = Config;
		KDropMenu kDropMenu = sizeInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X8_v1 (KDropMenu)+34]");
		int size = config.GetSize(0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X8_v1 (KDropMenu)+34]");
		OnTournamentSizeChanged(0);
	}
}
