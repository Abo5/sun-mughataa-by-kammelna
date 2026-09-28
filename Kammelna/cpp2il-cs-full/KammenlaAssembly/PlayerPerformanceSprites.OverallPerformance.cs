using System;
using Cpp2ILInjected;
using UnityEngine;

public class PlayerPerformanceSprites : ScriptableObject
{
	[Serializable]
	public class StampBorder
	{
		public Sprite Green;

		public Color GreenColor;

		public Sprite Orange;

		public Color OrangeColor;

		public Sprite Red;

		public Color RedColor;

		public StampBorder()
		{
			//IL_0012: Expected O, but got I
			//IL_0024: Expected O, but got I
			//IL_0036: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252D10]");
			GreenColor = (Color)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252D20]");
			OrangeColor = (Color)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252D30]");
			RedColor = (Color)0;
			base..ctor();
		}
	}

	[Serializable]
	public class OverallPerformance
	{
		public Sprite S;

		public Sprite A;

		public Sprite B;

		public Sprite C;
	}

	public StampBorder stampBorder;

	public OverallPerformance overallPerformance;

	public Sprite GetStampBorder(PlayerPerformance performance)
	{
		Sprite result;
		if (performance > PlayerPerformance.Good)
		{
			if (performance != PlayerPerformance.Excellent && performance != PlayerPerformance.Perfect)
			{
				bool flag = performance != PlayerPerformance.Champion;
				result = null;
				if (flag)
				{
					goto IL_0170;
				}
			}
			StampBorder stampBorder = this.stampBorder;
			if (this.stampBorder != null)
			{
				result = stampBorder.Green;
				goto IL_0170;
			}
		}
		else if (performance != PlayerPerformance.Weak)
		{
			bool flag2 = performance != PlayerPerformance.Good;
			result = null;
			if (flag2)
			{
				goto IL_0170;
			}
			StampBorder stampBorder2 = this.stampBorder;
			if (this.stampBorder != null)
			{
				return stampBorder2.Orange;
			}
		}
		else
		{
			StampBorder stampBorder3 = this.stampBorder;
			if (this.stampBorder != null)
			{
				return stampBorder3.Red;
			}
		}
		return (Sprite)(object)new NullReferenceException();
		IL_0170:
		return result;
	}

	public Color GetStampColor(PlayerPerformance performance)
	{
		if (performance > PlayerPerformance.Good)
		{
			if ((performance != PlayerPerformance.Excellent && performance != PlayerPerformance.Perfect && performance != PlayerPerformance.Champion) || stampBorder != null)
			{
				goto IL_0126;
			}
		}
		else if (performance != PlayerPerformance.Weak)
		{
			if (performance != PlayerPerformance.Good)
			{
				goto IL_0126;
			}
			if (stampBorder != null)
			{
				return (Color)this;
			}
		}
		else if (stampBorder != null)
		{
			return (Color)this;
		}
		return (Color)new NullReferenceException();
		IL_0126:
		return (Color)this;
	}

	public Sprite GetStampBorder(CheatingPerformance performance)
	{
		Sprite result;
		if (performance <= CheatingPerformance.FocussedTeammate)
		{
			if (performance <= CheatingPerformance.DoBetter)
			{
				if (performance != CheatingPerformance.Focus)
				{
					bool flag = performance != CheatingPerformance.DoBetter;
					result = null;
					if (flag)
					{
						goto IL_02da;
					}
					StampBorder stampBorder = this.stampBorder;
					if (this.stampBorder != null)
					{
						return stampBorder.Red;
					}
				}
				else
				{
					StampBorder stampBorder2 = this.stampBorder;
					if (this.stampBorder != null)
					{
						return stampBorder2.Red;
					}
				}
			}
			else if (performance != CheatingPerformance.CleanMatch)
			{
				bool flag2 = performance != CheatingPerformance.FocussedTeammate;
				result = null;
				if (flag2)
				{
					goto IL_02da;
				}
				StampBorder stampBorder3 = this.stampBorder;
				if (this.stampBorder != null)
				{
					return stampBorder3.Orange;
				}
			}
			else
			{
				StampBorder stampBorder4 = this.stampBorder;
				if (this.stampBorder != null)
				{
					return stampBorder4.Orange;
				}
			}
		}
		else if (performance <= CheatingPerformance.DirtyMatch)
		{
			if (performance != CheatingPerformance.GoodTeammate)
			{
				bool flag3 = performance != CheatingPerformance.DirtyMatch;
				result = null;
				if (flag3)
				{
					goto IL_02da;
				}
				StampBorder stampBorder5 = this.stampBorder;
				if (this.stampBorder != null)
				{
					return stampBorder5.Orange;
				}
			}
			else
			{
				StampBorder stampBorder6 = this.stampBorder;
				if (this.stampBorder != null)
				{
					return stampBorder6.Orange;
				}
			}
		}
		else
		{
			if (performance != CheatingPerformance.GoodPlayer)
			{
				bool flag4 = performance != CheatingPerformance.Champion;
				result = null;
				if (flag4)
				{
					goto IL_02da;
				}
			}
			StampBorder stampBorder7 = this.stampBorder;
			if (this.stampBorder != null)
			{
				result = stampBorder7.Green;
				goto IL_02da;
			}
		}
		return (Sprite)(object)new NullReferenceException();
		IL_02da:
		return result;
	}

	public Color GetStampColor(CheatingPerformance performance)
	{
		if (performance <= CheatingPerformance.FocussedTeammate)
		{
			if (performance <= CheatingPerformance.DoBetter)
			{
				if (performance != CheatingPerformance.Focus)
				{
					if (performance != CheatingPerformance.DoBetter)
					{
						goto IL_00ef;
					}
					if (stampBorder != null)
					{
						return (Color)this;
					}
				}
				else if (stampBorder != null)
				{
					return (Color)this;
				}
				goto IL_01ce;
			}
			if (performance == CheatingPerformance.CleanMatch || performance == CheatingPerformance.FocussedTeammate)
			{
				goto IL_012e;
			}
		}
		else if (performance <= CheatingPerformance.DirtyMatch)
		{
			if (performance == CheatingPerformance.GoodTeammate || performance == CheatingPerformance.DirtyMatch)
			{
				goto IL_012e;
			}
		}
		else if (performance == CheatingPerformance.GoodPlayer || performance == CheatingPerformance.Champion)
		{
			if (stampBorder != null)
			{
				return (Color)this;
			}
			goto IL_01ce;
		}
		goto IL_00ef;
		IL_01ce:
		return (Color)new NullReferenceException();
		IL_012e:
		if (stampBorder != null)
		{
			return (Color)this;
		}
		goto IL_01ce;
		IL_00ef:
		return (Color)this;
	}

	public Sprite GetOverallPerformanceBadge(PlayerPerformance performance)
	{
		Sprite result;
		if (performance <= PlayerPerformance.Excellent)
		{
			if (performance != PlayerPerformance.Good)
			{
				bool flag = performance != PlayerPerformance.Excellent;
				result = null;
				if (flag)
				{
					goto IL_0183;
				}
				OverallPerformance overallPerformance = this.overallPerformance;
				if (this.overallPerformance != null)
				{
					return overallPerformance.B;
				}
			}
			else
			{
				OverallPerformance overallPerformance2 = this.overallPerformance;
				if (this.overallPerformance != null)
				{
					return overallPerformance2.C;
				}
			}
			goto IL_0175;
		}
		if (performance != PlayerPerformance.Perfect)
		{
			bool flag2 = performance != PlayerPerformance.Champion;
			result = null;
			if (!flag2)
			{
				OverallPerformance overallPerformance3 = this.overallPerformance;
				if (this.overallPerformance != null)
				{
					return overallPerformance3.S;
				}
				goto IL_0175;
			}
		}
		else
		{
			OverallPerformance overallPerformance4 = this.overallPerformance;
			if (this.overallPerformance == null)
			{
				goto IL_0175;
			}
			result = overallPerformance4.A;
		}
		goto IL_0183;
		IL_0175:
		return (Sprite)(object)new NullReferenceException();
		IL_0183:
		return result;
	}
}
