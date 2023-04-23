import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Server } from '../servers.model';
import Titles from '../servers.json';
import { ServersService } from '../servers.service';
import { ListViewModel, Result, ResultStatus } from '../../components';

@Component({
  selector: 'app-server',
  templateUrl: './server.component.html',
})
export class ServerComponent {

  private sub: any;
  public columns_info: ListViewModel = Titles.list;
  public item: Server = { } as Server;

  constructor(
    private readonly service: ServersService,
    private readonly route: ActivatedRoute,
    private readonly router: Router) { }

  get Item(): Server {
    return this.item;
  }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      if ('id' in params) {
        this.service.Get(+params['id']).subscribe({
          next: (result: Server) => this.item = result,
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
        else this.router.navigate(['servers']);
      },
      error: console.error
    });
  }
}
