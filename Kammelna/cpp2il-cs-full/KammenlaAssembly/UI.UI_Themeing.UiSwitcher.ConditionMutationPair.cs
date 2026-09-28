using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using UI.Conditions;
using UI.Mutations;
using UnityEngine;
using UnityEngine.TextCore;

namespace UI.UI_Themeing;

public class UiSwitcher : MonoBehaviour
{
	[Serializable]
	private struct ConditionMutationPair
	{
		public ICondition Condition;

		public IMutation Mutation;
	}

	private List<ConditionMutationPair> cases;

	private void Start()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003b: Expected O, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_005b: Expected O, but got I
		//IL_03a1: Expected I, but got O
		//IL_0445: Expected I, but got O
		//IL_03c4: Expected I, but got O
		//IL_03f7: Expected O, but got I4
		//IL_00e5: Expected O, but got I
		//IL_0551: Expected I, but got O
		//IL_0569: Expected O, but got I
		//IL_0120: Expected O, but got I
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected O, but got Unknown
		//IL_05df: Expected O, but got I
		//IL_0200: Expected O, but got I
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_03db: Expected O, but got I4
		//IL_03e0: Expected I, but got O
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_02d4: Expected O, but got I
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_008e: Expected O, but got I
		//IL_00a1: Expected O, but got I4
		//IL_030f: Expected O, but got I
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected O, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		object obj5 = default(object);
		List<ConditionMutationPair>.Enumerator enumerator3 = default(List<ConditionMutationPair>.Enumerator);
		nint num = default(nint);
		if (cases != null)
		{
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1688;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = (nint)0 + (nint)1560;
			object obj4 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3936;
			obj5 = (nint)0 + (nint)720;
			List<ConditionMutationPair>.Enumerator enumerator = cases.GetEnumerator();
			List<ConditionMutationPair>.Enumerator enumerator2 = default(List<ConditionMutationPair>.Enumerator);
			object obj6 = default(object);
			bool flag2 = default(bool);
			List<ConditionMutationPair>.Enumerator enumerator4 = default(List<ConditionMutationPair>.Enumerator);
			object obj16 = default(object);
			Action action = default(Action);
			object obj15;
			object obj21;
			for (; enumerator2.MoveNext(); Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X0_v39+8]"), obj15 = 0, Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v562 @ X0_v39] (should have been resolved before IL gen)"), obj21 = 0)
			{
				GameObject gameObject = base.gameObject;
				object obj11;
				if (obj6 != null)
				{
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v11+12E]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v11+12E]");
					if ((nint)0 == 0)
					{
						goto IL_019d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v11+B0]");
					object obj9 = (nint)0 + (nint)8;
					bool flag = flag2;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X10_v21-8]");
						object obj10 = 0 - obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X10_v21-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj11 = obj9 + 16;
						obj8--;
						obj10 = obj8 - 1;
						bool flag3 = obj10 == null;
						flag2 = (nint)obj8 != 1;
						flag = flag2;
						obj9 = obj11;
						if (flag2)
						{
							continue;
						}
						goto IL_019d;
					}
					object obj12 = obj9 + 3;
					object obj13 = obj7 + obj12;
					object obj14 = obj13 + 312;
					flag2 = flag;
					obj11 = obj9;
					goto IL_052f;
				}
				NullReferenceException ex = new NullReferenceException();
				num = unchecked((nint)null);
				goto IL_03e5;
				IL_03e5:
				enumerator3 = enumerator4;
				enumerator4 = (List<ConditionMutationPair>.Enumerator)0;
				goto IL_0650;
				IL_027d:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				goto IL_05cf;
				IL_05cf:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v32+8]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v500 @ X0_v32] (should have been resolved before IL gen)");
				GameObject gameObject2 = base.gameObject;
				if (obj16 != null)
				{
					object obj17 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v17+12E]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v17+12E]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v17+B0]");
						obj11 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X10_v11-8]");
							object obj10 = 0 - obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X10_v11-8]");
							if (0 == (nint)obj4)
							{
								break;
							}
							obj11 += 16;
							obj18--;
							obj10 = obj18 - 1;
							bool flag3 = obj10 == null;
							flag2 = (nint)obj18 != 1;
							if (flag2)
							{
								continue;
							}
							goto IL_006f;
						}
						object obj19 = obj17 + obj11;
						object obj20 = obj19 + 312;
						continue;
					}
					goto IL_006f;
				}
				NullReferenceException ex2 = new NullReferenceException();
				obj21 = 0;
				num = unchecked((nint)null);
				goto IL_03e5;
				IL_006f:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				continue;
				IL_019d:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				goto IL_052f;
				IL_052f:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v430 @ X0_v27] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action..ctor(this, (IntPtr)obj3);
				object obj22 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v14+12E]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v14+12E]");
				if ((nint)0 == 0)
				{
					goto IL_027d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v14+B0]");
				object obj24 = (nint)0 + (nint)8;
				bool flag4 = flag2;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X10_v16-8]");
					object obj10 = 0 - obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X10_v16-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj11 = obj24 + 16;
					obj23--;
					obj10 = obj23 - 1;
					bool flag3 = obj10 == null;
					flag2 = (nint)obj23 != 1;
					flag4 = flag2;
					obj24 = obj11;
					if (flag2)
					{
						continue;
					}
					goto IL_027d;
				}
				object obj25 = obj22 + obj24;
				object obj26 = obj25 + 312;
				flag2 = flag4;
				obj11 = obj24;
				goto IL_05cf;
			}
			num = (nint)obj5;
			enumerator2.Dispose();
			goto IL_03af;
		}
		goto IL_0650;
		IL_03af:
		ToggleUI();
		return;
		IL_0650:
		NullReferenceException ex3 = new NullReferenceException();
		bool flag5 = num != 1;
		OutOfMemoryException ex4 = (OutOfMemoryException)(object)ex3;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj5;
			enumerator3.Dispose();
			object obj27 = default(object);
			if (obj27 == null)
			{
				goto IL_03af;
			}
			ex4 = new OutOfMemoryException();
			List<ConditionMutationPair>.Enumerator enumerator4 = (List<ConditionMutationPair>.Enumerator)obj27;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B19C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void OnDestroy()
	{
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0476: Expected I, but got O
		//IL_00bc: Expected I, but got O
		//IL_00ca: Expected I, but got O
		//IL_03fa: Expected I, but got O
		//IL_0417: Expected O, but got I4
		//IL_0428: Expected O, but got I4
		//IL_0104: Expected O, but got I
		//IL_0592: Expected O, but got I
		//IL_013f: Expected O, but got I
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected O, but got Unknown
		//IL_021f: Expected O, but got I
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_030a: Expected O, but got I
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I4
		//IL_0345: Expected O, but got I
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		object obj6 = default(object);
		List<ConditionMutationPair>.Enumerator enumerator3 = default(List<ConditionMutationPair>.Enumerator);
		nint num2 = default(nint);
		if (cases != null)
		{
			object obj = (nint)0 + (nint)728;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = (nint)0 + (nint)1560;
			object obj4 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1688;
			object obj5 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3936;
			obj6 = (nint)0 + (nint)720;
			List<ConditionMutationPair>.Enumerator enumerator = cases.GetEnumerator();
			List<ConditionMutationPair>.Enumerator enumerator2 = default(List<ConditionMutationPair>.Enumerator);
			Action action = default(Action);
			object obj7 = default(object);
			bool flag2 = default(bool);
			object obj23 = default(object);
			object obj22;
			while (true)
			{
				object obj12;
				nint num;
				if (enumerator2.MoveNext())
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					num = (nint)obj3;
					action..ctor(this, (IntPtr)obj3);
					if (obj7 != null)
					{
						object obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v11+12E]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v11+12E]");
						if ((nint)0 == 0)
						{
							goto IL_01bc;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v11+B0]");
						object obj10 = (nint)0 + (nint)8;
						bool flag = flag2;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X10_v21-8]");
							object obj11 = 0 - obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X10_v21-8]");
							if (0 == (nint)obj4)
							{
								break;
							}
							obj12 = obj10 + 16;
							obj9--;
							obj11 = obj9 - 1;
							bool flag3 = obj11 == null;
							flag2 = (nint)obj9 != 1;
							flag = flag2;
							obj10 = obj12;
							if (flag2)
							{
								continue;
							}
							goto IL_01bc;
						}
						object obj13 = obj10 + 1;
						object obj14 = obj8 + obj13;
						object obj15 = obj14 + 312;
						flag2 = flag;
						obj12 = obj10;
						goto IL_0560;
					}
					NullReferenceException ex = new NullReferenceException();
					num2 = (nint)this;
					break;
				}
				enumerator2.Dispose();
				return;
				IL_0560:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v26+8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v427 @ X0_v26] (should have been resolved before IL gen)");
				object obj16 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v14+12E]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v14+12E]");
				if ((nint)0 == 0)
				{
					goto IL_029c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v14+B0]");
				object obj18 = (nint)0 + (nint)8;
				bool flag4 = flag2;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X10_v16-8]");
					object obj11 = 0 - obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X10_v16-8]");
					if (0 == (nint)obj4)
					{
						break;
					}
					obj12 = obj18 + 16;
					obj17--;
					obj11 = obj17 - 1;
					bool flag3 = obj11 == null;
					flag2 = (nint)obj17 != 1;
					flag4 = flag2;
					obj18 = obj12;
					if (flag2)
					{
						continue;
					}
					goto IL_029c;
				}
				object obj19 = obj18 + 4;
				object obj20 = obj16 + obj19;
				object obj21 = obj20 + 312;
				flag2 = flag4;
				obj12 = obj18;
				goto IL_05f8;
				IL_0092:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v551 @ X0_v34] (should have been resolved before IL gen)");
				obj22 = 0;
				continue;
				IL_029c:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num = 4;
				goto IL_05f8;
				IL_05f8:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v29+8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v493 @ X0_v29] (should have been resolved before IL gen)");
				if (obj23 != null)
				{
					object obj24 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v17+12E]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v17+12E]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v17+B0]");
						obj12 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X10_v11-8]");
							object obj11 = 0 - obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X10_v11-8]");
							if (0 == (nint)obj5)
							{
								break;
							}
							obj12 += 16;
							obj25--;
							obj11 = obj25 - 1;
							bool flag3 = obj11 == null;
							flag2 = (nint)obj25 != 1;
							if (flag2)
							{
								continue;
							}
							goto IL_007a;
						}
						object obj26 = obj12 + 1;
						object obj27 = obj24 + obj26;
						object obj28 = obj27 + 312;
						goto IL_0092;
					}
					goto IL_007a;
				}
				NullReferenceException ex2 = new NullReferenceException();
				break;
				IL_007a:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num = 1;
				goto IL_0092;
				IL_01bc:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				goto IL_0560;
			}
			obj22 = 0;
			List<ConditionMutationPair>.Enumerator enumerator4 = default(List<ConditionMutationPair>.Enumerator);
			enumerator3 = enumerator4;
			enumerator4 = (List<ConditionMutationPair>.Enumerator)0;
		}
		NullReferenceException ex3 = new NullReferenceException();
		bool flag5 = num2 != 1;
		OutOfMemoryException ex4 = (OutOfMemoryException)(object)ex3;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num2 = (nint)obj6;
			enumerator3.Dispose();
			object obj29 = default(object);
			if (obj29 == null)
			{
				return;
			}
			ex4 = new OutOfMemoryException();
			List<ConditionMutationPair>.Enumerator enumerator4 = (List<ConditionMutationPair>.Enumerator)obj29;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B19C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void ToggleUI()
	{
		//IL_0617: Expected O, but got I4
		//IL_0620: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0046: Expected O, but got I
		//IL_063b: Expected I, but got O
		//IL_059d: Expected I, but got O
		//IL_054f: Expected O, but got I4
		//IL_00c3: Expected O, but got I
		//IL_0437: Expected I, but got O
		//IL_0447: Expected O, but got I
		//IL_018e: Expected O, but got I4
		//IL_04d6: Expected O, but got I4
		//IL_06d6: Expected O, but got I4
		//IL_00fe: Expected O, but got I
		//IL_0482: Expected O, but got I
		//IL_07cd: Expected I, but got O
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected O, but got Unknown
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected O, but got Unknown
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected O, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected O, but got Unknown
		//IL_01f6: Expected I, but got O
		//IL_0206: Expected O, but got I
		//IL_0325: Expected I, but got O
		//IL_0335: Expected O, but got I
		//IL_0072: Expected O, but got I4
		//IL_02ec: Expected O, but got I4
		//IL_0241: Expected O, but got I
		//IL_0370: Expected O, but got I
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected O, but got Unknown
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Expected O, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected O, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected O, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		bool flag = cases == null;
		List<ConditionMutationPair>.Enumerator enumerator = (List<ConditionMutationPair>.Enumerator)0;
		List<ConditionMutationPair>.Enumerator enumerator2 = (List<ConditionMutationPair>.Enumerator)0;
		UiSwitcher uiSwitcher = this;
		object obj3 = default(object);
		object obj4 = default(object);
		nint num = default(nint);
		object obj15;
		if (!flag)
		{
			object obj = (nint)0 + (nint)728;
			object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1688;
			obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3936;
			obj4 = (nint)0 + (nint)720;
			List<ConditionMutationPair>.Enumerator enumerator3 = cases.GetEnumerator();
			uiSwitcher = this;
			List<ConditionMutationPair>.Enumerator enumerator4 = default(List<ConditionMutationPair>.Enumerator);
			object obj5 = default(object);
			bool flag3 = default(bool);
			UiSwitcher uiSwitcher2 = default(UiSwitcher);
			List<ConditionMutationPair>.Enumerator enumerator5 = default(List<ConditionMutationPair>.Enumerator);
			object obj16 = default(object);
			while (true)
			{
				num = (nint)obj;
				if (enumerator4.MoveNext())
				{
					if (obj5 != null)
					{
						object obj6 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v17+12E]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v17+12E]");
						if ((nint)0 == 0)
						{
							goto IL_017b;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v17+B0]");
						object obj8 = (nint)0 + (nint)8;
						bool flag2 = flag3;
						object obj10;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X10_v31-8]");
							object obj9 = 0 - obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X10_v31-8]");
							if (0 == (nint)obj2)
							{
								break;
							}
							obj10 = obj8 + 16;
							obj7--;
							obj9 = obj7 - 1;
							bool flag4 = obj9 == null;
							flag3 = (nint)obj7 != 1;
							flag2 = flag3;
							obj8 = obj10;
							if (flag3)
							{
								continue;
							}
							goto IL_017b;
						}
						object obj11 = obj8 + 2;
						object obj12 = obj6 + obj11;
						object obj13 = obj12 + 312;
						flag3 = flag2;
						obj10 = obj8;
						goto IL_06a2;
					}
					NullReferenceException ex = new NullReferenceException();
					goto IL_052d;
				}
				uiSwitcher = null;
				goto IL_0725;
				IL_0509:
				NullReferenceException ex2 = new NullReferenceException();
				uiSwitcher = uiSwitcher2;
				goto IL_052d;
				IL_052d:
				enumerator = enumerator5;
				object obj14 = obj5;
				enumerator2 = enumerator5;
				enumerator5 = (List<ConditionMutationPair>.Enumerator)0;
				break;
				IL_0725:
				enumerator4.Dispose();
				obj14 = obj5;
				enumerator2 = enumerator5;
				goto IL_0412;
				IL_005f:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj15 = 3;
				goto IL_0077;
				IL_0077:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v608 @ X0_v47] (should have been resolved before IL gen)");
				uiSwitcher = uiSwitcher2;
				continue;
				IL_017b:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj15 = 2;
				goto IL_06a2;
				IL_06a2:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X0_v32+8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v462 @ X0_v32] (should have been resolved before IL gen)");
				bool flag5 = obj16 == null;
				object obj17 = !flag5;
				if (obj17 == null)
				{
					if ((object)uiSwitcher2 != null)
					{
						nint num2 = (nint)uiSwitcher2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v26 (Il2CppClass<UI.UI_Themeing.UiSwitcher>)+12E]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v26 (Il2CppClass<UI.UI_Themeing.UiSwitcher>)+12E]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v26 (Il2CppClass<UI.UI_Themeing.UiSwitcher>)+B0]");
							object obj10 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X10_v19-8]");
								object obj9 = 0 - obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X10_v19-8]");
								if (0 == (nint)obj3)
								{
									break;
								}
								obj10 += 16;
								obj18--;
								obj9 = obj18 - 1;
								bool flag4 = obj9 == null;
								flag3 = (nint)obj18 != 1;
								if (flag3)
								{
									continue;
								}
								goto IL_005f;
							}
							object obj19 = obj10 + 3;
							object obj20 = num2 + obj19;
							object obj21 = obj20 + 312;
							goto IL_0077;
						}
						goto IL_005f;
					}
					goto IL_0509;
				}
				while (true)
				{
					num = (nint)obj;
					bool flag6 = enumerator4.MoveNext();
					bool flag7 = !flag6;
					uiSwitcher = uiSwitcher2;
					if (flag7)
					{
						break;
					}
					if ((object)uiSwitcher2 != null)
					{
						nint num3 = (nint)uiSwitcher2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v21 (Il2CppClass<UI.UI_Themeing.UiSwitcher>)+12E]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v21 (Il2CppClass<UI.UI_Themeing.UiSwitcher>)+12E]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v21 (Il2CppClass<UI.UI_Themeing.UiSwitcher>)+B0]");
							object obj10 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X10_v19-8]");
								object obj9 = 0 - obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X10_v19-8]");
								if (0 == (nint)obj3)
								{
									break;
								}
								obj10 += 16;
								obj22--;
								obj9 = obj22 - 1;
								bool flag4 = obj9 == null;
								if ((nint)obj22 != 1)
								{
									continue;
								}
								goto IL_02d9;
							}
							object obj23 = obj10 + 3;
							object obj24 = num3 + obj23;
							object obj25 = obj24 + 312;
							goto IL_02f1;
						}
						goto IL_02d9;
					}
					goto IL_0509;
					IL_02f1:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v669 @ X0_v39] (should have been resolved before IL gen)");
					continue;
					IL_02d9:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj15 = 3;
					goto IL_02f1;
				}
				goto IL_0725;
			}
		}
		NullReferenceException ex3 = new NullReferenceException();
		bool flag8 = num != 1;
		OutOfMemoryException ex4 = (OutOfMemoryException)(object)ex3;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj4;
			enumerator.Dispose();
			object obj26 = default(object);
			if (obj26 == null)
			{
				goto IL_0412;
			}
			ex4 = new OutOfMemoryException();
			List<ConditionMutationPair>.Enumerator enumerator5 = (List<ConditionMutationPair>.Enumerator)obj26;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B19C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0412:
		if ((object)uiSwitcher == null)
		{
			return;
		}
		nint num4 = (nint)uiSwitcher;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v6 (Il2CppClass<UI.UI_Themeing.UiSwitcher>)+12E]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v6 (Il2CppClass<UI.UI_Themeing.UiSwitcher>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04c3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v6 (Il2CppClass<UI.UI_Themeing.UiSwitcher>)+B0]");
		object obj28 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X10_v8-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj28 += 16;
			obj27--;
			if ((nint)obj27 != 1)
			{
				continue;
			}
			goto IL_04c3;
		}
		object obj29 = obj28 + 2;
		object obj30 = num4 + obj29;
		object obj31 = obj30 + 312;
		goto IL_07a8;
		IL_04c3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj15 = 2;
		goto IL_07a8;
		IL_07a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v554 @ X0_v18] (should have been resolved before IL gen)");
	}
}
