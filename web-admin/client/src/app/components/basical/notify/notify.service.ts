import { Injectable } from '@angular/core';
import { ToasterComponent } from '@coreui/angular';
import { Notification } from './notification.model';
import { NotifyComponent } from './notify.component';

@Injectable({
  providedIn: 'platform',
})
export class NotifyService {

  private toaster!: ToasterComponent;

  setToaster(toaster: ToasterComponent) {
    this.toaster = toaster;
  }

  notify(notification: Notification) {
    if (!notification) return;

    if (!this.toaster) {
      if (notification.color == "danger")
        console.error(notification.title, notification.description);
      else console.log(notification.title, notification.description);

      return;
    }

    const notifValues = {
      autohide: notification.delay ? true : false,
      delay: notification.delay,
      color: notification.color,
      position: 'bottom-end',
      fade: true,
      closeButton: true,
      title: notification.title,
      description: notification.description,
    };

    const componentRef = this.toaster.addToast(NotifyComponent, notifValues, {});
    componentRef.instance['closeButton'] = notifValues.closeButton;
  }

}
