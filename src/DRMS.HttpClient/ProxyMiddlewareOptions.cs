namespace DRMS.HttpClient
{
    public class ProxyMiddlewareOptions
    {
        public const string SectionName = "Proxy";

        public string ProxyHost { get; set; }

        public string CertificatePath { get; set; }

        public string CertificatePassword { get; set; }

        /// <summary>
        ///   Получает или задаёт общее время ожидания для всех попыток в секундах.
        /// </summary>
        public int OverallTimeout { get; set; } = 170;

        /// <summary>
        ///   Получает или задаёт время ожидания для каждой отдельной попыти в секундах.
        /// </summary>
        /// <remarks>
        ///   Общее время выполнения запроса ограничено значением <see cref="OverallTimeout" />.
        ///   Независимо от количества повторных попыток.
        /// </remarks>
        public int TryTimeout { get; set; } = 170;

        /// <summary>
        ///   Получает или задаёт время задержки первой повторной попытки в секундах.
        /// </summary>
        /// <remarks>
        ///   Последующие попытки будут выполняться с экспоненциальной задержкой.
        /// </remarks>
        public int RetryDelay { get; set; } = 2;

        /// <summary>Задаёт максимальное количество повторных попыток.</summary>
        public int RetryCount { get; set; } = 10;
    }
}