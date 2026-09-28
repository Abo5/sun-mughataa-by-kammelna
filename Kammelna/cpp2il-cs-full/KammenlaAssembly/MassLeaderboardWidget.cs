using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using Kammelna.Server;
using Server.Models;
using Sfs2X.Entities;
using Unity.Properties;
using UnityEngine;

public class MassLeaderboardWidget : MassWidget
{
	private NormalPlaceItem[] topPlayers;

	private GameObject placeholder;

	private MassWinnersPanel massWinnersPanel;

	private GameObject leaderboardsPanel;

	private IEnumerable<GameObject> panels
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_00a4: Expected O, but got I8
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			object obj = typeof(TypeConverter<ushort, char>) + 2568;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			if ((object)massWinnersPanel != null)
			{
				GameObject gameObject = massWinnersPanel.gameObject;
				IEnumerable<GameObject> enumerable = default(IEnumerable<GameObject>);
				if (enumerable != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)+18]");
					if ((nint)0 != 0)
					{
						object obj2 = enumerable + 32;
						obj2 = gameObject;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X21_v5-8]");
						object obj3 = 0 & 0xFFFFFFFEL;
						if (obj3 != null)
						{
							object obj4 = enumerable + 40;
							obj4 = leaderboardsPanel;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							return enumerable;
						}
					}
					goto IL_00f6;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_00f6;
			IL_00f6:
			return (IEnumerable<GameObject>)(object)new IndexOutOfRangeException();
		}
	}

	protected override void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0129: Expected O, but got I
		//IL_015d: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0090: Expected I, but got O
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00fc: Expected I, but got O
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		GameObject go = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)3136;
		object varName = "___# Content push apply failed [{0}]: {1}" + 3960;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go, currentRoom, (string)varName, action);
		GameObject go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object varName2 = "startPosition" + 104;
		SessionModel sessionModel2 = default(SessionModel);
		Room currentRoom2 = sessionModel2.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go2, currentRoom2, (string)varName2, action2);
		Reload();
	}

	private void Reload()
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_0078: Expected I, but got O
		HideAllViews();
		int activeStageId = ((MassTournamentServerConnector)(object)this).GetActiveStageId();
		MassEventStageViewModel upcomingStage = _connector.GetUpcomingStage();
		if (upcomingStage != null)
		{
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2536;
			object obj2 = (nint)0 + (nint)3128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj2);
			_connector.GetTopPlayers(activeStageId, action);
		}
		else
		{
			InitializeWinners();
		}
	}

	private void InitializeLeaderboard(LeaderboardModel leaderboard)
	{
		//IL_0433: Expected O, but got I4
		//IL_002b: Expected I, but got O
		//IL_0034: Expected O, but got I4
		//IL_0065: Expected I, but got O
		//IL_006e: Expected O, but got I4
		//IL_00b2: Expected I, but got O
		//IL_0532: Expected I, but got O
		//IL_053a: Expected O, but got I4
		//IL_0136: Expected I, but got O
		//IL_013e: Expected O, but got I4
		//IL_0158: Expected O, but got I
		//IL_0164: Expected O, but got I
		//IL_01b2: Expected O, but got I4
		//IL_01b7: Expected I, but got O
		//IL_01f0: Expected O, but got I
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0209: Expected O, but got I4
		//IL_020e: Expected I, but got O
		//IL_041c: Expected O, but got I4
		//IL_0333: Expected O, but got I
		//IL_03c9: Expected O, but got I4
		//IL_039d: Expected O, but got I4
		//IL_02aa: Expected O, but got I
		//IL_0367: Expected I, but got O
		//IL_03f0: Expected O, but got I4
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_02ee: Expected O, but got I
		//IL_02f8: Expected I, but got O
		HideAllViews();
		bool flag = (object)leaderboardsPanel == null;
		LeaderboardModel leaderboardModel = leaderboard;
		LeaderboardModel leaderboardModel2;
		List<object>.Enumerator enumerator2;
		NullReferenceException ex;
		List<object>.Enumerator enumerator4;
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		if (!flag)
		{
			leaderboardsPanel.SetActive(value: true);
			bool flag2 = (object)_connector == null;
			nint num = unchecked((nint)null);
			leaderboardModel = (LeaderboardModel)1;
			if (!flag2)
			{
				int activeStageId = ((MassTournamentServerConnector)(object)leaderboardsPanel).GetActiveStageId();
				bool flag3 = leaderboard == null;
				num = unchecked((nint)null);
				leaderboardModel = (LeaderboardModel)1;
				if (!flag3)
				{
					bool flag4 = Enumerable.Any((IEnumerable<object>)leaderboard.<PlayersList>k__BackingField);
					GameObject gameObject = base.gameObject;
					bool flag5 = (object)gameObject == null;
					num = unchecked((nint)null);
					leaderboardModel = null;
					if (!flag5)
					{
						bool flag6 = activeStageId != 0 || flag4;
						gameObject.SetActive(flag6);
						bool flag7 = (object)placeholder == null;
						num = unchecked((nint)null);
						leaderboardModel = (LeaderboardModel)flag6;
						if (!flag7)
						{
							bool flag8 = (byte)((flag4 ? 1u : 0u) ^ 1u) != 0;
							placeholder.SetActive(flag8);
							bool flag9 = leaderboard.<PlayersList>k__BackingField == null;
							num = unchecked((nint)null);
							leaderboardModel = (LeaderboardModel)flag8;
							if (!flag9)
							{
								object obj = (nint)0 + (nint)3080;
								leaderboardModel2 = (LeaderboardModel)((nint)0 + (nint)3008);
								leaderboardModel = (LeaderboardModel)obj;
								List<object>.Enumerator enumerator = ((List<object>)(object)leaderboard.<PlayersList>k__BackingField).GetEnumerator();
								NormalPlaceItem[] array = topPlayers;
								bool flag10 = topPlayers == null;
								enumerator2 = enumerator3;
								enumerator4 = enumerator3;
								enumerator3 = (List<object>.Enumerator)0;
								num = unchecked((nint)null);
								if (flag10)
								{
									goto IL_0440;
								}
								if (array.Length < 1)
								{
									goto IL_036c;
								}
								object obj2 = (nint)0 + (nint)3016;
								object obj3 = topPlayers + 32;
								object obj4 = 0;
								num = unchecked((nint)null);
								LeaderBoardPlayer player = default(LeaderBoardPlayer);
								while (true)
								{
									leaderboardModel = (LeaderboardModel)obj2;
									if (enumerator2.MoveNext())
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X24_v5+v186 @ X22_v9*8]");
										if ((nint)0 == 0)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X24_v5+v186 @ X22_v9*8]");
										GameObject gameObject2 = ((Component)0).gameObject;
										if ((object)gameObject2 == null)
										{
											goto IL_03ce;
										}
										gameObject2.SetActive(value: true);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X24_v5+v186 @ X22_v9*8]");
										((NormalPlaceItem)0).Populate(player);
										num = unchecked((nint)null);
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X24_v5+v186 @ X22_v9*8]");
										if ((nint)0 == 0)
										{
											goto IL_03fa;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X24_v5+v186 @ X22_v9*8]");
										GameObject gameObject3 = ((Component)0).gameObject;
										if ((object)gameObject3 == null)
										{
											goto IL_037b;
										}
										gameObject3.SetActive(value: false);
										num = unchecked((nint)null);
									}
									obj4++;
									if ((nint)obj4 < array.Length)
									{
										continue;
									}
									goto IL_036c;
								}
								ex = new NullReferenceException();
								enumerator2 = enumerator3;
								enumerator4 = enumerator3;
								enumerator3 = (List<object>.Enumerator)0;
								goto IL_0454;
							}
						}
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		enumerator2 = (List<object>.Enumerator)0;
		leaderboardModel2 = leaderboard;
		goto IL_0440;
		IL_036c:
		enumerator2.Dispose();
		return;
		IL_03ce:
		ex = new NullReferenceException();
		enumerator2 = enumerator3;
		enumerator4 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		leaderboardModel = null;
		goto IL_0454;
		IL_03fa:
		ex = new NullReferenceException();
		enumerator2 = enumerator3;
		enumerator4 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		goto IL_0454;
		IL_0440:
		ex = new NullReferenceException();
		goto IL_0454;
		IL_0454:
		bool flag11 = (nint)leaderboardModel != 1;
		NullReferenceException ex3 = ex;
		if (!flag11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			leaderboardModel = leaderboardModel2;
			enumerator2.Dispose();
			object obj5 = default(object);
			if (obj5 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			enumerator3 = (List<object>.Enumerator)obj5;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22372D4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_037b:
		ex = new NullReferenceException();
		enumerator2 = enumerator3;
		enumerator4 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		leaderboardModel = null;
		goto IL_0454;
	}

	private void InitializeWinners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_0096: Expected I, but got O
		//IL_005d: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2408;
		object obj2 = (nint)0 + (nint)272;
		object obj3 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2392;
		object obj4 = (nint)0 + (nint)3120;
		GameObject lifecycle = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFS.TournamentError tournamentError = default(SFS.TournamentError);
		tournamentError..ctor(null, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFS.MassWinnersListSuccess massWinnersListSuccess = default(SFS.MassWinnersListSuccess);
		massWinnersListSuccess..ctor(this, (IntPtr)obj4);
		SFS.GetMassWinnersList(lifecycle, tournamentError, massWinnersListSuccess);
	}

	private void HideAllViews()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0056: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj2 = (nint)0 + (nint)1960;
		IEnumerable<GameObject> enumeration = panels;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		ArraysExtensions.ForEach(enumeration, action);
	}

	private void <InitializeWinners>b__9_0(List<MassEventWinner> winners)
	{
		HideAllViews();
		GameObject gameObject = massWinnersPanel.gameObject;
		MassEventStageViewModel upcomingStage = _connector.GetUpcomingStage();
		bool active = upcomingStage == null;
		gameObject.SetActive(active);
		MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)(object)gameObject).GetTournamentLiveData();
		MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
		massWinnersPanel.Populate(winners, cachedMassEvent.<Prizes>k__BackingField, cachedMassEvent.<Id>k__BackingField);
		if (Enumerable.Any((IEnumerable<object>)winners))
		{
			GameObject gameObject2 = base.gameObject;
			Transform transform = gameObject2.transform;
			transform.SetSiblingIndex(1);
		}
	}
}
