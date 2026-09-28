using System;
using Kammelna.Server.Models.Presence;

namespace Kammelna.Server;

public interface ISignalRConnector
{
	protected const string ReceiveMessageCommand = "ReceiveMessage";

	protected const string ConnectionUpdateCommand = "ConnectionStatusUpdate";

	protected const string OnlineFriendsUpdateCommand = "OnlineFriendsUpdate";

	protected const string GameInvitationCommand = "ReceiveGameInvitation";

	protected const string DisconnectCommand = "Disconnect";

	protected const string RemoveFriendCommand = "RemoveFriend";

	protected const string UpdateFriendStatusCommand = "UpdateFriendStatus";

	protected const string CONTENT_CHANGED_COMMAND = "ContentChanged";

	protected const string CONTENT_DELTA_COMMAND = "ContentDelta";

	protected const string CONTENT_BLOB_COMMAND = "ContentBlob";

	protected const string VariableUpdateCommand = "ClientReceiveVariableUpdate";

	protected const string ClanFeedAddedCommand = "ClanFeedAdded";

	protected const string ClanFeedRemovedCommand = "ClanFeedRemoved";

	protected const string ClanFeedPinChangedCommand = "ClanFeedPinChanged";

	protected const string ClanFeedLikeChangedCommand = "ClanFeedLikeChanged";

	protected const string PresenceUpdateCommand = "OnPresenceUpdate";

	protected const string ClanMembershipChangedCommand = "ClanMembershipChanged";

	protected const string ClanRosterChangedCommand = "ClanRosterChanged";

	void Connect(string hostUrl, string token);

	void SendMessage(PrivateMessageModel model, int recipientId);

	void MarkChatMessagesAsReceived(int userId);

	void UpdateConnectionStatus(string serverId);

	void SendGameInvitations(int[] userIds, int roomId, string password, int tournamentId);

	void UpdateFriendStatus(long friendId);

	void SetPresence(PresenceState state);

	void Disconnect(Action callback = null);

	bool IsConnected();

	void SetHandlers();
}
