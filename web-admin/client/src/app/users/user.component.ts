import { Component, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent, EntitySchema, Result, ResultStatus } from '../components';
import { RealmsService } from '../global-services/realms.service';
import { ProfilesService } from '../profiles/profiles.service';
import Titles from './info/users.json';
import { User } from './info/users.model';
import { UserLogsComponent } from './logs/log.component';
import { UsersService } from './users.service';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
})
export class UserComponent extends BaseComponent {

  private sub: any;
  public Item: User = {
    active: true,
    username: '',
    password: '',
    created: new Date(),
  } as User;
  public columns_info: EntitySchema = Titles.list;
  @ViewChild('UserLogs') private user_logs: UserLogsComponent | undefined;

  constructor(
    private readonly service: UsersService,
    private readonly route: ActivatedRoute,
    private readonly router: Router,
    public readonly profile_srv: ProfilesService,
    public readonly realms_srv: RealmsService) {
    super();
  }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      if ('id' in params) {
        this.service.Get(+params['id']).subscribe({
          next: (result: User) => {
            this.Item = result;
            this.user_logs?.Reload(result);
          },
          error: console.error
        });
      }
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
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
