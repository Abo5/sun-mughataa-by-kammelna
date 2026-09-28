using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class PlayerProfileNavigator : MonoBehaviour
{
	private sealed class <>c__DisplayClass15_0
	{
		public Toggle toggle;

		internal bool <DelayedSetToggleInternal>b__0()
		{
			//IL_006b: Expected I4, but got O
			if ((object)toggle != null)
			{
				GameObject gameObject = toggle.gameObject;
				if ((object)gameObject != null)
				{
					return gameObject.activeInHierarchy;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <DelayedSetToggleInternal>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public Toggle toggle;

		private <>c__DisplayClass15_0 <>8__1;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <DelayedSetToggleInternal>d__15(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00be: Expected I4, but got I8
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected O, but got Unknown
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected O, but got Unknown
			//IL_0204: Expected I4, but got O
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected O, but got Unknown
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Expected O, but got Unknown
			//IL_0036: Expected I4, but got I8
			//IL_0175: Expected O, but got I
			//IL_0188: Expected I, but got O
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Expected O, but got Unknown
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Expected O, but got Unknown
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					<>1__state = -1;
					<>c__DisplayClass15_0 <>c__DisplayClass15_ = <>8__1;
					if (<>8__1 == null || (object)<>c__DisplayClass15_.toggle == null)
					{
						goto IL_01f6;
					}
					<>c__DisplayClass15_.toggle.isOn = true;
				}
				return <>1__state == 0;
			}
			<>1__state = -1;
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = this + 40;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (obj3 != null)
			{
				object obj4 = obj3 + 16;
				obj4 = toggle;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj5 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj6 = (nint)0 + (nint)992;
				Func<bool> func = default(Func<bool>);
				func..ctor((object)<>8__1, (IntPtr)obj6);
				object obj7 = typeof(UsageHint) + 1680;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				WaitUntil waitUntil = default(WaitUntil);
				waitUntil..ctor(func);
				object obj8 = this + 24;
				obj8 = waitUntil;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 1;
				return <>1__state == 0;
			}
			goto IL_01f6;
			IL_01f6:
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
			object obj2 = (nint)0 + (nint)1000;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private Toggle Bio;

	private Toggle Rating;

	private Toggle Trophies;

	private Toggle Arrangment;

	private Toggle Performence;

	private Toggle Weeklyrank;

	private Toggle Monthlyrank;

	private Toggle Overallrank;

	private Toggle Weeklyperformence;

	private Toggle MonthlyPerformance;

	private Toggle Subtrophies;

	private Toggle Achiements;

	private Toggle Titles;

	public void OnRoute(RoutingCommand command, string commandParam)
	{
		//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Expected O, but got Unknown
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected O, but got Unknown
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fb: Expected O, but got Unknown
		//IL_0ec8: Expected O, but got I4
		//IL_0805: Expected O, but got I4
		//IL_080e: Expected O, but got I4
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_096f: Expected O, but got Unknown
		//IL_0841: Expected O, but got I
		//IL_085b: Expected O, but got I4
		//IL_0f0b: Expected O, but got I
		//IL_0f23: Expected O, but got I4
		//IL_0f2c: Expected O, but got I4
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected O, but got Unknown
		//IL_0e86: Expected O, but got I4
		//IL_1093: Expected O, but got I4
		//IL_0a4e: Expected O, but got I4
		//IL_0a57: Expected O, but got I4
		//IL_141c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1421: Expected O, but got Unknown
		//IL_1443: Unknown result type (might be due to invalid IL or missing references)
		//IL_1448: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_0a8a: Expected O, but got I
		//IL_0aa4: Expected O, but got I4
		//IL_10d6: Expected O, but got I
		//IL_10ee: Expected O, but got I4
		//IL_10f7: Expected O, but got I4
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected O, but got Unknown
		//IL_0f8e: Expected O, but got I4
		//IL_09c2: Expected O, but got I4
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b87: Expected O, but got Unknown
		//IL_08d4: Expected O, but got I
		//IL_08ee: Expected O, but got I4
		//IL_08f7: Expected O, but got I4
		//IL_0910: Expected O, but got I4
		//IL_0918: Expected I4, but got O
		//IL_0f43: Expected O, but got I4
		//IL_0f4c: Expected O, but got I4
		//IL_0cf8: Expected O, but got I4
		//IL_0435: Expected O, but got I4
		//IL_043e: Expected O, but got I4
		//IL_146e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1473: Expected O, but got Unknown
		//IL_1495: Unknown result type (might be due to invalid IL or missing references)
		//IL_149a: Expected O, but got Unknown
		//IL_0fec: Expected O, but got I
		//IL_1006: Expected O, but got I4
		//IL_0fbe: Expected O, but got I4
		//IL_0471: Expected O, but got I
		//IL_048b: Expected O, but got I4
		//IL_0d3b: Expected O, but got I
		//IL_0d53: Expected O, but got I4
		//IL_0d5c: Expected O, but got I4
		//IL_0c32: Expected O, but got I4
		//IL_026c: Expected O, but got I4
		//IL_0275: Expected O, but got I4
		//IL_0b1d: Expected O, but got I
		//IL_0b35: Expected O, but got I4
		//IL_110e: Expected O, but got I4
		//IL_1117: Expected O, but got I4
		//IL_0dbe: Expected O, but got I4
		//IL_05fe: Expected O, but got I4
		//IL_0607: Expected O, but got I4
		//IL_14c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c5: Expected O, but got Unknown
		//IL_09d9: Expected O, but got I4
		//IL_123b: Expected O, but got I4
		//IL_0bda: Expected O, but got I4
		//IL_14f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f9: Expected O, but got Unknown
		//IL_094e: Expected I4, but got O
		//IL_1378: Unknown result type (might be due to invalid IL or missing references)
		//IL_137d: Expected O, but got Unknown
		//IL_139f: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a4: Expected O, but got Unknown
		//IL_02a8: Expected O, but got I
		//IL_02c2: Expected O, but got I4
		//IL_0c75: Expected O, but got I
		//IL_0c8d: Expected O, but got I4
		//IL_0c96: Expected O, but got I4
		//IL_063a: Expected O, but got I
		//IL_0654: Expected O, but got I4
		//IL_0e01: Expected O, but got I
		//IL_0e19: Expected O, but got I4
		//IL_0e22: Expected O, but got I4
		//IL_1299: Expected O, but got I
		//IL_126b: Expected O, but got I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_0504: Expected O, but got I
		//IL_051c: Expected O, but got I4
		//IL_0d73: Expected O, but got I4
		//IL_0d7c: Expected O, but got I4
		//IL_1319: Unknown result type (might be due to invalid IL or missing references)
		//IL_131e: Expected O, but got Unknown
		//IL_1340: Unknown result type (might be due to invalid IL or missing references)
		//IL_1345: Expected O, but got Unknown
		//IL_0b5c: Expected O, but got I4
		//IL_0b64: Expected I4, but got O
		//IL_13ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cf: Expected O, but got Unknown
		//IL_13f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f6: Expected O, but got Unknown
		//IL_0bf1: Expected O, but got I4
		//IL_033b: Expected O, but got I
		//IL_0353: Expected O, but got I4
		//IL_0cad: Expected O, but got I4
		//IL_0cb6: Expected O, but got I4
		//IL_06cd: Expected O, but got I
		//IL_06e5: Expected O, but got I4
		//IL_0e39: Expected O, but got I4
		//IL_0e42: Expected O, but got I4
		//IL_1159: Expected O, but got I4
		//IL_00e6: Expected O, but got I4
		//IL_00ef: Expected O, but got I4
		//IL_0543: Expected O, but got I4
		//IL_054b: Expected I4, but got O
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0136: Expected O, but got I
		//IL_0150: Expected O, but got I4
		//IL_1195: Unknown result type (might be due to invalid IL or missing references)
		//IL_119a: Expected O, but got Unknown
		//IL_11b0: Expected O, but got I
		//IL_11c8: Expected O, but got I4
		//IL_11d1: Expected O, but got I4
		//IL_037a: Expected O, but got I4
		//IL_0382: Expected I4, but got O
		//IL_070c: Expected O, but got I4
		//IL_0714: Expected I4, but got O
		//IL_1305: Expected I4, but got O
		//IL_11f0: Expected O, but got I4
		//IL_11f9: Expected O, but got I4
		object obj4;
		UnityEngine.Object obj5;
		Toggle achiements;
		object obj6;
		object obj8;
		UnityEngine.Object obj10;
		Toggle toggle;
		object obj14;
		bool flag8;
		object obj21;
		UnityEngine.Object obj22;
		Toggle performence;
		Toggle toggle2;
		object obj29;
		UnityEngine.Object obj30;
		Toggle performence2;
		Toggle toggle3;
		object obj24;
		UnityEngine.Object obj25;
		object obj32;
		UnityEngine.Object obj33;
		object obj9;
		if (command > RoutingCommand.OverallRank)
		{
			if (command > RoutingCommand.PerformanceMonthly)
			{
				if (command != RoutingCommand.Trophies)
				{
					if (command != RoutingCommand.Titles)
					{
						if (command != RoutingCommand.Achievements)
						{
							return;
						}
						object obj = typeof(MemberAchievementClanFeedData) + 2976;
						object obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v155+E4]");
						if ((nint)0 != 0)
						{
							bool flag = Trophies != null;
							bool flag2 = !flag;
							object obj3 = !flag2;
							obj4 = 0;
							obj5 = null;
							if (obj3 == null)
							{
								goto IL_0102;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							bool flag3 = Trophies != null;
							bool flag4 = !flag3;
							obj4 = 0;
							obj5 = null;
							if (flag4)
							{
								goto IL_0102;
							}
						}
						Trophies.isOn = true;
						achiements = Achiements;
						obj6 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2584;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
						object obj7 = (nint)0 & (nint)1;
						bool flag5 = obj7 == null;
						obj4 = 0;
						obj5 = (UnityEngine.Object)1;
						if (flag5)
						{
							goto IL_0180;
						}
						obj8 = obj6;
						obj9 = 0;
						obj10 = (UnityEngine.Object)1;
						toggle = Achiements;
						goto IL_12f5;
					}
					object obj11 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v146+E4]");
					if ((nint)0 != 0)
					{
						bool flag6 = Trophies != null;
						bool flag7 = !flag6;
						object obj13 = !flag7;
						if (obj13 != null)
						{
							goto IL_1252;
						}
						obj14 = 0;
						flag8 = false;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						bool flag9 = Trophies != null;
						bool flag10 = !flag9;
						obj14 = 0;
						flag8 = false;
						if (!flag10)
						{
							goto IL_1252;
						}
					}
					goto IL_1279;
				}
				object obj15 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v137+E4]");
				if ((nint)0 != 0)
				{
					bool flag11 = Trophies != null;
					bool flag12 = !flag11;
					object obj17 = !flag12;
					if (obj17 != null)
					{
						goto IL_0fa5;
					}
					obj14 = 0;
					flag8 = false;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag13 = Trophies != null;
					bool flag14 = !flag13;
					obj14 = 0;
					flag8 = false;
					if (!flag14)
					{
						goto IL_0fa5;
					}
				}
				goto IL_0fcc;
			}
			if (command != RoutingCommand.PerformanceWeekly)
			{
				if (command != RoutingCommand.PerformanceMonthly)
				{
					return;
				}
				object obj18 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v110+E4]");
				if ((nint)0 != 0)
				{
					bool flag15 = Rating != null;
					bool flag16 = !flag15;
					object obj20 = !flag16;
					obj21 = 0;
					obj22 = null;
					if (obj20 == null)
					{
						goto IL_061a;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag17 = Rating != null;
					bool flag18 = !flag17;
					obj21 = 0;
					obj22 = null;
					if (flag18)
					{
						goto IL_061a;
					}
				}
				Rating.isOn = true;
				performence = Performence;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
				object obj23 = (nint)0 & (nint)1;
				bool flag19 = obj23 == null;
				obj21 = 0;
				obj22 = (UnityEngine.Object)1;
				if (flag19)
				{
					goto IL_067c;
				}
				obj24 = 0;
				obj25 = (UnityEngine.Object)1;
				toggle2 = Performence;
				goto IL_13bb;
			}
			object obj26 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj27 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v41+E4]");
			if ((nint)0 != 0)
			{
				bool flag20 = Rating != null;
				bool flag21 = !flag20;
				object obj28 = !flag21;
				obj29 = 0;
				obj30 = null;
				if (obj28 == null)
				{
					goto IL_0a6a;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag22 = Rating != null;
				bool flag23 = !flag22;
				obj29 = 0;
				obj30 = null;
				if (flag23)
				{
					goto IL_0a6a;
				}
			}
			Rating.isOn = true;
			performence2 = Performence;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
			object obj31 = (nint)0 & (nint)1;
			bool flag24 = obj31 == null;
			obj29 = 0;
			obj30 = (UnityEngine.Object)1;
			if (flag24)
			{
				goto IL_0acc;
			}
			obj32 = 0;
			obj33 = (UnityEngine.Object)1;
			toggle3 = Performence;
			goto IL_145f;
		}
		object obj37;
		UnityEngine.Object obj38;
		Toggle arrangment;
		Toggle toggle4;
		object obj40;
		UnityEngine.Object obj41;
		if (command <= RoutingCommand.WeeklyRank)
		{
			if (command != RoutingCommand.Bio)
			{
				if (command != RoutingCommand.WeeklyRank)
				{
					return;
				}
				object obj34 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj35 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v68+E4]");
				if ((nint)0 != 0)
				{
					bool flag25 = Rating != null;
					bool flag26 = !flag25;
					object obj36 = !flag26;
					obj37 = 0;
					obj38 = null;
					if (obj36 == null)
					{
						goto IL_0288;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag27 = Rating != null;
					bool flag28 = !flag27;
					obj37 = 0;
					obj38 = null;
					if (flag28)
					{
						goto IL_0288;
					}
				}
				Rating.isOn = true;
				arrangment = Arrangment;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
				object obj39 = (nint)0 & (nint)1;
				bool flag29 = obj39 == null;
				obj37 = 0;
				obj38 = (UnityEngine.Object)1;
				if (flag29)
				{
					goto IL_02ea;
				}
				obj40 = 0;
				obj41 = (UnityEngine.Object)1;
				toggle4 = Arrangment;
				goto IL_130a;
			}
			object obj42 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v29+E4]");
			if ((nint)0 != 0)
			{
				if (!(Bio != null))
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag30 = Bio != null;
				bool flag31 = !flag30;
				object obj44 = !flag31;
				if (obj44 == null)
				{
					return;
				}
			}
			Bio.isOn = true;
			return;
		}
		object obj48;
		UnityEngine.Object obj49;
		Toggle arrangment2;
		Toggle toggle5;
		object obj51;
		UnityEngine.Object obj52;
		if (command != RoutingCommand.MonthlyRank)
		{
			if (command != RoutingCommand.OverallRank)
			{
				return;
			}
			object obj45 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj46 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v39+E4]");
			if ((nint)0 != 0)
			{
				bool flag32 = Rating != null;
				bool flag33 = !flag32;
				object obj47 = !flag33;
				obj48 = 0;
				obj49 = null;
				if (obj47 == null)
				{
					goto IL_0451;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag34 = Rating != null;
				bool flag35 = !flag34;
				obj48 = 0;
				obj49 = null;
				if (flag35)
				{
					goto IL_0451;
				}
			}
			Rating.isOn = true;
			arrangment2 = Arrangment;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
			object obj50 = (nint)0 & (nint)1;
			bool flag36 = obj50 == null;
			obj48 = 0;
			obj49 = (UnityEngine.Object)1;
			if (flag36)
			{
				goto IL_04b3;
			}
			obj51 = 0;
			obj52 = (UnityEngine.Object)1;
			toggle5 = Arrangment;
			goto IL_1369;
		}
		object obj53 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj54 = obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v11+E4]");
		object obj56;
		UnityEngine.Object obj57;
		if ((nint)0 != 0)
		{
			bool flag37 = Rating != null;
			bool flag38 = !flag37;
			object obj55 = !flag38;
			obj56 = 0;
			obj57 = null;
			if (obj55 == null)
			{
				goto IL_0821;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag39 = Rating != null;
			bool flag40 = !flag39;
			obj56 = 0;
			obj57 = null;
			if (flag40)
			{
				goto IL_0821;
			}
		}
		Rating.isOn = true;
		Toggle arrangment3 = Arrangment;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
		object obj58 = (nint)0 & (nint)1;
		bool flag41 = obj58 == null;
		obj56 = 0;
		obj57 = (UnityEngine.Object)1;
		if (flag41)
		{
			goto IL_0883;
		}
		object obj59 = 0;
		UnityEngine.Object obj60 = (UnityEngine.Object)1;
		Toggle toggle6 = Arrangment;
		goto IL_140d;
		IL_1252:
		Trophies.isOn = true;
		obj14 = 0;
		flag8 = true;
		goto IL_1279;
		IL_145f:
		object obj61 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj62 = default(object);
		obj62..ctor();
		_ = 0;
		object obj63 = obj62 + 32;
		obj63 = toggle3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj62);
		Toggle toggle7 = Weeklyperformence;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
		object obj64 = (nint)0 & (nint)1;
		bool flag42 = obj64 == null;
		object obj65 = 0;
		IEnumerator enumerator = (IEnumerator)obj62;
		if (flag42)
		{
			goto IL_0930;
		}
		object obj66 = obj61;
		obj9 = 0;
		bool flag43 = (byte)(int)obj62 != 0;
		toggle = Weeklyperformence;
		goto IL_135c;
		IL_14b1:
		object obj67 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2584;
		object obj68 = obj67;
		goto IL_14d2;
		IL_12f5:
		obj68 = obj8;
		flag43 = (byte)(int)obj10 != 0;
		goto IL_14d2;
		IL_0180:
		_ = 1;
		obj8 = obj6;
		obj9 = obj4;
		obj10 = obj5;
		toggle = achiements;
		goto IL_12f5;
		IL_0102:
		achiements = Achiements;
		obj6 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2584;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
		object obj69 = (nint)0 & (nint)1;
		bool flag44 = obj69 == null;
		object obj70 = !flag44;
		obj8 = obj6;
		obj9 = obj4;
		obj10 = obj5;
		toggle = Achiements;
		if (obj70 == null)
		{
			goto IL_0180;
		}
		goto IL_12f5;
		IL_14d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj71 = default(object);
		obj71..ctor();
		_ = 0;
		object obj72 = obj71 + 32;
		obj72 = toggle;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine2 = StartCoroutine((IEnumerator)obj71);
		return;
		IL_0821:
		arrangment3 = Arrangment;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
		object obj73 = (nint)0 & (nint)1;
		bool flag45 = obj73 == null;
		object obj74 = !flag45;
		obj59 = obj56;
		obj60 = obj57;
		toggle6 = Arrangment;
		if (obj74 == null)
		{
			goto IL_0883;
		}
		goto IL_140d;
		IL_0883:
		_ = 1;
		obj59 = obj56;
		obj60 = obj57;
		toggle6 = arrangment3;
		goto IL_140d;
		IL_140d:
		obj61 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj75 = default(object);
		obj75..ctor();
		_ = 0;
		object obj76 = obj75 + 32;
		obj76 = toggle6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine3 = StartCoroutine((IEnumerator)obj75);
		toggle7 = Monthlyrank;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
		object obj77 = (nint)0 & (nint)1;
		bool flag46 = obj77 == null;
		object obj78 = !flag46;
		obj65 = 0;
		enumerator = (IEnumerator)obj75;
		obj66 = obj61;
		obj9 = 0;
		flag43 = (byte)(int)obj75 != 0;
		toggle = Monthlyrank;
		if (obj78 == null)
		{
			goto IL_0930;
		}
		goto IL_135c;
		IL_0acc:
		_ = 1;
		obj32 = obj29;
		obj33 = obj30;
		toggle3 = performence2;
		goto IL_145f;
		IL_130a:
		obj61 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj79 = default(object);
		obj79..ctor();
		_ = 0;
		object obj80 = obj79 + 32;
		obj80 = toggle4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine4 = StartCoroutine((IEnumerator)obj79);
		toggle7 = Weeklyrank;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
		object obj81 = (nint)0 & (nint)1;
		bool flag47 = obj81 == null;
		obj65 = 0;
		enumerator = (IEnumerator)obj79;
		if (flag47)
		{
			goto IL_0930;
		}
		obj66 = obj61;
		obj9 = 0;
		flag43 = (byte)(int)obj79 != 0;
		toggle = Weeklyrank;
		goto IL_135c;
		IL_061a:
		performence = Performence;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
		object obj82 = (nint)0 & (nint)1;
		bool flag48 = obj82 == null;
		object obj83 = !flag48;
		obj24 = obj21;
		obj25 = obj22;
		toggle2 = Performence;
		if (obj83 == null)
		{
			goto IL_067c;
		}
		goto IL_13bb;
		IL_135c:
		obj68 = obj66;
		goto IL_14d2;
		IL_0288:
		arrangment = Arrangment;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
		object obj84 = (nint)0 & (nint)1;
		bool flag49 = obj84 == null;
		object obj85 = !flag49;
		obj40 = obj37;
		obj41 = obj38;
		toggle4 = Arrangment;
		if (obj85 == null)
		{
			goto IL_02ea;
		}
		goto IL_130a;
		IL_0930:
		_ = 1;
		obj66 = obj61;
		obj9 = obj65;
		flag43 = (byte)(int)enumerator != 0;
		toggle = toggle7;
		goto IL_135c;
		IL_0451:
		arrangment2 = Arrangment;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
		object obj86 = (nint)0 & (nint)1;
		bool flag50 = obj86 == null;
		object obj87 = !flag50;
		obj51 = obj48;
		obj52 = obj49;
		toggle5 = Arrangment;
		if (obj87 == null)
		{
			goto IL_04b3;
		}
		goto IL_1369;
		IL_04b3:
		_ = 1;
		obj51 = obj48;
		obj52 = obj49;
		toggle5 = arrangment2;
		goto IL_1369;
		IL_1369:
		obj61 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj88 = default(object);
		obj88..ctor();
		_ = 0;
		object obj89 = obj88 + 32;
		obj89 = toggle5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine5 = StartCoroutine((IEnumerator)obj88);
		toggle7 = Overallrank;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
		object obj90 = (nint)0 & (nint)1;
		bool flag51 = obj90 == null;
		obj65 = 0;
		enumerator = (IEnumerator)obj88;
		if (flag51)
		{
			goto IL_0930;
		}
		obj66 = obj61;
		obj9 = 0;
		flag43 = (byte)(int)obj88 != 0;
		toggle = Overallrank;
		goto IL_135c;
		IL_13bb:
		obj61 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj91 = default(object);
		obj91..ctor();
		_ = 0;
		object obj92 = obj91 + 32;
		obj92 = toggle2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine6 = StartCoroutine((IEnumerator)obj91);
		toggle7 = MonthlyPerformance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
		object obj93 = (nint)0 & (nint)1;
		bool flag52 = obj93 == null;
		obj65 = 0;
		enumerator = (IEnumerator)obj91;
		if (flag52)
		{
			goto IL_0930;
		}
		obj66 = obj61;
		obj9 = 0;
		flag43 = (byte)(int)obj91 != 0;
		toggle = MonthlyPerformance;
		goto IL_135c;
		IL_02ea:
		_ = 1;
		obj40 = obj37;
		obj41 = obj38;
		toggle4 = arrangment;
		goto IL_130a;
		IL_067c:
		_ = 1;
		obj24 = obj21;
		obj25 = obj22;
		toggle2 = performence;
		goto IL_13bb;
		IL_102e:
		_ = 1;
		obj9 = obj14;
		flag43 = flag8;
		Toggle toggle8;
		toggle = toggle8;
		goto IL_14b1;
		IL_1279:
		toggle8 = Titles;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
		object obj94 = (nint)0 & (nint)1;
		if (obj94 == null)
		{
			goto IL_102e;
		}
		obj9 = obj14;
		flag43 = flag8;
		toggle = Titles;
		goto IL_14b1;
		IL_0a6a:
		performence2 = Performence;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
		object obj95 = (nint)0 & (nint)1;
		bool flag53 = obj95 == null;
		object obj96 = !flag53;
		obj32 = obj29;
		obj33 = obj30;
		toggle3 = Performence;
		if (obj96 == null)
		{
			goto IL_0acc;
		}
		goto IL_145f;
		IL_0fa5:
		Trophies.isOn = true;
		obj14 = 0;
		flag8 = true;
		goto IL_0fcc;
		IL_0fcc:
		toggle8 = Subtrophies;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7892]");
		object obj97 = (nint)0 & (nint)1;
		bool flag54 = obj97 == null;
		object obj98 = !flag54;
		obj9 = obj14;
		flag43 = flag8;
		toggle = Subtrophies;
		if (obj98 == null)
		{
			goto IL_102e;
		}
		goto IL_14b1;
	}

	private void DelayedSetToggle(Toggle toggle)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = toggle;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj2);
	}

	private static IEnumerator DelayedSetToggleInternal(Toggle toggle)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = toggle;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}
}
