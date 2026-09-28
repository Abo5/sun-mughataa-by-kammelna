using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Kammelna.Server.WebRequests;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;
using Util.SystemHelpers;

public class PlayerProfileControls : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action <>9__49_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <FakeReport>b__49_0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected O, but got Unknown
			//IL_0091: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object title = "DNQUALIFIER" + 3784;
			object body = "Read object reference Id '{0}' for {1}." + 2312;
			object buttonText = "Network Authentication Required" + 3128;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.ShowInfo((string)title, (string)body, (string)buttonText);
		}
	}

	private sealed class <>c__DisplayClass37_0
	{
		public Action<KammelnaError> errorCallback;

		internal unsafe void <Populate>b__0(KammelnaError error)
		{
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0061: Expected O, but got I4
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Expected O, but got Unknown
			//IL_0227: Expected I, but got O
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00c1: Expected O, but got Ref
			//IL_025a: Expected I, but got O
			//IL_00e6: Expected O, but got Ref
			//IL_027f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0284: Expected O, but got Unknown
			//IL_0290: Expected O, but got I
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Expected O, but got Unknown
			//IL_02ac: Expected I, but got O
			//IL_02bc: Expected O, but got I
			//IL_00fc: Expected I, but got O
			//IL_010c: Expected O, but got I
			//IL_0135: Expected O, but got I
			//IL_0464: Expected O, but got I4
			//IL_02f7: Expected O, but got I
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Expected O, but got Unknown
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_0361: Unknown result type (might be due to invalid IL or missing references)
			//IL_0366: Expected O, but got Unknown
			//IL_036e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0373: Expected O, but got Unknown
			//IL_037c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0381: Expected O, but got Unknown
			//IL_0386: Expected I, but got O
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Expected O, but got Unknown
			//IL_0313: Unknown result type (might be due to invalid IL or missing references)
			//IL_0318: Expected O, but got Unknown
			string text;
			LocalizableText localizableText;
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			string text2;
			if (error == KammelnaError.UserNotFound)
			{
				object obj = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v30+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Games currentGame = Preferences.CurrentGame;
				object obj5 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object[] array = default(object[]);
				bool flag2 = array == null;
				Games games = default(Games);
				text = (string)(&games);
				if (flag2)
				{
					goto IL_039a;
				}
				object obj6 = default(object);
				bool flag3 = obj6 == null;
				text = (string)(&games);
				if (!flag3)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag4 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
					text2 = (string)0;
					if (flag4)
					{
						goto IL_03be;
					}
				}
				if (array.Length == 0)
				{
					goto IL_03a8;
				}
				object obj7 = array + 32;
				obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object text3 = "Unsupported map type" + 664;
				localizableText = TextMeshProExtensions.LocalizeArguments((string)text3, array);
			}
			else
			{
				object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				Enum enumeration = default(Enum);
				string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
				localizableText = TextMeshProExtensions.Localize(friendlyName);
			}
			object obj9 = "Network Authentication Required" + 3128;
			text = (string)obj9;
			PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateError(null, (string)obj9);
			bool flag5 = popupWindowBuilder == null;
			nint num2 = unchecked((nint)null);
			object obj12;
			nint num4;
			object obj17;
			if (!flag5)
			{
				IPopupWindowBuilderAttributes popupWindowBuilderAttributes = popupWindowBuilder.WithContent(localizableText);
				bool flag6 = popupWindowBuilderAttributes == null;
				num2 = unchecked((nint)null);
				text = (string)(object)localizableText;
				if (!flag6)
				{
					object obj10 = typeof(System.IOAsyncCallback) + 368;
					object obj11 = (nint)0 + (nint)2216;
					obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
					nint num3 = (nint)popupWindowBuilderAttributes;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v11 (Il2CppClass<IPopupWindowBuilderAttributes>)+12E]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v11 (Il2CppClass<IPopupWindowBuilderAttributes>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0338;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v11 (Il2CppClass<IPopupWindowBuilderAttributes>)+B0]");
					object obj14 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X10_v5-8]");
						if (0 == (nint)obj10)
						{
							break;
						}
						obj14 += 16;
						obj13--;
						if ((nint)obj13 != 1)
						{
							continue;
						}
						goto IL_0338;
					}
					object obj15 = obj14 + 9;
					object obj16 = num3 + obj15;
					obj17 = obj16 + 312;
					num4 = unchecked((nint)null);
					goto IL_0418;
				}
			}
			goto IL_039a;
			IL_0418:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v317 @ X8_v12] (should have been resolved before IL gen)");
			Actions.SafeInvoke((Action<System.Int32Enum>)(object)errorCallback, (System.Int32Enum)error);
			ITrackEvent trackEvent = TrackerLibrary.ProfileMiniProfileLoadError();
			object obj18 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v13+E4]");
			bool flag7 = (nint)0 == 0;
			object obj19 = !flag7;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			return;
			IL_03a8:
			ex = new IndexOutOfRangeException();
			text2 = text;
			goto IL_03be;
			IL_0338:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num4 = 9;
			object obj20 = default(object);
			obj17 = obj20;
			goto IL_0418;
			IL_03be:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
			throw new OutOfMemoryException();
			IL_039a:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_03a8;
		}
	}

	private sealed class <>c__DisplayClass39_0
	{
		public string userId;

		public PlayerProfileControls <>4__this;

		public Func<User, bool> <>9__1;

		internal unsafe void <PopulateFromSFS>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0011: Expected O, but got I
			//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e2: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_007d: Expected O, but got I4
			//IL_032e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0333: Expected O, but got Unknown
			//IL_034c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0351: Expected O, but got Unknown
			//IL_037b: Expected O, but got I4
			//IL_00a6: Expected O, but got I
			//IL_051a: Unknown result type (might be due to invalid IL or missing references)
			//IL_051f: Expected O, but got Unknown
			//IL_0541: Expected I, but got O
			//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b5: Expected O, but got Unknown
			//IL_03db: Expected O, but got Ref
			//IL_057c: Expected I, but got O
			//IL_0400: Expected O, but got Ref
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Expected O, but got Unknown
			//IL_0118: Expected I, but got O
			//IL_0128: Expected O, but got I
			//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a6: Expected O, but got Unknown
			//IL_05ae: Expected I, but got O
			//IL_05be: Expected O, but got I
			//IL_01be: Expected O, but got I
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Expected O, but got Unknown
			//IL_0416: Expected I, but got O
			//IL_0426: Expected O, but got I
			//IL_044f: Expected O, but got I
			//IL_0731: Unknown result type (might be due to invalid IL or missing references)
			//IL_0736: Expected O, but got Unknown
			//IL_074c: Expected O, but got I
			//IL_075a: Expected I, but got O
			//IL_0163: Expected O, but got I
			//IL_08e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e7: Expected O, but got Unknown
			//IL_0911: Expected O, but got I4
			//IL_05f9: Expected O, but got I
			//IL_048d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0492: Expected O, but got Unknown
			//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b3: Expected O, but got Unknown
			//IL_077f: Expected O, but got I
			//IL_0787: Expected I, but got O
			//IL_0215: Expected O, but got I
			//IL_021d: Expected I, but got O
			//IL_0255: Expected I, but got O
			//IL_07b7: Expected O, but got I4
			//IL_07c0: Expected O, but got I4
			//IL_07d1: Expected O, but got I4
			//IL_07d9: Expected I, but got O
			//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_06aa: Expected O, but got Unknown
			//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b7: Expected O, but got Unknown
			//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c5: Expected O, but got Unknown
			//IL_06d5: Expected O, but got I
			//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ea: Expected O, but got Unknown
			//IL_070c: Expected O, but got I4
			//IL_0663: Unknown result type (might be due to invalid IL or missing references)
			//IL_0668: Expected O, but got Unknown
			//IL_0670: Unknown result type (might be due to invalid IL or missing references)
			//IL_0675: Expected O, but got Unknown
			//IL_067e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0683: Expected O, but got Unknown
			//IL_0688: Expected I, but got O
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Expected O, but got Unknown
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Expected O, but got Unknown
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Expected O, but got Unknown
			//IL_0607: Unknown result type (might be due to invalid IL or missing references)
			//IL_060c: Expected O, but got Unknown
			//IL_0615: Unknown result type (might be due to invalid IL or missing references)
			//IL_061a: Expected O, but got Unknown
			//IL_02c1: Expected O, but got I4
			bool flag = response == null;
			User user = (User)response;
			Func<object, bool> func;
			IEnumerable<object> source;
			IEnumerable<object> enumerable = default(IEnumerable<object>);
			nint num5;
			object obj29;
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			object obj12;
			object obj13;
			nint num3;
			if (!flag)
			{
				object obj = (nint)0 + (nint)1048;
				user = (User)obj;
				if (response.Succeeded)
				{
					object obj2 = typeof(Queue<string>) + 848;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v46+E4]");
					bool flag2 = (nint)0 == 0;
					object obj4 = !flag2;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj5 = (nint)0 + (nint)2200;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel = default(SessionModel);
					if ((object)sessionModel != null)
					{
						Room currentRoom = sessionModel.CurrentRoom;
						bool flag3 = currentRoom == null;
						user = null;
						if (!flag3)
						{
							object obj6 = typeof(RegisteredWaitHandle) + 1376;
							nint num = (nint)currentRoom;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v44 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
							object obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v44 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_01a4;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v44 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
							object obj8 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X10_v17-8]");
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
								goto IL_01a4;
							}
							object obj9 = obj8 + 28;
							object obj10 = num + obj9;
							object obj11 = obj10 + 312;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v61+8]");
							obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v506 @ X8_v61] (should have been resolved before IL gen)");
							obj13 = this + 32;
							func = (Func<object, bool>)obj13;
							bool flag4 = obj13 == null;
							object obj14 = !flag4;
							source = enumerable;
							if (obj14 != null)
							{
								goto IL_0209;
							}
							goto IL_0722;
						}
						goto IL_07ef;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Boolean>)+14]");
					LocalizableText localizableText;
					if ((nint)0 == 2000)
					{
						object obj15 = typeof(TypeConverter<ushort, char>) + 3400;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						object obj16 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
						object obj17 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v31+E4]");
						bool flag5 = (nint)0 == 0;
						object obj18 = !flag5;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Games currentGame = Preferences.CurrentGame;
						object obj19 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object[] array = default(object[]);
						bool flag6 = array == null;
						Games games = default(Games);
						user = (User)(&games);
						if (flag6)
						{
							goto IL_0821;
						}
						object obj20 = default(object);
						bool flag7 = obj20 == null;
						User user2 = (User)(&games);
						if (!flag7)
						{
							nint num2 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v35 (Il2CppClass<System.Object[]>)+40]");
							user2 = (User)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag8 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v35 (Il2CppClass<System.Object[]>)+40]");
							user = (User)0;
							if (flag8)
							{
								goto IL_083d;
							}
						}
						bool flag9 = array.Length == 0;
						user = user2;
						if (flag9)
						{
							goto IL_082f;
						}
						object obj21 = array + 32;
						obj21 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object text = "Unsupported map type" + 664;
						localizableText = TextMeshProExtensions.LocalizeArguments((string)text, array);
					}
					else
					{
						object obj22 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						Enum enumeration = default(Enum);
						string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
						localizableText = TextMeshProExtensions.Localize(friendlyName);
					}
					object obj23 = "Network Authentication Required" + 3128;
					PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateError(null, (string)obj23);
					bool flag10 = popupWindowBuilder == null;
					num3 = unchecked((nint)null);
					user = (User)obj23;
					if (!flag10)
					{
						IPopupWindowBuilderAttributes popupWindowBuilderAttributes = popupWindowBuilder.WithContent(localizableText);
						bool flag11 = popupWindowBuilderAttributes == null;
						num3 = unchecked((nint)null);
						user = (User)localizableText;
						if (!flag11)
						{
							object obj24 = typeof(System.IOAsyncCallback) + 368;
							nint num4 = (nint)popupWindowBuilderAttributes;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v14 (Il2CppClass<IPopupWindowBuilderAttributes>)+12E]");
							object obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v14 (Il2CppClass<IPopupWindowBuilderAttributes>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_063a;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v14 (Il2CppClass<IPopupWindowBuilderAttributes>)+B0]");
							object obj26 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X10_v8-8]");
								if (0 == (nint)obj24)
								{
									break;
								}
								obj26 += 16;
								obj25--;
								if ((nint)obj25 != 1)
								{
									continue;
								}
								goto IL_063a;
							}
							object obj27 = obj26 + 9;
							object obj28 = num4 + obj27;
							obj29 = obj28 + 312;
							num5 = unchecked((nint)null);
							goto IL_08c0;
						}
					}
				}
			}
			goto IL_0821;
			IL_0722:
			object obj30 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj31 = (nint)0 + (nint)832;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor((object)this, (IntPtr)obj31);
			<>9__1 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj32 = (nint)0 + (nint)1368;
			nint num6 = (nint)obj32;
			object obj33 = Enumerable.FirstOrDefault(source, func2);
			bool flag12 = obj33 == null;
			object obj34 = !flag12;
			object obj35 = 0;
			Func<object, bool> func3 = func2;
			object obj36 = 0;
			num3 = (nint)obj32;
			user = (User)(object)func2;
			if (obj34 != null)
			{
				goto IL_026b;
			}
			goto IL_07ef;
			IL_0209:
			object obj37 = (nint)0 + (nint)1368;
			num6 = (nint)obj37;
			obj33 = Enumerable.FirstOrDefault(enumerable, func);
			bool flag13 = obj33 == null;
			obj35 = obj36;
			func3 = func;
			num3 = (nint)obj37;
			user = (User)(object)func;
			if (!flag13)
			{
				goto IL_026b;
			}
			goto IL_07ef;
			IL_026b:
			object obj38 = typeof(System.Buffers.Text.ParserHelpers) + 1048;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object user3 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Boolean>)+30]");
			PlayerProfileModel playerProfileModel = default(PlayerProfileModel);
			playerProfileModel..ctor((User)user3, isLiked: false);
			bool flag14 = (object)<>4__this == null;
			obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Boolean>)+30]");
			num3 = 0;
			user = (User)obj33;
			if (!flag14)
			{
				<>4__this.Populate(playerProfileModel);
				return;
			}
			goto IL_0821;
			IL_07ef:
			if ((object)<>4__this != null)
			{
				<>4__this.Populate(userId);
				return;
			}
			goto IL_0821;
			IL_063a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num5 = 9;
			object obj39 = default(object);
			obj29 = obj39;
			goto IL_08c0;
			IL_0821:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_082f;
			IL_08c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v632 @ X8_v15] (should have been resolved before IL gen)");
			ITrackEvent trackEvent = TrackerLibrary.ProfileMiniProfileLoadError();
			object obj40 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj41 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v18+E4]");
			bool flag15 = (nint)0 == 0;
			object obj42 = !flag15;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			return;
			IL_083d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
			throw new OutOfMemoryException();
			IL_082f:
			ex = new IndexOutOfRangeException();
			goto IL_083d;
			IL_01a4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v66+8]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v461 @ X0_v66] (should have been resolved before IL gen)");
			obj13 = this + 32;
			func = (Func<object, bool>)obj13;
			bool flag16 = obj13 == null;
			num3 = 28;
			source = enumerable;
			if (!flag16)
			{
				goto IL_0209;
			}
			goto IL_0722;
		}

		internal bool <PopulateFromSFS>b__1(User u)
		{
			string dbId = SFSKammelnaUserExtensions.GetDbId(u);
			return dbId == userId;
		}
	}

	private sealed class <>c__DisplayClass46_0
	{
		public string message;

		public PlayerProfileControls <>4__this;

		internal void <Add>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0011: Expected O, but got I
			//IL_013c: Expected O, but got I
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			//IL_0187: Expected O, but got I4
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0079: Expected O, but got I4
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Expected O, but got Unknown
			//IL_0113: Expected O, but got I4
			object obj = (nint)0 + (nint)1048;
			if (response.Succeeded)
			{
				object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v14+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object title = "DNQUALIFIER" + 3784;
				object buttonText = "Network Authentication Required" + 3128;
				PopupWindow.ShowInfo((string)title, message, (string)buttonText);
				ITrackEvent trackEvent = TrackerLibrary.ProfileMiniProfileAddFriend();
				object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v21+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
			}
			else
			{
				object obj8 = (nint)0 + (nint)1024;
				string errorMessage = response.ErrorMessage;
				object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v11+E4]");
				bool flag3 = (nint)0 == 0;
				object obj11 = !flag3;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PopupWindow.ShowError(errorMessage);
			}
			<>4__this.UpdateButtonsState();
		}
	}

	private sealed class <>c__DisplayClass51_0
	{
		public int userId;

		public PlayerProfileControls <>4__this;

		internal void <Block>g__AttemptBlock|0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_0070: Expected I, but got O
			//IL_009a: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
			object obj2 = (nint)0 + (nint)848;
			object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj2);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			FriendsManager.BlockUser(userId, action);
		}

		internal void <Block>b__1(KammelnaResponseModel<bool> response)
		{
			//IL_0011: Expected O, but got I
			//IL_00e6: Expected O, but got I
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected O, but got Unknown
			//IL_0131: Expected O, but got I4
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0079: Expected O, but got I4
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected O, but got Unknown
			object obj = (nint)0 + (nint)1048;
			if (response.Succeeded)
			{
				object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v14+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object title = "DNQUALIFIER" + 3784;
				object body = "Unsupported map type" + 632;
				object buttonText = "Network Authentication Required" + 3128;
				PopupWindow.ShowInfo((string)title, (string)body, (string)buttonText);
			}
			else
			{
				object obj5 = (nint)0 + (nint)1024;
				string errorMessage = response.ErrorMessage;
				object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v11+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PopupWindow.ShowError(errorMessage);
			}
			<>4__this.UpdateButtonsState();
		}
	}

	private sealed class <>c__DisplayClass53_0
	{
		public int userId;

		public PlayerProfileControls <>4__this;

		public Action<KammelnaResponseModel<bool>> <>9__1;

		internal void <Remove>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Expected O, but got Unknown
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected O, but got Unknown
			//IL_014a: Expected O, but got I4
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Expected O, but got Unknown
			//IL_019a: Expected O, but got I
			//IL_01a8: Expected I, but got O
			//IL_01eb: Expected O, but got I4
			object obj = 152989696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E783B]");
			object obj2 = (nint)0 & (nint)1;
			object obj3;
			Action<object> action;
			int num;
			object obj5;
			int num2;
			if (obj2 != null)
			{
				obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
				object obj4 = this + 32;
				action = (Action<object>)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v2-10]");
				num = 0;
				bool flag = obj4 == null;
				obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v2-10]");
				num2 = 0;
				if (!flag)
				{
					goto IL_00a8;
				}
			}
			else
			{
				_ = 1;
				obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
				object obj4 = this + 32;
				action = (Action<object>)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v2-10]");
				num = 0;
				bool flag2 = obj4 == null;
				object obj6 = !flag2;
				obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v2-10]");
				num2 = 0;
				if (obj6 != null)
				{
					goto IL_00a8;
				}
			}
			object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj8 = (nint)0 + (nint)872;
			Action<object> action2 = default(Action<object>);
			action2..ctor((object)this, (IntPtr)obj8);
			<>9__1 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v1+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			action = action2;
			num = num2;
			Action<object> action3 = action2;
			if (obj10 != null)
			{
				goto IL_00e5;
			}
			goto IL_0211;
			IL_00e5:
			FriendsManager.RemoveFriend(num, action);
			return;
			IL_0211:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			action = action3;
			num = num2;
			goto IL_00e5;
			IL_00a8:
			obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v1+E4]");
			bool flag4 = (nint)0 == 0;
			action3 = action;
			num2 = num;
			if (!flag4)
			{
				goto IL_00e5;
			}
			goto IL_0211;
		}

		internal void <Remove>b__1(KammelnaResponseModel<bool> response)
		{
			//IL_0011: Expected O, but got I
			//IL_00e6: Expected O, but got I
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected O, but got Unknown
			//IL_0131: Expected O, but got I4
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0079: Expected O, but got I4
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected O, but got Unknown
			object obj = (nint)0 + (nint)1048;
			if (response.Succeeded)
			{
				object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v14+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object title = "DNQUALIFIER" + 3784;
				object body = "Read object reference Id '{0}' for {1}." + 1672;
				object buttonText = "Network Authentication Required" + 3128;
				PopupWindow.ShowInfo((string)title, (string)body, (string)buttonText);
			}
			else
			{
				object obj5 = (nint)0 + (nint)1024;
				string errorMessage = response.ErrorMessage;
				object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v11+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PopupWindow.ShowError(errorMessage);
			}
			<>4__this.UpdateButtonsState();
		}
	}

	private sealed class <>c__DisplayClass56_0
	{
		public BanRequestModel requestModel;

		public string message;

		public PlayerProfileControls <>4__this;

		public Action<KammelnaResponseModel<bool>> <>9__1;

		internal void <MuteAndZeroCurrency>b__0()
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_00a6: Expected O, but got I4
			//IL_0078: Expected O, but got I
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_002f: Expected O, but got I
			//IL_003d: Expected I, but got O
			object obj = this + 40;
			Action<object> callback = (Action<object>)obj;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj4 = (nint)0 + (nint)888;
				Action<object> action = default(Action<object>);
				action..ctor((object)this, (IntPtr)obj4);
				<>9__1 = action;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				callback = action;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X21_v2-18]");
			KammelnaRequests.PunishBeggar((BanRequestModel)0, callback);
		}

		internal void <MuteAndZeroCurrency>b__1(KammelnaResponseModel<bool> response)
		{
			//IL_0011: Expected O, but got I
			//IL_0116: Expected O, but got I
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected O, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0079: Expected O, but got I4
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected O, but got Unknown
			object obj = (nint)0 + (nint)1048;
			if (response.Succeeded)
			{
				object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object title = "DNQUALIFIER" + 3784;
				object body = "AvailableVoices" + 1344;
				object buttonText = "Network Authentication Required" + 3128;
				PopupWindow.ShowInfo((string)title, (string)body, (string)buttonText);
				PlayerProfileControls playerProfileControls = <>4__this;
				PlayerProfileModel profile = playerProfileControls._profile;
				SFS.AnnounceBeggarBan(message, profile.<userDbId>k__BackingField);
			}
			else
			{
				object obj5 = (nint)0 + (nint)1024;
				string errorMessage = response.ErrorMessage;
				object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v10+E4]");
				if ((nint)0 != 0)
				{
					PopupWindow.ShowError(errorMessage);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				PopupWindow.ShowError(errorMessage);
			}
		}
	}

	private sealed class <>c__DisplayClass59_0
	{
		public int userId;

		public PlayerProfileControls <>4__this;

		public Action<KammelnaResponseModel<bool>> <>9__1;

		internal void <RemoveBio>b__0()
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_00a6: Expected O, but got I4
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_002f: Expected O, but got I
			//IL_003d: Expected I, but got O
			object obj = this + 32;
			Action<object> callback = (Action<object>)obj;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj4 = (nint)0 + (nint)904;
				Action<object> action = default(Action<object>);
				action..ctor((object)this, (IntPtr)obj4);
				<>9__1 = action;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				callback = action;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X21_v2-10]");
			KammelnaRequests.RemoveBio(0, callback);
		}

		internal void <RemoveBio>b__1(KammelnaResponseModel<bool> response)
		{
			if (response.Succeeded)
			{
				<>4__this.PopulateBio(null);
			}
		}
	}

	private sealed class <>c__DisplayClass60_0
	{
		public int userId;

		public PlayerProfileControls <>4__this;

		public Action<KammelnaResponseModel<bool>> <>9__1;

		internal void <RemoveAvatar>b__0()
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_00a6: Expected O, but got I4
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_002f: Expected O, but got I
			//IL_003d: Expected I, but got O
			object obj = this + 32;
			Action<object> callback = (Action<object>)obj;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj4 = (nint)0 + (nint)920;
				Action<object> action = default(Action<object>);
				action..ctor((object)this, (IntPtr)obj4);
				<>9__1 = action;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				callback = action;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X21_v2-10]");
			KammelnaRequests.RemoveAvatar(0, callback);
		}

		internal void <RemoveAvatar>b__1(KammelnaResponseModel<bool> response)
		{
			if (response.Succeeded)
			{
				<>4__this.PopulateProfile();
			}
		}
	}

	private const string NoGameSpecificAccountMessage = "User doesn't have account in {0} game";

	private AvatarInitializer avatar;

	private Button like;

	private Button add;

	private Button challengeUserButton;

	private CanvasGroup blockerGroup;

	private RotatingLoadingIndicator loadingIndicator;

	private ComponentReference<CommunityBadgeScreenshot> communityBadgeScreenshot;

	private Button report;

	private TextMeshProUGUI bio;

	private Button gift;

	private Button block;

	private Button unblock;

	private Button remove;

	private Button preview;

	private Button mod;

	private Button muteAndZeroCurrency;

	private Button adminPage;

	private Button generateBadge;

	private TextMeshProUGUI aces;

	private ComponentReference<ModeratorControl> modControlRef;

	private Button removeBio;

	private Button removeAvatar;

	private ChallengeEventsChannel eventsChannel;

	private MonthlyTrophyUISetter _monthlyTrophyUISetter;

	private PlayerProfileModel _profile;

	private bool _alreadyReported;

	private const string CurrencyBegging = "Currency Begging";

	private bool IsMyProfile
	{
		get
		{
			//IL_00e6: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Expected O, but got I
			//IL_004f: Expected O, but got I4
			//IL_00c4: Expected O, but got I8
			PlayerProfileModel profile = _profile;
			if (_profile != null)
			{
				object obj = typeof(Queue<string>) + 848;
				object obj2 = (nint)0 + (nint)2200;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				if ((object)sessionModel != null)
				{
					User localUser = sessionModel.LocalUser;
					int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
					object obj5 = profile.<userDbId>k__BackingField - intDbId;
					return obj5 == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private string BioDefault
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_0061: Expected O, but got I4
			object result = "Cannot populate JSON object onto type '{0}'." + 3168;
			object result2 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3008;
			bool isMyProfile = IsMyProfile;
			bool flag = !isMyProfile;
			object obj = !flag;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				return (string)result;
			}
			return (string)result2;
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_169e: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a3: Expected O, but got Unknown
		//IL_16af: Expected O, but got I
		//IL_16be: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c3: Expected O, but got Unknown
		//IL_16db: Expected I, but got O
		//IL_1705: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_0098: Expected O, but got I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00ed: Expected O, but got I
		//IL_0105: Expected I, but got O
		//IL_0137: Expected O, but got I
		//IL_014f: Expected I, but got O
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_01cc: Expected O, but got I4
		//IL_0216: Expected O, but got I4
		//IL_021f: Expected O, but got I4
		//IL_0228: Expected O, but got I4
		//IL_0231: Expected O, but got I4
		//IL_09dd: Expected O, but got I
		//IL_09eb: Expected I, but got O
		//IL_026c: Expected O, but got I4
		//IL_0a36: Expected O, but got I4
		//IL_0a3f: Expected O, but got I4
		//IL_0a48: Expected O, but got I4
		//IL_0a51: Expected O, but got I4
		//IL_0a62: Expected O, but got I4
		//IL_0aee: Expected O, but got I
		//IL_0afc: Expected I, but got O
		//IL_0308: Expected O, but got I4
		//IL_0b47: Expected O, but got I4
		//IL_0b50: Expected O, but got I4
		//IL_0b59: Expected O, but got I4
		//IL_0b62: Expected O, but got I4
		//IL_0b73: Expected O, but got I4
		//IL_0bff: Expected O, but got I
		//IL_0c0d: Expected I, but got O
		//IL_03a4: Expected O, but got I4
		//IL_0c58: Expected O, but got I4
		//IL_0c61: Expected O, but got I4
		//IL_0c6a: Expected O, but got I4
		//IL_0c73: Expected O, but got I4
		//IL_0c84: Expected O, but got I4
		//IL_0d10: Expected O, but got I
		//IL_0d1e: Expected I, but got O
		//IL_0440: Expected O, but got I4
		//IL_0d69: Expected O, but got I4
		//IL_0d72: Expected O, but got I4
		//IL_0d7b: Expected O, but got I4
		//IL_0d84: Expected O, but got I4
		//IL_0d95: Expected O, but got I4
		//IL_0e21: Expected O, but got I
		//IL_0e2f: Expected I, but got O
		//IL_04dc: Expected O, but got I4
		//IL_0e7a: Expected O, but got I4
		//IL_0e83: Expected O, but got I4
		//IL_0e8c: Expected O, but got I4
		//IL_0e95: Expected O, but got I4
		//IL_0ea6: Expected O, but got I4
		//IL_0f32: Expected O, but got I
		//IL_0f40: Expected I, but got O
		//IL_0578: Expected O, but got I4
		//IL_0f8b: Expected O, but got I4
		//IL_0f94: Expected O, but got I4
		//IL_0f9d: Expected O, but got I4
		//IL_0fa6: Expected O, but got I4
		//IL_0fb7: Expected O, but got I4
		//IL_1043: Expected O, but got I
		//IL_1051: Expected I, but got O
		//IL_0614: Expected O, but got I4
		//IL_109c: Expected O, but got I4
		//IL_10a5: Expected O, but got I4
		//IL_10ae: Expected O, but got I4
		//IL_10b7: Expected O, but got I4
		//IL_10c8: Expected O, but got I4
		//IL_1154: Expected O, but got I
		//IL_1162: Expected I, but got O
		//IL_06b0: Expected O, but got I4
		//IL_11ad: Expected O, but got I4
		//IL_11b6: Expected O, but got I4
		//IL_11bf: Expected O, but got I4
		//IL_11c8: Expected O, but got I4
		//IL_11d9: Expected O, but got I4
		//IL_1265: Expected O, but got I
		//IL_1273: Expected I, but got O
		//IL_074c: Expected O, but got I4
		//IL_12be: Expected O, but got I4
		//IL_12c7: Expected O, but got I4
		//IL_12d0: Expected O, but got I4
		//IL_12d9: Expected O, but got I4
		//IL_12ea: Expected O, but got I4
		//IL_1376: Expected O, but got I
		//IL_1384: Expected I, but got O
		//IL_07e8: Expected O, but got I4
		//IL_13cf: Expected O, but got I4
		//IL_13d8: Expected O, but got I4
		//IL_13e1: Expected O, but got I4
		//IL_13ea: Expected O, but got I4
		//IL_13fb: Expected O, but got I4
		//IL_1487: Expected O, but got I
		//IL_1495: Expected I, but got O
		//IL_0884: Expected O, but got I4
		//IL_14e0: Expected O, but got I4
		//IL_14e9: Expected O, but got I4
		//IL_14f2: Expected O, but got I4
		//IL_14fb: Expected O, but got I4
		//IL_150c: Expected O, but got I4
		//IL_1598: Expected O, but got I
		//IL_15a6: Expected I, but got O
		//IL_1667: Expected O, but got I4
		//IL_1678: Expected O, but got I4
		//IL_091e: Expected O, but got I4
		//IL_15f1: Expected O, but got I4
		//IL_15fa: Expected O, but got I4
		//IL_1603: Expected O, but got I4
		//IL_160c: Expected O, but got I4
		//IL_161d: Expected O, but got I4
		//IL_0951: Expected O, but got I
		//IL_095f: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1120;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj5 = (nint)0 + (nint)1176;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj5);
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.OnPlayerProfileLoaded += action2;
		Button button = like;
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj12 = (nint)0 + (nint)1152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj12);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = add;
		object obj13 = (nint)0 + (nint)1104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj13);
		object obj14 = typeof(MemberAchievementClanFeedData) + 2976;
		button2.m_OnClick.AddListener(unityAction2);
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v8+E4]");
		UnityAction unityAction3;
		if ((nint)0 != 0)
		{
			bool flag3 = challengeUserButton;
			bool flag4 = !flag3;
			object obj16 = !flag4;
			unityAction3 = null;
			UnityAction unityAction4 = null;
			if (obj16 == null)
			{
				goto IL_01e4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = challengeUserButton;
			bool flag6 = !flag5;
			unityAction3 = null;
			UnityAction unityAction4 = null;
			if (flag6)
			{
				goto IL_01e4;
			}
		}
		Button button3 = challengeUserButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)1128;
		UnityAction unityAction5 = default(UnityAction);
		unityAction5..ctor(this, (IntPtr)obj17);
		button3.m_OnClick.AddListener(unityAction5);
		UnityEngine.Object obj18 = report;
		object obj19 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v76+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		object obj21 = 0;
		object obj22 = 0;
		object obj23 = 0;
		unityAction3 = unityAction5;
		object obj24 = 0;
		UnityEngine.Object obj25 = report;
		if (obj20 != null)
		{
			goto IL_0249;
		}
		goto IL_0a7a;
		IL_0861:
		UnityEngine.Object obj26;
		bool flag8 = obj26;
		bool flag9 = !flag8;
		object obj27 = !flag9;
		UnityAction unityAction6 = null;
		object obj28 = obj21;
		UnityAction unityAction7 = null;
		object obj29 = obj22;
		if (obj27 == null)
		{
			goto IL_08ac;
		}
		goto IL_1573;
		IL_1524:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj30;
		bool flag10 = obj30;
		bool flag11 = !flag10;
		obj21 = obj28;
		unityAction6 = null;
		obj22 = obj29;
		unityAction7 = null;
		if (flag11)
		{
			goto IL_08ac;
		}
		goto IL_1573;
		IL_08ac:
		object obj31 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ X0_v22+E4]");
		bool flag12 = (nint)0 == 0;
		UnityEngine.Object obj32 = generateBadge;
		object obj33 = obj21;
		object obj34 = obj22;
		UnityEngine.Object obj35 = generateBadge;
		if (!flag12)
		{
			goto IL_08fd;
		}
		goto IL_1635;
		IL_1573:
		Button button4 = removeAvatar;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj36 = (nint)0 + (nint)1216;
		UnityAction unityAction8 = default(UnityAction);
		unityAction8..ctor(this, (IntPtr)obj36);
		button4.m_OnClick.AddListener(unityAction8);
		obj32 = generateBadge;
		obj31 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ X0_v22+E4]");
		bool flag13 = (nint)0 == 0;
		object obj37 = !flag13;
		obj21 = 0;
		obj22 = 0;
		obj33 = 0;
		unityAction6 = unityAction8;
		obj34 = 0;
		obj35 = generateBadge;
		if (obj37 != null)
		{
			goto IL_08fd;
		}
		goto IL_1635;
		IL_092c:
		Button button5 = generateBadge;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj38 = (nint)0 + (nint)1136;
		UnityAction unityAction9 = default(UnityAction);
		unityAction9..ctor(this, (IntPtr)obj38);
		button5.m_OnClick.AddListener(unityAction9);
		return;
		IL_08fd:
		bool flag14 = obj32;
		bool flag15 = !flag14;
		object obj39 = 0;
		if (!flag15)
		{
			goto IL_092c;
		}
		return;
		IL_1635:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag16 = obj35;
		bool flag17 = !flag16;
		object obj40 = !flag17;
		obj21 = obj33;
		obj39 = 0;
		obj22 = obj34;
		if (obj40 == null)
		{
			return;
		}
		goto IL_092c;
		IL_01e4:
		obj18 = report;
		obj19 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v76+E4]");
		bool flag18 = (nint)0 == 0;
		obj21 = 0;
		obj22 = 0;
		obj23 = 0;
		obj24 = 0;
		obj25 = report;
		if (!flag18)
		{
			goto IL_0249;
		}
		goto IL_0a7a;
		IL_0a7a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag19 = obj25;
		bool flag20 = !flag19;
		obj21 = obj23;
		UnityAction unityAction10 = null;
		obj22 = obj24;
		UnityAction unityAction11 = null;
		if (flag20)
		{
			goto IL_0294;
		}
		goto IL_0ac9;
		IL_0249:
		bool flag21 = obj18;
		bool flag22 = !flag21;
		object obj41 = !flag22;
		unityAction10 = null;
		obj23 = obj21;
		unityAction11 = null;
		obj24 = obj22;
		if (obj41 == null)
		{
			goto IL_0294;
		}
		goto IL_0ac9;
		IL_0ac9:
		Button button6 = report;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj42 = (nint)0 + (nint)1232;
		UnityAction unityAction12 = default(UnityAction);
		unityAction12..ctor(this, (IntPtr)obj42);
		button6.m_OnClick.AddListener(unityAction12);
		UnityEngine.Object obj43 = gift;
		object obj44 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v70+E4]");
		bool flag23 = (nint)0 == 0;
		object obj45 = !flag23;
		obj21 = 0;
		obj22 = 0;
		object obj46 = 0;
		unityAction10 = unityAction12;
		object obj47 = 0;
		UnityEngine.Object obj48 = gift;
		if (obj45 != null)
		{
			goto IL_02e5;
		}
		goto IL_0b8b;
		IL_0294:
		obj43 = gift;
		obj44 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v70+E4]");
		bool flag24 = (nint)0 == 0;
		obj46 = obj21;
		obj47 = obj22;
		obj48 = gift;
		if (!flag24)
		{
			goto IL_02e5;
		}
		goto IL_0b8b;
		IL_0b8b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag25 = obj48;
		bool flag26 = !flag25;
		obj21 = obj46;
		UnityAction unityAction13 = null;
		obj22 = obj47;
		UnityAction unityAction14 = null;
		if (flag26)
		{
			goto IL_0330;
		}
		goto IL_0bda;
		IL_02e5:
		bool flag27 = obj43;
		bool flag28 = !flag27;
		object obj49 = !flag28;
		unityAction13 = null;
		obj46 = obj21;
		unityAction14 = null;
		obj47 = obj22;
		if (obj49 == null)
		{
			goto IL_0330;
		}
		goto IL_0bda;
		IL_0bda:
		Button button7 = gift;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj50 = (nint)0 + (nint)1144;
		UnityAction unityAction15 = default(UnityAction);
		unityAction15..ctor(this, (IntPtr)obj50);
		button7.m_OnClick.AddListener(unityAction15);
		UnityEngine.Object obj51 = block;
		object obj52 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v64+E4]");
		bool flag29 = (nint)0 == 0;
		object obj53 = !flag29;
		obj21 = 0;
		obj22 = 0;
		object obj54 = 0;
		unityAction13 = unityAction15;
		object obj55 = 0;
		UnityEngine.Object obj56 = block;
		if (obj53 != null)
		{
			goto IL_0381;
		}
		goto IL_0c9c;
		IL_0330:
		obj51 = block;
		obj52 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v64+E4]");
		bool flag30 = (nint)0 == 0;
		obj54 = obj21;
		obj55 = obj22;
		obj56 = block;
		if (!flag30)
		{
			goto IL_0381;
		}
		goto IL_0c9c;
		IL_0c9c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag31 = obj56;
		bool flag32 = !flag31;
		obj21 = obj54;
		UnityAction unityAction16 = null;
		obj22 = obj55;
		UnityAction unityAction17 = null;
		if (flag32)
		{
			goto IL_03cc;
		}
		goto IL_0ceb;
		IL_0381:
		bool flag33 = obj51;
		bool flag34 = !flag33;
		object obj57 = !flag34;
		unityAction16 = null;
		obj54 = obj21;
		unityAction17 = null;
		obj55 = obj22;
		if (obj57 == null)
		{
			goto IL_03cc;
		}
		goto IL_0ceb;
		IL_0ceb:
		Button button8 = block;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj58 = (nint)0 + (nint)1112;
		UnityAction unityAction18 = default(UnityAction);
		unityAction18..ctor(this, (IntPtr)obj58);
		button8.m_OnClick.AddListener(unityAction18);
		UnityEngine.Object obj59 = unblock;
		object obj60 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v96+E4]");
		bool flag35 = (nint)0 == 0;
		object obj61 = !flag35;
		obj21 = 0;
		obj22 = 0;
		object obj62 = 0;
		unityAction16 = unityAction18;
		object obj63 = 0;
		UnityEngine.Object obj64 = unblock;
		if (obj61 != null)
		{
			goto IL_041d;
		}
		goto IL_0dad;
		IL_03cc:
		obj60 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v96+E4]");
		bool flag36 = (nint)0 == 0;
		obj59 = unblock;
		obj62 = obj21;
		obj63 = obj22;
		obj64 = unblock;
		if (!flag36)
		{
			goto IL_041d;
		}
		goto IL_0dad;
		IL_0dad:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag37 = obj64;
		bool flag38 = !flag37;
		obj21 = obj62;
		UnityAction unityAction19 = null;
		obj22 = obj63;
		UnityAction unityAction20 = null;
		if (flag38)
		{
			goto IL_0468;
		}
		goto IL_0dfc;
		IL_041d:
		bool flag39 = obj59;
		bool flag40 = !flag39;
		object obj65 = !flag40;
		unityAction19 = null;
		obj62 = obj21;
		unityAction20 = null;
		obj63 = obj22;
		if (obj65 == null)
		{
			goto IL_0468;
		}
		goto IL_0dfc;
		IL_0dfc:
		Button button9 = unblock;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj66 = (nint)0 + (nint)1240;
		UnityAction unityAction21 = default(UnityAction);
		unityAction21..ctor(this, (IntPtr)obj66);
		button9.m_OnClick.AddListener(unityAction21);
		UnityEngine.Object obj67 = remove;
		object obj68 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v87+E4]");
		bool flag41 = (nint)0 == 0;
		object obj69 = !flag41;
		obj21 = 0;
		obj22 = 0;
		object obj70 = 0;
		unityAction19 = unityAction21;
		object obj71 = 0;
		UnityEngine.Object obj72 = remove;
		if (obj69 != null)
		{
			goto IL_04b9;
		}
		goto IL_0ebe;
		IL_0468:
		obj68 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v87+E4]");
		bool flag42 = (nint)0 == 0;
		obj67 = remove;
		obj70 = obj21;
		obj71 = obj22;
		obj72 = remove;
		if (!flag42)
		{
			goto IL_04b9;
		}
		goto IL_0ebe;
		IL_0ebe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag43 = obj72;
		bool flag44 = !flag43;
		obj21 = obj70;
		UnityAction unityAction22 = null;
		obj22 = obj71;
		UnityAction unityAction23 = null;
		if (flag44)
		{
			goto IL_0504;
		}
		goto IL_0f0d;
		IL_04b9:
		bool flag45 = obj67;
		bool flag46 = !flag45;
		object obj73 = !flag46;
		unityAction22 = null;
		obj70 = obj21;
		unityAction23 = null;
		obj71 = obj22;
		if (obj73 == null)
		{
			goto IL_0504;
		}
		goto IL_0f0d;
		IL_0f0d:
		Button button10 = remove;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj74 = (nint)0 + (nint)1208;
		UnityAction unityAction24 = default(UnityAction);
		unityAction24..ctor(this, (IntPtr)obj74);
		button10.m_OnClick.AddListener(unityAction24);
		UnityEngine.Object obj75 = preview;
		object obj76 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X0_v78+E4]");
		bool flag47 = (nint)0 == 0;
		object obj77 = !flag47;
		obj21 = 0;
		obj22 = 0;
		object obj78 = 0;
		unityAction22 = unityAction24;
		object obj79 = 0;
		UnityEngine.Object obj80 = preview;
		if (obj77 != null)
		{
			goto IL_0555;
		}
		goto IL_0fcf;
		IL_0504:
		obj76 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X0_v78+E4]");
		bool flag48 = (nint)0 == 0;
		obj75 = preview;
		obj78 = obj21;
		obj79 = obj22;
		obj80 = preview;
		if (!flag48)
		{
			goto IL_0555;
		}
		goto IL_0fcf;
		IL_0fcf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag49 = obj80;
		bool flag50 = !flag49;
		obj21 = obj78;
		UnityAction unityAction25 = null;
		obj22 = obj79;
		UnityAction unityAction26 = null;
		if (flag50)
		{
			goto IL_05a0;
		}
		goto IL_101e;
		IL_0555:
		bool flag51 = obj75;
		bool flag52 = !flag51;
		object obj81 = !flag52;
		unityAction25 = null;
		obj78 = obj21;
		unityAction26 = null;
		obj79 = obj22;
		if (obj81 == null)
		{
			goto IL_05a0;
		}
		goto IL_101e;
		IL_101e:
		Button button11 = preview;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj82 = (nint)0 + (nint)1200;
		UnityAction unityAction27 = default(UnityAction);
		unityAction27..ctor(this, (IntPtr)obj82);
		button11.m_OnClick.AddListener(unityAction27);
		UnityEngine.Object obj83 = mod;
		object obj84 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X8_v40+E4]");
		bool flag53 = (nint)0 == 0;
		object obj85 = !flag53;
		obj21 = 0;
		obj22 = 0;
		object obj86 = 0;
		unityAction25 = unityAction27;
		object obj87 = 0;
		UnityEngine.Object obj88 = mod;
		if (obj85 != null)
		{
			goto IL_05f1;
		}
		goto IL_10e0;
		IL_05a0:
		obj83 = mod;
		obj84 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X8_v40+E4]");
		bool flag54 = (nint)0 == 0;
		obj86 = obj21;
		obj87 = obj22;
		obj88 = mod;
		if (!flag54)
		{
			goto IL_05f1;
		}
		goto IL_10e0;
		IL_10e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag55 = obj88;
		bool flag56 = !flag55;
		obj21 = obj86;
		UnityAction unityAction28 = null;
		obj22 = obj87;
		UnityAction unityAction29 = null;
		if (flag56)
		{
			goto IL_063c;
		}
		goto IL_112f;
		IL_05f1:
		bool flag57 = obj83;
		bool flag58 = !flag57;
		object obj89 = !flag58;
		unityAction28 = null;
		obj86 = obj21;
		unityAction29 = null;
		obj87 = obj22;
		if (obj89 == null)
		{
			goto IL_063c;
		}
		goto IL_112f;
		IL_112f:
		Button button12 = mod;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj90 = (nint)0 + (nint)1160;
		UnityAction unityAction30 = default(UnityAction);
		unityAction30..ctor(this, (IntPtr)obj90);
		button12.m_OnClick.AddListener(unityAction30);
		UnityEngine.Object obj91 = muteAndZeroCurrency;
		object obj92 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X0_v59+E4]");
		bool flag59 = (nint)0 == 0;
		object obj93 = !flag59;
		obj21 = 0;
		obj22 = 0;
		object obj94 = 0;
		unityAction28 = unityAction30;
		object obj95 = 0;
		UnityEngine.Object obj96 = muteAndZeroCurrency;
		if (obj93 != null)
		{
			goto IL_068d;
		}
		goto IL_11f1;
		IL_063c:
		obj92 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X0_v59+E4]");
		bool flag60 = (nint)0 == 0;
		obj91 = muteAndZeroCurrency;
		obj94 = obj21;
		obj95 = obj22;
		obj96 = muteAndZeroCurrency;
		if (!flag60)
		{
			goto IL_068d;
		}
		goto IL_11f1;
		IL_11f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag61 = obj96;
		bool flag62 = !flag61;
		obj21 = obj94;
		UnityAction unityAction31 = null;
		obj22 = obj95;
		UnityAction unityAction32 = null;
		if (flag62)
		{
			goto IL_06d8;
		}
		goto IL_1240;
		IL_068d:
		bool flag63 = obj91;
		bool flag64 = !flag63;
		object obj97 = !flag64;
		unityAction31 = null;
		obj94 = obj21;
		unityAction32 = null;
		obj95 = obj22;
		if (obj97 == null)
		{
			goto IL_06d8;
		}
		goto IL_1240;
		IL_1240:
		Button button13 = muteAndZeroCurrency;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj98 = (nint)0 + (nint)1168;
		UnityAction unityAction33 = default(UnityAction);
		unityAction33..ctor(this, (IntPtr)obj98);
		button13.m_OnClick.AddListener(unityAction33);
		UnityEngine.Object obj99 = adminPage;
		object obj100 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X0_v50+E4]");
		bool flag65 = (nint)0 == 0;
		object obj101 = !flag65;
		obj21 = 0;
		obj22 = 0;
		object obj102 = 0;
		unityAction31 = unityAction33;
		object obj103 = 0;
		UnityEngine.Object obj104 = adminPage;
		if (obj101 != null)
		{
			goto IL_0729;
		}
		goto IL_1302;
		IL_06d8:
		obj100 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X0_v50+E4]");
		bool flag66 = (nint)0 == 0;
		obj99 = adminPage;
		obj102 = obj21;
		obj103 = obj22;
		obj104 = adminPage;
		if (!flag66)
		{
			goto IL_0729;
		}
		goto IL_1302;
		IL_1302:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag67 = obj104;
		bool flag68 = !flag67;
		obj21 = obj102;
		UnityAction unityAction34 = null;
		obj22 = obj103;
		UnityAction unityAction35 = null;
		if (flag68)
		{
			goto IL_0774;
		}
		goto IL_1351;
		IL_0729:
		bool flag69 = obj99;
		bool flag70 = !flag69;
		object obj105 = !flag70;
		unityAction34 = null;
		obj102 = obj21;
		unityAction35 = null;
		obj103 = obj22;
		if (obj105 == null)
		{
			goto IL_0774;
		}
		goto IL_1351;
		IL_1351:
		Button button14 = adminPage;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj106 = (nint)0 + (nint)1184;
		UnityAction unityAction36 = default(UnityAction);
		unityAction36..ctor(this, (IntPtr)obj106);
		button14.m_OnClick.AddListener(unityAction36);
		UnityEngine.Object obj107 = removeBio;
		object obj108 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v41+E4]");
		bool flag71 = (nint)0 == 0;
		object obj109 = !flag71;
		obj21 = 0;
		obj22 = 0;
		object obj110 = 0;
		unityAction34 = unityAction36;
		object obj111 = 0;
		UnityEngine.Object obj112 = removeBio;
		if (obj109 != null)
		{
			goto IL_07c5;
		}
		goto IL_1413;
		IL_0774:
		obj108 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v41+E4]");
		bool flag72 = (nint)0 == 0;
		obj107 = removeBio;
		obj110 = obj21;
		obj111 = obj22;
		obj112 = removeBio;
		if (!flag72)
		{
			goto IL_07c5;
		}
		goto IL_1413;
		IL_1413:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag73 = obj112;
		bool flag74 = !flag73;
		obj21 = obj110;
		UnityAction unityAction37 = null;
		obj22 = obj111;
		UnityAction unityAction38 = null;
		if (flag74)
		{
			goto IL_0810;
		}
		goto IL_1462;
		IL_07c5:
		bool flag75 = obj107;
		bool flag76 = !flag75;
		object obj113 = !flag76;
		unityAction37 = null;
		obj110 = obj21;
		unityAction38 = null;
		obj111 = obj22;
		if (obj113 == null)
		{
			goto IL_0810;
		}
		goto IL_1462;
		IL_1462:
		Button button15 = removeBio;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj114 = (nint)0 + (nint)1224;
		UnityAction unityAction39 = default(UnityAction);
		unityAction39..ctor(this, (IntPtr)obj114);
		button15.m_OnClick.AddListener(unityAction39);
		obj26 = removeAvatar;
		object obj115 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1048 @ X8_v16+E4]");
		bool flag77 = (nint)0 == 0;
		object obj116 = !flag77;
		obj21 = 0;
		obj22 = 0;
		obj28 = 0;
		unityAction37 = unityAction39;
		obj29 = 0;
		obj30 = removeAvatar;
		if (obj116 != null)
		{
			goto IL_0861;
		}
		goto IL_1524;
		IL_0810:
		obj26 = removeAvatar;
		obj115 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1048 @ X8_v16+E4]");
		bool flag78 = (nint)0 == 0;
		obj28 = obj21;
		obj29 = obj22;
		obj30 = removeAvatar;
		if (!flag78)
		{
			goto IL_0861;
		}
		goto IL_1524;
	}

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_027d: Expected O, but got I4
		//IL_0210: Expected O, but got I4
		//IL_0196: Expected O, but got I4
		//IL_02da: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7817]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0133;
		IL_0230:
		GameObject gameObject = report.gameObject;
		gameObject.SetActive(value: false);
		return;
		IL_01f6:
		UnityEngine.Object obj8;
		bool flag3 = obj8;
		bool flag4;
		object obj9 = flag3 && flag4;
		if ((nint)obj9 == 1)
		{
			goto IL_0230;
		}
		return;
		IL_0133:
		object obj10 = typeof(MemberAchievementClanFeedData) + 2976;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(currentRoom);
		bool flag7;
		UnityEngine.Object obj13;
		if (tournamentInfo != null)
		{
			object obj11 = tournamentInfo.<Type>k__BackingField - 1;
			bool flag5 = obj11 == null;
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v7+E4]");
			bool flag6 = (nint)0 == 0;
			flag4 = flag5;
			obj8 = report;
			flag7 = flag5;
			obj13 = report;
			if (!flag6)
			{
				goto IL_01f6;
			}
		}
		else
		{
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v7+E4]");
			bool flag8 = (nint)0 == 0;
			object obj14 = !flag8;
			flag4 = false;
			obj8 = report;
			flag7 = false;
			obj13 = report;
			if (obj14 != null)
			{
				goto IL_01f6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag9 = obj13;
		object obj15 = flag9 && flag7;
		if ((nint)obj15 != 1)
		{
			return;
		}
		goto IL_0230;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag10 = (object)sessionModel == null;
		object obj16 = !flag10;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00df: Expected O, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_010b: Expected I, but got O
		//IL_0135: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_0098: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1120;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj5 = (nint)0 + (nint)1176;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj5);
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.OnPlayerProfileLoaded -= action2;
	}

	private void ConfigChanged()
	{
		HandleButtonVisibility();
	}

	private void OnPlayerProfileLoaded(PlayerProfileModel model)
	{
		PlayerProfileModel profile = _profile;
		if (_profile != null && model.<userDbId>k__BackingField == profile.<userDbId>k__BackingField)
		{
			Populate(model);
		}
	}

	public void Populate(string dbId, Action<KammelnaError> errorCallback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00bb: Expected I, but got O
		//IL_00db: Expected I, but got O
		//IL_0105: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj4 = (nint)0 + (nint)1192;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2504;
		object obj6 = (nint)0 + (nint)816;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		object obj8 = obj2 + 16;
		obj8 = errorCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ResetUi();
		StartLoading();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action2 = default(Action<System.Int32Enum>);
		action2..ctor(obj2, (IntPtr)obj6);
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.RequestUserProfile(dbId, action, (Action<KammelnaError>)(object)action2);
	}

	public void Populate(PlayerProfileModel profileModel)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		ResetUi();
		object obj = this + 224;
		obj = profileModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		PopulateProfile();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v1+48]");
		PopulateBio((string)0);
		StopLoading();
		AnimateMonthlyTournamentTrophy();
		UpdateButtonsState();
		HandleButtonVisibility();
	}

	public void PopulateFromSFS(string userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00a7: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)824;
		object obj5 = obj2 + 16;
		obj5 = userId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ResetUi();
		StartLoading();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.GetIsPlayerLiked((string)obj5, action);
	}

	private void HandleButtonVisibility()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		if (_profile != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 56;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RemoteConfigModel current = RemoteConfig.Current;
			FriendlyChallengeConfig <FriendlyChallenge>k__BackingField = current.<FriendlyChallenge>k__BackingField;
			if (<FriendlyChallenge>k__BackingField.<Enabled>k__BackingField && !ThisIsMyProfile())
			{
				ShowChallengeButton();
				return;
			}
		}
		HideChallengeButton();
	}

	private bool ThisIsMyProfile()
	{
		//IL_00e6: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		//IL_00c4: Expected O, but got I8
		PlayerProfileModel profile = _profile;
		if (_profile != null)
		{
			object obj = typeof(Queue<string>) + 848;
			object obj2 = (nint)0 + (nint)2200;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				User localUser = sessionModel.LocalUser;
				int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
				object obj5 = profile.<userDbId>k__BackingField - intDbId;
				return obj5 == null;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void ShowChallengeButton()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_015e: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E781D]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = challengeUserButton;
			obj6 = challengeUserButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = challengeUserButton;
			obj6 = challengeUserButton;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		GameObject gameObject = challengeUserButton.gameObject;
		gameObject.SetActive(value: true);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private void HideChallengeButton()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_015e: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E781E]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = challengeUserButton;
			obj6 = challengeUserButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = challengeUserButton;
			obj6 = challengeUserButton;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		GameObject gameObject = challengeUserButton.gameObject;
		gameObject.SetActive(value: false);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private void UpdateButtonsState()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_0080: Expected O, but got I
		//IL_00fc: Expected O, but got I4
		//IL_0153: Expected O, but got I
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0195: Expected O, but got I4
		//IL_01d8: Expected O, but got I8
		//IL_01f2: Expected O, but got I4
		//IL_01ff: Expected O, but got I4
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_0222: Expected I4, but got O
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_028c: Expected O, but got I4
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02e3: Expected O, but got I8
		//IL_02fd: Expected O, but got I4
		//IL_030b: Expected O, but got I4
		//IL_0318: Expected I4, but got O
		//IL_0379: Expected O, but got I4
		//IL_03b8: Expected O, but got I4
		//IL_03cb: Expected O, but got I4
		//IL_06a2: Expected O, but got I4
		//IL_06ab: Expected O, but got I4
		//IL_06b4: Expected O, but got I4
		//IL_0406: Expected O, but got I4
		//IL_075f: Expected O, but got I4
		//IL_0768: Expected O, but got I4
		//IL_0771: Expected O, but got I4
		//IL_0489: Expected O, but got I4
		//IL_07f9: Expected O, but got I4
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Expected I4, but got Unknown
		//IL_0847: Expected O, but got I4
		//IL_0850: Expected O, but got I4
		//IL_0859: Expected O, but got I4
		//IL_050c: Expected O, but got I4
		//IL_091a: Expected O, but got I4
		//IL_0923: Expected O, but got I4
		//IL_092c: Expected O, but got I4
		//IL_058f: Expected O, but got I4
		//IL_09df: Expected O, but got I4
		//IL_09e8: Expected O, but got I4
		//IL_0a3a: Expected O, but got I4
		PlayerProfileModel profile = _profile;
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)2200;
		bool flag2 = FriendsManager.IsFriend(profile.<userDbId>k__BackingField);
		bool flag3 = FriendsManager.IsBlocked(profile.<userDbId>k__BackingField);
		bool flag4 = FriendsManager.IsReceivedFriendship(profile.<userDbId>k__BackingField);
		bool flag5 = FriendsManager.IsRequestedFriendship(profile.<userDbId>k__BackingField);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v14+E4]");
		bool flag6 = (nint)0 == 0;
		object obj7 = !flag6;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		object obj8 = (nint)0 + (nint)288;
		object obj9 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1408;
		object obj10 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		bool flag7 = !flag2;
		object obj11 = !flag7;
		object obj12 = ~obj11;
		object text = ((obj12 != null) ? obj10 : obj9);
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh, (string)text);
		object obj13 = intDbId - profile.<userDbId>k__BackingField;
		bool flag8 = obj13 == null;
		object obj14 = !flag8;
		object obj15 = flag2 || flag3;
		object obj16 = obj15 | flag5;
		object obj17 = ~obj16;
		bool interactable = (byte)(obj14 & obj17) != 0;
		add.interactable = interactable;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		PlayerProfileModel profile2 = _profile;
		object obj18 = "LAK" + 1648;
		object obj19 = "LAK" + 1640;
		bool flag9 = !profile2.<isLiked>k__BackingField;
		object obj20 = !flag9;
		object obj21 = ~obj20;
		object text2 = ((obj21 != null) ? obj19 : obj18);
		TextMeshProUGUI textMesh2 = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh2, (string)text2);
		PlayerProfileModel profile3 = _profile;
		object obj22 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj23 = intDbId - profile.<userDbId>k__BackingField;
		bool flag10 = obj23 == null;
		object obj24 = !flag10;
		object obj25 = ~(profile3.<isLiked>k__BackingField ? 1 : 0);
		bool interactable2 = (byte)(obj24 & obj25) != 0;
		like.interactable = interactable2;
		object obj26 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v14+E4]");
		bool flag13;
		if ((nint)0 != 0)
		{
			bool flag11 = report;
			bool flag12 = !flag11;
			object obj27 = !flag12;
			flag13 = false;
			if (obj27 == null)
			{
				goto IL_0390;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag14 = report;
			bool flag15 = !flag14;
			flag13 = false;
			if (flag15)
			{
				goto IL_0390;
			}
		}
		report.interactable = true;
		UnityEngine.Object obj28 = gift;
		object obj29 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v61+E4]");
		bool flag16 = (nint)0 == 0;
		object obj30 = !flag16;
		object obj31 = 0;
		object obj32 = 0;
		flag13 = true;
		UnityEngine.Object obj33 = gift;
		if (obj30 != null)
		{
			goto IL_03e3;
		}
		goto IL_06d5;
		IL_04a0:
		object obj34 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v46+E4]");
		bool flag17 = (nint)0 == 0;
		UnityEngine.Object obj35 = block;
		object obj36 = obj31;
		UnityEngine.Object obj37 = block;
		if (!flag17)
		{
			goto IL_04e9;
		}
		goto IL_0871;
		IL_07d8:
		GameObject gameObject = remove.gameObject;
		object obj38 = flag2 || flag4;
		bool active = (byte)((obj38 | flag5) ? 1 : 0) != 0;
		gameObject.SetActive(active);
		obj35 = block;
		obj34 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v46+E4]");
		bool flag18 = (nint)0 == 0;
		object obj39 = !flag18;
		obj31 = 0;
		obj36 = 0;
		obj37 = block;
		if (obj39 != null)
		{
			goto IL_04e9;
		}
		goto IL_0871;
		IL_04e9:
		bool flag19 = obj35;
		bool flag20 = !flag19;
		object obj40 = !flag20;
		bool flag21 = false;
		if (obj40 == null)
		{
			goto IL_0523;
		}
		goto IL_08b7;
		IL_0871:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag22 = obj37;
		bool flag23 = !flag22;
		obj31 = obj36;
		flag21 = false;
		if (flag23)
		{
			goto IL_0523;
		}
		goto IL_08b7;
		IL_0944:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj41;
		bool flag24 = obj41;
		bool flag25 = !flag24;
		object obj42;
		obj31 = obj42;
		bool flag26 = false;
		if (flag25)
		{
			goto IL_05a6;
		}
		goto IL_098a;
		IL_0523:
		UnityEngine.Object obj43 = unblock;
		object obj44 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v19+E4]");
		bool flag27 = (nint)0 == 0;
		obj42 = obj31;
		obj41 = unblock;
		if (!flag27)
		{
			goto IL_056c;
		}
		goto IL_0944;
		IL_08b7:
		GameObject gameObject2 = block.gameObject;
		flag21 = (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
		gameObject2.SetActive(flag21);
		obj43 = unblock;
		obj44 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v19+E4]");
		bool flag28 = (nint)0 == 0;
		object obj45 = !flag28;
		obj31 = 0;
		obj42 = 0;
		obj41 = unblock;
		if (obj45 != null)
		{
			goto IL_056c;
		}
		goto IL_0944;
		IL_05a6:
		UnityEngine.Object obj46 = preview;
		object obj47 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v16+E4]");
		bool flag29 = (nint)0 == 0;
		UnityEngine.Object obj48 = preview;
		if (!flag29)
		{
			goto IL_05e7;
		}
		goto IL_0a08;
		IL_098a:
		GameObject gameObject3 = unblock.gameObject;
		gameObject3.SetActive(flag3);
		obj46 = preview;
		obj47 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v16+E4]");
		bool flag30 = (nint)0 == 0;
		object obj49 = !flag30;
		obj31 = 0;
		flag26 = flag3;
		obj48 = preview;
		if (obj49 != null)
		{
			goto IL_05e7;
		}
		goto IL_0a08;
		IL_056c:
		bool flag31 = obj43;
		bool flag32 = !flag31;
		object obj50 = !flag32;
		flag26 = false;
		if (obj50 == null)
		{
			goto IL_05a6;
		}
		goto IL_098a;
		IL_060d:
		preview.interactable = true;
		return;
		IL_05e7:
		if ((bool)obj46)
		{
			goto IL_060d;
		}
		return;
		IL_0a08:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag33 = obj48;
		bool flag34 = !flag33;
		object obj51 = !flag34;
		if (obj51 == null)
		{
			return;
		}
		goto IL_060d;
		IL_0390:
		obj29 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v61+E4]");
		bool flag35 = (nint)0 == 0;
		obj31 = 0;
		obj28 = gift;
		obj32 = 0;
		obj33 = gift;
		if (!flag35)
		{
			goto IL_03e3;
		}
		goto IL_06d5;
		IL_06d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag36 = obj33;
		bool flag37 = !flag36;
		obj31 = obj32;
		bool flag38 = false;
		if (flag37)
		{
			goto IL_041d;
		}
		goto IL_071b;
		IL_03e3:
		bool flag39 = obj28;
		bool flag40 = !flag39;
		object obj52 = !flag40;
		flag38 = false;
		if (obj52 == null)
		{
			goto IL_041d;
		}
		goto IL_071b;
		IL_071b:
		gift.interactable = true;
		UnityEngine.Object obj53 = remove;
		object obj54 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X0_v54+E4]");
		bool flag41 = (nint)0 == 0;
		object obj55 = !flag41;
		obj31 = 0;
		object obj56 = 0;
		flag38 = true;
		UnityEngine.Object obj57 = remove;
		if (obj55 != null)
		{
			goto IL_0466;
		}
		goto IL_0792;
		IL_041d:
		obj54 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X0_v54+E4]");
		bool flag42 = (nint)0 == 0;
		obj53 = remove;
		obj56 = obj31;
		obj57 = remove;
		if (!flag42)
		{
			goto IL_0466;
		}
		goto IL_0792;
		IL_0792:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag43 = obj57;
		bool flag44 = !flag43;
		obj31 = obj56;
		active = false;
		if (flag44)
		{
			goto IL_04a0;
		}
		goto IL_07d8;
		IL_0466:
		bool flag45 = obj53;
		bool flag46 = !flag45;
		object obj58 = !flag46;
		active = false;
		if (obj58 == null)
		{
			goto IL_04a0;
		}
		goto IL_07d8;
	}

	private void Like()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0044: Expected O, but got I
		//IL_005c: Expected I, but got O
		like.interactable = false;
		PlayerProfileModel profile = _profile;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj2 = (nint)0 + (nint)1072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.LikeUser(profile.<userDbId>k__BackingField, action);
	}

	private void Add()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_013d: Expected O, but got I4
		//IL_0146: Expected O, but got I4
		//IL_014f: Expected O, but got I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00cf: Expected O, but got I4
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_02fd: Expected O, but got I
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_0338: Expected I, but got O
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_01a3: Expected O, but got I4
		//IL_0295: Expected O, but got I4
		//IL_01cc: Expected O, but got I
		//IL_00e6: Expected O, but got I4
		//IL_02c4: Expected I4, but got I8
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0228: Expected O, but got I4
		//IL_025e: Expected O, but got I4
		//IL_0248: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		PlayerProfileModel profile = _profile;
		object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		add.interactable = false;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v10+E4]");
		object obj6;
		object obj9;
		if ((nint)0 != 0)
		{
			bool flag = FriendsManager.IsReceivedFriendship(profile.<userDbId>k__BackingField);
			obj6 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1416;
			bool flag2 = !flag;
			object obj7 = 0;
			if (flag2)
			{
				goto IL_0165;
			}
			object obj8 = 0;
			obj9 = obj6;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = FriendsManager.IsReceivedFriendship(profile.<userDbId>k__BackingField);
			obj6 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1416;
			bool flag4 = !flag3;
			object obj10 = !flag4;
			object obj7 = 0;
			object obj8 = 0;
			obj9 = obj6;
			if (obj10 == null)
			{
				goto IL_0165;
			}
		}
		goto IL_02dd;
		IL_02dd:
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj12 = (nint)0 + (nint)840;
		object obj13 = obj2 + 16;
		obj13 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj12);
		object obj14 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v17+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.AddFriend((int)profile.<userDbId>k__BackingField, action);
		return;
		IL_0165:
		object obj16 = typeof(Queue<string>) + 848;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v22+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj19 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		bool flag7 = SFSKammelnaUserExtensions.Can(localUser, UserPermission.ForceFriend);
		object obj20 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1424;
		bool flag8 = !flag7;
		object obj21 = !flag8;
		object obj22 = ~obj21;
		if (obj22 == null)
		{
			object obj8 = 0;
			obj9 = obj6;
		}
		else
		{
			object obj8 = 0;
			obj9 = obj20;
		}
		goto IL_02dd;
	}

	private void Report()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_009d: Expected O, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_012e: Expected O, but got I
		//IL_013c: Expected I, but got O
		if (_alreadyReported)
		{
			FakeReport();
			return;
		}
		TrollingReportModel trollingReportModel = TrollingReportModel.MakeDefaultInstance();
		PlayerProfileModel profile = _profile;
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long value = Convert.ToInt64(profile.<userDbId>k__BackingField);
		object obj4 = (nint)0 + (nint)3184;
		long? <ReportedPlayerId>k__BackingField = value;
		trollingReportModel.<ReportedPlayerId>k__BackingField = <ReportedPlayerId>k__BackingField;
		PlayerProfileModel profile2 = _profile;
		object obj5 = trollingReportModel + 80;
		obj5 = profile2.<userName>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = "{0} color encoding is currently unsupported for outputting to HDR." + 2280;
		string chatText = ChatHandler.GetChatText();
		string text = (string)obj6 + chatText;
		object obj7 = trollingReportModel + 56;
		obj7 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)1088;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj9);
		KammelnaRequests.SendTrollingReport(trollingReportModel, action);
	}

	private string GetReportChatRecord()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object obj = "{0} color encoding is currently unsupported for outputting to HDR." + 2280;
		string chatText = ChatHandler.GetChatText();
		return (string)obj + chatText;
	}

	private void FakeReport()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_014b: Expected O, but got I
		//IL_015b: Expected O, but got I
		//IL_017d: Expected O, but got I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_007a: Expected O, but got I
		//IL_008a: Expected O, but got I
		//IL_01b5: Expected O, but got I4
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_027b: Expected O, but got I
		//IL_0283: Expected I, but got O
		//IL_0294: Expected I, but got O
		//IL_02b2: Expected O, but got I
		//IL_0214: Expected O, but got I4
		//IL_0224: Expected I4, but got O
		//IL_01e5: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2496;
		report.interactable = false;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v7+E4]");
		object obj3;
		object obj4;
		Action action;
		object obj5;
		if ((nint)0 != 0)
		{
			obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v7+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v6+8]");
			action = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v6+8]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_00b7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v7+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v6+8]");
			action = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v6+8]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_00b7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v13+B8]");
			obj4 = 0;
		}
		object obj9 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)808;
		nint num = (nint)obj10;
		Action action2 = default(Action);
		action2..ctor(obj4, (IntPtr)obj10);
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v11+B8]");
		object obj12 = (nint)0 + (nint)8;
		obj12 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj13 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v5+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		action = action2;
		bool flag5 = (byte)(int)action2 != 0;
		Action action3 = action2;
		if (obj14 != null)
		{
			goto IL_00fe;
		}
		goto IL_023a;
		IL_00b7:
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v5+E4]");
		bool flag6 = (nint)0 == 0;
		num = 0;
		flag5 = false;
		action3 = action;
		if (!flag6)
		{
			goto IL_00fe;
		}
		goto IL_023a;
		IL_023a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		action = action3;
		goto IL_00fe;
		IL_00fe:
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action);
	}

	private void Gift()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3760;
		long num = default(long);
		string dbId = num.ToString();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			BuyForFriendPopup.ShowFor(dbId);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		BuyForFriendPopup.ShowFor(dbId);
	}

	private void Block()
	{
		//IL_0010: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Expected O, but got Unknown
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_08e7: Expected O, but got I
		//IL_007c: Expected O, but got I8
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_034f: Expected O, but got I4
		//IL_038a: Expected O, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00dc: Expected I, but got O
		//IL_00ec: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_03cc: Expected O, but got I
		//IL_03e4: Expected O, but got I
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_0255: Expected O, but got I
		//IL_0127: Expected O, but got I
		//IL_0836: Expected I, but got O
		//IL_0846: Expected O, but got I
		//IL_041f: Expected O, but got I
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected O, but got Unknown
		//IL_0290: Expected O, but got I
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_0508: Expected O, but got I4
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_0536: Expected O, but got I
		//IL_05ee: Expected O, but got I4
		//IL_0571: Expected O, but got I
		//IL_060c: Expected I, but got O
		//IL_061c: Expected O, but got I
		//IL_06ab: Expected O, but got I4
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Expected O, but got Unknown
		//IL_06ff: Expected O, but got I4
		//IL_0708: Expected O, but got I4
		//IL_0657: Expected O, but got I
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected O, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected O, but got Unknown
		//IL_08b9: Expected O, but got I4
		//IL_08c1: Expected O, but got I
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected O, but got Unknown
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E788F]");
		PlayerProfileModel playerProfileModel = (PlayerProfileModel)0;
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object text = default(object);
		object obj6 = default(object);
		object obj7 = default(object);
		object obj9 = default(object);
		if (obj2 != null)
		{
			object obj3 = obj2 + 24;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			playerProfileModel = _profile;
			if (_profile != null)
			{
				playerProfileModel = (PlayerProfileModel)playerProfileModel.<userDbId>k__BackingField;
				_ = playerProfileModel.<userDbId>k__BackingField;
				IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
				if (popupWindowBuilderNeedsTitle != null)
				{
					object obj4 = typeof(System.IOAsyncCallback) + 392;
					text = "AvailableVoices" + 2160;
					nint num = (nint)popupWindowBuilderNeedsTitle;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v12 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v12 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0170;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v12 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
					obj6 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X10_v13-8]");
						if (0 == (nint)obj4)
						{
							break;
						}
						obj7 = obj6 + 16;
						obj5--;
						bool flag = (nint)obj5 != 1;
						obj6 = obj7;
						if (flag)
						{
							continue;
						}
						goto IL_0170;
					}
					object obj8 = num + obj6;
					playerProfileModel = (PlayerProfileModel)(obj8 + 312);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v275 @ X8_v4 (PlayerProfileModel)] (should have been resolved before IL gen)");
					bool flag2 = obj9 == null;
					obj7 = obj6;
					if (!flag2)
					{
						goto IL_020b;
					}
				}
			}
		}
		goto IL_0716;
		IL_02d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj11 = default(object);
		object obj10 = obj11;
		goto IL_07ca;
		IL_07ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v477 @ X8_v17] (should have been resolved before IL gen)");
		object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1408;
		goto IL_08f1;
		IL_08f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = default(object);
		obj13..ctor();
		_ = 2;
		object text2 = default(object);
		LocalizableText localizableText = TextMeshProExtensions.Localize((string)text2);
		object obj14 = obj13 + 24;
		obj14 = localizableText;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj15 = obj13 + 32;
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 1;
		_ = 0;
		object obj16 = default(object);
		bool flag3 = obj16 == null;
		obj7 = obj6;
		playerProfileModel = (PlayerProfileModel)1;
		if (flag3)
		{
			goto IL_0716;
		}
		object obj17 = typeof(System.IOAsyncCallback) + 368;
		object obj18 = typeof(SqlSingle[]) + 2376;
		object obj19 = (nint)0 + (nint)856;
		object obj20 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v22+12E]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v22+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0468;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v22+B0]");
		object obj22 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X10_v21-8]");
			if (0 == (nint)obj17)
			{
				break;
			}
			obj6 = obj22 + 16;
			obj21--;
			bool flag4 = (nint)obj21 != 1;
			obj22 = obj6;
			if (flag4)
			{
				continue;
			}
			goto IL_0468;
		}
		object obj23 = obj20 + obj22;
		object obj24 = obj23 + 312;
		obj6 = obj22;
		goto IL_0811;
		IL_0716:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0724;
		IL_0724:
		object obj25 = obj7 + 9;
		object obj26 = (object)playerProfileModel + obj25;
		object obj27 = obj26 + 312;
		goto IL_08cf;
		IL_08cf:
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v3+8]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v329 @ X2_v2 (should have been resolved before IL gen)");
		goto IL_08f1;
		IL_0604:
		nint num2 = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v29 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v29 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0698;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v29 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj7 = (nint)0 + (nint)8;
		object obj31;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X10_v28-8]");
			bool flag5 = 0 == (nint)obj17;
			obj31 = 0;
			playerProfileModel = (PlayerProfileModel)num2;
			if (flag5)
			{
				break;
			}
			obj7 += 16;
			obj30--;
			if ((nint)obj30 != 1)
			{
				continue;
			}
			goto IL_0698;
		}
		goto IL_0724;
		IL_0170:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v371 @ X0_v64 (PlayerProfileModel)] (should have been resolved before IL gen)");
		bool flag6 = obj9 == null;
		object obj32 = !flag6;
		obj6 = obj7;
		if (obj32 != null)
		{
			goto IL_020b;
		}
		PlayerProfileModel playerProfileModel2 = default(PlayerProfileModel);
		playerProfileModel = playerProfileModel2;
		goto IL_0716;
		IL_020b:
		object obj33 = typeof(System.IOAsyncCallback) + 384;
		object obj34 = "AvailableVoices" + 1064;
		text2 = "AvailableVoices" + 768;
		object obj35 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v16+12E]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v16+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02d9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v16+B0]");
		object obj37 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X10_v26-8]");
			if (0 == (nint)obj33)
			{
				break;
			}
			obj6 = obj37 + 16;
			obj36--;
			bool flag7 = (nint)obj36 != 1;
			obj37 = obj6;
			if (flag7)
			{
				continue;
			}
			goto IL_02d9;
		}
		object obj38 = obj35 + obj37;
		obj10 = obj38 + 312;
		obj6 = obj37;
		goto IL_07ca;
		IL_0811:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v568 @ X0_v27] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj19);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7894]");
		playerProfileModel = (PlayerProfileModel)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj39 = default(object);
		obj39..ctor();
		_ = 1;
		LocalizableText localizableText2 = TextMeshProExtensions.Localize((string)text);
		object obj40 = obj39 + 24;
		obj40 = localizableText2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj41 = obj39 + 32;
		obj41 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 1;
		_ = 0;
		object obj42 = default(object);
		bool flag8 = obj42 == null;
		obj31 = 0;
		obj7 = obj6;
		if (!flag8)
		{
			object obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v27+12E]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v27+12E]");
			if ((nint)0 == 0)
			{
				goto IL_05ba;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v27+B0]");
			obj7 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X10_v28-8]");
				if (0 == (nint)obj17)
				{
					break;
				}
				obj6 = obj7 + 16;
				obj44--;
				bool flag9 = (nint)obj44 != 1;
				obj7 = obj6;
				if (flag9)
				{
					continue;
				}
				goto IL_05ba;
			}
			object obj45 = obj43 + obj7;
			object obj46 = obj45 + 312;
			playerProfileModel = (PlayerProfileModel)obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v634 @ X0_v50] (should have been resolved before IL gen)");
			bool flag10 = ex == null;
			object obj47 = !flag10;
			obj31 = 0;
			if (obj47 != null)
			{
				goto IL_0604;
			}
		}
		goto IL_0716;
		IL_05ba:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj48 = default(object);
		playerProfileModel = (PlayerProfileModel)obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v619 @ X0_v47] (should have been resolved before IL gen)");
		bool flag11 = ex == null;
		obj31 = 0;
		obj7 = obj6;
		if (!flag11)
		{
			goto IL_0604;
		}
		goto IL_0716;
		IL_0468:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0811;
		IL_0698:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj31 = 0;
		object obj49 = default(object);
		obj27 = obj49;
		goto IL_08cf;
	}

	private void UnBlock()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0051: Expected I, but got O
		//IL_0080: Expected O, but got I4
		//IL_00af: Expected I4, but got I8
		PlayerProfileModel profile = _profile;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj2 = (nint)0 + (nint)1096;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.UnblockUser((int)profile.<userDbId>k__BackingField, action);
	}

	private void Remove()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0065: Expected O, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00bc: Expected I, but got O
		//IL_00eb: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		PlayerProfileModel profile = _profile;
		object obj4 = typeof(SqlSingle[]) + 2376;
		object obj5 = (nint)0 + (nint)864;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgTitle = "Complete" + 256;
		object msgBody = "Added Tournament Prizes And Features" + 2208;
		_ = profile.<userDbId>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj5);
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowNegativeConfirm((string)msgTitle, (string)msgBody, action);
	}

	private void Preview()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1792;
		long num = default(long);
		string dbId = num.ToString();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			AvatarPreviewPopup.Show(dbId);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		AvatarPreviewPopup.Show(dbId);
	}

	private void Mod()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0077: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2776;
		object obj2 = (nint)0 + (nint)1080;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj4 = (nint)0 + (nint)2160;
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

	private void MuteAndZeroCurrency()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_008c: Expected O, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_012f: Expected O, but got I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_017a: Expected O, but got I
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_01c9: Expected O, but got I4
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0255: Expected I, but got O
		//IL_0265: Expected O, but got I
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected O, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected O, but got Unknown
		//IL_02a0: Expected O, but got I
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_03bf: Expected O, but got I
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected O, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_044b: Expected I, but got O
		//IL_047a: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2104;
		object obj4 = obj2 + 32;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		BanRequestModel banRequestModel = default(BanRequestModel);
		banRequestModel..ctor();
		PlayerProfileModel profile = _profile;
		object obj5 = "Complete" + 3408;
		object obj6 = (nint)0 + (nint)2000;
		object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		banRequestModel.<UserID>k__BackingField = profile.<userDbId>k__BackingField;
		banRequestModel.<Duration>k__BackingField = 3;
		object obj8 = banRequestModel + 32;
		obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = banRequestModel + 40;
		obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v17+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SFSConfig currentSFS = Config.CurrentSFS;
		object obj12 = typeof(Queue<string>) + 848;
		object obj13 = (nint)0 + (nint)2200;
		object obj14 = banRequestModel + 48;
		obj14 = currentSFS.<ID>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj15 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v24+E4]");
		bool flag2 = (nint)0 == 0;
		object obj16 = !flag2;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		object obj17 = ((currentRoom != null) ? obj2 : null);
		object obj23;
		if (currentRoom != null)
		{
			object obj18 = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)currentRoom;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02e1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj20 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X10_v7-8]");
				if (0 == (nint)obj18)
				{
					break;
				}
				obj20 += 16;
				obj19--;
				if ((nint)obj19 != 1)
				{
					continue;
				}
				goto IL_02e1;
			}
			object obj21 = obj20 + 1;
			object obj22 = num + obj21;
			obj23 = obj22 + 312;
			goto IL_0502;
		}
		obj17 = obj2;
		goto IL_0511;
		IL_0511:
		Room room = (Room)((currentRoom != null) ? currentRoom : obj6);
		object obj24 = banRequestModel + 56;
		obj24 = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string reportText = ChatHandler.GetReportText();
		object obj25 = banRequestModel + 64;
		obj25 = reportText;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj26 = obj17 + 16;
		obj26 = banRequestModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object text = aces.text;
		PlayerProfileModel profile2 = _profile;
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 2256;
		object obj27 = typeof(SqlSingle[]) + 2376;
		object obj28 = (nint)0 + (nint)880;
		object obj29 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgTitle = "Material with texture name \"" + 3104;
		object msgBody = "Added Tournament Prizes And Features" + 2208;
		string text2 = string.Format((string)format, profile2.<userName>k__BackingField, text);
		object obj30 = obj2 + 24;
		obj30 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj28);
		object obj31 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v49+E4]");
		bool flag3 = (nint)0 == 0;
		object obj32 = !flag3;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowNegativeConfirm((string)msgTitle, (string)msgBody, action);
		return;
		IL_02e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj33 = default(object);
		obj23 = obj33;
		goto IL_0502;
		IL_0502:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v334 @ X8_v17] (should have been resolved before IL gen)");
		goto IL_0511;
	}

	private void GenerateCommunityBadge()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0077: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1688;
		object obj2 = (nint)0 + (nint)1064;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj4 = (nint)0 + (nint)1992;
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

	private void OpenAdminPage()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_016c: Expected O, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_0111: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4032;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string backendURL = Config.BackendURL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UriBuilder uriBuilder = default(UriBuilder);
		uriBuilder..ctor(backendURL);
		object obj5 = "___# Content push apply failed [{0}]: {1}" + 3832;
		string host = (string)obj5 + uriBuilder._host;
		uriBuilder.Host = host;
		string text = uriBuilder.ToString();
		object obj6 = "Unsupported map type" + 880;
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		long num = default(long);
		string text2 = num.ToString();
		string url = text + (string)obj6 + text2;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KUtil.OpenURL(url);
	}

	private void RemoveBio()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0065: Expected O, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00bc: Expected I, but got O
		//IL_00eb: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		PlayerProfileModel profile = _profile;
		object obj4 = typeof(SqlSingle[]) + 2376;
		object obj5 = (nint)0 + (nint)896;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgTitle = "Read object reference Id '{0}' for {1}." + 1616;
		object msgBody = "Added Tournament Prizes And Features" + 2208;
		_ = profile.<userDbId>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj5);
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowNegativeConfirm((string)msgTitle, (string)msgBody, action);
	}

	private void RemoveAvatar()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0065: Expected O, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00bc: Expected I, but got O
		//IL_00eb: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		PlayerProfileModel profile = _profile;
		object obj4 = typeof(SqlSingle[]) + 2376;
		object obj5 = (nint)0 + (nint)912;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgTitle = "Read object reference Id '{0}' for {1}." + 1608;
		object msgBody = "Added Tournament Prizes And Features" + 2208;
		_ = profile.<userDbId>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj5);
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowNegativeConfirm((string)msgTitle, (string)msgBody, action);
	}

	private void PopulateBio(string profileBio)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0219: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_0112: Expected O, but got I4
		//IL_0263: Expected O, but got I4
		//IL_026c: Expected O, but got I4
		//IL_02b1: Expected O, but got I4
		//IL_02bb: Expected O, but got I4
		//IL_0194: Expected O, but got I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_03ed: Expected O, but got I4
		//IL_03a3: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7890]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = bio;
			obj6 = bio;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = bio;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = bio;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c0;
		IL_0344:
		TextMeshProUGUI textMeshProUGUI;
		string text;
		textMeshProUGUI.text = text;
		bio.isRightToLeftText = true;
		return;
		IL_01a2:
		object obj10 = "Cannot populate JSON object onto type '{0}'." + 3168;
		object obj11 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3008;
		bool isMyProfile = IsMyProfile;
		bool flag5 = !isMyProfile;
		object obj12 = !flag5;
		object obj13 = ~obj12;
		object text2 = ((obj13 != null) ? obj11 : obj10);
		TextMeshProExtensions.Localize(bio, (string)text2);
		return;
		IL_00c0:
		object obj14 = typeof(System.IOAsyncCallback) + 3096;
		object obj15 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj16 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v20+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		text = InputSanitizer.SanitizeHtmlTags(profileBio);
		object obj18 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v24+E4]");
		if ((nint)0 != 0)
		{
			bool flag7 = StringsExtensions.IsNullOrEmpty(text);
			bool flag8 = !flag7;
			object obj19 = 0;
			if (!flag8)
			{
				goto IL_01a2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag9 = StringsExtensions.IsNullOrEmpty(text);
			bool flag10 = !flag9;
			object obj20 = !flag10;
			object obj19 = 0;
			if (obj20 != null)
			{
				goto IL_01a2;
			}
		}
		object obj21 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v26+E4]");
		TextMeshProUGUI textMesh;
		if ((nint)0 != 0)
		{
			bool flag11 = LocalizationUtil.IsArabicFixed(text);
			textMeshProUGUI = bio;
			bool flag12 = !flag11;
			textMesh = bio;
			if (!flag12)
			{
				goto IL_0344;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag13 = LocalizationUtil.IsArabicFixed(text);
			textMeshProUGUI = bio;
			bool flag14 = !flag13;
			object obj23 = !flag14;
			textMesh = bio;
			if (obj23 != null)
			{
				goto IL_0344;
			}
		}
		TextMeshProExtensions.FixArabic(textMesh, text);
		return;
		IL_0091:
		bool flag15 = obj5;
		bool flag16 = !flag15;
		obj9 = 0;
		if (!flag16)
		{
			goto IL_00c0;
		}
	}

	private void PopulateProfile()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004f: Expected O, but got I
		if (IsMyProfile)
		{
			avatar.InitializeMyAvatar();
			return;
		}
		AvatarData data = _profile;
		avatar.Initialize(data);
		object action = "Unsupported map type" + 2896;
		object type = (nint)0 + (nint)2000;
		FirebaseTrack.Event((string)action, (string)type);
	}

	private void StartLoading()
	{
		int num = ShortcutExtensions.DOKill(blockerGroup);
		GameObject gameObject = blockerGroup.gameObject;
		gameObject.SetActive(value: true);
		blockerGroup.alpha = 1f;
		loadingIndicator.StartLoading();
	}

	private void StopLoading()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2480;
		int num = ShortcutExtensions.DOKill(blockerGroup);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(blockerGroup, 0f, 0.3f);
		TweenCallback tweenCallback = TweenHelpers.Disable(blockerGroup);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		loadingIndicator.FinishLoading();
	}

	private void AnimateMonthlyTournamentTrophy()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00de: Expected O, but got I4
		UserAchievementModel monthlyTrophy = _profile.GetMonthlyTrophy();
		if (monthlyTrophy == null)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			if (!_monthlyTrophyUISetter)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = _monthlyTrophyUISetter;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				return;
			}
		}
		_monthlyTrophyUISetter.Populate(monthlyTrophy);
	}

	private void ResetUi()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6f: Expected O, but got Unknown
		//IL_0c78: Expected O, but got I4
		//IL_0072: Expected O, but got I
		//IL_002a: Expected O, but got I
		//IL_0044: Expected O, but got I4
		//IL_00e3: Expected O, but got I
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I4
		//IL_00b3: Expected O, but got I
		//IL_00c3: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_01b0: Expected O, but got I4
		//IL_01f9: Expected O, but got I4
		//IL_0202: Expected O, but got I4
		//IL_0674: Expected O, but got I4
		//IL_067d: Expected O, but got I4
		//IL_0686: Expected O, but got I4
		//IL_023d: Expected O, but got I4
		//IL_0731: Expected O, but got I4
		//IL_073a: Expected O, but got I4
		//IL_0743: Expected O, but got I4
		//IL_02c0: Expected O, but got I4
		//IL_0800: Expected O, but got I4
		//IL_0809: Expected O, but got I4
		//IL_0812: Expected O, but got I4
		//IL_0343: Expected O, but got I4
		//IL_08cf: Expected O, but got I4
		//IL_08d8: Expected O, but got I4
		//IL_08e1: Expected O, but got I4
		//IL_03c6: Expected O, but got I4
		//IL_099e: Expected O, but got I4
		//IL_09a7: Expected O, but got I4
		//IL_09b0: Expected O, but got I4
		//IL_0449: Expected O, but got I4
		//IL_0a5b: Expected O, but got I4
		//IL_0a64: Expected O, but got I4
		//IL_0a6d: Expected O, but got I4
		//IL_04cc: Expected O, but got I4
		//IL_0b2a: Expected O, but got I4
		//IL_0b33: Expected O, but got I4
		//IL_0b3c: Expected O, but got I4
		//IL_054f: Expected O, but got I4
		//IL_0bf9: Expected O, but got I4
		//IL_0c02: Expected O, but got I4
		//IL_0c55: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = this + 224;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X20_v3-80]");
			bool flag = (UnityEngine.Object)0;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				goto IL_0094;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X20_v3-80]");
			if ((bool)(UnityEngine.Object)0)
			{
				goto IL_0094;
			}
		}
		goto IL_00d7;
		IL_0566:
		UnityEngine.Object obj5 = removeAvatar;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		UnityEngine.Object obj7 = removeAvatar;
		if (!flag3)
		{
			goto IL_05a7;
		}
		goto IL_0c23;
		IL_0ba3:
		GameObject gameObject = removeBio.gameObject;
		gameObject.SetActive(value: false);
		obj5 = removeAvatar;
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		object obj9 = 0;
		bool flag5 = false;
		obj7 = removeAvatar;
		if (obj8 != null)
		{
			goto IL_05a7;
		}
		goto IL_0c23;
		IL_0094:
		object obj10 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v56+90]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v57+B8]");
		object text = 0;
		bio.text = (string)text;
		goto IL_00d7;
		IL_00d7:
		object obj12 = (nint)0 + (nint)288;
		object text2 = "LAK" + 1640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh, (string)text2);
		object text3 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		TextMeshProUGUI textMesh2 = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh2, (string)text3);
		like.interactable = false;
		add.interactable = false;
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v5+E4]");
		bool flag8;
		if ((nint)0 != 0)
		{
			bool flag6 = report;
			bool flag7 = !flag6;
			object obj14 = !flag7;
			flag8 = false;
			if (obj14 == null)
			{
				goto IL_01c7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag9 = report;
			bool flag10 = !flag9;
			flag8 = false;
			if (flag10)
			{
				goto IL_01c7;
			}
		}
		report.interactable = false;
		UnityEngine.Object obj15 = gift;
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v28+E4]");
		bool flag11 = (nint)0 == 0;
		object obj17 = !flag11;
		obj9 = 0;
		object obj18 = 0;
		flag8 = false;
		UnityEngine.Object obj19 = gift;
		if (obj17 != null)
		{
			goto IL_021a;
		}
		goto IL_06a7;
		IL_05cd:
		GameObject gameObject2 = removeAvatar.gameObject;
		gameObject2.SetActive(value: false);
		return;
		IL_05a7:
		if ((bool)obj5)
		{
			goto IL_05cd;
		}
		return;
		IL_0c23:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag12 = obj7;
		bool flag13 = !flag12;
		object obj20 = !flag13;
		if (obj20 == null)
		{
			return;
		}
		goto IL_05cd;
		IL_01c7:
		obj15 = gift;
		obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v28+E4]");
		bool flag14 = (nint)0 == 0;
		obj9 = 0;
		obj18 = 0;
		obj19 = gift;
		if (!flag14)
		{
			goto IL_021a;
		}
		goto IL_06a7;
		IL_06a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag15 = obj19;
		bool flag16 = !flag15;
		obj9 = obj18;
		bool flag17 = false;
		if (flag16)
		{
			goto IL_0254;
		}
		goto IL_06ed;
		IL_021a:
		bool flag18 = obj15;
		bool flag19 = !flag18;
		object obj21 = !flag19;
		flag17 = false;
		if (obj21 == null)
		{
			goto IL_0254;
		}
		goto IL_06ed;
		IL_06ed:
		gift.interactable = false;
		UnityEngine.Object obj22 = remove;
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v25+E4]");
		bool flag20 = (nint)0 == 0;
		object obj24 = !flag20;
		obj9 = 0;
		object obj25 = 0;
		flag17 = false;
		UnityEngine.Object obj26 = remove;
		if (obj24 != null)
		{
			goto IL_029d;
		}
		goto IL_0764;
		IL_0254:
		obj22 = remove;
		obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v25+E4]");
		bool flag21 = (nint)0 == 0;
		obj25 = obj9;
		obj26 = remove;
		if (!flag21)
		{
			goto IL_029d;
		}
		goto IL_0764;
		IL_0764:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag22 = obj26;
		bool flag23 = !flag22;
		obj9 = obj25;
		bool flag24 = false;
		if (flag23)
		{
			goto IL_02d7;
		}
		goto IL_07aa;
		IL_029d:
		bool flag25 = obj22;
		bool flag26 = !flag25;
		object obj27 = !flag26;
		flag24 = false;
		if (obj27 == null)
		{
			goto IL_02d7;
		}
		goto IL_07aa;
		IL_07aa:
		GameObject gameObject3 = remove.gameObject;
		gameObject3.SetActive(value: false);
		UnityEngine.Object obj28 = block;
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v22+E4]");
		bool flag27 = (nint)0 == 0;
		object obj30 = !flag27;
		obj9 = 0;
		object obj31 = 0;
		flag24 = false;
		UnityEngine.Object obj32 = block;
		if (obj30 != null)
		{
			goto IL_0320;
		}
		goto IL_0833;
		IL_02d7:
		obj28 = block;
		obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v22+E4]");
		bool flag28 = (nint)0 == 0;
		obj31 = obj9;
		obj32 = block;
		if (!flag28)
		{
			goto IL_0320;
		}
		goto IL_0833;
		IL_0833:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag29 = obj32;
		bool flag30 = !flag29;
		obj9 = obj31;
		bool flag31 = false;
		if (flag30)
		{
			goto IL_035a;
		}
		goto IL_0879;
		IL_0320:
		bool flag32 = obj28;
		bool flag33 = !flag32;
		object obj33 = !flag33;
		flag31 = false;
		if (obj33 == null)
		{
			goto IL_035a;
		}
		goto IL_0879;
		IL_0879:
		GameObject gameObject4 = block.gameObject;
		gameObject4.SetActive(value: false);
		UnityEngine.Object obj34 = unblock;
		object obj35 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v19+E4]");
		bool flag34 = (nint)0 == 0;
		object obj36 = !flag34;
		obj9 = 0;
		object obj37 = 0;
		flag31 = false;
		UnityEngine.Object obj38 = unblock;
		if (obj36 != null)
		{
			goto IL_03a3;
		}
		goto IL_0902;
		IL_035a:
		obj34 = unblock;
		obj35 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v19+E4]");
		bool flag35 = (nint)0 == 0;
		obj37 = obj9;
		obj38 = unblock;
		if (!flag35)
		{
			goto IL_03a3;
		}
		goto IL_0902;
		IL_0902:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag36 = obj38;
		bool flag37 = !flag36;
		obj9 = obj37;
		bool flag38 = false;
		if (flag37)
		{
			goto IL_03dd;
		}
		goto IL_0948;
		IL_03a3:
		bool flag39 = obj34;
		bool flag40 = !flag39;
		object obj39 = !flag40;
		flag38 = false;
		if (obj39 == null)
		{
			goto IL_03dd;
		}
		goto IL_0948;
		IL_0948:
		GameObject gameObject5 = unblock.gameObject;
		gameObject5.SetActive(value: false);
		UnityEngine.Object obj40 = preview;
		object obj41 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v38+E4]");
		bool flag41 = (nint)0 == 0;
		object obj42 = !flag41;
		obj9 = 0;
		object obj43 = 0;
		flag38 = false;
		UnityEngine.Object obj44 = preview;
		if (obj42 != null)
		{
			goto IL_0426;
		}
		goto IL_09d1;
		IL_03dd:
		obj41 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v38+E4]");
		bool flag42 = (nint)0 == 0;
		obj40 = preview;
		obj43 = obj9;
		obj44 = preview;
		if (!flag42)
		{
			goto IL_0426;
		}
		goto IL_09d1;
		IL_09d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag43 = obj44;
		bool flag44 = !flag43;
		obj9 = obj43;
		bool flag45 = false;
		if (flag44)
		{
			goto IL_0460;
		}
		goto IL_0a17;
		IL_0426:
		bool flag46 = obj40;
		bool flag47 = !flag46;
		object obj45 = !flag47;
		flag45 = false;
		if (obj45 == null)
		{
			goto IL_0460;
		}
		goto IL_0a17;
		IL_0a17:
		preview.interactable = false;
		UnityEngine.Object obj46 = mod;
		object obj47 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v31+E4]");
		bool flag48 = (nint)0 == 0;
		object obj48 = !flag48;
		obj9 = 0;
		object obj49 = 0;
		flag45 = false;
		UnityEngine.Object obj50 = mod;
		if (obj48 != null)
		{
			goto IL_04a9;
		}
		goto IL_0a8e;
		IL_0460:
		obj47 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v31+E4]");
		bool flag49 = (nint)0 == 0;
		obj46 = mod;
		obj49 = obj9;
		obj50 = mod;
		if (!flag49)
		{
			goto IL_04a9;
		}
		goto IL_0a8e;
		IL_0a8e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag50 = obj50;
		bool flag51 = !flag50;
		obj9 = obj49;
		bool flag52 = false;
		if (flag51)
		{
			goto IL_04e3;
		}
		goto IL_0ad4;
		IL_04a9:
		bool flag53 = obj46;
		bool flag54 = !flag53;
		object obj51 = !flag54;
		flag52 = false;
		if (obj51 == null)
		{
			goto IL_04e3;
		}
		goto IL_0ad4;
		IL_0ad4:
		GameObject gameObject6 = mod.gameObject;
		gameObject6.SetActive(value: false);
		UnityEngine.Object obj52 = removeBio;
		object obj53 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v23+E4]");
		bool flag55 = (nint)0 == 0;
		object obj54 = !flag55;
		obj9 = 0;
		object obj55 = 0;
		flag52 = false;
		UnityEngine.Object obj56 = removeBio;
		if (obj54 != null)
		{
			goto IL_052c;
		}
		goto IL_0b5d;
		IL_04e3:
		obj53 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v23+E4]");
		bool flag56 = (nint)0 == 0;
		obj52 = removeBio;
		obj55 = obj9;
		obj56 = removeBio;
		if (!flag56)
		{
			goto IL_052c;
		}
		goto IL_0b5d;
		IL_0b5d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag57 = obj56;
		bool flag58 = !flag57;
		obj9 = obj55;
		flag5 = false;
		if (flag58)
		{
			goto IL_0566;
		}
		goto IL_0ba3;
		IL_052c:
		bool flag59 = obj52;
		bool flag60 = !flag59;
		object obj57 = !flag60;
		flag5 = false;
		if (obj57 == null)
		{
			goto IL_0566;
		}
		goto IL_0ba3;
	}

	private void CreateChallengeClicked()
	{
		//IL_0023: Expected I4, but got I8
		PlayerProfileModel profile = _profile;
		eventsChannel.TriggerOnChallengeCreateStarted((int)profile.<userDbId>k__BackingField);
	}

	private void <Like>b__45_0(KammelnaResponseModel<bool> response)
	{
		//IL_0011: Expected O, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1048;
		if (response.Succeeded)
		{
			PlayerProfileModel profile = _profile;
			int <likes>k__BackingField = profile.<likes>k__BackingField + 1;
			profile.<likes>k__BackingField = <likes>k__BackingField;
			profile.<isLiked>k__BackingField = true;
			PopulateProfile();
			UpdateButtonsState();
			ITrackEvent trackEvent = TrackerLibrary.ProfileMiniProfileLiked();
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v9+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
		}
	}

	private void <Report>b__47_0(KammelnaResponseModel<bool> response)
	{
		//IL_0011: Expected O, but got I
		//IL_00fd: Expected O, but got I
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0075: Expected O, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1048;
		if (response.Succeeded)
		{
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object title = "DNQUALIFIER" + 3784;
			object body = "Read object reference Id '{0}' for {1}." + 2312;
			object buttonText = "Network Authentication Required" + 3128;
			PopupWindow.ShowInfo((string)title, (string)body, (string)buttonText);
			report.interactable = false;
			_alreadyReported = true;
		}
		else
		{
			object obj5 = (nint)0 + (nint)1024;
			string errorMessage = response.ErrorMessage;
			object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v10+E4]");
			if ((nint)0 != 0)
			{
				PopupWindow.ShowError(errorMessage);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.ShowError(errorMessage);
		}
	}

	private void <UnBlock>b__52_0(KammelnaResponseModel<bool> response)
	{
		//IL_0011: Expected O, but got I
		//IL_00ec: Expected O, but got I
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0137: Expected O, but got I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0079: Expected O, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1048;
		if (response.Succeeded)
		{
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object title = "DNQUALIFIER" + 3784;
			object body = "Unsupported map type" + 744;
			object buttonText = "Network Authentication Required" + 3128;
			PopupWindow.ShowInfo((string)title, (string)body, (string)buttonText);
			UpdateButtonsState();
		}
		else
		{
			object obj5 = (nint)0 + (nint)1024;
			string errorMessage = response.ErrorMessage;
			object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.ShowError(errorMessage);
			UpdateButtonsState();
		}
	}

	private void <Mod>b__55_0(ModeratorControl instance)
	{
		//IL_0021: Expected I4, but got I8
		PlayerProfileModel profile = _profile;
		instance.ShowForUser((int)profile.<userDbId>k__BackingField);
	}

	private void <GenerateCommunityBadge>b__57_0(CommunityBadgeScreenshot c)
	{
		long num = default(long);
		string dbId = num.ToString();
		c.ShareCommunityBadge(dbId);
	}
}
