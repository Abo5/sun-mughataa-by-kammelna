using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class RoutingManager : Singleton<RoutingManager>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action <>9__15_0;

		public static Action <>9__17_3;

		public static Action <>9__17_4;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <NavigateImmediate>b__15_0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0061: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 3136;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.LoadScene(Scenes.Menu);
		}

		internal void <Navigate>b__17_3()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00bc: Expected O, but got I
			//IL_00e6: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_012f: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(Queue<string>) + 752;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CEA]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2024;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
				object obj4 = (nint)0 + (nint)2024;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
			IAPController iAPController = default(IAPController);
			bool flag3 = (object)iAPController == null;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00a0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			goto IL_00a0;
			IL_00a0:
			iAPController.PresentPlatformCodeRedeemSheet();
		}

		internal void <Navigate>b__17_4()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected O, but got Unknown
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected O, but got Unknown
			//IL_01cd: Expected O, but got I4
			//IL_00fb: Expected O, but got I
			//IL_0115: Expected O, but got I4
			//IL_0075: Expected O, but got I
			//IL_0153: Expected O, but got I4
			//IL_00d0: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object message = "Index = {0} position = {1}" + 1736;
			object obj2 = typeof(RegisteredWaitHandle) + 1552;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.ShowError((string)message);
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DEF]");
				object obj6 = (nint)0 & (nint)1;
				if (obj6 != null)
				{
					goto IL_0092;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DEF]");
				object obj7 = (nint)0 & (nint)1;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				if (obj8 != null)
				{
					goto IL_0092;
				}
			}
			_ = 1;
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v15+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			object obj11 = obj9;
			if (obj10 != null)
			{
				goto IL_00c7;
			}
			goto IL_0169;
			IL_0092:
			obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			obj11 = obj9;
			if (!flag4)
			{
				goto IL_00c7;
			}
			goto IL_0169;
			IL_0169:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj2;
			goto IL_00c7;
			IL_00c7:
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public RoutingParams routingParams;

		internal bool <ValidateAndNavigate>b__0(Predicate<RoutingParams> predicate)
		{
			//IL_006f: Expected I4, but got O
			//IL_0037: Expected O, but got I
			//IL_0047: Expected O, but got I
			//IL_0057: Expected O, but got I
			if (predicate != null)
			{
				RoutingParams routingParams = this.routingParams;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [predicate @ X1 (System.Predicate`1<RoutingParams>)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [predicate @ X1 (System.Predicate`1<RoutingParams>)+40]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [predicate @ X1 (System.Predicate`1<RoutingParams>)+28]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X3_v1 (should have been resolved before IL gen)");
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <ValidateAndNavigate>b__1()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00cc: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1552;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CEB]");
			object obj2 = (nint)0 & (nint)1;
			RoutingParams routingParams;
			RoutingParams routingParams2;
			if (obj2 != null)
			{
				routingParams = this.routingParams;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				routingParams2 = this.routingParams;
				if (!flag)
				{
					goto IL_0088;
				}
			}
			else
			{
				_ = 1;
				routingParams = this.routingParams;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v1+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				routingParams2 = this.routingParams;
				if (obj4 != null)
				{
					goto IL_0088;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Navigate(routingParams2);
			return;
			IL_0088:
			Navigate(routingParams);
		}
	}

	private sealed class <>c__DisplayClass17_0
	{
		public RoutingParams routingParams;

		public Action <>9__1;

		public Action <>9__2;

		internal void <Navigate>b__0()
		{
			//IL_049f: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a4: Expected O, but got Unknown
			//IL_0462: Expected O, but got I
			//IL_0478: Expected I4, but got I8
			//IL_0831: Unknown result type (might be due to invalid IL or missing references)
			//IL_0836: Expected O, but got Unknown
			//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f5: Expected O, but got Unknown
			//IL_0717: Expected O, but got I4
			//IL_04ee: Expected O, but got I4
			//IL_0799: Unknown result type (might be due to invalid IL or missing references)
			//IL_079e: Expected O, but got Unknown
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Expected O, but got Unknown
			//IL_0213: Expected O, but got I4
			//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03af: Expected O, but got Unknown
			//IL_03d1: Expected O, but got I4
			//IL_0734: Unknown result type (might be due to invalid IL or missing references)
			//IL_0739: Expected O, but got Unknown
			//IL_074f: Expected O, but got I
			//IL_0757: Expected I, but got O
			//IL_0765: Expected I, but got O
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Expected O, but got Unknown
			//IL_0279: Expected O, but got I4
			//IL_051d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0522: Expected O, but got Unknown
			//IL_054c: Expected O, but got I4
			//IL_077d: Expected O, but got I4
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Expected O, but got Unknown
			//IL_02a2: Expected O, but got I
			//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c0: Expected O, but got Unknown
			//IL_02ea: Expected O, but got I4
			//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f3: Expected O, but got Unknown
			//IL_0409: Expected O, but got I
			//IL_0411: Expected I, but got O
			//IL_041f: Expected I, but got O
			//IL_0a32: Expected I, but got O
			//IL_08c5: Expected O, but got I
			//IL_08d5: Expected O, but got I
			//IL_08f7: Expected O, but got I4
			//IL_0437: Expected O, but got I4
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Expected O, but got Unknown
			//IL_00e4: Expected O, but got I
			//IL_00f4: Expected O, but got I
			//IL_0927: Expected O, but got I4
			//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b6c: Expected O, but got Unknown
			//IL_0b82: Expected O, but got I
			//IL_0b8a: Expected I, but got O
			//IL_0b9b: Expected I, but got O
			//IL_0bb9: Expected O, but got I
			//IL_096b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0970: Expected O, but got Unknown
			//IL_099a: Expected O, but got I4
			//IL_09ab: Expected O, but got I4
			//IL_09b3: Expected I, but got O
			//IL_0957: Expected O, but got I
			//IL_0a53: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a58: Expected O, but got Unknown
			//IL_0a82: Expected O, but got I4
			//IL_0aa8: Expected O, but got I
			//IL_0ab8: Expected O, but got I
			//IL_0ada: Expected O, but got I4
			//IL_06a8: Expected O, but got I4
			//IL_0659: Expected O, but got I4
			//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0afc: Expected O, but got Unknown
			//IL_0b12: Expected O, but got I
			//IL_0b23: Expected I, but got O
			//IL_0b41: Expected O, but got I
			//IL_06d8: Expected O, but got I
			RoutingParams routingParams = this.routingParams;
			Action action;
			Action action3;
			Action action4;
			object obj12;
			if (this.routingParams != null)
			{
				if (routingParams.Command > RoutingCommand.FastTrackMenu)
				{
					nint num2;
					if (routingParams.Command <= RoutingCommand.PresentRedeemCodeSheet)
					{
						nint num;
						object obj14;
						if (routingParams.Command != RoutingCommand.BuyProduct)
						{
							if (routingParams.Command != RoutingCommand.PresentRedeemCodeSheet)
							{
								goto IL_04db;
							}
							object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2200;
							object obj2 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v73+E4]");
							object obj3;
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v73+B8]");
								obj3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v58+10]");
								action = (Action)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v58+10]");
								if ((nint)0 != 0)
								{
									goto IL_0119;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj2 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v73+B8]");
								obj3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v58+10]");
								action = (Action)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v58+10]");
								bool flag = (nint)0 == 0;
								object obj4 = !flag;
								if (obj4 != null)
								{
									goto IL_0119;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v73+E4]");
							bool flag2 = (nint)0 == 0;
							object obj5 = !flag2;
							if (obj5 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj6 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v67+B8]");
								obj3 = 0;
							}
							object obj7 = typeof(SqlSingle[]) + 2376;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj8 = (nint)0 + (nint)960;
							num = (nint)obj8;
							Action action2 = default(Action);
							action2..ctor(obj3, (IntPtr)obj8);
							object obj9 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v63+B8]");
							object obj10 = (nint)0 + (nint)16;
							obj10 = action2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj11 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
							obj12 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v70+E4]");
							bool flag3 = (nint)0 == 0;
							object obj13 = !flag3;
							action = action2;
							obj14 = 0;
							num2 = (nint)action2;
							action3 = action2;
							if (obj13 != null)
							{
								goto IL_0162;
							}
							goto IL_09c9;
						}
						object obj15 = this + 24;
						action4 = (Action)obj15;
						bool flag4 = obj15 == null;
						object obj16 = !flag4;
						if (obj16 != null)
						{
							goto IL_078a;
						}
						object obj17 = typeof(SqlSingle[]) + 2376;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj18 = (nint)0 + (nint)1008;
						num = (nint)obj18;
						Action action5 = default(Action);
						action5..ctor(this, (IntPtr)obj18);
						<>9__1 = action5;
						obj14 = 0;
						action4 = action5;
					}
					else
					{
						if (routingParams.Command == (RoutingCommand)7008)
						{
							goto IL_0822;
						}
						if (routingParams.Command != RoutingCommand.BuyOffer)
						{
							goto IL_04db;
						}
						object obj15 = this + 32;
						action4 = (Action)obj15;
						bool flag5 = obj15 == null;
						object obj19 = !flag5;
						if (obj19 != null)
						{
							goto IL_078a;
						}
						object obj20 = typeof(SqlSingle[]) + 2376;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj21 = (nint)0 + (nint)1016;
						nint num = (nint)obj21;
						Action action6 = default(Action);
						action6..ctor(this, (IntPtr)obj21);
						<>9__2 = action6;
						object obj14 = 0;
						action4 = action6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					num2 = (nint)action4;
					goto IL_078a;
				}
				if (routingParams.Command == RoutingCommand.TVCreateGamePopup)
				{
					int tvUserId = int.Parse(routingParams.Payload);
					object obj22 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3680;
					object obj23 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v11+E4]");
					if ((nint)0 != 0)
					{
						TVCreateGameInvitePopup.Show(tvUserId);
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					TVCreateGameInvitePopup.Show(tvUserId);
					return;
				}
				if (routingParams.Command == RoutingCommand.Game)
				{
					int roomId = int.Parse(routingParams.Payload);
					object password = (nint)0 + (nint)2000;
					SFS.JoinGameRoom(roomId, -1, (string)password);
					return;
				}
				if (routingParams.Command != RoutingCommand.FastTrackMenu)
				{
					goto IL_0822;
				}
				object obj24 = typeof(RegisteredWaitHandle) + 1552;
				object obj25 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v17+E4]");
				bool flag6 = (nint)0 == 0;
				object obj26 = !flag6;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				SaveParams(this.routingParams);
				object obj27 = typeof(Queue<string>) + 856;
				object obj28 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v20+E4]");
				bool flag7 = (nint)0 == 0;
				object obj29 = !flag7;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj30 = (nint)0 + (nint)2216;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				object obj31 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
				object obj32 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X0_v24+E4]");
				bool flag8 = (nint)0 == 0;
				object obj33 = !flag8;
				if (obj33 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				SFSConfig fTServerForCurrentGame = Config.FTServerForCurrentGame;
				SfsConnectionManager sfsConnectionManager = default(SfsConnectionManager);
				if (fTServerForCurrentGame != null && (object)sfsConnectionManager != null)
				{
					sfsConnectionManager.SwitchServerAndReloadScene(fTServerForCurrentGame.<ID>k__BackingField);
					return;
				}
			}
			goto IL_09e2;
			IL_04db:
			object obj34 = routingParams.Command & (RoutingCommand)2147483646;
			if ((nint)obj34 == 13000)
			{
				object obj35 = typeof(RegisteredWaitHandle) + 1552;
				object obj36 = obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v41+E4]");
				bool flag9 = (nint)0 == 0;
				object obj37 = !flag9;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				SaveParams(this.routingParams);
				RoutingParams routingParams2 = this.routingParams;
				if (this.routingParams != null)
				{
					string s = routingParams2.Payload;
					if (routingParams2.Payload != null)
					{
						bool flag10 = routingParams2.Payload.Contains('|');
						bool flag11 = !flag10;
						StringSplitOptions stringSplitOptions = StringSplitOptions.None;
						if (!flag11)
						{
							string[] array = routingParams2.Payload.Split('|');
							if (array == null)
							{
								goto IL_09e2;
							}
							s = array[0];
							object obj14 = 0;
							stringSplitOptions = StringSplitOptions.None;
						}
						long num3 = long.Parse(s);
						object obj38 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2200;
						object obj39 = obj38;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X0_v50+E4]");
						bool flag12 = (nint)0 == 0;
						object obj40 = !flag12;
						long id = num3;
						if (obj40 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj39 = obj38;
							id = num3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X0_v50+B8]");
						object obj41 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v38+18]");
						Action failureCallback = (Action)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v38+18]");
						bool flag13 = (nint)0 == 0;
						object obj42 = !flag13;
						if (obj42 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X0_v50+E4]");
							bool flag14 = (nint)0 == 0;
							object obj43 = !flag14;
							if (obj43 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj44 = obj38;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X8_v44+B8]");
								obj41 = 0;
							}
							object obj45 = typeof(SqlSingle[]) + 2376;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj46 = (nint)0 + (nint)968;
							Action action7 = default(Action);
							action7..ctor(obj41, (IntPtr)obj46);
							object obj47 = obj38;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X8_v43+B8]");
							object obj48 = (nint)0 + (nint)24;
							obj48 = action7;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							failureCallback = action7;
						}
						MassTournamentManager.JoinRoom(id, null, failureCallback);
						return;
					}
				}
				goto IL_09e2;
			}
			if (routingParams.Command == RoutingCommand.RedeemGrant)
			{
				MarketingGrantHandler.Handle(routingParams.Payload);
				return;
			}
			goto IL_0822;
			IL_0822:
			object obj49 = typeof(RegisteredWaitHandle) + 1552;
			object obj50 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				LoadScene(this.routingParams);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			LoadScene(this.routingParams);
			return;
			IL_0162:
			Store.CallWhenLoaded(action);
			return;
			IL_0119:
			object obj51 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			obj12 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v70+E4]");
			bool flag15 = (nint)0 == 0;
			action3 = action;
			if (!flag15)
			{
				goto IL_0162;
			}
			goto IL_09c9;
			IL_09c9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Store.CallWhenLoaded(action3);
			return;
			IL_09e2:
			NullReferenceException ex = new NullReferenceException();
			throw new IndexOutOfRangeException();
			IL_078a:
			object obj52 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj53 = obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v36+E4]");
			if ((nint)0 != 0)
			{
				Store.CallWhenLoaded(action4);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Store.CallWhenLoaded(action4);
		}

		internal void <Navigate>b__1()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00e6: Expected O, but got I
			//IL_0110: Expected O, but got I4
			//IL_00c1: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Expected O, but got Unknown
			//IL_018c: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(Queue<string>) + 752;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CED]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2024;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v10+E4]");
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
				object obj4 = (nint)0 + (nint)2024;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v10+E4]");
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
			RoutingParams routingParams = this.routingParams;
			goto IL_014e;
			IL_014e:
			object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int productId = Convert.ToInt32(routingParams.Payload);
			IAPController iAPController = default(IAPController);
			iAPController.InitiateBuyingProduct(productId);
			return;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			routingParams = this.routingParams;
			bool flag4 = this.routingParams == null;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_014e;
		}

		internal void <Navigate>b__2()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00e6: Expected O, but got I
			//IL_0110: Expected O, but got I4
			//IL_00c1: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Expected O, but got Unknown
			//IL_018c: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(Queue<string>) + 752;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CEE]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2024;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v10+E4]");
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
				object obj4 = (nint)0 + (nint)2024;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v10+E4]");
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
			RoutingParams routingParams = this.routingParams;
			goto IL_014e;
			IL_014e:
			object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int offerId = Convert.ToInt32(routingParams.Payload);
			IAPController iAPController = default(IAPController);
			iAPController.InitiateBuyingOffer(offerId);
			return;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			routingParams = this.routingParams;
			bool flag4 = this.routingParams == null;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_014e;
		}
	}

	private sealed class <>c__DisplayClass18_0
	{
		public RoutingParams routingParams;

		internal void <LoadScene>g__TriggerRouteOnSceneLoaded|0(Scene scene, LoadSceneMode loadSceneMode)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_0077: Expected O, but got I4
			//IL_00c8: Expected I, but got O
			//IL_00f2: Expected O, but got I4
			RoutingParams routingParams = this.routingParams;
			object obj = typeof(RegisteredWaitHandle) + 1552;
			object obj2 = typeof(TypeConverter<ushort, char>) + 528;
			object obj3 = (nint)0 + (nint)1024;
			object obj4 = typeof(RegisteredWaitHandle) + 2944;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TriggerRoute(routingParams.Command, routingParams.Payload);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
			unityAction..ctor((object)this, (IntPtr)obj3);
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
		}
	}

	private sealed class <>c__DisplayClass20_0
	{
		public RoutingParams routingParams;

		internal void <NavigateWhenReady>g__SceneManagerOnSceneLoaded|0(Scene scene, LoadSceneMode mode)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00dc: Expected O, but got I4
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Expected O, but got Unknown
			//IL_0152: Expected O, but got I
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Expected O, but got Unknown
			//IL_017e: Expected I, but got O
			//IL_01ad: Expected O, but got I4
			//IL_0124: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(RegisteredWaitHandle) + 1552;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CF0]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v29+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v29+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool isTooEarlyToRoute = IsTooEarlyToRoute;
			bool flag3 = !isTooEarlyToRoute;
			object obj7 = !flag3;
			if (obj7 != null)
			{
				return;
			}
			goto IL_0132;
			IL_0132:
			object obj8 = typeof(TypeConverter<ushort, char>) + 528;
			object obj9 = (nint)0 + (nint)1032;
			object obj10 = typeof(RegisteredWaitHandle) + 2944;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
			unityAction..ctor((object)this, (IntPtr)obj9);
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v7+E4]");
			if ((nint)0 != 0)
			{
				ValidateAndNavigate(routingParams);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ValidateAndNavigate(routingParams);
			return;
			IL_0085:
			if (IsTooEarlyToRoute)
			{
				return;
			}
			goto IL_0132;
		}
	}

	public RoutingEventsChannel routingEventsChannel;

	public static LastRoutingParams LastRouting;

	private static readonly List<Predicate<RoutingParams>> validators;

	private static bool IsTooEarlyToRoute
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0279: Expected O, but got I
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0146: Expected O, but got I
			//IL_0160: Expected O, but got I4
			//IL_0070: Expected O, but got I
			//IL_01d6: Expected O, but got I
			//IL_01e6: Expected O, but got I
			//IL_01fc: Expected O, but got I
			//IL_0216: Expected O, but got I4
			//IL_019e: Expected O, but got I4
			//IL_00d2: Expected O, but got I
			//IL_00e2: Expected O, but got I
			//IL_00f8: Expected O, but got I
			//IL_0112: Expected O, but got I4
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Expected O, but got Unknown
			//IL_0248: Unknown result type (might be due to invalid IL or missing references)
			//IL_024d: Expected O, but got Unknown
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 552;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+B8]");
			object obj3 = 0;
			if ((nint)obj3 != 1)
			{
				goto IL_0120;
			}
			object obj4 = typeof(RegisteredWaitHandle) + 3136;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
				object obj6 = (nint)0 & (nint)1;
				if (obj6 != null)
				{
					goto IL_008d;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
				object obj7 = (nint)0 & (nint)1;
				bool flag = obj7 == null;
				object obj8 = !flag;
				if (obj8 != null)
				{
					goto IL_008d;
				}
			}
			_ = 1;
			object obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			object obj11 = obj9;
			if (obj10 != null)
			{
				goto IL_00c2;
			}
			goto IL_01b4;
			IL_01b4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v9+B8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v11+18]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v11+18]");
			object obj15 = -1;
			bool flag3 = (nint)obj15 < 2;
			object obj16 = !flag3;
			object obj17 = ~obj16;
			if (obj17 != null)
			{
				goto IL_0120;
			}
			goto IL_022d;
			IL_0120:
			return true;
			IL_022d:
			object obj18 = obj14 & 0xFFFFFFFDL;
			object obj19 = obj18 - 4;
			return obj19 == null;
			IL_00c2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v16+B8]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v18+18]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v18+18]");
			object obj21 = -1;
			bool flag4 = (nint)obj21 < 2;
			object obj22 = !flag4;
			if (obj22 == null)
			{
				goto IL_0120;
			}
			goto IL_022d;
			IL_008d:
			obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v16+E4]");
			bool flag5 = (nint)0 == 0;
			obj11 = obj9;
			if (!flag5)
			{
				goto IL_00c2;
			}
			goto IL_01b4;
		}
	}

	public static event Predicate<RoutingParams> OnValidateRouting
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0101: Expected O, but got I4
			//IL_008c: Expected O, but got I
			//IL_009c: Expected O, but got I
			//IL_00be: Expected O, but got I4
			//IL_0139: Expected O, but got I
			//IL_0149: Expected O, but got I
			//IL_01a2: Expected O, but got I4
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected O, but got Unknown
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Expected O, but got Unknown
			object obj = typeof(RegisteredWaitHandle) + 1552;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CD8]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v18+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = obj3;
				if (!flag)
				{
					goto IL_007c;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v18+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = obj3;
				if (obj5 != null)
				{
					goto IL_007c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v9+B8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v11+8]");
			List<object> list = (List<object>)0;
			goto IL_014e;
			IL_014e:
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag3 = list._size < items.Length;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				int size = list._size + 1;
				list._size = size;
				object obj9 = items + list._size;
				object obj10 = obj9 + 32;
				obj10 = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				list.AddWithResize((object)value);
			}
			return;
			IL_007c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v18+B8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v15+8]");
			list = (List<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v15+8]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_014e;
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e4: Expected O, but got I4
			//IL_008c: Expected O, but got I
			//IL_009c: Expected O, but got I
			//IL_011c: Expected O, but got I
			//IL_012c: Expected O, but got I
			//IL_014e: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1552;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CD9]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v16+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = obj3;
				if (!flag)
				{
					goto IL_007c;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v16+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = obj3;
				if (obj5 != null)
				{
					goto IL_007c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v5+B8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+8]");
			List<object> list = (List<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+8]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00a1;
			IL_007c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v16+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v11+8]");
			list = (List<object>)0;
			goto IL_00a1;
			IL_00a1:
			bool flag4 = list.Remove(value);
		}
	}

	protected override void OnAwake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00dc: Expected I, but got O
		//IL_0106: Expected O, but got I4
		object obj = typeof(TypeConverter<ushort, char>) + 528;
		object obj2 = (nint)0 + (nint)3136;
		object obj3 = typeof(RegisteredWaitHandle) + 2944;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
		unityAction..ctor((object)this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
		GameObject target = base.gameObject;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			UnityEngine.Object.DontDestroyOnLoad(target);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.DontDestroyOnLoad(target);
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
		object obj = typeof(TypeConverter<ushort, char>) + 528;
		object obj2 = (nint)0 + (nint)3136;
		object obj3 = typeof(RegisteredWaitHandle) + 2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
		unityAction..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
	}

	private void SceneManagerOnsceneLoaded(Scene unityScene, LoadSceneMode _)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f6: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		//IL_016b: Expected O, but got I
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_019d: Expected O, but got I4
		//IL_012e: Expected O, but got I
		//IL_01d5: Expected O, but got I4
		//IL_03da: Expected O, but got I
		//IL_0206: Expected O, but got I
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_0345: Expected O, but got I
		//IL_035f: Expected O, but got I4
		//IL_02bf: Expected O, but got I
		//IL_025d: Expected O, but got I4
		//IL_026e: Expected O, but got I4
		//IL_039d: Expected O, but got I4
		//IL_031a: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(RegisteredWaitHandle) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DEE]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v46+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			int num = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v46+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v39+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		if (obj8 == null)
		{
			return;
		}
		goto IL_0153;
		IL_03b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj10 = obj2;
		goto IL_0311;
		IL_0311:
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_02dc:
		obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v21+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = obj10;
		if (!flag3)
		{
			goto IL_0311;
		}
		goto IL_03b3;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v46+B8]");
		object obj13 = 0;
		obj9 = obj13;
		bool flag4 = obj13 == null;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			return;
		}
		goto IL_0153;
		IL_0153:
		object obj15 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v3+1B0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ X8_v3+1A8] (should have been resolved before IL gen)");
		object obj18 = default(object);
		object obj17 = obj18 & 1;
		bool flag5 = obj17 == null;
		object obj19 = !flag5;
		if (obj19 != null)
		{
			return;
		}
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v4+E4]");
		bool flag6 = (nint)0 == 0;
		object obj21 = !flag6;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v4+B8]");
		object obj22 = 0;
		object obj23 = obj22;
		object obj24 = (nint)0 + (nint)1552;
		string text = (string)obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D70F1C");
		object obj26 = default(object);
		object obj25 = obj26 & 1;
		if (obj25 != null)
		{
			Scene scene = default(Scene);
			string text2 = scene.name;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v6+20]");
			string text3 = ScenesEnumExtensions.GetName((Scenes)0);
			bool flag7 = text2.Equals(text3);
			bool flag8 = !flag7;
			object obj27 = !flag8;
			text = text3;
			obj16 = 0;
			if (obj27 != null)
			{
				return;
			}
		}
		object obj28 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v11+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DEF]");
			object obj29 = (nint)0 & (nint)1;
			if (obj29 != null)
			{
				goto IL_02dc;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DEF]");
			object obj30 = (nint)0 & (nint)1;
			bool flag9 = obj30 == null;
			object obj31 = !flag9;
			if (obj31 != null)
			{
				goto IL_02dc;
			}
		}
		int num2 = 1;
		obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v21+E4]");
		bool flag10 = (nint)0 == 0;
		object obj32 = !flag10;
		obj12 = obj10;
		if (obj32 != null)
		{
			goto IL_0311;
		}
		goto IL_03b3;
	}

	private static void ResetParams()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00c9: Expected O, but got I4
		//IL_008e: Expected O, but got I4
		//IL_00fa: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(RegisteredWaitHandle) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DEF]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj2;
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0085:
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public static void Route(RoutingCommand command, string payload = null, Games? game = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_010b: Expected O, but got I4
		//IL_00ba: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 1560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(RegisteredWaitHandle) + 1552;
		object obj4 = obj2 + 40;
		obj4 = payload;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = (??)game & 1;
		if (obj5 != null)
		{
			object obj6 = (object?)game >> 32;
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 != null)
			{
				goto IL_0163;
			}
		}
		else
		{
			object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Games currentGame = Preferences.CurrentGame;
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0163;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Route((RoutingParams)obj2);
		return;
		IL_0163:
		Route((RoutingParams)obj2);
	}

	public static void Route(RoutingParams routingParams)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_0113: Expected O, but got I4
		//IL_01f7: Expected O, but got I
		//IL_020d: Expected O, but got I4
		//IL_021d: Expected O, but got I
		//IL_016f: Expected O, but got I
		//IL_018a: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CDD]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v16+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = NavigateImmediate(routingParams);
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			return;
		}
		goto IL_0121;
		IL_01a0:
		object obj6;
		if (obj6 != null)
		{
			NavigateWhenReady(routingParams);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		NavigateWhenReady(routingParams);
		return;
		IL_0121:
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+E4]");
		object obj9;
		if ((nint)0 != 0)
		{
			bool isTooEarlyToRoute = IsTooEarlyToRoute;
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v10+E4]");
			obj6 = 0;
			bool flag4 = !isTooEarlyToRoute;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v10+E4]");
			obj9 = 0;
			object obj10 = obj8;
			if (!flag4)
			{
				goto IL_01a0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool isTooEarlyToRoute2 = IsTooEarlyToRoute;
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v10+E4]");
			obj6 = 0;
			bool flag5 = !isTooEarlyToRoute2;
			object obj11 = !flag5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v10+E4]");
			obj9 = 0;
			object obj10 = obj8;
			if (obj11 != null)
			{
				goto IL_01a0;
			}
		}
		if (obj9 != null)
		{
			ValidateAndNavigate(routingParams);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ValidateAndNavigate(routingParams);
		return;
		IL_0074:
		if (NavigateImmediate(routingParams))
		{
			return;
		}
		goto IL_0121;
	}

	private static void SaveParams(RoutingParams routingParams)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_00ba: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1512;
		object obj2 = typeof(RegisteredWaitHandle) + 1552;
		Scenes scene = RoutingCommandExtensions.GetScene(routingParams.Command);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = routingParams.Command;
		object obj4 = default(object);
		object obj3 = obj4 + 24;
		obj3 = routingParams.Payload;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
		}
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private static bool NavigateImmediate(RoutingParams routingParams)
	{
		//IL_0525: Expected I4, but got O
		//IL_00fd: Expected O, but got I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_03de: Expected O, but got I
		//IL_03ee: Expected O, but got I
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_0427: Expected O, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_015b: Expected O, but got I4
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_020c: Expected O, but got I4
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_02a1: Expected O, but got I
		//IL_02b1: Expected O, but got I
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0399: Expected O, but got I4
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_045f: Expected O, but got I4
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected O, but got Unknown
		//IL_0592: Expected O, but got I
		//IL_05a3: Expected I, but got O
		//IL_05c1: Expected O, but got I
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected O, but got Unknown
		//IL_04d2: Expected O, but got I4
		//IL_048f: Expected O, but got I
		Action action;
		string text;
		string text2;
		Action action3;
		string message;
		Action callback;
		object obj15;
		if (routingParams != null)
		{
			if (routingParams.Command > RoutingCommand.Login_Error)
			{
				if (routingParams.Command == RoutingCommand.OpenUpdateAppLink)
				{
					KammelnaURL.OpenUpdatePage();
					return true;
				}
				object obj = routingParams.Command & (RoutingCommand)2147483644;
				if ((nint)obj == 11000)
				{
					goto IL_011d;
				}
				goto IL_024a;
			}
			if (routingParams.Command > RoutingCommand.Internal_Error)
			{
				if (routingParams.Command == RoutingCommand.RoomInitializationError)
				{
					object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2200;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v20+E4]");
					object obj4;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v20+B8]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v19+8]");
						action = (Action)0;
						object obj5 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3112;
						text = (string)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v19+8]");
						bool flag = (nint)0 == 0;
						text2 = (string)obj5;
						if (!flag)
						{
							goto IL_02f5;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v20+B8]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v19+8]");
						action = (Action)0;
						object obj6 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3112;
						text = (string)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v19+8]");
						bool flag2 = (nint)0 == 0;
						object obj7 = !flag2;
						text2 = (string)obj6;
						if (obj7 != null)
						{
							goto IL_02f5;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v20+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj9 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v28+B8]");
						obj4 = 0;
					}
					object obj10 = typeof(SqlSingle[]) + 2376;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj11 = (nint)0 + (nint)976;
					Action action2 = default(Action);
					action2..ctor(obj4, (IntPtr)obj11);
					object obj12 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v24+B8]");
					object obj13 = (nint)0 + (nint)8;
					obj13 = action2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj14 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
					obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v18+E4]");
					bool flag4 = (nint)0 == 0;
					object obj16 = !flag4;
					action = action2;
					text = text2;
					action3 = action2;
					if (obj16 != null)
					{
						goto IL_0346;
					}
					goto IL_04f8;
				}
				if (routingParams.Command != RoutingCommand.OpenCustomURL)
				{
					if (routingParams.Command == RoutingCommand.Login_Error)
					{
						goto IL_011d;
					}
					goto IL_024a;
				}
				object obj17 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v39+E4]");
				bool flag5 = (nint)0 == 0;
				object obj19 = !flag5;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				KUtil.OpenURL(routingParams.Payload);
			}
			else if (routingParams.Command != RoutingCommand.NO_MESSAGE)
			{
				if (routingParams.Command != RoutingCommand.Internal_Error)
				{
					goto IL_024a;
				}
				object obj20 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v13+E4]");
				bool flag6 = (nint)0 == 0;
				object obj22 = !flag6;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj23 = "Index = {0} position = {1}" + 1736;
				message = (string)obj23;
				callback = null;
				goto IL_0542;
			}
			return true;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_011d:
		object obj24 = typeof(RegisteredWaitHandle) + 1552;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v4+E4]");
		bool flag7 = (nint)0 == 0;
		object obj26 = !flag7;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		LoadScene(routingParams);
		return true;
		IL_0542:
		PopupWindow.ShowError(message, callback);
		return true;
		IL_04f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		action = action3;
		text = text2;
		goto IL_0346;
		IL_0346:
		callback = action;
		message = text;
		goto IL_0542;
		IL_02f5:
		object obj27 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		obj15 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v18+E4]");
		bool flag8 = (nint)0 == 0;
		action3 = action;
		text2 = text;
		if (!flag8)
		{
			goto IL_0346;
		}
		goto IL_04f8;
		IL_024a:
		return false;
	}

	private static void ValidateAndNavigate(RoutingParams routingParams)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0097: Expected O, but got I4
		//IL_0318: Expected O, but got I
		//IL_0333: Expected I, but got O
		//IL_00c8: Expected O, but got I
		//IL_00dd: Expected O, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_01ef: Expected O, but got I
		//IL_021a: Expected O, but got I4
		//IL_0223: Expected O, but got I4
		//IL_022c: Expected O, but got I4
		//IL_0159: Expected O, but got I
		//IL_017d: Expected O, but got I4
		//IL_0186: Expected O, but got I4
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_026c: Expected O, but got I
		//IL_027d: Expected I, but got O
		//IL_02ac: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(RegisteredWaitHandle) + 1552;
		object obj4 = typeof(List<Tween>) + 3032;
		object obj5 = (nint)0 + (nint)984;
		object obj6 = obj2 + 16;
		obj6 = routingParams;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v9+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj2, (IntPtr)obj5);
		object obj10 = (nint)0 + (nint)3256;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v5+8]");
		if (!((List<object>)0).TrueForAll(predicate))
		{
			return;
		}
		object obj11 = obj6;
		object obj12 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v11+E4]");
		RoutingParams routingParams2;
		RoutingParams routingParams3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v8+10]");
			bool flag2 = StringsExtensions.IsNullOrEmpty((string)0);
			routingParams2 = (RoutingParams)obj6;
			bool flag3 = !flag2;
			object obj14 = 0;
			object obj15 = 0;
			routingParams3 = (RoutingParams)obj6;
			if (!flag3)
			{
				goto IL_019c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v8+10]");
			bool flag4 = StringsExtensions.IsNullOrEmpty((string)0);
			routingParams2 = (RoutingParams)obj6;
			bool flag5 = !flag4;
			object obj16 = !flag5;
			object obj14 = 0;
			object obj15 = 0;
			routingParams3 = (RoutingParams)obj6;
			if (obj16 != null)
			{
				goto IL_019c;
			}
		}
		object obj17 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)992;
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj18);
		object obj19 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v18+E4]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ShowConfirm(routingParams3, action);
		return;
		IL_019c:
		object obj21 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v27+E4]");
		if ((nint)0 != 0)
		{
			Navigate(routingParams2);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Navigate(routingParams2);
	}

	private static void Navigate(RoutingParams routingParams)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I
		//IL_00e5: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj4 = obj2 + 16;
		obj4 = routingParams;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string serverID = Config.ServerID;
		object obj7 = obj4;
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)1000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v5+30]");
		SfsConnectionManager.SwitchGame(serverID, Games.Baloot, action);
	}

	private static void LoadScene(RoutingParams routingParams)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0134: Expected O, but got I4
		//IL_0186: Expected I, but got O
		//IL_01b0: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(RegisteredWaitHandle) + 1552;
		object obj4 = obj2 + 16;
		obj4 = routingParams;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SaveParams((RoutingParams)obj4);
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v5+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		object obj10 = typeof(RegisteredWaitHandle) + 3136;
		object obj11 = typeof(TypeConverter<ushort, char>) + 528;
		object obj12 = (nint)0 + (nint)1024;
		object obj13 = typeof(RegisteredWaitHandle) + 2944;
		object obj14 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v7+20]");
		AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.LoadScene((Scenes)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
		unityAction..ctor(obj2, (IntPtr)obj12);
		object obj16 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v17+E4]");
		bool flag3 = (nint)0 == 0;
		object obj17 = !flag3;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
	}

	public static void TriggerRoute(RoutingCommand command, string payload)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_014c: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(Queue<string>) + 816;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CE3]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2136;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
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
			object obj4 = (nint)0 + (nint)2136;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
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
		IL_0133:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+20]");
		((RoutingEventsChannel)0).TriggerRoute(command, payload);
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = default(object);
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	private static void NavigateWhenReady(RoutingParams routingParams)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_008d: Expected I, but got O
		//IL_00b7: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(TypeConverter<ushort, char>) + 528;
		object obj4 = (nint)0 + (nint)1032;
		object obj5 = typeof(RegisteredWaitHandle) + 2944;
		object obj6 = obj2 + 16;
		obj6 = routingParams;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
		unityAction..ctor(obj2, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
	}

	private static void ShowConfirm(RoutingParams routingParams, Action confirmAction)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_03ce: Expected O, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_007e: Expected I, but got O
		//IL_008e: Expected O, but got I
		//IL_0436: Expected I, but got O
		//IL_00c9: Expected O, but got I
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0183: Expected O, but got I
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0219: Expected I, but got O
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_01be: Expected O, but got I
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_025c: Expected I, but got O
		//IL_026c: Expected O, but got I
		//IL_030a: Expected O, but got I
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_0345: Expected I, but got O
		//IL_0369: Expected O, but got I4
		//IL_02a7: Expected O, but got I
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CE5]");
		nint num = 0;
		object confirmText = "SetRoomVariables request error" + 560;
		object cancelText = "AvailableVoices" + 768;
		object obj4 = default(object);
		object obj7 = default(object);
		object obj9 = default(object);
		object obj12 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		object obj17 = default(object);
		object obj20 = default(object);
		while (true)
		{
			IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.CreateConfirm(confirmAction, (string)confirmText, (string)cancelText);
			if (routingParams != null)
			{
				LocalizableText localizableText = TextMeshProExtensions.FixOnly(routingParams.MessageTitle);
				if (popupWindowBuilderNeedsTitle != null)
				{
					object obj = typeof(System.IOAsyncCallback) + 392;
					nint num2 = (nint)popupWindowBuilderNeedsTitle;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0112;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
					object obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X10_v18-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj4 = obj3 + 16;
						obj2--;
						bool flag = (nint)obj2 != 1;
						obj3 = obj4;
						if (flag)
						{
							continue;
						}
						goto IL_0112;
					}
					object obj5 = obj3 + 1;
					object obj6 = num2 + obj5;
					obj7 = obj6 + 312;
					obj4 = obj3;
					goto IL_042e;
				}
			}
			goto IL_037f;
			IL_02e8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v15+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v225 @ X2_v9 (should have been resolved before IL gen)");
			goto IL_0314;
			IL_0314:
			object obj11 = obj12 + 1;
			object obj14;
			object obj13 = obj14 + obj11;
			object obj15 = obj13 + 312;
			num = (nint)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v366 @ X0_v21] (should have been resolved before IL gen)");
			bool flag2 = ex == null;
			object obj16 = !flag2;
			obj4 = obj12;
			if (obj16 != null)
			{
				goto IL_0240;
			}
			goto IL_037f;
			IL_0207:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = (nint)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v350 @ X0_v18] (should have been resolved before IL gen)");
			if (ex != null)
			{
				goto IL_0240;
			}
			goto IL_037f;
			IL_0240:
			object obj18 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X10_v10-8]");
					if (0 == (nint)obj18)
					{
						break;
					}
					obj4 += 16;
					obj19--;
					if ((nint)obj19 != 1)
					{
						continue;
					}
					goto IL_02e8;
				}
				goto IL_038d;
			}
			goto IL_02e8;
			IL_037f:
			ex = new NullReferenceException();
			goto IL_038d;
			IL_0112:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_042e;
			IL_042e:
			num = (nint)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v323 @ X0_v9] (should have been resolved before IL gen)");
			LocalizableText localizableText2 = TextMeshProExtensions.FixOnly(routingParams.MessageBody);
			if (obj20 != null)
			{
				object obj21 = typeof(System.IOAsyncCallback) + 384;
				obj14 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v14+12E]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v14+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0207;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v14+B0]");
				obj12 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X10_v13-8]");
					if (0 == (nint)obj21)
					{
						break;
					}
					obj4 = obj12 + 16;
					obj22--;
					bool flag3 = (nint)obj22 != 1;
					obj12 = obj4;
					if (flag3)
					{
						continue;
					}
					goto IL_0207;
				}
				goto IL_0314;
			}
			goto IL_037f;
			IL_038d:
			object obj23 = obj4 + 9;
			object obj24 = num + obj23;
			object obj25 = obj24 + 312;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v5+8]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v200 @ X2_v3 (should have been resolved before IL gen)");
		}
	}

	public RoutingManager()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(Queue<string>) + 816;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CE6]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2128;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
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
			object obj4 = (nint)0 + (nint)2128;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}

	static RoutingManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3816;
		object obj2 = typeof(RegisteredWaitHandle) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3+B8]");
		object obj4 = (nint)0 + (nint)8;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
