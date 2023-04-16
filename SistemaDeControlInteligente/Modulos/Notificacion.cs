using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeControlInteligente
{
    public class Notificacion
    {
        public void burbuja(string Uusuario,string code ,bool Acceso)
        {
            NotifyIcon notifyIcon = new NotifyIcon
            {
                Icon = new Icon(SystemIcons.Application, 40, 40),
                Visible = true,
                Text = "Notificacion",
                BalloonTipTitle = "Notificacion de ingreso"
            };
            if (Acceso == true)
            {
                notifyIcon.BalloonTipText = "Ha ingresado el " + Uusuario + " ID: " + code + " Fecha: " + DateTime.Now;
            }
            else
            {
                notifyIcon.BalloonTipText = "Se le ha negado el acceso al usuario " + Uusuario + " con el ID " + code + "Fecha: " + DateTime.Now;
            }
            notifyIcon.ShowBalloonTip(5000);

            Timer closeNotification = new Timer
            {
                Interval = 10000 //5 minutes in milliseconds
            };
            closeNotification.Start();
        }
    }
}
