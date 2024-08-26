namespace Play.Common.Settings
{
    public class MongoDbSettings
    {
        /// <note>
        /// We want this setting not change AFTER microservice loads,
        /// so we switch "set" to "init" => To prevent to modify value after
        /// they have been initialized
        /// </note>

        public string Host { get; init; }
        public int Port { get; init; }
        public string ConnecitonString => $"mongodb://{Host}:{Port}";
    }
}