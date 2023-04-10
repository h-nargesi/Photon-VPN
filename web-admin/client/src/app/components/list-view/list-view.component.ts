import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-list-view',
  templateUrl: './list-view.component.html',
})
export class ListViewComponent implements OnInit {
  @Input() DataSource: any[] = [];
  private data_columns: string[] = [];

  ngOnInit() {
    this.data_columns = [];
    if (this.DataSource != null && this.DataSource.length > 0) {
      for (const c in this.DataSource[0])
        this.data_columns.push(c);
    }
  }

  get DataColumns(): any[] {
    return this.data_columns;
  }
}
