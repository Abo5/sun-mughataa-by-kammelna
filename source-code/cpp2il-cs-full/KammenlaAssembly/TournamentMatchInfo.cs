using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.SceneManagement;

public class TournamentMatchInfo : Singleton<TournamentMatchInfo>
{
	private Room room;

	private int <MatchId>k__BackingField;

	private Action m_OnScoreUpdated;

	private int previousTeam1Score;

	private int previousTeam2Score;

	private int lastWinner;

	public int MatchId
	{
		get
		{
			return <MatchId>k__BackingField;
		}
		private set
		{
			<MatchId>k__BackingField = value;
		}
	}

	public MatchData Match
	{
		get
		{
			//IL_02fc: Expected O, but got I4
			//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Expected O, but got Unknown
			//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c5: Expected O, but got Unknown
			//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d3: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0048: Expected I, but got O
			//IL_0058: Expected O, but got I
			//IL_00ee: Expected I, but got O
			//IL_00fe: Expected O, but got I
			//IL_0127: Expected O, but got I
			//IL_0093: Expected O, but got I
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Expected O, but got Unknown
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			//IL_0165: Expected I, but got O
			//IL_0175: Expected O, but got I
			//IL_0204: Expected O, but got I4
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_021f: Expected O, but got Unknown
			//IL_0227: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Expected O, but got Unknown
			//IL_0235: Unknown result type (might be due to invalid IL or missing references)
			//IL_023a: Expected O, but got Unknown
			//IL_0242: Expected I, but got O
			//IL_0252: Expected O, but got I
			//IL_0276: Expected O, but got I4
			//IL_0286: Expected O, but got I
			//IL_01b0: Expected O, but got I
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Expected O, but got Unknown
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Expected O, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CC4]");
			nint num = 0;
			Room room = this.room;
			bool flag = this.room == null;
			object obj = 152985600;
			object obj6 = default(object);
			object obj10;
			NullReferenceException ex = default(NullReferenceException);
			object obj12;
			if (!flag)
			{
				object obj2 = typeof(RegisteredWaitHandle) + 1376;
				object obj3 = "tournament_participate_warning_body_with_tickets_warning_daily" + 672;
				obj = obj3;
				nint num2 = (nint)room;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00dc;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				object obj5 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X10_v13-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					obj6 = obj5 + 16;
					obj4--;
					bool flag2 = (nint)obj4 != 1;
					obj5 = obj6;
					if (flag2)
					{
						continue;
					}
					goto IL_00dc;
				}
				object obj7 = obj5 + 31;
				object obj8 = num2 + obj7;
				object obj9 = obj8 + 312;
				num = (nint)obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v17+8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v235 @ X0_v17] (should have been resolved before IL gen)");
				bool flag3 = ex == null;
				object obj11 = !flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v17+8]");
				obj12 = 0;
				obj6 = obj5;
				if (obj11 != null)
				{
					goto IL_0135;
				}
			}
			goto IL_029c;
			IL_029c:
			ex = new NullReferenceException();
			goto IL_02aa;
			IL_0135:
			object obj13 = typeof(UsageHint) + 664;
			obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3856;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01f1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
			obj6 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X10_v2-8]");
				bool flag4 = 0 == (nint)obj13;
				obj12 = obj10;
				if (flag4)
				{
					break;
				}
				obj6 += 16;
				obj14--;
				if ((nint)obj14 != 1)
				{
					continue;
				}
				goto IL_01f1;
			}
			goto IL_02aa;
			IL_02aa:
			object obj15 = obj6 + 7;
			object obj16 = num + obj15;
			object obj17 = obj16 + 312;
			goto IL_035a;
			IL_035a:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v221 @ X8_v3] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			MatchData matchData = default(MatchData);
			ISFSObject data = default(ISFSObject);
			matchData..ctor(data);
			return matchData;
			IL_01f1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj12 = 7;
			object obj18 = default(object);
			obj17 = obj18;
			goto IL_035a;
			IL_00dc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj19 = default(object);
			num = (nint)obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v14+8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v136 @ X0_v14] (should have been resolved before IL gen)");
			bool flag5 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v14+8]");
			obj12 = 0;
			if (!flag5)
			{
				goto IL_0135;
			}
			goto IL_029c;
		}
	}

	public TournamentData Tournament => SFSKammelnaRoomExtensions.GetTournamentInfo(room);

	public int TeamScore1
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object varName = "utf-32" + 1104;
			return SFSExtensions.GetVariable(room, (string)varName, 0);
		}
	}

	public int TeamScore2
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object varName = "utf-32" + 1112;
			return SFSExtensions.GetVariable(room, (string)varName, 0);
		}
	}

	public int LastWinner => lastWinner;

	public int WiningValue
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 680;
			return SFSExtensions.GetVariable(room, (string)varName, 0);
		}
	}

	public event Action OnScoreUpdated
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 48;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 48;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	protected override void OnAwake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_0344: Expected O, but got I4
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_03a8: Expected O, but got I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01cf: Expected O, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_020d: Expected O, but got I
		//IL_0225: Expected I, but got O
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_0268: Expected I, but got O
		//IL_02a1: Expected I, but got O
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02df: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CC6]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v34+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v34+E4]");
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
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		object obj8 = this + 32;
		obj8 = currentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		MatchData match = Match;
		<MatchId>k__BackingField = match.<ID>k__BackingField;
		GameObject gameObject = base.gameObject;
		if (match.<ID>k__BackingField > 0)
		{
			object obj9 = typeof(SqlSingle[]) + 2376;
			object obj10 = (nint)0 + (nint)984;
			object varName = "utf-32" + 1104;
			object varName2 = "utf-32" + 1112;
			object obj11 = typeof(TypeConverter<ushort, char>) + 528;
			object obj12 = (nint)0 + (nint)976;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj10);
			VariableBinderExtensions.Bind(gameObject, room, (string)varName, action);
			GameObject go = base.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action2 = default(Action);
			action2..ctor(this, (IntPtr)obj10);
			VariableBinderExtensions.Bind(go, room, (string)varName2, action2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
			unityAction..ctor((object)this, (IntPtr)obj12);
			object obj13 = typeof(RegisteredWaitHandle) + 2944;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v30+E4]");
			bool flag3 = (nint)0 == 0;
			object obj15 = !flag3;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
		}
		else
		{
			object obj16 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj18 = !flag4;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(gameObject);
			object obj19 = typeof(DataRelation) + 856;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			object obj21 = !flag5;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "ThisIsFakeReceiptData" + 1496;
			Debug.LogError(message);
		}
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag6 = (object)sessionModel == null;
		object obj22 = !flag6;
		if (obj22 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	private void OnSceneLoaded(Scene _, LoadSceneMode __)
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
		object obj2 = (nint)0 + (nint)976;
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
		SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
		GameObject obj7 = base.gameObject;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			UnityEngine.Object.Destroy(obj7);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.Destroy(obj7);
	}

	private void OnScoresUpdated()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_0196: Expected O, but got I4
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected I4, but got Unknown
		//IL_0205: Expected O, but got I4
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_0249: Expected O, but got I
		//IL_0263: Expected O, but got I4
		object varName = "utf-32" + 1104;
		int variable = SFSExtensions.GetVariable(room, (string)varName, 0);
		object varName2 = "utf-32" + 1112;
		if (previousTeam1Score == variable)
		{
			int variable2 = SFSExtensions.GetVariable(room, (string)varName2, 0);
			if (previousTeam2Score == variable2)
			{
				return;
			}
		}
		int variable3 = SFSExtensions.GetVariable(room, (string)varName, 0);
		if (variable3 > previousTeam1Score)
		{
			lastWinner = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CFA]");
			object obj = (nint)0 & (nint)1;
			if (obj == null)
			{
				goto IL_0083;
			}
		}
		else
		{
			int variable4 = SFSExtensions.GetVariable(room, (string)varName2, 0);
			object obj2 = variable4 - previousTeam2Score;
			bool flag = (nint)obj2 < 0;
			bool flag2 = obj2 == null;
			int num = variable4 ^ previousTeam2Score;
			int num2 = variable4 ^ obj2;
			int num3 = num & num2;
			bool flag3 = num3 < 0;
			bool flag4 = flag == flag3;
			object obj3 = !flag2;
			object obj4 = flag4 & obj3;
			object obj5 = ~obj4;
			int num4 = ((obj5 == null) ? 2 : 0);
			lastWinner = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CFA]");
			object obj6 = (nint)0 & (nint)1;
			bool flag5 = obj6 == null;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				goto IL_0083;
			}
		}
		goto IL_0148;
		IL_0148:
		int variable5 = SFSExtensions.GetVariable(room, (string)varName, 0);
		previousTeam1Score = variable5;
		int variable6 = SFSExtensions.GetVariable(room, (string)varName2, 0);
		previousTeam2Score = variable6;
		Actions.SafeInvoke(this.OnScoreUpdated);
		return;
		IL_0083:
		_ = 1;
		goto IL_0148;
	}

	public TournamentMatchInfo()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 872;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CC8]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2240;
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
			object obj4 = (nint)0 + (nint)2240;
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
}
