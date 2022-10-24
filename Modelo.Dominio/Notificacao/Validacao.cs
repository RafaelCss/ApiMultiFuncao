using Flunt.Notifications;
using Modelo.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dominio.Validacao
{
	public class CustomNotification : Notification
	{
		public CustomNotification(string key,string message)
		{
			Key = key;
			Message = message;
		}

		public class CustomNotifiable : Notifiable<CustomNotification>, INotifiable
		{
			public void AddNotifications(IEnumerable<Notification> notifications)
			{
				foreach(var item in notifications)
				{
					var notification = new CustomNotification(item.Key,item.Message);
					AddNotification(notification);
				}
			}
		}

	}
}
