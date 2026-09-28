using Sfs2X.Entities.Data;

namespace KammelnaOffline.OfflineServer;

public interface IRoomExtension
{
	OfflineRoom Room { get; set; }

	void OnExtensionRequest(string command, ISFSObject param);
}
