namespace CRM.HttpClient
{
    public class CRMServiceOptions
    {
        public const string SectionName = "Endpoints:CRM";

        public string? BaseAddress { get; set; }

        public string? ApiVersion { get; set; } = "v9.1";

        /// <summary>
        ///   Получает или задаёт общее время ожидания для всех попыток в секундах.
        /// </summary>
        public int OverallTimeout { get; set; } = 100;

        /// <summary>
        ///   Получает или задаёт время ожидания для каждой отдельной попыти в секундах.
        /// </summary>
        /// <remarks>
        ///   Общее время выполнения запроса ограничено значением <see cref="OverallTimeout" />.
        ///   Независимо от количества повторных попыток.
        /// </remarks>
        public int TryTimeout { get; set; } = 30;

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