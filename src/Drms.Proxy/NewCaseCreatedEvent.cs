using AspNetCore.RabbitMQ;

namespace Drms.Proxy
{

    public record NewCaseCreatedEvent : IIntegrationEvent
    {
        /// <summary>
        ///   Получает или задаёт уникальный идентификатор.
        /// </summary>
        public Guid Id { get; init; }

        /// <summary>
        ///   Получает или задаёт временную метку создания.
        /// </summary>
        public DateTime Created { get; init; }
    }
}