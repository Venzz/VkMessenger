using VkMessenger.Services;

namespace VkMessenger.Model
{
    public class ApplicationModel
    {
        public ChatEntriesCollection ChatEntries { get; }

        public ApplicationModel()
        {
            ChatEntries = new ChatEntriesCollection(new VkChatEntriesProvider());
        }
    }
}
