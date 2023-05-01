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
  @Input('item') UserItem: User = {} as User;
  Item: UserLog = {
    color: 0,
    content: '',
    created: new Date(),
  } as UserLog;
  @ViewChild('timeLineView') private widget_view: TimeLineViewComponent | undefined;

  constructor(
    private readonly service: UserLogService) {
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

  ngOnInit(): void {
    if (!this.UserItem || !this.UserItem.id) return;

    this.Item.permanentUserId = this.UserItem.id;
    this.Item.witer = 53;

    let query = {
      Filters: [{
        Name: "PermanentUserId",
        Value: this.UserItem.id
      }]
    } as ListQuery;

    this.service.List(query).subscribe({
      next: (result: any[]) => this.widget_view?.SetDataSource(result),
      error: console.error
    });
  }

  Submit() {
  }

  Delete(item: UserLog) {
    this.service.Delete(item.id).subscribe({
      next: (result: Result) => {
        if (result.status >= ResultStatus.Invalid)
          console.error(result);

        this.ngOnInit();
      },
      error: console.error
    });
  }

}
