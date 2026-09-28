using System.Collections.Generic;

public interface IProfileGiftDisplayer
{
	void Populate(IEnumerable<ProfileGiftQuantityPair> gifts, bool isMine);

	void AddCount(long giftId);
}
