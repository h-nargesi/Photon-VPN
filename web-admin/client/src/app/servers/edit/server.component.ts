import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Server } from '../servers.model';
import Titles from '../servers.json';
import { ServersService } from '../servers.service';
import { ListViewModel } from '../../components';

@Component({
  selector: 'app-server',
  templateUrl: './server.component.html',
})
export class ServerComponent {

  private sub: any;
  public columns_info: ListViewModel = Titles.list;
  public item: Server = {} as Server;

  constructor(
    private readonly route: ActivatedRoute,
    private readonly service: ServersService) { }

  get Item(): Server {
    return this.item;
  }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      this.service.Get(+params['id']).subscribe({
        next: (result: Server) => this.item = result,
        error: console.error
      });
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

  Submit() {
    console.log(this.item);
  }

  getTitle(name: string) {
    return this.columns_info != null ? this.columns_info[name].title : name;
  }

  val(event: any): any {
    return event.target.value;
  }
}
