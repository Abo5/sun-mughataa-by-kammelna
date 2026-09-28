using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using Server.Models;
using Sfs2X.Entities.Data;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public abstract class SfsLeaderboardSource : BaseLeaderboardSource
{
	private sealed class <>c__DisplayClass8_0
	{
		public Action<string> onError;

		public Action useCacheCallback;

		public Action<LeaderboardModel> successCallback;

		internal void <Load>b__0(ISFSObject response)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0030: Expected I, but got O
			//IL_0040: Expected O, but got I
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected O, but got Unknown
			//IL_007b: Expected O, but got I
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Expected O, but got Unknown
			//IL_01e7: Expected I, but got O
			//IL_01f7: Expected O, but got I
			//IL_00f9: Expected O, but got I
			//IL_02a1: Expected O, but got I4
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected O, but got Unknown
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Expected O, but got Unknown
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Expected O, but got Unknown
			//IL_0171: Expected O, but got I4
			//IL_031c: Expected I, but got O
			//IL_032c: Expected O, but got I
			//IL_0232: Expected O, but got I
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_03d6: Expected O, but got I4
			//IL_0367: Expected O, but got I
			//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ca: Expected O, but got Unknown
			//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d7: Expected O, but got Unknown
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e5: Expected O, but got Unknown
			//IL_0240: Unknown result type (might be due to invalid IL or missing references)
			//IL_0245: Expected O, but got Unknown
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Expected O, but got Unknown
			//IL_0486: Expected I, but got O
			//IL_0496: Expected O, but got I
			//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ff: Expected O, but got Unknown
			//IL_0407: Unknown result type (might be due to invalid IL or missing references)
			//IL_040c: Expected O, but got Unknown
			//IL_0415: Unknown result type (might be due to invalid IL or missing references)
			//IL_041a: Expected O, but got Unknown
			//IL_056c: Expected O, but got I
			//IL_057c: Expected O, but got I
			//IL_058c: Expected O, but got I
			//IL_0375: Unknown result type (might be due to invalid IL or missing references)
			//IL_037a: Expected O, but got Unknown
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Expected O, but got Unknown
			//IL_04d1: Expected O, but got I
			//IL_052a: Unknown result type (might be due to invalid IL or missing references)
			//IL_052f: Expected O, but got Unknown
			//IL_0537: Unknown result type (might be due to invalid IL or missing references)
			//IL_053c: Expected O, but got Unknown
			//IL_0545: Unknown result type (might be due to invalid IL or missing references)
			//IL_054a: Expected O, but got Unknown
			//IL_04df: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e4: Expected O, but got Unknown
			//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f2: Expected O, but got Unknown
			object obj = typeof(System.IOAsyncCallback) + 976;
			object varName = "destinationTimeZone" + 2696;
			nint num = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X10_v25-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj4 = obj3 + 1;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v258 @ X0_v42] (should have been resolved before IL gen)");
			object obj7 = default(object);
			bool flag = obj7 == null;
			object obj8 = !flag;
			if (obj8 != null)
			{
				goto IL_00ed;
			}
			goto IL_017f;
			IL_0449:
			SFSDataWrapper sFSDataWrapper = default(SFSDataWrapper);
			int type = sFSDataWrapper.Type;
			bool flag2 = type != 18;
			ISFSObject data = response;
			if (flag2)
			{
				goto IL_05df;
			}
			nint num2 = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0512;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj10 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X10_v9-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj10 += 16;
				obj9--;
				if ((nint)obj9 != 1)
				{
					continue;
				}
				goto IL_0512;
			}
			object obj11 = obj10 + 29;
			object obj12 = num2 + obj11;
			object obj13 = obj12 + 312;
			goto IL_0650;
			IL_0273:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v333 @ X0_v27] (should have been resolved before IL gen)");
			object obj14 = default(object);
			bool flag3 = obj14 == null;
			object obj15 = !flag3;
			if (obj15 != null)
			{
				goto IL_0314;
			}
			data = response;
			goto IL_05df;
			IL_0314:
			nint num3 = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03a8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj17 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X10_v14-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj17 += 16;
				obj16--;
				if ((nint)obj16 != 1)
				{
					continue;
				}
				goto IL_03a8;
			}
			object obj18 = obj17 + 10;
			object obj19 = num3 + obj18;
			object obj20 = obj19 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v504 @ X0_v23] (should have been resolved before IL gen)");
			bool flag4 = sFSDataWrapper == null;
			data = response;
			if (!flag4)
			{
				goto IL_0449;
			}
			goto IL_05df;
			IL_05df:
			Action<LeaderboardModel> action = successCallback;
			if (successCallback != null)
			{
				LeaderboardModel leaderboardModel = LeaderboardModel.FromSfsObject(data);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X20_v2 (System.Action`1<Server.Models.LeaderboardModel>)+18]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X20_v2 (System.Action`1<Server.Models.LeaderboardModel>)+40]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X20_v2 (System.Action`1<Server.Models.LeaderboardModel>)+28]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v152 @ X3_v2 (should have been resolved before IL gen)");
			}
			return;
			IL_00bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ X0_v39] (should have been resolved before IL gen)");
			object obj24 = default(object);
			if (obj24 != null)
			{
				goto IL_00ed;
			}
			goto IL_017f;
			IL_017f:
			object varName2 = "setMimeType" + 3816;
			int num4 = SFSExtensions.Get(response, (string)varName2, 0);
			if (num4 == 304)
			{
				Actions.SafeInvoke(useCacheCallback);
				return;
			}
			object obj25 = "com.unity.services.authentication.profile" + 2776;
			nint num5 = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0273;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj27 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X10_v19-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj27 += 16;
				obj26--;
				if ((nint)obj26 != 1)
				{
					continue;
				}
				goto IL_0273;
			}
			object obj28 = obj27 + 1;
			object obj29 = num5 + obj28;
			object obj30 = obj29 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v366 @ X0_v30] (should have been resolved before IL gen)");
			object obj31 = default(object);
			bool flag5 = obj31 == null;
			data = response;
			if (!flag5)
			{
				goto IL_0314;
			}
			goto IL_05df;
			IL_0512:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0650;
			IL_0650:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v577 @ X0_v13] (should have been resolved before IL gen)");
			ISFSObject iSFSObject = default(ISFSObject);
			data = iSFSObject;
			goto IL_05df;
			IL_00ed:
			object defaultValue = (nint)0 + (nint)2000;
			string arg = SFSExtensions.Get(response, (string)varName, (string)defaultValue);
			Actions.SafeInvoke((Action<object>)onError, arg);
			return;
			IL_03a8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v484 @ X0_v20] (should have been resolved before IL gen)");
			bool flag6 = sFSDataWrapper == null;
			object obj32 = !flag6;
			if (obj32 != null)
			{
				goto IL_0449;
			}
			data = response;
			goto IL_05df;
		}
	}

	protected abstract string SfsCommand { get; }

	protected abstract ISFSObject ExtraParams { get; }

	protected virtual bool IsRoomLevel => false;

	protected virtual bool IsAvailableForCurrentGame => true;

	public override void Load(GameObject lifecycle, Action<LeaderboardModel> successCallback, Action useCacheCallback, Action<string> onError)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0774: Expected I, but got O
		//IL_0784: Expected O, but got I
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_081a: Expected I, but got O
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0083: Expected I, but got O
		//IL_07bf: Expected O, but got I
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02c6: Expected O, but got I
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Expected O, but got Unknown
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected O, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Expected O, but got Unknown
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected O, but got Unknown
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_062a: Expected I, but got O
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected O, but got Unknown
		//IL_065e: Expected O, but got I
		//IL_066a: Expected O, but got I
		//IL_0684: Expected O, but got I4
		//IL_0964: Expected I, but got O
		//IL_0969: Expected I, but got O
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_0987: Expected O, but got Unknown
		//IL_099d: Expected O, but got I
		//IL_09ae: Expected I, but got O
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_019a: Expected I, but got O
		//IL_01aa: Expected O, but got I
		//IL_025c: Expected O, but got I4
		//IL_026d: Expected I8, but got I4
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_01e5: Expected O, but got I
		//IL_070e: Expected O, but got I4
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_03be: Expected O, but got I4
		//IL_0485: Expected I, but got O
		//IL_0495: Expected O, but got I
		//IL_08fd: Expected I, but got O
		//IL_090d: Expected O, but got I
		//IL_04d0: Expected O, but got I
		//IL_03e7: Expected O, but got I
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0430: Expected O, but got I
		//IL_057c: Expected O, but got I
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected O, but got Unknown
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected O, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected O, but got Unknown
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected O, but got Unknown
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected O, but got Unknown
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected O, but got Unknown
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected O, but got Unknown
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected O, but got Unknown
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		GameObject gameObject = lifecycle;
		Action action = default(Action);
		SFSObject sFSObject = default(SFSObject);
		object obj8 = default(object);
		object obj11 = default(object);
		object obj15 = default(object);
		object obj10;
		long num2;
		if (!flag)
		{
			object obj3 = obj2 + 16;
			obj3 = onError;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 32;
			obj5 = successCallback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			nint num = (nint)this;
			if (!IsAvailableForCurrentGame)
			{
				object obj6 = typeof(List<AdaptivePerformanceScaler>) + 2096;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				List<object> list = default(List<object>);
				list..ctor();
				object etag = (nint)0 + (nint)2000;
				LeaderboardModel arg = LeaderboardModel.FromList((List<LeaderBoardPlayer>)(object)list, (string)etag);
				Actions.SafeInvoke((Action<object>)obj5, arg);
				return;
			}
			object obj7 = typeof(RegisteredWaitHandle) + 2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			sFSObject..ctor();
			string eTag = GetETag();
			long result;
			bool flag2 = long.TryParse(eTag, out result);
			object key = "destinationTimeZone" + 1040;
			SFSExtensions.Put(sFSObject, (string)key, result);
			ISFSObject extraParams = ExtraParams;
			bool flag3 = extraParams == null;
			Action action2 = null;
			num2 = result;
			if (flag3)
			{
				goto IL_0625;
			}
			ISFSObject extraParams2 = ExtraParams;
			bool flag4 = extraParams2 == null;
			action = null;
			gameObject = lifecycle;
			if (!flag4)
			{
				obj8 = typeof(System.IOAsyncCallback) + 976;
				nint num3 = (nint)extraParams2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v40 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v40 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_022e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v40 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				obj10 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X10_v17-8]");
					if (0 == (nint)obj8)
					{
						break;
					}
					obj11 = obj10 + 16;
					obj9--;
					bool flag5 = (nint)obj9 != 1;
					obj10 = obj11;
					if (flag5)
					{
						continue;
					}
					goto IL_022e;
				}
				object obj12 = obj10 + 3;
				object obj13 = num3 + obj12;
				object obj14 = obj13 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v214 @ X8_v58] (should have been resolved before IL gen)");
				bool flag6 = obj15 == null;
				num2 = result;
				obj11 = obj10;
				action = null;
				gameObject = lifecycle;
				if (!flag6)
				{
					goto IL_0358;
				}
			}
		}
		goto IL_073e;
		IL_0358:
		object obj16 = obj15 + 32;
		NullReferenceException ex;
		object obj30;
		Action action3;
		GameObject gameObject2;
		if (sFSObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v53+18]");
			bool flag7 = (nint)0 < (nint)1;
			obj11 = obj10;
			Action action2 = null;
			if (flag7)
			{
				goto IL_0625;
			}
			object obj17 = 0;
			action = null;
			object obj23 = default(object);
			long num6 = default(long);
			while (true)
			{
				ISFSObject extraParams3 = ExtraParams;
				bool flag8 = extraParams3 == null;
				obj11 = obj10;
				gameObject = lifecycle;
				if (flag8)
				{
					break;
				}
				nint num4 = (nint)extraParams3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v46 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v46 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0519;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v46 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj19 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X10_v22-8]");
					if (0 == (nint)obj8)
					{
						break;
					}
					obj10 = obj19 + 16;
					obj18--;
					bool flag9 = (nint)obj18 != 1;
					obj19 = obj10;
					if (flag9)
					{
						continue;
					}
					goto IL_0519;
				}
				object obj20 = obj19 + 10;
				object obj21 = num4 + obj20;
				object obj22 = obj21 + 312;
				obj10 = obj19;
				goto IL_08eb;
				IL_0519:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj22 = obj23;
				goto IL_08eb;
				IL_08eb:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v712 @ X8_v47] (should have been resolved before IL gen)");
				nint num5 = (nint)sFSObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X8_v48 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X8_v48 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_03c8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X8_v48 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
				obj10 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X10_v17-8]");
					if (0 == (nint)obj8)
					{
						break;
					}
					obj10 += 16;
					obj24--;
					if ((nint)obj24 != 1)
					{
						continue;
					}
					goto IL_03c8;
				}
				object obj25 = obj10 + 52;
				object obj26 = num5 + obj25;
				object obj27 = obj26 + 312;
				goto IL_03d7;
				IL_03d7:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v62+8]");
				action = (Action)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v782 @ X0_v62] (should have been resolved before IL gen)");
				obj17++;
				object obj28 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v53+18]");
				bool flag10 = (nint)obj28 >= 0;
				obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v62+8]");
				action2 = (Action)0;
				num2 = num6;
				if (!flag10)
				{
					continue;
				}
				goto IL_0625;
				IL_03c8:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				goto IL_03d7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v53+18]");
			bool flag11 = (nint)0 >= (nint)1;
			obj11 = obj10;
			Action action2 = null;
			if (!flag11)
			{
				goto IL_0625;
			}
			gameObject = (GameObject)obj16;
			ex = (NullReferenceException)ExtraParams;
			bool flag12 = ex == null;
			object obj29 = !flag12;
			obj11 = obj10;
			action = null;
			obj30 = obj8;
			action3 = null;
			gameObject2 = (GameObject)obj16;
			if (obj29 != null)
			{
				goto IL_076c;
			}
		}
		goto IL_073e;
		IL_073e:
		ex = new NullReferenceException();
		obj10 = obj11;
		obj30 = obj8;
		action3 = action;
		gameObject2 = gameObject;
		goto IL_076c;
		IL_076c:
		nint num7 = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v5 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v5 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v5 (Il2CppClass<System.NullReferenceException>)+B0]");
			object obj32 = (nint)0 + (nint)8;
			bool flag14;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X10_v6-8]");
				bool flag13 = 0 == (nint)obj30;
				obj10 = obj32;
				if (!flag13)
				{
					obj10 = obj32 + 16;
					obj31--;
					flag14 = (nint)obj31 != 1;
					obj32 = obj10;
					continue;
				}
				object obj33 = obj10 + 10;
				object obj34 = num7 + obj33;
				object obj35 = obj34 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v381 @ X0_v6] (should have been resolved before IL gen)");
				throw new NullReferenceException();
			}
			while (flag14);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj36 = default(object);
		num7 = (nint)obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v311 @ X0_v11] (should have been resolved before IL gen)");
		throw new NullReferenceException();
		IL_0625:
		nint num8 = (nint)this;
		bool isRoomLevel = IsRoomLevel;
		object obj37 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj38 = (nint)0 + (nint)3504;
		object obj39 = (nint)0 + (nint)3512;
		bool flag15 = !isRoomLevel;
		object obj40 = !flag15;
		object obj41 = ~obj40;
		if (obj41 != null)
		{
			obj38 = obj39;
		}
		Action<object, object, object, bool, object> action4 = default(Action<object, object, object, bool, object>);
		action4..ctor((object)null, (IntPtr)obj38);
		nint num9 = (nint)this;
		string sfsCommand = SfsCommand;
		object obj42 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj43 = (nint)0 + (nint)2040;
		Action<object> action5 = default(Action<object>);
		action5..ctor(obj2, (IntPtr)obj43);
		bool flag16 = action4 == null;
		action = null;
		gameObject = lifecycle;
		if (!flag16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v555 @ X0_v44 (System.Action`5<System.Object, System.Object, System.Object, System.Boolean, System.Object>)+18] (should have been resolved before IL gen)");
			return;
		}
		goto IL_073e;
		IL_022e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v580 @ X0_v69] (should have been resolved before IL gen)");
		bool flag17 = obj15 == null;
		object obj44 = !flag17;
		obj10 = obj11;
		num2 = 3L;
		if (obj44 != null)
		{
			goto IL_0358;
		}
		action = null;
		gameObject = lifecycle;
		goto IL_073e;
	}
}
