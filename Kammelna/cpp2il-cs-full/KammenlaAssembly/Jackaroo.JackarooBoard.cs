using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;

namespace Jackaroo;

[Serializable]
public class JackarooBoard
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<int, JackarooNode> <>9__15_0;

		public static Func<JackarooNode, bool> <>9__65_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal JackarooNode <InitializeBoard>b__15_0(int _)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			JackarooNode jackarooNode = default(JackarooNode);
			jackarooNode..ctor(JackarooNodeType.None);
			return jackarooNode;
		}

		internal bool <MoveMarbleFromBoardToGraveyard>b__65_0(JackarooNode node)
		{
			//IL_0044: Expected I4, but got O
			if (node != null)
			{
				return node.<Marble>k__BackingField == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public JackarooNodeType type;

		internal JackarooNode <CreateNodeGroup>b__0(int _)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			JackarooNode jackarooNode = default(JackarooNode);
			jackarooNode..ctor(type);
			return jackarooNode;
		}
	}

	private JackarooRules <JackarooRules>k__BackingField;

	private bool _isSpectator;

	private int _myPlayerIndex;

	private int _mySeatIndex;

	private List<JackarooNode> <Nodes>k__BackingField;

	private List<JackarooNode> <NodesAndBases>k__BackingField;

	private (JackarooNode, JackarooNode)[] _homesAndBasesEntryNodes;

	private List<List<JackarooNode>> _basesNodes;

	private List<List<JackarooNode>> _graveyardsNodes;

	private readonly List<JackarooNode> _serverNodes;

	private readonly List<JackarooNode> _serverBases;

	private readonly List<JackarooNode> _serverNodesAndBases;

	private List<List<JackarooMarble>> _playersGraveyardMarbles;

	private List<List<JackarooMarble>> _playersPlantedMarbles;

	private readonly List<JackarooMarble> _othersPlantedMarbles;

	private readonly List<JackarooNode> _emptyList;

	public JackarooRules JackarooRules
	{
		get
		{
			return <JackarooRules>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<JackarooNode> Nodes
	{
		get
		{
			return <Nodes>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<JackarooNode> NodesAndBases
	{
		get
		{
			return <NodesAndBases>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public IReadOnlyList<JackarooNode> BasesNodes
	{
		get
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)1992;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C958DC");
			IReadOnlyList<JackarooNode> result = default(IReadOnlyList<JackarooNode>);
			return result;
		}
	}

	public IReadOnlyList<JackarooNode> GraveyardsNodes
	{
		get
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)1992;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C958DC");
			IReadOnlyList<JackarooNode> result = default(IReadOnlyList<JackarooNode>);
			return result;
		}
	}

	public IReadOnlyList<JackarooNode> ServerNodes => _serverNodes;

	public IReadOnlyList<JackarooNode> ServerNodesAndBases => _serverNodesAndBases;

	public unsafe List<JackarooMove> GetAllowedJackarooMoves(ref List<JackarooMove> allowedJackarooMoves, IReadOnlyCollection<Card> cards, JackarooLastActionInfo lastAction, IReadOnlyCollection<Card> nextPlayerCards, Card lastPlayedCard, Action<Card, JackarooMarbleMono> onGuardedMarbleAdded = null)
	{
		//IL_0362: Expected O, but got I4
		//IL_03af: Expected I4, but got O
		//IL_03b7: Expected I4, but got O
		//IL_0023: Expected I4, but got I8
		//IL_0389: Expected I4, but got O
		//IL_0391: Expected I4, but got O
		//IL_011a: Expected O, but got I4
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_04c2: Expected O, but got I4
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected Ref, but got Unknown
		//IL_052b: Expected O, but got I4
		//IL_021a: Expected I, but got O
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_030c: Expected I4, but got O
		Card card = default(Card);
		IReadOnlyCollection<Card> readOnlyCollection = default(IReadOnlyCollection<Card>);
		Action<Card, JackarooMarbleMono> action;
		IReadOnlyCollection<Card> readOnlyCollection3;
		List<JackarooMove> list2;
		ref List<JackarooMove> reference;
		IReadOnlyCollection<Card> readOnlyCollection2;
		int num;
		int num2;
		JackarooActions jackarooActions;
		if (lastAction != null)
		{
			int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(_myPlayerIndex, -1, 1, 5);
			if (((LastActionInfo)lastAction).<ActionPlayer>k__BackingField != rotatedNextIndex)
			{
				goto IL_00f1;
			}
			if (lastAction.<JackarooAction>k__BackingField != JackarooActions.BURN_OTHER_CARD_RANDOM)
			{
				if (lastAction.<JackarooAction>k__BackingField != JackarooActions.BURN_OTHER_CARD)
				{
					goto IL_00f1;
				}
				List<JackarooMove> burnCardsMoves = JackarooMove.GetBurnCardsMoves(readOnlyCollection);
				bool flag = allowedJackarooMoves == null;
				readOnlyCollection2 = null;
				num = 5;
				num2 = 1;
				jackarooActions = JackarooActions.NONE;
				if (!flag)
				{
					((List<object>)(object)allowedJackarooMoves).AddRange((IEnumerable<object>)burnCardsMoves);
					goto IL_03d2;
				}
			}
			else
			{
				List<JackarooMove> list = allowedJackarooMoves;
				JackarooMove burnCardMove = JackarooMove.GetBurnCardMove(card, JackarooActions.BURN_MY_CARD);
				bool flag2 = allowedJackarooMoves == null;
				readOnlyCollection2 = null;
				num = 5;
				num2 = 0;
				jackarooActions = JackarooActions.BURN_MY_CARD;
				if (!flag2)
				{
					int version = list._version + 1;
					list._version = version;
					JackarooMove[] items = list._items;
					bool flag3 = list._items == null;
					readOnlyCollection2 = null;
					num = 5;
					num2 = 0;
					jackarooActions = JackarooActions.BURN_MY_CARD;
					if (!flag3)
					{
						bool flag4 = list._size < items.Length;
						object obj = !flag4;
						if (obj == null)
						{
							int size = list._size + 1;
							list._size = size;
							object obj2 = list._items + list._size;
							reference = ref *(List<JackarooMove>*)(obj2 + 32);
							reference = ref *(List<JackarooMove>*)burnCardMove;
							action = null;
							readOnlyCollection3 = (IReadOnlyCollection<Card>)5;
							readOnlyCollection = null;
							list2 = (List<JackarooMove>)(object)burnCardMove;
							goto IL_0660;
						}
						((List<object>)(object)allowedJackarooMoves).AddWithResize((object)burnCardMove);
						goto IL_03d2;
					}
				}
			}
			goto IL_0552;
		}
		bool flag5 = AreAllMarblesInBases();
		bool flag6 = !flag5;
		object obj3 = !flag6;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			readOnlyCollection2 = nextPlayerCards;
			num = (int)lastAction;
			num2 = (int)readOnlyCollection;
			jackarooActions = (JackarooActions)3;
		}
		else
		{
			readOnlyCollection2 = nextPlayerCards;
			num = (int)lastAction;
			num2 = (int)readOnlyCollection;
			jackarooActions = JackarooActions.MOVE;
		}
		goto IL_05ed;
		IL_03d2:
		return allowedJackarooMoves;
		IL_0616:
		JackarooRules jackarooRules;
		int rotatedPlayerIndex;
		List<JackarooMove> allowedJackarooMoves2 = jackarooRules.GetAllowedJackarooMoves(rotatedPlayerIndex, readOnlyCollection, nextPlayerCards, onGuardedMarbleAdded);
		ref List<JackarooMove> reference2 = ref *(List<JackarooMove>*)allowedJackarooMoves2;
		action = onGuardedMarbleAdded;
		readOnlyCollection3 = nextPlayerCards;
		list2 = allowedJackarooMoves2;
		reference = ref allowedJackarooMoves;
		goto IL_0660;
		IL_056e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (List<JackarooMove>)(object)new OutOfMemoryException();
		IL_0560:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_056e;
		IL_00f1:
		bool flag7 = AreAllMarblesInBases();
		bool flag8 = !flag7;
		object obj5 = !flag8;
		object obj6 = ~obj5;
		JackarooActions jackarooActions2 = ((obj6 != null) ? JackarooActions.MOVE : ((JackarooActions)3));
		bool flag9 = ((LastActionInfo)lastAction).<ActionPlayer>k__BackingField != _myPlayerIndex;
		readOnlyCollection2 = null;
		num = 5;
		num2 = 1;
		jackarooActions = jackarooActions2;
		if (!flag9)
		{
			bool flag10 = lastAction.<JackarooAction>k__BackingField != JackarooActions.STEAL;
			readOnlyCollection2 = null;
			num = 5;
			num2 = 1;
			jackarooActions = jackarooActions2;
			if (!flag10)
			{
				object obj7 = typeof(TypeConverter<ushort, char>) + 1944;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				IReadOnlyCollection<Card> readOnlyCollection4 = default(IReadOnlyCollection<Card>);
				bool flag11 = readOnlyCollection4 == null;
				readOnlyCollection2 = null;
				num = 5;
				num2 = 1;
				jackarooActions = JackarooActions.MOVE;
				if (!flag11)
				{
					bool flag12 = card == null;
					JackarooActions jackarooActions3 = JackarooActions.MOVE;
					if (!flag12)
					{
						nint num3 = (nint)readOnlyCollection4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v19 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+40]");
						jackarooActions3 = JackarooActions.NONE;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag13 = ex == null;
						readOnlyCollection2 = null;
						num = 5;
						num2 = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v19 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+40]");
						jackarooActions = JackarooActions.NONE;
						if (flag13)
						{
							goto IL_056e;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v25 (System.Collections.Generic.IReadOnlyCollection`1<Card>)+18]");
					bool flag14 = (nint)0 == 0;
					readOnlyCollection2 = null;
					num = 5;
					num2 = 1;
					jackarooActions = jackarooActions3;
					if (flag14)
					{
						goto IL_0560;
					}
					object obj8 = readOnlyCollection4 + 32;
					obj8 = card;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag15 = <JackarooRules>k__BackingField == null;
					readOnlyCollection2 = null;
					num = 5;
					num2 = 1;
					jackarooActions = (JackarooActions)card;
					if (!flag15)
					{
						readOnlyCollection = readOnlyCollection4;
						rotatedPlayerIndex = (int)jackarooActions2;
						jackarooRules = <JackarooRules>k__BackingField;
						goto IL_0616;
					}
				}
				goto IL_0552;
			}
		}
		goto IL_05ed;
		IL_0660:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_03d2;
		IL_0552:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0560;
		IL_05ed:
		jackarooRules = <JackarooRules>k__BackingField;
		if (<JackarooRules>k__BackingField == null)
		{
			goto IL_0552;
		}
		rotatedPlayerIndex = (int)jackarooActions;
		goto IL_0616;
	}

	public bool IsMe(int playerIndex)
	{
		//IL_0026: Expected O, but got I4
		//IL_00c5: Expected O, but got I4
		//IL_0045: Expected O, but got I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_00ae: Unsupported input type for neg.
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected I4, but got Unknown
		int num = _myPlayerIndex;
		bool flag = !_isSpectator;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = _myPlayerIndex - _mySeatIndex;
			object obj3 = obj2 + 4;
			object obj4 = obj3 & 3;
			object obj5 = 0 - obj3;
			object obj6 = obj5 & 3;
			object obj7 = ((0 >= (nint)obj5) ? ((object)(0 - obj6)) : obj4);
			num = obj7 + 1;
		}
		object obj8 = num - playerIndex;
		return obj8 == null;
	}

	public bool IsMyTeam(int rotatedPlayerIndex)
	{
		//IL_0012: Expected I4, but got I8
		//IL_0020: Expected O, but got I4
		int num = (int)(rotatedPlayerIndex & 0xFFFFFFFDL);
		object obj = num - 1;
		return obj == null;
	}

	public bool IsOpponent(int rotatedPlayerIndex)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_004d: Expected O, but got I4
		object obj = rotatedPlayerIndex - 2;
		bool flag = obj == null;
		object obj2 = !flag;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			object obj4 = rotatedPlayerIndex - 4;
			return obj4 == null;
		}
		return true;
	}

	public int GetTeamMateIndex(int rotatedPlayerIndex)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_00aa: Expected O, but got I
		//IL_00c7: Expected I4, but got O
		object obj = rotatedPlayerIndex - 1;
		bool flag = (nint)obj < 4;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = 119877632 + 704;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X9_v2+v12 @ X8_v1*4]");
			return 0;
		}
		int num = default(int);
		string message = num.ToString();
		object obj4 = typeof(System.IOAsyncCallback) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		ex..ctor(message);
		object obj5 = (nint)0 + (nint)344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (int)ex2;
	}

	private int GetPlayerRotatedIndex(int index)
	{
		//IL_001c: Expected O, but got I4
		//IL_0039: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_00a2: Unsupported input type for neg.
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected I4, but got Unknown
		bool flag = !_isSpectator;
		object obj = !flag;
		int num = default(int);
		if (obj == null)
		{
			object obj2 = num - _mySeatIndex;
			object obj3 = obj2 + 4;
			object obj4 = obj3 & 3;
			object obj5 = 0 - obj3;
			object obj6 = obj5 & 3;
			object obj7 = ((0 >= (nint)obj5) ? ((object)(0 - obj6)) : obj4);
			return obj7 + 1;
		}
		return num;
	}

	public int GetRotatedPlayerIndex(int playerIndex)
	{
		//IL_001c: Expected O, but got I4
		//IL_0039: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_00a2: Unsupported input type for neg.
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected I4, but got Unknown
		bool flag = !_isSpectator;
		object obj = !flag;
		int num = default(int);
		if (obj == null)
		{
			object obj2 = num - _mySeatIndex;
			object obj3 = obj2 + 4;
			object obj4 = obj3 & 3;
			object obj5 = 0 - obj3;
			object obj6 = obj5 & 3;
			object obj7 = ((0 >= (nint)obj5) ? ((object)(0 - obj6)) : obj4);
			return obj7 + 1;
		}
		return num;
	}

	public JackarooBoard(bool isSpectator, int myPlayerIndex, int mySeatIndex, JackarooAllowedRules allowedRules)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0049: Expected O, but got I
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0069: Expected O, but got I
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0277: Expected O, but got I
		//IL_029e: Expected O, but got I
		//IL_02f8: Expected O, but got I4
		//IL_0375: Expected O, but got I
		//IL_0385: Expected O, but got I
		//IL_0395: Expected O, but got I
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_042e: Expected O, but got I4
		//IL_04ab: Expected O, but got I
		//IL_04bb: Expected O, but got I
		//IL_04cb: Expected O, but got I
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected O, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_0564: Expected O, but got I4
		//IL_05e1: Expected O, but got I
		//IL_05f1: Expected O, but got I
		//IL_0601: Expected O, but got I
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected O, but got Unknown
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected O, but got Unknown
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected O, but got Unknown
		//IL_06af: Expected O, but got I4
		//IL_0724: Expected O, but got I
		//IL_0734: Expected O, but got I
		//IL_0744: Expected O, but got I
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0761: Expected O, but got Unknown
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Expected O, but got Unknown
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected O, but got Unknown
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Expected O, but got Unknown
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected O, but got Unknown
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1976;
		object obj2 = typeof(TypeConverter<ushort, char>) + 1416;
		object obj3 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3760;
		object obj4 = (nint)0 + (nint)2984;
		object obj5 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3744;
		object obj6 = (nint)0 + (nint)2952;
		object obj7 = typeof(List<AdaptivePerformanceScaler>) + 1944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj8 = this + 40;
		obj8 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj9 = this + 48;
		obj9 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj10 = this + 56;
		object obj11 = default(object);
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list3 = default(List<object>);
		list3..ctor(4);
		object obj12 = this + 64;
		obj12 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list4 = default(List<object>);
		list4..ctor(4);
		object obj13 = this + 72;
		obj13 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list5 = default(List<object>);
		list5..ctor();
		object obj14 = this + 80;
		obj14 = list5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list6 = default(List<object>);
		list6..ctor();
		object obj15 = this + 88;
		obj15 = list6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list7 = default(List<object>);
		list7..ctor();
		object obj16 = this + 96;
		obj16 = list7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list8 = default(List<object>);
		list8..ctor(4);
		object obj17 = this + 104;
		obj17 = list8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list9 = default(List<object>);
		list9..ctor(4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)2168;
		object obj19 = obj18;
		List<object> list10 = default(List<object>);
		list10..ctor(4);
		object obj20 = (nint)0 + (nint)2960;
		object obj21 = obj20;
		list9._version++;
		object[] items = list9._items;
		if ((object)(list9._size >= items.Length) == null)
		{
			list9._size++;
			object obj22 = (object)(items + list9._size) + 32;
			obj22 = list10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj23 = list10;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v4+20]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v22+C0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v23+70]");
			obj19 = 0;
			list9.AddWithResize((object)list10);
			object obj23 = list10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj26 = obj18;
		List<object> list11 = default(List<object>);
		list11..ctor(4);
		object obj27 = obj20;
		list9._version++;
		object[] items2 = list9._items;
		if ((object)(list9._size >= items2.Length) == null)
		{
			list9._size++;
			object obj28 = (object)(items2 + list9._size) + 32;
			obj28 = list11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj29 = list11;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v6+20]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v19+C0]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v20+70]");
			obj26 = 0;
			list9.AddWithResize((object)list11);
			object obj29 = list11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj32 = obj18;
		List<object> list12 = default(List<object>);
		list12..ctor(4);
		object obj33 = obj20;
		list9._version++;
		object[] items3 = list9._items;
		if ((object)(list9._size >= items3.Length) == null)
		{
			list9._size++;
			object obj34 = (object)(items3 + list9._size) + 32;
			obj34 = list12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj35 = list12;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v8+20]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v16+C0]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v17+70]");
			obj32 = 0;
			list9.AddWithResize((object)list12);
			object obj35 = list12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj38 = obj18;
		List<object> list13 = default(List<object>);
		list13..ctor(4);
		object obj39 = obj20;
		list9._version++;
		object[] items4 = list9._items;
		object obj40 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
		if ((object)(list9._size >= items4.Length) == null)
		{
			list9._size++;
			object obj41 = (object)(items4 + list9._size) + 32;
			obj41 = list13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v10+20]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v13+C0]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v14+70]");
			obj38 = 0;
			list9.AddWithResize((object)list13);
		}
		object obj44 = this + 112;
		obj44 = list9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list14 = default(List<object>);
		list14..ctor();
		object obj45 = this + 120;
		obj45 = list14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list15 = default(List<object>);
		list15..ctor();
		object obj46 = this + 128;
		obj46 = list15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		_isSpectator = isSpectator;
		_myPlayerIndex = myPlayerIndex;
		_mySeatIndex = mySeatIndex;
		InitializeBoard();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		JackarooRules jackarooRules = default(JackarooRules);
		jackarooRules..ctor(this, allowedRules);
		object obj47 = this + 16;
		obj47 = jackarooRules;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void InitializeBoard()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_05ad: Expected O, but got I4
		//IL_05c7: Expected O, but got I
		//IL_05d8: Expected O, but got I
		//IL_05e8: Expected O, but got I
		//IL_060a: Expected O, but got I4
		//IL_008f: Expected I4, but got O
		//IL_0052: Expected O, but got I4
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected O, but got Unknown
		//IL_0642: Expected O, but got I
		//IL_0653: Expected I, but got O
		//IL_0671: Expected O, but got I
		//IL_00d8: Expected O, but got I
		//IL_00e4: Expected O, but got I
		//IL_00f0: Expected O, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0116: Expected O, but got I4
		//IL_0082: Expected O, but got I
		//IL_01ee: Expected O, but got I4
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_02e5: Expected O, but got I4
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_0426: Expected O, but got I4
		//IL_0134: Expected O, but got I
		//IL_0144: Expected O, but got I
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected O, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected O, but got Unknown
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected O, but got Unknown
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected O, but got Unknown
		//IL_053f: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 288;
		IEnumerable<int> source = Enumerable.Range(0, 76);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj4 = (nint)0 + (nint)3488;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v23+8]");
		Func<int, object> selector = (Func<int, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v23+8]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v29+B8]");
				obj5 = 0;
			}
			object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1888;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)1456;
			Func<int, object> func = default(Func<int, object>);
			func..ctor(obj5, (IntPtr)obj10);
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v28+B8]");
			object obj12 = (nint)0 + (nint)8;
			obj12 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		int num = (int)obj4;
		IEnumerable<object> source2 = Enumerable.Select(source, selector);
		List<object> list = Enumerable.ToList(source2);
		if (this != null)
		{
			object obj13 = (nint)0 + (nint)2992;
			object obj14 = (nint)0 + (nint)1992;
			object obj15 = (nint)0 + (nint)3144;
			object obj16 = this + 40;
			obj16 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj17 = 0;
			int num2 = 0;
			JackarooBoard jackarooBoard = default(JackarooBoard);
			JackarooBoard basesNodes2 = default(JackarooBoard);
			IEnumerable<object> source3 = default(IEnumerable<object>);
			while (true)
			{
				(JackarooNode, JackarooNode)[] homesAndBasesEntryNodes = _homesAndBasesEntryNodes;
				(JackarooNode, JackarooNode) tuple = CreateHomeAndBaseEntry(num2);
				if (_homesAndBasesEntryNodes == null)
				{
					break;
				}
				bool flag4 = num2 < homesAndBasesEntryNodes.Length;
				object obj18 = !flag4;
				if (obj18 == null)
				{
					object obj19 = (object)_homesAndBasesEntryNodes + obj17;
					object obj20 = obj19 + 32;
					obj20 = tuple;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					List<object> basesNodes = (List<object>)(object)_basesNodes;
					List<JackarooNode> list2 = jackarooBoard.CreateNodeGroup(JackarooNodeType.Base, 4);
					if (_basesNodes == null)
					{
						break;
					}
					int version = basesNodes._version + 1;
					basesNodes._version = version;
					object[] items = basesNodes._items;
					if (basesNodes._items == null)
					{
						break;
					}
					bool flag5 = basesNodes._size < items.Length;
					object obj21 = !flag5;
					if (obj21 == null)
					{
						int size = basesNodes._size + 1;
						basesNodes._size = size;
						object obj22 = basesNodes._items + basesNodes._size;
						object obj23 = obj22 + 32;
						obj23 = list2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					else
					{
						((List<object>)(object)_basesNodes).AddWithResize((object)list2);
						basesNodes2 = (JackarooBoard)(object)_basesNodes;
					}
					List<object> graveyardsNodes = (List<object>)(object)_graveyardsNodes;
					List<JackarooNode> list3 = basesNodes2.CreateNodeGroup(JackarooNodeType.Graveyard, 4);
					if (_graveyardsNodes == null)
					{
						break;
					}
					object obj24 = obj13;
					int version2 = graveyardsNodes._version + 1;
					graveyardsNodes._version = version2;
					object[] items2 = graveyardsNodes._items;
					if (graveyardsNodes._items == null)
					{
						break;
					}
					bool flag6 = graveyardsNodes._size < items2.Length;
					object obj25 = !flag6;
					if (obj25 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v14+20]");
						object obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v17+C0]");
						object obj27 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v18+70]");
						num = 0;
						((List<object>)(object)_graveyardsNodes).AddWithResize((object)list3);
						num2++;
						obj17 += 16;
						if (num2 != 4)
						{
							continue;
						}
					}
					else
					{
						int size2 = graveyardsNodes._size + 1;
						graveyardsNodes._size = size2;
						object obj28 = graveyardsNodes._items + graveyardsNodes._size;
						object obj29 = obj28 + 32;
						obj29 = list3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						num2++;
						obj17 += 16;
						bool flag7 = num2 != 4;
						num = 4;
						if (flag7)
						{
							continue;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C958DC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D95D88");
					List<object> list4 = Enumerable.ToList(source3);
					object obj30 = this + 48;
					obj30 = list4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					ResetServerNodes();
					object obj31 = this + 104;
					object playersGraveyardMarbles = obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X19_v2-20]");
					List<List<JackarooMarble>> list5 = SetupMarbles((List<List<JackarooMarble>>)playersGraveyardMarbles, (List<List<JackarooNode>>)0);
					obj31 = obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return;
				}
				goto IL_0569;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0569;
		IL_0569:
		throw new IndexOutOfRangeException();
	}

	private List<JackarooNode> CreateNodeGroup(JackarooNodeType type, int count)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0072: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1888;
			object obj4 = (nint)0 + (nint)1472;
			IEnumerable<int> source = Enumerable.Range(0, count);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<int, object> func = default(Func<int, object>);
			func..ctor(obj2, (IntPtr)obj4);
			IEnumerable<object> source2 = Enumerable.Select(source, func);
			return (List<JackarooNode>)(object)Enumerable.ToList(source2);
		}
		return (List<JackarooNode>)(object)new NullReferenceException();
	}

	private (JackarooNode, JackarooNode) CreateHomeAndBaseEntry(int playerIndex)
	{
		//IL_0018: Expected O, but got I8
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_006a: Expected I4, but got O
		//IL_00d5: Expected O, but got I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0138: Expected I4, but got O
		if (<Nodes>k__BackingField != null)
		{
			object obj = playerIndex * 4294967277L;
			object obj2 = 76 + obj;
			object obj3 = obj2 * 1808407283;
			object obj4 = obj3 >> 37;
			object obj5 = obj4 + obj4;
			object obj6 = obj5 * 76;
			int num = obj2 - obj6;
			object obj7 = ((List<object>)(object)<Nodes>k__BackingField).get_Item(num);
			if (obj7 != null)
			{
				((JackarooNode)obj7).SetType(JackarooNodeType.Home);
				if (<Nodes>k__BackingField != null)
				{
					object obj8 = num + 74;
					object obj9 = obj8 * 4294956949L;
					object obj10 = obj8 + obj9;
					object obj11 = obj10 & 0x8000;
					object obj12 = obj10 >> 6;
					object obj13 = obj12 + obj11;
					object obj14 = obj13 * 76;
					int index = obj8 - obj14;
					object obj15 = ((List<object>)(object)<Nodes>k__BackingField).get_Item(index);
					if (obj15 != null)
					{
						((JackarooNode)obj15).SetType(JackarooNodeType.BaseEntry);
						return ((JackarooNode)obj7, (JackarooNode)obj15);
					}
				}
			}
		}
		return ((JackarooNode, JackarooNode))new NullReferenceException();
	}

	public JackarooNode GetPlayerHomeNode(int rotatedPlayerIndex)
	{
		//IL_0037: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_007c: Expected O, but got I
		(JackarooNode, JackarooNode)[] homesAndBasesEntryNodes = _homesAndBasesEntryNodes;
		if (_homesAndBasesEntryNodes != null)
		{
			object obj = rotatedPlayerIndex - 1;
			bool flag = (nint)obj < homesAndBasesEntryNodes.Length;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = (object)_homesAndBasesEntryNodes + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v2+20]");
				return (JackarooNode)0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return (JackarooNode)(object)new IndexOutOfRangeException();
	}

	public JackarooNode GetBaseEntryNode(int rotatedPlayerIndex)
	{
		//IL_0037: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_007c: Expected O, but got I
		(JackarooNode, JackarooNode)[] homesAndBasesEntryNodes = _homesAndBasesEntryNodes;
		if (_homesAndBasesEntryNodes != null)
		{
			object obj = rotatedPlayerIndex - 1;
			bool flag = (nint)obj < homesAndBasesEntryNodes.Length;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = (object)_homesAndBasesEntryNodes + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v2+28]");
				return (JackarooNode)0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return (JackarooNode)(object)new IndexOutOfRangeException();
	}

	public IReadOnlyList<JackarooNode> GetBaseNodes(int rotatedPlayerIndex)
	{
		//IL_0014: Expected O, but got I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_006f: Unsupported input type for neg.
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected I4, but got Unknown
		if (_basesNodes != null)
		{
			object obj = 5 - rotatedPlayerIndex;
			int num = obj & 3;
			object obj2 = 0 - obj;
			object obj3 = obj2 & 3;
			int index = ((0 >= (nint)obj2) ? (0 - obj3) : num);
			return (IReadOnlyList<JackarooNode>)((List<object>)(object)_basesNodes).get_Item(index);
		}
		return (IReadOnlyList<JackarooNode>)new NullReferenceException();
	}

	private int GetBaseStartIndex(int playerIndex)
	{
		//IL_000e: Expected O, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected I4, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0069: Unsupported input type for neg.
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected I4, but got Unknown
		object obj = 5 - playerIndex;
		int result = obj & 3;
		object obj2 = 0 - obj;
		object obj3 = obj2 & 3;
		if (0 < (nint)obj2)
		{
			return result;
		}
		return 0 - obj3;
	}

	public IReadOnlyList<JackarooNode> GetPlayerGraveyardNodes(int rotatedPlayerIndex)
	{
		if (_graveyardsNodes != null)
		{
			int index = rotatedPlayerIndex - 1;
			return (IReadOnlyList<JackarooNode>)((List<object>)(object)_graveyardsNodes).get_Item(index);
		}
		return (IReadOnlyList<JackarooNode>)new NullReferenceException();
	}

	public void ResetServerNodes()
	{
		//IL_0011: Expected O, but got I
		//IL_0210: Expected O, but got I4
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_023d: Expected O, but got I
		//IL_026a: Expected O, but got I4
		List<JackarooNode> serverNodes = _serverNodes;
		object obj = (nint)0 + (nint)2968;
		int version = serverNodes._version + 1;
		serverNodes._size = 0;
		serverNodes._version = version;
		bool flag = serverNodes._size < 1;
		List<object> list = (List<object>)(object)serverNodes;
		if (!flag)
		{
			Array.Clear(serverNodes._items, 0, serverNodes._size);
			list = (List<object>)(object)_serverNodes;
		}
		object obj2 = _myPlayerIndex * 19;
		object obj3 = 4294967277L + obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9A210");
		IEnumerable<object> collection = default(IEnumerable<object>);
		list.AddRange(collection);
		List<JackarooNode> serverBases = _serverBases;
		int version2 = serverBases._version + 1;
		serverBases._size = 0;
		serverBases._version = version2;
		bool flag2 = serverBases._size < 1;
		List<object> list2 = (List<object>)(object)serverBases;
		if (!flag2)
		{
			Array.Clear(serverBases._items, 0, serverBases._size);
			list2 = (List<object>)(object)_serverBases;
		}
		object obj4 = (nint)0 + (nint)1992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C958DC");
		int num = _myPlayerIndex << 2;
		object obj5 = num - 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9A210");
		IEnumerable<object> collection2 = default(IEnumerable<object>);
		list2.AddRange(collection2);
		List<object> serverNodesAndBases = (List<object>)(object)_serverNodesAndBases;
		int version3 = serverNodesAndBases._version + 1;
		serverNodesAndBases._size = 0;
		serverNodesAndBases._version = version3;
		if (serverNodesAndBases._size >= 1)
		{
			Array.Clear(serverNodesAndBases._items, 0, serverNodesAndBases._size);
			serverNodesAndBases = (List<object>)(object)_serverNodesAndBases;
		}
		serverNodesAndBases.AddRange(_serverNodes);
		((List<object>)(object)_serverNodesAndBases).AddRange((IEnumerable<object>)_serverBases);
	}

	public int GetPlayerEntryIndex(int rotatedPlayerIndex)
	{
		//IL_0012: Expected O, but got I8
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected I4, but got Unknown
		object obj = rotatedPlayerIndex * 4294967277L;
		int step = 19 + obj;
		return IntegerExtensions.GetRotatedNextIndex(74, step, 0, 75);
	}

	private List<List<JackarooMarble>> SetupMarbles(List<List<JackarooMarble>> playersGraveyardMarbles, List<List<JackarooNode>> playersGraveyards)
	{
		//IL_05f9: Expected O, but got I
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0056: Expected O, but got I
		//IL_009a: Expected O, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00ec: Expected O, but got I
		//IL_0163: Expected O, but got I4
		//IL_01e5: Expected O, but got I
		//IL_01f5: Expected O, but got I
		//IL_0205: Expected O, but got I
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_05dd: Expected I, but got O
		//IL_0253: Expected O, but got I4
		//IL_02fa: Expected I, but got O
		//IL_030a: Expected O, but got I
		//IL_03c4: Expected O, but got I4
		//IL_044c: Expected I, but got O
		//IL_0345: Expected O, but got I
		//IL_03d7: Expected I, but got O
		//IL_047b: Expected I, but got O
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_041d: Expected I, but got O
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_04d7: Expected I, but got O
		//IL_0505: Expected O, but got I4
		//IL_0268: Expected O, but got I
		//IL_0278: Expected O, but got I
		//IL_0288: Expected O, but got I
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02bf: Expected I, but got O
		//IL_0080: Expected I, but got O
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected O, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected O, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected O, but got Unknown
		//IL_058f: Expected I, but got O
		//IL_05a0: Expected O, but got I4
		if (playersGraveyards != null)
		{
			if (playersGraveyardMarbles == null)
			{
				object obj = (nint)0 + (nint)3000;
				object obj2 = ((List<object>)(object)playersGraveyards).get_Item(0);
				object obj3 = typeof(List<AdaptivePerformanceScaler>) + 1944;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				List<object> list = default(List<object>);
				list..ctor();
				return (List<List<JackarooMarble>>)(object)new NullReferenceException();
			}
			object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 240;
			object obj5 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2488;
			object obj6 = (nint)0 + (nint)2176;
			int num = 0;
			List<object> list2 = default(List<object>);
			JackarooMarble jackarooMarble = default(JackarooMarble);
			bool flag3 = default(bool);
			JackarooNode jackarooNode = default(JackarooNode);
			JackarooMarble jackarooMarble2 = default(JackarooMarble);
			while (true)
			{
				IL_008e:
				object obj7 = (nint)0 + (nint)3000;
				object obj8 = obj7;
				object obj9 = ((List<object>)(object)playersGraveyards).get_Item(num);
				object obj10 = typeof(List<AdaptivePerformanceScaler>) + 1944;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				list2..ctor();
				object obj11 = (nint)0 + (nint)2960;
				object obj12 = obj11;
				int version = playersGraveyardMarbles._version + 1;
				playersGraveyardMarbles._version = version;
				List<JackarooMarble>[] items = playersGraveyardMarbles._items;
				if (playersGraveyardMarbles._items == null)
				{
					break;
				}
				bool flag = playersGraveyardMarbles._size < items.Length;
				object obj13 = !flag;
				if (obj13 == null)
				{
					int size = playersGraveyardMarbles._size + 1;
					playersGraveyardMarbles._size = size;
					object obj14 = playersGraveyardMarbles._items + playersGraveyardMarbles._size;
					object obj15 = obj14 + 32;
					obj15 = list2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj16 = list2;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v21+20]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v34+C0]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v35+70]");
					obj8 = 0;
					((List<object>)(object)playersGraveyardMarbles).AddWithResize((object)list2);
					object obj16 = list2;
				}
				num++;
				if (obj9 != null)
				{
					object obj19 = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						jackarooMarble..ctor(num, null);
						nint num2 = (nint)obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v24 (Il2CppClass<System.Object>)+12E]");
						object obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v24 (Il2CppClass<System.Object>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0396;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v24 (Il2CppClass<System.Object>)+B0]");
						object obj21 = (nint)0 + (nint)8;
						bool flag2 = flag3;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X10_v11-8]");
							if (0 == (nint)obj5)
							{
								break;
							}
							obj21 += 16;
							obj20--;
							flag3 = (nint)obj20 != 1;
							flag2 = flag3;
							if (flag3)
							{
								continue;
							}
							goto IL_0396;
						}
						object obj22 = num2 + obj21;
						object obj23 = obj22 + 312;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v449 @ X0_v34] (should have been resolved before IL gen)");
						bool flag4 = jackarooMarble == null;
						flag3 = flag2;
						nint num3 = unchecked((nint)null);
						if (flag4)
						{
							break;
						}
						goto IL_042b;
						IL_042b:
						jackarooMarble.SetNode(jackarooNode);
						bool flag5 = jackarooNode == null;
						num3 = unchecked((nint)null);
						if (flag5)
						{
							break;
						}
						jackarooNode.SetMarble(jackarooMarble);
						bool flag6 = list2 == null;
						num3 = unchecked((nint)null);
						if (flag6)
						{
							break;
						}
						object obj24 = obj6;
						int version2 = list2._version + 1;
						list2._version = version2;
						object[] items2 = list2._items;
						bool flag7 = list2._items == null;
						num3 = unchecked((nint)null);
						if (flag7)
						{
							break;
						}
						bool flag8 = list2._size < items2.Length;
						object obj25 = !flag8;
						bool flag10;
						if (obj25 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v26+20]");
							object obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v28+C0]");
							object obj27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v29+70]");
							obj8 = 0;
							list2.AddWithResize((object)jackarooMarble);
							obj19++;
							bool flag9 = (nint)obj19 == 4;
							flag10 = flag3;
							num3 = unchecked((nint)null);
							object obj16 = jackarooMarble;
							if (!flag9)
							{
								continue;
							}
						}
						else
						{
							int size2 = list2._size + 1;
							list2._size = size2;
							object obj28 = list2._items + list2._size;
							object obj29 = obj28 + 32;
							obj29 = jackarooMarble;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							obj19++;
							flag3 = (nint)obj19 != 4;
							num3 = unchecked((nint)null);
							object obj16 = jackarooMarble;
							obj8 = 0;
							if (flag3)
							{
								continue;
							}
							flag10 = flag3;
						}
						bool flag11 = num == 4;
						flag3 = flag10;
						num3 = unchecked((nint)null);
						if (!flag11)
						{
							goto IL_008e;
						}
						return playersGraveyardMarbles;
						IL_0396:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v433 @ X0_v31] (should have been resolved before IL gen)");
						bool flag12 = jackarooMarble == null;
						object obj30 = !flag12;
						if (obj30 == null)
						{
							num3 = unchecked((nint)null);
							break;
						}
						goto IL_042b;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					jackarooMarble2..ctor(num, null);
					nint num3 = unchecked((nint)null);
				}
				break;
			}
		}
		throw new NullReferenceException();
	}

	public List<JackarooMarble> GetAllMarbles()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0107: Expected O, but got I
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = (nint)0 + (nint)1984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C958DC");
		if (list != null)
		{
			IEnumerable<object> collection = default(IEnumerable<object>);
			list.AddRange(collection);
			if (_playersGraveyardMarbles != null)
			{
				object collection2 = ((List<object>)(object)_playersGraveyardMarbles).get_Item(0);
				list.AddRange((IEnumerable<object>)collection2);
				if (_playersGraveyardMarbles != null)
				{
					object collection3 = ((List<object>)(object)_playersGraveyardMarbles).get_Item(1);
					list.AddRange((IEnumerable<object>)collection3);
					if (_playersGraveyardMarbles != null)
					{
						object collection4 = ((List<object>)(object)_playersGraveyardMarbles).get_Item(2);
						list.AddRange((IEnumerable<object>)collection4);
						if (_playersGraveyardMarbles != null)
						{
							object collection5 = ((List<object>)(object)_playersGraveyardMarbles).get_Item(3);
							list.AddRange((IEnumerable<object>)collection5);
							return (List<JackarooMarble>)(object)list;
						}
					}
				}
			}
		}
		return (List<JackarooMarble>)(object)new NullReferenceException();
	}

	public JackarooMarble GetGraveyardMarble(int rotatedPlayerIndex)
	{
		//IL_0016: Expected O, but got I
		//IL_00e3: Expected O, but got I
		//IL_00fd: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0137: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F6C]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F6E]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F6E]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		List<object> playersGraveyardMarbles = (List<object>)(object)_playersGraveyardMarbles;
		bool flag2 = _playersGraveyardMarbles == null;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			goto IL_008f;
		}
		goto IL_0145;
		IL_008f:
		int index = rotatedPlayerIndex - 1;
		object source = playersGraveyardMarbles.get_Item(index);
		return (JackarooMarble)Enumerable.First((IEnumerable<object>)source);
		IL_0145:
		return (JackarooMarble)(object)new NullReferenceException();
		IL_0066:
		playersGraveyardMarbles = (List<object>)(object)_playersGraveyardMarbles;
		if (_playersGraveyardMarbles != null)
		{
			goto IL_008f;
		}
		goto IL_0145;
	}

	public IReadOnlyList<JackarooMarble> GetGraveyardMarbles(int rotatedPlayerIndex)
	{
		if (_playersGraveyardMarbles != null)
		{
			int index = rotatedPlayerIndex - 1;
			return (IReadOnlyList<JackarooMarble>)((List<object>)(object)_playersGraveyardMarbles).get_Item(index);
		}
		return (IReadOnlyList<JackarooMarble>)new NullReferenceException();
	}

	private List<JackarooMarble> Internal_GetGraveyardMarbles(int rotatedPlayerIndex)
	{
		if (_playersGraveyardMarbles != null)
		{
			int index = rotatedPlayerIndex - 1;
			return (List<JackarooMarble>)((List<object>)(object)_playersGraveyardMarbles).get_Item(index);
		}
		return (List<JackarooMarble>)(object)new NullReferenceException();
	}

	public IReadOnlyList<JackarooMarble> GetAllPlantedMarbles()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)1984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C958DC");
		IReadOnlyList<JackarooMarble> result = default(IReadOnlyList<JackarooMarble>);
		return result;
	}

	public IReadOnlyList<JackarooMarble> GetPlantedMarbles(int rotatedPlayerIndex = 1)
	{
		if (_playersPlantedMarbles != null)
		{
			int index = rotatedPlayerIndex - 1;
			return (IReadOnlyList<JackarooMarble>)((List<object>)(object)_playersPlantedMarbles).get_Item(index);
		}
		return (IReadOnlyList<JackarooMarble>)new NullReferenceException();
	}

	private List<JackarooMarble> Internal_GetPlantedMarbles(int rotatedPlayerIndex)
	{
		if (_playersPlantedMarbles != null)
		{
			int index = rotatedPlayerIndex - 1;
			return (List<JackarooMarble>)((List<object>)(object)_playersPlantedMarbles).get_Item(index);
		}
		return (List<JackarooMarble>)(object)new NullReferenceException();
	}

	public List<JackarooMarble> GetAllPlantedMarblesExcept(int rotatedPlayerIndex)
	{
		List<JackarooMarble> othersPlantedMarbles = _othersPlantedMarbles;
		List<object> othersPlantedMarbles2;
		List<object> othersPlantedMarbles3;
		if (_othersPlantedMarbles != null)
		{
			int version = othersPlantedMarbles._version + 1;
			othersPlantedMarbles._size = 0;
			othersPlantedMarbles._version = version;
			bool flag = othersPlantedMarbles._size < 1;
			othersPlantedMarbles2 = (List<object>)(object)_othersPlantedMarbles;
			if (!flag)
			{
				Array.Clear(othersPlantedMarbles._items, 0, othersPlantedMarbles._size);
				othersPlantedMarbles2 = (List<object>)(object)_othersPlantedMarbles;
			}
			if (rotatedPlayerIndex == 1)
			{
				goto IL_02ad;
			}
			if (_playersPlantedMarbles != null)
			{
				object collection = ((List<object>)(object)_playersPlantedMarbles).get_Item(0);
				if (othersPlantedMarbles2 != null)
				{
					othersPlantedMarbles2.AddRange((IEnumerable<object>)collection);
					othersPlantedMarbles2 = (List<object>)(object)_othersPlantedMarbles;
					bool flag2 = rotatedPlayerIndex == 2;
					othersPlantedMarbles3 = (List<object>)(object)_othersPlantedMarbles;
					if (!flag2)
					{
						goto IL_02ad;
					}
					goto IL_02cc;
				}
			}
		}
		goto IL_0238;
		IL_02eb:
		List<JackarooMarble> othersPlantedMarbles4;
		return othersPlantedMarbles4;
		IL_0238:
		return (List<JackarooMarble>)(object)new NullReferenceException();
		IL_02ad:
		List<object> othersPlantedMarbles5;
		if (_playersPlantedMarbles != null)
		{
			object collection2 = ((List<object>)(object)_playersPlantedMarbles).get_Item(1);
			if (othersPlantedMarbles2 != null)
			{
				othersPlantedMarbles2.AddRange((IEnumerable<object>)collection2);
				bool flag3 = rotatedPlayerIndex == 3;
				othersPlantedMarbles3 = (List<object>)(object)_othersPlantedMarbles;
				othersPlantedMarbles5 = (List<object>)(object)_othersPlantedMarbles;
				if (!flag3)
				{
					goto IL_02cc;
				}
				goto IL_02f0;
			}
		}
		goto IL_0238;
		IL_02f0:
		if (_playersPlantedMarbles != null)
		{
			object collection3 = ((List<object>)(object)_playersPlantedMarbles).get_Item(3);
			if (othersPlantedMarbles5 != null)
			{
				othersPlantedMarbles5.AddRange((IEnumerable<object>)collection3);
				othersPlantedMarbles4 = _othersPlantedMarbles;
				goto IL_02eb;
			}
		}
		goto IL_0238;
		IL_02cc:
		if (_playersPlantedMarbles != null)
		{
			object collection4 = ((List<object>)(object)_playersPlantedMarbles).get_Item(2);
			if (othersPlantedMarbles3 != null)
			{
				othersPlantedMarbles3.AddRange((IEnumerable<object>)collection4);
				othersPlantedMarbles5 = (List<object>)(object)_othersPlantedMarbles;
				bool flag4 = rotatedPlayerIndex == 4;
				othersPlantedMarbles4 = _othersPlantedMarbles;
				if (flag4)
				{
					goto IL_02eb;
				}
				goto IL_02f0;
			}
		}
		goto IL_0238;
	}

	internal void SetNodeAndMarble(JackarooMarble marble, JackarooNode newNode, JackarooNode oldNode)
	{
		oldNode.SetMarble();
		marble.SetNode(newNode);
		newNode.SetMarble(marble);
	}

	internal void SetNodeAndMarble(JackarooMarble marble, JackarooNode newNode)
	{
		marble.SetNode(newNode);
		newNode.SetMarble(marble);
	}

	public int GetNodeRelativeToServer(JackarooNode node)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C97238");
		int result = default(int);
		return result;
	}

	public void SetBoardState(int[][] playersMarbles)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		if (playersMarbles.Length >= 1)
		{
			object obj = playersMarbles + 32;
			int num = 0;
			do
			{
				num++;
				int playerIndex = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X22_v3+v87 @ X21_v4 (System.Int32)*8]");
				SetBoardState(playerIndex, (int[])0);
			}
			while (num < playersMarbles.Length);
		}
	}

	private void SetBoardState(int playerIndex, int[] marblesPositions)
	{
		//IL_0016: Expected O, but got I
		//IL_00a9: Expected O, but got I4
		//IL_006c: Expected O, but got I4
		//IL_00c6: Expected O, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_012f: Unsupported input type for neg.
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_017f: Expected O, but got I4
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected I4, but got Unknown
		//IL_045a: Expected O, but got I
		//IL_020c: Expected O, but got I
		//IL_0226: Expected O, but got I4
		//IL_01dd: Expected O, but got I4
		//IL_019a: Expected O, but got I
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_02a1: Expected I, but got O
		//IL_02b1: Expected O, but got I
		//IL_0363: Expected O, but got I4
		//IL_03ba: Expected O, but got I
		//IL_02ec: Expected O, but got I
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F73]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			if (_isSpectator)
			{
				goto IL_0052;
			}
		}
		else
		{
			_ = 1;
			bool flag = !_isSpectator;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_0052;
			}
		}
		object obj3 = playerIndex - _mySeatIndex;
		object obj4 = obj3 + 4;
		object obj5 = obj4 & 3;
		object obj6 = 0 - obj4;
		object obj7 = obj6 & 3;
		object obj8 = ((0 >= (nint)obj6) ? ((object)(0 - obj7)) : obj5);
		int num = obj8 + 1;
		goto IL_0139;
		IL_0052:
		bool flag2 = marblesPositions == null;
		object obj9 = !flag2;
		num = playerIndex;
		if (obj9 != null)
		{
			goto IL_0139;
		}
		goto IL_0406;
		IL_0139:
		if (marblesPositions.Length < 1)
		{
			return;
		}
		object obj10 = marblesPositions + 32;
		int index = num - 1;
		object obj11 = 0;
		JackarooNode jackarooNode = default(JackarooNode);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F6C]");
			object obj12 = (nint)0 & (nint)1;
			if (obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F6E]");
				object obj13 = (nint)0 & (nint)1;
				if (obj13 != null)
				{
					goto IL_01b7;
				}
			}
			else
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F6E]");
				object obj14 = (nint)0 & (nint)1;
				bool flag3 = obj14 == null;
				object obj15 = !flag3;
				if (obj15 != null)
				{
					goto IL_01b7;
				}
			}
			_ = 1;
			List<object> playersGraveyardMarbles = (List<object>)(object)_playersGraveyardMarbles;
			goto IL_0249;
			IL_03a8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v8 (System.Object)+20]");
			((JackarooNode)0).SetMarble();
			object obj16;
			((JackarooMarble)obj16).SetNode(jackarooNode);
			jackarooNode.SetMarble((JackarooMarble)obj16);
			obj11++;
			if ((nint)obj11 >= marblesPositions.Length)
			{
				return;
			}
			continue;
			IL_0335:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v390 @ X0_v15] (should have been resolved before IL gen)");
			bool flag4 = obj16 == null;
			object obj17 = !flag4;
			if (obj17 == null)
			{
				break;
			}
			goto IL_03a8;
			IL_0249:
			object source = playersGraveyardMarbles.get_Item(index);
			obj16 = Enumerable.First((IEnumerable<object>)source);
			MoveMarbleFromGraveyardListToPlantedList((JackarooMarble)obj16);
			List<JackarooNode> serverNodesAndBases = _serverNodesAndBases;
			object obj18 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2488;
			nint num2 = (nint)serverNodesAndBases;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v12 (Il2CppClass<System.Collections.Generic.List`1<Jackaroo.JackarooNode>>)+12E]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v12 (Il2CppClass<System.Collections.Generic.List`1<Jackaroo.JackarooNode>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0335;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v12 (Il2CppClass<System.Collections.Generic.List`1<Jackaroo.JackarooNode>>)+B0]");
			object obj20 = (nint)0 + (nint)8;
			object obj21;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X10_v8-8]");
				if (0 == (nint)obj18)
				{
					break;
				}
				obj21 = obj20 + 16;
				obj19--;
				bool flag5 = (nint)obj19 != 1;
				obj20 = obj21;
				if (flag5)
				{
					continue;
				}
				goto IL_0335;
			}
			object obj22 = num2 + obj20;
			object obj23 = obj22 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v406 @ X0_v18] (should have been resolved before IL gen)");
			obj21 = obj20;
			goto IL_03a8;
			IL_01b7:
			playersGraveyardMarbles = (List<object>)(object)_playersGraveyardMarbles;
			bool flag6 = _playersGraveyardMarbles == null;
			object obj24 = !flag6;
			if (obj24 == null)
			{
				break;
			}
			goto IL_0249;
		}
		goto IL_0406;
		IL_0406:
		throw new NullReferenceException();
	}

	public void GoToGraveyardImmediate(JackarooMarble marble)
	{
		JackarooNode jackarooNode = MoveMarbleFromBoardToGraveyard(marble);
		marble.<Node>k__BackingField.SetMarble();
		marble.SetNode(jackarooNode);
		jackarooNode.SetMarble(marble);
	}

	public JackarooNode MoveMarbleFromBoardToGraveyard(JackarooMarble marbleToDie)
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I
		//IL_01b4: Expected O, but got I
		//IL_01c4: Expected O, but got I
		//IL_01d4: Expected O, but got I
		//IL_01f6: Expected O, but got I4
		//IL_0216: Expected O, but got I
		//IL_0119: Expected O, but got I
		//IL_0129: Expected O, but got I
		//IL_0139: Expected O, but got I
		//IL_015b: Expected O, but got I4
		//IL_024e: Expected O, but got I4
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_0361: Expected O, but got I
		//IL_0372: Expected I, but got O
		//IL_0390: Expected O, but got I
		//IL_0189: Expected O, but got I
		//IL_027e: Expected O, but got I
		object obj3;
		object obj8;
		object obj11;
		object obj12;
		object obj10;
		Func<object, bool> func;
		object obj7;
		if (marbleToDie != null && _playersPlantedMarbles != null)
		{
			int index = marbleToDie.<PlayerIndex>k__BackingField - 1;
			object obj = ((List<object>)(object)_playersPlantedMarbles).get_Item(index);
			if (obj != null)
			{
				bool flag = ((List<object>)obj).Remove((object)marbleToDie);
				if (_playersGraveyardMarbles != null)
				{
					object obj2 = ((List<object>)(object)_playersGraveyardMarbles).get_Item(index);
					if (obj2 != null)
					{
						((List<object>)obj2).Insert(0, (object)marbleToDie);
						if (_graveyardsNodes != null)
						{
							obj3 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 288;
							object obj4 = (nint)0 + (nint)3000;
							object obj5 = ((List<object>)(object)_graveyardsNodes).get_Item(index);
							object obj6 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v18+E4]");
							if ((nint)0 != 0)
							{
								obj7 = (nint)0 + (nint)1760;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v18+B8]");
								obj8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v19+10]");
								func = (Func<object, bool>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v19+10]");
								bool flag2 = (nint)0 == 0;
								object obj9 = !flag2;
								obj10 = obj5;
								if (obj9 == null)
								{
									obj11 = obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v19+10]");
									Func<object, bool> func2 = (Func<object, bool>)0;
									obj12 = obj7;
									goto IL_022c;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj6 = obj3;
								obj12 = (nint)0 + (nint)1760;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v18+B8]");
								obj8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v19+10]");
								Func<object, bool> func2 = (Func<object, bool>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v19+10]");
								bool flag3 = (nint)0 == 0;
								object obj13 = !flag3;
								obj11 = obj5;
								obj10 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v19+10]");
								func = (Func<object, bool>)0;
								obj7 = obj12;
								if (obj13 == null)
								{
									goto IL_022c;
								}
							}
							goto IL_0328;
						}
					}
				}
			}
		}
		return (JackarooNode)(object)new NullReferenceException();
		IL_0328:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC848C");
		JackarooNode result = default(JackarooNode);
		return result;
		IL_022c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v18+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v25+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)1464;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v24+B8]");
		object obj19 = (nint)0 + (nint)16;
		obj19 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj11;
		func = func3;
		obj7 = obj12;
		goto IL_0328;
	}

	public void MoveMarbleFromGraveyardListToPlantedList(JackarooMarble newMarble)
	{
		//IL_0016: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_006e: Expected O, but got I
		//IL_009c: Expected O, but got I4
		//IL_017e: Expected O, but got I
		//IL_0198: Expected O, but got I4
		//IL_00c0: Expected O, but got I
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_011d: Expected O, but got I
		object obj = (nint)0 + (nint)2968;
		int index = newMarble.<PlayerIndex>k__BackingField - 1;
		object obj2 = ((List<object>)(object)_playersPlantedMarbles).get_Item(index);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v6 (System.Object)+1C]");
		object obj3 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v6 (System.Object)+10]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v6 (System.Object)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v4+18]");
		bool flag = num < 0;
		object obj5 = !flag;
		int <PlayerIndex>k__BackingField;
		int num2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v6 (System.Object)+18]");
			object obj6 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v6 (System.Object)+18]");
			object obj7 = obj4 + 0;
			object obj8 = obj7 + 32;
			obj8 = newMarble;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<PlayerIndex>k__BackingField = newMarble.<PlayerIndex>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F6E]");
			object obj9 = (nint)0 & (nint)1;
			if (obj9 == null)
			{
				goto IL_01b3;
			}
			num2 = newMarble.<PlayerIndex>k__BackingField;
		}
		else
		{
			((List<object>)obj2).AddWithResize((object)newMarble);
			<PlayerIndex>k__BackingField = newMarble.<PlayerIndex>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F6E]");
			object obj10 = (nint)0 & (nint)1;
			bool flag2 = obj10 == null;
			object obj11 = !flag2;
			num2 = newMarble.<PlayerIndex>k__BackingField;
			if (obj11 == null)
			{
				goto IL_01b3;
			}
		}
		goto IL_01c6;
		IL_01c6:
		int index2 = num2 - 1;
		object obj12 = ((List<object>)(object)_playersGraveyardMarbles).get_Item(index2);
		bool flag3 = ((List<object>)obj12).Remove((object)newMarble);
		return;
		IL_01b3:
		_ = 1;
		num2 = <PlayerIndex>k__BackingField;
		goto IL_01c6;
	}

	public bool AreAllMarblesInBases(int rotatedPlayerIndex = 1)
	{
		//IL_0016: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00d5: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_011e: Expected O, but got I
		//IL_0311: Expected I4, but got O
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_017e: Expected I, but got O
		//IL_018e: Expected O, but got I
		//IL_0224: Expected O, but got I
		//IL_0249: Expected O, but got I4
		//IL_01c9: Expected O, but got I
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_0281: Expected O, but got I
		//IL_028f: Expected I, but got O
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02d6: Expected O, but got I
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F76]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F70]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F70]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		List<object> playersPlantedMarbles = (List<object>)(object)_playersPlantedMarbles;
		if (_playersPlantedMarbles != null)
		{
			goto IL_0112;
		}
		goto IL_0303;
		IL_0257:
		object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = (nint)0 + (nint)352;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)this, (IntPtr)obj6);
		object obj7;
		return Enumerable.All((IEnumerable<object>)obj7, func);
		IL_02fd:
		return false;
		IL_020a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v13+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v208 @ X0_v13] (should have been resolved before IL gen)");
		object obj9 = default(object);
		bool flag2 = (nint)obj9 != 4;
		object obj10 = 0;
		if (!flag2)
		{
			goto IL_0257;
		}
		goto IL_02fd;
		IL_0066:
		playersPlantedMarbles = (List<object>)(object)_playersPlantedMarbles;
		bool flag3 = _playersPlantedMarbles == null;
		object obj11 = !flag3;
		if (obj11 != null)
		{
			goto IL_0112;
		}
		goto IL_0303;
		IL_0112:
		object obj12 = (nint)0 + (nint)2968;
		int index = rotatedPlayerIndex - 1;
		obj10 = obj12;
		obj7 = playersPlantedMarbles.get_Item(index);
		if (obj7 != null)
		{
			object obj13 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2248;
			nint num = (nint)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v8 (Il2CppClass<System.Object>)+12E]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v8 (Il2CppClass<System.Object>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_020a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v8 (Il2CppClass<System.Object>)+B0]");
			object obj15 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X10_v6-8]");
				if (0 == (nint)obj13)
				{
					break;
				}
				obj15 += 16;
				obj14--;
				if ((nint)obj14 != 1)
				{
					continue;
				}
				goto IL_020a;
			}
			object obj16 = num + obj15;
			object obj17 = obj16 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v16+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v247 @ X0_v16] (should have been resolved before IL gen)");
			object obj18 = default(object);
			if ((nint)obj18 == 4)
			{
				goto IL_0257;
			}
			goto IL_02fd;
		}
		goto IL_0303;
		IL_0303:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public bool IsMarbleAtBase(JackarooMarble marble)
	{
		//IL_0081: Expected I4, but got O
		//IL_005f: Expected O, but got I4
		if (marble != null)
		{
			JackarooNode <Node>k__BackingField = marble.<Node>k__BackingField;
			if (marble.<Node>k__BackingField != null)
			{
				object obj = <Node>k__BackingField.<Type>k__BackingField - 3;
				return obj == null;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public bool IsMarbleInLastBase(JackarooMarble marble)
	{
		//IL_0092: Expected I4, but got O
		//IL_001f: Expected O, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected I4, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_007a: Unsupported input type for neg.
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected I4, but got Unknown
		if (marble != null && _basesNodes != null)
		{
			object obj = 5 - marble.<PlayerIndex>k__BackingField;
			int num = obj & 3;
			object obj2 = 0 - obj;
			object obj3 = obj2 & 3;
			int index = ((0 >= (nint)obj2) ? (0 - obj3) : num);
			object source = ((List<object>)(object)_basesNodes).get_Item(index);
			object obj4 = Enumerable.Last((IEnumerable<object>)source);
			object obj5 = (object)marble.<Node>k__BackingField - obj4;
			return obj5 == null;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public bool IsMyMarble(JackarooMarble marble, int rotatedPlayerIndex)
	{
		//IL_0051: Expected I4, but got O
		//IL_002f: Expected O, but got I4
		if (marble != null)
		{
			object obj = marble.<PlayerIndex>k__BackingField - rotatedPlayerIndex;
			return obj == null;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public JackarooNode NextLocalNode(JackarooNode node)
	{
		return GetLocalNode(node, 1);
	}

	public JackarooNode PreviousLocalNode(JackarooNode node)
	{
		//IL_0013: Expected I4, but got I8
		return GetLocalNode(node, -1);
	}

	public JackarooNode GetLocalNode(JackarooNode node, int steps)
	{
		if (<Nodes>k__BackingField != null)
		{
			int index = ((List<object>)(object)<Nodes>k__BackingField).IndexOf((object)node);
			int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(index, steps, 0, 76);
			if (<Nodes>k__BackingField != null)
			{
				return (JackarooNode)((List<object>)(object)<Nodes>k__BackingField).get_Item(rotatedNextIndex);
			}
		}
		return (JackarooNode)(object)new NullReferenceException();
	}

	public JackarooNode GetLocalNode(int index, int steps)
	{
		int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(index, steps, 0, 76);
		if (<Nodes>k__BackingField != null)
		{
			return (JackarooNode)((List<object>)(object)<Nodes>k__BackingField).get_Item(rotatedNextIndex);
		}
		return (JackarooNode)(object)new NullReferenceException();
	}

	public bool IsMarbleAtHome(JackarooMarble marble)
	{
		//IL_00db: Expected I4, but got O
		//IL_0059: Expected O, but got I4
		//IL_0074: Expected O, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		if (marble != null)
		{
			(JackarooNode, JackarooNode)[] homesAndBasesEntryNodes = _homesAndBasesEntryNodes;
			if (_homesAndBasesEntryNodes != null)
			{
				object obj = marble.<PlayerIndex>k__BackingField - 1;
				bool flag = (nint)obj < homesAndBasesEntryNodes.Length;
				object obj2 = !flag;
				if (obj2 == null)
				{
					object obj3 = (object)_homesAndBasesEntryNodes + obj;
					JackarooNode <Node>k__BackingField = marble.<Node>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+20]");
					object obj4 = <Node>k__BackingField - 0;
					return obj4 == null;
				}
				goto IL_00cd;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00cd;
		IL_00cd:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	public List<JackarooNode> GetNodesAndMarblesRange(int start, int count, int rotatedPlayerIndex)
	{
		return GetServerWalkingNodes(start, count, rotatedPlayerIndex);
	}

	public List<JackarooNode> GetServerWalkingNodes(int start, int count, int rotatedPlayerIndex)
	{
		//IL_0136: Expected O, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004a: Expected I, but got O
		//IL_005a: Expected O, but got I
		//IL_0095: Expected O, but got I
		//IL_0121: Expected O, but got I
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_0197: Expected O, but got I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		object obj6 = default(object);
		if (start < 76)
		{
			List<JackarooNode> serverNodes = _serverNodes;
			if (_serverNodes != null)
			{
				object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2488;
				nint num = (nint)serverNodes;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v8 (Il2CppClass<System.Collections.Generic.List`1<Jackaroo.JackarooNode>>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v8 (Il2CppClass<System.Collections.Generic.List`1<Jackaroo.JackarooNode>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00d6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v8 (Il2CppClass<System.Collections.Generic.List`1<Jackaroo.JackarooNode>>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v6-8]");
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
					goto IL_00d6;
				}
				object obj4 = num + obj3;
				object obj5 = obj4 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v229 @ X0_v14] (should have been resolved before IL gen)");
				bool flag = obj6 == null;
				object obj7 = !flag;
				if (obj7 != null)
				{
					goto IL_0107;
				}
			}
			goto IL_01a5;
		}
		object obj8 = (nint)0 + (nint)2448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C965A4");
		IEnumerable<object> source = default(IEnumerable<object>);
		return (List<JackarooNode>)(object)Enumerable.ToList(source);
		IL_00d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v162 @ X0_v11] (should have been resolved before IL gen)");
		if (obj6 != null)
		{
			goto IL_0107;
		}
		goto IL_01a5;
		IL_0107:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v7+20]");
		return GetLocalWalkingNodes((JackarooMarble)0, count, rotatedPlayerIndex);
		IL_01a5:
		return (List<JackarooNode>)(object)new NullReferenceException();
	}

	public List<JackarooNode> GetLocalWalkingNodes(JackarooMarble marble, int count, int rotatedPlayerIndex)
	{
		if (marble != null && <NodesAndBases>k__BackingField != null)
		{
			int start = ((List<object>)(object)<NodesAndBases>k__BackingField).IndexOf((object)marble.<Node>k__BackingField);
			IEnumerable<JackarooNode> walkingNodes = GetWalkingNodes(<Nodes>k__BackingField, start, count, marble, rotatedPlayerIndex);
			return (List<JackarooNode>)(object)Enumerable.ToList((IEnumerable<object>)walkingNodes);
		}
		return (List<JackarooNode>)(object)new NullReferenceException();
	}

	private IEnumerable<JackarooNode> GetWalkingNodes(IReadOnlyList<JackarooNode> nodes, int start, int count, JackarooMarble marble, int rotatedPlayerIndex)
	{
		//IL_0192: Expected O, but got I8
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected I4, but got Unknown
		//IL_033e: Expected O, but got I
		//IL_00b9: Expected I4, but got I8
		//IL_01e6: Expected O, but got I4
		//IL_01f3: Expected O, but got I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected I4, but got Unknown
		//IL_0260: Expected O, but got I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_00f0: Expected I4, but got I8
		//IL_0391: Expected O, but got I4
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected I4, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected I4, but got Unknown
		if (marble != null)
		{
			if (marble.<PlayerIndex>k__BackingField == rotatedPlayerIndex || ((rotatedPlayerIndex == 4 || rotatedPlayerIndex == 2) && (marble.<PlayerIndex>k__BackingField == 2 || marble.<PlayerIndex>k__BackingField == 4)))
			{
				goto IL_0110;
			}
			int num = (int)(rotatedPlayerIndex & 0xFFFFFFFDL);
			if (num == 1)
			{
				int num2 = (int)(marble.<PlayerIndex>k__BackingField & 0xFFFFFFFDL);
				if (num2 == 1)
				{
					goto IL_0110;
				}
			}
			goto IL_0332;
		}
		goto IL_034d;
		IL_0332:
		object obj = (nint)0 + (nint)2448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C965A4");
		IEnumerable<JackarooNode> result = default(IEnumerable<JackarooNode>);
		return result;
		IL_034d:
		return (IEnumerable<JackarooNode>)new NullReferenceException();
		IL_0110:
		JackarooNode <Node>k__BackingField = marble.<Node>k__BackingField;
		if (marble.<Node>k__BackingField != null)
		{
			if (<Node>k__BackingField.<Type>k__BackingField == JackarooNodeType.Base)
			{
				return GetWalkingNodesFromBase(marble, count);
			}
			object obj2 = marble.<PlayerIndex>k__BackingField * 4294967277L;
			int step = 19 + obj2;
			int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(74, step, 0, 75);
			if (count >= 1)
			{
				object obj3 = count + start;
				object obj4 = start - rotatedNextIndex;
				bool flag = (nint)obj4 < 0;
				bool flag2 = obj4 == null;
				int num3 = start ^ rotatedNextIndex;
				int num4 = start ^ obj4;
				int num5 = num3 & num4;
				bool flag3 = num5 < 0;
				bool flag4 = flag == flag3;
				object obj5 = !flag4;
				object obj6 = obj5 | flag2;
				object obj7 = ~obj6;
				bool flag5;
				bool flag6;
				bool flag7;
				if (obj7 == null)
				{
					object obj8 = obj3 - rotatedNextIndex;
					flag5 = (nint)obj8 < 0;
					flag6 = obj8 == null;
					int num6 = obj3 ^ rotatedNextIndex;
					object obj9 = obj3 ^ obj8;
					int num7 = num6 & obj9;
					flag7 = num7 < 0;
				}
				else
				{
					flag7 = false;
					flag6 = true;
					flag5 = false;
				}
				bool flag8 = flag5 == flag7;
				object obj10 = !flag8;
				object obj11 = obj10 | flag6;
				if (obj11 == null)
				{
					return GetWalkingNodesEnteringBase(nodes, start, count, marble.<PlayerIndex>k__BackingField, rotatedNextIndex);
				}
			}
			goto IL_0332;
		}
		goto IL_034d;
	}

	private bool IsSameSide(int marblePlayerIndex, int rotatedPlayerIndex)
	{
		//IL_00c0: Expected I4, but got I8
		//IL_00d2: Expected I4, but got I8
		//IL_00e0: Expected O, but got I4
		//IL_00fd: Expected O, but got I4
		//IL_0117: Expected O, but got I4
		if (marblePlayerIndex == rotatedPlayerIndex)
		{
			return true;
		}
		if (rotatedPlayerIndex != 4 && rotatedPlayerIndex != 2)
		{
			goto IL_00ae;
		}
		bool flag = marblePlayerIndex == 2;
		bool result = true;
		if (!flag)
		{
			bool flag2 = marblePlayerIndex == 4;
			result = true;
			if (!flag2)
			{
				goto IL_00ae;
			}
		}
		goto IL_0149;
		IL_0149:
		return result;
		IL_00ae:
		int num = (int)(rotatedPlayerIndex & 0xFFFFFFFDL);
		int num2 = (int)(marblePlayerIndex & 0xFFFFFFFDL);
		object obj = num2 - 1;
		bool flag3 = obj == null;
		object obj2 = num - 1;
		bool flag4 = obj2 == null;
		object obj3 = !flag4;
		object obj4 = ~obj3;
		result = obj4 != null && flag3;
		goto IL_0149;
	}

	private IEnumerable<JackarooNode> GetWalkingNodesFromBase(JackarooMarble marble, int count)
	{
		//IL_013d: Expected O, but got I4
		//IL_0029: Expected O, but got I4
		//IL_006d: Expected O, but got I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected I4, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00c8: Unsupported input type for neg.
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected I4, but got Unknown
		//IL_0189: Expected O, but got I
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected I4, but got Unknown
		bool flag = count < 5;
		object obj = !flag;
		if (obj == null)
		{
			bool flag2 = IsMarbleInLastBase(marble);
			bool flag3 = !flag2;
			object obj2 = !flag3;
			if (obj2 == null)
			{
				if (marble == null || _basesNodes == null)
				{
					return (IEnumerable<JackarooNode>)new NullReferenceException();
				}
				object obj3 = 5 - marble.<PlayerIndex>k__BackingField;
				int num = obj3 & 3;
				object obj4 = 0 - obj3;
				object obj5 = obj4 & 3;
				int index = ((0 >= (nint)obj4) ? (0 - obj5) : num);
				object source = ((List<object>)(object)_basesNodes).get_Item(index);
				object obj6 = (nint)0 + (nint)2464;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C97238");
				object obj8 = default(object);
				object obj7 = 4 - obj8;
				if (count < (nint)obj7)
				{
					int count2 = obj8 + 1;
					IEnumerable<object> source2 = Enumerable.Skip((IEnumerable<object>)source, count2);
					return (IEnumerable<JackarooNode>)Enumerable.Take(source2, count);
				}
			}
		}
		return _emptyList;
	}

	private unsafe bool IsEnteringBase(int start, int count, int playerIndex, out int playerEntryIndex)
	{
		//IL_0012: Expected O, but got I8
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected I4, but got Unknown
		//IL_009c: Expected O, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected I4, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected I4, but got Unknown
		//IL_0116: Expected O, but got I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected I4, but got Unknown
		object obj = playerIndex * 4294967277L;
		int step = 19 + obj;
		int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(74, step, 0, 75);
		ref int reference = ref *(int*)rotatedNextIndex;
		bool flag = count < 1;
		bool result = false;
		if (!flag)
		{
			bool flag2 = start > rotatedNextIndex;
			result = false;
			if (!flag2)
			{
				object obj2 = count + start;
				object obj3 = obj2 - rotatedNextIndex;
				bool flag3 = (nint)obj3 < 0;
				bool flag4 = obj3 == null;
				int num = obj2 ^ rotatedNextIndex;
				object obj4 = obj2 ^ obj3;
				int num2 = num & obj4;
				bool flag5 = num2 < 0;
				bool flag6 = flag3 == flag5;
				object obj5 = !flag4;
				bool flag7 = (byte)((flag6 & obj5) ? 1 : 0) != 0;
				result = flag7;
			}
		}
		return result;
	}

	private List<JackarooNode> GetWalkingNodesEnteringBase(IReadOnlyList<JackarooNode> nodes, int start, int count, int marblePlayerIndex, int playerEntryIndex)
	{
		//IL_00fe: Expected O, but got I4
		//IL_010c: Expected O, but got I4
		//IL_0020: Expected O, but got I
		//IL_002e: Expected O, but got I4
		//IL_005e: Expected O, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected I4, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_00b9: Unsupported input type for neg.
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected I4, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		object obj = count + start;
		object obj2 = playerEntryIndex + 4;
		if (obj > obj2)
		{
			return _emptyList;
		}
		object obj3 = (nint)0 + (nint)2448;
		object obj4 = playerEntryIndex - start;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C965A4");
		IEnumerable<object> source = default(IEnumerable<object>);
		List<object> list = Enumerable.ToList(source);
		if (_basesNodes != null)
		{
			object obj5 = 5 - marblePlayerIndex;
			int num = obj5 & 3;
			object obj6 = 0 - obj5;
			object obj7 = obj6 & 3;
			int index = ((0 >= (nint)obj6) ? (0 - obj7) : num);
			object obj8 = ((List<object>)(object)_basesNodes).get_Item(index);
			object obj9 = count - obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C965A4");
			if (list != null)
			{
				IEnumerable<object> collection = default(IEnumerable<object>);
				list.AddRange(collection);
				return (List<JackarooNode>)(object)list;
			}
		}
		return (List<JackarooNode>)(object)new NullReferenceException();
	}
}
