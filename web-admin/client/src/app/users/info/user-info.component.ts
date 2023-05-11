import { Component, Input } from '@angular/core';
import { BaseComponent, EntitySchema, Result, ResultStatus } from '../../components';
import { RealmsService } from '../../global-services/realms.service';
import { ProfilesService } from '../../plans/profiles.service';
import { UsersService } from '../users.service';
import Titles from './users.json';
import { User } from './users.model';

@Component({
  selector: 'app-user-info',
  templateUrl: './user-info.component.html',
})
export class UserInfoComponent extends BaseComponent {

  public columns_info: EntitySchema = Titles.list;
  @Input('item') Item: User = {} as User;

  constructor(
    private readonly service: UsersService,
    public readonly profile_srv: ProfilesService,
    public readonly realms_srv: RealmsService) {
    super();
  }

  Submit() {
    this.service.Modify(this.Item).subscribe({
      next: (result: Result) => {
        if (result.status >= ResultStatus.Invalid) console.error(result);
        else {
          console.info(result);
          if (!this.Item.id) this.Item.id = Number(result.data);
        }
      },
      error: console.error
    });
  }

}
