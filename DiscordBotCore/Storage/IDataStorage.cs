namespace DiscordBotCore
{
    public interface IDataStorage
    {
        void StoreObject(object Obj, string key);

        T RestoreObject<T>(string key);
    }
}
