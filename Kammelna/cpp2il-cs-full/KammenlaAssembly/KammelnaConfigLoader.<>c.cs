using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class KammelnaConfigLoader : ScriptableObject
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ServerConfiguration, SFSConfig> <>9__16_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal SFSConfig <LoadServersConfig>b__16_1(ServerConfiguration server)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RegisteredWaitHandle) + 1960;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			SFSConfig sFSConfig = default(SFSConfig);
			sFSConfig..ctor(server);
			return sFSConfig;
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public KammelnaConfigLoader <>4__this;

		public Action<bool> callback;

		internal void <LoadServersConfig>b__0(KammelnaResponseModel<ConfigsModel> response)
		{
			//IL_1479: Expected O, but got I
			//IL_1493: Expected O, but got I4
			//IL_0011: Expected O, but got I
			//IL_1559: Expected O, but got I4
			//IL_0485: Expected O, but got I
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected O, but got Unknown
			//IL_0573: Expected O, but got I
			//IL_01b5: Expected O, but got I4
			//IL_0619: Expected O, but got I4
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a5: Expected O, but got Unknown
			//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ba: Expected O, but got Unknown
			//IL_070e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0713: Expected O, but got Unknown
			//IL_02f8: Expected O, but got I
			//IL_096e: Expected O, but got I
			//IL_097e: Expected O, but got I
			//IL_09a0: Expected O, but got I4
			//IL_09b0: Expected O, but got I
			//IL_16a6: Expected O, but got I
			//IL_16c0: Expected O, but got I4
			//IL_16c9: Expected O, but got I4
			//IL_16d2: Expected O, but got I4
			//IL_184e: Expected O, but got I
			//IL_1856: Expected I, but got O
			//IL_1878: Expected O, but got I
			//IL_1894: Unknown result type (might be due to invalid IL or missing references)
			//IL_1899: Expected O, but got Unknown
			//IL_08f7: Expected O, but got I
			//IL_0907: Expected O, but got I
			//IL_0929: Expected O, but got I4
			//IL_0756: Expected O, but got I
			//IL_076e: Expected O, but got I4
			//IL_0777: Expected O, but got I4
			//IL_0bb8: Expected O, but got I
			//IL_0bd2: Expected O, but got I4
			//IL_0bdb: Expected O, but got I4
			//IL_0be4: Expected O, but got I4
			//IL_09ce: Expected O, but got I
			//IL_09f0: Expected O, but got I4
			//IL_1710: Expected O, but got I4
			//IL_0a51: Expected O, but got I
			//IL_0a69: Expected O, but got I4
			//IL_0a72: Expected O, but got I4
			//IL_18d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_18da: Expected O, but got Unknown
			//IL_18f0: Expected O, but got I
			//IL_1901: Expected I, but got O
			//IL_191f: Expected O, but got I
			//IL_0947: Expected O, but got I
			//IL_07d8: Expected O, but got I
			//IL_0c68: Expected O, but got I
			//IL_0c22: Expected O, but got I4
			//IL_0a2e: Expected O, but got I4
			//IL_0a20: Expected O, but got I
			//IL_0ad3: Expected O, but got I
			//IL_0b0b: Expected O, but got I4
			//IL_0de0: Expected O, but got I4
			//IL_0df3: Expected O, but got I4
			//IL_0e24: Expected O, but got I4
			//IL_0e31: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e36: Expected O, but got Unknown
			//IL_176d: Expected O, but got I
			//IL_1787: Expected O, but got I4
			//IL_1790: Expected O, but got I4
			//IL_1799: Expected O, but got I4
			//IL_111a: Expected O, but got I
			//IL_1134: Expected O, but got I4
			//IL_113d: Expected O, but got I4
			//IL_1146: Expected O, but got I4
			//IL_0eba: Expected O, but got I
			//IL_0ed2: Expected O, but got I4
			//IL_0edb: Expected O, but got I4
			//IL_1007: Expected O, but got I
			//IL_101f: Expected O, but got I4
			//IL_1028: Expected O, but got I4
			//IL_17d7: Expected O, but got I4
			//IL_11ca: Expected O, but got I
			//IL_1184: Expected O, but got I4
			//IL_0f36: Expected O, but got I
			//IL_0f4b: Expected O, but got I
			//IL_0f5b: Expected O, but got I
			//IL_1089: Expected O, but got I
			//IL_10c7: Expected O, but got I4
			//IL_124e: Expected O, but got I4
			//IL_1264: Expected O, but got I
			//IL_1393: Expected O, but got I4
			//IL_12cc: Expected O, but got I
			//IL_1318: Expected O, but got I4
			//IL_13d1: Expected O, but got I
			//IL_1414: Expected O, but got I4
			//IL_142d: Expected O, but got I4
			//IL_1960: Expected O, but got I4
			//IL_1984: Expected O, but got I
			bool flag = response == null;
			KammelnaResponseModel<ConfigsModel> kammelnaResponseModel = response;
			bool flag2 = false;
			bool succeeded;
			bool flag4;
			string text;
			object obj2;
			bool flag8;
			bool flag9 = default(bool);
			bool flag10;
			bool flag11 = default(bool);
			object obj4;
			object obj5 = default(object);
			object obj6;
			object obj7 = default(object);
			object obj8;
			object obj9 = default(object);
			bool flag12;
			bool flag13 = default(bool);
			bool flag14;
			bool flag15 = default(bool);
			object obj10;
			object obj11 = default(object);
			object obj12;
			object obj13 = default(object);
			object obj14;
			object obj15 = default(object);
			IntPtr intPtr;
			nint num = default(nint);
			object obj16;
			object obj17 = default(object);
			object obj18;
			object obj19 = default(object);
			KammelnaResponseModel<ConfigsModel> kammelnaResponseModel2;
			if (!flag)
			{
				object obj = (nint)0 + (nint)1208;
				kammelnaResponseModel = (KammelnaResponseModel<ConfigsModel>)obj;
				succeeded = ((KammelnaResponseModel<object>)(object)response).Succeeded;
				bool flag3 = !succeeded;
				flag4 = succeeded;
				if (flag3)
				{
					goto IL_1352;
				}
				ConfigsModel <Model>k__BackingField = response.<Model>k__BackingField;
				bool flag5 = response.<Model>k__BackingField == null;
				flag2 = succeeded;
				if (!flag5)
				{
					text = <Model>k__BackingField.<BlobHost>k__BackingField;
					obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v146+E4]");
					if ((nint)0 != 0)
					{
						bool flag6 = StringsExtensions.IsNullOrEmpty(<Model>k__BackingField.<BlobHost>k__BackingField);
						bool flag7 = !flag6;
						kammelnaResponseModel = null;
						if (flag7)
						{
							goto IL_023d;
						}
						flag8 = flag9;
						flag10 = flag11;
						obj4 = obj5;
						obj6 = obj7;
						obj8 = obj9;
						flag12 = flag13;
						flag14 = flag15;
						obj10 = obj11;
						obj12 = obj13;
						obj14 = obj15;
						intPtr = num;
						obj16 = obj17;
						obj18 = obj19;
						kammelnaResponseModel2 = null;
						flag4 = succeeded;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						bool flag16 = StringsExtensions.IsNullOrEmpty(<Model>k__BackingField.<BlobHost>k__BackingField);
						bool flag17 = !flag16;
						object obj20 = !flag17;
						kammelnaResponseModel = null;
						flag8 = flag9;
						flag10 = flag11;
						obj4 = obj5;
						obj6 = obj7;
						obj8 = obj9;
						flag12 = flag13;
						flag14 = flag15;
						obj10 = obj11;
						obj12 = obj13;
						obj14 = obj15;
						intPtr = num;
						obj16 = obj17;
						obj18 = obj19;
						kammelnaResponseModel2 = null;
						flag4 = succeeded;
						if (obj20 == null)
						{
							goto IL_023d;
						}
					}
					goto IL_04a4;
				}
			}
			goto IL_144b;
			IL_1842:
			object obj21 = (nint)0 + (nint)4000;
			num = (nint)obj21;
			ConfigsModel <Model>k__BackingField2;
			Func<object, object> selector;
			IEnumerable<object> source = Enumerable.Select(<Model>k__BackingField2.<Servers>k__BackingField, selector);
			object obj22 = (nint)0 + (nint)2656;
			List<object> list = Enumerable.ToList(source);
			object obj23 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v24+E4]");
			object obj26;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45CD]");
				object obj25 = (nint)0 & (nint)1;
				bool flag18 = obj25 == null;
				obj26 = 146685952;
				obj19 = 146685952;
				if (!flag18)
				{
					goto IL_0a80;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45CD]");
				object obj27 = (nint)0 & (nint)1;
				bool flag19 = obj27 == null;
				object obj28 = !flag19;
				obj26 = 146685952;
				obj19 = 146685952;
				if (obj28 != null)
				{
					goto IL_0a80;
				}
			}
			_ = 1;
			object obj29 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v100+E4]");
			bool flag20 = (nint)0 == 0;
			object obj30 = !flag20;
			obj26 = obj19;
			object obj31 = obj29;
			if (obj30 != null)
			{
				goto IL_0abd;
			}
			goto IL_0c40;
			IL_1238:
			ConfigsModel <Model>k__BackingField3;
			KammelnaResponseModel<ConfigsModel> kammelnaResponseModel3 = (KammelnaResponseModel<ConfigsModel>)(object)<Model>k__BackingField3.<ForcedVersion>k__BackingField;
			object obj32 = 146685952;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45CE]");
			object obj33 = (nint)0 & (nint)1;
			if (obj33 != null)
			{
				object obj34 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X0_v51+E4]");
				bool flag21 = (nint)0 == 0;
				object obj35 = obj34;
				if (!flag21)
				{
					goto IL_12b6;
				}
			}
			else
			{
				_ = 1;
				object obj34 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X0_v51+E4]");
				bool flag22 = (nint)0 == 0;
				object obj36 = !flag22;
				object obj35 = obj34;
				if (obj36 != null)
				{
					goto IL_12b6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj37 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X0_v31+B8]");
			object obj38 = (nint)0 + (nint)24;
			obj38 = kammelnaResponseModel3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			ConfigsModel <Model>k__BackingField4 = response.<Model>k__BackingField;
			bool flag23 = response.<Model>k__BackingField == null;
			object obj39 = !flag23;
			KammelnaResponseModel<ConfigsModel> kammelnaResponseModel4 = kammelnaResponseModel3;
			obj15 = obj14;
			obj19 = 146685952;
			kammelnaResponseModel = kammelnaResponseModel3;
			flag2 = flag4;
			if (obj39 != null)
			{
				goto IL_1936;
			}
			goto IL_144b;
			IL_1073:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X0_v68+B8]");
			object obj40 = (nint)0 + (nint)16;
			obj40 = kammelnaResponseModel3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<Model>k__BackingField3 = response.<Model>k__BackingField;
			bool flag24 = response.<Model>k__BackingField == null;
			object obj41 = !flag24;
			KammelnaResponseModel<ConfigsModel> kammelnaResponseModel5 = kammelnaResponseModel3;
			if (obj41 != null)
			{
				goto IL_1238;
			}
			obj15 = obj14;
			kammelnaResponseModel = kammelnaResponseModel3;
			flag2 = flag4;
			goto IL_144b;
			IL_0a80:
			obj29 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v100+E4]");
			bool flag25 = (nint)0 == 0;
			obj19 = obj26;
			obj31 = obj29;
			if (!flag25)
			{
				goto IL_0abd;
			}
			goto IL_0c40;
			IL_11a2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj42 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X0_v58+B8]");
			object obj43 = (nint)0 + (nint)16;
			obj43 = kammelnaResponseModel3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<Model>k__BackingField3 = response.<Model>k__BackingField;
			bool flag26 = response.<Model>k__BackingField == null;
			kammelnaResponseModel5 = kammelnaResponseModel3;
			obj15 = obj14;
			object obj44;
			obj19 = obj44;
			kammelnaResponseModel = kammelnaResponseModel3;
			flag2 = flag4;
			if (!flag26)
			{
				goto IL_1238;
			}
			goto IL_144b;
			IL_023d:
			ConfigsModel <Model>k__BackingField5 = response.<Model>k__BackingField;
			bool flag27 = response.<Model>k__BackingField == null;
			obj23 = obj2;
			kammelnaResponseModel3 = (KammelnaResponseModel<ConfigsModel>)(object)text;
			flag2 = succeeded;
			if (flag27)
			{
				goto IL_144b;
			}
			kammelnaResponseModel3 = (KammelnaResponseModel<ConfigsModel>)(object)<Model>k__BackingField5.<BlobHost>k__BackingField;
			obj19 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			NullReferenceException ex = (NullReferenceException)obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v10 (System.NullReferenceException)+E4]");
			bool flag28 = (nint)0 == 0;
			obj23 = obj2;
			flag2 = succeeded;
			if (flag28)
			{
				goto IL_1459;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45CB]");
			object obj45 = (nint)0 & (nint)1;
			bool flag29 = obj45 == null;
			obj23 = obj2;
			flag2 = succeeded;
			flag8 = flag9;
			flag10 = flag11;
			obj4 = obj5;
			obj6 = obj7;
			obj8 = obj9;
			flag12 = flag13;
			flag14 = flag15;
			obj10 = obj11;
			obj12 = obj13;
			obj14 = obj15;
			intPtr = num;
			obj16 = obj17;
			obj18 = obj19;
			KammelnaResponseModel<ConfigsModel> kammelnaResponseModel6 = (KammelnaResponseModel<ConfigsModel>)(object)<Model>k__BackingField5.<BlobHost>k__BackingField;
			KammelnaResponseModel<ConfigsModel> kammelnaResponseModel7 = kammelnaResponseModel;
			flag4 = succeeded;
			if (!flag29)
			{
				goto IL_03aa;
			}
			goto IL_1529;
			IL_0abd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v100+B8]");
			object obj46 = (nint)0 + (nint)8;
			obj46 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			kammelnaResponseModel3 = (KammelnaResponseModel<ConfigsModel>)(object)<>4__this;
			bool flag30 = (object)<>4__this == null;
			object obj47 = !flag30;
			KammelnaConfigLoader kammelnaConfigLoader = <>4__this;
			KammelnaResponseModel<ConfigsModel> kammelnaResponseModel8 = (KammelnaResponseModel<ConfigsModel>)(object)list;
			if (obj47 != null)
			{
				goto IL_0d22;
			}
			flag9 = flag8;
			flag11 = flag10;
			obj5 = obj4;
			obj7 = obj6;
			obj9 = obj8;
			flag13 = flag12;
			flag15 = flag14;
			obj11 = obj10;
			obj13 = obj12;
			obj15 = obj14;
			obj19 = obj26;
			kammelnaResponseModel = (KammelnaResponseModel<ConfigsModel>)(object)list;
			flag2 = flag4;
			goto IL_144b;
			IL_0d22:
			KammelnaEnvironmentProvider environmentProvider = kammelnaConfigLoader.environmentProvider;
			bool flag31 = (object)kammelnaConfigLoader.environmentProvider == null;
			flag9 = flag8;
			flag11 = flag10;
			obj5 = obj4;
			obj7 = obj6;
			obj9 = obj8;
			flag13 = flag12;
			flag15 = flag14;
			obj11 = obj10;
			obj13 = obj12;
			obj15 = obj14;
			obj19 = obj26;
			kammelnaResponseModel3 = (KammelnaResponseModel<ConfigsModel>)(object)kammelnaConfigLoader;
			kammelnaResponseModel = kammelnaResponseModel8;
			flag2 = flag4;
			if (flag31)
			{
				goto IL_144b;
			}
			bool flag32 = environmentProvider.environment < ServerEnvironment.Development;
			obj13 = !flag32;
			obj11 = environmentProvider.environment - 2;
			flag15 = (nint)obj11 < 0;
			flag13 = obj11 == null;
			obj9 = environmentProvider.environment ^ ServerEnvironment.Development;
			obj7 = environmentProvider.environment ^ obj11;
			obj5 = obj9 & obj7;
			flag11 = (nint)obj5 < 0;
			flag9 = environmentProvider.environment != ServerEnvironment.Development;
			if (flag9)
			{
				goto IL_0f60;
			}
			object obj48 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X0_v74+E4]");
			object obj50;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
				object obj49 = (nint)0 & (nint)1;
				bool flag33 = obj49 == null;
				obj26 = 146685952;
				obj50 = 146685952;
				if (!flag33)
				{
					goto IL_0ee9;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
				object obj51 = (nint)0 & (nint)1;
				bool flag34 = obj51 == null;
				object obj52 = !flag34;
				obj26 = 146685952;
				obj50 = 146685952;
				if (obj52 != null)
				{
					goto IL_0ee9;
				}
			}
			_ = 1;
			object obj53 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v84+E4]");
			bool flag35 = (nint)0 == 0;
			object obj54 = !flag35;
			obj26 = obj50;
			object obj55 = obj53;
			if (obj54 != null)
			{
				goto IL_0f26;
			}
			goto IL_17f5;
			IL_0c40:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj56 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X0_v90+B8]");
			object obj57 = (nint)0 + (nint)8;
			obj57 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			kammelnaResponseModel3 = (KammelnaResponseModel<ConfigsModel>)(object)<>4__this;
			bool flag36 = (object)<>4__this == null;
			obj26 = obj19;
			kammelnaConfigLoader = <>4__this;
			kammelnaResponseModel8 = (KammelnaResponseModel<ConfigsModel>)(object)list;
			flag9 = flag8;
			flag11 = flag10;
			obj5 = obj4;
			obj7 = obj6;
			obj9 = obj8;
			flag13 = flag12;
			flag15 = flag14;
			obj11 = obj10;
			obj13 = obj12;
			obj15 = obj14;
			kammelnaResponseModel = (KammelnaResponseModel<ConfigsModel>)(object)list;
			flag2 = flag4;
			if (!flag36)
			{
				goto IL_0d22;
			}
			goto IL_144b;
			IL_04a4:
			ConfigsModel <Model>k__BackingField6 = response.<Model>k__BackingField;
			bool flag37 = response.<Model>k__BackingField == null;
			flag9 = flag8;
			flag11 = flag10;
			obj5 = obj4;
			obj7 = obj6;
			obj9 = obj8;
			flag13 = flag12;
			flag15 = flag14;
			obj11 = obj10;
			obj13 = obj12;
			obj15 = obj14;
			num = intPtr;
			obj17 = obj16;
			obj19 = obj18;
			obj23 = obj2;
			kammelnaResponseModel3 = (KammelnaResponseModel<ConfigsModel>)(object)text;
			kammelnaResponseModel = kammelnaResponseModel2;
			flag2 = flag4;
			string text2;
			KammelnaResponseModel<ConfigsModel> kammelnaResponseModel9;
			if (!flag37)
			{
				object obj58 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v15+E4]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v15+E4]");
				if ((nint)0 != 0)
				{
					bool flag38 = StringsExtensions.IsNullOrEmpty(<Model>k__BackingField6.<SignalRServerUrl>k__BackingField);
					bool flag39 = !flag38;
					kammelnaResponseModel = null;
					if (flag39)
					{
						goto IL_064b;
					}
					text2 = text;
					kammelnaResponseModel9 = null;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag40 = StringsExtensions.IsNullOrEmpty(<Model>k__BackingField6.<SignalRServerUrl>k__BackingField);
					bool flag41 = !flag40;
					object obj59 = !flag41;
					text = <Model>k__BackingField6.<SignalRServerUrl>k__BackingField;
					kammelnaResponseModel = null;
					text2 = <Model>k__BackingField6.<SignalRServerUrl>k__BackingField;
					kammelnaResponseModel9 = null;
					if (obj59 == null)
					{
						goto IL_064b;
					}
				}
				goto IL_07f7;
			}
			goto IL_144b;
			IL_03aa:
			object obj60 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v138+E4]");
			bool flag42 = (nint)0 == 0;
			flag8 = flag9;
			flag10 = flag11;
			obj4 = obj5;
			obj6 = obj7;
			obj8 = obj9;
			flag12 = flag13;
			flag14 = flag15;
			obj10 = obj11;
			obj12 = obj13;
			obj14 = obj15;
			intPtr = num;
			obj16 = obj17;
			obj18 = obj19;
			obj2 = obj23;
			text = (string)(object)kammelnaResponseModel3;
			flag4 = flag2;
			kammelnaResponseModel6 = kammelnaResponseModel3;
			kammelnaResponseModel7 = kammelnaResponseModel;
			object obj61 = obj60;
			if (!flag42)
			{
				goto IL_046f;
			}
			goto IL_15ef;
			IL_046f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v138+B8]");
			object obj62 = (nint)0 + (nint)40;
			obj62 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			kammelnaResponseModel2 = (KammelnaResponseModel<ConfigsModel>)(object)text;
			goto IL_04a4;
			IL_1459:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45CB]");
			object obj63 = (nint)0 & (nint)1;
			bool flag43 = obj63 == null;
			object obj64 = !flag43;
			flag8 = flag9;
			flag10 = flag11;
			obj4 = obj5;
			obj6 = obj7;
			obj8 = obj9;
			flag12 = flag13;
			flag14 = flag15;
			obj10 = obj11;
			obj12 = obj13;
			obj14 = obj15;
			intPtr = num;
			obj16 = obj17;
			obj18 = obj19;
			obj2 = obj23;
			kammelnaResponseModel6 = kammelnaResponseModel3;
			kammelnaResponseModel7 = kammelnaResponseModel;
			flag4 = flag2;
			if (obj64 != null)
			{
				goto IL_03aa;
			}
			goto IL_1529;
			IL_064b:
			ConfigsModel <Model>k__BackingField7 = response.<Model>k__BackingField;
			bool flag44 = response.<Model>k__BackingField == null;
			flag9 = flag8;
			flag11 = flag10;
			obj5 = obj4;
			obj7 = obj6;
			obj9 = obj8;
			flag13 = flag12;
			flag15 = flag14;
			obj11 = obj10;
			obj13 = obj12;
			obj15 = obj14;
			num = intPtr;
			obj19 = obj18;
			obj23 = obj2;
			kammelnaResponseModel3 = (KammelnaResponseModel<ConfigsModel>)(object)text;
			flag2 = flag4;
			if (flag44)
			{
				goto IL_144b;
			}
			text2 = <Model>k__BackingField7.<SignalRServerUrl>k__BackingField;
			obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj65 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v117+E4]");
			object obj67;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45CC]");
				object obj66 = (nint)0 & (nint)1;
				bool flag45 = obj66 == null;
				obj18 = 146685952;
				obj67 = 146685952;
				if (!flag45)
				{
					goto IL_0785;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45CC]");
				object obj68 = (nint)0 & (nint)1;
				bool flag46 = obj68 == null;
				object obj69 = !flag46;
				obj18 = 146685952;
				obj67 = 146685952;
				if (obj69 != null)
				{
					goto IL_0785;
				}
			}
			_ = 1;
			object obj70 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v127+E4]");
			bool flag47 = (nint)0 == 0;
			object obj71 = !flag47;
			obj18 = obj67;
			object obj72 = obj70;
			if (obj71 != null)
			{
				goto IL_07c2;
			}
			goto IL_172e;
			IL_12b6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X0_v51+B8]");
			object obj73 = (nint)0 + (nint)24;
			obj73 = kammelnaResponseModel3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<Model>k__BackingField4 = response.<Model>k__BackingField;
			bool flag48 = response.<Model>k__BackingField == null;
			kammelnaResponseModel4 = kammelnaResponseModel3;
			obj15 = obj14;
			obj19 = 146685952;
			kammelnaResponseModel = kammelnaResponseModel3;
			flag2 = flag4;
			if (flag48)
			{
				goto IL_144b;
			}
			goto IL_1936;
			IL_0f26:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v84+B8]");
			object obj74 = 0;
			KammelnaConfigLoader kammelnaConfigLoader2 = kammelnaConfigLoader;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v63+8]");
			kammelnaConfigLoader2.RedirectLocalServersToDevelopmentHost((List<SFSConfig>)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v63+8]");
			kammelnaResponseModel8 = (KammelnaResponseModel<ConfigsModel>)0;
			goto IL_0f60;
			IL_17f5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj53 = obj23;
			obj26 = obj50;
			goto IL_0f26;
			IL_0ee9:
			obj53 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v84+E4]");
			bool flag49 = (nint)0 == 0;
			obj50 = obj26;
			obj55 = obj53;
			if (!flag49)
			{
				goto IL_0f26;
			}
			goto IL_17f5;
			IL_0785:
			obj70 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v127+E4]");
			bool flag50 = (nint)0 == 0;
			obj67 = obj18;
			obj72 = obj70;
			if (!flag50)
			{
				goto IL_07c2;
			}
			goto IL_172e;
			IL_172e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj70 = obj2;
			obj18 = obj67;
			goto IL_07c2;
			IL_07c2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v127+B8]");
			object obj75 = (nint)0 + (nint)48;
			obj75 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			kammelnaResponseModel9 = (KammelnaResponseModel<ConfigsModel>)(object)text2;
			goto IL_07f7;
			IL_1936:
			object obj76 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X0_v42+E4]");
			bool flag51 = (nint)0 == 0;
			object obj77 = !flag51;
			if (obj77 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj76 = obj23;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X0_v42+B8]");
			object obj78 = (nint)0 + (nint)32;
			obj78 = <Model>k__BackingField4.<DownMessage>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			goto IL_1352;
			IL_07f7:
			<Model>k__BackingField2 = response.<Model>k__BackingField;
			bool flag52 = response.<Model>k__BackingField == null;
			flag9 = flag8;
			flag11 = flag10;
			obj5 = obj4;
			obj7 = obj6;
			obj9 = obj8;
			flag13 = flag12;
			flag15 = flag14;
			obj11 = obj10;
			obj13 = obj12;
			obj15 = obj14;
			num = intPtr;
			obj19 = obj18;
			obj23 = obj2;
			kammelnaResponseModel3 = (KammelnaResponseModel<ConfigsModel>)(object)text2;
			kammelnaResponseModel = kammelnaResponseModel9;
			flag2 = flag4;
			if (flag52)
			{
				goto IL_144b;
			}
			object obj79 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1344;
			object obj80 = obj79;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v106+E4]");
			object obj81;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v106+B8]");
				obj81 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v77+8]");
				selector = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v77+8]");
				bool flag53 = (nint)0 == 0;
				object obj82 = !flag53;
				if (obj82 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v77+8]");
					Func<object, object> func = (Func<object, object>)0;
					goto IL_09be;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj80 = obj79;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v106+B8]");
				obj81 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v77+8]");
				Func<object, object> func = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v77+8]");
				bool flag54 = (nint)0 == 0;
				object obj83 = !flag54;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v77+8]");
				selector = (Func<object, object>)0;
				if (obj83 == null)
				{
					goto IL_09be;
				}
			}
			goto IL_1842;
			IL_0f60:
			ConfigsModel <Model>k__BackingField8 = response.<Model>k__BackingField;
			bool flag55 = response.<Model>k__BackingField == null;
			obj15 = obj14;
			obj19 = obj26;
			kammelnaResponseModel3 = (KammelnaResponseModel<ConfigsModel>)(object)kammelnaConfigLoader;
			kammelnaResponseModel = kammelnaResponseModel8;
			flag2 = flag4;
			object obj88;
			object obj90;
			if (!flag55)
			{
				kammelnaResponseModel3 = (KammelnaResponseModel<ConfigsModel>)(object)<Model>k__BackingField8.<Maintenance>k__BackingField;
				object obj84 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v27+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C5]");
					object obj85 = (nint)0 & (nint)1;
					bool flag56 = obj85 == null;
					obj19 = 146685952;
					obj44 = 146685952;
					if (!flag56)
					{
						goto IL_1036;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C5]");
					object obj86 = (nint)0 & (nint)1;
					bool flag57 = obj86 == null;
					object obj87 = !flag57;
					obj19 = 146685952;
					obj44 = 146685952;
					if (obj87 != null)
					{
						goto IL_1036;
					}
				}
				_ = 1;
				obj88 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X0_v68+E4]");
				bool flag58 = (nint)0 == 0;
				object obj89 = !flag58;
				obj19 = obj44;
				obj90 = obj88;
				if (obj89 != null)
				{
					goto IL_1073;
				}
				goto IL_11a2;
			}
			goto IL_144b;
			IL_1529:
			_ = 1;
			obj60 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v138+E4]");
			bool flag59 = (nint)0 == 0;
			object obj91 = !flag59;
			text = (string)(object)kammelnaResponseModel6;
			flag9 = flag8;
			flag11 = flag10;
			obj5 = obj4;
			obj7 = obj6;
			obj9 = obj8;
			flag13 = flag12;
			flag15 = flag14;
			obj11 = obj10;
			obj13 = obj12;
			obj15 = obj14;
			num = intPtr;
			obj17 = obj16;
			obj19 = obj18;
			obj23 = obj2;
			obj61 = obj60;
			flag2 = flag4;
			if (obj91 != null)
			{
				goto IL_046f;
			}
			goto IL_15ef;
			IL_15ef:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj60 = obj19;
			flag8 = flag9;
			flag10 = flag11;
			obj4 = obj5;
			obj6 = obj7;
			obj8 = obj9;
			flag12 = flag13;
			flag14 = flag15;
			obj10 = obj11;
			obj12 = obj13;
			obj14 = obj15;
			intPtr = num;
			obj16 = obj17;
			obj18 = obj19;
			obj2 = obj23;
			text = (string)(object)kammelnaResponseModel6;
			flag4 = flag2;
			goto IL_046f;
			IL_144b:
			ex = new NullReferenceException();
			goto IL_1459;
			IL_09be:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v106+E4]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v106+E4]");
			bool flag60 = (nint)0 == 0;
			object obj92 = !flag60;
			if (obj92 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj93 = obj79;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v83+B8]");
				obj81 = 0;
			}
			object obj94 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3232;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj95 = (nint)0 + (nint)3240;
			Func<object, object> func2 = default(Func<object, object>);
			func2..ctor(obj81, (IntPtr)obj95);
			object obj96 = obj79;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v82+B8]");
			object obj97 = (nint)0 + (nint)8;
			obj97 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj14 = 0;
			selector = func2;
			goto IL_1842;
			IL_1036:
			obj88 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X0_v68+E4]");
			bool flag61 = (nint)0 == 0;
			obj44 = obj19;
			obj90 = obj88;
			if (!flag61)
			{
				goto IL_1073;
			}
			goto IL_11a2;
			IL_1352:
			Actions.SafeInvoke(callback, flag4);
		}
	}

	public KammelnaEnvironmentProvider environmentProvider;

	public string liveHostURL;

	public string preHostURL;

	public string defaultBlobUrl;

	private unsafe string defaultBlobUrlFallback
	{
		get
		{
			//IL_0010: Expected O, but got Ref
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			if ((object)environmentProvider != null)
			{
				object obj = default(object);
				string text = ((Enum)(&obj)).ToString();
				if (text != null)
				{
					object obj2 = ", stale={0}" + 2920;
					string text2 = text.ToLower();
					return defaultBlobUrl + text2 + (string)obj2;
				}
			}
			return (string)(object)new NullReferenceException();
		}
	}

	private string defaultSignalRServerUrl => "getSecondRescanTask" + 3848;

	public ServerEnvironment Environment
	{
		get
		{
			//IL_0041: Expected I4, but got O
			KammelnaEnvironmentProvider kammelnaEnvironmentProvider = environmentProvider;
			if ((object)environmentProvider != null)
			{
				return kammelnaEnvironmentProvider.environment;
			}
			NullReferenceException ex = new NullReferenceException();
			return (ServerEnvironment)ex;
		}
		set
		{
			KammelnaEnvironmentProvider kammelnaEnvironmentProvider = environmentProvider;
			kammelnaEnvironmentProvider.environment = value;
		}
	}

	public string LocalHostUrl
	{
		get
		{
			KammelnaEnvironmentProvider kammelnaEnvironmentProvider = environmentProvider;
			if ((object)environmentProvider != null)
			{
				return kammelnaEnvironmentProvider.localHostURL;
			}
			return (string)(object)new NullReferenceException();
		}
		set
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			object obj = environmentProvider + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string Host
	{
		get
		{
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected O, but got Unknown
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_0072: Expected O, but got I4
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Expected O, but got Unknown
			//IL_00f5: Expected O, but got I
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			KammelnaEnvironmentProvider kammelnaEnvironmentProvider = environmentProvider;
			if (kammelnaEnvironmentProvider.environment != ServerEnvironment.Development)
			{
				if (kammelnaEnvironmentProvider.environment != ServerEnvironment.Staging)
				{
					bool flag = kammelnaEnvironmentProvider.environment == ServerEnvironment.Production;
					object obj = !flag;
					if (obj == null)
					{
						return (string)(this + 32);
					}
					object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
					ex..ctor();
					object obj3 = (nint)0 + (nint)3472;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					return (string)(object)new OutOfMemoryException();
				}
				return (string)(this + 40);
			}
			return (string)(kammelnaEnvironmentProvider + 32);
		}
	}

	public void LoadServersConfig(Action<bool> callback)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_011d: Expected O, but got I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I4
		//IL_02fa: Expected O, but got I4
		//IL_03f9: Expected O, but got I
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_043a: Expected O, but got I4
		//IL_0332: Expected O, but got I
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_036e: Expected O, but got I
		//IL_037f: Expected I, but got O
		object obj = 152989696;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		if (obj3 != null)
		{
			object obj4 = obj3 + 16;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj3 + 24;
			obj5 = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			string text = defaultBlobUrlFallback;
			object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v45+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v49+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v49+B8]");
			object obj11 = (nint)0 + (nint)40;
			obj11 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj12 = "getSecondRescanTask" + 3848;
			object obj13 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v56+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v56+B8]");
			object obj15 = (nint)0 + (nint)48;
			obj15 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 544;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj17 = (nint)0 + (nint)3248;
			Action<object> action = default(Action<object>);
			action..ctor(obj3, (IntPtr)obj17);
			KammelnaRequests.GetServers(action);
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
			object obj18 = 0;
			NullReferenceException ex2 = ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		}
	}

	private unsafe void RedirectLocalServersToDevelopmentHost(List<SFSConfig> servers)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00de: Expected O, but got I4
		//IL_00e7: Expected O, but got I4
		//IL_0077: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_0089: Expected O, but got I4
		//IL_0348: Expected O, but got I
		//IL_0141: Expected O, but got I4
		//IL_018b: Expected O, but got I
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_02f6: Expected O, but got I4
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_020c: Expected O, but got I4
		//IL_0211: Expected I, but got O
		//IL_024c: Expected I, but got O
		//IL_0251: Expected I, but got O
		KammelnaEnvironmentProvider kammelnaEnvironmentProvider = environmentProvider;
		bool flag = (object)environmentProvider == null;
		List<SFSConfig> list = servers;
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		if (!flag)
		{
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4024;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v17+E4]");
			Uri result;
			if ((nint)0 != 0)
			{
				bool flag2 = Uri.TryCreate(kammelnaEnvironmentProvider.localHostURL, UriKind.Absolute, out result);
				bool flag3 = !flag2;
				object obj3 = !flag3;
				object obj4 = 0;
				list = (List<SFSConfig>)1;
				nint num = (nint)(&result);
				if (obj3 == null)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag4 = Uri.TryCreate(kammelnaEnvironmentProvider.localHostURL, UriKind.Absolute, out result);
				bool flag5 = !flag4;
				object obj4 = 0;
				list = (List<SFSConfig>)1;
				nint num = (nint)(&result);
				if (flag5)
				{
					return;
				}
			}
			if ((object)result != null)
			{
				bool isLoopback = result.IsLoopback;
				bool flag6 = !isLoopback;
				object obj5 = !flag6;
				if (obj5 != null)
				{
					return;
				}
				bool flag7 = servers == null;
				list = null;
				if (!flag7)
				{
					List<object>.Enumerator enumerator = ((List<object>)(object)servers).GetEnumerator();
					object obj6 = (nint)0 + (nint)864;
					object obj7 = "java.io.FileOutputStream" + 3032;
					object obj8 = "1.2.840.113549.1.12.1.5" + 744;
					List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
					object obj9 = default(object);
					while (true)
					{
						list = (List<SFSConfig>)obj6;
						if (enumerator2.MoveNext())
						{
							if (obj9 != null)
							{
								object obj10 = obj9 + 40;
								string text = (string)obj7;
								bool flag8 = (string)obj10 == (string)obj7;
								bool flag9 = !flag8;
								object obj11 = !flag9;
								nint num2 = unchecked((nint)null);
								nint num;
								if (obj11 == null)
								{
									text = (string)obj8;
									bool flag10 = (string)obj10 == (string)obj8;
									bool flag11 = !flag10;
									num2 = unchecked((nint)null);
									num = unchecked((nint)null);
									if (flag11)
									{
										continue;
									}
								}
								if ((object)result != null)
								{
									string host = result.Host;
									obj10 = host;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									num = num2;
									continue;
								}
								NullReferenceException ex = new NullReferenceException();
								list = (List<SFSConfig>)(object)text;
								num = num2;
								break;
							}
							NullReferenceException ex2 = new NullReferenceException();
							break;
						}
						enumerator2.Dispose();
						return;
					}
					List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
					enumerator3 = enumerator4;
					enumerator4 = (List<object>.Enumerator)0;
				}
			}
		}
		NullReferenceException ex3 = new NullReferenceException();
		bool flag12 = (nint)list != 1;
		NullReferenceException ex4 = ex3;
		if (!flag12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj12 = (nint)0 + (nint)856;
			list = (List<SFSConfig>)obj12;
			enumerator3.Dispose();
			object obj13 = default(object);
			if (obj13 == null)
			{
				return;
			}
			OutOfMemoryException ex5 = new OutOfMemoryException();
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj13;
			ex4 = (NullReferenceException)(object)ex5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2238554");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public unsafe override string ToString()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00b8: Expected O, but got I4
		//IL_00c0: Expected I, but got O
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_0150: Expected O, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		if ((object)environmentProvider != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 3776;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			KammelnaEnvironmentProvider kammelnaEnvironmentProvider = environmentProvider;
			bool flag = (object)environmentProvider == null;
			ServerEnvironment serverEnvironment = default(ServerEnvironment);
			nint num = (nint)(&serverEnvironment);
			if (!flag)
			{
				object obj3 = default(object);
				object arg;
				if (kammelnaEnvironmentProvider.environment != ServerEnvironment.Development)
				{
					if (kammelnaEnvironmentProvider.environment != ServerEnvironment.Staging)
					{
						bool flag2 = kammelnaEnvironmentProvider.environment == ServerEnvironment.Production;
						object obj2 = !flag2;
						num = (nint)obj3;
						if (obj2 != null)
						{
							object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
							ex..ctor();
							object obj5 = (nint)0 + (nint)3472;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
							return (string)(object)new OutOfMemoryException();
						}
						arg = this + 32;
					}
					else
					{
						arg = this + 40;
					}
				}
				else
				{
					arg = environmentProvider + 32;
				}
				object format = "destinationTimeZone" + 2560;
				return string.Format((string)format, obj3, arg, defaultBlobUrl);
			}
		}
		throw new NullReferenceException();
	}
}
