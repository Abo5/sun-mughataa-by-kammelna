using System;
using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Spine;
using Unity.Properties;
using UnityEngine.Purchasing.Telemetry;

namespace Server.Models;

public class TournamentConfig
{
	public enum PrizeCondition
	{
		Required,
		Optional,
		Disallowed
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<KeyValuePair<int, int>, int[]> <>9__48_0;

		public static Func<KeyValuePair<int, int>, int[]> <>9__48_1;

		public static Func<int[], int> <>9__49_0;

		public static Func<int[], int> <>9__49_1;

		public static Func<int[], int> <>9__49_2;

		public static Func<int[], int> <>9__49_3;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3456;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int[] <OnJsonDeserialized>b__48_0(KeyValuePair<int, int> pair)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_004a: Expected I4, but got O
			//IL_0089: Expected I4, but got O
			object obj = typeof(TypeConverter<ushort, char>) + 3048;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			int[] array = default(int[]);
			if (array != null)
			{
				if (array.Length != 0)
				{
					array[0] = (int)pair;
					if (array.Length != 1)
					{
						object obj2 = (object)pair >> 32;
						array[1] = (int)obj2;
						return array;
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			return (int[])(object)new NullReferenceException();
		}

		internal int[] <OnJsonDeserialized>b__48_1(KeyValuePair<int, int> pair)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_004a: Expected I4, but got O
			//IL_0089: Expected I4, but got O
			object obj = typeof(TypeConverter<ushort, char>) + 3048;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			int[] array = default(int[]);
			if (array != null)
			{
				if (array.Length != 0)
				{
					array[0] = (int)pair;
					if (array.Length != 1)
					{
						object obj2 = (object)pair >> 32;
						array[1] = (int)obj2;
						return array;
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			return (int[])(object)new NullReferenceException();
		}

		internal int <RebuildLookups>b__49_0(int[] pair)
		{
			return Enumerable.First(pair);
		}

		internal int <RebuildLookups>b__49_1(int[] pair)
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)1672;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC7038");
			int result = default(int);
			return result;
		}

		internal int <RebuildLookups>b__49_2(int[] pair)
		{
			return Enumerable.First(pair);
		}

		internal int <RebuildLookups>b__49_3(int[] pair)
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)1672;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC7038");
			int result = default(int);
			return result;
		}
	}

	public int[][] FixedFee;

	private float <CreationFee>k__BackingField;

	public int[][] AllowedSizes;

	private int <MaxStartTime>k__BackingField;

	private int <InstantTournamentStartTime>k__BackingField;

	private bool <CreationAllowed>k__BackingField;

	private PrizeCondition <TournamentPrizeCondition>k__BackingField;

	private Dictionary<int, int> <AllowedSizesWire>k__BackingField;

	private Dictionary<int, int> <FixedFeesWire>k__BackingField;

	private TimeSpan <MaxStartTimeWire>k__BackingField;

	private TimeSpan <InstantStartTimeWire>k__BackingField;

	private Dictionary<int, int> _acesMinPrizeBySize;

	private Dictionary<int, int> _fixedFeePriceBySize;

	public float CreationFee
	{
		get
		{
			return <CreationFee>k__BackingField;
		}
		private set
		{
			<CreationFee>k__BackingField = value;
		}
	}

	public int MinSize
	{
		get
		{
			//IL_003a: Expected I4, but got O
			if (_acesMinPrizeBySize != null)
			{
				Dictionary<int, int>.KeyCollection keys = _acesMinPrizeBySize.Keys;
				return Enumerable.Min(keys);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int MaxSize
	{
		get
		{
			//IL_003a: Expected I4, but got O
			if (_acesMinPrizeBySize != null)
			{
				Dictionary<int, int>.KeyCollection keys = _acesMinPrizeBySize.Keys;
				return Enumerable.Max(keys);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int MaxStartTime
	{
		get
		{
			return <MaxStartTime>k__BackingField;
		}
		private set
		{
			<MaxStartTime>k__BackingField = value;
		}
	}

	public int InstantTournamentStartTime
	{
		get
		{
			return <InstantTournamentStartTime>k__BackingField;
		}
		private set
		{
			<InstantTournamentStartTime>k__BackingField = value;
		}
	}

	private bool CreationAllowed
	{
		get
		{
			return <CreationAllowed>k__BackingField;
		}
		set
		{
			<CreationAllowed>k__BackingField = value;
		}
	}

	public bool CanCreateTournament
	{
		get
		{
			if (<CreationAllowed>k__BackingField)
			{
				return Enumerable.Any((IEnumerable<object>)AllowedSizes);
			}
			return false;
		}
	}

	public PrizeCondition TournamentPrizeCondition
	{
		get
		{
			return <TournamentPrizeCondition>k__BackingField;
		}
		private set
		{
			<TournamentPrizeCondition>k__BackingField = value;
		}
	}

	private Dictionary<int, int> AllowedSizesWire
	{
		get
		{
			return <AllowedSizesWire>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private Dictionary<int, int> FixedFeesWire
	{
		get
		{
			return <FixedFeesWire>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private TimeSpan MaxStartTimeWire
	{
		get
		{
			return <MaxStartTimeWire>k__BackingField;
		}
		set
		{
			<MaxStartTimeWire>k__BackingField = value;
		}
	}

	private TimeSpan InstantStartTimeWire
	{
		get
		{
			return <InstantStartTimeWire>k__BackingField;
		}
		set
		{
			<InstantStartTimeWire>k__BackingField = value;
		}
	}

	public TournamentConfig()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_014c: Expected O, but got I8
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0210: Expected O, but got I4
		//IL_0226: Expected O, but got I
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_03d9: Expected O, but got I8
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_049d: Expected O, but got I4
		//IL_04b3: Expected O, but got I
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected O, but got Unknown
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected O, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 1504;
		object obj2 = typeof(TypeConverter<ushort, char>) + 3048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+18]");
		if ((nint)0 != 0)
		{
			_ = 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+18]");
			if ((nint)0 != 1)
			{
				_ = 2000;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+18]");
				if ((nint)0 != 0)
				{
					object obj4 = default(object);
					object obj3 = obj4 + 32;
					object obj5 = default(object);
					obj3 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v14+18]");
					if ((nint)0 != 0)
					{
						_ = 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v14+18]");
						if ((nint)0 != 1)
						{
							_ = 4000;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+18]");
							if ((object)(0 & 0xFFFFFFFEL) != null)
							{
								object obj6 = obj4 + 40;
								object obj7 = default(object);
								obj6 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v19+18]");
								if ((nint)0 != 0)
								{
									_ = 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v19+18]");
									if ((nint)0 != 1)
									{
										_ = 8000;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+18]");
										object obj8 = (nint)0 >= (nint)2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+18]");
										if ((object)(~obj8 | ((object)(-2) == null)) == null)
										{
											object obj9 = obj4 + 48;
											object obj10 = default(object);
											obj9 = obj10;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											object obj11 = this + 16;
											obj11 = obj4;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											_ = 1036831949;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v28+18]");
											if ((nint)0 != 0)
											{
												_ = 8;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v28+18]");
												if ((nint)0 != 1)
												{
													_ = 30000;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v26+18]");
													if ((nint)0 != 0)
													{
														object obj13 = default(object);
														object obj12 = obj13 + 32;
														object obj14 = default(object);
														obj12 = obj14;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v33+18]");
														if ((nint)0 != 0)
														{
															_ = 16;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v33+18]");
															if ((nint)0 != 1)
															{
																_ = 40000;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v26+18]");
																if ((object)(0 & 0xFFFFFFFEL) != null)
																{
																	object obj15 = obj13 + 40;
																	object obj16 = default(object);
																	obj15 = obj16;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v38+18]");
																	if ((nint)0 != 0)
																	{
																		_ = 32;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v38+18]");
																		if ((nint)0 != 1)
																		{
																			_ = 50000;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v26+18]");
																			object obj17 = (nint)0 >= (nint)2;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v26+18]");
																			if ((object)(~obj17 | ((object)(-2) == null)) == null)
																			{
																				object obj18 = obj13 + 48;
																				object obj19 = default(object);
																				obj18 = obj19;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																				object obj20 = this + 32;
																				obj20 = obj13;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253210]");
																				<MaxStartTime>k__BackingField = 0;
																				base..ctor();
																				RebuildLookups();
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
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void OnJsonDeserialized(StreamingContext context)
	{
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected O, but got Unknown
		//IL_06cd: Expected O, but got I
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_04b7: Expected O, but got I
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_00db: Expected O, but got I4
		//IL_04eb: Expected O, but got I4
		//IL_04fc: Expected O, but got I4
		//IL_0387: Expected O, but got I
		//IL_03b8: Expected O, but got I4
		//IL_03c1: Expected O, but got I4
		//IL_03d2: Expected O, but got I4
		//IL_0265: Expected O, but got I
		//IL_0275: Expected O, but got I
		//IL_0297: Expected O, but got I4
		//IL_0148: Expected I, but got O
		//IL_0042: Expected O, but got I
		//IL_0052: Expected O, but got I
		//IL_0074: Expected O, but got I4
		//IL_0535: Expected O, but got I4
		//IL_0304: Expected I, but got O
		//IL_01fe: Expected O, but got I
		//IL_020e: Expected O, but got I
		//IL_0230: Expected O, but got I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_010b: Expected O, but got I4
		//IL_05c4: Expected O, but got I
		//IL_056c: Invalid comparison between F8 and I8
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_02c7: Expected O, but got I4
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected O, but got Unknown
		//IL_0717: Expected O, but got I
		//IL_0728: Expected I, but got O
		//IL_0746: Expected O, but got I
		//IL_0761: Expected O, but got I4
		//IL_0606: Expected O, but got I4
		//IL_0449: Expected O, but got I
		//IL_0478: Expected O, but got I4
		//IL_0481: Expected O, but got I4
		//IL_077d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Expected O, but got Unknown
		//IL_0798: Expected O, but got I
		//IL_07a9: Expected I, but got O
		//IL_07c7: Expected O, but got I
		//IL_07e2: Expected O, but got I4
		//IL_013b: Expected O, but got I
		//IL_0640: Expected O, but got I4
		//IL_0800: Expected I4, but got F8
		//IL_0834: Expected O, but got I4
		//IL_0841: Expected O, but got I8
		//IL_084e: Expected O, but got I8
		//IL_085f: Expected O, but got I4
		//IL_0590: Expected F8, but got I8
		//IL_02f7: Expected O, but got I
		//IL_0677: Invalid comparison between F8 and I8
		//IL_0891: Expected I4, but got F8
		//IL_069b: Expected F8, but got I8
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3456;
		object obj2 = (nint)0 + (nint)2752;
		object obj4;
		Func<KeyValuePair<int, int>, object> func;
		if (<AllowedSizesWire>k__BackingField != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v60+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v60+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v46+8]");
				func = (Func<KeyValuePair<int, int>, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v46+8]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					goto IL_00e9;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v60+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v46+8]");
				func = (Func<KeyValuePair<int, int>, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v46+8]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					goto IL_00e9;
				}
			}
			goto IL_0140;
		}
		goto IL_018e;
		IL_02a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v42+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		object obj9;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v39+B8]");
			obj9 = 0;
		}
		object obj10 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)3680;
		Func<KeyValuePair<int, int>, object> func2 = default(Func<KeyValuePair<int, int>, object>);
		func2..ctor(obj9, (IntPtr)obj11);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v38+B8]");
		object obj13 = (nint)0 + (nint)16;
		obj13 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj14 = 0;
		Func<KeyValuePair<int, int>, object> func3 = func2;
		goto IL_02fc;
		IL_05a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj16;
		object obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v14+B8]");
		object obj17 = 0;
		TimeSpan timeSpan = (TimeSpan)obj17;
		TimeSpan timeSpan2;
		bool flag4 = timeSpan2 > (TimeSpan)obj17;
		bool flag5 = !flag4;
		object obj19;
		object obj18 = obj19;
		double num2;
		double num = num2;
		object obj20 = 0;
		if (!flag5)
		{
			goto IL_0615;
		}
		goto IL_07ef;
		IL_03e0:
		TimeSpan timeSpan3 = <InstantStartTimeWire>k__BackingField;
		object obj21 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v27+E4]");
		bool flag6 = (nint)0 == 0;
		obj19 = obj18;
		num2 = num;
		object obj22 = obj21;
		timeSpan2 = <InstantStartTimeWire>k__BackingField;
		if (!flag6)
		{
			goto IL_0439;
		}
		goto IL_05a2;
		IL_00e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v60+E4]");
		bool flag7 = (nint)0 == 0;
		object obj23 = !flag7;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v52+B8]");
			obj4 = 0;
		}
		object obj25 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj26 = (nint)0 + (nint)3672;
		Func<KeyValuePair<int, int>, object> func4 = default(Func<KeyValuePair<int, int>, object>);
		func4..ctor(obj4, (IntPtr)obj26);
		object obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v51+B8]");
		object obj28 = (nint)0 + (nint)8;
		obj28 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj14 = 0;
		func = func4;
		goto IL_0140;
		IL_034a:
		object obj29 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v4+E4]");
		object obj33;
		TimeSpan timeSpan4;
		object obj32;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v4+B8]");
			object obj30 = 0;
			timeSpan4 = (TimeSpan)obj30;
			bool flag8 = <MaxStartTimeWire>k__BackingField > (TimeSpan)obj30;
			bool flag9 = !flag8;
			object obj31 = !flag9;
			obj32 = 0;
			TimeSpan timeSpan5 = (TimeSpan)obj30;
			obj33 = 0;
			if (obj31 == null)
			{
				goto IL_03e0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj34 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v24+B8]");
			object obj35 = 0;
			timeSpan4 = (TimeSpan)obj35;
			bool flag10 = <MaxStartTimeWire>k__BackingField > (TimeSpan)obj35;
			bool flag11 = !flag10;
			obj32 = 0;
			TimeSpan timeSpan5 = (TimeSpan)obj35;
			obj33 = 0;
			if (flag11)
			{
				goto IL_03e0;
			}
		}
		object obj36 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v18+E4]");
		bool flag12 = (nint)0 == 0;
		object obj37 = !flag12;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan6 = default(TimeSpan);
		num = timeSpan6.TotalSeconds;
		double num3 = ((num != 9.218868437227405E+18) ? num : 2147483648.0);
		<MaxStartTime>k__BackingField = (int)num3;
		timeSpan3 = <InstantStartTimeWire>k__BackingField;
		obj21 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v27+E4]");
		bool flag13 = (nint)0 == 0;
		object obj38 = !flag13;
		obj18 = 9218868437227405312L;
		obj19 = 9218868437227405312L;
		num2 = num;
		timeSpan4 = (TimeSpan)0;
		obj32 = obj33;
		obj22 = obj21;
		timeSpan2 = <InstantStartTimeWire>k__BackingField;
		if (obj38 != null)
		{
			goto IL_0439;
		}
		goto IL_05a2;
		IL_02fc:
		nint num4 = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCD610");
		IEnumerable<object> source = default(IEnumerable<object>);
		object[] array = Enumerable.ToArray(source);
		object obj39 = this + 16;
		obj39 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		StreamingContext streamingContext = (StreamingContext)array;
		goto IL_034a;
		IL_0140:
		num4 = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCD610");
		IEnumerable<object> source2 = default(IEnumerable<object>);
		object[] array2 = Enumerable.ToArray(source2);
		object obj40 = this + 32;
		obj40 = array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		streamingContext = (StreamingContext)array2;
		goto IL_018e;
		IL_018e:
		obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		if (<FixedFeesWire>k__BackingField != null)
		{
			object obj41 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v42+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v42+B8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v33+10]");
				func3 = (Func<KeyValuePair<int, int>, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v33+10]");
				bool flag14 = (nint)0 == 0;
				object obj42 = !flag14;
				if (obj42 == null)
				{
					goto IL_02a5;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj41 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v42+B8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v33+10]");
				func3 = (Func<KeyValuePair<int, int>, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v33+10]");
				bool flag15 = (nint)0 == 0;
				object obj43 = !flag15;
				if (obj43 == null)
				{
					goto IL_02a5;
				}
			}
			goto IL_02fc;
		}
		goto IL_034a;
		IL_0439:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v27+B8]");
		object obj44 = 0;
		timeSpan = (TimeSpan)obj44;
		bool flag16 = timeSpan3 > (TimeSpan)obj44;
		bool flag17 = !flag16;
		object obj45 = !flag17;
		obj20 = 0;
		if (obj45 != null)
		{
			goto IL_0615;
		}
		goto IL_07ef;
		IL_07ef:
		RebuildLookups();
		return;
		IL_0615:
		object obj46 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v8+E4]");
		bool flag18 = (nint)0 == 0;
		object obj47 = !flag18;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double totalMinutes = timeSpan6.TotalMinutes;
		double num5 = ((totalMinutes != 9.218868437227405E+18) ? totalMinutes : 2147483648.0);
		<InstantTournamentStartTime>k__BackingField = (int)num5;
		goto IL_07ef;
	}

	private void RebuildLookups()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_021f: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_02d3: Expected O, but got I4
		//IL_0261: Expected O, but got I
		//IL_0271: Expected O, but got I
		//IL_0293: Expected O, but got I4
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Expected O, but got Unknown
		//IL_0867: Expected O, but got I
		//IL_0878: Expected I, but got O
		//IL_0896: Expected O, but got I
		//IL_0332: Expected O, but got I4
		//IL_034b: Expected O, but got I4
		//IL_0353: Expected I, but got O
		//IL_035b: Expected I, but got O
		//IL_0303: Expected O, but got I
		//IL_0397: Expected O, but got I
		//IL_03a7: Expected O, but got I
		//IL_03b7: Expected O, but got I
		//IL_03d9: Expected O, but got I4
		//IL_014f: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_016f: Expected O, but got I
		//IL_0191: Expected O, but got I4
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_0431: Expected O, but got I4
		//IL_01b8: Expected O, but got I4
		//IL_01c0: Expected I, but got O
		//IL_01c8: Expected I, but got O
		//IL_061b: Expected O, but got I
		//IL_062b: Expected O, but got I
		//IL_064d: Expected O, but got I4
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected O, but got Unknown
		//IL_08d7: Expected O, but got I
		//IL_08e8: Expected I, but got O
		//IL_0906: Expected O, but got I
		//IL_055e: Expected I, but got O
		//IL_04e2: Expected O, but got I
		//IL_04f2: Expected O, but got I
		//IL_0461: Expected O, but got I
		//IL_0756: Expected O, but got I
		//IL_0766: Expected O, but got I
		//IL_0788: Expected O, but got I4
		//IL_0685: Expected O, but got I4
		//IL_0816: Expected O, but got I
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Expected O, but got Unknown
		//IL_058c: Expected O, but got I
		//IL_059c: Expected O, but got I
		//IL_05be: Expected O, but got I4
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Expected O, but got Unknown
		//IL_0967: Expected O, but got I
		//IL_096f: Expected I, but got O
		//IL_0980: Expected I, but got O
		//IL_099e: Expected O, but got I
		//IL_07c8: Expected O, but got I4
		//IL_06e4: Expected O, but got I4
		//IL_06ed: Expected O, but got I4
		//IL_070e: Expected O, but got I4
		//IL_06b5: Expected O, but got I
		//IL_09c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Expected O, but got Unknown
		//IL_09df: Expected O, but got I
		//IL_09f0: Expected I, but got O
		//IL_0a0e: Expected O, but got I
		//IL_05ec: Expected I, but got O
		//IL_07f8: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 3456;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7BC6]");
		object obj3 = (nint)0 & (nint)1;
		int[][] array;
		int[][] array2;
		object obj4;
		if (obj3 != null)
		{
			array = AllowedSizes;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			array2 = AllowedSizes;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			array = AllowedSizes;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			array2 = AllowedSizes;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v44+18]");
		Func<object, int> func = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v44+18]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		array = array2;
		object obj9 = obj4;
		if (obj8 != null)
		{
			goto IL_00ee;
		}
		goto IL_02b1;
		IL_0466:
		object obj11;
		object obj10 = obj11;
		IEnumerable<object> source;
		Func<object, int> keySelector;
		Func<object, int> func2;
		Dictionary<int, int> dictionary = Enumerable.ToDictionary(source, keySelector, func2);
		object obj12 = this + 88;
		obj12 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v12+E4]");
		object obj14;
		Func<object, int> func3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v12+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v17+28]");
			func3 = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v17+28]");
			bool flag4 = (nint)0 == 0;
			object obj15 = obj13;
			if (!flag4)
			{
				goto IL_051f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v12+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v17+28]");
			func3 = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v17+28]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			object obj15 = obj13;
			if (obj16 != null)
			{
				goto IL_051f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v23+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v24+B8]");
			obj14 = 0;
		}
		object obj19 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)3704;
		nint num = (nint)obj20;
		Func<object, int> func4 = default(Func<object, int>);
		func4..ctor(obj14, (IntPtr)obj20);
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v22+B8]");
		object obj22 = (nint)0 + (nint)40;
		obj22 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v12+E4]");
		bool flag7 = (nint)0 == 0;
		object obj23 = !flag7;
		obj10 = 0;
		Dictionary<int, int> dictionary2 = (Dictionary<int, int>)(object)func4;
		Func<object, int> func5 = (Func<object, int>)obj20;
		func3 = func4;
		object obj24 = 0;
		Dictionary<int, int> dictionary3 = (Dictionary<int, int>)(object)func4;
		Func<object, int> func6 = func4;
		object obj25 = obj13;
		if (obj23 != null)
		{
			goto IL_057c;
		}
		goto IL_0734;
		IL_07a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v12+E4]");
		bool flag8 = (nint)0 == 0;
		object obj26 = !flag8;
		object obj28;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj27 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v12+B8]");
			obj28 = 0;
		}
		object obj29 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj30 = (nint)0 + (nint)3712;
		Func<object, int> func7 = default(Func<object, int>);
		func7..ctor(obj28, (IntPtr)obj30);
		object obj31 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v11+B8]");
		object obj32 = (nint)0 + (nint)48;
		obj32 = func7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Func<object, int> elementSelector = func7;
		Func<object, int> func8;
		Func<object, int> keySelector2 = func8;
		goto IL_07fd;
		IL_07fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X20_v4-48]");
		Dictionary<int, int> dictionary4 = Enumerable.ToDictionary((IEnumerable<object>)0, keySelector2, elementSelector);
		object obj33 = this + 96;
		obj33 = dictionary4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0099:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v44+18]");
		func = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v44+18]");
		bool flag9 = (nint)0 == 0;
		obj9 = obj4;
		array2 = array;
		if (!flag9)
		{
			goto IL_00ee;
		}
		goto IL_02b1;
		IL_02b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v47+E4]");
		bool flag10 = (nint)0 == 0;
		object obj34 = !flag10;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj35 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v51+B8]");
			obj7 = 0;
		}
		object obj36 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj37 = (nint)0 + (nint)3688;
		Func<object, int> func9 = default(Func<object, int>);
		func9..ctor(obj7, (IntPtr)obj37);
		object obj38 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v49+B8]");
		object obj39 = (nint)0 + (nint)24;
		obj39 = func9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+E4]");
		bool flag11 = (nint)0 == 0;
		object obj40 = !flag11;
		func = func9;
		array = array2;
		object obj41 = 0;
		nint num2 = (nint)func9;
		nint num3 = (nint)obj37;
		Func<object, int> func10 = func9;
		object obj42 = obj4;
		if (obj40 != null)
		{
			goto IL_0143;
		}
		goto IL_0379;
		IL_0734:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v12+B8]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v6+30]");
		elementSelector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v6+30]");
		bool flag12 = (nint)0 == 0;
		object obj43 = !flag12;
		func8 = func6;
		keySelector2 = func6;
		if (obj43 == null)
		{
			goto IL_07a6;
		}
		goto IL_07fd;
		IL_057c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v12+B8]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v6+30]");
		elementSelector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v6+30]");
		bool flag13 = (nint)0 == 0;
		object obj44 = !flag13;
		keySelector2 = func3;
		if (obj44 == null)
		{
			obj24 = obj10;
			dictionary3 = dictionary2;
			num = (nint)func5;
			func8 = func3;
			goto IL_07a6;
		}
		goto IL_07fd;
		IL_00ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+E4]");
		bool flag14 = (nint)0 == 0;
		object obj45 = default(object);
		obj41 = obj45;
		IntPtr intPtr = default(IntPtr);
		num2 = intPtr;
		IntPtr intPtr2 = default(IntPtr);
		num3 = intPtr2;
		func10 = func;
		obj42 = obj4;
		array2 = array;
		if (!flag14)
		{
			goto IL_0143;
		}
		goto IL_0379;
		IL_0379:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj46 = (nint)0 + (nint)1664;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+B8]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v33+20]");
		func2 = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v33+20]");
		bool flag15 = (nint)0 == 0;
		object obj48 = !flag15;
		Func<object, int> func11 = func10;
		IEnumerable<object> enumerable = array2;
		obj11 = obj46;
		keySelector = func10;
		source = array2;
		if (obj48 == null)
		{
			goto IL_040f;
		}
		goto IL_0466;
		IL_0143:
		obj11 = (nint)0 + (nint)1664;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+B8]");
		obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v33+20]");
		func2 = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v33+20]");
		bool flag16 = (nint)0 == 0;
		object obj49 = !flag16;
		keySelector = func;
		source = array;
		if (obj49 == null)
		{
			obj41 = 0;
			num2 = (nint)func9;
			num3 = (nint)obj37;
			obj46 = obj11;
			func11 = func;
			enumerable = array;
			goto IL_040f;
		}
		goto IL_0466;
		IL_051f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v12+E4]");
		bool flag17 = (nint)0 == 0;
		dictionary2 = dictionary;
		func5 = func2;
		obj24 = obj10;
		dictionary3 = dictionary;
		num = (nint)func2;
		func6 = func3;
		obj25 = obj13;
		if (!flag17)
		{
			goto IL_057c;
		}
		goto IL_0734;
		IL_040f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+E4]");
		bool flag18 = (nint)0 == 0;
		object obj50 = !flag18;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj51 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v39+B8]");
			obj47 = 0;
		}
		object obj52 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj53 = (nint)0 + (nint)3696;
		Func<object, int> func12 = default(Func<object, int>);
		func12..ctor(obj47, (IntPtr)obj53);
		object obj54 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v38+B8]");
		object obj55 = (nint)0 + (nint)32;
		obj55 = func12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		func2 = func12;
		obj11 = obj46;
		keySelector = func11;
		source = enumerable;
		goto IL_0466;
	}

	public IEnumerable<int> GetSizes()
	{
		if (_acesMinPrizeBySize != null)
		{
			return _acesMinPrizeBySize.Keys;
		}
		return (IEnumerable<int>)new NullReferenceException();
	}

	public int GetSize(int index)
	{
		//IL_00c5: Expected I4, but got I8
		//IL_00df: Expected O, but got I4
		//IL_00b3: Expected I4, but got O
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0070: Expected O, but got I
		int num = (int)(index & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			int[][] allowedSizes = AllowedSizes;
			if (AllowedSizes == null)
			{
				goto IL_00a5;
			}
			if (index < allowedSizes.Length)
			{
				object obj2 = AllowedSizes + index;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v11+20]");
				return Enumerable.First((IEnumerable<int>)0);
			}
		}
		if (_acesMinPrizeBySize != null)
		{
			Dictionary<int, int>.KeyCollection keys = _acesMinPrizeBySize.Keys;
			return Enumerable.Min(keys);
		}
		goto IL_00a5;
		IL_00a5:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public int GetPrizeForSize(int size)
	{
		//IL_0081: Expected I4, but got O
		if (_acesMinPrizeBySize != null)
		{
			int num = (_acesMinPrizeBySize.ContainsKey(size) ? 1 : 0);
			if (num == 0)
			{
				return num;
			}
			if (_acesMinPrizeBySize != null)
			{
				return _acesMinPrizeBySize.get_Item(size);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public int GetFixedFeeForSize(int size)
	{
		//IL_0081: Expected I4, but got O
		if (_fixedFeePriceBySize != null)
		{
			int num = (_fixedFeePriceBySize.ContainsKey(size) ? 1 : 0);
			if (num == 0)
			{
				return num;
			}
			if (_fixedFeePriceBySize != null)
			{
				return _fixedFeePriceBySize.get_Item(size);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}
}
