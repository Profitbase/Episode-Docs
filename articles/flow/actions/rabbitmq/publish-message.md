# Publish message to RabbitMQ

This action publishes a string message to an [RabbitMq](https://www.rabbitmq.com/) message broker. Messages can be published to **Queues** or **Topics** dependent on how you configure name of the Exchange and/or routing key(s).

<!-- **Example** ![img](../../../../images/strz.jpg)   -->


## Properties

| Name           | Type     | Description                                      |
|----------------|----------|--------------------------------------------------|
| Title          | Optional | A descriptive label for the action.			   |
| Connection     | Required | Select the RabbitMQ connection. |
| Exchange       | Optional | Name of the [Exchange](https://www.rabbitmq.com/docs/exchanges) to publish to. An exchange can e.g. be Direct, Fanout, Topic, or Headers. |
| Routing Key    | Optional | Select or enter the routing key. This is a message attribute used by an exchange to determine how to route a message to queues (e.g. the queue name). |
| Result variable name | Optional | The name of the variable in which the result will be stored. |
| Description    | Optional | Additional notes or comments about the action or configuration. |


## Returns

Either **true** or **false**, depending on whether the message was sent successfully.

