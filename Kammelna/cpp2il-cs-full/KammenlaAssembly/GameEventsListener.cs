using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;

public class GameEventsListener : MonoBehaviour
{
	private GameEventsChannel channel;

	private UnityEvent ShowUi;

	private UnityEvent HideUi;

	private UnityEvent ExitGame;

	private UnityEvent PanelShow;

	private UnityEvent<KPlayer> PlayerClicked;

	private UnityEvent<string> WatcherClicked;

	private UnityEvent ShowDismissibleBlocker;

	private UnityEvent HideDismissibleBlocker;

	private UnityEvent<GameCard> DismissibleClicked;

	private UnityEvent CloseEndRoundPopup;

	private UnityEvent CloseEndGamePopup;

	private UnityEvent CloseQuickReplies;

	private UnityEvent CloseSawaPanel;

	private UnityEvent ShowQuickRepliesForSubscribersMessage;

	private UnityEvent ShowForfeitWarning;

	private UnityEvent ShowChat;

	private UnityEvent ShowMiniChat;

	private UnityEvent ToggleCatchPanel;

	private UnityEvent ToggleProjectsPanel;

	private UnityEvent ToggleSawaPanel;

	private UnityEvent ToggleTeamsDetails;

	private UnityEvent ShakeProjectsButton;

	private UnityEvent ShowGiftPanel;

	private UnityEvent ShowGiftSelection;

	private UnityEvent HideGiftSelection;

	private UnityEvent<GiftUIElement> GiftClicked;

	private UnityEvent<bool> GiftSelected;

	private UnityEvent<KPlayer> PlayerGiftClicked;

	private UnityEvent<Card> TutorialCardPreventedToPlay;

	private UnityEvent ShowOfflineUi;

	private UnityEvent BecomingWatcher;

	private UnityEvent BecomingPlayer;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_1806: Expected I, but got O
		//IL_1817: Expected O, but got I
		//IL_1823: Expected O, but got I
		//IL_1832: Unknown result type (might be due to invalid IL or missing references)
		//IL_1837: Expected O, but got Unknown
		//IL_1846: Unknown result type (might be due to invalid IL or missing references)
		//IL_184b: Expected O, but got Unknown
		//IL_185a: Unknown result type (might be due to invalid IL or missing references)
		//IL_185f: Expected O, but got Unknown
		//IL_186a: Unknown result type (might be due to invalid IL or missing references)
		//IL_186f: Expected O, but got Unknown
		//IL_00bf: Expected I, but got O
		//IL_1887: Unknown result type (might be due to invalid IL or missing references)
		//IL_188c: Expected O, but got Unknown
		//IL_015e: Expected I, but got O
		//IL_18a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a9: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I
		//IL_0209: Expected I, but got O
		//IL_18c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c6: Expected O, but got Unknown
		//IL_021c: Expected O, but got I4
		//IL_027b: Expected O, but got I4
		//IL_02ba: Expected O, but got I
		//IL_02c8: Expected I, but got O
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_029a: Expected O, but got I4
		//IL_190c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1911: Expected O, but got Unknown
		//IL_0379: Expected O, but got I
		//IL_0387: Expected I, but got O
		//IL_1929: Unknown result type (might be due to invalid IL or missing references)
		//IL_192e: Expected O, but got Unknown
		//IL_039a: Expected O, but got I4
		//IL_03f9: Expected O, but got I4
		//IL_0438: Expected O, but got I
		//IL_0446: Expected I, but got O
		//IL_0418: Expected O, but got I4
		//IL_1974: Unknown result type (might be due to invalid IL or missing references)
		//IL_1979: Expected O, but got Unknown
		//IL_0459: Expected O, but got I4
		//IL_04b8: Expected O, but got I4
		//IL_04f7: Expected O, but got I
		//IL_0505: Expected I, but got O
		//IL_04d7: Expected O, but got I4
		//IL_19bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c4: Expected O, but got Unknown
		//IL_05a2: Expected O, but got I
		//IL_05b0: Expected I, but got O
		//IL_19dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e1: Expected O, but got Unknown
		//IL_064d: Expected O, but got I
		//IL_065b: Expected I, but got O
		//IL_19f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fe: Expected O, but got Unknown
		//IL_1a44: Expected O, but got I4
		//IL_06c9: Expected O, but got I4
		//IL_06d2: Expected O, but got I4
		//IL_071e: Expected O, but got I
		//IL_072c: Expected I, but got O
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected O, but got Unknown
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected O, but got Unknown
		//IL_1a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6a: Expected O, but got Unknown
		//IL_07f1: Expected O, but got I
		//IL_07ff: Expected I, but got O
		//IL_1a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a87: Expected O, but got Unknown
		//IL_089c: Expected O, but got I
		//IL_08aa: Expected I, but got O
		//IL_1a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa4: Expected O, but got Unknown
		//IL_0947: Expected O, but got I
		//IL_0955: Expected I, but got O
		//IL_1abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac1: Expected O, but got Unknown
		//IL_09f2: Expected O, but got I
		//IL_0a00: Expected I, but got O
		//IL_1ad9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ade: Expected O, but got Unknown
		//IL_0a9d: Expected O, but got I
		//IL_0aab: Expected I, but got O
		//IL_1af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afb: Expected O, but got Unknown
		//IL_0b48: Expected O, but got I
		//IL_0b56: Expected I, but got O
		//IL_1b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b18: Expected O, but got Unknown
		//IL_0bf3: Expected O, but got I
		//IL_0c01: Expected I, but got O
		//IL_1b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b35: Expected O, but got Unknown
		//IL_0c9e: Expected O, but got I
		//IL_0cac: Expected I, but got O
		//IL_1b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b52: Expected O, but got Unknown
		//IL_0d49: Expected O, but got I
		//IL_0d57: Expected I, but got O
		//IL_1b6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6f: Expected O, but got Unknown
		//IL_0df4: Expected O, but got I
		//IL_0e02: Expected I, but got O
		//IL_1b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8c: Expected O, but got Unknown
		//IL_0e9f: Expected O, but got I
		//IL_0ead: Expected I, but got O
		//IL_1ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba9: Expected O, but got Unknown
		//IL_0f4a: Expected O, but got I
		//IL_0f58: Expected I, but got O
		//IL_1bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc6: Expected O, but got Unknown
		//IL_0fff: Expected O, but got I
		//IL_100d: Expected I, but got O
		//IL_1020: Unknown result type (might be due to invalid IL or missing references)
		//IL_1025: Expected O, but got Unknown
		//IL_10c2: Expected O, but got I
		//IL_10d0: Expected I, but got O
		//IL_10e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e8: Expected O, but got Unknown
		//IL_1185: Expected O, but got I
		//IL_1193: Expected I, but got O
		//IL_11a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ab: Expected O, but got Unknown
		//IL_1241: Unknown result type (might be due to invalid IL or missing references)
		//IL_1246: Expected O, but got Unknown
		//IL_125c: Expected O, but got I
		//IL_126a: Expected I, but got O
		//IL_127f: Expected O, but got I
		//IL_128d: Expected O, but got I4
		//IL_1c24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c29: Expected O, but got Unknown
		//IL_12cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d4: Expected O, but got Unknown
		//IL_1300: Expected O, but got I4
		//IL_1349: Expected O, but got I
		//IL_1357: Expected I, but got O
		//IL_131f: Expected O, but got I4
		//IL_136a: Expected O, but got I4
		//IL_1c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c77: Expected O, but got Unknown
		//IL_13c9: Expected O, but got I4
		//IL_1412: Expected O, but got I
		//IL_1420: Expected I, but got O
		//IL_13e8: Expected O, but got I4
		//IL_1433: Expected O, but got I4
		//IL_1cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc5: Expected O, but got Unknown
		//IL_1492: Expected O, but got I4
		//IL_14db: Expected O, but got I
		//IL_14e9: Expected I, but got O
		//IL_14b1: Expected O, but got I4
		//IL_1d0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d13: Expected O, but got Unknown
		//IL_1d44: Expected O, but got I4
		//IL_155f: Expected O, but got I4
		//IL_1568: Expected O, but got I4
		//IL_15be: Expected O, but got I
		//IL_15cc: Expected I, but got O
		//IL_15df: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e4: Expected O, but got Unknown
		//IL_1681: Expected O, but got I
		//IL_168f: Expected I, but got O
		//IL_16a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a7: Expected O, but got Unknown
		//IL_1744: Expected O, but got I
		//IL_1752: Expected I, but got O
		//IL_1765: Unknown result type (might be due to invalid IL or missing references)
		//IL_176a: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		Delegate obj3 = (Delegate)((nint)0 + (nint)320);
		Delegate obj4 = (Delegate)((nint)0 + (nint)280);
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2552;
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2064;
		object obj8 = channel + 24;
		Delegate obj9 = (Delegate)obj8;
		Delegate obj11 = default(Delegate);
		Action action2 = default(Action);
		Delegate obj15 = default(Delegate);
		Action action3 = default(Action);
		Delegate obj19 = default(Delegate);
		Action<System.Int32Enum> action4 = default(Action<System.Int32Enum>);
		object obj25 = default(object);
		Delegate obj29 = default(Delegate);
		Action action5 = default(Action);
		Delegate obj34 = default(Delegate);
		Action action6 = default(Action);
		Delegate obj39 = default(Delegate);
		Action<object> action7 = default(Action<object>);
		object obj46 = default(object);
		Delegate obj48 = default(Delegate);
		Action action8 = default(Action);
		Delegate obj55 = default(Delegate);
		Action action9 = default(Action);
		Delegate obj60 = default(Delegate);
		Action action10 = default(Action);
		Delegate obj65 = default(Delegate);
		Action action11 = default(Action);
		Delegate obj70 = default(Delegate);
		Action action12 = default(Action);
		Delegate obj75 = default(Delegate);
		Action action13 = default(Action);
		Delegate obj80 = default(Delegate);
		Action action14 = default(Action);
		Delegate obj85 = default(Delegate);
		Action action15 = default(Action);
		Delegate obj90 = default(Delegate);
		Action action16 = default(Action);
		Delegate obj95 = default(Delegate);
		Action action17 = default(Action);
		Delegate obj100 = default(Delegate);
		Action action18 = default(Action);
		Delegate obj105 = default(Delegate);
		Action action19 = default(Action);
		Delegate obj110 = default(Delegate);
		Action action20 = default(Action);
		Delegate obj115 = default(Delegate);
		Action action21 = default(Action);
		Delegate obj120 = default(Delegate);
		Action action22 = default(Action);
		Delegate obj125 = default(Delegate);
		Action action23 = default(Action);
		Delegate obj130 = default(Delegate);
		Action<object> action24 = default(Action<object>);
		object obj137 = default(object);
		Delegate obj142 = default(Delegate);
		Action<bool> action25 = default(Action<bool>);
		object obj147 = default(object);
		Delegate obj150 = default(Delegate);
		Action<object> action26 = default(Action<object>);
		object obj155 = default(object);
		Delegate obj158 = default(Delegate);
		Action<object> action27 = default(Action<object>);
		GameEventsChannel gameEventsChannel10 = default(GameEventsChannel);
		Delegate obj164 = default(Delegate);
		Action action28 = default(Action);
		Delegate obj169 = default(Delegate);
		Action action29 = default(Action);
		Delegate obj174 = default(Delegate);
		Action action30 = default(Action);
		Delegate obj179 = default(Delegate);
		Action<object> action31 = default(Action<object>);
		Delegate obj185 = default(Delegate);
		Delegate obj187 = default(Delegate);
		Action action32 = default(Action);
		Delegate obj192 = default(Delegate);
		Action<object> action33 = default(Action<object>);
		object obj198 = default(object);
		Delegate obj200 = default(Delegate);
		while (true)
		{
			Delegate obj10 = Delegate.Combine(obj9, action);
			if ((object)obj10 == null || obj10 == obj)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag = (object)obj11 == obj9;
				obj9 = obj11;
				if (!flag)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action2..ctor(this, (IntPtr)obj3);
				object obj12 = channel + 32;
				Delegate obj13 = (Delegate)obj12;
				while (true)
				{
					Delegate obj14 = Delegate.Combine(obj13, action2);
					if ((object)obj14 != null && obj14 != obj)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					bool flag2 = (object)obj15 == obj13;
					obj13 = obj15;
					if (!flag2)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					action3..ctor(this, (IntPtr)obj4);
					object obj16 = channel + 40;
					Delegate obj17 = (Delegate)obj16;
					while (true)
					{
						Delegate obj18 = Delegate.Combine(obj17, action3);
						if ((object)obj18 != null && obj18 != obj)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
						bool flag3 = (object)obj19 == obj17;
						obj17 = obj19;
						if (!flag3)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj20 = (nint)0 + (nint)328;
						action4..ctor((object)this, (IntPtr)obj20);
						object obj21 = channel + 48;
						Delegate obj22 = (Delegate)obj21;
						while (true)
						{
							Delegate obj23 = Delegate.Combine(obj22, action4);
							object obj27;
							Delegate obj28;
							if ((object)obj23 == null)
							{
								object obj24 = 0;
							}
							else
							{
								obj3 = (Delegate)obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag4 = obj25 == null;
								object obj26 = !flag4;
								object obj24 = obj25;
								if (obj26 == null)
								{
									obj27 = 0;
									obj28 = null;
									goto IL_06f5;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
							bool flag5 = (object)obj29 == obj22;
							obj22 = obj29;
							if (!flag5)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj30 = (nint)0 + (nint)336;
							action5..ctor(this, (IntPtr)obj30);
							obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2496;
							object obj31 = channel + 56;
							Delegate obj32 = (Delegate)obj31;
							while (true)
							{
								Delegate obj33 = Delegate.Combine(obj32, action5);
								if ((object)obj33 == null || obj33 == obj)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
									bool flag6 = (object)obj34 == obj32;
									obj32 = obj34;
									if (!flag6)
									{
										continue;
									}
									goto IL_0363;
								}
								break;
							}
							break;
							IL_058c:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj35 = (nint)0 + (nint)304;
							action6..ctor(this, (IntPtr)obj35);
							object obj36 = channel + 96;
							Delegate obj37 = (Delegate)obj36;
							while (true)
							{
								Delegate obj38 = Delegate.Combine(obj37, action6);
								if ((object)obj38 == null || obj38 == obj)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
									bool flag7 = (object)obj39 == obj37;
									obj37 = obj39;
									if (!flag7)
									{
										continue;
									}
									goto IL_0637;
								}
								break;
							}
							break;
							IL_06f5:
							Delegate obj40 = obj3;
							throw new InvalidCastException();
							IL_0422:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj41 = (nint)0 + (nint)480;
							action7..ctor((object)this, (IntPtr)obj41);
							object obj42 = channel + 80;
							Delegate obj43 = (Delegate)obj42;
							while (true)
							{
								Delegate obj44 = Delegate.Combine(obj43, action7);
								if ((object)obj44 == null)
								{
									object obj45 = 0;
								}
								else
								{
									obj3 = (Delegate)obj6;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag8 = obj46 == null;
									object obj47 = !flag8;
									object obj45 = obj46;
									if (obj47 == null)
									{
										break;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
								bool flag9 = (object)obj48 == obj43;
								obj43 = obj48;
								if (!flag9)
								{
									continue;
								}
								goto IL_04e1;
							}
							obj27 = 0;
							obj28 = null;
							goto IL_06f5;
							IL_0708:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj49 = (nint)0 + (nint)248;
							action8..ctor(this, (IntPtr)obj49);
							object obj50 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1368;
							object obj51 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
							object obj52 = channel + 128;
							Delegate obj53 = (Delegate)obj52;
							while (true)
							{
								Delegate obj54 = Delegate.Combine(obj53, action8);
								if ((object)obj54 != null && obj54 != obj)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
								bool flag10 = (object)obj55 == obj53;
								obj53 = obj55;
								if (!flag10)
								{
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj56 = (nint)0 + (nint)240;
								action9..ctor(this, (IntPtr)obj56);
								object obj57 = channel + 136;
								Delegate obj58 = (Delegate)obj57;
								while (true)
								{
									Delegate obj59 = Delegate.Combine(obj58, action9);
									if ((object)obj59 != null && obj59 != obj)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
									bool flag11 = (object)obj60 == obj58;
									obj58 = obj60;
									if (!flag11)
									{
										continue;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj61 = (nint)0 + (nint)256;
									action10..ctor(this, (IntPtr)obj61);
									object obj62 = channel + 144;
									Delegate obj63 = (Delegate)obj62;
									while (true)
									{
										Delegate obj64 = Delegate.Combine(obj63, action10);
										if ((object)obj64 != null && obj64 != obj)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
										bool flag12 = (object)obj65 == obj63;
										obj63 = obj65;
										if (!flag12)
										{
											continue;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										object obj66 = (nint)0 + (nint)264;
										action11..ctor(this, (IntPtr)obj66);
										object obj67 = channel + 152;
										Delegate obj68 = (Delegate)obj67;
										while (true)
										{
											Delegate obj69 = Delegate.Combine(obj68, action11);
											if ((object)obj69 != null && obj69 != obj)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
											bool flag13 = (object)obj70 == obj68;
											obj68 = obj70;
											if (!flag13)
											{
												continue;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											object obj71 = (nint)0 + (nint)424;
											action12..ctor(this, (IntPtr)obj71);
											object obj72 = channel + 160;
											Delegate obj73 = (Delegate)obj72;
											while (true)
											{
												Delegate obj74 = Delegate.Combine(obj73, action12);
												if ((object)obj74 != null && obj74 != obj)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
												bool flag14 = (object)obj75 == obj73;
												obj73 = obj75;
												if (!flag14)
												{
													continue;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												object obj76 = (nint)0 + (nint)384;
												action13..ctor(this, (IntPtr)obj76);
												object obj77 = channel + 168;
												Delegate obj78 = (Delegate)obj77;
												while (true)
												{
													Delegate obj79 = Delegate.Combine(obj78, action13);
													if ((object)obj79 != null && obj79 != obj)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
													bool flag15 = (object)obj80 == obj78;
													obj78 = obj80;
													if (!flag15)
													{
														continue;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
													object obj81 = (nint)0 + (nint)368;
													action14..ctor(this, (IntPtr)obj81);
													object obj82 = channel + 176;
													Delegate obj83 = (Delegate)obj82;
													while (true)
													{
														Delegate obj84 = Delegate.Combine(obj83, action14);
														if ((object)obj84 != null && obj84 != obj)
														{
															break;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
														bool flag16 = (object)obj85 == obj83;
														obj83 = obj85;
														if (!flag16)
														{
															continue;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
														object obj86 = (nint)0 + (nint)408;
														action15..ctor(this, (IntPtr)obj86);
														object obj87 = channel + 184;
														Delegate obj88 = (Delegate)obj87;
														while (true)
														{
															Delegate obj89 = Delegate.Combine(obj88, action15);
															if ((object)obj89 != null && obj89 != obj)
															{
																break;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
															bool flag17 = (object)obj90 == obj88;
															obj88 = obj90;
															if (!flag17)
															{
																continue;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
															object obj91 = (nint)0 + (nint)440;
															action16..ctor(this, (IntPtr)obj91);
															object obj92 = channel + 192;
															Delegate obj93 = (Delegate)obj92;
															while (true)
															{
																Delegate obj94 = Delegate.Combine(obj93, action16);
																if ((object)obj94 != null && obj94 != obj)
																{
																	break;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																bool flag18 = (object)obj95 == obj93;
																obj93 = obj95;
																if (!flag18)
																{
																	continue;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																object obj96 = (nint)0 + (nint)448;
																action17..ctor(this, (IntPtr)obj96);
																object obj97 = channel + 200;
																Delegate obj98 = (Delegate)obj97;
																while (true)
																{
																	Delegate obj99 = Delegate.Combine(obj98, action17);
																	if ((object)obj99 != null && obj99 != obj)
																	{
																		break;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																	bool flag19 = (object)obj100 == obj98;
																	obj98 = obj100;
																	if (!flag19)
																	{
																		continue;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																	object obj101 = (nint)0 + (nint)456;
																	action18..ctor(this, (IntPtr)obj101);
																	object obj102 = channel + 208;
																	Delegate obj103 = (Delegate)obj102;
																	while (true)
																	{
																		Delegate obj104 = Delegate.Combine(obj103, action18);
																		if ((object)obj104 != null && obj104 != obj)
																		{
																			break;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																		bool flag20 = (object)obj105 == obj103;
																		obj103 = obj105;
																		if (!flag20)
																		{
																			continue;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																		object obj106 = (nint)0 + (nint)464;
																		action19..ctor(this, (IntPtr)obj106);
																		object obj107 = channel + 216;
																		Delegate obj108 = (Delegate)obj107;
																		while (true)
																		{
																			Delegate obj109 = Delegate.Combine(obj108, action19);
																			if ((object)obj109 != null && obj109 != obj)
																			{
																				break;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																			bool flag21 = (object)obj110 == obj108;
																			obj108 = obj110;
																			if (!flag21)
																			{
																				continue;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																			object obj111 = (nint)0 + (nint)360;
																			action20..ctor(this, (IntPtr)obj111);
																			object obj112 = channel + 224;
																			Delegate obj113 = (Delegate)obj112;
																			while (true)
																			{
																				Delegate obj114 = Delegate.Combine(obj113, action20);
																				if ((object)obj114 != null && obj114 != obj)
																				{
																					break;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																				bool flag22 = (object)obj115 == obj113;
																				obj113 = obj115;
																				if (!flag22)
																				{
																					continue;
																				}
																				GameEventsChannel gameEventsChannel = channel;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																				object obj116 = (nint)0 + (nint)392;
																				action21..ctor(this, (IntPtr)obj116);
																				Delegate obj117 = gameEventsChannel.ShowGiftPanel;
																				while (true)
																				{
																					Delegate obj118 = Delegate.Combine(obj117, action21);
																					if ((object)obj118 != null && obj118 != obj)
																					{
																						break;
																					}
																					object obj119 = gameEventsChannel + 288;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																					bool flag23 = (object)obj120 == obj117;
																					obj117 = obj120;
																					if (!flag23)
																					{
																						continue;
																					}
																					GameEventsChannel gameEventsChannel2 = channel;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																					object obj121 = (nint)0 + (nint)400;
																					action22..ctor(this, (IntPtr)obj121);
																					Delegate obj122 = gameEventsChannel2.ShowGiftSelection;
																					while (true)
																					{
																						Delegate obj123 = Delegate.Combine(obj122, action22);
																						if ((object)obj123 != null && obj123 != obj)
																						{
																							break;
																						}
																						object obj124 = gameEventsChannel2 + 304;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																						bool flag24 = (object)obj125 == obj122;
																						obj122 = obj125;
																						if (!flag24)
																						{
																							continue;
																						}
																						GameEventsChannel gameEventsChannel3 = channel;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																						object obj126 = (nint)0 + (nint)312;
																						action23..ctor(this, (IntPtr)obj126);
																						Delegate obj127 = gameEventsChannel3.HideGiftSelection;
																						while (true)
																						{
																							Delegate obj128 = Delegate.Combine(obj127, action23);
																							if ((object)obj128 != null && obj128 != obj)
																							{
																								break;
																							}
																							object obj129 = gameEventsChannel3 + 312;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																							bool flag25 = (object)obj130 == obj127;
																							obj127 = obj130;
																							if (!flag25)
																							{
																								continue;
																							}
																							GameEventsChannel gameEventsChannel4 = channel;
																							object obj131 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2152;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																							object obj132 = (nint)0 + (nint)288;
																							action24..ctor((object)this, (IntPtr)obj132);
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E752D]");
																							object obj133 = 0;
																							Delegate obj134 = gameEventsChannel4.OnGiftClicked;
																							while (true)
																							{
																								Delegate obj135 = Delegate.Combine(obj134, action24);
																								object obj139;
																								Delegate obj140;
																								if ((object)obj135 == null)
																								{
																									object obj136 = 0;
																								}
																								else
																								{
																									obj133 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2152;
																									gameEventsChannel3 = (GameEventsChannel)obj133;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																									bool flag26 = obj137 == null;
																									object obj138 = !flag26;
																									object obj136 = obj137;
																									if (obj138 == null)
																									{
																										obj139 = 0;
																										obj140 = null;
																										goto IL_158b;
																									}
																								}
																								object obj141 = gameEventsChannel4 + 368;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																								bool flag27 = (object)obj142 == obj134;
																								obj134 = obj142;
																								if (!flag27)
																								{
																									continue;
																								}
																								GameEventsChannel gameEventsChannel5 = channel;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																								object obj143 = (nint)0 + (nint)296;
																								action25..ctor((object)this, (IntPtr)obj143);
																								Delegate obj144 = gameEventsChannel5.OnGiftSelected;
																								while (true)
																								{
																									Delegate obj145 = Delegate.Combine(obj144, action25);
																									if ((object)obj145 == null)
																									{
																										object obj146 = 0;
																									}
																									else
																									{
																										gameEventsChannel3 = (GameEventsChannel)obj51;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																										bool flag28 = obj147 == null;
																										object obj148 = !flag28;
																										object obj146 = obj147;
																										if (obj148 == null)
																										{
																											break;
																										}
																									}
																									object obj149 = gameEventsChannel5 + 376;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																									bool flag29 = (object)obj150 == obj144;
																									obj144 = obj150;
																									if (!flag29)
																									{
																										continue;
																									}
																									goto IL_13f2;
																								}
																								obj139 = 0;
																								obj140 = null;
																								goto IL_158b;
																								IL_13f2:
																								GameEventsChannel gameEventsChannel6 = channel;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																								object obj151 = (nint)0 + (nint)352;
																								action26..ctor((object)this, (IntPtr)obj151);
																								Delegate obj152 = gameEventsChannel6.OnPlayerGiftClicked;
																								while (true)
																								{
																									Delegate obj153 = Delegate.Combine(obj152, action26);
																									if ((object)obj153 == null)
																									{
																										object obj154 = 0;
																									}
																									else
																									{
																										gameEventsChannel3 = (GameEventsChannel)obj5;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																										bool flag30 = obj155 == null;
																										object obj156 = !flag30;
																										object obj154 = obj155;
																										if (obj156 == null)
																										{
																											break;
																										}
																									}
																									object obj157 = gameEventsChannel6 + 392;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																									bool flag31 = (object)obj158 == obj152;
																									obj152 = obj158;
																									if (!flag31)
																									{
																										continue;
																									}
																									goto IL_14bb;
																								}
																								obj139 = 0;
																								obj140 = null;
																								goto IL_158b;
																								IL_158b:
																								GameEventsChannel gameEventsChannel7 = gameEventsChannel3;
																								throw new InvalidCastException();
																								IL_14bb:
																								GameEventsChannel gameEventsChannel8 = channel;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																								object obj159 = (nint)0 + (nint)472;
																								action27..ctor((object)this, (IntPtr)obj159);
																								Delegate obj160 = gameEventsChannel8.OnTutorialCardPreventedToPlay;
																								while (true)
																								{
																									Delegate obj161 = Delegate.Combine(obj160, action27);
																									GameEventsChannel gameEventsChannel9;
																									if ((object)obj161 == null)
																									{
																										gameEventsChannel7 = null;
																										gameEventsChannel9 = gameEventsChannel3;
																									}
																									else
																									{
																										gameEventsChannel3 = (GameEventsChannel)obj50;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																										bool flag32 = (object)gameEventsChannel10 == null;
																										object obj162 = !flag32;
																										obj139 = 0;
																										obj140 = null;
																										gameEventsChannel7 = gameEventsChannel10;
																										gameEventsChannel9 = (GameEventsChannel)obj50;
																										if (obj162 == null)
																										{
																											break;
																										}
																									}
																									object obj163 = gameEventsChannel8 + 400;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																									bool flag33 = (object)obj164 == obj160;
																									obj160 = obj164;
																									gameEventsChannel3 = gameEventsChannel9;
																									obj139 = 0;
																									obj140 = obj164;
																									if (flag33)
																									{
																										goto end_IL_1292;
																									}
																								}
																								goto IL_158b;
																								continue;
																								end_IL_1292:
																								break;
																							}
																							GameEventsChannel gameEventsChannel11 = channel;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																							object obj165 = (nint)0 + (nint)416;
																							action28..ctor(this, (IntPtr)obj165);
																							Delegate obj166 = gameEventsChannel11.ShowOfflineUi;
																							while (true)
																							{
																								Delegate obj167 = Delegate.Combine(obj166, action28);
																								if ((object)obj167 != null && obj167 != obj)
																								{
																									break;
																								}
																								object obj168 = gameEventsChannel11 + 408;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																								bool flag34 = (object)obj169 == obj166;
																								obj166 = obj169;
																								if (!flag34)
																								{
																									continue;
																								}
																								GameEventsChannel gameEventsChannel12 = channel;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																								object obj170 = (nint)0 + (nint)232;
																								action29..ctor(this, (IntPtr)obj170);
																								Delegate obj171 = gameEventsChannel12.OnBecomingWatcher;
																								while (true)
																								{
																									Delegate obj172 = Delegate.Combine(obj171, action29);
																									if ((object)obj172 != null && obj172 != obj)
																									{
																										break;
																									}
																									object obj173 = gameEventsChannel12 + 416;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																									bool flag35 = (object)obj174 == obj171;
																									obj171 = obj174;
																									if (!flag35)
																									{
																										continue;
																									}
																									GameEventsChannel gameEventsChannel13 = channel;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																									object obj175 = (nint)0 + (nint)224;
																									action30..ctor(this, (IntPtr)obj175);
																									Delegate obj176 = gameEventsChannel13.OnBecomingPlayer;
																									while (true)
																									{
																										Delegate obj177 = Delegate.Combine(obj176, action30);
																										if ((object)obj177 == null || obj177 == obj)
																										{
																											object obj178 = gameEventsChannel13 + 424;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																											bool flag36 = (object)obj179 == obj176;
																											obj176 = obj179;
																											if (!flag36)
																											{
																												continue;
																											}
																											return;
																										}
																										break;
																									}
																									break;
																								}
																								break;
																							}
																							break;
																						}
																						break;
																					}
																					break;
																				}
																				break;
																			}
																			break;
																		}
																		break;
																	}
																	break;
																}
																break;
															}
															break;
														}
														break;
													}
													break;
												}
												break;
											}
											break;
										}
										break;
									}
									break;
								}
								break;
							}
							break;
							IL_0637:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj180 = (nint)0 + (nint)272;
							action31..ctor((object)this, (IntPtr)obj180);
							object obj181 = channel + 104;
							Delegate obj182 = (Delegate)obj181;
							Delegate obj183 = obj3;
							while (true)
							{
								Delegate obj184 = Delegate.Combine(obj182, action31);
								if ((object)obj184 == null)
								{
									obj40 = null;
								}
								else
								{
									obj3 = (Delegate)obj7;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag37 = (object)obj185 == null;
									object obj186 = !flag37;
									obj27 = 0;
									obj28 = null;
									obj183 = (Delegate)obj7;
									obj40 = obj185;
									if (obj186 == null)
									{
										break;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
								bool flag38 = (object)obj187 == obj182;
								obj182 = obj187;
								obj3 = obj183;
								obj27 = 0;
								obj28 = obj187;
								if (!flag38)
								{
									continue;
								}
								goto IL_0708;
							}
							goto IL_06f5;
							IL_04e1:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj188 = (nint)0 + (nint)376;
							action32..ctor(this, (IntPtr)obj188);
							object obj189 = channel + 88;
							Delegate obj190 = (Delegate)obj189;
							while (true)
							{
								Delegate obj191 = Delegate.Combine(obj190, action32);
								if ((object)obj191 == null || obj191 == obj)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
									bool flag39 = (object)obj192 == obj190;
									obj190 = obj192;
									if (!flag39)
									{
										continue;
									}
									goto IL_058c;
								}
								break;
							}
							break;
							IL_0363:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj193 = (nint)0 + (nint)344;
							action33..ctor((object)this, (IntPtr)obj193);
							object obj194 = channel + 72;
							Delegate obj195 = (Delegate)obj194;
							while (true)
							{
								Delegate obj196 = Delegate.Combine(obj195, action33);
								if ((object)obj196 == null)
								{
									object obj197 = 0;
								}
								else
								{
									obj3 = (Delegate)obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag40 = obj198 == null;
									object obj199 = !flag40;
									object obj197 = obj198;
									if (obj199 == null)
									{
										break;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
								bool flag41 = (object)obj200 == obj195;
								obj195 = obj200;
								if (!flag41)
								{
									continue;
								}
								goto IL_0422;
							}
							obj27 = 0;
							obj28 = null;
							goto IL_06f5;
						}
						break;
					}
					break;
				}
			}
			throw new InvalidCastException();
		}
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_1806: Expected I, but got O
		//IL_1817: Expected O, but got I
		//IL_1823: Expected O, but got I
		//IL_1832: Unknown result type (might be due to invalid IL or missing references)
		//IL_1837: Expected O, but got Unknown
		//IL_1846: Unknown result type (might be due to invalid IL or missing references)
		//IL_184b: Expected O, but got Unknown
		//IL_185a: Unknown result type (might be due to invalid IL or missing references)
		//IL_185f: Expected O, but got Unknown
		//IL_186a: Unknown result type (might be due to invalid IL or missing references)
		//IL_186f: Expected O, but got Unknown
		//IL_00bf: Expected I, but got O
		//IL_1887: Unknown result type (might be due to invalid IL or missing references)
		//IL_188c: Expected O, but got Unknown
		//IL_015e: Expected I, but got O
		//IL_18a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a9: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I
		//IL_0209: Expected I, but got O
		//IL_18c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c6: Expected O, but got Unknown
		//IL_021c: Expected O, but got I4
		//IL_027b: Expected O, but got I4
		//IL_02ba: Expected O, but got I
		//IL_02c8: Expected I, but got O
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_029a: Expected O, but got I4
		//IL_190c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1911: Expected O, but got Unknown
		//IL_0379: Expected O, but got I
		//IL_0387: Expected I, but got O
		//IL_1929: Unknown result type (might be due to invalid IL or missing references)
		//IL_192e: Expected O, but got Unknown
		//IL_039a: Expected O, but got I4
		//IL_03f9: Expected O, but got I4
		//IL_0438: Expected O, but got I
		//IL_0446: Expected I, but got O
		//IL_0418: Expected O, but got I4
		//IL_1974: Unknown result type (might be due to invalid IL or missing references)
		//IL_1979: Expected O, but got Unknown
		//IL_0459: Expected O, but got I4
		//IL_04b8: Expected O, but got I4
		//IL_04f7: Expected O, but got I
		//IL_0505: Expected I, but got O
		//IL_04d7: Expected O, but got I4
		//IL_19bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c4: Expected O, but got Unknown
		//IL_05a2: Expected O, but got I
		//IL_05b0: Expected I, but got O
		//IL_19dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e1: Expected O, but got Unknown
		//IL_064d: Expected O, but got I
		//IL_065b: Expected I, but got O
		//IL_19f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fe: Expected O, but got Unknown
		//IL_1a44: Expected O, but got I4
		//IL_06c9: Expected O, but got I4
		//IL_06d2: Expected O, but got I4
		//IL_071e: Expected O, but got I
		//IL_072c: Expected I, but got O
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected O, but got Unknown
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected O, but got Unknown
		//IL_1a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6a: Expected O, but got Unknown
		//IL_07f1: Expected O, but got I
		//IL_07ff: Expected I, but got O
		//IL_1a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a87: Expected O, but got Unknown
		//IL_089c: Expected O, but got I
		//IL_08aa: Expected I, but got O
		//IL_1a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa4: Expected O, but got Unknown
		//IL_0947: Expected O, but got I
		//IL_0955: Expected I, but got O
		//IL_1abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac1: Expected O, but got Unknown
		//IL_09f2: Expected O, but got I
		//IL_0a00: Expected I, but got O
		//IL_1ad9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ade: Expected O, but got Unknown
		//IL_0a9d: Expected O, but got I
		//IL_0aab: Expected I, but got O
		//IL_1af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afb: Expected O, but got Unknown
		//IL_0b48: Expected O, but got I
		//IL_0b56: Expected I, but got O
		//IL_1b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b18: Expected O, but got Unknown
		//IL_0bf3: Expected O, but got I
		//IL_0c01: Expected I, but got O
		//IL_1b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b35: Expected O, but got Unknown
		//IL_0c9e: Expected O, but got I
		//IL_0cac: Expected I, but got O
		//IL_1b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b52: Expected O, but got Unknown
		//IL_0d49: Expected O, but got I
		//IL_0d57: Expected I, but got O
		//IL_1b6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6f: Expected O, but got Unknown
		//IL_0df4: Expected O, but got I
		//IL_0e02: Expected I, but got O
		//IL_1b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8c: Expected O, but got Unknown
		//IL_0e9f: Expected O, but got I
		//IL_0ead: Expected I, but got O
		//IL_1ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba9: Expected O, but got Unknown
		//IL_0f4a: Expected O, but got I
		//IL_0f58: Expected I, but got O
		//IL_1bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc6: Expected O, but got Unknown
		//IL_0fff: Expected O, but got I
		//IL_100d: Expected I, but got O
		//IL_1020: Unknown result type (might be due to invalid IL or missing references)
		//IL_1025: Expected O, but got Unknown
		//IL_10c2: Expected O, but got I
		//IL_10d0: Expected I, but got O
		//IL_10e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e8: Expected O, but got Unknown
		//IL_1185: Expected O, but got I
		//IL_1193: Expected I, but got O
		//IL_11a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ab: Expected O, but got Unknown
		//IL_1241: Unknown result type (might be due to invalid IL or missing references)
		//IL_1246: Expected O, but got Unknown
		//IL_125c: Expected O, but got I
		//IL_126a: Expected I, but got O
		//IL_127f: Expected O, but got I
		//IL_128d: Expected O, but got I4
		//IL_1c24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c29: Expected O, but got Unknown
		//IL_12cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d4: Expected O, but got Unknown
		//IL_1300: Expected O, but got I4
		//IL_1349: Expected O, but got I
		//IL_1357: Expected I, but got O
		//IL_131f: Expected O, but got I4
		//IL_136a: Expected O, but got I4
		//IL_1c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c77: Expected O, but got Unknown
		//IL_13c9: Expected O, but got I4
		//IL_1412: Expected O, but got I
		//IL_1420: Expected I, but got O
		//IL_13e8: Expected O, but got I4
		//IL_1433: Expected O, but got I4
		//IL_1cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc5: Expected O, but got Unknown
		//IL_1492: Expected O, but got I4
		//IL_14db: Expected O, but got I
		//IL_14e9: Expected I, but got O
		//IL_14b1: Expected O, but got I4
		//IL_1d0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d13: Expected O, but got Unknown
		//IL_1d44: Expected O, but got I4
		//IL_155f: Expected O, but got I4
		//IL_1568: Expected O, but got I4
		//IL_15be: Expected O, but got I
		//IL_15cc: Expected I, but got O
		//IL_15df: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e4: Expected O, but got Unknown
		//IL_1681: Expected O, but got I
		//IL_168f: Expected I, but got O
		//IL_16a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a7: Expected O, but got Unknown
		//IL_1744: Expected O, but got I
		//IL_1752: Expected I, but got O
		//IL_1765: Unknown result type (might be due to invalid IL or missing references)
		//IL_176a: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		Delegate obj3 = (Delegate)((nint)0 + (nint)320);
		Delegate obj4 = (Delegate)((nint)0 + (nint)280);
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2552;
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2064;
		object obj8 = channel + 24;
		Delegate obj9 = (Delegate)obj8;
		Delegate obj11 = default(Delegate);
		Action action2 = default(Action);
		Delegate obj15 = default(Delegate);
		Action action3 = default(Action);
		Delegate obj19 = default(Delegate);
		Action<System.Int32Enum> action4 = default(Action<System.Int32Enum>);
		object obj25 = default(object);
		Delegate obj29 = default(Delegate);
		Action action5 = default(Action);
		Delegate obj34 = default(Delegate);
		Action action6 = default(Action);
		Delegate obj39 = default(Delegate);
		Action<object> action7 = default(Action<object>);
		object obj46 = default(object);
		Delegate obj48 = default(Delegate);
		Action action8 = default(Action);
		Delegate obj55 = default(Delegate);
		Action action9 = default(Action);
		Delegate obj60 = default(Delegate);
		Action action10 = default(Action);
		Delegate obj65 = default(Delegate);
		Action action11 = default(Action);
		Delegate obj70 = default(Delegate);
		Action action12 = default(Action);
		Delegate obj75 = default(Delegate);
		Action action13 = default(Action);
		Delegate obj80 = default(Delegate);
		Action action14 = default(Action);
		Delegate obj85 = default(Delegate);
		Action action15 = default(Action);
		Delegate obj90 = default(Delegate);
		Action action16 = default(Action);
		Delegate obj95 = default(Delegate);
		Action action17 = default(Action);
		Delegate obj100 = default(Delegate);
		Action action18 = default(Action);
		Delegate obj105 = default(Delegate);
		Action action19 = default(Action);
		Delegate obj110 = default(Delegate);
		Action action20 = default(Action);
		Delegate obj115 = default(Delegate);
		Action action21 = default(Action);
		Delegate obj120 = default(Delegate);
		Action action22 = default(Action);
		Delegate obj125 = default(Delegate);
		Action action23 = default(Action);
		Delegate obj130 = default(Delegate);
		Action<object> action24 = default(Action<object>);
		object obj137 = default(object);
		Delegate obj142 = default(Delegate);
		Action<bool> action25 = default(Action<bool>);
		object obj147 = default(object);
		Delegate obj150 = default(Delegate);
		Action<object> action26 = default(Action<object>);
		object obj155 = default(object);
		Delegate obj158 = default(Delegate);
		Action<object> action27 = default(Action<object>);
		GameEventsChannel gameEventsChannel10 = default(GameEventsChannel);
		Delegate obj164 = default(Delegate);
		Action action28 = default(Action);
		Delegate obj169 = default(Delegate);
		Action action29 = default(Action);
		Delegate obj174 = default(Delegate);
		Action action30 = default(Action);
		Delegate obj179 = default(Delegate);
		Action<object> action31 = default(Action<object>);
		Delegate obj185 = default(Delegate);
		Delegate obj187 = default(Delegate);
		Action action32 = default(Action);
		Delegate obj192 = default(Delegate);
		Action<object> action33 = default(Action<object>);
		object obj198 = default(object);
		Delegate obj200 = default(Delegate);
		while (true)
		{
			Delegate obj10 = Delegate.Remove(obj9, action);
			if ((object)obj10 == null || obj10 == obj)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag = (object)obj11 == obj9;
				obj9 = obj11;
				if (!flag)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action2..ctor(this, (IntPtr)obj3);
				object obj12 = channel + 32;
				Delegate obj13 = (Delegate)obj12;
				while (true)
				{
					Delegate obj14 = Delegate.Remove(obj13, action2);
					if ((object)obj14 != null && obj14 != obj)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					bool flag2 = (object)obj15 == obj13;
					obj13 = obj15;
					if (!flag2)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					action3..ctor(this, (IntPtr)obj4);
					object obj16 = channel + 40;
					Delegate obj17 = (Delegate)obj16;
					while (true)
					{
						Delegate obj18 = Delegate.Remove(obj17, action3);
						if ((object)obj18 != null && obj18 != obj)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
						bool flag3 = (object)obj19 == obj17;
						obj17 = obj19;
						if (!flag3)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj20 = (nint)0 + (nint)328;
						action4..ctor((object)this, (IntPtr)obj20);
						object obj21 = channel + 48;
						Delegate obj22 = (Delegate)obj21;
						while (true)
						{
							Delegate obj23 = Delegate.Remove(obj22, action4);
							object obj27;
							Delegate obj28;
							if ((object)obj23 == null)
							{
								object obj24 = 0;
							}
							else
							{
								obj3 = (Delegate)obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag4 = obj25 == null;
								object obj26 = !flag4;
								object obj24 = obj25;
								if (obj26 == null)
								{
									obj27 = 0;
									obj28 = null;
									goto IL_06f5;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
							bool flag5 = (object)obj29 == obj22;
							obj22 = obj29;
							if (!flag5)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj30 = (nint)0 + (nint)336;
							action5..ctor(this, (IntPtr)obj30);
							obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2496;
							object obj31 = channel + 56;
							Delegate obj32 = (Delegate)obj31;
							while (true)
							{
								Delegate obj33 = Delegate.Remove(obj32, action5);
								if ((object)obj33 == null || obj33 == obj)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
									bool flag6 = (object)obj34 == obj32;
									obj32 = obj34;
									if (!flag6)
									{
										continue;
									}
									goto IL_0363;
								}
								break;
							}
							break;
							IL_058c:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj35 = (nint)0 + (nint)304;
							action6..ctor(this, (IntPtr)obj35);
							object obj36 = channel + 96;
							Delegate obj37 = (Delegate)obj36;
							while (true)
							{
								Delegate obj38 = Delegate.Remove(obj37, action6);
								if ((object)obj38 == null || obj38 == obj)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
									bool flag7 = (object)obj39 == obj37;
									obj37 = obj39;
									if (!flag7)
									{
										continue;
									}
									goto IL_0637;
								}
								break;
							}
							break;
							IL_06f5:
							Delegate obj40 = obj3;
							throw new InvalidCastException();
							IL_0422:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj41 = (nint)0 + (nint)480;
							action7..ctor((object)this, (IntPtr)obj41);
							object obj42 = channel + 80;
							Delegate obj43 = (Delegate)obj42;
							while (true)
							{
								Delegate obj44 = Delegate.Remove(obj43, action7);
								if ((object)obj44 == null)
								{
									object obj45 = 0;
								}
								else
								{
									obj3 = (Delegate)obj6;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag8 = obj46 == null;
									object obj47 = !flag8;
									object obj45 = obj46;
									if (obj47 == null)
									{
										break;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
								bool flag9 = (object)obj48 == obj43;
								obj43 = obj48;
								if (!flag9)
								{
									continue;
								}
								goto IL_04e1;
							}
							obj27 = 0;
							obj28 = null;
							goto IL_06f5;
							IL_0708:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj49 = (nint)0 + (nint)248;
							action8..ctor(this, (IntPtr)obj49);
							object obj50 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1368;
							object obj51 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
							object obj52 = channel + 128;
							Delegate obj53 = (Delegate)obj52;
							while (true)
							{
								Delegate obj54 = Delegate.Remove(obj53, action8);
								if ((object)obj54 != null && obj54 != obj)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
								bool flag10 = (object)obj55 == obj53;
								obj53 = obj55;
								if (!flag10)
								{
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj56 = (nint)0 + (nint)240;
								action9..ctor(this, (IntPtr)obj56);
								object obj57 = channel + 136;
								Delegate obj58 = (Delegate)obj57;
								while (true)
								{
									Delegate obj59 = Delegate.Remove(obj58, action9);
									if ((object)obj59 != null && obj59 != obj)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
									bool flag11 = (object)obj60 == obj58;
									obj58 = obj60;
									if (!flag11)
									{
										continue;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj61 = (nint)0 + (nint)256;
									action10..ctor(this, (IntPtr)obj61);
									object obj62 = channel + 144;
									Delegate obj63 = (Delegate)obj62;
									while (true)
									{
										Delegate obj64 = Delegate.Remove(obj63, action10);
										if ((object)obj64 != null && obj64 != obj)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
										bool flag12 = (object)obj65 == obj63;
										obj63 = obj65;
										if (!flag12)
										{
											continue;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										object obj66 = (nint)0 + (nint)264;
										action11..ctor(this, (IntPtr)obj66);
										object obj67 = channel + 152;
										Delegate obj68 = (Delegate)obj67;
										while (true)
										{
											Delegate obj69 = Delegate.Remove(obj68, action11);
											if ((object)obj69 != null && obj69 != obj)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
											bool flag13 = (object)obj70 == obj68;
											obj68 = obj70;
											if (!flag13)
											{
												continue;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											object obj71 = (nint)0 + (nint)424;
											action12..ctor(this, (IntPtr)obj71);
											object obj72 = channel + 160;
											Delegate obj73 = (Delegate)obj72;
											while (true)
											{
												Delegate obj74 = Delegate.Remove(obj73, action12);
												if ((object)obj74 != null && obj74 != obj)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
												bool flag14 = (object)obj75 == obj73;
												obj73 = obj75;
												if (!flag14)
												{
													continue;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												object obj76 = (nint)0 + (nint)384;
												action13..ctor(this, (IntPtr)obj76);
												object obj77 = channel + 168;
												Delegate obj78 = (Delegate)obj77;
												while (true)
												{
													Delegate obj79 = Delegate.Remove(obj78, action13);
													if ((object)obj79 != null && obj79 != obj)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
													bool flag15 = (object)obj80 == obj78;
													obj78 = obj80;
													if (!flag15)
													{
														continue;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
													object obj81 = (nint)0 + (nint)368;
													action14..ctor(this, (IntPtr)obj81);
													object obj82 = channel + 176;
													Delegate obj83 = (Delegate)obj82;
													while (true)
													{
														Delegate obj84 = Delegate.Remove(obj83, action14);
														if ((object)obj84 != null && obj84 != obj)
														{
															break;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
														bool flag16 = (object)obj85 == obj83;
														obj83 = obj85;
														if (!flag16)
														{
															continue;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
														object obj86 = (nint)0 + (nint)408;
														action15..ctor(this, (IntPtr)obj86);
														object obj87 = channel + 184;
														Delegate obj88 = (Delegate)obj87;
														while (true)
														{
															Delegate obj89 = Delegate.Remove(obj88, action15);
															if ((object)obj89 != null && obj89 != obj)
															{
																break;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
															bool flag17 = (object)obj90 == obj88;
															obj88 = obj90;
															if (!flag17)
															{
																continue;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
															object obj91 = (nint)0 + (nint)440;
															action16..ctor(this, (IntPtr)obj91);
															object obj92 = channel + 192;
															Delegate obj93 = (Delegate)obj92;
															while (true)
															{
																Delegate obj94 = Delegate.Remove(obj93, action16);
																if ((object)obj94 != null && obj94 != obj)
																{
																	break;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																bool flag18 = (object)obj95 == obj93;
																obj93 = obj95;
																if (!flag18)
																{
																	continue;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																object obj96 = (nint)0 + (nint)448;
																action17..ctor(this, (IntPtr)obj96);
																object obj97 = channel + 200;
																Delegate obj98 = (Delegate)obj97;
																while (true)
																{
																	Delegate obj99 = Delegate.Remove(obj98, action17);
																	if ((object)obj99 != null && obj99 != obj)
																	{
																		break;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																	bool flag19 = (object)obj100 == obj98;
																	obj98 = obj100;
																	if (!flag19)
																	{
																		continue;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																	object obj101 = (nint)0 + (nint)456;
																	action18..ctor(this, (IntPtr)obj101);
																	object obj102 = channel + 208;
																	Delegate obj103 = (Delegate)obj102;
																	while (true)
																	{
																		Delegate obj104 = Delegate.Remove(obj103, action18);
																		if ((object)obj104 != null && obj104 != obj)
																		{
																			break;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																		bool flag20 = (object)obj105 == obj103;
																		obj103 = obj105;
																		if (!flag20)
																		{
																			continue;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																		object obj106 = (nint)0 + (nint)464;
																		action19..ctor(this, (IntPtr)obj106);
																		object obj107 = channel + 216;
																		Delegate obj108 = (Delegate)obj107;
																		while (true)
																		{
																			Delegate obj109 = Delegate.Remove(obj108, action19);
																			if ((object)obj109 != null && obj109 != obj)
																			{
																				break;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																			bool flag21 = (object)obj110 == obj108;
																			obj108 = obj110;
																			if (!flag21)
																			{
																				continue;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																			object obj111 = (nint)0 + (nint)360;
																			action20..ctor(this, (IntPtr)obj111);
																			object obj112 = channel + 224;
																			Delegate obj113 = (Delegate)obj112;
																			while (true)
																			{
																				Delegate obj114 = Delegate.Remove(obj113, action20);
																				if ((object)obj114 != null && obj114 != obj)
																				{
																					break;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																				bool flag22 = (object)obj115 == obj113;
																				obj113 = obj115;
																				if (!flag22)
																				{
																					continue;
																				}
																				GameEventsChannel gameEventsChannel = channel;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																				object obj116 = (nint)0 + (nint)392;
																				action21..ctor(this, (IntPtr)obj116);
																				Delegate obj117 = gameEventsChannel.ShowGiftPanel;
																				while (true)
																				{
																					Delegate obj118 = Delegate.Remove(obj117, action21);
																					if ((object)obj118 != null && obj118 != obj)
																					{
																						break;
																					}
																					object obj119 = gameEventsChannel + 288;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																					bool flag23 = (object)obj120 == obj117;
																					obj117 = obj120;
																					if (!flag23)
																					{
																						continue;
																					}
																					GameEventsChannel gameEventsChannel2 = channel;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																					object obj121 = (nint)0 + (nint)400;
																					action22..ctor(this, (IntPtr)obj121);
																					Delegate obj122 = gameEventsChannel2.ShowGiftSelection;
																					while (true)
																					{
																						Delegate obj123 = Delegate.Remove(obj122, action22);
																						if ((object)obj123 != null && obj123 != obj)
																						{
																							break;
																						}
																						object obj124 = gameEventsChannel2 + 304;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																						bool flag24 = (object)obj125 == obj122;
																						obj122 = obj125;
																						if (!flag24)
																						{
																							continue;
																						}
																						GameEventsChannel gameEventsChannel3 = channel;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																						object obj126 = (nint)0 + (nint)312;
																						action23..ctor(this, (IntPtr)obj126);
																						Delegate obj127 = gameEventsChannel3.HideGiftSelection;
																						while (true)
																						{
																							Delegate obj128 = Delegate.Remove(obj127, action23);
																							if ((object)obj128 != null && obj128 != obj)
																							{
																								break;
																							}
																							object obj129 = gameEventsChannel3 + 312;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																							bool flag25 = (object)obj130 == obj127;
																							obj127 = obj130;
																							if (!flag25)
																							{
																								continue;
																							}
																							GameEventsChannel gameEventsChannel4 = channel;
																							object obj131 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2152;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																							object obj132 = (nint)0 + (nint)288;
																							action24..ctor((object)this, (IntPtr)obj132);
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E752E]");
																							object obj133 = 0;
																							Delegate obj134 = gameEventsChannel4.OnGiftClicked;
																							while (true)
																							{
																								Delegate obj135 = Delegate.Remove(obj134, action24);
																								object obj139;
																								Delegate obj140;
																								if ((object)obj135 == null)
																								{
																									object obj136 = 0;
																								}
																								else
																								{
																									obj133 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2152;
																									gameEventsChannel3 = (GameEventsChannel)obj133;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																									bool flag26 = obj137 == null;
																									object obj138 = !flag26;
																									object obj136 = obj137;
																									if (obj138 == null)
																									{
																										obj139 = 0;
																										obj140 = null;
																										goto IL_158b;
																									}
																								}
																								object obj141 = gameEventsChannel4 + 368;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																								bool flag27 = (object)obj142 == obj134;
																								obj134 = obj142;
																								if (!flag27)
																								{
																									continue;
																								}
																								GameEventsChannel gameEventsChannel5 = channel;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																								object obj143 = (nint)0 + (nint)296;
																								action25..ctor((object)this, (IntPtr)obj143);
																								Delegate obj144 = gameEventsChannel5.OnGiftSelected;
																								while (true)
																								{
																									Delegate obj145 = Delegate.Remove(obj144, action25);
																									if ((object)obj145 == null)
																									{
																										object obj146 = 0;
																									}
																									else
																									{
																										gameEventsChannel3 = (GameEventsChannel)obj51;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																										bool flag28 = obj147 == null;
																										object obj148 = !flag28;
																										object obj146 = obj147;
																										if (obj148 == null)
																										{
																											break;
																										}
																									}
																									object obj149 = gameEventsChannel5 + 376;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																									bool flag29 = (object)obj150 == obj144;
																									obj144 = obj150;
																									if (!flag29)
																									{
																										continue;
																									}
																									goto IL_13f2;
																								}
																								obj139 = 0;
																								obj140 = null;
																								goto IL_158b;
																								IL_13f2:
																								GameEventsChannel gameEventsChannel6 = channel;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																								object obj151 = (nint)0 + (nint)352;
																								action26..ctor((object)this, (IntPtr)obj151);
																								Delegate obj152 = gameEventsChannel6.OnPlayerGiftClicked;
																								while (true)
																								{
																									Delegate obj153 = Delegate.Remove(obj152, action26);
																									if ((object)obj153 == null)
																									{
																										object obj154 = 0;
																									}
																									else
																									{
																										gameEventsChannel3 = (GameEventsChannel)obj5;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																										bool flag30 = obj155 == null;
																										object obj156 = !flag30;
																										object obj154 = obj155;
																										if (obj156 == null)
																										{
																											break;
																										}
																									}
																									object obj157 = gameEventsChannel6 + 392;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																									bool flag31 = (object)obj158 == obj152;
																									obj152 = obj158;
																									if (!flag31)
																									{
																										continue;
																									}
																									goto IL_14bb;
																								}
																								obj139 = 0;
																								obj140 = null;
																								goto IL_158b;
																								IL_158b:
																								GameEventsChannel gameEventsChannel7 = gameEventsChannel3;
																								throw new InvalidCastException();
																								IL_14bb:
																								GameEventsChannel gameEventsChannel8 = channel;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																								object obj159 = (nint)0 + (nint)472;
																								action27..ctor((object)this, (IntPtr)obj159);
																								Delegate obj160 = gameEventsChannel8.OnTutorialCardPreventedToPlay;
																								while (true)
																								{
																									Delegate obj161 = Delegate.Remove(obj160, action27);
																									GameEventsChannel gameEventsChannel9;
																									if ((object)obj161 == null)
																									{
																										gameEventsChannel7 = null;
																										gameEventsChannel9 = gameEventsChannel3;
																									}
																									else
																									{
																										gameEventsChannel3 = (GameEventsChannel)obj50;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																										bool flag32 = (object)gameEventsChannel10 == null;
																										object obj162 = !flag32;
																										obj139 = 0;
																										obj140 = null;
																										gameEventsChannel7 = gameEventsChannel10;
																										gameEventsChannel9 = (GameEventsChannel)obj50;
																										if (obj162 == null)
																										{
																											break;
																										}
																									}
																									object obj163 = gameEventsChannel8 + 400;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																									bool flag33 = (object)obj164 == obj160;
																									obj160 = obj164;
																									gameEventsChannel3 = gameEventsChannel9;
																									obj139 = 0;
																									obj140 = obj164;
																									if (flag33)
																									{
																										goto end_IL_1292;
																									}
																								}
																								goto IL_158b;
																								continue;
																								end_IL_1292:
																								break;
																							}
																							GameEventsChannel gameEventsChannel11 = channel;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																							object obj165 = (nint)0 + (nint)416;
																							action28..ctor(this, (IntPtr)obj165);
																							Delegate obj166 = gameEventsChannel11.ShowOfflineUi;
																							while (true)
																							{
																								Delegate obj167 = Delegate.Remove(obj166, action28);
																								if ((object)obj167 != null && obj167 != obj)
																								{
																									break;
																								}
																								object obj168 = gameEventsChannel11 + 408;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																								bool flag34 = (object)obj169 == obj166;
																								obj166 = obj169;
																								if (!flag34)
																								{
																									continue;
																								}
																								GameEventsChannel gameEventsChannel12 = channel;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																								object obj170 = (nint)0 + (nint)232;
																								action29..ctor(this, (IntPtr)obj170);
																								Delegate obj171 = gameEventsChannel12.OnBecomingWatcher;
																								while (true)
																								{
																									Delegate obj172 = Delegate.Remove(obj171, action29);
																									if ((object)obj172 != null && obj172 != obj)
																									{
																										break;
																									}
																									object obj173 = gameEventsChannel12 + 416;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																									bool flag35 = (object)obj174 == obj171;
																									obj171 = obj174;
																									if (!flag35)
																									{
																										continue;
																									}
																									GameEventsChannel gameEventsChannel13 = channel;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																									object obj175 = (nint)0 + (nint)224;
																									action30..ctor(this, (IntPtr)obj175);
																									Delegate obj176 = gameEventsChannel13.OnBecomingPlayer;
																									while (true)
																									{
																										Delegate obj177 = Delegate.Remove(obj176, action30);
																										if ((object)obj177 == null || obj177 == obj)
																										{
																											object obj178 = gameEventsChannel13 + 424;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
																											bool flag36 = (object)obj179 == obj176;
																											obj176 = obj179;
																											if (!flag36)
																											{
																												continue;
																											}
																											return;
																										}
																										break;
																									}
																									break;
																								}
																								break;
																							}
																							break;
																						}
																						break;
																					}
																					break;
																				}
																				break;
																			}
																			break;
																		}
																		break;
																	}
																	break;
																}
																break;
															}
															break;
														}
														break;
													}
													break;
												}
												break;
											}
											break;
										}
										break;
									}
									break;
								}
								break;
							}
							break;
							IL_0637:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj180 = (nint)0 + (nint)272;
							action31..ctor((object)this, (IntPtr)obj180);
							object obj181 = channel + 104;
							Delegate obj182 = (Delegate)obj181;
							Delegate obj183 = obj3;
							while (true)
							{
								Delegate obj184 = Delegate.Remove(obj182, action31);
								if ((object)obj184 == null)
								{
									obj40 = null;
								}
								else
								{
									obj3 = (Delegate)obj7;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag37 = (object)obj185 == null;
									object obj186 = !flag37;
									obj27 = 0;
									obj28 = null;
									obj183 = (Delegate)obj7;
									obj40 = obj185;
									if (obj186 == null)
									{
										break;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
								bool flag38 = (object)obj187 == obj182;
								obj182 = obj187;
								obj3 = obj183;
								obj27 = 0;
								obj28 = obj187;
								if (!flag38)
								{
									continue;
								}
								goto IL_0708;
							}
							goto IL_06f5;
							IL_04e1:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj188 = (nint)0 + (nint)376;
							action32..ctor(this, (IntPtr)obj188);
							object obj189 = channel + 88;
							Delegate obj190 = (Delegate)obj189;
							while (true)
							{
								Delegate obj191 = Delegate.Remove(obj190, action32);
								if ((object)obj191 == null || obj191 == obj)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
									bool flag39 = (object)obj192 == obj190;
									obj190 = obj192;
									if (!flag39)
									{
										continue;
									}
									goto IL_058c;
								}
								break;
							}
							break;
							IL_0363:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj193 = (nint)0 + (nint)344;
							action33..ctor((object)this, (IntPtr)obj193);
							object obj194 = channel + 72;
							Delegate obj195 = (Delegate)obj194;
							while (true)
							{
								Delegate obj196 = Delegate.Remove(obj195, action33);
								if ((object)obj196 == null)
								{
									object obj197 = 0;
								}
								else
								{
									obj3 = (Delegate)obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag40 = obj198 == null;
									object obj199 = !flag40;
									object obj197 = obj198;
									if (obj199 == null)
									{
										break;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
								bool flag41 = (object)obj200 == obj195;
								obj195 = obj200;
								if (!flag41)
								{
									continue;
								}
								goto IL_0422;
							}
							obj27 = 0;
							obj28 = null;
							goto IL_06f5;
						}
						break;
					}
					break;
				}
			}
			throw new InvalidCastException();
		}
	}

	private void OnShowUi()
	{
		ShowUi.Invoke();
	}

	private void OnHideUi()
	{
		HideUi.Invoke();
	}

	private void OnExitGame()
	{
		ExitGame.Invoke();
	}

	private void OnLeaveRoom(LeaveReason leaveReason)
	{
		ExitGame.Invoke();
	}

	private void OnPanelShow()
	{
		PanelShow.Invoke();
	}

	private void OnPlayerClicked(KPlayer kPlayer)
	{
		((UnityEvent<object>)(object)PlayerClicked).Invoke((object)kPlayer);
	}

	private void OnWatcherClicked(string s)
	{
		((UnityEvent<object>)(object)WatcherClicked).Invoke((object)s);
	}

	private void OnShowDismissibleBlocker()
	{
		ShowDismissibleBlocker.Invoke();
	}

	private void OnHideDismissibleBlocker()
	{
		HideDismissibleBlocker.Invoke();
	}

	private void OnDismissibleClicked(GameCard cardHit)
	{
		((UnityEvent<object>)(object)DismissibleClicked).Invoke((object)cardHit);
	}

	private void OnCloseEndRoundPopup()
	{
		CloseEndRoundPopup.Invoke();
	}

	private void OnCloseEndGamePopup()
	{
		CloseEndGamePopup.Invoke();
	}

	private void OnCloseQuickReplies()
	{
		CloseQuickReplies.Invoke();
	}

	private void OnCloseSawaPanel()
	{
		CloseSawaPanel.Invoke();
	}

	private void OnShowQuickRepliesForSubscribersMessage()
	{
		ShowQuickRepliesForSubscribersMessage.Invoke();
	}

	private void OnShowForfeitWarning()
	{
		ShowForfeitWarning.Invoke();
	}

	private void OnShowChat()
	{
		ShowChat.Invoke();
	}

	private void OnShowMiniChat()
	{
		ShowMiniChat.Invoke();
	}

	private void OnToggleCatchPanel()
	{
		ToggleCatchPanel.Invoke();
	}

	private void OnToggleProjectsPanel()
	{
		ToggleProjectsPanel.Invoke();
	}

	private void OnToggleSawaPanel()
	{
		ToggleSawaPanel.Invoke();
	}

	private void OnToggleTeamsDetails()
	{
		ToggleTeamsDetails.Invoke();
	}

	private void OnShakeProjectsButton()
	{
		ShakeProjectsButton.Invoke();
	}

	private void OnShowGiftPanel()
	{
		ShowGiftPanel.Invoke();
	}

	private void OnShowGiftSelection()
	{
		ShowGiftSelection.Invoke();
	}

	private void OnHideGiftSelection()
	{
		HideGiftSelection.Invoke();
	}

	private void OnGiftClicked(GiftUIElement giftUIElement)
	{
		((UnityEvent<object>)(object)GiftClicked).Invoke((object)giftUIElement);
	}

	private void OnGiftSelected(bool b)
	{
		bool arg = default(bool);
		GiftSelected.Invoke(arg);
	}

	private void OnPlayerGiftClicked(KPlayer kPlayer)
	{
		((UnityEvent<object>)(object)PlayerGiftClicked).Invoke((object)kPlayer);
	}

	private void OnTutorialCardPreventedToPlay(Card card)
	{
		((UnityEvent<object>)(object)TutorialCardPreventedToPlay).Invoke((object)card);
	}

	private void OnShowOfflineUi()
	{
		ShowOfflineUi.Invoke();
	}

	private void OnBecomingWatcher()
	{
		BecomingWatcher.Invoke();
	}

	private void OnBecomingPlayer()
	{
		BecomingPlayer.Invoke();
	}
}
