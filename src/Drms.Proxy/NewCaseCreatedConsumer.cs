using AspNetCore.RabbitMQ;
using RabbitMQ.Client.Events;

namespace Drms.Proxy
{
    public class NewCaseCreatedConsumer : IIntegrationEventHandler<NewCaseCreatedEvent>
    {
        private readonly ILogger logger;
        private readonly ICRMIntegration crmntegration;

        public NewCaseCreatedConsumer(
            ILogger<NewCaseCreatedConsumer> logger,
            ICRMIntegration crmntegration)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this.crmntegration = crmntegration;
        }

        public NewCaseCreatedEvent? Event { get; set; }

        public string RoutingKey { get; } = "new.case";

        public async Task HandleAsync(object sender, BasicDeliverEventArgs @event)
        {
            var consumer = (AsyncEventingBasicConsumer)sender;

            try
            {

                if (await crmntegration.CreateDrmsCase(@event.Body.ToArray(), new byte[0]))
                {
                    consumer.Model.BasicAck(@event.DeliveryTag, false);
                }
                else
                {
                    logger.LogError("Создание кейса не успешно",
                  @event.BasicProperties.MessageId);
                    consumer.Model.BasicNack(@event.DeliveryTag, false, true);
                }

            }
            catch (Exception e)
            {
                logger.LogError(e, "Не удалось выполнить десериализацию сообщения {MessageId}",
                  @event.BasicProperties.MessageId);
                consumer.Model.BasicNack(@event.DeliveryTag, false, false);
            }
        }
    }
}