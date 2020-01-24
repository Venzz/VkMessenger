using VkMessenger.Services;

namespace VkMessenger.Model
{
    public class ChatEntriesCollection
    {
        private IChatEntriesProvider ChatEntriesProvider;

        public ChatEntriesCollection(IChatEntriesProvider chatEntriesProvider)
        {
            ChatEntriesProvider = chatEntriesProvider;
        }
    }
}
