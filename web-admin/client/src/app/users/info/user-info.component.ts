import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';
import { RealmsService } from '../../global-services/realms.service';
import { ProfilesService } from '../../profiles/profiles.service';
import { BaseComponent, EntitySchema, Result, ResultStatus } from '../../components';
import Titles from './users.json';
import { User } from './users.model';
import { UsersService } from '../users.service';

@Component({
  selector: 'app-user-info',
  templateUrl: './user-info.component.html',
})
export class UserInfoComponent extends BaseComponent {

  public columns_info: EntitySchema = Titles.list;
  @Input('item') Item: User = {} as User;

  constructor(
    private readonly service: UsersService,
    private readonly router: Router,
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

  Delete() {
    if (!this.Item.id) return;

    this.service.Delete(this.Item.id).subscribe({
      next: (result: Result) => {
        if (result.status >= ResultStatus.Invalid) console.error(result);
        else this.router.navigate(['users']);
      },
      error: console.error
    });
  }
}
