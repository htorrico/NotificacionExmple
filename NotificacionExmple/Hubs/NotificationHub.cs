

namespace NotificacionExmple.Hubs
{
    using Microsoft.AspNet.SignalR;
    public class NotificationHub : Hub
    {
        /// <summary>
        /// Acción de notificación de una tarea completa.
        /// </summary>
        /// <param name="taskId">Identificador de la tarea.</param>
        /// <param name="taskResult">Resultado de la tarea.</param>
        public void Notificate(int taskId, bool taskResult)
        {

            Clients.All.markDone(taskId, taskResult);
        }

        public void NotificateHello(string message)
        {
            Clients.All.hello(message);
        }
    }
}