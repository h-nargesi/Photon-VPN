import { Component, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BaseComponent, EntitySchema } from '../components';
import { RealmsService } from '../global-services/realms.service';
import { ProfilesService } from '../profiles/profiles.service';
import Titles from './info/users.json';
import { User } from './info/users.model';
import { UsersService } from './users.service';
import { UserLogsComponent } from './logs/log.component';

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

}
