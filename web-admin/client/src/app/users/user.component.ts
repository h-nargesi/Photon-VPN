import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ListViewModel, Result, ResultStatus } from '../components';
import { UsersService } from './users.service';
import { User } from './users.model';
import Titles from './users.json';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
})
export class UserComponent {

  private sub: any;
  public columns_info: ListViewModel = Titles.list;
  public item: User = { } as User;

  constructor(
    private readonly service: UsersService,
    private readonly route: ActivatedRoute,
    private readonly router: Router) { }

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

  getTitle(name: string) {
    return this.columns_info != null && name in this.columns_info ? this.columns_info[name].title : name;
  }

  val(event: any): any {
    return event.target.value;
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
