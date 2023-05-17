import { Component, Input, ViewChild } from '@angular/core';
import { BaseComponent, EntitySchema, ListQuery, Result, ResultStatus, TimeLineSchema, TimeLineViewComponent, UIColors } from '../../components';
import Titles from './log.json';
import { UserLog } from './log.model';
import { UserLogService } from './log.service';
import { User } from '../info/users.model';

@Component({
  selector: 'app-user-log',
  templateUrl: './log.component.html',
})
export class UserLogsComponent extends BaseComponent {

  columns_info: EntitySchema = Titles.list;
  columns_schema: TimeLineSchema = Titles.schema;
  UserItem: User = {} as User;
  Item: UserLog = UserLogsComponent.InitalizeModel();
  @ViewChild('timeLineView') private time_line_view: TimeLineViewComponent | undefined;

  constructor(private readonly service: UserLogService) {
    super();
  }

  Colors = [
    { title: UIColors[UIColors.secondary], id: UIColors.secondary },
    { title: UIColors[UIColors.primary], id: UIColors.primary },
    { title: UIColors[UIColors.danger], id: UIColors.danger },
    { title: UIColors[UIColors.dark], id: UIColors.dark },
    { title: UIColors[UIColors.info], id: UIColors.info },
    { title: UIColors[UIColors.light], id: UIColors.light },
    { title: UIColors[UIColors.success], id: UIColors.success },
    { title: UIColors[UIColors.warning], id: UIColors.warning },
  ];

  Reload(user: User | undefined = undefined): void {
    if (user) this.UserItem = user;

    if (!this.UserItem || !this.UserItem.id) {
      throw 'user-id is not set';
    }

    this.service.SetUserId(this.UserItem.id).List().subscribe(
      (result: any[]) => this.time_line_view?.SetDataSource(result));
  }

  Selected(userLog: UserLog) {
    this.Item = userLog;
  }

  Submit() {
    if (!this.UserItem || !this.UserItem.id) {
      throw 'user-id is not set';
    }

    this.Item.permanentUserId = this.UserItem.id;

    console.log(this.Item);

    this.service.Modify(this.Item).subscribe((result: Result) => {
      if (result.status >= ResultStatus.Invalid) console.error(result);
      else {
        this.Item = UserLogsComponent.InitalizeModel();
        this.Reload();
      }
    });
  }

  Cancel() {
    this.Item = UserLogsComponent.InitalizeModel();
  }

  Delete() {
    this.service.Delete(this.Item.id).subscribe((result: Result) => {
      if (result.status >= ResultStatus.Invalid)
        console.error(result);

      this.Cancel();
      this.Reload();
    });
  }

  static InitalizeModel(): UserLog {
    return {
      witer: 53,
      color: 0,
      content: '',
      created: new Date(),
    } as UserLog;
  }
}
