import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent, ListViewModel, Result, ResultStatus } from '../components';
import { ProfilesService } from '../profiles/profiles.service';
import { RealmsService } from '../global-services/realms.service';
import { UsersService } from './users.service';
import { User } from './users.model';
import Titles from './users.json';
import { TabContentComponent } from '@coreui/angular';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
})
export class UserComponent extends BaseComponent {

  private sub: any;
  private item: User = {} as User;
  public columns_info: ListViewModel = Titles.list;
  m : TabContentComponent | undefined;

  constructor(
    private readonly service: UsersService,
    private readonly route: ActivatedRoute,
    private readonly router: Router,
    public readonly profile_srv: ProfilesService,
    public readonly realms_srv: RealmsService) {
    super();
  }

  get Item(): User {
    return this.item;
  }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      if ('id' in params) {
        this.service.Get(+params['id']).subscribe({
          next: (result: User) => this.item = result,
          error: console.error
        });
      }
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

  Submit() {
    console.log(this.item);

    this.service.Modify(this.item).subscribe({
      next: (result: Result) => {
        if (result.status >= ResultStatus.Invalid) console.error(result);
        else {
          console.info(result);
          if (!this.item.id) this.item.id = Number(result.data);
        }
      },
      error: console.error
    });
  }

  Delete() {
    if (!this.item.id) return;

    this.service.Delete(this.item.id).subscribe({
      next: (result: Result) => {
        if (result.status >= ResultStatus.Invalid) console.error(result);
        else this.router.navigate(['users']);
      },
      error: console.error
    });
  }
}
