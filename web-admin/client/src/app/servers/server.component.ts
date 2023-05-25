import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BaseComponent, EntitySchema, LinkService, Result, ResultStatus } from '../components';
import Titles from './servers.json';
import { Server } from './servers.model';
import { ServersService } from './servers.service';

@Component({
  selector: 'app-server',
  templateUrl: './server.component.html',
})
export class ServerComponent extends BaseComponent {

  private sub: any;
  private item: Server = {
    nasname: '',
    nasidentifier: '',
    type: 'other',
    secret: '',
    heartbeatDeadAfter: 3600,
    created: new Date(),
  } as Server;
  public columns_info: EntitySchema = Titles.list;

  constructor(
    private readonly service: ServersService,
    private readonly route: ActivatedRoute,
    private readonly router: LinkService,
  ) {
    super();
  }

  get Item(): Server {
    return this.item;
  }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      if ('id' in params) {
        this.service.Get(+params['id']).subscribe((result: Server) => this.item = result);
      }
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

  Submit() {
    console.log(this.item);

    this.service.Modify(this.item).subscribe((result: Result) => {
      if (result.status < ResultStatus.Info && !this.item.id)
        this.item.id = Number(result.data);
    });
  }

  Delete() {
    if (!this.item.id) return;

    this.service.Delete(this.item.id).subscribe((result: Result) => {
      if (result.status < ResultStatus.Info)
        this.router.navigate(['servers']);
    });
  }
}
